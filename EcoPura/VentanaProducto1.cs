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
    public partial class VentanaProducto1 : MetroFramework.Forms.MetroForm
    {
        public VentanaProducto1()
        {
            InitializeComponent();
            gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            WindowState = FormWindowState.Maximized;
        }

        private void VentanaProducto1_Load(object sender, EventArgs e)
        {
            CargarGridView();
        }

        private void CargarGridView()
        {
            string query = @"SELECT Codigo as 'Código De Barras', Descripcion as Descripción, Costo, Precio, Existencia, Clasificacion.Clasificacion As Clasificación, Proveedor.Proveedor
                             FROM Productos
                             LEFT JOIN Proveedor
                             ON Productos.IdProveedor = Proveedor.IdProveedor
                             LEFT JOIN Clasificacion
                             ON Productos.IdClasificacion = Clasificacion.IdClasificacion";

            this.gridview.DataSource = DatabaseAccess.CargarTabla(query);
            gridview.ClearSelection();
        }
        private void Busqueda()
        {
            //where nombre like '% variable %'
            string query = $@"SELECT Codigo as 'Código De Barras', Descripcion as Descripción, Costo, Precio, Existencia, Clasificacion.Clasificacion As Clasificación, Proveedor.Proveedor
                             FROM Productos
                             LEFT JOIN Proveedor
                             ON Productos.IdProveedor = Proveedor.IdProveedor
                             LEFT JOIN Clasificacion
                             ON Productos.IdClasificacion = Clasificacion.IdClasificacion
                             WHERE Descripcion LIKE '%{tbSearchBox.Text}%'";

            gridview.DataSource = DatabaseAccess.CargarTabla(query);
            gridview.ClearSelection();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var popUpProducto1 = new PopUpProducto1();
            popUpProducto1.StartPosition = FormStartPosition.CenterParent;
            popUpProducto1.ShowDialog();
            gridview.ClearSelection();
            CargarGridView();
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gridview.SelectedRows.Count > 0)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "¿Estás seguro que deseas borrar este producto?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    int selectedRowIndex = gridview.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = gridview.Rows[selectedRowIndex];
                    int codigo = Convert.ToInt32(selectedRow.Cells["Código De Barras"].Value);
                    string query = $@"DELETE FROM Productos WHERE Codigo = {codigo}";
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
            Modificar();
        }

        private void Modificar()
        {
            if (gridview.SelectedRows.Count > 0)
            {
                int selectedRowIndex = gridview.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = gridview.Rows[selectedRowIndex];
                int codigo = Convert.ToInt32(selectedRow.Cells["Código De Barras"].Value);
                var popUpProducto = new PopUpProducto1(codigo);
                popUpProducto.StartPosition = FormStartPosition.CenterParent;
                popUpProducto.ShowDialog();
                gridview.ClearSelection();
                CargarGridView();
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Por favor selecciona un producto de la tabla para modificar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Busqueda();
        }

        private void tbSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Busqueda();
            }
        }

        private void tbSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (tbSearchBox.Text.Equals(""))
            {
                Busqueda();
            }
        }

        private void tbSearchBox_Enter(object sender, EventArgs e)
        {
            if (tbSearchBox.Text.Equals("Busqueda de productos"))
            {
                tbSearchBox.Text = "";
                tbSearchBox.ForeColor = Color.Black;
            }
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            PopUpProveedores proveedores = new PopUpProveedores();
            proveedores.StartPosition = FormStartPosition.CenterParent;
            proveedores.ShowDialog();
            gridview.ClearSelection();
            CargarGridView();
        }

        private void btnClasificación_Click(object sender, EventArgs e)
        {
            PopUpClasificacion clasificacion = new PopUpClasificacion();
            clasificacion.StartPosition = FormStartPosition.CenterParent;
            clasificacion.ShowDialog();
            gridview.ClearSelection();
            CargarGridView();
        }
    }
}
