namespace PolideportivoUsuario_Proj
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.PnlGeneral = new MaterialSkin.Controls.MaterialTabControl();
            this.TbpInicio = new System.Windows.Forms.TabPage();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Lbl_Hora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbpJugadores = new System.Windows.Forms.TabPage();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LsvJugadores = new MaterialSkin.Controls.MaterialListView();
            this.ClmhJugador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmhEquipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmhPosicion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmhEstadoJugador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TbpEquipos = new System.Windows.Forms.TabPage();
            this.BtnConsultaEquipo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LsvEquipos = new MaterialSkin.Controls.MaterialListView();
            this.ClmhEquipoS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmhEntrenador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmhDepo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmhEstadoE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TbpCalendario = new System.Windows.Forms.TabPage();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.TmrInicio = new System.Windows.Forms.Timer(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.PnlGeneral.SuspendLayout();
            this.TbpInicio.SuspendLayout();
            this.TbpJugadores.SuspendLayout();
            this.TbpEquipos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector2.BaseTabControl = this.PnlGeneral;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Location = new System.Drawing.Point(-18, 63);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(1063, 33);
            this.materialTabSelector2.TabIndex = 19;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // PnlGeneral
            // 
            this.PnlGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlGeneral.Controls.Add(this.TbpInicio);
            this.PnlGeneral.Controls.Add(this.TbpJugadores);
            this.PnlGeneral.Controls.Add(this.TbpEquipos);
            this.PnlGeneral.Controls.Add(this.TbpCalendario);
            this.PnlGeneral.Controls.Add(this.tabPage1);
            this.PnlGeneral.Depth = 0;
            this.PnlGeneral.Location = new System.Drawing.Point(-2, 93);
            this.PnlGeneral.MouseState = MaterialSkin.MouseState.HOVER;
            this.PnlGeneral.Name = "PnlGeneral";
            this.PnlGeneral.SelectedIndex = 0;
            this.PnlGeneral.Size = new System.Drawing.Size(1026, 507);
            this.PnlGeneral.TabIndex = 20;
            // 
            // TbpInicio
            // 
            this.TbpInicio.Controls.Add(this.Lbl_Fecha);
            this.TbpInicio.Controls.Add(this.Lbl_Hora);
            this.TbpInicio.Controls.Add(this.label1);
            this.TbpInicio.Location = new System.Drawing.Point(4, 22);
            this.TbpInicio.Name = "TbpInicio";
            this.TbpInicio.Padding = new System.Windows.Forms.Padding(3);
            this.TbpInicio.Size = new System.Drawing.Size(1018, 481);
            this.TbpInicio.TabIndex = 5;
            this.TbpInicio.Text = "Inicio";
            this.TbpInicio.UseVisualStyleBackColor = true;
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.Lbl_Fecha.Location = new System.Drawing.Point(21, 447);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(79, 29);
            this.Lbl_Fecha.TabIndex = 1;
            this.Lbl_Fecha.Text = "label1";
            this.Lbl_Fecha.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Lbl_Hora
            // 
            this.Lbl_Hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Hora.AutoSize = true;
            this.Lbl_Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.Lbl_Hora.Location = new System.Drawing.Point(6, 329);
            this.Lbl_Hora.Name = "Lbl_Hora";
            this.Lbl_Hora.Size = new System.Drawing.Size(344, 120);
            this.Lbl_Hora.TabIndex = 0;
            this.Lbl_Hora.Text = "label1";
            this.Lbl_Hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1012, 475);
            this.label1.TabIndex = 2;
            // 
            // TbpJugadores
            // 
            this.TbpJugadores.BackColor = System.Drawing.Color.White;
            this.TbpJugadores.Controls.Add(this.materialRaisedButton2);
            this.TbpJugadores.Controls.Add(this.LsvJugadores);
            this.TbpJugadores.Location = new System.Drawing.Point(4, 22);
            this.TbpJugadores.Name = "TbpJugadores";
            this.TbpJugadores.Padding = new System.Windows.Forms.Padding(3);
            this.TbpJugadores.Size = new System.Drawing.Size(1018, 481);
            this.TbpJugadores.TabIndex = 0;
            this.TbpJugadores.Text = "Jugadores";
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(3, 442);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(1012, 36);
            this.materialRaisedButton2.TabIndex = 7;
            this.materialRaisedButton2.Text = "Consultar";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click_1);
            // 
            // LsvJugadores
            // 
            this.LsvJugadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsvJugadores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClmhJugador,
            this.ClmhEquipo,
            this.ClmhPosicion,
            this.ClmhEstadoJugador});
            this.LsvJugadores.Cursor = System.Windows.Forms.Cursors.Default;
            this.LsvJugadores.Depth = 0;
            this.LsvJugadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LsvJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.LsvJugadores.FullRowSelect = true;
            this.LsvJugadores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LsvJugadores.HideSelection = false;
            this.LsvJugadores.Location = new System.Drawing.Point(3, 3);
            this.LsvJugadores.MouseLocation = new System.Drawing.Point(-1, -1);
            this.LsvJugadores.MouseState = MaterialSkin.MouseState.OUT;
            this.LsvJugadores.Name = "LsvJugadores";
            this.LsvJugadores.OwnerDraw = true;
            this.LsvJugadores.Size = new System.Drawing.Size(1012, 475);
            this.LsvJugadores.TabIndex = 4;
            this.LsvJugadores.UseCompatibleStateImageBehavior = false;
            this.LsvJugadores.View = System.Windows.Forms.View.Details;
            // 
            // ClmhJugador
            // 
            this.ClmhJugador.Text = "Jugador";
            this.ClmhJugador.Width = 450;
            // 
            // ClmhEquipo
            // 
            this.ClmhEquipo.Text = "Equipo";
            this.ClmhEquipo.Width = 189;
            // 
            // ClmhPosicion
            // 
            this.ClmhPosicion.Text = "Posición";
            this.ClmhPosicion.Width = 190;
            // 
            // ClmhEstadoJugador
            // 
            this.ClmhEstadoJugador.Text = "Estado";
            this.ClmhEstadoJugador.Width = 1000;
            // 
            // TbpEquipos
            // 
            this.TbpEquipos.Controls.Add(this.BtnConsultaEquipo);
            this.TbpEquipos.Controls.Add(this.LsvEquipos);
            this.TbpEquipos.Location = new System.Drawing.Point(4, 22);
            this.TbpEquipos.Name = "TbpEquipos";
            this.TbpEquipos.Padding = new System.Windows.Forms.Padding(3);
            this.TbpEquipos.Size = new System.Drawing.Size(1018, 481);
            this.TbpEquipos.TabIndex = 3;
            this.TbpEquipos.Text = "Equipos";
            this.TbpEquipos.UseVisualStyleBackColor = true;
            // 
            // BtnConsultaEquipo
            // 
            this.BtnConsultaEquipo.AutoSize = true;
            this.BtnConsultaEquipo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnConsultaEquipo.Depth = 0;
            this.BtnConsultaEquipo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnConsultaEquipo.Icon = null;
            this.BtnConsultaEquipo.Location = new System.Drawing.Point(3, 442);
            this.BtnConsultaEquipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnConsultaEquipo.Name = "BtnConsultaEquipo";
            this.BtnConsultaEquipo.Primary = true;
            this.BtnConsultaEquipo.Size = new System.Drawing.Size(1012, 36);
            this.BtnConsultaEquipo.TabIndex = 6;
            this.BtnConsultaEquipo.Text = "Consultar";
            this.BtnConsultaEquipo.UseVisualStyleBackColor = true;
            this.BtnConsultaEquipo.Click += new System.EventHandler(this.BtnConsultaEquipo_Click);
            // 
            // LsvEquipos
            // 
            this.LsvEquipos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsvEquipos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClmhEquipoS,
            this.ClmhEntrenador,
            this.ClmhDepo,
            this.ClmhEstadoE});
            this.LsvEquipos.Cursor = System.Windows.Forms.Cursors.Default;
            this.LsvEquipos.Depth = 0;
            this.LsvEquipos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LsvEquipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.LsvEquipos.FullRowSelect = true;
            this.LsvEquipos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LsvEquipos.HideSelection = false;
            this.LsvEquipos.Location = new System.Drawing.Point(3, 3);
            this.LsvEquipos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.LsvEquipos.MouseState = MaterialSkin.MouseState.OUT;
            this.LsvEquipos.Name = "LsvEquipos";
            this.LsvEquipos.OwnerDraw = true;
            this.LsvEquipos.Size = new System.Drawing.Size(1012, 475);
            this.LsvEquipos.TabIndex = 5;
            this.LsvEquipos.UseCompatibleStateImageBehavior = false;
            this.LsvEquipos.View = System.Windows.Forms.View.Details;
            // 
            // ClmhEquipoS
            // 
            this.ClmhEquipoS.Text = "Equipo";
            this.ClmhEquipoS.Width = 150;
            // 
            // ClmhEntrenador
            // 
            this.ClmhEntrenador.Text = "Entrenador";
            this.ClmhEntrenador.Width = 190;
            // 
            // ClmhDepo
            // 
            this.ClmhDepo.Text = "Deporte";
            this.ClmhDepo.Width = 150;
            // 
            // ClmhEstadoE
            // 
            this.ClmhEstadoE.Text = "Estado";
            this.ClmhEstadoE.Width = 1000;
            // 
            // TbpCalendario
            // 
            this.TbpCalendario.Location = new System.Drawing.Point(4, 22);
            this.TbpCalendario.Name = "TbpCalendario";
            this.TbpCalendario.Padding = new System.Windows.Forms.Padding(3);
            this.TbpCalendario.Size = new System.Drawing.Size(1018, 481);
            this.TbpCalendario.TabIndex = 4;
            this.TbpCalendario.Text = "Calendario";
            this.TbpCalendario.UseVisualStyleBackColor = true;
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-2, 564);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1047, 1);
            this.materialDivider1.TabIndex = 17;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // TmrInicio
            // 
            this.TmrInicio.Enabled = true;
            this.TmrInicio.Interval = 1;
            this.TmrInicio.Tick += new System.EventHandler(this.TmrInicio_Tick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialTabSelector1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1018, 481);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = null;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(10, 6);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(799, 23);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.PnlGeneral);
            this.Controls.Add(this.materialTabSelector2);
            this.Controls.Add(this.materialDivider1);
            this.Name = "FrmMain";
            this.Text = "Polideportivo";
            this.PnlGeneral.ResumeLayout(false);
            this.TbpInicio.ResumeLayout(false);
            this.TbpInicio.PerformLayout();
            this.TbpJugadores.ResumeLayout(false);
            this.TbpJugadores.PerformLayout();
            this.TbpEquipos.ResumeLayout(false);
            this.TbpEquipos.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private MaterialSkin.Controls.MaterialTabControl PnlGeneral;
        private System.Windows.Forms.TabPage TbpJugadores;
        private System.Windows.Forms.TabPage TbpEquipos;
        private System.Windows.Forms.TabPage TbpCalendario;
        private System.Windows.Forms.TabPage TbpInicio;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.Timer TmrInicio;
        private System.Windows.Forms.Label Lbl_Hora;
        private System.Windows.Forms.Label Lbl_Fecha;
        private MaterialSkin.Controls.MaterialRaisedButton BtnConsultaEquipo;
        private MaterialSkin.Controls.MaterialListView LsvEquipos;
        private System.Windows.Forms.ColumnHeader ClmhEquipoS;
        private System.Windows.Forms.ColumnHeader ClmhEntrenador;
        private System.Windows.Forms.ColumnHeader ClmhDepo;
        private System.Windows.Forms.ColumnHeader ClmhEstadoE;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialListView LsvJugadores;
        private System.Windows.Forms.ColumnHeader ClmhJugador;
        private System.Windows.Forms.ColumnHeader ClmhEquipo;
        private System.Windows.Forms.ColumnHeader ClmhPosicion;
        private System.Windows.Forms.ColumnHeader ClmhEstadoJugador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
    }
}

