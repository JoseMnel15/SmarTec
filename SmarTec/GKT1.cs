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
    public partial class GKT1 : Form
    {
        public GKT1()
        {
            InitializeComponent();
        }
        private void GKT1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (btn_1.Checked)
            {
                MessageBox.Show("¡Perfecto! \n¡Has terminado todas tus lecciones! :)", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                MessageBox.Show("¡Opcion Incorrecta! \n Vuelva a intentarlo :(", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                MessageBox.Show("¡Muy bien! Buen trabajo! :)", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                panelGKT2.Visible = false;
                panelGKT1.Visible = true;

            }
            else
            {
                MessageBox.Show("¡Opcion Incorrecta! \n Vuelva a intentarlo :(", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

            if (radioButton7.Checked)
            {
                MessageBox.Show("¡Muy bien! Buen trabajo! :)", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                panelGKT3.Visible = false;
                panelGKT2.Visible = true;
            }
            else
            {
                MessageBox.Show("¡Opcion Incorrecta! \n Vuelva a intentarlo :(", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
