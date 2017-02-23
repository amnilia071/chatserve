Imports System.Data
Imports System.Data.SqlClient

Public Class MainMenu

    Private Sub MainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            GroupBox1.Text = Module1.room
            Dim Con As New SqlConnection(Module1.constring)
            Con.Open()
            Dim ds As New DataSet
            Dim da As SqlDataAdapter
            Dim sql As String
            sql = "SELECT [UserName] FROM Account where room ='" + Module1.room + "' "
            da = New SqlDataAdapter(sql, Con)
            da.Fill(ds, "Time")
            For count As Integer = 0 To ds.Tables("Time").Rows.Count - 1
                ListBox1.Items.Add(ds.Tables("Time").Rows(count).Item("UserName").ToString)
            Next
            Con.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rightNow As Date = Now
        Try
            Dim myCommand As SqlCommand
            Dim ra As Integer
            Dim myConnection As New SqlConnection(Module1.constring)
            myConnection.Open()
            Dim val As String
            Try
                val = ListBox1.SelectedItem.ToString

            Catch ex As Exception
                val = "User"
            End Try
            myCommand = New SqlCommand("INSERT INTO [Chat] ( [Date],[Sender]  ,[reciver] ,Note,[Status] )  VALUES ( '" + rightNow.Date + "', '" + Module1.user.ToString + "', '" + ListBox1.SelectedItem.ToString + "','" + txtchat.Text + "', 'Active')", myConnection)
            ra = myCommand.ExecuteNonQuery()
            myConnection.Close()
        Catch ex As Exception

        End Try
        Try
            Dim Con As New SqlConnection(Module1.constring)
            Con.Open()
            Dim ds As New DataSet
            Dim da As SqlDataAdapter
            Dim sql As String
            sql = "SELECT Sender,[Note] FROM Chat  where Sender='" + Module1.user.ToString + "' or  reciver='" + Module1.user.ToString + "'  order by id DESC  "
            da = New SqlDataAdapter(sql, Con)
            da.Fill(ds, "Time")
            TextBox1.Text = ""
            For count As Integer = 0 To ds.Tables("Time").Rows.Count - 1
                TextBox1.Text += (ds.Tables("Time").Rows(count).Item("Sender")) + ":" + (ds.Tables("Time").Rows(count).Item("Note")) + vbCrLf
            Next
        Catch ex As Exception

        End Try
        txtchat.Text = ""
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        GroupBox1.Text = Module1.room + "  with  " + ListBox1.SelectedItem.ToString
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Dim Con As New SqlConnection(Module1.constring)
            Con.Open()
            Dim ds As New DataSet
            Dim da As SqlDataAdapter
            Dim sql As String
            sql = "SELECT Sender,[Note] FROM Chat  where Sender='" + Module1.user.ToString + "' or   reciver='" + Module1.user.ToString + "'  order by id DESC"
            da = New SqlDataAdapter(sql, Con)
            da.Fill(ds, "Time")
            TextBox1.Text = ""
            For count As Integer = 0 To ds.Tables("Time").Rows.Count - 1
                TextBox1.Text += (ds.Tables("Time").Rows(count).Item("Sender")) + ":" + (ds.Tables("Time").Rows(count).Item("Note")) + vbCrLf
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        ControlPanel.Show()
    End Sub

    
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim myCommand As SqlCommand
            Dim ra As Integer
            Dim myConnection As New SqlConnection(Module1.constring)
            myConnection.Open()
            myCommand = New SqlCommand("update   [Account] set  [Status] ='offline' where   UserName='" + Module1.user + "' ", myConnection)
            ra = myCommand.ExecuteNonQuery()
            myConnection.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class