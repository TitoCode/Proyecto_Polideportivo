namespace PolideportivoAdmin_Proj.Mantenimientos.Gerencia
{
    partial class FrmUsuario
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
            this.Ptb_Foto = new System.Windows.Forms.PictureBox();
            this.Lbl_Usuario = new MetroFramework.Controls.MetroLabel();
            this.Lbl_Password = new MetroFramework.Controls.MetroLabel();
            this.Btn_Guardar = new MetroFramework.Controls.MetroButton();
            this.Btn_Seleccionar = new MetroFramework.Controls.MetroButton();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // Ptb_Foto
            // 
            this.Ptb_Foto.Location = new System.Drawing.Point(564, 155);
            this.Ptb_Foto.Name = "Ptb_Foto";
            this.Ptb_Foto.Size = new System.Drawing.Size(221, 239);
            this.Ptb_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ptb_Foto.TabIndex = 0;
            this.Ptb_Foto.TabStop = false;
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Location = new System.Drawing.Point(93, 198);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(126, 19);
            this.Lbl_Usuario.TabIndex = 1;
            this.Lbl_Usuario.Text = "Nombre de Usuario";
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Location = new System.Drawing.Point(93, 285);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(75, 19);
            this.Lbl_Password.TabIndex = 2;
            this.Lbl_Password.Text = "Contraseña";
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(189, 414);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(122, 39);
            this.Btn_Guardar.TabIndex = 7;
            this.Btn_Guardar.Text = "GUARDAR";
            this.Btn_Guardar.UseSelectable = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Seleccionar
            // 
            this.Btn_Seleccionar.Location = new System.Drawing.Point(602, 414);
            this.Btn_Seleccionar.Name = "Btn_Seleccionar";
            this.Btn_Seleccionar.Size = new System.Drawing.Size(150, 39);
            this.Btn_Seleccionar.TabIndex = 8;
            this.Btn_Seleccionar.Text = "CAMBIAR FOTOGRAFÍA";
            this.Btn_Seleccionar.UseSelectable = true;
            this.Btn_Seleccionar.Click += new System.EventHandler(this.Btn_Seleccionar_Click);
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Usuario.Location = new System.Drawing.Point(93, 231);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(298, 13);
            this.Txt_Usuario.TabIndex = 10;
            // 
            // Txt_Password
            // 
            this.Txt_Password.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Password.Location = new System.Drawing.Point(93, 317);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(298, 13);
            this.Txt_Password.TabIndex = 11;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(337, 77);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(221, 18);
            this.Lbl_Titulo.TabIndex = 12;
            this.Lbl_Titulo.Text = "Cambiar Datos de Usuario";
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(914, 523);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.Btn_Seleccionar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.Ptb_Foto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ptb_Foto;
        private MetroFramework.Controls.MetroLabel Lbl_Usuario;
        private MetroFramework.Controls.MetroLabel Lbl_Password;
        private MetroFramework.Controls.MetroButton Btn_Guardar;
        private MetroFramework.Controls.MetroButton Btn_Seleccionar;
        private System.Windows.Forms.Label Lbl_Titulo;
        public System.Windows.Forms.TextBox Txt_Usuario;
        public System.Windows.Forms.TextBox Txt_Password;
    }
}