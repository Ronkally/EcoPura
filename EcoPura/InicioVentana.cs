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
    public partial class InicioVentana : MetroFramework.Forms.MetroForm
    {
        User _user;
        public InicioVentana(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            var producto = new VentanaProducto();
            producto.StartPosition = FormStartPosition.CenterParent;
            producto.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            var ventas = new VentaVentana();
            ventas.StartPosition = FormStartPosition.CenterParent;
            ventas.ShowDialog();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            var caja = new CajaVentana();
            caja.StartPosition = FormStartPosition.CenterParent;
            caja.ShowDialog();
        }

        private void btnPuntoVenta_Click(object sender, EventArgs e)
        {
            var puntoVenta = new PuntoVentaVentana();
            puntoVenta.StartPosition = FormStartPosition.CenterParent;
            puntoVenta.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLavanderia_Click(object sender, EventArgs e)
        {
            var lavanderia = new LavanderiaVentana();
            lavanderia.StartPosition = FormStartPosition.CenterParent;
            lavanderia.ShowDialog();
        }

        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            var configuracion = new ConfiguracionVentana();
            configuracion.StartPosition = FormStartPosition.CenterParent;
            configuracion.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (!Shared.Autorizacion(_user))
            {
                MetroFramework.MetroMessageBox.Show(this, "No estás autorizado para entrar a esta ventana", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void InicioVentana_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "¿Estás seguro que deseas salir de la aplicación?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
