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
    public partial class CambioVentana1 : MetroFramework.Forms.MetroForm
    {
        float total = 0;
        public CambioVentana1()
        {
            InitializeComponent();
        }

        DataGridView gridview;

        public CambioVentana1(float total, DataGridView rows)
        {
            InitializeComponent();
            txtCodigo.Focus();

            float settup = 0;
            this.total = total;
            float dolares = total / 22;

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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Gracias por su compra", "Gracias!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            this.Close();
        }

        private void Cambio()
        {

            float cantidadRecibida = float.Parse(txtCodigo.Text);
            float monto = this.total;

            float diferencia = monto - cantidadRecibida;

            if (cantidadRecibida > monto)
            {
                float cambio = cantidadRecibida - total;
                lblTotal.Text = cambio.ToString("C2", CultureInfo.CreateSpecificCulture("es-MX"));
                cambio = cambio / 22;
                lblDolar.Text = cambio.ToString("C2", CultureInfo.CreateSpecificCulture("es-MX"));
                btnFinalizar.Visible = true;
            }
            else
            {

            }


            /*
            contador++;
            float cantidadRecibida = float.Parse(txtCodigo.Text);

            if (contador != 2)
            {
                if ((Int32.Parse(lblTotal.Text) - cantidadRecibida) >= 0)
               {
                    float cambio = cantidadRecibida - Int32.Parse(lblTotal.Text);
                    lblTotal.Text = cambio.ToString("C2", CultureInfo.CreateSpecificCulture("es-MX"));
                    btnFinalizar.Visible = true;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "No está recibiendo la cantidad suficiente para cubrir la venta", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else if (contador == 2)
            {
                MetroFramework.MetroMessageBox.Show(this, "Gracias por su compra", "Gracias!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                this.Close();
            }*/


        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "0";
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "¿Desea imprimir el Ticket de la venta?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Ticket ticket = new Ticket();
                //Cabecera
                ticket.TextoCentro("EcoPura");
                ticket.TextoIzquierda("EXPEDIDO EN: LOCAL PRINCIPAL");
                ticket.TextoIzquierda("DIREC: " + "");
                ticket.TextoIzquierda("");
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
                    /*  string query = $@"SELECT Descripcion, Costo, Precio, Existencia, Clasificacion.Clasificacion, Proveedor.Proveedor, Codigo, Minimo, Maximo
                               FROM Productos
                               LEFT JOIN Proveedor
                               ON Productos.IdProveedor = Proveedor.IdProveedor
                               LEFT JOIN Clasificacion
                               ON Productos.IdClasificacion = Clasificacion.IdClasificacion
                               WHERE Codigo = {codigo}";*/
                    // DatabaseAccess.
                }
                ticket.lineasGuio();

                float total = 0;

                foreach (DataGridViewRow rows in gridview.Rows)
                {
                    total += float.Parse(rows.Cells[4].Value.ToString());

                }

                //Resumen de la venta
                ticket.AgregarTotales("         TOTAL.........$", (decimal)total);
                ticket.TextoIzquierda("");

                //Texto final del Ticket.
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("ARTÍCULOS VENDIDOS: " + gridview.RowCount.ToString());
                ticket.TextoIzquierda("");
                ticket.TextoCentro("¡GRACIAS POR SU COMPRA!");
                ticket.CortaTicket();
                try
                {
                    // ticket.ImprimirTicket(ConseguirImpresora());
                }
                catch (Exception s) { MessageBox.Show("Error en la impresión"); }

            }
            this.Close();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void CambioVentana1_Load(object sender, EventArgs e)
        {

        }
    }
}
