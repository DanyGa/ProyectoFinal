Imports System.Diagnostics
Public Class Cuentas
    Dim r As Random = New Random()
    Dim valorMayor As Integer = 0
    Dim arregloInicial As Integer()
    Dim arregloAuxiliar As Integer()
    Dim arregloOrdenado As Integer()
    Dim stopWatch As Stopwatch = New Stopwatch()

    Public Function ImprimirArreglo(ByVal arreglo As Integer())
        Dim colaString As String = ""
        colaString += arreglo(0)

        For i As Integer = 0 To arreglo.Length - 1 - 1
            colaString += "," & arreglo(i + 1)
        Next

        Return colaString
    End Function

    'error en el metodo
    Public Sub OrdenarEInvertir(ByVal tamaño As Integer, ByVal minimo As Integer, ByVal maximo As Integer)
        stopWatch.Start()
        arregloInicial = New Integer(tamaño - 1) {}
        For i As Integer = 0 To arregloInicial.Length - 1
            arregloInicial(i) = r.[Next](minimo, maximo)
        Next
        lblOriginal.Text = ImprimirArreglo(arregloInicial)

        For i As Integer = 0 To arregloInicial.Length - 1

            If arregloInicial(i) > valorMayor Then
                valorMayor = arregloInicial(i)
            End If
        Next
        arregloAuxiliar = New Integer(valorMayor + 1 - 1) {}

        For i As Integer = 0 To arregloInicial.Length - 1
            Dim posicion As Integer = arregloInicial(i)
            arregloAuxiliar(posicion) += 1
        Next

        For i As Integer = 1 To arregloAuxiliar.Length - 1
            arregloAuxiliar(i) = arregloAuxiliar(i - 1) + arregloAuxiliar(i)
        Next

        Dim i As Integer = arregloAuxiliar.Length - 1

        While i <> 0
            arregloAuxiliar(i) = arregloAuxiliar(i - 1)
            i -= 1
        End While

        arregloAuxiliar(0) = 0
        arregloOrdenado = New Integer(arregloInicial.Length - 1) {}

        For i As Integer = 0 To arregloInicial.Length - 1
            Dim valor As Integer = arregloInicial(i)
            Dim posicion As Integer = arregloAuxiliar(valor)
            arregloOrdenado(posicion) = valor
            arregloAuxiliar(valor) += 1
        Next

        lblOrdenado.Text = ImprimirArreglo(arregloOrdenado)
        Array.Reverse(arregloOrdenado)
        lblInvertido.Text = ImprimirArreglo(arregloOrdenado)
        stopWatch.Stop()
        Dim ts As TimeSpan = stopWatch.Elapsed
        lblTiempo.Text = ts.ToString

    End Sub

    Private Sub btnCrearArreglo_Click(sender As Object, e As EventArgs) Handles btnCrearArreglo.Click

    End Sub

    Private Sub btnAleatorio_Click(sender As Object, e As EventArgs) Handles btnAleatorio.Click
        Dim tamaño As Integer = r.Next(3, 20)
        Dim minimo As Integer = r.Next(0, 25)
        Dim maximo As Integer = r.Next(minimo, 25)
        OrdenarEInvertir(tamaño, minimo, maximo,)
        GroupBox1.Visible = True
    End Sub

    Private Sub AlgoritmosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlgoritmosToolStripMenuItem.Click
        Dim geumsaek As MenuAlgoritmos = New MenuAlgoritmos()
        geumsaek.Show()
        Me.Close()
    End Sub

    Private Sub EstructurasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstructurasToolStripMenuItem.Click
        Dim eunsaek As MenuEstructuras = New MenuEstructuras()
        eunsaek.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class