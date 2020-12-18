Imports System.Diagnostics

Public Class Burbuja
    Dim n As Integer
    Dim may As Integer
    Dim men As Integer
    Dim i As Integer
    Dim lista As Integer()
    Dim contador As Stopwatch = New Stopwatch()

    Public Sub Agregar(ByVal n As Integer, ByVal men As Integer, ByVal may As Integer)
        lista = New Integer(n - 1) {}
        Dim aleatorio As Random = New Random()
        For i = 0 To lista.Length - 1
            lista(i) = aleatorio.[Next](men, may)
        Next
    End Sub

    Public Sub Mostrar(ByVal l As ListBox)
        For i = 0 To lista.Length - 1
            l.Items.Add(lista(i))
        Next
    End Sub

    Public Sub Ordenar(ByVal n)
        Dim aux As Integer
        Dim comparaciones As Integer = 0
        Dim intercambios As Integer = 0
        For i = 1 To lista.Length - 1
            For j As Integer = 0 To lista.Length - 1 - 1
                comparaciones += 1
                If lista(j) > lista(j + 1) Then
                    aux = lista(j)
                    lista(j) = lista(j + 1)
                    lista(j + 1) = aux
                    intercambios += 1
                End If

            Next
        Next
        lblComparaciones.Text = comparaciones.ToString() & " Comparaciones"
        lblIntercambios.Text = intercambios.ToString() & " Intercambios"
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Try
            lbNum.Items.Clear()
            lbOrd.Items.Clear()
            n = Integer.Parse(txtNum.Text)
            men = Integer.Parse(txtMen.Text)
            may = Integer.Parse(txtMay.Text)
            Agregar(n, men, may)
            Mostrar(lbNum)
            btnCrear.Enabled = False
            btnOrdenar.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Introduzca un numero valido")
        End Try
    End Sub

    Private Sub btnOrdenar_Click(sender As Object, e As EventArgs) Handles btnOrdenar.Click
        contador.Restart()
        Ordenar(n)
        contador.Stop()
        lblOrdenar.Text = contador.Elapsed.TotalMilliseconds.ToString() & " Milisegundos"
        Mostrar(lbOrd)
        btnCrear.Enabled = True
        btnOrdenar.Enabled = False
    End Sub

    Private Sub AlgoritmosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlgoritmosToolStripMenuItem.Click
        Dim boonhongsaek As MenuAlgoritmos = New MenuAlgoritmos()
        boonhongsaek.Show()
        Me.Close()
    End Sub

    Private Sub EstructurasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstructurasToolStripMenuItem.Click
        Dim galsaek As MenuEstructuras = New MenuEstructuras()
        galsaek.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class