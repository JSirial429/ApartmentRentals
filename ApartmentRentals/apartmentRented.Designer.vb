<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApartmentRented
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmApartmentRented))
        Me.gbxSelectItem = New System.Windows.Forms.GroupBox()
        Me.lstRented = New System.Windows.Forms.ListBox()
        Me.btnMakeAvailable = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.gbxSelectItem.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxSelectItem
        '
        Me.gbxSelectItem.Controls.Add(Me.lstRented)
        Me.gbxSelectItem.Location = New System.Drawing.Point(27, 37)
        Me.gbxSelectItem.Name = "gbxSelectItem"
        Me.gbxSelectItem.Size = New System.Drawing.Size(742, 293)
        Me.gbxSelectItem.TabIndex = 0
        Me.gbxSelectItem.TabStop = False
        Me.gbxSelectItem.Text = "Select Item"
        '
        'lstRented
        '
        Me.lstRented.FormattingEnabled = True
        Me.lstRented.ItemHeight = 20
        Me.lstRented.Location = New System.Drawing.Point(27, 38)
        Me.lstRented.Name = "lstRented"
        Me.lstRented.Size = New System.Drawing.Size(681, 224)
        Me.lstRented.TabIndex = 0
        '
        'btnMakeAvailable
        '
        Me.btnMakeAvailable.Location = New System.Drawing.Point(218, 359)
        Me.btnMakeAvailable.Name = "btnMakeAvailable"
        Me.btnMakeAvailable.Size = New System.Drawing.Size(176, 55)
        Me.btnMakeAvailable.TabIndex = 2
        Me.btnMakeAvailable.Text = "Make Available"
        Me.btnMakeAvailable.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(447, 359)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(176, 55)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmApartmentRented
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnMakeAvailable)
        Me.Controls.Add(Me.gbxSelectItem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmApartmentRented"
        Me.Text = "Rented"
        Me.gbxSelectItem.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxSelectItem As GroupBox
    Friend WithEvents btnMakeAvailable As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lstRented As ListBox
End Class
