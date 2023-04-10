using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BraileForm.ServiceReference1;

namespace BraileForm
{
    public partial class Form1 : Form
    {
        WebService1SoapClient obj;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Get the input text from the text box
            string inputText = InputTextBox.Text;



            // Set the output text to the braille letters
            OutputTextBox.Text = obj.abc(inputText).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            obj = new WebService1SoapClient();
        }

        
    }
}
