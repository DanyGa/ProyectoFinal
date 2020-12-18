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
            this.lT = new System.Windows.Forms.Label();
            this.lNum = new System.Windows.Forms.Label();
            this.lMin = new System.Windows.Forms.Label();
            this.lMax = new System.Windows.Forms.Label();
            this.lbNum = new System.Windows.Forms.ListBox();
            this.lbOrd = new System.Windows.Forms.ListBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.gbTiempo = new System.Windows.Forms.GroupBox();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.lOrd = new System.Windows.Forms.Label();
            this.lblComparaciones = new System.Windows.Forms.Label();
            this.lblIntercambios = new System.Windows.Forms.Label();
            this.lCom = new System.Windows.Forms.Label();
            this.lInt = new System.Windows.Forms.Label();
            this.algoritmosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbTiempo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lT
            // 
            this.lT.AutoSize = true;
            this.lT.BackColor = System.Drawing.Color.Transparent;
            this.lT.Font = new System.Drawing.Font("Elephant", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lT.ForeColor = System.Drawing.Color.DarkRed;
            this.lT.Location = new System.Drawing.Point(74, 51);
            this.lT.Name = "lT";
            this.lT.Size = new System.Drawing.Size(494, 29);
            this.lT.TabIndex = 0;
            this.lT.Text = "Ordenamiento de Burbuja Bidireccional";
            // 
            // lNum
            // 
            this.lNum.AutoSize = true;
            this.lNum.BackColor = System.Drawing.Color.Transparent;
            this.lNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lNum.Location = new System.Drawing.Point(27, 120);
            this.lNum.Name = "lNum";
            this.lNum.Size = new System.Drawing.Size(82, 18);
            this.lNum.TabIndex = 1;
            this.lNum.Text = "Numeros:";
            // 
            // lMin
            // 
            this.lMin.AutoSize = true;
            this.lMin.BackColor = System.Drawing.Color.Transparent;
            this.lMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lMin.Location = new System.Drawing.Point(27, 166);
            this.lMin.Name = "lMin";
            this.lMin.Size = new System.Drawing.Size(118, 18);
            this.lMin.TabIndex = 2;
            this.lMin.Text = "Limite Minimo:";
            // 
            // lMax
            // 
            this.lMax.AutoSize = true;
            this.lMax.BackColor = System.Drawing.Color.Transparent;
            this.lMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lMax.Location = new System.Drawing.Point(27, 217);
            this.lMax.Name = "lMax";
            this.lMax.Size = new System.Drawing.Size(122, 18);
            this.lMax.TabIndex = 3;
            this.lMax.Text = "Limite Maximo:";
            // 
            // lbNum
            // 
            this.lbNum.FormattingEnabled = true;
            this.lbNum.ItemHeight = 16;
            this.lbNum.Location = new System.Drawing.Point(288, 99);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(110, 180);
            this.lbNum.TabIndex = 4;
            // 
            // lbOrd
            // 
            this.lbOrd.FormattingEnabled = true;
            this.lbOrd.ItemHeight = 16;
            this.lbOrd.Location = new System.Drawing.Point(428, 98);
            this.lbOrd.Name = "lbOrd";
            this.lbOrd.Size = new System.Drawing.Size(120, 180);
            this.lbOrd.TabIndex = 5;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(132, 119);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 22);
            this.txtNum.TabIndex = 6;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(172, 216);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 22);
            this.txtMax.TabIndex = 7;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(168, 165);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 22);
            this.txtMin.TabIndex = 8;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Snow;
            this.btnGenerar.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.Maroon;
            this.btnGenerar.Location = new System.Drawing.Point(104, 259);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(128, 40);
            this.btnGenerar.TabIndex = 9;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.Snow;
            this.btnOrdenar.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.ForeColor = System.Drawing.Color.Maroon;
            this.btnOrdenar.Location = new System.Drawing.Point(348, 308);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(128, 40);
            this.btnOrdenar.TabIndex = 10;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // gbTiempo
            // 
            this.gbTiempo.BackColor = System.Drawing.Color.Snow;
            this.gbTiempo.Controls.Add(this.lblOrdenar);
            this.gbTiempo.Controls.Add(this.lOrd);
            this.gbTiempo.Controls.Add(this.lblComparaciones);
            this.gbTiempo.Controls.Add(this.lblIntercambios);
            this.gbTiempo.Controls.Add(this.lCom);
            this.gbTiempo.Controls.Add(this.lInt);
            this.gbTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTiempo.ForeColor = System.Drawing.Color.Maroon;
            this.gbTiempo.Location = new System.Drawing.Point(30, 321);
            this.gbTiempo.Name = "gbTiempo";
            this.gbTiempo.Size = new System.Drawing.Size(300, 124);
            this.gbTiempo.TabIndex = 11;
            this.gbTiempo.TabStop = false;
            this.gbTiempo.Text = "Tiempo de ejecucion:";
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenar.Location = new System.Drawing.Point(93, 100);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(28, 17);
            this.lblOrdenar.TabIndex = 5;
            this.lblOrdenar.Text = "0:0";
            // 
            // lOrd
            // 
            this.lOrd.AutoSize = true;
            this.lOrd.Location = new System.Drawing.Point(14, 100);
            this.lOrd.Name = "lOrd";
            this.lOrd.Size = new System.Drawing.Size(73, 17);
            this.lOrd.TabIndex = 4;
            this.lOrd.Text = "Ordenar:";
            // 
            // lblComparaciones
            // 
            this.lblComparaciones.AutoSize = true;
            this.lblComparaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComparaciones.Location = new System.Drawing.Point(144, 65);
            this.lblComparaciones.Name = "lblComparaciones";
            this.lblComparaciones.Size = new System.Drawing.Size(16, 17);
            this.lblComparaciones.TabIndex = 3;
            this.lblComparaciones.Text = "0";
            // 
            // lblIntercambios
            // 
            this.lblIntercambios.AutoSize = true;
            this.lblIntercambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntercambios.Location = new System.Drawing.Point(125, 31);
            this.lblIntercambios.Name = "lblIntercambios";
            this.lblIntercambios.Size = new System.Drawing.Size(16, 17);
            this.lblIntercambios.TabIndex = 2;
            this.lblIntercambios.Text = "0";
            // 
            // lCom
            // 
            this.lCom.AutoSize = true;
            this.lCom.Location = new System.Drawing.Point(14, 65);
            this.lCom.Name = "lCom";
            this.lCom.Size = new System.Drawing.Size(124, 17);
            this.lCom.TabIndex = 1;
            this.lCom.Text = "Comparaciones:";
            // 
            // lInt
            // 
            this.lInt.AutoSize = true;
            this.lInt.Location = new System.Drawing.Point(14, 31);
            this.lInt.Name = "lInt";
            this.lInt.Size = new System.Drawing.Size(105, 17);
            this.lInt.TabIndex = 0;
            this.lInt.Text = "Intercambios:";
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
            this.menuStrip1.Size = new System.Drawing.Size(654, 28);
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
            this.ClientSize = new System.Drawing.Size(654, 471);
            this.Controls.Add(this.gbTiempo);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lbOrd);
            this.Controls.Add(this.lbNum);
            this.Controls.Add(this.lMax);
            this.Controls.Add(this.lMin);
            this.Controls.Add(this.lNum);
            this.Controls.Add(this.lT);
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

        private System.Windows.Forms.Label lT;
        private System.Windows.Forms.Label lNum;
        private System.Windows.Forms.Label lMin;
        private System.Windows.Forms.Label lMax;
        private System.Windows.Forms.ListBox lbNum;
        private System.Windows.Forms.ListBox lbOrd;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.GroupBox gbTiempo;
        private System.Windows.Forms.Label lblOrdenar;
        private System.Windows.Forms.Label lOrd;
        private System.Windows.Forms.Label lblComparaciones;
        private System.Windows.Forms.Label lblIntercambios;
        private System.Windows.Forms.Label lCom;
        private System.Windows.Forms.Label lInt;
        private System.Windows.Forms.ToolStripMenuItem algoritmosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructurasToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}