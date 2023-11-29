Imports Microsoft.VisualBasic

Public Class Robot
    Private _x As Integer
    Private _y As Integer
    Private _orientation As Integer

    Public Sub New(_x As Integer, _y As Integer, _orientation As Integer)
        Me._x = _x
        Me._y = _y
        Me._orientation = _orientation
    End Sub
    Public Property X As Integer
        Get
            Return _x
        End Get
        Set(value As Integer)
            _x = value
        End Set
    End Property

    Public Property Y As Integer
        Get
            Return _y
        End Get
        Set(value As Integer)
            _y = value
        End Set
    End Property

    Public Property Orientation As Integer
        Get
            Return _orientation
        End Get
        Set(value As Integer)
            If value > 0 AndAlso value < 5 Then
                _orientation = value
            Else
                _orientation = 1
            End If
        End Set
    End Property

    Public Sub Avancer()
        If _orientation = 1 Then
            _y += 1
        ElseIf _orientation = 2 Then
            _x += 1
        ElseIf _orientation = 3 Then
            _y -= 1
        Else
            _x -= 1
        End If
    End Sub

    Public Sub TournerADroite()
        _orientation += 1
        If _orientation > 4 Then
            _orientation = 1
        End If
    End Sub

    Public Sub Afficher(o As TextBox)
        Dim s As String = "Position:" & vbCrLf & "x: " & X & " | y: " & Y & vbCrLf & "Orientation: " & Orientation
        o.Text = s
    End Sub

    Public Overrides Function ToString() As String
        Return "Hello, I'm A Robot!"
    End Function


End Class
