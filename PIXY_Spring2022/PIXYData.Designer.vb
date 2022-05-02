<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PIXYData
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
        Me.components = New System.ComponentModel.Container()
        Me.PIXYSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PICSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageDisplay = New System.Windows.Forms.TabPage()
        Me.ScoresGroupBox = New System.Windows.Forms.GroupBox()
        Me.Goal1Label = New System.Windows.Forms.Label()
        Me.Goal2Label = New System.Windows.Forms.Label()
        Me.Goal1TextBox = New System.Windows.Forms.TextBox()
        Me.Goal2TextBox = New System.Windows.Forms.TextBox()
        Me.CallibrateGroupBox = New System.Windows.Forms.GroupBox()
        Me.DefaultsCheckBox = New System.Windows.Forms.CheckBox()
        Me.BRCheckBox = New System.Windows.Forms.CheckBox()
        Me.TRCheckBox = New System.Windows.Forms.CheckBox()
        Me.BLCheckBox = New System.Windows.Forms.CheckBox()
        Me.TLCheckBox = New System.Windows.Forms.CheckBox()
        Me.CCheckBox = New System.Windows.Forms.CheckBox()
        Me.CallibrateButton = New System.Windows.Forms.Button()
        Me.PuckYLabel = New System.Windows.Forms.Label()
        Me.PuckYTextBox = New System.Windows.Forms.TextBox()
        Me.PuckXLabel = New System.Windows.Forms.Label()
        Me.PuckXTextBox = New System.Windows.Forms.TextBox()
        Me.TablePictureBox = New System.Windows.Forms.PictureBox()
        Me.TabPageTrouble = New System.Windows.Forms.TabPage()
        Me.DistGroupBox = New System.Windows.Forms.GroupBox()
        Me.YDistLabel = New System.Windows.Forms.Label()
        Me.YDistTextBox = New System.Windows.Forms.TextBox()
        Me.XDistLabel = New System.Windows.Forms.Label()
        Me.XDistTextBox = New System.Windows.Forms.TextBox()
        Me.SendsGroupBox = New System.Windows.Forms.GroupBox()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.ManualLocButton = New System.Windows.Forms.Button()
        Me.ReadyCheckBox = New System.Windows.Forms.CheckBox()
        Me.CautionLabel = New System.Windows.Forms.Label()
        Me.GoCheckBox = New System.Windows.Forms.CheckBox()
        Me.YLSBLabel = New System.Windows.Forms.Label()
        Me.YLSBTextBox = New System.Windows.Forms.TextBox()
        Me.XLSBLabel = New System.Windows.Forms.Label()
        Me.YMSBLabel = New System.Windows.Forms.Label()
        Me.XLSBTextBox = New System.Windows.Forms.TextBox()
        Me.YMSBTextBox = New System.Windows.Forms.TextBox()
        Me.VBHeadLabel = New System.Windows.Forms.Label()
        Me.XMSBLabel = New System.Windows.Forms.Label()
        Me.VBHeadTextBox = New System.Windows.Forms.TextBox()
        Me.XMSBTextBox = New System.Windows.Forms.TextBox()
        Me.PicDataGroupBox = New System.Windows.Forms.GroupBox()
        Me.StrikerReadyTextBox = New System.Windows.Forms.TextBox()
        Me.Goal1InLabel = New System.Windows.Forms.Label()
        Me.StrikerReadyLabel = New System.Windows.Forms.Label()
        Me.PicHandTextBox = New System.Windows.Forms.TextBox()
        Me.Goal1InTextBox = New System.Windows.Forms.TextBox()
        Me.Goal2InTextBox = New System.Windows.Forms.TextBox()
        Me.Goal2InLabel = New System.Windows.Forms.Label()
        Me.PICHeadLabel = New System.Windows.Forms.Label()
        Me.CommsGroupBox = New System.Windows.Forms.GroupBox()
        Me.MotorVGroupBox = New System.Windows.Forms.GroupBox()
        Me.VelSaveButton = New System.Windows.Forms.Button()
        Me.MotorVLabel = New System.Windows.Forms.Label()
        Me.MotorVTextBox = New System.Windows.Forms.TextBox()
        Me.AreaGroupBox = New System.Windows.Forms.GroupBox()
        Me.DimSaveButton = New System.Windows.Forms.Button()
        Me.HeightLabel = New System.Windows.Forms.Label()
        Me.HeightTextBox = New System.Windows.Forms.TextBox()
        Me.WLabel = New System.Windows.Forms.Label()
        Me.WidthTextBox = New System.Windows.Forms.TextBox()
        Me.RawPIXYGroupBox = New System.Windows.Forms.GroupBox()
        Me.X1TextBox = New System.Windows.Forms.TextBox()
        Me.Y1Label = New System.Windows.Forms.Label()
        Me.Y1TextBox = New System.Windows.Forms.TextBox()
        Me.Y0Label = New System.Windows.Forms.Label()
        Me.Y0TextBox = New System.Windows.Forms.TextBox()
        Me.Sig1Label = New System.Windows.Forms.Label()
        Me.X1Label = New System.Windows.Forms.Label()
        Me.Sig1TextBox = New System.Windows.Forms.TextBox()
        Me.Csum1Label = New System.Windows.Forms.Label()
        Me.Sync1Label = New System.Windows.Forms.Label()
        Me.CSum1TextBox = New System.Windows.Forms.TextBox()
        Me.Sync1TextBox = New System.Windows.Forms.TextBox()
        Me.Sig0Label = New System.Windows.Forms.Label()
        Me.X0Label = New System.Windows.Forms.Label()
        Me.Sig0TextBox = New System.Windows.Forms.TextBox()
        Me.X0TextBox = New System.Windows.Forms.TextBox()
        Me.CSum0Label = New System.Windows.Forms.Label()
        Me.Sync0Label = New System.Windows.Forms.Label()
        Me.CSum0TextBox = New System.Windows.Forms.TextBox()
        Me.Sync0TextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TroubleshootToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CallibrateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveVelocityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualGoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.TabPageDisplay.SuspendLayout()
        Me.ScoresGroupBox.SuspendLayout()
        Me.CallibrateGroupBox.SuspendLayout()
        CType(Me.TablePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageTrouble.SuspendLayout()
        Me.DistGroupBox.SuspendLayout()
        Me.SendsGroupBox.SuspendLayout()
        Me.PicDataGroupBox.SuspendLayout()
        Me.CommsGroupBox.SuspendLayout()
        Me.MotorVGroupBox.SuspendLayout()
        Me.AreaGroupBox.SuspendLayout()
        Me.RawPIXYGroupBox.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'PIXYSerialPort
        '
        Me.PIXYSerialPort.BaudRate = 100000
        '
        'Timer
        '
        Me.Timer.Interval = 1
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(654, 448)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(1)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(82, 38)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "&EXIT"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ErrorLabel
        '
        Me.ErrorLabel.AutoSize = True
        Me.ErrorLabel.Location = New System.Drawing.Point(612, 352)
        Me.ErrorLabel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(0, 13)
        Me.ErrorLabel.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.Enabled = False
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 16)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(72, 43)
        Me.ListBox1.TabIndex = 2
        '
        'PICSerialPort
        '
        Me.PICSerialPort.PortName = "COM3"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageDisplay)
        Me.TabControl1.Controls.Add(Me.TabPageTrouble)
        Me.TabControl1.Location = New System.Drawing.Point(10, 28)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(709, 410)
        Me.TabControl1.TabIndex = 3
        '
        'TabPageDisplay
        '
        Me.TabPageDisplay.Controls.Add(Me.ScoresGroupBox)
        Me.TabPageDisplay.Controls.Add(Me.CallibrateGroupBox)
        Me.TabPageDisplay.Controls.Add(Me.CallibrateButton)
        Me.TabPageDisplay.Controls.Add(Me.PuckYLabel)
        Me.TabPageDisplay.Controls.Add(Me.PuckYTextBox)
        Me.TabPageDisplay.Controls.Add(Me.PuckXLabel)
        Me.TabPageDisplay.Controls.Add(Me.PuckXTextBox)
        Me.TabPageDisplay.Controls.Add(Me.TablePictureBox)
        Me.TabPageDisplay.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDisplay.Margin = New System.Windows.Forms.Padding(1)
        Me.TabPageDisplay.Name = "TabPageDisplay"
        Me.TabPageDisplay.Padding = New System.Windows.Forms.Padding(1)
        Me.TabPageDisplay.Size = New System.Drawing.Size(701, 384)
        Me.TabPageDisplay.TabIndex = 0
        Me.TabPageDisplay.Text = "DISPLAY"
        Me.TabPageDisplay.UseVisualStyleBackColor = True
        '
        'ScoresGroupBox
        '
        Me.ScoresGroupBox.Controls.Add(Me.Goal1Label)
        Me.ScoresGroupBox.Controls.Add(Me.Goal2Label)
        Me.ScoresGroupBox.Controls.Add(Me.Goal1TextBox)
        Me.ScoresGroupBox.Controls.Add(Me.Goal2TextBox)
        Me.ScoresGroupBox.Location = New System.Drawing.Point(11, 271)
        Me.ScoresGroupBox.Margin = New System.Windows.Forms.Padding(1)
        Me.ScoresGroupBox.Name = "ScoresGroupBox"
        Me.ScoresGroupBox.Padding = New System.Windows.Forms.Padding(1)
        Me.ScoresGroupBox.Size = New System.Drawing.Size(108, 104)
        Me.ScoresGroupBox.TabIndex = 4
        Me.ScoresGroupBox.TabStop = False
        Me.ScoresGroupBox.Text = "SCORES"
        '
        'Goal1Label
        '
        Me.Goal1Label.AutoSize = True
        Me.Goal1Label.Location = New System.Drawing.Point(8, 14)
        Me.Goal1Label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Goal1Label.Name = "Goal1Label"
        Me.Goal1Label.Size = New System.Drawing.Size(70, 13)
        Me.Goal1Label.TabIndex = 2
        Me.Goal1Label.Text = "Goal1: Player"
        '
        'Goal2Label
        '
        Me.Goal2Label.AutoSize = True
        Me.Goal2Label.Location = New System.Drawing.Point(9, 55)
        Me.Goal2Label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Goal2Label.Name = "Goal2Label"
        Me.Goal2Label.Size = New System.Drawing.Size(73, 13)
        Me.Goal2Label.TabIndex = 3
        Me.Goal2Label.Text = "Goal2: Robot "
        '
        'Goal1TextBox
        '
        Me.Goal1TextBox.Enabled = False
        Me.Goal1TextBox.Location = New System.Drawing.Point(10, 29)
        Me.Goal1TextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.Goal1TextBox.Name = "Goal1TextBox"
        Me.Goal1TextBox.Size = New System.Drawing.Size(89, 20)
        Me.Goal1TextBox.TabIndex = 0
        '
        'Goal2TextBox
        '
        Me.Goal2TextBox.Enabled = False
        Me.Goal2TextBox.Location = New System.Drawing.Point(12, 69)
        Me.Goal2TextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.Goal2TextBox.Name = "Goal2TextBox"
        Me.Goal2TextBox.Size = New System.Drawing.Size(89, 20)
        Me.Goal2TextBox.TabIndex = 1
        '
        'CallibrateGroupBox
        '
        Me.CallibrateGroupBox.Controls.Add(Me.DefaultsCheckBox)
        Me.CallibrateGroupBox.Controls.Add(Me.BRCheckBox)
        Me.CallibrateGroupBox.Controls.Add(Me.TRCheckBox)
        Me.CallibrateGroupBox.Controls.Add(Me.BLCheckBox)
        Me.CallibrateGroupBox.Controls.Add(Me.TLCheckBox)
        Me.CallibrateGroupBox.Controls.Add(Me.CCheckBox)
        Me.CallibrateGroupBox.Location = New System.Drawing.Point(11, 130)
        Me.CallibrateGroupBox.Margin = New System.Windows.Forms.Padding(1)
        Me.CallibrateGroupBox.Name = "CallibrateGroupBox"
        Me.CallibrateGroupBox.Padding = New System.Windows.Forms.Padding(1)
        Me.CallibrateGroupBox.Size = New System.Drawing.Size(108, 127)
        Me.CallibrateGroupBox.TabIndex = 11
        Me.CallibrateGroupBox.TabStop = False
        Me.CallibrateGroupBox.Text = "Callibration Points:"
        '
        'DefaultsCheckBox
        '
        Me.DefaultsCheckBox.AutoSize = True
        Me.DefaultsCheckBox.Location = New System.Drawing.Point(12, 103)
        Me.DefaultsCheckBox.Margin = New System.Windows.Forms.Padding(1)
        Me.DefaultsCheckBox.Name = "DefaultsCheckBox"
        Me.DefaultsCheckBox.Size = New System.Drawing.Size(60, 17)
        Me.DefaultsCheckBox.TabIndex = 11
        Me.DefaultsCheckBox.Text = "Default"
        Me.DefaultsCheckBox.UseVisualStyleBackColor = True
        '
        'BRCheckBox
        '
        Me.BRCheckBox.AutoSize = True
        Me.BRCheckBox.Location = New System.Drawing.Point(12, 85)
        Me.BRCheckBox.Margin = New System.Windows.Forms.Padding(1)
        Me.BRCheckBox.Name = "BRCheckBox"
        Me.BRCheckBox.Size = New System.Drawing.Size(87, 17)
        Me.BRCheckBox.TabIndex = 10
        Me.BRCheckBox.Text = "Bottom Right"
        Me.BRCheckBox.UseVisualStyleBackColor = True
        '
        'TRCheckBox
        '
        Me.TRCheckBox.AutoSize = True
        Me.TRCheckBox.Location = New System.Drawing.Point(12, 68)
        Me.TRCheckBox.Margin = New System.Windows.Forms.Padding(1)
        Me.TRCheckBox.Name = "TRCheckBox"
        Me.TRCheckBox.Size = New System.Drawing.Size(73, 17)
        Me.TRCheckBox.TabIndex = 9
        Me.TRCheckBox.Text = "Top Right"
        Me.TRCheckBox.UseVisualStyleBackColor = True
        '
        'BLCheckBox
        '
        Me.BLCheckBox.AutoSize = True
        Me.BLCheckBox.Location = New System.Drawing.Point(12, 50)
        Me.BLCheckBox.Margin = New System.Windows.Forms.Padding(1)
        Me.BLCheckBox.Name = "BLCheckBox"
        Me.BLCheckBox.Size = New System.Drawing.Size(80, 17)
        Me.BLCheckBox.TabIndex = 8
        Me.BLCheckBox.Text = "Bottom Left"
        Me.BLCheckBox.UseVisualStyleBackColor = True
        '
        'TLCheckBox
        '
        Me.TLCheckBox.AutoSize = True
        Me.TLCheckBox.Location = New System.Drawing.Point(12, 32)
        Me.TLCheckBox.Margin = New System.Windows.Forms.Padding(1)
        Me.TLCheckBox.Name = "TLCheckBox"
        Me.TLCheckBox.Size = New System.Drawing.Size(66, 17)
        Me.TLCheckBox.TabIndex = 7
        Me.TLCheckBox.Text = "Top Left"
        Me.TLCheckBox.UseVisualStyleBackColor = True
        '
        'CCheckBox
        '
        Me.CCheckBox.AutoSize = True
        Me.CCheckBox.Location = New System.Drawing.Point(12, 15)
        Me.CCheckBox.Margin = New System.Windows.Forms.Padding(1)
        Me.CCheckBox.Name = "CCheckBox"
        Me.CCheckBox.Size = New System.Drawing.Size(57, 17)
        Me.CCheckBox.TabIndex = 6
        Me.CCheckBox.Text = "Center"
        Me.CCheckBox.UseVisualStyleBackColor = True
        '
        'CallibrateButton
        '
        Me.CallibrateButton.Location = New System.Drawing.Point(10, 95)
        Me.CallibrateButton.Margin = New System.Windows.Forms.Padding(1)
        Me.CallibrateButton.Name = "CallibrateButton"
        Me.CallibrateButton.Size = New System.Drawing.Size(86, 27)
        Me.CallibrateButton.TabIndex = 5
        Me.CallibrateButton.Text = "&CALLIBRATE"
        Me.CallibrateButton.UseVisualStyleBackColor = True
        '
        'PuckYLabel
        '
        Me.PuckYLabel.AutoSize = True
        Me.PuckYLabel.Location = New System.Drawing.Point(2, 53)
        Me.PuckYLabel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.PuckYLabel.Name = "PuckYLabel"
        Me.PuckYLabel.Size = New System.Drawing.Size(89, 13)
        Me.PuckYLabel.TabIndex = 4
        Me.PuckYLabel.Text = "Puck Location Y:"
        '
        'PuckYTextBox
        '
        Me.PuckYTextBox.Enabled = False
        Me.PuckYTextBox.Location = New System.Drawing.Point(22, 68)
        Me.PuckYTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.PuckYTextBox.Name = "PuckYTextBox"
        Me.PuckYTextBox.Size = New System.Drawing.Size(68, 20)
        Me.PuckYTextBox.TabIndex = 3
        '
        'PuckXLabel
        '
        Me.PuckXLabel.AutoSize = True
        Me.PuckXLabel.Location = New System.Drawing.Point(2, 13)
        Me.PuckXLabel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.PuckXLabel.Name = "PuckXLabel"
        Me.PuckXLabel.Size = New System.Drawing.Size(89, 13)
        Me.PuckXLabel.TabIndex = 2
        Me.PuckXLabel.Text = "Puck Location X:"
        '
        'PuckXTextBox
        '
        Me.PuckXTextBox.Enabled = False
        Me.PuckXTextBox.Location = New System.Drawing.Point(22, 28)
        Me.PuckXTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.PuckXTextBox.Name = "PuckXTextBox"
        Me.PuckXTextBox.Size = New System.Drawing.Size(68, 20)
        Me.PuckXTextBox.TabIndex = 1
        '
        'TablePictureBox
        '
        Me.TablePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TablePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TablePictureBox.InitialImage = Nothing
        Me.TablePictureBox.Location = New System.Drawing.Point(135, 10)
        Me.TablePictureBox.Margin = New System.Windows.Forms.Padding(1)
        Me.TablePictureBox.Name = "TablePictureBox"
        Me.TablePictureBox.Size = New System.Drawing.Size(557, 366)
        Me.TablePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TablePictureBox.TabIndex = 0
        Me.TablePictureBox.TabStop = False
        '
        'TabPageTrouble
        '
        Me.TabPageTrouble.Controls.Add(Me.DistGroupBox)
        Me.TabPageTrouble.Controls.Add(Me.SendsGroupBox)
        Me.TabPageTrouble.Controls.Add(Me.PicDataGroupBox)
        Me.TabPageTrouble.Controls.Add(Me.CommsGroupBox)
        Me.TabPageTrouble.Controls.Add(Me.MotorVGroupBox)
        Me.TabPageTrouble.Controls.Add(Me.AreaGroupBox)
        Me.TabPageTrouble.Controls.Add(Me.RawPIXYGroupBox)
        Me.TabPageTrouble.Location = New System.Drawing.Point(4, 22)
        Me.TabPageTrouble.Margin = New System.Windows.Forms.Padding(1)
        Me.TabPageTrouble.Name = "TabPageTrouble"
        Me.TabPageTrouble.Padding = New System.Windows.Forms.Padding(1)
        Me.TabPageTrouble.Size = New System.Drawing.Size(701, 384)
        Me.TabPageTrouble.TabIndex = 1
        Me.TabPageTrouble.Text = "TROUBLESHOOT"
        Me.TabPageTrouble.UseVisualStyleBackColor = True
        '
        'DistGroupBox
        '
        Me.DistGroupBox.Controls.Add(Me.YDistLabel)
        Me.DistGroupBox.Controls.Add(Me.YDistTextBox)
        Me.DistGroupBox.Controls.Add(Me.XDistLabel)
        Me.DistGroupBox.Controls.Add(Me.XDistTextBox)
        Me.DistGroupBox.Location = New System.Drawing.Point(442, 275)
        Me.DistGroupBox.Margin = New System.Windows.Forms.Padding(1)
        Me.DistGroupBox.Name = "DistGroupBox"
        Me.DistGroupBox.Padding = New System.Windows.Forms.Padding(1)
        Me.DistGroupBox.Size = New System.Drawing.Size(103, 94)
        Me.DistGroupBox.TabIndex = 39
        Me.DistGroupBox.TabStop = False
        Me.DistGroupBox.Text = "DISTANCE (IN):"
        '
        'YDistLabel
        '
        Me.YDistLabel.AutoSize = True
        Me.YDistLabel.Location = New System.Drawing.Point(8, 52)
        Me.YDistLabel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.YDistLabel.Name = "YDistLabel"
        Me.YDistLabel.Size = New System.Drawing.Size(17, 13)
        Me.YDistLabel.TabIndex = 38
        Me.YDistLabel.Text = "Y:"
        '
        'YDistTextBox
        '
        Me.YDistTextBox.Enabled = False
        Me.YDistTextBox.Location = New System.Drawing.Point(10, 66)
        Me.YDistTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.YDistTextBox.Name = "YDistTextBox"
        Me.YDistTextBox.Size = New System.Drawing.Size(88, 20)
        Me.YDistTextBox.TabIndex = 37
        '
        'XDistLabel
        '
        Me.XDistLabel.AutoSize = True
        Me.XDistLabel.Location = New System.Drawing.Point(8, 16)
        Me.XDistLabel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.XDistLabel.Name = "XDistLabel"
        Me.XDistLabel.Size = New System.Drawing.Size(17, 13)
        Me.XDistLabel.TabIndex = 36
        Me.XDistLabel.Text = "X:"
        '
        'XDistTextBox
        '
        Me.XDistTextBox.Enabled = False
        Me.XDistTextBox.Location = New System.Drawing.Point(10, 31)
        Me.XDistTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.XDistTextBox.Name = "XDistTextBox"
        Me.XDistTextBox.Size = New System.Drawing.Size(88, 20)
        Me.XDistTextBox.TabIndex = 35
        '
        'SendsGroupBox
        '
        Me.SendsGroupBox.Controls.Add(Me.GoButton)
        Me.SendsGroupBox.Controls.Add(Me.ManualLocButton)
        Me.SendsGroupBox.Controls.Add(Me.ReadyCheckBox)
        Me.SendsGroupBox.Controls.Add(Me.CautionLabel)
        Me.SendsGroupBox.Controls.Add(Me.GoCheckBox)
        Me.SendsGroupBox.Controls.Add(Me.YLSBLabel)
        Me.SendsGroupBox.Controls.Add(Me.YLSBTextBox)
        Me.SendsGroupBox.Controls.Add(Me.XLSBLabel)
        Me.SendsGroupBox.Controls.Add(Me.YMSBLabel)
        Me.SendsGroupBox.Controls.Add(Me.XLSBTextBox)
        Me.SendsGroupBox.Controls.Add(Me.YMSBTextBox)
        Me.SendsGroupBox.Controls.Add(Me.VBHeadLabel)
        Me.SendsGroupBox.Controls.Add(Me.XMSBLabel)
        Me.SendsGroupBox.Controls.Add(Me.VBHeadTextBox)
        Me.SendsGroupBox.Controls.Add(Me.XMSBTextBox)
        Me.SendsGroupBox.Location = New System.Drawing.Point(442, 9)
        Me.SendsGroupBox.Margin = New System.Windows.Forms.Padding(1)
        Me.SendsGroupBox.Name = "SendsGroupBox"
        Me.SendsGroupBox.Padding = New System.Windows.Forms.Padding(1)
        Me.SendsGroupBox.Size = New System.Drawing.Size(248, 247)
        Me.SendsGroupBox.TabIndex = 37
        Me.SendsGroupBox.TabStop = False
        Me.SendsGroupBox.Text = "VB PIC SENDS:"
        '
        'GoButton
        '
        Me.GoButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.GoButton.Location = New System.Drawing.Point(135, 200)
        Me.GoButton.Margin = New System.Windows.Forms.Padding(1)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(93, 38)
        Me.GoButton.TabIndex = 5
        Me.GoButton.Text = "MANUAL &GO"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'ManualLocButton
        '
        Me.ManualLocButton.Location = New System.Drawing.Point(135, 145)
        Me.ManualLocButton.Margin = New System.Windows.Forms.Padding(1)
        Me.ManualLocButton.Name = "ManualLocButton"
        Me.ManualLocButton.Size = New System.Drawing.Size(93, 38)
        Me.ManualLocButton.TabIndex = 40
        Me.ManualLocButton.Text = "MANUAL &LOCATION"
        Me.ManualLocButton.UseVisualStyleBackColor = True
        '
        'ReadyCheckBox
        '
        Me.ReadyCheckBox.AutoSize = True
        Me.ReadyCheckBox.Location = New System.Drawing.Point(126, 47)
        Me.ReadyCheckBox.Margin = New System.Windows.Forms.Padding(1)
        Me.ReadyCheckBox.Name = "ReadyCheckBox"
        Me.ReadyCheckBox.Size = New System.Drawing.Size(111, 17)
        Me.ReadyCheckBox.TabIndex = 42
        Me.ReadyCheckBox.Text = "MANUAL READY"
        Me.ReadyCheckBox.UseVisualStyleBackColor = True
        '
        'CautionLabel
        '
        Me.CautionLabel.AutoSize = True
        Me.CautionLabel.ForeColor = System.Drawing.Color.Red
        Me.CautionLabel.Location = New System.Drawing.Point(123, 102)
        Me.CautionLabel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.CautionLabel.Name = "CautionLabel"
        Me.CautionLabel.Size = New System.Drawing.Size(39, 13)
        Me.CautionLabel.TabIndex = 41
        Me.CautionLabel.Text = "Label1"
        '
        'GoCheckBox
        '
        Me.GoCheckBox.AutoSize = True
        Me.GoCheckBox.Location = New System.Drawing.Point(126, 75)
        Me.GoCheckBox.Margin = New System.Windows.Forms.Padding(1)
        Me.GoCheckBox.Name = "GoCheckBox"
        Me.GoCheckBox.Size = New System.Drawing.Size(90, 17)
        Me.GoCheckBox.TabIndex = 40
        Me.GoCheckBox.Text = "MANUAL GO"
        Me.GoCheckBox.UseVisualStyleBackColor = True
        '
        'YLSBLabel
        '
        Me.YLSBLabel.AutoSize = True
        Me.YLSBLabel.Location = New System.Drawing.Point(7, 158)
        Me.YLSBLabel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.YLSBLabel.Name = "YLSBLabel"
        Me.YLSBLabel.Size = New System.Drawing.Size(74, 13)
        Me.YLSBLabel.TabIndex = 34
        Me.YLSBLabel.Text = "Y LSB (steps):"
        '
        'YLSBTextBox
        '
        Me.YLSBTextBox.Enabled = False
        Me.YLSBTextBox.Location = New System.Drawing.Point(9, 172)
        Me.YLSBTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.YLSBTextBox.Name = "YLSBTextBox"
        Me.YLSBTextBox.Size = New System.Drawing.Size(88, 20)
        Me.YLSBTextBox.TabIndex = 33
        '
        'XLSBLabel
        '
        Me.XLSBLabel.AutoSize = True
        Me.XLSBLabel.Location = New System.Drawing.Point(7, 86)
        Me.XLSBLabel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.XLSBLabel.Name = "XLSBLabel"
        Me.XLSBLabel.Size = New System.Drawing.Size(74, 13)
        Me.XLSBLabel.TabIndex = 32
        Me.XLSBLabel.Text = "X LSB (steps):"
        '
        'YMSBLabel
        '
        Me.YMSBLabel.AutoSize = True
        Me.YMSBLabel.Location = New System.Drawing.Point(7, 122)
        Me.YMSBLabel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.YMSBLabel.Name = "YMSBLabel"
        Me.YMSBLabel.Size = New System.Drawing.Size(77, 13)
        Me.YMSBLabel.TabIndex = 31
        Me.YMSBLabel.Text = "Y MSB (steps):"
        '
        'XLSBTextBox
        '
        Me.XLSBTextBox.Enabled = False
        Me.XLSBTextBox.Location = New System.Drawing.Point(9, 101)
        Me.XLSBTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.XLSBTextBox.Name = "XLSBTextBox"
        Me.XLSBTextBox.Size = New System.Drawing.Size(88, 20)
        Me.XLSBTextBox.TabIndex = 30
        '
        'YMSBTextBox
        '
        Me.YMSBTextBox.Enabled = False
        Me.YMSBTextBox.Location = New System.Drawing.Point(9, 137)
        Me.YMSBTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.YMSBTextBox.Name = "YMSBTextBox"
        Me.YMSBTextBox.Size = New System.Drawing.Size(88, 20)
        Me.YMSBTextBox.TabIndex = 29
        '
        'VBHeadLabel
        '
        Me.VBHeadLabel.AutoSize = True
        Me.VBHeadLabel.Location = New System.Drawing.Point(7, 16)
        Me.VBHeadLabel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.VBHeadLabel.Name = "VBHeadLabel"
        Me.VBHeadLabel.Size = New System.Drawing.Size(62, 13)
        Me.VBHeadLabel.TabIndex = 27
        Me.VBHeadLabel.Text = "VB Header:"
        '
        'XMSBLabel
        '
        Me.XMSBLabel.AutoSize = True
        Me.XMSBLabel.Location = New System.Drawing.Point(7, 50)
        Me.XMSBLabel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.XMSBLabel.Name = "XMSBLabel"
        Me.XMSBLabel.Size = New System.Drawing.Size(77, 13)
        Me.XMSBLabel.TabIndex = 28
        Me.XMSBLabel.Text = "X MSB (steps):"
        '
        'VBHeadTextBox
        '
        Me.VBHeadTextBox.Enabled = False
        Me.VBHeadTextBox.Location = New System.Drawing.Point(9, 30)
        Me.VBHeadTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.VBHeadTextBox.Name = "VBHeadTextBox"
        Me.VBHeadTextBox.Size = New System.Drawing.Size(88, 20)
        Me.VBHeadTextBox.TabIndex = 25
        '
        'XMSBTextBox
        '
        Me.XMSBTextBox.Enabled = False
        Me.XMSBTextBox.Location = New System.Drawing.Point(9, 65)
        Me.XMSBTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.XMSBTextBox.Name = "XMSBTextBox"
        Me.XMSBTextBox.Size = New System.Drawing.Size(88, 20)
        Me.XMSBTextBox.TabIndex = 26
        '
        'PicDataGroupBox
        '
        Me.PicDataGroupBox.Controls.Add(Me.StrikerReadyTextBox)
        Me.PicDataGroupBox.Controls.Add(Me.Goal1InLabel)
        Me.PicDataGroupBox.Controls.Add(Me.StrikerReadyLabel)
        Me.PicDataGroupBox.Controls.Add(Me.PicHandTextBox)
        Me.PicDataGroupBox.Controls.Add(Me.Goal1InTextBox)
        Me.PicDataGroupBox.Controls.Add(Me.Goal2InTextBox)
        Me.PicDataGroupBox.Controls.Add(Me.Goal2InLabel)
        Me.PicDataGroupBox.Controls.Add(Me.PICHeadLabel)
        Me.PicDataGroupBox.Location = New System.Drawing.Point(205, 210)
        Me.PicDataGroupBox.Margin = New System.Windows.Forms.Padding(1)
        Me.PicDataGroupBox.Name = "PicDataGroupBox"
        Me.PicDataGroupBox.Padding = New System.Windows.Forms.Padding(1)
        Me.PicDataGroupBox.Size = New System.Drawing.Size(195, 94)
        Me.PicDataGroupBox.TabIndex = 36
        Me.PicDataGroupBox.TabStop = False
        Me.PicDataGroupBox.Text = "RAW PIC DATA:"
        '
        'StrikerReadyTextBox
        '
        Me.StrikerReadyTextBox.Enabled = False
        Me.StrikerReadyTextBox.Location = New System.Drawing.Point(104, 66)
        Me.StrikerReadyTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.StrikerReadyTextBox.Name = "StrikerReadyTextBox"
        Me.StrikerReadyTextBox.Size = New System.Drawing.Size(88, 20)
        Me.StrikerReadyTextBox.TabIndex = 34
        '
        'Goal1InLabel
        '
        Me.Goal1InLabel.AutoSize = True
        Me.Goal1InLabel.Location = New System.Drawing.Point(102, 16)
        Me.Goal1InLabel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Goal1InLabel.Name = "Goal1InLabel"
        Me.Goal1InLabel.Size = New System.Drawing.Size(72, 13)
        Me.Goal1InLabel.TabIndex = 31
        Me.Goal1InLabel.Text = "Goal 1 Score:"
        '
        'StrikerReadyLabel
        '
        Me.StrikerReadyLabel.AutoSize = True
        Me.StrikerReadyLabel.Location = New System.Drawing.Point(102, 52)
        Me.StrikerReadyLabel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.StrikerReadyLabel.Name = "StrikerReadyLabel"
        Me.StrikerReadyLabel.Size = New System.Drawing.Size(74, 13)
        Me.StrikerReadyLabel.TabIndex = 30
        Me.StrikerReadyLabel.Text = "Striker Ready:"
        '
        'PicHandTextBox
        '
        Me.PicHandTextBox.Enabled = False
        Me.PicHandTextBox.Location = New System.Drawing.Point(9, 31)
        Me.PicHandTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.PicHandTextBox.Name = "PicHandTextBox"
        Me.PicHandTextBox.Size = New System.Drawing.Size(88, 20)
        Me.PicHandTextBox.TabIndex = 25
        '
        'Goal1InTextBox
        '
        Me.Goal1InTextBox.Enabled = False
        Me.Goal1InTextBox.Location = New System.Drawing.Point(104, 31)
        Me.Goal1InTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.Goal1InTextBox.Name = "Goal1InTextBox"
        Me.Goal1InTextBox.Size = New System.Drawing.Size(88, 20)
        Me.Goal1InTextBox.TabIndex = 29
        '
        'Goal2InTextBox
        '
        Me.Goal2InTextBox.Enabled = False
        Me.Goal2InTextBox.Location = New System.Drawing.Point(9, 65)
        Me.Goal2InTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.Goal2InTextBox.Name = "Goal2InTextBox"
        Me.Goal2InTextBox.Size = New System.Drawing.Size(88, 20)
        Me.Goal2InTextBox.TabIndex = 26
        '
        'Goal2InLabel
        '
        Me.Goal2InLabel.AutoSize = True
        Me.Goal2InLabel.Location = New System.Drawing.Point(8, 50)
        Me.Goal2InLabel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Goal2InLabel.Name = "Goal2InLabel"
        Me.Goal2InLabel.Size = New System.Drawing.Size(72, 13)
        Me.Goal2InLabel.TabIndex = 28
        Me.Goal2InLabel.Text = "Goal 2 Score:"
        '
        'PICHeadLabel
        '
        Me.PICHeadLabel.AutoSize = True
        Me.PICHeadLabel.Location = New System.Drawing.Point(7, 16)
        Me.PICHeadLabel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.PICHeadLabel.Name = "PICHeadLabel"
        Me.PICHeadLabel.Size = New System.Drawing.Size(85, 13)
        Me.PICHeadLabel.TabIndex = 27
        Me.PICHeadLabel.Text = "PIC Handshake:"
        '
        'CommsGroupBox
        '
        Me.CommsGroupBox.Controls.Add(Me.ListBox1)
        Me.CommsGroupBox.Location = New System.Drawing.Point(6, 9)
        Me.CommsGroupBox.Margin = New System.Windows.Forms.Padding(1)
        Me.CommsGroupBox.Name = "CommsGroupBox"
        Me.CommsGroupBox.Padding = New System.Windows.Forms.Padding(1)
        Me.CommsGroupBox.Size = New System.Drawing.Size(102, 65)
        Me.CommsGroupBox.TabIndex = 35
        Me.CommsGroupBox.TabStop = False
        Me.CommsGroupBox.Text = "COMMS:"
        '
        'MotorVGroupBox
        '
        Me.MotorVGroupBox.Controls.Add(Me.VelSaveButton)
        Me.MotorVGroupBox.Controls.Add(Me.MotorVLabel)
        Me.MotorVGroupBox.Controls.Add(Me.MotorVTextBox)
        Me.MotorVGroupBox.Location = New System.Drawing.Point(6, 210)
        Me.MotorVGroupBox.Margin = New System.Windows.Forms.Padding(1)
        Me.MotorVGroupBox.Name = "MotorVGroupBox"
        Me.MotorVGroupBox.Padding = New System.Windows.Forms.Padding(1)
        Me.MotorVGroupBox.Size = New System.Drawing.Size(172, 82)
        Me.MotorVGroupBox.TabIndex = 34
        Me.MotorVGroupBox.TabStop = False
        Me.MotorVGroupBox.Text = "MOTOR VELOCITY (IN/STEP):"
        '
        'VelSaveButton
        '
        Me.VelSaveButton.Location = New System.Drawing.Point(23, 38)
        Me.VelSaveButton.Margin = New System.Windows.Forms.Padding(1)
        Me.VelSaveButton.Name = "VelSaveButton"
        Me.VelSaveButton.Size = New System.Drawing.Size(74, 37)
        Me.VelSaveButton.TabIndex = 33
        Me.VelSaveButton.Text = "SAVE &VELOCITY"
        Me.VelSaveButton.UseVisualStyleBackColor = True
        '
        'MotorVLabel
        '
        Me.MotorVLabel.AutoSize = True
        Me.MotorVLabel.Location = New System.Drawing.Point(10, 14)
        Me.MotorVLabel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.MotorVLabel.Name = "MotorVLabel"
        Me.MotorVLabel.Size = New System.Drawing.Size(47, 13)
        Me.MotorVLabel.TabIndex = 32
        Me.MotorVLabel.Text = "Velocity:"
        '
        'MotorVTextBox
        '
        Me.MotorVTextBox.Location = New System.Drawing.Point(59, 14)
        Me.MotorVTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.MotorVTextBox.Name = "MotorVTextBox"
        Me.MotorVTextBox.Size = New System.Drawing.Size(65, 20)
        Me.MotorVTextBox.TabIndex = 31
        '
        'AreaGroupBox
        '
        Me.AreaGroupBox.Controls.Add(Me.DimSaveButton)
        Me.AreaGroupBox.Controls.Add(Me.HeightLabel)
        Me.AreaGroupBox.Controls.Add(Me.HeightTextBox)
        Me.AreaGroupBox.Controls.Add(Me.WLabel)
        Me.AreaGroupBox.Controls.Add(Me.WidthTextBox)
        Me.AreaGroupBox.Location = New System.Drawing.Point(6, 84)
        Me.AreaGroupBox.Margin = New System.Windows.Forms.Padding(1)
        Me.AreaGroupBox.Name = "AreaGroupBox"
        Me.AreaGroupBox.Padding = New System.Windows.Forms.Padding(1)
        Me.AreaGroupBox.Size = New System.Drawing.Size(146, 113)
        Me.AreaGroupBox.TabIndex = 31
        Me.AreaGroupBox.TabStop = False
        Me.AreaGroupBox.Text = "PIXY DATA AREA (IN):"
        '
        'DimSaveButton
        '
        Me.DimSaveButton.Location = New System.Drawing.Point(27, 65)
        Me.DimSaveButton.Margin = New System.Windows.Forms.Padding(1)
        Me.DimSaveButton.Name = "DimSaveButton"
        Me.DimSaveButton.Size = New System.Drawing.Size(66, 38)
        Me.DimSaveButton.TabIndex = 30
        Me.DimSaveButton.Text = "SAVE &AREA"
        Me.DimSaveButton.UseVisualStyleBackColor = True
        '
        'HeightLabel
        '
        Me.HeightLabel.AutoSize = True
        Me.HeightLabel.Location = New System.Drawing.Point(6, 44)
        Me.HeightLabel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.HeightLabel.Name = "HeightLabel"
        Me.HeightLabel.Size = New System.Drawing.Size(41, 13)
        Me.HeightLabel.TabIndex = 29
        Me.HeightLabel.Text = "Height:"
        '
        'HeightTextBox
        '
        Me.HeightTextBox.Location = New System.Drawing.Point(49, 41)
        Me.HeightTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.HeightTextBox.Name = "HeightTextBox"
        Me.HeightTextBox.Size = New System.Drawing.Size(65, 20)
        Me.HeightTextBox.TabIndex = 28
        '
        'WLabel
        '
        Me.WLabel.AutoSize = True
        Me.WLabel.Location = New System.Drawing.Point(6, 21)
        Me.WLabel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.WLabel.Name = "WLabel"
        Me.WLabel.Size = New System.Drawing.Size(38, 13)
        Me.WLabel.TabIndex = 27
        Me.WLabel.Text = "Width:"
        '
        'WidthTextBox
        '
        Me.WidthTextBox.Location = New System.Drawing.Point(49, 19)
        Me.WidthTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.WidthTextBox.Name = "WidthTextBox"
        Me.WidthTextBox.Size = New System.Drawing.Size(65, 20)
        Me.WidthTextBox.TabIndex = 26
        '
        'RawPIXYGroupBox
        '
        Me.RawPIXYGroupBox.Controls.Add(Me.X1TextBox)
        Me.RawPIXYGroupBox.Controls.Add(Me.Y1Label)
        Me.RawPIXYGroupBox.Controls.Add(Me.Y1TextBox)
        Me.RawPIXYGroupBox.Controls.Add(Me.Y0Label)
        Me.RawPIXYGroupBox.Controls.Add(Me.Y0TextBox)
        Me.RawPIXYGroupBox.Controls.Add(Me.Sig1Label)
        Me.RawPIXYGroupBox.Controls.Add(Me.X1Label)
        Me.RawPIXYGroupBox.Controls.Add(Me.Sig1TextBox)
        Me.RawPIXYGroupBox.Controls.Add(Me.Csum1Label)
        Me.RawPIXYGroupBox.Controls.Add(Me.Sync1Label)
        Me.RawPIXYGroupBox.Controls.Add(Me.CSum1TextBox)
        Me.RawPIXYGroupBox.Controls.Add(Me.Sync1TextBox)
        Me.RawPIXYGroupBox.Controls.Add(Me.Sig0Label)
        Me.RawPIXYGroupBox.Controls.Add(Me.X0Label)
        Me.RawPIXYGroupBox.Controls.Add(Me.Sig0TextBox)
        Me.RawPIXYGroupBox.Controls.Add(Me.X0TextBox)
        Me.RawPIXYGroupBox.Controls.Add(Me.CSum0Label)
        Me.RawPIXYGroupBox.Controls.Add(Me.Sync0Label)
        Me.RawPIXYGroupBox.Controls.Add(Me.CSum0TextBox)
        Me.RawPIXYGroupBox.Controls.Add(Me.Sync0TextBox)
        Me.RawPIXYGroupBox.Location = New System.Drawing.Point(205, 9)
        Me.RawPIXYGroupBox.Margin = New System.Windows.Forms.Padding(1)
        Me.RawPIXYGroupBox.Name = "RawPIXYGroupBox"
        Me.RawPIXYGroupBox.Padding = New System.Windows.Forms.Padding(1)
        Me.RawPIXYGroupBox.Size = New System.Drawing.Size(213, 195)
        Me.RawPIXYGroupBox.TabIndex = 25
        Me.RawPIXYGroupBox.TabStop = False
        Me.RawPIXYGroupBox.Text = "RAW PIXY DATA:"
        '
        'X1TextBox
        '
        Me.X1TextBox.Enabled = False
        Me.X1TextBox.Location = New System.Drawing.Point(14, 133)
        Me.X1TextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.X1TextBox.Name = "X1TextBox"
        Me.X1TextBox.Size = New System.Drawing.Size(88, 20)
        Me.X1TextBox.TabIndex = 24
        '
        'Y1Label
        '
        Me.Y1Label.AutoSize = True
        Me.Y1Label.Location = New System.Drawing.Point(11, 154)
        Me.Y1Label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Y1Label.Name = "Y1Label"
        Me.Y1Label.Size = New System.Drawing.Size(60, 13)
        Me.Y1Label.TabIndex = 23
        Me.Y1Label.Text = "Y Center 1:"
        '
        'Y1TextBox
        '
        Me.Y1TextBox.Enabled = False
        Me.Y1TextBox.Location = New System.Drawing.Point(14, 169)
        Me.Y1TextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.Y1TextBox.Name = "Y1TextBox"
        Me.Y1TextBox.Size = New System.Drawing.Size(88, 20)
        Me.Y1TextBox.TabIndex = 22
        '
        'Y0Label
        '
        Me.Y0Label.AutoSize = True
        Me.Y0Label.Location = New System.Drawing.Point(114, 154)
        Me.Y0Label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Y0Label.Name = "Y0Label"
        Me.Y0Label.Size = New System.Drawing.Size(60, 13)
        Me.Y0Label.TabIndex = 21
        Me.Y0Label.Text = "Y Center 0:"
        '
        'Y0TextBox
        '
        Me.Y0TextBox.Enabled = False
        Me.Y0TextBox.Location = New System.Drawing.Point(117, 169)
        Me.Y0TextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.Y0TextBox.Name = "Y0TextBox"
        Me.Y0TextBox.Size = New System.Drawing.Size(88, 20)
        Me.Y0TextBox.TabIndex = 20
        '
        'Sig1Label
        '
        Me.Sig1Label.AutoSize = True
        Me.Sig1Label.Location = New System.Drawing.Point(11, 83)
        Me.Sig1Label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Sig1Label.Name = "Sig1Label"
        Me.Sig1Label.Size = New System.Drawing.Size(89, 13)
        Me.Sig1Label.TabIndex = 19
        Me.Sig1Label.Text = "Signature Num 1:"
        '
        'X1Label
        '
        Me.X1Label.AutoSize = True
        Me.X1Label.Location = New System.Drawing.Point(11, 118)
        Me.X1Label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.X1Label.Name = "X1Label"
        Me.X1Label.Size = New System.Drawing.Size(60, 13)
        Me.X1Label.TabIndex = 18
        Me.X1Label.Text = "X Center 1:"
        '
        'Sig1TextBox
        '
        Me.Sig1TextBox.Enabled = False
        Me.Sig1TextBox.Location = New System.Drawing.Point(14, 97)
        Me.Sig1TextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.Sig1TextBox.Name = "Sig1TextBox"
        Me.Sig1TextBox.Size = New System.Drawing.Size(88, 20)
        Me.Sig1TextBox.TabIndex = 17
        '
        'Csum1Label
        '
        Me.Csum1Label.AutoSize = True
        Me.Csum1Label.Location = New System.Drawing.Point(11, 49)
        Me.Csum1Label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Csum1Label.Name = "Csum1Label"
        Me.Csum1Label.Size = New System.Drawing.Size(69, 13)
        Me.Csum1Label.TabIndex = 15
        Me.Csum1Label.Text = "Checksum 1:"
        '
        'Sync1Label
        '
        Me.Sync1Label.AutoSize = True
        Me.Sync1Label.Location = New System.Drawing.Point(11, 14)
        Me.Sync1Label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Sync1Label.Name = "Sync1Label"
        Me.Sync1Label.Size = New System.Drawing.Size(43, 13)
        Me.Sync1Label.TabIndex = 14
        Me.Sync1Label.Text = "Sync 1:"
        '
        'CSum1TextBox
        '
        Me.CSum1TextBox.Enabled = False
        Me.CSum1TextBox.Location = New System.Drawing.Point(14, 63)
        Me.CSum1TextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.CSum1TextBox.Name = "CSum1TextBox"
        Me.CSum1TextBox.Size = New System.Drawing.Size(88, 20)
        Me.CSum1TextBox.TabIndex = 13
        '
        'Sync1TextBox
        '
        Me.Sync1TextBox.Enabled = False
        Me.Sync1TextBox.Location = New System.Drawing.Point(14, 29)
        Me.Sync1TextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.Sync1TextBox.Name = "Sync1TextBox"
        Me.Sync1TextBox.Size = New System.Drawing.Size(88, 20)
        Me.Sync1TextBox.TabIndex = 12
        '
        'Sig0Label
        '
        Me.Sig0Label.AutoSize = True
        Me.Sig0Label.Location = New System.Drawing.Point(114, 83)
        Me.Sig0Label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Sig0Label.Name = "Sig0Label"
        Me.Sig0Label.Size = New System.Drawing.Size(89, 13)
        Me.Sig0Label.TabIndex = 11
        Me.Sig0Label.Text = "Signature Num 0:"
        '
        'X0Label
        '
        Me.X0Label.AutoSize = True
        Me.X0Label.Location = New System.Drawing.Point(114, 118)
        Me.X0Label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.X0Label.Name = "X0Label"
        Me.X0Label.Size = New System.Drawing.Size(60, 13)
        Me.X0Label.TabIndex = 10
        Me.X0Label.Text = "X Center 0:"
        '
        'Sig0TextBox
        '
        Me.Sig0TextBox.Enabled = False
        Me.Sig0TextBox.Location = New System.Drawing.Point(117, 97)
        Me.Sig0TextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.Sig0TextBox.Name = "Sig0TextBox"
        Me.Sig0TextBox.Size = New System.Drawing.Size(88, 20)
        Me.Sig0TextBox.TabIndex = 9
        '
        'X0TextBox
        '
        Me.X0TextBox.Enabled = False
        Me.X0TextBox.Location = New System.Drawing.Point(117, 133)
        Me.X0TextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.X0TextBox.Name = "X0TextBox"
        Me.X0TextBox.Size = New System.Drawing.Size(88, 20)
        Me.X0TextBox.TabIndex = 8
        '
        'CSum0Label
        '
        Me.CSum0Label.AutoSize = True
        Me.CSum0Label.Location = New System.Drawing.Point(114, 49)
        Me.CSum0Label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.CSum0Label.Name = "CSum0Label"
        Me.CSum0Label.Size = New System.Drawing.Size(69, 13)
        Me.CSum0Label.TabIndex = 7
        Me.CSum0Label.Text = "Checksum 0:"
        '
        'Sync0Label
        '
        Me.Sync0Label.AutoSize = True
        Me.Sync0Label.Location = New System.Drawing.Point(114, 14)
        Me.Sync0Label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Sync0Label.Name = "Sync0Label"
        Me.Sync0Label.Size = New System.Drawing.Size(43, 13)
        Me.Sync0Label.TabIndex = 6
        Me.Sync0Label.Text = "Sync 0:"
        '
        'CSum0TextBox
        '
        Me.CSum0TextBox.Enabled = False
        Me.CSum0TextBox.Location = New System.Drawing.Point(117, 63)
        Me.CSum0TextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.CSum0TextBox.Name = "CSum0TextBox"
        Me.CSum0TextBox.Size = New System.Drawing.Size(88, 20)
        Me.CSum0TextBox.TabIndex = 5
        '
        'Sync0TextBox
        '
        Me.Sync0TextBox.Enabled = False
        Me.Sync0TextBox.Location = New System.Drawing.Point(117, 29)
        Me.Sync0TextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.Sync0TextBox.Name = "Sync0TextBox"
        Me.Sync0TextBox.Size = New System.Drawing.Size(88, 20)
        Me.Sync0TextBox.TabIndex = 4
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.HELPToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(2, 1, 0, 1)
        Me.MenuStrip.Size = New System.Drawing.Size(779, 24)
        Me.MenuStrip.TabIndex = 4
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TroubleshootToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 22)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'TroubleshootToolStripMenuItem
        '
        Me.TroubleshootToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CallibrateToolStripMenuItem, Me.SaveAreaToolStripMenuItem, Me.SaveVelocityToolStripMenuItem, Me.ManualLocationToolStripMenuItem, Me.ManualGoToolStripMenuItem})
        Me.TroubleshootToolStripMenuItem.Name = "TroubleshootToolStripMenuItem"
        Me.TroubleshootToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.TroubleshootToolStripMenuItem.Text = "&TroubleShoot"
        '
        'CallibrateToolStripMenuItem
        '
        Me.CallibrateToolStripMenuItem.Name = "CallibrateToolStripMenuItem"
        Me.CallibrateToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CallibrateToolStripMenuItem.Text = "&Callibrate"
        '
        'SaveAreaToolStripMenuItem
        '
        Me.SaveAreaToolStripMenuItem.Name = "SaveAreaToolStripMenuItem"
        Me.SaveAreaToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.SaveAreaToolStripMenuItem.Text = "Save &Area"
        '
        'SaveVelocityToolStripMenuItem
        '
        Me.SaveVelocityToolStripMenuItem.Name = "SaveVelocityToolStripMenuItem"
        Me.SaveVelocityToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.SaveVelocityToolStripMenuItem.Text = "Save &Velocity"
        '
        'ManualLocationToolStripMenuItem
        '
        Me.ManualLocationToolStripMenuItem.Name = "ManualLocationToolStripMenuItem"
        Me.ManualLocationToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ManualLocationToolStripMenuItem.Text = "Manual &Location"
        '
        'ManualGoToolStripMenuItem
        '
        Me.ManualGoToolStripMenuItem.Name = "ManualGoToolStripMenuItem"
        Me.ManualGoToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ManualGoToolStripMenuItem.Text = "Manual &Go"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'HELPToolStripMenuItem
        '
        Me.HELPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HELPToolStripMenuItem.Name = "HELPToolStripMenuItem"
        Me.HELPToolStripMenuItem.Size = New System.Drawing.Size(47, 22)
        Me.HELPToolStripMenuItem.Text = "HELP"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'PIXYData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(779, 511)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.MenuStrip)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "PIXYData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AUTOMATED AIRHOCKEY"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageDisplay.ResumeLayout(False)
        Me.TabPageDisplay.PerformLayout()
        Me.ScoresGroupBox.ResumeLayout(False)
        Me.ScoresGroupBox.PerformLayout()
        Me.CallibrateGroupBox.ResumeLayout(False)
        Me.CallibrateGroupBox.PerformLayout()
        CType(Me.TablePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageTrouble.ResumeLayout(False)
        Me.DistGroupBox.ResumeLayout(False)
        Me.DistGroupBox.PerformLayout()
        Me.SendsGroupBox.ResumeLayout(False)
        Me.SendsGroupBox.PerformLayout()
        Me.PicDataGroupBox.ResumeLayout(False)
        Me.PicDataGroupBox.PerformLayout()
        Me.CommsGroupBox.ResumeLayout(False)
        Me.MotorVGroupBox.ResumeLayout(False)
        Me.MotorVGroupBox.PerformLayout()
        Me.AreaGroupBox.ResumeLayout(False)
        Me.AreaGroupBox.PerformLayout()
        Me.RawPIXYGroupBox.ResumeLayout(False)
        Me.RawPIXYGroupBox.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PIXYSerialPort As IO.Ports.SerialPort
    Friend WithEvents Timer As Timer
    Friend WithEvents ExitButton As Button
    Friend WithEvents ErrorLabel As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents PICSerialPort As IO.Ports.SerialPort
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageDisplay As TabPage
    Friend WithEvents TabPageTrouble As TabPage
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FILEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HELPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Goal2Label As Label
    Friend WithEvents Goal1Label As Label
    Friend WithEvents Goal2TextBox As TextBox
    Friend WithEvents Goal1TextBox As TextBox
    Friend WithEvents ScoresGroupBox As GroupBox
    Friend WithEvents Sig0Label As Label
    Friend WithEvents X0Label As Label
    Friend WithEvents Sig0TextBox As TextBox
    Friend WithEvents X0TextBox As TextBox
    Friend WithEvents CSum0Label As Label
    Friend WithEvents Sync0Label As Label
    Friend WithEvents CSum0TextBox As TextBox
    Friend WithEvents Sync0TextBox As TextBox
    Friend WithEvents Sig1Label As Label
    Friend WithEvents X1Label As Label
    Friend WithEvents Sig1TextBox As TextBox
    Friend WithEvents Csum1Label As Label
    Friend WithEvents Sync1Label As Label
    Friend WithEvents CSum1TextBox As TextBox
    Friend WithEvents Sync1TextBox As TextBox
    Friend WithEvents Y1Label As Label
    Friend WithEvents Y1TextBox As TextBox
    Friend WithEvents Y0Label As Label
    Friend WithEvents Y0TextBox As TextBox
    Friend WithEvents X1TextBox As TextBox
    Friend WithEvents RawPIXYGroupBox As GroupBox
    Friend WithEvents CallibrateButton As Button
    Friend WithEvents PuckYLabel As Label
    Friend WithEvents PuckYTextBox As TextBox
    Friend WithEvents PuckXLabel As Label
    Friend WithEvents PuckXTextBox As TextBox
    Friend WithEvents TablePictureBox As PictureBox
    Friend WithEvents BRCheckBox As CheckBox
    Friend WithEvents TRCheckBox As CheckBox
    Friend WithEvents BLCheckBox As CheckBox
    Friend WithEvents TLCheckBox As CheckBox
    Friend WithEvents CCheckBox As CheckBox
    Friend WithEvents CallibrateGroupBox As GroupBox
    Friend WithEvents HeightLabel As Label
    Friend WithEvents HeightTextBox As TextBox
    Friend WithEvents WLabel As Label
    Friend WithEvents WidthTextBox As TextBox
    Friend WithEvents AreaGroupBox As GroupBox
    Friend WithEvents DimSaveButton As Button
    Friend WithEvents DefaultsCheckBox As CheckBox
    Friend WithEvents MotorVLabel As Label
    Friend WithEvents MotorVTextBox As TextBox
    Friend WithEvents MotorVGroupBox As GroupBox
    Friend WithEvents VelSaveButton As Button
    Friend WithEvents CommsGroupBox As GroupBox
    Friend WithEvents StrikerReadyTextBox As TextBox
    Friend WithEvents Goal1InLabel As Label
    Friend WithEvents StrikerReadyLabel As Label
    Friend WithEvents PicHandTextBox As TextBox
    Friend WithEvents Goal1InTextBox As TextBox
    Friend WithEvents Goal2InTextBox As TextBox
    Friend WithEvents Goal2InLabel As Label
    Friend WithEvents PICHeadLabel As Label
    Friend WithEvents PicDataGroupBox As GroupBox
    Friend WithEvents DistGroupBox As GroupBox
    Friend WithEvents YDistLabel As Label
    Friend WithEvents YDistTextBox As TextBox
    Friend WithEvents XDistLabel As Label
    Friend WithEvents XDistTextBox As TextBox
    Friend WithEvents SendsGroupBox As GroupBox
    Friend WithEvents YLSBLabel As Label
    Friend WithEvents YLSBTextBox As TextBox
    Friend WithEvents XLSBLabel As Label
    Friend WithEvents YMSBLabel As Label
    Friend WithEvents XLSBTextBox As TextBox
    Friend WithEvents YMSBTextBox As TextBox
    Friend WithEvents VBHeadLabel As Label
    Friend WithEvents XMSBLabel As Label
    Friend WithEvents VBHeadTextBox As TextBox
    Friend WithEvents XMSBTextBox As TextBox
    Friend WithEvents GoCheckBox As CheckBox
    Friend WithEvents GoButton As Button
    Friend WithEvents CautionLabel As Label
    Friend WithEvents ReadyCheckBox As CheckBox
    Friend WithEvents ManualLocButton As Button
    Friend WithEvents TroubleshootToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CallibrateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAreaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveVelocityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManualLocationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManualGoToolStripMenuItem As ToolStripMenuItem
End Class
