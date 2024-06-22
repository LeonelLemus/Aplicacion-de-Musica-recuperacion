using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aplicacion_de_Musica
{
    public partial class frmLogin : Form
    {
        int usuarioID;
        public frmLogin()
        {
            InitializeComponent();
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtPassword.Text;

            // Validar las credenciales en la base de datos
            if (ValidarCredenciales(nombreUsuario, contraseña))
            {
                
                this.Hide();
                
                
                frmBienvenida bienvenida = new frmBienvenida();
                bienvenida.ShowDialog();
                frmCatalogo principalForm = new frmCatalogo(usuarioID);
                principalForm.Show();
              
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }
        }


        private bool ValidarCredenciales(string nombreUsuario, string contraseña)
        {
            bool credencialesValidas = false;

            // Validar las credenciales en la base de datos
            try
            {
                using (MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=musicapp;user=root;password=;"))
                {
                    con.Open();
                    string query = "SELECT * FROM Usuarios WHERE NombreUsuario = @usuario AND Contrasena = @contraseña";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@usuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        credencialesValidas = true;
                         usuarioID = Convert.ToInt32(reader["ID"]);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar las credenciales: " + ex.Message);
            }

            return credencialesValidas;
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            frmRegistro registrar = new frmRegistro();
            registrar.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

