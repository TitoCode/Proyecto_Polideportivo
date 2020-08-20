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
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.TbcPrincipal = new MaterialSkin.Controls.MaterialTabControl();
            this.TbpInicio = new System.Windows.Forms.TabPage();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Lbl_Hora = new System.Windows.Forms.Label();
            this.LblLogo = new System.Windows.Forms.Label();
            this.TbpJugadores = new System.Windows.Forms.TabPage();
            this.BtnConsultaJu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LsvJugadores = new MaterialSkin.Controls.MaterialListView();
            this.ClmhJugador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmhEquipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmhPosicion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmhEstadoJugador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TbpEquipo = new System.Windows.Forms.TabPage();
            this.BtnConsultaEquipo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LsvEquipos = new MaterialSkin.Controls.MaterialListView();
            this.ClmhEquipoS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmhEntrenador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmhDepo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmhEstadoE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TbpCalendario = new System.Windows.Forms.TabPage();
            this.TbpPartido = new System.Windows.Forms.TabPage();
            this.LblEstadoP = new System.Windows.Forms.Label();
            this.LsvSanciones = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LsvMejorJugador = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LblEncabezadoRP = new System.Windows.Forms.Label();
            this.LblEncabezadoEstado = new System.Windows.Forms.Label();
            this.LblJugadoresSancionados = new System.Windows.Forms.Label();
            this.LblMejorJugador = new System.Windows.Forms.Label();
            this.BtnBusquedaTorneo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtBusquedaTorneo = new System.Windows.Forms.TextBox();
            this.LsvVisitante = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LblVisitante = new System.Windows.Forms.Label();
            this.LblLocal = new System.Windows.Forms.Label();
            this.LsvLocal = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TmrInicio = new System.Windows.Forms.Timer(this.components);
            this.LblResultadoP = new System.Windows.Forms.Label();
            this.LblBienvenida = new System.Windows.Forms.Label();
            this.LsvCalendario = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TmrCalendario = new System.Windows.Forms.Timer(this.components);
            this.BtnAyuda = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TbcPrincipal.SuspendLayout();
            this.TbpInicio.SuspendLayout();
            this.TbpJugadores.SuspendLayout();
            this.TbpEquipo.SuspendLayout();
            this.TbpCalendario.SuspendLayout();
            this.TbpPartido.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.TbcPrincipal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(118, 31);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(830, 29);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // TbcPrincipal
            // 
            this.TbcPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbcPrincipal.Controls.Add(this.TbpInicio);
            this.TbcPrincipal.Controls.Add(this.TbpJugadores);
            this.TbcPrincipal.Controls.Add(this.TbpEquipo);
            this.TbcPrincipal.Controls.Add(this.TbpPartido);
            this.TbcPrincipal.Controls.Add(this.TbpCalendario);
            this.TbcPrincipal.Depth = 0;
            this.TbcPrincipal.Location = new System.Drawing.Point(1, 66);
            this.TbcPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbcPrincipal.Name = "TbcPrincipal";
            this.TbcPrincipal.SelectedIndex = 0;
            this.TbcPrincipal.Size = new System.Drawing.Size(1022, 701);
            this.TbcPrincipal.TabIndex = 1;
            // 
            // TbpInicio
            // 
            this.TbpInicio.Controls.Add(this.Lbl_Fecha);
            this.TbpInicio.Controls.Add(this.Lbl_Hora);
            this.TbpInicio.Controls.Add(this.LblLogo);
            this.TbpInicio.Location = new System.Drawing.Point(4, 22);
            this.TbpInicio.Name = "TbpInicio";
            this.TbpInicio.Padding = new System.Windows.Forms.Padding(3);
            this.TbpInicio.Size = new System.Drawing.Size(1014, 675);
            this.TbpInicio.TabIndex = 0;
            this.TbpInicio.Text = "Inicio";
            this.TbpInicio.UseVisualStyleBackColor = true;
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.Lbl_Fecha.Location = new System.Drawing.Point(22, 639);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(79, 29);
            this.Lbl_Fecha.TabIndex = 3;
            this.Lbl_Fecha.Text = "label1";
            this.Lbl_Fecha.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Lbl_Hora
            // 
            this.Lbl_Hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Hora.AutoSize = true;
            this.Lbl_Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.Lbl_Hora.Location = new System.Drawing.Point(7, 521);
            this.Lbl_Hora.Name = "Lbl_Hora";
            this.Lbl_Hora.Size = new System.Drawing.Size(344, 120);
            this.Lbl_Hora.TabIndex = 2;
            this.Lbl_Hora.Text = "label1";
            this.Lbl_Hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblLogo
            // 
            this.LblLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblLogo.Image = ((System.Drawing.Image)(resources.GetObject("LblLogo.Image")));
            this.LblLogo.Location = new System.Drawing.Point(3, 3);
            this.LblLogo.Name = "LblLogo";
            this.LblLogo.Size = new System.Drawing.Size(1008, 669);
            this.LblLogo.TabIndex = 3;
            // 
            // TbpJugadores
            // 
            this.TbpJugadores.Controls.Add(this.BtnConsultaJu);
            this.TbpJugadores.Controls.Add(this.LsvJugadores);
            this.TbpJugadores.Location = new System.Drawing.Point(4, 22);
            this.TbpJugadores.Name = "TbpJugadores";
            this.TbpJugadores.Padding = new System.Windows.Forms.Padding(3);
            this.TbpJugadores.Size = new System.Drawing.Size(1014, 675);
            this.TbpJugadores.TabIndex = 1;
            this.TbpJugadores.Text = "Jugadores";
            this.TbpJugadores.UseVisualStyleBackColor = true;
            // 
            // BtnConsultaJu
            // 
            this.BtnConsultaJu.AutoSize = true;
            this.BtnConsultaJu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnConsultaJu.Depth = 0;
            this.BtnConsultaJu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnConsultaJu.Icon = null;
            this.BtnConsultaJu.Location = new System.Drawing.Point(3, 636);
            this.BtnConsultaJu.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnConsultaJu.Name = "BtnConsultaJu";
            this.BtnConsultaJu.Primary = true;
            this.BtnConsultaJu.Size = new System.Drawing.Size(1008, 36);
            this.BtnConsultaJu.TabIndex = 8;
            this.BtnConsultaJu.Text = "Consultar";
            this.BtnConsultaJu.UseVisualStyleBackColor = true;
            this.BtnConsultaJu.Click += new System.EventHandler(this.BtnConsultaJu_Click);
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
            this.LsvJugadores.Size = new System.Drawing.Size(1008, 669);
            this.LsvJugadores.TabIndex = 5;
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
            // TbpEquipo
            // 
            this.TbpEquipo.Controls.Add(this.BtnConsultaEquipo);
            this.TbpEquipo.Controls.Add(this.LsvEquipos);
            this.TbpEquipo.Location = new System.Drawing.Point(4, 22);
            this.TbpEquipo.Name = "TbpEquipo";
            this.TbpEquipo.Padding = new System.Windows.Forms.Padding(3);
            this.TbpEquipo.Size = new System.Drawing.Size(1014, 675);
            this.TbpEquipo.TabIndex = 2;
            this.TbpEquipo.Text = "Equipos";
            this.TbpEquipo.UseVisualStyleBackColor = true;
            // 
            // BtnConsultaEquipo
            // 
            this.BtnConsultaEquipo.AutoSize = true;
            this.BtnConsultaEquipo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnConsultaEquipo.Depth = 0;
            this.BtnConsultaEquipo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnConsultaEquipo.Icon = null;
            this.BtnConsultaEquipo.Location = new System.Drawing.Point(3, 636);
            this.BtnConsultaEquipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnConsultaEquipo.Name = "BtnConsultaEquipo";
            this.BtnConsultaEquipo.Primary = true;
            this.BtnConsultaEquipo.Size = new System.Drawing.Size(1008, 36);
            this.BtnConsultaEquipo.TabIndex = 7;
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
            this.LsvEquipos.Size = new System.Drawing.Size(1008, 669);
            this.LsvEquipos.TabIndex = 6;
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
            this.TbpCalendario.Controls.Add(this.LsvCalendario);
            this.TbpCalendario.Location = new System.Drawing.Point(4, 22);
            this.TbpCalendario.Name = "TbpCalendario";
            this.TbpCalendario.Padding = new System.Windows.Forms.Padding(3);
            this.TbpCalendario.Size = new System.Drawing.Size(1014, 675);
            this.TbpCalendario.TabIndex = 4;
            this.TbpCalendario.Text = "Calendario";
            this.TbpCalendario.UseVisualStyleBackColor = true;
            // 
            // TbpPartido
            // 
            this.TbpPartido.Controls.Add(this.LblResultadoP);
            this.TbpPartido.Controls.Add(this.LblEstadoP);
            this.TbpPartido.Controls.Add(this.LsvSanciones);
            this.TbpPartido.Controls.Add(this.LsvMejorJugador);
            this.TbpPartido.Controls.Add(this.LblEncabezadoRP);
            this.TbpPartido.Controls.Add(this.LblEncabezadoEstado);
            this.TbpPartido.Controls.Add(this.LblJugadoresSancionados);
            this.TbpPartido.Controls.Add(this.LblMejorJugador);
            this.TbpPartido.Controls.Add(this.BtnBusquedaTorneo);
            this.TbpPartido.Controls.Add(this.TxtBusquedaTorneo);
            this.TbpPartido.Controls.Add(this.LsvVisitante);
            this.TbpPartido.Controls.Add(this.LblVisitante);
            this.TbpPartido.Controls.Add(this.LblLocal);
            this.TbpPartido.Controls.Add(this.LsvLocal);
            this.TbpPartido.Controls.Add(this.LblBienvenida);
            this.TbpPartido.Location = new System.Drawing.Point(4, 22);
            this.TbpPartido.Name = "TbpPartido";
            this.TbpPartido.Padding = new System.Windows.Forms.Padding(3);
            this.TbpPartido.Size = new System.Drawing.Size(1014, 675);
            this.TbpPartido.TabIndex = 5;
            this.TbpPartido.Text = "Partido";
            this.TbpPartido.UseVisualStyleBackColor = true;
            // 
            // LblEstadoP
            // 
            this.LblEstadoP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblEstadoP.AutoSize = true;
            this.LblEstadoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstadoP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.LblEstadoP.Location = new System.Drawing.Point(514, 406);
            this.LblEstadoP.Name = "LblEstadoP";
            this.LblEstadoP.Size = new System.Drawing.Size(0, 39);
            this.LblEstadoP.TabIndex = 15;
            this.LblEstadoP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LsvSanciones
            // 
            this.LsvSanciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsvSanciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader13});
            this.LsvSanciones.Depth = 0;
            this.LsvSanciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.LsvSanciones.FullRowSelect = true;
            this.LsvSanciones.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LsvSanciones.HideSelection = false;
            this.LsvSanciones.Location = new System.Drawing.Point(7, 533);
            this.LsvSanciones.MouseLocation = new System.Drawing.Point(-1, -1);
            this.LsvSanciones.MouseState = MaterialSkin.MouseState.OUT;
            this.LsvSanciones.Name = "LsvSanciones";
            this.LsvSanciones.OwnerDraw = true;
            this.LsvSanciones.Size = new System.Drawing.Size(500, 71);
            this.LsvSanciones.TabIndex = 14;
            this.LsvSanciones.UseCompatibleStateImageBehavior = false;
            this.LsvSanciones.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Jugador";
            this.columnHeader11.Width = 400;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Sanción";
            this.columnHeader13.Width = 100;
            // 
            // LsvMejorJugador
            // 
            this.LsvMejorJugador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsvMejorJugador.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.LsvMejorJugador.Depth = 0;
            this.LsvMejorJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.LsvMejorJugador.FullRowSelect = true;
            this.LsvMejorJugador.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LsvMejorJugador.HideSelection = false;
            this.LsvMejorJugador.Location = new System.Drawing.Point(8, 406);
            this.LsvMejorJugador.MouseLocation = new System.Drawing.Point(-1, -1);
            this.LsvMejorJugador.MouseState = MaterialSkin.MouseState.OUT;
            this.LsvMejorJugador.Name = "LsvMejorJugador";
            this.LsvMejorJugador.OwnerDraw = true;
            this.LsvMejorJugador.Size = new System.Drawing.Size(500, 93);
            this.LsvMejorJugador.TabIndex = 13;
            this.LsvMejorJugador.UseCompatibleStateImageBehavior = false;
            this.LsvMejorJugador.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Jugador";
            this.columnHeader9.Width = 400;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Puntuación";
            this.columnHeader10.Width = 100;
            // 
            // LblEncabezadoRP
            // 
            this.LblEncabezadoRP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblEncabezadoRP.AutoSize = true;
            this.LblEncabezadoRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEncabezadoRP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.LblEncabezadoRP.Location = new System.Drawing.Point(517, 501);
            this.LblEncabezadoRP.Name = "LblEncabezadoRP";
            this.LblEncabezadoRP.Size = new System.Drawing.Size(188, 24);
            this.LblEncabezadoRP.TabIndex = 12;
            this.LblEncabezadoRP.Text = "Resultado del Partido";
            this.LblEncabezadoRP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblEncabezadoEstado
            // 
            this.LblEncabezadoEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblEncabezadoEstado.AutoSize = true;
            this.LblEncabezadoEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEncabezadoEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.LblEncabezadoEstado.Location = new System.Drawing.Point(512, 374);
            this.LblEncabezadoEstado.Name = "LblEncabezadoEstado";
            this.LblEncabezadoEstado.Size = new System.Drawing.Size(162, 24);
            this.LblEncabezadoEstado.TabIndex = 11;
            this.LblEncabezadoEstado.Text = "Estado del Partido";
            this.LblEncabezadoEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblJugadoresSancionados
            // 
            this.LblJugadoresSancionados.AutoSize = true;
            this.LblJugadoresSancionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblJugadoresSancionados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.LblJugadoresSancionados.Location = new System.Drawing.Point(285, 501);
            this.LblJugadoresSancionados.Name = "LblJugadoresSancionados";
            this.LblJugadoresSancionados.Size = new System.Drawing.Size(214, 24);
            this.LblJugadoresSancionados.TabIndex = 10;
            this.LblJugadoresSancionados.Text = "Jugadores Sancionados";
            this.LblJugadoresSancionados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblMejorJugador
            // 
            this.LblMejorJugador.AutoSize = true;
            this.LblMejorJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMejorJugador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.LblMejorJugador.Location = new System.Drawing.Point(367, 374);
            this.LblMejorJugador.Name = "LblMejorJugador";
            this.LblMejorJugador.Size = new System.Drawing.Size(132, 24);
            this.LblMejorJugador.TabIndex = 9;
            this.LblMejorJugador.Text = "Mejor Jugador";
            this.LblMejorJugador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnBusquedaTorneo
            // 
            this.BtnBusquedaTorneo.AutoSize = true;
            this.BtnBusquedaTorneo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnBusquedaTorneo.Depth = 0;
            this.BtnBusquedaTorneo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnBusquedaTorneo.Icon = null;
            this.BtnBusquedaTorneo.Location = new System.Drawing.Point(3, 636);
            this.BtnBusquedaTorneo.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBusquedaTorneo.Name = "BtnBusquedaTorneo";
            this.BtnBusquedaTorneo.Primary = true;
            this.BtnBusquedaTorneo.Size = new System.Drawing.Size(1008, 36);
            this.BtnBusquedaTorneo.TabIndex = 8;
            this.BtnBusquedaTorneo.Text = "Buscar";
            this.BtnBusquedaTorneo.UseVisualStyleBackColor = true;
            this.BtnBusquedaTorneo.Click += new System.EventHandler(this.BtnBusquedaTorneo_Click);
            // 
            // TxtBusquedaTorneo
            // 
            this.TxtBusquedaTorneo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBusquedaTorneo.Location = new System.Drawing.Point(6, 610);
            this.TxtBusquedaTorneo.Name = "TxtBusquedaTorneo";
            this.TxtBusquedaTorneo.Size = new System.Drawing.Size(1001, 20);
            this.TxtBusquedaTorneo.TabIndex = 7;
            // 
            // LsvVisitante
            // 
            this.LsvVisitante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LsvVisitante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsvVisitante.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.LsvVisitante.Depth = 0;
            this.LsvVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.LsvVisitante.FullRowSelect = true;
            this.LsvVisitante.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LsvVisitante.HideSelection = false;
            this.LsvVisitante.Location = new System.Drawing.Point(516, 43);
            this.LsvVisitante.MouseLocation = new System.Drawing.Point(-1, -1);
            this.LsvVisitante.MouseState = MaterialSkin.MouseState.OUT;
            this.LsvVisitante.Name = "LsvVisitante";
            this.LsvVisitante.OwnerDraw = true;
            this.LsvVisitante.Size = new System.Drawing.Size(492, 328);
            this.LsvVisitante.TabIndex = 6;
            this.LsvVisitante.UseCompatibleStateImageBehavior = false;
            this.LsvVisitante.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Jugador";
            this.columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Equipo";
            this.columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Posición";
            this.columnHeader8.Width = 179;
            // 
            // LblVisitante
            // 
            this.LblVisitante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblVisitante.AutoSize = true;
            this.LblVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVisitante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.LblVisitante.Location = new System.Drawing.Point(516, 11);
            this.LblVisitante.Name = "LblVisitante";
            this.LblVisitante.Size = new System.Drawing.Size(104, 29);
            this.LblVisitante.TabIndex = 5;
            this.LblVisitante.Text = "Visitante";
            this.LblVisitante.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LblLocal
            // 
            this.LblLocal.AutoSize = true;
            this.LblLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.LblLocal.Location = new System.Drawing.Point(428, 11);
            this.LblLocal.Name = "LblLocal";
            this.LblLocal.Size = new System.Drawing.Size(71, 29);
            this.LblLocal.TabIndex = 4;
            this.LblLocal.Text = "Local";
            this.LblLocal.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LsvLocal
            // 
            this.LsvLocal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsvLocal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LsvLocal.Depth = 0;
            this.LsvLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.LsvLocal.FullRowSelect = true;
            this.LsvLocal.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LsvLocal.HideSelection = false;
            this.LsvLocal.Location = new System.Drawing.Point(7, 43);
            this.LsvLocal.MouseLocation = new System.Drawing.Point(-1, -1);
            this.LsvLocal.MouseState = MaterialSkin.MouseState.OUT;
            this.LsvLocal.Name = "LsvLocal";
            this.LsvLocal.OwnerDraw = true;
            this.LsvLocal.Size = new System.Drawing.Size(492, 328);
            this.LsvLocal.TabIndex = 0;
            this.LsvLocal.UseCompatibleStateImageBehavior = false;
            this.LsvLocal.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Jugador";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Equipo";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Posición";
            this.columnHeader4.Width = 179;
            // 
            // TmrInicio
            // 
            this.TmrInicio.Enabled = true;
            this.TmrInicio.Interval = 1;
            this.TmrInicio.Tick += new System.EventHandler(this.TmrInicio_Tick);
            // 
            // LblResultadoP
            // 
            this.LblResultadoP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblResultadoP.AutoSize = true;
            this.LblResultadoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultadoP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.LblResultadoP.Location = new System.Drawing.Point(514, 533);
            this.LblResultadoP.Name = "LblResultadoP";
            this.LblResultadoP.Size = new System.Drawing.Size(0, 39);
            this.LblResultadoP.TabIndex = 16;
            this.LblResultadoP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblBienvenida
            // 
            this.LblBienvenida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.LblBienvenida.Location = new System.Drawing.Point(3, 3);
            this.LblBienvenida.Name = "LblBienvenida";
            this.LblBienvenida.Size = new System.Drawing.Size(1008, 669);
            this.LblBienvenida.TabIndex = 17;
            this.LblBienvenida.Text = "INGRESE UN CÓDIGO DE PARTIDO";
            this.LblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LsvCalendario
            // 
            this.LsvCalendario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsvCalendario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
            this.LsvCalendario.Cursor = System.Windows.Forms.Cursors.Default;
            this.LsvCalendario.Depth = 0;
            this.LsvCalendario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LsvCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.LsvCalendario.FullRowSelect = true;
            this.LsvCalendario.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LsvCalendario.HideSelection = false;
            this.LsvCalendario.Location = new System.Drawing.Point(3, 3);
            this.LsvCalendario.MouseLocation = new System.Drawing.Point(-1, -1);
            this.LsvCalendario.MouseState = MaterialSkin.MouseState.OUT;
            this.LsvCalendario.Name = "LsvCalendario";
            this.LsvCalendario.OwnerDraw = true;
            this.LsvCalendario.Size = new System.Drawing.Size(1008, 669);
            this.LsvCalendario.TabIndex = 7;
            this.LsvCalendario.UseCompatibleStateImageBehavior = false;
            this.LsvCalendario.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "No.";
            this.columnHeader12.Width = 67;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Nombre";
            this.columnHeader14.Width = 190;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Fecha";
            this.columnHeader15.Width = 150;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Local";
            this.columnHeader16.Width = 140;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Visitante";
            this.columnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader17.Width = 178;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Marcador";
            this.columnHeader18.Width = 171;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Estado";
            this.columnHeader19.Width = 1000;
            // 
            // TmrCalendario
            // 
            this.TmrCalendario.Enabled = true;
            this.TmrCalendario.Interval = 1000;
            this.TmrCalendario.Tick += new System.EventHandler(this.TmrCalendario_Tick);
            // 
            // BtnAyuda
            // 
            this.BtnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAyuda.AutoSize = true;
            this.BtnAyuda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAyuda.Depth = 0;
            this.BtnAyuda.Icon = null;
            this.BtnAyuda.Location = new System.Drawing.Point(984, 24);
            this.BtnAyuda.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAyuda.Name = "BtnAyuda";
            this.BtnAyuda.Primary = true;
            this.BtnAyuda.Size = new System.Drawing.Size(28, 36);
            this.BtnAyuda.TabIndex = 2;
            this.BtnAyuda.Text = "?";
            this.BtnAyuda.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.BtnAyuda);
            this.Controls.Add(this.TbcPrincipal);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "FrmMain";
            this.Text = "Polideportivo";
            this.TbcPrincipal.ResumeLayout(false);
            this.TbpInicio.ResumeLayout(false);
            this.TbpInicio.PerformLayout();
            this.TbpJugadores.ResumeLayout(false);
            this.TbpJugadores.PerformLayout();
            this.TbpEquipo.ResumeLayout(false);
            this.TbpEquipo.PerformLayout();
            this.TbpCalendario.ResumeLayout(false);
            this.TbpPartido.ResumeLayout(false);
            this.TbpPartido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl TbcPrincipal;
        private System.Windows.Forms.TabPage TbpInicio;
        private System.Windows.Forms.TabPage TbpJugadores;
        private System.Windows.Forms.Label LblLogo;
        private System.Windows.Forms.Timer TmrInicio;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Label Lbl_Hora;
        private MaterialSkin.Controls.MaterialRaisedButton BtnConsultaJu;
        private MaterialSkin.Controls.MaterialListView LsvJugadores;
        private System.Windows.Forms.ColumnHeader ClmhJugador;
        private System.Windows.Forms.ColumnHeader ClmhEquipo;
        private System.Windows.Forms.ColumnHeader ClmhPosicion;
        private System.Windows.Forms.ColumnHeader ClmhEstadoJugador;
        private System.Windows.Forms.TabPage TbpEquipo;
        private System.Windows.Forms.TabPage TbpCalendario;
        private MaterialSkin.Controls.MaterialRaisedButton BtnConsultaEquipo;
        private MaterialSkin.Controls.MaterialListView LsvEquipos;
        private System.Windows.Forms.ColumnHeader ClmhEquipoS;
        private System.Windows.Forms.ColumnHeader ClmhEntrenador;
        private System.Windows.Forms.ColumnHeader ClmhDepo;
        private System.Windows.Forms.ColumnHeader ClmhEstadoE;
        private System.Windows.Forms.TabPage TbpPartido;
        private System.Windows.Forms.Label LblVisitante;
        private System.Windows.Forms.Label LblLocal;
        private MaterialSkin.Controls.MaterialListView LsvLocal;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox TxtBusquedaTorneo;
        private MaterialSkin.Controls.MaterialListView LsvVisitante;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBusquedaTorneo;
        private System.Windows.Forms.Label LblEncabezadoRP;
        private System.Windows.Forms.Label LblEncabezadoEstado;
        private System.Windows.Forms.Label LblJugadoresSancionados;
        private System.Windows.Forms.Label LblMejorJugador;
        private MaterialSkin.Controls.MaterialListView LsvSanciones;
        private MaterialSkin.Controls.MaterialListView LsvMejorJugador;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Label LblEstadoP;
        private System.Windows.Forms.Label LblResultadoP;
        private System.Windows.Forms.Label LblBienvenida;
        private MaterialSkin.Controls.MaterialListView LsvCalendario;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.Timer TmrCalendario;
        private MaterialSkin.Controls.MaterialRaisedButton BtnAyuda;
    }
}

