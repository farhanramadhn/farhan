<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tNameReq = New System.Windows.Forms.TextBox()
        Me.tIdNumber = New System.Windows.Forms.TextBox()
        Me.tUnit = New System.Windows.Forms.TextBox()
        Me.tIntruction = New System.Windows.Forms.TextBox()
        Me.tUnitDesti = New System.Windows.Forms.TextBox()
        Me.tACReg = New System.Windows.Forms.TextBox()
        Me.cTransportation = New System.Windows.Forms.ComboBox()
        Me.tPhone = New System.Windows.Forms.TextBox()
        Me.tTransportation = New System.Windows.Forms.TextBox()
        Me.bSend = New System.Windows.Forms.Button()
        Me.LVreq = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bRequest = New System.Windows.Forms.Button()
        Me.tRequestId = New System.Windows.Forms.TextBox()
        Me.DTPIssue = New System.Windows.Forms.DateTimePicker()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name of Requestor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Unit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date of Issue"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Instructions"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(382, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "to Unit/Destination"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(382, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "A/C Reg"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(382, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Ext, Phone/HP"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(382, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Transportation"
        '
        'tNameReq
        '
        Me.tNameReq.Location = New System.Drawing.Point(156, 41)
        Me.tNameReq.Name = "tNameReq"
        Me.tNameReq.Size = New System.Drawing.Size(100, 20)
        Me.tNameReq.TabIndex = 9
        '
        'tIdNumber
        '
        Me.tIdNumber.Location = New System.Drawing.Point(156, 76)
        Me.tIdNumber.Name = "tIdNumber"
        Me.tIdNumber.Size = New System.Drawing.Size(100, 20)
        Me.tIdNumber.TabIndex = 10
        '
        'tUnit
        '
        Me.tUnit.Location = New System.Drawing.Point(156, 108)
        Me.tUnit.Name = "tUnit"
        Me.tUnit.Size = New System.Drawing.Size(100, 20)
        Me.tUnit.TabIndex = 11
        '
        'tIntruction
        '
        Me.tIntruction.Location = New System.Drawing.Point(156, 182)
        Me.tIntruction.Multiline = True
        Me.tIntruction.Name = "tIntruction"
        Me.tIntruction.Size = New System.Drawing.Size(565, 107)
        Me.tIntruction.TabIndex = 13
        '
        'tUnitDesti
        '
        Me.tUnitDesti.Location = New System.Drawing.Point(479, 38)
        Me.tUnitDesti.Name = "tUnitDesti"
        Me.tUnitDesti.Size = New System.Drawing.Size(100, 20)
        Me.tUnitDesti.TabIndex = 14
        '
        'tACReg
        '
        Me.tACReg.Location = New System.Drawing.Point(479, 76)
        Me.tACReg.Name = "tACReg"
        Me.tACReg.Size = New System.Drawing.Size(100, 20)
        Me.tACReg.TabIndex = 15
        '
        'cTransportation
        '
        Me.cTransportation.FormattingEnabled = True
        Me.cTransportation.Location = New System.Drawing.Point(479, 111)
        Me.cTransportation.Name = "cTransportation"
        Me.cTransportation.Size = New System.Drawing.Size(100, 21)
        Me.cTransportation.TabIndex = 16
        '
        'tPhone
        '
        Me.tPhone.Location = New System.Drawing.Point(479, 144)
        Me.tPhone.Name = "tPhone"
        Me.tPhone.Size = New System.Drawing.Size(100, 20)
        Me.tPhone.TabIndex = 17
        '
        'tTransportation
        '
        Me.tTransportation.Location = New System.Drawing.Point(585, 111)
        Me.tTransportation.Name = "tTransportation"
        Me.tTransportation.Size = New System.Drawing.Size(100, 20)
        Me.tTransportation.TabIndex = 18
        '
        'bSend
        '
        Me.bSend.Location = New System.Drawing.Point(156, 295)
        Me.bSend.Name = "bSend"
        Me.bSend.Size = New System.Drawing.Size(129, 23)
        Me.bSend.TabIndex = 19
        Me.bSend.Text = "Send Request"
        Me.bSend.UseVisualStyleBackColor = True
        '
        'LVreq
        '
        Me.LVreq.ContextMenuStrip = Me.ContextMenuStrip1
        Me.LVreq.Location = New System.Drawing.Point(25, 324)
        Me.LVreq.Name = "LVreq"
        Me.LVreq.Size = New System.Drawing.Size(696, 182)
        Me.LVreq.TabIndex = 20
        Me.LVreq.UseCompatibleStateImageBehavior = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'bRequest
        '
        Me.bRequest.Location = New System.Drawing.Point(156, 294)
        Me.bRequest.Name = "bRequest"
        Me.bRequest.Size = New System.Drawing.Size(129, 23)
        Me.bRequest.TabIndex = 22
        Me.bRequest.Text = "Update Request"
        Me.bRequest.UseVisualStyleBackColor = True
        '
        'tRequestId
        '
        Me.tRequestId.Location = New System.Drawing.Point(698, 297)
        Me.tRequestId.Name = "tRequestId"
        Me.tRequestId.ShortcutsEnabled = False
        Me.tRequestId.Size = New System.Drawing.Size(23, 20)
        Me.tRequestId.TabIndex = 23
        '
        'DTPIssue
        '
        Me.DTPIssue.CustomFormat = "MM/dd/yyyy HH:mm:ss"
        Me.DTPIssue.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPIssue.Location = New System.Drawing.Point(156, 150)
        Me.DTPIssue.Name = "DTPIssue"
        Me.DTPIssue.Size = New System.Drawing.Size(200, 20)
        Me.DTPIssue.TabIndex = 24
        Me.DTPIssue.Value = New Date(2018, 10, 19, 14, 32, 13, 0)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 518)
        Me.Controls.Add(Me.DTPIssue)
        Me.Controls.Add(Me.tRequestId)
        Me.Controls.Add(Me.bRequest)
        Me.Controls.Add(Me.LVreq)
        Me.Controls.Add(Me.bSend)
        Me.Controls.Add(Me.tTransportation)
        Me.Controls.Add(Me.tPhone)
        Me.Controls.Add(Me.cTransportation)
        Me.Controls.Add(Me.tACReg)
        Me.Controls.Add(Me.tUnitDesti)
        Me.Controls.Add(Me.tIntruction)
        Me.Controls.Add(Me.tUnit)
        Me.Controls.Add(Me.tIdNumber)
        Me.Controls.Add(Me.tNameReq)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tNameReq As System.Windows.Forms.TextBox
    Friend WithEvents tIdNumber As System.Windows.Forms.TextBox
    Friend WithEvents tUnit As System.Windows.Forms.TextBox
    Friend WithEvents tIntruction As System.Windows.Forms.TextBox
    Friend WithEvents tUnitDesti As System.Windows.Forms.TextBox
    Friend WithEvents tACReg As System.Windows.Forms.TextBox
    Friend WithEvents cTransportation As System.Windows.Forms.ComboBox
    Friend WithEvents tPhone As System.Windows.Forms.TextBox
    Friend WithEvents tTransportation As System.Windows.Forms.TextBox
    Friend WithEvents bSend As System.Windows.Forms.Button
    Friend WithEvents LVreq As System.Windows.Forms.ListView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bRequest As System.Windows.Forms.Button
    Friend WithEvents tRequestId As System.Windows.Forms.TextBox
    Friend WithEvents DTPIssue As System.Windows.Forms.DateTimePicker

End Class
