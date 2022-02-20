<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class First
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(First))
        Me.PaletPrimer = New Krypton.Toolkit.KryptonPalette(Me.components)
        Me.PaletSekunder = New Krypton.Toolkit.KryptonPalette(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TNotepad = New Krypton.Toolkit.KryptonTextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Pemisah1 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.BTNStart = New Krypton.Toolkit.KryptonButton()
        Me.BTNGuess = New Krypton.Toolkit.KryptonButton()
        Me.LB1 = New Krypton.Toolkit.KryptonListBox()
        Me.LBL1 = New Krypton.Toolkit.KryptonLabel()
        Me.KryptonButton1 = New Krypton.Toolkit.KryptonButton()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        'PaletSekunder
        '
        Me.PaletSekunder.BasePaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.PaletSekunder.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PaletSekunder.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PaletSekunder.Images.CheckBox.CheckedDisabled = CType(resources.GetObject("resource.CheckedDisabled2"), System.Drawing.Image)
        Me.PaletSekunder.Images.CheckBox.CheckedNormal = CType(resources.GetObject("resource.CheckedNormal2"), System.Drawing.Image)
        Me.PaletSekunder.Images.CheckBox.CheckedPressed = CType(resources.GetObject("resource.CheckedPressed2"), System.Drawing.Image)
        Me.PaletSekunder.Images.CheckBox.CheckedTracking = CType(resources.GetObject("resource.CheckedTracking2"), System.Drawing.Image)
        Me.PaletSekunder.Images.CheckBox.Common = CType(resources.GetObject("resource.Common2"), System.Drawing.Image)
        Me.PaletSekunder.Images.CheckBox.UncheckedDisabled = CType(resources.GetObject("resource.UncheckedDisabled2"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.CheckedDisabled = CType(resources.GetObject("resource.CheckedDisabled3"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.CheckedNormal = CType(resources.GetObject("resource.CheckedNormal3"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.CheckedPressed = CType(resources.GetObject("resource.CheckedPressed3"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.CheckedTracking = CType(resources.GetObject("resource.CheckedTracking3"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.Common = CType(resources.GetObject("resource.Common3"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.UncheckedDisabled = CType(resources.GetObject("resource.UncheckedDisabled3"), System.Drawing.Image)
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateActive.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateActive.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Border.Rounding = 0!
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Border.Width = 1
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateDisabled.Border.Rounding = 0!
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateDisabled.Border.Width = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1100, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ToolStripMenuItem1, Me.SaveToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ToolStripMenuItem2, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(143, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(143, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.CloseToolStripMenuItem.Text = "C&lose"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.ToolStripMenuItem3, Me.CopyToolStripMenuItem, Me.CutToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(141, 6)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'TNotepad
        '
        Me.TNotepad.AlwaysActive = False
        Me.TNotepad.Location = New System.Drawing.Point(3, 27)
        Me.TNotepad.MaxLength = 255
        Me.TNotepad.Multiline = True
        Me.TNotepad.Name = "TNotepad"
        Me.TNotepad.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TNotepad.Size = New System.Drawing.Size(354, 123)
        Me.TNotepad.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TNotepad.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TNotepad.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TNotepad.StateActive.Border.Rounding = 0!
        Me.TNotepad.StateActive.Border.Width = 1
        Me.TNotepad.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TNotepad.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TNotepad.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TNotepad.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TNotepad.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TNotepad.StateCommon.Border.Rounding = 0!
        Me.TNotepad.StateCommon.Border.Width = 1
        Me.TNotepad.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TNotepad.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNotepad.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TNotepad.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TNotepad.StateDisabled.Border.Rounding = 0!
        Me.TNotepad.StateDisabled.Border.Width = 0
        Me.TNotepad.TabIndex = 90
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Harus Txt|*.txt"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(363, 27)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox1.TabIndex = 91
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(363, 54)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(100, 96)
        Me.RichTextBox1.TabIndex = 92
        Me.RichTextBox1.Text = ""
        '
        'Pemisah1
        '
        Me.Pemisah1.Location = New System.Drawing.Point(3, 156)
        Me.Pemisah1.Name = "Pemisah1"
        Me.Pemisah1.Size = New System.Drawing.Size(1090, 3)
        Me.Pemisah1.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Pemisah1.StateCommon.Width = 3
        Me.Pemisah1.Text = "KryptonBorderEdge1"
        '
        'BTNStart
        '
        Me.BTNStart.Location = New System.Drawing.Point(3, 165)
        Me.BTNStart.Name = "BTNStart"
        Me.BTNStart.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNStart.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNStart.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNStart.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNStart.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNStart.Size = New System.Drawing.Size(143, 40)
        Me.BTNStart.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNStart.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNStart.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNStart.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNStart.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNStart.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNStart.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNStart.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNStart.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BTNStart.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNStart.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNStart.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNStart.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNStart.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BTNStart.TabIndex = 95
        Me.BTNStart.Values.Text = "Start"
        '
        'BTNGuess
        '
        Me.BTNGuess.Location = New System.Drawing.Point(3, 243)
        Me.BTNGuess.Name = "BTNGuess"
        Me.BTNGuess.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNGuess.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNGuess.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNGuess.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNGuess.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNGuess.Size = New System.Drawing.Size(143, 40)
        Me.BTNGuess.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNGuess.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNGuess.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNGuess.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNGuess.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNGuess.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGuess.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNGuess.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNGuess.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BTNGuess.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNGuess.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNGuess.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNGuess.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNGuess.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BTNGuess.TabIndex = 95
        Me.BTNGuess.Values.Text = "Guess a Number"
        '
        'LB1
        '
        Me.LB1.Location = New System.Drawing.Point(152, 167)
        Me.LB1.Name = "LB1"
        Me.LB1.Size = New System.Drawing.Size(205, 116)
        Me.LB1.TabIndex = 97
        '
        'LBL1
        '
        Me.LBL1.AutoSize = False
        Me.LBL1.Location = New System.Drawing.Point(3, 211)
        Me.LBL1.Name = "LBL1"
        Me.LBL1.Size = New System.Drawing.Size(143, 26)
        Me.LBL1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBL1.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBL1.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL1.TabIndex = 99
        Me.LBL1.Values.Text = "Supplier"
        '
        'KryptonButton1
        '
        Me.KryptonButton1.Location = New System.Drawing.Point(23, 356)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.KryptonButton1.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.KryptonButton1.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.KryptonButton1.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.KryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.KryptonButton1.Size = New System.Drawing.Size(143, 40)
        Me.KryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.KryptonButton1.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.KryptonButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.KryptonButton1.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.KryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.KryptonButton1.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonButton1.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.KryptonButton1.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.KryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.KryptonButton1.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.KryptonButton1.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.KryptonButton1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.KryptonButton1.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.KryptonButton1.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.KryptonButton1.TabIndex = 95
        Me.KryptonButton1.Values.Text = "Guess a Number"
        '
        'First
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Controls.Add(Me.LBL1)
        Me.Controls.Add(Me.LB1)
        Me.Controls.Add(Me.KryptonButton1)
        Me.Controls.Add(Me.BTNGuess)
        Me.Controls.Add(Me.BTNStart)
        Me.Controls.Add(Me.Pemisah1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.TNotepad)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "First"
        Me.Size = New System.Drawing.Size(1100, 650)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PaletPrimer As Krypton.Toolkit.KryptonPalette
    Friend WithEvents PaletSekunder As Krypton.Toolkit.KryptonPalette
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TNotepad As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Pemisah1 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents BTNStart As Krypton.Toolkit.KryptonButton
    Friend WithEvents BTNGuess As Krypton.Toolkit.KryptonButton
    Friend WithEvents LB1 As Krypton.Toolkit.KryptonListBox
    Friend WithEvents LBL1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonButton1 As Krypton.Toolkit.KryptonButton
End Class
