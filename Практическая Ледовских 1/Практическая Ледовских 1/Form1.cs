using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_Ледовских_1
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using System;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private Random random;

        public Form1()
        {
            random = new Random();
            InitializeComponent();
        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            int num1 = random.Next(0, 10);
            int num2 = random.Next(0, 10);
            int num3 = random.Next(0, 10);

            textBox1.Text = num1.ToString();
            textBox2.Text = num2.ToString();
            textBox3.Text = num3.ToString();

            // Исправлено условие на наличие семерки
            if (num1 == 7 || num2 == 7 || num3 == 7)
            {
                label1.Text = "Счастливая семерка!";
                string imagePath = @"C:\Users\Дмитрий\OneDrive\Рабочий стол\123.jpg"; 
                if (File.Exists(imagePath)) 
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                    pictureBox1.Visible = true;
                }
                else
                {
                    label1.Text = "Изображение не найдено!";
                    pictureBox1.Visible = false;
                }
            }
            else
            {
                label1.Text = "Попробуйте еще раз!";
                pictureBox1.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

