Imports System.Diagnostics
Public Class BurbujaBidireccional
    Dim vector As Integer()
    Dim n As Integer
    Dim min As Integer
    Dim max As Integer
    Dim i As Integer
    Dim contador As Stopwatch = New Stopwatch()

    Public Sub GenerarDatos(ByVal n As Integer, ByVal min As Integer, ByVal max As Integer)
        vector = New Integer(n - 1) {}
        Dim aleatorio As Random = New Random()
        For i = 0 To vector.Length - 1
            vector(i) = aleatorio.[Next](min, max)
        Next
    End Sub

    'arreglar error en el metodo
    Public Sub Metodo(ByVal n)
        Dim der As Integer = vector.Length - 1
        Dim izq As Integer = 0
        Dim ultimo As Integer = 0
        Dim aux As Integer
        Dim comparaciones As Integer = 0
        Dim intercambios As Integer = 0

        Do
            For i As Integer = izq To der - 1
                comparaciones += 1
                If vector(i) > vector(i + 1) Then
                    aux = vector(i)
                    vector(i) = vector(i + 1)
                    vector(i + 1) = aux
                    ultimo = i
                    intercambios += 1
                End If
            Next
            der = ultimo

            For j As Integer = der To izq + 1
                comparaciones += 1
                If vector(j - 1) > vector(j) Then
                    aux = vector(j)
                    vector(j) = vector(j - 1)
                    vector(j - 1) = aux
                    ultimo = j
                    intercambios += 1
                End If
            Next
            izq = ultimo

        Loop While izq < der

        lblComparaciones.Text = comparaciones.ToString() & " Comparaciones"
        lblIntercambios.Text = intercambios.ToString() & " Intercambios"
        Return
    End Sub

    Public Sub Mostrar(ByVal l As ListBox)
        For i = 0 To vector.Length - 1
            l.Items.Add(vector(i))
        Next
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Try
            lbNum.Items.Clear()
            lbOrd.Items.Clear()
            n = Integer.Parse(txtNum.Text)
            min = Integer.Parse(txtMin.Text)
            max = Integer.Parse(txtMax.Text)
            GenerarDatos(n, min, max)
            Mostrar(lbNum)
            btnGenerar.Enabled = False
            btnOrdenar.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Introduzca un numero valido")
        End Try
    End Sub

    Private Sub btnOrdenar_Click(sender As Object, e As EventArgs) Handles btnOrdenar.Click
        contador.Restart()
        Metodo(n)
        contador.Stop()
        lblOrdenar.Text = contador.Elapsed.TotalMilliseconds.ToString() & " Milisegundos"
        Mostrar(lbOrd)
        btnGenerar.Enabled = True
        btnOrdenar.Enabled = False
    End Sub

    Private Sub AlgoritmosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlgoritmosToolStripMenuItem.Click
        Dim paransaek As MenuAlgoritmos = New MenuAlgoritmos()
        paransaek.Show()
        Me.Close()
    End Sub

    Private Sub EstructurasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstructurasToolStripMenuItem.Click
        Dim ppalgansaek As MenuEstructuras = New MenuEstructuras()
        ppalgansaek.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class