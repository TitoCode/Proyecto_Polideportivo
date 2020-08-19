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
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnIngreso = new System.Windows.Forms.Button();
            this.Ptb_Password = new System.Windows.Forms.PictureBox();
            this.Ptb_Usuario = new System.Windows.Forms.PictureBox();
            this.Pnl_Superior = new System.Windows.Forms.Panel();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Lbl_Informacion = new System.Windows.Forms.Label();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Usuario)).BeginInit();
            this.Pnl_Superior.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtUsuario.Location = new System.Drawing.Point(111, 102);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(189, 13);
            this.TxtUsuario.TabIndex = 1;
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtPassword.Location = new System.Drawing.Point(111, 132);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(189, 13);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // BtnIngreso
            // 
            this.BtnIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(194)))));
            this.BtnIngreso.FlatAppearance.BorderSize = 0;
            this.BtnIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngreso.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngreso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnIngreso.Location = new System.Drawing.Point(75, 172);
            this.BtnIngreso.Name = "BtnIngreso";
            this.BtnIngreso.Size = new System.Drawing.Size(234, 31);
            this.BtnIngreso.TabIndex = 3;
            this.BtnIngreso.Text = "Login";
            this.BtnIngreso.UseVisualStyleBackColor = false;
            this.BtnIngreso.Click += new System.EventHandler(this.BtnIngreso_Click);
            // 
            // Ptb_Password
            // 
            this.Ptb_Password.Image = ((System.Drawing.Image)(resources.GetObject("Ptb_Password.Image")));
            this.Ptb_Password.Location = new System.Drawing.Point(81, 121);
            this.Ptb_Password.Name = "Ptb_Password";
            this.Ptb_Password.Size = new System.Drawing.Size(24, 24);
            this.Ptb_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Ptb_Password.TabIndex = 6;
            this.Ptb_Password.TabStop = false;
            // 
            // Ptb_Usuario
            // 
            this.Ptb_Usuario.Image = ((System.Drawing.Image)(resources.GetObject("Ptb_Usuario.Image")));
            this.Ptb_Usuario.Location = new System.Drawing.Point(81, 91);
            this.Ptb_Usuario.Name = "Ptb_Usuario";
            this.Ptb_Usuario.Size = new System.Drawing.Size(24, 24);
            this.Ptb_Usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ptb_Usuario.TabIndex = 7;
            this.Ptb_Usuario.TabStop = false;
            // 
            // Pnl_Superior
            // 
            this.Pnl_Superior.Controls.Add(this.Lbl_Titulo);
            this.Pnl_Superior.Controls.Add(this.Btn_Cerrar);
            this.Pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Superior.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Superior.Name = "Pnl_Superior";
            this.Pnl_Superior.Size = new System.Drawing.Size(389, 32);
            this.Pnl_Superior.TabIndex = 8;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(194)))));
            this.Lbl_Titulo.Location = new System.Drawing.Point(165, 9);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(57, 24);
            this.Lbl_Titulo.TabIndex = 11;
            this.Lbl_Titulo.Text = "Login";
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.Btn_Cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.Btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.Brown;
            this.Btn_Cerrar.Location = new System.Drawing.Point(356, 0);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(33, 32);
            this.Btn_Cerrar.TabIndex = 9;
            this.Btn_Cerrar.Text = "X";
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Lbl_Informacion
            // 
            this.Lbl_Informacion.AutoSize = true;
            this.Lbl_Informacion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Informacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Informacion.Location = new System.Drawing.Point(79, 65);
            this.Lbl_Informacion.Name = "Lbl_Informacion";
            this.Lbl_Informacion.Size = new System.Drawing.Size(152, 13);
            this.Lbl_Informacion.TabIndex = 12;
            this.Lbl_Informacion.Text = "Ingresa Tus Credenciales";
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Btn_Ayuda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.Btn_Ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_Ayuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.Btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ayuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ayuda.ForeColor = System.Drawing.Color.Brown;
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(0, 198);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(33, 32);
            this.Btn_Ayuda.TabIndex = 13;
            this.Btn_Ayuda.UseVisualStyleBackColor = false;
            this.Btn_Ayuda.Click += new System.EventHandler(this.Btn_Ayuda_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(389, 228);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Lbl_Informacion);
            this.Controls.Add(this.Pnl_Superior);
            this.Controls.Add(this.Ptb_Usuario);
            this.Controls.Add(this.Ptb_Password);
            this.Controls.Add(this.BtnIngreso);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Usuario)).EndInit();
            this.Pnl_Superior.ResumeLayout(false);
            this.Pnl_Superior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnIngreso;
        private System.Windows.Forms.PictureBox Ptb_Password;
        private System.Windows.Forms.PictureBox Ptb_Usuario;
        private System.Windows.Forms.Panel Pnl_Superior;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Informacion;
        private System.Windows.Forms.Button Btn_Ayuda;
    }
}

