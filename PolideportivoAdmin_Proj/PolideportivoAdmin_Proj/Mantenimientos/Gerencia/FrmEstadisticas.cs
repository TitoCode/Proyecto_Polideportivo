﻿using PolideportivoAdmin_Proj.Clases.ClsGerencia;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolideportivoAdmin_Proj.Mantenimientos.Gerencia
{
    public partial class FrmEstadisticas : Form
    {
        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        ClsMantenimientoEstadisticas Estadisticas = new ClsMantenimientoEstadisticas();
        ClsConexion conexion = new ClsConexion();

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            GraficoBitacora();
        }

        public void GraficoBitacora()
        {
            ArrayList Usuarios = new ArrayList();
            ArrayList Logs = new ArrayList();
            try
            {
                string BuscarDatoEmpleado = "SELECT ID_USUARIO_FK, COUNT(ID_USUARIO_FK) FROM BITACORA GROUP BY ID_USUARIO_FK;";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(BuscarDatoEmpleado, conexion.conexion());
                OdbcDataReader Lector = Query_Busqueda1.ExecuteReader();
                while (Lector.Read())
                {
                    Usuarios.Add(Lector.GetString(0));
                    Logs.Add(Lector.GetString(1));
                }
                Graf_Bitacora.Series[0].Points.DataBindXY(Usuarios, Logs);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
