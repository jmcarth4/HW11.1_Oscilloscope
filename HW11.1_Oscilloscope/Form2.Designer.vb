<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.BaudRateComboBox = New System.Windows.Forms.ComboBox()
        Me.ComPortComboBox = New System.Windows.Forms.ComboBox()
        Me.HideButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BaudRateComboBox
        '
        Me.BaudRateComboBox.FormattingEnabled = True
        Me.BaudRateComboBox.Location = New System.Drawing.Point(149, 44)
        Me.BaudRateComboBox.Name = "BaudRateComboBox"
        Me.BaudRateComboBox.Size = New System.Drawing.Size(121, 28)
        Me.BaudRateComboBox.TabIndex = 221
        '
        'ComPortComboBox
        '
        Me.ComPortComboBox.FormattingEnabled = True
        Me.ComPortComboBox.Location = New System.Drawing.Point(6, 44)
        Me.ComPortComboBox.Name = "ComPortComboBox"
        Me.ComPortComboBox.Size = New System.Drawing.Size(121, 28)
        Me.ComPortComboBox.TabIndex = 220
        '
        'HideButton
        '
        Me.HideButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.HideButton.Location = New System.Drawing.Point(553, 323)
        Me.HideButton.Name = "HideButton"
        Me.HideButton.Size = New System.Drawing.Size(68, 57)
        Me.HideButton.TabIndex = 220
        Me.HideButton.Text = "Leave"
        Me.HideButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SaveButton)
        Me.GroupBox1.Controls.Add(Me.BaudRateComboBox)
        Me.GroupBox1.Controls.Add(Me.ComPortComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(180, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(301, 159)
        Me.GroupBox1.TabIndex = 221
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'SaveButton
        '
        Me.SaveButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SaveButton.Location = New System.Drawing.Point(202, 96)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(68, 57)
        Me.SaveButton.TabIndex = 220
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.HideButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents BaudRateComboBox As ComboBox
    Friend WithEvents ComPortComboBox As ComboBox
    Friend WithEvents HideButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SaveButton As Button
End Class
