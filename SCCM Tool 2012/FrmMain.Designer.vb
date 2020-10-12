<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.statusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lstCollections = New System.Windows.Forms.ListBox()
        Me.btnAddTitles = New System.Windows.Forms.Button()
        Me.lblUsers = New System.Windows.Forms.Label()
        Me.lstIDsToAdd = New System.Windows.Forms.ListBox()
        Me.txtCollections = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstUsers = New System.Windows.Forms.ListBox()
        Me.txtComputers = New System.Windows.Forms.RichTextBox()
        Me.btnAddNames = New System.Windows.Forms.Button()
        Me.btnAddFromClipboard = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPush = New System.Windows.Forms.Button()
        Me.chkShowAll = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgressBar, Me.statusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 339)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(499, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ProgressBar
        '
        Me.ProgressBar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(100, 16)
        '
        'statusLabel
        '
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(42, 17)
        Me.statusLabel.Text = "Ready."
        '
        'lstCollections
        '
        Me.lstCollections.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCollections.FormattingEnabled = True
        Me.lstCollections.Location = New System.Drawing.Point(12, 93)
        Me.lstCollections.Name = "lstCollections"
        Me.lstCollections.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstCollections.Size = New System.Drawing.Size(294, 199)
        Me.lstCollections.Sorted = True
        Me.lstCollections.TabIndex = 3
        '
        'btnAddTitles
        '
        Me.btnAddTitles.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTitles.Location = New System.Drawing.Point(11, 60)
        Me.btnAddTitles.Name = "btnAddTitles"
        Me.btnAddTitles.Size = New System.Drawing.Size(296, 27)
        Me.btnAddTitles.TabIndex = 21
        Me.btnAddTitles.Text = "Add To Queue"
        Me.btnAddTitles.UseVisualStyleBackColor = True
        '
        'lblUsers
        '
        Me.lblUsers.AutoSize = True
        Me.lblUsers.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsers.Location = New System.Drawing.Point(325, 9)
        Me.lblUsers.Name = "lblUsers"
        Me.lblUsers.Size = New System.Drawing.Size(104, 15)
        Me.lblUsers.TabIndex = 16
        Me.lblUsers.Text = "Computer Names:"
        '
        'lstIDsToAdd
        '
        Me.lstIDsToAdd.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstIDsToAdd.FormattingEnabled = True
        Me.lstIDsToAdd.Location = New System.Drawing.Point(328, 236)
        Me.lstIDsToAdd.Name = "lstIDsToAdd"
        Me.lstIDsToAdd.Size = New System.Drawing.Size(159, 56)
        Me.lstIDsToAdd.TabIndex = 15
        '
        'txtCollections
        '
        Me.txtCollections.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCollections.Location = New System.Drawing.Point(13, 27)
        Me.txtCollections.Multiline = False
        Me.txtCollections.Name = "txtCollections"
        Me.txtCollections.Size = New System.Drawing.Size(293, 27)
        Me.txtCollections.TabIndex = 0
        Me.txtCollections.Text = ""
        Me.txtCollections.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 15)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Software Collections:"
        '
        'lstUsers
        '
        Me.lstUsers.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstUsers.FormattingEnabled = True
        Me.lstUsers.Location = New System.Drawing.Point(328, 145)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.Size = New System.Drawing.Size(159, 69)
        Me.lstUsers.TabIndex = 14
        '
        'txtComputers
        '
        Me.txtComputers.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComputers.Location = New System.Drawing.Point(328, 27)
        Me.txtComputers.Name = "txtComputers"
        Me.txtComputers.Size = New System.Drawing.Size(159, 27)
        Me.txtComputers.TabIndex = 1
        Me.txtComputers.Text = ""
        Me.txtComputers.WordWrap = False
        '
        'btnAddNames
        '
        Me.btnAddNames.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNames.Location = New System.Drawing.Point(327, 60)
        Me.btnAddNames.Name = "btnAddNames"
        Me.btnAddNames.Size = New System.Drawing.Size(160, 27)
        Me.btnAddNames.TabIndex = 29
        Me.btnAddNames.Text = "Add To Queue"
        Me.btnAddNames.UseVisualStyleBackColor = True
        '
        'btnAddFromClipboard
        '
        Me.btnAddFromClipboard.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddFromClipboard.Location = New System.Drawing.Point(327, 93)
        Me.btnAddFromClipboard.Name = "btnAddFromClipboard"
        Me.btnAddFromClipboard.Size = New System.Drawing.Size(160, 27)
        Me.btnAddFromClipboard.TabIndex = 30
        Me.btnAddFromClipboard.Text = "Add From Clipboard"
        Me.btnAddFromClipboard.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(325, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 15)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Collections To Add:"
        '
        'btnPush
        '
        Me.btnPush.Location = New System.Drawing.Point(10, 298)
        Me.btnPush.Name = "btnPush"
        Me.btnPush.Size = New System.Drawing.Size(479, 33)
        Me.btnPush.TabIndex = 32
        Me.btnPush.Text = "Push Queue"
        Me.btnPush.UseVisualStyleBackColor = True
        '
        'chkShowAll
        '
        Me.chkShowAll.AutoSize = True
        Me.chkShowAll.Location = New System.Drawing.Point(239, 7)
        Me.chkShowAll.Name = "chkShowAll"
        Me.chkShowAll.Size = New System.Drawing.Size(71, 17)
        Me.chkShowAll.TabIndex = 33
        Me.chkShowAll.Text = "Show All"
        Me.chkShowAll.UseVisualStyleBackColor = True
        Me.chkShowAll.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(325, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 15)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Workstations To Add:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 361)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkShowAll)
        Me.Controls.Add(Me.btnPush)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddFromClipboard)
        Me.Controls.Add(Me.btnAddNames)
        Me.Controls.Add(Me.txtComputers)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCollections)
        Me.Controls.Add(Me.btnAddTitles)
        Me.Controls.Add(Me.lblUsers)
        Me.Controls.Add(Me.lstIDsToAdd)
        Me.Controls.Add(Me.lstUsers)
        Me.Controls.Add(Me.lstCollections)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ninja"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents statusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lstCollections As System.Windows.Forms.ListBox
    Friend WithEvents btnAddTitles As System.Windows.Forms.Button
    Friend WithEvents lblUsers As System.Windows.Forms.Label
    Friend WithEvents lstIDsToAdd As System.Windows.Forms.ListBox
    Friend WithEvents txtCollections As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstUsers As System.Windows.Forms.ListBox
    Friend WithEvents txtComputers As System.Windows.Forms.RichTextBox
    Friend WithEvents btnAddNames As System.Windows.Forms.Button
    Friend WithEvents btnAddFromClipboard As System.Windows.Forms.Button
    Friend WithEvents ProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPush As System.Windows.Forms.Button
    Friend WithEvents chkShowAll As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
