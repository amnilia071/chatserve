Imports System.Data
Imports System.Data.SqlClient

Public Class ControlPanel

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text = "" Then
            Else
                Dim myCommand As SqlCommand
                Dim ra As Integer
                Dim myConnection As New SqlConnection(Module1.constring)
                myConnection.Open()
                myCommand = New SqlCommand("INSERT INTO [room] ( [roomname])  VALUES ( '" + TextBox1.Text + "')", myConnection)
                ra = myCommand.ExecuteNonQuery()
                myConnection.Close()
                lblmes.Text = "room Created"
                TextBox1.Text = ""
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ControlPanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myConnection As New SqlConnection(Module1.constring)

        Dim dataAdapter2 As SqlDataAdapter
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Dim dataset2 As DataSet
        Dim cmd As SqlCommand = New SqlCommand("SELECT * from room     ", myConnection)
        dataAdapter2 = New SqlDataAdapter(cmd)
        Dim builder As SqlCommandBuilder = New SqlCommandBuilder(dataAdapter2)
        myConnection.Open()
        dataset2 = New DataSet
        dataAdapter2.Fill(dataset2, "AirCrew")
        myConnection.Close()
        DataGridView1.DataSource = dataset2
        DataGridView1.DataMember = "AirCrew"



        'اعداد خصائص داتا جريد برمجيا
        'DataGridView1.EnableHeadersVisualStyles = False

        DataGridView1.RowHeadersWidth = 30
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        DataGridView1.Columns(0).HeaderCell.Style.BackColor = Color.Yellow
         

        DataGridView1.Columns(0).Frozen = True
       

        DataGridView1.Columns(0).HeaderText = "roomname"
      
    End Sub
End Class