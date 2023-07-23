using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cockroach_race
{
    public partial class Form1 : Form
    {
        int flag1; 
        int x1, x2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "0"; 
            label2.Text = "0"; 
            x1 = 1; 
            x2 = 1; 
            pictureBox1.Left = x1; 
            pictureBox2.Left = x2;
            flag1 = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag1 = 1;

            //642
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag1 != 0) // Если дан старт :  
            {
                Random a = new Random(); // Включаем генератор случайных чисел
                // В переменную count записываем случайное число в диапазоне от 0 до 8
                int count = a.Next(8); 
                // Наращиваем значение координаты x1 на случайное число 
                x1 += count;
                // Выводим значение пройденного пути для первого игрока 
                label1.Text = Convert.ToString(x1);
                // Смещаем первого жучка на случайную величину 
                pictureBox1.Left = x1;
                // Создаём случайное число для второго игрока и повторяем всё то же самое
                count = a.Next(8); x2 += count;
                label2.Text = Convert.ToString(x2);
                pictureBox2.Left = x2;
            }
            
            // Проверяем какой из игроков дошёл до финиша и останавливаем процесс
            if ((x1 >= 642) || (x2 >= 642))
            {
                flag1 = 0;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Вася"; textBox2.Text = "Петя"; label1.Text = "0"; label2.Text = "0"; pictureBox1.Left = 1; pictureBox2.Left = 1;
        }
    }
}
