using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuroMillon
{
    public partial class Form1 : Form
    {
        Random aleatorio = new Random();
        int[] misNumeros = new int[6];
        int[] numGanadores = new int[6];
        //int[] numAcertados = new int[6];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            //Variables
            int aciertos = 0;

            //Metemos los valores CORRECTOS de los textBox en un array
            foreach (Control ctrl in columna1.Controls)
            {
                if(Convert.ToInt32(ctrl.Text) > 50 || Convert.ToInt32(ctrl.Text) < 1)
                {
                    MessageBox.Show("Números no válidos");
                }
                else
                {
                    for (int i = 0; i < misNumeros.Length; i++)
                    {
                        misNumeros[i] = Convert.ToInt32(ctrl.Text);
                    }
                }
            }

            //Llenamos un array con numers aleatorios hasta el 50 sin repeticiones
            for(int i = 0; i < numGanadores.Length; i++)
            {
                Boolean continuar = true;

                while (continuar)
                {
                    int num = aleatorio.Next(50);
                    Boolean esta = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (numGanadores[j] == num)
                        {
                            esta = true;
                        }
                    }
                    if (esta == false)
                        continuar = false;
                    numGanadores[i] = num;
                }
            }

            //Mostramos los valores aleatorios
            n1.Items.Add(numGanadores[0]);
            n2.Items.Add(numGanadores[1]);
            n3.Items.Add(numGanadores[2]);
            n4.Items.Add(numGanadores[3]);
            n5.Items.Add(numGanadores[4]);
            n6.Items.Add(numGanadores[5]);

            //Comparamos los array para ver si hay números premiados
            for (int i = 0; i < misNumeros.Length; i++){
                for(int j = 0; j < numGanadores.Length; j++)
                {
                    if(misNumeros[i] == numGanadores[j])
                    {
                        aciertos++;
                        //numAcertados[i] = misNumeros[i];
                    }
                }
            }

            textAciertos.Items.Add(aciertos);

        }

        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
