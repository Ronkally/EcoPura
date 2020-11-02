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
    public partial class PopUpAbonar : MetroFramework.Forms.MetroForm
    {
        string _codigo;
        User _user;
        public PopUpAbonar(string codigo, User user)
        {
            InitializeComponent();
            LlenarCampos(codigo);
            _user = user;
            _codigo = codigo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Shared.InvalidString(tbAbono.Text))
                    throw new ArgumentException();

                float montoAbonar = float.Parse(tbAbono.Text);

                if (montoAbonar <= 0 || (montoAbonar + float.Parse(tbRecibido.Text)) > float.Parse(tbCosto.Text))
                    throw new ArgumentException();

                int tipoPago = 1;

                if (cbTipoDePago.SelectedIndex == 1)
                    tipoPago = 2;

                string query = $@"Insert into caja (Ingreso, motivo, Fecha, idpago, tipo) values({montoAbonar}, 'Abono a pedido limpiaduría', '{DateTime.Now.ToString("MM/dd/yyyy")}', {tipoPago},'Ingreso')";
                DatabaseAccess.EjecutarConsulta(query);


                if (montoAbonar + float.Parse(tbRecibido.Text) == float.Parse(tbCosto.Text))
                {
                    string query1 = $@"Update Limpiaduria Set Recibido = {(montoAbonar + float.Parse(tbRecibido.Text))}, Estado = 'Entregado', FechaEntregado = '{DateTime.Now.ToString("MM/dd/yyyy")}' WHERE NumPedido = {_codigo}";
                    DatabaseAccess.EjecutarConsulta(query1);
                }
                else
                {
                    string query1 = $@"Update Limpiaduria Set Recibido = {(montoAbonar + float.Parse(tbRecibido.Text))} WHERE NumPedido = {_codigo}";
                    DatabaseAccess.EjecutarConsulta(query1);
                }

                string query2 = $@"Insert into VentasCorte (fechahora, producto, precio, cantidad, importe, idPago, IdClasificacion) values (
                '{DateTime.Now.ToString("MM/dd/yyyy")}','Pedido Limpiaduría',
                {tbAbono.Text},
                1,
                {tbAbono.Text},
                '{tipoPago}', 6
                )";

                DatabaseAccess.EjecutarConsulta(query2);
                this.Close();
            }
            catch (Exception es)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error en el monto para realizar el abono", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopUpAbonar_Load(object sender, EventArgs e)
        {
            cbTipoDePago.SelectedIndex = 0;
        }

        private void LlenarCampos(string codigo)
        {
            string query = $@"SELECT Costo, Recibido From Limpiaduria
                             Where NumPedido = {codigo}";

            DataTable da = DatabaseAccess.CargarTabla(query);

            tbCosto.Text = da.Rows[0][0].ToString();
            tbRecibido.Text = da.Rows[0][1].ToString();
        }
    }
}
