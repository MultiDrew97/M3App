using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SPPBC.M3Tools.Data
{
	/// <summary>
	/// Base class for data grid controls used in the app
	/// </summary>
	/// <typeparam name="T">The type of data grid this will be</typeparam>
	public partial class DataGrid<T> where T : Types.IDbEntry, new()
	{
		// TODO: Add Pagination to the display grid
		private bool Moved = false;

		#region Columns
		/// <summary>
		/// 
		/// </summary>
		protected internal DataGridViewCheckBoxColumn dgc_Selection = new();
		/// <summary>
		/// 
		/// </summary>
		protected internal DataGridViewTextBoxColumn dgc_ID = new();
		/// <summary>
		/// 
		/// </summary>
		protected internal DataGridViewImageButtonEditColumn dgc_Edit = new();
		/// <summary>
		/// 
		/// </summary>
		protected internal DataGridViewImageButtonDeleteColumn dgc_Remove = new();
		#endregion

		#region Events
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
		#endregion

		/// <summary>
		/// 
		/// </summary>
		public DataGrid() : base()
		{
			AutoGenerateColumns = false;

			InitializeComponent();

			// Context Menu Strip events
			cms_Tools.Opened += new EventHandler(ToolsOpened);
			cms_Tools.EditSelected += new EventHandler(EditSelected);
			cms_Tools.RemoveSelected += new EventHandler(RemoveSelectedRows);
			cms_Tools.RefreshView += (sender, e) => Reload?.Invoke(sender, e);
		}

		/// <inheritdoc />
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			if (!(ColumnHeadersVisible && RowsCheckable) && Moved)
			{
				return;
			}

			System.Drawing.Rectangle rect = GetCellDisplayRectangle(dgc_Selection.DisplayIndex, -1, true);
			chk_SelectAll.Location = new System.Drawing.Point(rect.Location.X + (rect.Width / 2) - (chk_SelectAll.Width / 2), rect.Location.Y + (rect.Height / 2) - (chk_SelectAll.Height / 2));
			Moved = true;
		}

		private void RemoveSelectedRows(object sender, EventArgs e)
		{
			if (SelectedRows.Count < 1)
			{
				return;
			}

			int done = 0;

			foreach (DataGridViewRow row in SelectedRows)
			{
				try
				{
					OnUserDeletingRow(new DataGridViewRowCancelEventArgs(row));
					done++;
				}
				catch (Exception ex)
				{
					Console.Error.WriteLine(ex.Message);
					continue;
				}
			}

			_ = MessageBox.Show($"Failed to remove {done} {(done > 1 ? "entries" : "entry")}", "Entries Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		/// <summary>
		/// Whether the data grid allows for column reordering
		/// </summary>
		[DefaultValue(false)]
		[Category("Behavior")]
		public bool CanReorder
		{
			get => AllowUserToOrderColumns;
			set => AllowUserToOrderColumns = value;
		}

		/// <summary>
		/// Whether the data grid allows for editing data
		/// </summary>
		[DefaultValue(true)]
		[Category("Behavior")]
		public bool CanEdit
		{
			get => dgc_Edit.Visible;
			set => dgc_Edit.Visible = value;
		}

		/// <summary>
		/// Whether the data grid allows for deleting entries
		/// </summary>
		[DefaultValue(true)]
		[Category("Behavior")]
		public bool CanDelete
		{
			get => dgc_Remove.Visible;
			set => dgc_Remove.Visible = value;
		}

		/// <summary>
		/// Whether the data grid allows for adding entries
		/// </summary>
		[DefaultValue(false)]
		[Category("Behavior")]
		public bool CanAdd
		{
			get => base.AllowUserToAddRows;
			set => base.AllowUserToAddRows = value;
		}

		/// <summary>
		/// Whether rows can be selected in the data grid
		/// </summary>
		[DefaultValue(true)]
		[Category("Behavior")]
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
		[Browsable(false)]
		public new DataGridViewSelectedRowCollection SelectedRows
		{
			get
			{
				if (RowsCheckable)
				{
					ClearSelection();

					foreach (DataGridViewRow row in Rows)
					{
						row.Selected = (bool?)row.Cells[dgc_Selection.DisplayIndex].Value ?? false;
					}
				}

				return base.SelectedRows;
			}
		}

		/// <summary>
		/// Load the columns for the data grid
		/// </summary>
		protected virtual void LoadColumns()
		{
			// Entry selection column
			dgc_Selection.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			dgc_Selection.FalseValue = "False";
			dgc_Selection.Frozen = true;
			dgc_Selection.HeaderText = "";
			dgc_Selection.MinimumWidth = 25;
			dgc_Selection.Name = "dgc_Selection";
			dgc_Selection.Resizable = DataGridViewTriState.False;
			dgc_Selection.SortMode = DataGridViewColumnSortMode.Automatic;
			dgc_Selection.TrueValue = "True";
			dgc_Selection.Width = 25;

			// Entry ID column
			dgc_ID.DataPropertyName = "Id";
			dgc_ID.Name = "dgc_ID";
			dgc_ID.ReadOnly = true;
			dgc_ID.Visible = false;

			// Edit entry button column
			dgc_Edit.ButtonImage = null;
			dgc_Edit.FillWeight = 5F;
			dgc_Edit.FlatStyle = FlatStyle.Flat;
			dgc_Edit.HeaderText = "";
			dgc_Edit.MinimumWidth = 25;
			dgc_Edit.Name = "dgc_Edit";
			dgc_Edit.ReadOnly = true;
			dgc_Edit.Resizable = DataGridViewTriState.False;
			dgc_Edit.ToolTipText = "Edit";
			dgc_Edit.Width = 25;

			// Remove entry button column
			dgc_Remove.ButtonImage = null;
			dgc_Remove.FillWeight = 5F;
			dgc_Remove.FlatStyle = FlatStyle.Flat;
			dgc_Remove.HeaderText = "";
			dgc_Remove.MinimumWidth = 25;
			dgc_Remove.Name = "dgc_Remove";
			dgc_Remove.ReadOnly = true;
			dgc_Remove.Resizable = DataGridViewTriState.False;
			dgc_Remove.ToolTipText = "Remove";
			dgc_Remove.Width = 25;
		}

		/// <summary>
		/// Selects all rows in the data grid view
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void SelectAll(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in Rows)
			{
				row.Cells[dgc_Selection.Index].Value = chk_SelectAll.Checked;
			}

			_ = CommitEdit(DataGridViewDataErrorContexts.Commit);
		}

		private void ToolsOpened(object sender, EventArgs e)
		{
			bool enable = SelectedRows.Count > 0;
			cms_Tools.RemoveEnabled = enable;
			cms_Tools.EditEnabled = enable;
		}

		private void EditSelected(object sender, EventArgs e)
		{
			if (SelectedRows.Count < 1)
			{
				return;
			}

			foreach (DataGridViewRow row in SelectedRows)
			{
				UpdateEntry?.Invoke(this, M3Tools.Events.DataEventArgs<T>.Parse((T)row.DataBoundItem, M3Tools.Events.EventType.Updated));
			}
		}

		/// <inheritdoc/>
		protected override void OnCellContentClick(DataGridViewCellEventArgs e)
		{
			DataGridViewDataErrorContexts context = DataGridViewDataErrorContexts.Commit;
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

			_ = CommitEdit(context);
		}

		/// <inheritdoc/>
		protected override void OnUserDeletingRow(DataGridViewRowCancelEventArgs e)
		{
			base.OnUserDeletingRow(e);
			RemoveEntry?.Invoke(this, M3Tools.Events.DataEventArgs<T>.Parse((T)e.Row.DataBoundItem, M3Tools.Events.EventType.Removed));
		}

		/// <inheritdoc/>
		protected override void OnUserAddedRow(DataGridViewRowEventArgs e)
		{
			base.OnUserAddedRow(e);

			AddEntry?.Invoke(this, new((T)e.Row.DataBoundItem, M3Tools.Events.EventType.Added));
		}

		/// <inheritdoc/>
		protected override void OnDataError(bool noHandler, DataGridViewDataErrorEventArgs e)
		{
			base.OnDataError(false, e);

			_ = MessageBox.Show(e.Exception.Message, "Display Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
