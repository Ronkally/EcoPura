using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Globalization;
using System.Windows.Forms;
using EcoPuraLibreria;

namespace EcoPura
{
    public partial class Productos : Form
    {

        int posY = 0;
        int posX = 0;
        public Productos()
        {
            InitializeComponent();
        }
        private void VentanaProducto_Load(object sender, EventArgs e)
        {
            CargarGridView();
        }
        private void CargarGridView()
        {
            string query = @"SELECT Descripcion as Descripción, Costo, Precio, Existencia, Clasificacion.Clasificacion As Clasificación, Proveedor.Proveedor, Codigo as CódigoDeBarras
                             FROM Productos
                             INNER JOIN Proveedor
                             ON Productos.IdProveedor = Proveedor.IdProveedor
                             INNER JOIN Clasificacion
                             ON Productos.IdClasificacion = Clasificacion.IdClasificacion";

            this.dataGridView1.DataSource = DatabaseAccess.CargarTabla(query);
            dataGridView1.ClearSelection();
        }
        private void Busqueda()
        {
            //where nombre like '% variable %'
            string query = $@"SELECT Descripcion as Descripción, Costo, Precio, Existencia, Clasificacion.Clasificacion As Clasificación, Proveedor.Proveedor, Codigo as CódigoDeBarras
                             FROM Productos
                             INNER JOIN Proveedor
                             ON Productos.IdProveedor = Proveedor.IdProveedor
                             INNER JOIN Clasificacion
                             ON Productos.IdClasificacion = Clasificacion.IdClasificacion
                             WHERE Descripcion LIKE '%{SearchBox.Text}%'";

            dataGridView1.DataSource = DatabaseAccess.CargarTabla(query);
            dataGridView1.ClearSelection();
        }
        private void Minimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MenuTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                int codigo = Convert.ToInt32(selectedRow.Cells["CódigoDeBarras"].Value);
                string query = $@"DELETE FROM Productos WHERE Codigo = {codigo}";
                DatabaseAccess.EjecutarConsulta(query);
                dataGridView1.ClearSelection();
                CargarGridView();
            }   
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var popUpProducto = new PopUpProducto();
            popUpProducto.StartPosition = FormStartPosition.CenterParent;
            popUpProducto.ShowDialog();
            dataGridView1.ClearSelection();
            CargarGridView();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Busqueda();
        }
        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Busqueda();
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void Modificar()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                int codigo = Convert.ToInt32(selectedRow.Cells["CódigoDeBarras"].Value);
                var popUpProducto = new PopUpProducto(codigo);
                popUpProducto.StartPosition = FormStartPosition.CenterParent;
                popUpProducto.ShowDialog();
                dataGridView1.ClearSelection();
                CargarGridView();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Modificar();
        }
    }
}
