using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFStruc;
using System.Text.RegularExpressions;

namespace OrderWin
{
    public partial class addOrder : Form
    {
        MainForm form1 = null;
        public addOrder()
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
                using(var db = new OrderDB())
                {
                    int orderNum = 0;

                    string pipeNum = db.Order.ToList().LastOrDefault<Order>().Id.Split('-')[3];
                    Int32.TryParse(pipeNum, out orderNum);
                    Order.num = orderNum;
                }
                form1.myService.Add(new Order(new Customer(textBox1.Text, textBox2.Text),
                    new List<OrderDetail>()));
                MessageBox.Show("Add order succeed!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (form1 != null)
                form1.reloadForm();
            this.Close();
        }

    }
}
