using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea2_lenguaje_3_proyecto_asincona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Calcularbutton_Click(object sender, EventArgs e)
        {
            decimal num1 = Convert.ToDecimal(nota1textBox.Text);
            decimal num2 = Convert.ToDecimal(nota2textBox.Text);
            decimal num3 = Convert.ToDecimal(nota3textBox.Text);
            decimal num4 = Convert.ToDecimal(nota4textBox.Text);

            decimal resultado = num1+ num2 + num3 + num4;
            decimal promedio = await PromedioAsync(num1, num2, num3, num4);

            MessageBox.Show("El Promedio de el estudiante es: " + promedio);
        }
        private async Task<decimal> PromedioAsync(decimal num1, decimal num2, decimal num3, decimal num4)
        {
        decimal promedio = await Task.Run(() =>
        {
            return num1+ num2+ num3+ num4;
        });
            return promedio / 4;
    }
    }            
        
}
