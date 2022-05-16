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

        private void btn_correc3_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("¡Perfecto! Has completado todas tus lecciones :)", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btn_correc2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("¡Muy bien! Buen trabajo! :)", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            panelGVT2.Visible = false;
            panelGVT1.Visible = true;
        }

        private void btn_correc1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("¡Muy bien! Buen trabajo! :)", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            panelGVT3.Visible = false;
            panelGVT2.Visible = true;
        }
    }
}
