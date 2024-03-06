namespace TrackBar_EJE14
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
            this.lbl_Texto = new System.Windows.Forms.Label();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.trackBar_Tamaño = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Tamaño)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Texto
            // 
            this.lbl_Texto.AutoSize = true;
            this.lbl_Texto.Location = new System.Drawing.Point(166, 89);
            this.lbl_Texto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Texto.Name = "lbl_Texto";
            this.lbl_Texto.Size = new System.Drawing.Size(53, 16);
            this.lbl_Texto.TabIndex = 0;
            this.lbl_Texto.Text = "LABEL";
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Location = new System.Drawing.Point(166, 187);
            this.lbl_Valor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(0, 16);
            this.lbl_Valor.TabIndex = 1;
            // 
            // trackBar_Tamaño
            // 
            this.trackBar_Tamaño.Location = new System.Drawing.Point(245, 126);
            this.trackBar_Tamaño.Name = "trackBar_Tamaño";
            this.trackBar_Tamaño.Size = new System.Drawing.Size(117, 45);
            this.trackBar_Tamaño.TabIndex = 2;
            this.trackBar_Tamaño.Scroll += new System.EventHandler(this.trackBar_Tamaño_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.trackBar_Tamaño);
            this.Controls.Add(this.lbl_Valor);
            this.Controls.Add(this.lbl_Texto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Tamaño de Fuente";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Tamaño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Texto;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.TrackBar trackBar_Tamaño;
    }
}

