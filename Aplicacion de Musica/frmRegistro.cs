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

namespace Aplicacion_de_Musica
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btntRegistrar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=musicapp;user=root;password=;"))
            {
                con.Open();
                string query = "INSERT INTO Usuarios (NombreUsuario, Contrasena, email) VALUES (@nombreUsuario, @contrasena, @email)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nombreUsuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@contrasena", txtPassword.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario registrado exitosamente.");
                this.Close();
            }
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
