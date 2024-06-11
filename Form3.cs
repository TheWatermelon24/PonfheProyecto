using Microsoft.VisualBasic;
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

namespace Proyecto
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int practicas = int.Parse(Interaction.InputBox("Cuantas practicas hizo el maestro"));

            double temporal;
            double[] prac = new double[practicas];
            double prac_c = 0;
            double exa_c = 0;

            //Pide la calificación de cada una de las practicas
            for (int i = 0; i < practicas; i++)
            {

                // Pide la calificación de la practica "i"
                temporal = Convert.ToDouble(Interaction.InputBox("Ingrese la calificación de la practica Numero: " + (i + 1)));


                // Si la calificación es una real, la guarda en la variable "prac"
                if (temporal < 11 && temporal > -1)
                {
                    prac[i] = (temporal);
                    prac_c = prac_c + prac[i];
                }

                // Si no, le vuelve a pedir un numero que sea valido
                else
                {
                    MessageBox.Show("Ingrese un valor valido.");
                    i = i - 1;
                }


            }

            int exa = int.Parse(Interaction.InputBox("Cuanto sacaste en el examen"));
            prac_c = (prac_c / practicas) * 0.5;
            exa_c = exa * 0.5;

            MessageBox.Show("Calificación Parcial 1: " + ((prac_c + exa_c)) + " / 10");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int practicas = int.Parse(Interaction.InputBox("Cuantas practicas hizo el maestro"));

            double temporal;
            double[] prac = new double[practicas];
            double prac_c = 0;
            double exa_c = 0;

            //Pide la calificación de cada una de las practicas
            for (int i = 0; i < practicas; i++)
            {

                // Pide la calificación de la practica "i"
                temporal = Convert.ToDouble(Interaction.InputBox("Ingrese la calificación de la practica Numero: " + (i + 1)));


                // Si la calificación es una real, la guarda en la variable "prac"
                if (temporal < 11 && temporal > -1)
                {
                    prac[i] = (temporal);
                    prac_c = prac_c + prac[i];
                }

                // Si no, le vuelve a pedir un numero que sea valido
                else
                {
                    MessageBox.Show("Ingrese un valor valido.");
                    i = i - 1;
                }


            }

            int exa = int.Parse(Interaction.InputBox("Cuanto sacaste en el examen"));
            prac_c = (prac_c / practicas) * 0.5;
            exa_c = exa * 0.5;

            MessageBox.Show("Calificación Parcial 3: " + ((prac_c + exa_c)) + " / 10");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int practicas = int.Parse(Interaction.InputBox("Cuantas practicas hizo el maestro"));

            double temporal;
            double[] prac = new double[practicas];
            double prac_c = 0;
            double exa_c = 0;

            //Pide la calificación de cada una de las practicas
            for (int i = 0; i < practicas; i++)
            {

                // Pide la calificación de la practica "i"
                temporal = Convert.ToDouble(Interaction.InputBox("Ingrese la calificación de la practica Numero: " + (i + 1)));


                // Si la calificación es una real, la guarda en la variable "prac"
                if (temporal < 11 && temporal > -1)
                {
                    prac[i] = (temporal);
                    prac_c = prac_c + prac[i];
                }

                // Si no, le vuelve a pedir un numero que sea valido
                else
                {
                    MessageBox.Show("Ingrese un valor valido.");
                    i = i - 1;
                }


            }

            int exa = int.Parse(Interaction.InputBox("Cuanto sacaste en el examen"));
            prac_c = (prac_c / practicas) * 0.5;
            exa_c = exa * 0.5;

            MessageBox.Show("Calificación Parcial 2: " + ((prac_c + exa_c)) + " / 10");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double par1, par2, par3;

            par1 = double.Parse(Interaction.InputBox("Cual es su calificación del Parcial 1"));
            par2 = double.Parse(Interaction.InputBox("Cual es su calificación del Parcial 2"));
            par3 = double.Parse(Interaction.InputBox("Cual es su calificación del Parcial 3"));

            double calf = (par1 + par2 + par3) / 3;
            MessageBox.Show($"Tu calificación es {calf}");
        }
    }
}
