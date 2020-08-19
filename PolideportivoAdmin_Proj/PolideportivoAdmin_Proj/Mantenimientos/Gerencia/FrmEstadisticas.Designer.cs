namespace PolideportivoAdmin_Proj.Mantenimientos.Gerencia
{
    partial class FrmEstadisticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadisticas));
            this.Tbp_Estadistica = new MetroFramework.Controls.MetroTabPage();
            this.Graf_Bitacora = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Tbc_Estadistica = new MetroFramework.Controls.MetroTabControl();
            this.Tbp_Futbol = new MetroFramework.Controls.MetroTabPage();
            this.Tbp_Basquet = new MetroFramework.Controls.MetroTabPage();
            this.Tbp_Beisbol = new MetroFramework.Controls.MetroTabPage();
            this.Tbp_Voleibol = new MetroFramework.Controls.MetroTabPage();
            this.Btn_Ayuda_Sistema = new System.Windows.Forms.Button();
            this.Btn_Ayuda_Futbol = new System.Windows.Forms.Button();
            this.Btn_Ayuda_Basquet = new System.Windows.Forms.Button();
            this.Btn_Ayuda_Beisbol = new System.Windows.Forms.Button();
            this.Btn_Ayuda_Voleibol = new System.Windows.Forms.Button();
            this.Tbp_Estadistica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graf_Bitacora)).BeginInit();
            this.Tbc_Estadistica.SuspendLayout();
            this.Tbp_Futbol.SuspendLayout();
            this.Tbp_Basquet.SuspendLayout();
            this.Tbp_Beisbol.SuspendLayout();
            this.Tbp_Voleibol.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbp_Estadistica
            // 
            this.Tbp_Estadistica.Controls.Add(this.Btn_Ayuda_Sistema);
            this.Tbp_Estadistica.Controls.Add(this.Graf_Bitacora);
            this.Tbp_Estadistica.HorizontalScrollbarBarColor = true;
            this.Tbp_Estadistica.HorizontalScrollbarHighlightOnWheel = false;
            this.Tbp_Estadistica.HorizontalScrollbarSize = 10;
            this.Tbp_Estadistica.Location = new System.Drawing.Point(4, 38);
            this.Tbp_Estadistica.Name = "Tbp_Estadistica";
            this.Tbp_Estadistica.Size = new System.Drawing.Size(906, 481);
            this.Tbp_Estadistica.TabIndex = 0;
            this.Tbp_Estadistica.Text = "Del Sistema";
            this.Tbp_Estadistica.VerticalScrollbarBarColor = true;
            this.Tbp_Estadistica.VerticalScrollbarHighlightOnWheel = false;
            this.Tbp_Estadistica.VerticalScrollbarSize = 10;
            // 
            // Graf_Bitacora
            // 
            chartArea1.Name = "ChartArea1";
            this.Graf_Bitacora.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Graf_Bitacora.Legends.Add(legend1);
            this.Graf_Bitacora.Location = new System.Drawing.Point(27, 160);
            this.Graf_Bitacora.Name = "Graf_Bitacora";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Graf_Bitacora.Series.Add(series1);
            this.Graf_Bitacora.Size = new System.Drawing.Size(300, 300);
            this.Graf_Bitacora.TabIndex = 2;
            this.Graf_Bitacora.Text = "chart1";
            // 
            // Tbc_Estadistica
            // 
            this.Tbc_Estadistica.Controls.Add(this.Tbp_Estadistica);
            this.Tbc_Estadistica.Controls.Add(this.Tbp_Futbol);
            this.Tbc_Estadistica.Controls.Add(this.Tbp_Basquet);
            this.Tbc_Estadistica.Controls.Add(this.Tbp_Beisbol);
            this.Tbc_Estadistica.Controls.Add(this.Tbp_Voleibol);
            this.Tbc_Estadistica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Estadistica.Location = new System.Drawing.Point(0, 0);
            this.Tbc_Estadistica.Name = "Tbc_Estadistica";
            this.Tbc_Estadistica.SelectedIndex = 4;
            this.Tbc_Estadistica.Size = new System.Drawing.Size(914, 523);
            this.Tbc_Estadistica.TabIndex = 0;
            this.Tbc_Estadistica.UseSelectable = true;
            // 
            // Tbp_Futbol
            // 
            this.Tbp_Futbol.Controls.Add(this.Btn_Ayuda_Futbol);
            this.Tbp_Futbol.HorizontalScrollbarBarColor = true;
            this.Tbp_Futbol.HorizontalScrollbarHighlightOnWheel = false;
            this.Tbp_Futbol.HorizontalScrollbarSize = 10;
            this.Tbp_Futbol.Location = new System.Drawing.Point(4, 38);
            this.Tbp_Futbol.Name = "Tbp_Futbol";
            this.Tbp_Futbol.Size = new System.Drawing.Size(906, 481);
            this.Tbp_Futbol.TabIndex = 1;
            this.Tbp_Futbol.Text = "Fútbol";
            this.Tbp_Futbol.VerticalScrollbarBarColor = true;
            this.Tbp_Futbol.VerticalScrollbarHighlightOnWheel = false;
            this.Tbp_Futbol.VerticalScrollbarSize = 10;
            // 
            // Tbp_Basquet
            // 
            this.Tbp_Basquet.Controls.Add(this.Btn_Ayuda_Basquet);
            this.Tbp_Basquet.HorizontalScrollbarBarColor = true;
            this.Tbp_Basquet.HorizontalScrollbarHighlightOnWheel = false;
            this.Tbp_Basquet.HorizontalScrollbarSize = 10;
            this.Tbp_Basquet.Location = new System.Drawing.Point(4, 38);
            this.Tbp_Basquet.Name = "Tbp_Basquet";
            this.Tbp_Basquet.Size = new System.Drawing.Size(906, 481);
            this.Tbp_Basquet.TabIndex = 2;
            this.Tbp_Basquet.Text = "Basquetbol";
            this.Tbp_Basquet.VerticalScrollbarBarColor = true;
            this.Tbp_Basquet.VerticalScrollbarHighlightOnWheel = false;
            this.Tbp_Basquet.VerticalScrollbarSize = 10;
            // 
            // Tbp_Beisbol
            // 
            this.Tbp_Beisbol.Controls.Add(this.Btn_Ayuda_Beisbol);
            this.Tbp_Beisbol.HorizontalScrollbarBarColor = true;
            this.Tbp_Beisbol.HorizontalScrollbarHighlightOnWheel = false;
            this.Tbp_Beisbol.HorizontalScrollbarSize = 10;
            this.Tbp_Beisbol.Location = new System.Drawing.Point(4, 38);
            this.Tbp_Beisbol.Name = "Tbp_Beisbol";
            this.Tbp_Beisbol.Size = new System.Drawing.Size(906, 481);
            this.Tbp_Beisbol.TabIndex = 3;
            this.Tbp_Beisbol.Text = "Béisbol";
            this.Tbp_Beisbol.VerticalScrollbarBarColor = true;
            this.Tbp_Beisbol.VerticalScrollbarHighlightOnWheel = false;
            this.Tbp_Beisbol.VerticalScrollbarSize = 10;
            // 
            // Tbp_Voleibol
            // 
            this.Tbp_Voleibol.Controls.Add(this.Btn_Ayuda_Voleibol);
            this.Tbp_Voleibol.HorizontalScrollbarBarColor = true;
            this.Tbp_Voleibol.HorizontalScrollbarHighlightOnWheel = false;
            this.Tbp_Voleibol.HorizontalScrollbarSize = 10;
            this.Tbp_Voleibol.Location = new System.Drawing.Point(4, 38);
            this.Tbp_Voleibol.Name = "Tbp_Voleibol";
            this.Tbp_Voleibol.Size = new System.Drawing.Size(906, 481);
            this.Tbp_Voleibol.TabIndex = 4;
            this.Tbp_Voleibol.Text = "Voleibol";
            this.Tbp_Voleibol.VerticalScrollbarBarColor = true;
            this.Tbp_Voleibol.VerticalScrollbarHighlightOnWheel = false;
            this.Tbp_Voleibol.VerticalScrollbarSize = 10;
            // 
            // Btn_Ayuda_Sistema
            // 
            this.Btn_Ayuda_Sistema.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Ayuda_Sistema.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar;
            this.Btn_Ayuda_Sistema.FlatAppearance.BorderSize = 0;
            this.Btn_Ayuda_Sistema.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuBar;
            this.Btn_Ayuda_Sistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ayuda_Sistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ayuda_Sistema.ForeColor = System.Drawing.Color.Brown;
            this.Btn_Ayuda_Sistema.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda_Sistema.Image")));
            this.Btn_Ayuda_Sistema.Location = new System.Drawing.Point(865, 3);
            this.Btn_Ayuda_Sistema.Name = "Btn_Ayuda_Sistema";
            this.Btn_Ayuda_Sistema.Size = new System.Drawing.Size(33, 32);
            this.Btn_Ayuda_Sistema.TabIndex = 28;
            this.Btn_Ayuda_Sistema.UseVisualStyleBackColor = false;
            // 
            // Btn_Ayuda_Futbol
            // 
            this.Btn_Ayuda_Futbol.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Ayuda_Futbol.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar;
            this.Btn_Ayuda_Futbol.FlatAppearance.BorderSize = 0;
            this.Btn_Ayuda_Futbol.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuBar;
            this.Btn_Ayuda_Futbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ayuda_Futbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ayuda_Futbol.ForeColor = System.Drawing.Color.Brown;
            this.Btn_Ayuda_Futbol.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda_Futbol.Image")));
            this.Btn_Ayuda_Futbol.Location = new System.Drawing.Point(865, 3);
            this.Btn_Ayuda_Futbol.Name = "Btn_Ayuda_Futbol";
            this.Btn_Ayuda_Futbol.Size = new System.Drawing.Size(33, 32);
            this.Btn_Ayuda_Futbol.TabIndex = 28;
            this.Btn_Ayuda_Futbol.UseVisualStyleBackColor = false;
            // 
            // Btn_Ayuda_Basquet
            // 
            this.Btn_Ayuda_Basquet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Ayuda_Basquet.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar;
            this.Btn_Ayuda_Basquet.FlatAppearance.BorderSize = 0;
            this.Btn_Ayuda_Basquet.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuBar;
            this.Btn_Ayuda_Basquet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ayuda_Basquet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ayuda_Basquet.ForeColor = System.Drawing.Color.Brown;
            this.Btn_Ayuda_Basquet.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda_Basquet.Image")));
            this.Btn_Ayuda_Basquet.Location = new System.Drawing.Point(865, 3);
            this.Btn_Ayuda_Basquet.Name = "Btn_Ayuda_Basquet";
            this.Btn_Ayuda_Basquet.Size = new System.Drawing.Size(33, 32);
            this.Btn_Ayuda_Basquet.TabIndex = 28;
            this.Btn_Ayuda_Basquet.UseVisualStyleBackColor = false;
            // 
            // Btn_Ayuda_Beisbol
            // 
            this.Btn_Ayuda_Beisbol.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Ayuda_Beisbol.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar;
            this.Btn_Ayuda_Beisbol.FlatAppearance.BorderSize = 0;
            this.Btn_Ayuda_Beisbol.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuBar;
            this.Btn_Ayuda_Beisbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ayuda_Beisbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ayuda_Beisbol.ForeColor = System.Drawing.Color.Brown;
            this.Btn_Ayuda_Beisbol.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda_Beisbol.Image")));
            this.Btn_Ayuda_Beisbol.Location = new System.Drawing.Point(865, 3);
            this.Btn_Ayuda_Beisbol.Name = "Btn_Ayuda_Beisbol";
            this.Btn_Ayuda_Beisbol.Size = new System.Drawing.Size(33, 32);
            this.Btn_Ayuda_Beisbol.TabIndex = 28;
            this.Btn_Ayuda_Beisbol.UseVisualStyleBackColor = false;
            // 
            // Btn_Ayuda_Voleibol
            // 
            this.Btn_Ayuda_Voleibol.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Ayuda_Voleibol.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar;
            this.Btn_Ayuda_Voleibol.FlatAppearance.BorderSize = 0;
            this.Btn_Ayuda_Voleibol.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuBar;
            this.Btn_Ayuda_Voleibol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ayuda_Voleibol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ayuda_Voleibol.ForeColor = System.Drawing.Color.Brown;
            this.Btn_Ayuda_Voleibol.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda_Voleibol.Image")));
            this.Btn_Ayuda_Voleibol.Location = new System.Drawing.Point(865, 3);
            this.Btn_Ayuda_Voleibol.Name = "Btn_Ayuda_Voleibol";
            this.Btn_Ayuda_Voleibol.Size = new System.Drawing.Size(33, 32);
            this.Btn_Ayuda_Voleibol.TabIndex = 28;
            this.Btn_Ayuda_Voleibol.UseVisualStyleBackColor = false;
            // 
            // FrmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(914, 523);
            this.Controls.Add(this.Tbc_Estadistica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstadisticas";
            this.Text = "FrmEstadisticas";
            this.Load += new System.EventHandler(this.FrmEstadisticas_Load);
            this.Tbp_Estadistica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Graf_Bitacora)).EndInit();
            this.Tbc_Estadistica.ResumeLayout(false);
            this.Tbp_Futbol.ResumeLayout(false);
            this.Tbp_Basquet.ResumeLayout(false);
            this.Tbp_Beisbol.ResumeLayout(false);
            this.Tbp_Voleibol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage Tbp_Estadistica;
        private MetroFramework.Controls.MetroTabControl Tbc_Estadistica;
        private MetroFramework.Controls.MetroTabPage Tbp_Futbol;
        private MetroFramework.Controls.MetroTabPage Tbp_Basquet;
        private MetroFramework.Controls.MetroTabPage Tbp_Beisbol;
        private MetroFramework.Controls.MetroTabPage Tbp_Voleibol;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graf_Bitacora;
        private System.Windows.Forms.Button Btn_Ayuda_Sistema;
        private System.Windows.Forms.Button Btn_Ayuda_Futbol;
        private System.Windows.Forms.Button Btn_Ayuda_Basquet;
        private System.Windows.Forms.Button Btn_Ayuda_Beisbol;
        private System.Windows.Forms.Button Btn_Ayuda_Voleibol;
    }
}