namespace PolideportivoAdmin_Proj.Mantenimientos.Entrenador
{
    partial class FrmEntrenador_Jugador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tbc_Jugadores = new MetroFramework.Controls.MetroTabControl();
            this.Tbp_Listado = new MetroFramework.Controls.MetroTabPage();
            this.Dgw_Listado = new MetroFramework.Controls.MetroGrid();
            this.ID_EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ttx_Busqueda_Listado = new MetroFramework.Controls.MetroTextBox();
            this.Tbp_Ingreso = new MetroFramework.Controls.MetroTabPage();
            this.Btn_Ingreso = new System.Windows.Forms.Button();
            this.Gpb_Datos_Eliminar = new System.Windows.Forms.GroupBox();
            this.Dtp_FechaContrato_Eliminar = new MetroFramework.Controls.MetroDateTime();
            this.Dtp_FechaNacimiento_Eliminar = new MetroFramework.Controls.MetroDateTime();
            this.Lbl_FechaContrato_Eliminar = new System.Windows.Forms.Label();
            this.Cmb_TipoPuesto_Eliminar = new System.Windows.Forms.ComboBox();
            this.Txt_DPI_Eliminar = new System.Windows.Forms.TextBox();
            this.Lbl_Telefono_Eliminar = new System.Windows.Forms.Label();
            this.Lbl_TipoPuesto_Eliminar = new System.Windows.Forms.Label();
            this.Txt_NIT_Eliminar = new System.Windows.Forms.TextBox();
            this.Lbl_Direccion_Eliminar = new System.Windows.Forms.Label();
            this.Lbl_NIT_Eliminar = new System.Windows.Forms.Label();
            this.Lbl_FechaNacimiento_Eliminar = new System.Windows.Forms.Label();
            this.Txt_Email_Eliminar = new System.Windows.Forms.TextBox();
            this.Lbl_Email_Eliminar = new System.Windows.Forms.Label();
            this.Txt_Direccion_Eliminar = new System.Windows.Forms.TextBox();
            this.Lbl_DPI_Eliminar = new System.Windows.Forms.Label();
            this.Txt_Nombre1_Eliminar = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre1_Eliminar = new System.Windows.Forms.Label();
            this.Lbl_Nombre2_Eliminar = new System.Windows.Forms.Label();
            this.Txt_Telefono_Eliminar = new System.Windows.Forms.TextBox();
            this.Lbl_Apellido1_Eliminar = new System.Windows.Forms.Label();
            this.Txt_Apellido2_Eliminar = new System.Windows.Forms.TextBox();
            this.Lbl_Apellido2_Eliminar = new System.Windows.Forms.Label();
            this.Txt_Apellido1_Eliminar = new System.Windows.Forms.TextBox();
            this.Txt_Nombre2_Eliminar = new System.Windows.Forms.TextBox();
            this.Tbp_Modificar = new MetroFramework.Controls.MetroTabPage();
            this.Txt_Busqueda_Eliminar = new System.Windows.Forms.TextBox();
            this.Lbl_Titulo4 = new System.Windows.Forms.Label();
            this.Tbp_Eliminar = new MetroFramework.Controls.MetroTabPage();
            this.Tbc_Jugadores.SuspendLayout();
            this.Tbp_Listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_Listado)).BeginInit();
            this.Tbp_Ingreso.SuspendLayout();
            this.Gpb_Datos_Eliminar.SuspendLayout();
            this.Tbp_Modificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbc_Jugadores
            // 
            this.Tbc_Jugadores.Controls.Add(this.Tbp_Listado);
            this.Tbc_Jugadores.Controls.Add(this.Tbp_Ingreso);
            this.Tbc_Jugadores.Controls.Add(this.Tbp_Modificar);
            this.Tbc_Jugadores.Controls.Add(this.Tbp_Eliminar);
            this.Tbc_Jugadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Jugadores.Location = new System.Drawing.Point(0, 0);
            this.Tbc_Jugadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tbc_Jugadores.Name = "Tbc_Jugadores";
            this.Tbc_Jugadores.SelectedIndex = 1;
            this.Tbc_Jugadores.Size = new System.Drawing.Size(1219, 644);
            this.Tbc_Jugadores.TabIndex = 1;
            this.Tbc_Jugadores.UseSelectable = true;
            // 
            // Tbp_Listado
            // 
            this.Tbp_Listado.Controls.Add(this.Dgw_Listado);
            this.Tbp_Listado.Controls.Add(this.Ttx_Busqueda_Listado);
            this.Tbp_Listado.HorizontalScrollbarBarColor = true;
            this.Tbp_Listado.HorizontalScrollbarHighlightOnWheel = false;
            this.Tbp_Listado.HorizontalScrollbarSize = 12;
            this.Tbp_Listado.Location = new System.Drawing.Point(4, 38);
            this.Tbp_Listado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tbp_Listado.Name = "Tbp_Listado";
            this.Tbp_Listado.Size = new System.Drawing.Size(1211, 602);
            this.Tbp_Listado.TabIndex = 0;
            this.Tbp_Listado.Text = "Listado de Jugadores";
            this.Tbp_Listado.VerticalScrollbarBarColor = true;
            this.Tbp_Listado.VerticalScrollbarHighlightOnWheel = false;
            this.Tbp_Listado.VerticalScrollbarSize = 13;
            // 
            // Dgw_Listado
            // 
            this.Dgw_Listado.AllowUserToResizeRows = false;
            this.Dgw_Listado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Dgw_Listado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgw_Listado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dgw_Listado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgw_Listado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgw_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgw_Listado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_EMPLEADO,
            this.Nombre,
            this.Nombre2});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgw_Listado.DefaultCellStyle = dataGridViewCellStyle5;
            this.Dgw_Listado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dgw_Listado.EnableHeadersVisualStyles = false;
            this.Dgw_Listado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Dgw_Listado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Dgw_Listado.Location = new System.Drawing.Point(0, 101);
            this.Dgw_Listado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dgw_Listado.Name = "Dgw_Listado";
            this.Dgw_Listado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgw_Listado.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Dgw_Listado.RowHeadersWidth = 51;
            this.Dgw_Listado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgw_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgw_Listado.Size = new System.Drawing.Size(1211, 501);
            this.Dgw_Listado.Style = MetroFramework.MetroColorStyle.Blue;
            this.Dgw_Listado.TabIndex = 5;
            // 
            // ID_EMPLEADO
            // 
            this.ID_EMPLEADO.HeaderText = "Column1";
            this.ID_EMPLEADO.MinimumWidth = 6;
            this.ID_EMPLEADO.Name = "ID_EMPLEADO";
            this.ID_EMPLEADO.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Column1";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Nombre2
            // 
            this.Nombre2.HeaderText = "Column1";
            this.Nombre2.MinimumWidth = 6;
            this.Nombre2.Name = "Nombre2";
            this.Nombre2.Width = 125;
            // 
            // Ttx_Busqueda_Listado
            // 
            // 
            // 
            // 
            this.Ttx_Busqueda_Listado.CustomButton.Image = null;
            this.Ttx_Busqueda_Listado.CustomButton.Location = new System.Drawing.Point(985, 2);
            this.Ttx_Busqueda_Listado.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Ttx_Busqueda_Listado.CustomButton.Name = "";
            this.Ttx_Busqueda_Listado.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.Ttx_Busqueda_Listado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Ttx_Busqueda_Listado.CustomButton.TabIndex = 1;
            this.Ttx_Busqueda_Listado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Ttx_Busqueda_Listado.CustomButton.UseSelectable = true;
            this.Ttx_Busqueda_Listado.CustomButton.Visible = false;
            this.Ttx_Busqueda_Listado.Lines = new string[0];
            this.Ttx_Busqueda_Listado.Location = new System.Drawing.Point(64, 23);
            this.Ttx_Busqueda_Listado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ttx_Busqueda_Listado.MaxLength = 32767;
            this.Ttx_Busqueda_Listado.Name = "Ttx_Busqueda_Listado";
            this.Ttx_Busqueda_Listado.PasswordChar = '\0';
            this.Ttx_Busqueda_Listado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Ttx_Busqueda_Listado.SelectedText = "";
            this.Ttx_Busqueda_Listado.SelectionLength = 0;
            this.Ttx_Busqueda_Listado.SelectionStart = 0;
            this.Ttx_Busqueda_Listado.ShortcutsEnabled = true;
            this.Ttx_Busqueda_Listado.Size = new System.Drawing.Size(765, 28);
            this.Ttx_Busqueda_Listado.TabIndex = 4;
            this.Ttx_Busqueda_Listado.UseSelectable = true;
            this.Ttx_Busqueda_Listado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Ttx_Busqueda_Listado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Tbp_Ingreso
            // 
            this.Tbp_Ingreso.Controls.Add(this.Btn_Ingreso);
            this.Tbp_Ingreso.Controls.Add(this.Gpb_Datos_Eliminar);
            this.Tbp_Ingreso.HorizontalScrollbarBarColor = true;
            this.Tbp_Ingreso.HorizontalScrollbarHighlightOnWheel = false;
            this.Tbp_Ingreso.HorizontalScrollbarSize = 12;
            this.Tbp_Ingreso.Location = new System.Drawing.Point(4, 38);
            this.Tbp_Ingreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tbp_Ingreso.Name = "Tbp_Ingreso";
            this.Tbp_Ingreso.Size = new System.Drawing.Size(1211, 602);
            this.Tbp_Ingreso.TabIndex = 1;
            this.Tbp_Ingreso.Text = "Ingreso de Jugadores";
            this.Tbp_Ingreso.VerticalScrollbarBarColor = true;
            this.Tbp_Ingreso.VerticalScrollbarHighlightOnWheel = false;
            this.Tbp_Ingreso.VerticalScrollbarSize = 13;
            // 
            // Btn_Ingreso
            // 
            this.Btn_Ingreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            this.Btn_Ingreso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            this.Btn_Ingreso.FlatAppearance.BorderSize = 0;
            this.Btn_Ingreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ingreso.Font = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ingreso.Location = new System.Drawing.Point(920, 423);
            this.Btn_Ingreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Ingreso.Name = "Btn_Ingreso";
            this.Btn_Ingreso.Size = new System.Drawing.Size(181, 50);
            this.Btn_Ingreso.TabIndex = 37;
            this.Btn_Ingreso.Text = "INGRESAR";
            this.Btn_Ingreso.UseVisualStyleBackColor = false;
            this.Btn_Ingreso.Click += new System.EventHandler(this.Btn_Ingreso_Click);
            // 
            // Gpb_Datos_Eliminar
            // 
            this.Gpb_Datos_Eliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Gpb_Datos_Eliminar.Controls.Add(this.Dtp_FechaContrato_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Dtp_FechaNacimiento_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Lbl_FechaContrato_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Cmb_TipoPuesto_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Txt_DPI_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Lbl_Telefono_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Lbl_TipoPuesto_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Txt_NIT_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Lbl_Direccion_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Lbl_NIT_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Lbl_FechaNacimiento_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Txt_Email_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Lbl_Email_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Txt_Direccion_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Lbl_DPI_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Txt_Nombre1_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Lbl_Nombre1_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Lbl_Nombre2_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Txt_Telefono_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Lbl_Apellido1_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Txt_Apellido2_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Lbl_Apellido2_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Txt_Apellido1_Eliminar);
            this.Gpb_Datos_Eliminar.Controls.Add(this.Txt_Nombre2_Eliminar);
            this.Gpb_Datos_Eliminar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Datos_Eliminar.Location = new System.Drawing.Point(36, 59);
            this.Gpb_Datos_Eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gpb_Datos_Eliminar.Name = "Gpb_Datos_Eliminar";
            this.Gpb_Datos_Eliminar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gpb_Datos_Eliminar.Size = new System.Drawing.Size(736, 516);
            this.Gpb_Datos_Eliminar.TabIndex = 36;
            this.Gpb_Datos_Eliminar.TabStop = false;
            this.Gpb_Datos_Eliminar.Text = "Datos Personales";
            // 
            // Dtp_FechaContrato_Eliminar
            // 
            this.Dtp_FechaContrato_Eliminar.Enabled = false;
            this.Dtp_FechaContrato_Eliminar.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.Dtp_FechaContrato_Eliminar.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.Dtp_FechaContrato_Eliminar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_FechaContrato_Eliminar.Location = new System.Drawing.Point(400, 385);
            this.Dtp_FechaContrato_Eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dtp_FechaContrato_Eliminar.MinimumSize = new System.Drawing.Size(0, 27);
            this.Dtp_FechaContrato_Eliminar.Name = "Dtp_FechaContrato_Eliminar";
            this.Dtp_FechaContrato_Eliminar.Size = new System.Drawing.Size(307, 27);
            this.Dtp_FechaContrato_Eliminar.TabIndex = 49;
            this.Dtp_FechaContrato_Eliminar.Value = new System.DateTime(2020, 8, 12, 0, 0, 0, 0);
            // 
            // Dtp_FechaNacimiento_Eliminar
            // 
            this.Dtp_FechaNacimiento_Eliminar.Enabled = false;
            this.Dtp_FechaNacimiento_Eliminar.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.Dtp_FechaNacimiento_Eliminar.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.Dtp_FechaNacimiento_Eliminar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_FechaNacimiento_Eliminar.Location = new System.Drawing.Point(12, 321);
            this.Dtp_FechaNacimiento_Eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dtp_FechaNacimiento_Eliminar.MinimumSize = new System.Drawing.Size(0, 27);
            this.Dtp_FechaNacimiento_Eliminar.Name = "Dtp_FechaNacimiento_Eliminar";
            this.Dtp_FechaNacimiento_Eliminar.Size = new System.Drawing.Size(307, 27);
            this.Dtp_FechaNacimiento_Eliminar.TabIndex = 48;
            this.Dtp_FechaNacimiento_Eliminar.Value = new System.DateTime(2020, 8, 12, 0, 0, 0, 0);
            // 
            // Lbl_FechaContrato_Eliminar
            // 
            this.Lbl_FechaContrato_Eliminar.AutoSize = true;
            this.Lbl_FechaContrato_Eliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_FechaContrato_Eliminar.Enabled = false;
            this.Lbl_FechaContrato_Eliminar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FechaContrato_Eliminar.Location = new System.Drawing.Point(396, 364);
            this.Lbl_FechaContrato_Eliminar.Name = "Lbl_FechaContrato_Eliminar";
            this.Lbl_FechaContrato_Eliminar.Size = new System.Drawing.Size(168, 18);
            this.Lbl_FechaContrato_Eliminar.TabIndex = 45;
            this.Lbl_FechaContrato_Eliminar.Text = "FECHA DE CONTRATACIÓN";
            // 
            // Cmb_TipoPuesto_Eliminar
            // 
            this.Cmb_TipoPuesto_Eliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_TipoPuesto_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_TipoPuesto_Eliminar.FormattingEnabled = true;
            this.Cmb_TipoPuesto_Eliminar.Location = new System.Drawing.Point(12, 384);
            this.Cmb_TipoPuesto_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cmb_TipoPuesto_Eliminar.Name = "Cmb_TipoPuesto_Eliminar";
            this.Cmb_TipoPuesto_Eliminar.Size = new System.Drawing.Size(307, 26);
            this.Cmb_TipoPuesto_Eliminar.TabIndex = 39;
            // 
            // Txt_DPI_Eliminar
            // 
            this.Txt_DPI_Eliminar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Txt_DPI_Eliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_DPI_Eliminar.Enabled = false;
            this.Txt_DPI_Eliminar.Location = new System.Drawing.Point(400, 254);
            this.Txt_DPI_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_DPI_Eliminar.Name = "Txt_DPI_Eliminar";
            this.Txt_DPI_Eliminar.Size = new System.Drawing.Size(308, 19);
            this.Txt_DPI_Eliminar.TabIndex = 44;
            // 
            // Lbl_Telefono_Eliminar
            // 
            this.Lbl_Telefono_Eliminar.AutoSize = true;
            this.Lbl_Telefono_Eliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Telefono_Eliminar.Enabled = false;
            this.Lbl_Telefono_Eliminar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Telefono_Eliminar.Location = new System.Drawing.Point(9, 167);
            this.Lbl_Telefono_Eliminar.Name = "Lbl_Telefono_Eliminar";
            this.Lbl_Telefono_Eliminar.Size = new System.Drawing.Size(72, 18);
            this.Lbl_Telefono_Eliminar.TabIndex = 43;
            this.Lbl_Telefono_Eliminar.Text = "TELÉFONO";
            // 
            // Lbl_TipoPuesto_Eliminar
            // 
            this.Lbl_TipoPuesto_Eliminar.AutoSize = true;
            this.Lbl_TipoPuesto_Eliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_TipoPuesto_Eliminar.Enabled = false;
            this.Lbl_TipoPuesto_Eliminar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TipoPuesto_Eliminar.Location = new System.Drawing.Point(9, 364);
            this.Lbl_TipoPuesto_Eliminar.Name = "Lbl_TipoPuesto_Eliminar";
            this.Lbl_TipoPuesto_Eliminar.Size = new System.Drawing.Size(89, 18);
            this.Lbl_TipoPuesto_Eliminar.TabIndex = 23;
            this.Lbl_TipoPuesto_Eliminar.Text = "TIPO PUESTO";
            // 
            // Txt_NIT_Eliminar
            // 
            this.Txt_NIT_Eliminar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Txt_NIT_Eliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_NIT_Eliminar.Enabled = false;
            this.Txt_NIT_Eliminar.Location = new System.Drawing.Point(400, 320);
            this.Txt_NIT_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_NIT_Eliminar.Name = "Txt_NIT_Eliminar";
            this.Txt_NIT_Eliminar.Size = new System.Drawing.Size(308, 19);
            this.Txt_NIT_Eliminar.TabIndex = 42;
            // 
            // Lbl_Direccion_Eliminar
            // 
            this.Lbl_Direccion_Eliminar.AutoSize = true;
            this.Lbl_Direccion_Eliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Direccion_Eliminar.Enabled = false;
            this.Lbl_Direccion_Eliminar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Direccion_Eliminar.Location = new System.Drawing.Point(396, 167);
            this.Lbl_Direccion_Eliminar.Name = "Lbl_Direccion_Eliminar";
            this.Lbl_Direccion_Eliminar.Size = new System.Drawing.Size(76, 18);
            this.Lbl_Direccion_Eliminar.TabIndex = 41;
            this.Lbl_Direccion_Eliminar.Text = "DIRECCIÓN";
            // 
            // Lbl_NIT_Eliminar
            // 
            this.Lbl_NIT_Eliminar.AutoSize = true;
            this.Lbl_NIT_Eliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_NIT_Eliminar.Enabled = false;
            this.Lbl_NIT_Eliminar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NIT_Eliminar.Location = new System.Drawing.Point(396, 300);
            this.Lbl_NIT_Eliminar.Name = "Lbl_NIT_Eliminar";
            this.Lbl_NIT_Eliminar.Size = new System.Drawing.Size(29, 18);
            this.Lbl_NIT_Eliminar.TabIndex = 35;
            this.Lbl_NIT_Eliminar.Text = "NIT";
            // 
            // Lbl_FechaNacimiento_Eliminar
            // 
            this.Lbl_FechaNacimiento_Eliminar.AutoSize = true;
            this.Lbl_FechaNacimiento_Eliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_FechaNacimiento_Eliminar.Enabled = false;
            this.Lbl_FechaNacimiento_Eliminar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FechaNacimiento_Eliminar.Location = new System.Drawing.Point(9, 300);
            this.Lbl_FechaNacimiento_Eliminar.Name = "Lbl_FechaNacimiento_Eliminar";
            this.Lbl_FechaNacimiento_Eliminar.Size = new System.Drawing.Size(133, 18);
            this.Lbl_FechaNacimiento_Eliminar.TabIndex = 34;
            this.Lbl_FechaNacimiento_Eliminar.Text = "FECHA NACIMIENTO";
            // 
            // Txt_Email_Eliminar
            // 
            this.Txt_Email_Eliminar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Txt_Email_Eliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Email_Eliminar.Enabled = false;
            this.Txt_Email_Eliminar.Location = new System.Drawing.Point(12, 254);
            this.Txt_Email_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Email_Eliminar.Name = "Txt_Email_Eliminar";
            this.Txt_Email_Eliminar.Size = new System.Drawing.Size(308, 19);
            this.Txt_Email_Eliminar.TabIndex = 38;
            // 
            // Lbl_Email_Eliminar
            // 
            this.Lbl_Email_Eliminar.AutoSize = true;
            this.Lbl_Email_Eliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Email_Eliminar.Enabled = false;
            this.Lbl_Email_Eliminar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Email_Eliminar.Location = new System.Drawing.Point(9, 234);
            this.Lbl_Email_Eliminar.Name = "Lbl_Email_Eliminar";
            this.Lbl_Email_Eliminar.Size = new System.Drawing.Size(147, 18);
            this.Lbl_Email_Eliminar.TabIndex = 27;
            this.Lbl_Email_Eliminar.Text = "CORREO ELECTRÓNICO";
            // 
            // Txt_Direccion_Eliminar
            // 
            this.Txt_Direccion_Eliminar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Txt_Direccion_Eliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Direccion_Eliminar.Enabled = false;
            this.Txt_Direccion_Eliminar.Location = new System.Drawing.Point(400, 187);
            this.Txt_Direccion_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Direccion_Eliminar.Name = "Txt_Direccion_Eliminar";
            this.Txt_Direccion_Eliminar.Size = new System.Drawing.Size(308, 19);
            this.Txt_Direccion_Eliminar.TabIndex = 37;
            // 
            // Lbl_DPI_Eliminar
            // 
            this.Lbl_DPI_Eliminar.AutoSize = true;
            this.Lbl_DPI_Eliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_DPI_Eliminar.Enabled = false;
            this.Lbl_DPI_Eliminar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DPI_Eliminar.Location = new System.Drawing.Point(396, 234);
            this.Lbl_DPI_Eliminar.Name = "Lbl_DPI_Eliminar";
            this.Lbl_DPI_Eliminar.Size = new System.Drawing.Size(29, 18);
            this.Lbl_DPI_Eliminar.TabIndex = 36;
            this.Lbl_DPI_Eliminar.Text = "DPI";
            // 
            // Txt_Nombre1_Eliminar
            // 
            this.Txt_Nombre1_Eliminar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Txt_Nombre1_Eliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Nombre1_Eliminar.Enabled = false;
            this.Txt_Nombre1_Eliminar.Location = new System.Drawing.Point(12, 64);
            this.Txt_Nombre1_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Nombre1_Eliminar.Name = "Txt_Nombre1_Eliminar";
            this.Txt_Nombre1_Eliminar.Size = new System.Drawing.Size(308, 19);
            this.Txt_Nombre1_Eliminar.TabIndex = 28;
            // 
            // Lbl_Nombre1_Eliminar
            // 
            this.Lbl_Nombre1_Eliminar.AutoSize = true;
            this.Lbl_Nombre1_Eliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Nombre1_Eliminar.Enabled = false;
            this.Lbl_Nombre1_Eliminar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre1_Eliminar.Location = new System.Drawing.Point(9, 44);
            this.Lbl_Nombre1_Eliminar.Name = "Lbl_Nombre1_Eliminar";
            this.Lbl_Nombre1_Eliminar.Size = new System.Drawing.Size(115, 18);
            this.Lbl_Nombre1_Eliminar.TabIndex = 33;
            this.Lbl_Nombre1_Eliminar.Text = "PRIMER NOMBRE";
            // 
            // Lbl_Nombre2_Eliminar
            // 
            this.Lbl_Nombre2_Eliminar.AutoSize = true;
            this.Lbl_Nombre2_Eliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Nombre2_Eliminar.Enabled = false;
            this.Lbl_Nombre2_Eliminar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre2_Eliminar.Location = new System.Drawing.Point(396, 44);
            this.Lbl_Nombre2_Eliminar.Name = "Lbl_Nombre2_Eliminar";
            this.Lbl_Nombre2_Eliminar.Size = new System.Drawing.Size(130, 18);
            this.Lbl_Nombre2_Eliminar.TabIndex = 24;
            this.Lbl_Nombre2_Eliminar.Text = "SEGUNDO NOMBRE";
            // 
            // Txt_Telefono_Eliminar
            // 
            this.Txt_Telefono_Eliminar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Txt_Telefono_Eliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Telefono_Eliminar.Enabled = false;
            this.Txt_Telefono_Eliminar.Location = new System.Drawing.Point(12, 187);
            this.Txt_Telefono_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Telefono_Eliminar.Name = "Txt_Telefono_Eliminar";
            this.Txt_Telefono_Eliminar.Size = new System.Drawing.Size(164, 19);
            this.Txt_Telefono_Eliminar.TabIndex = 32;
            // 
            // Lbl_Apellido1_Eliminar
            // 
            this.Lbl_Apellido1_Eliminar.AutoSize = true;
            this.Lbl_Apellido1_Eliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Apellido1_Eliminar.Enabled = false;
            this.Lbl_Apellido1_Eliminar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Apellido1_Eliminar.Location = new System.Drawing.Point(9, 106);
            this.Lbl_Apellido1_Eliminar.Name = "Lbl_Apellido1_Eliminar";
            this.Lbl_Apellido1_Eliminar.Size = new System.Drawing.Size(118, 18);
            this.Lbl_Apellido1_Eliminar.TabIndex = 25;
            this.Lbl_Apellido1_Eliminar.Text = "PRIMER APELLIDO";
            // 
            // Txt_Apellido2_Eliminar
            // 
            this.Txt_Apellido2_Eliminar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Txt_Apellido2_Eliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Apellido2_Eliminar.Enabled = false;
            this.Txt_Apellido2_Eliminar.Location = new System.Drawing.Point(400, 126);
            this.Txt_Apellido2_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Apellido2_Eliminar.Name = "Txt_Apellido2_Eliminar";
            this.Txt_Apellido2_Eliminar.Size = new System.Drawing.Size(308, 19);
            this.Txt_Apellido2_Eliminar.TabIndex = 31;
            // 
            // Lbl_Apellido2_Eliminar
            // 
            this.Lbl_Apellido2_Eliminar.AutoSize = true;
            this.Lbl_Apellido2_Eliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Apellido2_Eliminar.Enabled = false;
            this.Lbl_Apellido2_Eliminar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Apellido2_Eliminar.Location = new System.Drawing.Point(396, 106);
            this.Lbl_Apellido2_Eliminar.Name = "Lbl_Apellido2_Eliminar";
            this.Lbl_Apellido2_Eliminar.Size = new System.Drawing.Size(133, 18);
            this.Lbl_Apellido2_Eliminar.TabIndex = 26;
            this.Lbl_Apellido2_Eliminar.Text = "SEGUNDO APELLIDO";
            // 
            // Txt_Apellido1_Eliminar
            // 
            this.Txt_Apellido1_Eliminar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Txt_Apellido1_Eliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Apellido1_Eliminar.Enabled = false;
            this.Txt_Apellido1_Eliminar.Location = new System.Drawing.Point(12, 126);
            this.Txt_Apellido1_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Apellido1_Eliminar.Name = "Txt_Apellido1_Eliminar";
            this.Txt_Apellido1_Eliminar.Size = new System.Drawing.Size(308, 19);
            this.Txt_Apellido1_Eliminar.TabIndex = 30;
            // 
            // Txt_Nombre2_Eliminar
            // 
            this.Txt_Nombre2_Eliminar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Txt_Nombre2_Eliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Nombre2_Eliminar.Enabled = false;
            this.Txt_Nombre2_Eliminar.Location = new System.Drawing.Point(400, 64);
            this.Txt_Nombre2_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Nombre2_Eliminar.Name = "Txt_Nombre2_Eliminar";
            this.Txt_Nombre2_Eliminar.Size = new System.Drawing.Size(308, 19);
            this.Txt_Nombre2_Eliminar.TabIndex = 29;
            // 
            // Tbp_Modificar
            // 
            this.Tbp_Modificar.Controls.Add(this.Txt_Busqueda_Eliminar);
            this.Tbp_Modificar.Controls.Add(this.Lbl_Titulo4);
            this.Tbp_Modificar.HorizontalScrollbarBarColor = true;
            this.Tbp_Modificar.HorizontalScrollbarHighlightOnWheel = false;
            this.Tbp_Modificar.HorizontalScrollbarSize = 12;
            this.Tbp_Modificar.Location = new System.Drawing.Point(4, 38);
            this.Tbp_Modificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tbp_Modificar.Name = "Tbp_Modificar";
            this.Tbp_Modificar.Size = new System.Drawing.Size(1211, 602);
            this.Tbp_Modificar.TabIndex = 2;
            this.Tbp_Modificar.Text = "Modificar un Jugador";
            this.Tbp_Modificar.VerticalScrollbarBarColor = true;
            this.Tbp_Modificar.VerticalScrollbarHighlightOnWheel = false;
            this.Tbp_Modificar.VerticalScrollbarSize = 13;
            // 
            // Txt_Busqueda_Eliminar
            // 
            this.Txt_Busqueda_Eliminar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Txt_Busqueda_Eliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Busqueda_Eliminar.Location = new System.Drawing.Point(347, 25);
            this.Txt_Busqueda_Eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Busqueda_Eliminar.Name = "Txt_Busqueda_Eliminar";
            this.Txt_Busqueda_Eliminar.Size = new System.Drawing.Size(417, 15);
            this.Txt_Busqueda_Eliminar.TabIndex = 36;
            // 
            // Lbl_Titulo4
            // 
            this.Lbl_Titulo4.AutoSize = true;
            this.Lbl_Titulo4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Titulo4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo4.Location = new System.Drawing.Point(36, 23);
            this.Lbl_Titulo4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Titulo4.Name = "Lbl_Titulo4";
            this.Lbl_Titulo4.Size = new System.Drawing.Size(230, 18);
            this.Lbl_Titulo4.TabIndex = 35;
            this.Lbl_Titulo4.Text = "Ingrese el ID del empleado";
            // 
            // Tbp_Eliminar
            // 
            this.Tbp_Eliminar.HorizontalScrollbarBarColor = true;
            this.Tbp_Eliminar.HorizontalScrollbarHighlightOnWheel = false;
            this.Tbp_Eliminar.HorizontalScrollbarSize = 12;
            this.Tbp_Eliminar.Location = new System.Drawing.Point(4, 38);
            this.Tbp_Eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tbp_Eliminar.Name = "Tbp_Eliminar";
            this.Tbp_Eliminar.Size = new System.Drawing.Size(1211, 602);
            this.Tbp_Eliminar.TabIndex = 3;
            this.Tbp_Eliminar.Text = "Eliminar un Jugador";
            this.Tbp_Eliminar.VerticalScrollbarBarColor = true;
            this.Tbp_Eliminar.VerticalScrollbarHighlightOnWheel = false;
            this.Tbp_Eliminar.VerticalScrollbarSize = 13;
            // 
            // FrmEntrenador_Jugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 644);
            this.Controls.Add(this.Tbc_Jugadores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmEntrenador_Jugador";
            this.Text = "FrmEntrenador_Jugador";
            this.Tbc_Jugadores.ResumeLayout(false);
            this.Tbp_Listado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_Listado)).EndInit();
            this.Tbp_Ingreso.ResumeLayout(false);
            this.Gpb_Datos_Eliminar.ResumeLayout(false);
            this.Gpb_Datos_Eliminar.PerformLayout();
            this.Tbp_Modificar.ResumeLayout(false);
            this.Tbp_Modificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl Tbc_Jugadores;
        private MetroFramework.Controls.MetroTabPage Tbp_Listado;
        private MetroFramework.Controls.MetroGrid Dgw_Listado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_EMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre2;
        private MetroFramework.Controls.MetroTextBox Ttx_Busqueda_Listado;
        private MetroFramework.Controls.MetroTabPage Tbp_Ingreso;
        private System.Windows.Forms.Button Btn_Ingreso;
        private System.Windows.Forms.GroupBox Gpb_Datos_Eliminar;
        private MetroFramework.Controls.MetroDateTime Dtp_FechaContrato_Eliminar;
        private MetroFramework.Controls.MetroDateTime Dtp_FechaNacimiento_Eliminar;
        private System.Windows.Forms.Label Lbl_FechaContrato_Eliminar;
        private System.Windows.Forms.ComboBox Cmb_TipoPuesto_Eliminar;
        private System.Windows.Forms.TextBox Txt_DPI_Eliminar;
        private System.Windows.Forms.Label Lbl_Telefono_Eliminar;
        private System.Windows.Forms.Label Lbl_TipoPuesto_Eliminar;
        private System.Windows.Forms.TextBox Txt_NIT_Eliminar;
        private System.Windows.Forms.Label Lbl_Direccion_Eliminar;
        private System.Windows.Forms.Label Lbl_NIT_Eliminar;
        private System.Windows.Forms.Label Lbl_FechaNacimiento_Eliminar;
        private System.Windows.Forms.TextBox Txt_Email_Eliminar;
        private System.Windows.Forms.Label Lbl_Email_Eliminar;
        private System.Windows.Forms.TextBox Txt_Direccion_Eliminar;
        private System.Windows.Forms.Label Lbl_DPI_Eliminar;
        private System.Windows.Forms.TextBox Txt_Nombre1_Eliminar;
        private System.Windows.Forms.Label Lbl_Nombre1_Eliminar;
        private System.Windows.Forms.Label Lbl_Nombre2_Eliminar;
        private System.Windows.Forms.TextBox Txt_Telefono_Eliminar;
        private System.Windows.Forms.Label Lbl_Apellido1_Eliminar;
        private System.Windows.Forms.TextBox Txt_Apellido2_Eliminar;
        private System.Windows.Forms.Label Lbl_Apellido2_Eliminar;
        private System.Windows.Forms.TextBox Txt_Apellido1_Eliminar;
        private System.Windows.Forms.TextBox Txt_Nombre2_Eliminar;
        private MetroFramework.Controls.MetroTabPage Tbp_Modificar;
        private MetroFramework.Controls.MetroTabPage Tbp_Eliminar;
        private System.Windows.Forms.TextBox Txt_Busqueda_Eliminar;
        private System.Windows.Forms.Label Lbl_Titulo4;
    }
}