namespace setup_downloader_proyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbCuenta = new System.Windows.Forms.GroupBox();
            this.cbSetupCuenta = new System.Windows.Forms.CheckBox();
            this.btnDescargarCuenta = new System.Windows.Forms.Button();
            this.cbTelemetriaCuenta = new System.Windows.Forms.CheckBox();
            this.cbOlapCuenta = new System.Windows.Forms.CheckBox();
            this.cbBlapCuenta = new System.Windows.Forms.CheckBox();
            this.cbCuenta = new System.Windows.Forms.ComboBox();
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.btnBorrarCategoria = new System.Windows.Forms.Button();
            this.cbSetupCategoria = new System.Windows.Forms.CheckBox();
            this.lstCategoria = new System.Windows.Forms.ListBox();
            this.btnDescargarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.cbTelemetriaCategoria = new System.Windows.Forms.CheckBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbOlapCategoria = new System.Windows.Forms.CheckBox();
            this.cbBlapCategoria = new System.Windows.Forms.CheckBox();
            this.gbCoche = new System.Windows.Forms.GroupBox();
            this.btnBorrarCoche = new System.Windows.Forms.Button();
            this.cbSetupCoche = new System.Windows.Forms.CheckBox();
            this.cbCoche = new System.Windows.Forms.ComboBox();
            this.lstCoche = new System.Windows.Forms.ListBox();
            this.cbBlapCoche = new System.Windows.Forms.CheckBox();
            this.btnDescargarCoche = new System.Windows.Forms.Button();
            this.cbOlapCoche = new System.Windows.Forms.CheckBox();
            this.btnAgregarCoche = new System.Windows.Forms.Button();
            this.cbTelemetriaCoche = new System.Windows.Forms.CheckBox();
            this.gbCuenta.SuspendLayout();
            this.gbCategoria.SuspendLayout();
            this.gbCoche.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCuenta
            // 
            this.gbCuenta.Controls.Add(this.cbSetupCuenta);
            this.gbCuenta.Controls.Add(this.btnDescargarCuenta);
            this.gbCuenta.Controls.Add(this.cbTelemetriaCuenta);
            this.gbCuenta.Controls.Add(this.cbOlapCuenta);
            this.gbCuenta.Controls.Add(this.cbBlapCuenta);
            this.gbCuenta.Controls.Add(this.cbCuenta);
            this.gbCuenta.Location = new System.Drawing.Point(12, 34);
            this.gbCuenta.Name = "gbCuenta";
            this.gbCuenta.Size = new System.Drawing.Size(571, 160);
            this.gbCuenta.TabIndex = 0;
            this.gbCuenta.TabStop = false;
            this.gbCuenta.Text = "Cuentas";
            this.gbCuenta.Enter += new System.EventHandler(this.gbCuenta_Enter);
            // 
            // cbSetupCuenta
            // 
            this.cbSetupCuenta.AutoSize = true;
            this.cbSetupCuenta.Location = new System.Drawing.Point(447, 83);
            this.cbSetupCuenta.Name = "cbSetupCuenta";
            this.cbSetupCuenta.Size = new System.Drawing.Size(59, 17);
            this.cbSetupCuenta.TabIndex = 4;
            this.cbSetupCuenta.Text = "Setups";
            this.cbSetupCuenta.UseVisualStyleBackColor = true;
            // 
            // btnDescargarCuenta
            // 
            this.btnDescargarCuenta.Location = new System.Drawing.Point(447, 112);
            this.btnDescargarCuenta.Name = "btnDescargarCuenta";
            this.btnDescargarCuenta.Size = new System.Drawing.Size(75, 23);
            this.btnDescargarCuenta.TabIndex = 5;
            this.btnDescargarCuenta.Text = "Descargar";
            this.btnDescargarCuenta.UseVisualStyleBackColor = true;
            this.btnDescargarCuenta.Click += new System.EventHandler(this.btnDescargarCuenta_Click);
            // 
            // cbTelemetriaCuenta
            // 
            this.cbTelemetriaCuenta.AutoSize = true;
            this.cbTelemetriaCuenta.Location = new System.Drawing.Point(447, 60);
            this.cbTelemetriaCuenta.Name = "cbTelemetriaCuenta";
            this.cbTelemetriaCuenta.Size = new System.Drawing.Size(77, 17);
            this.cbTelemetriaCuenta.TabIndex = 3;
            this.cbTelemetriaCuenta.Text = "Telemetría";
            this.cbTelemetriaCuenta.UseVisualStyleBackColor = true;
            // 
            // cbOlapCuenta
            // 
            this.cbOlapCuenta.AutoSize = true;
            this.cbOlapCuenta.Location = new System.Drawing.Point(447, 37);
            this.cbOlapCuenta.Name = "cbOlapCuenta";
            this.cbOlapCuenta.Size = new System.Drawing.Size(46, 17);
            this.cbOlapCuenta.TabIndex = 2;
            this.cbOlapCuenta.Text = "olap";
            this.cbOlapCuenta.UseVisualStyleBackColor = true;
            // 
            // cbBlapCuenta
            // 
            this.cbBlapCuenta.AutoSize = true;
            this.cbBlapCuenta.Location = new System.Drawing.Point(447, 17);
            this.cbBlapCuenta.Name = "cbBlapCuenta";
            this.cbBlapCuenta.Size = new System.Drawing.Size(46, 17);
            this.cbBlapCuenta.TabIndex = 1;
            this.cbBlapCuenta.Text = "blap";
            this.cbBlapCuenta.UseVisualStyleBackColor = true;
            // 
            // cbCuenta
            // 
            this.cbCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCuenta.FormattingEnabled = true;
            this.cbCuenta.Location = new System.Drawing.Point(15, 60);
            this.cbCuenta.Name = "cbCuenta";
            this.cbCuenta.Size = new System.Drawing.Size(219, 21);
            this.cbCuenta.TabIndex = 0;
            this.cbCuenta.SelectedIndexChanged += new System.EventHandler(this.cbCuenta_SelectedIndexChanged);
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.btnBorrarCategoria);
            this.gbCategoria.Controls.Add(this.cbSetupCategoria);
            this.gbCategoria.Controls.Add(this.lstCategoria);
            this.gbCategoria.Controls.Add(this.btnDescargarCategoria);
            this.gbCategoria.Controls.Add(this.btnAgregarCategoria);
            this.gbCategoria.Controls.Add(this.cbTelemetriaCategoria);
            this.gbCategoria.Controls.Add(this.cbCategoria);
            this.gbCategoria.Controls.Add(this.cbOlapCategoria);
            this.gbCategoria.Controls.Add(this.cbBlapCategoria);
            this.gbCategoria.Location = new System.Drawing.Point(12, 200);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(571, 227);
            this.gbCategoria.TabIndex = 1;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Categorías";
            // 
            // btnBorrarCategoria
            // 
            this.btnBorrarCategoria.Location = new System.Drawing.Point(142, 143);
            this.btnBorrarCategoria.Name = "btnBorrarCategoria";
            this.btnBorrarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarCategoria.TabIndex = 2;
            this.btnBorrarCategoria.Text = "Borrar";
            this.btnBorrarCategoria.UseVisualStyleBackColor = true;
            this.btnBorrarCategoria.Click += new System.EventHandler(this.btnBorrarCategoria_Click);
            // 
            // cbSetupCategoria
            // 
            this.cbSetupCategoria.AutoSize = true;
            this.cbSetupCategoria.Location = new System.Drawing.Point(447, 114);
            this.cbSetupCategoria.Name = "cbSetupCategoria";
            this.cbSetupCategoria.Size = new System.Drawing.Size(59, 17);
            this.cbSetupCategoria.TabIndex = 7;
            this.cbSetupCategoria.Text = "Setups";
            this.cbSetupCategoria.UseVisualStyleBackColor = true;
            // 
            // lstCategoria
            // 
            this.lstCategoria.FormattingEnabled = true;
            this.lstCategoria.Location = new System.Drawing.Point(253, 25);
            this.lstCategoria.Name = "lstCategoria";
            this.lstCategoria.Size = new System.Drawing.Size(188, 173);
            this.lstCategoria.TabIndex = 3;
            // 
            // btnDescargarCategoria
            // 
            this.btnDescargarCategoria.Location = new System.Drawing.Point(447, 143);
            this.btnDescargarCategoria.Name = "btnDescargarCategoria";
            this.btnDescargarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnDescargarCategoria.TabIndex = 8;
            this.btnDescargarCategoria.Text = "Descargar";
            this.btnDescargarCategoria.UseVisualStyleBackColor = true;
            this.btnDescargarCategoria.Click += new System.EventHandler(this.btnDescargarCategoria_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(25, 143);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCategoria.TabIndex = 1;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // cbTelemetriaCategoria
            // 
            this.cbTelemetriaCategoria.AutoSize = true;
            this.cbTelemetriaCategoria.Location = new System.Drawing.Point(447, 91);
            this.cbTelemetriaCategoria.Name = "cbTelemetriaCategoria";
            this.cbTelemetriaCategoria.Size = new System.Drawing.Size(77, 17);
            this.cbTelemetriaCategoria.TabIndex = 6;
            this.cbTelemetriaCategoria.Text = "Telemetría";
            this.cbTelemetriaCategoria.UseVisualStyleBackColor = true;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(15, 64);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbCategoria.Size = new System.Drawing.Size(219, 21);
            this.cbCategoria.TabIndex = 0;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // cbOlapCategoria
            // 
            this.cbOlapCategoria.AutoSize = true;
            this.cbOlapCategoria.Location = new System.Drawing.Point(447, 68);
            this.cbOlapCategoria.Name = "cbOlapCategoria";
            this.cbOlapCategoria.Size = new System.Drawing.Size(46, 17);
            this.cbOlapCategoria.TabIndex = 5;
            this.cbOlapCategoria.Text = "olap";
            this.cbOlapCategoria.UseVisualStyleBackColor = true;
            // 
            // cbBlapCategoria
            // 
            this.cbBlapCategoria.AutoSize = true;
            this.cbBlapCategoria.Location = new System.Drawing.Point(447, 48);
            this.cbBlapCategoria.Name = "cbBlapCategoria";
            this.cbBlapCategoria.Size = new System.Drawing.Size(46, 17);
            this.cbBlapCategoria.TabIndex = 4;
            this.cbBlapCategoria.Text = "blap";
            this.cbBlapCategoria.UseVisualStyleBackColor = true;
            // 
            // gbCoche
            // 
            this.gbCoche.Controls.Add(this.btnBorrarCoche);
            this.gbCoche.Controls.Add(this.cbSetupCoche);
            this.gbCoche.Controls.Add(this.cbCoche);
            this.gbCoche.Controls.Add(this.lstCoche);
            this.gbCoche.Controls.Add(this.cbBlapCoche);
            this.gbCoche.Controls.Add(this.btnDescargarCoche);
            this.gbCoche.Controls.Add(this.cbOlapCoche);
            this.gbCoche.Controls.Add(this.btnAgregarCoche);
            this.gbCoche.Controls.Add(this.cbTelemetriaCoche);
            this.gbCoche.Location = new System.Drawing.Point(12, 446);
            this.gbCoche.Name = "gbCoche";
            this.gbCoche.Size = new System.Drawing.Size(571, 223);
            this.gbCoche.TabIndex = 1;
            this.gbCoche.TabStop = false;
            this.gbCoche.Text = "Coches";
            // 
            // btnBorrarCoche
            // 
            this.btnBorrarCoche.Location = new System.Drawing.Point(142, 142);
            this.btnBorrarCoche.Name = "btnBorrarCoche";
            this.btnBorrarCoche.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarCoche.TabIndex = 2;
            this.btnBorrarCoche.Text = "Borrar";
            this.btnBorrarCoche.UseVisualStyleBackColor = true;
            this.btnBorrarCoche.Click += new System.EventHandler(this.btnBorrarCoche_Click);
            // 
            // cbSetupCoche
            // 
            this.cbSetupCoche.AutoSize = true;
            this.cbSetupCoche.Location = new System.Drawing.Point(447, 113);
            this.cbSetupCoche.Name = "cbSetupCoche";
            this.cbSetupCoche.Size = new System.Drawing.Size(59, 17);
            this.cbSetupCoche.TabIndex = 7;
            this.cbSetupCoche.Text = "Setups";
            this.cbSetupCoche.UseVisualStyleBackColor = true;
            // 
            // cbCoche
            // 
            this.cbCoche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoche.FormattingEnabled = true;
            this.cbCoche.Location = new System.Drawing.Point(15, 66);
            this.cbCoche.Name = "cbCoche";
            this.cbCoche.Size = new System.Drawing.Size(219, 21);
            this.cbCoche.TabIndex = 0;
            // 
            // lstCoche
            // 
            this.lstCoche.FormattingEnabled = true;
            this.lstCoche.Location = new System.Drawing.Point(253, 24);
            this.lstCoche.Name = "lstCoche";
            this.lstCoche.Size = new System.Drawing.Size(175, 173);
            this.lstCoche.TabIndex = 3;
            // 
            // cbBlapCoche
            // 
            this.cbBlapCoche.AutoSize = true;
            this.cbBlapCoche.Location = new System.Drawing.Point(447, 47);
            this.cbBlapCoche.Name = "cbBlapCoche";
            this.cbBlapCoche.Size = new System.Drawing.Size(46, 17);
            this.cbBlapCoche.TabIndex = 4;
            this.cbBlapCoche.Text = "blap";
            this.cbBlapCoche.UseVisualStyleBackColor = true;
            // 
            // btnDescargarCoche
            // 
            this.btnDescargarCoche.Location = new System.Drawing.Point(447, 142);
            this.btnDescargarCoche.Name = "btnDescargarCoche";
            this.btnDescargarCoche.Size = new System.Drawing.Size(75, 23);
            this.btnDescargarCoche.TabIndex = 8;
            this.btnDescargarCoche.Text = "Descargar";
            this.btnDescargarCoche.UseVisualStyleBackColor = true;
            this.btnDescargarCoche.Click += new System.EventHandler(this.btnDescargarCoche_Click);
            // 
            // cbOlapCoche
            // 
            this.cbOlapCoche.AutoSize = true;
            this.cbOlapCoche.Location = new System.Drawing.Point(447, 67);
            this.cbOlapCoche.Name = "cbOlapCoche";
            this.cbOlapCoche.Size = new System.Drawing.Size(46, 17);
            this.cbOlapCoche.TabIndex = 5;
            this.cbOlapCoche.Text = "olap";
            this.cbOlapCoche.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCoche
            // 
            this.btnAgregarCoche.Location = new System.Drawing.Point(25, 142);
            this.btnAgregarCoche.Name = "btnAgregarCoche";
            this.btnAgregarCoche.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCoche.TabIndex = 1;
            this.btnAgregarCoche.Text = "Agregar";
            this.btnAgregarCoche.UseVisualStyleBackColor = true;
            this.btnAgregarCoche.Click += new System.EventHandler(this.btnAgregarCoche_Click);
            // 
            // cbTelemetriaCoche
            // 
            this.cbTelemetriaCoche.AutoSize = true;
            this.cbTelemetriaCoche.Location = new System.Drawing.Point(447, 90);
            this.cbTelemetriaCoche.Name = "cbTelemetriaCoche";
            this.cbTelemetriaCoche.Size = new System.Drawing.Size(77, 17);
            this.cbTelemetriaCoche.TabIndex = 6;
            this.cbTelemetriaCoche.Text = "Telemetría";
            this.cbTelemetriaCoche.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 706);
            this.Controls.Add(this.gbCategoria);
            this.Controls.Add(this.gbCoche);
            this.Controls.Add(this.gbCuenta);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Setup dowloader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCuenta.ResumeLayout(false);
            this.gbCuenta.PerformLayout();
            this.gbCategoria.ResumeLayout(false);
            this.gbCategoria.PerformLayout();
            this.gbCoche.ResumeLayout(false);
            this.gbCoche.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCuenta;
        private System.Windows.Forms.CheckBox cbSetupCuenta;
        private System.Windows.Forms.Button btnDescargarCuenta;
        private System.Windows.Forms.CheckBox cbTelemetriaCuenta;
        private System.Windows.Forms.CheckBox cbOlapCuenta;
        private System.Windows.Forms.CheckBox cbBlapCuenta;
        private System.Windows.Forms.ComboBox cbCuenta;
        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.CheckBox cbSetupCategoria;
        private System.Windows.Forms.ListBox lstCategoria;
        private System.Windows.Forms.Button btnDescargarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.CheckBox cbTelemetriaCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.CheckBox cbOlapCategoria;
        private System.Windows.Forms.CheckBox cbBlapCategoria;
        private System.Windows.Forms.GroupBox gbCoche;
        private System.Windows.Forms.CheckBox cbSetupCoche;
        private System.Windows.Forms.ComboBox cbCoche;
        private System.Windows.Forms.ListBox lstCoche;
        private System.Windows.Forms.CheckBox cbBlapCoche;
        private System.Windows.Forms.Button btnDescargarCoche;
        private System.Windows.Forms.CheckBox cbOlapCoche;
        private System.Windows.Forms.Button btnAgregarCoche;
        private System.Windows.Forms.CheckBox cbTelemetriaCoche;
        private System.Windows.Forms.Button btnBorrarCategoria;
        private System.Windows.Forms.Button btnBorrarCoche;
    }
}

