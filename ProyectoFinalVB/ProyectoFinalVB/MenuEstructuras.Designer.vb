﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuEstructuras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuEstructuras))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblInst = New System.Windows.Forms.Label()
        Me.btnListas = New System.Windows.Forms.Button()
        Me.btnPila = New System.Windows.Forms.Button()
        Me.btnCola = New System.Windows.Forms.Button()
        Me.btnGrafo = New System.Windows.Forms.Button()
        Me.btnArbol = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Elephant", 25.8!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.ForeColor = System.Drawing.Color.Snow
        Me.lblTitulo.Location = New System.Drawing.Point(54, 44)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(505, 55)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Estructuras de Datos"
        '
        'lblInst
        '
        Me.lblInst.AutoSize = True
        Me.lblInst.BackColor = System.Drawing.Color.Transparent
        Me.lblInst.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblInst.ForeColor = System.Drawing.Color.Olive
        Me.lblInst.Location = New System.Drawing.Point(141, 99)
        Me.lblInst.Name = "lblInst"
        Me.lblInst.Size = New System.Drawing.Size(366, 25)
        Me.lblInst.TabIndex = 1
        Me.lblInst.Text = "Selecciona un tipo de Estructura"
        '
        'btnListas
        '
        Me.btnListas.BackColor = System.Drawing.Color.Snow
        Me.btnListas.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnListas.ForeColor = System.Drawing.Color.Olive
        Me.btnListas.Location = New System.Drawing.Point(64, 164)
        Me.btnListas.Name = "btnListas"
        Me.btnListas.Size = New System.Drawing.Size(137, 70)
        Me.btnListas.TabIndex = 2
        Me.btnListas.Text = "Listas"
        Me.btnListas.UseVisualStyleBackColor = False
        '
        'btnPila
        '
        Me.btnPila.BackColor = System.Drawing.Color.Snow
        Me.btnPila.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPila.ForeColor = System.Drawing.Color.Olive
        Me.btnPila.Location = New System.Drawing.Point(244, 164)
        Me.btnPila.Name = "btnPila"
        Me.btnPila.Size = New System.Drawing.Size(137, 70)
        Me.btnPila.TabIndex = 3
        Me.btnPila.Text = "Pila"
        Me.btnPila.UseVisualStyleBackColor = False
        '
        'btnCola
        '
        Me.btnCola.BackColor = System.Drawing.Color.Snow
        Me.btnCola.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCola.ForeColor = System.Drawing.Color.Olive
        Me.btnCola.Location = New System.Drawing.Point(422, 164)
        Me.btnCola.Name = "btnCola"
        Me.btnCola.Size = New System.Drawing.Size(137, 70)
        Me.btnCola.TabIndex = 4
        Me.btnCola.Text = "Cola"
        Me.btnCola.UseVisualStyleBackColor = False
        '
        'btnGrafo
        '
        Me.btnGrafo.BackColor = System.Drawing.Color.Snow
        Me.btnGrafo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnGrafo.ForeColor = System.Drawing.Color.Olive
        Me.btnGrafo.Location = New System.Drawing.Point(146, 280)
        Me.btnGrafo.Name = "btnGrafo"
        Me.btnGrafo.Size = New System.Drawing.Size(137, 70)
        Me.btnGrafo.TabIndex = 5
        Me.btnGrafo.Text = "Grafo"
        Me.btnGrafo.UseVisualStyleBackColor = False
        '
        'btnArbol
        '
        Me.btnArbol.BackColor = System.Drawing.Color.Snow
        Me.btnArbol.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnArbol.ForeColor = System.Drawing.Color.Olive
        Me.btnArbol.Location = New System.Drawing.Point(330, 280)
        Me.btnArbol.Name = "btnArbol"
        Me.btnArbol.Size = New System.Drawing.Size(137, 70)
        Me.btnArbol.TabIndex = 6
        Me.btnArbol.Text = "Arbol"
        Me.btnArbol.UseVisualStyleBackColor = False
        '
        'MenuEstructuras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(634, 391)
        Me.Controls.Add(Me.btnArbol)
        Me.Controls.Add(Me.btnGrafo)
        Me.Controls.Add(Me.btnCola)
        Me.Controls.Add(Me.btnPila)
        Me.Controls.Add(Me.btnListas)
        Me.Controls.Add(Me.lblInst)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "MenuEstructuras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estructuras de Datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblInst As Label
    Friend WithEvents btnListas As Button
    Friend WithEvents btnPila As Button
    Friend WithEvents btnCola As Button
    Friend WithEvents btnGrafo As Button
    Friend WithEvents btnArbol As Button
End Class
