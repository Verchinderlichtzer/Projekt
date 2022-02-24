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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReadInfo()
        FillDGV(Info, DataGridView1)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Sort(Info)
        FillDGV(Info, DataGridView1)
    End Sub

    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
        Dim Koleksi As New Collection
        Koleksi.Add(Button1)
        Koleksi.Add(Button2)
        Koleksi.Add(DataGridView1)
        For Each x In Koleksi
            MsgBox(x.Width)
        Next
    End Sub
    Dim Waktu As Date
    Dim ff As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Waktu = Now
        KryptonButton1.Text = Format(Waktu, "HH:mm:ss")
        ff += 1
        Label1.Text = ff
    End Sub
    Private Sub KryptonButton1_TextChanged(sender As Object, e As EventArgs) Handles KryptonButton1.TextChanged
        'If KryptonButton1.Text = MaskedTextBox1.Text Then
        '    MsgBox("Bingo")
        'End If
    End Sub
End Class
