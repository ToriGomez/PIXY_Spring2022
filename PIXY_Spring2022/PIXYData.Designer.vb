<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PIXYData
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
        Me.PIXYSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.SendTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PICSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageDisplay = New System.Windows.Forms.TabPage()
        Me.Goal2Label = New System.Windows.Forms.Label()
        Me.Goal1Label = New System.Windows.Forms.Label()
        Me.Goal2TextBox = New System.Windows.Forms.TextBox()
        Me.Goal1TextBox = New System.Windows.Forms.TextBox()
        Me.TabPageTrouble = New System.Windows.Forms.TabPage()
        Me.CommPortsLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScoresGroupBox = New System.Windows.Forms.GroupBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPageDisplay.SuspendLayout()
        Me.TabPageTrouble.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ScoresGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'PIXYSerialPort
        '
        Me.PIXYSerialPort.BaudRate = 19200
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(15, 675)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(220, 90)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "&EXIT"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ErrorLabel
        '
        Me.ErrorLabel.AutoSize = True
        Me.ErrorLabel.Location = New System.Drawing.Point(1633, 839)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(0, 32)
        Me.ErrorLabel.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 31
        Me.ListBox1.Location = New System.Drawing.Point(26, 50)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(270, 128)
        Me.ListBox1.TabIndex = 2
        '
        'PICSerialPort
        '
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageDisplay)
        Me.TabControl1.Controls.Add(Me.TabPageTrouble)
        Me.TabControl1.Location = New System.Drawing.Point(15, 65)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1009, 595)
        Me.TabControl1.TabIndex = 3
        '
        'TabPageDisplay
        '
        Me.TabPageDisplay.Controls.Add(Me.ScoresGroupBox)
        Me.TabPageDisplay.Location = New System.Drawing.Point(10, 48)
        Me.TabPageDisplay.Name = "TabPageDisplay"
        Me.TabPageDisplay.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDisplay.Size = New System.Drawing.Size(989, 537)
        Me.TabPageDisplay.TabIndex = 0
        Me.TabPageDisplay.Text = "DISPLAY"
        Me.TabPageDisplay.UseVisualStyleBackColor = True
        '
        'Goal2Label
        '
        Me.Goal2Label.AutoSize = True
        Me.Goal2Label.Location = New System.Drawing.Point(365, 63)
        Me.Goal2Label.Name = "Goal2Label"
        Me.Goal2Label.Size = New System.Drawing.Size(190, 32)
        Me.Goal2Label.TabIndex = 3
        Me.Goal2Label.Text = "Goal2: Robot "
        '
        'Goal1Label
        '
        Me.Goal1Label.AutoSize = True
        Me.Goal1Label.Location = New System.Drawing.Point(22, 63)
        Me.Goal1Label.Name = "Goal1Label"
        Me.Goal1Label.Size = New System.Drawing.Size(188, 32)
        Me.Goal1Label.TabIndex = 2
        Me.Goal1Label.Text = "Goal1: Player"
        '
        'Goal2TextBox
        '
        Me.Goal2TextBox.Location = New System.Drawing.Point(371, 98)
        Me.Goal2TextBox.Name = "Goal2TextBox"
        Me.Goal2TextBox.Size = New System.Drawing.Size(230, 38)
        Me.Goal2TextBox.TabIndex = 1
        '
        'Goal1TextBox
        '
        Me.Goal1TextBox.Location = New System.Drawing.Point(28, 98)
        Me.Goal1TextBox.Name = "Goal1TextBox"
        Me.Goal1TextBox.Size = New System.Drawing.Size(230, 38)
        Me.Goal1TextBox.TabIndex = 0
        '
        'TabPageTrouble
        '
        Me.TabPageTrouble.Controls.Add(Me.CommPortsLabel)
        Me.TabPageTrouble.Controls.Add(Me.ListBox1)
        Me.TabPageTrouble.Location = New System.Drawing.Point(10, 48)
        Me.TabPageTrouble.Name = "TabPageTrouble"
        Me.TabPageTrouble.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageTrouble.Size = New System.Drawing.Size(989, 537)
        Me.TabPageTrouble.TabIndex = 1
        Me.TabPageTrouble.Text = "TROUBLESHOOT"
        Me.TabPageTrouble.UseVisualStyleBackColor = True
        '
        'CommPortsLabel
        '
        Me.CommPortsLabel.AutoSize = True
        Me.CommPortsLabel.Location = New System.Drawing.Point(20, 15)
        Me.CommPortsLabel.Name = "CommPortsLabel"
        Me.CommPortsLabel.Size = New System.Drawing.Size(273, 32)
        Me.CommPortsLabel.TabIndex = 3
        Me.CommPortsLabel.Text = "ALL COMM PORTS:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.HELPToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1120, 49)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(94, 45)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'HELPToolStripMenuItem
        '
        Me.HELPToolStripMenuItem.Name = "HELPToolStripMenuItem"
        Me.HELPToolStripMenuItem.Size = New System.Drawing.Size(109, 45)
        Me.HELPToolStripMenuItem.Text = "HELP"
        '
        'ScoresGroupBox
        '
        Me.ScoresGroupBox.Controls.Add(Me.Goal1Label)
        Me.ScoresGroupBox.Controls.Add(Me.Goal2Label)
        Me.ScoresGroupBox.Controls.Add(Me.Goal1TextBox)
        Me.ScoresGroupBox.Controls.Add(Me.Goal2TextBox)
        Me.ScoresGroupBox.Location = New System.Drawing.Point(21, 50)
        Me.ScoresGroupBox.Name = "ScoresGroupBox"
        Me.ScoresGroupBox.Size = New System.Drawing.Size(628, 181)
        Me.ScoresGroupBox.TabIndex = 4
        Me.ScoresGroupBox.TabStop = False
        Me.ScoresGroupBox.Text = "SCORES"
        '
        'PIXYData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(1120, 818)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PIXYData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AIRHOCKEY"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageDisplay.ResumeLayout(False)
        Me.TabPageTrouble.ResumeLayout(False)
        Me.TabPageTrouble.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ScoresGroupBox.ResumeLayout(False)
        Me.ScoresGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PIXYSerialPort As IO.Ports.SerialPort
    Friend WithEvents SendTimer As Timer
    Friend WithEvents ExitButton As Button
    Friend WithEvents ErrorLabel As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents PICSerialPort As IO.Ports.SerialPort
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageDisplay As TabPage
    Friend WithEvents TabPageTrouble As TabPage
    Friend WithEvents CommPortsLabel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FILEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HELPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Goal2Label As Label
    Friend WithEvents Goal1Label As Label
    Friend WithEvents Goal2TextBox As TextBox
    Friend WithEvents Goal1TextBox As TextBox
    Friend WithEvents ScoresGroupBox As GroupBox
End Class
