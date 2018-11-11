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
using System.Text.RegularExpressions;

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
            //电话(手机）号码格式
            string pattern = "^1[0-9]{10}$";
            Regex rx = new Regex(pattern);
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please enter enough information!!!");
            }
            else if(textBox1.Text != "" && !rx.IsMatch(textBox2.Text))
            {
                MessageBox.Show("Telephone number's format is wrong!!!");
            }
            else
            {
                form1.myService.addOrder(new Order(new Customer(textBox1.Text,textBox2.Text)));
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
