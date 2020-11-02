namespace EcoPura
{
    partial class PopUpLavanderiaModificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUpLavanderiaModificacion));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbEstado = new MetroFramework.Controls.MetroComboBox();
            this.dtFechaEntrega = new MetroFramework.Controls.MetroDateTime();
            this.lblFechaEntrega = new MetroFramework.Controls.MetroLabel();
            this.lblTelefono = new MetroFramework.Controls.MetroLabel();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtFecha = new MetroFramework.Controls.MetroDateTime();
            this.lblCliente = new MetroFramework.Controls.MetroLabel();
            this.lblFechaRecibido = new MetroFramework.Controls.MetroLabel();
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
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.cbEstado);
            this.metroTabPage1.Controls.Add(this.dtFechaEntrega);
            this.metroTabPage1.Controls.Add(this.lblFechaEntrega);
            this.metroTabPage1.Controls.Add(this.lblTelefono);
            this.metroTabPage1.Controls.Add(this.tbTelefono);
            this.metroTabPage1.Controls.Add(this.btnCancelar);
            this.metroTabPage1.Controls.Add(this.btnAgregar);
            this.metroTabPage1.Controls.Add(this.dtFecha);
            this.metroTabPage1.Controls.Add(this.lblCliente);
            this.metroTabPage1.Controls.Add(this.lblFechaRecibido);
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
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 206);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 40;
            this.metroLabel1.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.ItemHeight = 19;
            this.cbEstado.Items.AddRange(new object[] {
            "Recibido",
            "En Proceso",
            "Entregado"});
            this.cbEstado.Location = new System.Drawing.Point(4, 228);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(410, 25);
            this.cbEstado.TabIndex = 39;
            this.cbEstado.UseSelectable = true;
            // 
            // dtFechaEntrega
            // 
            this.dtFechaEntrega.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtFechaEntrega.Location = new System.Drawing.Point(218, 166);
            this.dtFechaEntrega.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtFechaEntrega.Name = "dtFechaEntrega";
            this.dtFechaEntrega.Size = new System.Drawing.Size(196, 25);
            this.dtFechaEntrega.TabIndex = 37;
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Location = new System.Drawing.Point(217, 144);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(114, 19);
            this.lblFechaEntrega.TabIndex = 38;
            this.lblFechaEntrega.Text = "Fecha de entrega:";
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
            this.tbTelefono.MaxLength = 15;
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
            // dtFecha
            // 
            this.dtFecha.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtFecha.Location = new System.Drawing.Point(4, 166);
            this.dtFecha.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(203, 25);
            this.dtFecha.TabIndex = 3;
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
            // lblFechaRecibido
            // 
            this.lblFechaRecibido.AutoSize = true;
            this.lblFechaRecibido.Location = new System.Drawing.Point(3, 144);
            this.lblFechaRecibido.Name = "lblFechaRecibido";
            this.lblFechaRecibido.Size = new System.Drawing.Size(117, 19);
            this.lblFechaRecibido.TabIndex = 17;
            this.lblFechaRecibido.Text = "Fecha de recibido:";
            // 
            // tbCliente
            // 
            this.tbCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCliente.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbCliente.Location = new System.Drawing.Point(4, 41);
            this.tbCliente.MaxLength = 40;
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(410, 25);
            this.tbCliente.TabIndex = 1;
            this.tbCliente.Text = "Ej. Juan";
            this.tbCliente.Enter += new System.EventHandler(this.tbCliente_Enter);
            this.tbCliente.Leave += new System.EventHandler(this.tbCliente_Leave);
            // 
            // PopUpLavanderiaModificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 461);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PopUpLavanderiaModificacion";
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

        public System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel lblCliente;
        private MetroFramework.Controls.MetroLabel lblFechaRecibido;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private MetroFramework.Controls.MetroDateTime dtFecha;
        private MetroFramework.Controls.MetroLabel lblTelefono;
        private System.Windows.Forms.TextBox tbTelefono;
        private MetroFramework.Controls.MetroDateTime dtFechaEntrega;
        private MetroFramework.Controls.MetroLabel lblFechaEntrega;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbEstado;
    }
}