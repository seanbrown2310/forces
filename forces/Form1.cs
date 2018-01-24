using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double FORCE = Convert.ToDouble(textBox1.Text);
            double ANGLE = Convert.ToDouble(textBox2.Text);
            double fx = FORCE * cos(ANGLE);
            double fY = FORCE * sin(ANGLE);
            MessageBox.Show("fx =" + fx);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }

        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }
    }   
}
