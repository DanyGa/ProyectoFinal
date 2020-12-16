namespace ProyectoFinal
{
    partial class Menu
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
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.btnAlgoritmo = new System.Windows.Forms.Button();
            this.btnEstructura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.l1.Location = new System.Drawing.Point(119, 19);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(199, 38);
            this.l1.TabIndex = 0;
            this.l1.Text = "Bienvenid@";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.l2.Location = new System.Drawing.Point(92, 57);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(248, 35);
            this.l2.TabIndex = 1;
            this.l2.Text = "Que desea crear?";
            // 
            // btnAlgoritmo
            // 
            this.btnAlgoritmo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlgoritmo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAlgoritmo.Location = new System.Drawing.Point(241, 102);
            this.btnAlgoritmo.Name = "btnAlgoritmo";
            this.btnAlgoritmo.Size = new System.Drawing.Size(175, 73);
            this.btnAlgoritmo.TabIndex = 2;
            this.btnAlgoritmo.Text = "Algoritmo de Ordenamiento";
            this.btnAlgoritmo.UseVisualStyleBackColor = true;
            // 
            // btnEstructura
            // 
            this.btnEstructura.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstructura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEstructura.Location = new System.Drawing.Point(21, 102);
            this.btnEstructura.Name = "btnEstructura";
            this.btnEstructura.Size = new System.Drawing.Size(175, 73);
            this.btnEstructura.TabIndex = 3;
            this.btnEstructura.Text = "Estructura de Datos";
            this.btnEstructura.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(441, 211);
            this.Controls.Add(this.btnEstructura);
            this.Controls.Add(this.btnAlgoritmo);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Button btnAlgoritmo;
        private System.Windows.Forms.Button btnEstructura;
    }
}

