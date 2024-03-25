using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ProductsComboBox : System.Windows.Forms.UserControl
    {

        // UserControl overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            cbx_Items = new System.Windows.Forms.ComboBox();
            cbx_Items.SelectedIndexChanged += new EventHandler(IndexChanged);
            bsItems = new System.Windows.Forms.BindingSource(components);
            lbl_Items = new System.Windows.Forms.Label();
            bw_LoadItems = new System.ComponentModel.BackgroundWorker();
            bw_LoadItems.DoWork += new System.ComponentModel.DoWorkEventHandler(LoadItems);
            bw_LoadItems.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(ItemsLoaded);
            db_Products = new Database.InventoryDatabase(components);
            TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsItems).BeginInit();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 1;
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0f));
            TableLayoutPanel1.Controls.Add(cbx_Items, 0, 1);
            TableLayoutPanel1.Controls.Add(lbl_Items, 0, 0);
            TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 2;
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            TableLayoutPanel1.Size = new System.Drawing.Size(200, 42);
            TableLayoutPanel1.TabIndex = 1;
            // 
            // cbx_Items
            // 
            cbx_Items.DataSource = bsItems;
            cbx_Items.DisplayMember = "Name";
            cbx_Items.Dock = System.Windows.Forms.DockStyle.Fill;
            cbx_Items.FormattingEnabled = true;
            cbx_Items.Location = new System.Drawing.Point(3, 16);
            cbx_Items.Name = "cbx_Items";
            cbx_Items.Size = new System.Drawing.Size(194, 21);
            cbx_Items.TabIndex = 2;
            cbx_Items.ValueMember = "Id";
            // 
            // bsItems
            // 
            bsItems.DataSource = typeof(Types.Product);
            // 
            // lbl_Items
            // 
            lbl_Items.AutoSize = true;
            lbl_Items.Dock = System.Windows.Forms.DockStyle.Fill;
            lbl_Items.Location = new System.Drawing.Point(3, 0);
            lbl_Items.Name = "lbl_Items";
            lbl_Items.Size = new System.Drawing.Size(194, 13);
            lbl_Items.TabIndex = 0;
            lbl_Items.Text = "Items";
            // 
            // bw_LoadItems
            // 
            // 
            // ProductsComboBox
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(TableLayoutPanel1);
            MaximumSize = new System.Drawing.Size(0, 42);
            MinimumSize = new System.Drawing.Size(200, 42);
            Name = "ProductsComboBox";
            Size = new System.Drawing.Size(200, 42);
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsItems).EndInit();
            Load += new EventHandler(ControlLoaded);
            ResumeLayout(false);

        }

        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Label lbl_Items;
        internal System.Windows.Forms.ComboBox cbx_Items;
        internal System.ComponentModel.BackgroundWorker bw_LoadItems;
        internal Database.InventoryDatabase db_Products;
        internal System.Windows.Forms.BindingSource bsItems;
    }
}