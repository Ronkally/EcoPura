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
    public partial class CambioVentana1 : MetroFramework.Forms.MetroForm
    {
        int contador = 0 ;
        public CambioVentana1()
        {
            InitializeComponent();
        }

        public CambioVentana1(float total, DataGridViewRowCollection rows)
        {
            InitializeComponent();
            txtCodigo.Focus();
            float settup = 0;
            lblTotal.Text = settup.ToString("C2", CultureInfo.CreateSpecificCulture("es-MX"));
            lblMonto.Text = total.ToString("C2", CultureInfo.CreateSpecificCulture("es-MX"));
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
            if(txtCodigo.Text.Length > 0)
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
            contador++;
            MetroFramework.MetroMessageBox.Show(this, "Gracias por su compra", "Gracias!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            this.Close();
        }

        private void Cambio()
        {

            float cantidadRecibida = float.Parse(txtCodigo.Text);
            float monto = float.Parse(lblMonto.Text);

            float diferencia = monto - cantidadRecibida;

            if (cantidadRecibida > monto)
            {
                float cambio = cantidadRecibida - Int32.Parse(lblTotal.Text);
                lblTotal.Text = cambio.ToString("C2", CultureInfo.CreateSpecificCulture("es-MX"));
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
            MetroFramework.MetroMessageBox.Show(this, "Gracias por su compra", "Gracias!", MessageBoxButtons.OK, MessageBoxIcon.Question);
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
