﻿namespace PolideportivoAdmin_Proj.Mantenimientos.Gerencia
{
    partial class FrmBitacora
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tbc_Bitacora = new MetroFramework.Controls.MetroTabControl();
            this.Tbp_Bitacora = new MetroFramework.Controls.MetroTabPage();
            this.Dgv_Bitacora = new MetroFramework.Controls.MetroGrid();
            this.Tmr_Bitacora = new System.Windows.Forms.Timer(this.components);
            this.Tbc_Bitacora.SuspendLayout();
            this.Tbp_Bitacora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Bitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // Tbc_Bitacora
            // 
            this.Tbc_Bitacora.Controls.Add(this.Tbp_Bitacora);
            this.Tbc_Bitacora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Bitacora.Location = new System.Drawing.Point(0, 0);
            this.Tbc_Bitacora.Name = "Tbc_Bitacora";
            this.Tbc_Bitacora.SelectedIndex = 0;
            this.Tbc_Bitacora.Size = new System.Drawing.Size(914, 523);
            this.Tbc_Bitacora.TabIndex = 0;
            this.Tbc_Bitacora.UseSelectable = true;
            // 
            // Tbp_Bitacora
            // 
            this.Tbp_Bitacora.Controls.Add(this.Dgv_Bitacora);
            this.Tbp_Bitacora.HorizontalScrollbarBarColor = true;
            this.Tbp_Bitacora.HorizontalScrollbarHighlightOnWheel = false;
            this.Tbp_Bitacora.HorizontalScrollbarSize = 10;
            this.Tbp_Bitacora.Location = new System.Drawing.Point(4, 38);
            this.Tbp_Bitacora.Name = "Tbp_Bitacora";
            this.Tbp_Bitacora.Size = new System.Drawing.Size(906, 481);
            this.Tbp_Bitacora.TabIndex = 0;
            this.Tbp_Bitacora.Text = "Log de la Bitácora";
            this.Tbp_Bitacora.VerticalScrollbarBarColor = true;
            this.Tbp_Bitacora.VerticalScrollbarHighlightOnWheel = false;
            this.Tbp_Bitacora.VerticalScrollbarSize = 10;
            // 
            // Dgv_Bitacora
            // 
            this.Dgv_Bitacora.AllowUserToResizeRows = false;
            this.Dgv_Bitacora.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Dgv_Bitacora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Bitacora.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dgv_Bitacora.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Bitacora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_Bitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Bitacora.DefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_Bitacora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Bitacora.EnableHeadersVisualStyles = false;
            this.Dgv_Bitacora.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Dgv_Bitacora.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Dgv_Bitacora.Location = new System.Drawing.Point(0, 0);
            this.Dgv_Bitacora.Name = "Dgv_Bitacora";
            this.Dgv_Bitacora.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Bitacora.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_Bitacora.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgv_Bitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Bitacora.Size = new System.Drawing.Size(906, 481);
            this.Dgv_Bitacora.TabIndex = 2;
            // 
            // Tmr_Bitacora
            // 
            this.Tmr_Bitacora.Enabled = true;
            this.Tmr_Bitacora.Interval = 10000;
            this.Tmr_Bitacora.Tick += new System.EventHandler(this.Tmr_Bitacora_Tick);
            // 
            // FrmBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(914, 523);
            this.Controls.Add(this.Tbc_Bitacora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBitacora";
            this.Text = "FrmBitacora";
            this.Tbc_Bitacora.ResumeLayout(false);
            this.Tbp_Bitacora.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Bitacora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl Tbc_Bitacora;
        private MetroFramework.Controls.MetroTabPage Tbp_Bitacora;
        private MetroFramework.Controls.MetroGrid Dgv_Bitacora;
        private System.Windows.Forms.Timer Tmr_Bitacora;
    }
}