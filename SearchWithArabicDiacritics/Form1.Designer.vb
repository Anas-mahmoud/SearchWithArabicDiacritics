<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.rtbSource = New System.Windows.Forms.RichTextBox()
        Me.chkAutoColor = New System.Windows.Forms.CheckBox()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblResults = New System.Windows.Forms.ToolStripStatusLabel()
        Me.prgColor = New System.Windows.Forms.ToolStripProgressBar()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'rtbSource
        '
        Me.rtbSource.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbSource.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbSource.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.rtbSource.Location = New System.Drawing.Point(10, 10)
        Me.rtbSource.Margin = New System.Windows.Forms.Padding(10)
        Me.rtbSource.Name = "rtbSource"
        Me.rtbSource.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rtbSource.Size = New System.Drawing.Size(606, 354)
        Me.rtbSource.TabIndex = 1
        Me.rtbSource.Text = resources.GetString("rtbSource.Text")
        '
        'chkAutoColor
        '
        Me.chkAutoColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAutoColor.AutoSize = True
        Me.chkAutoColor.Checked = True
        Me.chkAutoColor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoColor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkAutoColor.Location = New System.Drawing.Point(571, 22)
        Me.chkAutoColor.Name = "chkAutoColor"
        Me.chkAutoColor.Size = New System.Drawing.Size(87, 19)
        Me.chkAutoColor.TabIndex = 5
        Me.chkAutoColor.Text = "تلوين تلقائي"
        Me.chkAutoColor.UseVisualStyleBackColor = True
        '
        'lstResults
        '
        Me.lstResults.BackColor = System.Drawing.SystemColors.Window
        Me.lstResults.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstResults.Dock = System.Windows.Forms.DockStyle.Right
        Me.lstResults.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.IntegralHeight = False
        Me.lstResults.ItemHeight = 27
        Me.lstResults.Location = New System.Drawing.Point(626, 105)
        Me.lstResults.Margin = New System.Windows.Forms.Padding(2)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(133, 396)
        Me.lstResults.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(759, 57)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ادخل النص المطلوب البحث عنه:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StatusStrip1
        '
        Me.StatusStrip1.GripMargin = New System.Windows.Forms.Padding(0)
        Me.StatusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblResults, Me.prgColor})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 479)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(626, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblResults
        '
        Me.lblResults.BackColor = System.Drawing.SystemColors.Window
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(65, 17)
        Me.lblResults.Text = "- نتيجة بحث"
        '
        'prgColor
        '
        Me.prgColor.AutoSize = False
        Me.prgColor.Name = "prgColor"
        Me.prgColor.RightToLeftLayout = True
        Me.prgColor.Size = New System.Drawing.Size(200, 16)
        Me.prgColor.Step = 1
        Me.prgColor.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'btnColor
        '
        Me.btnColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnColor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnColor.Location = New System.Drawing.Point(664, 12)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(83, 36)
        Me.btnColor.TabIndex = 7
        Me.btnColor.Text = "تلوين النتائج"
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rtbSource)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 105)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel1.Size = New System.Drawing.Size(626, 374)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtSearch)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel2.Size = New System.Drawing.Size(759, 48)
        Me.Panel2.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearch.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.txtSearch.Location = New System.Drawing.Point(10, 10)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(737, 28)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.Text = "من"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(759, 501)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnColor)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.chkAutoColor)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "البحث بالعربية داخل التشكيل"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rtbSource As RichTextBox
    Friend WithEvents chkAutoColor As CheckBox
    Friend WithEvents lstResults As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblResults As ToolStripStatusLabel
    Friend WithEvents prgColor As ToolStripProgressBar
    Friend WithEvents btnColor As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSearch As TextBox
End Class
