Imports System.Data.OleDb, System.Environment
Module Module1

    Public CONN As OleDbConnection 'SqlConnection
    Public CMD As OleDbCommand 'SqlCommand
    Public DR As OleDbDataReader 'SqlDataReader
    Public DA As OleDbDataAdapter 'SqlDataAdapter
    Public DS As DataSet

    Public FormStartup As String = Nothing
    Public UserAktif As String = Nothing
    Public Path As String = GetFolderPath(SpecialFolder.ApplicationData) & "\Projekt"

    Public Sub Koneksi()
        'Pilih SQL Server 2005 Express (SqlClient) atau Access DB 2016 (OleDb)
        CONN = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Path & "\Projekt.accdb;Jet OLEDB:Database Password=;")
        CONN.Open()
    End Sub

    Public Sub QR(QueryReader As String)
        CMD = New OleDbCommand(QueryReader, CONN)
        DR = CMD.ExecuteReader
        DR.Read()
    End Sub

    Public Sub QRL(QueryReaderLooping As String)
        CMD = New OleDbCommand(QueryReaderLooping, CONN)
        DR = CMD.ExecuteReader
    End Sub

    Public Sub QN(QueryNonReader As String)
        CMD = New OleDbCommand(QueryNonReader, CONN)
        CMD.ExecuteNonQuery()
    End Sub

    Public Sub QDGV(QueryDGV As String, DataGrid As DataGridView)
        DA = New OleDbDataAdapter(QueryDGV, CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGrid.DataSource = DS.Tables(0)
    End Sub

    'Public Sub Pesan(msg As String, type As FormAlert.AlertTypeEnum)
    '    Dim f As New FormAlert
    '    f.SetAlert(msg, type)
    'End Sub

    Public Sub Angka(e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8 Or (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57)) Then e.Handled = True
    End Sub

    Public Sub Huruf_KeyPress(sender As Object, e As KeyPressEventArgs) 'DGV Input Bebas
        If Asc(e.KeyChar) = 27 Then e.Handled = True
    End Sub

    Public Sub Angka_KeyPress(sender As Object, e As KeyPressEventArgs) 'DGV Input Angka
        Angka(e)
    End Sub

End Module