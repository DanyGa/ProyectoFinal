<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.lblBi = New System.Windows.Forms.Label()
        Me.lblPr = New System.Windows.Forms.Label()
        Me.btnEstructura = New System.Windows.Forms.Button()
        Me.btnAlgoritmo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblBi
        '
        Me.lblBi.AutoSize = True
        Me.lblBi.BackColor = System.Drawing.Color.Transparent
        Me.lblBi.Font = New System.Drawing.Font("Elephant", 25.8!)
        Me.lblBi.ForeColor = System.Drawing.Color.Snow
        Me.lblBi.Location = New System.Drawing.Point(171, 23)
        Me.lblBi.Name = "lblBi"
        Me.lblBi.Size = New System.Drawing.Size(285, 55)
        Me.lblBi.TabIndex = 0
        Me.lblBi.Text = "Bienvenid@"
        '
        'lblPr
        '
        Me.lblPr.AutoSize = True
        Me.lblPr.BackColor = System.Drawing.Color.Transparent
        Me.lblPr.Font = New System.Drawing.Font("Elephant", 24.0!)
        Me.lblPr.ForeColor = System.Drawing.Color.Snow
        Me.lblPr.Location = New System.Drawing.Point(131, 78)
        Me.lblPr.Name = "lblPr"
        Me.lblPr.Size = New System.Drawing.Size(364, 51)
        Me.lblPr.TabIndex = 1
        Me.lblPr.Text = "Que desea crear?"
        '
        'btnEstructura
        '
        Me.btnEstructura.BackColor = System.Drawing.Color.Snow
        Me.btnEstructura.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEstructura.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.btnEstructura.Location = New System.Drawing.Point(75, 150)
        Me.btnEstructura.Name = "btnEstructura"
        Me.btnEstructura.Size = New System.Drawing.Size(175, 73)
        Me.btnEstructura.TabIndex = 2
        Me.btnEstructura.Text = "Estructura de Datos"
        Me.btnEstructura.UseVisualStyleBackColor = False
        '
        'btnAlgoritmo
        '
        Me.btnAlgoritmo.BackColor = System.Drawing.Color.Snow
        Me.btnAlgoritmo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAlgoritmo.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.btnAlgoritmo.Location = New System.Drawing.Point(374, 150)
        Me.btnAlgoritmo.Name = "btnAlgoritmo"
        Me.btnAlgoritmo.Size = New System.Drawing.Size(175, 73)
        Me.btnAlgoritmo.TabIndex = 3
        Me.btnAlgoritmo.Text = "Algoritmo de Ordenamiento"
        Me.btnAlgoritmo.UseVisualStyleBackColor = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(624, 272)
        Me.Controls.Add(Me.btnAlgoritmo)
        Me.Controls.Add(Me.btnEstructura)
        Me.Controls.Add(Me.lblPr)
        Me.Controls.Add(Me.lblBi)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBi As Label
    Friend WithEvents lblPr As Label
    Friend WithEvents btnEstructura As Button
    Friend WithEvents btnAlgoritmo As Button
End Class
