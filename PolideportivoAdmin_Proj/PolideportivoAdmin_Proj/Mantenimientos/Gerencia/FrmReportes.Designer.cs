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
<<<<<<< HEAD
            this.Dgv_DatosReporte = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
=======
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tbc_Reportes = new MetroFramework.Controls.MetroTabControl();
            this.Tbp_Jugador = new MetroFramework.Controls.MetroTabPage();
            this.Tbp_Suspendidos = new MetroFramework.Controls.MetroTabPage();
            this.Tbp_ResultadosPartidos = new MetroFramework.Controls.MetroTabPage();
            this.Tbp_PosicionesCampeonatos = new MetroFramework.Controls.MetroTabPage();
>>>>>>> e136fe018706aa0e462393dbea001106e8bfa1cd
            this.Btn_Generar_Reporte = new System.Windows.Forms.Button();
            this.Gbx_TipoReporte = new System.Windows.Forms.GroupBox();
            this.Rbtn_Tipo3 = new System.Windows.Forms.RadioButton();
            this.Rbtn_Tipo2 = new System.Windows.Forms.RadioButton();
            this.Rbtn_Tipo1 = new System.Windows.Forms.RadioButton();
<<<<<<< HEAD
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DatosReporte)).BeginInit();
=======
            this.Dgv_DatosReporte = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tbp_EquipoCampeonato = new MetroFramework.Controls.MetroTabPage();
            this.Tbp_JugadoreEquipo = new MetroFramework.Controls.MetroTabPage();
            this.Dgv_Suspendidos = new MetroFramework.Controls.MetroGrid();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tbc_Reportes.SuspendLayout();
            this.Tbp_Jugador.SuspendLayout();
>>>>>>> e136fe018706aa0e462393dbea001106e8bfa1cd
            this.Gbx_TipoReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DatosReporte)).BeginInit();
            this.Tbp_EquipoCampeonato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Suspendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // Tbc_Reportes
            // 
<<<<<<< HEAD
            this.Dgv_DatosReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_DatosReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.Dgv_DatosReporte.Location = new System.Drawing.Point(4, 37);
            this.Dgv_DatosReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_DatosReporte.Name = "Dgv_DatosReporte";
            this.Dgv_DatosReporte.RowHeadersWidth = 51;
            this.Dgv_DatosReporte.RowTemplate.Height = 24;
            this.Dgv_DatosReporte.Size = new System.Drawing.Size(677, 378);
            this.Dgv_DatosReporte.TabIndex = 6;
=======
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
>>>>>>> e136fe018706aa0e462393dbea001106e8bfa1cd
            // 
            // Tbp_Jugador
            // 
<<<<<<< HEAD
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
=======
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
>>>>>>> e136fe018706aa0e462393dbea001106e8bfa1cd
            // 
            // Tbp_Suspendidos
            // 
<<<<<<< HEAD
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
=======
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
>>>>>>> e136fe018706aa0e462393dbea001106e8bfa1cd
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Btn_Generar_Reporte
            // 
<<<<<<< HEAD
            this.Btn_Generar_Reporte.Location = new System.Drawing.Point(705, 217);
            this.Btn_Generar_Reporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Generar_Reporte.Name = "Btn_Generar_Reporte";
            this.Btn_Generar_Reporte.Size = new System.Drawing.Size(128, 50);
            this.Btn_Generar_Reporte.TabIndex = 9;
=======
            this.Btn_Generar_Reporte.Location = new System.Drawing.Point(594, 260);
            this.Btn_Generar_Reporte.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Generar_Reporte.Name = "Btn_Generar_Reporte";
            this.Btn_Generar_Reporte.Size = new System.Drawing.Size(96, 41);
            this.Btn_Generar_Reporte.TabIndex = 12;
>>>>>>> e136fe018706aa0e462393dbea001106e8bfa1cd
            this.Btn_Generar_Reporte.Text = "Generar Reporte";
            this.Btn_Generar_Reporte.UseVisualStyleBackColor = true;
            // 
            // Gbx_TipoReporte
            // 
            this.Gbx_TipoReporte.BackColor = System.Drawing.SystemColors.Window;
            this.Gbx_TipoReporte.Controls.Add(this.Rbtn_Tipo3);
            this.Gbx_TipoReporte.Controls.Add(this.Rbtn_Tipo2);
            this.Gbx_TipoReporte.Controls.Add(this.Rbtn_Tipo1);
<<<<<<< HEAD
            this.Gbx_TipoReporte.Location = new System.Drawing.Point(705, 59);
            this.Gbx_TipoReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gbx_TipoReporte.Name = "Gbx_TipoReporte";
            this.Gbx_TipoReporte.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gbx_TipoReporte.Size = new System.Drawing.Size(128, 154);
            this.Gbx_TipoReporte.TabIndex = 8;
=======
            this.Gbx_TipoReporte.Location = new System.Drawing.Point(594, 66);
            this.Gbx_TipoReporte.Margin = new System.Windows.Forms.Padding(2);
            this.Gbx_TipoReporte.Name = "Gbx_TipoReporte";
            this.Gbx_TipoReporte.Padding = new System.Windows.Forms.Padding(2);
            this.Gbx_TipoReporte.Size = new System.Drawing.Size(96, 125);
            this.Gbx_TipoReporte.TabIndex = 11;
