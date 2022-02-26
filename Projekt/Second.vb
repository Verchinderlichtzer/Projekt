Imports System.Data.OleDb
Public Class Second
    ' this is the structure to store person information
    Structure PersonInfo
        Dim Name As String
        Dim Tel As String
        Dim Sal As Decimal
        Dim LincenseNumber As String
    End Structure
    ' this is the array to store persons' info
    Dim Info() As PersonInfo
    ' read the information and store it in an array
    Public Sub ReadInfo()
        Dim I As Integer
        Dim N As Integer
        N = InputBox("Enter the number of people")
        ReDim Info(0 To N - 1)
        ' read info here
        For I = 0 To N - 1
            Info(I).Name = InputBox("enter the name of person")
            Info(I).Tel = InputBox("enter the telephone number")
            Info(I).Sal = InputBox("enter the salary")
            Info(I).LincenseNumber = InputBox("enter license number")
        Next
    End Sub
    ' fill the data grid with array info
    Public Sub FillDGV(DAT() As PersonInfo, DGV As DataGridView)
        DGV.Rows.Clear()
        Dim I As Integer
        For I = 0 To DAT.Length - 1
            DGV.Rows.Add(DAT(I).Name, DAT(I).Tel, DAT(I).Sal, DAT(I).LincenseNumber)
        Next
    End Sub
    ' the sort subroutine
    Public Sub Sort(ByRef Arr() As PersonInfo)
        Dim Flg As Boolean
        Dim I As Integer
        Dim Tmp As PersonInfo
        Do
            Flg = False
            For I = 0 To Arr.Length - 2
                If Arr(I).Name > Arr(I + 1).Name Then
                    Tmp = Arr(I)
                    Arr(I) = Arr(I + 1)
                    Arr(I + 1) = Tmp
                    Flg = True
                End If
            Next
        Loop While Flg
    End Sub
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    ReadInfo()
    '    FillDGV(Info, DataGridView1)
    'End Sub
    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Sort(Info)
    '    FillDGV(Info, DataGridView1)
    'End Sub

    '#Region "Databased"
    '    Dim FetchData As Integer
    '    Dim CurrentPage As Integer = 1

    '    Sub Counter()
    '        QR("SELECT COUNT(*) FROM TBLManusia")
    '        TCounter.Text = CurrentPage & " / " & Math.Ceiling(DR(0) / 7)
    '    End Sub

    '    Private Sub Second_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        Column1.Items.Clear()

    '        'For x = 1 To 40
    '        '    'Column1.Items.Add(x)
    '        '    KryptonTextBox1.AutoCompleteCustomSource.Add(x)
    '        'Next
    '        DA = New OleDbDataAdapter("SELECT * FROM TBLManusia", CONN)
    '        DS = New DataSet
    '        DA.Fill(DS, FetchData, 7, 0)
    '        DGV.DataSource = DS.Tables(0)
    '        DGV.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
    '        DGV.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
    '        DGV.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
    '        Counter()
    '    End Sub

    '    Private Sub BTNKiriClick(sender As Object, e As EventArgs) Handles BTNKiri.Click
    '        If CurrentPage = 1 Then Exit Sub
    '        FetchData -= 7
    '        DS.Clear()
    '        DA.Fill(DS, FetchData, 7, 0)
    '        CurrentPage -= 1
    '        Counter()
    '    End Sub

    '    Private Sub BTNKananClick(sender As Object, e As EventArgs) Handles BTNKanan.Click
    '        If CurrentPage = Math.Ceiling(DR(0) / 7) Then Exit Sub
    '        FetchData += 7
    '        DS.Clear()
    '        DA.Fill(DS, FetchData, 7, 0)
    '        CurrentPage += 1
    '        Counter()
    '    End Sub

    '    Private Sub DGV_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.ColumnHeaderMouseClick
    '        Dim x As Integer = -1
    '        If e.ColumnIndex = 0 Then
    '            If x = 0 Then
    '                DA = New OleDbDataAdapter("SELECT * FROM TBLManusia ORDER BY ID DESC", CONN)
    '            Else
    '                DA = New OleDbDataAdapter("SELECT * FROM TBLManusia ORDER BY ID", CONN)
    '            End If
    '            x = 0
    '        ElseIf e.ColumnIndex = 1 Then
    '            DA = New OleDbDataAdapter("SELECT * FROM TBLManusia ORDER BY Nama", CONN)
    '        ElseIf e.ColumnIndex = 2 Then
    '            DA = New OleDbDataAdapter("SELECT * FROM TBLManusia ORDER BY Umur", CONN)
    '        End If

    '        DS = New DataSet
    '        DA.Fill(DS, FetchData, 7, 0)
    '        DGV.DataSource = DS.Tables(0)
    '    End Sub

    '    Private Sub SortirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortirToolStripMenuItem.Click
    '        MsgBox("Awal")
    '        SuspendLayout()
    '        MsgBox("Akhir")
    '        ResumeLayout()
    '        MsgBox("Tengah")
    '    End Sub

    '#End Region

#Region "Arr"
    Dim Arr(99, 1)
    Dim NoArr As Integer = -1

    Dim FetchData As Integer
    Dim CurrentPage As Integer = 1

    Sub Counter()
        TCounterArr.Text = CurrentPage & " / " & Math.Ceiling((NoArr + 1) / 6)
    End Sub

    Private Sub BTNTambahArr_Click(sender As Object, e As EventArgs) Handles BTNTambahArr.Click
        NoArr += 1
        Arr(NoArr, 0) = TAngka.Text
        Arr(NoArr, 1) = THuruf.Text

        DGVArr.Rows.Clear()
        For x = FetchData To FetchData + 5
            If IsNothing(Arr(x, 0)) Then Exit For
            DGVArr.Rows.Add(Arr(x, 0), Arr(x, 1))
        Next

        Counter()
    End Sub

    Private Sub BTNKiriArr_Click(sender As Object, e As EventArgs) Handles BTNKiriArr.Click
        If CurrentPage = 1 Then Exit Sub
        FetchData -= 6

        DGVArr.Rows.Clear()
        For x = FetchData To FetchData + 5
            If IsNothing(Arr(x, 0)) Then Exit For
            DGVArr.Rows.Add(Arr(x, 0), Arr(x, 1))
        Next

        CurrentPage -= 1
        Counter()
    End Sub

    Private Sub BTNKananArr_Click(sender As Object, e As EventArgs) Handles BTNKananArr.Click
        If CurrentPage = Math.Ceiling((NoArr + 1) / 6) Then Exit Sub
        FetchData += 6

        DGVArr.Rows.Clear()
        For x = FetchData To FetchData + 5
            If IsNothing(Arr(x, 0)) Then Exit For
            DGVArr.Rows.Add(Arr(x, 0), Arr(x, 1))
        Next

        CurrentPage += 1
        Counter()
    End Sub
#End Region
End Class
