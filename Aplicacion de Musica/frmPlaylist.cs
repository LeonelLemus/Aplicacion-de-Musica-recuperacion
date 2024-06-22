﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacion_de_Musica;
using MySql.Data.MySqlClient;

namespace Aplicacion_de_Musica
{
    public partial class frmPlaylist : Form
    {
        private int usuarioID;
        public frmPlaylist(int userID)
        {
            InitializeComponent();
            usuarioID = userID;
            CargarPlaylists();

        }


        private void CargarPlaylists()
        {
            listViewPlaylists.Items.Clear();

            using (MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=musicapp;user=root;password=;"))
            {
                con.Open();
                string query = "SELECT * FROM Playlists WHERE UsuarioID = @UsuarioID";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["Nombre"].ToString());
                    item.Tag = reader["PlaylistID"];
                    listViewPlaylists.Items.Add(item);
                }
            }
        }

        private void listViewPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPlaylists.SelectedItems.Count > 0)
            {
                int playlistID = Convert.ToInt32(listViewPlaylists.SelectedItems[0].Tag);
                CargarCancionesPlaylist(playlistID);
            }
        }
        private void CargarCancionesPlaylist(int playlistID)
        {
            listViewCancionesPlaylist.Items.Clear();

            using (MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=musicapp;user=root;password=;"))
            {
                con.Open();
                string query = @"SELECT c.Titulo, c.Album, c.Artista 
                             FROM PlaylistCanciones pc
                             JOIN Canciones c ON pc.CancionID = c.ID
                             WHERE pc.PlaylistID = @PlaylistID";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@PlaylistID", playlistID);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["Titulo"].ToString());
                    item.SubItems.Add(reader["Album"].ToString());
                    item.SubItems.Add(reader["Artista"].ToString());
                    listViewCancionesPlaylist.Items.Add(item);
                }
            }
        }

        private void frmPlaylist_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listViewPlaylists.SelectedItems.Count > 0)
            {
                int playlistID = Convert.ToInt32(listViewPlaylists.SelectedItems[0].Tag);

                using (MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=musicapp;user=root;password=;"))
                {
                    con.Open();
                    string query = "DELETE FROM Playlists WHERE PlaylistID = @PlaylistID";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@PlaylistID", playlistID);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Playlist eliminada.");
                CargarPlaylists();
            }
            else
            {
                MessageBox.Show("Seleccione una playlist para eliminar.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listViewPlaylists.SelectedItems.Count > 0)
            {
                int playlistID = Convert.ToInt32(listViewPlaylists.SelectedItems[0].Tag);
                fmrAgregarCancionAPlaylist frmAgregarCancionAPlaylist = new fmrAgregarCancionAPlaylist(playlistID);
                frmAgregarCancionAPlaylist.ShowDialog();
                CargarCancionesPlaylist(playlistID);
            }
            else
            {
                MessageBox.Show("Seleccione una playlist para agregar canciones.");
            }
        }
    }

}