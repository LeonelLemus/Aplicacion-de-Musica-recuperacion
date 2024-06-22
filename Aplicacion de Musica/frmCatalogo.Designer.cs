namespace Aplicacion_de_Musica
{
    partial class frmCatalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalogo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearPlaylist = new System.Windows.Forms.Button();
            this.btnVerPlaylist = new System.Windows.Forms.Button();
            this.listViewCatalogo = new System.Windows.Forms.ListView();
            this.btnReproducir = new System.Windows.Forms.Button();
            this.btnPausarReanudar = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.lblEstado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCrearPlaylist);
            this.panel1.Controls.Add(this.btnVerPlaylist);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 678);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 51);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(122, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Playlist";
            // 
            // btnCrearPlaylist
            // 
            this.btnCrearPlaylist.Location = new System.Drawing.Point(4, 214);
            this.btnCrearPlaylist.Name = "btnCrearPlaylist";
            this.btnCrearPlaylist.Size = new System.Drawing.Size(136, 36);
            this.btnCrearPlaylist.TabIndex = 2;
            this.btnCrearPlaylist.Text = "Crear una PLaylist";
            this.btnCrearPlaylist.UseVisualStyleBackColor = true;
            this.btnCrearPlaylist.Click += new System.EventHandler(this.btnCrearPlaylist_Click);
            // 
            // btnVerPlaylist
            // 
            this.btnVerPlaylist.Location = new System.Drawing.Point(3, 171);
            this.btnVerPlaylist.Name = "btnVerPlaylist";
            this.btnVerPlaylist.Size = new System.Drawing.Size(113, 36);
            this.btnVerPlaylist.TabIndex = 1;
            this.btnVerPlaylist.Text = "Ver mis playlist";
            this.btnVerPlaylist.UseVisualStyleBackColor = true;
            this.btnVerPlaylist.Click += new System.EventHandler(this.btnVerPlaylist_Click);
            // 
            // listViewCatalogo
            // 
            this.listViewCatalogo.AllowDrop = true;
            this.listViewCatalogo.HideSelection = false;
            this.listViewCatalogo.LargeImageList = this.imageList;
            this.listViewCatalogo.Location = new System.Drawing.Point(281, 14);
            this.listViewCatalogo.Name = "listViewCatalogo";
            this.listViewCatalogo.Size = new System.Drawing.Size(1080, 515);
            this.listViewCatalogo.SmallImageList = this.imageList;
            this.listViewCatalogo.StateImageList = this.imageList;
            this.listViewCatalogo.TabIndex = 1;
            this.listViewCatalogo.UseCompatibleStateImageBehavior = false;
            this.listViewCatalogo.SelectedIndexChanged += new System.EventHandler(this.listViewCatalogo_SelectedIndexChanged);
            // 
            // btnReproducir
            // 
            this.btnReproducir.Location = new System.Drawing.Point(338, 568);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(140, 59);
            this.btnReproducir.TabIndex = 2;
            this.btnReproducir.Text = "Reproducir";
            this.btnReproducir.UseVisualStyleBackColor = true;
            this.btnReproducir.Click += new System.EventHandler(this.btnReproducir_Click);
            // 
            // btnPausarReanudar
            // 
            this.btnPausarReanudar.Location = new System.Drawing.Point(535, 568);
            this.btnPausarReanudar.Name = "btnPausarReanudar";
            this.btnPausarReanudar.Size = new System.Drawing.Size(149, 59);
            this.btnPausarReanudar.TabIndex = 3;
            this.btnPausarReanudar.Text = "Pausar";
            this.btnPausarReanudar.UseVisualStyleBackColor = true;
            this.btnPausarReanudar.Click += new System.EventHandler(this.btnPausarReanudar_Click);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(80, 80);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(838, 568);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(68, 24);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";
            // 
            // frmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 678);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnPausarReanudar);
            this.Controls.Add(this.btnReproducir);
            this.Controls.Add(this.listViewCatalogo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmCatalogo";
            this.Text = "Music-App";
            this.Load += new System.EventHandler(this.frmCatalogo_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCrearPlaylist;
        private System.Windows.Forms.Button btnVerPlaylist;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewCatalogo;
        private System.Windows.Forms.Button btnReproducir;
        private System.Windows.Forms.Button btnPausarReanudar;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label lblEstado;
    }
}