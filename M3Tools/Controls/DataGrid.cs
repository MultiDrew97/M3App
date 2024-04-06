using System;
using System.ComponentModel;
using System.Collections;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// Base class for data grid controls used in the app
	/// </summary>
	/// <typeparam name="T">The type of data grid this will be</typeparam>
	public partial class DataGrid<T> : System.Windows.Forms.DataGridView where T : Types.IDbEntry
	{
		internal event Events.DataEventHandler<T> AddEntry;
		internal event Events.DataEventHandler<T> UpdateEntry;
		internal event Events.DataEventHandler<T> RemoveEntry;
		internal event RefreshDisplayEventHandler Reload;

		public delegate void RefreshDisplayEventHandler();

		/// <summary>
		/// The data used for the data grid
		/// </summary>
		// <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		// <DefaultValue(GetType(BindingSource))>
		// <AttributeProvider(GetType(IListSource))>
		[RefreshProperties(RefreshProperties.Repaint)]
		[Description("Data Source to use for data grid.")]
		public virtual new Data.BindingSource<T> DataSource { get => (Data.BindingSource<T>)base.DataSource; set => base.DataSource = value; }
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
				UpdateEntry?.Invoke(this, M3Tools.Events.DataEventArgs<T>.Parse((T)row.DataBoundItem));
		}

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
						UpdateEntry?.Invoke(this, M3Tools.Events.DataEventArgs<T>.Parse((T)Rows[e.RowIndex].DataBoundItem));
						break;
					}
				case var @remove when @remove == dgc_Remove.Index:
					{
						RemoveEntry?.Invoke(this, M3Tools.Events.DataEventArgs<T>.Parse((T)Rows[e.RowIndex].DataBoundItem));
						break;
					}
			}
		}

		/// <summary>
		/// Remove an entry from the database
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void DeleteEntry(object sender, System.Windows.Forms.DataGridViewRowCancelEventArgs e)
		{
			RemoveEntry?.Invoke(sender, M3Tools.Events.DataEventArgs<T>.Parse((T)e.Row.DataBoundItem));
		}
	}
}
