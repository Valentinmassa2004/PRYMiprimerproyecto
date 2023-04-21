namespace PRYMiprimerproyecto
{
    partial class frmalacena
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
            this.fmalacena = new System.Windows.Forms.GroupBox();
            this.lstcategorias = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmdbuscar = new System.Windows.Forms.Button();
            this.fmalacena.SuspendLayout();
            this.SuspendLayout();
            // 
            // fmalacena
            // 
            this.fmalacena.Controls.Add(this.cmdbuscar);
            this.fmalacena.Controls.Add(this.lstcategorias);
            this.fmalacena.Location = new System.Drawing.Point(0, 0);
            this.fmalacena.Name = "fmalacena";
            this.fmalacena.Size = new System.Drawing.Size(273, 143);
            this.fmalacena.TabIndex = 0;
            this.fmalacena.TabStop = false;
            this.fmalacena.Text = "Alacena";
            // 
            // lstcategorias
            // 
            this.lstcategorias.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstcategorias.FormattingEnabled = true;
            this.lstcategorias.Items.AddRange(new object[] {
            "Productos de limpieza",
            "Productos perecederos",
            "Azucar ",
            "Yerba",
            "Galletas",
            "Pamificaiones",
            "Aceite",
            "Vinagre",
            "Sal gruesa y fina",
            "Rollisec"});
            this.lstcategorias.Location = new System.Drawing.Point(12, 40);
            this.lstcategorias.Name = "lstcategorias";
            this.lstcategorias.Size = new System.Drawing.Size(243, 33);
            this.lstcategorias.TabIndex = 0;
            this.lstcategorias.Text = "categorias";
            this.lstcategorias.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmdbuscar
            // 
            this.cmdbuscar.Font = new System.Drawing.Font("Wide Latin", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdbuscar.Location = new System.Drawing.Point(159, 106);
            this.cmdbuscar.Name = "cmdbuscar";
            this.cmdbuscar.Size = new System.Drawing.Size(96, 29);
            this.cmdbuscar.TabIndex = 1;
            this.cmdbuscar.Text = "Buscar";
            this.cmdbuscar.UseVisualStyleBackColor = true;
            this.cmdbuscar.Click += new System.EventHandler(this.cmdbuscar_Click);
            // 
            // frmalacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 147);
            this.Controls.Add(this.fmalacena);
            this.Name = "frmalacena";
            this.Text = "Alacena";
            this.fmalacena.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox fmalacena;
        private System.Windows.Forms.ComboBox lstcategorias;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button cmdbuscar;
    }
}