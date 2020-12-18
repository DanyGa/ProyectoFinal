namespace ProyectoFinal
{
    partial class MenuAlgoritmos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAlgoritmos));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnBurbuja = new System.Windows.Forms.Button();
            this.btnBurbujaB = new System.Windows.Forms.Button();
            this.lblIndi = new System.Windows.Forms.Label();
            this.btnCuentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Snow;
            this.lblTitulo.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Crimson;
            this.lblTitulo.Location = new System.Drawing.Point(38, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(644, 55);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Algoritmos de Ordenamiento";
            // 
            // btnBurbuja
            // 
            this.btnBurbuja.BackColor = System.Drawing.Color.Snow;
            this.btnBurbuja.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurbuja.ForeColor = System.Drawing.Color.Crimson;
            this.btnBurbuja.Location = new System.Drawing.Point(48, 177);
            this.btnBurbuja.Name = "btnBurbuja";
            this.btnBurbuja.Size = new System.Drawing.Size(167, 67);
            this.btnBurbuja.TabIndex = 1;
            this.btnBurbuja.Text = "Burbuja";
            this.btnBurbuja.UseVisualStyleBackColor = false;
            this.btnBurbuja.Click += new System.EventHandler(this.btnBurbuja_Click);
            // 
            // btnBurbujaB
            // 
            this.btnBurbujaB.BackColor = System.Drawing.Color.Snow;
            this.btnBurbujaB.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurbujaB.ForeColor = System.Drawing.Color.Crimson;
            this.btnBurbujaB.Location = new System.Drawing.Point(48, 265);
            this.btnBurbujaB.Name = "btnBurbujaB";
            this.btnBurbujaB.Size = new System.Drawing.Size(167, 67);
            this.btnBurbujaB.TabIndex = 2;
            this.btnBurbujaB.Text = "Burbuja Bidireccional";
            this.btnBurbujaB.UseVisualStyleBackColor = false;
            this.btnBurbujaB.Click += new System.EventHandler(this.btnBurbujaB_Click);
            // 
            // lblIndi
            // 
            this.lblIndi.AutoSize = true;
            this.lblIndi.BackColor = System.Drawing.Color.Snow;
            this.lblIndi.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndi.ForeColor = System.Drawing.Color.Crimson;
            this.lblIndi.Location = new System.Drawing.Point(37, 74);
            this.lblIndi.Name = "lblIndi";
            this.lblIndi.Size = new System.Drawing.Size(645, 30);
            this.lblIndi.TabIndex = 3;
            this.lblIndi.Text = " Selecciona un tipo de Algoritmo de Ordenamiento  ";
            // 
            // btnCuentas
            // 
            this.btnCuentas.BackColor = System.Drawing.Color.Snow;
            this.btnCuentas.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnCuentas.ForeColor = System.Drawing.Color.Crimson;
            this.btnCuentas.Location = new System.Drawing.Point(236, 265);
            this.btnCuentas.Name = "btnCuentas";
            this.btnCuentas.Size = new System.Drawing.Size(167, 67);
            this.btnCuentas.TabIndex = 4;
            this.btnCuentas.Text = "Cuentas";
            this.btnCuentas.UseVisualStyleBackColor = false;
            this.btnCuentas.Click += new System.EventHandler(this.btnCuentas_Click);
            // 
            // MenuAlgoritmos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 485);
            this.Controls.Add(this.btnCuentas);
            this.Controls.Add(this.lblIndi);
            this.Controls.Add(this.btnBurbujaB);
            this.Controls.Add(this.btnBurbuja);
            this.Controls.Add(this.lblTitulo);
            this.Name = "MenuAlgoritmos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algoritmos de Ordenamiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnBurbuja;
        private System.Windows.Forms.Button btnBurbujaB;
        private System.Windows.Forms.Label lblIndi;
        private System.Windows.Forms.Button btnCuentas;
    }
}