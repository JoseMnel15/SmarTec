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
    public partial class GVT2_1 : Form
    {
        public GVT2_1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
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
            if (radioButton5.Checked)
            {
                MessageBox.Show("¡Muy bien! Buen trabajo! :)", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                panelGVT22.Visible = false;
                panelGVT21.Visible = true;
            }
            else
            {
                MessageBox.Show("¡Opcion Incorrecta! \n Vuelva a intentarlo :(", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                MessageBox.Show("¡Muy bien! Buen trabajo! :)", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                panelGVT23.Visible = false;
                panelGVT22.Visible = true;
            }
            else
            {
                MessageBox.Show("¡Opcion Incorrecta! \n Vuelva a intentarlo :(", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
