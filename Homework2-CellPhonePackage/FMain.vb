




Public Class FMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnIndividual_Click(sender As Object, e As EventArgs) Handles btnIndividual.Click

        Dim clsIndividual As New FIndividual
        clsIndividual.ShowDialog()

    End Sub

    Private Sub btnFamily_Click(sender As Object, e As EventArgs) Handles btnFamily.Click

        Dim clsFamily As New FFamily
        clsFamily.ShowDialog()

    End Sub

End Class
