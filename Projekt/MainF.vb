Imports MadMilkman.Ini
Public Class MainF
    Friend Uc As UserControl
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub LBLTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles LBLTitle.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Public Sub LBLTitle_MouseMove(sender As Object, e As MouseEventArgs) Handles LBLTitle.MouseMove
        If MoveForm Then Location += (e.Location - MoveForm_MousePosition)
    End Sub

    Public Sub LBLTitle_MouseUp(sender As Object, e As MouseEventArgs) Handles LBLTitle.MouseUp
        If e.Button = MouseButtons.Left Then MoveForm = 0
    End Sub

    Private Sub BTNForm(sender As Object, e As EventArgs) Handles BTN9.Click, BTN8.Click, BTN7.Click, BTN6.Click, BTN5.Click, BTN4.Click, BTN3.Click, BTN21.Click, BTN20.Click, BTN2.Click, BTN19.Click, BTN18.Click, BTN17.Click, BTN16.Click, BTN15.Click, BTN14.Click, BTN13.Click, BTN12.Click, BTN11.Click, BTN10.Click, BTN1.Click
        PanelForm.Controls.Clear()
        Dim BTNMenu() As Object = {BTN1, BTN2, BTN3, BTN4, BTN5, BTN6, BTN7, BTN8, BTN9, BTN10, BTN11, BTN12, BTN13, BTN14, BTN15, BTN16, BTN17, BTN18, BTN19, BTN20, BTN21}
        For Each x In BTNMenu
            x.Checked = 0
            If x Is sender Then x.Checked = 1
        Next
        If sender Is BTN1 Then
            LBLTitle.Text = "User"
            Uc = New First
        ElseIf sender Is BTN2 Then
            LBLTitle.Text = "Barang"
            Uc = New Second
        End If
        PanelForm.Controls.Add(Uc)
    End Sub

    Private Sub MainF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TSupplier.Items.Clear()
    End Sub

    Private Sub BTNMinimize_Click(sender As Object, e As EventArgs) Handles BTNMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BTNClose_Click(sender As Object, e As EventArgs) Handles BTNClose.Click
        Application.ExitThread()
    End Sub

    Private Sub MainF_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.ExitThread()
    End Sub

End Class