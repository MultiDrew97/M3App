using System;
using System.Data.SqlClient;
using System.Drawing;
using static System.Text.RegularExpressions.Regex;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace M3App
{

    public partial class AddProductDialog
    {
        public AddProductDialog()
        {
            InitializeComponent();
        }
        private void Frm_AddNewProduct_Load(object sender, EventArgs e)
        {
            Reset();
        }

        // Private Sub frm_AddNewProduct_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        // Try
        // CType(Opener, frm_ViewInventory).customLoad()
        // Catch ex As ApplicationException
        // Finally
        // Opener.Show()
        // End Try
        // End Sub

        private void Reset()
        {
            txt_ProductName.Text = "";
            nud_Stock.Value = 0m;
            txt_Price.Text = "$0.00";
        }

        private void AddProduct(object sender, EventArgs e)
        {
            bw_AddProduct.RunWorkerAsync();
            Hide();
        }

        private void NameGotFocus(object sender, EventArgs e)
        {
            tss_AddProduct.ForeColor = SystemColors.WindowText;
            tss_AddProduct.Text = "Enter the products information.";
            if (txt_ProductName.Text.Equals("Product Name"))
            {
                txt_ProductName.Text = "";
                txt_ProductName.ForeColor = SystemColors.WindowText;
            }
        }

        private void NameLostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ProductName.Text))
            {
                ep_EmptyFields.SetError(txt_ProductName, "Enter a name for the product");
                txt_ProductName.Text = "Product Name";
                txt_ProductName.ForeColor = SystemColors.ControlLight;
            }
        }

        private void PriceGotFocus(object sender, EventArgs e)
        {
            if (txt_Price.Text.Equals("$0.00"))
            {
                txt_Price.Text = "";
                txt_Price.ForeColor = SystemColors.WindowText;
            }
        }

        private void PriceLostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Price.Text) | !IsMatch(txt_Price.Text, @"\d*.\d*"))
            {
                txt_Price.Text = Strings.Format("0", "Currency");
                txt_Price.ForeColor = SystemColors.ControlLight;
                ep_EmptyFields.SetError(txt_Price, "Set a price for the product.");
            }
            else if (IsMatch(txt_Price.Text, @"\d*.\d*"))
            {
                txt_Price.Text = Strings.Format(txt_Price.Text, "Currency");
            }
        }

        private void CancelAddition(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void NameTextChanged(object sender, EventArgs e)
        {
            if (!txt_ProductName.Text.Equals("Product Name"))
            {
                txt_ProductName.ForeColor = SystemColors.WindowText;
                txt_ProductName.Text = txt_ProductName.Text.ToUpper();
                txt_ProductName.SelectionStart = txt_ProductName.Text.Length + 1;
            }
        }

        private void StockGotFocus(object sender, EventArgs e)
        {
            nud_Stock.Select();
            nud_Stock.Select(0, nud_Stock.Text.Length);
        }

        private void AddProductBW(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                // TODO: Add new item
                tss_AddProduct.ForeColor = SystemColors.WindowText;
                tss_AddProduct.Text = "Product was successfully added.";

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (SqlException ex)
            {
                tss_AddProduct.ForeColor = Color.Red;
                tss_AddProduct.Text = "Product could not be added. Try again.";
            }
        }

        // Private Sub txt_Price_TextChanged(sender As Object, e As EventArgs) Handles txt_Price.TextChanged
        // If (Regex.IsMatch(txt_Price.Text, "\d{1,}.\d{0,2}")) Then
        // txt_Price.Text = Format(txt_Price.Text.Substring(0, txt_Price.Text.Length - 1), "Currency")
        // End If
        // End Sub
    }
}