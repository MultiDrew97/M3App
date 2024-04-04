using System;
using System.Data;

using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using SPPBC.M3Tools.Types;

namespace M3App
{

    public partial class PlaceOrderDialog
    {
        private DataTable CustomersTable;
        private readonly System.Collections.ObjectModel.Collection<Customer> Customers;
        private DataTable ProductsTable;
        private readonly System.Collections.ObjectModel.Collection<Product> Products;

        public PlaceOrderDialog()
        {
            InitializeComponent();
        }

        private void Frm_PlaceOrder_Load(object sender, EventArgs e)
        {
            LoadData();

            bsCustomers.DataSource = CustomersTable;
            bsProducts.DataSource = ProductsTable;

            cbx_Name.DisplayMember = "Name";
            cbx_ItemName.DisplayMember = "Name";
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Btn_AddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: Add new order

                tss_AddOrder.ForeColor = SystemColors.WindowText;
                tss_AddOrder.Text = "The order was successfully added for " + cbx_Name.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (SqlException ex)
            {
                tss_AddOrder.Text = "The order could not be added. Please try again";
                tss_AddOrder.ForeColor = Color.Red;
            }
        }

        private void GenerateTables()
        {
            CustomersTable = new DataTable();
            ProductsTable = new DataTable();

            GenerateColumns();
        }

        private void GenerateColumns()
        {
            CustomersTable.Columns.AddRange(new[] { new DataColumn("CustomerID", typeof(int)), new DataColumn("Name", typeof(string)) });

            ProductsTable.Columns.AddRange(new[] { new DataColumn("ProductID", typeof(int)), new DataColumn("Name", typeof(string)), new DataColumn("Available", typeof(bool)) });

            FillTables();
        }

        private void FillTables()
        {
            DataRow row;

            foreach (Customer customer in Customers)
            {
                row = CustomersTable.NewRow();
                row["CustomerID"] = customer.Id;
                row["Name"] = customer.Name;
                CustomersTable.Rows.Add(row);
            }

            foreach (Product product in Products)
            {
                row = ProductsTable.NewRow();
                row["ProductID"] = product.Id;
                row["Name"] = product.Name;
                row["Available"] = product.Available;
                ProductsTable.Rows.Add(row);
            }
        }

        // Private Sub cbx_Name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_Name.SelectedIndexChanged
        // Using db As New Database
        // Customer = db.GetCustomerInfo(CInt(CustomersTable.Rows(cbx_Name.SelectedIndex)("CustomerID")))
        // End Using
        // End Sub

        // Private Sub cbx_ItemName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_ItemName.SelectedIndexChanged
        // Using db As New Database
        // Product = db.GetProductInfo(CInt(ProductsTable.Rows(cbx_ItemName.SelectedIndex)("ProductID")))
        // End Using
        // End Sub

        private void LoadData()
        {
            // TODO: Load orders

            GenerateTables();
        }


        // Private Sub wait(ByVal seconds As Integer)
        // 'found this here https://stackoverflow.com/questions/15857893/wait-5-seconds-before-continuing-code-vb-net/15861154

        // For i As Integer = 0 To seconds * 100
        // System.Threading.Thread.Sleep(10)
        // Application.DoEvents()
        // Next
        // End Sub
    }
}