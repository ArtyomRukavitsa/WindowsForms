using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Do_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Contains("2") || textBox1.Text.Contains("3") ||
                    textBox1.Text.Contains("4") || textBox1.Text.Contains("5") ||
                    textBox1.Text.Contains("6") || textBox1.Text.Contains("7") ||
                    textBox1.Text.Contains("8") || textBox1.Text.Contains("9"))
                    throw new Exception("Число не в 2ой системе");
                if (radioButton1.Checked) // 8
                {
                    textBox2.Text = NumeralSystem.ConvertToEight(textBox1.Text);
                }
                else if (radioButton2.Checked) // 10
                {
                    textBox2.Text = NumeralSystem.ConvertToTen(textBox1.Text);
                }
                else if (radioButton3.Checked) // 16
                {
                    textBox2.Text = NumeralSystem.ConvertToSixteen(textBox1.Text);
                }
            }
            catch (FormatException)
            {
                textBox2.Text = "Вы ввели не число!";
            }
            catch (Exception Error)
            {
                textBox2.Text = Error.Message;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
