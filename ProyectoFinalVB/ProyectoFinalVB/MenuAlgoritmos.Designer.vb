<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAlgoritmos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuAlgoritmos))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblIndi = New System.Windows.Forms.Label()
        Me.btnBurbuja = New System.Windows.Forms.Button()
        Me.btnBurbujaB = New System.Windows.Forms.Button()
        Me.btnCuentas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Snow
        Me.lblTitulo.Font = New System.Drawing.Font("Elephant", 25.8!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.Crimson
        Me.lblTitulo.Location = New System.Drawing.Point(38, 19)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(644, 55)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Algoritmos de Ordenamiento"
        '
        'lblIndi
        '
        Me.lblIndi.AutoSize = True
        Me.lblIndi.BackColor = System.Drawing.Color.Snow
        Me.lblIndi.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold)
        Me.lblIndi.ForeColor = System.Drawing.Color.Crimson
        Me.lblIndi.Location = New System.Drawing.Point(37, 74)
        Me.lblIndi.Name = "lblIndi"
        Me.lblIndi.Size = New System.Drawing.Size(645, 30)
        Me.lblIndi.TabIndex = 1
        Me.lblIndi.Text = " Selecciona un tipo de Algoritmo de Ordenamiento  "
        '
        'btnBurbuja
        '
        Me.btnBurbuja.BackColor = System.Drawing.Color.Snow
        Me.btnBurbuja.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBurbuja.ForeColor = System.Drawing.Color.Crimson
        Me.btnBurbuja.Location = New System.Drawing.Point(48, 177)
        Me.btnBurbuja.Name = "btnBurbuja"
        Me.btnBurbuja.Size = New System.Drawing.Size(167, 67)
        Me.btnBurbuja.TabIndex = 2
        Me.btnBurbuja.Text = "Burbuja"
        Me.btnBurbuja.UseVisualStyleBackColor = False
        '
        'btnBurbujaB
        '
        Me.btnBurbujaB.BackColor = System.Drawing.Color.Snow
        Me.btnBurbujaB.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBurbujaB.ForeColor = System.Drawing.Color.Crimson
        Me.btnBurbujaB.Location = New System.Drawing.Point(48, 265)
        Me.btnBurbujaB.Name = "btnBurbujaB"
        Me.btnBurbujaB.Size = New System.Drawing.Size(167, 67)
        Me.btnBurbujaB.TabIndex = 3
        Me.btnBurbujaB.Text = "Burbuja Bidireccional"
        Me.btnBurbujaB.UseVisualStyleBackColor = False
        '
        'btnCuentas
        '
        Me.btnCuentas.BackColor = System.Drawing.Color.Snow
        Me.btnCuentas.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCuentas.ForeColor = System.Drawing.Color.Crimson
        Me.btnCuentas.Location = New System.Drawing.Point(236, 265)
        Me.btnCuentas.Name = "btnCuentas"
        Me.btnCuentas.Size = New System.Drawing.Size(167, 67)
        Me.btnCuentas.TabIndex = 4
        Me.btnCuentas.Text = "Cuentas"
        Me.btnCuentas.UseVisualStyleBackColor = False
        '
        'MenuAlgoritmos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 485)
        Me.Controls.Add(Me.btnCuentas)
        Me.Controls.Add(Me.btnBurbujaB)
        Me.Controls.Add(Me.btnBurbuja)
        Me.Controls.Add(Me.lblIndi)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "MenuAlgoritmos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Algoritmos de Ordenamiento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblIndi As Label
    Friend WithEvents btnBurbuja As Button
    Friend WithEvents btnBurbujaB As Button
    Friend WithEvents btnCuentas As Button
End Class
