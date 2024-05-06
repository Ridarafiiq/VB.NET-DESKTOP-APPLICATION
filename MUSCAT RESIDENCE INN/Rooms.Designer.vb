<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Rooms
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rooms))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RoomsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Muscat_Residence_InnDataSet = New MUSCAT_RESIDENCE_INN.Muscat_Residence_InnDataSet()
        Me.Listview1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RoomsTableAdapter = New MUSCAT_RESIDENCE_INN.Muscat_Residence_InnDataSetTableAdapters.roomsTableAdapter()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.RoomNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOOfBedsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.RoomsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Muscat_Residence_InnDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Listview1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(22, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 33)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Room Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 22)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Room NO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 22)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Room type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 22)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Room Rate:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 22)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "NO. of beds:"
        '
        'RoomsBindingSource
        '
        Me.RoomsBindingSource.DataMember = "rooms"
        Me.RoomsBindingSource.DataSource = Me.Muscat_Residence_InnDataSet
        '
        'Muscat_Residence_InnDataSet
        '
        Me.Muscat_Residence_InnDataSet.DataSetName = "Muscat_Residence_InnDataSet"
        Me.Muscat_Residence_InnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Listview1
        '
        Me.Listview1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Listview1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Listview1.AutoGenerateColumns = False
        Me.Listview1.BackgroundColor = System.Drawing.Color.White
        Me.Listview1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Listview1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Listview1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Listview1.ColumnHeadersHeight = 52
        Me.Listview1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RoomNODataGridViewTextBoxColumn, Me.RoomTypeDataGridViewTextBoxColumn, Me.NOOfBedsDataGridViewTextBoxColumn, Me.RoomRateDataGridViewTextBoxColumn})
        Me.Listview1.DataSource = Me.RoomsBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Listview1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Listview1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Listview1.DoubleBuffered = True
        Me.Listview1.EnableHeadersVisualStyles = False
        Me.Listview1.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.Listview1.HeaderBgColor = System.Drawing.Color.SteelBlue
        Me.Listview1.HeaderForeColor = System.Drawing.Color.White
        Me.Listview1.Location = New System.Drawing.Point(0, 310)
        Me.Listview1.Name = "Listview1"
        Me.Listview1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Listview1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Listview1.RowHeadersWidth = 45
        Me.Listview1.RowTemplate.Height = 28
        Me.Listview1.Size = New System.Drawing.Size(1001, 356)
        Me.Listview1.TabIndex = 13
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomsBindingSource, "Room type", True))
        Me.ComboBox1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Single", "Double", "Triple", "Quad"})
        Me.ComboBox1.Location = New System.Drawing.Point(195, 151)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(370, 32)
        Me.ComboBox1.TabIndex = 1
        '
        'RoomsTableAdapter
        '
        Me.RoomsTableAdapter.ClearBeforeFill = True
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
        Me.BunifuThinButton23.ButtonText = "DELETE"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Century Schoolbook", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.DeepSkyBlue
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.DeepSkyBlue
        Me.BunifuThinButton23.Location = New System.Drawing.Point(729, 221)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(232, 54)
        Me.BunifuThinButton23.TabIndex = 6
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.BunifuThinButton21.ButtonText = "UPDATE"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Schoolbook", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.DeepSkyBlue
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.DeepSkyBlue
        Me.BunifuThinButton21.Location = New System.Drawing.Point(729, 157)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(232, 54)
        Me.BunifuThinButton21.TabIndex = 5
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.BunifuThinButton22.ButtonText = "ADD "
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Schoolbook", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.DeepSkyBlue
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.DeepSkyBlue
        Me.BunifuThinButton22.Location = New System.Drawing.Point(729, 93)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(232, 54)
        Me.BunifuThinButton22.TabIndex = 4
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomsBindingSource, "Room NO", True))
        Me.TextBox5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(195, 93)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(370, 33)
        Me.TextBox5.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomsBindingSource, "NO of beds", True))
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(195, 198)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(370, 33)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomsBindingSource, "Room Rate", True))
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(195, 259)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(370, 33)
        Me.TextBox2.TabIndex = 3
        '
        'RoomNODataGridViewTextBoxColumn
        '
        Me.RoomNODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RoomNODataGridViewTextBoxColumn.DataPropertyName = "Room NO"
        Me.RoomNODataGridViewTextBoxColumn.HeaderText = "Room NO"
        Me.RoomNODataGridViewTextBoxColumn.Name = "RoomNODataGridViewTextBoxColumn"
        '
        'RoomTypeDataGridViewTextBoxColumn
        '
        Me.RoomTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RoomTypeDataGridViewTextBoxColumn.DataPropertyName = "Room type"
        Me.RoomTypeDataGridViewTextBoxColumn.HeaderText = "Room type"
        Me.RoomTypeDataGridViewTextBoxColumn.Name = "RoomTypeDataGridViewTextBoxColumn"
        '
        'NOOfBedsDataGridViewTextBoxColumn
        '
        Me.NOOfBedsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NOOfBedsDataGridViewTextBoxColumn.DataPropertyName = "NO of beds"
        Me.NOOfBedsDataGridViewTextBoxColumn.HeaderText = "NO of beds"
        Me.NOOfBedsDataGridViewTextBoxColumn.Name = "NOOfBedsDataGridViewTextBoxColumn"
        '
        'RoomRateDataGridViewTextBoxColumn
        '
        Me.RoomRateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RoomRateDataGridViewTextBoxColumn.DataPropertyName = "Room Rate"
        Me.RoomRateDataGridViewTextBoxColumn.HeaderText = "Room Rate"
        Me.RoomRateDataGridViewTextBoxColumn.Name = "RoomRateDataGridViewTextBoxColumn"
        '
        'Rooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1001, 666)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Listview1)
        Me.Controls.Add(Me.BunifuThinButton23)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.BunifuThinButton22)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Rooms"
        Me.Text = "rooms"
        CType(Me.RoomsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Muscat_Residence_InnDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Listview1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Listview1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents ComboBox1 As ComboBox

    Private Sub rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents Muscat_Residence_InnDataSet As Muscat_Residence_InnDataSet
    Friend WithEvents RoomsBindingSource As BindingSource
    Friend WithEvents RoomsTableAdapter As Muscat_Residence_InnDataSetTableAdapters.roomsTableAdapter
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents RoomNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoomTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOOfBedsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoomRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
