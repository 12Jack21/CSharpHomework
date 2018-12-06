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

/*
1、为订单添加数据验证功能，要求
  （1）订单号不能为空、不能重复、并且是”年月日+三位流水号”的形式。
  （2）客户的电话号码是正确的格式。
2、将订单导出为HTML文件，在浏览器打开并显示。（备注：使用XSLT进行转换）
*/

namespace OrderWin
{
    public partial class MainForm : Form
    {
        ////让子窗体调用父窗体
        //public static Form1 form1 = null;
        public OrderService myService = new OrderService();
        DataTable ds = new DataTable("Orderrr");
        public string OrderTxt { get => label2.Text; }

        public MainForm()
        {
            InitializeComponent();
            orderBindingSource.DataSource = myService.GetAllOrders();       
        }

        private void setDataGridView2()
        {
            //if(orderBindingSource.Count != 0)
            //{
            //    label2.DataBindings.Clear();
            //    label2.DataBindings.Add("Text", orderBindingSource, "OrderID");
            //    orderDatasBindingSource.DataSource = myService.searchOrderByID(label2.Text)[0].OrderDatas;
            //}
            //if (orderDatasBindingSource.Count != 0)
            //{
            //    label6.DataBindings.Clear();
            //    label6.DataBindings.Add("Text", orderDatasBindingSource, "Name");
            //    dataGridView2.Rows[0].Selected = true;
            //    label6.Text = myService.searchOrderByID(label2.Text)[0].OrderDatas[0].Name;
            //}
            Order order = myService.GetOrder(label2.Text);
            if (order == null)
            {
                this.dataGridView2.DataSource = null;
            }
            else
            {
                orderDetailsBindingSource.DataSource = order.OrderDetails;
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = orderDetailsBindingSource;

            }
        }

        public void reloadForm()
        {
            orderBindingSource.DataSource = myService.GetAllOrders();
            //重新指向新的orderBindingSource
            dataGridView1.DataSource = new List<Order>();
            dataGridView1.DataSource = orderBindingSource;
            setDataGridView2();
        }
        private void orderBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            //label2.DataBindings.Clear();
            //label2.DataBindings.Add("Text", orderBindingSource, "OrderID");
        }
        private void orderDatasBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            //label6.DataBindings.Clear();
            //label6.DataBindings.Add("Text", orderDatasBindingSource, "Name");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setDataGridView2();
        }

        //添加订单
        private void button1_Click(object sender, EventArgs e)
        {
            addOrder add = new addOrder();
            add.Owner = this;
            add.ShowDialog();
        }
        //删除订单
        private void button2_Click(object sender, EventArgs e)
        {           
            if(label2.Text == "")
            {
                MessageBox.Show("no order to remove!!!");
            }
            else if(MessageBox.Show("Confirm remove ?", "remove order", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
               Order remOrder = myService.GetOrder(label2.Text);
                if (remOrder == null)
                    MessageBox.Show("remove failed!!!");
                else
                {
                    myService.Delete(remOrder.Id);
                    reloadForm();
                }
            }
        }
        //修改订单
        private void button3_Click(object sender, EventArgs e)
        {
            modifyOrder modify = new modifyOrder();
            modify.Owner = this;
            modify.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            setDataGridView2();
        }

        //增加订单明细
        private void button6_Click(object sender, EventArgs e)
        {
            addDetail addDetail = new addDetail();
            addDetail.Owner = this;
            addDetail.ShowDialog();
        }
        //移除订单明细
        private void button5_Click(object sender, EventArgs e)
        {
            if(label2.Text != "" && label6.Text != "")
            {
                if(MessageBox.Show("Remove comfim ?","remove detail",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Order selOrder = myService.GetOrder(label2.Text);
                    selOrder.removeDetail(selOrder.searchDetail(label6.Text));
                    myService.Delete(selOrder.Id);
                    myService.Add(selOrder);
                    setDataGridView2();
                    MessageBox.Show("Remove succeed!!!");
                }
            }
            else
            {
                MessageBox.Show("No datail to remove!!!");
            }
        }
        //修改订单明细
        private void button4_Click(object sender, EventArgs e)
        {
            modifyDetail modifyDetail = new modifyDetail();
            modifyDetail.Owner = this;
            modifyDetail.ShowDialog();
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        //开始搜索
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                //ID
                if (radioButton1.Checked == true)
                {
                    orderBindingSource.DataSource = myService.GetOrder(textBox1.Text);
                }//Customer
                else if (radioButton2.Checked == true)
                {
                    orderBindingSource.DataSource = myService.QueryByCustormer(textBox1.Text);
                }//AbovePrice
                else if (radioButton3.Checked == true)
                {
                    orderBindingSource.DataSource = myService.QueryAbovePrice(Convert.ToDouble(textBox1.Text));
                }
                else
                {
                    orderBindingSource.DataSource = myService.QueryByGoods(textBox1.Text);
                }
            }
            catch
            {
                orderBindingSource.DataSource = new List<Order>();
            }
            setDataGridView2();
        }

        //取消搜索，显示所有订单
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            orderBindingSource.DataSource = myService.GetAllOrders();
            setDataGridView2();
        }
    }
}
