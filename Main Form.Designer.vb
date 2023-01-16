<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortAcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortDecendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SortOriginalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WriteFileToStorageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAddState = New System.Windows.Forms.Button()
        Me.lblUserAdd = New System.Windows.Forms.TextBox()
        Me.lstStates = New System.Windows.Forms.ListBox()
        Me.btnReadFile = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SortToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(439, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SortToolStripMenuItem
        '
        Me.SortToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SortAcToolStripMenuItem, Me.SortDecendingToolStripMenuItem, Me.ToolStripSeparator1, Me.SortOriginalToolStripMenuItem, Me.WriteFileToStorageToolStripMenuItem})
        Me.SortToolStripMenuItem.Name = "SortToolStripMenuItem"
        Me.SortToolStripMenuItem.Size = New System.Drawing.Size(50, 24)
        Me.SortToolStripMenuItem.Text = "Sort"
        '
        'SortAcToolStripMenuItem
        '
        Me.SortAcToolStripMenuItem.Name = "SortAcToolStripMenuItem"
        Me.SortAcToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.SortAcToolStripMenuItem.Text = "Sort Ascending"
        '
        'SortDecendingToolStripMenuItem
        '
        Me.SortDecendingToolStripMenuItem.Name = "SortDecendingToolStripMenuItem"
        Me.SortDecendingToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.SortDecendingToolStripMenuItem.Text = "Sort Decending"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(226, 6)
        '
        'SortOriginalToolStripMenuItem
        '
        Me.SortOriginalToolStripMenuItem.Name = "SortOriginalToolStripMenuItem"
        Me.SortOriginalToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.SortOriginalToolStripMenuItem.Text = "Sort Original"
        '
        'WriteFileToStorageToolStripMenuItem
        '
        Me.WriteFileToStorageToolStripMenuItem.Name = "WriteFileToStorageToolStripMenuItem"
        Me.WriteFileToStorageToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.WriteFileToStorageToolStripMenuItem.Text = "Write File to Storage"
        '
        'btnAddState
        '
        Me.btnAddState.Location = New System.Drawing.Point(182, 97)
        Me.btnAddState.Name = "btnAddState"
        Me.btnAddState.Size = New System.Drawing.Size(126, 29)
        Me.btnAddState.TabIndex = 2
        Me.btnAddState.Text = "Add a State"
        Me.btnAddState.UseVisualStyleBackColor = True
        '
        'lblUserAdd
        '
        Me.lblUserAdd.Location = New System.Drawing.Point(168, 64)
        Me.lblUserAdd.Name = "lblUserAdd"
        Me.lblUserAdd.Size = New System.Drawing.Size(154, 27)
        Me.lblUserAdd.TabIndex = 3
        '
        'lstStates
        '
        Me.lstStates.FormattingEnabled = True
        Me.lstStates.ItemHeight = 20
        Me.lstStates.Location = New System.Drawing.Point(12, 64)
        Me.lstStates.Name = "lstStates"
        Me.lstStates.Size = New System.Drawing.Size(150, 104)
        Me.lstStates.TabIndex = 4
        '
        'btnReadFile
        '
        Me.btnReadFile.Location = New System.Drawing.Point(26, 174)
        Me.btnReadFile.Name = "btnReadFile"
        Me.btnReadFile.Size = New System.Drawing.Size(124, 29)
        Me.btnReadFile.TabIndex = 5
        Me.btnReadFile.Text = "Read From File"
        Me.btnReadFile.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Organized List"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 217)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReadFile)
        Me.Controls.Add(Me.lstStates)
        Me.Controls.Add(Me.lblUserAdd)
        Me.Controls.Add(Me.btnAddState)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Countries & States"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortAcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortDecendingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAddState As Button
    Friend WithEvents lblUserAdd As TextBox
    Friend WithEvents lstStates As ListBox
    Friend WithEvents btnReadFile As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SortOriginalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WriteFileToStorageToolStripMenuItem As ToolStripMenuItem
End Class
