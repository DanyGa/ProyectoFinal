<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Burbuja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Burbuja))
        Me.lblRMay = New System.Windows.Forms.Label()
        Me.lblRMen = New System.Windows.Forms.Label()
        Me.lblTNum = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnOrdenar = New System.Windows.Forms.Button()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.txtMen = New System.Windows.Forms.TextBox()
        Me.txtMay = New System.Windows.Forms.TextBox()
        Me.gbTiempo = New System.Windows.Forms.GroupBox()
        Me.lblInt = New System.Windows.Forms.Label()
        Me.lblIntercambios = New System.Windows.Forms.Label()
        Me.lblCom = New System.Windows.Forms.Label()
        Me.lblComparaciones = New System.Windows.Forms.Label()
        Me.lblOrd = New System.Windows.Forms.Label()
        Me.lblOrdenar = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AlgoritmosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstructurasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbNum = New System.Windows.Forms.ListBox()
        Me.lbOrd = New System.Windows.Forms.ListBox()
        Me.gbTiempo.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRMay
        '
        Me.lblRMay.AutoSize = True
        Me.lblRMay.BackColor = System.Drawing.Color.Snow
        Me.lblRMay.Font = New System.Drawing.Font("Britannic Bold", 13.8!)
        Me.lblRMay.ForeColor = System.Drawing.Color.Brown
        Me.lblRMay.Location = New System.Drawing.Point(62, 254)
        Me.lblRMay.Name = "lblRMay"
        Me.lblRMay.Size = New System.Drawing.Size(159, 27)
        Me.lblRMay.TabIndex = 4
        Me.lblRMay.Text = "Rango Mayor:"
        '
        'lblRMen
        '
        Me.lblRMen.AutoSize = True
        Me.lblRMen.BackColor = System.Drawing.Color.Snow
        Me.lblRMen.Font = New System.Drawing.Font("Britannic Bold", 13.8!)
        Me.lblRMen.ForeColor = System.Drawing.Color.Brown
        Me.lblRMen.Location = New System.Drawing.Point(62, 207)
        Me.lblRMen.Name = "lblRMen"
        Me.lblRMen.Size = New System.Drawing.Size(161, 27)
        Me.lblRMen.TabIndex = 5
        Me.lblRMen.Text = "Rango Menor:"
        '
        'lblTNum
        '
        Me.lblTNum.AutoSize = True
        Me.lblTNum.BackColor = System.Drawing.Color.Snow
        Me.lblTNum.Font = New System.Drawing.Font("Britannic Bold", 13.8!)
        Me.lblTNum.ForeColor = System.Drawing.Color.Brown
        Me.lblTNum.Location = New System.Drawing.Point(62, 161)
        Me.lblTNum.Name = "lblTNum"
        Me.lblTNum.Size = New System.Drawing.Size(205, 27)
        Me.lblTNum.TabIndex = 6
        Me.lblTNum.Text = "Total de Numeros:"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Snow
        Me.lblTitulo.Font = New System.Drawing.Font("Elephant", 22.2!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.Brown
        Me.lblTitulo.Location = New System.Drawing.Point(180, 72)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(519, 49)
        Me.lblTitulo.TabIndex = 7
        Me.lblTitulo.Text = "Ordenamiento de Burbuja"
        '
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.Snow
        Me.btnCrear.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnCrear.ForeColor = System.Drawing.Color.Brown
        Me.btnCrear.Location = New System.Drawing.Point(66, 316)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(136, 53)
        Me.btnCrear.TabIndex = 8
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'btnOrdenar
        '
        Me.btnOrdenar.BackColor = System.Drawing.Color.Snow
        Me.btnOrdenar.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnOrdenar.ForeColor = System.Drawing.Color.Brown
        Me.btnOrdenar.Location = New System.Drawing.Point(242, 316)
        Me.btnOrdenar.Name = "btnOrdenar"
        Me.btnOrdenar.Size = New System.Drawing.Size(136, 53)
        Me.btnOrdenar.TabIndex = 9
        Me.btnOrdenar.Text = "Ordenar"
        Me.btnOrdenar.UseVisualStyleBackColor = False
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(289, 166)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(89, 22)
        Me.txtNum.TabIndex = 11
        '
        'txtMen
        '
        Me.txtMen.Location = New System.Drawing.Point(242, 212)
        Me.txtMen.Name = "txtMen"
        Me.txtMen.Size = New System.Drawing.Size(135, 22)
        Me.txtMen.TabIndex = 12
        '
        'txtMay
        '
        Me.txtMay.Location = New System.Drawing.Point(243, 259)
        Me.txtMay.Name = "txtMay"
        Me.txtMay.Size = New System.Drawing.Size(135, 22)
        Me.txtMay.TabIndex = 13
        '
        'gbTiempo
        '
        Me.gbTiempo.BackColor = System.Drawing.Color.Snow
        Me.gbTiempo.Controls.Add(Me.lblInt)
        Me.gbTiempo.Controls.Add(Me.lblIntercambios)
        Me.gbTiempo.Controls.Add(Me.lblCom)
        Me.gbTiempo.Controls.Add(Me.lblComparaciones)
        Me.gbTiempo.Controls.Add(Me.lblOrd)
        Me.gbTiempo.Controls.Add(Me.lblOrdenar)
        Me.gbTiempo.ForeColor = System.Drawing.Color.Brown
        Me.gbTiempo.Location = New System.Drawing.Point(23, 401)
        Me.gbTiempo.Name = "gbTiempo"
        Me.gbTiempo.Size = New System.Drawing.Size(406, 143)
        Me.gbTiempo.TabIndex = 14
        Me.gbTiempo.TabStop = False
        '
        'lblInt
        '
        Me.lblInt.AutoSize = True
        Me.lblInt.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.lblInt.ForeColor = System.Drawing.Color.Brown
        Me.lblInt.Location = New System.Drawing.Point(14, 18)
        Me.lblInt.Name = "lblInt"
        Me.lblInt.Size = New System.Drawing.Size(133, 22)
        Me.lblInt.TabIndex = 5
        Me.lblInt.Text = "Intercambios:"
        '
        'lblIntercambios
        '
        Me.lblIntercambios.AutoSize = True
        Me.lblIntercambios.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.lblIntercambios.ForeColor = System.Drawing.Color.Brown
        Me.lblIntercambios.Location = New System.Drawing.Point(161, 18)
        Me.lblIntercambios.Name = "lblIntercambios"
        Me.lblIntercambios.Size = New System.Drawing.Size(22, 22)
        Me.lblIntercambios.TabIndex = 4
        Me.lblIntercambios.Text = "0"
        '
        'lblCom
        '
        Me.lblCom.AutoSize = True
        Me.lblCom.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.lblCom.ForeColor = System.Drawing.Color.Brown
        Me.lblCom.Location = New System.Drawing.Point(14, 64)
        Me.lblCom.Name = "lblCom"
        Me.lblCom.Size = New System.Drawing.Size(155, 22)
        Me.lblCom.TabIndex = 3
        Me.lblCom.Text = "Comparaciones:"
        '
        'lblComparaciones
        '
        Me.lblComparaciones.AutoSize = True
        Me.lblComparaciones.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.lblComparaciones.ForeColor = System.Drawing.Color.Brown
        Me.lblComparaciones.Location = New System.Drawing.Point(188, 64)
        Me.lblComparaciones.Name = "lblComparaciones"
        Me.lblComparaciones.Size = New System.Drawing.Size(22, 22)
        Me.lblComparaciones.TabIndex = 2
        Me.lblComparaciones.Text = "0"
        '
        'lblOrd
        '
        Me.lblOrd.AutoSize = True
        Me.lblOrd.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.lblOrd.ForeColor = System.Drawing.Color.Brown
        Me.lblOrd.Location = New System.Drawing.Point(18, 110)
        Me.lblOrd.Name = "lblOrd"
        Me.lblOrd.Size = New System.Drawing.Size(90, 22)
        Me.lblOrd.TabIndex = 1
        Me.lblOrd.Text = "Ordenar:"
        '
        'lblOrdenar
        '
        Me.lblOrdenar.AutoSize = True
        Me.lblOrdenar.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.lblOrdenar.ForeColor = System.Drawing.Color.Brown
        Me.lblOrdenar.Location = New System.Drawing.Point(129, 110)
        Me.lblOrdenar.Name = "lblOrdenar"
        Me.lblOrdenar.Size = New System.Drawing.Size(40, 22)
        Me.lblOrdenar.TabIndex = 0
        Me.lblOrdenar.Text = "0:0"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlgoritmosToolStripMenuItem, Me.EstructurasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(875, 30)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AlgoritmosToolStripMenuItem
        '
        Me.AlgoritmosToolStripMenuItem.Name = "AlgoritmosToolStripMenuItem"
        Me.AlgoritmosToolStripMenuItem.Size = New System.Drawing.Size(98, 26)
        Me.AlgoritmosToolStripMenuItem.Text = "Algoritmos"
        '
        'EstructurasToolStripMenuItem
        '
        Me.EstructurasToolStripMenuItem.Name = "EstructurasToolStripMenuItem"
        Me.EstructurasToolStripMenuItem.Size = New System.Drawing.Size(98, 26)
        Me.EstructurasToolStripMenuItem.Text = "Estructuras"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(53, 26)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'lbNum
        '
        Me.lbNum.FormattingEnabled = True
        Me.lbNum.ItemHeight = 16
        Me.lbNum.Location = New System.Drawing.Point(487, 161)
        Me.lbNum.Name = "lbNum"
        Me.lbNum.Size = New System.Drawing.Size(110, 340)
        Me.lbNum.TabIndex = 6
        '
        'lbOrd
        '
        Me.lbOrd.FormattingEnabled = True
        Me.lbOrd.ItemHeight = 16
        Me.lbOrd.Location = New System.Drawing.Point(647, 161)
        Me.lbOrd.Name = "lbOrd"
        Me.lbOrd.Size = New System.Drawing.Size(110, 340)
        Me.lbOrd.TabIndex = 7
        '
        'Burbuja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(875, 578)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbNum)
        Me.Controls.Add(Me.lbOrd)
        Me.Controls.Add(Me.gbTiempo)
        Me.Controls.Add(Me.txtMay)
        Me.Controls.Add(Me.txtMen)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.btnOrdenar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblTNum)
        Me.Controls.Add(Me.lblRMen)
        Me.Controls.Add(Me.lblRMay)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Burbuja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Burbuja"
        Me.gbTiempo.ResumeLayout(False)
        Me.gbTiempo.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRMay As Label
    Friend WithEvents lblRMen As Label
    Friend WithEvents lblTNum As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnCrear As Button
    Friend WithEvents btnOrdenar As Button
    Friend WithEvents txtNum As TextBox
    Friend WithEvents txtMen As TextBox
    Friend WithEvents txtMay As TextBox
    Friend WithEvents gbTiempo As GroupBox
    Friend WithEvents lblInt As Label
    Friend WithEvents lblIntercambios As Label
    Friend WithEvents lblCom As Label
    Friend WithEvents lblComparaciones As Label
    Friend WithEvents lblOrd As Label
    Friend WithEvents lblOrdenar As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AlgoritmosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstructurasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbNum As ListBox
    Friend WithEvents lbOrd As ListBox
End Class
