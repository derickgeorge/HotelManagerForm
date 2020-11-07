using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelManagerForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            movingpanel.Left = CustomerRegistration.Left+58;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            movingpanel.Left = Employee.Left ;
        }

        private void Checkout_Click(object sender, EventArgs e)
        {
            movingpanel.Left = Checkout.Left ;
        }

        private void CustomerDetails_Click(object sender, EventArgs e)
        {
            movingpanel.Left = CustomerDetails.Left ;
        }
    }
}
