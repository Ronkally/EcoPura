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
    public partial class PopUpProducto1 : MetroFramework.Forms.MetroForm
    {

        Boolean Actualizar = false;
        string codigo;
        ErrorProvider validacion = new ErrorProvider();

        public PopUpProducto1()
        {
            InitializeComponent();
        }

        public PopUpProducto1(string codigo)
        {
            InitializeComponent();
            LlenarCampos(codigo);
            Actualizar = true;
            this.codigo = codigo;

            tbDescripcioon.ForeColor = Color.Black;
            tbBarras.ForeColor = Color.Black;
            cbClasificacion.ForeColor = Color.Black;
            cbProveedor.ForeColor = Color.Black;
            tbExistencia.ForeColor = Color.Black;
            tbCosto.ForeColor = Color.Black;
            tbPrecio.ForeColor = Color.Black;
            tbMaximo.ForeColor = Color.Black;
            tbMinimo.ForeColor = Color.Black;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                IfEmptyNull();
                if (!Actualizar)
                    GuardarProducto();
                else
                    ActualizarProducto();

                this.Close();
            }
        }


        #region Metodos
        private void CargarProveedores()
        {
            cbProveedor.SelectedItem = null;
            string query = @"Select * FROM Proveedor";
            DataTable Proveedores = DatabaseAccess.CargarTabla(query);
            using (Proveedores)
            {
                foreach (DataRow fila in Proveedores.Rows)
                {
                    cbProveedor.Items.Add(fila["Proveedor"].ToString());
                    if (cbProveedor.Text.Equals(fila["Proveedor"].ToString()))
                    {
                        cbProveedor.SelectedIndex = cbProveedor.FindStringExact(cbProveedor.Text);
                    }

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
                    if (fila[1].ToString() != "Agua")
                        cbClasificacion.Items.Add(fila["Clasificacion"].ToString());

                    if (cbClasificacion.Text.Equals(fila["Clasificacion"].ToString()))
                        cbClasificacion.SelectedIndex = cbClasificacion.FindStringExact(cbClasificacion.Text);
                }
            }
        }

        private void GuardarProducto()
        {
            //Validacion

            string getProveedorId = cbProveedor.SelectedItem != null ? $@"(SELECT IdProveedor 
                                            FROM Proveedor
                                            WHERE Proveedor = '{cbProveedor.SelectedItem.ToString()}')" : "null";


            string getClasificacionId = cbClasificacion.SelectedItem != null ? $@"(SELECT IdClasificacion 
                                            FROM Clasificacion
                                            WHERE Clasificacion = '{cbClasificacion.SelectedItem.ToString()}')" : "null";


            string query = $@"Insert into Productos 
                             (Codigo, Descripcion, IdClasificacion, IdProveedor, Costo, Precio, Existencia, Minimo, Maximo, PorcentajeDescuento, CantidadDescuento)
                             Values ('{tbBarras.Text}', '{tbDescripcioon.Text}',{getClasificacionId}, {getProveedorId}, {tbCosto.Text}, {tbPrecio.Text}, {tbExistencia.Text}, {tbMinimo.Text}, {tbMaximo.Text}, {tbPorcentajeD.Text}, {tbCantidadD.Text})";



            DatabaseAccess.EjecutarConsulta(query);
        }
        private void ActualizarProducto()
        {

            string getProveedorId = cbProveedor.SelectedItem != null ? $@"(SELECT IdProveedor 
                                            FROM Proveedor
                                            WHERE Proveedor = '{cbProveedor.SelectedItem.ToString()}')" : "null";

            string getClasificacionId = cbClasificacion.SelectedItem != null ? $@"(SELECT IdClasificacion 
                                            FROM Clasificacion
                                            WHERE Clasificacion = '{cbClasificacion.SelectedItem.ToString()}')" : "null";

            string query = $@"UPDATE Productos
                              SET Codigo = '{tbBarras.Text}', Descripcion = '{tbDescripcioon.Text}', Costo = {tbCosto.Text}, Precio = {tbPrecio.Text}, Existencia = {tbExistencia.Text}, IdClasificacion = {getClasificacionId}, IdProveedor = {getProveedorId}, Minimo = {tbMinimo.Text}, Maximo = {tbMaximo.Text}, PorcentajeDescuento = {tbPorcentajeD.Text}, CantidadDescuento = {tbCantidadD.Text}
                              WHERE Codigo = '{codigo}'";

            DatabaseAccess.EjecutarConsulta(query);
        }

        private void LlenarCampos(string codigo)
        {
            string query = $@"SELECT Descripcion, Costo, Precio, Existencia, Clasificacion.Clasificacion, Proveedor.Proveedor, Codigo, Minimo, Maximo, PorcentajeDescuento, CantidadDescuento
                             FROM Productos
                             LEFT JOIN Proveedor
                             ON Productos.IdProveedor = Proveedor.IdProveedor
                             LEFT JOIN Clasificacion
                             ON Productos.IdClasificacion = Clasificacion.IdClasificacion
                             WHERE Codigo = '{codigo}'";

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
            tbPorcentajeD.Text = da.Rows[0][9].ToString();
            tbCantidadD.Text = da.Rows[0][10].ToString();
        }




        #endregion

        #region Placeholders
        private void tbDescripcioon_Enter(object sender, EventArgs e)
        {
            //Ingresa una descripción
            if (tbDescripcioon.Text.Equals("Ej. Doritos") || tbDescripcioon.Text.Equals("Ingresa una descripción"))
            {
                tbDescripcioon.Text = "";
                tbDescripcioon.ForeColor = Color.Black;
            }
        }

        private void tbDescripcioon_Leave(object sender, EventArgs e)
        {
            if (tbDescripcioon.Text.Equals(""))
            {
                tbDescripcioon.Text = "Ej. Doritos";
                tbDescripcioon.ForeColor = Color.Gray;
            }
        }

        //Ej. 5901234123
        private void tbBarras_Enter(object sender, EventArgs e)
        {
            if (tbBarras.Text.Equals("Ej. 5901234123") || tbBarras.Text.Equals("Ingresa un código de barras, solo números"))
            {
                tbBarras.Text = "";
                tbBarras.ForeColor = Color.Black;
            }
        }

        private void tbBarras_Leave(object sender, EventArgs e)
        {
            if (tbBarras.Text.Equals(""))
            {
                tbBarras.Text = "Ej. 5901234123";
                tbBarras.ForeColor = Color.Gray;
            }
        }
        //Ej. Dulcería
        private void cbClasificacion_Enter(object sender, EventArgs e)
        {
            if (cbClasificacion.Text.Equals("Ej. Dulcería"))
            {
                cbClasificacion.ForeColor = Color.Black;
                cbClasificacion.Text = "";
            }
        }

        private void cbClasificacion_Leave(object sender, EventArgs e)
        {
            if (cbClasificacion.Text.Equals(""))
            {
                cbClasificacion.ForeColor = Color.Gray;
                cbClasificacion.Text = "Ej. Dulcería";
            }
        }
        //Ej. Juan
        private void cbProveedor_Enter(object sender, EventArgs e)
        {
            if (cbProveedor.Text.Equals("Ej. Juan"))
            {
                cbProveedor.ForeColor = Color.Black;
                cbProveedor.Text = "";
            }
        }

        private void cbProveedor_Leave(object sender, EventArgs e)
        {
            if (cbProveedor.Text.Equals(""))
            {
                cbProveedor.ForeColor = Color.Gray;
                cbProveedor.Text = "Ej. Juan";
            }
        }
        //Ej. 50
        private void tbExistencia_Enter(object sender, EventArgs e)
        {
            if (tbExistencia.Text.Equals("Ej. 50") || tbExistencia.Text.Equals("Ingresa una existencia, solo números"))
            {
                tbExistencia.ForeColor = Color.Black;
                tbExistencia.Text = "";
            }
        }

        private void tbExistencia_Leave(object sender, EventArgs e)
        {
            if (tbExistencia.Text.Equals(""))
            {
                tbExistencia.ForeColor = Color.Gray;
                tbExistencia.Text = "Ej. 50";
            }
        }
        //Ej. 5
        private void tbMinimo_Enter(object sender, EventArgs e)
        {
            if (tbMinimo.Text.Equals("Ej. 5"))
            {
                tbMinimo.ForeColor = Color.Black;
                tbMinimo.Text = "";
            }
        }

        private void tbMinimo_Leave(object sender, EventArgs e)
        {
            if (tbMinimo.Text.Equals(""))
            {
                tbMinimo.ForeColor = Color.Gray;
                tbMinimo.Text = "Ej. 5";
            }
        }
        //Ej. 100
        private void tbMaximo_Enter(object sender, EventArgs e)
        {
            if (tbMaximo.Text.Equals("Ej. 100"))
            {
                tbMaximo.ForeColor = Color.Black;
                tbMaximo.Text = "";
            }
        }

        private void tbMaximo_Leave(object sender, EventArgs e)
        {
            if (tbMaximo.Text.Equals(""))
            {
                tbMaximo.ForeColor = Color.Gray;
                tbMaximo.Text = "Ej. 100";
            }
        }

        private void tbPrecio_Enter(object sender, EventArgs e)
        {
            if (tbPrecio.Text.Equals("Ingresa un precio, solo números") || tbPrecio.Text.Equals("Ej. 15"))
            {
                tbPrecio.ForeColor = Color.Black;
                tbPrecio.Text = "";
            }
        }
        //Ej. 15
        private void tbPrecio_Leave(object sender, EventArgs e)
        {
            if (tbPrecio.Text.Equals(""))
            {
                tbPrecio.ForeColor = Color.Gray;
                tbPrecio.Text = "Ej. 15";
            }
        }
        //Ej. 10
        private void tbCosto_Enter(object sender, EventArgs e)
        {
            if (tbCosto.Text.Equals("Ej. 10"))
            {
                tbCosto.ForeColor = Color.Black;
                tbCosto.Text = "";
            }
        }

        private void tbCosto_Leave(object sender, EventArgs e)
        {
            if (tbCosto.Text.Equals(""))
            {
                tbCosto.ForeColor = Color.Gray;
                tbCosto.Text = "Ej. 10";
            }
        }

        private void tbPorcentajeD_Enter(object sender, EventArgs e)
        {
            if (tbPorcentajeD.Text.Equals("0"))
            {
                tbPorcentajeD.ForeColor = Color.Black;
                tbPorcentajeD.Text = "";
            }
        }

        private void tbPorcentajeD_Leave(object sender, EventArgs e)
        {
            if (tbPorcentajeD.Text.Equals(""))
            {
                tbPorcentajeD.ForeColor = Color.Black;
                tbPorcentajeD.Text = "0";
            }
        }

        private void tbCantidadD_Enter(object sender, EventArgs e)
        {
            if (tbCantidadD.Text.Equals("1"))
            {
                tbCantidadD.ForeColor = Color.Black;
                tbCantidadD.Text = "";
            }
        }

        private void tbCantidadD_Leave(object sender, EventArgs e)
        {
            if (tbCantidadD.Text.Equals(""))
            {
                tbCantidadD.ForeColor = Color.Black;
                tbCantidadD.Text = "1";
            }
        }


        #endregion

        private bool Validacion()
        {
            bool bandera = true;

            if (tbDescripcioon.Text.Equals("Ej. Doritos") || tbDescripcioon.Text.Equals("Ingresa una descripción") || Shared.InvalidString(tbDescripcioon.Text))
            {
                tbDescripcioon.Text = "Ingresa una descripción";
                tbDescripcioon.ForeColor = Color.Red;
                bandera = false;
            }

            if (tbBarras.Text.Equals("Ej. 5901234123") || !IsNumber(tbBarras.Text) || tbBarras.Text.Equals("Ingresa un código de barras, solo números") || Shared.InvalidString(tbBarras.Text))
            {
                tbBarras.Text = "Ingresa un código de barras, solo números";
                tbBarras.ForeColor = Color.Red;
                bandera = false;
            }

            if (tbPrecio.Text.Equals("Ej. 15") || !IsNumber(tbPrecio.Text) || tbPrecio.Text.Equals("Ingresa un precio, solo números") || Shared.InvalidString(tbPrecio.Text))
            {
                tbPrecio.Text = "Ingresa un precio, solo números";
                tbPrecio.ForeColor = Color.Red;
                bandera = false;
            }

            if (!IsNumber(tbCantidadD.Text) || tbCantidadD.Text.Equals("Ingresa solo números") || Shared.InvalidString(tbCantidadD.Text))
            {
                tbCantidadD.Text = "Ingresa solo números";
                tbCantidadD.ForeColor = Color.Red;
                bandera = false;
            }

            if (!IsNumber(tbPorcentajeD.Text) || tbPorcentajeD.Text.Equals("Ingresa solo números") || Shared.InvalidString(tbPorcentajeD.Text))
            {
                tbPorcentajeD.Text = "Ingresa solo números";
                tbPorcentajeD.ForeColor = Color.Red;
                bandera = false;
            }

            if (tbExistencia.Text.Equals("Ej. 50") || !IsNumber(tbExistencia.Text) || tbExistencia.Text.Equals("Ingresa una existencia, solo números") || Shared.InvalidString(tbExistencia.Text))
            {
                tbExistencia.Text = "Ingresa una existencia, solo números";
                tbExistencia.ForeColor = Color.Red;
                bandera = false;
            }
            if (!(cbClasificacion.SelectedIndex > -1))
            {
                MessageBox.Show("Selecciona una clasificación");
                bandera = false;
            }


            return bandera;
        }

        private void IfEmptyNull()
        {
            if (tbCosto.Text.Equals("Ej. 10") || tbCosto.Text.Equals(""))
                tbCosto.Text = "null";

            if (tbMaximo.Text.Equals("Ej. 100") || tbMaximo.Text.Equals(""))
                tbMaximo.Text = "null";

            if (tbMinimo.Text.Equals("Ej. 5") || tbMinimo.Text.Equals(""))
                tbMinimo.Text = "null";

            if (tbExistencia.Text.Equals("Ej. 50") || tbExistencia.Text.Equals(""))
                tbExistencia.Text = "null";
        }

        private bool IsNumber(string text)
        {
            float parsedValue;

            if (!float.TryParse(text, out parsedValue))
                return false;
            else
                return parsedValue >= 0;
        }

        private void PopUpProducto1_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = metroTabPage1;
            CargarClasificacion();
            CargarProveedores();
        }


    }
}
