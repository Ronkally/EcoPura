using DespachaMas.UI.WinForms;
using EcoPuraLibreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoPura
{
    public partial class CajaVentana : MetroFramework.Forms.MetroForm
    {
        public CajaVentana()
        {
            InitializeComponent();
            gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            WindowState = FormWindowState.Maximized;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CajaVentana_Load(object sender, EventArgs e)
        {

            CargarGridView();
            gridview.Columns["Flujo"].DefaultCellStyle.Format = "c";
            gridview.Columns["Flujo"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-MX");

            gridview.Columns["NoTicket"].Width = 100;


        }

        private void SumarIngresos()
        {

        }


        private void CargarGridView()
        {
            /*string query = @"SELECT Codigo as 'Código De Barras', Descripcion as Descripción, Costo, Precio, Existencia, Clasificacion.Clasificacion As Clasificación, Proveedor.Proveedor
                             FROM Productos
                             LEFT JOIN Proveedor
                             ON Productos.IdProveedor = Proveedor.IdProveedor
                             LEFT JOIN Clasificacion*
                             ON Productos.IdClasificacion = Clasificacion.IdClasificacion";*/

            string query = @"SELECT Id As NoTicket, Ingreso As Flujo, Motivo, Fecha, Pago.Pago, Tipo
                            FROM CAJA
                            LEFT JOIN PAGO
                            ON Caja.IdPago = Pago.IdPago";

            this.gridview.DataSource = DatabaseAccess.CargarTabla(query);

            SumaIngresos();


            gridview.ClearSelection();
        }

        private void SumaIngresos()
        {
            float totalIngresosE = DatabaseAccess.PrecioTotal("SELECT SUM(INGRESO) FROM CAJA WHERE TIPO != 'Retiro' AND IdPago = 1");
            float totalRetiros = DatabaseAccess.PrecioTotal("SELECT SUM(INGRESO) FROM CAJA WHERE TIPO = 'Retiro'");
            float totalTarjeta = DatabaseAccess.PrecioTotal("SELECT SUM(INGRESO) FROM CAJA WHERE IdPago = 2");

            float total = totalIngresosE - totalRetiros;

            lblTotal.Text = total.ToString("C2", CultureInfo.CreateSpecificCulture("es-MX"));


            lblTotalTarjeta.Text = totalTarjeta.ToString("C2", CultureInfo.CreateSpecificCulture("es-MX"));

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (gridview.SelectedRows.Count > 0)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "¿Estás seguro que deseas borrar este flujo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    int selectedRowIndex = gridview.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = gridview.Rows[selectedRowIndex];
                    string codigo = selectedRow.Cells["NoTicket"].Value.ToString();
                    string query = $@"DELETE FROM Caja WHERE Id = '{codigo}'";
                    DatabaseAccess.EjecutarConsulta(query);
                    gridview.ClearSelection();
                    CargarGridView();
                }
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Por favor selecciona un flujo de la tabla para eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "¿Estás seguro que deseas hacer corte de caja?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                TicketCorte();
                DatabaseAccess.EjecutarConsulta("delete from caja ");
                DatabaseAccess.EjecutarConsulta("UPDATE SQLITE_SEQUENCE SET SEQ=0 WHERE NAME='caja';");
                CargarGridView();
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var sacarMonto = new PopUpSacarMonto();
            sacarMonto.StartPosition = FormStartPosition.CenterParent;
            sacarMonto.ShowDialog();
            CargarGridView();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var agregarFondo = new PopUpAgregarFondo();
            agregarFondo.StartPosition = FormStartPosition.CenterParent;
            agregarFondo.ShowDialog();
            CargarGridView();
        }


        private void TicketCorte()
        {
            if (DatabaseAccess.Existe("select count(producto) from VentasCorte"))
            {
                Ticket ticket = new Ticket();
                int noTicket = DatabaseAccess.Cantidad("select max(id) from caja");

                //Cabecera
                ticket.TextoCentro("EcoPura");
                ticket.TextoIzquierda("Corte de caja");
                ticket.TextoIzquierda("EXPEDIDO EN: LOCAL PRINCIPAL");
                ticket.TextoIzquierda("DIREC: Salvador Alvarado, Misión #4480, Soler, 22530 Tijuana, B.C.  ");
                ticket.TextoIzquierda("TEL: 664 975 4148");
                ticket.lineasAsteriscos();

                //Totales
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("FECHA: " + DateTime.Now.ToShortDateString());

                float VeinteL = DatabaseAccess.PrecioTotal("select sum(Importe) FROM VentasCorte WHERE Producto = '20 Litros Purificada'");
                float CincoGal = DatabaseAccess.PrecioTotal("select sum(Importe) FROM VentasCorte WHERE Producto = '5 Galones Purificada'");
                float TresGal = DatabaseAccess.PrecioTotal("select sum(Importe) FROM VentasCorte WHERE Producto = '3 Galones Purificada'");
                float totalGarrafones = VeinteL + CincoGal + TresGal;

                DataTable clasificaciones = DatabaseAccess.CargarTabla("SELECT sum(importe) as Total, Clasificacion.Clasificacion FROM VentasCorte  LEFT JOIN Clasificacion on VentasCorte.IdClasificacion = Clasificacion.IdClasificacion WHERE VentasCorte.IdClasificacion != 3 GROUP By VentasCorte.IdClasificacion");



                int totalVeinte = DatabaseAccess.Cantidad("select sum(Cantidad) FROM VentasCorte WHERE Producto = '20 Litros Purificada'");
                int totalCinco = DatabaseAccess.Cantidad("select sum(Cantidad) FROM VentasCorte WHERE Producto = '5 Galones Purificada'");
                int totalTres = DatabaseAccess.Cantidad("select sum(Cantidad) FROM VentasCorte WHERE Producto = '3 Galones Purificada'");

                int total = totalVeinte + totalCinco + totalTres;
                ticket.TextoIzquierda("Cantidad Garrafones Vendidos....." + total);
                ticket.TextoIzquierda("Total Venta Garrafones.....$" + totalGarrafones);
                if (clasificaciones != null)
                {
                    for (int i = 0; i < clasificaciones.Rows.Count; i++)
                    {
                        ticket.TextoIzquierda("Total Venta " + clasificaciones.Rows[i]["Clasificacion"].ToString() + ".....$" + clasificaciones.Rows[i]["Total"].ToString());

                    }
                }

                ticket.TextoIzquierda("Total Caja....." + lblTotal.Text);
                ticket.TextoIzquierda("Total Tarjeta....." + lblTotalTarjeta.Text);
                //Final
                float totalIngresosE = DatabaseAccess.PrecioTotal("SELECT SUM(INGRESO) FROM CAJA WHERE TIPO != 'Retiro' AND IdPago = 1");
                float totalRetiros = DatabaseAccess.PrecioTotal("SELECT SUM(INGRESO) FROM CAJA WHERE TIPO = 'Retiro'");
                float totalTarjeta = DatabaseAccess.PrecioTotal("SELECT SUM(INGRESO) FROM CAJA WHERE IdPago = 2");

                float totalt = totalTarjeta + (totalIngresosE - totalRetiros);


                ticket.TextoIzquierda("Total Venta Corte.....$" + totalt.ToString());
                // ticket.TextoIzquierda("");
                ticket.TextoCentro("¡Fin corte de caja!");
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                DatabaseAccess.EjecutarConsulta("Delete from VentasCorte");
                ticket.TextoIzquierda("");
                ticket.CortaTicket();
                try
                {

                    ticket.ImprimirTicket("Microsoft XPS Document Writer", "Corte de caja " + DateTime.Now.ToShortDateString());
                    ticket.ImprimirTicket(DatabaseAccess.GetInfo("select impresora from configuracion where id = 1"), "Corte de caja " + DateTime.Now.ToShortDateString());

                    ticket.ClearMethod();
                }
                catch (Exception s) { MessageBox.Show("Error al imprimir"); }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "No se puede hacer corte de caja aún", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }



        }

        private void gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
