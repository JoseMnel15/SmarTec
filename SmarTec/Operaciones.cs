using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;



namespace SmarTec
{
    internal class Operaciones
    {
        public int vcon = 0;
        public int acon = 0;
        public int kcon = 0;

        public int t2vcon = 0;
        public int t2acon = 0;
        public int t2kcon = 0;

        String cadenaconexion = "Database=smartec;Server=localhost;Uid=root;Pwd=JoseMnel2022";

        public MySqlConnection conectarapp;

        public void ConectarBD()
        {
            conectarapp = new MySqlConnection(cadenaconexion);
        }
        //Metodo para registrar Usuarios
        public int Registradatos(String nombre, String Ap, String Am, int edad, String mail, String Pass)
        {
            int usuarioregistrado = 0;
            ConectarBD();

            if (conectarapp.State == ConnectionState.Closed)
            {
                conectarapp.Open();
            }
            MySqlCommand ingresadatos = new MySqlCommand("insert into datos values(0, @nom, @ap, @am, @edad, @email, @pass)", conectarapp);

            ingresadatos.Parameters.AddWithValue("@nom", nombre);
            ingresadatos.Parameters.AddWithValue("@ap", Ap);
            ingresadatos.Parameters.AddWithValue("@am", Am);
            ingresadatos.Parameters.AddWithValue("@edad", edad);
            ingresadatos.Parameters.AddWithValue("@email", mail);
            ingresadatos.Parameters.AddWithValue("@pass", Pass);

            try
            {
                usuarioregistrado = ingresadatos.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }

            conectarapp.Close();

            return usuarioregistrado;
        }

        public String sacNom(String email, String contra)
        {
            String nombre = "";

            ConectarBD();
            conectarapp.Open();

            MySqlCommand con = new MySqlCommand("select nombre from datos where correo = @email and contraseña = @contra ", conectarapp);
            con.Parameters.AddWithValue("@email", email);
            con.Parameters.AddWithValue("@contra", contra);

            MySqlDataAdapter data = new MySqlDataAdapter(con);
            MySqlDataReader read = con.ExecuteReader();

            if (read.Read())
            {
                nombre = read["nombre"].ToString();
            }
            return nombre;
        }

        public String sacEd(String nombre)
        {
            String edad = "";

            ConectarBD();
            conectarapp.Open();

            MySqlCommand con = new MySqlCommand("select edad from datos where nombre = @nombre", conectarapp);
            con.Parameters.AddWithValue("@nombre", nombre);

            MySqlDataAdapter data = new MySqlDataAdapter(con);
            MySqlDataReader read = con.ExecuteReader();

            if (read.Read())
            {

                edad = read["edad"].ToString().Trim();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return edad;
        }
    }
}
