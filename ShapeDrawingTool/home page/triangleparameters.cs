using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home_page
{
    public partial class triangleparameters : Form
    {
        Graphics gr_graphics = default(Graphics);
        public triangleparameters()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void triangleparameters_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            /*Point[] pnt = new Point[3];
            pnt[0].X = Convert.ToInt32(textBox1.Text);
            pnt[0].Y = Convert.ToInt32(textBox2.Text);

            pnt[1].X = Convert.ToInt32(textBox3.Text);
            pnt[1].Y = Convert.ToInt32(textBox4.Text);

            pnt[2].X = Convert.ToInt32(textBox5.Text);
            pnt[2].Y = Convert.ToInt32(textBox6.Text);*/
            Point[] points =
        {
            new Point(0, 0),
            new Point(a, 0),
            new Point((int)(0.5 * (Math.Pow(c, 2) - Math.Pow(b, 2) + Math.Pow(a, 2)) / a), (int)(Math.Sqrt(Math.Pow(c, 2) - Math.Pow((double)(Math.Pow(c, 2) - Math.Pow(b, 2) + Math.Pow(a, 2)) / (2 * a), 2))))
        };

            System.Drawing.Graphics gObj;
            gObj = this.CreateGraphics();
            Pen myPen = new Pen(System.Drawing.Color.Black, 5);
            float[] dashPattern = new float[] { 2, 2 };
            myPen.DashPattern = dashPattern;
            gObj.DrawPolygon(myPen,points);
        }
    }
}
