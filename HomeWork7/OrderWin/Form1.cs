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
    public partial class Form1 : Form
    {
        ////让子窗体调用父窗体
        //public static Form1 form1 = null;
        public OrderService myService = null;
        DataTable ds = new DataTable("Orderrr");
        public string OrderTxt { get => label2.Text; }

        public Form1()
        {
            InitializeComponent();
            initOrderService();
            orderBindingSource.DataSource = myService.Orders;        
        }
        //默认订单
        private void initOrderService()
        {
            //////////////////////////////////////////////还有修改订单处需要改善
            myService = new OrderService();
            Order order1 = new Order("xiaoming");
            order1.addDetail(new OrderDetail("water", 10, 3.2));
            order1.addDetail(new OrderDetail("milk", 100, 4.76));
            order1.addDetail(new OrderDetail("laptop", 2, 500));
            order1.addDetail(new OrderDetail("course", 5, 539.99));
            Order order2 = new Order("lihua");
            order2.addDetail(new OrderDetail("ball", 1, 290));
            order2.addDetail(new OrderDetail("book", 2, 54.7));
            Order order3 = new Order("Sam");
            order3.addDetail(new OrderDetail("bag", 2, 100.3));
            order3.addDetail(new OrderDetail("shoe", 4, 1423.5));
            order3.addDetail(new OrderDetail("chair", 10, 45.1));
            order3.addDetail(new OrderDetail("telephone", 34, 1020));
            myService.addOrder(order1);
            myService.addOrder(order2);
            myService.addOrder(order3);
        }
        private void setDataGridView2()
        {
            if(orderBindingSource.Count != 0)
            {
                //label2.DataBindings.Clear();
                //label2.DataBindings.Add("Text", orderBindingSource, "OrderID");
                //orderDatasBindingSource.DataSource = myService.searchOrderByID(label2.Text)[0].OrderDatas;
            }
            if (orderDatasBindingSource.Count != 0)
            {
                //label6.DataBindings.Clear();
                //label6.DataBindings.Add("Text", orderDatasBindingSource, "Name");
                //dataGridView2.Rows[0].Selected = true;
                //label6.Text = myService.searchOrderByID(label2.Text)[0].OrderDatas[0].Name;
            }
            List<Order> orderlist = myService.searchOrderByID(label2.Text);
            if (orderlist.Count == 0)
            {
                this.dataGridView2.DataSource = null;
            }
            else
            {
                orderDatasBindingSource.DataSource = orderlist[0].OrderDatas;
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = orderDatasBindingSource;
            }
        }

        public void reloadForm()
        {
            orderBindingSource.DataSource = myService.Orders;
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
                List<Order> remOrders = myService.searchOrderByID(label2.Text);
                if (remOrders.Count == 0)
                    MessageBox.Show("remove failed!!!");
                else
                {
                    myService.removeOrder(remOrders);
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
                    Order selOrder = myService.searchOrderByID(label2.Text)[0];
                    selOrder.removeDetail(selOrder.searchDetail(label6.Text));
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
                    orderBindingSource.DataSource = myService.searchOrderByID(textBox1.Text);
                }//Customer
                else if (radioButton2.Checked == true)
                {
                    orderBindingSource.DataSource = myService.searchOrderByCus(textBox1.Text);
                }//AbovePrice
                else if (radioButton3.Checked == true)
                {
                    orderBindingSource.DataSource = myService.searchOrderHtPrice(Convert.ToDouble(textBox1.Text));
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
            orderBindingSource.DataSource = myService.Orders;
            setDataGridView2();
        }
    }
}
