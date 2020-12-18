namespace ProyectoFinal.AlgoritmosdeOdenamiento
{
    partial class Cuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cuentas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnCrearArreglo = new System.Windows.Forms.Button();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblRan = new System.Windows.Forms.Label();
            this.lblTam = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblInvertido = new System.Windows.Forms.Label();
            this.lblOrdenado = new System.Windows.Forms.Label();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.lblEla = new System.Windows.Forms.Label();
            this.lblInv = new System.Windows.Forms.Label();
            this.lblOrd = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.algoritmosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnAleatorio);
            this.groupBox1.Controls.Add(this.txtMax);
            this.groupBox1.Controls.Add(this.btnCrearArreglo);
            this.groupBox1.Controls.Add(this.txtMin);
            this.groupBox1.Controls.Add(this.txtTamaño);
            this.groupBox1.Controls.Add(this.lblMax);
            this.groupBox1.Controls.Add(this.lblMin);
            this.groupBox1.Controls.Add(this.lblRan);
            this.groupBox1.Controls.Add(this.lblTam);
            this.groupBox1.Location = new System.Drawing.Point(26, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.BackColor = System.Drawing.Color.Snow;
            this.btnAleatorio.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAleatorio.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAleatorio.Location = new System.Drawing.Point(467, 78);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(135, 48);
            this.btnAleatorio.TabIndex = 8;
            this.btnAleatorio.Text = "Aleatorio";
            this.btnAleatorio.UseVisualStyleBackColor = false;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(383, 51);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(49, 22);
            this.txtMax.TabIndex = 6;
            // 
            // btnCrearArreglo
            // 
            this.btnCrearArreglo.BackColor = System.Drawing.Color.Snow;
            this.btnCrearArreglo.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCrearArreglo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCrearArreglo.Location = new System.Drawing.Point(467, 21);
            this.btnCrearArreglo.Name = "btnCrearArreglo";
            this.btnCrearArreglo.Size = new System.Drawing.Size(135, 48);
            this.btnCrearArreglo.TabIndex = 7;
            this.btnCrearArreglo.Text = "Crear";
            this.btnCrearArreglo.UseVisualStyleBackColor = false;
            this.btnCrearArreglo.Click += new System.EventHandler(this.btnCrearArreglo_Click);
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(306, 51);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(49, 22);
            this.txtMin.TabIndex = 5;
            // 
            // txtTamaño
            // 
            this.txtTamaño.Location = new System.Drawing.Point(212, 51);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(49, 22);
            this.txtTamaño.TabIndex = 4;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.BackColor = System.Drawing.Color.Snow;
            this.lblMax.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMax.Location = new System.Drawing.Point(389, 90);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(38, 19);
            this.lblMax.TabIndex = 3;
            this.lblMax.Text = "Max";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.Color.Snow;
            this.lblMin.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMin.Location = new System.Drawing.Point(314, 90);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(36, 19);
            this.lblMin.TabIndex = 2;
            this.lblMin.Text = "Min";
            // 
            // lblRan
            // 
            this.lblRan.AutoSize = true;
            this.lblRan.BackColor = System.Drawing.Color.Snow;
            this.lblRan.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRan.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblRan.Location = new System.Drawing.Point(343, 18);
            this.lblRan.Name = "lblRan";
            this.lblRan.Size = new System.Drawing.Size(57, 19);
            this.lblRan.TabIndex = 1;
            this.lblRan.Text = "Rango";
            // 
            // lblTam
            // 
            this.lblTam.AutoSize = true;
            this.lblTam.BackColor = System.Drawing.Color.Snow;
            this.lblTam.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.lblTam.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblTam.Location = new System.Drawing.Point(6, 51);
            this.lblTam.Name = "lblTam";
            this.lblTam.Size = new System.Drawing.Size(190, 22);
            this.lblTam.TabIndex = 0;
            this.lblTam.Text = "Tamaño del arreglo:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblTiempo);
            this.groupBox2.Controls.Add(this.lblInvertido);
            this.groupBox2.Controls.Add(this.lblOrdenado);
            this.groupBox2.Controls.Add(this.lblOriginal);
            this.groupBox2.Controls.Add(this.lblEla);
            this.groupBox2.Controls.Add(this.lblInv);
            this.groupBox2.Controls.Add(this.lblOrd);
            this.groupBox2.Controls.Add(this.lblDes);
            this.groupBox2.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(608, 220);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.BackColor = System.Drawing.Color.Snow;
            this.lblTiempo.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblTiempo.Location = new System.Drawing.Point(199, 177);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(35, 22);
            this.lblTiempo.TabIndex = 11;
            this.lblTiempo.Text = "-----";
            // 
            // lblInvertido
            // 
            this.lblInvertido.AutoSize = true;
            this.lblInvertido.BackColor = System.Drawing.Color.Snow;
            this.lblInvertido.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvertido.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblInvertido.Location = new System.Drawing.Point(199, 129);
            this.lblInvertido.Name = "lblInvertido";
            this.lblInvertido.Size = new System.Drawing.Size(35, 22);
            this.lblInvertido.TabIndex = 10;
            this.lblInvertido.Text = "-----";
            // 
            // lblOrdenado
            // 
            this.lblOrdenado.AutoSize = true;
            this.lblOrdenado.BackColor = System.Drawing.Color.Snow;
            this.lblOrdenado.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenado.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblOrdenado.Location = new System.Drawing.Point(208, 80);
            this.lblOrdenado.Name = "lblOrdenado";
            this.lblOrdenado.Size = new System.Drawing.Size(35, 22);
            this.lblOrdenado.TabIndex = 9;
            this.lblOrdenado.Text = "-----";
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.BackColor = System.Drawing.Color.Snow;
            this.lblOriginal.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginal.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblOriginal.Location = new System.Drawing.Point(243, 38);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(35, 22);
            this.lblOriginal.TabIndex = 8;
            this.lblOriginal.Text = "-----";
            // 
            // lblEla
            // 
            this.lblEla.AutoSize = true;
            this.lblEla.BackColor = System.Drawing.Color.Snow;
            this.lblEla.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEla.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblEla.Location = new System.Drawing.Point(17, 177);
            this.lblEla.Name = "lblEla";
            this.lblEla.Size = new System.Drawing.Size(166, 22);
            this.lblEla.TabIndex = 7;
            this.lblEla.Text = "TIempo elapsado:";
            // 
            // lblInv
            // 
            this.lblInv.AutoSize = true;
            this.lblInv.BackColor = System.Drawing.Color.Snow;
            this.lblInv.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInv.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblInv.Location = new System.Drawing.Point(17, 129);
            this.lblInv.Name = "lblInv";
            this.lblInv.Size = new System.Drawing.Size(167, 22);
            this.lblInv.TabIndex = 6;
            this.lblInv.Text = "Arreglo invertido:";
            // 
            // lblOrd
            // 
            this.lblOrd.AutoSize = true;
            this.lblOrd.BackColor = System.Drawing.Color.Snow;
            this.lblOrd.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrd.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblOrd.Location = new System.Drawing.Point(17, 80);
            this.lblOrd.Name = "lblOrd";
            this.lblOrd.Size = new System.Drawing.Size(173, 22);
            this.lblOrd.TabIndex = 5;
            this.lblOrd.Text = "Arreglo ordenado:";
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.BackColor = System.Drawing.Color.Snow;
            this.lblDes.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblDes.Location = new System.Drawing.Point(17, 38);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(204, 22);
            this.lblDes.TabIndex = 4;
            this.lblDes.Text = "Arreglo desordenado:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Snow;
            this.lblTitulo.Font = new System.Drawing.Font("Elephant", 22.2F);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblTitulo.Location = new System.Drawing.Point(65, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(535, 49);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Ordenamiento por Cuentas";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmosToolStripMenuItem,
            this.estructurasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(690, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // algoritmosToolStripMenuItem
            // 
            this.algoritmosToolStripMenuItem.Name = "algoritmosToolStripMenuItem";
            this.algoritmosToolStripMenuItem.Size = new System.Drawing.Size(98, 26);
            this.algoritmosToolStripMenuItem.Text = "Algoritmos";
            this.algoritmosToolStripMenuItem.Click += new System.EventHandler(this.algoritmosToolStripMenuItem_Click);
            // 
            // estructurasToolStripMenuItem
            // 
            this.estructurasToolStripMenuItem.Name = "estructurasToolStripMenuItem";
            this.estructurasToolStripMenuItem.Size = new System.Drawing.Size(98, 26);
            this.estructurasToolStripMenuItem.Text = "Estructuras";
            this.estructurasToolStripMenuItem.Click += new System.EventHandler(this.estructurasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Cuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(690, 487);
            this.ControlBox = false;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Cuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAleatorio;
        private System.Windows.Forms.Button btnCrearArreglo;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblRan;
        private System.Windows.Forms.Label lblTam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblInvertido;
        private System.Windows.Forms.Label lblOrdenado;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.Label lblEla;
        private System.Windows.Forms.Label lblInv;
        private System.Windows.Forms.Label lblOrd;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algoritmosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructurasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lblTiempo;
    }
}