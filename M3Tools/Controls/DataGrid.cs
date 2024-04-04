using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// Base class for data grid controls used in the app
	/// </summary>
	/// <typeparam name="T">The type of data grid this will be</typeparam>
	public partial class DataGrid<T> : DataGridView where T : Types.IDbEntry
	{
		internal event Events.DataEventHandler<T> Add;
		internal event Events.DataEventHandler<T> Update;
		internal event Events.DataEventHandler<T> Remove;
		internal event RefreshDisplayEventHandler Reload;

		public delegate void RefreshDisplayEventHandler();

		protected void RemoveSelectedRows()
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
					DeleteEntry(this, new DataGridViewRowCancelEventArgs(row));
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
				MessageBox.Show($"Failed to remove {failed} {(failed > 1 ? "entries" : "entry")}", "Failed Removals", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			if (total - failed > 0)
			{
				MessageBox.Show($"Successfully removed {total - failed} {(total - failed > 1 ? "entries" : "entry")}", "Successful Removals", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}


		[DefaultValue(false)]
		public bool AllowColumnReordering
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

		[DefaultValue(true)]
		public bool AllowEditting
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

		[DefaultValue(true)]
		public bool AllowDeleting
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

		[DefaultValue(false)]
		public bool AllowAdding 
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
		/// The data used for the data grid
		/// </summary>
		// <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		// <DefaultValue(GetType(BindingSource))>
		// <AttributeProvider(GetType(IListSource))>
		[RefreshProperties(RefreshProperties.Repaint)]
		[Description("Data Source to use for data grid.")]
		public new Data.BindingSource<T> DataSource
		{
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
		}

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

				foreach (DataGridViewRow row in Rows)
					row.Selected = (bool)row.Cells[dgc_Selection.DisplayIndex].Value;

				return base.SelectedRows;
			}
		}

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

		public DataGrid()
		{
			InitializeComponent();

			//cms_Tools.EditSelected += EditSelected;
		}

		private void SelectAll(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in Rows)
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

			foreach (DataGridViewRow row in SelectedRows)
				Update?.Invoke(this, M3Tools.Events.DataEventArgs<T>.Parse((T)row.DataBoundItem));
		}

		protected virtual void CellClicked(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex != dgc_Edit.Index && e.ColumnIndex != dgc_Remove.Index)
			{
				return;
			}

			switch (e.ColumnIndex)
			{
				case var @edit when @edit == dgc_Edit.Index:
					{
						Update?.Invoke(this, M3Tools.Events.DataEventArgs<T>.Parse((T)Rows[e.RowIndex].DataBoundItem));
						break;
					}
				case var @remove when @remove == dgc_Remove.Index:
					{
						Remove?.Invoke(this, M3Tools.Events.DataEventArgs<T>.Parse((T)Rows[e.RowIndex].DataBoundItem));
						break;
					}
			}
		}

		/// <summary>
		/// Remove an entry from the database
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void DeleteEntry(object sender, DataGridViewRowCancelEventArgs e)
		{
			Remove?.Invoke(sender, M3Tools.Events.DataEventArgs<T>.Parse((T)e.Row.DataBoundItem));
		}
	}
}
