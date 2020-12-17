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
            this.lAl = new System.Windows.Forms.Label();
            this.btnBurbuja = new System.Windows.Forms.Button();
            this.btnBurbujaB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lAl
            // 
            this.lAl.AutoSize = true;
            this.lAl.BackColor = System.Drawing.Color.Transparent;
            this.lAl.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAl.ForeColor = System.Drawing.Color.Crimson;
            this.lAl.Location = new System.Drawing.Point(38, 19);
            this.lAl.Name = "lAl";
            this.lAl.Size = new System.Drawing.Size(644, 55);
            this.lAl.TabIndex = 0;
            this.lAl.Text = "Algoritmos de Ordenamiento";
            // 
            // btnBurbuja
            // 
            this.btnBurbuja.BackColor = System.Drawing.Color.Snow;
            this.btnBurbuja.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurbuja.ForeColor = System.Drawing.Color.Crimson;
            this.btnBurbuja.Location = new System.Drawing.Point(48, 177);
            this.btnBurbuja.Name = "btnBurbuja";
            this.btnBurbuja.Size = new System.Drawing.Size(150, 67);
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
            this.btnBurbujaB.Size = new System.Drawing.Size(150, 67);
            this.btnBurbujaB.TabIndex = 2;
            this.btnBurbujaB.Text = "Burbuja Bidireccional";
            this.btnBurbujaB.UseVisualStyleBackColor = false;
            this.btnBurbujaB.Click += new System.EventHandler(this.btnBurbujaB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(43, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecciona un tipo de Algoritmo de Ordenamiento";
            // 
            // MenuAlgoritmos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(729, 485);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBurbujaB);
            this.Controls.Add(this.btnBurbuja);
            this.Controls.Add(this.lAl);
            this.Name = "MenuAlgoritmos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algoritmos de Ordenamiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAl;
        private System.Windows.Forms.Button btnBurbuja;
        private System.Windows.Forms.Button btnBurbujaB;
        private System.Windows.Forms.Label label1;
    }
}