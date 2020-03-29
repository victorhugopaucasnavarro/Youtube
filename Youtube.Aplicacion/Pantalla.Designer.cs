namespace Youtube.Aplicacion
{
    partial class Pantalla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla));
            this.lblEnlace = new System.Windows.Forms.Label();
            this.txtEnlace = new System.Windows.Forms.TextBox();
            this.pgbProgreso = new System.Windows.Forms.ProgressBar();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.lblProgreso = new System.Windows.Forms.Label();
            this.btnRuta = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.mstContenedor = new System.Windows.Forms.MenuStrip();
            this.tsmAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.fbdRuta = new System.Windows.Forms.FolderBrowserDialog();
            this.cboArchivo = new System.Windows.Forms.ComboBox();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.mstContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnlace
            // 
            this.lblEnlace.AutoSize = true;
            this.lblEnlace.Location = new System.Drawing.Point(34, 89);
            this.lblEnlace.Name = "lblEnlace";
            this.lblEnlace.Size = new System.Drawing.Size(72, 19);
            this.lblEnlace.TabIndex = 0;
            this.lblEnlace.Text = "Enlace:";
            // 
            // txtEnlace
            // 
            this.txtEnlace.Location = new System.Drawing.Point(121, 86);
            this.txtEnlace.Name = "txtEnlace";
            this.txtEnlace.Size = new System.Drawing.Size(447, 26);
            this.txtEnlace.TabIndex = 1;
            this.txtEnlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pgbProgreso
            // 
            this.pgbProgreso.Location = new System.Drawing.Point(38, 213);
            this.pgbProgreso.Name = "pgbProgreso";
            this.pgbProgreso.Size = new System.Drawing.Size(658, 23);
            this.pgbProgreso.TabIndex = 0;
            // 
            // btnDescargar
            // 
            this.btnDescargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescargar.Location = new System.Drawing.Point(448, 152);
            this.btnDescargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(120, 34);
            this.btnDescargar.TabIndex = 3;
            this.btnDescargar.TabStop = false;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // lblProgreso
            // 
            this.lblProgreso.AutoSize = true;
            this.lblProgreso.Location = new System.Drawing.Point(34, 191);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(0, 19);
            this.lblProgreso.TabIndex = 0;
            // 
            // btnRuta
            // 
            this.btnRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRuta.Location = new System.Drawing.Point(576, 48);
            this.btnRuta.Margin = new System.Windows.Forms.Padding(4);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(120, 34);
            this.btnRuta.TabIndex = 0;
            this.btnRuta.Text = "Seleccionar";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.BackColor = System.Drawing.Color.White;
            this.txtRuta.Enabled = false;
            this.txtRuta.Location = new System.Drawing.Point(121, 53);
            this.txtRuta.Margin = new System.Windows.Forms.Padding(4);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(447, 26);
            this.txtRuta.TabIndex = 9;
            this.txtRuta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(34, 56);
            this.lblRuta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(54, 19);
            this.lblRuta.TabIndex = 8;
            this.lblRuta.Text = "Ruta:";
            // 
            // mstContenedor
            // 
            this.mstContenedor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstContenedor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAyuda});
            this.mstContenedor.Location = new System.Drawing.Point(0, 0);
            this.mstContenedor.Name = "mstContenedor";
            this.mstContenedor.Size = new System.Drawing.Size(734, 27);
            this.mstContenedor.TabIndex = 10;
            this.mstContenedor.Text = "menuStrip1";
            // 
            // tsmAyuda
            // 
            this.tsmAyuda.Name = "tsmAyuda";
            this.tsmAyuda.Size = new System.Drawing.Size(66, 23);
            this.tsmAyuda.Text = "Ayuda";
            this.tsmAyuda.Click += new System.EventHandler(this.tsmAyuda_Click);
            // 
            // cboArchivo
            // 
            this.cboArchivo.BackColor = System.Drawing.Color.White;
            this.cboArchivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArchivo.FormattingEnabled = true;
            this.cboArchivo.Items.AddRange(new object[] {
            "Audio",
            "Video"});
            this.cboArchivo.Location = new System.Drawing.Point(121, 118);
            this.cboArchivo.Name = "cboArchivo";
            this.cboArchivo.Size = new System.Drawing.Size(447, 27);
            this.cboArchivo.TabIndex = 2;
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(34, 121);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(81, 19);
            this.lblArchivo.TabIndex = 0;
            this.lblArchivo.Text = "Archivo:";
            // 
            // Pantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 211);
            this.Controls.Add(this.lblArchivo);
            this.Controls.Add(this.cboArchivo);
            this.Controls.Add(this.mstContenedor);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.lblProgreso);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.pgbProgreso);
            this.Controls.Add(this.txtEnlace);
            this.Controls.Add(this.lblEnlace);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Pantalla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube";
            this.Load += new System.EventHandler(this.Pantalla_Load);
            this.mstContenedor.ResumeLayout(false);
            this.mstContenedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnlace;
        private System.Windows.Forms.TextBox txtEnlace;
        private System.Windows.Forms.ProgressBar pgbProgreso;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.Label lblProgreso;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.MenuStrip mstContenedor;
        private System.Windows.Forms.ToolStripMenuItem tsmAyuda;
        private System.Windows.Forms.FolderBrowserDialog fbdRuta;
        private System.Windows.Forms.ComboBox cboArchivo;
        private System.Windows.Forms.Label lblArchivo;
    }
}

