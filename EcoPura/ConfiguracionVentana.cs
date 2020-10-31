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
    public partial class ConfiguracionVentana : MetroFramework.Forms.MetroForm
    {
        public ConfiguracionVentana()
        {
            InitializeComponent();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                float tipoCambio = float.Parse(tbTipoCambio.Text);

                if (tipoCambio <= 0)
                    throw new Exception();

                string query1 = $@"update configuracion set impresora = '{cbImpresora.SelectedItem.ToString()}',
                tipoCambio = {tbTipoCambio.Text} where id = 1";
                DatabaseAccess.EjecutarConsulta(query1);
                MessageBox.Show("Configuración guardada");
                this.Close();

            }
            catch (Exception es)
            {
                MessageBox.Show("Error en el tipo de cambio");
                tbTipoCambio.Focus();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfiguracionVentana_Load(object sender, EventArgs e)
        {
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cbImpresora.Items.Add(printer);
            }

            string impresoraActual = DatabaseAccess.GetInfo("Select impresora from configuracion where id = 1");
            cbImpresora.Text = impresoraActual;

            float tipoDeCambio = DatabaseAccess.PrecioTotal("Select tipocambio from configuracion where id = 1");
            tbTipoCambio.Text = tipoDeCambio.ToString();
        }
    }
}
