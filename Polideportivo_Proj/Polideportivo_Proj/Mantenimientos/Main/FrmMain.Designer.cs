namespace Polideportivo_Proj
{
    partial class FrmMain
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
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnListadoE = new System.Windows.Forms.Button();
            this.BtnCalendario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(710, 337);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(166, 36);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Log in";
            this.BtnLogin.UseVisualStyleBackColor = true;
            // 
            // BtnListadoE
            // 
            this.BtnListadoE.FlatAppearance.BorderSize = 0;
            this.BtnListadoE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnListadoE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListadoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListadoE.Location = new System.Drawing.Point(493, 337);
            this.BtnListadoE.Name = "BtnListadoE";
            this.BtnListadoE.Size = new System.Drawing.Size(211, 36);
            this.BtnListadoE.TabIndex = 3;
            this.BtnListadoE.Text = "Listados De Equipos";
            this.BtnListadoE.UseVisualStyleBackColor = true;
            this.BtnListadoE.Click += new System.EventHandler(this.BtnListadoE_Click);
            // 
            // BtnCalendario
            // 
            this.BtnCalendario.FlatAppearance.BorderSize = 0;
            this.BtnCalendario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalendario.Location = new System.Drawing.Point(276, 337);
            this.BtnCalendario.Name = "BtnCalendario";
            this.BtnCalendario.Size = new System.Drawing.Size(211, 36);
            this.BtnCalendario.TabIndex = 4;
            this.BtnCalendario.Text = "Calendario";
            this.BtnCalendario.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 39);
            this.panel1.TabIndex = 5;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(993, 494);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnCalendario);
            this.Controls.Add(this.BtnListadoE);
            this.Controls.Add(this.BtnLogin);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnListadoE;
        private System.Windows.Forms.Button BtnCalendario;
        private System.Windows.Forms.Panel panel1;
    }
}

