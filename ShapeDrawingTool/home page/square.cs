using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using home_page.Properties;
using home_page.ServiceReference1;


namespace home_page
{
    public partial class square : Form
    {
        WebService1SoapClient obj;
        public square()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            double c = obj.Square(a);
            double d = obj.Svolume(a);
            MessageBox.Show("Dots count = " + c + "v = " + d);

            System.Drawing.Graphics gObj;
            gObj = this.CreateGraphics();
            Pen myPen = new Pen(System.Drawing.Color.Black, 5);
            //myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            //Rectangle rectangle = new Rectangle(0,0,100,100);
            //gObj.DrawRectangle(myPen, rectangle);
            float[] dashPattern = new float[] { 2, 2 };
            myPen.DashPattern = dashPattern;
            gObj.DrawRectangle(myPen, 200, 200, a * 10, a * 10);
        }

        private void square_Load(object sender, EventArgs e)
        {
            obj = new WebService1SoapClient();
        }
    }
}
