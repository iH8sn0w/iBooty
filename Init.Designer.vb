<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Init
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Init))
        Me.URLGithub = New System.Windows.Forms.Label
        Me.InitCount = New System.Windows.Forms.Label
        Me.thismsgtxt = New System.Windows.Forms.Label
        Me.warning = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'URLGithub
        '
        Me.URLGithub.AutoSize = True
        Me.URLGithub.Cursor = System.Windows.Forms.Cursors.Hand
        Me.URLGithub.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.URLGithub.ForeColor = System.Drawing.Color.Blue
        Me.URLGithub.Location = New System.Drawing.Point(84, 87)
        Me.URLGithub.Name = "URLGithub"
        Me.URLGithub.Size = New System.Drawing.Size(199, 13)
        Me.URLGithub.TabIndex = 7
        Me.URLGithub.Text = "http://github.com/ih8sn0w/ibooty"
        '
        'InitCount
        '
        Me.InitCount.AutoSize = True
        Me.InitCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InitCount.ForeColor = System.Drawing.Color.Black
        Me.InitCount.Location = New System.Drawing.Point(294, 111)
        Me.InitCount.Name = "InitCount"
        Me.InitCount.Size = New System.Drawing.Size(21, 13)
        Me.InitCount.TabIndex = 6
        Me.InitCount.Text = "10"
        '
        'thismsgtxt
        '
        Me.thismsgtxt.AutoSize = True
        Me.thismsgtxt.ForeColor = System.Drawing.Color.Black
        Me.thismsgtxt.Location = New System.Drawing.Point(5, 111)
        Me.thismsgtxt.Name = "thismsgtxt"
        Me.thismsgtxt.Size = New System.Drawing.Size(359, 13)
        Me.thismsgtxt.TabIndex = 5
        Me.thismsgtxt.Text = "This message will only be displayed once. It will disappear in          seconds"
        '
        'warning
        '
        Me.warning.AutoSize = True
        Me.warning.ForeColor = System.Drawing.Color.Black
        Me.warning.Location = New System.Drawing.Point(6, 8)
        Me.warning.Name = "warning"
        Me.warning.Size = New System.Drawing.Size(352, 104)
        Me.warning.TabIndex = 4
        Me.warning.Text = resources.GetString("warning.Text")
        Me.warning.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Init
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 133)
        Me.Controls.Add(Me.URLGithub)
        Me.Controls.Add(Me.InitCount)
        Me.Controls.Add(Me.thismsgtxt)
        Me.Controls.Add(Me.warning)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Init"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Init"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents URLGithub As System.Windows.Forms.Label
    Friend WithEvents InitCount As System.Windows.Forms.Label
    Friend WithEvents thismsgtxt As System.Windows.Forms.Label
    Friend WithEvents warning As System.Windows.Forms.Label
End Class
