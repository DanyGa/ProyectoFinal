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
            this.lEs = new System.Windows.Forms.Label();
            this.btnListas = new System.Windows.Forms.Button();
            this.btnGrafo = new System.Windows.Forms.Button();
            this.btnPila = new System.Windows.Forms.Button();
            this.btnArbol = new System.Windows.Forms.Button();
            this.btnCola = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lEs
            // 
            this.lEs.AutoSize = true;
            this.lEs.BackColor = System.Drawing.Color.Transparent;
            this.lEs.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEs.ForeColor = System.Drawing.Color.Snow;
            this.lEs.Location = new System.Drawing.Point(54, 44);
            this.lEs.Name = "lEs";
            this.lEs.Size = new System.Drawing.Size(505, 55);
            this.lEs.TabIndex = 0;
            this.lEs.Text = "Estructuras de Datos";
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(141, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecciona un tipo de Estructura";
            // 
            // MenuEstructuras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(634, 391);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCola);
            this.Controls.Add(this.btnArbol);
            this.Controls.Add(this.btnPila);
            this.Controls.Add(this.btnGrafo);
            this.Controls.Add(this.btnListas);
            this.Controls.Add(this.lEs);
            this.Name = "MenuEstructuras";
            this.Text = "Estructuras de Datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lEs;
        private System.Windows.Forms.Button btnListas;
        private System.Windows.Forms.Button btnGrafo;
        private System.Windows.Forms.Button btnPila;
        private System.Windows.Forms.Button btnArbol;
        private System.Windows.Forms.Button btnCola;
        private System.Windows.Forms.Label label1;
    }
}