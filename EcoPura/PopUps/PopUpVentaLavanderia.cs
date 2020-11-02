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
        User _user;
        public PopUpVentaLavanderia(User user)
        {
            InitializeComponent();
            _user = user;
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

                string query = $@"Insert into Limpiaduria (Cliente, Telefono, Costo, Recibido, Estado, FechaInicial, FechaEntregado) values('{tbCliente.Text}', '{tbTelefono.Text}',{tbPrecio.Text},{tbAbono.Text},'Recibido','{dtFecha.Value.ToString("MM/dd/yyyy")}', null)";
                DatabaseAccess.EjecutarConsulta(query);

                string query1 = $@"Insert into caja (Ingreso, motivo, Fecha, idpago, tipo) values({tbAbono.Text}, 'Pedido de Limpiaduría', '{dtFecha.Value.ToString("MM/dd/yyyy")}', '{pago}','Ingreso')";
                DatabaseAccess.EjecutarConsulta(query1);

                string query2 = $@"Insert into VentasCorte (fechahora, producto, precio, cantidad, importe, idPago, IdClasificacion) values (
                '{dtFecha.Value.ToString("MM/dd/yyyy")}','Pedido Limpiaduría',
                {tbAbono.Text},
                1,
                {tbAbono.Text},
                '{pago}', 6
                )";

                DatabaseAccess.EjecutarConsulta(query2);

                string query3 = $@"Insert into Ventas (fechahora, producto, precio, cantidad, importe, idPago, IdClasificacion, IdUsuario) values (
                '{dtFecha.Value.ToString("MM/dd/yyyy")}','Pedido Limpiaduría',
                {tbPrecio.Text},
                1,
                {tbPrecio.Text},
                '{pago}', 6, {_user.Id}
                )";


                DatabaseAccess.EjecutarConsulta(query3);
                this.Close();
            }
        }

        #region validaciones
        public bool validacion()
        {
            bool bandera = true;

            if (string.IsNullOrEmpty(tbCliente.Text) || tbCliente.Text.Equals("Ej. Juan") || tbCliente.Text.Equals("Ingresa un nombre válido") || Shared.InvalidString(tbCliente.Text))
            {
                bandera = false;
                tbCliente.Text = "Ingresa un nombre válido";
                tbCliente.ForeColor = Color.Red;
            }

            if (!IsNumber(tbPrecio.Text) || tbPrecio.Text.Equals("Ej. 50") || tbPrecio.Text.Equals("Ingresa un precio válido") || Shared.InvalidString(tbPrecio.Text))
            {
                bandera = false;
                tbPrecio.Text = "Ingresa un precio válido";
                tbPrecio.ForeColor = Color.Red;
            }

            if (!IsNumber(tbTelefono.Text) || tbTelefono.Text.Equals("Ej. 6647523659") || tbTelefono.Text.Equals("Ingresa un teléfono válido, solo números") || Shared.InvalidString(tbTelefono.Text))
            {
                bandera = false;
                tbTelefono.Text = "Ingresa un teléfono válido, solo números";
                tbTelefono.ForeColor = Color.Red;
            }

            if (!IsNumber(tbAbono.Text) || tbAbono.Text.Equals("Ej. 50") || tbAbono.Text.Equals("Ingresa un valor válido") || Shared.InvalidString(tbTelefono.Text) || float.Parse(tbAbono.Text) > float.Parse(tbPrecio.Text))
            {
                bandera = false;
                tbAbono.Text = "Ingresa un valor válido";
                tbAbono.ForeColor = Color.Red;
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
            if (tbCliente.Text.Equals("Ej. Juan") || tbCliente.Text.Equals("Ingresa un nombre válido"))
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
            if (tbPrecio.Text.Equals("Ej. 50") || tbPrecio.Text.Equals("Ingresa un precio válido"))
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
            if (tbTelefono.Text.Equals("Ej. 6647523659") || tbTelefono.Text.Equals("Ingresa un teléfono válido, solo números"))
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

        private void tbAbono_Enter(object sender, EventArgs e)
        {
            if (tbAbono.Text.Equals("Ej. 50") || tbAbono.Text.Equals("Ingresa un valor válido"))
            {
                tbAbono.Text = "";
                tbAbono.ForeColor = Color.Black;
            }
        }

        private void tbAbono_Leave(object sender, EventArgs e)
        {
            if (tbAbono.Text.Equals(""))
            {
                tbAbono.Text = "Ej. 50";
                tbAbono.ForeColor = Color.Gray;
            }
        }
    }
}
