using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmarTec
{
    public partial class GAT2_1 : Form
    {
        public GAT2_1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (leer.Text == "EL ABUELO ESTA VIEJO" | leer.Text == "el abuelo esta viejo" | leer.Text == "El abuelo esta viejo")
            {
                MessageBox.Show("¡Perfecto! \n¡Has terminado todas tus lecciones! :)", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                MessageBox.Show("¡Opcion Incorrecta! \n Vuelva a intentarlo :(", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                leer.Text = "";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (gat22.Text == "LA CASA ES DE COLOR AMARILLA" | gat22.Text == "la casa es de color amarilla" | gat22.Text == "La casa es de color amarilla")
            {
                MessageBox.Show("¡Muy bien! Buen trabajo! :)", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                panelGAT22.Visible = false;
                panelGAT21.Visible = true;
            }
            else
            {
                MessageBox.Show("¡Opcion Incorrecta! \n Vuelva a intentarlo :(", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                gat22.Text = "";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (zapt.Text == "ESOS ZAPATOS SON AZULES" | zapt.Text == "esos zapatos son azules" | zapt.Text == "Esos zapatos son azules")
            {
                MessageBox.Show("¡Muy bien! Buen trabajo! :)", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                panelGAT23.Visible = false;
                panelGAT22.Visible = true;
            }
            else
            {
                MessageBox.Show("¡Opcion Incorrecta! \n Vuelva a intentarlo :(", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                zapt.Text = "";
            }
        }
    }
}
