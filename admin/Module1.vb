
Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand

    'Recommend to change method name based on user access
    Sub openCon()
        con.ConnectionString = "server=100.113.245.127; username=kelv; password=kel; database=kyky"
        con.Open()
    End Sub

    'Make methods for update, select, and delete for code reuse 



End Module


