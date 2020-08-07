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
            this.BtnListadoE = new System.Windows.Forms.Button();
            this.BtnCalendario = new System.Windows.Forms.Button();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.PtbSlider1 = new System.Windows.Forms.PictureBox();
            this.PtbSlider2 = new System.Windows.Forms.PictureBox();
            this.PtbSlider3 = new System.Windows.Forms.PictureBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbSlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbSlider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbSlider3)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnListadoE
            // 
            this.BtnListadoE.FlatAppearance.BorderSize = 0;
            this.BtnListadoE.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnListadoE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListadoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListadoE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnListadoE.Location = new System.Drawing.Point(808, 0);
            this.BtnListadoE.Margin = new System.Windows.Forms.Padding(2);
            this.BtnListadoE.Name = "BtnListadoE";
            this.BtnListadoE.Size = new System.Drawing.Size(176, 35);
            this.BtnListadoE.TabIndex = 3;
            this.BtnListadoE.Text = "Listados De Equipos";
            this.BtnListadoE.UseVisualStyleBackColor = true;
            this.BtnListadoE.Click += new System.EventHandler(this.BtnListadoE_Click);
            // 
            // BtnCalendario
            // 
            this.BtnCalendario.FlatAppearance.BorderSize = 0;
            this.BtnCalendario.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalendario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCalendario.Location = new System.Drawing.Point(635, 0);
            this.BtnCalendario.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCalendario.Name = "BtnCalendario";
            this.BtnCalendario.Size = new System.Drawing.Size(178, 35);
            this.BtnCalendario.TabIndex = 4;
            this.BtnCalendario.Text = "Calendario";
            this.BtnCalendario.UseVisualStyleBackColor = true;
            this.BtnCalendario.Click += new System.EventHandler(this.BtnCalendario_Click);
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(109)))), ((int)(((byte)(163)))));
            this.PanelHeader.Controls.Add(this.BtnCalendario);
            this.PanelHeader.Controls.Add(this.BtnListadoE);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(984, 35);
            this.PanelHeader.TabIndex = 5;
            // 
            // PtbSlider1
            // 
            this.PtbSlider1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PtbSlider1.Image = ((System.Drawing.Image)(resources.GetObject("PtbSlider1.Image")));
            this.PtbSlider1.Location = new System.Drawing.Point(0, 35);
            this.PtbSlider1.Name = "PtbSlider1";
            this.PtbSlider1.Size = new System.Drawing.Size(984, 496);
            this.PtbSlider1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbSlider1.TabIndex = 6;
            this.PtbSlider1.TabStop = false;
            // 
            // PtbSlider2
            // 
            this.PtbSlider2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PtbSlider2.Image = ((System.Drawing.Image)(resources.GetObject("PtbSlider2.Image")));
            this.PtbSlider2.Location = new System.Drawing.Point(0, 35);
            this.PtbSlider2.Name = "PtbSlider2";
            this.PtbSlider2.Size = new System.Drawing.Size(984, 496);
            this.PtbSlider2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbSlider2.TabIndex = 7;
            this.PtbSlider2.TabStop = false;
            // 
            // PtbSlider3
            // 
            this.PtbSlider3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PtbSlider3.Image = ((System.Drawing.Image)(resources.GetObject("PtbSlider3.Image")));
            this.PtbSlider3.Location = new System.Drawing.Point(0, 35);
            this.PtbSlider3.Name = "PtbSlider3";
            this.PtbSlider3.Size = new System.Drawing.Size(984, 496);
            this.PtbSlider3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbSlider3.TabIndex = 8;
            this.PtbSlider3.TabStop = false;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 5000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 531);
            this.Controls.Add(this.PtbSlider3);
            this.Controls.Add(this.PtbSlider2);
            this.Controls.Add(this.PtbSlider1);
            this.Controls.Add(this.PanelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.PanelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbSlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbSlider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbSlider3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnListadoE;
        private System.Windows.Forms.Button BtnCalendario;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.PictureBox PtbSlider1;
        private System.Windows.Forms.PictureBox PtbSlider2;
        private System.Windows.Forms.PictureBox PtbSlider3;
        private System.Windows.Forms.Timer Timer1;
    }
}

