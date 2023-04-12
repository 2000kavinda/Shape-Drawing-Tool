using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;

namespace ShapeDrawingTool
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public double Circle(int r, int g)
        {
            double pi = 3.14;
            double p = 2 * pi * r;
            double c = p / g ;
            return Math.Round(c);
            
        }
        [WebMethod]
        public double Cvolume(int r, int g)
        {
            double pi = 3.14;
            double h = 0.05;
            double p = 2 * pi * r;
            double c = p / g ;
            double v = c*2 * pi * h * h * h / 3;
            return v;
            
        }
        [WebMethod]
        public double Rectangle(int x, int y)
        {
            double p = 2 * (x+y) ;
            double c = p / 2;
            return Math.Round(c);

        }
        [WebMethod]
        public double Rvolume(int x, int y)
        {
            double pi = 3.14;
            double h = 0.05;
            double p = 2 * (x + y);
            double c = p / 2;
            double v = c * 2 * pi * h * h * h / 3;
            return v;

        }
        [WebMethod]
        public double Square(int x)
        {
            double p = 4*x;
            double c = p / 2;
            return Math.Round(c);

        }
        [WebMethod]
        public double Svolume(int x)
        {
            double pi = 3.14;
            double h = 0.05;
            double p = 4 * x;
            double c = p / 2;
            double v = c * 2 * pi * h * h * h / 3;
            return v;

        }
        [WebMethod]
        public double Triangle(int a, int b,int c)
        {
            double co = (a+b+c)/2;
            return Math.Round(co);

        }
        [WebMethod]
        public double Tvolume(int a, int b, int c)
        {
            double pi = 3.14;
            double h = 0.05;
            double co = (a + b + c) / 2;
            double v = c * 2 * pi * h * h * h / 3;
            return v;

        }
        [WebMethod]
        public String abc(string inputText)
        {
            // Create a dictionary to map regular letters to their corresponding braille letters
            Dictionary<char, string> brailleMap = new Dictionary<char, string>()
            {
                {'a', "⠇"},
                {'b', "⠃"},
                {'c', "⠉"},
                {'d', "⠙"},
                {'e', "⠑"},
                {'f', "⠋"},
                {'g', "⠛"},
                {'h', "⠓"},
                {'i', "⠊"},
                {'j', "⠚"},
                {'k', "⠅"},
                {'l', "⠇"},
                {'m', "⠍"},
                {'n', "⠝"},
                {'o', "⠕"},
                {'p', "⠏"},
                {'q', "⠟"},
                {'r', "⠗"},
                {'s', "⠎"},
                {'t', "⠞"},
                {'u', "⠥"},
                {'v', "⠧"},
                {'w', "⠺"},
                {'x', "⠭"},
                {'y', "⠽"},
                {'z', "⠵"}
            };
            String k = " ";
            // Create a StringBuilder to store the output braille letters
            //StringBuilder outputBuilder = new StringBuilder();

            // Convert each letter of the input text to its corresponding braille letter
            foreach (char c in inputText)
            {
                // Check if the letter is in the dictionary
                if (brailleMap.ContainsKey(c))
                {
                    // If the letter is in the dictionary, add its braille letter to the output
                    //outputBuilder.Append(brailleMap[c]);
                    k = k + brailleMap[c];
                }
                else
                {
                    // If the letter is not in the dictionary, add a space to the output
                    //outputBuilder.Append(" ");
                    k = k + " ";
                }

            }
            return k;
        }

    }
}
