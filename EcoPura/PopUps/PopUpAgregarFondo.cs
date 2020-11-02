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
    public partial class PopUpAgregarFondo : MetroFramework.Forms.MetroForm
    {
        public PopUpAgregarFondo()
        {
            InitializeComponent();
        }

        private void PopUpAgregarFondo_Load(object sender, EventArgs e)
        {
            cbTipo.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Shared.InvalidString(tbMotivo.Text))
                    throw new ArgumentException();

                string fechaHora = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
                float montoAgregado = float.Parse(tbAgregado.Text);

                if (montoAgregado <= 0)
                    throw new ArgumentException();

                string descripcion = tbMotivo.Text;
                int tipoPago = 1;

                if (cbTipo.SelectedIndex == 1)
                    tipoPago = 2;



                string query = $@"Insert into caja (Ingreso, motivo, Fecha, idpago, tipo) values({montoAgregado}, '{descripcion}', '{fechaHora}', {tipoPago},'Ingreso')";
                DatabaseAccess.EjecutarConsulta(query);
                this.Close();

            }
            catch (Exception es)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error en el monto a ingresar y/o no hay motivo especificado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
