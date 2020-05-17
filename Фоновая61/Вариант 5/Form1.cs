using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Вариант_5
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button2.Location.Y < 10 && button2.Location.Y >= 0)
                button2.Location = new Point(button2.Location.X, 0);
            else
                button2.Location = new Point(button2.Location.X, button2.Location.Y - 10);
            changeColor();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Научный метод тыка показал, что высота шапки примерно равна 37 px
            // button2.Location.Y + button2.Size.Height + 37 — это сумма координаты игрек
            // левой верхней вершины, высоты кнопки, высоты шапки 
            if (button2.Location.Y + button2.Size.Height + 37 <= Size.Height 
                && button2.Location.Y + button2.Size.Height + 37 >= Size.Height - 10)
                button2.Location = new Point(button2.Location.X, Size.Height - 37 - button2.Size.Height);
            else
                button2.Location = new Point(button2.Location.X, button2.Location.Y + 10);
            changeColor();
        }
        
        private void changeColor()
        {
            button1.BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            button2.BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }
    }
}
