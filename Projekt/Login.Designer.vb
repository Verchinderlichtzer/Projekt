<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.LBLUsername = New Krypton.Toolkit.KryptonLabel()
        Me.TUsername = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLPassword = New Krypton.Toolkit.KryptonLabel()
        Me.TPassword = New Krypton.Toolkit.KryptonTextBox()
        Me.BTNLogin = New Krypton.Toolkit.KryptonButton()
        Me.LBLBatal = New Krypton.Toolkit.KryptonLabel()
        Me.CBCookies = New Krypton.Toolkit.KryptonCheckBox()
        Me.PaletPrimer = New Krypton.Toolkit.KryptonPalette(Me.components)
        Me.BTNRibbon = New Krypton.Toolkit.KryptonButton()
        Me.SuspendLayout()
        '
        'LBLUsername
        '
        Me.LBLUsername.AutoSize = False
        Me.LBLUsername.Location = New System.Drawing.Point(145, 280)
        Me.LBLUsername.Name = "LBLUsername"
        Me.LBLUsername.Size = New System.Drawing.Size(110, 26)
        Me.LBLUsername.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLUsername.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLUsername.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLUsername.TabIndex = 125
        Me.LBLUsername.Values.Text = "Username"
        '
        'TUsername
        '
        Me.TUsername.AlwaysActive = False
        Me.TUsername.Location = New System.Drawing.Point(151, 312)
        Me.TUsername.MaxLength = 255
        Me.TUsername.Name = "TUsername"
        Me.TUsername.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TUsername.Size = New System.Drawing.Size(489, 29)
        Me.TUsername.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TUsername.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TUsername.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.TUsername.StateActive.Border.Rounding = 0!
        Me.TUsername.StateActive.Border.Width = 1
        Me.TUsername.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TUsername.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TUsername.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TUsername.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TUsername.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.TUsername.StateCommon.Border.Rounding = 0!
        Me.TUsername.StateCommon.Border.Width = 1
        Me.TUsername.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TUsername.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.5!)
        Me.TUsername.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TUsername.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TUsername.StateDisabled.Border.Rounding = 0!
        Me.TUsername.StateDisabled.Border.Width = 0
        Me.TUsername.TabIndex = 124
        '
        'LBLPassword
        '
        Me.LBLPassword.AutoSize = False
        Me.LBLPassword.Location = New System.Drawing.Point(145, 359)
        Me.LBLPassword.Name = "LBLPassword"
        Me.LBLPassword.Size = New System.Drawing.Size(110, 26)
        Me.LBLPassword.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLPassword.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLPassword.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLPassword.TabIndex = 125
        Me.LBLPassword.Values.Text = "Password"
        '
        'TPassword
        '
        Me.TPassword.AlwaysActive = False
        Me.TPassword.Location = New System.Drawing.Point(151, 391)
        Me.TPassword.MaxLength = 255
        Me.TPassword.Name = "TPassword"
        Me.TPassword.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TPassword.Size = New System.Drawing.Size(489, 29)
        Me.TPassword.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TPassword.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TPassword.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.TPassword.StateActive.Border.Rounding = 0!
        Me.TPassword.StateActive.Border.Width = 1
        Me.TPassword.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TPassword.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TPassword.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TPassword.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TPassword.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.TPassword.StateCommon.Border.Rounding = 0!
        Me.TPassword.StateCommon.Border.Width = 1
        Me.TPassword.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TPassword.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.5!)
        Me.TPassword.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TPassword.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPassword.StateDisabled.Border.Rounding = 0!
        Me.TPassword.StateDisabled.Border.Width = 0
        Me.TPassword.TabIndex = 124
        '
        'BTNLogin
        '
        Me.BTNLogin.Location = New System.Drawing.Point(151, 484)
        Me.BTNLogin.Name = "BTNLogin"
        Me.BTNLogin.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNLogin.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLogin.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLogin.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNLogin.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNLogin.Size = New System.Drawing.Size(489, 38)
        Me.BTNLogin.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNLogin.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLogin.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLogin.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNLogin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNLogin.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLogin.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNLogin.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNLogin.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BTNLogin.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLogin.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNLogin.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNLogin.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLogin.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BTNLogin.TabIndex = 126
        Me.BTNLogin.Values.Text = "Login"
        '
        'LBLBatal
        '
        Me.LBLBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LBLBatal.Location = New System.Drawing.Point(593, 528)
        Me.LBLBatal.Name = "LBLBatal"
        Me.LBLBatal.Size = New System.Drawing.Size(47, 22)
        Me.LBLBatal.StateCommon.ShortText.Color1 = System.Drawing.SystemColors.Highlight
        Me.LBLBatal.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLBatal.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBatal.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLBatal.TabIndex = 125
        Me.LBLBatal.Values.Text = "Batal"
        '
        'CBCookies
        '
        Me.CBCookies.Enabled = False
        Me.CBCookies.Location = New System.Drawing.Point(151, 430)
        Me.CBCookies.Name = "CBCookies"
        Me.CBCookies.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBCookies.Palette = Me.PaletPrimer
        Me.CBCookies.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.CBCookies.Size = New System.Drawing.Size(140, 25)
        Me.CBCookies.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBCookies.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBCookies.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CBCookies.StateDisabled.ShortText.Color1 = System.Drawing.Color.Gray
        Me.CBCookies.TabIndex = 127
        Me.CBCookies.Values.Text = "Remember Me"
        '
        'PaletPrimer
        '
        Me.PaletPrimer.BasePaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.PaletPrimer.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PaletPrimer.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PaletPrimer.Images.CheckBox.CheckedDisabled = CType(resources.GetObject("resource.CheckedDisabled"), System.Drawing.Image)
        Me.PaletPrimer.Images.CheckBox.CheckedNormal = CType(resources.GetObject("resource.CheckedNormal"), System.Drawing.Image)
        Me.PaletPrimer.Images.CheckBox.CheckedPressed = CType(resources.GetObject("resource.CheckedPressed"), System.Drawing.Image)
        Me.PaletPrimer.Images.CheckBox.CheckedTracking = CType(resources.GetObject("resource.CheckedTracking"), System.Drawing.Image)
        Me.PaletPrimer.Images.CheckBox.Common = CType(resources.GetObject("resource.Common"), System.Drawing.Image)
        Me.PaletPrimer.Images.CheckBox.UncheckedDisabled = CType(resources.GetObject("resource.UncheckedDisabled"), System.Drawing.Image)
        Me.PaletPrimer.Images.RadioButton.CheckedDisabled = CType(resources.GetObject("resource.CheckedDisabled1"), System.Drawing.Image)
        Me.PaletPrimer.Images.RadioButton.CheckedNormal = CType(resources.GetObject("resource.CheckedNormal1"), System.Drawing.Image)
        Me.PaletPrimer.Images.RadioButton.CheckedPressed = CType(resources.GetObject("resource.CheckedPressed1"), System.Drawing.Image)
        Me.PaletPrimer.Images.RadioButton.CheckedTracking = CType(resources.GetObject("resource.CheckedTracking1"), System.Drawing.Image)
        Me.PaletPrimer.Images.RadioButton.Common = CType(resources.GetObject("resource.Common1"), System.Drawing.Image)
        Me.PaletPrimer.Images.RadioButton.UncheckedDisabled = CType(resources.GetObject("resource.UncheckedDisabled1"), System.Drawing.Image)
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateActive.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateActive.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Border.Rounding = 0!
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Border.Width = 1
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateDisabled.Border.Rounding = 0!
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateDisabled.Border.Width = 1
        '
        'BTNRibbon
        '
        Me.BTNRibbon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNRibbon.Location = New System.Drawing.Point(600, 131)
        Me.BTNRibbon.Name = "BTNRibbon"
        Me.BTNRibbon.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.BTNRibbon.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNRibbon.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNRibbon.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNRibbon.Size = New System.Drawing.Size(43, 88)
        Me.BTNRibbon.StateCommon.Back.Color1 = System.Drawing.Color.Transparent
        Me.BTNRibbon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNRibbon.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNRibbon.TabIndex = 128
        Me.BTNRibbon.Values.Text = ""
        '
        'Login
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Projekt.My.Resources.Resources.Login_Light
        Me.ClientSize = New System.Drawing.Size(790, 577)
        Me.Controls.Add(Me.BTNRibbon)
        Me.Controls.Add(Me.CBCookies)
        Me.Controls.Add(Me.BTNLogin)
        Me.Controls.Add(Me.LBLBatal)
        Me.Controls.Add(Me.LBLPassword)
        Me.Controls.Add(Me.LBLUsername)
        Me.Controls.Add(Me.TPassword)
        Me.Controls.Add(Me.TUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLUsername As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TUsername As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLPassword As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TPassword As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents BTNLogin As Krypton.Toolkit.KryptonButton
    Friend WithEvents LBLBatal As Krypton.Toolkit.KryptonLabel
    Friend WithEvents CBCookies As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents PaletPrimer As Krypton.Toolkit.KryptonPalette
    Friend WithEvents BTNRibbon As Krypton.Toolkit.KryptonButton
End Class
