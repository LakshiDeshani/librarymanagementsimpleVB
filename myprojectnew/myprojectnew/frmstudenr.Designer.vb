<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmstudenr
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
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.butExit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.butsave = New System.Windows.Forms.Button()
        Me.txtstudent = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panelmain = New System.Windows.Forms.Panel()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Panelsearch = New System.Windows.Forms.Panel()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelTop.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelLeft.SuspendLayout()
        Me.Panelmain.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelsearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.PanelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTop.Controls.Add(Me.Label1)
        Me.PanelTop.Controls.Add(Me.butExit)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(1539, 70)
        Me.PanelTop.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Uighur", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(193, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1344, 68)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Manage Student"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'butExit
        '
        Me.butExit.BackColor = System.Drawing.Color.White
        Me.butExit.Dock = System.Windows.Forms.DockStyle.Left
        Me.butExit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.butExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.butExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butExit.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butExit.ForeColor = System.Drawing.Color.Black
        Me.butExit.Image = Global.myprojectnew.My.Resources.Resources.logout
        Me.butExit.Location = New System.Drawing.Point(0, 0)
        Me.butExit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.butExit.Name = "butExit"
        Me.butExit.Size = New System.Drawing.Size(193, 68)
        Me.butExit.TabIndex = 8
        Me.butExit.Text = "Back Home"
        Me.butExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.butExit.UseMnemonic = False
        Me.butExit.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 693)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1539, 35)
        Me.Panel2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Font = New System.Drawing.Font("Stencil", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, -2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1537, 35)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "All Rights Reserved By KDU "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelLeft
        '
        Me.PanelLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.PanelLeft.Controls.Add(Me.butsave)
        Me.PanelLeft.Controls.Add(Me.txtstudent)
        Me.PanelLeft.Controls.Add(Me.Label2)
        Me.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeft.Font = New System.Drawing.Font("Microsoft YaHei", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelLeft.Location = New System.Drawing.Point(0, 70)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(574, 623)
        Me.PanelLeft.TabIndex = 2
        '
        'butsave
        '
        Me.butsave.BackColor = System.Drawing.Color.DarkBlue
        Me.butsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.butsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butsave.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butsave.ForeColor = System.Drawing.Color.White
        Me.butsave.Location = New System.Drawing.Point(221, 152)
        Me.butsave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.butsave.Name = "butsave"
        Me.butsave.Size = New System.Drawing.Size(308, 46)
        Me.butsave.TabIndex = 6
        Me.butsave.Text = "Save"
        Me.butsave.UseMnemonic = False
        Me.butsave.UseVisualStyleBackColor = False
        '
        'txtstudent
        '
        Me.txtstudent.Location = New System.Drawing.Point(221, 71)
        Me.txtstudent.Multiline = True
        Me.txtstudent.Name = "txtstudent"
        Me.txtstudent.Size = New System.Drawing.Size(308, 48)
        Me.txtstudent.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "student Name"
        '
        'Panelmain
        '
        Me.Panelmain.BackColor = System.Drawing.Color.AliceBlue
        Me.Panelmain.Controls.Add(Me.dgv1)
        Me.Panelmain.Controls.Add(Me.Panelsearch)
        Me.Panelmain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panelmain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panelmain.Location = New System.Drawing.Point(574, 70)
        Me.Panelmain.Name = "Panelmain"
        Me.Panelmain.Size = New System.Drawing.Size(965, 623)
        Me.Panelmain.TabIndex = 3
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv1.Location = New System.Drawing.Point(0, 61)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.RowTemplate.Height = 24
        Me.dgv1.Size = New System.Drawing.Size(965, 562)
        Me.dgv1.TabIndex = 1
        '
        'Panelsearch
        '
        Me.Panelsearch.Controls.Add(Me.txtsearch)
        Me.Panelsearch.Controls.Add(Me.Label4)
        Me.Panelsearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panelsearch.Location = New System.Drawing.Point(0, 0)
        Me.Panelsearch.Name = "Panelsearch"
        Me.Panelsearch.Size = New System.Drawing.Size(965, 61)
        Me.Panelsearch.TabIndex = 0
        '
        'txtsearch
        '
        Me.txtsearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.Location = New System.Drawing.Point(98, 11)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(856, 30)
        Me.txtsearch.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 26)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Search"
        '
        'frmDep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1539, 728)
        Me.Controls.Add(Me.Panelmain)
        Me.Controls.Add(Me.PanelLeft)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDep"
        Me.Text = "frmDep"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelTop.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.PanelLeft.ResumeLayout(False)
        Me.PanelLeft.PerformLayout()
        Me.Panelmain.ResumeLayout(False)
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelsearch.ResumeLayout(False)
        Me.Panelsearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PanelLeft As System.Windows.Forms.Panel
    Friend WithEvents Panelmain As System.Windows.Forms.Panel
    Friend WithEvents butExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtstudent As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents butsave As System.Windows.Forms.Button
    Friend WithEvents Panelsearch As System.Windows.Forms.Panel
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
End Class
