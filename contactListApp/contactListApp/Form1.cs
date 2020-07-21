using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contactListApp
{
    public partial class ContactListApp : Form
    {
        public ContactListApp()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

            firstNameText.Text = FirstNameBox.Text;
            lastNameText.Text = lastNameBox.Text;
            phoneText.Text = phoneBox.Text;
            cityText.Text = cityBox.Text;
            addressText.Text = addressBox.Text;

        }
    }
}
