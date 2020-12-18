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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTNum = new System.Windows.Forms.Label();
            this.lblRMay = new System.Windows.Forms.Label();
            this.lblRMen = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtMay = new System.Windows.Forms.TextBox();
            this.txtMen = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lbNum = new System.Windows.Forms.ListBox();
            this.lbOrd = new System.Windows.Forms.ListBox();
            this.gbTiempo = new System.Windows.Forms.GroupBox();
            this.lblIntercambios = new System.Windows.Forms.Label();
            this.lblComparaciones = new System.Windows.Forms.Label();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.lblOrd = new System.Windows.Forms.Label();
            this.lblCom = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbTiempo.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(875, 28);
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
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Snow;
            this.lblTitulo.Font = new System.Drawing.Font("Elephant", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Brown;
            this.lblTitulo.Location = new System.Drawing.Point(180, 72);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(519, 49);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Ordenamiento de Burbuja";
            // 
            // lblTNum
            // 
            this.lblTNum.AutoSize = true;
            this.lblTNum.BackColor = System.Drawing.Color.Snow;
            this.lblTNum.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTNum.ForeColor = System.Drawing.Color.Brown;
            this.lblTNum.Location = new System.Drawing.Point(62, 161);
            this.lblTNum.Name = "lblTNum";
            this.lblTNum.Size = new System.Drawing.Size(205, 27);
            this.lblTNum.TabIndex = 2;
            this.lblTNum.Text = "Total de Numeros:";
            // 
            // lblRMay
            // 
            this.lblRMay.AutoSize = true;
            this.lblRMay.BackColor = System.Drawing.Color.Snow;
            this.lblRMay.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRMay.ForeColor = System.Drawing.Color.Brown;
            this.lblRMay.Location = new System.Drawing.Point(62, 254);
            this.lblRMay.Name = "lblRMay";
            this.lblRMay.Size = new System.Drawing.Size(159, 27);
            this.lblRMay.TabIndex = 3;
            this.lblRMay.Text = "Rango Mayor:";
            // 
            // lblRMen
            // 
            this.lblRMen.AutoSize = true;
            this.lblRMen.BackColor = System.Drawing.Color.Snow;
            this.lblRMen.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRMen.ForeColor = System.Drawing.Color.Brown;
            this.lblRMen.Location = new System.Drawing.Point(62, 207);
            this.lblRMen.Name = "lblRMen";
            this.lblRMen.Size = new System.Drawing.Size(161, 27);
            this.lblRMen.TabIndex = 4;
            this.lblRMen.Text = "Rango Menor:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(289, 166);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(89, 22);
            this.txtNum.TabIndex = 9;
            // 
            // txtMay
            // 
            this.txtMay.Location = new System.Drawing.Point(243, 259);
            this.txtMay.Name = "txtMay";
            this.txtMay.Size = new System.Drawing.Size(135, 22);
            this.txtMay.TabIndex = 10;
            // 
            // txtMen
            // 
            this.txtMen.Location = new System.Drawing.Point(242, 212);
            this.txtMen.Name = "txtMen";
            this.txtMen.Size = new System.Drawing.Size(135, 22);
            this.txtMen.TabIndex = 11;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.Snow;
            this.btnCrear.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.Brown;
            this.btnCrear.Location = new System.Drawing.Point(66, 316);
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
            this.btnOrdenar.Location = new System.Drawing.Point(242, 316);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(136, 53);
            this.btnOrdenar.TabIndex = 7;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // lbNum
            // 
            this.lbNum.FormattingEnabled = true;
            this.lbNum.ItemHeight = 16;
            this.lbNum.Location = new System.Drawing.Point(487, 161);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(110, 340);
            this.lbNum.TabIndex = 16;
            // 
            // lbOrd
            // 
            this.lbOrd.FormattingEnabled = true;
            this.lbOrd.ItemHeight = 16;
            this.lbOrd.Location = new System.Drawing.Point(647, 161);
            this.lbOrd.Name = "lbOrd";
            this.lbOrd.Size = new System.Drawing.Size(110, 340);
            this.lbOrd.TabIndex = 17;
            // 
            // gbTiempo
            // 
            this.gbTiempo.BackColor = System.Drawing.Color.Snow;
            this.gbTiempo.Controls.Add(this.lblIntercambios);
            this.gbTiempo.Controls.Add(this.lblComparaciones);
            this.gbTiempo.Controls.Add(this.lblOrdenar);
            this.gbTiempo.Controls.Add(this.lblOrd);
            this.gbTiempo.Controls.Add(this.lblCom);
            this.gbTiempo.Controls.Add(this.lblInt);
            this.gbTiempo.Location = new System.Drawing.Point(23, 401);
            this.gbTiempo.Name = "gbTiempo";
            this.gbTiempo.Size = new System.Drawing.Size(406, 143);
            this.gbTiempo.TabIndex = 18;
            this.gbTiempo.TabStop = false;
            // 
            // lblIntercambios
            // 
            this.lblIntercambios.AutoSize = true;
            this.lblIntercambios.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.lblIntercambios.ForeColor = System.Drawing.Color.Brown;
            this.lblIntercambios.Location = new System.Drawing.Point(161, 18);
            this.lblIntercambios.Name = "lblIntercambios";
            this.lblIntercambios.Size = new System.Drawing.Size(22, 22);
            this.lblIntercambios.TabIndex = 5;
            this.lblIntercambios.Text = "0";
            // 
            // lblComparaciones
            // 
            this.lblComparaciones.AutoSize = true;
            this.lblComparaciones.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.lblComparaciones.ForeColor = System.Drawing.Color.Brown;
            this.lblComparaciones.Location = new System.Drawing.Point(188, 64);
            this.lblComparaciones.Name = "lblComparaciones";
            this.lblComparaciones.Size = new System.Drawing.Size(22, 22);
            this.lblComparaciones.TabIndex = 4;
            this.lblComparaciones.Text = "0";
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.lblOrdenar.ForeColor = System.Drawing.Color.Brown;
            this.lblOrdenar.Location = new System.Drawing.Point(129, 110);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(40, 22);
            this.lblOrdenar.TabIndex = 3;
            this.lblOrdenar.Text = "0:0";
            // 
            // lblOrd
            // 
            this.lblOrd.AutoSize = true;
            this.lblOrd.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.lblOrd.ForeColor = System.Drawing.Color.Brown;
            this.lblOrd.Location = new System.Drawing.Point(18, 110);
            this.lblOrd.Name = "lblOrd";
            this.lblOrd.Size = new System.Drawing.Size(90, 22);
            this.lblOrd.TabIndex = 2;
            this.lblOrd.Text = "Ordenar:";
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.lblCom.ForeColor = System.Drawing.Color.Brown;
            this.lblCom.Location = new System.Drawing.Point(14, 64);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(155, 22);
            this.lblCom.TabIndex = 1;
            this.lblCom.Text = "Comparaciones:";
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.lblInt.ForeColor = System.Drawing.Color.Brown;
            this.lblInt.Location = new System.Drawing.Point(14, 18);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(133, 22);
            this.lblInt.TabIndex = 0;
            this.lblInt.Text = "Intercambios:";
            // 
            // Burbuja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(875, 578);
            this.ControlBox = false;
            this.Controls.Add(this.gbTiempo);
            this.Controls.Add(this.lbOrd);
            this.Controls.Add(this.lbNum);
            this.Controls.Add(this.txtMen);
            this.Controls.Add(this.txtMay);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblRMen);
            this.Controls.Add(this.lblRMay);
            this.Controls.Add(this.lblTNum);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Burbuja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Burbuja";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbTiempo.ResumeLayout(false);
            this.gbTiempo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algoritmosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructuraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTNum;
        private System.Windows.Forms.Label lblRMay;
        private System.Windows.Forms.Label lblRMen;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtMay;
        private System.Windows.Forms.TextBox txtMen;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.ListBox lbNum;
        private System.Windows.Forms.ListBox lbOrd;
        private System.Windows.Forms.GroupBox gbTiempo;
        private System.Windows.Forms.Label lblIntercambios;
        private System.Windows.Forms.Label lblComparaciones;
        private System.Windows.Forms.Label lblOrdenar;
        private System.Windows.Forms.Label lblOrd;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.Label lblInt;
    }
}