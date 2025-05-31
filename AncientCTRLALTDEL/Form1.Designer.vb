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
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.warn = New System.Windows.Forms.Label
        Me.leave = New System.Windows.Forms.Button
        Me.endtsk = New System.Windows.Forms.Button
        Me.shutdown = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(300, 147)
        Me.ListBox1.TabIndex = 0
        '
        'warn
        '
        Me.warn.AutoSize = True
        Me.warn.Location = New System.Drawing.Point(9, 166)
        Me.warn.Name = "warn"
        Me.warn.Size = New System.Drawing.Size(294, 39)
        Me.warn.TabIndex = 1
        Me.warn.Text = "WARNING: Pressing CTRL+ALT+DEL again will restart your " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "computer. You will lose " & _
            "unsaved information in all programs " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "that are running,"
        '
        'leave
        '
        Me.leave.Location = New System.Drawing.Point(212, 226)
        Me.leave.MaximumSize = New System.Drawing.Size(100, 23)
        Me.leave.MinimumSize = New System.Drawing.Size(100, 23)
        Me.leave.Name = "leave"
        Me.leave.Size = New System.Drawing.Size(100, 23)
        Me.leave.TabIndex = 4
        Me.leave.Text = "&Cancel"
        Me.leave.UseVisualStyleBackColor = True
        '
        'endtsk
        '
        Me.endtsk.Location = New System.Drawing.Point(12, 226)
        Me.endtsk.Name = "endtsk"
        Me.endtsk.Size = New System.Drawing.Size(99, 23)
        Me.endtsk.TabIndex = 5
        Me.endtsk.Text = "&End Task"
        Me.endtsk.UseVisualStyleBackColor = True
        '
        'shutdown
        '
        Me.shutdown.Location = New System.Drawing.Point(117, 226)
        Me.shutdown.Name = "shutdown"
        Me.shutdown.Size = New System.Drawing.Size(89, 23)
        Me.shutdown.TabIndex = 6
        Me.shutdown.Text = "&Shut Down"
        Me.shutdown.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 261)
        Me.Controls.Add(Me.shutdown)
        Me.Controls.Add(Me.endtsk)
        Me.Controls.Add(Me.leave)
        Me.Controls.Add(Me.warn)
        Me.Controls.Add(Me.ListBox1)
        Me.MaximumSize = New System.Drawing.Size(332, 288)
        Me.MinimumSize = New System.Drawing.Size(332, 288)
        Me.Name = "Form1"
        Me.Text = "Close Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents warn As System.Windows.Forms.Label
    Friend WithEvents leave As System.Windows.Forms.Button
    Friend WithEvents endtsk As System.Windows.Forms.Button
    Friend WithEvents shutdown As System.Windows.Forms.Button

End Class
