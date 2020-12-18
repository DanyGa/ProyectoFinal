Public Class Menu
    Private Sub btnAlgoritmo_Click(sender As Object, e As EventArgs) Handles btnAlgoritmo.Click
        Dim abrir As MenuAlgoritmos = New MenuAlgoritmos()
        abrir.Show()
    End Sub

    Private Sub btnEstructura_Click(sender As Object, e As EventArgs) Handles btnEstructura.Click
        Dim aperto As MenuEstructuras = New MenuEstructuras()
        aperto.Show()
    End Sub
End Class
