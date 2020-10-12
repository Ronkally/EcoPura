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
    public partial class LavanderiaVentana : MetroFramework.Forms.MetroForm
    {
        public LavanderiaVentana()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarGridView()
        {
            string fecha = dtFecha.Value.ToString("MM/dd/yyyy");
            string query = $@"SELECT NUMPEDIDO AS NoPedido, Cliente, Telefono as Teléfono, Estado, FechaInicial, FechaEntregado
                             From limpiaduria
                             WHERE FechaInicial like '%{ fecha }%' AND Estado = '{cbCategoria.Text}'";

            this.gridview.DataSource = DatabaseAccess.CargarTabla(query);
            gridview.ClearSelection();
        }

        private void LavanderiaVentana_Load(object sender, EventArgs e)
        {
            cbCategoria.SelectedIndex = 0;
            CargarGridView();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var ventanaPedidos = new PopUpVentaLavanderia();
            ventanaPedidos.StartPosition = FormStartPosition.CenterParent;
            ventanaPedidos.ShowDialog();
            CargarGridView();
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGridView();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gridview.SelectedRows.Count > 0)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "¿Estás seguro que deseas borrar este pedido?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    int selectedRowIndex = gridview.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = gridview.Rows[selectedRowIndex];
                    string codigo = selectedRow.Cells["NoPedido"].Value.ToString();
                    string query = $@"DELETE FROM Limpiaduria WHERE NumPedido = '{codigo}'";
                    DatabaseAccess.EjecutarConsulta(query);
                    gridview.ClearSelection();
                    CargarGridView();
                }
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Por favor selecciona un producto de la tabla para eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (gridview.SelectedRows.Count > 0)
            {
                int selectedRowIndex = gridview.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = gridview.Rows[selectedRowIndex];
                string codigo = selectedRow.Cells["NoPedido"].Value.ToString();
                var popUpProducto = new PopUpLavanderiaModificacion(codigo);
                popUpProducto.StartPosition = FormStartPosition.CenterParent;
                popUpProducto.ShowDialog();
                gridview.ClearSelection();
                CargarGridView();
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Por favor selecciona un producto de la tabla para modificar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
