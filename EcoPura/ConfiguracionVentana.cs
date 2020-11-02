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

                if (tipoCambio <= 0 || Shared.InvalidString(tbCorreo.Text))
                    throw new Exception();

                string query1 = $@"update configuracion  set Correo = '{tbCorreo.Text}', impresora = '{cbImpresora.SelectedItem.ToString()}',
                tipoCambio = {tbTipoCambio.Text} where id = 1";
                DatabaseAccess.EjecutarConsulta(query1);
                MetroFramework.MetroMessageBox.Show(this, "Configuración guardada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Question);
                this.Close();

            }
            catch (Exception es)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error al establecer el tipo de cambio o el correo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            string correo = DatabaseAccess.GetInfo("Select correo from configuracion where id = 1");
            tbCorreo.Text = correo;
        }
    }
}
