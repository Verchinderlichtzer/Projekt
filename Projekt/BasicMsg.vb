Partial Public Class BasicMsg
    'Private xTitle As String
    'Public Property Title As String
    '	Get
    '		Return xTitle
    '	End Get
    '	Set(ByVal value As String)
    '		xTitle = value
    '		lblTitle.Text = "test"
    '	End Set
    'End Property

    'Private xDesc As String
    'Public Property Desc As String
    '	Get
    '		Return xDesc
    '	End Get
    '	Set(ByVal value As String)
    '		xDesc = value
    '		lblDesc.Text = value
    '	End Set
    'End Property


    'Public Sub New(ByVal MyTitle As String, MyDesc As String, ByVal MyStyle As MsgBoxStyle)

    '	Me.InitializeComponent()
    '	Me.Title = MyTitle
    '	Me.Desc = MyDesc

    '	Select Case MyStyle
    '		Case MsgBoxStyle.Information
    '			pictIcon.Image = SystemIcons.Information.ToBitmap
    '			'load button disini sesuai modenya, yg didesigner sebaiknya dibuang, itu hanya sample aja
    '		Case MsgBoxStyle.Critical
    '			pictIcon.Image = SystemIcons.Error.ToBitmap
    '		Case MsgBoxStyle.Question
    '			pictIcon.Image = SystemIcons.Question.ToBitmap
    '	End Select
    'End Sub

    'Sub BtnOKClick(sender As Object, e As EventArgs)
    '	Me.DialogResult = vbOK
    'End Sub

    'Sub BtnCancelClick(sender As Object, e As EventArgs)
    '	Me.DialogResult = vbCancel
    'End Sub

    Private xTitle As String
    Public Property Title As String
        Get
            Return xTitle
        End Get
        Set(value As String)
            xTitle = value
            LBLTitle.Text = value
        End Set
    End Property

    Private xDesc As String
    Public Property Desc As String
        Get
            Return xDesc
        End Get
        Set(value As String)
            xDesc = value
            TDesc.Text = value
        End Set
    End Property


    Public Sub New(MyTitle As String, MyDesc As String)
        InitializeComponent()
        Title = MyTitle
        Desc = MyDesc
        PBIcon.Image = My.Resources.konfirmasi
    End Sub

    Private Sub BTNYa_Click(sender As Object, e As EventArgs) Handles BTNYa.Click
        DialogResult = vbYes
    End Sub

    Private Sub BTNTidak_Click(sender As Object, e As EventArgs) Handles BTNTidak.Click
        DialogResult = vbNo
    End Sub
End Class