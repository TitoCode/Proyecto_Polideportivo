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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.BtnListadoJ = new System.Windows.Forms.Button();
            this.BtnCalendario = new System.Windows.Forms.Button();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.BtnListadoE = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.DgvUsuario = new System.Windows.Forms.DataGridView();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnListadoJ
            // 
            this.BtnListadoJ.FlatAppearance.BorderSize = 0;
            this.BtnListadoJ.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnListadoJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListadoJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListadoJ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnListadoJ.Location = new System.Drawing.Point(783, 2);
            this.BtnListadoJ.Margin = new System.Windows.Forms.Padding(2);
            this.BtnListadoJ.Name = "BtnListadoJ";
            this.BtnListadoJ.Size = new System.Drawing.Size(190, 31);
            this.BtnListadoJ.TabIndex = 3;
            this.BtnListadoJ.Text = "Listados De Jugadores";
            this.BtnListadoJ.UseVisualStyleBackColor = true;
            this.BtnListadoJ.Click += new System.EventHandler(this.BtnListadoJ_Click);
            // 
            // BtnCalendario
            // 
            this.BtnCalendario.FlatAppearance.BorderSize = 0;
            this.BtnCalendario.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalendario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCalendario.Location = new System.Drawing.Point(2, 2);
            this.BtnCalendario.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCalendario.Name = "BtnCalendario";
            this.BtnCalendario.Size = new System.Drawing.Size(178, 31);
            this.BtnCalendario.TabIndex = 4;
            this.BtnCalendario.Text = "Calendario";
            this.BtnCalendario.UseVisualStyleBackColor = true;
            this.BtnCalendario.Click += new System.EventHandler(this.BtnCalendario_Click);
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(109)))), ((int)(((byte)(163)))));
            this.PanelHeader.Controls.Add(this.BtnListadoE);
            this.PanelHeader.Controls.Add(this.BtnCalendario);
            this.PanelHeader.Controls.Add(this.BtnListadoJ);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(984, 35);
            this.PanelHeader.TabIndex = 5;
            // 
            // BtnListadoE
            // 
            this.BtnListadoE.FlatAppearance.BorderSize = 0;
            this.BtnListadoE.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnListadoE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListadoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListadoE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnListadoE.Location = new System.Drawing.Point(596, 2);
            this.BtnListadoE.Margin = new System.Windows.Forms.Padding(2);
            this.BtnListadoE.Name = "BtnListadoE";
            this.BtnListadoE.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnListadoE.Size = new System.Drawing.Size(176, 31);
            this.BtnListadoE.TabIndex = 5;
            this.BtnListadoE.Text = "Listados De Equipos";
            this.BtnListadoE.UseVisualStyleBackColor = true;
            this.BtnListadoE.Click += new System.EventHandler(this.BtnListadoE_Click);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 5000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // DgvUsuario
            // 
            this.DgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuario.Location = new System.Drawing.Point(12, 38);
            this.DgvUsuario.Name = "DgvUsuario";
            this.DgvUsuario.Size = new System.Drawing.Size(960, 388);
            this.DgvUsuario.TabIndex = 6;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 531);
            this.Controls.Add(this.DgvUsuario);
            this.Controls.Add(this.PanelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.PanelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnListadoJ;
        private System.Windows.Forms.Button BtnCalendario;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.DataGridView DgvUsuario;
        private System.Windows.Forms.Button BtnListadoE;
    }
}

