Public Class AdvancedMsg
    '#Region "Deklarasi fungsi dan Const"
    '    Private Declare Function RemoveMenu Lib "user32" (ByVal hMenu As IntPtr, ByVal nPosition As Integer, ByVal wFlags As Integer) As Integer
    '    Private Declare Function GetSystemMenu Lib "user32" (ByVal hWnd As Integer, ByVal bRevert As Boolean) As IntPtr
    '    Private Declare Function GetMenuItemCount Lib "user32" (ByVal hMenu As IntPtr) As Integer
    '    Private Declare Function DrawMenuBar Lib "user32" (ByVal hWnd As IntPtr) As Boolean

    '    Private Const MF_ByPosition = &H400
    '    Private Const MF_Remove = &H1000
    '    Private Const MF_Disabled = &H2
    '#End Region

    '#Region "Kumpulan Method dan Pembuatan Menu"
    '    Private Sub DisabledClosedButton(ByVal hWnd As IntPtr)
    '        Dim hMenu As IntPtr : Dim menuItemCount As Integer
    '        hMenu = GetSystemMenu(hWnd, False)
    '        menuItemCount = GetMenuItemCount(hMenu)

    '        Call RemoveMenu(hMenu, menuItemCount - 1, MF_Disabled Or MF_ByPosition)
    '        Call RemoveMenu(hMenu, menuItemCount - 2, MF_Disabled Or MF_ByPosition)
    '        Call DrawMenuBar(hWnd)
    '    End Sub

    '    Enum CustomMsgBoxResult 'Ini untuk menghasilkan hasil resultnya
    '        Ok
    '        Cancel
    '        Yes
    '        No
    '    End Enum

    '    Enum CustomMsgBoxButtons 'Ini untuk membuat list tombolnya yang ditampilkan di library codenya nanti
    '        Ok
    '        Cancel
    '        Yes
    '        No
    '        OkCancel
    '        YesNoCancel
    '        YesNo
    '    End Enum

    '    Public Result As CustomMsgBoxResult

    '    Public Overloads Function Show(ByVal mParent As Form, ByVal msgboxMessage As String, ByVal msgboxIcon As Bitmap, ByVal msgboxButtons As CustomMsgBoxButtons,
    '                                Optional ByVal msgboxTitle As String = "", Optional ByVal msgboxInherit As Boolean = False) As CustomMsgBoxResult
    '        lblTitle.Text = msgboxTitle 'Ini untuk Judul messageboxnya
    '        lblDesc.Text = msgboxMessage 'Ini untuk isi messageboxnya
    '        pictIcon.BackgroundImage = msgboxIcon 'ini untuk iconnya
    '        pictIcon.BackgroundImageLayout = ImageLayout.Stretch 'saya kasih size mode Stretch supaya ukurannya selalu pas dengan ukuran picturebox 
    '        'yang sudah saya sediakan
    '        Me.Icon = mParent.Icon 'ini untuk menyamakan icon form messageboxnya

    '        For Each Butt As Control In Panel3.Controls 'Fungsi ini untuk membuat tombolnya tidak terlihat dulu
    '            If TypeOf Butt Is Button Then
    '                Butt.Visible = False
    '            End If
    '        Next

    '        'Disinilah fungsi dimana tombol-tombol tersebut dapat tampil sesuai dengan menu yang kita buat tadi
    '        If msgboxButtons = CustomMsgBoxButtons.Cancel Then
    '            btnCancel.Visible = True
    '        ElseIf msgboxButtons = CustomMsgBoxButtons.Ok Then
    '            btnOK.Visible = True
    '        ElseIf msgboxButtons = CustomMsgBoxButtons.No Then
    '            btnNo.Visible = True
    '        ElseIf msgboxButtons = CustomMsgBoxButtons.OkCancel Then
    '            btnOK.Visible = True
    '            btnCancel.Visible = True
    '        ElseIf msgboxButtons = CustomMsgBoxButtons.Yes Then
    '            btnYes.Visible = True
    '        ElseIf msgboxButtons = CustomMsgBoxButtons.YesNo Then
    '            btnYes.Visible = True
    '            btnNo.Visible = True
    '        ElseIf msgboxButtons = CustomMsgBoxButtons.YesNoCancel Then
    '            btnYes.Visible = True
    '            btnNo.Visible = True
    '            btnCancel.Visible = True
    '        End If

    '        'Ini untuk membuat tampilan warna-warna dasar messagebox ini sama dengan form yang kalian buat jika
    '        'msgboxInherit = true
    '        If msgboxInherit Then
    '            Me.Font = mParent.Font
    '            Me.ForeColor = mParent.ForeColor
    '            Me.BackColor = mParent.BackColor

    '            For Each Butt As Control In Panel3.Controls
    '                If TypeOf Butt Is Button Then
    '                    Butt.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
    '                End If
    '            Next
    '        End If

    '        Me.ShowDialog(mParent)
    '        Return Result
    '    End Function
    '#End Region

    '    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    '        Result = CustomMsgBoxResult.Cancel
    '        Me.Close()
    '    End Sub

    '    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
    '        Result = CustomMsgBoxResult.Ok
    '        Me.Close()
    '    End Sub

    '    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
    '        Result = CustomMsgBoxResult.No
    '        Me.Close()
    '    End Sub

    '    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
    '        Result = CustomMsgBoxResult.Yes
    '        Me.Close()
    '    End Sub

    '    Private Sub lblDesc_SizeChanged(sender As Object, e As EventArgs) Handles lblDesc.SizeChanged
    '        'Ini untuk membuat ukuran form messageboxnya menjadi flexibel
    '        Me.Width = lblDesc.Location.X + lblDesc.Width + 20
    '        Me.Height = lblDesc.Height + lblDesc.Location.Y + Panel1.Height
    '    End Sub

    '    Private Sub timerShow_Tick(sender As Object, e As EventArgs) Handles timerShow.Tick
    '        Me.Opacity += 0.1
    '        If Me.Opacity = 1 Then
    '            timerShow.Enabled = False
    '        End If
    '    End Sub

    '    Private Sub CustomMsgBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        Me.Opacity = 0
    '        timerShow.Enabled = True
    '    End Sub
End Class