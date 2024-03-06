namespace Ejemplo_MessageBox
{
    partial class frmMessageBox
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
            this.btnAnularReintentarOmitir = new System.Windows.Forms.Button();
            this.btnReintentarCancelar = new System.Windows.Forms.Button();
            this.btnSiNoCancelar = new System.Windows.Forms.Button();
            this.btnSiNo = new System.Windows.Forms.Button();
            this.btnAceptarCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cantidad y tipo de botones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnularReintentarOmitir
            // 
            this.btnAnularReintentarOmitir.Location = new System.Drawing.Point(12, 193);
            this.btnAnularReintentarOmitir.Name = "btnAnularReintentarOmitir";
            this.btnAnularReintentarOmitir.Size = new System.Drawing.Size(231, 23);
            this.btnAnularReintentarOmitir.TabIndex = 13;
            this.btnAnularReintentarOmitir.Text = "ANULAR / REINTENTAR / OMITIR";
            this.btnAnularReintentarOmitir.UseVisualStyleBackColor = true;
            this.btnAnularReintentarOmitir.Click += new System.EventHandler(this.btnAnularReintentarOmitir_Click);
            // 
            // btnReintentarCancelar
            // 
            this.btnReintentarCancelar.Location = new System.Drawing.Point(12, 164);
            this.btnReintentarCancelar.Name = "btnReintentarCancelar";
            this.btnReintentarCancelar.Size = new System.Drawing.Size(231, 23);
            this.btnReintentarCancelar.TabIndex = 12;
            this.btnReintentarCancelar.Text = "REINTENTAR / CANCELAR";
            this.btnReintentarCancelar.UseVisualStyleBackColor = true;
            this.btnReintentarCancelar.Click += new System.EventHandler(this.btnReintentarCancelar_Click);
            // 
            // btnSiNoCancelar
            // 
            this.btnSiNoCancelar.Location = new System.Drawing.Point(12, 135);
            this.btnSiNoCancelar.Name = "btnSiNoCancelar";
            this.btnSiNoCancelar.Size = new System.Drawing.Size(231, 23);
            this.btnSiNoCancelar.TabIndex = 11;
            this.btnSiNoCancelar.Text = "SI / NO / CANCELAR";
            this.btnSiNoCancelar.UseVisualStyleBackColor = true;
            this.btnSiNoCancelar.Click += new System.EventHandler(this.btnSiNoCancelar_Click);
            // 
            // btnSiNo
            // 
            this.btnSiNo.Location = new System.Drawing.Point(12, 106);
            this.btnSiNo.Name = "btnSiNo";
            this.btnSiNo.Size = new System.Drawing.Size(231, 23);
            this.btnSiNo.TabIndex = 10;
            this.btnSiNo.Text = "SI / NO";
            this.btnSiNo.UseVisualStyleBackColor = true;
            this.btnSiNo.Click += new System.EventHandler(this.btnSiNo_Click);
            // 
            // btnAceptarCancelar
            // 
            this.btnAceptarCancelar.Location = new System.Drawing.Point(12, 77);
            this.btnAceptarCancelar.Name = "btnAceptarCancelar";
            this.btnAceptarCancelar.Size = new System.Drawing.Size(231, 23);
            this.btnAceptarCancelar.TabIndex = 9;
            this.btnAceptarCancelar.Text = "ACEPTAR / CANCELAR";
            this.btnAceptarCancelar.UseVisualStyleBackColor = true;
            this.btnAceptarCancelar.Click += new System.EventHandler(this.btnAceptarCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(12, 48);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(231, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 228);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnularReintentarOmitir);
            this.Controls.Add(this.btnReintentarCancelar);
            this.Controls.Add(this.btnSiNoCancelar);
            this.Controls.Add(this.btnSiNo);
            this.Controls.Add(this.btnAceptarCancelar);
            this.Controls.Add(this.btnAceptar);
            this.MaximizeBox = false;
            this.Name = "frmMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMessageBox_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnularReintentarOmitir;
        private System.Windows.Forms.Button btnReintentarCancelar;
        private System.Windows.Forms.Button btnSiNoCancelar;
        private System.Windows.Forms.Button btnSiNo;
        private System.Windows.Forms.Button btnAceptarCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}

