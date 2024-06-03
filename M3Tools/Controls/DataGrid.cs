using System;
using System.ComponentModel;
using System.Collections;
using System.Windows.Forms;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// Base class for data grid controls used in the app
	/// </summary>
	/// <typeparam name="T">The type of data grid this will be</typeparam>
	public partial class DataGrid<T>
	{
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

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			if (!(ColumnHeadersVisible && RowsCheckable))
			{
				return;
			}

			System.Drawing.Rectangle rect = GetCellDisplayRectangle(dgc_Selection.DisplayIndex, -1, true);
			chk_SelectAll.Location = new System.Drawing.Point(rect.Location.X + rect.Width / 2 - chk_SelectAll.Width / 2, rect.Location.Y + rect.Height / 2 - chk_SelectAll.Height / 2);
		}

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


//#pragma warning disable IDE0051 // Remove unused private members
		private new void OnDataSourceChanged(EventArgs e)
//#pragma warning restore IDE0051 // Remove unused private members
		{
			Console.WriteLine("--------------------- Custom DataSource Changed handler ---------------------------");
			AutoGenerateColumns = false;
			RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(delegate (object sender, System.Windows.Forms.DataGridViewRowsAddedEventArgs ea)
			{
				Console.WriteLine(ea.RowCount);
			});
			base.OnDataSourceChanged(e);
		}
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
					var list = new Types.ListenerCollection();
					foreach (System.Windows.Forms.DataGridViewRow row in Rows)
						list.Add((Types.Listener)row.DataBoundItem);

					return list;
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
			get => dgc_Selection.Visible;
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
			AutoGenerateColumns = false;

			cms_Tools.Opened += new EventHandler(ToolsOpened);
			cms_Tools.EditSelected += (sender, e) => EditSelected();
			cms_Tools.RemoveSelected += (sender, e) => RemoveSelectedRows();
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

			RefreshEdit();
		}

		private void ToolsOpened(object sender, EventArgs e)
		{
			cms_Tools.RemoveEnabled = SelectedRows.Count > 0;
			cms_Tools.EditEnabled = SelectedRows.Count > 0;
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
	}
}
