<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApartmentRentals
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmApartmentRentals))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUnits = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAvailable = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRented = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbxApartmentList = New System.Windows.Forms.GroupBox()
        Me.lblTotalOutput = New System.Windows.Forms.Label()
        Me.lblAvailableOutput = New System.Windows.Forms.Label()
        Me.lblRentedOutput = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblAvailable = New System.Windows.Forms.Label()
        Me.lblRented = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblStatusCount = New System.Windows.Forms.Label()
        Me.cboStatusCount = New System.Windows.Forms.ComboBox()
        Me.lstApartments = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.gbxApartmentList.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuUnits, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReset, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(50, 29)
        Me.mnuFile.Text = "File"
        '
        'mnuReset
        '
        Me.mnuReset.Name = "mnuReset"
        Me.mnuReset.Size = New System.Drawing.Size(252, 30)
        Me.mnuReset.Text = "Reset"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuExit.Size = New System.Drawing.Size(252, 30)
        Me.mnuExit.Text = "Exit"
        '
        'mnuUnits
        '
        Me.mnuUnits.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAvailable, Me.mnuRented})
        Me.mnuUnits.Name = "mnuUnits"
        Me.mnuUnits.Size = New System.Drawing.Size(64, 29)
        Me.mnuUnits.Text = "Units"
        '
        'mnuAvailable
        '
        Me.mnuAvailable.Name = "mnuAvailable"
        Me.mnuAvailable.Size = New System.Drawing.Size(167, 30)
        Me.mnuAvailable.Text = "Available"
        '
        'mnuRented
        '
        Me.mnuRented.Name = "mnuRented"
        Me.mnuRented.Size = New System.Drawing.Size(167, 30)
        Me.mnuRented.Text = "Rented"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(61, 29)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.mnuAbout.Size = New System.Drawing.Size(252, 30)
        Me.mnuAbout.Text = "About"
        '
        'gbxApartmentList
        '
        Me.gbxApartmentList.Controls.Add(Me.lblTotalOutput)
        Me.gbxApartmentList.Controls.Add(Me.lblAvailableOutput)
        Me.gbxApartmentList.Controls.Add(Me.lblRentedOutput)
        Me.gbxApartmentList.Controls.Add(Me.lblTotal)
        Me.gbxApartmentList.Controls.Add(Me.lblAvailable)
        Me.gbxApartmentList.Controls.Add(Me.lblRented)
        Me.gbxApartmentList.Controls.Add(Me.btnRemove)
        Me.gbxApartmentList.Controls.Add(Me.lblStatusCount)
        Me.gbxApartmentList.Controls.Add(Me.cboStatusCount)
        Me.gbxApartmentList.Controls.Add(Me.lstApartments)
        Me.gbxApartmentList.Location = New System.Drawing.Point(12, 59)
        Me.gbxApartmentList.Name = "gbxApartmentList"
        Me.gbxApartmentList.Size = New System.Drawing.Size(776, 402)
        Me.gbxApartmentList.TabIndex = 2
        Me.gbxApartmentList.TabStop = False
        Me.gbxApartmentList.Text = "Apartment List"
        '
        'lblTotalOutput
        '
        Me.lblTotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalOutput.Location = New System.Drawing.Point(625, 263)
        Me.lblTotalOutput.Name = "lblTotalOutput"
        Me.lblTotalOutput.Size = New System.Drawing.Size(136, 20)
        Me.lblTotalOutput.TabIndex = 8
        Me.lblTotalOutput.Text = "lblTotalOutput"
        '
        'lblAvailableOutput
        '
        Me.lblAvailableOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvailableOutput.Location = New System.Drawing.Point(625, 95)
        Me.lblAvailableOutput.Name = "lblAvailableOutput"
        Me.lblAvailableOutput.Size = New System.Drawing.Size(136, 20)
        Me.lblAvailableOutput.TabIndex = 7
        Me.lblAvailableOutput.Text = "lblAvailableOutput"
        '
        'lblRentedOutput
        '
        Me.lblRentedOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRentedOutput.Location = New System.Drawing.Point(625, 32)
        Me.lblRentedOutput.Name = "lblRentedOutput"
        Me.lblRentedOutput.Size = New System.Drawing.Size(136, 31)
        Me.lblRentedOutput.TabIndex = 6
        Me.lblRentedOutput.Text = "lblRentedOutput"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(505, 263)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(48, 20)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "Total:"
        '
        'lblAvailable
        '
        Me.lblAvailable.AutoSize = True
        Me.lblAvailable.Location = New System.Drawing.Point(487, 95)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(76, 20)
        Me.lblAvailable.TabIndex = 4
        Me.lblAvailable.Text = "Available:"
        '
        'lblRented
        '
        Me.lblRented.AutoSize = True
        Me.lblRented.Location = New System.Drawing.Point(497, 32)
        Me.lblRented.Name = "lblRented"
        Me.lblRented.Size = New System.Drawing.Size(66, 20)
        Me.lblRented.TabIndex = 5
        Me.lblRented.Text = "Rented:"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(313, 312)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(92, 42)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'lblStatusCount
        '
        Me.lblStatusCount.AutoSize = True
        Me.lblStatusCount.Location = New System.Drawing.Point(25, 323)
        Me.lblStatusCount.Name = "lblStatusCount"
        Me.lblStatusCount.Size = New System.Drawing.Size(107, 20)
        Me.lblStatusCount.TabIndex = 2
        Me.lblStatusCount.Text = "Status Count:"
        '
        'cboStatusCount
        '
        Me.cboStatusCount.FormattingEnabled = True
        Me.cboStatusCount.Location = New System.Drawing.Point(138, 320)
        Me.cboStatusCount.Name = "cboStatusCount"
        Me.cboStatusCount.Size = New System.Drawing.Size(168, 28)
        Me.cboStatusCount.TabIndex = 1
        '
        'lstApartments
        '
        Me.lstApartments.FormattingEnabled = True
        Me.lstApartments.ItemHeight = 20
        Me.lstApartments.Location = New System.Drawing.Point(29, 32)
        Me.lstApartments.Name = "lstApartments"
        Me.lstApartments.Size = New System.Drawing.Size(376, 264)
        Me.lstApartments.TabIndex = 0
        '
        'frmApartmentRentals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 473)
        Me.Controls.Add(Me.gbxApartmentList)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmApartmentRentals"
        Me.Text = "Apartment Rentals"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbxApartmentList.ResumeLayout(False)
        Me.gbxApartmentList.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuReset As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuUnits As ToolStripMenuItem
    Friend WithEvents mnuAvailable As ToolStripMenuItem
    Friend WithEvents mnuRented As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents gbxApartmentList As GroupBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents lblStatusCount As Label
    Friend WithEvents cboStatusCount As ComboBox
    Friend WithEvents lstApartments As ListBox
    Friend WithEvents lblTotalOutput As Label
    Friend WithEvents lblAvailableOutput As Label
    Friend WithEvents lblRentedOutput As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblAvailable As Label
    Friend WithEvents lblRented As Label
End Class
