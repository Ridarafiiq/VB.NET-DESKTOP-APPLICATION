<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class guestlist
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(guestlist))
        Me.DataGrid1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.CUSTOMERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GENDERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOOFADULTSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOOFCHILDRENDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHONENODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddGuestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Muscat_Residence_InnDataSet = New MUSCAT_RESIDENCE_INN.Muscat_Residence_InnDataSet()
        Me.Add_guestTableAdapter = New MUSCAT_RESIDENCE_INN.Muscat_Residence_InnDataSetTableAdapters.add_guestTableAdapter()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.textbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddGuestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Muscat_Residence_InnDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrid1.AutoGenerateColumns = False
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.White
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CUSTOMERIDDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.LASTNAMEDataGridViewTextBoxColumn, Me.GENDERDataGridViewTextBoxColumn, Me.EMAILADDRESSDataGridViewTextBoxColumn, Me.ADDRESSDataGridViewTextBoxColumn, Me.NOOFADULTSDataGridViewTextBoxColumn, Me.NOOFCHILDRENDataGridViewTextBoxColumn, Me.PHONENODataGridViewTextBoxColumn})
        Me.DataGrid1.DataSource = Me.AddGuestBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGrid1.DoubleBuffered = True
        Me.DataGrid1.EnableHeadersVisualStyles = False
        Me.DataGrid1.HeaderBgColor = System.Drawing.Color.SteelBlue
        Me.DataGrid1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGrid1.Location = New System.Drawing.Point(12, 96)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGrid1.RowHeadersWidth = 33
        Me.DataGrid1.RowTemplate.Height = 28
        Me.DataGrid1.Size = New System.Drawing.Size(776, 400)
        Me.DataGrid1.TabIndex = 0
        '
        'CUSTOMERIDDataGridViewTextBoxColumn
        '
        Me.CUSTOMERIDDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMER ID"
        Me.CUSTOMERIDDataGridViewTextBoxColumn.HeaderText = "CUSTOMER ID"
        Me.CUSTOMERIDDataGridViewTextBoxColumn.Name = "CUSTOMERIDDataGridViewTextBoxColumn"
        '
        'FIRSTNAMEDataGridViewTextBoxColumn
        '
        Me.FIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRST NAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRST NAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Name = "FIRSTNAMEDataGridViewTextBoxColumn"
        '
        'LASTNAMEDataGridViewTextBoxColumn
        '
        Me.LASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LAST NAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.HeaderText = "LAST NAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.Name = "LASTNAMEDataGridViewTextBoxColumn"
        '
        'GENDERDataGridViewTextBoxColumn
        '
        Me.GENDERDataGridViewTextBoxColumn.DataPropertyName = "GENDER"
        Me.GENDERDataGridViewTextBoxColumn.HeaderText = "GENDER"
        Me.GENDERDataGridViewTextBoxColumn.Name = "GENDERDataGridViewTextBoxColumn"
        '
        'EMAILADDRESSDataGridViewTextBoxColumn
        '
        Me.EMAILADDRESSDataGridViewTextBoxColumn.DataPropertyName = "EMAIL ADDRESS"
        Me.EMAILADDRESSDataGridViewTextBoxColumn.HeaderText = "EMAIL ADDRESS"
        Me.EMAILADDRESSDataGridViewTextBoxColumn.Name = "EMAILADDRESSDataGridViewTextBoxColumn"
        Me.EMAILADDRESSDataGridViewTextBoxColumn.Width = 190
        '
        'ADDRESSDataGridViewTextBoxColumn
        '
        Me.ADDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.Name = "ADDRESSDataGridViewTextBoxColumn"
        '
        'NOOFADULTSDataGridViewTextBoxColumn
        '
        Me.NOOFADULTSDataGridViewTextBoxColumn.DataPropertyName = "NO OF ADULTS"
        Me.NOOFADULTSDataGridViewTextBoxColumn.HeaderText = "NO OF ADULTS"
        Me.NOOFADULTSDataGridViewTextBoxColumn.Name = "NOOFADULTSDataGridViewTextBoxColumn"
        '
        'NOOFCHILDRENDataGridViewTextBoxColumn
        '
        Me.NOOFCHILDRENDataGridViewTextBoxColumn.DataPropertyName = "NO OF CHILDREN"
        Me.NOOFCHILDRENDataGridViewTextBoxColumn.HeaderText = "NO OF CHILDREN"
        Me.NOOFCHILDRENDataGridViewTextBoxColumn.Name = "NOOFCHILDRENDataGridViewTextBoxColumn"
        '
        'PHONENODataGridViewTextBoxColumn
        '
        Me.PHONENODataGridViewTextBoxColumn.DataPropertyName = "PHONE NO"
        Me.PHONENODataGridViewTextBoxColumn.HeaderText = "PHONE NO"
        Me.PHONENODataGridViewTextBoxColumn.Name = "PHONENODataGridViewTextBoxColumn"
        Me.PHONENODataGridViewTextBoxColumn.Width = 120
        '
        'AddGuestBindingSource
        '
        Me.AddGuestBindingSource.DataMember = "add guest"
        Me.AddGuestBindingSource.DataSource = Me.Muscat_Residence_InnDataSet
        '
        'Muscat_Residence_InnDataSet
        '
        Me.Muscat_Residence_InnDataSet.DataSetName = "Muscat_Residence_InnDataSet"
        Me.Muscat_Residence_InnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Add_guestTableAdapter
        '
        Me.Add_guestTableAdapter.ClearBeforeFill = True
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
        Me.BunifuThinButton21.ButtonText = "search"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.SteelBlue
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.Honeydew
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.Location = New System.Drawing.Point(426, 25)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(199, 43)
        Me.BunifuThinButton21.TabIndex = 1
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'textbox1
        '
        Me.textbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.textbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.textbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.textbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.textbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textbox1.HintForeColor = System.Drawing.Color.Empty
        Me.textbox1.HintText = ""
        Me.textbox1.isPassword = False
        Me.textbox1.LineFocusedColor = System.Drawing.Color.Blue
        Me.textbox1.LineIdleColor = System.Drawing.Color.Gray
        Me.textbox1.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.textbox1.LineThickness = 3
        Me.textbox1.Location = New System.Drawing.Point(134, 35)
        Me.textbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.textbox1.MaxLength = 32767
        Me.textbox1.Name = "textbox1"
        Me.textbox1.Size = New System.Drawing.Size(264, 33)
        Me.textbox1.TabIndex = 2
        Me.textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'guestlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 527)
        Me.Controls.Add(Me.textbox1)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.DataGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "guestlist"
        Me.Text = "Form5"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddGuestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Muscat_Residence_InnDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGrid1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Muscat_Residence_InnDataSet As Muscat_Residence_InnDataSet
    Friend WithEvents AddGuestBindingSource As BindingSource
    Friend WithEvents Add_guestTableAdapter As Muscat_Residence_InnDataSetTableAdapters.add_guestTableAdapter
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents textbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents CUSTOMERIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GENDERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMAILADDRESSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ADDRESSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOOFADULTSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOOFCHILDRENDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PHONENODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
