<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PathLocations
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
        Me.AshitaPathTextBox = New System.Windows.Forms.TextBox()
        Me.AshitaPathButton = New System.Windows.Forms.Button()
        Me.AshitaPathLabel = New System.Windows.Forms.Label()
        Me.DSPPathLabel = New System.Windows.Forms.Label()
        Me.DSPPathButton = New System.Windows.Forms.Button()
        Me.DSPPathTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AshitaPathTextBox
        '
        Me.AshitaPathTextBox.Location = New System.Drawing.Point(15, 73)
        Me.AshitaPathTextBox.Name = "AshitaPathTextBox"
        Me.AshitaPathTextBox.Size = New System.Drawing.Size(196, 20)
        Me.AshitaPathTextBox.TabIndex = 18
        '
        'AshitaPathButton
        '
        Me.AshitaPathButton.Location = New System.Drawing.Point(217, 73)
        Me.AshitaPathButton.Name = "AshitaPathButton"
        Me.AshitaPathButton.Size = New System.Drawing.Size(75, 23)
        Me.AshitaPathButton.TabIndex = 17
        Me.AshitaPathButton.Text = "Browse"
        Me.AshitaPathButton.UseVisualStyleBackColor = True
        '
        'AshitaPathLabel
        '
        Me.AshitaPathLabel.AutoSize = True
        Me.AshitaPathLabel.Location = New System.Drawing.Point(12, 57)
        Me.AshitaPathLabel.Name = "AshitaPathLabel"
        Me.AshitaPathLabel.Size = New System.Drawing.Size(80, 13)
        Me.AshitaPathLabel.TabIndex = 16
        Me.AshitaPathLabel.Text = "Ashita Location"
        '
        'DSPPathLabel
        '
        Me.DSPPathLabel.AutoSize = True
        Me.DSPPathLabel.Location = New System.Drawing.Point(12, 9)
        Me.DSPPathLabel.Name = "DSPPathLabel"
        Me.DSPPathLabel.Size = New System.Drawing.Size(69, 13)
        Me.DSPPathLabel.TabIndex = 15
        Me.DSPPathLabel.Text = "DSP location"
        '
        'DSPPathButton
        '
        Me.DSPPathButton.Location = New System.Drawing.Point(217, 22)
        Me.DSPPathButton.Name = "DSPPathButton"
        Me.DSPPathButton.Size = New System.Drawing.Size(75, 23)
        Me.DSPPathButton.TabIndex = 14
        Me.DSPPathButton.Text = "Browse"
        Me.DSPPathButton.UseVisualStyleBackColor = True
        '
        'DSPPathTextBox
        '
        Me.DSPPathTextBox.Location = New System.Drawing.Point(15, 25)
        Me.DSPPathTextBox.Name = "DSPPathTextBox"
        Me.DSPPathTextBox.Size = New System.Drawing.Size(196, 20)
        Me.DSPPathTextBox.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 129)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Load Paths"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(217, 129)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Save Paths"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PathLocations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 164)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AshitaPathTextBox)
        Me.Controls.Add(Me.AshitaPathButton)
        Me.Controls.Add(Me.AshitaPathLabel)
        Me.Controls.Add(Me.DSPPathLabel)
        Me.Controls.Add(Me.DSPPathButton)
        Me.Controls.Add(Me.DSPPathTextBox)
        Me.Name = "PathLocations"
        Me.Text = "PathLocations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AshitaPathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AshitaPathButton As System.Windows.Forms.Button
    Friend WithEvents AshitaPathLabel As System.Windows.Forms.Label
    Friend WithEvents DSPPathLabel As System.Windows.Forms.Label
    Friend WithEvents DSPPathButton As System.Windows.Forms.Button
    Friend WithEvents DSPPathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
