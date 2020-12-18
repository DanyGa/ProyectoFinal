namespace ProyectoFinal
{
    partial class MenuEstructuras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEstructuras));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnListas = new System.Windows.Forms.Button();
            this.btnGrafo = new System.Windows.Forms.Button();
            this.btnPila = new System.Windows.Forms.Button();
            this.btnArbol = new System.Windows.Forms.Button();
            this.btnCola = new System.Windows.Forms.Button();
            this.lblInst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Snow;
            this.lblTitulo.Location = new System.Drawing.Point(54, 44);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(505, 55);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Estructuras de Datos";
            // 
            // btnListas
            // 
            this.btnListas.BackColor = System.Drawing.Color.Snow;
            this.btnListas.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListas.ForeColor = System.Drawing.Color.Olive;
            this.btnListas.Location = new System.Drawing.Point(64, 164);
            this.btnListas.Name = "btnListas";
            this.btnListas.Size = new System.Drawing.Size(137, 70);
            this.btnListas.TabIndex = 1;
            this.btnListas.Text = "Listas";
            this.btnListas.UseVisualStyleBackColor = false;
            this.btnListas.Click += new System.EventHandler(this.btnListas_Click);
            // 
            // btnGrafo
            // 
            this.btnGrafo.BackColor = System.Drawing.Color.Snow;
            this.btnGrafo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafo.ForeColor = System.Drawing.Color.Olive;
            this.btnGrafo.Location = new System.Drawing.Point(146, 280);
            this.btnGrafo.Name = "btnGrafo";
            this.btnGrafo.Size = new System.Drawing.Size(137, 70);
            this.btnGrafo.TabIndex = 2;
            this.btnGrafo.Text = "Grafo";
            this.btnGrafo.UseVisualStyleBackColor = false;
            this.btnGrafo.Click += new System.EventHandler(this.btnGrafo_Click);
            // 
            // btnPila
            // 
            this.btnPila.BackColor = System.Drawing.Color.Snow;
            this.btnPila.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPila.ForeColor = System.Drawing.Color.Olive;
            this.btnPila.Location = new System.Drawing.Point(244, 164);
            this.btnPila.Name = "btnPila";
            this.btnPila.Size = new System.Drawing.Size(137, 70);
            this.btnPila.TabIndex = 3;
            this.btnPila.Text = "Pila";
            this.btnPila.UseVisualStyleBackColor = false;
            this.btnPila.Click += new System.EventHandler(this.btnPila_Click);
            // 
            // btnArbol
            // 
            this.btnArbol.BackColor = System.Drawing.Color.Snow;
            this.btnArbol.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArbol.ForeColor = System.Drawing.Color.Olive;
            this.btnArbol.Location = new System.Drawing.Point(330, 280);
            this.btnArbol.Name = "btnArbol";
            this.btnArbol.Size = new System.Drawing.Size(137, 70);
            this.btnArbol.TabIndex = 4;
            this.btnArbol.Text = "Arbol";
            this.btnArbol.UseVisualStyleBackColor = false;
            this.btnArbol.Click += new System.EventHandler(this.btnArbol_Click);
            // 
            // btnCola
            // 
            this.btnCola.BackColor = System.Drawing.Color.Snow;
            this.btnCola.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCola.ForeColor = System.Drawing.Color.Olive;
            this.btnCola.Location = new System.Drawing.Point(422, 164);
            this.btnCola.Name = "btnCola";
            this.btnCola.Size = new System.Drawing.Size(137, 70);
            this.btnCola.TabIndex = 5;
            this.btnCola.Text = "Cola";
            this.btnCola.UseVisualStyleBackColor = false;
            this.btnCola.Click += new System.EventHandler(this.btnCola_Click);
            // 
            // lblInst
            // 
            this.lblInst.AutoSize = true;
            this.lblInst.BackColor = System.Drawing.Color.Transparent;
            this.lblInst.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInst.ForeColor = System.Drawing.Color.Olive;
            this.lblInst.Location = new System.Drawing.Point(141, 99);
            this.lblInst.Name = "lblInst";
            this.lblInst.Size = new System.Drawing.Size(366, 25);
            this.lblInst.TabIndex = 6;
            this.lblInst.Text = "Selecciona un tipo de Estructura";
            // 
            // MenuEstructuras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(634, 391);
            this.Controls.Add(this.lblInst);
            this.Controls.Add(this.btnCola);
            this.Controls.Add(this.btnArbol);
            this.Controls.Add(this.btnPila);
            this.Controls.Add(this.btnGrafo);
            this.Controls.Add(this.btnListas);
            this.Controls.Add(this.lblTitulo);
            this.Name = "MenuEstructuras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructuras de Datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnListas;
        private System.Windows.Forms.Button btnGrafo;
        private System.Windows.Forms.Button btnPila;
        private System.Windows.Forms.Button btnArbol;
        private System.Windows.Forms.Button btnCola;
        private System.Windows.Forms.Label lblInst;
    }
}