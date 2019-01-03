Public Class Form1

    Dim Data_received As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 300
        Timer1.Enabled = False

        ModuleComPortParameters.configuration_is_valid = False
        SendBtn.Enabled = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ConfigurePortBtn.Click
        ConfigurationPort.StartPosition = FormStartPosition.CenterParent
        ConfigurationPort.ShowDialog()

        If ModuleComPortParameters.configuration_is_valid = True Then
            With SerialPort1
                .PortName = ModuleComPortParameters.Port
                .BaudRate = ModuleComPortParameters.Baudrate
                .Parity = ModuleComPortParameters.Parity
            End With
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        End
    End Sub

    Private Sub OpenPort_btn_Click(sender As Object, e As EventArgs) Handles OpenPortBtn.Click
        If ModuleComPortParameters.configuration_is_valid = True Then
            If SerialPort1.IsOpen Then
                SerialPort1.Close()
                SendBtn.Enabled = False
                OpenPortBtn.Text = "Open Port"
                OpenPortBtn.BackColor = Color.LightGray
                Timer1.Enabled = False
            Else
                SerialPort1.Open()
                SendBtn.Enabled = True
                OpenPortBtn.Text = "Close Port"
                OpenPortBtn.BackColor = Color.Red
                Timer1.Enabled = True
            End If
        Else
            MsgBox("Cannot open port with an invalid configuration")
        End If
    End Sub

    Private Sub Send_Btn_Click(sender As Object, e As EventArgs) Handles SendBtn.Click
        SerialPort1.Write(SendTextBox.Text)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Data_received &= SerialPort1.ReadExisting
        If Len(Data_received) > 0 Then
            ReceiveTextBox.Text = Data_received
            HistoryTextBox.Text = TimeOfDay.ToLongTimeString + " : " + Data_received + vbNewLine + HistoryTextBox.Text
            Data_received = ""
        End If
    End Sub
End Class
