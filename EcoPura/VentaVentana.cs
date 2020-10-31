using EcoPuraLibreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoPura
{
    public partial class VentaVentana : MetroFramework.Forms.MetroForm
    {
        public VentaVentana()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void VentaVentana1_Load(object sender, EventArgs e)
        {
            CargarGridView(0);      
            cbCategoria.SelectedIndex = 0;
        }


        private void CargarGridView(int i)
        {

            string fecha = dtFecha.Value.ToString("MM/dd/yyyy");
            string query = "";

            if( i == 0){
                 query = @"SELECT  Producto, SUM(Precio) AS Precio , sum(Cantidad) As Cantidad, sum(Importe) As Importe
                             FROM Ventas
                             WHERE FechaHora like '%" + fecha + "%' group by Producto, cantidad " +
                             "Order By cantidad desc";
            }
            else
            {
                 query = @"SELECT FechaHora as 'Fecha', Producto, Precio, Cantidad, Importe, Pago.Pago
                               FROM Ventas
                               LEFT JOIN Pago
                               ON Ventas.IdPago = Pago.IdPago
                               WHERE FechaHora like '%" + fecha + "%'";
            }


            gridview.DataSource = null;
            this.gridview.DataSource = DatabaseAccess.CargarTabla(query);
            if(i != 0)
            {
                gridview.Columns["Producto"].Width = 230;
                gridview.Columns["Fecha"].Width = 200;

            }

            gridview.Columns["Precio"].DefaultCellStyle.Format = "c";
            gridview.Columns["Precio"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-MX");

            gridview.Columns["Importe"].DefaultCellStyle.Format = "c";
            gridview.Columns["Importe"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-MX");

            gridview.ClearSelection();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbSearchBox_Enter(object sender, EventArgs e)
        {
        }

        private void tbSearchBox_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "¿Estás seguro que deseas borrar esta venta?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {

            }
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCategoria.SelectedIndex ==1)
                CargarGridView(1);
            else
                CargarGridView(0);
        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        { 
            if (cbCategoria.SelectedIndex == 1)
                CargarGridView(1);
            else
                CargarGridView(0);
        }

        private void btnGenerarVenta_Click(object sender, EventArgs e)
        {
            int i = cbCategoria.SelectedIndex;
            var venta = new PopUpVenta();
            venta.StartPosition = FormStartPosition.CenterParent;
            venta.ShowDialog();
            gridview.ClearSelection();
            CargarGridView(i);
        }
    }
}

