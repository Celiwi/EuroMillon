using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //Tamaño del vector de los números
        static int tamanioMisNum = 0;

        int[] misNumeros;
        int[] numGanadores;
        int[] numAcertados;
        Random aleatorio = new Random();

        //Posicion del vector
        //Segundos del temporizador
        int posicion = 0, segundos = 10, correcto;

        public Form1()
        {
            InitializeComponent();

            //Vemos el número de textBox para establecer el tamaño de los vectores
            foreach (Control ctrl in grupo1.Controls)
            {
                tamanioMisNum++;
            }
            misNumeros = new int[tamanioMisNum];
            numGanadores = new int[tamanioMisNum];
            numAcertados = new int[tamanioMisNum];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void textnum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo deja escribir números y teclas de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textnum1_KeyUp(object sender, KeyEventArgs e)
        {
            //Comprobaciones con el enter
            if (e.KeyCode == Keys.Enter)
            {
                //Convertimos el objeto en textBox
                TextBox txt = (TextBox)sender;

                //Cogemos el número del textBox y lo convertimos a int
                //De esta forma nos dice si ha tenido exito o no, por lo que si das enter
                //sin ningun número te salta error pero no excepcion
                int numero;
                Boolean error = int.TryParse(txt.Text, out numero);

                //Comprobamos los números
                //noEsta nos dice si el numero ya estaba previamente
                Boolean noEsta = comprobaciones(numero);

                if (noEsta)
                {
                    //Desactivamos el textBox
                    txt.Enabled = false;
                    misNumeros[posicion] = numero;
                    posicion++;
                }
                else
                {
                    //reseteamos el cuadro de texto
                    txt.Text = "";
                    txt.Focus();
                }

                //Si el vector esta lleno
                if (posicion == tamanioMisNum)
                {
                    generarCombinacionGanadora();
                }
            }

            //Limpiar al pulsar espacio
            if (e.KeyCode == Keys.Space)
            {
                resetear();
            }

            //Para salir de la aplicación
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult resultado = MessageBox.Show("¿Deseas finalizar?", "Euro 1.0", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(resultado == DialogResult.Yes)
                {
                    Close();
                }
            }
        }

        //resetea el programa
        private void resetear()
        {
            foreach(Control ctrl in grupo1.Controls)
            {
                ctrl.Text = "";
                ctrl.Enabled = true;
            }

            foreach(Control ctrl in grupo2.Controls)
            {
                ctrl.Text = "";
            }

            foreach(Control ctrl in grupo3.Controls)
            {
                ctrl.Text = "";
            }

            textnum1.Focus();
            labelAciertos.Text = "";

            limpiarVectores();

            timer1.Enabled = true;
        }

        //Metodo para limpiar los vectores
        private void limpiarVectores()
        {
            for(int i = 0; i < misNumeros.Length; i++)
            {
                misNumeros[i] = 0;
                numGanadores[i] = 0;
                numAcertados[i] = 0;
            }
            posicion = 0;
        }

        private void generarCombinacionGanadora()
        {
            int indiceG = 0;
            while (indiceG < numGanadores.Length){
                int numAleatorio = aleatorio.Next(1, 50);
                
                //Comprobar si está o no el número
                if (!estaNumGanador(numAleatorio))
                {
                    numGanadores[indiceG] = numAleatorio;
                    indiceG++;
                }
            }

            indiceG = 0;
            Array.Reverse(numGanadores);

            //Volcamos el vector ordenado en el segundo groupBox
            foreach (Control ctrl in grupo2.Controls)
            {
                ctrl.Text = Convert.ToString(numGanadores[indiceG]);
                indiceG++;
            }

            //Comparamos ambos vectores
            compararVectores(misNumeros, numGanadores);
        }

        //Metodo para ver los aciertos
        private void compararVectores(int[] misNumeros, int[] numGanadores)
        {
            int aciertos = 0;
            int posicion = 0;
            for(int i = 0; i < misNumeros.Length; i++)
            {
                for(int j = 0; j < numGanadores.Length; j++)
                {
                    if(misNumeros[i] == numGanadores[j])
                    {
                        aciertos++;
                        correcto++;
                        numAcertados[posicion] = numGanadores[i];
                        posicion++;
                    }
                }
            }
            Array.Sort(numAcertados);
            Array.Reverse(numAcertados);

            //Sacamos el número de aciertos
            labelAciertos.Text = "Aciertos: " + aciertos;

            //Volcamos el vector de los números que hemos acertado
            posicion = 0;
            foreach (Control ctrl in grupo3.Controls)
            {
                if(numAcertados[posicion] != 0)
                ctrl.Text = Convert.ToString(numAcertados[posicion]);
                posicion++;
            }
        }

        //Método para ver si el número ya está en el vector
        //de la combinación ganadora
        private bool estaNumGanador(int numAleatorio)
        {
            Boolean esta = false;
            for (int i = 0; i < numGanadores.Length; i++)
            {
                if(numGanadores[i] == numAleatorio)
                {
                    esta = true;
                }
            }
            return esta;
        }

        //Método para comprobar que no haya repeticiones en
        //el vector de los números del usuario
        private bool comprobaciones(int numero)
        {
            Boolean noEsta = true;
            for(int i = 0; i < misNumeros.Length; i++)
            {
                //que no este repetido y que no sea ni mayor de 50 ni 0
                if (misNumeros[i] == numero || numero > 50 || numero == 0)
                {
                    noEsta = false;
                }
            }
            return noEsta;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Método que te busca la combinación ganadora automáticamente
        private void btnAutomataico_Click(object sender, EventArgs e)
        {
            while (correcto != tamanioMisNum)
            {
                correcto = 0;
                generarCombinacionGanadora();
            }
        }

        //Método del temporizador
        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos--;
            labelTemporizador.Text = Convert.ToString(segundos);
            if(segundos == 0)
            {
                timer1.Enabled = false;
                resetear();
                segundos = 10;
            }
        }
    }
}
