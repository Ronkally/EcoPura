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
    public partial class PopUpSacarMonto : MetroFramework.Forms.MetroForm
    {
        public PopUpSacarMonto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Shared.InvalidString(tbMotivo.Text))
                    throw new ArgumentException();

                string fechaHora = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
                float montoRetirado = float.Parse(tbRetirado.Text);

                if (montoRetirado <= 0)
                    throw new ArgumentException();

                string descripcion = tbMotivo.Text;

                float totalCaja = DatabaseAccess.PrecioTotal("SELECT SUM(INGRESO) FROM CAJA WHERE TIPO != 'Retiro' AND IdPago = 1");

                if (totalCaja >= montoRetirado)
                {
                    string query = $@"Insert into caja (Ingreso, motivo, Fecha, idpago, tipo) values({montoRetirado}, '{descripcion}', '{fechaHora}', {1},'Retiro')";
                    DatabaseAccess.EjecutarConsulta(query);
                    this.Close();
                }
                else
                    MessageBox.Show("No hay suficiente dinero en caja");
            }
            catch (Exception es)
            {
                MessageBox.Show("Error en el monto a retirar y/o no hay motivo especifícado");
            }
        }
    }
}
