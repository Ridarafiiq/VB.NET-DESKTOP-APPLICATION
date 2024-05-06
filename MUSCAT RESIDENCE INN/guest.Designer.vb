<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class guest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(guest))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.b = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(216, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(827, 572)
        Me.Panel1.TabIndex = 5
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Add new guest"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.DodgerBlue
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.DodgerBlue
        Me.BunifuThinButton22.Location = New System.Drawing.Point(25, 132)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(163, 44)
        Me.BunifuThinButton22.TabIndex = 4
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'b
        '
        Me.b.ActiveBorderThickness = 1
        Me.b.ActiveCornerRadius = 20
        Me.b.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.b.ActiveForecolor = System.Drawing.Color.White
        Me.b.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.b.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.b.BackgroundImage = CType(resources.GetObject("b.BackgroundImage"), System.Drawing.Image)
        Me.b.ButtonText = "Guest list"
        Me.b.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.b.IdleBorderThickness = 1
        Me.b.IdleCornerRadius = 20
        Me.b.IdleFillColor = System.Drawing.Color.White
        Me.b.IdleForecolor = System.Drawing.Color.DodgerBlue
        Me.b.IdleLineColor = System.Drawing.Color.DodgerBlue
        Me.b.Location = New System.Drawing.Point(25, 65)
        Me.b.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(163, 44)
        Me.b.TabIndex = 3
        Me.b.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'guest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1283, 651)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BunifuThinButton22)
        Me.Controls.Add(Me.b)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "guest"
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents b As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel1 As Panel
End Class
