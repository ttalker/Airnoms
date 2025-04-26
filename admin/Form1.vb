Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            openCon()
            MessageBox.Show("Connection Successful!")
        Catch ex As Exception
            MessageBox.Show("Connection Failed: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class
