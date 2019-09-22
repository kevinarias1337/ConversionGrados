namespace conversiongrados
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbtipogrados = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgrados = new System.Windows.Forms.TextBox();
            this.btnconvertir = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversión de grados.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la cantidad de grados a convertir:";
            // 
            // cbtipogrados
            // 
            this.cbtipogrados.FormattingEnabled = true;
            this.cbtipogrados.Items.AddRange(new object[] {
            "Farenheit",
            "Celcius"});
            this.cbtipogrados.Location = new System.Drawing.Point(80, 60);
            this.cbtipogrados.Name = "cbtipogrados";
            this.cbtipogrados.Size = new System.Drawing.Size(121, 21);
            this.cbtipogrados.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingrese el tipo de grados a convertir:";
            // 
            // txtgrados
            // 
            this.txtgrados.Location = new System.Drawing.Point(90, 116);
            this.txtgrados.Name = "txtgrados";
            this.txtgrados.Size = new System.Drawing.Size(100, 20);
            this.txtgrados.TabIndex = 4;
            // 
            // btnconvertir
            // 
            this.btnconvertir.Location = new System.Drawing.Point(102, 145);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(75, 23);
            this.btnconvertir.TabIndex = 5;
            this.btnconvertir.Text = "Convertir";
            this.btnconvertir.UseVisualStyleBackColor = true;
            this.btnconvertir.Click += new System.EventHandler(this.btnconvertir_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(99, 193);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(35, 13);
            this.lblresultado.TabIndex = 6;
            this.lblresultado.Text = "label4";
            this.lblresultado.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 215);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnconvertir);
            this.Controls.Add(this.txtgrados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbtipogrados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbtipogrados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgrados;
        private System.Windows.Forms.Button btnconvertir;
        private System.Windows.Forms.Label lblresultado;
    }
}

