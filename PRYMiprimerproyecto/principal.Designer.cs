namespace PRYMiprimerproyecto
{
    partial class principal
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
            this.btnmensualidad = new System.Windows.Forms.Button();
            this.btnalacena = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmensualidad
            // 
            this.btnmensualidad.Location = new System.Drawing.Point(3, 12);
            this.btnmensualidad.Name = "btnmensualidad";
            this.btnmensualidad.Size = new System.Drawing.Size(445, 127);
            this.btnmensualidad.TabIndex = 0;
            this.btnmensualidad.Text = "mensualidad";
            this.btnmensualidad.UseVisualStyleBackColor = true;
            this.btnmensualidad.Click += new System.EventHandler(this.btnmensualidad_Click);
            // 
            // btnalacena
            // 
            this.btnalacena.Location = new System.Drawing.Point(3, 155);
            this.btnalacena.Name = "btnalacena";
            this.btnalacena.Size = new System.Drawing.Size(445, 137);
            this.btnalacena.TabIndex = 1;
            this.btnalacena.Text = "alacena";
            this.btnalacena.UseVisualStyleBackColor = true;
            this.btnalacena.Click += new System.EventHandler(this.btnalacena_Click);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 347);
            this.Controls.Add(this.btnalacena);
            this.Controls.Add(this.btnmensualidad);
            this.Name = "principal";
            this.Text = "principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmensualidad;
        private System.Windows.Forms.Button btnalacena;
    }
}