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
        timeLabel = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' timeLabel
        ' 
        timeLabel.BorderStyle = BorderStyle.FixedSingle
        timeLabel.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        timeLabel.Location = New Point(270, 8)
        timeLabel.Name = "timeLabel"
        timeLabel.Size = New Size(200, 30)
        timeLabel.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(147, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 35)
        Label1.TabIndex = 1
        Label1.Text = "Time Left"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(482, 353)
        Controls.Add(Label1)
        Controls.Add(timeLabel)
        Name = "Form1"
        Text = "Math Quiz"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents timeLabel As Label
    Friend WithEvents Label1 As Label
End Class
