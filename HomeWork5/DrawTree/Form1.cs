using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void draw_Click(object sender, EventArgs e)
        {
            if (graphics != null) graphics.Clear(BackColor);
            graphics = this.CreateGraphics();
            //drawCayleyTree(10, 200, 310, 100, -Math.PI / 2)；
            drawCayleyTree(10, 200, 450, 100, -Math.PI / 2);
        }

        private Graphics graphics;

        void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0) return;

            double angle1 = Convert.ToDouble(offleft.Text) * Math.PI / 180; ;
            double angle2 = Convert.ToDouble(offright.Text) * Math.PI / 180;

            double per1 = Convert.ToDouble(perleft.Text);
            double per2 = Convert.ToDouble(perright.Text);

            double k = Convert.ToDouble(lenpara.Text);
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            double x2;
            double y2;
            if(n == 10)
            {
                //随机产生x2,y2
                x2 = x1;
                y2 = y0 + (new Random()).NextDouble() * (y1 - y0);
            }
            else
            {
                x2 = x0 + leng * k * Math.Cos(th);
                y2 = y0 + leng * k * Math.Sin(th);
            }
            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + angle1);
            drawCayleyTree(n - 1, x2, y2, per2 * leng, th - angle2);
        }
        
        void drawLine(double x0,double y0,double x1,double y1)
        {
            Pen myPen = null;
            string color = colorbox.Text;
            switch (color)
            {
                case "Pink":
                    myPen = Pens.Pink;
                    break;
                case "Red":
                    myPen = Pens.Red;
                    break;
                case "Yellow":
                    myPen = Pens.Yellow;
                    break;
                case "Black":
                    myPen = Pens.Black;
                    break;
                case "White":
                    myPen = Pens.White;
                    break;
                case "Green":
                    myPen = Pens.Green;
                    break;
            }
            graphics.DrawLine(myPen,
                (int)x0, (int)y0, (int)x1, (int)y1);       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
        }

        private void per1_Scroll(object sender, EventArgs e)
        {
            perleft.Text = ((per1.Value) / 100.0).ToString();
        }
        private void per2_Scroll(object sender, EventArgs e)
        {
            perright.Text = ((per2.Value) / 100.0).ToString();
        }

        private void angle1_Scroll(object sender, EventArgs e)
        {
            offleft.Text = angle1.Value.ToString();
        }

        private void angle2_Scroll(object sender, EventArgs e)
        {
            offright.Text = angle2.Value.ToString();
        }
    }
}
