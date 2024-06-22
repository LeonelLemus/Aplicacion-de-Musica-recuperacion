using System;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Net;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using NAudio.Wave;

namespace Aplicacion_de_Musica
{
    public partial class frmCatalogo : Form
    {
        private IWavePlayer waveOutDevice;
        private AudioFileReader audioFileReader;
        private bool isPaused;


        public frmCatalogo()
        {
            InitializeComponent();

            listViewCatalogo.View = View.Details;
            listViewCatalogo.OwnerDraw = true;
            listViewCatalogo.Columns.Add("Canciones", 250);
            listViewCatalogo.Columns.Add("Álbum", 200);
            listViewCatalogo.Columns.Add("Artista(s)", 200);
            listViewCatalogo.FullRowSelect = true;
            listViewCatalogo.GridLines = false;
            listViewCatalogo.HeaderStyle = ColumnHeaderStyle.Nonclickable;

            listViewCatalogo.DrawColumnHeader += listViewCatalogo_DrawColumnHeader;
            listViewCatalogo.DrawItem += listViewCatalogo_DrawItem;
            listViewCatalogo.DrawSubItem += listViewCatalogo_DrawSubItem;

            btnPausarReanudar.Text = "Pausar";
        }

        private void frmCatalogo_Load(object sender, EventArgs e)
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
                    item.Tag = row["AudioFilePath"].ToString();

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

                    listViewCatalogo.Items.Add(item);
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

            lblEstado.Text = "Reproduciendo: " + Path.GetFileName(filePath);
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

            lblEstado.Text = "Reproducción detenida";
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            if (listViewCatalogo.SelectedItems.Count > 0)
            {
                string filePath = listViewCatalogo.SelectedItems[0].Tag.ToString();
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
                    lblEstado.Text = "Reproducción reanudada";
                    isPaused = false;
                }
                else
                {
                    waveOutDevice.Pause();
                    btnPausarReanudar.Text = "Reanudar";
                    lblEstado.Text = "Reproducción pausada";
                    isPaused = true;
                }
            }
        }
    }
}
    

