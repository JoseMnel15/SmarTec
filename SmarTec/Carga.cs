using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SmarTec
{
    public partial class Carga : Form
    {
        Thread hilo;
        delegate void delegado(int valor);

        public Carga()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            Barraprogress1.Value += 1;
            if (Barraprogress1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void Carga_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();

            hilo = new Thread(new ThreadStart(progr1));
            hilo.Start();
        }
        public void progr1()
        {
            for (int i = 0; i < 101; i++)//Incrementa el valor de la barra de progreso hasta 100
            {
                delegado DH = new delegado(actualizar1);//Se instancia el delegado y se le pasa como parámetro el método Actualizar1
                this.Invoke(DH, new object[] { i });
                Thread.Sleep(100);//Espera 100 milisegundos para simular una carga de trabajo
            }
        }
        public void actualizar1(int valor)//Método para actualizar la barra de progreso1
        {
            Barraprogress1.Value = valor;//Se asigna el valor a la barra de progreso1
        }

        private void Barraprogress1_Click(object sender, EventArgs e)
        {

        }
    }
}
