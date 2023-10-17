

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()

    End Sub


    ' ProcessMonitor()
    Sub ProcessMonitor()
        ' GetProcessesByName(), 
        Dim processesFA() As Process = Process.GetProcessesByName("ForgedAlliance")
        Dim processesSC() As Process = Process.GetProcessesByName("SupremeCommander")
        Dim ProcessUsage As Double
        ' Found something?
        Dim myProcess() As Process
        Dim MyProcessname As String = ""

        If processesFA.Length > 0 Then
            myProcess = processesFA
            MyProcessname = "ForgedAlliance.exe"
        End If

        If processesSC.Length > 0 Then
            myProcess = processesSC
            MyProcessname = "SupremeCommander.exe"
        End If


        If myProcess IsNot Nothing Then
            ' Loop
            For cnt = 0 To myProcess.Length - 1
                ' Process is still running?
                If Not myProcess(cnt).HasExited Then

                    ProcessUsage = (myProcess(cnt).WorkingSet64 / 1024)

                    lblRAM.Text = Format(ProcessUsage, "##,##0K")

                    If ProcessUsage > 2000000 Then
                        Me.BackColor = Color.Red
                        NotifyIcon.Icon = My.Resources.red_gr_2gb

                        If GlobalVars.FirstTimeShow = True Then
                            Me.WindowState = FormWindowState.Normal
                            Me.TopMost = True
                        End If

                        GlobalVars.FirstTimeShow = False

                    Else

                        Me.BackColor = SystemColors.Control
                        Me.TopMost = False
                        LblError.BackColor = SystemColors.Control
                        LblError.Text = "Process " & MyProcessname & " found!"
                        NotifyIcon.Icon = My.Resources.blue_less_2GB
                    End If
                End If
            Next
        Else


            LblError.Text = "Process not found!"
            LblError.BackColor = Color.Red
            lblRAM.Text = "0k"

        End If ' If myProcess IsNot Nothing Then

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProcessMonitor()
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon.Visible = True
            'Me.Hide()
            'NotifyIcon1.BalloonTipText = "Hi from right system tray"
            'NotifyIcon1.ShowBalloonTip(500)
        End If
    End Sub

    Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon.DoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon.Visible = False
    End Sub

End Class
