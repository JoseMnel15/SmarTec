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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panelogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Email_Enter(object sender, EventArgs e)
        {
            if (Email.Text == "EMAIL")
            {
                Email.Text = "";
                Email.ForeColor = Color.Black;

                panele.BackColor = Color.Black;
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (Email.Text == "")
            {
                Email.Text = "EMAIL";
                Email.ForeColor = Color.Silver;

                panele.BackColor = Color.Silver;
            }
        }

        private void Pass_Enter(object sender, EventArgs e)
        {
            if (Pass.Text == "CONTRASEÑA")
            {
                Pass.Text = "";
                Pass.ForeColor = Color.Black;

                panelc.BackColor = Color.Black;
            }
        }

        private void Pass_Leave(object sender, EventArgs e)
        {
            if (Pass.Text == "")
            {
                Pass.Text = "CONTRASEÑA";
                Pass.ForeColor = Color.Silver;

                panelc.BackColor = Color.Silver;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.panelogin.Hide();
        }
    }
}
