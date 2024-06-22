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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewPlaylists = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEliminarPlaylist = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewCancionesPlaylist = new System.Windows.Forms.ListView();
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
            this.panel1.Size = new System.Drawing.Size(362, 617);
            this.panel1.TabIndex = 0;
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
            // listViewPlaylists
            // 
            this.listViewPlaylists.HideSelection = false;
            this.listViewPlaylists.Location = new System.Drawing.Point(22, 99);
            this.listViewPlaylists.Name = "listViewPlaylists";
            this.listViewPlaylists.Size = new System.Drawing.Size(318, 342);
            this.listViewPlaylists.TabIndex = 1;
            this.listViewPlaylists.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar Canción";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminarPlaylist
            // 
            this.btnEliminarPlaylist.Location = new System.Drawing.Point(200, 474);
            this.btnEliminarPlaylist.Name = "btnEliminarPlaylist";
            this.btnEliminarPlaylist.Size = new System.Drawing.Size(117, 44);
            this.btnEliminarPlaylist.TabIndex = 3;
            this.btnEliminarPlaylist.Text = "Elimnar Playlist";
            this.btnEliminarPlaylist.UseVisualStyleBackColor = true;
            this.btnEliminarPlaylist.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.listViewCancionesPlaylist);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(362, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(913, 617);
            this.panel2.TabIndex = 1;
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
            // listViewCancionesPlaylist
            // 
            this.listViewCancionesPlaylist.HideSelection = false;
            this.listViewCancionesPlaylist.Location = new System.Drawing.Point(34, 89);
            this.listViewCancionesPlaylist.Name = "listViewCancionesPlaylist";
            this.listViewCancionesPlaylist.Size = new System.Drawing.Size(855, 416);
            this.listViewCancionesPlaylist.TabIndex = 1;
            this.listViewCancionesPlaylist.UseCompatibleStateImageBehavior = false;
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
            this.Load += new System.EventHandler(this.frmPlaylist_Load);
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
    }
}