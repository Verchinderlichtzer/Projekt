<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Third
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
        Me.PrimerLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.PrimerBTN1 = New Krypton.Toolkit.KryptonButton()
        Me.SuspendLayout()
        '
        'PrimerLabel1
        '
        Me.PrimerLabel1.AutoSize = False
        Me.PrimerLabel1.Location = New System.Drawing.Point(25, 34)
        Me.PrimerLabel1.Name = "PrimerLabel1"
        Me.PrimerLabel1.Size = New System.Drawing.Size(122, 26)
        Me.PrimerLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PrimerLabel1.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PrimerLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.PrimerLabel1.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.PrimerLabel1.TabIndex = 125
        Me.PrimerLabel1.Values.Text = "ReadOnly"
        '
        'PrimerBTN1
        '
        Me.PrimerBTN1.Location = New System.Drawing.Point(25, 66)
        Me.PrimerBTN1.Name = "PrimerBTN1"
        Me.PrimerBTN1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.PrimerBTN1.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PrimerBTN1.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.PrimerBTN1.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.PrimerBTN1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.PrimerBTN1.Size = New System.Drawing.Size(189, 45)
        Me.PrimerBTN1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.PrimerBTN1.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PrimerBTN1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.PrimerBTN1.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.PrimerBTN1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PrimerBTN1.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrimerBTN1.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.PrimerBTN1.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.PrimerBTN1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.PrimerBTN1.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PrimerBTN1.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.PrimerBTN1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.PrimerBTN1.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PrimerBTN1.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PrimerBTN1.TabIndex = 124
        Me.PrimerBTN1.Values.Text = "Switch"
        '
        'Third
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.PrimerLabel1)
        Me.Controls.Add(Me.PrimerBTN1)
        Me.Name = "Third"
        Me.Size = New System.Drawing.Size(1100, 650)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrimerLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents PrimerBTN1 As Krypton.Toolkit.KryptonButton
End Class
