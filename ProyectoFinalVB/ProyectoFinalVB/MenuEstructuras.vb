Public Class MenuEstructuras
    Private Sub btnListas_Click(sender As Object, e As EventArgs) Handles btnListas.Click
        Dim hana As Listas = New Listas()
        hana.Show()
        Me.Close()
    End Sub

    Private Sub btnPila_Click(sender As Object, e As EventArgs) Handles btnPila.Click
        Dim dul As Pilas = New Pilas()
        dul.Show()
        Me.Close()
    End Sub

    Private Sub btnCola_Click(sender As Object, e As EventArgs) Handles btnCola.Click
        Dim tres As Colas = New Colas()
        tres.Show()
        Me.Close()
    End Sub

    Private Sub btnGrafo_Click(sender As Object, e As EventArgs) Handles btnGrafo.Click
        Dim net As Grafos = New Grafos()
        net.Show()
        Me.Close()
    End Sub

    Private Sub btnArbol_Click(sender As Object, e As EventArgs) Handles btnArbol.Click
        Dim daseot As Arboles = New Arboles()
        daseot.Show()
        Me.Close()
    End Sub
End Class