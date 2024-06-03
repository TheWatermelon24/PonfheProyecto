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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            //Consigue el numero de trabajos que se ingreso en el menu
            int trabajos = Convert.ToInt32(numericUpDown1.Value);

            ///Declara las Variables
            int pt_e;
            double temporal;
            double[] tra = new double[trabajos];
            double tra_c = 0;
            double tra_p = Convert.ToDouble(numericUpDown1.Value);
            double tra_e = Convert.ToDouble(numericUpDown2.Value);
            double exa_c = 0;

            // Evita que se entregen mas trabajos de las que se pidieron
            if (numericUpDown2.Value > numericUpDown1.Value)
            {
                numericUpDown2.Value = numericUpDown1.Value;
            }

            //Pide la calificación de cada una de las practicas
            for (int i = 0; i < trabajos; i++)
            {

                // Pide la calificación de la practica "i"
                temporal = Convert.ToDouble(Interaction.InputBox("Ingrese la calificación del trabajo numero: " + (i + 1)));


                // Si la calificación es una real, la guarda en la variable "tar"
                if (temporal < 11 && temporal > -1)
                {
                    tra[i] = (temporal);
                    tra_c += tra[i];
                }

                // Si no, le vuelve a pedir un numero que sea valido
                else
                {
                    MessageBox.Show("Ingrese un valor valido.");
                    i = i - 1;
                }


            }

            tra_c = (tra_c / trabajos) * 0.5;
            exa_c = (Convert.ToDouble(numericUpDown3.Value)) * 0.5;

            if ((tra_c + exa_c) < 6)
            {
                label6.ForeColor = Color.Red;
            }
            else
            {
                label6.ForeColor = SystemColors.ControlText;
            }
            label6.Text = "Calificación Parcial 1: " + ((tra_c + exa_c)) + " / 10";
            MessageBox.Show(label6.Text, "Resultado");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Consigue el numero de trabajos que se ingreso en el menu
            int trabajos = Convert.ToInt32(numericUpDown8.Value);

            ///Declara las Variables
            double temporal;
            double[] tra = new double[trabajos];
            double tra_c = 0;
            double tra_p = Convert.ToDouble(numericUpDown8.Value);
            double tra_e = Convert.ToDouble(numericUpDown7.Value);
            double exa_c = 0;

            // Evita que se entregen mas trabajos de las que se pidieron
            if (numericUpDown7.Value > numericUpDown8.Value)
            {
                numericUpDown7.Value = numericUpDown8.Value;
            }

            //Pide la calificación de cada una de las practicas
            for (int i = 0; i < trabajos; i++)
            {

                // Pide la calificación de la practica "i"
                temporal = Convert.ToDouble(Interaction.InputBox("Ingrese la calificación del trabajo numero: " + (i + 1)));


                // Si la calificación es una real, la guarda en la variable "tar"
                if (temporal < 11 && temporal > -1)
                {
                    tra[i] = (temporal);
                    tra_c += tra[i];
                }

                // Si no, le vuelve a pedir un numero que sea valido
                else
                {
                    MessageBox.Show("Ingrese un valor valido.");
                    i = i - 1;
                }


            }

            tra_c = (tra_c / trabajos) * 0.5;
            exa_c = (Convert.ToDouble(numericUpDown6.Value)) * 0.5;

            if ((tra_c + exa_c) < 6)
            {
                label8.ForeColor = Color.Red;
            }
            else
            {
                label8.ForeColor = SystemColors.ControlText;
            }
            label8.Text = "Calificación Parcial 3: " + ((tra_c + exa_c)) + " / 10";
            MessageBox.Show(label8.Text, "Resultado");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //Consigue el numero de trabajos que se ingreso en el menu
            int trabajos = Convert.ToInt32(numericUpDown12.Value);

            ///Declara las Variables
            double temporal;
            double[] tra = new double[trabajos];
            double tra_c = 0;
            double tra_p = Convert.ToDouble(numericUpDown12.Value);
            double tra_e = Convert.ToDouble(numericUpDown11.Value);
            double exa_c = 0;

            // Evita que se entregen mas trabajos de las que se pidieron
            if (numericUpDown11.Value > numericUpDown12.Value)
            {
                numericUpDown11.Value = numericUpDown12.Value;
            }

            //Pide la calificación de cada una de las practicas
            for (int i = 0; i < trabajos; i++)
            {

                // Pide la calificación de la practica "i"
                temporal = Convert.ToDouble(Interaction.InputBox("Ingrese la calificación del trabajo numero: " + (i + 1)));


                // Si la calificación es una real, la guarda en la variable "tar"
                if (temporal < 11 && temporal > -1)
                {
                    tra[i] = (temporal);
                    tra_c += tra[i];
                }

                // Si no, le vuelve a pedir un numero que sea valido
                else
                {
                    MessageBox.Show("Ingrese un valor valido.");
                    i = i - 1;
                }


            }

            tra_c = (tra_c / trabajos) * 0.5;
            exa_c = (Convert.ToDouble(numericUpDown10.Value)) * 0.5;

            if ((tra_c + exa_c) < 6)
            {
                label14.ForeColor = Color.Red;
            }
            else
            {
                label14.ForeColor = SystemColors.ControlText;
            }
            label14.Text = "Calificación Parcial 3: " + ((tra_c + exa_c)) + " / 10";
            MessageBox.Show(label14.Text, "Resultado");
        }
    }
}