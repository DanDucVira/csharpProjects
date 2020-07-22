using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace convertMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int result;



            num1 = Convert.ToInt32(numBox1.Text);
            //num1 = int.Parse(numBox1.Text);
            num2 = Convert.ToInt32(numBox2.Text);


            result = num1 + num2;


            resultNum.Text = result.ToString();


        }
    }
}
