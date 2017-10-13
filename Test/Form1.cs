using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spirograph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.ValueChanged += NumericUpDown1_ValueChanged;
            numericUpDown2.ValueChanged += NumericUpDown2_ValueChanged;
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = String.Join(" x ", Utils.Factorization((int)numericUpDown2.Value));
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = String.Join(" x ", Utils.Factorization((int)numericUpDown1.Value));
        }

        private void Calculate()
        {
            numericUpDown3.Value = Utils.LeastCommonMultiple((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            textBox3.Text= String.Join(" x ", Utils.Factorization((int)numericUpDown3.Value));
            numericUpDown4.Value = Utils.CountLoops((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            textBox4.Text = String.Join(" x ", Utils.Factorization((int)numericUpDown4.Value));
        }


    }
}
