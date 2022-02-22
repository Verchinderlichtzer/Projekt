Public Class First
    Private Sub First_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each x In Arrayx
            LBFunctions.Items.Add(x)
        Next
    End Sub

#Region "1. Read / Write Txt File"

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        TNotepad.Text = ""
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName = "" Then
            Exit Sub
        End If
        ' this part saves the file
        FileOpen(1, SaveFileDialog1.FileName, OpenMode.Output)
        Print(1, TNotepad.Text)
        FileClose(1)
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName = "" Then
            Exit Sub
        End If
        ' this part loads the file
        Dim Tmp As String
        Tmp = ""
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Input)
        Do While Not EOF(1)
            Tmp = Tmp & LineInput(1)
            If Not EOF(1) Then
                Tmp = Tmp & Chr(13) & Chr(10)
            End If
        Loop
        FileClose(1)
        TNotepad.Text = Tmp
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        TNotepad.Font = FontDialog1.Font
        MaskedTextBox1.Font = FontDialog1.Font
        RichTextBox1.Font = FontDialog1.Font
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.ExitThread()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Clipboard.SetText(TNotepad.Text)
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        Clipboard.SetText(TNotepad.Text)
        TNotepad.SelectedText = ""
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        TNotepad.SelectedText = Clipboard.GetText
    End Sub

#End Region

#Region "2. Array, Collection"

    Dim Arrayz(7) As String

    Private Sub BTNTampilArray_Click(sender As Object, e As EventArgs) Handles BTNTampilArray.Click
        For x = 1 To Arrayz.Length
            Arrayz(x) = InputBox("Masukkeun...!")
        Next

        For Each y In Arrayz
            LBArray.Items.Add(y)
        Next
    End Sub


    ' we define two arrays one to store names, another to store marks
    Dim Names() As String
    Dim Marks() As Integer
    ' we define a variable to store how many element of the array we 
    ' used
    Dim StCount As Integer = 0

    Private Sub BTNInputSiswa_Click(sender As Object, e As EventArgs) Handles BTNInputSiswa.Click
        ReDim Preserve Names(StCount)
        ReDim Preserve Marks(StCount)
        ' read the name and mark and put them in the next empty slot
        Names(StCount) = InputBox("Masukkan Nama Siswa")
        Marks(StCount) = InputBox("Masukkan Nilai")
        ' the new name and mark should be displayed on the data grid
        DGV1.Rows.Add(Names(StCount), Marks(StCount))
        ' move the counter to the next empty slot
        StCount += 1
    End Sub

    Private Sub BTNTerbesar_Click(sender As Object, e As EventArgs) Handles BTNTerbesar.Click
        ' find the maximum mark
        Dim I As Integer ' used for counting
        Dim MaxPos As Integer ' used to remember the index of 
        ' maximum mark
        MaxPos = 0 ' assume first mark is the maximum
        For I = 1 To StCount - 1 ' loop over all other slots
            ' is there an element with a mark greater than the current maximum?
            If Marks(I) > Marks(MaxPos) Then
                MaxPos = I ' we found a new max, 
                ' update our maximum
            End If
        Next
        MsgBox("siswa " & Names(MaxPos) & " nilainya tertinggi!")
        'MsgBox("siswa " & Marks.Max & " nilainya tertinggi!")
    End Sub

    Private Sub BTNTerkecil_Click(sender As Object, e As EventArgs) Handles BTNTerkecil.Click
        ' find minimum
        ' it is identical to the previous, except for the condition
        Dim I As Integer
        Dim MinPos As Integer
        MinPos = 0
        For I = 1 To StCount - 1
            If Marks(I) < Marks(MinPos) Then
                MinPos = I
            End If
        Next
        MsgBox("siswa " & Names(MinPos) & " nilainya terendah!")
        'MsgBox("siswa " & Marks.Min & " nilainya terendah!")
    End Sub

    Private Sub BTNRataRata_Click(sender As Object, e As EventArgs) Handles BTNRataRata.Click
        Dim I As Integer ' I is counter
        Dim AVG As Double ' Used to store the sum and finding 
        ' the average
        AVG = 0 ' The avg is zero
        For I = 0 To StCount - 1 ' Loop over all elements in the 
            ' array
            AVG += Marks(I) ' Add each element to the some of 
            ' the previous ones
        Next
        AVG /= StCount ' divide the total by number of 
        ' elements to get the average
        MsgBox("rata-rata nilai:" & AVG)
    End Sub

    Private Sub BTNGetUpperBound_Click(sender As Object, e As EventArgs) Handles BTNGetUpperBound.Click
        MsgBox(Names.GetUpperBound(0))
    End Sub

    Private Sub BTNLength_Click(sender As Object, e As EventArgs) Handles BTNLength.Click
        MsgBox(Names.Length)
    End Sub

    'Collection
    Dim MyCollection As New Collection

    Private Sub BTNClear_Click(sender As Object, e As EventArgs) Handles BTNClear.Click
        ' this method clears all the elements in the collection
        MyCollection.Clear()
    End Sub

    Private Sub BTNTambah_Click(sender As Object, e As EventArgs) Handles BTNTambah.Click
        ' read a name
        Dim Name As String
        Name = InputBox("enter a name")
        ' add the name into the list
        If Name IsNot Nothing Then MyCollection.Add(Name)
    End Sub

    Private Sub BTNGetNumber_Click(sender As Object, e As EventArgs) Handles BTNGetNumber.Click
        MsgBox("the number of items is:" & MyCollection.Count)
    End Sub

    Private Sub BTNViewItem_Click(sender As Object, e As EventArgs) Handles BTNViewItem.Click
        ' clear old content
        LBCollection.Items.Clear()
        ' insert the items into the list box
        For Each x In MyCollection
            LBCollection.Items.Add(x)
        Next

    End Sub

    Private Sub BTNRemove_Click(sender As Object, e As EventArgs) Handles BTNRemove.Click
        ' get element position
        Dim I As Integer
        I = InputBox("enter the element number you want to remove:")
        MyCollection.Remove(I)
    End Sub

    Private Sub BTNReplace_Click(sender As Object, e As EventArgs) Handles BTNReplace.Click
        ' get element position
        Dim I As Integer
        Dim N As String
        I = InputBox("enter the element number:")
        N = InputBox("enter the new name:")
        MyCollection.Add(N, , , I)
        MyCollection.Remove(I)
    End Sub
