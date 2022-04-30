'Tori Gomez
'3/30/21
'Code for the PIXYCMUcam5 to get data to be sent to the PIC16LF1788.
'The PIXY will detect the puck that is illuminated in green and the striker.
'Based on the serial data sent from the PIXY, this code will read and analyze
'and tell the PIC16LF1788 on what to do in direction the puck will need to move.

'Refer to link https://github.com/ToriGomez/PIXY_Spring2022 for original code

Option Strict On
Option Explicit On
Imports System.IO.Ports
Imports System.Math
Imports System.Threading.Thread



Public Class PIXYData
    Dim receiveBytesPic(10) As Byte                                                                 'All the Bytes of data the PIC will send
    Dim recieveBytesPixy(15) As Byte                                                                'All the Bytes of data the PIXY will send
    Dim comPort1String As String                                                                    'Both of the Serial Ports used in the program
    Dim comPort2String As String                                                                    '/
    Dim xLocationInteger(10) As Integer                                                             'Save 11 Frames of data arrays for x & y
    Dim yLocationInteger(10) As Integer                                                             '/
    Dim frameInteger As Integer                                                                     'Dimension of the number of saved frame data
    Dim picDataBoolean As Boolean = False                                                           '/
    Dim strikerReadyBoolean As Boolean = False                                                      'Dimension to wait until the striker/motors are in home postion
    Dim callibrations(10) As Integer                                                                'Holds all the save coordinates from callibration
    Dim xInchConversionSingle(5) As Single                                                          'Holds all the X step conversions
    Dim yInchConversionSingle(5) As Single                                                          'Holds all the y step conversions
    Dim graphicsDisplayBoolean(5) As Boolean                                                        'Boolean to know what graphic of puck (location) will be seen
    Dim manualGoBoolean As Boolean                                                                  'Boolean to know that the Manual Go has been pressed
    Dim manualReadyBoolean As Boolean                                                               'Boolean to know that the Manual Ready is checked
    Dim widthSingle As Single                                                                       'Width value of the table under test
    Dim heightSingle As Single                                                                      'Height value of the table under test
    Dim velocitySingle As Single = 0.004                                                            'Velocity value of the motors. Set in PIC code
    Dim timerTestInteger As Integer                                                                 'timer to know the time span that has passed
    Dim portRenameBoolean As Boolean                                                                'Dimension that will only allow the portRename happen once



    'Sub for when the Form loads, test and opens all of the communication ports. One for the PIXY data through the breakout board and the
    'main board from the PIC16LF1788.
    Private Sub PIXYData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetSerialPortNamesSub()                                                                     'Sub to get all the ports being used

        PIXYSerialPort.PortName = comPort1String                                                    'Test if the port is the PIXY
        PIXYSerialPort.BaudRate = 100000                                                            'Baudrate of 100000 bits/sec. Up to 230k supported.
        PIXYSerialPort.DataBits = 8                                                                 '8 data bits
        PIXYSerialPort.StopBits = IO.Ports.StopBits.One                                             '1 stop bit
        PIXYSerialPort.Parity = IO.Ports.Parity.None                                                'No parity bits
        PIXYSerialPort.Open()                                                                       'Open the port to receive data


        CallibrateButton.Visible = False                                                            'Hide callibrate button untill one checkbox is selected
        TRCheckBox.Visible = False                                                                  'Hide the other callibrations until the center is done
        TLCheckBox.Visible = False                                                                  '--/
        BRCheckBox.Visible = False                                                                  '-/
        BLCheckBox.Visible = False                                                                  '/


        WidthTextBox.Text = "35"                                                                    'Default area of the PIXY Area
        HeightTextBox.Text = "15"                                                                   'Default area of the PIXY Area
        widthSingle = CSng(WidthTextBox.Text) / 2                                                   'Defines the width radius of the test area of the PIXY
        heightSingle = CSng(HeightTextBox.Text)                                                     'Defines the height of the test area of the PIXY



        callibrations(0) = 153                                                                      'Default coordinates so that it doesn't have to callibrated at every bootup
        callibrations(1) = 145                                                                      '--------/
        callibrations(2) = 70                                                                       '-------/
        callibrations(3) = 110                                                                      '------/
        callibrations(4) = 237                                                                      '-----/
        callibrations(5) = 110                                                                      '----/
        callibrations(6) = 70                                                                       '---/
        callibrations(7) = 180                                                                      '--/
        callibrations(8) = 233                                                                      '-/
        callibrations(9) = 180                                                                      '/

        xInchConversionSingle(0) = 0.2228915                                                        'Default inch conversions from default coordinates
        yInchConversionSingle(0) = 0.2142857                                                        '------/
        xInchConversionSingle(1) = 0.2202381                                                        '-----/
        yInchConversionSingle(1) = 0.2142857                                                        '----/
        xInchConversionSingle(2) = 0.2228915                                                        '---/
        yInchConversionSingle(2) = 0.2142857                                                        '--/
        xInchConversionSingle(3) = 0.23125                                                          '-/
        yInchConversionSingle(3) = 0.2142857                                                        '/  

        MotorVTextBox.Text = "0.004"                                                                'Default Velocity of the Motors

        GoCheckBox.Checked = True                                                                   'Manual Go for VB Send to PIC for saftey
        manualGoBoolean = False                                                                     'Boolean for manual Go false until Go Button Pressed
        CautionLabel.Text = "TROUBLESHOOTING"                                                       'In Manual mode, it is in the Troubleshooting state
        CautionLabel.ForeColor = Color.Green                                                        'Green for Safety

        Timer.Enabled = True                                                                        'Enables the timer

    End Sub



    'Sub for when the form is changed in size. The monitor will display in full screen, this portions the controls to this.
    Private Sub PIXYData_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        ExitButton.Top = Me.Height - 70
        ExitButton.Left = Me.Width - 200
        TabControl1.Width = Me.Width - 50
        TabControl1.Height = Me.Height - 120
        TablePictureBox.Width = TabControl1.Width - 160
        TablePictureBox.Height = TabControl1.Height - 50

    End Sub



    'Sub for every interval of 1ms has passed. Reads the data from the PIXY will send the data to the PIC.
    Private Sub SendTimer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        Timer.Enabled = False                                                                       'Disables timer to interrupt again

        If portRenameBoolean = False Then
            If timerTestInteger >= 100 Then                                                         'If the PIXY communictation port is correct,
                SerialPortRenameSub()                                                               'Sub that will rename the port being used for the PIXY
                timerTestInteger = 0                                                                'Reset the timer 
            End If
        Else
            Try                                                                                     'Opens the PIC port if the PIXY is Initially correct
                PICSerialPort.PortName = comPort2String                                             'Doesn't reopen if it already has been opened
                PICSerialPort.BaudRate = 57600                                                      'Baudrate of 57600 bits/sec
                PICSerialPort.DataBits = 8                                                          '8 data bits
                PICSerialPort.StopBits = IO.Ports.StopBits.One                                      '1 stop bit
                PICSerialPort.Parity = IO.Ports.Parity.None                                         'No parity bits
                PICSerialPort.Open()
            Catch ex As Exception
            End Try
        End If


        AirHockeyGraphicsSub()                                                                      'Sub to Draw the background of picture box of the goal

        SignatureLocationSub()                                                                      'Displays the current puck Location seen.

        If picDataBoolean Then                                                                      'Wait until the PIC data has beed read
            PicRawSerialSub()                                                                       'Get the data from the PIC
        End If

        If strikerReadyBoolean Then                                                                 'If the Motor is at home, get data to send out to the PIC
            'IntersectionPointSub()                                                                 'NOT FINISHED Calculate the point of intersection of the moving puck
            PuckPointSub()                                                                          'Gets the current location of the puck to be hit(NOT INTERSECTION POINT)
            strikerReadyBoolean = False                                                             'Disable sends to PIC until homed again
        End If


        Timer.Enabled = True                                                                        'ReEnable the timer to interrupt again

    End Sub



    'Sub for read the serial data from the PIC16LF1788 which will send 4 bytes, receive up to 11 bytes of data in case of errors.
    Private Sub PICSerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles PICSerialPort.DataReceived

        CheckForIllegalCrossThreadCalls = False                                                     'Disables for there to be errors with cross thread

        PICSerialPort.Read(receiveBytesPic, 0, 11)                                                  'Save serial

        picDataBoolean = True                                                                       'The data has been received

    End Sub



    'Sub for read the serial data from the PIC16LF1788 which will send 14 bytes, receive up to 15 bytes of data in case of errors.
    Private Sub PIXYSerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles PIXYSerialPort.DataReceived
        Dim byte0Integer As Integer                                                                 'Dimension for the LSB sync data, can be 0x55 or 0x56
        Dim byte1Integer As Integer                                                                 'Dimension for the MSB sync data, is 0xaa
        Dim byte2Integer As Integer                                                                 'Dimension for the LSB checksum
        Dim byte3Integer As Integer                                                                 'Dimension for the MSB checksum
        Dim byte4Integer As Integer                                                                 'Dimension for the LSB signature number
        Dim byte5Integer As Integer                                                                 'Dimension for the MSB signature number 
        Dim byte6Integer As Integer                                                                 'Dimension for the LSB x center of object
        Dim byte7Integer As Integer                                                                 'Dimension for the MSB x center of object
        Dim byte8Integer As Integer                                                                 'Dimension for the LSB y center of object
        Dim byte9Integer As Integer                                                                 'Dimension for the MSB y center of object


        CheckForIllegalCrossThreadCalls = False                                                     'Disables for there to be errors with cross thread

        PIXYSerialPort.Read(recieveBytesPixy, 0, 15)                                                'Save serial


        byte0Integer = PIXYSerialPort.ReadByte                                                      'Read the first sync word from the PIXY
        byte1Integer = PIXYSerialPort.ReadByte                                                      'Read The second sync word from the PIXY

        If byte0Integer = 85 And byte1Integer = 170 Then                                            'If the second sync word is correct

            portRenameBoolean = True                                                                'Correct port selected

            byte2Integer = PIXYSerialPort.ReadByte                                                  'Read the rest of the sync data 
            byte3Integer = PIXYSerialPort.ReadByte                                                  '------/

            If byte2Integer = 85 And byte3Integer = 170 Then                                        'If rest another sync, following data is information
                byte2Integer = PIXYSerialPort.ReadByte                                              'Read the rest of the data 
                byte3Integer = PIXYSerialPort.ReadByte                                              '/
            End If

            byte4Integer = PIXYSerialPort.ReadByte                                                  '-----/
            byte5Integer = PIXYSerialPort.ReadByte                                                  '----/
            byte6Integer = PIXYSerialPort.ReadByte                                                  '---/
            byte7Integer = PIXYSerialPort.ReadByte                                                  '--/
            byte8Integer = PIXYSerialPort.ReadByte                                                  '-/
            byte9Integer = PIXYSerialPort.ReadByte                                                  '/


            Sync0TextBox.Text = (CInt(byte0Integer).ToString)                                       'Writes all the bytes of data for the User to See from the PIXY
            Sync1TextBox.Text = (CInt(byte1Integer).ToString)                                       '--------/
            CSum0TextBox.Text = (CInt(byte2Integer).ToString)                                       '-------/
            CSum1TextBox.Text = (CInt(byte3Integer).ToString)                                       '------/
            Sig0TextBox.Text = (CInt(byte4Integer).ToString)                                        '-----/
            Sig1TextBox.Text = (CInt(byte5Integer).ToString)                                        '----/
            X0TextBox.Text = (CInt(byte6Integer).ToString)                                          '---/
            X1TextBox.Text = (CInt(byte7Integer).ToString)                                          '--/
            Y0TextBox.Text = (CInt(byte8Integer).ToString)                                          '-/
            Y1TextBox.Text = (CInt(byte9Integer).ToString)                                          '/


            'save the data to know how to move the striker. PIXY data runs at 
            '50 frames per second. Saving data will help when getting the velocity
            'and direction of the puck
            If byte4Integer = 1 Then                                                                'Test if the Puck has been detected. This is the signature of the puck
                xLocationInteger(frameInteger) = byte6Integer                                       'No data is saved if it is not
                yLocationInteger(frameInteger) = byte8Integer                                       '---/

                frameInteger += 1                                                                   '--/

                If frameInteger = 10 Then                                                           '-/
                    frameInteger = 1                                                                '/
                End If
            End If
        Else                                                                                        'If the 85 and 170 sync is not received, add to timer to test 
            If portRenameBoolean = False Then                                                       'if this is the correct port for the PIXY
                timerTestInteger += 1                                                               '/
            End If
        End If

    End Sub



    'Sub for everytime the Center Callibrate Checkbox is selected. Deselects the other checkboxes and enables the Callibration button to be saved.
    Private Sub CCheckBox_Click(sender As Object, e As EventArgs) Handles CCheckBox.Click

        TRCheckBox.Checked = False
        TLCheckBox.Checked = False
        BRCheckBox.Checked = False
        BLCheckBox.Checked = False
        DefaultsCheckBox.Checked = False

        If CCheckBox.Checked Then
            CallibrateButton.Visible = True
        Else
            CallibrateButton.Visible = False
        End If

    End Sub



    'Sub for everytime the Top Right Callibrate Checkbox is selected. Deselects the other checkboxes and enables the Callibration button to be saved.
    Private Sub TRCheckBox_Click(sender As Object, e As EventArgs) Handles TRCheckBox.Click

        CCheckBox.Checked = False
        TLCheckBox.Checked = False
        BRCheckBox.Checked = False
        BLCheckBox.Checked = False
        DefaultsCheckBox.Checked = False

        If TRCheckBox.Checked Then
            CallibrateButton.Visible = True
        Else
            CallibrateButton.Visible = False
        End If

    End Sub



    'Sub for everytime the Top Left Callibrate Checkbox is selected. Deselects the other checkboxes and enables the Callibration button to be saved.
    Private Sub TLCheckBox_Click(sender As Object, e As EventArgs) Handles TLCheckBox.Click

        CCheckBox.Checked = False
        TRCheckBox.Checked = False
        BRCheckBox.Checked = False
        BLCheckBox.Checked = False
        DefaultsCheckBox.Checked = False

        If TLCheckBox.Checked Then
            CallibrateButton.Visible = True
        Else
            CallibrateButton.Visible = False
        End If

    End Sub



    'Sub for everytime the Bottom Right Callibrate Checkbox is selected. Deselects the other checkboxes and enables the Callibration button to be saved.
    Private Sub BRCheckBox_Click(sender As Object, e As EventArgs) Handles BRCheckBox.Click

        CCheckBox.Checked = False
        TRCheckBox.Checked = False
        TLCheckBox.Checked = False
        BLCheckBox.Checked = False
        DefaultsCheckBox.Checked = False

        If BRCheckBox.Checked Then
            CallibrateButton.Visible = True
        Else
            CallibrateButton.Visible = False
        End If

    End Sub



    'Sub for everytime the Bottom Left Callibrate Checkbox is selected. Deselects the other checkboxes and enables the Callibration button to be saved.
    Private Sub BLCheckBox_Click(sender As Object, e As EventArgs) Handles BLCheckBox.Click

        CCheckBox.Checked = False
        TRCheckBox.Checked = False
        TLCheckBox.Checked = False
        BRCheckBox.Checked = False
        DefaultsCheckBox.Checked = False

        If BLCheckBox.Checked Then
            CallibrateButton.Visible = True
        Else
            CallibrateButton.Visible = False
        End If

    End Sub



    'Sub for everytime the Default Callibrate Checkbox is selected. Deselects the other checkboxes and enables the Callibration button to be saved.
    'The default values can be seen in the load, for the SPRING 2022 these are for the current callibration so that it does not need to be callibrated
    'everytime the program starts.
    Private Sub DefaultsCheckBox_Click(sender As Object, e As EventArgs) Handles DefaultsCheckBox.Click

        CCheckBox.Checked = False
        TRCheckBox.Checked = False
        TLCheckBox.Checked = False
        BRCheckBox.Checked = False
        BLCheckBox.Checked = False

        If DefaultsCheckBox.Checked Then
            CallibrateButton.Visible = True
        Else
            CallibrateButton.Visible = False
        End If

    End Sub



    'Sub that will Callibrate the dimensions of the Table.
    Private Sub CallibrateButton_Click(sender As Object, e As EventArgs) Handles CallibrateButton.Click, CallibrateToolStripMenuItem.Click

        Dim xPointInteger As Integer                                                                'Dimension for the x Point to be saved 
        Dim yPointInteger As Integer                                                                'Dimension for the y Point to be saved

        If DefaultsCheckBox.Checked Then                                                            'Functions for when the Default callibration is made

            TRCheckBox.Visible = True                                                               'Enables Visibility on all the checkboxes 
            TLCheckBox.Visible = True                                                               '--/
            BRCheckBox.Visible = True                                                               '-/ 
            BLCheckBox.Visible = True                                                               '/

            callibrations(0) = 153                                                                  'Default coordinates so that it doesn't have to callibrated at every bootup
            callibrations(1) = 145                                                                  '--------/
            callibrations(2) = 70                                                                   '-------/
            callibrations(3) = 110                                                                  '------/
            callibrations(4) = 237                                                                  '-----/
            callibrations(5) = 110                                                                  '----/
            callibrations(6) = 70                                                                   '---/
            callibrations(7) = 180                                                                  '--/
            callibrations(8) = 233                                                                  '-/
            callibrations(9) = 180                                                                  '/

            xInchConversionSingle(0) = 0.2228915                                                    'Default inch conversions from default coordinates
            yInchConversionSingle(0) = 0.2142857                                                    '------/
            xInchConversionSingle(1) = 0.2202381                                                    '-----/
            yInchConversionSingle(1) = 0.2142857                                                    '----/
            xInchConversionSingle(2) = 0.2228915                                                    '---/
            yInchConversionSingle(2) = 0.2142857                                                    '--/
            xInchConversionSingle(3) = 0.23125                                                      '-/
            yInchConversionSingle(3) = 0.2142857                                                    '/  

            GraphicStateSub(6)                                                                      'Sub that allows for the callibration locations of the puck to be displayed
            TablePictureBoxSub(xLocationInteger(1), xLocationInteger(1),                            'Sub that graphs the puck based on the Graphic State Sub
                               callibrations, graphicsDisplayBoolean)                               '/
        End If

        If CCheckBox.Checked Then                                                                   'Functions for when the Center callibration is made
            xPointInteger = CInt(PuckXTextBox.Text)                                                 'Get the current location of the puck
            yPointInteger = CInt(PuckXTextBox.Text)                                                 '/

            callibrations(0) = xPointInteger                                                        'Saves the location into the callibrations array
            callibrations(1) = yPointInteger                                                        '/

            TRCheckBox.Visible = True                                                               'Enables Visibility on all the checkboxes 
            TLCheckBox.Visible = True                                                               '--/
            BRCheckBox.Visible = True                                                               '-/
            BLCheckBox.Visible = True                                                               '/

            GraphicStateSub(0)                                                                      'Sub that allows for the center callibration of the puck to be displayed
            TablePictureBoxSub(xLocationInteger(1), xLocationInteger(1),                            'Sub that graphs the puck based on the Graphic State Sub
                               callibrations, graphicsDisplayBoolean)                               '/
        End If

        If TLCheckBox.Checked Then                                                                  'Functions for when the Top Left callibration is made
            xPointInteger = CInt(PuckXTextBox.Text)                                                 'Get the current location of the puck
            yPointInteger = CInt(PuckYTextBox.Text)                                                 '/

            callibrations(2) = xPointInteger                                                        'Saves the location into the callibrations array
            callibrations(3) = yPointInteger                                                        '/

            xInchConversionSingle(0) = callibrations(0) - callibrations(2)                          'Difference from top left x location from center
            xInchConversionSingle(0) = xInchConversionSingle(0) / (CSng(WidthTextBox.Text) / 2)     'points of PIXY per inch
            xInchConversionSingle(0) = 1 / xInchConversionSingle(0)                                 'inch per points of PIXY

            yInchConversionSingle(0) = callibrations(1) - callibrations(3)                          'Difference from top left y location from center
            yInchConversionSingle(0) = yInchConversionSingle(0) / (CSng(HeightTextBox.Text) / 2)    'points of PIXY per inch
            yInchConversionSingle(0) = 1 / yInchConversionSingle(0)                                 'inch per points of PIXY

            GraphicStateSub(1)                                                                      'Sub that allows for the top left callibration of the puck to be displayed
            TablePictureBoxSub(xLocationInteger(1), xLocationInteger(1),                            'Sub that graphs the puck based on the Graphic State Sub
                               callibrations, graphicsDisplayBoolean)                               '/
        End If

        If TRCheckBox.Checked Then                                                                  'Functions for when the Top Right callibration is made
            xPointInteger = CInt(PuckXTextBox.Text)                                                 'Get the current location of the puck
            yPointInteger = CInt(PuckYTextBox.Text)                                                 '/

            callibrations(4) = xPointInteger                                                        'Saves the location into the callibrations array
            callibrations(5) = yPointInteger                                                        '/

            xInchConversionSingle(1) = callibrations(4) - callibrations(0)                          'Difference from top right x location from center
            xInchConversionSingle(1) = xInchConversionSingle(1) / (CSng(WidthTextBox.Text) / 2)     'points of PIXY per inch
            xInchConversionSingle(1) = 1 / xInchConversionSingle(1)                                 'inch per points of PIXY

            yInchConversionSingle(1) = callibrations(1) - callibrations(5)                          'Difference from top right y location from center
            yInchConversionSingle(1) = yInchConversionSingle(1) / (CSng(HeightTextBox.Text) / 2)    'points of PIXY per inch
            yInchConversionSingle(1) = 1 / yInchConversionSingle(1)                                 'inch per points of PIXY

            GraphicStateSub(2)                                                                      'Sub that allows for the top right callibration of the puck to be displayed
            TablePictureBoxSub(xLocationInteger(1), xLocationInteger(1),                            'Sub that graphs the puck based on the Graphic State Sub
                               callibrations, graphicsDisplayBoolean)                               '/
        End If

        If BLCheckBox.Checked Then                                                                  'Functions for when the Bottom Left callibration is made
            xPointInteger = CInt(PuckXTextBox.Text)                                                 'Get the current location of the puck
            yPointInteger = CInt(PuckYTextBox.Text)                                                 '/

            callibrations(6) = xPointInteger                                                        'Saves the location into the callibrations array
            callibrations(7) = yPointInteger                                                        '/

            xInchConversionSingle(2) = callibrations(0) - callibrations(6)                          'Difference from Bottom left x location from center
            xInchConversionSingle(2) = xInchConversionSingle(2) / (CSng(WidthTextBox.Text) / 2)     'points of PIXY per inch
            xInchConversionSingle(2) = 1 / xInchConversionSingle(2)                                 'inch per points of PIXY

            yInchConversionSingle(2) = callibrations(7) - callibrations(1)                          'Difference from Bottom left y location from center
            yInchConversionSingle(2) = yInchConversionSingle(2) / (CSng(HeightTextBox.Text) / 2)    'points of PIXY per inch
            yInchConversionSingle(2) = 1 / yInchConversionSingle(2)                                 'inch per points of PIXY

            GraphicStateSub(3)                                                                      'Sub that allows for the bottom left callibration of the puck to be displayed
            TablePictureBoxSub(xLocationInteger(1), xLocationInteger(1),                            'Sub that graphs the puck based on the Graphic State Sub
                               callibrations, graphicsDisplayBoolean)                               '/
        End If

        If BRCheckBox.Checked Then                                                                  'Functions for when the Bottom Right callibration is made
            xPointInteger = CInt(PuckXTextBox.Text)                                                 'Get the current location of the puck
            yPointInteger = CInt(PuckYTextBox.Text)                                                 '/

            callibrations(8) = xPointInteger                                                        'Saves the location into the callibrations array
            callibrations(9) = yPointInteger                                                        '/

            xInchConversionSingle(3) = callibrations(8) - callibrations(0)                          'Difference from Bottom Right x location from center
            xInchConversionSingle(3) = xInchConversionSingle(3) / (CSng(WidthTextBox.Text) / 2)     'points of PIXY per inch
            xInchConversionSingle(3) = 1 / xInchConversionSingle(3)                                 'inch per points of PIXY

            yInchConversionSingle(3) = callibrations(9) - callibrations(1)                          'Difference from Bottom Right y location from center
            yInchConversionSingle(3) = yInchConversionSingle(3) / (CSng(HeightTextBox.Text) / 2)    'points of PIXY per inch
            yInchConversionSingle(3) = 1 / yInchConversionSingle(3)                                 'inch per points of PIXY

            GraphicStateSub(4)                                                                      'Sub that allows for the bottom right callibration of the puck to be displayed
            TablePictureBoxSub(xLocationInteger(1), xLocationInteger(1),                            'Sub that graphs the puck based on the Graphic State Sub
                               callibrations, graphicsDisplayBoolean)                               '/
        End If

        DefaultsCheckBox.Checked = False                                                            'Disables check after callibration is set
        CCheckBox.Checked = False                                                                   '----/
        TLCheckBox.Checked = False                                                                  '---/
        TRCheckBox.Checked = False                                                                  '--/
        BLCheckBox.Checked = False                                                                  '-/
        BRCheckBox.Checked = False                                                                  '/

        TablePictureBox.Refresh()                                                                   'Refresh the Picture box after callibration puck display finished

    End Sub



    'Save the Dimensions of the PIXY area if it is not at default location.
    'To test to see if an area is usable, it is easy to find by the led on the PIXY 
    'sensor. If it is flashing/on then that means the puck can be seen from that spot.
    'If it is not that means the PIXY can not read the location of the puck.
    'Move the puck around and mark locations to know what these dimensions will be.
    Private Sub DimSaveButton_Click(sender As Object, e As EventArgs) Handles DimSaveButton.Click, SaveAreaToolStripMenuItem.Click

        If IsNumeric(WidthTextBox.Text) And IsNumeric(HeightTextBox.Text) Then                      'Test if the Dimenstion save text boxes are VAILD, if not set to default
            If WidthTextBox.Text = "0" Or HeightTextBox.Text = "0" Then                             '-----/
                WidthTextBox.Text = "32"                                                            '----/
                HeightTextBox.Text = "15"                                                           '---/
            End If
        Else                                                                                        '--/
            WidthTextBox.Text = "32"                                                                '-/
            HeightTextBox.Text = "15"                                                               '/
        End If

        widthSingle = (CSng(WidthTextBox.Text) / 2)                                                 'Save the dimensions of the PIXY testing area
        heightSingle = CSng(HeightTextBox.Text)                                                     '/

    End Sub



    'Save the Velocity of the Motor if it is not at the default. This is changed in the PIC16LF1788 code. 
    'Refer to that to know the set velocity.
    Private Sub VelSaveButton_Click(sender As Object, e As EventArgs) Handles VelSaveButton.Click, SaveVelocityToolStripMenuItem.Click

        If IsNumeric(MotorVTextBox.Text) Then                                                       'Test if the Velocity save text box is VALID, if not set to default
            If MotorVTextBox.Text = "0" Then                                                        '---/
                MotorVTextBox.Text = "0.004"                                                        '--/
            End If
        Else                                                                                        '-/
            MotorVTextBox.Text = "0.004"                                                            '/
        End If

        VelocitySingle = CSng(MotorVTextBox.Text)                                                   'Save the Velocity to be used later

    End Sub



    'Sub to manually indicate that the striker at home and is ready. Goes to the current location of the puck.
    Private Sub ReadyCheckBox_Click(sender As Object, e As EventArgs) Handles ReadyCheckBox.Click

        If ReadyCheckBox.Checked = True Then                                                        'If the Ready checked, allows for the PIC send to be sent
            ManualLocButton.Visible = False                                                         'for current puck location
            strikerReadyBoolean = True                                                              '/
        Else                                                                                        'If not checked, the manual location send can be done
            ManualLocButton.Visible = True                                                          'nothing is sent to the PIC while in troubleshooting mode
            strikerReadyBoolean = False                                                             '/
        End If

    End Sub


    'If the Manual Go check box is deselected, the VB will automatically will Send data out.
    'CAUTION IF TROUBLESHOOTING, ALWAYS HAVE THE MANUAL GO ON WHEN TROUBLESHOOTING.
    Private Sub GoCheckBox_Click(sender As Object, e As EventArgs) Handles GoCheckBox.Click

        If GoCheckBox.Checked = False Then                                                          'If manual go checked, then the Go button needs to be pressed
            ReadyCheckBox.Checked = False                                                           'to send out the data. Indicates that it is in safe
            ReadyCheckBox.Visible = False                                                           'troubleshooting mode. If not data is sent automatically to 
            ManualLocButton.Visible = False                                                         'the PIC when it is ready and is not save when troubleshooting
            GoButton.Visible = False                                                                '---------/
            CautionLabel.Text = "CAUTION" & vbNewLine & "TROUBLESHOOTING"                           'Unsave state
            CautionLabel.ForeColor = Color.Red                                                      '-------/
        Else                                                                                        'Save state
            ReadyCheckBox.Checked = False                                                           '-----/
            ReadyCheckBox.Visible = True                                                            '----/
            ManualLocButton.Visible = True                                                          '---/
            GoButton.Visible = True                                                                 '--/
            CautionLabel.Text = "TROUBLESHOOTING"                                                   '-/
            CautionLabel.ForeColor = Color.Green                                                    '/
        End If

    End Sub



    'Sub for when the Manual location is Pressed. When the motor is at home this will move the y motors up so that
    'it goes to the center location of the PIXY testing area. This is for testing so that we know that the communication 
    'with the PIC and VB is working properly. This bypasses the current sends for the current location of the puck.
    Private Sub ManualLocButton_Click(sender As Object, e As EventArgs) Handles ManualLocButton.Click, ManualLocationToolStripMenuItem.Click

        Dim sendByte(4) As Byte                                                                     'Dimension for the array of data being sent to the PIC

        sendByte(0) = CByte(94)                                                                     'Send Handshake ^ Hex:5E Dec:94
        sendByte(1) = CByte(0)                                                                      'MSB byte of x step
        sendByte(2) = CByte(0)                                                                      'LSB byte of x step
        sendByte(3) = CByte(7)                                                                      'MSB byte of y step
        sendByte(4) = CByte(29)                                                                     'LSB byte of y step

        PICSerialPort.Write(sendByte, 0, 5)                                                         'if the MANUAL GO button has been pressed

    End Sub



    'Sub for when the manual Go button is pressed. VB will send the data to the PIC once until
    'pressed again.
    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click, ManualGoToolStripMenuItem.Click

        manualGoBoolean = True

    End Sub




    'Sub of the Exit button that closes out the program.
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click

        Dim stateSingle As Single                                                                   'Dimension StateSingle is a vbYes or vbNo.

        stateSingle = MsgBox("Would you like to exit?", CType(vbYesNo + vbCritical +                'Message box with message and a Yes and No buttons. Writes Select to stateSingle.
                             vbDefaultButton2, MsgBoxStyle), "Exit")                                '/

        If stateSingle = vbYes Then                                                                 'If/Then Function tests if Yes was selected, stating that the user wants to exit.
            PICSerialPort.Close()                                                                   'If selected Yes, Closes Program.
            PIXYSerialPort.Close()                                                                  '-/
            Me.Close()                                                                              '/
        ElseIf stateSingle = vbNo Then                                                              'If selected No, then clear and return to program.
        End If
    End Sub



    'Sub to redesignate the serial ports to the correct portname
    Sub SerialPortRenameSub()

        PIXYSerialPort.Close()                                                                      'Close the incorrect port

        PIXYSerialPort.PortName = comPort2String                                                    'Re-name the PIXY to the new port
        PIXYSerialPort.BaudRate = 100000                                                            'Baudrate of 100000 bits/sec. Up to 230k supported.
        PIXYSerialPort.DataBits = 8                                                                 '8 data bits
        PIXYSerialPort.StopBits = IO.Ports.StopBits.One                                             '1 stop bit
        PIXYSerialPort.Parity = IO.Ports.Parity.None                                                'No parity bits
        PIXYSerialPort.Open()



        PICSerialPort.PortName = comPort1String                                                     'Open the PIC serial port 
        PICSerialPort.BaudRate = 57600                                                              'Baudrate of 57600 bits/sec
        PICSerialPort.DataBits = 8                                                                  '8 data bits
        PICSerialPort.StopBits = IO.Ports.StopBits.One                                              '1 stop bit
        PICSerialPort.Parity = IO.Ports.Parity.None                                                 'No parity bits
        PICSerialPort.Open()


    End Sub



    'Show all available/in-use COMM ports.
    Sub GetSerialPortNamesSub()

        Dim comPortInteger As Integer = 1                                                           'Serial port number under test

        For Each sp As String In My.Computer.Ports.SerialPortNames                                  'Gets every Serial Port (sp) connected

            If comPortInteger = 1 Then                                                              'For the first port found
                comPort1String = sp                                                                 'Set the port found to the global first port
                comPortInteger += 1                                                                 'Goes to next serial port
                portRenameBoolean = True                                                            'Indicates one port
            Else                                                                                    'If second found, set the port to the second global
                comPort2String = sp                                                                 '/
                portRenameBoolean = False                                                           'Indicates more than one port
            End If
            ListBox1.Items.Add(sp)                                                                  'displays the communication ports
        Next

        If comPort2String = "" Then
            MsgBox("ERROR OF COMMUNICATIONS CONNECTIONS!!!" + vbNewLine +
                   "CHECK CONNECTIONS AND RESTART PROGRAM.")
        End If
    End Sub



    'Sub to read the current location of the Puck being seen by the PIXY
    Sub SignatureLocationSub()

        PuckXTextBox.Text = X0TextBox.Text                                                          'displays the current x location of the puck
        PuckYTextBox.Text = Y0TextBox.Text                                                          '/

        If IsNumeric(X0TextBox.Text) And IsNumeric(Y0TextBox.Text) Then
            GraphicStateSub(5)                                                                      'Sub that indicates that the current location of the puck is to be displayed
            TablePictureBoxSub(xLocationInteger(1), yLocationInteger(1),                            'Sub that graphs the puck based on the Graphic State Sub
                                callibrations, graphicsDisplayBoolean)                              '/
        End If

    End Sub



    'Sub of the Raw PIC serial Data
    Sub PicRawSerialSub()

        Dim receivedHeaderInteger As Integer                                                        'Header to verify the serial port is the PIC
        Dim goal1Integer As Integer                                                                 'Value of how many goals have gone into Player side
        Dim goal2Integer As Integer                                                                 'Value of how many goals have gone into Robot side
        Dim motorsHomeInteger As Integer                                                            'Flag that the striker is at home position

        receivedHeaderInteger = PICSerialPort.ReadByte                                              'Sets the receivedHeader to the values of the first byte sent from the PIC

        If receivedHeaderInteger = 36 Then                                                          'Tests if the Header was the $ sign

            goal1Integer = PICSerialPort.ReadByte                                                   'Read the goal 1 data from PIC
            goal2Integer = PICSerialPort.ReadByte                                                   'Read the goal 2 data from PIC
            motorsHomeInteger = PICSerialPort.ReadByte                                              'Read if the motors are at home position

            Goal1TextBox.Text = (CInt(goal1Integer).ToString)                                       'Write the scores on the display for the player to see
            Goal2TextBox.Text = (CInt(goal2Integer).ToString)                                       '/

            If Not motorsHomeInteger = 0 Then                                                       'Last PIC byte determines if the motor is back at home or not
                strikerReadyBoolean = True                                                          '0 indicates that it is not at home, anything but that does
            Else                                                                                    '-/
                strikerReadyBoolean = False                                                         '/
            End If

            PicHandTextBox.Text = CStr(receivedHeaderInteger)                                       'Display all the RAW PIC DATA for the user
            Goal1InTextBox.Text = CStr(goal1Integer)                                                '--/
            Goal2InTextBox.Text = CStr(goal2Integer)                                                '-/
            StrikerReadyTextBox.Text = CStr(motorsHomeInteger)                                      '/
        End If

        If ReadyCheckBox.Checked Then                                                               'To manually still be able to move the motors if PIC is not sending ready
            strikerReadyBoolean = True                                                              '/
        End If

    End Sub



    'Sub to calculate the amount of steps in the x & y motors to move them to the location of the puck.

    'This is the instaneous time of the puck with a velocity of zero. If the puck is moving the intersectionPointSub()
    'will have to be made to know were to move the striker.

    'The sent back data will have a MSB of 1/0 to indicate if the X motor needs to move right/left. The 
    'LSB bits will be the value of steps needed. 

    'The home location of the striker will be in the middle range of where the data of the Puck can be read. This will be at the 
    '(153,180) quardanents read from the PIXY. Therefore the maximum distance left or right is 18.5in and the maximum steps are
    '4.625k. If the calculated steps is greater than this 4.625 then there is a mistake. 

    'In the Y direction the maximum distance up is 15in and the maximum steps are 3.75k. If the calculated steps is greater than this
    '3.75k then were is a mistake.
    Sub PuckPointSub()

        Dim strikerVelocitySingle As Single                                                         'Dimension of the set velocity of the motors/striker
        Dim xInchSingle As Single                                                                   'Dimension of the x conversion number based on quadrant
        Dim yInchSingle As Single                                                                   'Dimension of the y conversion number based on quadrant
        Dim puckDeltaXInteger As Integer                                                            'Dimension of the displacement of the puck from the center x
        Dim puckDeltaYInteger As Integer                                                            'Dimension of the displacement of the puck from the center y
        Dim xMotorDirectionBoolean As Boolean                                                       'Dimension of the x motor for right and left. True indicates right
        Dim xStepDouble As Double                                                                   'Dimension of the number of x axis steps to be sent out
        Dim yStepDouble As Double                                                                   'Dimension of the number of y axis steps to be sent out
        Dim xDistanceSingle As Single                                                               'Dimension of the number of inches the puck is displaced in x
        Dim yDistanceSingle As Single                                                               'Dimension of the number of inches the puck is displaced in y
        Dim xStepByte As Byte()                                                                     'Dimension of the byte to hold all the x value of steps
        Dim yStepByte As Byte()                                                                     'Dimension of the byte to hold all the y value of steps
        Dim sendByte(4) As Byte                                                                     'Dimension of the full byte to be sent to the PIC


        strikerVelocitySingle = velocitySingle                                                      'Set the velocity of the motor


        If xLocationInteger(1) <= 153 Then                                                          'Based on the current location get the proper inches/point conversion
            If yLocationInteger(1) <= 145 Then                                                      'from each quadrant from the center point
                xInchSingle = xInchConversionSingle(0)                                              '-----------/
                yInchSingle = yInchConversionSingle(0)                                              '----------/
            Else                                                                                    '---------/
                xInchSingle = xInchConversionSingle(2)                                              '--------/
                yInchSingle = yInchConversionSingle(2)                                              '-------/
            End If
        Else                                                                                        '------/
            If yLocationInteger(1) <= 145 Then                                                      '-----/
                xInchSingle = xInchConversionSingle(1)                                              '----/
                yInchSingle = yInchConversionSingle(1)                                              '---/
            Else                                                                                    '--/
                xInchSingle = xInchConversionSingle(3)                                              '-/
                yInchSingle = yInchConversionSingle(3)                                              '/
            End If
        End If


        puckDeltaXInteger = callibrations(0) - xLocationInteger(1)                                  'Get the displacement from center point
        puckDeltaYInteger = callibrations(9) - yLocationInteger(1)                                  '/

        If puckDeltaXInteger < 0 Then                                                               'Sets if the x displacement is right or left from home
            xMotorDirectionBoolean = True                                                           '--/
        Else                                                                                        '-/
            xMotorDirectionBoolean = False                                                          '/
        End If


        xStepDouble = Abs(puckDeltaXInteger) * xInchSingle                                          'Get the amount of inches needed to get to the displacement

        Try                                                                                         'If the displacement distance is larger than test area, set to max
            If xStepDouble > widthSingle Then xStepDouble = widthSingle                             '--/
        Catch ex As Exception                                                                       '-/
            If xStepDouble > 18.5 Then xStepDouble = 18.5                                           '/
        End Try

        xDistanceSingle = CSng(xStepDouble)                                                         'Save the distance to be displayed on the form
        XDistTextBox.Text = CStr(xDistanceSingle)                                                   '/
        xStepDouble = CInt(xStepDouble / strikerVelocitySingle)                                     'Get the step value based on the distance


        yStepDouble = Abs(puckDeltaYInteger) * yInchSingle                                          'Get the amount of inches needed to get to the displacement

        Try                                                                                         'If the displacement distance is larger than test area, set to max
            If yStepDouble > heightSingle Then yStepDouble = heightSingle                           '--/
        Catch ex As Exception                                                                       '-/
            If yStepDouble > 15 Then yStepDouble = 15                                               '/
        End Try

        yDistanceSingle = CSng(yStepDouble)                                                         'Save the distance to be displayed on the form
        YDistTextBox.Text = CStr(yDistanceSingle)                                                   '/
        yStepDouble = CInt(yStepDouble / strikerVelocitySingle)                                     'Get the step value based on the distance

        sendByte(0) = CByte(94)                                                                     'Send Handshake ^ Hex:5E Dec:94

        If xMotorDirectionBoolean = True Then                                                       'If on the right, Set the MSB of data for x HIGH
            xStepDouble += 32768                                                                    'Add a &H8000 indicating to move right
        End If

        xStepByte = IntToByteArrayFunction(CInt(xStepDouble))                                       'Get 4 8-byte words back for x step value. Bytes 2 & 3 hold value
        sendByte(1) = xStepByte(2)                                                                  'MSB byte of x step
        sendByte(2) = xStepByte(3)                                                                  'LSB byte of x step

        yStepByte = IntToByteArrayFunction(CInt(yStepDouble))                                       'Get 4 8-byte words back for y step value. Bytes 2 & 3 hold value
        sendByte(3) = yStepByte(2)                                                                  'MSB byte of y step
        sendByte(4) = yStepByte(3)                                                                  'LSB byte of y step

        If GoButton.Visible = False Or manualGoBoolean Then                                         'Send data if the manual is off or
            PICSerialPort.Write(sendByte, 0, 5)                                                     'if the GO button has been pressed
            manualGoBoolean = False                                                                 'Clear boolean to wait until next press
        End If

        VBHeadTextBox.Text = CStr(sendByte(0))                                                      'Displays the data sent out for the user
        XMSBTextBox.Text = CStr(sendByte(1))                                                        '---/
        XLSBTextBox.Text = CStr(sendByte(2))                                                        '--/
        YMSBTextBox.Text = CStr(sendByte(3))                                                        '-/
        YLSBTextBox.Text = CStr(sendByte(4))                                                        '/

    End Sub



    'Function that writes the integer/double into 4-bytes. In this program, only 
    'two will be used. The two MSB bytes are always 0s. The result of all the bytes is 
    'sent back. The MSB is in byte(2) and LSB is in byte(3).
    Function IntToByteArrayFunction(valueInteger As Integer) As Byte()

        Dim result(Len(New Integer) - 1) As Byte                                                    '4 Bytes
        Dim mask = &HFF                                                                             '0xFF - Hexadecimal for 1111 1111

        For i As Integer = result.Length - 1 To 0 Step -1                                           'Get all the bytes of data from the inserted value
            result(i) = CByte(valueInteger And mask)                                                '/
            valueInteger >>= 8                                                                      'Shift from left to right 8 bits
        Next                                                                                        '/
        Return result                                                                               'Return 4 bytes of data

    End Function



    'THIS IS NOT FINISHED AND TESTED!!!!
    'Sub to calculate the Velocity of the puck and which direction it needs to move to.
    Sub IntersectionPointSub()

        Dim strikerVelocitySingle As Single                                                         'Dimension of the striker velocity
        Dim puckDeltaXInteger As Integer                                                            'Dimension of the displacement x of the puck
        Dim puckDeltaYInteger As Integer                                                            'Dimension of the displacemetn y of the puck
        Dim puckVelocityDouble As Double                                                            'Dimension of the puck velocity 
        Dim puckVelocityBoolean As Boolean = True                                                   'Dimension of the puck is moving (true)
        Dim aPointDouble As Double                                                                  'Dimension of the a value of quadratic
        Dim bPointDouble As Double                                                                  'Dimension of the b value of quadratic
        Dim cPointDouble As Double                                                                  'Dimension of the c value of quadratic
        Dim distanceDouble As Double                                                                'Dimenison of the linear distance from puck to striker
        Dim timeDouble As Double                                                                    'Dimenison of the time of intercept
        Dim intersectionYInteger As Integer                                                         'Dimension of the x value of intersection
        Dim intersectionXInteger As Integer                                                         'Dimension of the y value of IN


        If Not xLocationInteger(1) = 0 Then                                                         'Test in location data is good fro velocity
            puckDeltaXInteger = callibrations(0) - xLocationInteger(1)                              'Get the displacement from center point
            puckDeltaYInteger = callibrations(9) - yLocationInteger(1)                              '/

            aPointDouble = Abs(puckDeltaXInteger) ^ (2)                                             'Get the linear distance to the puck from striker at home
            bPointDouble = Abs(puckDeltaYInteger) ^ (2)                                             '--/
            cPointDouble = (aPointDouble + bPointDouble) ^ (1 / 2)                                  '-/
            distanceDouble = cPointDouble * 0.223                                                   '/

            Try                                                                                     'Test to see if the puck is moving
                puckVelocityDouble = (xLocationInteger(1) - xLocationInteger(0)) /                  '-/
                    (yLocationInteger(1) - yLocationInteger(0))                                     '/
                puckVelocityDouble = puckVelocityDouble * 0.223 * (50)                              'Convert the velocity into inches/sec
            Catch ex As Exception                                                                   'If puck not moving set to flag to move motors to puck location
                puckVelocityBoolean = False                                                         '/
            End Try


            aPointDouble = (strikerVelocitySingle ^ 2) - (puckVelocityDouble ^ 2)                   'Get the two values of time that the striker can intersect the puck
            bPointDouble = 2 * (distanceDouble * puckVelocityDouble)                                '-/
            cPointDouble = (-(distanceDouble) ^ 2)                                                  '/

            timeDouble = QuadraticFunction(aPointDouble, bPointDouble, cPointDouble)                'Function to return the value of time of intersection

            If puckVelocityBoolean Then                                                             'If the puck is moving, Get the x and y value of intersection
                intersectionXInteger = (xLocationInteger(1) +                                       '---/
                    (CInt(puckVelocityDouble) * CInt(timeDouble)))                                  '--/
                intersectionYInteger = (yLocationInteger(1) +                                       '-/
                    CInt(puckVelocityDouble) * CInt(timeDouble))                                    '/
            Else                                                                                    'If the puck is not moving, go to puck point sub to go to current puck location
                PuckPointSub()                                                                      '/
            End If

        End If
    End Sub



    'Function to get the two values for time of the IntersectionPointSub. 
    'If both are negative then the puck is not able to be reached by the stiker. This is an error.
    'If there is negative time that Is incorrect. The other value of t is sent back.
    'If both are positive then the shortest time is sent back.
    Function QuadraticFunction(a As Double, b As Double, c As Double) As Double

        Dim time1Double As Double                                                                   'Dimension for the first time
        Dim time2Double As Double                                                                   'Dimension for the second time

        time1Double = ((-b) + ((b ^ 2) - 4 * (a * c)) ^ (1 / 2))                                    'Get the first time from the quadratic equation
        time1Double = time1Double / (2 * a)                                                         '+


        time2Double = ((-b) - ((b ^ 2) - 4 * (a * c)) ^ (1 / 2))                                    'Get the second time from the quadratic equation
        time2Double = time2Double / (2 * a)                                                         '-

        If time1Double > 0 Or time2Double > 0 Then
            If time1Double < time2Double Then                                                       'Determines witch of the two times will be sent back
                Return time1Double                                                                  '----/
            Else                                                                                    '---/
                Return time2Double                                                                  '--/
            End If
        Else                                                                                        '-/
            Return Nothing                                                                          '/
        End If

    End Function



    'Sub to know which Graphic state is desired. There are 6 possiblities, all the callibration locations
    'and the current puck location
    Sub GraphicStateSub(state As Integer)

        Select Case state
            Case 0
                graphicsDisplayBoolean = {True, False, False, False, False, False}
            Case 1
                graphicsDisplayBoolean = {False, True, False, False, False, False}
            Case 2
                graphicsDisplayBoolean = {False, False, True, False, False, False}
            Case 3
                graphicsDisplayBoolean = {False, False, False, True, False, False}
            Case 4
                graphicsDisplayBoolean = {False, False, False, False, True, False}
            Case 5
                graphicsDisplayBoolean = {False, False, False, False, False, True}
            Case 6
                graphicsDisplayBoolean = {True, True, True, True, True, False}
        End Select

    End Sub



    'Sub for() the Graphic Background For the Table Picture so that User knows the orientation
    Sub AirHockeyGraphicsSub()

        Dim linePen As New Pen(Color.Black, 100)                                                    'Dimension of the pen used to draw the robot goal
        Dim rightInteger As Integer                                                                 'Dimensions of the 4 corners locations of the picture box
        Dim leftInteger As Integer                                                                  '--/
        Dim topInteger As Integer                                                                   '-/
        Dim bottomInteger As Integer                                                                '/
        Dim xMidInteger As Integer                                                                  'Dimensions of the middle points of the picture box
        Dim yMidInteger As Integer                                                                  '/

        bottomInteger = Me.Height - (TablePictureBox.Height - 420)                                  'Calculated locations for the graphics locations based on screen size
        rightInteger = Me.Width - 315                                                               '--/
        topInteger = 1                                                                              '-/
        leftInteger = 1                                                                             '/

        xMidInteger = (rightInteger + leftInteger) \ 2                                              'Calculated center location based on the 4 corners
        yMidInteger = (topInteger + bottomInteger) \ 2                                              '/

        TablePictureBox.CreateGraphics.DrawEllipse(linePen, CSng(xMidInteger / 4),                  'Draw the goal for user orientation of the display
                                                   topInteger - 450, 1000, 500)                     '/

    End Sub


    'Sub for the Graphic on the Table Picture Box so that the location of the PUCK can be seen
    Sub TablePictureBoxSub(xLocationInteger As Integer, yLocationInteger As Integer, ByVal callibration As Array, ByVal stateBoolean As Array)

        Dim yScaleSingle As Single                                                                  'Dimensions of the scaling of the PIXY points to the Picture box
        Dim xScaleSingle As Single                                                                  '/
        Dim xInteger As Integer                                                                     'Dimensions of the current puck locations to the display
        Dim yInteger As Integer                                                                     '/
        Dim rightInteger As Integer                                                                 'Dimensions of the 4 corners locations of the picture box
        Dim leftInteger As Integer                                                                  '--/
        Dim topInteger As Integer                                                                   '-/
        Dim bottomInteger As Integer                                                                '/
        Dim xMidInteger As Integer                                                                  'Dimensions of the middle points of the picture box
        Dim yMidInteger As Integer                                                                  '/
        Dim puckBrush As New SolidBrush(Color.GreenYellow)                                          'Dimensions for the Brushes used to make the green puck and have it erased
        Dim refreshBrush As New SolidBrush(Color.White)                                             '/
        Dim callibration2() As Integer                                                              'Copy of the Inserted callibration array
        Dim graphicStateBoolean() As Boolean                                                        'Copy of the Inserted state of what puck graphic is to be drawn
        Dim callibrationsx(4) As Integer                                                            'Dimension to get the MAX and MIN of the x callibration values
        Dim callibrationsy(4) As Integer                                                            'Dimension to get tha MAX and MIN of the y callibration values
        Static minInteger As Integer                                                                'Dimension of the MAX and MIN found in the MinMaxSub
        Static maxInteger As Integer                                                                '/

        AirHockeyGraphicsSub()                                                                      'Sub to Draw the background of picture box of the goal

        bottomInteger = Me.Height - (TablePictureBox.Height - 420)                                  'Calculated locations for the graphics locations based on screen size
        rightInteger = Me.Width - 315                                                               '--/
        topInteger = 1                                                                              '-/
        leftInteger = 1                                                                             '/

        xMidInteger = (rightInteger + leftInteger) \ 2                                              'Calculated center location based on the 4 corners
        yMidInteger = (topInteger + bottomInteger) \ 2                                              '/

        graphicStateBoolean = CType(stateBoolean, Boolean())                                        'Reset the copy of state from the array for testing


        'Graph the Center Callibration
        If graphicStateBoolean(0) Then
            TablePictureBox.CreateGraphics.FillEllipse(puckBrush, xMidInteger, yMidInteger, 100, 100)
            Sleep(1000)
            TablePictureBox.CreateGraphics.FillEllipse(refreshBrush, xMidInteger, yMidInteger, 100, 100)
        End If


        'Graph the Top Left Callibration
        If graphicStateBoolean(1) Then
            TablePictureBox.CreateGraphics.FillEllipse(puckBrush, leftInteger, topInteger, 100, 100)
            Sleep(1000)
            TablePictureBox.CreateGraphics.FillEllipse(refreshBrush, leftInteger, topInteger, 100, 100)
        End If


        'Graph the Top Right Callibration
        If graphicStateBoolean(2) Then
            TablePictureBox.CreateGraphics.FillEllipse(puckBrush, rightInteger, topInteger, 100, 100)
            Sleep(1000)
            TablePictureBox.CreateGraphics.FillEllipse(refreshBrush, rightInteger, topInteger, 100, 100)
        End If


        'Graph the Bottom Left Callibration
        If graphicStateBoolean(3) Then
            TablePictureBox.CreateGraphics.FillEllipse(puckBrush, leftInteger, bottomInteger, 100, 100)
            Sleep(1000)
            TablePictureBox.CreateGraphics.FillEllipse(refreshBrush, leftInteger, bottomInteger, 100, 100)
        End If

        'Graph the Bottom Right Callibration
        If graphicStateBoolean(4) Then
            TablePictureBox.CreateGraphics.FillEllipse(puckBrush, rightInteger, bottomInteger, 100, 100)
            Sleep(1000)
            TablePictureBox.CreateGraphics.FillEllipse(refreshBrush, rightInteger, bottomInteger, 100, 100)
        End If

        'Graph the current location of the puck
        If graphicStateBoolean(5) Then

            callibration2 = CType(callibration, Integer())                                          'Reset the copy of state from the array for testing

            For i = 0 To 9 Step 2                                                                   'Get the X callibration values in one array
                Dim valueInteger As Integer                                                         '-----/
                Dim locationInteger As Integer                                                      '----/

                valueInteger = callibration2(i)                                                     '---/
                callibrationsx(locationInteger) = valueInteger                                      '--/
                locationInteger += 1                                                                '-/
            Next                                                                                    '/
            For i = 1 To 9 Step 2                                                                   'Get the Y callibration values in one array
                Dim valueInteger As Integer                                                         '-----/
                Dim locationInteger As Integer                                                      '----/

                valueInteger = callibration2(i)                                                     '---/
                callibrationsy(locationInteger) = valueInteger                                      '--/
                locationInteger += 1                                                                '-/
            Next                                                                                    '/

            MinMaxSub(callibrationsx, minInteger, maxInteger)                                       'Get the max and min values of the x callibration
            xScaleSingle = CSng((rightInteger - leftInteger) \ (maxInteger - minInteger))           'Set the x scaling
            xInteger = CInt(rightInteger - ((xLocationInteger - minInteger) * xScaleSingle))        'Get the x current graph location based on scaling

            MinMaxSub(callibrationsy, minInteger, maxInteger)                                       'Get the max and min values of the y callibration
            yScaleSingle = CSng((bottomInteger - topInteger) \ (maxInteger - minInteger))           'Set the y scaling
            yInteger = CInt(bottomInteger - ((yLocationInteger - minInteger) * yScaleSingle))       'Get the y current graph location based on scaling


            'Graph the current location
            TablePictureBox.CreateGraphics.FillEllipse(puckBrush, xInteger, yInteger, 100, 100)
            Sleep(1000)
            TablePictureBox.CreateGraphics.FillEllipse(refreshBrush, xInteger, yInteger, 100, 100)


            AirHockeyGraphicsSub()                                                                  'Sub to Draw the background of picture box of the goal
        End If

    End Sub



    'Sub that gets the min and the max values found in the array of data.
    Sub MinMaxSub(ByVal arry As Array, ByRef minInteger As Integer, ByRef maxInteger As Integer)

        Dim arryInteger() As Integer                                                                'Dimension of the array of all the voltages found.

        arryInteger = CType(arry, Integer())                                                        'Sets the array dimension to be equal to the arry values inserted the sub.

        minInteger = arryInteger(0)                                                                 'Gets the first location of the array.
        maxInteger = arryInteger(0)                                                                 '/

        For i As Integer = 0 To 4                                                                   'Gets all the samples from all the voltages of the array.
            If arryInteger(i) < minInteger Then minInteger = arryInteger(i)                         'Tests if the current minimum value and sees if it is lower than the minimum voltage of all previous values.
            If arryInteger(i) > maxInteger Then maxInteger = arryInteger(i)                         'Tests if the current maximum value and sees if it is higher than the maximum voltage of all previous values.
        Next                                                                                        'Goes to next array location.

        If minInteger = 1023 Then minInteger = 1022                                                 'Tests if the Minimum is the absolute maximum value. Sets it to one less of the maximum.
        If minInteger = maxInteger Then maxInteger = minInteger + 1                                 'Tests if the Maximum and the minimum are equal. Sets the maximum to be one more than.

    End Sub



    'Sub routine to display a Message box of the functionality of the program.
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Welcome to Automated Air Hokey." + vbNewLine + vbNewLine +
                "Communications with the PIXY Camera and Main Board PIC, allows for the program to receive data and to calcuate how to move motors." +
                " This also displays the score and the location of the puck on the board." + vbNewLine + vbNewLine +
                "Click one of the callibration checkboxes to manually set the center callibration or do all defaults." +
                " If the center Is selected, then the rest of callibrations need to be done also." + vbNewLine + vbNewLine +
                "Click the Callibration button to save the puck location as a center/corner(s)." + vbNewLine + vbNewLine +
                "Check the MANUAL GO checkbox to bypass the program to automatically send the data to the PIC to move Motors. " +
                "This Is a SAFETY PRECAUTION for while troubleshooting. Troubleshooting Cautions are MANUAL READY, MANUAL LOCATION, Or MANUALLY GO. " + vbNewLine + vbNewLine +
                "Check the MANUAL READY to bypass the receive data from the PIC to allow for the data to be sent out to the pic, CAUTION when Not at home." + vbNewLine + vbNewLine +
                "Click the MANUAL LOCATION to send the Motors manually to the center postion of the PIXY Testing Area. " +
                "NOTE: The motor needs to be at home location of table." + vbNewLine + vbNewLine +
                "Click the MANUAL GO to send the data out, when the MANUAL Go checkbox is selected and/or if the MANUAL READY is selected. " +
                "If the data received from PIC is ready, the MANUAL READY does not need to be pressed." + vbNewLine + vbNewLine +
                "Click EXIT to leave program.")
    End Sub

End Class

