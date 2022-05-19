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
    public partial class Test2 : Form
    {
        Operaciones op = new Operaciones();
        public Test2()
        {
            InitializeComponent();
        }

        private void label28_Click(object sender, EventArgs e)
        {
            if (radioButton24.Checked)
            {
                op.t2vcon++;
            }
            if (radioButton23.Checked)
            {
                op.t2kcon++;
            }
            if (radioButton22.Checked)
            {
                op.t2acon++;
            }
            if (op.t2vcon > op.t2acon && op.t2vcon > op.t2kcon)
            {
                MessageBox.Show("¡Tu aprendizaje es Visual! :)", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                new GVT2_1().Show();
                this.Hide();
            }
            if (op.t2acon > op.t2vcon && op.t2acon > op.t2kcon)
            {
                MessageBox.Show("¡Tu aprendizaje es Auditivo! :)", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                new GAT2_1().Show();
                this.Hide();
            }
            if (op.t2kcon > op.t2acon && op.t2kcon > op.t2vcon)
            {
                MessageBox.Show("¡Tu aprendizaje es Kinestesico! :)", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                new GKT2_1().Show();
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                op.t2acon++;
                panelT214.Visible = false;
                panelT215.Visible = true;
            }
            if (radioButton2.Checked)
            {
                op.t2vcon++;
                panelT214.Visible = false;
                panelT215.Visible = true;
            }
            if (radioButton1.Checked)
            {
                op.t2kcon++;
                panelT214.Visible = false;
                panelT215.Visible = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                op.t2vcon++;
                panelT213.Visible = false;
                panelT214.Visible = true;
            }
            if (radioButton5.Checked)
            {
                op.t2acon++;
                panelT213.Visible = false;
                panelT214.Visible = true;
            }
            if (radioButton4.Checked)
            {
                op.t2kcon++;
                panelT213.Visible = false;
                panelT214.Visible = true;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                op.t2kcon++;
                panelT212.Visible = false;
                panelT213.Visible = true;
            }
            if (radioButton8.Checked)
            {
                op.t2vcon++;
                panelT212.Visible = false;
                panelT213.Visible = true;
            }
            if (radioButton7.Checked)
            {
                op.t2acon++;
                panelT212.Visible = false;
                panelT213.Visible = true;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (radioButton12.Checked)
            {
                op.t2acon++;
                panelT211.Visible = false;
                panelT212.Visible = true;
            }
            if (radioButton11.Checked)
            {
                op.t2vcon++;
                panelT211.Visible = false;
                panelT212.Visible = true;
            }
            if (radioButton10.Checked)
            {
                op.t2kcon++;
                panelT211.Visible = false;
                panelT212.Visible = true;
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            if (radioButton15.Checked)
            {
                op.t2kcon++;
                panelT210.Visible = false;
                panelT211.Visible = true;
            }
            if (radioButton14.Checked)
            {
                op.t2acon++;
                panelT210.Visible = false;
                panelT211.Visible = true;
            }
            if (radioButton13.Checked)
            {
                op.t2vcon++;
                panelT210.Visible = false;
                panelT211.Visible = true;
            }

        }
        private void label21_Click(object sender, EventArgs e)
        {
            if (radioButton18.Checked)
            {
                op.t2vcon++;
                panelT29.Visible = false;
                panelT210.Visible = true;
            }
            if (radioButton17.Checked)
            {
                op.t2kcon++;
                panelT29.Visible = false;
                panelT210.Visible = true;
            }
            if (radioButton16.Checked)
            {
                op.t2acon++;
                panelT29.Visible = false;
                panelT210.Visible = true;
            }
        }

        private void label25_Click(object sender, EventArgs e)
        {
            if (radioButton21.Checked)
            {
                op.t2acon++;
                panelT28.Visible = false;
                panelT29.Visible = true;
            }
            if (radioButton20.Checked)
            {
                op.t2vcon++;
                panelT28.Visible = false;
                panelT29.Visible = true;
            }
            if (radioButton19.Checked)
            {
                op.t2kcon++;
                panelT28.Visible = false;
                panelT29.Visible = true;
            }
        }

        private void label33_Click(object sender, EventArgs e)
        {
            if (radioButton27.Checked)
            {
                op.t2vcon++;
                panelT27.Visible = false;
                panelT28.Visible = true;
            }
            if (radioButton26.Checked)
            {
                op.t2acon++;
                panelT27.Visible = false;
                panelT28.Visible = true;
            }
            if (radioButton25.Checked)
            {
                op.t2kcon++;
                panelT27.Visible = false;
                panelT28.Visible = true;
            }
        }

        private void label37_Click(object sender, EventArgs e)
        {
            if (radioButton30.Checked)
            {
                op.t2acon++;
                panelT26.Visible = false;
                panelT27.Visible = true;
            }
            if (radioButton29.Checked)
            {
                op.t2vcon++;
                panelT26.Visible = false;
                panelT27.Visible = true;
            }
            if (radioButton28.Checked)
            {
                op.t2kcon++;
                panelT26.Visible = false;
                panelT27.Visible = true;
            }
        }

        private void label41_Click(object sender, EventArgs e)
        {
            if (radioButton33.Checked)
            {
                op.t2acon++;
                panelT25.Visible = false;
                panelT26.Visible = true;
            }
            if (radioButton32.Checked)
            {
                op.t2vcon++;
                panelT25.Visible = false;
                panelT26.Visible = true;
            }
            if (radioButton31.Checked)
            {
                op.t2kcon++;
                panelT25.Visible = false;
                panelT26.Visible = true;
            }
        }

        private void label45_Click(object sender, EventArgs e)
        {
            if (radioButton36.Checked)
            {
                op.t2kcon++;
                panelT24.Visible = false;
                panelT25.Visible = true;
            }
            if (radioButton35.Checked)
            {
                op.t2acon++;
                panelT24.Visible = false;
                panelT25.Visible = true;
            }
            if (radioButton34.Checked)
            {
                op.t2vcon++;
                panelT24.Visible = false;
                panelT25.Visible = true;
            }
        }

        private void label49_Click(object sender, EventArgs e)
        {
            if (radioButton39.Checked)
            {
                op.t2acon++;
                panelT23.Visible = false;
                panelT24.Visible = true;
            }
            if (radioButton38.Checked)
            {
                op.t2vcon++;
                panelT23.Visible = false;
                panelT24.Visible = true;
            }
            if (radioButton37.Checked)
            {
                op.t2kcon++;
                panelT23.Visible = false;
                panelT24.Visible = true;
            }
        }

        private void label53_Click(object sender, EventArgs e)
        {
            if (radioButton42.Checked)
            {
                op.t2vcon++;
                panelT22.Visible = false;
                panelT23.Visible = true;
            }
            if (radioButton41.Checked)
            {
                op.t2kcon++;
                panelT22.Visible = false;
                panelT23.Visible = true;

            }
            if (radioButton40.Checked)
            {
                op.t2acon++;
                panelT22.Visible = false;
                panelT23.Visible = true;

            }
        }

        private void label57_Click(object sender, EventArgs e)
        {
            if (r1.Checked)
            {
                op.t2acon++;
                panelT21.Visible = false;
                panelT22.Visible = true;
            }
            if (r2.Checked)
            {
                op.t2vcon++;
                panelT21.Visible = false;
                panelT22.Visible = true;

            }
            if (r3.Checked)
            {
                op.t2kcon++;
                panelT21.Visible = false;
                panelT22.Visible = true;

            }
        }
    }
}
