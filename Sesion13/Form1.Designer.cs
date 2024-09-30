namespace MetodoBurbuja
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
            this.btnumero = new System.Windows.Forms.TextBox();
            this.btagregar = new System.Windows.Forms.Button();
            this.lbNumbers = new System.Windows.Forms.ListBox();
            this.btnsort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa un #:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnumero
            // 
            this.btnumero.Location = new System.Drawing.Point(118, 24);
            this.btnumero.Name = "btnumero";
            this.btnumero.Size = new System.Drawing.Size(100, 20);
            this.btnumero.TabIndex = 1;
            // 
            // btagregar
            // 
            this.btagregar.Location = new System.Drawing.Point(245, 24);
            this.btagregar.Name = "btagregar";
            this.btagregar.Size = new System.Drawing.Size(75, 23);
            this.btagregar.TabIndex = 2;
            this.btagregar.Text = "Agregar";
            this.btagregar.UseVisualStyleBackColor = true;
            this.btagregar.Click += new System.EventHandler(this.btagregar_Click);
            // 
            // lbNumbers
            // 
            this.lbNumbers.FormattingEnabled = true;
            this.lbNumbers.Location = new System.Drawing.Point(77, 91);
            this.lbNumbers.Name = "lbNumbers";
            this.lbNumbers.Size = new System.Drawing.Size(186, 134);
            this.lbNumbers.TabIndex = 3;
            // 
            // btnsort
            // 
            this.btnsort.Location = new System.Drawing.Point(245, 62);
            this.btnsort.Name = "btnsort";
            this.btnsort.Size = new System.Drawing.Size(75, 23);
            this.btnsort.TabIndex = 4;
            this.btnsort.Text = "Ordenar";
            this.btnsort.UseVisualStyleBackColor = true;
            this.btnsort.Click += new System.EventHandler(this.btnsort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsort);
            this.Controls.Add(this.lbNumbers);
            this.Controls.Add(this.btagregar);
            this.Controls.Add(this.btnumero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ingresa un #:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox btnumero;
        private System.Windows.Forms.Button btagregar;
        private System.Windows.Forms.ListBox lbNumbers;
        private System.Windows.Forms.Button btnsort;
    }
}

