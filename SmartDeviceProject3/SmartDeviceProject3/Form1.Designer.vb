<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label0 = New System.Windows.Forms.Label
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label0
        '
        Me.Label0.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
        Me.Label0.Location = New System.Drawing.Point(3, 9)
        Me.Label0.Name = "Label0"
        Me.Label0.Size = New System.Drawing.Size(141, 20)
        Me.Label0.Text = "Choose Your Move"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(3, 32)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(53, 20)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.Text = "Rock"
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(3, 58)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(70, 20)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.Text = "Paper"
        '
        'RadioButton3
        '
        Me.RadioButton3.Location = New System.Drawing.Point(3, 84)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(70, 20)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.Text = "Scissors"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(88, 234)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 30)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Go!"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 31)
        Me.Label1.Text = "            "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 294)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label0)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Rock! Paper! Scissors!"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label0 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
