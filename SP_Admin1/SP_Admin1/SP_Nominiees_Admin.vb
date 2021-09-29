Imports System.Data.OleDb
Public Class SP_Nominiees_Admin
    Dim con1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Voting\Database1.accdb")
    Dim cmd As New OleDbCommand("", con1)
    Dim adapter As New OleDbDataAdapter
    Dim table As New DataTable



    Private Sub LoadData()
        table.Clear()
        con1.Open()
        cmd.CommandText = "SELECT * from SP_Category_nomination"
        cmd.ExecuteNonQuery()
        con1.Close()
        adapter.SelectCommand = cmd
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub SP_Nomination_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadData()
    


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
  

        Dim con1 As New OleDb.OleDbConnection
        con1.ConnectionString = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=D:\Voting\Database1.accdb;Persist Security Info=False;"

        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT id FROM SP_category_nomination WHERE id = @p_id", con1)
        cmd.Parameters.AddWithValue("@p_id", idtextbox.Text)
        con1.Open()
        Dim read As OleDb.OleDbDataReader = cmd.ExecuteReader()
        If read.HasRows Then
            MsgBox("One child cannot be the captian of 2 category ")
        Else
            Dim sql As String = "INSERT INTO SP_category_nomination (ID, house,[category_name]  ) VALUES (@p_id,@p_house,@p_category)"
            Dim cmd1 As New OleDbCommand(sql, con1)
            cmd1.Parameters.AddWithValue("@p_id", idtextbox.Text)
            cmd1.Parameters.AddWithValue("@p_house", housecmbo.SelectedItem)
            cmd1.Parameters.AddWithValue("@p_category", categorycmbo.SelectedItem)

            cmd1.ExecuteNonQuery()
        End If

        LoadData()


        Try

            Dim sql_record_inserted As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT id from sp_category_nomination where id = @p_id", con1)

            sql_record_inserted.Parameters.AddWithValue("@p_id", idtextbox.Text)
            Dim read_record_inserted As OleDb.OleDbDataReader = sql_record_inserted.ExecuteReader()


            If read_record_inserted.HasRows Then
                read_record_inserted.Read()
                MsgBox("Student Record Created Successfully with Login Id " + read_record_inserted.Item(0))
            Else
                MsgBox("Error Created Student Record")
            End If
            LoadData()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        housecmbo.Text = ""
        idtextbox.Clear()
        categorycmbo.Text = ""

        LoadData()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        con1.Open()
        cmd.CommandText = "DELETE from SP_category_nomination where id = " & Val(idtextbox.Text) & " and house = '" & housecmbo.Text & "' and category_name ='" & categorycmbo.Text & "'  "
        cmd.ExecuteNonQuery()
        con1.Close()
        MsgBox("deleted")
        LoadData()

    End Sub


    Private Sub DataGridView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        Try

            If DataGridView1.SelectedCells.Count > 0 Then
                idtextbox.Text = DataGridView1.SelectedCells(0).Value

                categorycmbo.Text = DataGridView1.SelectedCells(2).Value
                housecmbo.Text = DataGridView1.SelectedCells(1).Value

            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        con1.Open()
        cmd.CommandText = "UPDATE SP_Category_Nomination set house = '" & housecmbo.Text & "', category_name = '" & categorycmbo.Text & "' where [id] = " & Val(idtextbox.Text) & ""
        cmd.ExecuteNonQuery()
        con1.Close()
        MsgBox("updated")
        LoadData()
    End Sub

    
    Private Sub categorycmbo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles categorycmbo.SelectedIndexChanged
 
    End Sub

End Class