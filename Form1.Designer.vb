<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblRAM = New System.Windows.Forms.Label()
        Me.lblRamUsage = New System.Windows.Forms.Label()
        Me.TxtBeschrieb = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblError = New System.Windows.Forms.Label()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        'lblRAM
        '
        Me.lblRAM.AutoSize = True
        Me.lblRAM.Location = New System.Drawing.Point(84, 47)
        Me.lblRAM.Name = "lblRAM"
        Me.lblRAM.Size = New System.Drawing.Size(19, 13)
        Me.lblRAM.TabIndex = 1
        Me.lblRAM.Text = "0k"
        '
        'lblRamUsage
        '
        Me.lblRamUsage.AutoSize = True
        Me.lblRamUsage.Location = New System.Drawing.Point(12, 47)
        Me.lblRamUsage.Name = "lblRamUsage"
        Me.lblRamUsage.Size = New System.Drawing.Size(66, 13)
        Me.lblRamUsage.TabIndex = 3
        Me.lblRamUsage.Text = "Ram Usage:"
        '
        'TxtBeschrieb
        '
        Me.TxtBeschrieb.BackColor = System.Drawing.SystemColors.Control
        Me.TxtBeschrieb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBeschrieb.Enabled = False
        Me.TxtBeschrieb.Location = New System.Drawing.Point(12, 12)
        Me.TxtBeschrieb.Multiline = True
        Me.TxtBeschrieb.Name = "TxtBeschrieb"
        Me.TxtBeschrieb.Size = New System.Drawing.Size(130, 32)
        Me.TxtBeschrieb.TabIndex = 5
        Me.TxtBeschrieb.Text = "Show RAM usage SupremeCommander.exe"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'LblError
        '
        Me.LblError.AutoSize = True
        Me.LblError.Location = New System.Drawing.Point(12, 82)
        Me.LblError.Name = "LblError"
        Me.LblError.Size = New System.Drawing.Size(10, 13)
        Me.LblError.TabIndex = 7
        Me.LblError.Text = "."
        '
        'NotifyIcon
        '
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "NotifyIcon"
        Me.NotifyIcon.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(217, 107)
        Me.Controls.Add(Me.LblError)
        Me.Controls.Add(Me.TxtBeschrieb)
        Me.Controls.Add(Me.lblRamUsage)
        Me.Controls.Add(Me.lblRAM)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "SC_RAM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRAM As Label
    Friend WithEvents lblRamUsage As Label
    Friend WithEvents TxtBeschrieb As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LblError As Label
    Friend WithEvents NotifyIcon As NotifyIcon
End Class
