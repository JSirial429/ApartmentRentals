<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApartmentAvailable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmApartmentAvailable))
        Me.gbxSelectItem = New System.Windows.Forms.GroupBox()
        Me.lstAvailable = New System.Windows.Forms.ListBox()
        Me.btnMakeRented = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.gbxSelectItem.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxSelectItem
        '
        Me.gbxSelectItem.Controls.Add(Me.lstAvailable)
        Me.gbxSelectItem.Location = New System.Drawing.Point(31, 37)
        Me.gbxSelectItem.Name = "gbxSelectItem"
        Me.gbxSelectItem.Size = New System.Drawing.Size(737, 295)
        Me.gbxSelectItem.TabIndex = 0
        Me.gbxSelectItem.TabStop = False
        Me.gbxSelectItem.Text = "Select Item"
        '
        'lstAvailable
        '
        Me.lstAvailable.FormattingEnabled = True
        Me.lstAvailable.ItemHeight = 20
        Me.lstAvailable.Location = New System.Drawing.Point(28, 35)
        Me.lstAvailable.Name = "lstAvailable"
        Me.lstAvailable.Size = New System.Drawing.Size(681, 224)
        Me.lstAvailable.TabIndex = 1
        '
        'btnMakeRented
        '
        Me.btnMakeRented.Location = New System.Drawing.Point(211, 367)
        Me.btnMakeRented.Name = "btnMakeRented"
        Me.btnMakeRented.Size = New System.Drawing.Size(176, 55)
        Me.btnMakeRented.TabIndex = 1
        Me.btnMakeRented.Text = "Make Rented"
        Me.btnMakeRented.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(442, 367)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(164, 55)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'frmApartmentAvailable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.btnMakeRented)
        Me.Controls.Add(Me.gbxSelectItem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmApartmentAvailable"
        Me.Text = "Available"
        Me.gbxSelectItem.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxSelectItem As GroupBox
    Friend WithEvents btnMakeRented As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents lstAvailable As ListBox
End Class
