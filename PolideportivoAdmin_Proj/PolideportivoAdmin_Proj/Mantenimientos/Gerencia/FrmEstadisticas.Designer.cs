namespace PolideportivoAdmin_Proj.Mantenimientos.Gerencia
{
    partial class FrmEstadisticas
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
            this.Tbc_Estadistica = new MetroFramework.Controls.MetroTabControl();
            this.Tbp_Estadistica = new MetroFramework.Controls.MetroTabPage();
            this.Tbc_Estadistica.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbc_Estadistica
            // 
            this.Tbc_Estadistica.Controls.Add(this.Tbp_Estadistica);
            this.Tbc_Estadistica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Estadistica.Location = new System.Drawing.Point(0, 0);
            this.Tbc_Estadistica.Name = "Tbc_Estadistica";
            this.Tbc_Estadistica.SelectedIndex = 0;
            this.Tbc_Estadistica.Size = new System.Drawing.Size(914, 523);
            this.Tbc_Estadistica.TabIndex = 0;
            this.Tbc_Estadistica.UseSelectable = true;
            // 
            // Tbp_Estadistica
            // 
            this.Tbp_Estadistica.HorizontalScrollbarBarColor = true;
            this.Tbp_Estadistica.HorizontalScrollbarHighlightOnWheel = false;
            this.Tbp_Estadistica.HorizontalScrollbarSize = 10;
            this.Tbp_Estadistica.Location = new System.Drawing.Point(4, 38);
            this.Tbp_Estadistica.Name = "Tbp_Estadistica";
            this.Tbp_Estadistica.Size = new System.Drawing.Size(906, 481);
            this.Tbp_Estadistica.TabIndex = 0;
            this.Tbp_Estadistica.Text = "Estadisticas";
            this.Tbp_Estadistica.VerticalScrollbarBarColor = true;
            this.Tbp_Estadistica.VerticalScrollbarHighlightOnWheel = false;
            this.Tbp_Estadistica.VerticalScrollbarSize = 10;
            // 
            // FrmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(914, 523);
            this.Controls.Add(this.Tbc_Estadistica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstadisticas";
            this.Text = "FrmEstadisticas";
            this.Tbc_Estadistica.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl Tbc_Estadistica;
        private MetroFramework.Controls.MetroTabPage Tbp_Estadistica;
    }
}