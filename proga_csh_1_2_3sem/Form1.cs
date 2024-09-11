using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace proga_csh_1_2_3sem
{
    public partial class Form1 : Form
    {
        private double radius;
        private double angle;
        private double x;
        private double y;
        public Form1()
        {
            InitializeComponent();
        }

        private void angletextBox_Leave(object sender, EventArgs e)
        {
            if (!double.TryParse(angletextBox.Text, out angle) || angle < 0 || angle > 360)
            {
                // Очищение текстового поля и вывод ошибки, если пользователь ввел неправильное значение
                //angle = 0;
                //angletextBox.Text = "";
                MessageBox.Show("Неверное значение. Пожалуйста, введите число от 0 до 360.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Установить фокус на angletextBox при ошибке
                angletextBox.Focus();
                angletextBox.SelectAll();
            }
            else
            {
                if (double.TryParse(radiustextBox.Text, out radius) && radius >= 0 &&
                    double.TryParse(angletextBox.Text, out angle) && angle >= 0 && angle <= 360)
                {
                    // перевод
                    x = radius * Math.Cos(angle * Math.PI / 180); // преобразуем угол из градусов в радианы
                    y = radius * Math.Sin(angle * Math.PI / 180); // преобразуем угол из градусов в радианы

                    xlabel.Text = x.ToString(); // установите текст Label5 равным значению x
                    ylabel.Text = y.ToString(); // установите текст Label6 равным значению y
                }
                else
                {
                    //MessageBox.Show("Неверное значение. Пожалуйста, введите неотрицательные числа для радиуса и угла.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void radiustextBox_Leave(object sender, EventArgs e)
        {
            if (!double.TryParse(radiustextBox.Text, out radius) || radius < 0)
            {
                // Очищение текстового поля и вывод ошибки, если пользователь ввел неправильное значение
                //radius = 0;
                //radiustextBox.Text = "";
                MessageBox.Show("Неверное значение. Пожалуйста, введите число от 0 до 360.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Установить фокус на angletextBox при ошибке
                radiustextBox.Focus();
                radiustextBox.SelectAll();
            }
            else
            {
                if (double.TryParse(radiustextBox.Text, out radius) && radius >= 0 &&
                    double.TryParse(angletextBox.Text, out angle) && angle >= 0 && angle <= 360)
                {
                    // перевод
                    x = radius * Math.Cos(angle * Math.PI / 180); // преобразуем угол из градусов в радианы
                    y = radius * Math.Sin(angle * Math.PI / 180); // преобразуем угол из градусов в радианы

                    xlabel.Text = x.ToString(); // установите текст Label5 равным значению x
                    ylabel.Text = y.ToString(); // установите текст Label6 равным значению y
                }
                else
                {
                    //MessageBox.Show("Неверное значение. Пожалуйста, введите неотрицательные числа для радиуса и угла.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void xlabel_Click(object sender, EventArgs e)
        {

        }

        private void ylabel_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
