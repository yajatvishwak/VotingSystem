Imports System.Data.OleDb
Public Class SP_Admin_Students



    Dim con1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Voting\Database1.accdb")
    Dim cmd As New OleDbCommand("", con1)
    Dim adapter As New OleDbDataAdapter
    Dim table As New DataTable

    Private Sub LoadData()
        table.Clear()
        con1.Open()
        cmd.CommandText = "SELECT * from SP_Student_Master"
        cmd.ExecuteNonQuery()
        con1.Close()
        adapter.SelectCommand = cmd
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub btninsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninsert.Click
        If ClassCombo.Text = "" Or Roll_noTextBox.Text = "" Or Student_nameTextBox.Text = "" Or SectionCombo.Text = "" Or HouseCombo.Text = "" Or Login_idTextBox.Text = "" Or PasswordTextBox.Text = "" Or GenderCmbo.SelectedItem = "" Then

            MsgBox("please complete the form ")
            Exit Sub 'exit 
        End If
        Try
            Dim con1 As New OleDb.OleDbConnection
            con1.ConnectionString = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=D:\Voting\Database1.accdb;Persist Security Info=False;"

            Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT login_id FROM SP_STUDENT_MASTER WHERE login_id = @p_login_id", con1)
            cmd.Parameters.AddWithValue("@p_login_id", Login_idTextBox.Text)
            con1.Open()
            Dim read As OleDb.OleDbDataReader = cmd.ExecuteReader()
            If read.HasRows Then
                MsgBox("Login id used by other user ")

            Else
                'mainfest
                'Dim sql As String = "INSERT INTO SP_STUDENT_MASTER (ID,CLASS,SECTION,ROLL_NO,STUDENT_NAME,HOUSE_COLOR,LOGIN_ID,PASSWORD,GENDER) VALUES (@p_id,@p_class,@p_section,@p_roll_no,@p_student_name,@p_house_color,@p_login_id,@p_password,@p_gender)"
                Dim sql As String = "INSERT INTO SP_STUDENT_MASTER (ID,CLASS,[roll_no],[student_name],[section],[house_color],[login_id],[password],[gender]) VALUES (@p_id,@p_class,@p_roll_no,@p_student_name,@p_section,@p_house_color,@p_login_id,@p_password,@p_gender)"

                Dim sql_max_id As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT max(id)+1 from sp_student_master", con1)
                Dim read_max_id As OleDb.OleDbDataReader = sql_max_id.ExecuteReader()
                While read_max_id.Read()
                    IdTextBox.Text = read_max_id.Item(0)
                End While


                Dim cmd4 As New OleDb.OleDbCommand(sql, con1)
                cmd4.Parameters.AddWithValue("@p_id", IdTextBox.Text)
                cmd4.Parameters.AddWithValue("@p_class", ClassCombo.SelectedItem)
                cmd4.Parameters.AddWithValue("@p_roll_no", Roll_noTextBox.Text)
                cmd4.Parameters.AddWithValue("@p_student_name", Student_nameTextBox.Text)
                cmd4.Parameters.AddWithValue("@p_section", SectionCombo.SelectedItem)
                cmd4.Parameters.AddWithValue("@p_house_color", HouseCombo.SelectedItem)
                cmd4.Parameters.AddWithValue("@p_login_id", Login_idTextBox.Text)
                cmd4.Parameters.AddWithValue("@p_password", PasswordTextBox.Text)
                cmd4.Parameters.AddWithValue("@p_gender", GenderCmbo.SelectedItem)
                cmd4.ExecuteNonQuery()

                Dim sql_record_inserted As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT login_id from sp_student_master where id = @p_id", con1)

                sql_record_inserted.Parameters.AddWithValue("@p_id", IdTextBox.Text)
                Dim read_record_inserted As OleDb.OleDbDataReader = sql_record_inserted.ExecuteReader()


                If read_record_inserted.HasRows Then
                    read_record_inserted.Read()
                    MsgBox("Student Record Created Successfully with Login Id " + read_record_inserted.Item(0))
                Else
                    MsgBox("Error Created Student Record")
                End If
            End If
            LoadData()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassCombo.SelectedIndexChanged
        Login_idTextBox.Text = Student_nameTextBox.Text + ClassCombo.SelectedItem + SectionCombo.SelectedItem + Roll_noTextBox.Text
    End Sub
    Private Sub Student_nameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Student_nameTextBox.TextChanged
        Login_idTextBox.Text = Student_nameTextBox.Text + ClassCombo.SelectedItem + SectionCombo.SelectedItem + Roll_noTextBox.Text

    End Sub
    Private Sub SectionCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectionCombo.SelectedIndexChanged
        Login_idTextBox.Text = Student_nameTextBox.Text + ClassCombo.SelectedItem + SectionCombo.SelectedItem + Roll_noTextBox.Text
    End Sub

    Private Sub Roll_noTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Roll_noTextBox.TextChanged
        Login_idTextBox.Text = Student_nameTextBox.Text + ClassCombo.SelectedItem + SectionCombo.SelectedItem + Roll_noTextBox.Text
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        Try

            If DataGridView1.SelectedCells.Count > 0 Then
                IdTextBox.Text = DataGridView1.SelectedCells(0).Value
                ClassCombo.Text = DataGridView1.SelectedCells(1).Value
                SectionCombo.Text = DataGridView1.SelectedCells(2).Value
                Roll_noTextBox.Text = DataGridView1.SelectedCells(3).Value
                Student_nameTextBox.Text = DataGridView1.SelectedCells(4).Value
                HouseCombo.Text = DataGridView1.SelectedCells(5).Value
                Login_idTextBox.Text = DataGridView1.SelectedCells(6).Value
                PasswordTextBox.Text = DataGridView1.SelectedCells(8).Value
                GenderCmbo.Text = DataGridView1.SelectedCells(9).Value
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SP__Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnaddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddnew.Click
        IdTextBox.Clear()
        ClassCombo.Text = ""
        Roll_noTextBox.Clear()
        Student_nameTextBox.Clear()
        SectionCombo.Text = ""
        HouseCombo.Text = ""
        Login_idTextBox.Clear()
        PasswordTextBox.Clear()
        GenderCmbo.Text = ""

    End Sub


    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If ClassCombo.Text = "" Or Roll_noTextBox.Text = "" Or Student_nameTextBox.Text = "" Or SectionCombo.Text = "" Or HouseCombo.Text = "" Or Login_idTextBox.Text = "" Or PasswordTextBox.Text = "" Or GenderCmbo.SelectedItem = "" Then

            MsgBox("please complete the form ")
            Exit Sub 'exit 
        End If
        Try
            con1.Open()
            cmd.CommandText = "DELETE from SP_STUDENT_MASTER where class='" & ClassCombo.Text & "' and [section] = '" & SectionCombo.Text & "' and [roll_no] = '" & Roll_noTextBox.Text & "' and [student_name] = '" & Student_nameTextBox.Text & "' and [house_color] = '" & HouseCombo.Text & "' and [login_id]= '" & Login_idTextBox.Text & "' and [password]  = '" & PasswordTextBox.Text & "' and [gender] = '" & GenderCmbo.Text & "'"
            cmd.ExecuteNonQuery()
            con1.Close()
            MsgBox("deleted")
            LoadData()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Try
            con1.Open()
            cmd.CommandText = "UPDATE SP_STUDENT_MASTER set class = " & Val(ClassCombo.Text) & ", [section] = '" & SectionCombo.Text & "' , [roll_no] = '" & Roll_noTextBox.Text & "' ,[student_name] = '" & Student_nameTextBox.Text & "' , [house_color] = '" & HouseCombo.Text & "' , [login_id]= '" & Login_idTextBox.Text & "' , [password]  = '" & PasswordTextBox.Text & "' , [gender] = '" & GenderCmbo.Text & "' where [id] = " & Val(IdTextBox.Text) & ""

            'cmd.CommandText = "UPDATE SP_STUDENT_MASTER set class = " & Val(ClassCombo.Text) & "  where [id] = " & Val(IdTextBox.Text) & ""

            cmd.ExecuteNonQuery()
            con1.Close()
            MsgBox("updated")
            LoadData()
        Catch ex As Exception
        End Try
    End Sub


End Class

