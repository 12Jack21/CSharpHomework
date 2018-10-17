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
            if(radioYes.Checked == true)
            {
                itemRandom();
            }
            graphics = this.CreateGraphics();
            //drawCayleyTree(10, 200, 310, 100, -Math.PI / 2)；
            drawCayleyTree(10, 200, 450, 100, -Math.PI / 2);
        }

        private Graphics graphics;
        private Random random;
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
                y2 = y0 + random.NextDouble() * (y1 - y0);
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
                    myPen = new Pen(Color.Pink);
                    break;
                case "Red":
                    myPen = new Pen(Color.Red);
                    break;
                case "Yellow":
                    myPen = new Pen(Color.Yellow);
                    break;
                case "Black":
                    myPen = new Pen(Color.Black);
                    break;
                case "White":
                    myPen = new Pen(Color.White);
                    break;
                case "Green":
                    myPen = new Pen(Color.Green);
                    break;
                case "Blue":
                    myPen = new Pen(Color.Blue);
                    break;
            }
            //调节画笔的宽度
            myPen.Width = (float)(Convert.ToDouble(width.Text));
            graphics.DrawLine(myPen,
                (int)x0, (int)y0, (int)x1, (int)y1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            if (random == null) random = new Random();
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

        private void widthbar_Scroll(object sender, EventArgs e)
        {
            width.Text = (widthbar.Value / 100.0).ToString("0.00");
        }

        private void offleft_Leave(object sender, EventArgs e)
        {
            if (offleft.Text != "")
            {
                angle1.Value = Convert.ToInt32(offleft.Text);
            }
        }

        private void offright_Leave(object sender, EventArgs e)
        {
            if (offright.Text != "")
            {
                angle2.Value = Convert.ToInt32(offright.Text);
            }
        }

        private void perleft_Leave(object sender, EventArgs e)
        {
            if (perleft.Text != "")
            {
                per1.Value = Convert.ToInt32(perleft.Text);
            }
        }

        private void perright_Leave(object sender, EventArgs e)
        {
            if (perright.Text != "")
            {
                per2.Value = Convert.ToInt32(perright.Text);
            }
        }

        private void width_Leave(object sender, EventArgs e)
        {
            if (width.Text != "")
            {
                widthbar.Value = (int)(Convert.ToDouble(width.Text) * 100);
            }
        }

        private void radioYes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioYes.Checked == false) return;
            itemRandom();
        }

        //各个项的随机数产生
        private void itemRandom()
        {
            offleft.Text = random.Next(0, 90).ToString();
            angle1.Value = Convert.ToInt32(offleft.Text);
            offright.Text = random.Next(0, 90).ToString();
            angle2.Value = Convert.ToInt32(offright.Text);
            perleft.Text = random.NextDouble().ToString("0.00");
            per1.Value = (int)(Convert.ToDouble(perleft.Text) * 100);
            perright.Text = random.NextDouble().ToString("0.00");
            per2.Value = (int)(Convert.ToDouble(perright.Text) * 100);
            lenpara.Text = (random.NextDouble() * 2).ToString("0.00");
            width.Text = (random.NextDouble() * 5).ToString("0.00");
            widthbar.Value = (int)(Convert.ToDouble(width.Text) * 100);
            int colorTag = random.Next(0, 7);
            string colorSt = null;
            switch (colorTag)
            {
                case 0:
                    colorSt = "Pink";
                    break;
                case 1:
                    colorSt = "Red";
                    break;
                case 2:
                    colorSt = "Green";
                    break;
                case 3:
                    colorSt = "Yellow";
                    break;
                case 4:
                    colorSt = "Blue";
                    break;
                case 5:
                    colorSt = "White";
                    break;
                case 6:
                    colorSt = "Black";
                    break;
            }
            colorbox.Text = colorSt;
        }

    }
}
