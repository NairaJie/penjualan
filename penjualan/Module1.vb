
Imports MySql.Data.MySqlClient
Module Module1
    Public strkon As String = "server=localhost; userid=root; database=dppenjualannai"
    Public kon As New MySqlConnection(strkon)
    Public perintah As New MySqlCommand
    Public cek As MySqlDataReader
    Public mda As New MySqlDataAdapter
    Public ds As New DataSet
End Module