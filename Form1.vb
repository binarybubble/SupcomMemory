

Imports System.ComponentModel

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()

        Me.TopLevel = True
        Me.TopMost = True

        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)

        Me.TransparencyKey = SystemColors.Control
        Me.BackColor = SystemColors.Control


    End Sub


    ' Check for Mouse Rightclick on Form and textboxes, show contextmenu
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Right Then
            'ContextMenuStrip1.Show(Me, New Point(e.X, e.Y))
            ContextMenuStrip1.Show(MousePosition.X, MousePosition.Y)
        End If
    End Sub

    Private Sub lblramusage_click(sender As Object, e As MouseEventArgs) Handles lblRamUsage.MouseClick
        If e.Button = MouseButtons.Right Then
            'ContextMenuStrip1.Show(Me, New Point(e.X, e.Y))
            ContextMenuStrip1.Show(MousePosition.X, MousePosition.Y)
        End If
    End Sub

    Private Sub lblram_click(sender As Object, e As MouseEventArgs) Handles lblRAM.MouseClick
        If e.Button = MouseButtons.Right Then
            'ContextMenuStrip1.Show(Me, New Point(e.X, e.Y))
            ContextMenuStrip1.Show(MousePosition.X, MousePosition.Y)
        End If
    End Sub
    Private Sub NotifyIcon_click(sender As Object, e As MouseEventArgs) Handles NotifyIcon.MouseClick
        If e.Button = MouseButtons.Right Then
            ContextMenuStrip1.Show(MousePosition.X, MousePosition.Y)
        End If
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

                    If ProcessUsage > 2000000 Then ' 2000000 Then
                        Me.BackColor = Color.Red
                        Me.Opacity = 0.6
                        NotifyIcon.Icon = My.Resources.red_gr_2gb

                        'If GlobalVars.FirstTimeShow = True Then
                        'Me.WindowState = FormWindowState.Normal
                        'Me.TopMost = True
                        'End If

                        'GlobalVars.FirstTimeShow = False

                    Else

                        Me.BackColor = SystemColors.Control
                        Me.TransparencyKey = SystemColors.Control
                        'Me.TopMost = False
                        'LblError.BackColor = SystemColors.Control
                        'LblError.Text = MyProcessname & " found!"
                        NotifyIcon.Icon = My.Resources.blue_less_2GB
                    End If
                End If
            Next
        Else


            'LblError.Text = "Process not found!"
            'LblError.BackColor = Color.Red
            lblRAM.Text = "0k"

        End If ' If myProcess IsNot Nothing Then

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProcessMonitor()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        NotifyIcon.Visible = False
        Me.Close()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        NotifyIcon.Visible = False
    End Sub


End Class
