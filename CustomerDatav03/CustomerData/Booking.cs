﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerData
{
    public partial class Booking : Form
    {
        public decimal Amount { get; set; }
        public int ID { get; set; }

        public Booking()
        {
            InitializeComponent();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            Text = "Book Amount to Customer";
        }
        /// <summary>
        /// Gives the main Window the amount to pay in for the choosen Customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPayIn_Click(object sender, EventArgs e)
        {
            decimal amount;
            Decimal.TryParse(tbAmount.Text, out amount);
            var id = tbCustomerNumber.Text;
            if (id.Length >0)
            {
                int ii;
                Int32.TryParse(id, out ii);
                ID = ii;
                Amount = amount;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("No ID inserted");
            }
            
        }
        /// <summary>
        /// Gives the main Window the amount to pay out for the choosen Customer
        /// (uses the textbox and makes the value negativ)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPayOut_Click(object sender, EventArgs e)
        {
            decimal i;
            Decimal.TryParse(tbAmount.Text, out i);
            Amount = 0-i; // make negertiv value
            var id = tbCustomerNumber.Text;
            if (id.Length > 0)
            {
                int ii;
                Int32.TryParse(id, out ii);
                ID = ii;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("No ID inserted");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }

        private void tbCustomerNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
