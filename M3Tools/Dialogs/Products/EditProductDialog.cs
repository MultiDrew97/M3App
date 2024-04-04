//using System;
//using System.Windows.Forms;

//namespace SPPBC.M3Tools.Dialogs
//{
//    public partial class EditProductDialog
//    {
//        // TODO: Figure out better way to manage state of editted value for all edit dialogs
//        private Types.Product _product;
//        // Private _newInfo As Types.Customer

//        private event ProductChangedEventHandler ProductChanged;

//        private delegate void ProductChangedEventHandler();

//        public Types.Product Product
//        {
//            get
//            {
//                return _product;
//            }
//            set
//            {
//                _product = value;
//                ProductChanged?.Invoke();
//            }
//        }

//        public Types.Product NewInfo
//        {
//            get
//            {
//                return new Types.Product(Product.Id, ProductName, ProductStock, ProductPrice, Available);
//            }
//        }

//        private new string ProductName
//        {
//            get
//            {
//                return gi_Name.Text;
//            }
//            set
//            {
//                gi_Name.Text = value;
//            }
//        }

//        private int ProductStock
//        {
//            get
//            {
//                return qn_Stock.Quantity;
//            }
//            set
//            {
//                qn_Stock.Quantity = value;
//            }
//        }

//        private decimal ProductPrice
//        {
//            get
//            {
//                return pi_Price.Price;
//            }
//            set
//            {
//                pi_Price.Price = value;
//            }
//        }

//        private bool Available
//        {
//            get
//            {
//                return chk_Available.Checked;
//            }
//            set
//            {
//                chk_Available.Checked = value;
//            }
//        }

//        public EditProductDialog()
//        {
//            InitializeComponent();
//        }

//        private void FinishDialog(object sender, EventArgs e)
//        {
//            if (!ValidChangesDetected())
//            {
//                MessageBox.Show("There were errors in your edits. Please review And try again.", "Editting Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }

//            DialogResult = DialogResult.OK;
//            Close();
//        }

//        private void CancelDialog(object sender, EventArgs e)
//        {
//            DialogResult = DialogResult.Cancel;
//            Close();
//        }

//        private void ProductUpdated()
//        {
//            // _newInfo = Product.Clone()
//            ProductName = Product.Name;
//            ProductStock = Product.Stock;
//            ProductPrice = Product.Price;
//            Available = Product.Available;
//            Text = string.Format(Text, Name);
//        }

//        private bool ValidChangesDetected()
//        {
//            if ((Name ?? "") != (Product.Name ?? ""))
//            {
//                return true;
//            }

//            if (ProductStock != Product.Stock && ProductStock >= 0)
//            {
//                return true;
//            }

//            if (ProductPrice != Product.Price && ProductPrice >= 0m)
//            {
//                return true;
//            }

//            if (Available != Product.Available)
//            {
//                return true;
//            }

//            return false;
//        }

//        // Private Sub CustomersLoaded(sender As Object, e As RunWorkerCompletedEventArgs)
//        // If e.Cancelled Then
//        // Dim answer = MessageBox.Show("Unable to retrieve customer. Would you Like to try again?", "Customer Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Error)

//        // If answer = DialogResult.Yes Then
//        // While bw_LoadCustomer.IsBusy
//        // Console.WriteLine("LoadCustomers Background worker Not finished...")
//        // Utils.Wait()
//        // End While

//        // bw_LoadCustomer.RunWorkerAsync()
//        // End If
//        // Return
//        // End If

//        // FirstName = _customer.FirstName
//        // LastName = _customer.LastName
//        // Phone = _customer.PhoneNumber
//        // Email = _customer.Email
//        // Address = _customer.Address
//        // End Sub

//        // Private Sub Reload()
//        // bw_LoadCustomer.RunWorkerAsync()
//        // End Sub
//    }
//}
