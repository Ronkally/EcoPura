﻿using EcoPuraLibreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoPura
{
    public partial class PopUpLavanderiaModificacion : MetroFramework.Forms.MetroForm
    {
        string _id;
        public PopUpLavanderiaModificacion(string id)
        {
            InitializeComponent();
            _id = id;
            LlenarCampos(id);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopUpAgregarFondo_Load(object sender, EventArgs e)
        {
            cbEstado.SelectedIndex = 1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validacion())
            {
                string query = $@"Update Limpiaduria Set Cliente='{tbCliente.Text}', telefono = '{tbTelefono.Text}', Estado = '{cbEstado.Text}', FechaInicial = '{dtFecha.Value.ToString("MM/dd/yyyy")}', FechaEntregado = '{dtFechaEntrega.Value.ToString("MM/dd/yyyy")}' where NumPedido = {_id}";
                DatabaseAccess.EjecutarConsulta(query);
                this.Close();
            }
        }

        private void LlenarCampos(string codigo)
        {
            string query = $@"Select Cliente, Telefono, FechaInicial, FechaEntregado, Estado FROM Limpiaduria WHERE NumPedido = {codigo}";

            DataTable da = DatabaseAccess.CargarTabla(query);

            tbCliente.Text = da.Rows[0][0].ToString();
            tbTelefono.Text = da.Rows[0][1].ToString();
            dtFecha.Value = DateTime.Parse(da.Rows[0][2].ToString());
            if (!Shared.InvalidString(da.Rows[0][3].ToString()))
            {
                dtFechaEntrega.Value = DateTime.Parse(da.Rows[0][3].ToString());
            }
            cbEstado.SelectedIndex = cbEstado.FindStringExact(da.Rows[0][4].ToString());
        }

        #region validaciones
        public bool validacion()
        {
            bool bandera = true;

            if (string.IsNullOrEmpty(tbCliente.Text) || tbCliente.Text.Equals("Ej. Juan") || tbCliente.Text.Equals("Ingresa un nombre valido") || Shared.InvalidString(tbTelefono.Text))
            {
                bandera = false;
                tbCliente.Text = "Ingresa un nombre valido";
                tbCliente.ForeColor = Color.Red;
            }

            if (!IsNumber(tbTelefono.Text) || tbTelefono.Text.Equals("Ej. 6647523659") || tbTelefono.Text.Equals("Ingresa un teléfono valido, solo números") || Shared.InvalidString(tbTelefono.Text))
            {
                bandera = false;
                tbTelefono.Text = "Ingresa un teléfono valido, solo números";
                tbTelefono.ForeColor = Color.Red;
            }

            return bandera;
        }
        private bool IsNumber(string text)
        {
            float parsedValue;

            if (!float.TryParse(text, out parsedValue))
                return false;
            else
                return parsedValue >= 0;
        }
        #endregion

        #region placeholders
        private void tbCliente_Enter(object sender, EventArgs e)
        {
            if (tbCliente.Text.Equals("Ej. Juan") || tbCliente.Text.Equals("Ingresa un nombre valido"))
            {
                tbCliente.Text = "";
                tbCliente.ForeColor = Color.Black;
            }
        }

        private void tbCliente_Leave(object sender, EventArgs e)
        {
            if (tbCliente.Text.Equals(""))
            {
                tbCliente.Text = "Ej. Juan";
                tbCliente.ForeColor = Color.Gray;
            }
        }

        private void tbTelefono_Enter(object sender, EventArgs e)
        {
            if (tbTelefono.Text.Equals("Ej. 6647523659") || tbTelefono.Text.Equals("Ingresa un teléfono valido, solo números"))
            {
                tbTelefono.Text = "";
                tbTelefono.ForeColor = Color.Black;
            }
        }

        private void tbTelefono_Leave(object sender, EventArgs e)
        {
            if (tbTelefono.Text.Equals(""))
            {
                tbTelefono.Text = "Ej. 6647523659";
                tbTelefono.ForeColor = Color.Gray;
            }
        }
        #endregion


    }
}
