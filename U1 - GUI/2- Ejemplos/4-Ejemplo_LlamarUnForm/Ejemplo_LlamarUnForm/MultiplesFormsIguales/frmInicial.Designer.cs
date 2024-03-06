namespace MultiplesFormsIguales
{
    partial class FrmInicial
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
            this.btnLocalidades = new System.Windows.Forms.Button();
            this.btnPartidos = new System.Windows.Forms.Button();
            this.btnProvincias = new System.Windows.Forms.Button();
            this.btnVacio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLocalidades
            // 
            this.btnLocalidades.Location = new System.Drawing.Point(102, 66);
            this.btnLocalidades.Name = "btnLocalidades";
            this.btnLocalidades.Size = new System.Drawing.Size(75, 23);
            this.btnLocalidades.TabIndex = 0;
            this.btnLocalidades.Text = "Localidades";
            this.btnLocalidades.UseVisualStyleBackColor = true;
            this.btnLocalidades.Click += new System.EventHandler(this.btnLocalidades_Click);
            // 
            // btnPartidos
            // 
            this.btnPartidos.Location = new System.Drawing.Point(102, 37);
            this.btnPartidos.Name = "btnPartidos";
            this.btnPartidos.Size = new System.Drawing.Size(75, 23);
            this.btnPartidos.TabIndex = 1;
            this.btnPartidos.Text = "Partidos";
            this.btnPartidos.UseVisualStyleBackColor = true;
            this.btnPartidos.Click += new System.EventHandler(this.btnPartidos_Click);
            // 
            // btnProvincias
            // 
            this.btnProvincias.Location = new System.Drawing.Point(102, 95);
            this.btnProvincias.Name = "btnProvincias";
            this.btnProvincias.Size = new System.Drawing.Size(75, 23);
            this.btnProvincias.TabIndex = 2;
            this.btnProvincias.Text = "Provincias";
            this.btnProvincias.UseVisualStyleBackColor = true;
            this.btnProvincias.Click += new System.EventHandler(this.btnProvincias_Click);
            // 
            // btnVacio
            // 
            this.btnVacio.Location = new System.Drawing.Point(102, 124);
            this.btnVacio.Name = "btnVacio";
            this.btnVacio.Size = new System.Drawing.Size(75, 23);
            this.btnVacio.TabIndex = 3;
            this.btnVacio.Text = "Vacio";
            this.btnVacio.UseVisualStyleBackColor = true;
            this.btnVacio.Click += new System.EventHandler(this.btnVacio_Click);
            // 
            // FrmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 181);
            this.Controls.Add(this.btnVacio);
            this.Controls.Add(this.btnProvincias);
            this.Controls.Add(this.btnPartidos);
            this.Controls.Add(this.btnLocalidades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Llamar Formularios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLocalidades;
        private System.Windows.Forms.Button btnPartidos;
        private System.Windows.Forms.Button btnProvincias;
        private System.Windows.Forms.Button btnVacio;
    }
}

