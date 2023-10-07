namespace SpaceInvaders
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.totalProyectiles = new System.Windows.Forms.Label();
            this.textPuntuacio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalProyectiles
            // 
            this.totalProyectiles.AutoSize = true;
            this.totalProyectiles.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.totalProyectiles.Location = new System.Drawing.Point(13, 13);
            this.totalProyectiles.Name = "totalProyectiles";
            this.totalProyectiles.Size = new System.Drawing.Size(44, 16);
            this.totalProyectiles.TabIndex = 0;
            this.totalProyectiles.Text = "label1";
            // 
            // textPuntuacio
            // 
            this.textPuntuacio.AutoSize = true;
            this.textPuntuacio.Location = new System.Drawing.Point(13, 33);
            this.textPuntuacio.Name = "textPuntuacio";
            this.textPuntuacio.Size = new System.Drawing.Size(44, 16);
            this.textPuntuacio.TabIndex = 1;
            this.textPuntuacio.Text = "label1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::SpaceInvaders.Properties.Resources._1280x960_space_invaders_press_start_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textPuntuacio);
            this.Controls.Add(this.totalProyectiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label totalProyectiles;
        private System.Windows.Forms.Label textPuntuacio;
    }
}

