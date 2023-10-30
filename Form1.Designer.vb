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
        plusLeftLabel = New Label()
        Label2 = New Label()
        plusRightLabel = New Label()
        Label3 = New Label()
        sum = New NumericUpDown()
        CType(sum, ComponentModel.ISupportInitialize).BeginInit()
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
        ' plusLeftLabel
        ' 
        plusLeftLabel.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        plusLeftLabel.Location = New Point(50, 75)
        plusLeftLabel.Name = "plusLeftLabel"
        plusLeftLabel.Size = New Size(60, 50)
        plusLeftLabel.TabIndex = 2
        plusLeftLabel.Text = "?"
        plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(116, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 50)
        Label2.TabIndex = 3
        Label2.Text = "+"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' plusRightLabel
        ' 
        plusRightLabel.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        plusRightLabel.Location = New Point(182, 75)
        plusRightLabel.Name = "plusRightLabel"
        plusRightLabel.Size = New Size(60, 50)
        plusRightLabel.TabIndex = 4
        plusRightLabel.Text = "?"
        plusRightLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(248, 75)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 50)
        Label3.TabIndex = 5
        Label3.Text = "="
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' sum
        ' 
        sum.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        sum.Location = New Point(314, 78)
        sum.Name = "sum"
        sum.Size = New Size(100, 47)
        sum.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(482, 353)
        Controls.Add(sum)
        Controls.Add(Label3)
        Controls.Add(plusRightLabel)
        Controls.Add(Label2)
        Controls.Add(plusLeftLabel)
        Controls.Add(Label1)
        Controls.Add(timeLabel)
        Name = "Form1"
        Text = "Math Quiz"
        CType(sum, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents timeLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents plusLeftLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents plusRightLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents sum As NumericUpDown
End Class
