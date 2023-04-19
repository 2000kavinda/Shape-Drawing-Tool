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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;

namespace home_page
{
    public partial class triangleparameters : Form
    {
        WebService1SoapClient obj;
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
            obj = new WebService1SoapClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            double k= obj.Triangle(a, b, c);
            double s= obj.Tvolume(a, b, c);
            textBox4.Text = k.ToString();
            textBox5.Text = s.ToString();

            //MessageBox.Show("Dots count = " + k + "v = " + s);
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;

            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Shapes f3 = new Shapes();
            f3.Show();
            this.Hide();
        }
    }
}
