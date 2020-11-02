namespace EcoPura
{
    public partial class PopUpProducto1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUpProducto1));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.tbCosto = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.tbMaximo = new System.Windows.Forms.TextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tbMinimo = new System.Windows.Forms.TextBox();
            this.tbExistencia = new System.Windows.Forms.TextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.cbClasificacion = new System.Windows.Forms.ComboBox();
            this.tbBarras = new System.Windows.Forms.TextBox();
            this.tbDescripcioon = new System.Windows.Forms.TextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.tbCantidadD = new System.Windows.Forms.TextBox();
            this.tbPorcentajeD = new System.Windows.Forms.TextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.tbIEPS = new MetroFramework.Controls.MetroTextBox();
            this.tbIVA = new MetroFramework.Controls.MetroTextBox();
            this.cbIEPS = new MetroFramework.Controls.MetroCheckBox();
            this.cbIVA = new MetroFramework.Controls.MetroCheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(64, 71);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(422, 363);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.tbCosto);
            this.metroTabPage1.Controls.Add(this.tbPrecio);
            this.metroTabPage1.Controls.Add(this.metroLabel9);
            this.metroTabPage1.Controls.Add(this.metroLabel8);
            this.metroTabPage1.Controls.Add(this.tbMaximo);
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.tbMinimo);
            this.metroTabPage1.Controls.Add(this.tbExistencia);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.cbProveedor);
            this.metroTabPage1.Controls.Add(this.cbClasificacion);
            this.metroTabPage1.Controls.Add(this.tbBarras);
            this.metroTabPage1.Controls.Add(this.tbDescripcioon);
            this.metroTabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(414, 321);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Producto";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // tbCosto
            // 
            this.tbCosto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCosto.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbCosto.Location = new System.Drawing.Point(216, 288);
            this.tbCosto.MaxLength = 15;
            this.tbCosto.Name = "tbCosto";
            this.tbCosto.Size = new System.Drawing.Size(198, 23);
            this.tbCosto.TabIndex = 31;
            this.tbCosto.Text = "Ej. 10";
            this.tbCosto.Enter += new System.EventHandler(this.tbCosto_Enter);
            this.tbCosto.Leave += new System.EventHandler(this.tbCosto_Leave);
            // 
            // tbPrecio
            // 
            this.tbPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecio.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbPrecio.Location = new System.Drawing.Point(3, 288);
            this.tbPrecio.MaxLength = 15;
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(198, 23);
            this.tbPrecio.TabIndex = 28;
            this.tbPrecio.Text = "Ej. 15";
            this.tbPrecio.Enter += new System.EventHandler(this.tbPrecio_Enter);
            this.tbPrecio.Leave += new System.EventHandler(this.tbPrecio_Leave);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(214, 264);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(46, 19);
            this.metroLabel9.TabIndex = 30;
            this.metroLabel9.Text = "Costo:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(0, 264);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(49, 19);
            this.metroLabel8.TabIndex = 27;
            this.metroLabel8.Text = "Precio:";
            // 
            // tbMaximo
            // 
            this.tbMaximo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaximo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbMaximo.Location = new System.Drawing.Point(290, 229);
            this.tbMaximo.MaxLength = 15;
            this.tbMaximo.Name = "tbMaximo";
            this.tbMaximo.Size = new System.Drawing.Size(124, 23);
            this.tbMaximo.TabIndex = 26;
            this.tbMaximo.Text = "Ej. 100";
            this.tbMaximo.Enter += new System.EventHandler(this.tbMaximo_Enter);
            this.tbMaximo.Leave += new System.EventHandler(this.tbMaximo_Leave);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(290, 207);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(60, 19);
            this.metroLabel7.TabIndex = 25;
            this.metroLabel7.Text = "Máximo:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(147, 207);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(57, 19);
            this.metroLabel6.TabIndex = 24;
            this.metroLabel6.Text = "Mínimo:";
            // 
            // tbMinimo
            // 
            this.tbMinimo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMinimo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbMinimo.Location = new System.Drawing.Point(147, 229);
            this.tbMinimo.MaxLength = 15;
            this.tbMinimo.Name = "tbMinimo";
            this.tbMinimo.Size = new System.Drawing.Size(128, 23);
            this.tbMinimo.TabIndex = 23;
            this.tbMinimo.Text = "Ej. 5";
            this.tbMinimo.Enter += new System.EventHandler(this.tbMinimo_Enter);
            this.tbMinimo.Leave += new System.EventHandler(this.tbMinimo_Leave);
            // 
            // tbExistencia
            // 
            this.tbExistencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExistencia.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbExistencia.Location = new System.Drawing.Point(4, 229);
            this.tbExistencia.MaxLength = 15;
            this.tbExistencia.Name = "tbExistencia";
            this.tbExistencia.Size = new System.Drawing.Size(128, 23);
            this.tbExistencia.TabIndex = 22;
            this.tbExistencia.Text = "Ej. 50";
            this.tbExistencia.Enter += new System.EventHandler(this.tbExistencia_Enter);
            this.tbExistencia.Leave += new System.EventHandler(this.tbExistencia_Leave);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(0, 207);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(67, 19);
            this.metroLabel5.TabIndex = 21;
            this.metroLabel5.Text = "Existencia:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(214, 142);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(75, 19);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Proveedor:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(0, 142);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(83, 19);
            this.metroLabel3.TabIndex = 19;
            this.metroLabel3.Text = "Clasificación:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(0, 83);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(116, 19);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Código de Barras:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Descripción:";
            // 
            // cbProveedor
            // 
            this.cbProveedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProveedor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(216, 164);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(198, 23);
            this.cbProveedor.TabIndex = 14;
            this.cbProveedor.Text = "Ej. Juan";
            this.cbProveedor.Enter += new System.EventHandler(this.cbProveedor_Enter);
            this.cbProveedor.Leave += new System.EventHandler(this.cbProveedor_Leave);
            // 
            // cbClasificacion
            // 
            this.cbClasificacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClasificacion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbClasificacion.FormattingEnabled = true;
            this.cbClasificacion.Location = new System.Drawing.Point(4, 164);
            this.cbClasificacion.Name = "cbClasificacion";
            this.cbClasificacion.Size = new System.Drawing.Size(198, 23);
            this.cbClasificacion.TabIndex = 13;
            this.cbClasificacion.Text = "Ej. Dulcería";
            this.cbClasificacion.Enter += new System.EventHandler(this.cbClasificacion_Enter);
            this.cbClasificacion.Leave += new System.EventHandler(this.cbClasificacion_Leave);
            // 
            // tbBarras
            // 
            this.tbBarras.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBarras.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbBarras.Location = new System.Drawing.Point(4, 105);
            this.tbBarras.MaxLength = 20;
            this.tbBarras.Name = "tbBarras";
            this.tbBarras.Size = new System.Drawing.Size(410, 23);
            this.tbBarras.TabIndex = 12;
            this.tbBarras.Text = "Ej. 5901234123";
            this.tbBarras.Enter += new System.EventHandler(this.tbBarras_Enter);
            this.tbBarras.Leave += new System.EventHandler(this.tbBarras_Leave);
            // 
            // tbDescripcioon
            // 
            this.tbDescripcioon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcioon.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbDescripcioon.Location = new System.Drawing.Point(3, 47);
            this.tbDescripcioon.MaxLength = 30;
            this.tbDescripcioon.Name = "tbDescripcioon";
            this.tbDescripcioon.Size = new System.Drawing.Size(411, 23);
            this.tbDescripcioon.TabIndex = 11;
            this.tbDescripcioon.Text = "Ej. Doritos";
            this.tbDescripcioon.Enter += new System.EventHandler(this.tbDescripcioon_Enter);
            this.tbDescripcioon.Leave += new System.EventHandler(this.tbDescripcioon_Leave);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.tbCantidadD);
            this.metroTabPage2.Controls.Add(this.tbPorcentajeD);
            this.metroTabPage2.Controls.Add(this.metroLabel12);
            this.metroTabPage2.Controls.Add(this.metroLabel11);
            this.metroTabPage2.Controls.Add(this.metroLabel10);
            this.metroTabPage2.Controls.Add(this.tbIEPS);
            this.metroTabPage2.Controls.Add(this.tbIVA);
            this.metroTabPage2.Controls.Add(this.cbIEPS);
            this.metroTabPage2.Controls.Add(this.cbIVA);
            this.metroTabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(414, 321);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Otros";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // tbCantidadD
            // 
            this.tbCantidadD.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tbCantidadD.Location = new System.Drawing.Point(7, 226);
            this.tbCantidadD.MaxLength = 15;
            this.tbCantidadD.Name = "tbCantidadD";
            this.tbCantidadD.Size = new System.Drawing.Size(404, 21);
            this.tbCantidadD.TabIndex = 13;
            this.tbCantidadD.Text = "1";
            this.tbCantidadD.Enter += new System.EventHandler(this.tbCantidadD_Enter);
            this.tbCantidadD.Leave += new System.EventHandler(this.tbCantidadD_Leave);
            // 
            // tbPorcentajeD
            // 
            this.tbPorcentajeD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbPorcentajeD.Location = new System.Drawing.Point(7, 160);
            this.tbPorcentajeD.MaxLength = 3;
            this.tbPorcentajeD.Name = "tbPorcentajeD";
            this.tbPorcentajeD.Size = new System.Drawing.Size(407, 21);
            this.tbPorcentajeD.TabIndex = 12;
            this.tbPorcentajeD.Text = "0";
            this.tbPorcentajeD.Enter += new System.EventHandler(this.tbPorcentajeD_Enter);
            this.tbPorcentajeD.Leave += new System.EventHandler(this.tbPorcentajeD_Leave);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(3, 204);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(260, 19);
            this.metroLabel12.TabIndex = 10;
            this.metroLabel12.Text = "Cantidad necesaria para aplicar descuento:";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(3, 138);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(155, 19);
            this.metroLabel11.TabIndex = 8;
            this.metroLabel11.Text = "Porcentaje de descuento:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(3, 109);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(77, 19);
            this.metroLabel10.TabIndex = 7;
            this.metroLabel10.Text = "Descuento:";
            // 
            // tbIEPS
            // 
            // 
            // 
            // 
            this.tbIEPS.CustomButton.Image = null;
            this.tbIEPS.CustomButton.Location = new System.Drawing.Point(324, 1);
            this.tbIEPS.CustomButton.Name = "";
            this.tbIEPS.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbIEPS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbIEPS.CustomButton.TabIndex = 1;
            this.tbIEPS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbIEPS.CustomButton.UseSelectable = true;
            this.tbIEPS.CustomButton.Visible = false;
            this.tbIEPS.Lines = new string[] {
        "Escriba porcentaje"};
            this.tbIEPS.Location = new System.Drawing.Point(65, 70);
            this.tbIEPS.MaxLength = 32767;
            this.tbIEPS.Name = "tbIEPS";
            this.tbIEPS.PasswordChar = '\0';
            this.tbIEPS.ReadOnly = true;
            this.tbIEPS.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbIEPS.SelectedText = "";
            this.tbIEPS.SelectionLength = 0;
            this.tbIEPS.SelectionStart = 0;
            this.tbIEPS.ShortcutsEnabled = true;
            this.tbIEPS.Size = new System.Drawing.Size(346, 23);
            this.tbIEPS.TabIndex = 6;
            this.tbIEPS.Text = "Escriba porcentaje";
            this.tbIEPS.UseSelectable = true;
            this.tbIEPS.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbIEPS.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbIVA
            // 
            // 
            // 
            // 
            this.tbIVA.CustomButton.Image = null;
            this.tbIVA.CustomButton.Location = new System.Drawing.Point(324, 1);
            this.tbIVA.CustomButton.Name = "";
            this.tbIVA.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbIVA.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbIVA.CustomButton.TabIndex = 1;
            this.tbIVA.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbIVA.CustomButton.UseSelectable = true;
            this.tbIVA.CustomButton.Visible = false;
            this.tbIVA.Lines = new string[] {
        "Escriba porcentaje"};
            this.tbIVA.Location = new System.Drawing.Point(65, 34);
            this.tbIVA.MaxLength = 32767;
            this.tbIVA.Name = "tbIVA";
            this.tbIVA.PasswordChar = '\0';
            this.tbIVA.ReadOnly = true;
            this.tbIVA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbIVA.SelectedText = "";
            this.tbIVA.SelectionLength = 0;
            this.tbIVA.SelectionStart = 0;
            this.tbIVA.ShortcutsEnabled = true;
            this.tbIVA.Size = new System.Drawing.Size(346, 23);
            this.tbIVA.TabIndex = 5;
            this.tbIVA.Text = "Escriba porcentaje";
            this.tbIVA.UseSelectable = true;
            this.tbIVA.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbIVA.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbIEPS
            // 
            this.cbIEPS.AutoSize = true;
            this.cbIEPS.Enabled = false;
            this.cbIEPS.Location = new System.Drawing.Point(3, 73);
            this.cbIEPS.Name = "cbIEPS";
            this.cbIEPS.Size = new System.Drawing.Size(45, 15);
            this.cbIEPS.TabIndex = 4;
            this.cbIEPS.Text = "IEPS";
            this.cbIEPS.UseSelectable = true;
            // 
            // cbIVA
            // 
            this.cbIVA.AutoSize = true;
            this.cbIVA.Enabled = false;
            this.cbIVA.Location = new System.Drawing.Point(3, 37);
            this.cbIVA.Name = "cbIVA";
            this.cbIVA.Size = new System.Drawing.Size(40, 15);
            this.cbIVA.TabIndex = 3;
            this.cbIVA.Text = "IVA";
            this.cbIVA.UseSelectable = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(284, 447);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 29);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(188, 447);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(81, 29);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // PopUpProducto1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 499);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PopUpProducto1";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "9";
            this.Load += new System.EventHandler(this.PopUpProducto1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.ComboBox cbClasificacion;
        private System.Windows.Forms.TextBox tbBarras;
        private System.Windows.Forms.TextBox tbDescripcioon;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TextBox tbExistencia;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.TextBox tbMinimo;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        public System.Windows.Forms.TextBox tbMaximo;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbCosto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.TextBox tbCantidadD;
        private System.Windows.Forms.TextBox tbPorcentajeD;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox tbIEPS;
        private MetroFramework.Controls.MetroTextBox tbIVA;
        private MetroFramework.Controls.MetroCheckBox cbIEPS;
        private MetroFramework.Controls.MetroCheckBox cbIVA;
    }
}