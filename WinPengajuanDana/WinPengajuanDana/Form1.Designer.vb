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
        Me.tNamaPel = New System.Windows.Forms.TextBox()
        Me.tJmlPermintaan = New System.Windows.Forms.TextBox()
        Me.tKeperluan = New System.Windows.Forms.TextBox()
        Me.cBidang = New System.Windows.Forms.ComboBox()
        Me.rTunai = New System.Windows.Forms.RadioButton()
        Me.rCekBank = New System.Windows.Forms.RadioButton()
        Me.rGiro = New System.Windows.Forms.RadioButton()
        Me.bSimpan = New System.Windows.Forms.Button()
        Me.LVPengajuan = New System.Windows.Forms.ListView()
        Me.CMpengajuan = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tId = New System.Windows.Forms.TextBox()
        Me.bUpdate = New System.Windows.Forms.Button()
        Me.CMpengajuan.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Pelaksana"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bidang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jml. Permintaan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Bentuk Dana"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Keperluan"
        '
        'tNamaPel
        '
        Me.tNamaPel.Location = New System.Drawing.Point(138, 64)
        Me.tNamaPel.Name = "tNamaPel"
        Me.tNamaPel.Size = New System.Drawing.Size(190, 20)
        Me.tNamaPel.TabIndex = 5
        '
        'tJmlPermintaan
        '
        Me.tJmlPermintaan.Location = New System.Drawing.Point(138, 160)
        Me.tJmlPermintaan.Name = "tJmlPermintaan"
        Me.tJmlPermintaan.Size = New System.Drawing.Size(190, 20)
        Me.tJmlPermintaan.TabIndex = 6
        '
        'tKeperluan
        '
        Me.tKeperluan.Location = New System.Drawing.Point(138, 323)
        Me.tKeperluan.Multiline = True
        Me.tKeperluan.Name = "tKeperluan"
        Me.tKeperluan.Size = New System.Drawing.Size(229, 127)
        Me.tKeperluan.TabIndex = 7
        '
        'cBidang
        '
        Me.cBidang.FormattingEnabled = True
        Me.cBidang.Location = New System.Drawing.Point(138, 115)
        Me.cBidang.Name = "cBidang"
        Me.cBidang.Size = New System.Drawing.Size(190, 21)
        Me.cBidang.TabIndex = 8
        '
        'rTunai
        '
        Me.rTunai.AutoSize = True
        Me.rTunai.Location = New System.Drawing.Point(138, 207)
        Me.rTunai.Name = "rTunai"
        Me.rTunai.Size = New System.Drawing.Size(52, 17)
        Me.rTunai.TabIndex = 9
        Me.rTunai.TabStop = True
        Me.rTunai.Text = "Tunai"
        Me.rTunai.UseVisualStyleBackColor = True
        '
        'rCekBank
        '
        Me.rCekBank.AutoSize = True
        Me.rCekBank.Location = New System.Drawing.Point(138, 242)
        Me.rCekBank.Name = "rCekBank"
        Me.rCekBank.Size = New System.Drawing.Size(72, 17)
        Me.rCekBank.TabIndex = 10
        Me.rCekBank.TabStop = True
        Me.rCekBank.Text = "Cek Bank"
        Me.rCekBank.UseVisualStyleBackColor = True
        '
        'rGiro
        '
        Me.rGiro.AutoSize = True
        Me.rGiro.Location = New System.Drawing.Point(138, 277)
        Me.rGiro.Name = "rGiro"
        Me.rGiro.Size = New System.Drawing.Size(44, 17)
        Me.rGiro.TabIndex = 11
        Me.rGiro.TabStop = True
        Me.rGiro.Text = "Giro"
        Me.rGiro.UseVisualStyleBackColor = True
        '
        'bSimpan
        '
        Me.bSimpan.Location = New System.Drawing.Point(147, 461)
        Me.bSimpan.Name = "bSimpan"
        Me.bSimpan.Size = New System.Drawing.Size(75, 23)
        Me.bSimpan.TabIndex = 12
        Me.bSimpan.Text = "Simpan"
        Me.bSimpan.UseVisualStyleBackColor = True
        '
        'LVPengajuan
        '
        Me.LVPengajuan.ContextMenuStrip = Me.CMpengajuan
        Me.LVPengajuan.Location = New System.Drawing.Point(379, 64)
        Me.LVPengajuan.Name = "LVPengajuan"
        Me.LVPengajuan.Size = New System.Drawing.Size(396, 230)
        Me.LVPengajuan.TabIndex = 14
        Me.LVPengajuan.UseCompatibleStateImageBehavior = False
        '
        'CMpengajuan
        '
        Me.CMpengajuan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.CMpengajuan.Name = "CMpengajuan"
        Me.CMpengajuan.Size = New System.Drawing.Size(108, 48)
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
        'tId
        '
        Me.tId.Location = New System.Drawing.Point(739, 464)
        Me.tId.Name = "tId"
        Me.tId.Size = New System.Drawing.Size(36, 20)
        Me.tId.TabIndex = 15
        '
        'bUpdate
        '
        Me.bUpdate.Location = New System.Drawing.Point(147, 461)
        Me.bUpdate.Name = "bUpdate"
        Me.bUpdate.Size = New System.Drawing.Size(75, 23)
        Me.bUpdate.TabIndex = 16
        Me.bUpdate.Text = "Update"
        Me.bUpdate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 496)
        Me.Controls.Add(Me.bUpdate)
        Me.Controls.Add(Me.tId)
        Me.Controls.Add(Me.LVPengajuan)
        Me.Controls.Add(Me.bSimpan)
        Me.Controls.Add(Me.rGiro)
        Me.Controls.Add(Me.rCekBank)
        Me.Controls.Add(Me.rTunai)
        Me.Controls.Add(Me.cBidang)
        Me.Controls.Add(Me.tKeperluan)
        Me.Controls.Add(Me.tJmlPermintaan)
        Me.Controls.Add(Me.tNamaPel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Pengajuan Dana"
        Me.CMpengajuan.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tNamaPel As System.Windows.Forms.TextBox
    Friend WithEvents tJmlPermintaan As System.Windows.Forms.TextBox
    Friend WithEvents tKeperluan As System.Windows.Forms.TextBox
    Friend WithEvents cBidang As System.Windows.Forms.ComboBox
    Friend WithEvents rTunai As System.Windows.Forms.RadioButton
    Friend WithEvents rCekBank As System.Windows.Forms.RadioButton
    Friend WithEvents rGiro As System.Windows.Forms.RadioButton
    Friend WithEvents bSimpan As System.Windows.Forms.Button
    Friend WithEvents LVPengajuan As System.Windows.Forms.ListView
    Friend WithEvents CMpengajuan As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tId As System.Windows.Forms.TextBox
    Friend WithEvents bUpdate As System.Windows.Forms.Button

End Class
