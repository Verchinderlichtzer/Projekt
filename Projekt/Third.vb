Public Class Third
    Private Sub PrimerBTN1_Click(sender As Object, e As EventArgs) Handles PrimerBTN1.Click
        Dim Mymsg As New BasicMsg("Konfirmasi Hapus", "Apakah asdasd asd a sdfsdfsdf sfsd fsd fssd asd asd a anda yakin ingin hapus Buku Tulis?")
        If Mymsg.ShowDialog() = DialogResult.Yes Then
            MsgBox("Ya")
        Else
            MsgBox("Tidak")
        End If
    End Sub
    '    Private Sub btnCallMessagebox_Click(sender As Object, e As EventArgs) Handles btnCallMessagebox.Click
    '        'Ini salah satu cara memanggil messageboxnya
    '        'Untuk iconnya bisa kalian ambil dari reference image kalian sendiri, formatnya HARUS berformat PNG atau JPEG atau BMP
    '
    '        If CustomMsgBox.Show(Me, "This is a custom message box ^_^", SystemIcons.Information.ToBitmap, _
    '                             CustomMsgBox.CustomMsgBoxButtons.YesNo, "Hello !", False) = CustomMsgBox.CustomMsgBoxResult.Yes Then
    '            CustomMsgBox.Show(Me, "Tombol Yes telah di klik", SystemIcons.Information.ToBitmap, _
    '                              CustomMsgBox.CustomMsgBoxButtons.Ok, "Information", False)
    '        Else
    '            CustomMsgBox.Show(Me, "Tombol No telah di klik", SystemIcons.Information.ToBitmap, _
    '                              CustomMsgBox.CustomMsgBoxButtons.Ok, "Information", False)
    '        End If
    '    End Sub
    '    
    'Sub BtnCallMessageboxClick(sender As Object, e As EventArgs)
    '    Dim Mymsg As New newmsgbox("This is Title", "this is desc", MsgBoxStyle.Information)
    '    If Mymsg.ShowDialog() = DialogResult.Cancel Then
    '        Me.BackColor = Color.Red
    '    Else
    '        Me.BackColor = Color.Green
    '    End If

    'End Sub
End Class