#End Region

#Region "3. Random"

    Dim AngkaRahasia As Integer
    Dim Percobaan As Integer
    Private Sub BTNStart_Click(sender As Object, e As EventArgs) Handles BTNMulai.Click
        Randomize()
        AngkaRahasia = Int(Rnd() * 100)
        Percobaan = 0
        LB1.Items.Clear()
        LBL1.Text = "Percobaan ke-" & Percobaan.ToString
    End Sub

    Private Sub BTNGuess_Click(sender As Object, e As EventArgs) Handles BTNTebak.Click
        Dim MyNumber As Integer
        Dim Tmp As String = InputBox("Masukin angka antara 1 sampai 100", "Tebak Angka")
        If IsNumeric(Tmp) Then
            MyNumber = Tmp
        Else
            MsgBox("harus angka")
            Exit Sub
        End If
        If MyNumber = AngkaRahasia Then
            MsgBox("Jawabannya " & AngkaRahasia, MsgBoxStyle.OkOnly, "Anda Benar!")
        ElseIf MyNumber > AngkaRahasia Then
            LB1.Items.Add("Kecilin!")
        Else
            LB1.Items.Add("Gedein!")
        End If
        Percobaan += 1
        LBL1.Text = "Percobaan ke-" & Percobaan.ToString
    End Sub

    Shared Acak As New Random()
    Private Sub BTNRandom_Click(sender As Object, e As EventArgs) Handles BTNRandom.Click
        Dim i As Integer
        For i = 1 To 10
            MsgBox(Convert.ToString(Acak.Next(10, 21)))
        Next
    End Sub

#End Region

#Region "4. Bilangan Prima"

    Private Sub BTNBilanganPrima_Click(sender As Object, e As EventArgs) Handles BTNBilanganPrima.Click
        Dim MyNumber As Integer
        Dim RemainderIsZeroFlag As Boolean
        Dim I As Integer
        ' read a number from the screen
        MyNumber = InputBox("Enter a number")
        ' this is a flag to tell us when the condition 
        ' of prime number is not satisfied
        RemainderIsZeroFlag = False
        ' start checking all the numbers
        For I = 2 To MyNumber - 1
            ' if the condition is not satisfied
            If MyNumber Mod I = 0 Then
                ' mark that the remainder is not zero
                RemainderIsZeroFlag = True
            End If
        Next
        ' if there was any remainder then tell the user
        ' that the number is not prime, else it is.
        If RemainderIsZeroFlag Then
            MsgBox("The number is not prime")
        Else
            MsgBox("The number is prime")
        End If
    End Sub

#End Region

