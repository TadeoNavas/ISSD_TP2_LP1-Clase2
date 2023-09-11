using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISSD_TP2_LP1_Clase2
{
    public partial class Form1 : Form
    {
        int contador =1;
        public Form1()
        {
            InitializeComponent();
        }
        private int aumentar(int valor)
        {
            return valor+1;
        }
        private int aumentar(int valor,int valor2)
        {
            return valor + valor2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = aumentar(int.Parse(this.Text)).ToString();

        }

        private string evaluar( TextBox textBox)
        {
            string resultado = "";
            if(int.Parse(textBox.Text) >=4)
            {
                resultado = "Aprobado";
            }
            else
            {
                resultado = "Desaprobado";
            }
            return resultado;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Random random= new Random();
            int numeroAleatorio = random.Next(1,10);
            this.Text = aumentar(int.Parse(this.Text), numeroAleatorio).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                try
                {
                    label1.Text = (int.Parse(textBox1.Text) / int.Parse(textBox2.Text)).ToString();
                }
                catch (DivideByZeroException error)
                {
                    MessageBox.Show("No se puede dividir por cero");
                }
                catch (FormatException error)
                {
                    MessageBox.Show("No ingreso valores divisibles");
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Text = contador.ToString();
            button.Width = 30;

            if(contador > 10 && contador < 21)
            {
                button.Location = new System.Drawing.Point(33 * (contador -10), 20);
                contador = contador + 1;
            }
            else if (contador > 0 && contador < 11)
            {
                button.Location = new System.Drawing.Point(33 * contador, 0);
                contador = contador + 1;
            }
            else
            {
                MessageBox.Show("No puede agregar más botones");
            }
            panel1.Controls.Add(button);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // para agregar salto de linea se usa \n
            label2.Text = evaluar(textBox3);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
