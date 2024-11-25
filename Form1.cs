using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NCalc;

namespace CalculadoraRungeKuttaOrden4
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

                // Obtener datos de los campos de texto
                string functionInput = textBox1.Text;
                double y0 = double.Parse(textBox2.Text);
                double x0 = double.Parse(textBox3.Text);
                double xF = double.Parse(textBox4.Text);
                double h = double.Parse(textBox5.Text);

                // Definir la función
                Func<double, double, double> f = (x, y) =>
                {
                    string replacedFunction = functionInput.Replace("x", x.ToString()).Replace("y", y.ToString());
                    return Evaluate(replacedFunction);
                };

                // Ejecutar el método de Runge-Kutta de Orden 4
                var (xValues, yValues) = RungeKutta4(f, y0, x0, xF, h);

                // Mostrar resultados en el ListBox
                listBox1.Items.Clear();
                listBox1.Items.Add("Resultados:");
                for (int i = 0; i < xValues.Count; i++)
                {
                    listBox1.Items.Add($"x = {xValues[i]:F2}, y = {yValues[i]:F6}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos y la lista de resultados
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            listBox1.Items.Clear();
        }

        // Método de Runge-Kutta de Orden 4
        private static (List<double> x, List<double> y) RungeKutta4(Func<double, double, double> f, double y0, double x0, double xF, double h)
        {
            int n = (int)((xF - x0) / h) + 1; // Número de pasos
            var x = new List<double>(n);
            var y = new List<double>(n);

            x.Add(x0);
            y.Add(y0);

            for (int i = 0; i < n - 1; i++)
            {
                double xi = x[i];
                double yi = y[i];

                double k1 = h * f(xi, yi);
                double k2 = h * f(xi + h / 2, yi + k1 / 2);
                double k3 = h * f(xi + h / 2, yi + k2 / 2);
                double k4 = h * f(xi + h, yi + k3);

                double yi_next = yi + (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                double xi_next = xi + h;

                x.Add(xi_next);
                y.Add(yi_next);
            }

            return (x, y);
        }

        // Evaluar expresión matemática simple
        private double Evaluate(string expression)
        {
            try
            {
                // Usamos NCalc para evaluar la expresión matemática
                Expression e = new Expression(expression);

                // Evaluamos la expresión y la retornamos como un valor double
                return Convert.ToDouble(e.Evaluate());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al evaluar la expresión: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
