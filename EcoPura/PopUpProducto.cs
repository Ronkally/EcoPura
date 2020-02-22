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
    public partial class PopUpProducto : Form
    {
        private int posX = 0;
        private int posY = 0;
        Boolean Actualizar = false;
        int codigo;
        public PopUpProducto()
        {
            InitializeComponent();
        }
        public PopUpProducto(int codigo)
        {
            InitializeComponent();     
            LlenarCampos(codigo);
            Actualizar = true;
            this.codigo = codigo;

        }
        private void PopUpProducto_Load(object sender, EventArgs e)
        {
            CargarClasificacion();
            CargarProveedores();
        }

        private void MenuTopp_MouseMove(object sender, MouseEventArgs e)
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
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(Actualizar)
                GuardarProducto();
            else

            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbMaximo_TextChanged(object sender, EventArgs e)
        {

        }

        #region Metodos
        private void CargarProveedores()
        {
            string query = @"Select * FROM Proveedor";
            DataTable Proveedores = DatabaseAccess.CargarTabla(query);
            using (Proveedores)
            {
                foreach (DataRow fila in Proveedores.Rows)
                {
                    cbProveedor.Items.Add(fila["Proveedor"].ToString());
                }
            }
        }

        private void CargarClasificacion()
        {
            string query = @"Select * from Clasificacion";
            DataTable Clasificacion = DatabaseAccess.CargarTabla(query);
            using (Clasificacion)
            {
                foreach (DataRow fila in Clasificacion.Rows)
                {
                    cbClasificacion.Items.Add(fila["Clasificacion"].ToString());
                }
            }
        }

        private void GuardarProducto()
        {
            //Validacion
            string getProveedorId = $@"(SELECT IdProveedor 
                                            FROM Proveedor
                                            WHERE Proveedor = '{cbProveedor.SelectedItem.ToString()}')";


            string getClasificacionId = $@"(SELECT IdClasificacion 
                                            FROM Clasificacion
                                            WHERE Clasificacion = '{cbClasificacion.SelectedItem.ToString()}')";


            string query = $@"Insert into Productos 
                             (Codigo, Descripcion, IdClasificacion, IdProveedor, Costo, Precio, Existencia, Minimo, Maximo)
                             Values ({tbBarras.Text}, '{tbDescripcioon.Text}',{getClasificacionId}, {getProveedorId}, {tbCosto.Text}, {tbPrecio.Text}, {tbExistencia.Text}, {tbMinimo.Text}, {tbMaximo.Text} )";
           
            DatabaseAccess.EjecutarConsulta(query);
        }
        private void ActualizarProducto()
        {
            string getProveedorId = $@"(SELECT IdProveedor 
                                            FROM Proveedor
                                            WHERE Proveedor = '{cbProveedor.SelectedItem.ToString()}')";


            string getClasificacionId = $@"(SELECT IdClasificacion 
                                            FROM Clasificacion
                                            WHERE Clasificacion = '{cbClasificacion.SelectedItem.ToString()}')";

            string query = $@"UPDATE Productos
                              SET ";
        }

        private void LlenarCampos(int codigo)
        {
            string query = $@"SELECT Descripcion, Costo, Precio, Existencia, Clasificacion.Clasificacion, Proveedor.Proveedor, Codigo, Minimo, Maximo
                             FROM Productos
                             INNER JOIN Proveedor
                             ON Productos.IdProveedor = Proveedor.IdProveedor
                             INNER JOIN Clasificacion
                             ON Productos.IdClasificacion = Clasificacion.IdClasificacion
                             WHERE Codigo = {codigo}";

            DataTable da = DatabaseAccess.CargarTabla(query);

            tbDescripcioon.Text = da.Rows[0][0].ToString();
            tbCosto.Text = da.Rows[0][1].ToString();
            tbPrecio.Text = da.Rows[0][2].ToString();
            tbExistencia.Text = da.Rows[0][3].ToString();
            cbClasificacion.Text = da.Rows[0][4].ToString();
            cbProveedor.Text = da.Rows[0][5].ToString();
            tbBarras.Text = da.Rows[0][6].ToString();
            tbMinimo.Text = da.Rows[0][7].ToString();
            tbMaximo.Text = da.Rows[0][8].ToString();
        }



        #endregion

        
    }
}
