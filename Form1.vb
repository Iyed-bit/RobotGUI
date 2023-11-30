Public Class Form1


    Dim r As New Robot(10, 10, 2)

    Private Sub TournerBt_Click(sender As Object, e As EventArgs) Handles TournerBt.Click
        r.TournerADroite()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Avancer_Click(sender As Object, e As EventArgs) Handles Avancer.Click
        r.Avancer()
    End Sub

End Class
