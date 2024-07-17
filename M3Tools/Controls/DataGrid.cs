using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// Base class for data grid controls used in the app
	/// </summary>
	/// <typeparam name="T">The type of data grid this will be</typeparam>
	public partial class DataGrid<T> //where T : Types.IDbEntry
	{
		// TODO: Add Pagination to the display grid
		private bool Moved = false;

		// TODO: Maybe Remove this later
		/// <summary>
		/// Event that occurs when adding data
		/// </summary>
		protected event Events.DataEventHandler<T> AddEntry;

		/// <summary>
		/// Event that occurs when updating data
		/// </summary>
		protected event Events.DataEventHandler<T> UpdateEntry;

		/// <summary>
		/// Event that occurs when removing data
		/// </summary>
		protected event Events.DataEventHandler<T> RemoveEntry;

		/// <summary>
		/// Issues a reload event for the data grid
		/// </summary>
		public event EventHandler Reload;

		// TODO: Make it so the datagrid has it's own binding source and when using in a form, you just pass the list itself

		/// <summary>
		/// 
		/// </summary>
		public new bool AutoGenerateColumns = false;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="e"></param>
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			if (!(ColumnHeadersVisible && RowsCheckable) && Moved)
			{
				return;
			}

			System.Drawing.Rectangle rect = GetCellDisplayRectangle(dgc_Selection.DisplayIndex, -1, true);
			chk_SelectAll.Location = new System.Drawing.Point(rect.Location.X + rect.Width / 2 - chk_SelectAll.Width / 2, rect.Location.Y + rect.Height / 2 - chk_SelectAll.Height / 2);
			Moved = true;
		}

		private void RemoveSelectedRows(object sender, EventArgs e)
		{
			if (SelectedRows.Count < 1)
			{
				return;
			}

			int failed = 0;
			int total = SelectedRows.Count;

			foreach (DataGridViewRow row in SelectedRows)
			{
				try
				{
					OnUserDeletingRow(new DataGridViewRowCancelEventArgs(row));
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					failed += 1;
					continue;
				}
			}

			if (failed > 0)
			{
				System.Windows.Forms.MessageBox.Show($"Failed to remove {failed} {(failed > 1 ? "entries" : "entry")}", "Failed Removals", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			}

			if (total - failed > 0)
			{
				System.Windows.Forms.MessageBox.Show($"Successfully removed {total - failed} {(total - failed > 1 ? "entries" : "entry")}", "Successful Removals", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
			}
		}

		/// <summary>
		/// Whether the data grid allows for column reordering
		/// </summary>
		[DefaultValue(false)]
		public bool CanReorder
		{
			get => AllowUserToOrderColumns;
			set => AllowUserToOrderColumns = value;
		}

		/// <summary>
		/// Whether the data grid allows for editing data
		/// </summary>
		[DefaultValue(true)]
		public bool CanEdit
		{
			get => dgc_Edit.Visible;
			set => dgc_Edit.Visible = value;
		}

		/// <summary>
		/// Whether the data grid allows for deleting entries
		/// </summary>
		[DefaultValue(true)]
		public bool CanDelete
		{
			get => dgc_Remove.Visible;
			set => dgc_Remove.Visible = value;
		}

		/// <summary>
		/// Whether the data grid allows for adding entries
		/// </summary>
		[DefaultValue(false)]
		public bool CanAdd 
		{
			get => base.AllowUserToAddRows;
			set => base.AllowUserToAddRows = value;
		}

		/// <summary>
		/// 
		/// </summary>
		[Browsable(false)]
		public new System.Collections.ICollection SelectedRows
		{
			get
			{
				if (RowsCheckable) { 
					ClearSelection();

					foreach (System.Windows.Forms.DataGridViewRow row in Rows)
						row.Selected = (bool?)row.Cells[dgc_Selection.DisplayIndex].Value ?? false;
				}

				return base.SelectedRows;
			}
		}

		/// <summary>
		/// Whether rows can be selected in the data grid
		/// </summary>
		[DefaultValue(true)]
		public bool RowsCheckable
		{
			get => dgc_Selection.Visible;
			set
			{
				dgc_Selection.Visible = value;
				chk_SelectAll.Visible = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public DataGrid() : base()
		{
			InitializeComponent();

			cms_Tools.Opened += new EventHandler(ToolsOpened);
			cms_Tools.EditSelected += new EventHandler(EditSelected);
			cms_Tools.RemoveSelected += new EventHandler(RemoveSelectedRows);
			cms_Tools.RefreshView += (sender, e) => Reload?.Invoke(sender, e);
		}

		/// <summary>
		/// Selects all rows in the data grid view
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void SelectAll(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in Rows)
				row.Cells[dgc_Selection.Index].Value = chk_SelectAll.Checked;

			this.CommitEdit(DataGridViewDataErrorContexts.Commit);
		}

		private void ToolsOpened(object sender, EventArgs e)
		{
			var enable = SelectedRows.Count > 0;
			cms_Tools.RemoveEnabled = enable;
			cms_Tools.EditEnabled = enable;
		}

		private void EditSelected(object sender, EventArgs e)
		{
			if (SelectedRows.Count < 1)
			{
				return;
			}

			foreach (System.Windows.Forms.DataGridViewRow row in SelectedRows)
				UpdateEntry?.Invoke(this, M3Tools.Events.DataEventArgs<T>.Parse((T)row.DataBoundItem, M3Tools.Events.EventType.Updated));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="e"></param>
		protected override void OnCellContentClick(DataGridViewCellEventArgs e)
		{
			var context = DataGridViewDataErrorContexts.Commit;
			base.OnCellContentClick(e);

			switch (e.ColumnIndex)
			{
				case var @select when select == dgc_Selection.DisplayIndex:
					Rows[e.RowIndex].Cells[dgc_Selection.DisplayIndex].Value = !(bool)Rows[e.RowIndex].Cells[dgc_Selection.DisplayIndex].FormattedValue;
					chk_SelectAll.Checked = SelectedRows.Count == Rows.Count;
					break;
				case var @edit when @edit == dgc_Edit.DisplayIndex:
					UpdateEntry?.Invoke(this, M3Tools.Events.DataEventArgs<T>.Parse((T)Rows[e.RowIndex].DataBoundItem, M3Tools.Events.EventType.Updated));
					break;
				case var @remove when @remove == dgc_Remove.DisplayIndex:
					OnUserDeletingRow(new(Rows[e.RowIndex]));
					break;
			}

			CommitEdit(context);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="e"></param>
		protected override void OnUserDeletingRow(DataGridViewRowCancelEventArgs e)
		{
			base.OnUserDeletingRow(e);
			RemoveEntry?.Invoke(this, M3Tools.Events.DataEventArgs<T>.Parse((T)e.Row.DataBoundItem, M3Tools.Events.EventType.Removed));
		}

		protected override void OnDataError(bool displayErrorDialogIfNoHandler, DataGridViewDataErrorEventArgs e)
		{
			base.OnDataError(false, e);

			if (Rows[e.RowIndex] is not null)
				return;
		}
	}
}
