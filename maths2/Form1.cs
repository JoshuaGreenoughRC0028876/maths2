using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maths2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double d4 = Math.Sqrt(49);
            double d5 = Math.Pow(5, 3);
            double d6 = Math.Pow(27, 1.0, / 3.0);

            richTextBox1.AppendText(d4 + "\n" + d5 + "\n" + d6 + "\n");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        double sin (double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));

        }
        double asin(double x)
        {
            return (Math.Sin(x) * 180 / Math.PI);

        }
    }
    
    
}
