
Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand

    Sub openCon()
        con.ConnectionString = "server=100,94,231,52; username=kelvin; password=; database=testing_db"
        con.Open()
    End Sub

End Module


