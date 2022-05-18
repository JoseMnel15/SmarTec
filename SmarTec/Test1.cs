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
    public partial class TestP : Form
    {
        Operaciones op = new Operaciones();
        public TestP()
        {
            InitializeComponent();
        }

        private void btn_p8_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                op.vcon++;
            }
            if (radioButton2.Checked)
            {
                op.acon++;
            }
            if (radioButton3.Checked)
            {
                op.kcon++;
            }
            if (op.vcon > op.acon && op.vcon > op.kcon)
            {
                MessageBox.Show("¡Tu aprendizaje es Visual! :)", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                new GVT1().Show();
                this.Hide();
            }
            if (op.acon > op.vcon && op.acon > op.kcon)
            {
                MessageBox.Show("¡Tu aprendizaje es Auditivo! :)", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                new GAT1().Show();
                this.Hide();
            }
            if (op.kcon > op.vcon && op.kcon > op.acon)
            {
                MessageBox.Show("¡Tu aprendizaje es Kinestesico! :)", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                new GKT1().Show();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                op.vcon++;
                panelT7.Visible = false;
                panelT8.Visible = true;
            }
            if (radioButton5.Checked)
            {
                op.acon++;
                panelT7.Visible = false;
                panelT8.Visible = true;
            }
            if (radioButton4.Checked)
            {
                op.kcon++;
                panelT7.Visible = false;
                panelT8.Visible = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                op.vcon++;
                panelT6.Visible = false;
                panelT7.Visible = true;
            }
            if (radioButton8.Checked)
            {
                op.acon++;
                panelT6.Visible = false;
                panelT7.Visible = true;
            }
            if (radioButton7.Checked)
            {
                op.kcon++;
                panelT6.Visible = false;
                panelT7.Visible = true;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

            if (radioButton12.Checked)
            {
                op.vcon++;
                panelT5.Visible = false;
                panelT6.Visible = true;
            }
            if (radioButton11.Checked)
            {
                op.acon++;
                panelT5.Visible = false;
                panelT6.Visible = true;
            }
            if (radioButton10.Checked)
            {
                op.kcon++;
                panelT5.Visible = false;
                panelT6.Visible = true;
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            if (radioButton15.Checked)
            {
                op.vcon++;
                panelT4.Visible = false;
                panelT5.Visible = true;
            }
            if (radioButton14.Checked)
            {
                op.acon++;
                panelT4.Visible = false;
                panelT5.Visible = true;
            }
            if (radioButton13.Checked)
            {
                op.kcon++;
                panelT4.Visible = false;
                panelT5.Visible = true;
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {
            if (radioButton18.Checked)
            {
                op.vcon++;
                panelT3.Visible = false;
                panelT4.Visible = true;
            }
            if (radioButton17.Checked)
            {
                op.acon++;
                panelT3.Visible = false;
                panelT4.Visible = true;
            }
            if (radioButton16.Checked)
            {
                op.kcon++;
                panelT3.Visible = false;
                panelT4.Visible = true;
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {
            if (radioButton21.Checked)
            {
                op.vcon++;
                panelT2.Visible = false;
                panelT3.Visible = true;
            }
            if (radioButton20.Checked)
            {
                op.acon++;
                panelT2.Visible = false;
                panelT3.Visible = true;
            }
            if (radioButton19.Checked)
            {
                op.kcon++;
                panelT2.Visible = false;
                panelT3.Visible = true;
            }
        }

        private void label28_Click(object sender, EventArgs e)
        {
            if (radioButton24.Checked)
            {
                op.vcon++;
                panelT1.Visible = false;
                panelT2.Visible = true;
            }
            if (radioButton23.Checked)
            {
                op.acon++;
                panelT1.Visible = false;
                panelT2.Visible = true;
            }
            if (radioButton22.Checked)
            {
                op.kcon++;
                panelT1.Visible = false;
                panelT2.Visible = true;
            }
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
