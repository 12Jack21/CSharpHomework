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


namespace OrderWin
{
    public partial class modifyDetail : Form
    {
        MainForm form1;
        List<OrderDetail> detailGroup;
        bool isChange;
        bool isConfirm;

        public modifyDetail()
        {
            InitializeComponent();
            isChange = false;
        }
        
        private void initDetailGroup()
        {
            detailGroup = new List<OrderDetail>();
            foreach (OrderDetail d in form1.myService.QueryByCustormer(label4.Text)[0].OrderDetails)
            {
                detailGroup.Add(d);
            }
        }
        private void modifyDetail_Load(object sender, EventArgs e)
        {
            form1 = (MainForm)this.Owner;
            label4.Text = form1.myService.GetOrder(form1.OrderTxt).Cus.Name;
            initDetailGroup();
            dataGridView1.DataSource = detailGroup;
        }
        //将更改传递到原订单服务中（确认）
        private void button1_Click(object sender, EventArgs e)
        {
            if(isChange)
            {
                MessageBox.Show("Modify succeed!!!");
                isConfirm = true;
            }
            else
            {
                MessageBox.Show("No modification!!!");
            }        
        }
        //更改对原订单服务不造成影响（取消）
        private void button2_Click(object sender, EventArgs e)
        {
            if(isConfirm)
            {
                Order o = form1.myService.QueryByCustormer(label4.Text)[0];
                o.OrderDetails = detailGroup;
                form1.myService.Update(o);
                form1.reloadForm();
            }
            this.Close();
        }
        //数据格式出错，修改重置
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Data format is wrong!!!");
            e.Cancel = false;      
            //initDetailGroup();           
            //dataGridView1.DataSource = new List<OrderDetail>();
            ////dataGridView1.DataSource = detailGroup;           
        }
        //做出改动
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            isChange = true;
        }
    }
}
