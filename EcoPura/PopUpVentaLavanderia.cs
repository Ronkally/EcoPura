using EcoPuraLibreria;
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
    public partial class PopUpVentaLavanderia : MetroFramework.Forms.MetroForm
    {
        public PopUpVentaLavanderia()
        {
            InitializeComponent();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopUpAgregarFondo_Load(object sender, EventArgs e)
        {
            cbTipoDePago.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validacion())
            {
                int pago = cbTipoDePago.SelectedIndex == 0 ? 1 : 2;

                string query = $@"Insert into Limpiaduria (Cliente, Telefono, Costo, Recibido, Estado, FechaInicial, FechaEntregado) values('{tbCliente.Text}', '{tbTelefono.Text}',{tbPrecio.Text},0,'Recibido','{dtFecha.Value.ToString("MM/dd/yyyy")}', null)";
                DatabaseAccess.EjecutarConsulta(query);

                string query1 = $@"Insert into caja (Ingreso, motivo, Fecha, idpago, tipo) values({tbPrecio.Text}, 'Pedido de Limpiaduría', '{dtFecha.Value.ToString("MM/dd/yyyy")}', '{pago}','Ingreso')";
                DatabaseAccess.EjecutarConsulta(query1);

                string query2 = $@"Insert into VentasCorte (fechahora, producto, precio, cantidad, importe, idPago, IdClasificacion) values (
                '{dtFecha.Value.ToString("MM/dd/yyyy")}','Pedido Limpiaduría',
                {tbPrecio.Text},
                1,
                {tbPrecio.Text},
                '{pago}', 6
                )";

                DatabaseAccess.EjecutarConsulta(query2);
                this.Close();
            }
        }

        #region validaciones
        public bool validacion()
        {
            bool bandera = true;

            if (string.IsNullOrEmpty(tbCliente.Text) || tbCliente.Text.Equals("Ej. Juan") || tbCliente.Text.Equals("Ingresa un nombre valido"))
            {
                bandera = false;
                tbCliente.Text = "Ingresa un nombre valido";
                tbCliente.ForeColor = Color.Red;
            }

            if (!IsNumber(tbPrecio.Text) || tbPrecio.Text.Equals("Ej. 50") || tbPrecio.Text.Equals("Ingresa un precio valido"))
            {
                bandera = false;
                tbPrecio.Text = "Ingresa un precio valido";
                tbPrecio.ForeColor = Color.Red;
            }

            if (!IsNumber(tbTelefono.Text) || tbTelefono.Text.Equals("Ej. 6647523659") || tbTelefono.Text.Equals("Ingresa un teléfono valido, solo números"))
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

            return true;
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

        private void tbPrecio_Enter(object sender, EventArgs e)
        {
            if (tbPrecio.Text.Equals("Ej. 50") || tbPrecio.Text.Equals("Ingresa un precio valido"))
            {
                tbPrecio.Text = "";
                tbPrecio.ForeColor = Color.Black;
            }
        }

        private void tbPrecio_Leave(object sender, EventArgs e)
        {
            if (tbPrecio.Text.Equals(""))
            {
                tbPrecio.Text = "Ej. 50";
                tbPrecio.ForeColor = Color.Gray;
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
