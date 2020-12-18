<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BurbujaBidireccional
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BurbujaBidireccional))
        Me.lblNum = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.btnOrdenar = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.lbNum = New System.Windows.Forms.ListBox()
        Me.lbOrd = New System.Windows.Forms.ListBox()
        Me.gbTiempo = New System.Windows.Forms.GroupBox()
        Me.lblIntercambios = New System.Windows.Forms.Label()
        Me.lblOrd = New System.Windows.Forms.Label()
        Me.lblOrdenar = New System.Windows.Forms.Label()
        Me.lblCom = New System.Windows.Forms.Label()
        Me.lblComparaciones = New System.Windows.Forms.Label()
        Me.lblInt = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AlgoritmosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstructurasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbTiempo.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.BackColor = System.Drawing.Color.Snow
        Me.lblNum.Font = New System.Drawing.Font("Britannic Bold", 13.8!)
        Me.lblNum.ForeColor = System.Drawing.Color.DarkRed
        Me.lblNum.Location = New System.Drawing.Point(62, 161)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(113, 27)
        Me.lblNum.TabIndex = 0
        Me.lblNum.Text = "Numeros:"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.BackColor = System.Drawing.Color.Snow
        Me.lblMin.Font = New System.Drawing.Font("Britannic Bold", 13.8!)
        Me.lblMin.ForeColor = System.Drawing.Color.DarkRed
        Me.lblMin.Location = New System.Drawing.Point(62, 207)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(171, 27)
        Me.lblMin.TabIndex = 1
        Me.lblMin.Text = "Limite Minimo:"
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.BackColor = System.Drawing.Color.Snow
        Me.lblMax.Font = New System.Drawing.Font("Britannic Bold", 13.8!)
        Me.lblMax.ForeColor = System.Drawing.Color.DarkRed
        Me.lblMax.Location = New System.Drawing.Point(62, 254)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(174, 27)
        Me.lblMax.TabIndex = 2
        Me.lblMax.Text = "Limite Maximo:"
        '
        'txtMax
        '
        Me.txtMax.Location = New System.Drawing.Point(262, 259)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(116, 22)
        Me.txtMax.TabIndex = 3
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(262, 212)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(116, 22)
        Me.txtMin.TabIndex = 4
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(197, 166)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(181, 22)
        Me.txtNum.TabIndex = 5
        '
        'btnOrdenar
        '
        Me.btnOrdenar.BackColor = System.Drawing.Color.Snow
        Me.btnOrdenar.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnOrdenar.ForeColor = System.Drawing.Color.DarkRed
        Me.btnOrdenar.Location = New System.Drawing.Point(242, 316)
        Me.btnOrdenar.Name = "btnOrdenar"
        Me.btnOrdenar.Size = New System.Drawing.Size(136, 53)
        Me.btnOrdenar.TabIndex = 6
        Me.btnOrdenar.Text = "Ordenar"
        Me.btnOrdenar.UseVisualStyleBackColor = False
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.Snow
        Me.btnGenerar.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnGenerar.ForeColor = System.Drawing.Color.DarkRed
        Me.btnGenerar.Location = New System.Drawing.Point(66, 316)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(136, 53)
        Me.btnGenerar.TabIndex = 7
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'lbNum
        '
        Me.lbNum.FormattingEnabled = True
        Me.lbNum.ItemHeight = 16
        Me.lbNum.Location = New System.Drawing.Point(487, 161)
        Me.lbNum.Name = "lbNum"
        Me.lbNum.Size = New System.Drawing.Size(110, 340)
        Me.lbNum.TabIndex = 8
        '
        'lbOrd
        '
        Me.lbOrd.FormattingEnabled = True
        Me.lbOrd.ItemHeight = 16
        Me.lbOrd.Location = New System.Drawing.Point(647, 161)
        Me.lbOrd.Name = "lbOrd"
        Me.lbOrd.Size = New System.Drawing.Size(110, 340)
        Me.lbOrd.TabIndex = 9
        '
        'gbTiempo
        '
        Me.gbTiempo.BackColor = System.Drawing.Color.Snow
        Me.gbTiempo.Controls.Add(Me.lblIntercambios)
        Me.gbTiempo.Controls.Add(Me.lblOrd)
        Me.gbTiempo.Controls.Add(Me.lblOrdenar)
        Me.gbTiempo.Controls.Add(Me.lblCom)
        Me.gbTiempo.Controls.Add(Me.lblComparaciones)
        Me.gbTiempo.Controls.Add(Me.lblInt)
        Me.gbTiempo.Location = New System.Drawing.Point(23, 401)
        Me.gbTiempo.Name = "gbTiempo"
        Me.gbTiempo.Size = New System.Drawing.Size(406, 143)
        Me.gbTiempo.TabIndex = 10
        Me.gbTiempo.TabStop = False
        '
        'lblIntercambios
        '
        Me.lblIntercambios.AutoSize = True
        Me.lblIntercambios.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.lblIntercambios.ForeColor = System.Drawing.Color.DarkRed
        Me.lblIntercambios.Location = New System.Drawing.Point(161, 18)
        Me.lblIntercambios.Name = "lblIntercambios"
        Me.lblIntercambios.Size = New System.Drawing.Size(22, 22)
        Me.lblIntercambios.TabIndex = 5
        Me.lblIntercambios.Text = "0"
        '
        'lblOrd
        '
        Me.lblOrd.AutoSize = True
        Me.lblOrd.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.lblOrd.ForeColor = System.Drawing.Color.DarkRed
        Me.lblOrd.Location = New System.Drawing.Point(18, 110)
        Me.lblOrd.Name = "lblOrd"
        Me.lblOrd.Size = New System.Drawing.Size(90, 22)
        Me.lblOrd.TabIndex = 4
        Me.lblOrd.Text = "Ordenar:"
        '
        'lblOrdenar
        '
        Me.lblOrdenar.AutoSize = True
        Me.lblOrdenar.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.lblOrdenar.ForeColor = System.Drawing.Color.DarkRed
        Me.lblOrdenar.Location = New System.Drawing.Point(129, 110)
        Me.lblOrdenar.Name = "lblOrdenar"
        Me.lblOrdenar.Size = New System.Drawing.Size(40, 22)
        Me.lblOrdenar.TabIndex = 3
        Me.lblOrdenar.Text = "0:0"
        '
        'lblCom
        '
        Me.lblCom.AutoSize = True
        Me.lblCom.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.lblCom.ForeColor = System.Drawing.Color.DarkRed
        Me.lblCom.Location = New System.Drawing.Point(14, 64)
        Me.lblCom.Name = "lblCom"
        Me.lblCom.Size = New System.Drawing.Size(155, 22)
        Me.lblCom.TabIndex = 2
        Me.lblCom.Text = "Comparaciones:"
        '
        'lblComparaciones
        '
        Me.lblComparaciones.AutoSize = True
        Me.lblComparaciones.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.lblComparaciones.ForeColor = System.Drawing.Color.DarkRed
        Me.lblComparaciones.Location = New System.Drawing.Point(188, 64)
        Me.lblComparaciones.Name = "lblComparaciones"
        Me.lblComparaciones.Size = New System.Drawing.Size(22, 22)
        Me.lblComparaciones.TabIndex = 1
        Me.lblComparaciones.Text = "0"
        '
        'lblInt
        '
        Me.lblInt.AutoSize = True
        Me.lblInt.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.lblInt.ForeColor = System.Drawing.Color.DarkRed
        Me.lblInt.Location = New System.Drawing.Point(14, 18)
        Me.lblInt.Name = "lblInt"
        Me.lblInt.Size = New System.Drawing.Size(133, 22)
        Me.lblInt.TabIndex = 0
        Me.lblInt.Text = "Intercambios:"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Snow
        Me.lblTitulo.Font = New System.Drawing.Font("Elephant", 22.2!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTitulo.Location = New System.Drawing.Point(57, 72)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(785, 49)
        Me.lblTitulo.TabIndex = 5
        Me.lblTitulo.Text = "Ordenamiento de Burbuja Bidireccional"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlgoritmosToolStripMenuItem, Me.EstructurasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(875, 28)
        Me.MenuStrip1.TabIndex = 11
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
        'BurbujaBidireccional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(875, 578)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.gbTiempo)
        Me.Controls.Add(Me.lbOrd)
        Me.Controls.Add(Me.lbNum)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.btnOrdenar)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.txtMax)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "BurbujaBidireccional"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Burbuja Bidireccional"
        Me.gbTiempo.ResumeLayout(False)
        Me.gbTiempo.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNum As Label
    Friend WithEvents lblMin As Label
    Friend WithEvents lblMax As Label
    Friend WithEvents txtMax As TextBox
    Friend WithEvents txtMin As TextBox
    Friend WithEvents txtNum As TextBox
    Friend WithEvents btnOrdenar As Button
    Friend WithEvents btnGenerar As Button
    Friend WithEvents lbNum As ListBox
    Friend WithEvents lbOrd As ListBox
    Friend WithEvents gbTiempo As GroupBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblOrd As Label
    Friend WithEvents lblOrdenar As Label
    Friend WithEvents lblCom As Label
    Friend WithEvents lblComparaciones As Label
    Friend WithEvents lblInt As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AlgoritmosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstructurasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblIntercambios As Label
End Class
