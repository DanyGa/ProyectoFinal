namespace ProyectoFinal.EstructurasdeDatos.TiposdeListas
{
    partial class ListaDobleCircular
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
            this.lblLista = new System.Windows.Forms.Label();
            this.lblDato = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.bntContar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBorrarL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(309, 124);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(42, 17);
            this.lblLista.TabIndex = 0;
            this.lblLista.Text = "Lista:";
            // 
            // lblDato
            // 
            this.lblDato.AutoSize = true;
            this.lblDato.Location = new System.Drawing.Point(268, 243);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(42, 17);
            this.lblDato.TabIndex = 1;
            this.lblDato.Text = "Dato:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(373, 49);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(127, 17);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Lista doble circular";
            // 
            // txtNodo
            // 
            this.txtNodo.Location = new System.Drawing.Point(353, 243);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(100, 22);
            this.txtNodo.TabIndex = 3;
            // 
            // bntContar
            // 
            this.bntContar.Location = new System.Drawing.Point(512, 49);
            this.bntContar.Name = "bntContar";
            this.bntContar.Size = new System.Drawing.Size(75, 64);
            this.bntContar.TabIndex = 4;
            this.bntContar.Text = "Contar";
            this.bntContar.UseVisualStyleBackColor = true;
            this.bntContar.Click += new System.EventHandler(this.bntContar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(512, 147);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 64);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardad Lista";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(512, 251);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 64);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar Lista";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(126, 77);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 64);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(126, 147);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 64);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBorrarL
            // 
            this.btnBorrarL.Location = new System.Drawing.Point(104, 251);
            this.btnBorrarL.Name = "btnBorrarL";
            this.btnBorrarL.Size = new System.Drawing.Size(75, 64);
            this.btnBorrarL.TabIndex = 9;
            this.btnBorrarL.Text = "Borrar Lista";
            this.btnBorrarL.UseVisualStyleBackColor = true;
            this.btnBorrarL.Click += new System.EventHandler(this.btnBorrarL_Click);
            // 
            // ListaDobleCircular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBorrarL);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.bntContar);
            this.Controls.Add(this.txtNodo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDato);
            this.Controls.Add(this.lblLista);
            this.Name = "ListaDobleCircular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaDobleCircular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Label lblDato;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.Button bntContar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBorrarL;
    }
}