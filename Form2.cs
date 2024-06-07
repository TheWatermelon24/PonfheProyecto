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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Consigue el numero de practicas que se ingreso en el menu
            int practicas = Convert.ToInt32(numericUpDown4.Value);

            ///Declara las Variables
            double temporal;
            double[] prac = new double[practicas];
            double prac_c = 0;
            double tar_p = Convert.ToDouble(numericUpDown1.Value);
            double tar_e = Convert.ToDouble(numericUpDown2.Value);
            double tar_c = 0;
            double exa_c = 0;

            // Evita que se entregen mas tareas de las que se pidieron

            if (numericUpDown2.Value > numericUpDown1.Value)
            {
                numericUpDown2.Value = numericUpDown1.Value;
            }

            //Pide la calificación de cada una de las practicas
            for (int i = 0; i < practicas; i++) {

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

            prac_c = (prac_c / practicas) * 0.3;
            tar_c = ((tar_e / tar_p) * 10) * 0.3;
            exa_c = (Convert.ToDouble(numericUpDown3.Value)) * 0.4;

            if ((prac_c + tar_c + exa_c) < 6)
            {
                label6.ForeColor = Color.Red;
            }
            else
            {
                label6.ForeColor = SystemColors.ControlText;
            }
            label6.Text = "Calificación Parcial 1: " + ((prac_c + tar_c + exa_c)) + " / 10";
            MessageBox.Show(label6.Text, "Resultado");


            string text = "Calificaciones faltantes: ";
            this.label1.Text = text;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Consigue el numero de practicas que se ingreso en el menu
            int practicas = Convert.ToInt32(numericUpDown5.Value);

            ///Declara las Variables
            double temporal;
            double[] prac = new double[practicas];
            double prac_c = 0;
            double tar_p = Convert.ToDouble(numericUpDown8.Value);
            double tar_e = Convert.ToDouble(numericUpDown7.Value);
            double tar_c = 0;
            double exa_c = 0;

            // Evita que se entregen mas tareas de las que se pidieron

            if (numericUpDown7.Value > numericUpDown8.Value)
            {
                numericUpDown7.Value = numericUpDown8.Value;
            }

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

            prac_c = (prac_c / practicas) * 0.3;
            tar_c = ((tar_e / tar_p) * 10) * 0.3;
            exa_c = (Convert.ToDouble(numericUpDown6.Value)) * 0.4;

            if ((prac_c + tar_c + exa_c) < 6)
            {
                label8.ForeColor = Color.Red;
            }
            else
            {
                label8.ForeColor = SystemColors.ControlText;
            }
            label8.Text = "Calificación Parcial 2: " + ((prac_c + tar_c + exa_c)) + " / 10";
            MessageBox.Show(label8.Text, "Resultado");

            string text = "Calificaciones faltantes: ";
            this.label1.Text = text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Consigue el numero de practicas que se ingreso en el menu
            int practicas = Convert.ToInt32(numericUpDown9.Value);

            ///Declara las Variables
            double temporal;
            double[] prac = new double[practicas];
            double prac_c = 0;
            double tar_p = Convert.ToDouble(numericUpDown12.Value);
            double tar_e = Convert.ToDouble(numericUpDown11.Value);
            double tar_c = 0;
            double exa_c = 0;

            // Evita que se entregen mas tareas de las que se pidieron

            if (numericUpDown11.Value > numericUpDown12.Value)
            {
                numericUpDown11.Value = numericUpDown12.Value;
            }

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

            prac_c = (prac_c / practicas) * 0.3;
            tar_c = ((tar_e / tar_p) * 10) * 0.3;
            exa_c = (Convert.ToDouble(numericUpDown10.Value)) * 0.4;

            if ((prac_c + tar_c + exa_c) < 6)
            {
                label14.ForeColor = Color.Red;
            }
            else
            {
                label14.ForeColor = SystemColors.ControlText;
            }
            label14.Text = "Calificación Parcial 3: " + ((prac_c + tar_c + exa_c)) + " / 10";
            MessageBox.Show(label14.Text, "Resultado");

            string text = "Calificaciones faltantes: ";
            this.label1.Text = text;
        }
    }
}
