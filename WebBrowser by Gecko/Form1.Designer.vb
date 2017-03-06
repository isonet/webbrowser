<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ss = New System.Windows.Forms.StatusStrip
        Me.ts = New System.Windows.Forms.ToolStrip
        Me.cms_mouse = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsb_backward = New System.Windows.Forms.ToolStripButton
        Me.tsb_forward = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ts_cbURL = New System.Windows.Forms.ToolStripComboBox
        Me.ms_head = New System.Windows.Forms.MenuStrip
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.line_head = New System.Windows.Forms.Button
        Me.line_head_2 = New System.Windows.Forms.Button
        Me.cms_wb = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenNewTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EigenschaftenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.ts.SuspendLayout()
        Me.ms_head.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.cms_wb.SuspendLayout()
        Me.SuspendLayout()
        '
        'ss
        '
        Me.ss.Location = New System.Drawing.Point(0, 518)
        Me.ss.Name = "ss"
        Me.ss.Size = New System.Drawing.Size(742, 22)
        Me.ss.TabIndex = 3
        Me.ss.Text = "StatusStrip1"
        '
        'ts
        '
        Me.ts.AllowItemReorder = True
        Me.ts.AutoSize = False
        Me.ts.BackColor = System.Drawing.Color.Silver
        Me.ts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ts.CanOverflow = False
        Me.ts.ContextMenuStrip = Me.cms_mouse
        Me.ts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsb_backward, Me.tsb_forward, Me.ToolStripButton1, Me.ts_cbURL})
        Me.ts.Location = New System.Drawing.Point(0, 24)
        Me.ts.Name = "ts"
        Me.ts.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ts.Size = New System.Drawing.Size(742, 35)
        Me.ts.TabIndex = 4
        '
        'cms_mouse
        '
        Me.cms_mouse.Name = "cms_mouse"
        Me.cms_mouse.Size = New System.Drawing.Size(61, 4)
        '
        'tsb_backward
        '
        Me.tsb_backward.AutoSize = False
        Me.tsb_backward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_backward.Image = CType(resources.GetObject("tsb_backward.Image"), System.Drawing.Image)
        Me.tsb_backward.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsb_backward.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_backward.Name = "tsb_backward"
        Me.tsb_backward.Size = New System.Drawing.Size(35, 35)
        Me.tsb_backward.Text = "ToolStripButton2"
        '
        'tsb_forward
        '
        Me.tsb_forward.AutoSize = False
        Me.tsb_forward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_forward.Image = CType(resources.GetObject("tsb_forward.Image"), System.Drawing.Image)
        Me.tsb_forward.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsb_forward.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_forward.Name = "tsb_forward"
        Me.tsb_forward.Size = New System.Drawing.Size(35, 35)
        Me.tsb_forward.Text = "ToolStripButton1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(35, 35)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ts_cbURL
        '
        Me.ts_cbURL.AutoSize = False
        Me.ts_cbURL.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ts_cbURL.Name = "ts_cbURL"
        Me.ts_cbURL.Size = New System.Drawing.Size(121, 23)
        Me.ts_cbURL.Sorted = True
        '
        'ms_head
        '
        Me.ms_head.BackColor = System.Drawing.Color.Silver
        Me.ms_head.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.ms_head.Location = New System.Drawing.Point(0, 0)
        Me.ms_head.Name = "ms_head"
        Me.ms_head.Size = New System.Drawing.Size(742, 24)
        Me.ms_head.TabIndex = 6
        Me.ms_head.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem1.Text = "?"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ListBox1)
        Me.Panel2.Location = New System.Drawing.Point(1, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(740, 418)
        Me.Panel2.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(741, 22)
        Me.Panel1.TabIndex = 7
        '
        'line_head
        '
        Me.line_head.BackColor = System.Drawing.Color.Gray
        Me.line_head.Enabled = False
        Me.line_head.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.line_head.FlatAppearance.BorderSize = 0
        Me.line_head.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.line_head.Location = New System.Drawing.Point(0, 24)
        Me.line_head.Name = "line_head"
        Me.line_head.Size = New System.Drawing.Size(102, 2)
        Me.line_head.TabIndex = 9
        Me.line_head.UseVisualStyleBackColor = False
        '
        'line_head_2
        '
        Me.line_head_2.BackColor = System.Drawing.Color.Gray
        Me.line_head_2.Enabled = False
        Me.line_head_2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.line_head_2.FlatAppearance.BorderSize = 0
        Me.line_head_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.line_head_2.Location = New System.Drawing.Point(0, 57)
        Me.line_head_2.Name = "line_head_2"
        Me.line_head_2.Size = New System.Drawing.Size(102, 2)
        Me.line_head_2.TabIndex = 10
        Me.line_head_2.UseVisualStyleBackColor = False
        '
        'cms_wb
        '
        Me.cms_wb.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenNewTabToolStripMenuItem, Me.EigenschaftenToolStripMenuItem})
        Me.cms_wb.Name = "cms_wb"
        Me.cms_wb.Size = New System.Drawing.Size(152, 48)
        '
        'OpenNewTabToolStripMenuItem
        '
        Me.OpenNewTabToolStripMenuItem.Name = "OpenNewTabToolStripMenuItem"
        Me.OpenNewTabToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.OpenNewTabToolStripMenuItem.Text = "Open new Tab"
        '
        'EigenschaftenToolStripMenuItem
        '
        Me.EigenschaftenToolStripMenuItem.Name = "EigenschaftenToolStripMenuItem"
        Me.EigenschaftenToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.EigenschaftenToolStripMenuItem.Text = "Eigenschaften"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(246, 50)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(226, 290)
        Me.ListBox1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(742, 540)
        Me.Controls.Add(Me.line_head_2)
        Me.Controls.Add(Me.line_head)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ts)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ss)
        Me.Controls.Add(Me.ms_head)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.ms_head
        Me.Name = "Form1"
        Me.Text = "WebBrowser"
        Me.ts.ResumeLayout(False)
        Me.ts.PerformLayout()
        Me.ms_head.ResumeLayout(False)
        Me.ms_head.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.cms_wb.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ss As System.Windows.Forms.StatusStrip
    Friend WithEvents ts As System.Windows.Forms.ToolStrip
    Friend WithEvents ts_cbURL As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tsb_forward As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsb_backward As System.Windows.Forms.ToolStripButton
    Friend WithEvents cms_mouse As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ms_head As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents line_head As System.Windows.Forms.Button
    Friend WithEvents line_head_2 As System.Windows.Forms.Button
    Friend WithEvents cms_wb As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenNewTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EigenschaftenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
