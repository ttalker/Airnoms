
Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand

    'Recommend to change method name based on user access
    Sub openCon()
        con.ConnectionString = "server=100.89.19.71; username=root; password=; database=testing_db"
        con.Open()
    End Sub

    'Make methods for update, select, and delete for code reuse 



End Module


