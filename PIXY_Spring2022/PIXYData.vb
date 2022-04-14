'Tori Gomez
'3/30/21
'Code for the PIXYCMUcam5 to get data to be sent to the PIC16LF1788.
'The PIXY will detect the puck that is illuminated in green and the striker.
'Based on the serial data sent from the PIXY, this code will read and analyze
'and tell the PIC16LF1788 on what to do in direction the puck will need to move.

Option Strict On
Option Explicit On
Imports System.IO.Ports
Imports System.Math
Imports System.Threading.Thread

Public Class PIXYData
    Dim receiveBytesPic(4) As Byte                                                                  'All the Bytes of data the PIC will send
    Dim recieveBytesPixy(15) As Byte                                                                'All the Bytes of data the PIXY will send
    Dim comPort1String As String                                                                    'Both of the Serial Ports used in the program
    Dim comPort2String As String                                                                    '/

    'Sub for when the Form loads, test and opens all of the communication ports. One for the PIXY data through the breakout board and the
    'main board from the PIC16LF1788.
    Private Sub PIXYData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetSerialPortNames()                                                                        'Sub to get all the ports being used



        PICSerialPort.PortName = comPort1String                                                     'Test if the port is the main PIC
        PICSerialPort.BaudRate = 57600                                                              'Baudrate of 57600 bits/sec
        PICSerialPort.DataBits = 8                                                                  '8 data bits
        PICSerialPort.StopBits = IO.Ports.StopBits.One                                              '1 stop bit
        PICSerialPort.Parity = IO.Ports.Parity.None                                                 'No parity bits
        PICSerialPort.Open()



        PIXYSerialPort.PortName = comPort2String                                                    'Test if the port is the PIXY
        PIXYSerialPort.BaudRate = 19200                                                             'Baudrate of 9600 bits/sec
        PIXYSerialPort.DataBits = 8                                                                 '8 data bits
        PIXYSerialPort.StopBits = IO.Ports.StopBits.One                                             '1 stop bit
        PIXYSerialPort.Parity = IO.Ports.Parity.None                                                'No parity bits
        PIXYSerialPort.Open()


        SendTimer.Enabled = True                                                                       'Enables the timer
    End Sub


    'Sub of the Exit button that closes out the program.
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        PICSerialPort.Close()                                                                       'Shut off ports when form closed
        PIXYSerialPort.Close()                                                                      '/
        Me.Close()                                                                                  'Close Program
    End Sub


    'Show all available/in-use COMM ports.
    Sub GetSerialPortNames()
        Dim comPortInteger As Integer = 1
        For Each sp As String In My.Computer.Ports.SerialPortNames
            If comPortInteger = 1 Then
                comPort1String = sp
                comPortInteger += 1
            Else
                comPort2String = sp
            End If
            ListBox1.Items.Add(sp)
        Next
    End Sub


    Function PixyRawSerial() As Boolean
        Dim PixyBoolean As Boolean = True
        Dim byte0Integer As Integer
        Dim byte1Integer As Integer
        Dim byte2Integer As Integer
        Dim byte3Integer As Integer
        Dim byte4Integer As Integer
        Dim byte5Integer As Integer
        Dim byte6Integer As Integer
        Dim byte7Integer As Integer
        Dim normObjectInteger As Integer
        Dim codeObjectInteger As Integer
        Dim checksumInteger As Integer
        Dim xInteger As Integer
        Dim yInteger As Integer

        CheckForIllegalCrossThreadCalls = False
        byte0Integer = PIXYSerialPort.ReadByte                                                    'Sets the receivedHeader to the value of the first byte sent from the PIC16F883
        normObjectInteger = byte0Integer
        byte1Integer = PIXYSerialPort.ReadByte
        normObjectInteger += byte1Integer
        If normObjectInteger = 43605 Then                                                              'If the PIXY sends the first sync bytes of 0xAA55, indicating normal object
            byte2Integer = PIXYSerialPort.ReadByte
            codeObjectInteger = byte2Integer
            byte3Integer = PIXYSerialPort.ReadByte
            codeObjectInteger += byte3Integer
            If codeObjectInteger = 43606 Then                                                           'If the PIXY sends the second sync bytes of 0xAA56, indicating color code object

                PixyBoolean = True

                byte4Integer = PIXYSerialPort.ReadByte                                                     'Receive High Byte
                checksumInteger = byte4Integer
                byte5Integer = PIXYSerialPort.ReadByte                                                     'Receive Low Byte
                checksumInteger += byte5Integer

                'adHighByteInteger = adHighByteInteger * 4                                                   'Left shift 2 places
                'adLowByteInteger = adLowByteInteger \ 64                                                    'Right shift 6 places
                'adInteger = adHighByteInteger + adLowByteInteger                                            'Add values together for total number
                'CountTextBox.Text = (CInt(adInteger).ToString)                                              '0 to 1023 count value                                                                        

            End If
        End If
        Return PixyBoolean
    End Function


    'Sub for read the serial data from the PIC16LF1788 which will send 3 bytes, receive up to 5 bytes of data in case of errors.
    Private Sub PICSerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles PICSerialPort.DataReceived
        Dim receivedHeaderInteger As Integer                                                                    'Header to verify the serial port is the PIC

        PICSerialPort.Read(receiveBytesPic, 0, 5)                                                               'Save serial
        CheckForIllegalCrossThreadCalls = False
        receivedHeaderInteger = PICSerialPort.ReadByte                                                          'Sets the receivedHeader to the values of the first byte sent from the PIC
        If Not receivedHeaderInteger = 36 Then                                                                  'Test if the correct port is selected
            PICSerialPort.PortName = comPort2String                                                             'If no header Of 0x24/$ Then re-name port
            PIXYSerialPort.PortName = comPort1String                                                            'Re-name the PIXY to the new port
        End If
    End Sub



    'Sub for read the serial data from the PIC16LF1788 which will send 14 bytes, receive up to 15 bytes of data in case of errors.
    Private Sub PIXYSerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles PIXYSerialPort.DataReceived
        PIXYSerialPort.Read(recieveBytesPixy, 0, 15)                                                            'Save serial
    End Sub

End Class