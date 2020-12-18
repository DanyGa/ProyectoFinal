namespace ProyectoFinal.AlgoritmosdeOdenamiento
{
    partial class Burbuja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Burbuja));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.algoritmosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructuraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtMay = new System.Windows.Forms.TextBox();
            this.txtMen = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnEliminarL = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblOrdenado = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmosToolStripMenuItem,
            this.estructuraToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // algoritmosToolStripMenuItem
            // 
            this.algoritmosToolStripMenuItem.Name = "algoritmosToolStripMenuItem";
            this.algoritmosToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.algoritmosToolStripMenuItem.Text = "Algoritmos";
            this.algoritmosToolStripMenuItem.Click += new System.EventHandler(this.algoritmosToolStripMenuItem_Click);
            // 
            // estructuraToolStripMenuItem
            // 
            this.estructuraToolStripMenuItem.Name = "estructuraToolStripMenuItem";
            this.estructuraToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.estructuraToolStripMenuItem.Text = "Estructuras";
            this.estructuraToolStripMenuItem.Click += new System.EventHandler(this.estructuraToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ordenamiento de Burbuja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total de Numeros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(35, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rango Mayor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(35, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rango Menor:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(220, 165);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 22);
            this.txtNum.TabIndex = 9;
            // 
            // txtMay
            // 
            this.txtMay.Location = new System.Drawing.Point(185, 211);
            this.txtMay.Name = "txtMay";
            this.txtMay.Size = new System.Drawing.Size(135, 22);
            this.txtMay.TabIndex = 10;
            // 
            // txtMen
            // 
            this.txtMen.Location = new System.Drawing.Point(185, 256);
            this.txtMen.Name = "txtMen";
            this.txtMen.Size = new System.Drawing.Size(135, 22);
            this.txtMen.TabIndex = 11;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.Snow;
            this.btnCrear.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.Brown;
            this.btnCrear.Location = new System.Drawing.Point(39, 316);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(136, 53);
            this.btnCrear.TabIndex = 5;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.Snow;
            this.btnOrdenar.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.ForeColor = System.Drawing.Color.Brown;
            this.btnOrdenar.Location = new System.Drawing.Point(215, 316);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(136, 53);
            this.btnOrdenar.TabIndex = 7;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnEliminarL
            // 
            this.btnEliminarL.BackColor = System.Drawing.Color.Snow;
            this.btnEliminarL.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarL.ForeColor = System.Drawing.Color.Brown;
            this.btnEliminarL.Location = new System.Drawing.Point(378, 316);
            this.btnEliminarL.Name = "btnEliminarL";
            this.btnEliminarL.Size = new System.Drawing.Size(136, 53);
            this.btnEliminarL.TabIndex = 6;
            this.btnEliminarL.Text = "Eliminar Todo";
            this.btnEliminarL.UseVisualStyleBackColor = false;
            this.btnEliminarL.Click += new System.EventHandler(this.btnEliminarL_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label5.Location = new System.Drawing.Point(12, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Numeros:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label6.Location = new System.Drawing.Point(12, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ordenado:";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.BackColor = System.Drawing.Color.Transparent;
            this.lblNum.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.lblNum.Location = new System.Drawing.Point(130, 439);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(30, 22);
            this.lblNum.TabIndex = 14;
            this.lblNum.Text = "----";
            // 
            // lblOrdenado
            // 
            this.lblOrdenado.AutoSize = true;
            this.lblOrdenado.BackColor = System.Drawing.Color.Transparent;
            this.lblOrdenado.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.lblOrdenado.Location = new System.Drawing.Point(130, 497);
            this.lblOrdenado.Name = "lblOrdenado";
            this.lblOrdenado.Size = new System.Drawing.Size(30, 22);
            this.lblOrdenado.TabIndex = 15;
            this.lblOrdenado.Text = "----";
            // 
            // Burbuja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(583, 579);
            this.Controls.Add(this.lblOrdenado);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMen);
            this.Controls.Add(this.txtMay);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnEliminarL);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Burbuja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Burbuja";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algoritmosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructuraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtMay;
        private System.Windows.Forms.TextBox txtMen;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnEliminarL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblOrdenado;
    }
}