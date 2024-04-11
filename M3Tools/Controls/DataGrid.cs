using System;
using System.ComponentModel;
using System.Collections;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// Base class for data grid controls used in the app
	/// </summary>
	/// <typeparam name="T">The type of data grid this will be</typeparam>
	public partial class DataGrid<T> : System.Windows.Forms.DataGridView // where T : Types.IDbEntry
	{
		internal event Events.DataEventHandler<T> AddEntry;
		internal event Events.DataEventHandler<T> UpdateEntry;
		internal event Events.DataEventHandler<T> RemoveEntry;

		/// <summary>
		/// Issues a reload event for the data grid
		/// </summary>
		public event Events.RefreshViewEventHandler Reload;

		/// <summary>
		/// The data used for the data grid
		/// </summary>
		// <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		// <DefaultValue(GetType(BindingSource))>
		/*[AttributeProvider(typeof(IListSource))]
		[RefreshProperties(RefreshProperties.Repaint)]
		[Description("Data Source to use for data grid.")]
		public virtual new System.Windows.Forms.BindingSource DataSource { get => (System.Windows.Forms.BindingSource)base.DataSource; set
			{
				AutoGenerateColumns = false;
				base.DataSource = value;
			}
		}*/

/*
#pragma warning disable IDE0051 // Remove unused private members
		private new void OnDataSourceChanged(EventArgs e)
#pragma warning restore IDE0051 // Remove unused private members
		{
			Console.WriteLine("Custom DataSource Changed handler...");
			AutoGenerateColumns = false;
			base.OnDataSourceChanged(e);
		}*/
		/*		{
					get
					{
						return (Data.BindingSource<T>)base.DataSource;
					}
					set
					{
						AutoGenerateColumns = false;
						base.DataSource = value;
						//switch (true)
						//{
						//	case object _ when value is Types.CustomersBindingSource:
						//		{
						//			base.DataSource = value;
						//			break;
						//		}
						//	case object _ when value is Types.Customer:
						//		{
						//			base.DataSource = new Types.CustomersCollection();
						//			break;
						//		}

						//	default:
						//		{
						//			throw new Exception("CustomerDataGrid - Unknown DataSource Type");
						//		}
						//}
					}
				}*/

		private void RemoveSelectedRows()
		{
			if (SelectedRows.Count < 1)
			{
				return;
			}

			int failed = 0;
			int total = SelectedRows.Count;

			foreach (System.Windows.Forms.DataGridViewRow row in SelectedRows)
			{
				try
				{
					DeleteEntry(this, new System.Windows.Forms.DataGridViewRowCancelEventArgs(row));
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
			get
			{
				return AllowUserToOrderColumns;
			}
			set
			{
				AllowUserToOrderColumns = value;
			}
		}

		/// <summary>
		/// Whether the data grid allows for editing data
		/// </summary>
		[DefaultValue(true)]
		public bool CanEdit
		{
			get
			{
				return dgc_Edit.Visible;
			}
			set
			{
				dgc_Edit.Visible = value;
			}
		}

		/// <summary>
		/// Whether the data grid allows for deleting entries
		/// </summary>
		[DefaultValue(true)]
		public bool CanDelete
		{
			get
			{
				return dgc_Remove.Visible;
			}
			set
			{
				dgc_Remove.Visible = value;
			}
		}

		/// <summary>
		/// Whether the data grid allows for adding entries
		/// </summary>
		[DefaultValue(false)]
		public bool CanAdd 
		{
			get
			{
				return base.AllowUserToAddRows;
			}
			set
			{
				base.AllowUserToAddRows = value;
			}
		}

		/// <summary>
		/// The list of selected rows in the data grid
		/// </summary>
		[Browsable(false)]
		public new IList SelectedRows
		{
			get
			{
				if (!RowsCheckable)
				{
					return base.SelectedRows;
				}

				if (chk_SelectAll.Checked)
				{
					return Rows;
				}

				ClearSelection();

				foreach (System.Windows.Forms.DataGridViewRow row in Rows)
					row.Selected = (bool)row.Cells[dgc_Selection.DisplayIndex].Value;

				return base.SelectedRows;
			}
		}

		/// <summary>
		/// Whether rows can be selected in the data grid
		/// </summary>
		[DefaultValue(true)]
		public bool RowsCheckable
		{
			get
			{
				return dgc_Selection.Visible;
			}
			set
			{
				dgc_Selection.Visible = value;
				chk_SelectAll.Visible = value;
			}
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public DataGrid() : base()
		{
			InitializeComponent();


			this.dgc_Selection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dgc_Edit = new SPPBC.M3Tools.DataGridViewImageButtonEditColumn();
			this.dgc_Remove = new SPPBC.M3Tools.DataGridViewImageButtonDeleteColumn();

			LoadColumns();

			cms_Tools.Opened += new EventHandler(ToolsOpened);
			cms_Tools.EditSelected += EditSelected;
			cms_Tools.RemoveRows += RemoveSelectedRows;
			cms_Tools.RefreshView += Reload;
		}

		/// <summary>
		/// Loads the respective columns for the data grid view
		/// </summary>
		protected internal virtual void LoadColumns()
		{
			// 
			// dgc_Selection
			// 
			this.dgc_Selection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.dgc_Selection.Frozen = true;
			this.dgc_Selection.HeaderText = "";
			this.dgc_Selection.MinimumWidth = 25;
			this.dgc_Selection.Name = "dgc_Selection";
			this.dgc_Selection.ReadOnly = true;
			this.dgc_Selection.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgc_Selection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dgc_Selection.Width = 25;
			// 
			// dgc_Edit
			// 
			this.dgc_Edit.ButtonImage = null;
			this.dgc_Edit.FillWeight = 5F;
			this.dgc_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.dgc_Edit.HeaderText = "";
			this.dgc_Edit.MinimumWidth = 25;
			this.dgc_Edit.Name = "dgc_Edit";
			this.dgc_Edit.ReadOnly = true;
			this.dgc_Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgc_Edit.ToolTipText = "Edit";
			this.dgc_Edit.Width = 25;
			// 
			// dgc_Remove
			// 
			this.dgc_Remove.ButtonImage = null;
			this.dgc_Remove.FillWeight = 5F;
			this.dgc_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.dgc_Remove.HeaderText = "";
			this.dgc_Remove.MinimumWidth = 25;
			this.dgc_Remove.Name = "dgc_Remove";
			this.dgc_Remove.ReadOnly = true;
			this.dgc_Remove.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgc_Remove.ToolTipText = "Remove";
			this.dgc_Remove.Width = 25;
		}

		/// <summary>
		/// Selects all rows in the data grid view
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void SelectAll(object sender, EventArgs e)
		{
			foreach (System.Windows.Forms.DataGridViewRow row in Rows)
				row.Cells[dgc_Selection.Index].Value = chk_SelectAll.Checked;
			Invalidate();
		}

		private void ToolsOpened(object sender, EventArgs e)
		{
			cms_Tools.ToggleRemove(SelectedRows.Count > 0);
			cms_Tools.ToggleEdit(SelectedRows.Count > 0);
		}

		private void EditSelected()
		{
			if (SelectedRows.Count < 1)
			{
				return;
			}

			foreach (System.Windows.Forms.DataGridViewRow row in SelectedRows)
				UpdateEntry?.Invoke(this, M3Tools.Events.DataEventArgs<T>.Parse((T)row.DataBoundItem, M3Tools.Events.EventType.Updated));
		}

		/// <summary>
		/// Called when a cell is clicked in the data grid view. Can be shadowed to add extra functionality as well.
		/// </summary>
		/// <param name="sender">The object calling the function</param>
		/// <param name="e">The data grid view cell information for the call</param>
		protected virtual void CellClicked(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex != dgc_Edit.Index && e.ColumnIndex != dgc_Remove.Index)
			{
				return;
			}

			switch (e.ColumnIndex)
			{
				case var @edit when @edit == dgc_Edit.Index:
					{
						UpdateEntry?.Invoke(this, M3Tools.Events.DataEventArgs<T>.Parse((T)Rows[e.RowIndex].DataBoundItem, M3Tools.Events.EventType.Updated));
						break;
					}
				case var @remove when @remove == dgc_Remove.Index:
					{
						RemoveEntry?.Invoke(this, M3Tools.Events.DataEventArgs<T>.Parse((T)Rows[e.RowIndex].DataBoundItem, M3Tools.Events.EventType.Removed));
						break;
					}
			}
		}

		/// <summary>
		/// Remove an entry from the database
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void DeleteEntry(object sender, System.Windows.Forms.DataGridViewRowCancelEventArgs e)
		{
			RemoveEntry?.Invoke(sender, M3Tools.Events.DataEventArgs<T>.Parse((T)e.Row.DataBoundItem, M3Tools.Events.EventType.Removed));
		}

		/// <summary>
		/// The column associated with selecting an entry
		/// </summary>
		protected internal System.Windows.Forms.DataGridViewCheckBoxColumn dgc_Selection;

		/// <summary>
		/// The column associated with editting the entry
		/// </summary>
		protected internal DataGridViewImageButtonEditColumn dgc_Edit;

		/// <summary>
		/// The column associated with removing the entry
		/// </summary>
		protected internal DataGridViewImageButtonDeleteColumn dgc_Remove;
	}
}
