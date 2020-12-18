namespace ProyectoFinal.AlgoritmosdeOdenamiento
{
    partial class BurbujaBidireccional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BurbujaBidireccional));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lbNum = new System.Windows.Forms.ListBox();
            this.lbOrd = new System.Windows.Forms.ListBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.gbTiempo = new System.Windows.Forms.GroupBox();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.lblOrd = new System.Windows.Forms.Label();
            this.lblComparaciones = new System.Windows.Forms.Label();
            this.lblIntercambios = new System.Windows.Forms.Label();
            this.lblCom = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.algoritmosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbTiempo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Snow;
            this.lblTitulo.Font = new System.Drawing.Font("Elephant", 22.2F);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitulo.Location = new System.Drawing.Point(57, 72);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(785, 49);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ordenamiento de Burbuja Bidireccional";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.BackColor = System.Drawing.Color.Snow;
            this.lblNum.Font = new System.Drawing.Font("Britannic Bold", 13.8F);
            this.lblNum.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNum.Location = new System.Drawing.Point(62, 161);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(113, 27);
            this.lblNum.TabIndex = 1;
            this.lblNum.Text = "Numeros:";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.Color.Snow;
            this.lblMin.Font = new System.Drawing.Font("Britannic Bold", 13.8F);
            this.lblMin.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMin.Location = new System.Drawing.Point(62, 207);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(171, 27);
            this.lblMin.TabIndex = 2;
            this.lblMin.Text = "Limite Minimo:";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.BackColor = System.Drawing.Color.Snow;
            this.lblMax.Font = new System.Drawing.Font("Britannic Bold", 13.8F);
            this.lblMax.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMax.Location = new System.Drawing.Point(62, 254);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(174, 27);
            this.lblMax.TabIndex = 3;
            this.lblMax.Text = "Limite Maximo:";
            // 
            // lbNum
            // 
            this.lbNum.FormattingEnabled = true;
            this.lbNum.ItemHeight = 16;
            this.lbNum.Location = new System.Drawing.Point(487, 161);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(110, 340);
            this.lbNum.TabIndex = 4;
            // 
            // lbOrd
            // 
            this.lbOrd.FormattingEnabled = true;
            this.lbOrd.ItemHeight = 16;
            this.lbOrd.Location = new System.Drawing.Point(647, 161);
            this.lbOrd.Name = "lbOrd";
            this.lbOrd.Size = new System.Drawing.Size(110, 340);
            this.lbOrd.TabIndex = 5;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(197, 166);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(181, 22);
            this.txtNum.TabIndex = 6;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(262, 259);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(116, 22);
            this.txtMax.TabIndex = 7;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(262, 212);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(116, 22);
            this.txtMin.TabIndex = 8;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Snow;
            this.btnGenerar.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGenerar.Location = new System.Drawing.Point(66, 316);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(136, 53);
            this.btnGenerar.TabIndex = 9;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.Snow;
            this.btnOrdenar.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnOrdenar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnOrdenar.Location = new System.Drawing.Point(242, 316);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(136, 53);
            this.btnOrdenar.TabIndex = 10;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // gbTiempo
            // 
            this.gbTiempo.BackColor = System.Drawing.Color.Snow;
            this.gbTiempo.Controls.Add(this.lblOrdenar);
            this.gbTiempo.Controls.Add(this.lblOrd);
            this.gbTiempo.Controls.Add(this.lblComparaciones);
            this.gbTiempo.Controls.Add(this.lblIntercambios);
            this.gbTiempo.Controls.Add(this.lblCom);
            this.gbTiempo.Controls.Add(this.lblInt);
            this.gbTiempo.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.gbTiempo.ForeColor = System.Drawing.Color.DarkRed;
            this.gbTiempo.Location = new System.Drawing.Point(23, 401);
            this.gbTiempo.Name = "gbTiempo";
            this.gbTiempo.Size = new System.Drawing.Size(406, 143);
            this.gbTiempo.TabIndex = 11;
            this.gbTiempo.TabStop = false;
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.lblOrdenar.Location = new System.Drawing.Point(129, 110);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(40, 22);
            this.lblOrdenar.TabIndex = 5;
            this.lblOrdenar.Text = "0:0";
            // 
            // lblOrd
            // 
            this.lblOrd.AutoSize = true;
            this.lblOrd.Location = new System.Drawing.Point(18, 110);
            this.lblOrd.Name = "lblOrd";
            this.lblOrd.Size = new System.Drawing.Size(90, 22);
            this.lblOrd.TabIndex = 4;
            this.lblOrd.Text = "Ordenar:";
            // 
            // lblComparaciones
            // 
            this.lblComparaciones.AutoSize = true;
            this.lblComparaciones.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.lblComparaciones.Location = new System.Drawing.Point(188, 64);
            this.lblComparaciones.Name = "lblComparaciones";
            this.lblComparaciones.Size = new System.Drawing.Size(22, 22);
            this.lblComparaciones.TabIndex = 3;
            this.lblComparaciones.Text = "0";
            // 
            // lblIntercambios
            // 
            this.lblIntercambios.AutoSize = true;
            this.lblIntercambios.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.lblIntercambios.Location = new System.Drawing.Point(161, 18);
            this.lblIntercambios.Name = "lblIntercambios";
            this.lblIntercambios.Size = new System.Drawing.Size(22, 22);
            this.lblIntercambios.TabIndex = 2;
            this.lblIntercambios.Text = "0";
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Location = new System.Drawing.Point(14, 64);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(155, 22);
            this.lblCom.TabIndex = 1;
            this.lblCom.Text = "Comparaciones:";
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Location = new System.Drawing.Point(14, 18);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(133, 22);
            this.lblInt.TabIndex = 0;
            this.lblInt.Text = "Intercambios:";
            // 
            // algoritmosToolStripMenuItem
            // 
            this.algoritmosToolStripMenuItem.Name = "algoritmosToolStripMenuItem";
            this.algoritmosToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.algoritmosToolStripMenuItem.Text = "Algoritmos";
            this.algoritmosToolStripMenuItem.Click += new System.EventHandler(this.algoritmosToolStripMenuItem_Click);
            // 
            // estructurasToolStripMenuItem
            // 
            this.estructurasToolStripMenuItem.Name = "estructurasToolStripMenuItem";
            this.estructurasToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.estructurasToolStripMenuItem.Text = "Estructuras";
            this.estructurasToolStripMenuItem.Click += new System.EventHandler(this.estructurasToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Snow;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmosToolStripMenuItem,
            this.estructurasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // BurbujaBidireccional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(921, 578);
            this.ControlBox = false;
            this.Controls.Add(this.gbTiempo);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lbOrd);
            this.Controls.Add(this.lbNum);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BurbujaBidireccional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Burbuja Bidireccional";
            this.gbTiempo.ResumeLayout(false);
            this.gbTiempo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.ListBox lbNum;
        private System.Windows.Forms.ListBox lbOrd;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.GroupBox gbTiempo;
        private System.Windows.Forms.Label lblOrdenar;
        private System.Windows.Forms.Label lblOrd;
        private System.Windows.Forms.Label lblComparaciones;
        private System.Windows.Forms.Label lblIntercambios;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.ToolStripMenuItem algoritmosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructurasToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}