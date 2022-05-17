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
    public partial class GAT1 : Form
    {
        public GAT1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (quesad.Text == "Quesadilla" | quesad.Text == "QUESADILLA" | quesad.Text == "quesadilla")
            {
                MessageBox.Show("¡Perfecto! \n¡Has terminado todas tus lecciones! :)", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("¡Opcion Incorrecta! \n Vuelva a intentarlo :(", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                quesad.Text = "";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                MessageBox.Show("¡Muy bien! Buen trabajo! :)", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                panelGAT2.Visible = false;
                panelGAT1.Visible = true;
            }
            else
            {
                MessageBox.Show("¡Opcion Incorrecta! \n Vuelva a intentarlo :(", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                MessageBox.Show("¡Muy bien! Buen trabajo! :)", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                panelGAT3.Visible = false;
                panelGAT2.Visible = true;
            }
            else
            {
                MessageBox.Show("¡Opcion Incorrecta! \n Vuelva a intentarlo :(", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
