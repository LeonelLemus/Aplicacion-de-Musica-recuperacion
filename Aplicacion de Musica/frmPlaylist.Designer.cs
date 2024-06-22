namespace Aplicacion_de_Musica
{
    partial class frmPlaylist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminarCancion = new System.Windows.Forms.Button();
            this.btnEliminarPlaylist = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewPlaylists = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewCancionesPlaylist = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnReproducir = new System.Windows.Forms.Button();
            this.btnPausarReanudar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnEliminarPlaylist);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.listViewPlaylists);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 617);
            this.panel1.TabIndex = 0;
            // 
            // btnEliminarCancion
            // 
            this.btnEliminarCancion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminarCancion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEliminarCancion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCancion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCancion.Location = new System.Drawing.Point(54, 534);
            this.btnEliminarCancion.Name = "btnEliminarCancion";
            this.btnEliminarCancion.Size = new System.Drawing.Size(210, 44);
            this.btnEliminarCancion.TabIndex = 4;
            this.btnEliminarCancion.Text = "Eliminar Canción";
            this.btnEliminarCancion.UseVisualStyleBackColor = false;
            this.btnEliminarCancion.Click += new System.EventHandler(this.btnEliminarCancion_Click);
            // 
            // btnEliminarPlaylist
            // 
            this.btnEliminarPlaylist.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEliminarPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEliminarPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPlaylist.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarPlaylist.Location = new System.Drawing.Point(194, 474);
            this.btnEliminarPlaylist.Name = "btnEliminarPlaylist";
            this.btnEliminarPlaylist.Size = new System.Drawing.Size(170, 68);
            this.btnEliminarPlaylist.TabIndex = 3;
            this.btnEliminarPlaylist.Text = "Eliminar Playlist";
            this.btnEliminarPlaylist.UseVisualStyleBackColor = false;
            this.btnEliminarPlaylist.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar Canción";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewPlaylists
            // 
            this.listViewPlaylists.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listViewPlaylists.Font = new System.Drawing.Font("Showcard Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPlaylists.ForeColor = System.Drawing.Color.White;
            this.listViewPlaylists.HideSelection = false;
            this.listViewPlaylists.Location = new System.Drawing.Point(22, 99);
            this.listViewPlaylists.Name = "listViewPlaylists";
            this.listViewPlaylists.Size = new System.Drawing.Size(353, 342);
            this.listViewPlaylists.TabIndex = 1;
            this.listViewPlaylists.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(52, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Playlists Creadas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.btnPausarReanudar);
            this.panel2.Controls.Add(this.btnReproducir);
            this.panel2.Controls.Add(this.btnEliminarCancion);
            this.panel2.Controls.Add(this.listViewCancionesPlaylist);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(381, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 617);
            this.panel2.TabIndex = 1;
            // 
            // listViewCancionesPlaylist
            // 
            this.listViewCancionesPlaylist.HideSelection = false;
            this.listViewCancionesPlaylist.LargeImageList = this.imageList;
            this.listViewCancionesPlaylist.Location = new System.Drawing.Point(54, 89);
            this.listViewCancionesPlaylist.Name = "listViewCancionesPlaylist";
            this.listViewCancionesPlaylist.Size = new System.Drawing.Size(835, 416);
            this.listViewCancionesPlaylist.SmallImageList = this.imageList;
            this.listViewCancionesPlaylist.StateImageList = this.imageList;
            this.listViewCancionesPlaylist.TabIndex = 1;
            this.listViewCancionesPlaylist.UseCompatibleStateImageBehavior = false;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(80, 80);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Canciones de Playlist";
            // 
            // btnReproducir
            // 
            this.btnReproducir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReproducir.Location = new System.Drawing.Point(349, 534);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(180, 56);
            this.btnReproducir.TabIndex = 5;
            this.btnReproducir.Text = "Reproducir";
            this.btnReproducir.UseVisualStyleBackColor = true;
            this.btnReproducir.Click += new System.EventHandler(this.btnReproducir_Click);
            // 
            // btnPausarReanudar
            // 
            this.btnPausarReanudar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPausarReanudar.Location = new System.Drawing.Point(588, 534);
            this.btnPausarReanudar.Name = "btnPausarReanudar";
            this.btnPausarReanudar.Size = new System.Drawing.Size(206, 56);
            this.btnPausarReanudar.TabIndex = 6;
            this.btnPausarReanudar.Text = "Pausar";
            this.btnPausarReanudar.UseVisualStyleBackColor = true;
            this.btnPausarReanudar.Click += new System.EventHandler(this.btnPausarReanudar_Click);
            // 
            // frmPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 617);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPlaylist";
            this.Text = "frmPlaylist";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarPlaylist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewPlaylists;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listViewCancionesPlaylist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button btnEliminarCancion;
        private System.Windows.Forms.Button btnPausarReanudar;
        private System.Windows.Forms.Button btnReproducir;
    }
}