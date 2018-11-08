using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderWin
{
    public partial class modifyOrder : Form
    {
        Form1 form1 = null;
        public modifyOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1 = (Form1)this.Owner;
            if (textBox1.Text != "")
            {
                form1.myService.searchOrderByID(form1.OrderTxt)[0].update(textBox1.Text);
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
