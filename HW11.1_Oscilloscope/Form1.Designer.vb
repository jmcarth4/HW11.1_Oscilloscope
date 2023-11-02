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
        Me.DefaultButton = New System.Windows.Forms.Button()
        Me.VDLabel = New System.Windows.Forms.Label()
        Me.TDLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GndTrackBar = New System.Windows.Forms.TrackBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.PortOpenButton = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.VA1Label = New System.Windows.Forms.Label()
        Me.AnIn1CheckBox = New System.Windows.Forms.CheckBox()
        CType(Me.GndTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultButton
        '
        Me.DefaultButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.DefaultButton.Location = New System.Drawing.Point(860, 569)
        Me.DefaultButton.Name = "DefaultButton"
        Me.DefaultButton.Size = New System.Drawing.Size(88, 42)
        Me.DefaultButton.TabIndex = 244
        Me.DefaultButton.Text = "Default"
        Me.DefaultButton.UseVisualStyleBackColor = True
        '
        'VDLabel
        '
        Me.VDLabel.AutoSize = True
        Me.VDLabel.Location = New System.Drawing.Point(1011, 305)
        Me.VDLabel.Name = "VDLabel"
        Me.VDLabel.Size = New System.Drawing.Size(111, 20)
        Me.VDLabel.TabIndex = 239
        Me.VDLabel.Text = "Volts / Division"
        '
        'TDLabel
        '
        Me.TDLabel.AutoSize = True
        Me.TDLabel.Location = New System.Drawing.Point(450, 550)
        Me.TDLabel.Name = "TDLabel"
        Me.TDLabel.Size = New System.Drawing.Size(109, 20)
        Me.TDLabel.TabIndex = 238
        Me.TDLabel.Text = "Time / Division"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(691, 557)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 20)
        Me.Label1.TabIndex = 236
        Me.Label1.Text = "Voltage Reference"
        '
        'GndTrackBar
        '
        Me.GndTrackBar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.GndTrackBar.Location = New System.Drawing.Point(638, 580)
        Me.GndTrackBar.Maximum = 500
        Me.GndTrackBar.Minimum = 177
        Me.GndTrackBar.Name = "GndTrackBar"
        Me.GndTrackBar.Size = New System.Drawing.Size(181, 69)
        Me.GndTrackBar.TabIndex = 235
        Me.GndTrackBar.Value = 177
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Location = New System.Drawing.Point(5, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1000, 500)
        Me.PictureBox1.TabIndex = 234
        Me.PictureBox1.TabStop = False
        '
        'LoadButton
        '
        Me.LoadButton.Location = New System.Drawing.Point(1113, 89)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(103, 56)
        Me.LoadButton.TabIndex = 232
        Me.LoadButton.Text = "Load settings"
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'SettingsButton
        '
        Me.SettingsButton.Location = New System.Drawing.Point(1113, 45)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(103, 38)
        Me.SettingsButton.TabIndex = 231
        Me.SettingsButton.Text = "Settings"
        Me.SettingsButton.UseVisualStyleBackColor = True
        '
        'PortOpenButton
        '
        Me.PortOpenButton.Location = New System.Drawing.Point(1113, 151)
        Me.PortOpenButton.Name = "PortOpenButton"
        Me.PortOpenButton.Size = New System.Drawing.Size(103, 38)
        Me.PortOpenButton.TabIndex = 210
        Me.PortOpenButton.Text = "Connect"
        Me.PortOpenButton.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        '
        'QuitButton
        '
        Me.QuitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.QuitButton.Location = New System.Drawing.Point(1153, 566)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(68, 57)
        Me.QuitButton.TabIndex = 231
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1126, 361)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 209
        Me.Label6.Text = "Voltage In"
        '
        'VA1Label
        '
        Me.VA1Label.AutoSize = True
        Me.VA1Label.Location = New System.Drawing.Point(1149, 381)
        Me.VA1Label.Name = "VA1Label"
        Me.VA1Label.Size = New System.Drawing.Size(44, 20)
        Me.VA1Label.TabIndex = 209
        Me.VA1Label.Text = "VA1 "
        '
        'AnIn1CheckBox
        '
        Me.AnIn1CheckBox.AutoSize = True
        Me.AnIn1CheckBox.Location = New System.Drawing.Point(1113, 207)
        Me.AnIn1CheckBox.Name = "AnIn1CheckBox"
        Me.AnIn1CheckBox.Size = New System.Drawing.Size(80, 24)
        Me.AnIn1CheckBox.TabIndex = 243
        Me.AnIn1CheckBox.Text = " Input "
        Me.AnIn1CheckBox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1247, 635)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PortOpenButton)
        Me.Controls.Add(Me.VA1Label)
        Me.Controls.Add(Me.LoadButton)
        Me.Controls.Add(Me.DefaultButton)
        Me.Controls.Add(Me.SettingsButton)
        Me.Controls.Add(Me.VDLabel)
        Me.Controls.Add(Me.TDLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GndTrackBar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.AnIn1CheckBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GndTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DefaultButton As Button
    Friend WithEvents VDLabel As Label
    Friend WithEvents TDLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GndTrackBar As TrackBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LoadButton As Button
    Friend WithEvents SettingsButton As Button
    Friend WithEvents PortOpenButton As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents QuitButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label6 As Label
    Friend WithEvents VA1Label As Label
    Friend WithEvents AnIn1CheckBox As CheckBox
End Class
