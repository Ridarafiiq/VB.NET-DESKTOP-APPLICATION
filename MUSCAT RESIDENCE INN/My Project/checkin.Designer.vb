<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(checkin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuDatepicker1 = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuMetroTextbox2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BunifuMetroTextbox3 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BunifuDatepicker2 = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BunifuMaterialTextbox2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BunifuMetroTextbox4 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(28, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Guest Check-in"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Firebrick
        Me.Label2.Location = New System.Drawing.Point(30, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Customer ID:"
        '
        'BunifuMetroTextbox1
        '
        Me.BunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.Maroon
        Me.BunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox1.BorderThickness = 2
        Me.BunifuMetroTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox1.isPassword = False
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(164, 97)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox1.MaxLength = 32767
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(203, 31)
        Me.BunifuMetroTextbox1.TabIndex = 7
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 22)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Arrival date:"
        '
        'BunifuDatepicker1
        '
        Me.BunifuDatepicker1.BackColor = System.Drawing.Color.Firebrick
        Me.BunifuDatepicker1.BorderRadius = 0
        Me.BunifuDatepicker1.ForeColor = System.Drawing.Color.White
        Me.BunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.BunifuDatepicker1.FormatCustom = Nothing
        Me.BunifuDatepicker1.Location = New System.Drawing.Point(164, 167)
        Me.BunifuDatepicker1.Name = "BunifuDatepicker1"
        Me.BunifuDatepicker1.Size = New System.Drawing.Size(274, 36)
        Me.BunifuDatepicker1.TabIndex = 9
        Me.BunifuDatepicker1.Value = New Date(2020, 11, 8, 0, 0, 0, 0)
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.BunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.BunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox1.HintText = ""
        Me.BunifuMaterialTextbox1.isPassword = False
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.DarkRed
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox1.LineThickness = 3
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(630, 167)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox1.MaxLength = 32767
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(142, 36)
        Me.BunifuMaterialTextbox1.TabIndex = 11
        Me.BunifuMaterialTextbox1.Text = "           "
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 22)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "No of guests:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(163, 232)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(199, 27)
        Me.NumericUpDown1.TabIndex = 14
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Time:"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.Firebrick
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaShell
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.Location = New System.Drawing.Point(502, 158)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(119, 50)
        Me.BunifuThinButton21.TabIndex = 16
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 22)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Room NO:"
        '
        'BunifuMetroTextbox2
        '
        Me.BunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.Maroon
        Me.BunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox2.BorderThickness = 2
        Me.BunifuMetroTextbox2.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMetroTextbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox2.isPassword = False
        Me.BunifuMetroTextbox2.Location = New System.Drawing.Point(127, 33)
        Me.BunifuMetroTextbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox2.MaxLength = 32767
        Me.BunifuMetroTextbox2.Name = "BunifuMetroTextbox2"
        Me.BunifuMetroTextbox2.Size = New System.Drawing.Size(210, 31)
        Me.BunifuMetroTextbox2.TabIndex = 18
        Me.BunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(422, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(199, 22)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "No of days reserved:"
        '
        'BunifuMetroTextbox3
        '
        Me.BunifuMetroTextbox3.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox3.BorderColorIdle = System.Drawing.Color.Maroon
        Me.BunifuMetroTextbox3.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox3.BorderThickness = 2
        Me.BunifuMetroTextbox3.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuMetroTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMetroTextbox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox3.isPassword = False
        Me.BunifuMetroTextbox3.Location = New System.Drawing.Point(630, 232)
        Me.BunifuMetroTextbox3.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox3.MaxLength = 32767
        Me.BunifuMetroTextbox3.Name = "BunifuMetroTextbox3"
        Me.BunifuMetroTextbox3.Size = New System.Drawing.Size(144, 31)
        Me.BunifuMetroTextbox3.TabIndex = 20
        Me.BunifuMetroTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.BunifuMetroTextbox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 289)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(749, 100)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Room info"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(388, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 22)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Room type:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BunifuMaterialTextbox2)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.BunifuDatepicker2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(25, 414)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(749, 95)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Check-out info"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Single", "Double", "Triple", "Quad"})
        Me.ComboBox1.Location = New System.Drawing.Point(510, 35)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(222, 29)
        Me.ComboBox1.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 22)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Checkout date:"
        '
        'BunifuDatepicker2
        '
        Me.BunifuDatepicker2.BackColor = System.Drawing.Color.Firebrick
        Me.BunifuDatepicker2.BorderRadius = 0
        Me.BunifuDatepicker2.ForeColor = System.Drawing.Color.White
        Me.BunifuDatepicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.BunifuDatepicker2.FormatCustom = Nothing
        Me.BunifuDatepicker2.Location = New System.Drawing.Point(170, 35)
        Me.BunifuDatepicker2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuDatepicker2.Name = "BunifuDatepicker2"
        Me.BunifuDatepicker2.Size = New System.Drawing.Size(218, 36)
        Me.BunifuDatepicker2.TabIndex = 23
        Me.BunifuDatepicker2.Value = New Date(2020, 11, 8, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(449, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 22)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Time:"
        '
        'BunifuMaterialTextbox2
        '
        Me.BunifuMaterialTextbox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.BunifuMaterialTextbox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.BunifuMaterialTextbox2.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox2.HintText = ""
        Me.BunifuMaterialTextbox2.isPassword = False
        Me.BunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.DarkRed
        Me.BunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox2.LineThickness = 3
        Me.BunifuMaterialTextbox2.Location = New System.Drawing.Point(511, 35)
        Me.BunifuMaterialTextbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox2.MaxLength = 32767
        Me.BunifuMaterialTextbox2.Name = "BunifuMaterialTextbox2"
        Me.BunifuMaterialTextbox2.Size = New System.Drawing.Size(148, 36)
        Me.BunifuMaterialTextbox2.TabIndex = 23
        Me.BunifuMaterialTextbox2.Text = "           "
        Me.BunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 549)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(193, 22)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Advance Payment:"
        '
        'BunifuMetroTextbox4
        '
        Me.BunifuMetroTextbox4.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox4.BorderColorIdle = System.Drawing.Color.Maroon
        Me.BunifuMetroTextbox4.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox4.BorderThickness = 2
        Me.BunifuMetroTextbox4.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuMetroTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMetroTextbox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox4.isPassword = False
        Me.BunifuMetroTextbox4.Location = New System.Drawing.Point(230, 540)
        Me.BunifuMetroTextbox4.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox4.MaxLength = 32767
        Me.BunifuMetroTextbox4.Name = "BunifuMetroTextbox4"
        Me.BunifuMetroTextbox4.Size = New System.Drawing.Size(214, 31)
        Me.BunifuMetroTextbox4.TabIndex = 27
        Me.BunifuMetroTextbox4.Text = "           OMR"
        Me.BunifuMetroTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "CHECK IN"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Schoolbook", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.Firebrick
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.Azure
        Me.BunifuThinButton22.Location = New System.Drawing.Point(25, 611)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(513, 60)
        Me.BunifuThinButton22.TabIndex = 30
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton23
        '
        Me.BunifuThinButton23.ActiveBorderThickness = 1
        Me.BunifuThinButton23.ActiveCornerRadius = 20
        Me.BunifuThinButton23.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton23.BackgroundImage = CType(resources.GetObject("BunifuThinButton23.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton23.ButtonText = "CLEAR"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Century Schoolbook", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.Firebrick
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.Azure
        Me.BunifuThinButton23.Location = New System.Drawing.Point(560, 611)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(214, 60)
        Me.BunifuThinButton23.TabIndex = 31
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'checkin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(811, 716)
        Me.Controls.Add(Me.BunifuThinButton23)
        Me.Controls.Add(Me.BunifuThinButton22)
        Me.Controls.Add(Me.BunifuMetroTextbox4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BunifuMetroTextbox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.Controls.Add(Me.BunifuDatepicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BunifuMetroTextbox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "checkin"
        Me.Text = "checkin"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuDatepicker1 As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuMetroTextbox2 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents BunifuMetroTextbox3 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BunifuMaterialTextbox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents BunifuDatepicker2 As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BunifuMetroTextbox4 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
End Class
