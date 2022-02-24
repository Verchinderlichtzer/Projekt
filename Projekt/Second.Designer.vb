<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Second
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Second))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PaletPrimer = New Krypton.Toolkit.KryptonPalette(Me.components)
        Me.PaletSekunder = New Krypton.Toolkit.KryptonPalette(Me.components)
        Me.PanelTransaksi = New Krypton.Toolkit.KryptonGroup()
        Me.Button2 = New Krypton.Toolkit.KryptonButton()
        Me.Button1 = New Krypton.Toolkit.KryptonButton()
        Me.DataGridView1 = New Krypton.Toolkit.KryptonDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KryptonBorderEdge1 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.LBLTransaksi = New Krypton.Toolkit.KryptonLabel()
        Me.KryptonGroup1 = New Krypton.Toolkit.KryptonGroup()
        Me.KryptonBorderEdge2 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.KryptonGroup3 = New Krypton.Toolkit.KryptonGroup()
        Me.KryptonButton1 = New Krypton.Toolkit.KryptonButton()
        Me.KryptonBorderEdge4 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
        Me.KryptonGroup4 = New Krypton.Toolkit.KryptonGroup()
        Me.KryptonBorderEdge5 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PanelTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelTransaksi.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTransaksi.Panel.SuspendLayout()
        Me.PanelTransaksi.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        CType(Me.KryptonGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup3.Panel.SuspendLayout()
        Me.KryptonGroup3.SuspendLayout()
        CType(Me.KryptonGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup4.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup4.Panel.SuspendLayout()
        Me.KryptonGroup4.SuspendLayout()
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
        'PanelTransaksi
        '
        Me.PanelTransaksi.Location = New System.Drawing.Point(8, 8)
        Me.PanelTransaksi.Name = "PanelTransaksi"
        Me.PanelTransaksi.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        '
        'PanelTransaksi.Panel
        '
        Me.PanelTransaksi.Panel.Controls.Add(Me.Button2)
        Me.PanelTransaksi.Panel.Controls.Add(Me.Button1)
        Me.PanelTransaksi.Panel.Controls.Add(Me.DataGridView1)
        Me.PanelTransaksi.Panel.Controls.Add(Me.KryptonBorderEdge1)
        Me.PanelTransaksi.Panel.Controls.Add(Me.LBLTransaksi)
        Me.PanelTransaksi.Size = New System.Drawing.Size(540, 315)
        Me.PanelTransaksi.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PanelTransaksi.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PanelTransaksi.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.PanelTransaksi.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.PanelTransaksi.StateCommon.Border.Width = 3
        Me.PanelTransaksi.TabIndex = 101
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(130, 37)
        Me.Button2.Name = "Button2"
        Me.Button2.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Button2.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.Button2.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.Button2.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.Button2.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.Button2.Size = New System.Drawing.Size(121, 24)
        Me.Button2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Button2.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.Button2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.Button2.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.Button2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button2.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Button2.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.Button2.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Button2.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.Button2.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.Button2.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Button2.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.Button2.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button2.TabIndex = 138
        Me.Button2.Values.Text = "Sort"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Button1.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.Button1.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.Button1.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.Button1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.Button1.Size = New System.Drawing.Size(121, 24)
        Me.Button1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Button1.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.Button1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.Button1.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.Button1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button1.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Button1.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.Button1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Button1.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.Button1.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.Button1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Button1.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.Button1.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button1.TabIndex = 139
        Me.Button1.Values.Text = "Add"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeight = 27
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataGridView1.HideOuterBorders = True
        Me.DataGridView1.Location = New System.Drawing.Point(3, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 27
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(496, 239)
        Me.DataGridView1.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.DataGridView1.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.DataGridView1.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.DataGridView1.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.DataGridView1.StateCommon.DataCell.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.DataGridView1.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView1.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridView1.StateCommon.HeaderColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DataGridView1.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DataGridView1.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.DataGridView1.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DataGridView1.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DataGridView1.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.DataGridView1.StateSelected.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DataGridView1.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.Black
        Me.DataGridView1.StateTracking.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.DataGridView1.TabIndex = 137
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Column4"
        Me.Column4.Name = "Column4"
        '
        'KryptonBorderEdge1
        '
        Me.KryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonBorderEdge1.Location = New System.Drawing.Point(0, 28)
        Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
        Me.KryptonBorderEdge1.Size = New System.Drawing.Size(534, 3)
        Me.KryptonBorderEdge1.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.KryptonBorderEdge1.StateCommon.Width = 3
        Me.KryptonBorderEdge1.Text = "KryptonBorderEdge1"
        '
        'LBLTransaksi
        '
        Me.LBLTransaksi.AutoSize = False
        Me.LBLTransaksi.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLTransaksi.Location = New System.Drawing.Point(0, 0)
        Me.LBLTransaksi.Name = "LBLTransaksi"
        Me.LBLTransaksi.Size = New System.Drawing.Size(534, 28)
        Me.LBLTransaksi.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLTransaksi.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLTransaksi.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTransaksi.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLTransaksi.TabIndex = 28
        Me.LBLTransaksi.Values.Text = "1.) Structure"
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Location = New System.Drawing.Point(8, 327)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        Me.KryptonGroup1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonBorderEdge2)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroup1.Size = New System.Drawing.Size(540, 315)
        Me.KryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.KryptonGroup1.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.KryptonGroup1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.KryptonGroup1.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonGroup1.StateCommon.Border.Width = 3
        Me.KryptonGroup1.TabIndex = 102
        '
        'KryptonBorderEdge2
        '
        Me.KryptonBorderEdge2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonBorderEdge2.Location = New System.Drawing.Point(0, 28)
        Me.KryptonBorderEdge2.Name = "KryptonBorderEdge2"
        Me.KryptonBorderEdge2.Size = New System.Drawing.Size(534, 3)
        Me.KryptonBorderEdge2.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.KryptonBorderEdge2.StateCommon.Width = 3
        Me.KryptonBorderEdge2.Text = "KryptonBorderEdge2"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.AutoSize = False
        Me.KryptonLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonLabel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(534, 28)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.KryptonLabel1.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.KryptonLabel1.TabIndex = 28
        Me.KryptonLabel1.Values.Text = ""
        '
        'KryptonGroup3
        '
        Me.KryptonGroup3.Location = New System.Drawing.Point(552, 8)
        Me.KryptonGroup3.Name = "KryptonGroup3"
        Me.KryptonGroup3.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        '
        'KryptonGroup3.Panel
        '
        Me.KryptonGroup3.Panel.Controls.Add(Me.Label1)
        Me.KryptonGroup3.Panel.Controls.Add(Me.MaskedTextBox1)
        Me.KryptonGroup3.Panel.Controls.Add(Me.KryptonButton1)
        Me.KryptonGroup3.Panel.Controls.Add(Me.KryptonBorderEdge4)
        Me.KryptonGroup3.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonGroup3.Size = New System.Drawing.Size(540, 315)
        Me.KryptonGroup3.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.KryptonGroup3.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.KryptonGroup3.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.KryptonGroup3.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonGroup3.StateCommon.Border.Width = 3
        Me.KryptonGroup3.TabIndex = 101
        '
        'KryptonButton1
        '
        Me.KryptonButton1.Location = New System.Drawing.Point(162, 113)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.KryptonButton1.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.KryptonButton1.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.KryptonButton1.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.KryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.KryptonButton1.Size = New System.Drawing.Size(181, 75)
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
        Me.KryptonButton1.TabIndex = 139
        Me.KryptonButton1.Values.Text = ""
        '
        'KryptonBorderEdge4
        '
        Me.KryptonBorderEdge4.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonBorderEdge4.Location = New System.Drawing.Point(0, 28)
        Me.KryptonBorderEdge4.Name = "KryptonBorderEdge4"
        Me.KryptonBorderEdge4.Size = New System.Drawing.Size(534, 3)
        Me.KryptonBorderEdge4.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.KryptonBorderEdge4.StateCommon.Width = 3
        Me.KryptonBorderEdge4.Text = "KryptonBorderEdge1"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.AutoSize = False
        Me.KryptonLabel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonLabel3.Location = New System.Drawing.Point(0, 0)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(534, 28)
        Me.KryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.KryptonLabel3.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.KryptonLabel3.TabIndex = 28
        Me.KryptonLabel3.Values.Text = ""
        '
        'KryptonGroup4
        '
        Me.KryptonGroup4.Location = New System.Drawing.Point(552, 327)
        Me.KryptonGroup4.Name = "KryptonGroup4"
        Me.KryptonGroup4.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        '
        'KryptonGroup4.Panel
        '
        Me.KryptonGroup4.Panel.Controls.Add(Me.KryptonBorderEdge5)
        Me.KryptonGroup4.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonGroup4.Size = New System.Drawing.Size(540, 315)
        Me.KryptonGroup4.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.KryptonGroup4.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.KryptonGroup4.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.KryptonGroup4.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonGroup4.StateCommon.Border.Width = 3
        Me.KryptonGroup4.TabIndex = 102
        '
        'KryptonBorderEdge5
        '
        Me.KryptonBorderEdge5.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonBorderEdge5.Location = New System.Drawing.Point(0, 28)
        Me.KryptonBorderEdge5.Name = "KryptonBorderEdge5"
        Me.KryptonBorderEdge5.Size = New System.Drawing.Size(534, 3)
        Me.KryptonBorderEdge5.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.KryptonBorderEdge5.StateCommon.Width = 3
        Me.KryptonBorderEdge5.Text = "KryptonBorderEdge2"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.AutoSize = False
        Me.KryptonLabel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonLabel4.Location = New System.Drawing.Point(0, 0)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(534, 28)
        Me.KryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.KryptonLabel4.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.KryptonLabel4.TabIndex = 28
        Me.KryptonLabel4.Values.Text = ""
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(200, 216)
        Me.MaskedTextBox1.Mask = "00:00:00"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox1.TabIndex = 141
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "Label1"
        '
        'Second
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Controls.Add(Me.KryptonGroup4)
        Me.Controls.Add(Me.KryptonGroup1)
        Me.Controls.Add(Me.KryptonGroup3)
        Me.Controls.Add(Me.PanelTransaksi)
        Me.Name = "Second"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(1100, 650)
        CType(Me.PanelTransaksi.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTransaksi.Panel.ResumeLayout(False)
        Me.PanelTransaksi.Panel.PerformLayout()
        CType(Me.PanelTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTransaksi.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        Me.KryptonGroup1.Panel.PerformLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        CType(Me.KryptonGroup3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup3.Panel.ResumeLayout(False)
        Me.KryptonGroup3.Panel.PerformLayout()
        CType(Me.KryptonGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup3.ResumeLayout(False)
        CType(Me.KryptonGroup4.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup4.Panel.ResumeLayout(False)
        Me.KryptonGroup4.Panel.PerformLayout()
        CType(Me.KryptonGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PaletPrimer As Krypton.Toolkit.KryptonPalette
    Friend WithEvents PaletSekunder As Krypton.Toolkit.KryptonPalette
    Friend WithEvents PanelTransaksi As Krypton.Toolkit.KryptonGroup
    Friend WithEvents KryptonBorderEdge1 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents LBLTransaksi As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonGroup1 As Krypton.Toolkit.KryptonGroup
    Friend WithEvents KryptonBorderEdge2 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonGroup3 As Krypton.Toolkit.KryptonGroup
    Friend WithEvents KryptonBorderEdge4 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonGroup4 As Krypton.Toolkit.KryptonGroup
    Friend WithEvents KryptonBorderEdge5 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents Button2 As Krypton.Toolkit.KryptonButton
    Friend WithEvents Button1 As Krypton.Toolkit.KryptonButton
    Friend WithEvents DataGridView1 As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonButton1 As Krypton.Toolkit.KryptonButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label1 As Label
End Class
