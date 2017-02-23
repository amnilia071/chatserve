Imports System.Data.SqlClient
Imports System.Data
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim Con As New SqlConnection(ConfigurationManager.ConnectionStrings("Constring").ConnectionString)
            Con.Open()
            Dim ds As New DataSet
            Dim da As SqlDataAdapter
            Dim sql As String
            sql = "SELECT * FROM Account where UserName ='" + txtusername.Text + "' and Password='" + txtpassword.Text + "'  order by id DESC  "
            da = New SqlDataAdapter(sql, Con)
            da.Fill(ds, "Time")
            If ds.Tables("Time").Rows.Count > 0 Then
                Class1.user = txtusername.Text
                Response.Redirect("~/Menu.aspx")
            End If

        Catch ex As Exception
            lblmes.Text = "please use valid passwor"
        End Try
    End Sub
End Class
