﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        minusLeftLabel = New Label()
        Label4 = New Label()
        minusRightLabel = New Label()
        Label5 = New Label()
        difference = New NumericUpDown()
        timesLeftLabel = New Label()
        Label7 = New Label()
        timesRightLabel = New Label()
        Label9 = New Label()
        product = New NumericUpDown()
        dividedLeftLabel = New Label()
        Label8 = New Label()
        dividedRightLabel = New Label()
        Label11 = New Label()
        quotient = New NumericUpDown()
        startButton = New Button()
        CType(sum, ComponentModel.ISupportInitialize).BeginInit()
        CType(difference, ComponentModel.ISupportInitialize).BeginInit()
        CType(product, ComponentModel.ISupportInitialize).BeginInit()
        CType(quotient, ComponentModel.ISupportInitialize).BeginInit()
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
        sum.TabIndex = 1
        ' 
        ' minusLeftLabel
        ' 
        minusLeftLabel.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        minusLeftLabel.Location = New Point(50, 125)
        minusLeftLabel.Name = "minusLeftLabel"
        minusLeftLabel.Size = New Size(60, 50)
        minusLeftLabel.TabIndex = 7
        minusLeftLabel.Text = "?"
        minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(116, 125)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 50)
        Label4.TabIndex = 8
        Label4.Text = "-"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' minusRightLabel
        ' 
        minusRightLabel.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        minusRightLabel.Location = New Point(182, 125)
        minusRightLabel.Name = "minusRightLabel"
        minusRightLabel.Size = New Size(60, 50)
        minusRightLabel.TabIndex = 9
        minusRightLabel.Text = "?"
        minusRightLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(248, 125)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 50)
        Label5.TabIndex = 10
        Label5.Text = "="
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' difference
        ' 
        difference.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        difference.Location = New Point(314, 131)
        difference.Name = "difference"
        difference.Size = New Size(100, 47)
        difference.TabIndex = 2
        ' 
        ' timesLeftLabel
        ' 
        timesLeftLabel.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        timesLeftLabel.Location = New Point(50, 175)
        timesLeftLabel.Name = "timesLeftLabel"
        timesLeftLabel.Size = New Size(60, 50)
        timesLeftLabel.TabIndex = 12
        timesLeftLabel.Text = "?"
        timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(116, 175)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 50)
        Label7.TabIndex = 13
        Label7.Text = "×"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' timesRightLabel
        ' 
        timesRightLabel.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        timesRightLabel.Location = New Point(182, 175)
        timesRightLabel.Name = "timesRightLabel"
        timesRightLabel.Size = New Size(60, 50)
        timesRightLabel.TabIndex = 14
        timesRightLabel.Text = "?"
        timesRightLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(248, 175)
        Label9.Name = "Label9"
        Label9.Size = New Size(60, 50)
        Label9.TabIndex = 15
        Label9.Text = "="
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' product
        ' 
        product.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        product.Location = New Point(314, 184)
        product.Name = "product"
        product.Size = New Size(100, 47)
        product.TabIndex = 3
        ' 
        ' dividedLeftLabel
        ' 
        dividedLeftLabel.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        dividedLeftLabel.Location = New Point(50, 225)
        dividedLeftLabel.Name = "dividedLeftLabel"
        dividedLeftLabel.Size = New Size(60, 50)
        dividedLeftLabel.TabIndex = 17
        dividedLeftLabel.Text = "?"
        dividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(116, 225)
        Label8.Name = "Label8"
        Label8.Size = New Size(60, 50)
        Label8.TabIndex = 18
        Label8.Text = "÷"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dividedRightLabel
        ' 
        dividedRightLabel.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        dividedRightLabel.Location = New Point(182, 225)
        dividedRightLabel.Name = "dividedRightLabel"
        dividedRightLabel.Size = New Size(60, 50)
        dividedRightLabel.TabIndex = 19
        dividedRightLabel.Text = "?"
        dividedRightLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label11
        ' 
        Label11.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(248, 225)
        Label11.Name = "Label11"
        Label11.Size = New Size(60, 50)
        Label11.TabIndex = 20
        Label11.Text = "="
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' quotient
        ' 
        quotient.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        quotient.Location = New Point(314, 237)
        quotient.Name = "quotient"
        quotient.Size = New Size(100, 47)
        quotient.TabIndex = 4
        ' 
        ' startButton
        ' 
        startButton.AutoSize = True
        startButton.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        startButton.Location = New Point(147, 299)
        startButton.Name = "startButton"
        startButton.Size = New Size(128, 42)
        startButton.TabIndex = 0
        startButton.Text = "Start Quiz"
        startButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(482, 353)
        Controls.Add(startButton)
        Controls.Add(quotient)
        Controls.Add(Label11)
        Controls.Add(dividedRightLabel)
        Controls.Add(Label8)
        Controls.Add(dividedLeftLabel)
        Controls.Add(product)
        Controls.Add(Label9)
        Controls.Add(timesRightLabel)
        Controls.Add(Label7)
        Controls.Add(timesLeftLabel)
        Controls.Add(difference)
        Controls.Add(Label5)
        Controls.Add(minusRightLabel)
        Controls.Add(Label4)
        Controls.Add(minusLeftLabel)
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
        CType(difference, ComponentModel.ISupportInitialize).EndInit()
        CType(product, ComponentModel.ISupportInitialize).EndInit()
        CType(quotient, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents minusLeftLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents minusRightLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents difference As NumericUpDown
    Friend WithEvents timesLeftLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents timesRightLabel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents product As NumericUpDown
    Friend WithEvents dividedLeftLabel As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dividedRightLabel As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents quotient As NumericUpDown
    Friend WithEvents startButton As Button
End Class
