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
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TournerBt
        ' 
        TournerBt.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        TournerBt.Location = New Point(92, 66)
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
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Cat03
        PictureBox1.Location = New Point(227, 187)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(84, 97)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(541, 449)
        Controls.Add(PictureBox1)
        Controls.Add(Avancer)
        Controls.Add(TournerBt)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TournerBt As Button
    Friend WithEvents Avancer As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
