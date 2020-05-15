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
    public partial class InicioVentana2 : MetroFramework.Forms.MetroForm
    {
        public InicioVentana2()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            var producto = new VentanaProducto1();
            producto.StartPosition = FormStartPosition.CenterParent;
            producto.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            var ventas = new VentaVentana1();
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
            var puntoVenta = new PuntoVentaVentana2();
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
    }
}
