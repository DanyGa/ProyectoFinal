namespace ProyectoFinal.EstructurasdeDatos
{
    partial class Colas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Colas));
            this.gbArriba = new System.Windows.Forms.GroupBox();
            this.gbAbajo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.algoritmosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCola = new System.Windows.Forms.Label();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnDesencolar = new System.Windows.Forms.Button();
            this.btnEncolar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbArriba.SuspendLayout();
            this.gbAbajo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbArriba
            // 
            this.gbArriba.BackColor = System.Drawing.Color.Transparent;
            this.gbArriba.Controls.Add(this.btnCargar);
            this.gbArriba.Controls.Add(this.btnNuevo);
            this.gbArriba.Location = new System.Drawing.Point(22, 101);
            this.gbArriba.Name = "gbArriba";
            this.gbArriba.Size = new System.Drawing.Size(569, 80);
            this.gbArriba.TabIndex = 0;
            this.gbArriba.TabStop = false;
            // 
            // gbAbajo
            // 
            this.gbAbajo.BackColor = System.Drawing.Color.Transparent;
            this.gbAbajo.Controls.Add(this.btnGuardar);
            this.gbAbajo.Controls.Add(this.btnEncolar);
            this.gbAbajo.Controls.Add(this.btnDesencolar);
            this.gbAbajo.Controls.Add(this.btnConsultar);
            this.gbAbajo.Controls.Add(this.txtDato);
            this.gbAbajo.Controls.Add(this.txtArchivo);
            this.gbAbajo.Controls.Add(this.label2);
            this.gbAbajo.Controls.Add(this.lblCola);
            this.gbAbajo.Controls.Add(this.label3);
            this.gbAbajo.Location = new System.Drawing.Point(22, 209);
            this.gbAbajo.Name = "gbAbajo";
            this.gbAbajo.Size = new System.Drawing.Size(569, 236);
            this.gbAbajo.TabIndex = 1;
            this.gbAbajo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 22.2F);
            this.label1.Location = new System.Drawing.Point(246, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Colas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label2.Location = new System.Drawing.Point(62, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label3.Location = new System.Drawing.Point(198, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre del archivo";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Snow;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmosToolStripMenuItem,
            this.estructurasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // algoritmosToolStripMenuItem
            // 
            this.algoritmosToolStripMenuItem.Name = "algoritmosToolStripMenuItem";
            this.algoritmosToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.algoritmosToolStripMenuItem.Text = "Algoritmos";
            this.algoritmosToolStripMenuItem.Click += new System.EventHandler(this.algoritmosToolStripMenuItem_Click);
            // 
            // estructurasToolStripMenuItem
            // 
            this.estructurasToolStripMenuItem.Name = "estructurasToolStripMenuItem";
            this.estructurasToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.estructurasToolStripMenuItem.Text = "Estructuras";
            this.estructurasToolStripMenuItem.Click += new System.EventHandler(this.estructurasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // lblCola
            // 
            this.lblCola.AutoSize = true;
            this.lblCola.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.lblCola.Location = new System.Drawing.Point(409, 31);
            this.lblCola.Name = "lblCola";
            this.lblCola.Size = new System.Drawing.Size(49, 22);
            this.lblCola.TabIndex = 3;
            this.lblCola.Text = "Cola";
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(173, 159);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(166, 22);
            this.txtArchivo.TabIndex = 4;
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(151, 62);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(65, 22);
            this.txtDato.TabIndex = 5;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Snow;
            this.btnConsultar.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.Location = new System.Drawing.Point(413, 80);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(127, 42);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Frente";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnDesencolar
            // 
            this.btnDesencolar.BackColor = System.Drawing.Color.Snow;
            this.btnDesencolar.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnDesencolar.Location = new System.Drawing.Point(246, 80);
            this.btnDesencolar.Name = "btnDesencolar";
            this.btnDesencolar.Size = new System.Drawing.Size(127, 42);
            this.btnDesencolar.TabIndex = 7;
            this.btnDesencolar.Text = "Desencolar";
            this.btnDesencolar.UseVisualStyleBackColor = false;
            this.btnDesencolar.Click += new System.EventHandler(this.btnDesencolar_Click);
            // 
            // btnEncolar
            // 
            this.btnEncolar.BackColor = System.Drawing.Color.Snow;
            this.btnEncolar.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnEncolar.Location = new System.Drawing.Point(246, 21);
            this.btnEncolar.Name = "btnEncolar";
            this.btnEncolar.Size = new System.Drawing.Size(127, 42);
            this.btnEncolar.TabIndex = 8;
            this.btnEncolar.Text = "Encolar";
            this.btnEncolar.UseVisualStyleBackColor = false;
            this.btnEncolar.Click += new System.EventHandler(this.btnEncolar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Snow;
            this.btnGuardar.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Location = new System.Drawing.Point(22, 149);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(127, 42);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Snow;
            this.btnCargar.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCargar.Location = new System.Drawing.Point(314, 21);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(127, 42);
            this.btnCargar.TabIndex = 10;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Snow;
            this.btnNuevo.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.Location = new System.Drawing.Point(147, 21);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(127, 42);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Colas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(653, 485);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbAbajo);
            this.Controls.Add(this.gbArriba);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Colas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colas";
            this.Load += new System.EventHandler(this.Colas_Load);
            this.gbArriba.ResumeLayout(false);
            this.gbAbajo.ResumeLayout(false);
            this.gbAbajo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbArriba;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbAbajo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEncolar;
        private System.Windows.Forms.Button btnDesencolar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algoritmosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructurasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}