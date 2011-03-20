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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Quote = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.console = New System.Windows.Forms.RichTextBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Status = New System.Windows.Forms.Label
        Me.Prepare = New System.Windows.Forms.Label
        Me.dfuinstructions = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.line = New System.Windows.Forms.PictureBox
        CType(Me.line, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Quote
        '
        Me.Quote.AutoSize = True
        Me.Quote.Location = New System.Drawing.Point(516, 136)
        Me.Quote.Name = "Quote"
        Me.Quote.Size = New System.Drawing.Size(12, 13)
        Me.Quote.TabIndex = 1
        Me.Quote.Text = """"
        Me.Quote.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(318, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 18)
        Me.Label1.TabIndex = 3
        '
        'console
        '
        Me.console.Location = New System.Drawing.Point(545, 181)
        Me.console.Name = "console"
        Me.console.Size = New System.Drawing.Size(10, 13)
        Me.console.TabIndex = 5
        Me.console.Text = ""
        Me.console.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 102)
        Me.ProgressBar1.MarqueeAnimationSpeed = 50
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(438, 23)
        Me.ProgressBar1.TabIndex = 6
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Location = New System.Drawing.Point(12, 86)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(104, 13)
        Me.Status.TabIndex = 7
        Me.Status.Text = "Searching for DFU..."
        '
        'Prepare
        '
        Me.Prepare.AutoSize = True
        Me.Prepare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Prepare.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prepare.ForeColor = System.Drawing.Color.Red
        Me.Prepare.Location = New System.Drawing.Point(-1, 6)
        Me.Prepare.Name = "Prepare"
        Me.Prepare.Size = New System.Drawing.Size(280, 20)
        Me.Prepare.TabIndex = 9
        Me.Prepare.Text = "Prepare to press Power + Home (5)"
        Me.Prepare.Visible = False
        '
        'dfuinstructions
        '
        Me.dfuinstructions.AutoSize = True
        Me.dfuinstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dfuinstructions.ForeColor = System.Drawing.Color.Black
        Me.dfuinstructions.Location = New System.Drawing.Point(-4, 28)
        Me.dfuinstructions.Name = "dfuinstructions"
        Me.dfuinstructions.Size = New System.Drawing.Size(195, 18)
        Me.dfuinstructions.TabIndex = 10
        Me.dfuinstructions.Text = "I'm the DFU instructions."
        Me.dfuinstructions.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.Enabled = False
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(12, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 32)
        Me.Button1.TabIndex = 11
        Me.Button1.TabStop = False
        Me.Button1.Text = "Select your device!"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(321, 70)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(129, 29)
        Me.Button3.TabIndex = 12
        Me.Button3.TabStop = False
        Me.Button3.Text = "Reset DFU Instructions"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(115, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 42)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "iBooty V2.2"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(9, 131)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(174, 15)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Requires iTunes 10 or above."
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ComboBox1.Items.AddRange(New Object() {"Select your iDevice:"})
        Me.ComboBox1.Location = New System.Drawing.Point(321, 128)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(128, 21)
        Me.ComboBox1.TabIndex = 16
        Me.ComboBox1.TabStop = False
        '
        'line
        '
        Me.line.Image = Global.iBooty.My.Resources.Resources.line
        Me.line.Location = New System.Drawing.Point(148, 70)
        Me.line.Name = "line"
        Me.line.Size = New System.Drawing.Size(288, 29)
        Me.line.TabIndex = 17
        Me.line.TabStop = False
        Me.line.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(462, 151)
        Me.Controls.Add(Me.line)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.console)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Quote)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Prepare)
        Me.Controls.Add(Me.dfuinstructions)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "iBooty 2.1 -- By: iH8sn0w"
        CType(Me.line, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Quote As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents console As System.Windows.Forms.RichTextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Status As System.Windows.Forms.Label
    Friend WithEvents Prepare As System.Windows.Forms.Label
    Friend WithEvents dfuinstructions As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents line As System.Windows.Forms.PictureBox

End Class
