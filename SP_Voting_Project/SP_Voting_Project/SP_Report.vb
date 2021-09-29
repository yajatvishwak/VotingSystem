

Public Class SP_Report
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim table As New DataTable
    Dim table1 As New DataTable
    Dim table2 As New DataTable
    Dim con1 As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SLAB-27\Voting\Database1.accdb")
    Dim cmd As New OleDb.OleDbCommand("", con1)
    Private Sub SP_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=\\SLAB-27\Voting\Database1.accdb;Persist Security Info=False;"


        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT count(*) from SP_STUDENT_MASTER  ", con)
        con.Open()
        Dim read As OleDb.OleDbDataReader = cmd.ExecuteReader()
        read.Read()
        totalstdlbl.Text = read.Item(0)
        con.Close()

        Dim cmd_voted As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT count(*) from SP_STUDENT_MASTER where voted = 'Y'", con)
        con.Open()
        Dim read_voted As OleDb.OleDbDataReader = cmd_voted.ExecuteReader
        read_voted.Read()
        votedlbl.Text = read_voted.Item(0)
        con.Close()

        Dim cmd_nonvoted As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT count(*) from SP_STUDENT_MASTER where voted <> 'Y'", con)
        con.Open()
        Dim read_nonvoted As OleDb.OleDbDataReader = cmd_nonvoted.ExecuteReader
        read_nonvoted.Read()
        nonvotedlbl.Text = read_nonvoted.Item(0)
        con.Close()

        LoadData()


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        SP_Welcome.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub LoadData()
        table.Clear()
        con1.Open()
        cmd.CommandText = "SELECT voting_result_view.* from voting_result_view"
        cmd.ExecuteNonQuery()
        con1.Close()
        adapter.SelectCommand = cmd
        adapter.Fill(table)
        DataGridView1.DataSource = table

        table1.Clear()
        con1.Open()
        cmd.CommandText = "SELECT SP_winners_boy.* from sp_winners_boy"
        cmd.ExecuteNonQuery()
        con1.Close()
        adapter.SelectCommand = cmd
        adapter.Fill(table1)
        DataGridView2.DataSource = table1

        table2.Clear()
        con1.Open()
        cmd.CommandText = "SELECT SP_winners_girl.* from sp_winners_girl"
        cmd.ExecuteNonQuery()
        con1.Close()
        adapter.SelectCommand = cmd
        adapter.Fill(table2)
        DataGridView3.DataSource = table2
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
      
    End Sub

    Private Sub DataGridView3_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub
End Class