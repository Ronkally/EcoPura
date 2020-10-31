namespace EcoPura
{
    partial class PopUpVentaLavanderia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUpVentaLavanderia));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.lblTelefono = new MetroFramework.Controls.MetroLabel();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTipodePago = new MetroFramework.Controls.MetroLabel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbTipoDePago = new MetroFramework.Controls.MetroComboBox();
            this.dtFecha = new MetroFramework.Controls.MetroDateTime();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new MetroFramework.Controls.MetroLabel();
            this.lblCliente = new MetroFramework.Controls.MetroLabel();
            this.lblFechaEntrega = new MetroFramework.Controls.MetroLabel();
            this.tbCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EcoPura.Properties.Resources.IconoEco;
            this.pictureBox1.Location = new System.Drawing.Point(17, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(59, 68);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(422, 363);
            this.metroTabControl1.TabIndex = 29;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.lblTelefono);
            this.metroTabPage1.Controls.Add(this.tbTelefono);
            this.metroTabPage1.Controls.Add(this.btnCancelar);
            this.metroTabPage1.Controls.Add(this.lblTipodePago);
            this.metroTabPage1.Controls.Add(this.btnAgregar);
            this.metroTabPage1.Controls.Add(this.cbTipoDePago);
            this.metroTabPage1.Controls.Add(this.dtFecha);
            this.metroTabPage1.Controls.Add(this.tbPrecio);
            this.metroTabPage1.Controls.Add(this.lblPrecio);
            this.metroTabPage1.Controls.Add(this.lblCliente);
            this.metroTabPage1.Controls.Add(this.lblFechaEntrega);
            this.metroTabPage1.Controls.Add(this.tbCliente);
            this.metroTabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(414, 321);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Pedido";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(0, 82);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(61, 19);
            this.lblTelefono.TabIndex = 36;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbTelefono.Location = new System.Drawing.Point(4, 104);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(410, 25);
            this.tbTelefono.TabIndex = 2;
            this.tbTelefono.Text = "Ej. 6647523659";
            this.tbTelefono.Enter += new System.EventHandler(this.tbTelefono_Enter);
            this.tbTelefono.Leave += new System.EventHandler(this.tbTelefono_Leave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(218, 280);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 29);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTipodePago
            // 
            this.lblTipodePago.AutoSize = true;
            this.lblTipodePago.Location = new System.Drawing.Point(4, 205);
            this.lblTipodePago.Name = "lblTipodePago";
            this.lblTipodePago.Size = new System.Drawing.Size(89, 19);
            this.lblTipodePago.TabIndex = 34;
            this.lblTipodePago.Text = "Tipo de pago";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(115, 280);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(81, 29);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbTipoDePago
            // 
            this.cbTipoDePago.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbTipoDePago.FormattingEnabled = true;
            this.cbTipoDePago.ItemHeight = 19;
            this.cbTipoDePago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.cbTipoDePago.Location = new System.Drawing.Point(4, 227);
            this.cbTipoDePago.Name = "cbTipoDePago";
            this.cbTipoDePago.Size = new System.Drawing.Size(204, 25);
            this.cbTipoDePago.TabIndex = 5;
            this.cbTipoDePago.UseSelectable = true;
            // 
            // dtFecha
            // 
            this.dtFecha.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtFecha.Location = new System.Drawing.Point(4, 166);
            this.dtFecha.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(203, 25);
            this.dtFecha.TabIndex = 3;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecio.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbPrecio.Location = new System.Drawing.Point(230, 166);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(184, 25);
            this.tbPrecio.TabIndex = 4;
            this.tbPrecio.Text = "Ej. 50";
            this.tbPrecio.Enter += new System.EventHandler(this.tbPrecio_Enter);
            this.tbPrecio.Leave += new System.EventHandler(this.tbPrecio_Leave);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(227, 144);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 19);
            this.lblPrecio.TabIndex = 21;
            this.lblPrecio.Text = "Costo:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(0, 19);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(125, 19);
            this.lblCliente.TabIndex = 18;
            this.lblCliente.Text = "Nombre del cliente:";
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Location = new System.Drawing.Point(3, 144);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(114, 19);
            this.lblFechaEntrega.TabIndex = 17;
            this.lblFechaEntrega.Text = "Fecha de entrega:";
            // 
            // tbCliente
            // 
            this.tbCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCliente.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbCliente.Location = new System.Drawing.Point(4, 41);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(410, 25);
            this.tbCliente.TabIndex = 1;
            this.tbCliente.Text = "Ej. Juan";
            this.tbCliente.Enter += new System.EventHandler(this.tbCliente_Enter);
            this.tbCliente.Leave += new System.EventHandler(this.tbCliente_Leave);
            // 
            // PopUpVentaLavanderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 478);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PopUpVentaLavanderia";
            this.Resizable = false;
            this.Text = "   Pedido";
            this.Load += new System.EventHandler(this.PopUpAgregarFondo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.TextBox tbPrecio;
        private MetroFramework.Controls.MetroLabel lblPrecio;
        private MetroFramework.Controls.MetroLabel lblCliente;
        private MetroFramework.Controls.MetroLabel lblFechaEntrega;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private MetroFramework.Controls.MetroDateTime dtFecha;
        private MetroFramework.Controls.MetroLabel lblTipodePago;
        private MetroFramework.Controls.MetroComboBox cbTipoDePago;
        private MetroFramework.Controls.MetroLabel lblTelefono;
        private System.Windows.Forms.TextBox tbTelefono;
    }
}