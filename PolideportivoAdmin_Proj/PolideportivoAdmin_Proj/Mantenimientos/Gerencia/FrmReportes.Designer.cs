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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tbc_Reportes = new MetroFramework.Controls.MetroTabControl();
            this.Tbp_Jugador = new MetroFramework.Controls.MetroTabPage();
            this.Tbp_Suspendidos = new MetroFramework.Controls.MetroTabPage();
            this.Tbp_ResultadosPartidos = new MetroFramework.Controls.MetroTabPage();
            this.Tbp_PosicionesCampeonatos = new MetroFramework.Controls.MetroTabPage();
            this.Btn_Generar_Reporte = new System.Windows.Forms.Button();
            this.Gbx_TipoReporte = new System.Windows.Forms.GroupBox();
            this.Rbtn_Tipo3 = new System.Windows.Forms.RadioButton();
            this.Rbtn_Tipo2 = new System.Windows.Forms.RadioButton();
            this.Rbtn_Tipo1 = new System.Windows.Forms.RadioButton();
            this.Dgv_DatosReporte = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tbp_EquipoCampeonato = new MetroFramework.Controls.MetroTabPage();
            this.Tbp_JugadoreEquipo = new MetroFramework.Controls.MetroTabPage();
            this.Dgv_Suspendidos = new MetroFramework.Controls.MetroGrid();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tbc_Reportes.SuspendLayout();
            this.Tbp_Jugador.SuspendLayout();
            this.Gbx_TipoReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DatosReporte)).BeginInit();
            this.Tbp_EquipoCampeonato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Suspendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // Tbc_Reportes
            // 
            this.Tbc_Reportes.Controls.Add(this.Tbp_Jugador);
            this.Tbc_Reportes.Controls.Add(this.Tbp_Suspendidos);
            this.Tbc_Reportes.Controls.Add(this.Tbp_ResultadosPartidos);
            this.Tbc_Reportes.Controls.Add(this.Tbp_PosicionesCampeonatos);
            this.Tbc_Reportes.Controls.Add(this.Tbp_EquipoCampeonato);
            this.Tbc_Reportes.Controls.Add(this.Tbp_JugadoreEquipo);
            this.Tbc_Reportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Reportes.Location = new System.Drawing.Point(0, 0);
            this.Tbc_Reportes.Name = "Tbc_Reportes";
            this.Tbc_Reportes.SelectedIndex = 4;
            this.Tbc_Reportes.Size = new System.Drawing.Size(914, 523);
            this.Tbc_Reportes.TabIndex = 10;
            this.Tbc_Reportes.UseSelectable = true;
            // 
            // Tbp_Jugador
            // 
            this.Tbp_Jugador.Controls.Add(this.Btn_Generar_Reporte);
            this.Tbp_Jugador.Controls.Add(this.Gbx_TipoReporte);
            this.Tbp_Jugador.Controls.Add(this.Dgv_DatosReporte);
            this.Tbp_Jugador.HorizontalScrollbarBarColor = true;
            this.Tbp_Jugador.HorizontalScrollbarHighlightOnWheel = false;
            this.Tbp_Jugador.HorizontalScrollbarSize = 10;
            this.Tbp_Jugador.Location = new System.Drawing.Point(4, 38);
            this.Tbp_Jugador.Name = "Tbp_Jugador";
            this.Tbp_Jugador.Size = new System.Drawing.Size(906, 481);
            this.Tbp_Jugador.TabIndex = 0;
            this.Tbp_Jugador.Text = "Jugador";
            this.Tbp_Jugador.VerticalScrollbarBarColor = true;
            this.Tbp_Jugador.VerticalScrollbarHighlightOnWheel = false;
            this.Tbp_Jugador.VerticalScrollbarSize = 10;
            // 
            // Tbp_Suspendidos
            // 
            this.Tbp_Suspendidos.HorizontalScrollbarBarColor = true;
            this.Tbp_Suspendidos.HorizontalScrollbarHighlightOnWheel = false;
            this.Tbp_Suspendidos.HorizontalScrollbarSize = 10;
            this.Tbp_Suspendidos.Location = new System.Drawing.Point(4, 38);
            this.Tbp_Suspendidos.Name = "Tbp_Suspendidos";
            this.Tbp_Suspendidos.Size = new System.Drawing.Size(906, 481);
            this.Tbp_Suspendidos.TabIndex = 1;
            this.Tbp_Suspendidos.Text = "Jugadores Suspendidos";
            this.Tbp_Suspendidos.VerticalScrollbarBarColor = true;
            this.Tbp_Suspendidos.VerticalScrollbarHighlightOnWheel = false;
            this.Tbp_Suspendidos.VerticalScrollbarSize = 10;
            // 
            // Tbp_ResultadosPartidos
            // 
            this.Tbp_ResultadosPartidos.HorizontalScrollbarBarColor = true;
            this.Tbp_ResultadosPartidos.HorizontalScrollbarHighlightOnWheel = false;
            this.Tbp_ResultadosPartidos.HorizontalScrollbarSize = 10;
            this.Tbp_ResultadosPartidos.Location = new System.Drawing.Point(4, 38);
            this.Tbp_ResultadosPartidos.Name = "Tbp_ResultadosPartidos";
            this.Tbp_ResultadosPartidos.Size = new System.Drawing.Size(906, 481);
            this.Tbp_ResultadosPartidos.TabIndex = 2;
            this.Tbp_ResultadosPartidos.Text = "Resultados de Partidos";
            this.Tbp_ResultadosPartidos.VerticalScrollbarBarColor = true;
            this.Tbp_ResultadosPartidos.VerticalScrollbarHighlightOnWheel = false;
            this.Tbp_ResultadosPartidos.VerticalScrollbarSize = 10;
            // 
            // Tbp_PosicionesCampeonatos
            // 
            this.Tbp_PosicionesCampeonatos.HorizontalScrollbarBarColor = true;
            this.Tbp_PosicionesCampeonatos.HorizontalScrollbarHighlightOnWheel = false;
            this.Tbp_PosicionesCampeonatos.HorizontalScrollbarSize = 10;
            this.Tbp_PosicionesCampeonatos.Location = new System.Drawing.Point(4, 38);
            this.Tbp_PosicionesCampeonatos.Name = "Tbp_PosicionesCampeonatos";
            this.Tbp_PosicionesCampeonatos.Size = new System.Drawing.Size(906, 481);
            this.Tbp_PosicionesCampeonatos.TabIndex = 3;
            this.Tbp_PosicionesCampeonatos.Text = "Tabla de Posiciones por Campeonato";
            this.Tbp_PosicionesCampeonatos.VerticalScrollbarBarColor = true;
            this.Tbp_PosicionesCampeonatos.VerticalScrollbarHighlightOnWheel = false;
            this.Tbp_PosicionesCampeonatos.VerticalScrollbarSize = 10;
            // 
            // Btn_Generar_Reporte
            // 
            this.Btn_Generar_Reporte.Location = new System.Drawing.Point(594, 260);
            this.Btn_Generar_Reporte.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Generar_Reporte.Name = "Btn_Generar_Reporte";
            this.Btn_Generar_Reporte.Size = new System.Drawing.Size(96, 41);
            this.Btn_Generar_Reporte.TabIndex = 12;
            this.Btn_Generar_Reporte.Text = "Generar Reporte";
            this.Btn_Generar_Reporte.UseVisualStyleBackColor = true;
            // 
            // Gbx_TipoReporte
            // 
            this.Gbx_TipoReporte.BackColor = System.Drawing.SystemColors.Window;
            this.Gbx_TipoReporte.Controls.Add(this.Rbtn_Tipo3);
            this.Gbx_TipoReporte.Controls.Add(this.Rbtn_Tipo2);
            this.Gbx_TipoReporte.Controls.Add(this.Rbtn_Tipo1);
            this.Gbx_TipoReporte.Location = new System.Drawing.Point(594, 66);
            this.Gbx_TipoReporte.Margin = new System.Windows.Forms.Padding(2);
            this.Gbx_TipoReporte.Name = "Gbx_TipoReporte";
            this.Gbx_TipoReporte.Padding = new System.Windows.Forms.Padding(2);
            this.Gbx_TipoReporte.Size = new System.Drawing.Size(96, 125);
            this.Gbx_TipoReporte.TabIndex = 11;
            this.Gbx_TipoReporte.TabStop = false;
            this.Gbx_TipoReporte.Text = "Tipo de Reporte";
            // 
            // Rbtn_Tipo3
            // 
            this.Rbtn_Tipo3.AutoSize = true;
            this.Rbtn_Tipo3.Location = new System.Drawing.Point(11, 96);
            this.Rbtn_Tipo3.Margin = new System.Windows.Forms.Padding(2);
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
            this.Rbtn_Tipo2.Margin = new System.Windows.Forms.Padding(2);
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
            this.Rbtn_Tipo1.Margin = new System.Windows.Forms.Padding(2);
            this.Rbtn_Tipo1.Name = "Rbtn_Tipo1";
            this.Rbtn_Tipo1.Size = new System.Drawing.Size(53, 17);
            this.Rbtn_Tipo1.TabIndex = 0;
            this.Rbtn_Tipo1.TabStop = true;
            this.Rbtn_Tipo1.Text = "Faltas";
            this.Rbtn_Tipo1.UseVisualStyleBackColor = true;
            // 
            // Dgv_DatosReporte
            // 
            this.Dgv_DatosReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_DatosReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.Dgv_DatosReporte.Location = new System.Drawing.Point(107, 66);
            this.Dgv_DatosReporte.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_DatosReporte.Name = "Dgv_DatosReporte";
            this.Dgv_DatosReporte.RowHeadersWidth = 51;
            this.Dgv_DatosReporte.RowTemplate.Height = 24;
            this.Dgv_DatosReporte.Size = new System.Drawing.Size(460, 307);
            this.Dgv_DatosReporte.TabIndex = 10;
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
            // Tbp_EquipoCampeonato
            // 
            this.Tbp_EquipoCampeonato.Controls.Add(this.Dgv_Suspendidos);
            this.Tbp_EquipoCampeonato.HorizontalScrollbarBarColor = true;
            this.Tbp_EquipoCampeonato.HorizontalScrollbarHighlightOnWheel = false;
            this.Tbp_EquipoCampeonato.HorizontalScrollbarSize = 10;
            this.Tbp_EquipoCampeonato.Location = new System.Drawing.Point(4, 38);
            this.Tbp_EquipoCampeonato.Name = "Tbp_EquipoCampeonato";
            this.Tbp_EquipoCampeonato.Size = new System.Drawing.Size(906, 481);
            this.Tbp_EquipoCampeonato.TabIndex = 4;
            this.Tbp_EquipoCampeonato.Text = "Equipos en Campeonato";
            this.Tbp_EquipoCampeonato.VerticalScrollbarBarColor = true;
            this.Tbp_EquipoCampeonato.VerticalScrollbarHighlightOnWheel = false;
            this.Tbp_EquipoCampeonato.VerticalScrollbarSize = 10;
            // 
            // Tbp_JugadoreEquipo
            // 
            this.Tbp_JugadoreEquipo.HorizontalScrollbarBarColor = true;
            this.Tbp_JugadoreEquipo.HorizontalScrollbarHighlightOnWheel = false;
            this.Tbp_JugadoreEquipo.HorizontalScrollbarSize = 10;
            this.Tbp_JugadoreEquipo.Location = new System.Drawing.Point(4, 38);
            this.Tbp_JugadoreEquipo.Name = "Tbp_JugadoreEquipo";
            this.Tbp_JugadoreEquipo.Size = new System.Drawing.Size(906, 481);
            this.Tbp_JugadoreEquipo.TabIndex = 5;
            this.Tbp_JugadoreEquipo.Text = "Jugadores por Equipo";
            this.Tbp_JugadoreEquipo.VerticalScrollbarBarColor = true;
            this.Tbp_JugadoreEquipo.VerticalScrollbarHighlightOnWheel = false;
            this.Tbp_JugadoreEquipo.VerticalScrollbarSize = 10;
            // 
            // Dgv_Suspendidos
            // 
            this.Dgv_Suspendidos.AllowUserToAddRows = false;
            this.Dgv_Suspendidos.AllowUserToDeleteRows = false;
            this.Dgv_Suspendidos.AllowUserToResizeRows = false;
            this.Dgv_Suspendidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Dgv_Suspendidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Suspendidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dgv_Suspendidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Suspendidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Suspendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Suspendidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Suspendidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Suspendidos.EnableHeadersVisualStyles = false;
            this.Dgv_Suspendidos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Dgv_Suspendidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Dgv_Suspendidos.Location = new System.Drawing.Point(-4, 0);
            this.Dgv_Suspendidos.Name = "Dgv_Suspendidos";
            this.Dgv_Suspendidos.ReadOnly = true;
            this.Dgv_Suspendidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Suspendidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Suspendidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgv_Suspendidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Suspendidos.Size = new System.Drawing.Size(589, 478);
            this.Dgv_Suspendidos.TabIndex = 2;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "sdsadsad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(914, 523);
            this.Controls.Add(this.Tbc_Reportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            this.Tbc_Reportes.ResumeLayout(false);
            this.Tbp_Jugador.ResumeLayout(false);
            this.Gbx_TipoReporte.ResumeLayout(false);
            this.Gbx_TipoReporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DatosReporte)).EndInit();
            this.Tbp_EquipoCampeonato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Suspendidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl Tbc_Reportes;
        private MetroFramework.Controls.MetroTabPage Tbp_Jugador;
        private System.Windows.Forms.Button Btn_Generar_Reporte;
        private System.Windows.Forms.GroupBox Gbx_TipoReporte;
        private System.Windows.Forms.RadioButton Rbtn_Tipo3;
        private System.Windows.Forms.RadioButton Rbtn_Tipo2;
        private System.Windows.Forms.RadioButton Rbtn_Tipo1;
        private System.Windows.Forms.DataGridView Dgv_DatosReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private MetroFramework.Controls.MetroTabPage Tbp_Suspendidos;
        private MetroFramework.Controls.MetroTabPage Tbp_ResultadosPartidos;
        private MetroFramework.Controls.MetroTabPage Tbp_PosicionesCampeonatos;
        private MetroFramework.Controls.MetroTabPage Tbp_EquipoCampeonato;
        private MetroFramework.Controls.MetroGrid Dgv_Suspendidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private MetroFramework.Controls.MetroTabPage Tbp_JugadoreEquipo;
    }
}