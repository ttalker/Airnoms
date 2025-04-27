Imports System.IO
Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand

    Sub openCon()
        con.ConnectionString = "server=100.89.19.71; username=root; password=; database=comprog_db"
        con.Open()
    End Sub

End Module