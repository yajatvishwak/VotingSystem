Imports System.Data.OleDb


Public Class SP_Change_Password

    Dim con1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SLAB-27\Voting\Database1.accdb")
    Dim cmd As New OleDbCommand("", con1)
    Private Sub Change_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Change_btn.Click
        

        con1.Open()

        cmd.CommandText = ("UPDATE sp_student_master set password = '" & pass_tb.Text & "' where login_id = @p_login_id   ")
        cmd.Parameters.AddWithValue("@p_login_id", SP_login_page.Login_id.Text)
        
        con1.Close()

    End Sub

    Private Sub SP_Change_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class