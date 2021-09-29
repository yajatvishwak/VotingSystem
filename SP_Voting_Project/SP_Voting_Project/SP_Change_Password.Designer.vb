<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SP_Change_Password
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
        Me.pass_tb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Change_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(602, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to St Pauls Voting System"
        '
        'pass_tb
        '
        Me.pass_tb.Location = New System.Drawing.Point(277, 204)
        Me.pass_tb.Name = "pass_tb"
        Me.pass_tb.Size = New System.Drawing.Size(280, 20)
        Me.pass_tb.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter Your New Password : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(308, 31)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Change Your Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Rules For Changing Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(62, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(246, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "•  Password should not be the same."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(62, 391)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(403, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "•  Make sure you make a strong and a meaningful password."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(130, 476)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 17)
        Me.Label7.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(62, 447)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(301, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "•  Do not SHARE your password with any one."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(62, 497)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(533, 17)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "•  Make sure you remember your password as it will be used in casting your votes." & _
    ""
        '
        'Change_btn
        '
        Me.Change_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Change_btn.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.arrow_28_512
        Me.Change_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Change_btn.FlatAppearance.BorderSize = 0
        Me.Change_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Change_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Change_btn.Location = New System.Drawing.Point(711, 422)
        Me.Change_btn.Name = "Change_btn"
        Me.Change_btn.Size = New System.Drawing.Size(121, 113)
        Me.Change_btn.TabIndex = 11
        Me.Change_btn.UseVisualStyleBackColor = False
        '
        'SP_Change_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(871, 568)
        Me.Controls.Add(Me.Change_btn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pass_tb)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SP_Change_Password"
        Me.Text = "SP_Change_Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pass_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Change_btn As System.Windows.Forms.Button
End Class
