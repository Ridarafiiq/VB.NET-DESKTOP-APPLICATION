<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkout
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(checkout))
        Me.BunifuCustomDataGrid1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.CheckInBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Muscat_Residence_InnDataSet = New MUSCAT_RESIDENCE_INN.Muscat_Residence_InnDataSet()
        Me.Check_inTableAdapter = New MUSCAT_RESIDENCE_INN.Muscat_Residence_InnDataSetTableAdapters.check_inTableAdapter()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArrivalDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoOfGuestsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoOfDaysReservedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckoutDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckoutTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckInBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Muscat_Residence_InnDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCustomDataGrid1
        '
        Me.BunifuCustomDataGrid1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BunifuCustomDataGrid1.AutoGenerateColumns = False
        Me.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.White
        Me.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuCustomDataGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.ArrivalDateDataGridViewTextBoxColumn, Me.TimeDataGridViewTextBoxColumn, Me.NoOfGuestsDataGridViewTextBoxColumn, Me.NoOfDaysReservedDataGridViewTextBoxColumn, Me.RoomNODataGridViewTextBoxColumn, Me.RoomTypeDataGridViewTextBoxColumn, Me.CheckoutDateDataGridViewTextBoxColumn, Me.CheckoutTimeDataGridViewTextBoxColumn})
        Me.BunifuCustomDataGrid1.DataSource = Me.CheckInBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BunifuCustomDataGrid1.DefaultCellStyle = DataGridViewCellStyle3
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.DarkCyan
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(41, 40)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(867, 374)
        Me.BunifuCustomDataGrid1.TabIndex = 0
        '
        'CheckInBindingSource
        '
        Me.CheckInBindingSource.DataMember = "check in"
        Me.CheckInBindingSource.DataSource = Me.Muscat_Residence_InnDataSet
        '
        'Muscat_Residence_InnDataSet
        '
        Me.Muscat_Residence_InnDataSet.DataSetName = "Muscat_Residence_InnDataSet"
        Me.Muscat_Residence_InnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Check_inTableAdapter
        '
        Me.Check_inTableAdapter.ClearBeforeFill = True
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "CHECK OUT"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.Teal
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.Location = New System.Drawing.Point(190, 464)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(481, 63)
        Me.BunifuThinButton21.TabIndex = 1
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer ID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "Customer ID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        '
        'ArrivalDateDataGridViewTextBoxColumn
        '
        Me.ArrivalDateDataGridViewTextBoxColumn.DataPropertyName = "Arrival date"
        Me.ArrivalDateDataGridViewTextBoxColumn.HeaderText = "Arrival date"
        Me.ArrivalDateDataGridViewTextBoxColumn.Name = "ArrivalDateDataGridViewTextBoxColumn"
        Me.ArrivalDateDataGridViewTextBoxColumn.Width = 150
        '
        'TimeDataGridViewTextBoxColumn
        '
        Me.TimeDataGridViewTextBoxColumn.DataPropertyName = "time"
        Me.TimeDataGridViewTextBoxColumn.HeaderText = "time"
        Me.TimeDataGridViewTextBoxColumn.Name = "TimeDataGridViewTextBoxColumn"
        Me.TimeDataGridViewTextBoxColumn.Width = 170
        '
        'NoOfGuestsDataGridViewTextBoxColumn
        '
        Me.NoOfGuestsDataGridViewTextBoxColumn.DataPropertyName = "No of guests"
        Me.NoOfGuestsDataGridViewTextBoxColumn.HeaderText = "No of guests"
        Me.NoOfGuestsDataGridViewTextBoxColumn.Name = "NoOfGuestsDataGridViewTextBoxColumn"
        '
        'NoOfDaysReservedDataGridViewTextBoxColumn
        '
        Me.NoOfDaysReservedDataGridViewTextBoxColumn.DataPropertyName = "No of days reserved"
        Me.NoOfDaysReservedDataGridViewTextBoxColumn.HeaderText = "No of days reserved"
        Me.NoOfDaysReservedDataGridViewTextBoxColumn.Name = "NoOfDaysReservedDataGridViewTextBoxColumn"
        '
        'RoomNODataGridViewTextBoxColumn
        '
        Me.RoomNODataGridViewTextBoxColumn.DataPropertyName = "Room NO"
        Me.RoomNODataGridViewTextBoxColumn.HeaderText = "Room NO"
        Me.RoomNODataGridViewTextBoxColumn.Name = "RoomNODataGridViewTextBoxColumn"
        '
        'RoomTypeDataGridViewTextBoxColumn
        '
        Me.RoomTypeDataGridViewTextBoxColumn.DataPropertyName = "Room type"
        Me.RoomTypeDataGridViewTextBoxColumn.HeaderText = "Room type"
        Me.RoomTypeDataGridViewTextBoxColumn.Name = "RoomTypeDataGridViewTextBoxColumn"
        '
        'CheckoutDateDataGridViewTextBoxColumn
        '
        Me.CheckoutDateDataGridViewTextBoxColumn.DataPropertyName = "Checkout date"
        Me.CheckoutDateDataGridViewTextBoxColumn.HeaderText = "Checkout date"
        Me.CheckoutDateDataGridViewTextBoxColumn.Name = "CheckoutDateDataGridViewTextBoxColumn"
        Me.CheckoutDateDataGridViewTextBoxColumn.Width = 150
        '
        'CheckoutTimeDataGridViewTextBoxColumn
        '
        Me.CheckoutTimeDataGridViewTextBoxColumn.DataPropertyName = "checkout time"
        Me.CheckoutTimeDataGridViewTextBoxColumn.HeaderText = "checkout time"
        Me.CheckoutTimeDataGridViewTextBoxColumn.Name = "CheckoutTimeDataGridViewTextBoxColumn"
        Me.CheckoutTimeDataGridViewTextBoxColumn.Width = 170
        '
        'checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(938, 541)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "checkout"
        Me.Text = "checkout"
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckInBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Muscat_Residence_InnDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuCustomDataGrid1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Muscat_Residence_InnDataSet As Muscat_Residence_InnDataSet
    Friend WithEvents CheckInBindingSource As BindingSource
    Friend WithEvents Check_inTableAdapter As Muscat_Residence_InnDataSetTableAdapters.check_inTableAdapter
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ArrivalDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoOfGuestsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoOfDaysReservedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoomNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoomTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CheckoutDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CheckoutTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
