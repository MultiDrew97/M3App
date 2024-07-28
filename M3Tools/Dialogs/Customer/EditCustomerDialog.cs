﻿using System;
using System.Windows.Forms;

// TODO: Create a base class for these edit dialogs and other components I use for easier updating

namespace SPPBC.M3Tools.Dialogs
{
	/// <summary>
	/// 
	/// </summary>
	public partial class EditCustomerDialog
	{
		private event EventHandler CustomerChanged;

		/// <summary>
		/// The customer being edited
		/// </summary>
		public Types.Customer Original { get; private set; }

		/// <summary>
		/// The new info for the customer
		/// </summary>
		public Types.Customer Customer => new(Original.Id, FirstName, LastName, Address, Phone, Email);

		private string FirstName
		{
			get => gi_FirstName.Text;
			set => gi_FirstName.Text = value;
		}

		private string LastName
		{
			get => gi_LastName.Text;
			set => gi_LastName.Text = value;
		}

		private string Phone
		{
			get => pf_Phone.PhoneNumber;
			set => pf_Phone.PhoneNumber = value;
		}

		private string Email
		{
			get => gi_Email.Text;
			set => gi_Email.Text = value;
		}

		private Types.Address Address
		{
			get => af_Address.Address;
			set => af_Address.Address = value;
		}
		private EditCustomerDialog()
		{
			InitializeComponent();
			CustomerChanged += new EventHandler(CustomerUpdated);
		}

		/// <summary>
		/// 
		/// </summary>
		public EditCustomerDialog(Types.Customer customer) : this()
		{
			Original = (Types.Customer)customer.Clone();
			CustomerChanged?.Invoke(this, EventArgs.Empty);
		}

		private void FinishDialog(object sender, EventArgs e)
		{
			if (Customer == Original)
			{
				_ = MessageBox.Show("There were errors in your edits. Please review And try again.", "Editting Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			DialogResult = DialogResult.OK;
			Close();
		}

		private void CancelDialog(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void CustomerUpdated(object sender, EventArgs e)
		{
			FirstName = Original.FirstName;
			LastName = Original.LastName;
			Address = Original.Address;
			Phone = Original.Phone;
			Email = Original.Email;
			Text = string.Format(Text, Original.Name);
		}
	}
}
