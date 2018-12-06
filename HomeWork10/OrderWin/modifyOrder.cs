using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFStruc;

namespace OrderWin
{
    public partial class modifyOrder : Form
    {
        MainForm form1 = null;
        public modifyOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1 = (MainForm)this.Owner;
            //电话(手机）号码格式
            string pattern = "^1[0-9]{10}$";
            Regex rx = new Regex(pattern);

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please enter enough information!!!");
            }
            else if (textBox1.Text != "" && !rx.IsMatch(textBox2.Text))
            {
                MessageBox.Show("Telephone number's format is wrong!!!");
            }
            else
            {
                Order o = form1.myService.GetOrder(form1.OrderTxt);
                o.update(textBox1.Text, textBox2.Text);
                form1.myService.Update(o);
                MessageBox.Show("Modify succeed!!!");
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
