using EcoPuraLibreria;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EcoPura
{
    public partial class PuntoVentaVentana : MetroFramework.Forms.MetroForm
    {

        DataTable Productos;
        bool Alcaline = false;
        int contadorGarrafones = 0;
        User _user;

        public PuntoVentaVentana(User user)
        {
            InitializeComponent();
            _user = user;
            gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            WindowState = FormWindowState.Maximized;
            this.ActiveControl = labelP;
            cbTipo.SelectedIndex = 0;
            SelectTextBox();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCantidadProducto();
            SelectTextBox();
        }

        private void AgregarCantidadProducto()
        {
            if (gridview.SelectedRows.Count > 0)
            {
                int cantidad = Int32.Parse(gridview.Rows[gridview.CurrentRow.Index].Cells["Cantidad"].Value.ToString());
                cantidad++;

                float precio = float.Parse(gridview.Rows[gridview.CurrentRow.Index].Cells["Precio"].Value.ToString());

                float importe = cantidad * precio;

                gridview.Rows[gridview.CurrentRow.Index].Cells["Cantidad"].Value = cantidad;
                gridview.Rows[gridview.CurrentRow.Index].Cells["Importe"].Value = importe;
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Por favor selecciona un producto para aumentar su cantidad", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
            Total();
        }


        private void AgregarProducto()
        {
            bool bandera = false;

            for (int i = 0; i < Productos.Rows.Count; i++)
            {
                if (tbSearchBox.Text.Equals(Productos.Rows[i]["Código"].ToString()))
                {

                    for (int j = 0; j < gridview.Rows.Count; j++)
                    {
                        if (tbSearchBox.Text.Equals(gridview.Rows[j].Cells["Código"].Value.ToString()))
                        {
                            int cantidad = Int32.Parse(gridview.Rows[j].Cells["Cantidad"].Value.ToString());
                            cantidad++;

                            float precio = 0;

                            if (Productos.Rows[i]["CantidadDescuento"].ToString() == cantidad.ToString())
                            {
                                float porcentajeD = float.Parse(Productos.Rows[i]["PorcentajeDescuento"].ToString());
                                float precioP = float.Parse(Productos.Rows[i]["Precio"].ToString());

                                precio = precioP * (1 - (porcentajeD / 100));
                                gridview.Rows[j].Cells["Precio"].Value = precio;
                            }
                            else
                            {
                                precio = float.Parse(gridview.Rows[j].Cells["Precio"].Value.ToString());
                            }

                            float importe = cantidad * precio;

                            gridview.Rows[j].Cells["Cantidad"].Value = cantidad;
                            gridview.Rows[j].Cells["Importe"].Value = importe;

                            bandera = true;
                            break;
                        }
                    }

                    if (!bandera)
                    {
                        float precio = 0;

                        if (Productos.Rows[i]["CantidadDescuento"].ToString() == "1")
                        {
                            float porcentajeD = float.Parse(Productos.Rows[i]["PorcentajeDescuento"].ToString());
                            float precioP = float.Parse(Productos.Rows[i]["Precio"].ToString());

                            precio = precioP * (1 - (porcentajeD / 100));
                        }
                        else
                        {
                            precio = float.Parse(Productos.Rows[i]["Precio"].ToString());
                        }

                        using (DataGridViewRow row = new DataGridViewRow())
                        {
                            row.CreateCells(gridview);

                            row.Cells[gridview.Columns["Código"].Index].Value = Productos.Rows[i]["Código"].ToString();
                            row.Cells[gridview.Columns["Descripción"].Index].Value = Productos.Rows[i]["Descripción"].ToString();
                            row.Cells[gridview.Columns["Precio"].Index].Value = precio;
                            row.Cells[gridview.Columns["Cantidad"].Index].Value = 1;
                            row.Cells[gridview.Columns["Importe"].Index].Value = precio;
                            gridview.Rows.Add(row);
                            break;
                        }
                    }

                }
            }

            Total();
            gridview.ClearSelection();
        }

        private void tbSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AgregarProducto();
            }
        }

        private void PuntoVentaVentana2_Load(object sender, EventArgs e)
        {
            string query = $@"Select codigo as Código, Descripcion as Descripción, Precio, CantidadDescuento, PorcentajeDescuento
                          FROM Productos";
            Productos = DatabaseAccess.CargarTabla(query);

            gridview.Columns["Precio"].DefaultCellStyle.Format = "c";
            gridview.Columns["Precio"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-MX");

            gridview.Columns["Importe"].DefaultCellStyle.Format = "c";
            gridview.Columns["Importe"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-MX");

            gridview.Columns[0].ReadOnly = true;
            gridview.Columns[1].ReadOnly = true;
            gridview.Columns[2].ReadOnly = true;
            gridview.Columns[4].ReadOnly = true;
            int cero = 0;
            labelP.Text = cero.ToString("C2", CultureInfo.GetCultureInfo("es-MX"));
            lblDolar.Text = cero.ToString("C2", CultureInfo.GetCultureInfo("en-US"));
        }

        private void tbSearchBox_Enter(object sender, EventArgs e)
        {
            if (tbSearchBox.Text.Equals("Código de barras"))
            {
                tbSearchBox.Text = "";
                tbSearchBox.ForeColor = Color.Black;
            }
        }

        private void tbSearchBox_Leave(object sender, EventArgs e)
        {
            if (tbSearchBox.Text.Equals(""))
            {
                tbSearchBox.Text = "Código de barras";
                tbSearchBox.ForeColor = Color.Gray;
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            contadorGarrafones = 0;
            gridview.Rows.Clear();
            Total();
            SelectTextBox();
        }

        private void btnBorrarUltimo_Click(object sender, EventArgs e)
        {
            if (gridview.SelectedRows.Count > 0)
            {
                DataGridViewRow row = gridview.Rows[gridview.CurrentRow.Index];

                if (gridview.Rows[gridview.CurrentRow.Index].Cells["Descripción"].Value.ToString().Contains("5 Galones Purificada")
                    || gridview.Rows[gridview.CurrentRow.Index].Cells["Descripción"].Value.ToString().Contains("20 Litros Purificada"))
                {
                    int c = int.Parse(gridview.Rows[gridview.CurrentRow.Index].Cells["Cantidad"].Value.ToString());
                    contadorGarrafones = contadorGarrafones - c;
                    QuitarDescuento();
                }
                gridview.Rows.Remove(row);
                Total();
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Por favor selecciona un producto para borrar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Question);

            SelectTextBox();
        }

        private void PuntoVentaVentana2_KeyPress(object sender, KeyPressEventArgs e)
        {
            int i;
            if (int.TryParse(e.KeyChar.ToString(), out i))
            {
                tbSearchBox.Focus();
            }
        }

        private void btnGarrafon20L_Click(object sender, EventArgs e)
        {
            if (cbTipo.SelectedIndex == 0)
            {
                if (!DoesRowExist("1 Litro Purificada"))
                {
                    AddRowGarrafon("1 Litro Purificada", 2, 1, 2);
                }
            }
            else
            {
                if (!DoesRowExist("1 Litro Alcalina"))
                {
                    AddRowGarrafon("1 Litro Alcalina", 4, 1, 4);
                }
            }
            // contadorGarrafones++;
            Total();
            gridview.ClearSelection();
            SelectTextBox();
        }

        private bool DoesRowExist(string descripcion)
        {
            bool bandera = false;
            for (int j = 0; j < gridview.Rows.Count; j++)
            {
                if (descripcion.Equals(gridview.Rows[j].Cells["Descripción"].Value.ToString()))
                {
                    int cantidad = Int32.Parse(gridview.Rows[j].Cells["Cantidad"].Value.ToString());
                    cantidad++;

                    float precio = float.Parse(gridview.Rows[j].Cells["Precio"].Value.ToString());

                    float importe = cantidad * precio;

                    gridview.Rows[j].Cells["Cantidad"].Value = cantidad;
                    gridview.Rows[j].Cells["Importe"].Value = importe;

                    bandera = true;
                    break;
                }
            }
            return bandera;
        }

        public void Total()
        {
            float total = 0;
            float dolar = 0;

            foreach (DataGridViewRow rows in gridview.Rows)
            {
                total += float.Parse(rows.Cells[4].Value.ToString());
            }

            dolar = total / DatabaseAccess.PrecioTotal("select tipocambio from configuracion where id = 1");

            labelP.Text = total.ToString("C2", CultureInfo.CreateSpecificCulture("es-MX"));
            lblDolar.Text = dolar.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
            tbSearchBox.Text = "";

            SelectTextBox();
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            if (gridview.Rows.Count > 0)
            {
                string converter = labelP.Text;
                float total = float.Parse(converter.Replace("$", ""));
                var cambio = new CambioVentana(total, gridview, _user);
                cambio.StartPosition = FormStartPosition.CenterParent;
                cambio.ShowDialog();
                gridview.Rows.Clear();
                contadorGarrafones = 0;
                int cero = 0;
                labelP.Text = cero.ToString("C2", CultureInfo.GetCultureInfo("es-MX"));
                lblDolar.Text = cero.ToString("C2", CultureInfo.GetCultureInfo("es-MX"));
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Agrega productos para realizar una venta", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Question);

            SelectTextBox();
        }


        private void gridview_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = gridview.CurrentCell.RowIndex;
            float precio = float.Parse(gridview.Rows[rowIndex].Cells["Precio"].Value.ToString());

            try
            {
                if (IsNumber(gridview.Rows[rowIndex].Cells[3].Value.ToString()))
                {
                    int cantidad = Int32.Parse(gridview.Rows[rowIndex].Cells["Cantidad"].Value.ToString());
                    float importe = cantidad * precio;

                    gridview.Rows[rowIndex].Cells["Cantidad"].Value = cantidad.ToString();
                    gridview.Rows[rowIndex].Cells["Importe"].Value = importe.ToString();
                }
                else
                {
                    gridview.Rows[rowIndex].Cells["Cantidad"].Value = 1;
                    gridview.Rows[rowIndex].Cells["Importe"].Value = 1 * precio;
                }
                Total();
            }
            catch (Exception s)
            {
                gridview.Rows[rowIndex].Cells["Cantidad"].Value = 1;
                gridview.Rows[rowIndex].Cells["Importe"].Value = 1 * precio;
            }
            SelectTextBox();
        }

        private bool IsNumber(string text)
        {
            float parsedValue;

            if (!float.TryParse(text, out parsedValue))
                return false;

            return true;
        }

        private void btnDecrementar_Click(object sender, EventArgs e)
        {
            if (gridview.SelectedRows.Count > 0)
            {
                int cantidad = Int32.Parse(gridview.Rows[gridview.CurrentRow.Index].Cells["Cantidad"].Value.ToString());
                cantidad--;

                if (gridview.Rows[gridview.CurrentRow.Index].Cells["Descripción"].Value.ToString().Contains("5 Galones Purificada")
                    || gridview.Rows[gridview.CurrentRow.Index].Cells["Descripción"].Value.ToString().Contains("20 Litros Purificada"))
                {
                    contadorGarrafones--;
                    QuitarDescuento();
                }

                if (cantidad == 0)
                {
                    gridview.Rows.Remove(gridview.Rows[gridview.CurrentRow.Index]);
                }
                else
                {
                    float precio = float.Parse(gridview.Rows[gridview.CurrentRow.Index].Cells["Precio"].Value.ToString());

                    float importe = cantidad * precio;

                    gridview.Rows[gridview.CurrentRow.Index].Cells["Cantidad"].Value = cantidad;
                    gridview.Rows[gridview.CurrentRow.Index].Cells["Importe"].Value = importe;
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Por favor selecciona un producto para aumentar su cantidad", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
            SelectTextBox();
            Total();
        }



        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.D0 ||
                keyData == Keys.D1 ||
                keyData == Keys.D2 ||
                keyData == Keys.D3 ||
                keyData == Keys.D4 ||
                keyData == Keys.D5 ||
                keyData == Keys.D6 ||
                keyData == Keys.D7 ||
                keyData == Keys.D8 ||
                keyData == Keys.D9)
            {
                SelectTextBox();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void gridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AgregarCantidadProducto();
            DescuentoGarrafon();
            SelectTextBox();
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            AgregarCantidadProducto();

            if (gridview.Rows[gridview.CurrentRow.Index].Cells["Descripción"].Value.ToString().Contains("5 Galones Purificada")
                    || gridview.Rows[gridview.CurrentRow.Index].Cells["Descripción"].Value.ToString().Contains("20 Litros Purificada"))
            {
                contadorGarrafones++;
            }
            DescuentoGarrafon();
            SelectTextBox();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AgregarProducto();
            SelectTextBox();
        }

        private void SelectTextBox()
        {
            tbSearchBox.Focus();
            tbSearchBox.Select();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (cbTipo.SelectedIndex == 0)
            {
                if (!DoesRowExist("1 Galón Purificada"))
                {
                    AddRowGarrafon("1 Galón Purificada", 5, 1, 5);
                }
            }
            else
            {
                if (!DoesRowExist("1 Galón Alcalina"))
                {
                    AddRowGarrafon("1 Galón Alcalina", 10, 1, 10);
                }
            }

            // contadorGarrafones++;
            Total();
            gridview.ClearSelection();
            SelectTextBox();
        }

        private void AddRowGarrafon(String descripcion, float precio, int cantidad, float importe)
        {
            using (DataGridViewRow row = new DataGridViewRow())
            {
                row.CreateCells(gridview);

                row.Cells[gridview.Columns["Código"].Index].Value = "";
                row.Cells[gridview.Columns["Descripción"].Index].Value = descripcion;
                row.Cells[gridview.Columns["Precio"].Index].Value = precio;
                row.Cells[gridview.Columns["Cantidad"].Index].Value = cantidad;
                row.Cells[gridview.Columns["Importe"].Index].Value = importe;
                gridview.Rows.Add(row);

            }
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipo.SelectedIndex == 0)
            {
                Alcaline = false;
                btn56Litros.Text = "5/6Litros";
                btn3Galones.Text = "3Galones";
                btn5Galones.Text = "5Galones";
                btn20Litros.Text = "20Litros";
            }
            else
            {
                Alcaline = true;
                btn56Litros.Text = "5Litros";
                btn3Galones.Text = "6litros";
                btn5Galones.Text = "3Galones";
                btn20Litros.Text = "5Galones";
            }
        }

        private void DescuentoGarrafon()
        {
            if (contadorGarrafones >= 4 && contadorGarrafones <= 6)
            {
                for (int j = 0; j < gridview.Rows.Count; j++)
                {
                    if (gridview.Rows[j].Cells["Descripción"].Value.ToString().Contains("5 Galones Purificada"))
                    {
                        float precio = float.Parse(gridview.Rows[j].Cells["Precio"].Value.ToString());

                        if (precio == 13.50)
                            precio = precio - 1;

                        gridview.Rows[j].Cells["Precio"].Value = precio;
                        int cantidad = int.Parse(gridview.Rows[j].Cells["Cantidad"].Value.ToString());

                        float importe = precio * cantidad;

                        gridview.Rows[j].Cells["Importe"].Value = importe;
                    }

                    if (gridview.Rows[j].Cells["Descripción"].Value.ToString().Contains("20 Litros Purificada"))
                    {
                        float precio = float.Parse(gridview.Rows[j].Cells["Precio"].Value.ToString());

                        if (precio == 14.00)
                            precio = precio - 1;

                        gridview.Rows[j].Cells["Precio"].Value = precio;
                        int cantidad = int.Parse(gridview.Rows[j].Cells["Cantidad"].Value.ToString());

                        float importe = precio * cantidad;

                        gridview.Rows[j].Cells["Importe"].Value = importe;
                    }
                }
            }

            if (contadorGarrafones >= 7)
            {
                for (int j = 0; j < gridview.Rows.Count; j++)
                {
                    if (gridview.Rows[j].Cells["Descripción"].Value.ToString().Contains("5 Galones Purificada"))
                    {
                        float precio = float.Parse(gridview.Rows[j].Cells["Precio"].Value.ToString());


                        if (precio == 12.50)
                            precio = precio - 1;

                        gridview.Rows[j].Cells["Precio"].Value = precio;

                        int cantidad = int.Parse(gridview.Rows[j].Cells["Cantidad"].Value.ToString());

                        float importe = precio * cantidad;

                        gridview.Rows[j].Cells["Importe"].Value = importe;
                    }

                    if (gridview.Rows[j].Cells["Descripción"].Value.ToString().Contains("20 Litros Purificada"))
                    {
                        float precio = float.Parse(gridview.Rows[j].Cells["Precio"].Value.ToString());

                        if (precio == 13.00)
                            precio = precio - 1;

                        gridview.Rows[j].Cells["Precio"].Value = precio;

                        int cantidad = int.Parse(gridview.Rows[j].Cells["Cantidad"].Value.ToString());

                        float importe = precio * cantidad;

                        gridview.Rows[j].Cells["Importe"].Value = importe;
                    }
                }
            }
        }
        private void QuitarDescuento()
        {
            if (contadorGarrafones < 4)
            {
                for (int j = 0; j < gridview.Rows.Count; j++)
                {
                    if (gridview.Rows[j].Cells["Descripción"].Value.ToString().Contains("5 Galones Purificada"))
                    {


                        float precio = float.Parse(gridview.Rows[j].Cells["Precio"].Value.ToString());

                        precio = 13.50F;

                        gridview.Rows[j].Cells["Precio"].Value = precio;


                    }

                    if (gridview.Rows[j].Cells["Descripción"].Value.ToString().Contains("20 Litros Purificada"))
                    {
                        float precio = float.Parse(gridview.Rows[j].Cells["Precio"].Value.ToString());


                        precio = 14.00F;

                        gridview.Rows[j].Cells["Precio"].Value = precio;
                    }
                }
            }

            if (contadorGarrafones < 7)
            {
                for (int j = 0; j < gridview.Rows.Count; j++)
                {
                    if (gridview.Rows[j].Cells["Descripción"].Value.ToString().Contains("5 Galones Purificada"))
                    {


                        float precio = float.Parse(gridview.Rows[j].Cells["Precio"].Value.ToString());

                        if (precio == 11.50F)
                            precio = 12.50F;

                        gridview.Rows[j].Cells["Precio"].Value = precio;


                    }

                    if (gridview.Rows[j].Cells["Descripción"].Value.ToString().Contains("20 Litros Purificada"))
                    {
                        float precio = float.Parse(gridview.Rows[j].Cells["Precio"].Value.ToString());

                        if (precio == 12.00F)
                            precio = 13.00F;

                        gridview.Rows[j].Cells["Precio"].Value = precio;
                    }
                }
            }
        }

        private void btn56Litros_Click(object sender, EventArgs e)
        {
            if (cbTipo.SelectedIndex == 0)
            {
                if (!DoesRowExist("5 y 6 Litros Purificada"))
                {
                    AddRowGarrafon("5 y 6 Litros Purificada", 6, 1, 6);
                }
            }
            else
            {
                if (!DoesRowExist("5 Litros Alcalina"))
                {
                    AddRowGarrafon("5 Litros Alcalina", 12, 1, 12);
                }
            }

            // contadorGarrafones++;
            Total();
            gridview.ClearSelection();
            SelectTextBox();
        }

        private void btn3Galones_Click(object sender, EventArgs e)
        {
            if (cbTipo.SelectedIndex == 0)
            {
                if (!DoesRowExist("3 Galones Purificada"))
                {
                    AddRowGarrafon("3 Galones Purificada", (float)8.5, 1, (float)8.5);
                }
            }
            else
            {
                if (!DoesRowExist("6 Litros Alcalina"))
                {
                    AddRowGarrafon("6 Litros Alcalina", 15, 1, 15);
                }
            }

            // contadorGarrafones++;
            Total();
            gridview.ClearSelection();
            SelectTextBox();
        }

        private void btn5Galones_Click(object sender, EventArgs e)
        {
            if (cbTipo.SelectedIndex == 0)
            {
                if (!DoesRowExist("5 Galones Purificada"))
                {
                    AddRowGarrafon("5 Galones Purificada", (float)13.5, 1, (float)13.5);
                    contadorGarrafones++;
                }
                else
                {
                    contadorGarrafones++;
                }
            }
            else
            {
                if (!DoesRowExist("3 Galones Alcalina"))
                {
                    AddRowGarrafon("3 Galones Alcalina", 25, 1, 25);
                }
            }

            DescuentoGarrafon();

            Total();
            gridview.ClearSelection();
            SelectTextBox();
        }

        private void btn20Litros_Click(object sender, EventArgs e)
        {
            if (cbTipo.SelectedIndex == 0)
            {
                if (!DoesRowExist("20 Litros Purificada"))
                {
                    AddRowGarrafon("20 Litros Purificada", (float)14.00, 1, (float)14.00);
                    contadorGarrafones++;
                }
                else
                {
                    contadorGarrafones++;
                }
            }
            else
            {
                if (!DoesRowExist("5 Galones Alcalina"))
                {
                    AddRowGarrafon("5 Galones Alcalina", 40, 1, 40);
                }
            }
            DescuentoGarrafon();

            Total();
            gridview.ClearSelection();
            SelectTextBox();
        }

        private void btnLimpiaduria_Click(object sender, EventArgs e)
        {
            var ventanaPedidos = new PopUpVentaLavanderia(_user);
            ventanaPedidos.StartPosition = FormStartPosition.CenterParent;
            ventanaPedidos.ShowDialog();
        }
    }
}

