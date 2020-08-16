namespace PolideportivoAdmin_Proj
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.PtbUsuario = new System.Windows.Forms.PictureBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblLogin = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.PtbPassword = new System.Windows.Forms.PictureBox();
            this.BtnIngreso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PtbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // PtbUsuario
            // 
            this.PtbUsuario.Image = ((System.Drawing.Image)(resources.GetObject("PtbUsuario.Image")));
            this.PtbUsuario.Location = new System.Drawing.Point(31, 157);
            this.PtbUsuario.Name = "PtbUsuario";
            this.PtbUsuario.Size = new System.Drawing.Size(38, 34);
            this.PtbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtbUsuario.TabIndex = 0;
            this.PtbUsuario.TabStop = false;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(84, 171);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(193, 20);
            this.TxtUsuario.TabIndex = 1;
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.Location = new System.Drawing.Point(120, 33);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(76, 25);
            this.LblLogin.TabIndex = 2;
            this.LblLogin.Text = "LOGIN";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(84, 215);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '■';
            this.TxtPassword.Size = new System.Drawing.Size(193, 20);
            this.TxtPassword.TabIndex = 3;
            // 
            // PtbPassword
            // 
            this.PtbPassword.Image = ((System.Drawing.Image)(resources.GetObject("PtbPassword.Image")));
            this.PtbPassword.Location = new System.Drawing.Point(31, 201);
            this.PtbPassword.Name = "PtbPassword";
            this.PtbPassword.Size = new System.Drawing.Size(38, 34);
            this.PtbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtbPassword.TabIndex = 4;
            this.PtbPassword.TabStop = false;
            // 
            // BtnIngreso
            // 
            this.BtnIngreso.Location = new System.Drawing.Point(125, 297);
            this.BtnIngreso.Name = "BtnIngreso";
            this.BtnIngreso.Size = new System.Drawing.Size(75, 23);
            this.BtnIngreso.TabIndex = 5;
            this.BtnIngreso.Text = "Ingreso";
            this.BtnIngreso.UseVisualStyleBackColor = true;
            this.BtnIngreso.Click += new System.EventHandler(this.BtnIngreso_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(321, 415);
            this.Controls.Add(this.BtnIngreso);
            this.Controls.Add(this.PtbPassword);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.PtbUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.PtbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PtbUsuario;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.PictureBox PtbPassword;
        private System.Windows.Forms.Button BtnIngreso;
    }
}

