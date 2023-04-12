﻿using System;
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

namespace home_page
{
    public partial class circleparameters : Form
    {
        WebService1SoapClient obj;
        public circleparameters()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void circleparameters_Load(object sender, EventArgs e)
        {
            obj = new WebService1SoapClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a = Convert.ToInt32(textBox1.Text);
            double c = obj.Circle(a, 2);
            double d = obj.Cvolume(a, 2);
            textBox3.Text = c.ToString();
            textBox2.Text = d.ToString();


            //Console.WriteLine("Dots count = " + c);
            //double d = obj.Cvolume(obj.Circle(a, b));
            //MessageBox.Show("Dots count = " + c+"v = "+d);

            System.Drawing.Graphics gObj;
            gObj = this.CreateGraphics();
            Pen myPen = new Pen(System.Drawing.Color.Black, 5);
            //myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            //Rectangle rectangle = new Rectangle(0,0,100,100);
            //gObj.DrawRectangle(myPen, rectangle);
            float[] dashPattern = new float[] { 2, 2 };
            myPen.DashPattern = dashPattern;
            gObj.DrawEllipse(myPen, 50, 50, a * 2*10, a * 2*10);
            
        }
    }
}