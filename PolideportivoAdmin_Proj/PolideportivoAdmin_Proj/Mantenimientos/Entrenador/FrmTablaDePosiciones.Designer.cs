namespace PolideportivoAdmin_Proj.Mantenimientos.Entrenador
{
    partial class FrmTablaDePosiciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTablaDePosiciones));
            this.Tbc_TablaPosiciones = new MetroFramework.Controls.MetroTabControl();
            this.Tbp_Tabla = new MetroFramework.Controls.MetroTabPage();
            this.Btn_BuscarID = new System.Windows.Forms.Button();
            this.Txt_IDCampeonato = new System.Windows.Forms.TextBox();
            this.Lbl_Titulo1 = new System.Windows.Forms.Label();
            this.Dgv_TablaPosiciones = new MetroFramework.Controls.MetroGrid();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Tbc_TablaPosiciones.SuspendLayout();
            this.Tbp_Tabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TablaPosiciones)).BeginInit();
            this.SuspendLayout();
            // 
            // Tbc_TablaPosiciones
            // 
            this.Tbc_TablaPosiciones.Controls.Add(this.Tbp_Tabla);
            this.Tbc_TablaPosiciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_TablaPosiciones.Location = new System.Drawing.Point(0, 0);
            this.Tbc_TablaPosiciones.Name = "Tbc_TablaPosiciones";
            this.Tbc_TablaPosiciones.SelectedIndex = 0;
            this.Tbc_TablaPosiciones.Size = new System.Drawing.Size(914, 523);
            this.Tbc_TablaPosiciones.TabIndex = 0;
            this.Tbc_TablaPosiciones.UseSelectable = true;
            // 
            // Tbp_Tabla
            // 
            this.Tbp_Tabla.Controls.Add(this.Btn_Ayuda);
            this.Tbp_Tabla.Controls.Add(this.Btn_BuscarID);
            this.Tbp_Tabla.Controls.Add(this.Txt_IDCampeonato);
            this.Tbp_Tabla.Controls.Add(this.Lbl_Titulo1);
            this.Tbp_Tabla.Controls.Add(this.Dgv_TablaPosiciones);
            this.Tbp_Tabla.HorizontalScrollbarBarColor = true;
            this.Tbp_Tabla.HorizontalScrollbarHighlightOnWheel = false;
            this.Tbp_Tabla.HorizontalScrollbarSize = 10;
            this.Tbp_Tabla.Location = new System.Drawing.Point(4, 38);
            this.Tbp_Tabla.Name = "Tbp_Tabla";
            this.Tbp_Tabla.Size = new System.Drawing.Size(906, 481);
            this.Tbp_Tabla.TabIndex = 0;
            this.Tbp_Tabla.Text = "Tabla de Posiciones del Campeonato";
            this.Tbp_Tabla.VerticalScrollbarBarColor = true;
            this.Tbp_Tabla.VerticalScrollbarHighlightOnWheel = false;
            this.Tbp_Tabla.VerticalScrollbarSize = 10;
            // 
            // Btn_BuscarID
            // 
            this.Btn_BuscarID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            this.Btn_BuscarID.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(177)))), ((int)(((byte)(221)))));
            this.Btn_BuscarID.FlatAppearance.BorderSize = 0;
            this.Btn_BuscarID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BuscarID.Font = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BuscarID.Location = new System.Drawing.Point(676, 19);
            this.Btn_BuscarID.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_BuscarID.Name = "Btn_BuscarID";
            this.Btn_BuscarID.Size = new System.Drawing.Size(141, 28);
            this.Btn_BuscarID.TabIndex = 34;
            this.Btn_BuscarID.Text = "BUSCAR";
            this.Btn_BuscarID.UseVisualStyleBackColor = false;
            this.Btn_BuscarID.Click += new System.EventHandler(this.Btn_BuscarID_Click);
            // 
            // Txt_IDCampeonato
            // 
            this.Txt_IDCampeonato.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Txt_IDCampeonato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_IDCampeonato.Location = new System.Drawing.Point(286, 27);
            this.Txt_IDCampeonato.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_IDCampeonato.Name = "Txt_IDCampeonato";
            this.Txt_IDCampeonato.Size = new System.Drawing.Size(313, 13);
            this.Txt_IDCampeonato.TabIndex = 33;
            // 
            // Lbl_Titulo1
            // 
            this.Lbl_Titulo1.AutoSize = true;
            this.Lbl_Titulo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Titulo1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo1.Location = new System.Drawing.Point(42, 26);
            this.Lbl_Titulo1.Name = "Lbl_Titulo1";
            this.Lbl_Titulo1.Size = new System.Drawing.Size(204, 14);
            this.Lbl_Titulo1.TabIndex = 29;
            this.Lbl_Titulo1.Text = "Ingrese el ID del Campeonato";
            // 
            // Dgv_TablaPosiciones
            // 
            this.Dgv_TablaPosiciones.AllowUserToResizeRows = false;
            this.Dgv_TablaPosiciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_TablaPosiciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Dgv_TablaPosiciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_TablaPosiciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dgv_TablaPosiciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_TablaPosiciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_TablaPosiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_TablaPosiciones.DefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_TablaPosiciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dgv_TablaPosiciones.EnableHeadersVisualStyles = false;
            this.Dgv_TablaPosiciones.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Dgv_TablaPosiciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Dgv_TablaPosiciones.Location = new System.Drawing.Point(0, 67);
            this.Dgv_TablaPosiciones.Name = "Dgv_TablaPosiciones";
            this.Dgv_TablaPosiciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_TablaPosiciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_TablaPosiciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgv_TablaPosiciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_TablaPosiciones.Size = new System.Drawing.Size(906, 414);
            this.Dgv_TablaPosiciones.TabIndex = 2;
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Ayuda.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar;
            this.Btn_Ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_Ayuda.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuBar;
            this.Btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ayuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ayuda.ForeColor = System.Drawing.Color.Brown;
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(865, 3);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(33, 32);
            this.Btn_Ayuda.TabIndex = 35;
            this.Btn_Ayuda.UseVisualStyleBackColor = false;
            // 
            // FrmTablaDePosiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(914, 523);
            this.Controls.Add(this.Tbc_TablaPosiciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTablaDePosiciones";
            this.Text = "FrmTablaDePosiciones";
            this.Tbc_TablaPosiciones.ResumeLayout(false);
            this.Tbp_Tabla.ResumeLayout(false);
            this.Tbp_Tabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TablaPosiciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl Tbc_TablaPosiciones;
        private MetroFramework.Controls.MetroTabPage Tbp_Tabla;
        private MetroFramework.Controls.MetroGrid Dgv_TablaPosiciones;
        private System.Windows.Forms.Label Lbl_Titulo1;
        private System.Windows.Forms.TextBox Txt_IDCampeonato;
        private System.Windows.Forms.Button Btn_BuscarID;
        private System.Windows.Forms.Button Btn_Ayuda;
    }
}