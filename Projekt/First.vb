Public Class First
    Private Sub First_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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
        Clipboard.SetText(TNotepad.SelectedText)
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        Clipboard.SetText(TNotepad.SelectedText)
        TNotepad.SelectedText = ""
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        TNotepad.SelectedText = Clipboard.GetText
    End Sub

    Dim SecretNumber As Integer
    Dim Attempts As Integer
    Private Sub BTNStart_Click(sender As Object, e As EventArgs) Handles BTNStart.Click
        Randomize()
        SecretNumber = Int(Rnd() * 100)
        Attempts = 0
        LB1.Items.Clear()
        LBL1.Text = "Attempts:" & Attempts.ToString
    End Sub

    Private Sub BTNGuess_Click(sender As Object, e As EventArgs) Handles BTNGuess.Click
        Dim MyNumber As Integer
        Dim Tmp As String = InputBox("Enter a number between 1 and 100", "Guessing game")
        If IsNumeric(Tmp) Then
            MyNumber = Tmp
        Else
            MsgBox("harus angka")
            Exit Sub
        End If
        If MyNumber = SecretNumber Then
            MsgBox("Anda Benar!")
        ElseIf MyNumber > SecretNumber Then
            LB1.Items.Add("kecilin")
        Else
            LB1.Items.Add("gedein")
        End If
        Attempts += 1
        LBL1.Text = "Attempts:" & Attempts.ToString
    End Sub

    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
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
End Class
