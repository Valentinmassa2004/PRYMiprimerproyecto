namespace PRYMiprimerproyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmensualidad = new System.Windows.Forms.TextBox();
            this.txtgastosfijos = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.ingresos = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblimpuestos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.txtgastosfijos.SuspendLayout();
            this.ingresos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmensualidad);
            this.groupBox1.Location = new System.Drawing.Point(22, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 19);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mensualidad";
            // 
            // txtmensualidad
            // 
            this.txtmensualidad.Location = new System.Drawing.Point(90, 0);
            this.txtmensualidad.Name = "txtmensualidad";
            this.txtmensualidad.Size = new System.Drawing.Size(100, 20);
            this.txtmensualidad.TabIndex = 0;
            this.txtmensualidad.Text = "$63000";
            this.txtmensualidad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtgastosfijos
            // 
            this.txtgastosfijos.Controls.Add(this.label5);
            this.txtgastosfijos.Controls.Add(this.lblimpuestos);
            this.txtgastosfijos.Controls.Add(this.label1);
            this.txtgastosfijos.Controls.Add(this.button2);
            this.txtgastosfijos.Controls.Add(this.textBox4);
            this.txtgastosfijos.Controls.Add(this.textBox7);
            this.txtgastosfijos.Controls.Add(this.textBox3);
            this.txtgastosfijos.Controls.Add(this.label3);
            this.txtgastosfijos.Controls.Add(this.textBox2);
            this.txtgastosfijos.Controls.Add(this.lbl);
            this.txtgastosfijos.Location = new System.Drawing.Point(22, 70);
            this.txtgastosfijos.Name = "txtgastosfijos";
            this.txtgastosfijos.Size = new System.Drawing.Size(204, 175);
            this.txtgastosfijos.TabIndex = 1;
            this.txtgastosfijos.TabStop = false;
            this.txtgastosfijos.Text = "Gastos fijos";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(115, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "CALCULAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(78, 81);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "$";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(78, 107);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 5;
            this.textBox7.Text = "$";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(78, 55);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gastos varios";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "$";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(6, 29);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(41, 91);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Alquiler\r\n\r\n\r\n\r\n\r\n\r\n ";
            this.lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(182, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(76, 261);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "$";
            // 
            // ingresos
            // 
            this.ingresos.Controls.Add(this.textBox6);
            this.ingresos.Controls.Add(this.textBox5);
            this.ingresos.Controls.Add(this.label4);
            this.ingresos.Controls.Add(this.button1);
            this.ingresos.Controls.Add(this.label2);
            this.ingresos.Controls.Add(this.txtgastosfijos);
            this.ingresos.Controls.Add(this.groupBox1);
            this.ingresos.Location = new System.Drawing.Point(12, 12);
            this.ingresos.Name = "ingresos";
            this.ingresos.Size = new System.Drawing.Size(346, 414);
            this.ingresos.TabIndex = 1;
            this.ingresos.TabStop = false;
            this.ingresos.Text = "Ingresos";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(76, 314);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 8;
            this.textBox6.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // lblimpuestos
            // 
            this.lblimpuestos.AutoSize = true;
            this.lblimpuestos.Location = new System.Drawing.Point(6, 58);
            this.lblimpuestos.Name = "lblimpuestos";
            this.lblimpuestos.Size = new System.Drawing.Size(55, 13);
            this.lblimpuestos.TabIndex = 8;
            this.lblimpuestos.Text = "Impuestos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Comida";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 355);
            this.Controls.Add(this.ingresos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "mensualidad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.txtgastosfijos.ResumeLayout(false);
            this.txtgastosfijos.PerformLayout();
            this.ingresos.ResumeLayout(false);
            this.ingresos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmensualidad;
        private System.Windows.Forms.GroupBox txtgastosfijos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox ingresos;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblimpuestos;
        private System.Windows.Forms.Label label5;
    }
}

