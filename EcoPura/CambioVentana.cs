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
using DespachaMas.UI.WinForms;
using EcoPuraLibreria;

namespace EcoPura
{
    public partial class CambioVentana : MetroFramework.Forms.MetroForm
    {
        float total = 0;
        float totalrecibido = 0;
        bool tieneDolar = false;
        float cambioT = 0;
        public CambioVentana()
        {
            InitializeComponent();
        }

        DataGridView gridview;

        public CambioVentana(float total, DataGridView rows)
        {
            InitializeComponent();
            txtCodigo.Focus();

            float settup = 0;
            this.total = total;
            float dolares = total / DatabaseAccess.PrecioTotal("select tipocambio from configuracion where id = 1");

            this.gridview = rows;
            lblTotal.Text = settup.ToString("C2", CultureInfo.CreateSpecificCulture("es-MX"));
            lblMonto.Text = total.ToString("C2", CultureInfo.CreateSpecificCulture("es-MX"));
            lblDolar.Text = settup.ToString("C2", CultureInfo.CreateSpecificCulture("es-MX"));
            lblDolarTotal.Text = dolares.ToString("C2", CultureInfo.CreateSpecificCulture("es-MX"));
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "8";

        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "9";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length > 0)
            {
                txtCodigo.Text = txtCodigo.Text.Remove(txtCodigo.Text.Length - 1);
            }


        }

        private void btnRetroceso_Click(object sender, EventArgs e)
        {
            Cambio();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cambio();
            }
            else if (e.KeyCode == Keys.F1)
            {
                if (tieneDolar)
                {
                    txtCodigo.ForeColor = Color.Black;
                    tieneDolar = false;
                    button2.Text = "Ingresar Dólares";
                }
                else
                {
                    txtCodigo.ForeColor = Color.Green;
                    tieneDolar = true;
                    button2.Text = "Ingresar pesos";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tieneDolar)
            {
                txtCodigo.ForeColor = Color.Black;
                tieneDolar = false;
                button2.Text = "Ingresar Dólares";
            }
            else
            {
                txtCodigo.ForeColor = Color.Green;
                tieneDolar = true;
                button2.Text = "Ingresar pesos";
            }
            txtCodigo.Text = "";
            txtCodigo.Focus();
        }

        private void Cambio()
        {
            float cantidadRecibida = 0;

            try
            {
                cantidadRecibida = float.Parse(txtCodigo.Text);

                if (cantidadRecibida <= 0)
                    throw new ArgumentException();
            }
            catch (Exception e)
            {
                MessageBox.Show("Monto recibido erróneo ");
                return;
            }

            if (tieneDolar)
                cantidadRecibida = cantidadRecibida * DatabaseAccess.PrecioTotal("select tipocambio from configuracion where id = 1");

            totalrecibido += cantidadRecibida;
            float monto = this.total;

            float diferencia = monto - cantidadRecibida;

            if (cantidadRecibida >= monto)
            {
                float cambio = cantidadRecibida - total;
                cambioT = cambio;
                lblTotal.Text = cambio.ToString("C2", CultureInfo.CreateSpecificCulture("es-MX"));
                cambio = cambio / DatabaseAccess.PrecioTotal("select tipocambio from configuracion where id = 1");
                lblDolar.Text = cambio.ToString("C2", CultureInfo.CreateSpecificCulture("es-MX"));
                lblDolarTotal.Text = "0.00";
                lblMonto.Text = "0.00";


                btnFinalizar.Visible = true;
            }
            else
            {
                if (tieneDolar)
                {

                    total = total - cantidadRecibida;
                    float dolares = total / DatabaseAccess.PrecioTotal("select tipocambio from configuracion where id = 1");
                    lblDolarTotal.Text = dolares.ToString("C2", CultureInfo.CreateSpecificCulture("es-MX"));
                    lblMonto.Text = total.ToString("C2", CultureInfo.CreateSpecificCulture("es-MX"));
                }
                else
                {

                    total = total - cantidadRecibida;
                    float dolares = total / DatabaseAccess.PrecioTotal("select tipocambio from configuracion where id = 1");
                    lblDolarTotal.Text = dolares.ToString("C2", CultureInfo.CreateSpecificCulture("es-MX"));
                    lblMonto.Text = total.ToString("C2", CultureInfo.CreateSpecificCulture("es-MX"));

                }


            }
            txtCodigo.Text = "";
            txtCodigo.Focus();

        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "0";
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            float total = 0;
            string fechaHora = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
            foreach (DataGridViewRow fila in gridview.Rows)//dgvLista es el nombre del datagridview
            {

                string clasificacion = DatabaseAccess.GetInfo($@"SELECT IdClasificacion FROM Productos WHERE Descripcion = '{fila.Cells[1].Value.ToString()}'");
                if (String.IsNullOrEmpty(clasificacion))
                {
                    clasificacion = "3";
                }

                if (fila.Cells[1].Value.ToString().Contains("Alcalina"))
                {
                    clasificacion = "5";
                }


                int tipoPago = 2;
                if (RbEfectivo.Checked)
                    tipoPago = 1;


                string query = $@"Insert into Ventas (fechahora, producto, precio, cantidad, importe, idPago, IdClasificacion) values (
                '{fechaHora}','{fila.Cells[1].Value.ToString()}',
                {Decimal.Parse(fila.Cells[2].Value.ToString())},
                {Int32.Parse(fila.Cells[3].Value.ToString())},
                {Decimal.Parse(fila.Cells[4].Value.ToString())},
                {tipoPago}, {clasificacion}
                )";

                string query1 = $@"Insert into VentasCorte (fechahora, producto, precio, cantidad, importe, idPago, IdClasificacion) values (
                '{fechaHora}','{fila.Cells[1].Value.ToString()}',
                {Decimal.Parse(fila.Cells[2].Value.ToString())},
                {Int32.Parse(fila.Cells[3].Value.ToString())},
                {Decimal.Parse(fila.Cells[4].Value.ToString())},
                {tipoPago}, {clasificacion}
                )";

