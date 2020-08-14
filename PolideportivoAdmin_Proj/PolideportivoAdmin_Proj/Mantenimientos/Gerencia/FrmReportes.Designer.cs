namespace PolideportivoAdmin_Proj.Mantenimientos.Gerencia
{
    partial class FrmReportes
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
            this.Dgv_DatosReporte = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Generar_Reporte = new System.Windows.Forms.Button();
            this.Gbx_TipoReporte = new System.Windows.Forms.GroupBox();
            this.Rbtn_Tipo3 = new System.Windows.Forms.RadioButton();
            this.Rbtn_Tipo2 = new System.Windows.Forms.RadioButton();
            this.Rbtn_Tipo1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DatosReporte)).BeginInit();
            this.Gbx_TipoReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_DatosReporte
            // 
            this.Dgv_DatosReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_DatosReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.Dgv_DatosReporte.Location = new System.Drawing.Point(28, 28);
            this.Dgv_DatosReporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dgv_DatosReporte.Name = "Dgv_DatosReporte";
            this.Dgv_DatosReporte.RowHeadersWidth = 51;
            this.Dgv_DatosReporte.RowTemplate.Height = 24;
            this.Dgv_DatosReporte.Size = new System.Drawing.Size(460, 307);
            this.Dgv_DatosReporte.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Btn_Generar_Reporte
            // 
            this.Btn_Generar_Reporte.Location = new System.Drawing.Point(529, 242);
            this.Btn_Generar_Reporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Generar_Reporte.Name = "Btn_Generar_Reporte";
            this.Btn_Generar_Reporte.Size = new System.Drawing.Size(96, 41);
            this.Btn_Generar_Reporte.TabIndex = 9;
            this.Btn_Generar_Reporte.Text = "Generar Reporte";
            this.Btn_Generar_Reporte.UseVisualStyleBackColor = true;
            this.Btn_Generar_Reporte.Click += new System.EventHandler(this.Btn_Generar_Reporte_Click);
            // 
            // Gbx_TipoReporte
            // 
            this.Gbx_TipoReporte.BackColor = System.Drawing.SystemColors.Window;
            this.Gbx_TipoReporte.Controls.Add(this.Rbtn_Tipo3);
            this.Gbx_TipoReporte.Controls.Add(this.Rbtn_Tipo2);
            this.Gbx_TipoReporte.Controls.Add(this.Rbtn_Tipo1);
            this.Gbx_TipoReporte.Location = new System.Drawing.Point(529, 48);
            this.Gbx_TipoReporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gbx_TipoReporte.Name = "Gbx_TipoReporte";
            this.Gbx_TipoReporte.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gbx_TipoReporte.Size = new System.Drawing.Size(96, 125);
            this.Gbx_TipoReporte.TabIndex = 8;
            this.Gbx_TipoReporte.TabStop = false;
            this.Gbx_TipoReporte.Text = "Tipo de Reporte";
            // 
            // Rbtn_Tipo3
            // 
            this.Rbtn_Tipo3.AutoSize = true;
            this.Rbtn_Tipo3.Location = new System.Drawing.Point(11, 96);
            this.Rbtn_Tipo3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rbtn_Tipo3.Name = "Rbtn_Tipo3";
            this.Rbtn_Tipo3.Size = new System.Drawing.Size(74, 17);
            this.Rbtn_Tipo3.TabIndex = 2;
            this.Rbtn_Tipo3.TabStop = true;
            this.Rbtn_Tipo3.Text = "Jugadores";
            this.Rbtn_Tipo3.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Tipo2
            // 
            this.Rbtn_Tipo2.AutoSize = true;
            this.Rbtn_Tipo2.Location = new System.Drawing.Point(11, 63);
            this.Rbtn_Tipo2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rbtn_Tipo2.Name = "Rbtn_Tipo2";
            this.Rbtn_Tipo2.Size = new System.Drawing.Size(63, 17);
            this.Rbtn_Tipo2.TabIndex = 1;
            this.Rbtn_Tipo2.TabStop = true;
            this.Rbtn_Tipo2.Text = "Partidos";
            this.Rbtn_Tipo2.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Tipo1
            // 
            this.Rbtn_Tipo1.AutoSize = true;
            this.Rbtn_Tipo1.Location = new System.Drawing.Point(11, 33);
            this.Rbtn_Tipo1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rbtn_Tipo1.Name = "Rbtn_Tipo1";
            this.Rbtn_Tipo1.Size = new System.Drawing.Size(53, 17);
            this.Rbtn_Tipo1.TabIndex = 0;
            this.Rbtn_Tipo1.TabStop = true;
            this.Rbtn_Tipo1.Text = "Faltas";
            this.Rbtn_Tipo1.UseVisualStyleBackColor = true;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(914, 523);
            this.Controls.Add(this.Btn_Generar_Reporte);
            this.Controls.Add(this.Gbx_TipoReporte);
            this.Controls.Add(this.Dgv_DatosReporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DatosReporte)).EndInit();
            this.Gbx_TipoReporte.ResumeLayout(false);
            this.Gbx_TipoReporte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_DatosReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button Btn_Generar_Reporte;
        private System.Windows.Forms.GroupBox Gbx_TipoReporte;
        private System.Windows.Forms.RadioButton Rbtn_Tipo2;
        private System.Windows.Forms.RadioButton Rbtn_Tipo1;
        private System.Windows.Forms.RadioButton Rbtn_Tipo3;
    }
}