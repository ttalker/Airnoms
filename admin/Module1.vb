
Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand

    Sub openCon()
        con.ConnectionString = "server=26.143.215.198; username=ky; password=ky; database=testing_db"
        con.Open()
    End Sub

End Module


