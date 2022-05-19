using MySql.Data.MySqlClient;
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
        Operaciones op = new Operaciones();
        public SignUp()
        {
            InitializeComponent();
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

        private void label8_Click(object sender, EventArgs e)
        {
            panelre.Visible = false;
            panelogin.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panelogin.Visible = false;
            panelre.Visible = true;
        }

        private void NomR_Enter(object sender, EventArgs e)
        {
            if (NomR.Text == "NOMBRE")
            {
                NomR.Text = "";
                NomR.ForeColor = Color.Black;

                panel5.BackColor = Color.Black;
            }

        }

        private void NomR_Leave(object sender, EventArgs e)
        {
            if (NomR.Text == "")
            {
                NomR.Text = "NOMBRE";
                NomR.ForeColor = Color.Silver;

                panel5.BackColor = Color.Silver;
            }
        }

        private void Apep_Enter(object sender, EventArgs e)
        {
            if (Apep.Text == "APELLIDO PATERNO")
            {
                Apep.Text = "";
                Apep.ForeColor = Color.Black;

                panel8.BackColor = Color.Black;
            }
        }

        private void Apep_Leave(object sender, EventArgs e)
        {
            if (Apep.Text == "")
            {
                Apep.Text = "APELLIDO PATERNO";
                Apep.ForeColor = Color.Silver;

                panel8.BackColor = Color.Silver;
            }
        }

        private void Apem_Enter(object sender, EventArgs e)
        {
            if (Apem.Text == "APELLIDO MATERNO")
            {
                Apem.Text = "";
                Apem.ForeColor = Color.Black;

                panel9.BackColor = Color.Black;
            }
        }

        private void Apem_Leave(object sender, EventArgs e)
        {
            if (Apem.Text == "")
            {
                Apem.Text = "APELLIDO MATERNO";
                Apem.ForeColor = Color.Silver;

                panel9.BackColor = Color.Silver;
            }
        }

        private void EdadR_Enter(object sender, EventArgs e)
        {
            if (EdadR.Text == "EDAD")
            {
                EdadR.Text = "";
                EdadR.ForeColor = Color.Black;

                panel10.BackColor = Color.Black;
            }
        }

        private void EdadR_Leave(object sender, EventArgs e)
        {
            if (EdadR.Text == "")
            {
                EdadR.Text = "EDAD";
                EdadR.ForeColor = Color.Silver;

                panel10.BackColor = Color.Silver;
            }
        }

        private void EmailR_Enter(object sender, EventArgs e)
        {
            if (EmailR.Text == "EMAIL")
            {
                EmailR.Text = "";
                EmailR.ForeColor = Color.Black;

                panel3.BackColor = Color.Black;
            }
        }

        private void EmailR_Leave(object sender, EventArgs e)
        {
            if (EmailR.Text == "")
            {
                EmailR.Text = "EMAIL";
                EmailR.ForeColor = Color.Silver;

                panel3.BackColor = Color.Silver;
            }
        }

        private void PassR_Enter(object sender, EventArgs e)
        {

            if (PassR.Text == "CONTRASEÑA")
            {
                PassR.Text = "";
                PassR.ForeColor = Color.Black;

                panel4.BackColor = Color.Black;
            }
        }

        private void PassR_Leave(object sender, EventArgs e)
        {
            if (PassR.Text == "")
            {
                PassR.Text = "CONTRASEÑA";
                PassR.ForeColor = Color.Silver;

                panel4.BackColor = Color.Silver;
            }
        }

        private void btn_regis_Click(object sender, EventArgs e)
        {
            if (NomR.Text == "NOMBRE" | Apep.Text == "APELLIDO PATERNO" | Apem.Text == "APELLIDO MATERNO" | EdadR.Text == "EDAD" | EmailR.Text == "EMAIL" | PassR.Text == "CONTRASEÑA")
            {
                MessageBox.Show("¡Error! Algunos campos no han sido llenados, ¡Llenelos!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                int ed = int.Parse(EdadR.Text);
                if (ed < 6 | ed > 12)
                {
                    MessageBox.Show("¡Edad no permitida!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                if (ed >= 6 && ed <= 8 | ed >= 9 && ed <= 12)
                {
                    int registra = 0;

                    registra = op.Registradatos(NomR.Text, Apep.Text, Apem.Text, int.Parse(EdadR.Text), EmailR.Text, PassR.Text);
                    if (registra > 0)
                    {
                        MessageBox.Show("Usuario Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            op.ConectarBD();

            op.conectarapp.Open();

            if (Email.Text == "EMAIL" && Pass.Text == "")
            {
                MessageBox.Show("¡Error! Algunos campos no han sido llenados, ¡Llenelos!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                String email = Email.Text;
                String contra = Pass.Text;
                String nombre = op.sacNom(email, contra);
                String edad = op.sacEd(nombre);

                int ed = int.Parse(edad);

                MessageBox.Show("¡Bienvenido! " + nombre, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (ed >= 6 && ed <= 8)
                {
                    new TestP().Show();
                    new Carga().Show();
                    this.Hide();
                }
                if (ed >= 9 && ed <= 12)
                {
                    new Test2().Show();
                    new Carga().Show();
                    this.Hide();

                }
                op.conectarapp.Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
