namespace Aplicacion_de_Musica
{
    partial class fmrAgregarCancionAPlaylist
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
            this.listViewCancionesDisponibles = new System.Windows.Forms.ListView();
            this.btnAgregarCancion = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listViewCancionesDisponibles
            // 
            this.listViewCancionesDisponibles.HideSelection = false;
            this.listViewCancionesDisponibles.LargeImageList = this.imageList;
            this.listViewCancionesDisponibles.Location = new System.Drawing.Point(93, 25);
            this.listViewCancionesDisponibles.Name = "listViewCancionesDisponibles";
            this.listViewCancionesDisponibles.Size = new System.Drawing.Size(934, 497);
            this.listViewCancionesDisponibles.SmallImageList = this.imageList;
            this.listViewCancionesDisponibles.StateImageList = this.imageList;
            this.listViewCancionesDisponibles.TabIndex = 0;
            this.listViewCancionesDisponibles.UseCompatibleStateImageBehavior = false;
            this.listViewCancionesDisponibles.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnAgregarCancion
            // 
            this.btnAgregarCancion.Location = new System.Drawing.Point(1083, 265);
            this.btnAgregarCancion.Name = "btnAgregarCancion";
            this.btnAgregarCancion.Size = new System.Drawing.Size(234, 77);
            this.btnAgregarCancion.TabIndex = 1;
            this.btnAgregarCancion.Text = "Agregar Cancion";
            this.btnAgregarCancion.UseVisualStyleBackColor = true;
            this.btnAgregarCancion.Click += new System.EventHandler(this.btnAgregarCancion_Click);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(75, 75);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // fmrAgregarCancionAPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 565);
            this.Controls.Add(this.btnAgregarCancion);
            this.Controls.Add(this.listViewCancionesDisponibles);
            this.Name = "fmrAgregarCancionAPlaylist";
            this.Text = "fmrAgregarCancionAPlaylist";
            this.Load += new System.EventHandler(this.fmrAgregarCancionAPlaylist_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewCancionesDisponibles;
        private System.Windows.Forms.Button btnAgregarCancion;
        private System.Windows.Forms.ImageList imageList;
    }
}