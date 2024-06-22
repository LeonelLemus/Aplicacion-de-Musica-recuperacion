namespace Aplicacion_de_Musica
{
    partial class frmCrearPLaylist
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombrePlaylist = new System.Windows.Forms.TextBox();
            this.btnCrearPlaylist = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Playlist:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Crear Playlist";
            // 
            // txtNombrePlaylist
            // 
            this.txtNombrePlaylist.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombrePlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombrePlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePlaylist.Location = new System.Drawing.Point(66, 119);
            this.txtNombrePlaylist.Name = "txtNombrePlaylist";
            this.txtNombrePlaylist.Size = new System.Drawing.Size(247, 20);
            this.txtNombrePlaylist.TabIndex = 2;
            // 
            // btnCrearPlaylist
            // 
            this.btnCrearPlaylist.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCrearPlaylist.FlatAppearance.BorderSize = 3;
            this.btnCrearPlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCrearPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnCrearPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPlaylist.Location = new System.Drawing.Point(105, 193);
            this.btnCrearPlaylist.Name = "btnCrearPlaylist";
            this.btnCrearPlaylist.Size = new System.Drawing.Size(188, 47);
            this.btnCrearPlaylist.TabIndex = 3;
            this.btnCrearPlaylist.Text = "Crear";
            this.btnCrearPlaylist.UseVisualStyleBackColor = true;
            this.btnCrearPlaylist.Click += new System.EventHandler(this.btnCrearPlaylist_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(67, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 1);
            this.panel1.TabIndex = 4;
            // 
            // frmCrearPLaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 445);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCrearPlaylist);
            this.Controls.Add(this.txtNombrePlaylist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmCrearPLaylist";
            this.Text = "CrearPLaylist";
            this.Load += new System.EventHandler(this.frmCrearPLaylist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombrePlaylist;
        private System.Windows.Forms.Button btnCrearPlaylist;
        private System.Windows.Forms.Panel panel1;
    }
}