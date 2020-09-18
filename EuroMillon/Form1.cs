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
        int[] numAcertados = new int[6];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            //Variables
            int aciertos = 0;

            //Metemos los valores CORRECTOS de los textBox en un array
            foreach (Control ctrl in grupo1.Controls)
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

            Array.Sort(misNumeros);
            Array.Reverse(misNumeros);

            int izq = 0, der = misNumeros.Length -1, mitad = der/2;
            Boolean repetido = false;
            int indice = 0;
            while (!repetido)
            {
                while (izq <= der)
                {
                    if (misNumeros[mitad] < misNumeros[indice])
                    {
                        izq = mitad + 1;
                    } else if (misNumeros[mitad] == misNumeros[indice])
                    {
                        MessageBox.Show("No se pueden repetir números");
                        repetido = true;
                        break;
                    }
                    else
                    {
                        der = mitad - 1;
                    }

                    mitad = (izq + der) / 2;
                }
                indice++;
            }

            //Llenamos un array con numeros aleatorios hasta el 50 sin repeticiones
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

            //Ordenamos el vector ganador
            int pos = 0;
            for (int i = 0; i < numGanadores.Length - 1; i++)
            {
                for (int j = 1; j < numGanadores.Length; j++)
                {
                    if (numGanadores[j] > numGanadores[j - 1])
                    {
                        int aux;
                        aux = numGanadores[j];
                        numGanadores[j] = numGanadores[j - 1];
                        numGanadores[j - 1] = aux;
                        pos++;
                    }
                }
            }

            //Mostrar números ganadores
            int z = 0;
            foreach(Control ctrl in grupo2.Controls)
            {
                ctrl.Text = Convert.ToString(numGanadores[z]);
                z++;
            }

            //Comparamos los array para ver si hay números premiados
            for (int i = 0; i < misNumeros.Length; i++){
                for(int j = 0; j < numGanadores.Length; j++)
                {
                    if(misNumeros[i] == numGanadores[j])
                    {
                        aciertos++;
                        numAcertados[i] = misNumeros[i];
                    }
                }
            }

            //Mostramos el número de aciertos
            textAciertos.Items.Add(aciertos);

            //Mostramos los números acertados
            int k = 0;
            foreach(Control ctrl in grupo3.Controls)
            {
                ctrl.Text = Convert.ToString(numAcertados[k]);
                k++;
            }

            //Limpiamos los textBox
            foreach (Control ctrl in grupo1.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }

            //Posición del cursor
            textNum1.Focus();
        }

        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Seguro que quieres salir?");
            Application.Exit();
        }
    }
}
