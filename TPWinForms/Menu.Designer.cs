
namespace TPWinForms
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnAgregarArticulos = new System.Windows.Forms.Button();
            this.btnDetalleArticulos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(218, 49);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(206, 17);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Sistema de gestion de Articulos";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(244, 122);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(147, 63);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar Articulos";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnAgregarArticulos
            // 
            this.btnAgregarArticulos.Location = new System.Drawing.Point(244, 230);
            this.btnAgregarArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarArticulos.Name = "btnAgregarArticulos";
            this.btnAgregarArticulos.Size = new System.Drawing.Size(147, 61);
            this.btnAgregarArticulos.TabIndex = 3;
            this.btnAgregarArticulos.Text = "Agregar Articulos";
            this.btnAgregarArticulos.UseVisualStyleBackColor = true;
            this.btnAgregarArticulos.Click += new System.EventHandler(this.btnAgregarArticulos_Click);
            // 
            // btnDetalleArticulos
            // 
            this.btnDetalleArticulos.Location = new System.Drawing.Point(244, 338);
            this.btnDetalleArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetalleArticulos.Name = "btnDetalleArticulos";
            this.btnDetalleArticulos.Size = new System.Drawing.Size(147, 63);
            this.btnDetalleArticulos.TabIndex = 6;
            this.btnDetalleArticulos.Text = "Detalle Articulos";
            this.btnDetalleArticulos.UseVisualStyleBackColor = true;
            this.btnDetalleArticulos.Click += new System.EventHandler(this.btnDetalleArticulos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnDetalleArticulos);
            this.Controls.Add(this.btnAgregarArticulos);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAgregarArticulos;
        private System.Windows.Forms.Button btnDetalleArticulos;
    }
}

