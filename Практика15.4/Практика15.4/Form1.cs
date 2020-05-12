using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика15._4
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int general_attempts = 0;
        int right_answers = 0;
        int computer_number;
        public Form1()
        {
            InitializeComponent();
            general_attempts = 1;
            right_answers = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            computer_number = rnd.Next(0, 11);
            
            if (general_attempts < 10)
            {
                try
                {
                    if (int.Parse(textBox1.Text) > 10 || int.Parse(textBox1.Text) < 0)
                        throw new Exception("число лежит вне диапазона");
                    if (computer_number == int.Parse(textBox1.Text))
                    {
                        label2.Text = "Вы угадали :))";
                        right_answers += 1;
                        general_attempts += 1;
                    }
                    else
                    {
                        label2.Text = "Ошибочка, не угадали :))";
                        general_attempts += 1;
                    }
                }
                
                catch (FormatException)
                {
                    label2.Text = "Ошибочка, ты ввел не число!";
                }
                catch (Exception err)
                {
                    label2.Text = "Ошибочка, " + err.Message;
                }
                label2.Location = new Point(25 + 10 * general_attempts, 257); // (25; 257) — начальное положение
            }
            else
            {
                label3.Text = $"Ваш коэффициент невезучести равен: {(general_attempts - right_answers) / 10.0}";
            }
        }

        
    }
}
