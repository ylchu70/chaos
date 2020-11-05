using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chaos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double funX(double x)
        {
            double a = double.Parse(textBox_a.Text);
            return (a * x - a * x * x);

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox_n.Text);
            int num = int.Parse(textBox_num.Text);
            double z0 = double.Parse(textBox_z0.Text);
            double x;

            x = z0;

            richTextBox1.Clear();

            for (int i = 0; i < n; i++)
                x = funX(x);
            for (int i = 0; i< num; i++)
            {
                richTextBox1.AppendText(x.ToString() + "\n");
                x = funX(x);
            }

        }
    }
}
