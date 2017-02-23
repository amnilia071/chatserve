Imports System.Data.SqlClient
Imports System.Data
Partial Class SignUp
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text = TextBox2.Text Then
                Dim myCommand As SqlCommand
                Dim ra As Integer
                Dim myConnection As New SqlConnection(ConfigurationManager.ConnectionStrings("Constring").ConnectionString)
                myConnection.Open()
                myCommand = New SqlCommand("INSERT INTO [Account] ( [UserName],[Password]  ,[Autentication] ,room,Status)  VALUES ( '" + txtusername.Text + "', '" + TextBox1.Text + "', '" + DropDownList1.SelectedItem.ToString + "', '" + DropDownList1.SelectedItem.ToString + "','Offline')", myConnection)
                ra = myCommand.ExecuteNonQuery()
                lblmes.Text = "Thanks Sucesfully saved"
                myConnection.Close()
            Else
                TextBox1.Text = ""
                TextBox2.Text = ""
            End If

        Catch ex As Exception

        End Try
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
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class
