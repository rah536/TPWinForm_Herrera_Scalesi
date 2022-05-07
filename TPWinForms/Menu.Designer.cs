
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnAgregarArticulos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(49, 36);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(467, 42);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Sistema de gestion de Articulos";
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(212, 164);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(110, 51);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar Articulos";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnAgregarArticulos
            // 
            this.btnAgregarArticulos.BackColor = System.Drawing.Color.Coral;
            this.btnAgregarArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarArticulos.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArticulos.Location = new System.Drawing.Point(212, 272);
            this.btnAgregarArticulos.Name = "btnAgregarArticulos";
            this.btnAgregarArticulos.Size = new System.Drawing.Size(110, 50);
            this.btnAgregarArticulos.TabIndex = 3;
            this.btnAgregarArticulos.Text = "Agregar Articulos";
            this.btnAgregarArticulos.UseVisualStyleBackColor = false;
            this.btnAgregarArticulos.Click += new System.EventHandler(this.btnAgregarArticulos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.btnAgregarArticulos);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblMenu);
            this.Name = "Form1";
            this.Text = "Sistema de gestion de Articulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAgregarArticulos;
    }
}