#Region "5. Functions"
    Function Factorial(N As Integer) As Double
        Dim F As Double ' the factorial total
        Dim I As Integer ' the counter
        F = 1 ' the initial value of F
        For I = 1 To N ' this loop to calculate the factorial
            F *= I
        Next
        Return F ' return the result 
    End Function

    Private Sub BTNFactorial_Click(sender As Object, e As EventArgs) Handles BTNFactorial.Click
        MsgBox(Factorial(8))
    End Sub

    ' the max value in an array
    Function GetMax(A() As Integer) As Integer
        Dim I As Integer
        Dim Max As Integer
        Max = A(0) ' assume the max value is the 
        ' first value
        For I = 1 To A.Length - 1 ' loop over all other values in 
            ' an array
            If Max < A(I) Then ' if we find another value 
                ' larger than max then
                Max = A(I) ' update max 
            End If
        Next
        Return Max ' return the result
    End Function
    ' the avg value of an array
    Function GetAVG(A() As Integer) As Integer
        Dim I As Integer
        Dim sum As Integer
        sum = 0 ' assume the sum value is 0
        For I = 0 To A.Length - 1 ' loop over all other values in 
            ' an array
            sum = sum + A(I)
        Next
        Return sum / A.Length ' return the result
    End Function
    ' read array
    Function ReadArray() As Integer()
        ' the counter
        Dim I As Integer
        ' the number of elements
        Dim N As Integer
        ' read the number of elements from the display
        N = InputBox("how many elements in the array")
        ' create the array
        Dim A(0 To N - 1) As Integer
        ' read the elements of the array
        For I = 0 To N - 1
            A(I) = InputBox("enter the element:" & I.ToString)
        Next
        ' return the result
        Return A
    End Function

    Dim Arrayx() As Integer = {44, 33, 22, 717, 95, 88, 77, 66, 55}

    Private Sub BTNGetMax_Click(sender As Object, e As EventArgs) Handles BTNGetMax.Click
        MsgBox(GetMax(Arrayx))
    End Sub

    Private Sub BTNGetAVG_Click(sender As Object, e As EventArgs) Handles BTNGetAVG.Click
        MsgBox(GetAVG(Arrayx))
    End Sub

    Private Sub BTNReadArray_Click(sender As Object, e As EventArgs) Handles BTNReadArray.Click
        ReadArray()
    End Sub

    Function TestByVal(N As Integer) As Integer
        N = 0
        Return N
    End Function

    Function TestByRef(ByRef N As Integer) As Integer
        N = 0
        Return N
    End Function

    Private Sub BTNByValByRef_Click(sender As Object, e As EventArgs) Handles BTNByValByRef.Click
        Dim K1 As Integer = 100
        TestByVal(K1)
        MsgBox(K1)
        Dim K2 As Integer = 100
        TestByRef(K2)
        MsgBox(K2)
    End Sub

    Function Swap(ByRef V1 As Integer, ByRef V2 As Integer)
        Dim Tmp As Integer
        Tmp = V1
        V1 = V2
        V2 = Tmp
        'ByRef - ByRef = N2 - N1 (Dibalik)
        '- = N1 - N2 (Normal)
        '- ByRef = N1 - N1 (Inputan pertama semua)
        Return Nothing
    End Function

    Private Sub BTNSwap_Click(sender As Object, e As EventArgs) Handles BTNSwap.Click
        Dim N1 As Integer
        Dim N2 As Integer
        N1 = InputBox("Enter N1")
        N2 = InputBox("Enter N2")
        Swap(N1, N2)
        MsgBox("N1:" & N1)
        MsgBox("N2:" & N2)
    End Sub

    Dim A() As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
        Dim Count As Integer
        Count = InputBox("enter the number of values:")
        ReDim A(0 To Count - 1)
        Dim I As Integer
        For I = 0 To Count - 1
            A(I) = Integer.Parse(InputBox("Enter the value " & I))
        Next
        ViewArray(A, ListBox1)
    End Sub

    Public Sub ViewArray(Ar() As Integer, L As ListBox)
        L.Items.Clear()
        Dim I As Integer
        For I = 0 To Ar.Length - 1
            L.Items.Add(Ar(I))
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles KryptonButton2.Click
        ' sort
        Dim I As Integer
        Dim J As Integer
        Dim Flag As Boolean
        Do
            Flag = False
            For I = 0 To A.Length - 2
                If A(I) > A(I + 1) Then
                    Flag = True
                    J = A(I)
                    A(I) = A(I + 1)
                    A(I + 1) = J
                End If
            Next
        Loop Until Flag = False
        ViewArray(A, ListBox1)

    End Sub

#End Region

End Class
