namespace PolideportivoAdmin_Proj.Mantenimientos.Administración
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.Pnl_Menu = new System.Windows.Forms.Panel();
            this.Btn_Campeonato = new System.Windows.Forms.Button();
            this.Btn_Equipo = new System.Windows.Forms.Button();
            this.Btn_Partido = new System.Windows.Forms.Button();
            this.Btn_Calendario = new System.Windows.Forms.Button();
            this.Btn_Tabla_Posiciones = new System.Windows.Forms.Button();
            this.Pnl_algo = new System.Windows.Forms.Panel();
            this.Pnl_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Menu
            // 
            this.Pnl_Menu.Controls.Add(this.Btn_Tabla_Posiciones);
            this.Pnl_Menu.Controls.Add(this.Btn_Campeonato);
            this.Pnl_Menu.Controls.Add(this.Btn_Equipo);
            this.Pnl_Menu.Controls.Add(this.Btn_Calendario);
            this.Pnl_Menu.Controls.Add(this.Btn_Partido);
            this.Pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Menu.Name = "Pnl_Menu";
            this.Pnl_Menu.Size = new System.Drawing.Size(186, 450);
            this.Pnl_Menu.TabIndex = 0;
            // 
            // Btn_Campeonato
            // 
            this.Btn_Campeonato.Location = new System.Drawing.Point(22, 37);
            this.Btn_Campeonato.Name = "Btn_Campeonato";
            this.Btn_Campeonato.Size = new System.Drawing.Size(138, 23);
            this.Btn_Campeonato.TabIndex = 0;
            this.Btn_Campeonato.Text = "Campeonato";
            this.Btn_Campeonato.UseVisualStyleBackColor = true;
            // 
            // Btn_Equipo
            // 
            this.Btn_Equipo.Location = new System.Drawing.Point(22, 80);
            this.Btn_Equipo.Name = "Btn_Equipo";
            this.Btn_Equipo.Size = new System.Drawing.Size(138, 23);
            this.Btn_Equipo.TabIndex = 1;
            this.Btn_Equipo.Text = "Equipo";
            this.Btn_Equipo.UseVisualStyleBackColor = true;
            // 
            // Btn_Partido
            // 
            this.Btn_Partido.Location = new System.Drawing.Point(22, 129);
            this.Btn_Partido.Name = "Btn_Partido";
            this.Btn_Partido.Size = new System.Drawing.Size(138, 23);
            this.Btn_Partido.TabIndex = 2;
            this.Btn_Partido.Text = "Partido";
            this.Btn_Partido.UseVisualStyleBackColor = true;
            // 
            // Btn_Calendario
            // 
            this.Btn_Calendario.Location = new System.Drawing.Point(22, 178);
            this.Btn_Calendario.Name = "Btn_Calendario";
            this.Btn_Calendario.Size = new System.Drawing.Size(138, 23);
            this.Btn_Calendario.TabIndex = 3;
            this.Btn_Calendario.Text = "Calendario";
            this.Btn_Calendario.UseVisualStyleBackColor = true;
            // 
            // Btn_Tabla_Posiciones
            // 
            this.Btn_Tabla_Posiciones.Location = new System.Drawing.Point(22, 224);
            this.Btn_Tabla_Posiciones.Name = "Btn_Tabla_Posiciones";
            this.Btn_Tabla_Posiciones.Size = new System.Drawing.Size(138, 23);
            this.Btn_Tabla_Posiciones.TabIndex = 4;
            this.Btn_Tabla_Posiciones.Text = "Tabla de Posiciones";
            this.Btn_Tabla_Posiciones.UseVisualStyleBackColor = true;
            // 
            // Pnl_algo
            // 
            this.Pnl_algo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_algo.Location = new System.Drawing.Point(186, 0);
            this.Pnl_algo.Name = "Pnl_algo";
            this.Pnl_algo.Size = new System.Drawing.Size(614, 450);
            this.Pnl_algo.TabIndex = 5;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pnl_algo);
            this.Controls.Add(this.Pnl_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.Pnl_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Menu;
        private System.Windows.Forms.Button Btn_Campeonato;
        private System.Windows.Forms.Button Btn_Equipo;
        private System.Windows.Forms.Button Btn_Partido;
        private System.Windows.Forms.Button Btn_Calendario;
        private System.Windows.Forms.Button Btn_Tabla_Posiciones;
        private System.Windows.Forms.Panel Pnl_algo;
    }
}