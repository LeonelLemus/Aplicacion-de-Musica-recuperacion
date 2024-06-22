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
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnReproducir = new System.Windows.Forms.Button();
            this.btnPausarReanudar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCrearPlaylist);
            this.panel1.Controls.Add(this.btnVerPlaylist);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 678);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
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
            this.btnCrearPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCrearPlaylist.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnCrearPlaylist.FlatAppearance.BorderSize = 3;
            this.btnCrearPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearPlaylist.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPlaylist.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCrearPlaylist.Location = new System.Drawing.Point(-6, 300);
            this.btnCrearPlaylist.Name = "btnCrearPlaylist";
            this.btnCrearPlaylist.Size = new System.Drawing.Size(275, 39);
            this.btnCrearPlaylist.TabIndex = 2;
            this.btnCrearPlaylist.Text = "Crear una PLaylist";
            this.btnCrearPlaylist.UseVisualStyleBackColor = false;
            this.btnCrearPlaylist.Click += new System.EventHandler(this.btnCrearPlaylist_Click);
            // 
            // btnVerPlaylist
            // 
            this.btnVerPlaylist.BackColor = System.Drawing.Color.Chartreuse;
            this.btnVerPlaylist.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnVerPlaylist.FlatAppearance.BorderSize = 2;
            this.btnVerPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerPlaylist.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPlaylist.Location = new System.Drawing.Point(0, 209);
            this.btnVerPlaylist.Name = "btnVerPlaylist";
            this.btnVerPlaylist.Size = new System.Drawing.Size(272, 44);
            this.btnVerPlaylist.TabIndex = 1;
            this.btnVerPlaylist.Text = "Ver mis playlist";
            this.btnVerPlaylist.UseVisualStyleBackColor = false;
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
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(80, 80);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
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
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(84, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 73);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cerrar sesión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(3, 587);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 73);
            this.panel3.TabIndex = 6;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
    }
}