<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SP_Admin_Students
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
        Dim Login_idLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim ClassLabel As System.Windows.Forms.Label
        Dim House_colorLabel As System.Windows.Forms.Label
        Dim SectionLabel As System.Windows.Forms.Label
        Dim Student_nameLabel As System.Windows.Forms.Label
        Dim Roll_noLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.Login_idTextBox = New System.Windows.Forms.TextBox()
        Me.GenderCmbo = New System.Windows.Forms.ComboBox()
        Me.HouseCombo = New System.Windows.Forms.ComboBox()
        Me.SectionCombo = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ClassCombo = New System.Windows.Forms.ComboBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Roll_noTextBox = New System.Windows.Forms.TextBox()
        Me.Student_nameTextBox = New System.Windows.Forms.TextBox()
        Me.btnaddnew = New System.Windows.Forms.Button()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.btnupdate = New System.Windows.Forms.Button()
        Login_idLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        ClassLabel = New System.Windows.Forms.Label()
        House_colorLabel = New System.Windows.Forms.Label()
        SectionLabel = New System.Windows.Forms.Label()
        Student_nameLabel = New System.Windows.Forms.Label()
        Roll_noLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Login_idLabel
        '
        Login_idLabel.AutoSize = True
        Login_idLabel.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Login_idLabel.Location = New System.Drawing.Point(847, 437)
        Login_idLabel.Name = "Login_idLabel"
        Login_idLabel.Size = New System.Drawing.Size(83, 20)
        Login_idLabel.TabIndex = 131
        Login_idLabel.Text = "Login id:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(491, 439)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(53, 16)
        GenderLabel.TabIndex = 126
        GenderLabel.Text = "Gender:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.Location = New System.Drawing.Point(491, 546)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(62, 16)
        PasswordLabel.TabIndex = 124
        PasswordLabel.Text = "Password:"
        '
        'ClassLabel
        '
        ClassLabel.AutoSize = True
        ClassLabel.Location = New System.Drawing.Point(-73, 412)
        ClassLabel.Name = "ClassLabel"
        ClassLabel.Size = New System.Drawing.Size(34, 13)
        ClassLabel.TabIndex = 116
        ClassLabel.Text = "class:"
        '
        'House_colorLabel
        '
        House_colorLabel.AutoSize = True
        House_colorLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        House_colorLabel.Location = New System.Drawing.Point(481, 337)
        House_colorLabel.Name = "House_colorLabel"
        House_colorLabel.Size = New System.Drawing.Size(73, 16)
        House_colorLabel.TabIndex = 123
        House_colorLabel.Text = "House color:"
        '
        'SectionLabel
        '
        SectionLabel.AutoSize = True
        SectionLabel.Location = New System.Drawing.Point(-83, 490)
        SectionLabel.Name = "SectionLabel"
        SectionLabel.Size = New System.Drawing.Size(44, 13)
        SectionLabel.TabIndex = 117
        SectionLabel.Text = "section:"
        '
        'Student_nameLabel
        '
        Student_nameLabel.AutoSize = True
        Student_nameLabel.Location = New System.Drawing.Point(-90, 337)
        Student_nameLabel.Name = "Student_nameLabel"
        Student_nameLabel.Size = New System.Drawing.Size(74, 13)
        Student_nameLabel.TabIndex = 121
        Student_nameLabel.Text = "student name:"
        '
        'Roll_noLabel
        '
        Roll_noLabel.AutoSize = True
        Roll_noLabel.Location = New System.Drawing.Point(-73, 575)
        Roll_noLabel.Name = "Roll_noLabel"
        Roll_noLabel.Size = New System.Drawing.Size(38, 13)
        Roll_noLabel.TabIndex = 119
        Roll_noLabel.Text = "roll no:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(1271, 755)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 137
        IdLabel.Text = "id:"
        IdLabel.Visible = False
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(116, 407)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(38, 16)
        Label1.TabIndex = 139
        Label1.Text = "Class:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(106, 485)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(51, 16)
        Label2.TabIndex = 140
        Label2.Text = "Section:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(71, 332)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(90, 16)
        Label3.TabIndex = 142
        Label3.Text = "Student Name:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(116, 570)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(47, 16)
        Label4.TabIndex = 141
        Label4.Text = "Roll No:"
        '
        'Login_idTextBox
        '
        Me.Login_idTextBox.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_idTextBox.Location = New System.Drawing.Point(949, 425)
        Me.Login_idTextBox.Name = "Login_idTextBox"
        Me.Login_idTextBox.ReadOnly = True
        Me.Login_idTextBox.Size = New System.Drawing.Size(186, 37)
        Me.Login_idTextBox.TabIndex = 132
        '
        'GenderCmbo
        '
        Me.GenderCmbo.FormattingEnabled = True
        Me.GenderCmbo.Items.AddRange(New Object() {"B", "G"})
        Me.GenderCmbo.Location = New System.Drawing.Point(599, 436)
        Me.GenderCmbo.Name = "GenderCmbo"
        Me.GenderCmbo.Size = New System.Drawing.Size(121, 21)
        Me.GenderCmbo.TabIndex = 130
        '
        'HouseCombo
        '
        Me.HouseCombo.FormattingEnabled = True
        Me.HouseCombo.Items.AddRange(New Object() {"Emerald", "Ruby", "Saphire", "Topaz"})
        Me.HouseCombo.Location = New System.Drawing.Point(599, 332)
        Me.HouseCombo.Name = "HouseCombo"
        Me.HouseCombo.Size = New System.Drawing.Size(121, 21)
        Me.HouseCombo.TabIndex = 129
        '
        'SectionCombo
        '
        Me.SectionCombo.FormattingEnabled = True
        Me.SectionCombo.Items.AddRange(New Object() {"A", "B", "C", "D", "E"})
        Me.SectionCombo.Location = New System.Drawing.Point(192, 483)
        Me.SectionCombo.Name = "SectionCombo"
        Me.SectionCombo.Size = New System.Drawing.Size(121, 21)
        Me.SectionCombo.TabIndex = 128
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(69, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1262, 297)
        Me.DataGridView1.TabIndex = 118
        '
        'ClassCombo
        '
        Me.ClassCombo.FormattingEnabled = True
        Me.ClassCombo.Items.AddRange(New Object() {"8", "9", "10"})
        Me.ClassCombo.Location = New System.Drawing.Point(192, 400)
        Me.ClassCombo.Name = "ClassCombo"
        Me.ClassCombo.Size = New System.Drawing.Size(121, 21)
        Me.ClassCombo.TabIndex = 127
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(599, 543)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(121, 20)
        Me.PasswordTextBox.TabIndex = 125
        '
        'Roll_noTextBox
        '
        Me.Roll_noTextBox.Location = New System.Drawing.Point(192, 568)
        Me.Roll_noTextBox.Name = "Roll_noTextBox"
        Me.Roll_noTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Roll_noTextBox.TabIndex = 120
        '
        'Student_nameTextBox
        '
        Me.Student_nameTextBox.Location = New System.Drawing.Point(192, 330)
        Me.Student_nameTextBox.Name = "Student_nameTextBox"
        Me.Student_nameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Student_nameTextBox.TabIndex = 122
        '
        'btnaddnew
        '
        Me.btnaddnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaddnew.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddnew.Location = New System.Drawing.Point(57, 603)
        Me.btnaddnew.Name = "btnaddnew"
        Me.btnaddnew.Size = New System.Drawing.Size(164, 45)
        Me.btnaddnew.TabIndex = 136
        Me.btnaddnew.Text = "Add New"
        Me.btnaddnew.UseVisualStyleBackColor = True
        '
        'btninsert
        '
        Me.btninsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninsert.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsert.Location = New System.Drawing.Point(366, 603)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(164, 45)
        Me.btninsert.TabIndex = 135
        Me.btninsert.Text = "Insert"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(1039, 603)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(164, 45)
        Me.btndelete.TabIndex = 134
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'IdTextBox
        '
        Me.IdTextBox.Location = New System.Drawing.Point(1299, 752)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(34, 20)
        Me.IdTextBox.TabIndex = 138
        Me.IdTextBox.Visible = False
        '
        'btnupdate
        '
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(718, 603)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(164, 45)
        Me.btnupdate.TabIndex = 133
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'SP_Admin_Students
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 681)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.btnaddnew)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Login_idLabel)
        Me.Controls.Add(Me.Login_idTextBox)
        Me.Controls.Add(Me.GenderCmbo)
        Me.Controls.Add(Me.HouseCombo)
        Me.Controls.Add(Me.SectionCombo)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.ClassCombo)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(ClassLabel)
        Me.Controls.Add(House_colorLabel)
        Me.Controls.Add(SectionLabel)
        Me.Controls.Add(Student_nameLabel)
        Me.Controls.Add(Me.Roll_noTextBox)
        Me.Controls.Add(Me.Student_nameTextBox)
        Me.Controls.Add(Roll_noLabel)
        Me.Name = "SP_Admin_Students"
        Me.Text = "SP_Admin_Students"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Login_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderCmbo As System.Windows.Forms.ComboBox
    Friend WithEvents HouseCombo As System.Windows.Forms.ComboBox
    Friend WithEvents SectionCombo As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ClassCombo As System.Windows.Forms.ComboBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Roll_noTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Student_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnaddnew As System.Windows.Forms.Button
    Friend WithEvents btninsert As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnupdate As System.Windows.Forms.Button
End Class
