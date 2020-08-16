namespace PolideportivoAdmin_Proj.Mantenimientos
{
    partial class FrmBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBase));
            this.Tmr_HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.Lbl_Hora = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Ptb_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Tmr_HoraFecha
            // 
            this.Tmr_HoraFecha.Enabled = true;
            this.Tmr_HoraFecha.Tick += new System.EventHandler(this.Tmr_HoraFecha_Tick);
            // 
            // Lbl_Hora
            // 
            this.Lbl_Hora.AutoSize = true;
            this.Lbl_Hora.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Hora.Font = new System.Drawing.Font("Century Gothic", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));

            this.Lbl_Hora.Location = new System.Drawing.Point(285, 389);

            this.Lbl_Hora.Location = new System.Drawing.Point(327, 387);

            this.Lbl_Hora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Hora.Name = "Lbl_Hora";
            this.Lbl_Hora.Size = new System.Drawing.Size(0, 161);
            this.Lbl_Hora.TabIndex = 36;
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));

            this.Lbl_Fecha.Location = new System.Drawing.Point(265, 548);

            this.Lbl_Fecha.Location = new System.Drawing.Point(313, 536);

            this.Lbl_Fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(0, 51);
            this.Lbl_Fecha.TabIndex = 37;
            // 
            // Ptb_Logo
            // 
            this.Ptb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Ptb_Logo.Image")));
            this.Ptb_Logo.Location = new System.Drawing.Point(405, 46);
            this.Ptb_Logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ptb_Logo.Name = "Ptb_Logo";
            this.Ptb_Logo.Size = new System.Drawing.Size(413, 340);
            this.Ptb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ptb_Logo.TabIndex = 38;
            this.Ptb_Logo.TabStop = false;
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1219, 644);
            this.Controls.Add(this.Ptb_Logo);
            this.Controls.Add(this.Lbl_Fecha);
            this.Controls.Add(this.Lbl_Hora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmBase";
            this.Text = "FrmBase";
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Tmr_HoraFecha;
        private System.Windows.Forms.Label Lbl_Hora;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.PictureBox Ptb_Logo;
    }
}