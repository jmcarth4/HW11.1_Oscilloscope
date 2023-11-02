'Jessica McArthur
'RCET 3371
'1 November 2023
'HW 11.1 Oscilloscope - Form 1

Public Class Form1
    Dim portState As Boolean                    'Enables serial communication
    Dim receiveByte(18) As Byte                 'Receive Data Bytes
    Public TXdata(3) As Byte                    'Byte array to transmit data to Qy@ board
    Dim fileName As String                      'Names file
    Dim drivePath As String                     'Path to file
    Dim port As String                          'Set port name
    Dim baud As String                          'Set baud rate
    Dim vOut As String                          'Calculated voltage in for input
    Dim vInv As String                          'Inverted voltage of input
    Dim receiveCount, TransmitCount As Double
    Dim newData As Integer                       'Received data
    Dim dataIn1, dataIn2, dataIn3, dataIn4, dataIn5, dataIn6, dataIn7, dataIn8 As Integer  'Processes data in
    Public newX As Single                             'Current x value to plot
    Public newY As Single                             'Current y value to plot
    Public maxAmplidue As Integer                     'Multiples input
    Public lastX As Single                            'Former x value plotted
    Public lastY As Single                            'Former y value plotted
    Public lastGnd As Single                          'Former ground point
    Public timerloop As Integer                       'Loops time and set x value of graph
    Public width1 As Integer                          'variables to set vertical reference lines
    Public width2 As Integer
    Public width3 As Integer
    Public width4 As Integer
    Public width5 As Integer
    Public width6 As Integer
    Public width7 As Integer
    Public width8 As Integer
    Public width9 As Integer
    Dim gndHieght As Integer                            'Sets ground point
    Public vPens As Pen                                 'Sets color of drawn line as a variable

    'Draws input, erases past input and sets reference line
    Sub draw()
        Dim vScale As String

        gndHieght = 500 - GndTrackBar.Value                       'Inverts set reference point

        maxAmplidue = 200                                         'Increased input by 200
        newX = timerloop                                          'Sets newX to timer loop to plot

        If AnIn1CheckBox.Checked = False Then

        ElseIf AnIn1CheckBox.Checked = True Then

            vInv = 3.3 - vOut                                     'Inverts input
            vScale = (vInv / 3.3) * (500 / 1023)                  'Scales inut of Qy@ board to fit in picture box
            newY = (vScale * maxAmplidue) + gndHieght - (maxAmplidue / 2)    'Calculate newY value to plot
        End If

        'Draws input and erases past inputs to display on current line
        PictureBox1.CreateGraphics.DrawLine(vPens, newX + 1, 0, newX + 1, PictureBox1.Height)
        PictureBox1.CreateGraphics.DrawLine(Pens.White, lastX, lastY, newX, newY)
        If gndHieght <> lastGnd Then        'Erases former referene line when line moved by user
            PictureBox1.CreateGraphics.DrawLine(Pens.Black, 0, lastGnd, PictureBox1.Width, lastGnd)
        End If

        'Draws reference line across screen
        PictureBox1.CreateGraphics.DrawLine(Pens.Orange, 0, gndHieght, PictureBox1.Width, gndHieght)

        'Set reference variables for next time sub is used
        lastGnd = gndHieght
        lastX = newX
        lastY = newY
    End Sub

    'Draw horizontal division every 12.5 % of picture box hieght (7 markers)
    Sub HDiv()
        Dim hieght1 As Integer
        Dim hieght2 As Integer
        Dim hieght3 As Integer
        Dim hieght4 As Integer
        Dim hieght5 As Integer
        Dim hieght6 As Integer
        Dim hieght7 As Integer

        'Calculate hieght variables
        hieght1 = PictureBox1.Height * 0.125
        hieght2 = PictureBox1.Height * 0.25
        hieght3 = PictureBox1.Height * 0.375
        hieght4 = PictureBox1.Height * 0.5
        hieght5 = PictureBox1.Height * 0.625
        hieght6 = PictureBox1.Height * 0.75
        hieght7 = PictureBox1.Height * 0.875

        vPens = Pens.Blue   'Write horizontal lines in blue

        'Draw horizontal division lines
        PictureBox1.CreateGraphics.DrawLine(vPens, newX + 1, hieght1, PictureBox1.Width, hieght1)
        PictureBox1.CreateGraphics.DrawLine(vPens, newX + 1, hieght2, PictureBox1.Width, hieght2)
        PictureBox1.CreateGraphics.DrawLine(vPens, newX + 1, hieght3, PictureBox1.Width, hieght3)
        PictureBox1.CreateGraphics.DrawLine(vPens, newX + 1, hieght4, PictureBox1.Width, hieght4)
        PictureBox1.CreateGraphics.DrawLine(vPens, newX + 1, hieght5, PictureBox1.Width, hieght5)
        PictureBox1.CreateGraphics.DrawLine(vPens, newX + 1, hieght6, PictureBox1.Width, hieght6)
        PictureBox1.CreateGraphics.DrawLine(vPens, newX + 1, hieght7, PictureBox1.Width, hieght7)
    End Sub

    'Sets reference to center of picture box
    Private Sub DefaultButton_Click(sender As Object, e As EventArgs) Handles DefaultButton.Click
        GndTrackBar.Value = 338
    End Sub

    'Draws input in picture box, communicates with the Qy@ board and processes recieved data
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim dataIn As String
        Dim inPut1, inPut2, inPut3, inPut4, inPut5, inPut6, inPut7, inPut8 As Integer

        'Draws input with each timer tic
        If timerloop >= 1000 Then     'Sets timerloop back to 0, when end of picture box is reached
            draw()
            HDiv()
            timerloop = 0
            'Sets vertical reference lines
        ElseIf timerloop = width2 Or timerloop = width1 Or timerloop = width3 Or timerloop = width4 Or
            timerloop = width5 Or timerloop = width6 Or timerloop = width7 Or timerloop = width8 Or
             timerloop = width9 Then
            vPens = Pens.Blue                   'Draws vertical reference lines in blue
            draw()
            HDiv()

        ElseIf timerloop = 1 Then       'Starts with black line at beginning of picture box
            lastX = 0
            vPens = Pens.Black
            draw()
            HDiv()
        Else                            'All other times draw black line (erase form input)
            vPens = Pens.Black
            draw()
            HDiv()
        End If
        timerloop += 1                  'Increase timer loop for each tic of timer

        'Enable input from Qy@ board when check box is checked
        If AnIn1CheckBox.Checked = True Then
            'Calls functions to communicate with Qy@ board, analog input 1 when serial communication is present
            If portState = True Then
                'Transmit and receive data from Qy@ analog input 1 
                AnalogIn()
            End If
        End If



        If newData > 0 Then                             'Test newData if >0 there is information to display
            Select Case newData
                Case = 8
                    inPut8 = dataIn8
                    newData -= 1
            End Select
            Select Case newData
                Case = 7
                    inPut7 = dataIn7
                    newData -= 1
            End Select
            Select Case newData
                Case = 6
                    inPut6 = dataIn6
                    newData -= 1
            End Select
            Select Case newData
                Case = 5
                    inPut5 = dataIn5
                    newData -= 1
            End Select
            Select Case newData
                Case = 4
                    inPut4 = dataIn4
                    newData -= 1
            End Select
            Select Case newData
                Case = 3
                    inPut3 = dataIn3
                    newData -= 1
            End Select
            Select Case newData
                Case = 2
                    inPut2 = dataIn2
                    newData -= 1
            End Select
            Select Case newData
                Case = 1
                    inPut1 = dataIn1
                    newData -= 1
            End Select

        End If
    End Sub

    'Establishs communication and displays received data from Qy@ board, analog input1
    Sub AnalogIn()
        TXdata(0) = 81                          'Send command for analog input 1
        TXdata(1) = 0
        TXdata(2) = 0
        SendData()                              'Calls function to send serial data
        AnVoltage()                             'Calls function to calcuate input voltage 
        VA1Label.Text = vOut                    'Display input voltage
    End Sub

    'Converts received byte 1 and 2 to binary value (0 to 1024) and voltage (0 to 3.3)
    Sub AnVoltage()
        Dim vPort As Double             'Variables to manipulate received data
        Dim n1 As Double
        Dim n2 As Double
        Dim n3 As Double
        Dim n4 As Double

        n1 = dataIn1 * 4
        n2 = dataIn2 / 64
        n3 = Fix(n1 + n2)               'Calcuated number of bits recieved
        n4 = 3.3 / 1023
        vPort = n4 * n3
        vOut = Format(vPort, "n")       'Calculated voltage at input
    End Sub

    'Opens form 2 to set com port and baud rate of input device
    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        Form2.Show()                            'Open form 2
        Try
            SerialPort1.Close()                 'Close serial port
        Catch ex As Exception

        End Try
    End Sub


    'Loads and reads settings file
    Public Sub Load_setting()
        drivePath = CurDir()
        fileName = drivePath & "\ScopeSettings.txt"               'File found in debug folder of project
        Try
            FileOpen(1, fileName, OpenMode.Input)                 'Open file for read
        Catch ex As Exception
            MsgBox("Settings file not found, please go to settings menu") 'Alerts user if no file found
            Exit Sub
        End Try

        Input(1, port)      'Load port name
        Input(1, baud)      'Load baud rate
    End Sub

    'Button -Loads saved setting of com port and baud rate when presssed
    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        Load_setting()                                      'Reads file
        Try
            SerialPort1.Close()                             'Try to close port before change
        Catch ex As Exception

        End Try

        PortOpenButton.Text = "Connect"
        portState = False

        SerialPort1.BaudRate = baud 'See if baud rate data is in the list box
        SerialPort1.PortName = port 'Bot baud rate, save port name
    End Sub

    'Button to exit the program
    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub

    'Loads serial settings and picture box setting when loads form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clears old Com Ports
        portState = False                              'Disables serial port

        SerialPort1.BaudRate = 9600                    '9600 baud rate
        SerialPort1.DataBits = 8                       '8 data bits
        SerialPort1.StopBits = IO.Ports.StopBits.One   '1 stop bit
        SerialPort1.Parity = IO.Ports.Parity.None      'no Parity

        Timer1.Enabled = True                           'timer set to 1 ms
        AnIn1CheckBox.Checked = False                   'Input disabled

        timerloop = 1                                   'Increment timer loop

        width1 = PictureBox1.Width * 0.1                'Calulated width different veritcal placements 
        width2 = PictureBox1.Width * 0.2                'of the picture box
        width3 = PictureBox1.Width * 0.3
        width4 = PictureBox1.Width * 0.4
        width5 = PictureBox1.Width * 0.5
        width6 = PictureBox1.Width * 0.6
        width7 = PictureBox1.Width * 0.7
        width8 = PictureBox1.Width * 0.8
        width9 = PictureBox1.Width * 0.9
        GndTrackBar.Value = 338
    End Sub
    'Sends byte array to serial port
    Function SendData() As Byte
        Timer1.Enabled = False                                 'Disable timer when writing to serial port
        If portState = True Then
            SerialPort1.Write(TXdata, 0, 3)                    'Write byte array to serial port
        Else
            MsgBox("Please configure and open serial port to procede")      'Send user message box if no port connected
        End If
        Timer1.Enabled = True                                   'Enable timer when done

    End Function

    'Asynchronous Serial receive subroutine triggered by serial receive event
    Private Sub DataReceived(sender As Object, e As EventArgs) Handles SerialPort1.DataReceived
        receiveCount += 1                                           'Increment recieve byte counter
        SerialPort1.Read(receiveByte, 0, 4)                         'Read serial buffer value

        Select Case newData                                         'Test case to determine where to place info
            Case = 0

                dataIn1 = receiveByte(0)
            Case = 1
                dataIn2 = receiveByte(0)
            Case = 2
                dataIn3 = receiveByte(0)
            Case = 3
                dataIn4 = receiveByte(0)
            Case = 4
                dataIn5 = receiveByte(0)
            Case = 5
                dataIn6 = receiveByte(0)
            Case = 6
                dataIn7 = receiveByte(0)
            Case = 7
                dataIn8 = receiveByte(0)

            Case Else
                newData = 0                                             'Possible over flow, reset newData
                Exit Sub

        End Select
        newData += 1                                                    'Increment newData once loop is complete
    End Sub

    'Activates selected comport
    Private Sub PortOpenButton_Click(sender As Object, e As EventArgs) Handles PortOpenButton.Click
        'Load_setting()
        If PortOpenButton.Text = "Connect" Then                     'Com port is disconnected. Press button to connect.
            Try
                SerialPort1.Open()
                PortOpenButton.Text = "Disconnect"                  'Displays that com port is connected
                portState = True                                    'To disconnect press button again
            Catch ex As Exception
                MsgBox("Port Already Open or Port Unavailable")     'Com port is disconnected. Press button to connect.
                PortOpenButton.Text = "Connect"
                portState = False
            End Try
        Else                                                        'Com port is disconnected. Press button to connect.
            Try                                                     'Com port stays disconned until button is pressed
                SerialPort1.Close()
            Catch ex As Exception

            End Try
            portState = False
            PortOpenButton.Text = "Connect"
        End If
    End Sub

    'Closes Serial Ports when forms closes
    Private Sub Form1_UnLoad()
        Try
            SerialPort1.Close()                 'Closes serial port
        Catch ex As Exception

        End Try
    End Sub
End Class





