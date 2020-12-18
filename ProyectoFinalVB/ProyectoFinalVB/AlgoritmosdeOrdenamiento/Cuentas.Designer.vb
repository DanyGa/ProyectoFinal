<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cuentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cuentas))
        Me.lblOriginal = New System.Windows.Forms.Label()
        Me.lblOrd = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.lblInv = New System.Windows.Forms.Label()
        Me.lblEla = New System.Windows.Forms.Label()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.lblInvertido = New System.Windows.Forms.Label()
        Me.lblOrdenado = New System.Windows.Forms.Label()
        Me.lblDes = New System.Windows.Forms.Label()
        Me.lblRan = New System.Windows.Forms.Label()
        Me.lblTam = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCrearArreglo = New System.Windows.Forms.Button()
        Me.btnAleatorio = New System.Windows.Forms.Button()
        Me.txtTamaño = New System.Windows.Forms.TextBox()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AlgoritmosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstructurasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblOriginal
        '
        Me.lblOriginal.AutoSize = True
        Me.lblOriginal.BackColor = System.Drawing.Color.Snow
        Me.lblOriginal.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.lblOriginal.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblOriginal.Location = New System.Drawing.Point(243, 38)
        Me.lblOriginal.Name = "lblOriginal"
        Me.lblOriginal.Size = New System.Drawing.Size(30, 22)
        Me.lblOriginal.TabIndex = 0
        Me.lblOriginal.Text = "----"
        '
        'lblOrd
        '
        Me.lblOrd.AutoSize = True
        Me.lblOrd.BackColor = System.Drawing.Color.Snow
        Me.lblOrd.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.lblOrd.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblOrd.Location = New System.Drawing.Point(17, 80)
        Me.lblOrd.Name = "lblOrd"
        Me.lblOrd.Size = New System.Drawing.Size(173, 22)
        Me.lblOrd.TabIndex = 1
        Me.lblOrd.Text = "Arreglo ordenado:"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.BackColor = System.Drawing.Color.Snow
        Me.lblMin.Font = New System.Drawing.Font("Britannic Bold", 10.2!)
        Me.lblMin.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblMin.Location = New System.Drawing.Point(314, 90)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(36, 19)
        Me.lblMin.TabIndex = 2
        Me.lblMin.Text = "Min"
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.BackColor = System.Drawing.Color.Snow
        Me.lblMax.Font = New System.Drawing.Font("Britannic Bold", 10.2!)
        Me.lblMax.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblMax.Location = New System.Drawing.Point(389, 90)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(38, 19)
        Me.lblMax.TabIndex = 3
        Me.lblMax.Text = "Max"
        '
        'lblInv
        '
        Me.lblInv.AutoSize = True
        Me.lblInv.BackColor = System.Drawing.Color.Snow
        Me.lblInv.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.lblInv.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblInv.Location = New System.Drawing.Point(17, 129)
        Me.lblInv.Name = "lblInv"
        Me.lblInv.Size = New System.Drawing.Size(167, 22)
        Me.lblInv.TabIndex = 4
        Me.lblInv.Text = "Arreglo invertido:"
        '
        'lblEla
        '
        Me.lblEla.AutoSize = True
        Me.lblEla.BackColor = System.Drawing.Color.Snow
        Me.lblEla.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.lblEla.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblEla.Location = New System.Drawing.Point(17, 177)
        Me.lblEla.Name = "lblEla"
        Me.lblEla.Size = New System.Drawing.Size(166, 22)
        Me.lblEla.TabIndex = 5
        Me.lblEla.Text = "TIempo elapsado:"
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.BackColor = System.Drawing.Color.Snow
        Me.lblTiempo.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.lblTiempo.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblTiempo.Location = New System.Drawing.Point(199, 177)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(30, 22)
        Me.lblTiempo.TabIndex = 6
        Me.lblTiempo.Text = "----"
        '
        'lblInvertido
        '
        Me.lblInvertido.AutoSize = True
        Me.lblInvertido.BackColor = System.Drawing.Color.Snow
        Me.lblInvertido.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.lblInvertido.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblInvertido.Location = New System.Drawing.Point(199, 129)
        Me.lblInvertido.Name = "lblInvertido"
        Me.lblInvertido.Size = New System.Drawing.Size(30, 22)
        Me.lblInvertido.TabIndex = 7
        Me.lblInvertido.Text = "----"
        '
        'lblOrdenado
        '
        Me.lblOrdenado.AutoSize = True
        Me.lblOrdenado.BackColor = System.Drawing.Color.Snow
        Me.lblOrdenado.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.lblOrdenado.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblOrdenado.Location = New System.Drawing.Point(208, 80)
        Me.lblOrdenado.Name = "lblOrdenado"
        Me.lblOrdenado.Size = New System.Drawing.Size(30, 22)
        Me.lblOrdenado.TabIndex = 8
        Me.lblOrdenado.Text = "----"
        '
        'lblDes
        '
        Me.lblDes.AutoSize = True
        Me.lblDes.BackColor = System.Drawing.Color.Snow
        Me.lblDes.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.lblDes.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblDes.Location = New System.Drawing.Point(17, 38)
        Me.lblDes.Name = "lblDes"
        Me.lblDes.Size = New System.Drawing.Size(204, 22)
        Me.lblDes.TabIndex = 9
        Me.lblDes.Text = "Arreglo desordenado:"
        '
        'lblRan
        '
        Me.lblRan.AutoSize = True
        Me.lblRan.BackColor = System.Drawing.Color.Snow
        Me.lblRan.Font = New System.Drawing.Font("Britannic Bold", 10.2!)
        Me.lblRan.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblRan.Location = New System.Drawing.Point(343, 18)
        Me.lblRan.Name = "lblRan"
        Me.lblRan.Size = New System.Drawing.Size(57, 19)
        Me.lblRan.TabIndex = 10
        Me.lblRan.Text = "Rango"
        '
        'lblTam
        '
        Me.lblTam.AutoSize = True
        Me.lblTam.BackColor = System.Drawing.Color.Snow
        Me.lblTam.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.lblTam.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblTam.Location = New System.Drawing.Point(6, 51)
        Me.lblTam.Name = "lblTam"
        Me.lblTam.Size = New System.Drawing.Size(190, 22)
        Me.lblTam.TabIndex = 11
        Me.lblTam.Text = "Tamaño del arreglo:"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Snow
        Me.lblTitulo.Font = New System.Drawing.Font("Elephant", 22.2!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblTitulo.Location = New System.Drawing.Point(65, 42)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(535, 49)
        Me.lblTitulo.TabIndex = 12
        Me.lblTitulo.Text = "Ordenamiento por Cuentas"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblMin)
        Me.GroupBox1.Controls.Add(Me.lblTam)
        Me.GroupBox1.Controls.Add(Me.btnCrearArreglo)
        Me.GroupBox1.Controls.Add(Me.btnAleatorio)
        Me.GroupBox1.Controls.Add(Me.lblMax)
        Me.GroupBox1.Controls.Add(Me.txtTamaño)
        Me.GroupBox1.Controls.Add(Me.txtMin)
        Me.GroupBox1.Controls.Add(Me.txtMax)
        Me.GroupBox1.Controls.Add(Me.lblRan)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 132)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'btnCrearArreglo
        '
        Me.btnCrearArreglo.BackColor = System.Drawing.Color.Snow
        Me.btnCrearArreglo.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnCrearArreglo.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.btnCrearArreglo.Location = New System.Drawing.Point(467, 21)
        Me.btnCrearArreglo.Name = "btnCrearArreglo"
        Me.btnCrearArreglo.Size = New System.Drawing.Size(135, 48)
        Me.btnCrearArreglo.TabIndex = 0
        Me.btnCrearArreglo.Text = "Crear"
        Me.btnCrearArreglo.UseVisualStyleBackColor = False
        '
        'btnAleatorio
        '
        Me.btnAleatorio.BackColor = System.Drawing.Color.Snow
        Me.btnAleatorio.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnAleatorio.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.btnAleatorio.Location = New System.Drawing.Point(467, 78)
        Me.btnAleatorio.Name = "btnAleatorio"
        Me.btnAleatorio.Size = New System.Drawing.Size(135, 48)
        Me.btnAleatorio.TabIndex = 1
        Me.btnAleatorio.Text = "Aleatorio"
        Me.btnAleatorio.UseVisualStyleBackColor = False
        '
        'txtTamaño
        '
        Me.txtTamaño.Location = New System.Drawing.Point(212, 51)
        Me.txtTamaño.Name = "txtTamaño"
        Me.txtTamaño.Size = New System.Drawing.Size(49, 22)
        Me.txtTamaño.TabIndex = 17
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(306, 51)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(49, 22)
        Me.txtMin.TabIndex = 16
        '
        'txtMax
        '
        Me.txtMax.Location = New System.Drawing.Point(383, 51)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(49, 22)
        Me.txtMax.TabIndex = 15
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblOriginal)
        Me.GroupBox2.Controls.Add(Me.lblInvertido)
        Me.GroupBox2.Controls.Add(Me.lblOrd)
        Me.GroupBox2.Controls.Add(Me.lblDes)
        Me.GroupBox2.Controls.Add(Me.lblInv)
        Me.GroupBox2.Controls.Add(Me.lblOrdenado)
        Me.GroupBox2.Controls.Add(Me.lblEla)
        Me.GroupBox2.Controls.Add(Me.lblTiempo)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 256)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(608, 220)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlgoritmosToolStripMenuItem, Me.EstructurasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(690, 28)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AlgoritmosToolStripMenuItem
        '
        Me.AlgoritmosToolStripMenuItem.Name = "AlgoritmosToolStripMenuItem"
        Me.AlgoritmosToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.AlgoritmosToolStripMenuItem.Text = "Algoritmos"
        '
        'EstructurasToolStripMenuItem
        '
        Me.EstructurasToolStripMenuItem.Name = "EstructurasToolStripMenuItem"
        Me.EstructurasToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.EstructurasToolStripMenuItem.Text = "Estructuras"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Cuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(690, 487)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Cuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuentas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOriginal As Label
    Friend WithEvents lblOrd As Label
    Friend WithEvents lblMin As Label
    Friend WithEvents lblMax As Label
    Friend WithEvents lblInv As Label
    Friend WithEvents lblEla As Label
    Friend WithEvents lblTiempo As Label
    Friend WithEvents lblInvertido As Label
    Friend WithEvents lblOrdenado As Label
    Friend WithEvents lblDes As Label
    Friend WithEvents lblRan As Label
    Friend WithEvents lblTam As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCrearArreglo As Button
    Friend WithEvents btnAleatorio As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents txtMax As TextBox
    Friend WithEvents txtMin As TextBox
    Friend WithEvents txtTamaño As TextBox
    Friend WithEvents AlgoritmosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstructurasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
