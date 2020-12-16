namespace ProyectoFinal.EstructurasdeDatos
{
    partial class Listas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listas));
            this.lL = new System.Windows.Forms.Label();
            this.btnSimple = new System.Windows.Forms.Button();
            this.btnDoble = new System.Windows.Forms.Button();
            this.btnSimpleCircular = new System.Windows.Forms.Button();
            this.btnDobleCircular = new System.Windows.Forms.Button();
            this.lI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lL
            // 
            this.lL.AutoSize = true;
            this.lL.BackColor = System.Drawing.Color.Transparent;
            this.lL.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lL.ForeColor = System.Drawing.Color.Snow;
            this.lL.Location = new System.Drawing.Point(189, 37);
            this.lL.Name = "lL";
            this.lL.Size = new System.Drawing.Size(164, 55);
            this.lL.TabIndex = 0;
            this.lL.Text = "Listas";
            // 
            // btnSimple
            // 
            this.btnSimple.BackColor = System.Drawing.Color.Snow;
            this.btnSimple.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimple.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSimple.Location = new System.Drawing.Point(72, 139);
            this.btnSimple.Name = "btnSimple";
            this.btnSimple.Size = new System.Drawing.Size(154, 66);
            this.btnSimple.TabIndex = 1;
            this.btnSimple.Text = "Lista Simple";
            this.btnSimple.UseVisualStyleBackColor = false;
            // 
            // btnDoble
            // 
            this.btnDoble.BackColor = System.Drawing.Color.Snow;
            this.btnDoble.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoble.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDoble.Location = new System.Drawing.Point(72, 244);
            this.btnDoble.Name = "btnDoble";
            this.btnDoble.Size = new System.Drawing.Size(154, 66);
            this.btnDoble.TabIndex = 2;
            this.btnDoble.Text = "Lista Doble";
            this.btnDoble.UseVisualStyleBackColor = false;
            // 
            // btnSimpleCircular
            // 
            this.btnSimpleCircular.BackColor = System.Drawing.Color.Snow;
            this.btnSimpleCircular.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpleCircular.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSimpleCircular.Location = new System.Drawing.Point(308, 139);
            this.btnSimpleCircular.Name = "btnSimpleCircular";
            this.btnSimpleCircular.Size = new System.Drawing.Size(154, 66);
            this.btnSimpleCircular.TabIndex = 3;
            this.btnSimpleCircular.Text = "Lista Simple Circular";
            this.btnSimpleCircular.UseVisualStyleBackColor = false;
            // 
            // btnDobleCircular
            // 
            this.btnDobleCircular.BackColor = System.Drawing.Color.Snow;
            this.btnDobleCircular.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDobleCircular.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDobleCircular.Location = new System.Drawing.Point(308, 244);
            this.btnDobleCircular.Name = "btnDobleCircular";
            this.btnDobleCircular.Size = new System.Drawing.Size(154, 66);
            this.btnDobleCircular.TabIndex = 4;
            this.btnDobleCircular.Text = "Lista Doble Circular";
            this.btnDobleCircular.UseVisualStyleBackColor = false;
            // 
            // lI
            // 
            this.lI.AutoSize = true;
            this.lI.BackColor = System.Drawing.Color.Transparent;
            this.lI.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lI.ForeColor = System.Drawing.Color.Snow;
            this.lI.Location = new System.Drawing.Point(82, 92);
            this.lI.Name = "lI";
            this.lI.Size = new System.Drawing.Size(365, 31);
            this.lI.TabIndex = 5;
            this.lI.Text = "Selecciona un tipo de Lista";
            // 
            // Listas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(531, 394);
            this.Controls.Add(this.lI);
            this.Controls.Add(this.btnDobleCircular);
            this.Controls.Add(this.btnSimpleCircular);
            this.Controls.Add(this.btnDoble);
            this.Controls.Add(this.btnSimple);
            this.Controls.Add(this.lL);
            this.Name = "Listas";
            this.Text = "Listas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lL;
        private System.Windows.Forms.Button btnSimple;
        private System.Windows.Forms.Button btnDoble;
        private System.Windows.Forms.Button btnSimpleCircular;
        private System.Windows.Forms.Button btnDobleCircular;
        private System.Windows.Forms.Label lI;
    }
}