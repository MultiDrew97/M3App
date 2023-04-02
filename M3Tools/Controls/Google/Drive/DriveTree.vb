Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Windows.Forms

Public Class DriveTree
	'Private __username As String

	ReadOnly Property Nodes As TreeNodeCollection
		Get
			Return tv_DriveFiles.Nodes
		End Get
	End Property

	<DefaultValue(True)>
	Property Checkboxes As Boolean
		Get
			Return tv_DriveFiles.CheckBoxes
		End Get
		Set(value As Boolean)
			tv_DriveFiles.CheckBoxes = value
		End Set
	End Property

	ReadOnly Property SelectedNode As TreeNode
		Get
			Return tv_DriveFiles.SelectedNode
		End Get
	End Property

	<DefaultValue(True)>
	<Description("Whether the tree should include the children of folders")>
	Public Property WithChildren As Boolean

	Public Sub FillTable(treeNodes As GTools.Types.FileCollection)
		UseWaitCursor = True
		tv_DriveFiles.Nodes(0).Nodes.Clear()
		tv_DriveFiles.Nodes(0).Nodes.AddRange(ParseNodes(treeNodes))
		tv_DriveFiles.Nodes(0).Expand()
		UseWaitCursor = False
	End Sub

	''' <summary>
	''' Takes the file collection and filters out duplicates and places sub files and folders under their proper parent folders.
	''' </summary>
	''' <param name="folders">The collection of files and folders to filter.</param>
	''' <returns>The filtered file collection as a tree node array.</returns>
	Private Function ParseNodes(folders As GTools.Types.FileCollection) As TreeNode()
		Dim i As Integer = 0

		Do
			If folders(i).Parents Is Nothing Then
				i += 1
				Continue Do
			End If

			If folders.Contains(folders(i).Parents(0)) Then
				Dim parentFolder = CType(folders(folders(i).Parents(0)), GTools.Types.Folder)

				If parentFolder.Children.Count = 0 Then
					parentFolder.Children.Add(folders(i))
				Else
					Dim folderUnderParent = CType(parentFolder.Children(folders(i).Id), GTools.Types.Folder)

					If folderUnderParent Is Nothing Then
						parentFolder.Children.Add(folders(i))
					Else
						folderUnderParent.Children.AddRange(CType(folders(i), GTools.Types.Folder).Children)
					End If

				End If


				folders.Remove(folders(i))
			Else
				i += 1
			End If
		Loop Until i >= folders.Count

		Return ParseTree(folders)
	End Function

	''' <summary>
	''' Parses the File Collection into a TreeNode array with proper child node nesting.
	''' </summary>
	''' <param name="folders">The collections of files that hold the file heirarchy information.</param>
	''' <returns>An array of tree nodes, based on the file heirarchy in the file collection.</returns>
	Private Function ParseTree(folders As GTools.Types.FileCollection) As TreeNode()
		Dim nodes As New Collection(Of TreeNode)

		For Each folder In folders
			If folder.GetType = GetType(GTools.Types.Folder) Then
				If CType(folder, GTools.Types.Folder).Children.Count = 0 Then
					'Add This folder to the collection as is
					nodes.Add(New TreeNode(folder.Name) With {.Name = folder.Id})
				Else
					nodes.Add(New TreeNode(folder.Name, ParseTree(CType(folder, GTools.Types.Folder).Children)) With {.Name = folder.Id})
				End If
			Else
				nodes.Add(New TreeNode(folder.Name) With {.Name = folder.Id})
			End If
		Next

		Return nodes.ToArray
	End Function

	Private Function GetSelectedNode(nodes As TreeNodeCollection) As TreeNode
		If nodes.Count > 0 Then
			For Each node As TreeNode In nodes
				If node.IsSelected Or node.Checked Then
					Return node
				End If

				Dim recNode = GetSelectedNode(node.Nodes)

				If recNode IsNot Nothing Then
					Return recNode
				End If
			Next
		End If

		Return Nothing
	End Function

	Function GetSelectedNodes(Optional nodes As TreeNodeCollection = Nothing) As Collection(Of TreeNode)
		' TODO: When checking a folder, check child files and folders as well
		Dim treeNodes As New Collection(Of TreeNode)

		For Each node As TreeNode In If(nodes, tv_DriveFiles.Nodes)
			If node.Checked Then
				treeNodes.Add(node)
			End If

			If node.Nodes.Count > 0 Then
				Dim innerNodes = GetSelectedNodes(node.Nodes)
				For Each innerNode In innerNodes
					treeNodes.Add(innerNode)
				Next
			End If
		Next

		Return treeNodes
	End Function

	Private Async Sub RefreshTree()
		If WithChildren Then
			FillTable(Await gdt_GDrive.GetFoldersWithChildren())
		Else
			FillTable(Await gdt_GDrive.GetFolders())
		End If
	End Sub

	Public Sub Reload()
		UseWaitCursor = True
		RefreshTree()
		UseWaitCursor = False
	End Sub

	Private Sub NewFolder(sender As Object, e As EventArgs) Handles tsmi_NewFolder.Click
		Using newFolder As New CreateFolderDialog()
			If newFolder.ShowDialog = DialogResult.OK Then
				Reload()
			End If
		End Using
	End Sub

	Public Shadows Sub Load()
		gdt_GDrive.Authorize()
	End Sub
End Class
