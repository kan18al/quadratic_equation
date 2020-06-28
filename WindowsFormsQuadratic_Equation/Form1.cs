using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quadratic_equation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double num = 0.0;
            if (Double.TryParse(this.textBox1.Text, out num) && Double.TryParse(this.textBox2.Text, out num) && Double.TryParse(this.textBox3.Text, out num))
            {
                parabola para = new parabola(Double.Parse(this.textBox1.Text), Double.Parse(this.textBox2.Text), Double.Parse(this.textBox3.Text));
                para.discriminant();
                if (para.D < 0)
                {
                    MessageBox.Show("Дискриминант меньше нуля. Корней нет.");
                }
                else if (para.D == 0)
                {
                    para.root_one();
                    MessageBox.Show("Дискриминант равен нулю. Корень равен " + para.X1 + ".");
                }
                else if (para.D > 0)
                {
                    para.root_two();
                    MessageBox.Show("Дискриминант равен " + para.D + ". Первый корень равен " + para.X1 + ". Второй корень равен " + para.X2 + ".");
                }
            }
            else
            {
                MessageBox.Show("некорректно заполнены поля!");
            }
        }
    }
}
