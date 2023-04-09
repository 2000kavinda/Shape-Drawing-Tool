using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParameterForm.ServiceReference1;

namespace ParameterForm
{
    public partial class Form1 : Form
    {
        WebService1SoapClient obj;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            double c = obj.Circle(a, b);
            MessageBox.Show("Dots count = " + c);

            System.Drawing.Graphics gObj;
            gObj = this.CreateGraphics();
            Pen myPen = new Pen(System.Drawing.Color.Black, 5);
            //myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            //Rectangle rectangle = new Rectangle(0,0,100,100);
            //gObj.DrawRectangle(myPen, rectangle);
            float[] dashPattern = new float[] { b, b };
            myPen.DashPattern = dashPattern;
            gObj.DrawEllipse(myPen, 200, 200, a * 2, a * 2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            obj = new WebService1SoapClient();
        }
    }
}