>>>>>>> e136fe018706aa0e462393dbea001106e8bfa1cd
            this.Gbx_TipoReporte.TabStop = false;
            this.Gbx_TipoReporte.Text = "Tipo de Reporte";
            // 
            // Rbtn_Tipo3
            // 
            this.Rbtn_Tipo3.AutoSize = true;
<<<<<<< HEAD
            this.Rbtn_Tipo3.Location = new System.Drawing.Point(15, 118);
            this.Rbtn_Tipo3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.Rbtn_Tipo3.Location = new System.Drawing.Point(11, 96);
            this.Rbtn_Tipo3.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> e136fe018706aa0e462393dbea001106e8bfa1cd
            this.Rbtn_Tipo3.Name = "Rbtn_Tipo3";
            this.Rbtn_Tipo3.Size = new System.Drawing.Size(96, 21);
            this.Rbtn_Tipo3.TabIndex = 2;
            this.Rbtn_Tipo3.TabStop = true;
            this.Rbtn_Tipo3.Text = "Jugadores";
            this.Rbtn_Tipo3.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Tipo2
            // 
            this.Rbtn_Tipo2.AutoSize = true;
<<<<<<< HEAD
            this.Rbtn_Tipo2.Location = new System.Drawing.Point(15, 78);
            this.Rbtn_Tipo2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.Rbtn_Tipo2.Location = new System.Drawing.Point(11, 63);
            this.Rbtn_Tipo2.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> e136fe018706aa0e462393dbea001106e8bfa1cd
            this.Rbtn_Tipo2.Name = "Rbtn_Tipo2";
            this.Rbtn_Tipo2.Size = new System.Drawing.Size(81, 21);
            this.Rbtn_Tipo2.TabIndex = 1;
            this.Rbtn_Tipo2.TabStop = true;
            this.Rbtn_Tipo2.Text = "Partidos";
            this.Rbtn_Tipo2.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Tipo1
            // 
            this.Rbtn_Tipo1.AutoSize = true;
<<<<<<< HEAD
            this.Rbtn_Tipo1.Location = new System.Drawing.Point(15, 41);
            this.Rbtn_Tipo1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.Rbtn_Tipo1.Location = new System.Drawing.Point(11, 33);
            this.Rbtn_Tipo1.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> e136fe018706aa0e462393dbea001106e8bfa1cd
            this.Rbtn_Tipo1.Name = "Rbtn_Tipo1";
            this.Rbtn_Tipo1.Size = new System.Drawing.Size(67, 21);
            this.Rbtn_Tipo1.TabIndex = 0;
            this.Rbtn_Tipo1.TabStop = true;
            this.Rbtn_Tipo1.Text = "Faltas";
            this.Rbtn_Tipo1.UseVisualStyleBackColor = true;
            // 
<<<<<<< HEAD
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(901, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 22);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(901, 156);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 22);
            this.textBox2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(928, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id Campeonato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(928, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Inserte id_equipo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(740, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 48);
            this.button1.TabIndex = 14;
            this.button1.Text = "Reporte de Equipos por Campeonato";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(981, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 48);
            this.button2.TabIndex = 15;
            this.button2.Text = "Reporte de jugadores por equipo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(981, 473);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 48);
            this.button3.TabIndex = 16;
            this.button3.Text = "Reporte de posiciones Campeonato";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(740, 473);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 48);
            this.button4.TabIndex = 17;
            this.button4.Text = "Resultados Partidos por Campeonato";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(4, 473);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(205, 48);
            this.button5.TabIndex = 18;
            this.button5.Text = "Reporte Jugadores Suspendidos";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(465, 487);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(205, 48);
            this.button6.TabIndex = 19;
            this.button6.Text = "Reporte jugador";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(928, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Inserte id_ jugador";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(901, 257);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(197, 22);
            this.textBox3.TabIndex = 20;
=======
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
>>>>>>> e136fe018706aa0e462393dbea001106e8bfa1cd
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1219, 644);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btn_Generar_Reporte);
            this.Controls.Add(this.Gbx_TipoReporte);
            this.Controls.Add(this.Dgv_DatosReporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.ClientSize = new System.Drawing.Size(914, 523);
            this.Controls.Add(this.Tbc_Reportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> e136fe018706aa0e462393dbea001106e8bfa1cd
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
            this.PerformLayout();

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.DataGridView Dgv_DatosReporte;
=======
        private MetroFramework.Controls.MetroTabControl Tbc_Reportes;
        private MetroFramework.Controls.MetroTabPage Tbp_Jugador;
>>>>>>> e136fe018706aa0e462393dbea001106e8bfa1cd
        private System.Windows.Forms.Button Btn_Generar_Reporte;
        private System.Windows.Forms.GroupBox Gbx_TipoReporte;
        private System.Windows.Forms.RadioButton Rbtn_Tipo3;
        private System.Windows.Forms.RadioButton Rbtn_Tipo2;
        private System.Windows.Forms.RadioButton Rbtn_Tipo1;
<<<<<<< HEAD
        private System.Windows.Forms.RadioButton Rbtn_Tipo3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
=======
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
>>>>>>> e136fe018706aa0e462393dbea001106e8bfa1cd
    }
}