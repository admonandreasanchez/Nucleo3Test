
using System;
using System.Windows.Forms;

namespace Nucleo3Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Lógica que se ejecuta al cargar el formulario
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // Lógica para el evento TextChanged de textBox1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RealizarOperacion("+");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RealizarOperacion("-");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Lógica para el evento Click de label1
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Lógica para el evento Click de label2
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Lógica para el evento Click de label4
        }

        private void RealizarOperacion(string operacion)
        {
            double numero1, numero2, resultado;

            if (double.TryParse(textBox1.Text, out numero1) && double.TryParse(textBox2.Text, out numero2))
            {
                switch (operacion)
                {
                    case "+":
                        resultado = numero1 + numero2;
                        break;
                    case "-":
                        resultado = numero1 - numero2;
                        break;
                    case "*":
                        resultado = numero1 * numero2;
                        break;
                    case "/":
                        if (numero2 != 0)
                        {
                            resultado = numero1 / numero2;
                        }
                        else
                        {
                            MessageBox.Show("No se puede dividir por cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    default:
                        MessageBox.Show("Operación no válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                textBox3.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese números válidos en ambas cajas de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}






