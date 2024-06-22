using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacion_de_Musica;
using MySql.Data.MySqlClient;
using NAudio.Wave;

namespace Aplicacion_de_Musica
{
    public partial class frmPlaylist : Form
    {
        private int usuarioID;
        private int selectedPlaylistID = -1;
        private IWavePlayer waveOutDevice;
        private AudioFileReader audioFileReader;
        private bool isPaused;
        private string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

        public frmPlaylist(int userID)
        {
            InitializeComponent();
            usuarioID = userID;
            CargarPlaylists();

            // Configurar ListView para Playlists
            listViewPlaylists.View = View.Details;
            listViewPlaylists.OwnerDraw = true;
            listViewPlaylists.Columns.Add("Playlists", 250);
            listViewPlaylists.FullRowSelect = true;
            listViewPlaylists.GridLines = false;
            listViewPlaylists.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewPlaylists.DrawColumnHeader += listViewCatalogo_DrawColumnHeader;
            listViewPlaylists.DrawItem += listViewCatalogo_DrawItem;
            listViewPlaylists.DrawSubItem += listViewCatalogo_DrawSubItem;
            listViewPlaylists.SelectedIndexChanged += listViewPlaylists_SelectedIndexChanged;

            // Configurar ListView para Canciones
            listViewCancionesPlaylist.View = View.Details;
            listViewCancionesPlaylist.OwnerDraw = true;
            listViewCancionesPlaylist.Columns.Add("Cancione(s)", 250);
            listViewCancionesPlaylist.Columns.Add("Álbum", 200);
            listViewCancionesPlaylist.Columns.Add("Artista(s)", 200);
            listViewCancionesPlaylist.FullRowSelect = true;
            listViewCancionesPlaylist.GridLines = false;
            listViewCancionesPlaylist.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewCancionesPlaylist.DrawColumnHeader += listViewCatalogo_DrawColumnHeader;
            listViewCancionesPlaylist.DrawItem += listViewCatalogo_DrawItem;
            listViewCancionesPlaylist.DrawSubItem += listViewCatalogo_DrawSubItem;
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
                    item.Tag = reader["ID"];
                    listViewPlaylists.Items.Add(item);
                }
            }
        }

        private void listViewPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPlaylists.SelectedItems.Count > 0)
            {
                selectedPlaylistID = Convert.ToInt32(listViewPlaylists.SelectedItems[0].Tag);
                CargarCancionesPlaylist(selectedPlaylistID);
            }
        }

        private void CargarCancionesPlaylist(int playlistID)
        {
            listViewCancionesPlaylist.Items.Clear();

            using (MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=musicapp;user=root;password=;"))
            {
                con.Open();
                string query = @"SELECT c.Titulo, c.Album, c.Artista, c.ImagenUrl, c.AudioFilePath 
                          FROM PlaylistCanciones pc
                          JOIN Canciones c ON pc.CancionID = c.ID
                          WHERE pc.PlaylistID = @PlaylistID";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@PlaylistID", playlistID);
                MySqlDataReader reader = cmd.ExecuteReader();

                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["Titulo"].ToString());
                    item.SubItems.Add(reader["Album"].ToString());
                    item.SubItems.Add(reader["Artista"].ToString());
                    item.Tag = Path.Combine(baseDirectory, reader["AudioFilePath"].ToString());

                    string imagenRelativa = reader["ImagenUrl"].ToString();
                    string imagenAbsoluta = Path.Combine(baseDirectory, imagenRelativa);
                    if (File.Exists(imagenAbsoluta))
                    {
                        try
                        {
                            using (FileStream stream = new FileStream(imagenAbsoluta, FileMode.Open))
                            {
                                Image img = Image.FromStream(stream);
                                imageList.Images.Add(img);
                                item.ImageIndex = imageList.Images.Count - 1;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Archivo de imagen no encontrado: " + imagenAbsoluta);
                    }

                    listViewCancionesPlaylist.Items.Add(item);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listViewPlaylists.SelectedItems.Count > 0)
            {
                int playlistID = Convert.ToInt32(listViewPlaylists.SelectedItems[0].Tag);

                using (MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=musicapp;user=root;password=;"))
                {
                    con.Open();

                    // Eliminar todas las canciones de la playlist
                    string deleteSongsQuery = "DELETE FROM PlaylistCanciones WHERE PlaylistID = @PlaylistID";
                    MySqlCommand deleteSongsCmd = new MySqlCommand(deleteSongsQuery, con);
                    deleteSongsCmd.Parameters.AddWithValue("@PlaylistID", playlistID);
                    deleteSongsCmd.ExecuteNonQuery();

                    // Eliminar la playlist
                    string deletePlaylistQuery = "DELETE FROM Playlists WHERE ID = @PlaylistID";
                    MySqlCommand deletePlaylistCmd = new MySqlCommand(deletePlaylistQuery, con);
                    deletePlaylistCmd.Parameters.AddWithValue("@PlaylistID", playlistID);
                    deletePlaylistCmd.ExecuteNonQuery();
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

        private void btnEliminarCancion_Click(object sender, EventArgs e)
        {
            if (listViewCancionesPlaylist.SelectedItems.Count > 0 && selectedPlaylistID != -1)
            {
                string cancionTitulo = listViewCancionesPlaylist.SelectedItems[0].Text;

                using (MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=musicapp;user=root;password=;"))
                {
                    con.Open();
                    string query = @"DELETE pc
                                 FROM PlaylistCanciones pc
                                 JOIN Canciones c ON pc.CancionID = c.ID
                                 WHERE pc.PlaylistID = @PlaylistID AND c.Titulo = @Titulo";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@PlaylistID", selectedPlaylistID);
                    cmd.Parameters.AddWithValue("@Titulo", cancionTitulo);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Canción eliminada de la playlist.");
                CargarCancionesPlaylist(selectedPlaylistID);
            }
            else
            {
                MessageBox.Show("Seleccione una canción para eliminar.");
            }
        }

        // Métodos de dibujo
        private void listViewCatalogo_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(Color.LightGray))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }
            using (Pen pen = new Pen(Color.Gray))
            {
                e.Graphics.DrawRectangle(pen, e.Bounds);
            }
            TextRenderer.DrawText(e.Graphics, e.Header.Text, e.Font, e.Bounds, Color.Black, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
        }

        private void listViewCatalogo_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            if (e.Item.Selected)
            {
                using (Pen pen = new Pen(Color.Green, 5))
                {
                    Rectangle rect = e.Bounds;
                    rect.Width -= 3;
                    rect.Height -= 3;
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }
        }

        private void listViewCatalogo_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if (e.Item.Selected)
            {
                e.Graphics.FillRectangle(Brushes.LightGreen, e.Bounds);
            }
            else
            {
                e.DrawBackground();
            }

            e.DrawText();
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            if (listViewCancionesPlaylist.SelectedItems.Count > 0)
            {
                string filePath = listViewCancionesPlaylist.SelectedItems[0].Tag.ToString();
                ReproducirCancion(filePath);
                btnPausarReanudar.Text = "Pausar";
                isPaused = false;
            }
            else
            {
                MessageBox.Show("Seleccione una canción para reproducir.");
            }
        }

        private void btnPausarReanudar_Click(object sender, EventArgs e)
        {
            if (waveOutDevice != null)
            {
                if (isPaused)
                {
                    waveOutDevice.Play();
                    btnPausarReanudar.Text = "Pausar";
                    isPaused = false;
                }
                else
                {
                    waveOutDevice.Pause();
                    btnPausarReanudar.Text = "Reanudar";
                    isPaused = true;
                }
            }
        }

        private void ReproducirCancion(string filePath)
        {
            DetenerReproduccion();

            waveOutDevice = new WaveOut();
            audioFileReader = new AudioFileReader(filePath);
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();

            waveOutDevice.PlaybackStopped += (s, a) =>
            {
                DetenerReproduccion();
            };

        }

        private void DetenerReproduccion()
        {
            if (waveOutDevice != null)
            {
                waveOutDevice.Stop();
                waveOutDevice.Dispose();
                waveOutDevice = null;
            }
            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
                audioFileReader = null;
            }


        }

    }
}