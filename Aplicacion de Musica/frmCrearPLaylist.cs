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
    public partial class frmCrearPLaylist : Form
    {
        private int usuarioID;
        public frmCrearPLaylist(int userID)
        {
            InitializeComponent();
            usuarioID = userID;
        }

        private void frmCrearPLaylist_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearPlaylist_Click(object sender, EventArgs e)
        {
            string nombrePlaylist = txtNombrePlaylist.Text;

            using (MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=musicapp;user=root;password=;"))
            {
                con.Open();
                string query = "INSERT INTO Playlists (Nombre, UsuarioID) VALUES (@Nombre, @UsuarioID)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nombre", nombrePlaylist);
                cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Playlist creada.");
            this.Close();
        }
    }
}
