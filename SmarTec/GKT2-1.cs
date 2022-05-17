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
    public partial class GKT2_1 : Form
    {
        public GKT2_1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("¡Perfecto! \n¡Has terminado todas tus lecciones! :)", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("¡Opcion Incorrecta! \n Vuelva a intentarlo :(", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                MessageBox.Show("¡Muy bien! Buen trabajo! :)", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                panelGKT22.Visible = false;
                panelGKT21.Visible = true;
            }
            else
            {
                MessageBox.Show("¡Opcion Incorrecta! \n Vuelva a intentarlo :(", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (tamo.Text == "huetamo" | tamo.Text == "HUETAMO" | tamo.Text == "Huetamo")
            {
                MessageBox.Show("¡Muy bien! Buen trabajo! :)", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                panelGKT23.Visible = false;
                panelGKT22.Visible = true;
            }
            else
            {
                MessageBox.Show("¡Opcion Incorrecta! \n Vuelva a intentarlo :(", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tamo.Text = "";
            }
        }
    }
}