                total += float.Parse(fila.Cells[4].Value.ToString());

                DatabaseAccess.EjecutarConsulta(query1);
                DatabaseAccess.EjecutarConsulta(query);



            }
            Caja(total, fechaHora);



            ControlarInventarios();
            bool acepta = MetroFramework.MetroMessageBox.Show(this, "¿Desea imprimir el Ticket de la venta?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;


            Ticket ticket = new Ticket();
            int noTicket = DatabaseAccess.Cantidad("select max(id) from caja");

            //Cabecera
            ticket.TextoCentro("EcoPura");
            ticket.TextoIzquierda("No. Ticket: " + noTicket.ToString());
            ticket.TextoIzquierda("EXPEDIDO EN: LOCAL PRINCIPAL");
            ticket.TextoIzquierda("DIREC: Salvador Alvarado, Misión #4480, Soler, 22530 Tijuana, B.C.  ");
            ticket.TextoIzquierda("TEL: 664 975 4148");
            ticket.lineasAsteriscos();

            //Sub cabecera.
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("CLIENTE: PUBLICO EN GENERAL");
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString());
            ticket.lineasAsteriscos();

            ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
            ticket.lineasAsteriscos();

            foreach (DataGridViewRow fila in gridview.Rows)//dgvLista es el nombre del datagridview
            {


                ticket.AgregaArticulo(fila.Cells[1].Value.ToString(), Int32.Parse(fila.Cells[3].Value.ToString()), Decimal.Parse(fila.Cells[2].Value.ToString()), Decimal.Parse(fila.Cells[4].Value.ToString()));


            }
            ticket.lineasGuio();


            //Resumen de la venta
            ticket.AgregarTotales("         TOTAL.........$", (decimal)total);
            ticket.AgregarTotales("         RECIBIDO......$", (decimal)totalrecibido);
            ticket.AgregarTotales("         CAMBIO........$", (decimal)cambioT);
            // ticket.TextoIzquierda("");

            //Texto final del Ticket.
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("ARTÍCULOS VENDIDOS: " + gridview.RowCount.ToString());
            // ticket.TextoIzquierda("");
            ticket.TextoCentro("¡GRACIAS POR SU COMPRA!");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.CortaTicket();
            try
            {

                ticket.ImprimirTicket("Microsoft XPS Document Writer", "No. Ticket: " + noTicket.ToString());

                if (acepta)
                    ticket.ImprimirTicket(DatabaseAccess.GetInfo("select impresora from configuracion where id = 1"), "No. Ticket: " + noTicket.ToString());

                ticket.ClearMethod();
            }
            catch (Exception s) { MessageBox.Show("Error al imprimir"); }

            this.Close();
        }
        private void ControlarInventarios()
        {
            foreach (DataGridViewRow fila in gridview.Rows)//dgvLista es el nombre del datagridview
            {

                if (!fila.Cells[0].Value.ToString().Equals(""))
                {
                    int cantidad = DatabaseAccess.Cantidad("SELECT existencia FROM PRODUCTOS WHERE Codigo = '" + fila.Cells[0].Value.ToString() + "'");

                    if (cantidad < Int32.Parse(fila.Cells[3].Value.ToString()))
                        cantidad = 0;
                    else
                        cantidad -= Int32.Parse(fila.Cells[3].Value.ToString());


                    DatabaseAccess.EjecutarConsulta("UPDATE PRODUCTOS SET existencia = " + cantidad.ToString() + " WHERE Codigo ='" + fila.Cells[0].Value.ToString() + "'");

                }
            }

        }
        private void Caja(float total, string fechaHora)
        {
            int tipoPago = 2;
            if (RbEfectivo.Checked)
                tipoPago = 1;

            string query = $@"Insert into caja (Ingreso, motivo, Fecha, idpago, tipo) values({total}, 'Venta', '{fechaHora}', {tipoPago},'Ingreso')";
            DatabaseAccess.EjecutarConsulta(query);
        }
    }
}
