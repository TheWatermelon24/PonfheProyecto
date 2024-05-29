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

           
            //Pide la calificación de cada una de las practicas
            for (int i = 0; i < practicas; i++) {

                // Pide la calificación de la practica "i"
                temporal = Convert.ToDouble(Interaction.InputBox("Ingrese la calificación de la practica Numero: " + (i+1)));


                // Si la calificación es una real, la guarda en la variable "prac"
                if (temporal < 11 && temporal > -1)
                {
                    prac[i] = (temporal);
                    prac_c = prac_c + prac[i];
                }


                else
                {
                    MessageBox.Show("Ingrese un valor valido.");
                    i = i-1;
                }
                
                
            }

            prac_c = prac_c / practicas;
            
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
