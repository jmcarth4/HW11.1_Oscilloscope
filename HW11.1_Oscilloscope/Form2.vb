'Jessica McArthur
'RCET 3371
'1 November 2023
'HW 11.1 Oscilloscope - form 2
Public Class Form2
    Dim portState As Boolean                    'Enables serial communication
    Dim drivePath As String                     'Path to file
    Dim fileName As String                      'Names file
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        drivePath = CurDir()
        fileName = drivePath & "\ScopeSettings.txt"             'File found in debug folder of project

        BaudRateComboBox.Items.Clear()                          'Clear list box and load baud rate values
        BaudRateComboBox.Items.Add(1200)
        BaudRateComboBox.Items.Add(2400)
        BaudRateComboBox.Items.Add(4800)
        BaudRateComboBox.Items.Add(9600)
        BaudRateComboBox.Items.Add(19200)
        BaudRateComboBox.Items.Add(38400)
        BaudRateComboBox.Items.Add(57600)
        BaudRateComboBox.Items.Add(115200)
        BaudRateComboBox.Items.Add(230400)
        BaudRateComboBox.Items.Add(230400)
        BaudRateComboBox.Items.Add(460800)
        BaudRateComboBox.Items.Add(921600)


        ComPortComboBox.Items.Clear()                                    'Clears past com ports
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComPortComboBox.Items.Add(sp)                                'Loads all current com ports to list box
        Next
        Try
            SerialPort1.Close()                             'Try to close port before change
        Catch ex As Exception

        End Try

    End Sub

    'Selects com port when selected in combo box
    Private Sub ComPortComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComPortComboBox.SelectedIndexChanged
        ReadComPorts()
    End Sub

    'Sets com port and baud rate 
    Sub ReadComPorts()
        portState = False
        Try
            SerialPort1.BaudRate = ComPortComboBox.SelectedItem 'See if baud rate data is in the list box
        Catch ex As Exception
            SerialPort1.PortName = ComPortComboBox.SelectedItem 'Bot baud rate, save port name
        End Try
    End Sub

    'Selects baud rate when selected in combo box
    Private Sub BaudRateComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BaudRateComboBox.SelectedIndexChanged
        ReadComPorts()
    End Sub

    'Saves set values to file
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            FileOpen(1, fileName, OpenMode.Output)                 'Open file for write
        Catch ex As Exception

        End Try

        WriteLine(1, ComPortComboBox.SelectedItem, BaudRateComboBox.SelectedItem) 'Write file
        FileClose(1)                                                'Closes file
    End Sub

    'Closes form 2
    Private Sub HideButton_Click(sender As Object, e As EventArgs) Handles HideButton.Click
        Me.Hide()
    End Sub
End Class