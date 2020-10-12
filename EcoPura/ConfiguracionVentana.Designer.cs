namespace EcoPura
{
    partial class ConfiguracionVentana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguracionVentana));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbTipoCambio = new MetroFramework.Controls.MetroTextBox();
            this.lblTicket = new MetroFramework.Controls.MetroLabel();
            this.cbImpresora = new MetroFramework.Controls.MetroComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(16, 17);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(29, 36);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 27;
            this.pbLogo.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(32, 89);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(134, 25);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "Tipo de cambio:";
            // 
            // tbTipoCambio
            // 
            // 
            // 
            // 
            this.tbTipoCambio.CustomButton.Image = null;
            this.tbTipoCambio.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.tbTipoCambio.CustomButton.Name = "";
            this.tbTipoCambio.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.tbTipoCambio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTipoCambio.CustomButton.TabIndex = 1;
            this.tbTipoCambio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTipoCambio.CustomButton.UseSelectable = true;
            this.tbTipoCambio.CustomButton.Visible = false;
            this.tbTipoCambio.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbTipoCambio.Lines = new string[0];
            this.tbTipoCambio.Location = new System.Drawing.Point(35, 117);
            this.tbTipoCambio.MaxLength = 32767;
            this.tbTipoCambio.Name = "tbTipoCambio";
            this.tbTipoCambio.PasswordChar = '\0';
            this.tbTipoCambio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTipoCambio.SelectedText = "";
            this.tbTipoCambio.SelectionLength = 0;
            this.tbTipoCambio.SelectionStart = 0;
            this.tbTipoCambio.ShortcutsEnabled = true;
            this.tbTipoCambio.Size = new System.Drawing.Size(353, 35);
            this.tbTipoCambio.TabIndex = 29;
            this.tbTipoCambio.UseSelectable = true;
            this.tbTipoCambio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTipoCambio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTicket.Location = new System.Drawing.Point(32, 181);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(164, 25);
            this.lblTicket.TabIndex = 30;
            this.lblTicket.Text = "Impresora de Ticket:";
            // 
            // cbImpresora
            // 
            this.cbImpresora.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbImpresora.FormattingEnabled = true;
            this.cbImpresora.ItemHeight = 29;
            this.cbImpresora.Location = new System.Drawing.Point(35, 209);
            this.cbImpresora.Name = "cbImpresora";
            this.cbImpresora.Size = new System.Drawing.Size(353, 35);
            this.cbImpresora.TabIndex = 31;
            this.cbImpresora.UseSelectable = true;
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
            this.btnCancelar.Location = new System.Drawing.Point(211, 275);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 29);
            this.btnCancelar.TabIndex = 33;
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
            this.btnAgregar.Location = new System.Drawing.Point(115, 275);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(81, 29);
            this.btnAgregar.TabIndex = 32;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // ConfiguracionVentana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 343);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbImpresora);
            this.Controls.Add(this.lblTicket);
            this.Controls.Add(this.tbTipoCambio);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pbLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConfiguracionVentana";
            this.Resizable = false;
            this.Text = "    Configuración";
            this.Load += new System.EventHandler(this.ConfiguracionVentana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbTipoCambio;
        private MetroFramework.Controls.MetroLabel lblTicket;
        private MetroFramework.Controls.MetroComboBox cbImpresora;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
    }
}