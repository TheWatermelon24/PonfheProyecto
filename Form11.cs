using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double examen, trabajos;

            examen = double.Parse(Interaction.InputBox("Dime la calificación del examen:"));


            Console.WriteLine("Ingrese la calificación de los trabajos: ");
            trabajos = double.Parse(Interaction.InputBox("Dime la calificación de los trabajos:"));


            double calificacion = (examen * 0.2) + (trabajos * 0.8);


            MessageBox.Show("Tu calificación es: " + calificacion);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double examen, trabajos, calificacion;
            examen = double.Parse(Interaction.InputBox("Dime la calificación del examen:"));


            Console.WriteLine("Ingrese la calificación de los trabajos: ");
            trabajos = double.Parse(Interaction.InputBox("Dime la calificación de los trabajos:"));


            calificacion = (examen * 0.2) + (trabajos * 0.8);


            MessageBox.Show("Tu calificación es: " + calificacion);

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double examen, trabajos, calificacion;
            examen = double.Parse(Interaction.InputBox("Dime la calificación del examen:"));


            Console.WriteLine("Ingrese la calificación de los trabajos: ");
            trabajos = double.Parse(Interaction.InputBox("Dime la calificación de los trabajos:"));


            calificacion = (examen * 0.2) + (trabajos * 0.8);


            MessageBox.Show("Tu calificación es: " + calificacion);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
