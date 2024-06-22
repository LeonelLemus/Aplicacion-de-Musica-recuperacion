using MySql.Data.MySqlClient;
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

namespace Aplicacion_de_Musica
{
    public partial class fmrAgregarCancionAPlaylist : Form
    {
        private int playlistID;
        public fmrAgregarCancionAPlaylist(int plID)
        {
            playlistID = plID;
            InitializeComponent();


            listViewCancionesDisponibles.View = View.Details;
            listViewCancionesDisponibles.OwnerDraw = true;
            listViewCancionesDisponibles.Columns.Add("Canciones", 250);
            listViewCancionesDisponibles.Columns.Add("Álbum", 200);
            listViewCancionesDisponibles.Columns.Add("Artista(s)", 200);
            listViewCancionesDisponibles.FullRowSelect = true;
            listViewCancionesDisponibles.GridLines = false;
            listViewCancionesDisponibles.HeaderStyle = ColumnHeaderStyle.Nonclickable;

            listViewCancionesDisponibles.DrawColumnHeader += listViewCatalogo_DrawColumnHeader;
            listViewCancionesDisponibles.DrawItem += listViewCatalogo_DrawItem;
            listViewCancionesDisponibles.DrawSubItem += listViewCatalogo_DrawSubItem;
        }


        private void fmrAgregarCancionAPlaylist_Load(object sender, EventArgs e)
        {

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            using (MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=musicapp;user=root;password=;"))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Canciones", con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row["Titulo"].ToString());
                    item.SubItems.Add(row["Album"].ToString());
                    item.SubItems.Add(row["Artista"].ToString());
                   

                    string imagenRelativa = row["ImagenUrl"].ToString();
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

                    listViewCancionesDisponibles.Items.Add(item);
                }
            }
        }

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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarCancion_Click(object sender, EventArgs e)
        {
            if (listViewCancionesDisponibles.SelectedItems.Count > 0)
            {
                int cancionID = Convert.ToInt32(listViewCancionesDisponibles.SelectedItems[0].Tag);

                using (MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=musicapp;user=root;password=;"))
                {
                    con.Open();
                    string query = "INSERT INTO PlaylistCanciones (PlaylistID, CancionID) VALUES (@PlaylistID, @CancionID)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@PlaylistID", playlistID);
                    cmd.Parameters.AddWithValue("@CancionID", cancionID);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Canción agregada a la playlist.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione una canción para agregar.");
            }
        }
    }
}
