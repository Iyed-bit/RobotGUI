Public Class Form1


    Dim r As New Robot(10, 10, 2)

    Private Sub TournerBt_Click(sender As Object, e As EventArgs) Handles TournerBt.Click
        r.TournerADroite()
        r.Afficher(RobotData)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        r.Afficher(RobotData)
    End Sub

    Private Sub Avancer_Click(sender As Object, e As EventArgs) Handles Avancer.Click
        r.Avancer()
        r.Afficher(RobotData)
    End Sub


End Class
