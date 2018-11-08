using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderSpace;

namespace OrderWin
{
    public partial class addOrder : Form
    {
        Form1 form1 = null;
        public addOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1 = (Form1)this.Owner;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter the name!!!");
            }
            else
            {
                form1.myService.addOrder(new Order(textBox1.Text));
                MessageBox.Show("Add order succeed!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(form1 != null)
                form1.reloadForm();
            this.Close();
        }
    }
}
