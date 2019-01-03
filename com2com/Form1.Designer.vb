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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SendTextBox = New System.Windows.Forms.RichTextBox()
        Me.ReceiveTextBox = New System.Windows.Forms.RichTextBox()
        Me.HistoryTextBox = New System.Windows.Forms.RichTextBox()
        Me.ConfigurePortBtn = New System.Windows.Forms.Button()
        Me.OpenPortBtn = New System.Windows.Forms.Button()
        Me.SendBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'SendTextBox
        '
        Me.SendTextBox.Location = New System.Drawing.Point(12, 35)
        Me.SendTextBox.Name = "SendTextBox"
        Me.SendTextBox.Size = New System.Drawing.Size(159, 144)
        Me.SendTextBox.TabIndex = 0
        Me.SendTextBox.Text = ""
        '
        'ReceiveTextBox
        '
        Me.ReceiveTextBox.Location = New System.Drawing.Point(177, 35)
        Me.ReceiveTextBox.Name = "ReceiveTextBox"
        Me.ReceiveTextBox.Size = New System.Drawing.Size(159, 144)
        Me.ReceiveTextBox.TabIndex = 1
        Me.ReceiveTextBox.Text = ""
        '
        'HistoryTextBox
        '
        Me.HistoryTextBox.Location = New System.Drawing.Point(445, 35)
        Me.HistoryTextBox.Name = "HistoryTextBox"
        Me.HistoryTextBox.Size = New System.Drawing.Size(159, 144)
        Me.HistoryTextBox.TabIndex = 2
        Me.HistoryTextBox.Text = ""
        '
        'ConfigurePortBtn
        '
        Me.ConfigurePortBtn.Location = New System.Drawing.Point(345, 45)
        Me.ConfigurePortBtn.Name = "ConfigurePortBtn"
        Me.ConfigurePortBtn.Size = New System.Drawing.Size(94, 23)
        Me.ConfigurePortBtn.TabIndex = 3
        Me.ConfigurePortBtn.Text = "Configure Port"
        Me.ConfigurePortBtn.UseVisualStyleBackColor = True
        '
        'OpenPortBtn
        '
        Me.OpenPortBtn.Location = New System.Drawing.Point(345, 74)
        Me.OpenPortBtn.Name = "OpenPortBtn"
        Me.OpenPortBtn.Size = New System.Drawing.Size(94, 23)
        Me.OpenPortBtn.TabIndex = 4
        Me.OpenPortBtn.Text = "Open Port"
        Me.OpenPortBtn.UseVisualStyleBackColor = True
        '
        'SendBtn
        '
        Me.SendBtn.Location = New System.Drawing.Point(44, 185)
        Me.SendBtn.Name = "SendBtn"
        Me.SendBtn.Size = New System.Drawing.Size(94, 23)
        Me.SendBtn.TabIndex = 5
        Me.SendBtn.Text = "Send"
        Me.SendBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(345, 185)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(94, 23)
        Me.ExitBtn.TabIndex = 6
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(465, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Communication History"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 217)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.SendBtn)
        Me.Controls.Add(Me.OpenPortBtn)
        Me.Controls.Add(Me.ConfigurePortBtn)
        Me.Controls.Add(Me.HistoryTextBox)
        Me.Controls.Add(Me.ReceiveTextBox)
        Me.Controls.Add(Me.SendTextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents SendTextBox As RichTextBox
    Friend WithEvents ReceiveTextBox As RichTextBox
    Friend WithEvents HistoryTextBox As RichTextBox
    Friend WithEvents ConfigurePortBtn As Button
    Friend WithEvents OpenPortBtn As Button
    Friend WithEvents SendBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents Label1 As Label
End Class
