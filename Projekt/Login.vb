Public Class Login

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub Login_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Public Sub Login_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If MoveForm Then Location += (e.Location - MoveForm_MousePosition)
    End Sub

    Public Sub Login_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then MoveForm = 0
    End Sub

    Dim x As Integer = 1
    Private Sub BTNRibbon_Click(sender As Object, e As EventArgs) Handles BTNRibbon.Click
        If x = 1 Then
            BackColor = Color.FromArgb(33, 31, 45)
            BackgroundImage = My.Resources.Login_Dark
            BTNRibbon.Location = New Point(121, 131)
            TransparencyKey = Color.FromArgb(255, 57, 85)
            x = 2
        Else
            BackColor = Color.FromArgb(65, 63, 188)
            BackgroundImage = My.Resources.Login_Light
            BTNRibbon.Location = New Point(600, 131)
            TransparencyKey = Color.FromArgb(67, 65, 191)
            x = 1
        End If
    End Sub
End Class