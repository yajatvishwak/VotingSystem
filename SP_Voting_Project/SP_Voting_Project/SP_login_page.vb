Public Class SP_login_page

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AcceptButton = Button1
        Label3.Parent = PictureBox1
        Label2.Parent = PictureBox1
        Label1.Parent = PictureBox1




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Login_id.Text <> "Admin" Then
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=\SLAB-27\Voting\Database1.accdb;Persist Security Info=False;"

            Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT login_id , password  from SP_Student_Master where [login_id] = @p_login_id and [password] = @p_password", con)
            cmd.Parameters.AddWithValue("@p_login_id", Login_id.Text)
            cmd.Parameters.AddWithValue("@p_password", Password.Text)
            con.Open()


            Dim read As OleDb.OleDbDataReader = cmd.ExecuteReader()

            If read.HasRows Then
                Me.Hide()
                SP_Voting.Show()

            Else
                MsgBox("Invalid Login data...")
            End If

        Else
            Dim con1 As New OleDb.OleDbConnection
            con1.ConnectionString = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=\\SLAB-27\Voting\Database1.accdb;Persist Security Info=False;"
            Dim cmd1 As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT Admin_login and Admin_pass from SP_Admin where Admin_login = @p_id and Admin_pass = @p_pass", con1)
            cmd1.Parameters.AddWithValue("@p_id", Login_id.Text)
            cmd1.Parameters.AddWithValue("@p_pass", Password.Text)
            con1.Open()
            Dim read1 As OleDb.OleDbDataReader = cmd1.ExecuteReader()

            If read1.HasRows Then
                MsgBox("Admin Login id is valid...")
                Me.Hide()
                SP_Welcome.Show()
            Else
                MsgBox("Login invalid")
            End If

        End If

    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
