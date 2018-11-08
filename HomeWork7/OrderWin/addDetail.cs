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
    public partial class addDetail : Form
    {
        Form1 form1;
        Order seleOrder;
        List<OrderDetail> detailGroup;
        public addDetail()
        {
            InitializeComponent();
        }

        private void addDetail_Load(object sender, EventArgs e)
        {
            form1 = (Form1)this.Owner;
            detailGroup = new List<OrderDetail>();
            seleOrder = form1.myService.searchOrderByID(form1.OrderTxt)[0];
            foreach(OrderDetail d in seleOrder.OrderDatas)
            {
                detailGroup.Add(d);
            }
            dataGridView1.DataSource = detailGroup;
        }
        //确定
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("The input data cannot be null !!!");
                return;
            }
            try
            {
                detailGroup.Add(new OrderDetail(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToDouble(textBox3.Text)));
                MessageBox.Show("Add detail succeed!!!");
            }
            catch
            {
                MessageBox.Show("The format of the input data is wrong !!!");
            }
            finally
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            //刷新dataGridView
            dataGridView1.DataSource = new List<OrderDetail>();
            dataGridView1.DataSource = detailGroup;
        }
        //取消，退出
        private void button2_Click(object sender, EventArgs e)
        {
            seleOrder.OrderDatas = detailGroup;
            form1.reloadForm();
            this.Close();
        }
    }
}
