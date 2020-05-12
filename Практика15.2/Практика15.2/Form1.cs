using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика15._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = $"Указанное число миль равно: {double.Parse(textBox1.Text) * 1.609:f2} км.";
            }
            catch (FormatException)
            {
                label2.Text = "Вы указали не число, исправьтесь :(";
            }
        }
    }
}
+