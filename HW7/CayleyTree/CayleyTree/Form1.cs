using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void per1_trackBar_Scroll(object sender, EventArgs e)
        {
            per1_value.Text = "0." + per1_trackBar.Value.ToString();
        }

        private void per2_trackBar_Scroll(object sender, EventArgs e)
        {

            per2_value.Text = "0." + per2_trackBar.Value.ToString();
        }

        private void th1_trackBar_Scroll(object sender, EventArgs e)
        {
            th1_value.Text = (th1_trackBar.Value*10).ToString();
        }
  
        private void th2_trackBar_Scroll(object sender, EventArgs e)
        {
            th2_value.Text = (th2_trackBar.Value*10).ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(penColor.Text)
            {
                case "Blue":
                    pensColor = Pens.Blue;
                    break;
                case "Black":
                    pensColor = Pens.Black;
                    break;
                case "Red":
                    pensColor = Pens.Red;
                    break;
                case "Gray":
                    pensColor = Pens.Gray;
                    break;
                case "Yellow":
                    pensColor = Pens.Yellow;
                    break;
                case "Purple":
                    pensColor = Pens.Purple;
                    break;
                default:
                    break;

            }
        }

        private Graphics graphics;
        double th1;
        double th2;
        double per1;
        double per2;
        int n;
        double leng;
        double th = -Math.PI / 2;
        System.Drawing.Pen pensColor;


        private void Draw_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(n_textBox.Text);
            leng = Convert.ToDouble(leng_textBox.Text);
            th1 = (Convert.ToDouble(th1_value.Text) * Math.PI / 180);  // 30 * Math.PI / 180;
            th2 =(Convert.ToDouble(th2_value.Text) * Math.PI / 180);  // 20 * Math.PI / 180;
            per1 = Convert.ToDouble(per1_value.Text);//0.6
            per2 = Convert.ToDouble(per2_value.Text);//0.7
            //double th = Convert.ToDouble(th_textBox.Text);

            if (graphics == null)graphics= this.DisplayCayleyTree.CreateGraphics();
            drawCayleyTree(n, 200, 310, leng, th);
        }
        
        void drawLine(double x0,double y0,double x1,double y1)
        {
            graphics.DrawLine(pensColor, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            n_textBox.Text = ""; leng_textBox.Text = "";
             th1 =0;th2 = 0;
            per1 = 0;per2 = 0;
            per1_value.Text = "0"; per2_value.Text = "0";
            th1_value.Text = "0"; th2_value.Text = "0";
            per1_trackBar.Value = 0; per2_trackBar.Value = 0;
            th1_trackBar.Value = 0; th2_trackBar.Value = 0;
            DisplayCayleyTree.Refresh();
        }

        
    }
}
