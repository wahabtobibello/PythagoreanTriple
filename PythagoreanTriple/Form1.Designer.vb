<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mTbx = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nTbx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.side2Tbx = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.hypoTbx = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.side1Tbx = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(185, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "M"
        '
        'mTbx
        '
        Me.mTbx.Location = New System.Drawing.Point(209, 84)
        Me.mTbx.Name = "mTbx"
        Me.mTbx.Size = New System.Drawing.Size(100, 23)
        Me.mTbx.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "N"
        '
        'nTbx
        '
        Me.nTbx.Location = New System.Drawing.Point(209, 138)
        Me.nTbx.Name = "nTbx"
        Me.nTbx.Size = New System.Drawing.Size(100, 23)
        Me.nTbx.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(165, 322)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Side 2"
        '
        'side2Tbx
        '
        Me.side2Tbx.Enabled = False
        Me.side2Tbx.Location = New System.Drawing.Point(209, 319)
        Me.side2Tbx.Name = "side2Tbx"
        Me.side2Tbx.Size = New System.Drawing.Size(100, 23)
        Me.side2Tbx.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(125, 370)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Hypothenuse"
        '
        'hypoTbx
        '
        Me.hypoTbx.Enabled = False
        Me.hypoTbx.Location = New System.Drawing.Point(209, 367)
        Me.hypoTbx.Name = "hypoTbx"
        Me.hypoTbx.Size = New System.Drawing.Size(100, 23)
        Me.hypoTbx.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(165, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Side 1"
        '
        'side1Tbx
        '
        Me.side1Tbx.Enabled = False
        Me.side1Tbx.Location = New System.Drawing.Point(209, 271)
        Me.side1Tbx.Name = "side1Tbx"
        Me.side1Tbx.Size = New System.Drawing.Size(100, 23)
        Me.side1Tbx.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(154, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 30)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Pythagorean Triple"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(209, 191)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.hypoTbx)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.side1Tbx)
        Me.Controls.Add(Me.nTbx)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.side2Tbx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.mTbx)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Pythagorean Triple"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents mTbx As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nTbx As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents side2Tbx As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents side1Tbx As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents hypoTbx As TextBox
End Class
