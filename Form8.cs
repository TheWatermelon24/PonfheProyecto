using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int opcion, calf;
            int tape, taen, a1, a2, pp, pe, a3, a4, pro, a5, exa, a6, a7, calif1, calif2, calif3;
            do
            {
                opcion = Int16.Parse(Interaction.InputBox(
                "\n 1 Parcial I" +
                "\n 2 Parcial II " +
                "\n 3 Parcial III " +
                "\n 4 salir" +
                "\n 5.Calificación final " +
                "\n Seleccione el parcial que quieras:"));

                switch (opcion)
                {

                    case 1:
                        tape = int.Parse(Interaction.InputBox("Dime cuantas tareas pidieron en el parcial:"));
                        taen = int.Parse(Interaction.InputBox("Dime cuantas tareas entregaste:"));

                        a1 = 10 / tape;
                        a2 = a1 * taen;

                        pp = int.Parse(Interaction.InputBox("Dime cuantas practicas pidieron en el parcial:"));
                        pe = int.Parse(Interaction.InputBox("Dime cuantas practicas entregaste:"));

                        a3 = 20 / pp;
                        a4 = a3 * pe;

                        pro = int.Parse(Interaction.InputBox("Dime cuanto sacaste en el proyecto:"));
                        a5 = 2 * pro;

                        exa = int.Parse(Interaction.InputBox("Dime cuanto sacaste en el examen:"));
                        a6 = 5 * exa;

                        a7 = a2 + a4 + a5 + a6;
                        calif1 = a7 / 10;

                        MessageBox.Show("Tu calificación final es: " + calif1);

                        break;

                    case 2:

                        tape = int.Parse(Interaction.InputBox("Dime cuantas tareas pidieron en el parcial:"));
                        taen = int.Parse(Interaction.InputBox("Dime cuantas tareas entregaste:"));

                        a1 = 20 / tape;
                        a2 = a1 * taen;

                        pro = int.Parse(Interaction.InputBox("Dime cuanto sacaste en el proyecto:"));

                        a5 = 2 * pro;

                        exa = int.Parse(Interaction.InputBox("Dime cuanto sacaste en el examen:"));

                        a6 = 6 * exa;

                        a7 = a2 + a5 + a6;
                        calif2 = a7 / 10;

                        MessageBox.Show("Tu calificación final es: " + calif2);

                        break;

                    case 3:

                        tape = int.Parse(Interaction.InputBox("Dime cuantas tareas pidieron en el parcial:"));
                        taen = int.Parse(Interaction.InputBox("Dime cuantas tareas entregaste:"));

                        a1 = 10 / tape;
                        a2 = a1 * taen;

                        pp = int.Parse(Interaction.InputBox("Dime cuantas practicas pidieron en el parcial:"));
                        pe = int.Parse(Interaction.InputBox("Dime cuantas practicas entregaste:"));

                        a3 = 20 / pp;
                        a4 = a3 * pe;

                        pro = int.Parse(Interaction.InputBox("Dime cuanto sacaste en el proyecto:"));
                        a5 = 2 * pro;

                        exa = int.Parse(Interaction.InputBox("Dime cuanto sacaste en el examen:"));
                        a6 = 5 * exa;

                        a7 = a2 + a4 + a5 + a6;
                        calif3 = a7 / 10;

                        MessageBox.Show("Tu calificación final es: " + calif3);

                        break;
                    case 5:
                        calf = (calif1 + calif2 + calif3) / 3;
                        MessageBox.Show($"Tu calificación final es {calf}");
                        break;
                    case 4:
                        MessageBox.Show("Gracias por usar este programa ");
                        break;
                   

                    default:
                        MessageBox.Show("Error opción incorrecta");
                        break;

                }
            } while (opcion != 4);
        }
private void button1_Click(object sender, EventArgs e)
        {
            int tape, taen, a1, a2, pp, pe, a3, a4, pro, a5, exa, a6, a7, calif;

            tape = int.Parse(Interaction.InputBox("Dime cuantas tareas pidieron en el parcial:"));
            taen = int.Parse(Interaction.InputBox("Dime cuantas tareas entregaste:"));

            a1 = 10 / tape;
            a2 = a1 * taen;

            pp = int.Parse(Interaction.InputBox("Dime cuantas practicas pidieron en el parcial:"));
            pe = int.Parse(Interaction.InputBox("Dime cuantas practicas entregaste:"));

            a3 = 20 / pp;
            a4 = a3 * pe;

            pro = int.Parse(Interaction.InputBox("Dime cuanto sacaste en el proyecto:"));
            a5 = 2 * pro;

            exa = int.Parse(Interaction.InputBox("Dime cuanto sacaste en el examen:"));
            a6 = 5 * exa;

            a7 = a2 + a4 + a5 + a6;
            calif = a7 / 10;

            MessageBox.Show("Tu calificación final es: " + calif);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tape, taen, a1, a2, pp, pe, a3, a4, pro, a5, exa, a6, a7, calif2;
            tape = int.Parse(Interaction.InputBox("Dime cuantas tareas pidieron en el parcial:"));
            taen = int.Parse(Interaction.InputBox("Dime cuantas tareas entregaste:"));

            a1 = 20 / tape;
            a2 = a1 * taen;

            pro = int.Parse(Interaction.InputBox("Dime cuanto sacaste en el proyecto:"));

            a5 = 2 * pro;

            exa = int.Parse(Interaction.InputBox("Dime cuanto sacaste en el examen:"));

            a6 = 6 * exa;

            a7 = a2 + a5 + a6;
            calif2 = a7 / 10;

            MessageBox.Show("Tu calificación final es: " + calif2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tape, taen, a1, a2, pp, pe, a3, a4, pro, a5, exa, a6, a7, calif1;
            tape = int.Parse(Interaction.InputBox("Dime cuantas tareas pidieron en el parcial:"));
            taen = int.Parse(Interaction.InputBox("Dime cuantas tareas entregaste:"));

            a1 = 10 / tape;
            a2 = a1 * taen;

            pp = int.Parse(Interaction.InputBox("Dime cuantas practicas pidieron en el parcial:"));
            pe = int.Parse(Interaction.InputBox("Dime cuantas practicas entregaste:"));

            a3 = 20 / pp;
            a4 = a3 * pe;

            pro = int.Parse(Interaction.InputBox("Dime cuanto sacaste en el proyecto:"));
            a5 = 2 * pro;

            exa = int.Parse(Interaction.InputBox("Dime cuanto sacaste en el examen:"));
            a6 = 5 * exa;

            a7 = a2 + a4 + a5 + a6;
            calif1 = a7 / 10;

            MessageBox.Show("Tu calificación final es: " + calif1);
        }
    }
}
