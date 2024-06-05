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
    public partial class Form1 : Form
    {

        Form2 ImplementaMenu;
        Form3 DiseñaMenu;
        Form4 CodificaMenu;
        Form5 MateMenu;
        Form6 ForMenu;
        Form7 CulMenu;
        Form8 quiMenu;
        Form9 LeoMenu;
        Form10 INglMenu;
        Form11 CiensMenu;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                ImplementaMenu = new Form2();
                ImplementaMenu.Show();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DiseñaMenu = new Form3();
            DiseñaMenu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CodificaMenu = new Form4();
            CodificaMenu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MateMenu = new Form5();
            MateMenu.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ForMenu = new Form6();
            ForMenu.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CulMenu = new Form7();
            CulMenu.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            quiMenu = new Form8();
            quiMenu.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a = 0;
            int d = 0, tp = 0, te = 0;
            float calt = 0, calpr = 0, calex = 0, calas = 0, ca = 0, final = 0;

            do
            {
                d = int.Parse(Interaction.InputBox("Materia: Leoye\nIngresa de que quieres saber tu calificación?\n 1.Parcial\n2.Semestre\n3.Para Salir"));
                switch (d)
                {

                    case 1:

                        tp = int.Parse(Interaction.InputBox("Ingresa la cantidad de trabajos pedidos por la maestra:"));
                        te = int.Parse(Interaction.InputBox("Ingresa la cantidad de trabajos entregados:"));
                        calt = (float)(((tp / te) * 10) * 0.3);
                        calpr = float.Parse(Interaction.InputBox("Ingresa tu calificacion del proyecto"));
                        calpr = (float)(calpr * 0.3);
                        calex = float.Parse(Interaction.InputBox("Ingresa tu calificacion del examen"));
                        calex = (float)(calex * 0.3);
                        calas = int.Parse(Interaction.InputBox("Ingresa tu calificación de asistencias"));
                        ca = (float)(calas * 0.1);
                        final = ca + calpr + calt + calex;
                        MessageBox.Show("Tu calificación del parcial es " + final);



                        break;
                    case 2:

                        float p1, p2, p3, pf;
                        p1 = float.Parse(Interaction.InputBox("Ingresa tu calificación del parcial 1"));
                        p2 = float.Parse(Interaction.InputBox("Ingresa tu calificación del parcial 2"));
                        p3 = float.Parse(Interaction.InputBox("Ingresa tu calificación del parcial 3"));
                        pf = (p1 + p2 + p3) / 3;
                        MessageBox.Show("Promedio final: " + pf);
                        break;

                    case 3:
                        a = 3;
                        break;
                    default:
                        MessageBox.Show("Ingresa un valor valido");
                        break;
                }
            } while (d != 3);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //INglMenu = new Form10();
            //INglMenu.Show();
            int a = 0, d;

            int calv, ce, cl;
            float rcalv, rce, rcl, fin;
            do
            {
                d = int.Parse(Interaction.InputBox("Ingresa de que quieres saber tu calificación\n 1.Parcial\n2.Semestre\n3.Para Salir", "Ingles"));
                switch (d)
                {
                    case 1:
                        calv = int.Parse(Interaction.InputBox("Ingresa tu calificación del aula virtual: "));
                        rcalv = (float)(calv * 0.2);
                        ce = int.Parse(Interaction.InputBox("Ingresa tu calificación del examen"));
                        rce = (float)(ce * 0.7);
                        cl = int.Parse(Interaction.InputBox("Ingresa tu calificación del libro"));
                        rcl = (float)(cl * 0.1);
                        fin = rcl + rce + rcalv;
                        MessageBox.Show("Tu calificación del parcial es:" + fin);


                        break;

                    case 2:
                        float p1, p2, p3, pf;
                        p1 = float.Parse(Interaction.InputBox("Ingresa tu calificación del parcial 1"));
                        p2 = float.Parse(Interaction.InputBox("Ingresa tu calificación del parcial 2"));
                        p3 = float.Parse(Interaction.InputBox("Ingresa tu calificación del parcial 3"));
                        pf = (p1 + p2 + p3) / 3;
                        MessageBox.Show("Promedio final: " + pf);
                        break;

                    case 3:
                        a = 5;
                        break;
                    default:
                        MessageBox.Show("Ingresa un valor valido");
                        break;
                }

            } while (a != 5);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CiensMenu = new Form11();
            CiensMenu.Show();
        }
    }
}
