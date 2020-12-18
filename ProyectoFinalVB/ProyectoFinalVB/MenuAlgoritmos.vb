Public Class MenuAlgoritmos
    Private Sub btnBurbuja_Click(sender As Object, e As EventArgs) Handles btnBurbuja.Click
        Dim il As Burbuja = New Burbuja()
        il.Show()
        Me.Close()
    End Sub

    Private Sub btnBurbujaB_Click(sender As Object, e As EventArgs) Handles btnBurbujaB.Click
        Dim i As BurbujaBidireccional = New BurbujaBidireccional()
        i.Show()
        Me.Close()
    End Sub

    Private Sub btnCuentas_Click(sender As Object, e As EventArgs) Handles btnCuentas.Click
        Dim sam As Cuentas = New Cuentas()
        sam.Show()
        Me.Close()
    End Sub
End Class