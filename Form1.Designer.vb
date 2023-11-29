<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TournerBt = New Button()
        Avancer = New Button()
        RobotData = New TextBox()
        Label = New Label()
        SuspendLayout()
        ' 
        ' TournerBt
        ' 
        TournerBt.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        TournerBt.Location = New Point(89, 66)
        TournerBt.Name = "TournerBt"
        TournerBt.Size = New Size(138, 54)
        TournerBt.TabIndex = 0
        TournerBt.Text = "Tourner A Droite"
        TournerBt.UseVisualStyleBackColor = True
        ' 
        ' Avancer
        ' 
        Avancer.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Avancer.Location = New Point(304, 66)
        Avancer.Name = "Avancer"
        Avancer.Size = New Size(138, 54)
        Avancer.TabIndex = 1
        Avancer.Text = "Avancer"
        Avancer.UseVisualStyleBackColor = True
        ' 
        ' RobotData
        ' 
        RobotData.Location = New Point(89, 212)
        RobotData.Multiline = True
        RobotData.Name = "RobotData"
        RobotData.Size = New Size(353, 152)
        RobotData.TabIndex = 2
        ' 
        ' Label
        ' 
        Label.AutoSize = True
        Label.Font = New Font("Segoe UI Symbol", 25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label.Location = New Point(160, 163)
        Label.Name = "Label"
        Label.Size = New Size(201, 46)
        Label.TabIndex = 3
        Label.Text = "Robot Data"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(541, 449)
        Controls.Add(Label)
        Controls.Add(RobotData)
        Controls.Add(Avancer)
        Controls.Add(TournerBt)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TournerBt As Button
    Friend WithEvents Avancer As Button
    Friend WithEvents RobotData As TextBox
    Friend WithEvents Label As Label
End Class
