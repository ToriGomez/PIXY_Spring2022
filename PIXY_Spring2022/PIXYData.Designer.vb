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
        Me.ExitButton.Location = New System.Drawing.Point(1745, 1069)
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
        Me.ListBox1.Enabled = False
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 31
        Me.ListBox1.Location = New System.Drawing.Point(33, 37)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(184, 97)
        Me.ListBox1.TabIndex = 2
        '
        'PICSerialPort
        '
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageDisplay)
        Me.TabControl1.Controls.Add(Me.TabPageTrouble)
        Me.TabControl1.Location = New System.Drawing.Point(28, 66)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1891, 978)
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
        Me.TabPageDisplay.Location = New System.Drawing.Point(10, 48)
        Me.TabPageDisplay.Name = "TabPageDisplay"
        Me.TabPageDisplay.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDisplay.Size = New System.Drawing.Size(1871, 920)
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
        Me.ScoresGroupBox.Location = New System.Drawing.Point(29, 646)
        Me.ScoresGroupBox.Name = "ScoresGroupBox"
        Me.ScoresGroupBox.Size = New System.Drawing.Size(288, 247)
        Me.ScoresGroupBox.TabIndex = 4
        Me.ScoresGroupBox.TabStop = False
        Me.ScoresGroupBox.Text = "SCORES"
        '
        'Goal1Label
        '
        Me.Goal1Label.AutoSize = True
        Me.Goal1Label.Location = New System.Drawing.Point(22, 34)
        Me.Goal1Label.Name = "Goal1Label"
        Me.Goal1Label.Size = New System.Drawing.Size(188, 32)
        Me.Goal1Label.TabIndex = 2
        Me.Goal1Label.Text = "Goal1: Player"
        '
        'Goal2Label
        '
        Me.Goal2Label.AutoSize = True
        Me.Goal2Label.Location = New System.Drawing.Point(25, 130)
        Me.Goal2Label.Name = "Goal2Label"
        Me.Goal2Label.Size = New System.Drawing.Size(190, 32)
        Me.Goal2Label.TabIndex = 3
        Me.Goal2Label.Text = "Goal2: Robot "
        '
        'Goal1TextBox
        '
        Me.Goal1TextBox.Enabled = False
        Me.Goal1TextBox.Location = New System.Drawing.Point(28, 69)
        Me.Goal1TextBox.Name = "Goal1TextBox"
        Me.Goal1TextBox.Size = New System.Drawing.Size(230, 38)
        Me.Goal1TextBox.TabIndex = 0
        '
        'Goal2TextBox
        '
        Me.Goal2TextBox.Enabled = False
        Me.Goal2TextBox.Location = New System.Drawing.Point(31, 165)
        Me.Goal2TextBox.Name = "Goal2TextBox"
        Me.Goal2TextBox.Size = New System.Drawing.Size(230, 38)
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
        Me.CallibrateGroupBox.Location = New System.Drawing.Point(29, 309)
        Me.CallibrateGroupBox.Name = "CallibrateGroupBox"
        Me.CallibrateGroupBox.Size = New System.Drawing.Size(288, 303)
        Me.CallibrateGroupBox.TabIndex = 11
        Me.CallibrateGroupBox.TabStop = False
        Me.CallibrateGroupBox.Text = "Callibration Points:"
        '
        'DefaultsCheckBox
        '
        Me.DefaultsCheckBox.AutoSize = True
        Me.DefaultsCheckBox.Location = New System.Drawing.Point(31, 245)
        Me.DefaultsCheckBox.Name = "DefaultsCheckBox"
        Me.DefaultsCheckBox.Size = New System.Drawing.Size(144, 36)
        Me.DefaultsCheckBox.TabIndex = 11
        Me.DefaultsCheckBox.Text = "Default"
        Me.DefaultsCheckBox.UseVisualStyleBackColor = True
        '
        'BRCheckBox
        '
        Me.BRCheckBox.AutoSize = True
        Me.BRCheckBox.Location = New System.Drawing.Point(31, 203)
        Me.BRCheckBox.Name = "BRCheckBox"
        Me.BRCheckBox.Size = New System.Drawing.Size(217, 36)
        Me.BRCheckBox.TabIndex = 10
        Me.BRCheckBox.Text = "Bottom Right"
        Me.BRCheckBox.UseVisualStyleBackColor = True
        '
        'TRCheckBox
        '
        Me.TRCheckBox.AutoSize = True
        Me.TRCheckBox.Location = New System.Drawing.Point(31, 161)
        Me.TRCheckBox.Name = "TRCheckBox"
        Me.TRCheckBox.Size = New System.Drawing.Size(176, 36)
        Me.TRCheckBox.TabIndex = 9
        Me.TRCheckBox.Text = "Top Right"
        Me.TRCheckBox.UseVisualStyleBackColor = True
        '
        'BLCheckBox
        '
        Me.BLCheckBox.AutoSize = True
        Me.BLCheckBox.Location = New System.Drawing.Point(31, 119)
        Me.BLCheckBox.Name = "BLCheckBox"
        Me.BLCheckBox.Size = New System.Drawing.Size(198, 36)
        Me.BLCheckBox.TabIndex = 8
        Me.BLCheckBox.Text = "Bottom Left"
        Me.BLCheckBox.UseVisualStyleBackColor = True
        '
        'TLCheckBox
        '
        Me.TLCheckBox.AutoSize = True
        Me.TLCheckBox.Location = New System.Drawing.Point(31, 77)
        Me.TLCheckBox.Name = "TLCheckBox"
        Me.TLCheckBox.Size = New System.Drawing.Size(157, 36)
        Me.TLCheckBox.TabIndex = 7
        Me.TLCheckBox.Text = "Top Left"
        Me.TLCheckBox.UseVisualStyleBackColor = True
        '
        'CCheckBox
        '
        Me.CCheckBox.AutoSize = True
        Me.CCheckBox.Location = New System.Drawing.Point(31, 35)
        Me.CCheckBox.Name = "CCheckBox"
        Me.CCheckBox.Size = New System.Drawing.Size(138, 36)
        Me.CCheckBox.TabIndex = 6
        Me.CCheckBox.Text = "Center"
        Me.CCheckBox.UseVisualStyleBackColor = True
        '
        'CallibrateButton
        '
        Me.CallibrateButton.Location = New System.Drawing.Point(28, 226)
        Me.CallibrateButton.Name = "CallibrateButton"
        Me.CallibrateButton.Size = New System.Drawing.Size(228, 64)
        Me.CallibrateButton.TabIndex = 5
        Me.CallibrateButton.Text = "&CALLIBRATE"
        Me.CallibrateButton.UseVisualStyleBackColor = True
        '
        'PuckYLabel
        '
        Me.PuckYLabel.AutoSize = True
        Me.PuckYLabel.Location = New System.Drawing.Point(6, 126)
        Me.PuckYLabel.Name = "PuckYLabel"
        Me.PuckYLabel.Size = New System.Drawing.Size(228, 32)
        Me.PuckYLabel.TabIndex = 4
        Me.PuckYLabel.Text = "Puck Location Y:"
        '
        'PuckYTextBox
        '
        Me.PuckYTextBox.Enabled = False
        Me.PuckYTextBox.Location = New System.Drawing.Point(60, 161)
        Me.PuckYTextBox.Name = "PuckYTextBox"
        Me.PuckYTextBox.Size = New System.Drawing.Size(174, 38)
        Me.PuckYTextBox.TabIndex = 3
        '
        'PuckXLabel
        '
        Me.PuckXLabel.AutoSize = True
        Me.PuckXLabel.Location = New System.Drawing.Point(6, 32)
        Me.PuckXLabel.Name = "PuckXLabel"
        Me.PuckXLabel.Size = New System.Drawing.Size(228, 32)
        Me.PuckXLabel.TabIndex = 2
        Me.PuckXLabel.Text = "Puck Location X:"
        '
        'PuckXTextBox
        '
        Me.PuckXTextBox.Enabled = False
        Me.PuckXTextBox.Location = New System.Drawing.Point(60, 67)
        Me.PuckXTextBox.Name = "PuckXTextBox"
        Me.PuckXTextBox.Size = New System.Drawing.Size(174, 38)
        Me.PuckXTextBox.TabIndex = 1
        '
        'TablePictureBox
        '
        Me.TablePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TablePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TablePictureBox.InitialImage = Nothing
        Me.TablePictureBox.Location = New System.Drawing.Point(361, 23)
        Me.TablePictureBox.Name = "TablePictureBox"
        Me.TablePictureBox.Size = New System.Drawing.Size(1483, 870)
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
        Me.TabPageTrouble.Location = New System.Drawing.Point(10, 48)
        Me.TabPageTrouble.Name = "TabPageTrouble"
        Me.TabPageTrouble.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageTrouble.Size = New System.Drawing.Size(1871, 920)
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
        Me.DistGroupBox.Location = New System.Drawing.Point(1179, 655)
        Me.DistGroupBox.Name = "DistGroupBox"
        Me.DistGroupBox.Size = New System.Drawing.Size(274, 224)
        Me.DistGroupBox.TabIndex = 39
        Me.DistGroupBox.TabStop = False
        Me.DistGroupBox.Text = "DISTANCE (IN):"
        '
        'YDistLabel
        '
        Me.YDistLabel.AutoSize = True
        Me.YDistLabel.Location = New System.Drawing.Point(21, 123)
        Me.YDistLabel.Name = "YDistLabel"
        Me.YDistLabel.Size = New System.Drawing.Size(42, 32)
        Me.YDistLabel.TabIndex = 38
        Me.YDistLabel.Text = "Y:"
        '
        'YDistTextBox
        '
        Me.YDistTextBox.Enabled = False
        Me.YDistTextBox.Location = New System.Drawing.Point(27, 158)
        Me.YDistTextBox.Name = "YDistTextBox"
        Me.YDistTextBox.Size = New System.Drawing.Size(229, 38)
        Me.YDistTextBox.TabIndex = 37
        '
        'XDistLabel
        '
        Me.XDistLabel.AutoSize = True
        Me.XDistLabel.Location = New System.Drawing.Point(21, 38)
        Me.XDistLabel.Name = "XDistLabel"
        Me.XDistLabel.Size = New System.Drawing.Size(42, 32)
        Me.XDistLabel.TabIndex = 36
        Me.XDistLabel.Text = "X:"
        '
        'XDistTextBox
        '
        Me.XDistTextBox.Enabled = False
        Me.XDistTextBox.Location = New System.Drawing.Point(27, 73)
        Me.XDistTextBox.Name = "XDistTextBox"
        Me.XDistTextBox.Size = New System.Drawing.Size(229, 38)
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
        Me.SendsGroupBox.Location = New System.Drawing.Point(1179, 22)
        Me.SendsGroupBox.Name = "SendsGroupBox"
        Me.SendsGroupBox.Size = New System.Drawing.Size(661, 589)
        Me.SendsGroupBox.TabIndex = 37
        Me.SendsGroupBox.TabStop = False
        Me.SendsGroupBox.Text = "VB PIC SENDS:"
        '
        'GoButton
        '
        Me.GoButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.GoButton.Location = New System.Drawing.Point(361, 478)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(248, 90)
        Me.GoButton.TabIndex = 5
        Me.GoButton.Text = "MANUAL &GO"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'ManualLocButton
        '
        Me.ManualLocButton.Location = New System.Drawing.Point(361, 346)
        Me.ManualLocButton.Name = "ManualLocButton"
        Me.ManualLocButton.Size = New System.Drawing.Size(248, 90)
        Me.ManualLocButton.TabIndex = 40
        Me.ManualLocButton.Text = "MANUAL &LOCATION"
        Me.ManualLocButton.UseVisualStyleBackColor = True
        '
        'ReadyCheckBox
        '
        Me.ReadyCheckBox.AutoSize = True
        Me.ReadyCheckBox.Location = New System.Drawing.Point(335, 112)
        Me.ReadyCheckBox.Name = "ReadyCheckBox"
        Me.ReadyCheckBox.Size = New System.Drawing.Size(274, 36)
        Me.ReadyCheckBox.TabIndex = 42
        Me.ReadyCheckBox.Text = "MANUAL READY"
        Me.ReadyCheckBox.UseVisualStyleBackColor = True
        '
        'CautionLabel
        '
        Me.CautionLabel.AutoSize = True
        Me.CautionLabel.ForeColor = System.Drawing.Color.Red
        Me.CautionLabel.Location = New System.Drawing.Point(329, 244)
        Me.CautionLabel.Name = "CautionLabel"
        Me.CautionLabel.Size = New System.Drawing.Size(102, 32)
        Me.CautionLabel.TabIndex = 41
        Me.CautionLabel.Text = "Label1"
        '
        'GoCheckBox
        '
        Me.GoCheckBox.AutoSize = True
        Me.GoCheckBox.Location = New System.Drawing.Point(335, 179)
        Me.GoCheckBox.Name = "GoCheckBox"
        Me.GoCheckBox.Size = New System.Drawing.Size(221, 36)
        Me.GoCheckBox.TabIndex = 40
        Me.GoCheckBox.Text = "MANUAL GO"
        Me.GoCheckBox.UseVisualStyleBackColor = True
        '
        'YLSBLabel
        '
        Me.YLSBLabel.AutoSize = True
        Me.YLSBLabel.Location = New System.Drawing.Point(19, 376)
        Me.YLSBLabel.Name = "YLSBLabel"
        Me.YLSBLabel.Size = New System.Drawing.Size(196, 32)
        Me.YLSBLabel.TabIndex = 34
        Me.YLSBLabel.Text = "Y LSB (steps):"
        '
        'YLSBTextBox
        '
        Me.YLSBTextBox.Enabled = False
        Me.YLSBTextBox.Location = New System.Drawing.Point(25, 411)
        Me.YLSBTextBox.Name = "YLSBTextBox"
        Me.YLSBTextBox.Size = New System.Drawing.Size(229, 38)
        Me.YLSBTextBox.TabIndex = 33
        '
        'XLSBLabel
        '
        Me.XLSBLabel.AutoSize = True
        Me.XLSBLabel.Location = New System.Drawing.Point(19, 206)
        Me.XLSBLabel.Name = "XLSBLabel"
        Me.XLSBLabel.Size = New System.Drawing.Size(196, 32)
        Me.XLSBLabel.TabIndex = 32
        Me.XLSBLabel.Text = "X LSB (steps):"
        '
        'YMSBLabel
        '
        Me.YMSBLabel.AutoSize = True
        Me.YMSBLabel.Location = New System.Drawing.Point(19, 291)
        Me.YMSBLabel.Name = "YMSBLabel"
        Me.YMSBLabel.Size = New System.Drawing.Size(203, 32)
        Me.YMSBLabel.TabIndex = 31
        Me.YMSBLabel.Text = "Y MSB (steps):"
        '
        'XLSBTextBox
        '
        Me.XLSBTextBox.Enabled = False
        Me.XLSBTextBox.Location = New System.Drawing.Point(25, 241)
        Me.XLSBTextBox.Name = "XLSBTextBox"
        Me.XLSBTextBox.Size = New System.Drawing.Size(229, 38)
        Me.XLSBTextBox.TabIndex = 30
        '
        'YMSBTextBox
        '
        Me.YMSBTextBox.Enabled = False
        Me.YMSBTextBox.Location = New System.Drawing.Point(25, 326)
        Me.YMSBTextBox.Name = "YMSBTextBox"
        Me.YMSBTextBox.Size = New System.Drawing.Size(229, 38)
        Me.YMSBTextBox.TabIndex = 29
        '
        'VBHeadLabel
        '
        Me.VBHeadLabel.AutoSize = True
        Me.VBHeadLabel.Location = New System.Drawing.Point(19, 37)
        Me.VBHeadLabel.Name = "VBHeadLabel"
        Me.VBHeadLabel.Size = New System.Drawing.Size(161, 32)
        Me.VBHeadLabel.TabIndex = 27
        Me.VBHeadLabel.Text = "VB Header:"
        '
        'XMSBLabel
        '
        Me.XMSBLabel.AutoSize = True
        Me.XMSBLabel.Location = New System.Drawing.Point(19, 119)
        Me.XMSBLabel.Name = "XMSBLabel"
        Me.XMSBLabel.Size = New System.Drawing.Size(203, 32)
        Me.XMSBLabel.TabIndex = 28
        Me.XMSBLabel.Text = "X MSB (steps):"
        '
        'VBHeadTextBox
        '
        Me.VBHeadTextBox.Enabled = False
        Me.VBHeadTextBox.Location = New System.Drawing.Point(25, 72)
        Me.VBHeadTextBox.Name = "VBHeadTextBox"
        Me.VBHeadTextBox.Size = New System.Drawing.Size(229, 38)
        Me.VBHeadTextBox.TabIndex = 25
        '
        'XMSBTextBox
        '
        Me.XMSBTextBox.Enabled = False
        Me.XMSBTextBox.Location = New System.Drawing.Point(25, 154)
        Me.XMSBTextBox.Name = "XMSBTextBox"
        Me.XMSBTextBox.Size = New System.Drawing.Size(229, 38)
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
        Me.PicDataGroupBox.Location = New System.Drawing.Point(546, 500)
        Me.PicDataGroupBox.Name = "PicDataGroupBox"
        Me.PicDataGroupBox.Size = New System.Drawing.Size(520, 225)
        Me.PicDataGroupBox.TabIndex = 36
        Me.PicDataGroupBox.TabStop = False
        Me.PicDataGroupBox.Text = "RAW PIC DATA:"
        '
        'StrikerReadyTextBox
        '
        Me.StrikerReadyTextBox.Enabled = False
        Me.StrikerReadyTextBox.Location = New System.Drawing.Point(278, 158)
        Me.StrikerReadyTextBox.Name = "StrikerReadyTextBox"
        Me.StrikerReadyTextBox.Size = New System.Drawing.Size(229, 38)
        Me.StrikerReadyTextBox.TabIndex = 34
        '
        'Goal1InLabel
        '
        Me.Goal1InLabel.AutoSize = True
        Me.Goal1InLabel.Location = New System.Drawing.Point(272, 38)
        Me.Goal1InLabel.Name = "Goal1InLabel"
        Me.Goal1InLabel.Size = New System.Drawing.Size(188, 32)
        Me.Goal1InLabel.TabIndex = 31
        Me.Goal1InLabel.Text = "Goal 1 Score:"
        '
        'StrikerReadyLabel
        '
        Me.StrikerReadyLabel.AutoSize = True
        Me.StrikerReadyLabel.Location = New System.Drawing.Point(272, 123)
        Me.StrikerReadyLabel.Name = "StrikerReadyLabel"
        Me.StrikerReadyLabel.Size = New System.Drawing.Size(194, 32)
        Me.StrikerReadyLabel.TabIndex = 30
        Me.StrikerReadyLabel.Text = "Striker Ready:"
        '
        'PicHandTextBox
        '
        Me.PicHandTextBox.Enabled = False
        Me.PicHandTextBox.Location = New System.Drawing.Point(25, 73)
        Me.PicHandTextBox.Name = "PicHandTextBox"
        Me.PicHandTextBox.Size = New System.Drawing.Size(229, 38)
        Me.PicHandTextBox.TabIndex = 25
        '
        'Goal1InTextBox
        '
        Me.Goal1InTextBox.Enabled = False
        Me.Goal1InTextBox.Location = New System.Drawing.Point(278, 73)
        Me.Goal1InTextBox.Name = "Goal1InTextBox"
        Me.Goal1InTextBox.Size = New System.Drawing.Size(229, 38)
        Me.Goal1InTextBox.TabIndex = 29
        '
        'Goal2InTextBox
        '
        Me.Goal2InTextBox.Enabled = False
        Me.Goal2InTextBox.Location = New System.Drawing.Point(25, 155)
        Me.Goal2InTextBox.Name = "Goal2InTextBox"
        Me.Goal2InTextBox.Size = New System.Drawing.Size(229, 38)
        Me.Goal2InTextBox.TabIndex = 26
        '
        'Goal2InLabel
        '
        Me.Goal2InLabel.AutoSize = True
        Me.Goal2InLabel.Location = New System.Drawing.Point(20, 120)
        Me.Goal2InLabel.Name = "Goal2InLabel"
        Me.Goal2InLabel.Size = New System.Drawing.Size(188, 32)
        Me.Goal2InLabel.TabIndex = 28
        Me.Goal2InLabel.Text = "Goal 2 Score:"
        '
        'PICHeadLabel
        '
        Me.PICHeadLabel.AutoSize = True
        Me.PICHeadLabel.Location = New System.Drawing.Point(19, 38)
        Me.PICHeadLabel.Name = "PICHeadLabel"
        Me.PICHeadLabel.Size = New System.Drawing.Size(220, 32)
        Me.PICHeadLabel.TabIndex = 27
        Me.PICHeadLabel.Text = "PIC Handshake:"
        '
        'CommsGroupBox
        '
        Me.CommsGroupBox.Controls.Add(Me.ListBox1)
        Me.CommsGroupBox.Location = New System.Drawing.Point(16, 22)
        Me.CommsGroupBox.Name = "CommsGroupBox"
        Me.CommsGroupBox.Size = New System.Drawing.Size(271, 155)
        Me.CommsGroupBox.TabIndex = 35
        Me.CommsGroupBox.TabStop = False
        Me.CommsGroupBox.Text = "COMMS:"
        '
        'MotorVGroupBox
        '
        Me.MotorVGroupBox.Controls.Add(Me.VelSaveButton)
        Me.MotorVGroupBox.Controls.Add(Me.MotorVLabel)
        Me.MotorVGroupBox.Controls.Add(Me.MotorVTextBox)
        Me.MotorVGroupBox.Location = New System.Drawing.Point(16, 500)
        Me.MotorVGroupBox.Name = "MotorVGroupBox"
        Me.MotorVGroupBox.Size = New System.Drawing.Size(460, 196)
        Me.MotorVGroupBox.TabIndex = 34
        Me.MotorVGroupBox.TabStop = False
        Me.MotorVGroupBox.Text = "MOTOR VELOCITY (IN/SEC):"
        '
        'VelSaveButton
        '
        Me.VelSaveButton.Location = New System.Drawing.Point(61, 91)
        Me.VelSaveButton.Name = "VelSaveButton"
        Me.VelSaveButton.Size = New System.Drawing.Size(196, 89)
        Me.VelSaveButton.TabIndex = 33
        Me.VelSaveButton.Text = "SAVE &VELOCITY"
        Me.VelSaveButton.UseVisualStyleBackColor = True
        '
        'MotorVLabel
        '
        Me.MotorVLabel.AutoSize = True
        Me.MotorVLabel.Location = New System.Drawing.Point(27, 34)
        Me.MotorVLabel.Name = "MotorVLabel"
        Me.MotorVLabel.Size = New System.Drawing.Size(124, 32)
        Me.MotorVLabel.TabIndex = 32
        Me.MotorVLabel.Text = "Velocity:"
        '
        'MotorVTextBox
        '
        Me.MotorVTextBox.Location = New System.Drawing.Point(157, 34)
        Me.MotorVTextBox.Name = "MotorVTextBox"
        Me.MotorVTextBox.Size = New System.Drawing.Size(166, 38)
        Me.MotorVTextBox.TabIndex = 31
        '
        'AreaGroupBox
        '
        Me.AreaGroupBox.Controls.Add(Me.DimSaveButton)
        Me.AreaGroupBox.Controls.Add(Me.HeightLabel)
        Me.AreaGroupBox.Controls.Add(Me.HeightTextBox)
        Me.AreaGroupBox.Controls.Add(Me.WLabel)
        Me.AreaGroupBox.Controls.Add(Me.WidthTextBox)
        Me.AreaGroupBox.Location = New System.Drawing.Point(16, 201)
        Me.AreaGroupBox.Name = "AreaGroupBox"
        Me.AreaGroupBox.Size = New System.Drawing.Size(389, 270)
        Me.AreaGroupBox.TabIndex = 31
        Me.AreaGroupBox.TabStop = False
        Me.AreaGroupBox.Text = "PIXY DATA AREA (IN):"
        '
        'DimSaveButton
        '
        Me.DimSaveButton.Location = New System.Drawing.Point(71, 156)
        Me.DimSaveButton.Name = "DimSaveButton"
        Me.DimSaveButton.Size = New System.Drawing.Size(175, 91)
        Me.DimSaveButton.TabIndex = 30
        Me.DimSaveButton.Text = "SAVE &AREA"
        Me.DimSaveButton.UseVisualStyleBackColor = True
        '
        'HeightLabel
        '
        Me.HeightLabel.AutoSize = True
        Me.HeightLabel.Location = New System.Drawing.Point(16, 104)
        Me.HeightLabel.Name = "HeightLabel"
        Me.HeightLabel.Size = New System.Drawing.Size(106, 32)
        Me.HeightLabel.TabIndex = 29
        Me.HeightLabel.Text = "Height:"
        '
        'HeightTextBox
        '
        Me.HeightTextBox.Location = New System.Drawing.Point(131, 98)
        Me.HeightTextBox.Name = "HeightTextBox"
        Me.HeightTextBox.Size = New System.Drawing.Size(166, 38)
        Me.HeightTextBox.TabIndex = 28
        '
        'WLabel
        '
        Me.WLabel.AutoSize = True
        Me.WLabel.Location = New System.Drawing.Point(16, 51)
        Me.WLabel.Name = "WLabel"
        Me.WLabel.Size = New System.Drawing.Size(96, 32)
        Me.WLabel.TabIndex = 27
        Me.WLabel.Text = "Width:"
        '
        'WidthTextBox
        '
        Me.WidthTextBox.Location = New System.Drawing.Point(131, 45)
        Me.WidthTextBox.Name = "WidthTextBox"
        Me.WidthTextBox.Size = New System.Drawing.Size(166, 38)
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
        Me.RawPIXYGroupBox.Location = New System.Drawing.Point(546, 22)
        Me.RawPIXYGroupBox.Name = "RawPIXYGroupBox"
        Me.RawPIXYGroupBox.Size = New System.Drawing.Size(567, 465)
        Me.RawPIXYGroupBox.TabIndex = 25
        Me.RawPIXYGroupBox.TabStop = False
        Me.RawPIXYGroupBox.Text = "RAW PIXY DATA:"
        '
        'X1TextBox
        '
        Me.X1TextBox.Enabled = False
        Me.X1TextBox.Location = New System.Drawing.Point(36, 317)
        Me.X1TextBox.Name = "X1TextBox"
        Me.X1TextBox.Size = New System.Drawing.Size(229, 38)
        Me.X1TextBox.TabIndex = 24
        '
        'Y1Label
        '
        Me.Y1Label.AutoSize = True
        Me.Y1Label.Location = New System.Drawing.Point(30, 367)
        Me.Y1Label.Name = "Y1Label"
        Me.Y1Label.Size = New System.Drawing.Size(157, 32)
        Me.Y1Label.TabIndex = 23
        Me.Y1Label.Text = "Y Center 1:"
        '
        'Y1TextBox
        '
        Me.Y1TextBox.Enabled = False
        Me.Y1TextBox.Location = New System.Drawing.Point(36, 402)
        Me.Y1TextBox.Name = "Y1TextBox"
        Me.Y1TextBox.Size = New System.Drawing.Size(229, 38)
        Me.Y1TextBox.TabIndex = 22
        '
        'Y0Label
        '
        Me.Y0Label.AutoSize = True
        Me.Y0Label.Location = New System.Drawing.Point(305, 367)
        Me.Y0Label.Name = "Y0Label"
        Me.Y0Label.Size = New System.Drawing.Size(157, 32)
        Me.Y0Label.TabIndex = 21
        Me.Y0Label.Text = "Y Center 0:"
        '
        'Y0TextBox
        '
        Me.Y0TextBox.Enabled = False
        Me.Y0TextBox.Location = New System.Drawing.Point(311, 402)
        Me.Y0TextBox.Name = "Y0TextBox"
        Me.Y0TextBox.Size = New System.Drawing.Size(229, 38)
        Me.Y0TextBox.TabIndex = 20
        '
        'Sig1Label
        '
        Me.Sig1Label.AutoSize = True
        Me.Sig1Label.Location = New System.Drawing.Point(30, 197)
        Me.Sig1Label.Name = "Sig1Label"
        Me.Sig1Label.Size = New System.Drawing.Size(235, 32)
        Me.Sig1Label.TabIndex = 19
        Me.Sig1Label.Text = "Signature Num 1:"
        '
        'X1Label
        '
        Me.X1Label.AutoSize = True
        Me.X1Label.Location = New System.Drawing.Point(30, 282)
        Me.X1Label.Name = "X1Label"
        Me.X1Label.Size = New System.Drawing.Size(157, 32)
        Me.X1Label.TabIndex = 18
        Me.X1Label.Text = "X Center 1:"
        '
        'Sig1TextBox
        '
        Me.Sig1TextBox.Enabled = False
        Me.Sig1TextBox.Location = New System.Drawing.Point(36, 232)
        Me.Sig1TextBox.Name = "Sig1TextBox"
        Me.Sig1TextBox.Size = New System.Drawing.Size(229, 38)
        Me.Sig1TextBox.TabIndex = 17
        '
        'Csum1Label
        '
        Me.Csum1Label.AutoSize = True
        Me.Csum1Label.Location = New System.Drawing.Point(30, 116)
        Me.Csum1Label.Name = "Csum1Label"
        Me.Csum1Label.Size = New System.Drawing.Size(179, 32)
        Me.Csum1Label.TabIndex = 15
        Me.Csum1Label.Text = "Checksum 1:"
        '
        'Sync1Label
        '
        Me.Sync1Label.AutoSize = True
        Me.Sync1Label.Location = New System.Drawing.Point(30, 34)
        Me.Sync1Label.Name = "Sync1Label"
        Me.Sync1Label.Size = New System.Drawing.Size(109, 32)
        Me.Sync1Label.TabIndex = 14
        Me.Sync1Label.Text = "Sync 1:"
        '
        'CSum1TextBox
        '
        Me.CSum1TextBox.Enabled = False
        Me.CSum1TextBox.Location = New System.Drawing.Point(36, 151)
        Me.CSum1TextBox.Name = "CSum1TextBox"
        Me.CSum1TextBox.Size = New System.Drawing.Size(229, 38)
        Me.CSum1TextBox.TabIndex = 13
        '
        'Sync1TextBox
        '
        Me.Sync1TextBox.Enabled = False
        Me.Sync1TextBox.Location = New System.Drawing.Point(36, 69)
        Me.Sync1TextBox.Name = "Sync1TextBox"
        Me.Sync1TextBox.Size = New System.Drawing.Size(229, 38)
        Me.Sync1TextBox.TabIndex = 12
        '
        'Sig0Label
        '
        Me.Sig0Label.AutoSize = True
        Me.Sig0Label.Location = New System.Drawing.Point(305, 197)
        Me.Sig0Label.Name = "Sig0Label"
        Me.Sig0Label.Size = New System.Drawing.Size(235, 32)
        Me.Sig0Label.TabIndex = 11
        Me.Sig0Label.Text = "Signature Num 0:"
        '
        'X0Label
        '
        Me.X0Label.AutoSize = True
        Me.X0Label.Location = New System.Drawing.Point(305, 282)
        Me.X0Label.Name = "X0Label"
        Me.X0Label.Size = New System.Drawing.Size(157, 32)
        Me.X0Label.TabIndex = 10
        Me.X0Label.Text = "X Center 0:"
        '
        'Sig0TextBox
        '
        Me.Sig0TextBox.Enabled = False
        Me.Sig0TextBox.Location = New System.Drawing.Point(311, 232)
        Me.Sig0TextBox.Name = "Sig0TextBox"
        Me.Sig0TextBox.Size = New System.Drawing.Size(229, 38)
        Me.Sig0TextBox.TabIndex = 9
        '
        'X0TextBox
        '
        Me.X0TextBox.Enabled = False
        Me.X0TextBox.Location = New System.Drawing.Point(311, 317)
        Me.X0TextBox.Name = "X0TextBox"
        Me.X0TextBox.Size = New System.Drawing.Size(229, 38)
        Me.X0TextBox.TabIndex = 8
        '
        'CSum0Label
        '
        Me.CSum0Label.AutoSize = True
        Me.CSum0Label.Location = New System.Drawing.Point(305, 116)
        Me.CSum0Label.Name = "CSum0Label"
        Me.CSum0Label.Size = New System.Drawing.Size(179, 32)
        Me.CSum0Label.TabIndex = 7
        Me.CSum0Label.Text = "Checksum 0:"
        '
        'Sync0Label
        '
        Me.Sync0Label.AutoSize = True
        Me.Sync0Label.Location = New System.Drawing.Point(305, 34)
        Me.Sync0Label.Name = "Sync0Label"
        Me.Sync0Label.Size = New System.Drawing.Size(109, 32)
        Me.Sync0Label.TabIndex = 6
        Me.Sync0Label.Text = "Sync 0:"
        '
        'CSum0TextBox
        '
        Me.CSum0TextBox.Enabled = False
        Me.CSum0TextBox.Location = New System.Drawing.Point(311, 151)
        Me.CSum0TextBox.Name = "CSum0TextBox"
        Me.CSum0TextBox.Size = New System.Drawing.Size(229, 38)
        Me.CSum0TextBox.TabIndex = 5
        '
        'Sync0TextBox
        '
        Me.Sync0TextBox.Enabled = False
        Me.Sync0TextBox.Location = New System.Drawing.Point(311, 69)
        Me.Sync0TextBox.Name = "Sync0TextBox"
        Me.Sync0TextBox.Size = New System.Drawing.Size(229, 38)
        Me.Sync0TextBox.TabIndex = 4
        '
        'MenuStrip
        '
        Me.MenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.HELPToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(2000, 60)
        Me.MenuStrip.TabIndex = 4
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TroubleshootToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(94, 50)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'TroubleshootToolStripMenuItem
        '
        Me.TroubleshootToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CallibrateToolStripMenuItem, Me.SaveAreaToolStripMenuItem, Me.SaveVelocityToolStripMenuItem, Me.ManualLocationToolStripMenuItem, Me.ManualGoToolStripMenuItem})
        Me.TroubleshootToolStripMenuItem.Name = "TroubleshootToolStripMenuItem"
        Me.TroubleshootToolStripMenuItem.Size = New System.Drawing.Size(362, 54)
        Me.TroubleshootToolStripMenuItem.Text = "&TroubleShoot"
        '
        'CallibrateToolStripMenuItem
        '
        Me.CallibrateToolStripMenuItem.Name = "CallibrateToolStripMenuItem"
        Me.CallibrateToolStripMenuItem.Size = New System.Drawing.Size(403, 54)
        Me.CallibrateToolStripMenuItem.Text = "&Callibrate"
        '
        'SaveAreaToolStripMenuItem
        '
        Me.SaveAreaToolStripMenuItem.Name = "SaveAreaToolStripMenuItem"
        Me.SaveAreaToolStripMenuItem.Size = New System.Drawing.Size(403, 54)
        Me.SaveAreaToolStripMenuItem.Text = "Save &Area"
        '
        'SaveVelocityToolStripMenuItem
        '
        Me.SaveVelocityToolStripMenuItem.Name = "SaveVelocityToolStripMenuItem"
        Me.SaveVelocityToolStripMenuItem.Size = New System.Drawing.Size(403, 54)
        Me.SaveVelocityToolStripMenuItem.Text = "Save &Velocity"
        '
        'ManualLocationToolStripMenuItem
        '
        Me.ManualLocationToolStripMenuItem.Name = "ManualLocationToolStripMenuItem"
        Me.ManualLocationToolStripMenuItem.Size = New System.Drawing.Size(403, 54)
        Me.ManualLocationToolStripMenuItem.Text = "Manual &Location"
        '
        'ManualGoToolStripMenuItem
        '
        Me.ManualGoToolStripMenuItem.Name = "ManualGoToolStripMenuItem"
        Me.ManualGoToolStripMenuItem.Size = New System.Drawing.Size(403, 54)
        Me.ManualGoToolStripMenuItem.Text = "Manual &Go"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(362, 54)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'HELPToolStripMenuItem
        '
        Me.HELPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HELPToolStripMenuItem.Name = "HELPToolStripMenuItem"
        Me.HELPToolStripMenuItem.Size = New System.Drawing.Size(109, 50)
        Me.HELPToolStripMenuItem.Text = "HELP"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(266, 54)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'PIXYData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(2000, 1194)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.MenuStrip)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "PIXYData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AIRHOCKEY"
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
