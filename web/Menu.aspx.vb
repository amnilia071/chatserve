Imports System.Data
Imports System.Data.SqlClient

Partial Class Menu
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rightNow As Date = Now
        Try
            Dim myCommand As SqlCommand
            Dim ra As Integer
            Dim myConnection As New SqlConnection(ConfigurationManager.ConnectionStrings("Constring").ConnectionString)
            myConnection.Open()
            myCommand = New SqlCommand("INSERT INTO [Chat] ( [Date],[Sender]  ,[reciver] ,Note,[Status] )  VALUES ( '" + rightNow.Date + "', '" + Class1.user.ToString + "', '" + Label2.Text + "','" + txtnote.Text + "', 'Active')", myConnection)
            ra = myCommand.ExecuteNonQuery()
            myConnection.Close()
        Catch ex As Exception

        End Try
        Try
            Dim Con As New SqlConnection(ConfigurationManager.ConnectionStrings("Constring").ConnectionString)
            Con.Open()
            Dim ds As New DataSet
            Dim da As SqlDataAdapter
            Dim sql As String
            sql = "SELECT Sender,[Note] FROM Chat  where Sender='" + Class1.user.ToString + "' or   reciver='" + Class1.user.ToString + "' order by id DESC  "
            da = New SqlDataAdapter(sql, Con)
            da.Fill(ds, "Time")
            TextBox1.Text = ""
            For count As Integer = 0 To ds.Tables("Time").Rows.Count - 1
                TextBox1.Text += (ds.Tables("Time").Rows(count).Item("Sender")) + ":" + (ds.Tables("Time").Rows(count).Item("Note")) + vbCrLf
            Next
            Con.Close()
        Catch ex As Exception

        End Try
        txtnote.Text = ""
    End Sub

    Protected Sub txtnote_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnote.TextChanged

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            Try
                Dim Con As New SqlConnection(ConfigurationManager.ConnectionStrings("Constring").ConnectionString)
                Con.Open()
                Dim ds As New DataSet
                Dim da As SqlDataAdapter
                Dim sql As String
                sql = "SELECT roomname  FROM room    "
                da = New SqlDataAdapter(sql, Con)
                da.Fill(ds, "Time")

                For count As Integer = 0 To ds.Tables("Time").Rows.Count - 1
                    DropDownList1.Items.Add(ds.Tables("Time").Rows(count).Item("roomname"))
                Next
                Con.Close()
            Catch ex As Exception

            End Try
        End If


         
    End Sub

    'Protected Sub ListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
    '    Label2.Text = ListBox1.SelectedItem.ToString
    'End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged

        Try
            Dim Con As New SqlConnection(ConfigurationManager.ConnectionStrings("Constring").ConnectionString)
            Con.Open()
            Dim ds As New DataSet
            Dim da As SqlDataAdapter
            Dim sql As String
            sql = "SELECT UserName,Status  FROM Account where room ='" + DropDownList1.SelectedItem.ToString + "'   "
            da = New SqlDataAdapter(sql, Con)
            da.Fill(ds, "Time")
            DropDownList2.Items.Clear()
            For count As Integer = 0 To ds.Tables("Time").Rows.Count - 1
                DropDownList2.Items.Add("Please Select User")
                DropDownList2.Items.Add(New ListItem(ds.Tables("Time").Rows(count).Item("UserName") + "  " + ds.Tables("Time").Rows(count).Item("Status"), ds.Tables("Time").Rows(count).Item("UserName")))
            Next
            Con.Close()
        Catch ex As Exception
        End Try
        Try
            Dim myCommand As SqlCommand
            Dim ra As Integer
            Dim myConnection As New SqlConnection(ConfigurationManager.ConnectionStrings("Constring").ConnectionString)
            myConnection.Open()
            myCommand = New SqlCommand("update   [Account] set  [room] ='" + DropDownList1.SelectedItem.ToString + "' where   [UserName]='" + Class1.user.ToString + "' ", myConnection)
            ra = myCommand.ExecuteNonQuery()
            myConnection.Close()
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
           Dim Con As New SqlConnection(ConfigurationManager.ConnectionStrings("Constring").ConnectionString)
            Con.Open()
            Dim ds As New DataSet
            Dim da As SqlDataAdapter
            Dim sql As String
            sql = "SELECT Sender,[Note] FROM Chat  where Sender='" + Class1.user.ToString + "' or   reciver='" + Class1.user.ToString + "' order by id DESC  "
            da = New SqlDataAdapter(sql, Con)
            da.Fill(ds, "Time")
            TextBox1.Text = ""
            For count As Integer = 0 To ds.Tables("Time").Rows.Count - 1
                TextBox1.Text += (ds.Tables("Time").Rows(count).Item("Sender")) + ":" + (ds.Tables("Time").Rows(count).Item("Note")) + vbCrLf
            Next
            Con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub DropDownList2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList2.SelectedIndexChanged
        Label2.Text = DropDownList2.SelectedValue.ToString

       
    End Sub
End Class
