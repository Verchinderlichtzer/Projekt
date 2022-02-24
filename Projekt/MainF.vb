Imports MadMilkman.Ini
Public Class MainF
    Friend Uc As UserControl
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub LBLTitle_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Public Sub LBLTitle_MouseMove(sender As Object, e As MouseEventArgs)
        If MoveForm Then Location += (e.Location - MoveForm_MousePosition)
    End Sub

    Public Sub LBLTitle_MouseUp(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then MoveForm = 0
    End Sub

    Private Sub BTNForm(sender As Object, e As EventArgs) Handles BTN9.Click, BTN8.Click, BTN7.Click, BTN6.Click, BTN5.Click, BTN4.Click, BTN3.Click, BTN20.Click, BTN2.Click, BTN19.Click, BTN18.Click, BTN17.Click, BTN16.Click, BTN15.Click, BTN14.Click, BTN13.Click, BTN12.Click, BTN11.Click, BTN10.Click, BTN1.Click
        PanelForm.Controls.Clear()
        Dim BTNMenu() As Object = {BTN1, BTN2, BTN3, BTN4, BTN5, BTN6, BTN7, BTN8, BTN9, BTN10, BTN11, BTN12, BTN13, BTN14, BTN15, BTN16, BTN17, BTN18, BTN19, BTN20}
        For Each x In BTNMenu
            x.Checked = 0
            If x Is sender Then x.Checked = 1
        Next
        If sender Is BTN1 Then
            Text = "User"
            Uc = New First
        ElseIf sender Is BTN2 Then
            Text = "Barang"
            Uc = New Second
        End If
        PanelForm.Controls.Add(Uc)
    End Sub

    Private Sub MainF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrimerComboBox1.Items.Clear()
        PrimerComboBox2.Items.Clear()
        SekunderComboBox1.Items.Clear()
        SekunderComboBox2.Items.Clear()
        For x = 4 To 39 Step 3
            PrimerComboBox1.Items.Add(x)
            PrimerComboBox2.Items.Add(x)
            SekunderComboBox1.Items.Add(x)
            SekunderComboBox2.Items.Add(x)
        Next
    End Sub

    Dim y As Boolean = False

    Private Sub BTNClear_Click(sender As Object, e As EventArgs) Handles BTNClear.Click
        If y = False Then y = True Else y = False
        Dim z() As Object = {PrimerTextBox2, PrimerComboBox2, PrimerBTN2, PrimerDTP2, PrimerCB2, PrimerRB2, SekunderTextBox2, SekunderComboBox2, SekunderBTN2, SekunderDTP2, SekunderCB2, SekunderRB2}
        For Each Saklar In z
            Saklar.Enabled = y
        Next
    End Sub

    Private Sub BTNHapus_Click(sender As Object, e As EventArgs) Handles BTNHapus.Click
        MsgBox(Size.Width & " x " & Size.Height)
    End Sub
End Class