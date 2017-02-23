Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim Con As New SqlConnection(Module1.constring)
        Con.Open()
        Dim sql As String
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        sql = "SELECT * FROM [Account]  where UserName='" + txtusername.Text + "' and Password='" + txtpass.Text + "' "
        da = New SqlDataAdapter(sql, Con)
        da.Fill(ds, "Time2")
        Try
            If ds.Tables("Time2").Rows.Count > 0 Then

                Try
                    Dim myCommand As SqlCommand
                    Dim ra As Integer
                    Dim myConnection As New SqlConnection(Module1.constring)
                    myConnection.Open()
                    myCommand = New SqlCommand("UPDATE  Account SET Status = 'Active' WHERE (UserName = '" + txtusername.Text.Trim + "' ) ", myConnection)
                    ra = myCommand.ExecuteNonQuery()
                    myConnection.Close()
                Catch ex As Exception

                End Try
                Me.Hide()
                Module1.user = txtusername.Text
                Module1.room = ComboBox1.SelectedItem.ToString
                MainMenu.Show()
            Else
                lblmes.Text = "Plese use valid Username and password"
            End If
        Catch ex As Exception
            lblmes.Text = "Error"
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim Con As New SqlConnection(Module1.constring)
            Con.Open()
            Dim ds As New DataSet
            Dim da As SqlDataAdapter
            Dim sql As String
            sql = "SELECT roomname  FROM room    "
            da = New SqlDataAdapter(sql, Con)
            da.Fill(ds, "Time")

            For count As Integer = 0 To ds.Tables("Time").Rows.Count - 1
                ComboBox1.Items.Add(ds.Tables("Time").Rows(count).Item("roomname"))
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class
