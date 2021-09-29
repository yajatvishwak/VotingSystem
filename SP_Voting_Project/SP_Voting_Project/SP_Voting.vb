Public Class SP_Voting
    ' Dim con As New OleDb.OleDbConnection


    Private Sub SP_Voting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AcceptButton = Button1
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=\\SLAB-27\Voting\Database1.accdb;Persist Security Info=False;"

        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT student_name ,house_color, gender from SP_Student_Master where [login_id] = @p_login_id AND trim(VOTED)='N'", con)
        cmd.Parameters.AddWithValue("@p_login_id", SP_login_page.Login_id.Text) ' set variable @p_login_id
        con.Open()


        Dim read As OleDb.OleDbDataReader = cmd.ExecuteReader()


        If read.HasRows Then
            read.Read()
            lbl_Student_Name.Text = read.Item(0)
            lbl_House_Color.Text = read.Item(1)
            lbl_Gender.Text = read.Item(2)
        Else
            MsgBox("Invalid Login OR Already Voted")
            Me.Close()
            SP_login_page.Show()
        End If

        con.Close()
        Dim cmd1 As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT sp_student_master.student_name,sp_category_nomination.id from sp_student_master, sp_category_nomination where sp_category_nomination.id = sp_student_master.id and sp_Student_master.gender=@p_gender and sp_category_nomination.[category_name]='School'", con)
        cmd1.Parameters.AddWithValue("@p_gender", lbl_Gender.Text)
        con.Open()
        Dim read1 As OleDb.OleDbDataReader = cmd1.ExecuteReader()

        While read1.Read()
            LB_School_Captain.Items.Add(read1.Item(0))
        End While
        con.Close()


        Dim cmd2 As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT sp_student_master.student_name from sp_student_master, sp_category_nomination where sp_category_nomination.id = sp_student_master.id and sp_Student_master.gender=@p_gender and sp_category_nomination.[category_name]='Cultural'", con)
        cmd2.Parameters.AddWithValue("@p_gender", lbl_Gender.Text)

        con.Open()

        Dim read2 As OleDb.OleDbDataReader = cmd2.ExecuteReader()
        While read2.Read()
            LB_Cultural_Captain.Items.Add(read2.Item(0))
        End While
        con.Close()

        Dim cmd3 As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT sp_student_master.student_name from sp_student_master, sp_category_nomination where sp_category_nomination.id = sp_student_master.id and sp_Student_master.gender=@p_gender and sp_category_nomination.[house]=@p_house", con)
        cmd3.Parameters.AddWithValue("@p_gender", lbl_Gender.Text)
        cmd3.Parameters.AddWithValue("@p_house", lbl_House_Color.Text)
        con.Open()


        Dim read3 As OleDb.OleDbDataReader = cmd3.ExecuteReader()
        While read3.Read()
            LB_House_Captain.Items.Add(read3.Item(0))
        End While
        con.Close()


        Dim cmd5 As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT sp_student_master.student_name from sp_student_master, sp_category_nomination where sp_category_nomination.id = sp_student_master.id and  sp_student_master.gender = @p_gender and sp_category_nomination.[category_name]='Sports'", con)
        cmd5.Parameters.AddWithValue("@p_gender", lbl_Gender.Text)

        con.Open()
        Dim read5 As OleDb.OleDbDataReader = cmd5.ExecuteReader
        While read5.Read()
            LB_Sports_Captain.Items.Add(read5.Item(0))
        End While
        con.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Student_Name.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New OleDb.OleDbConnection
        If LB_House_Captain.SelectedItem = "" Or LB_Cultural_Captain.SelectedItem = "" Or LB_House_Captain.SelectedItem = "" Or LB_Sports_Captain.Text = "" Then
            MsgBox("Please Choose all four categories nomination")
        Else


            con.ConnectionString = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=\\SLAB-27\Voting\Database1.accdb;Persist Security Info=False;"
            con.Open()

            Dim sql_school As String = "UPDATE SP_CATEGORY_NOMINATION SET VOTING_COUNTER = VOTING_COUNTER + 1 WHERE id = (SELECT id FROM SP_STUDENT_MASTER WHERE trim(STUDENT_NAME) = @p_captain_nomination AND trim(CLASS) = '9') AND CATEGORY_NAME='School'"
            Dim cmd4 As New OleDb.OleDbCommand(sql_school, con)
            cmd4.Parameters.AddWithValue("@p_captain_nomination", LB_School_Captain.SelectedItem)
            cmd4.ExecuteNonQuery()

            Dim sql_cultural As String = "UPDATE SP_CATEGORY_NOMINATION SET VOTING_COUNTER = VOTING_COUNTER + 1 WHERE id = (SELECT id FROM SP_STUDENT_MASTER WHERE trim(STUDENT_NAME) = @p_captain_nomination AND trim(CLASS) = '9') AND CATEGORY_NAME='Cultural'"
            Dim cmd5 As New OleDb.OleDbCommand(sql_cultural, con)
            cmd5.Parameters.AddWithValue("@p_captain_nomination", LB_Cultural_Captain.SelectedItem)
            cmd5.ExecuteNonQuery()

            Dim sql_house As String = "UPDATE SP_CATEGORY_NOMINATION SET VOTING_COUNTER = VOTING_COUNTER + 1 WHERE id = (SELECT id FROM SP_STUDENT_MASTER WHERE trim(STUDENT_NAME) = @p_captain_nomination AND trim(CLASS) = '9') AND CATEGORY_NAME='House' AND house = @p_house"
            Dim cmd6 As New OleDb.OleDbCommand(sql_house, con)
            cmd6.Parameters.AddWithValue("@p_captain_nomination", LB_House_Captain.SelectedItem)
            cmd6.Parameters.AddWithValue("@p_house", lbl_House_Color.Text)
            cmd6.ExecuteNonQuery()

            ' Dim sql_Assistant_head As String = "UPDATE SP_CATEGORY_NOMINATION SET VOTING_COUNTER = VOTING_COUNTER + 1 WHERE id = (SELECT id FROM SP_STUDENT_MASTER WHERE STUDENT_NAME = @p_captain_nomination AND CLASS = '9') AND CATEGORY_NAME ='Assistant_head'"
            '  Dim cmd7 As New OleDb.OleDbCommand(sql_Assistant_head, con)
            ' cmd7.Parameters.AddWithValue("@p_captain_nomination", LB_Assistant_Head_Captain.SelectedItem)
            '  cmd7.ExecuteNonQuery()


            Dim sql_Sports As String = "UPDATE SP_CATEGORY_NOMINATION SET VOTING_COUNTER = VOTING_COUNTER + 1 WHERE id = (SELECT id FROM SP_STUDENT_MASTER WHERE trim(STUDENT_NAME) = @p_captain_nomination AND trim(CLASS) = '9') AND CATEGORY_NAME ='Sports'"
            Dim cmd8 As New OleDb.OleDbCommand(sql_Sports, con)
            cmd8.Parameters.AddWithValue("@p_captain_nomination", LB_Sports_Captain.SelectedItem)
            cmd8.ExecuteNonQuery()



            Dim sql_login As String = "UPDATE SP_STUDENT_MASTER SET VOTED = 'Y' WHERE LOGIN_ID = @P_LOGIN"
            Dim cmd9 As New OleDb.OleDbCommand(sql_login, con)
            cmd9.Parameters.AddWithValue("@p_login", SP_login_page.Login_id.Text)
            cmd9.ExecuteNonQuery()

            con.Close()

            MsgBox("Thanks for Voting")


            SP_login_page.Login_id.Clear()
            SP_login_page.Password.Clear()
            Me.Close()
            SP_login_page.Show()

        End If

    End Sub

    Private Sub LB_School_Captain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB_School_Captain.SelectedIndexChanged
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=\\SLAB-27\Voting\Database1.accdb;Persist Security Info=False;"
        Dim cmd1 As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT sp_category_nomination.img from sp_student_master, sp_category_nomination where sp_category_nomination.[id] = sp_student_master.[id] and sp_Student_master.[student_name]=@p_captain_nomination", con)
        cmd1.Parameters.AddWithValue("@p_captain_nomination", LB_School_Captain.SelectedItem)
        con.Open()

        Dim read3 As OleDb.OleDbDataReader = cmd1.ExecuteReader()
        If read3.HasRows Then
            read3.Read()
            PictureBox1.ImageLocation = IIf(IsDBNull(read3.Item(0)), String.Empty, read3.Item(0))

        End If
        con.Close()

    End Sub


    Private Sub LB_Cultural_Captain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB_Cultural_Captain.SelectedIndexChanged
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=\\SLAB-27\Voting\Database1.accdb;Persist Security Info=False;"
        Dim cmd1 As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT sp_category_nomination.img from sp_student_master, sp_category_nomination where sp_category_nomination.[id] = sp_student_master.[id] and sp_Student_master.[student_name]=@p_captain_nomination", con)
        cmd1.Parameters.AddWithValue("@p_captain_nomination", LB_Cultural_Captain.SelectedItem)
        con.Open()
        Dim read3 As OleDb.OleDbDataReader = cmd1.ExecuteReader()
        If read3.HasRows Then
            read3.Read()
            PictureBox2.ImageLocation = IIf(IsDBNull(read3.Item(0)), String.Empty, read3.Item(0))

        End If
        con.Close()


    End Sub



    Private Sub LB_House_Captain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB_House_Captain.SelectedIndexChanged
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=\\SLAB-27\Voting\Database1.accdb;Persist Security Info=False;"
        Dim cmd1 As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT sp_category_nomination.img from sp_student_master, sp_category_nomination where sp_category_nomination.[id] = sp_student_master.[id] and sp_Student_master.[student_name]=@p_house_nomination", con)
        cmd1.Parameters.AddWithValue("@p_house_nomination", LB_House_Captain.SelectedItem)
        con.Open()
        Dim read3 As OleDb.OleDbDataReader = cmd1.ExecuteReader()
        If read3.HasRows Then
            read3.Read()
            PictureBox3.ImageLocation = IIf(IsDBNull(read3.Item(0)), String.Empty, read3.Item(0))

        End If
        con.Close()

    End Sub

    Private Sub LB_Sports_Captain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB_Sports_Captain.SelectedIndexChanged
        Try
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=\\SLAB-27\Voting\Database1.accdb;Persist Security Info=False;"
            Dim cmd1 As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT sp_category_nomination.img from sp_student_master, sp_category_nomination where sp_category_nomination.[id] = sp_student_master.[id] and sp_Student_master.[student_name]=@p_sports_captain_nomination", con)
            cmd1.Parameters.AddWithValue("@p_sports_captain_nomination", LB_Sports_Captain.SelectedItem)
            con.Open()
            Dim read3 As OleDb.OleDbDataReader = cmd1.ExecuteReader()
            If read3.HasRows Then
                read3.Read()
                PictureBox5.ImageLocation = IIf(IsDBNull(read3.Item(0)), String.Empty, read3.Item(0))

            End If
            con.Close()
        Catch ex As Exception
        End Try
    End Sub

End Class