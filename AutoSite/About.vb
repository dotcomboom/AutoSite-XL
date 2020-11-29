Public Class About

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Me.Close()
    End Sub

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Version.Text = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor
        If My.Application.Info.Version.Build > 0 Then
            Version.Text &= "." & My.Application.Info.Version.Build
        End If
        If My.Application.Info.Version.Revision > 0 Then
            Version.Text &= "." & My.Application.Info.Version.Revision
        End If
        Version.Text &= " " & My.Application.Info.Description
        If Application.VisualStyleState = VisualStyles.VisualStyleState.NoneEnabled Then
            Me.BackColor = SystemColors.Control
            LicenseBox.BackColor = SystemColors.Control
            ChangelogBox.BackColor = SystemColors.Control
        End If

        Me.Font = Main.getFont()

        Sysinfo.Text = System.Environment.OSVersion.VersionString & Environment.NewLine & System.Environment.Version.ToString
        If System.Environment.Version.ToString = "4.0.30319.42000" Then
            Sysinfo.Text &= " (or later .NET)" 'microsoft decided to deprecate system.environment.version when 4.5 came out for some reason
        End If
        If Main.InspectorBtn.Enabled = True Then
            Sysinfo.Show()
        End If
    End Sub

    Private Sub GithubLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles GithubLink.LinkClicked
        Process.Start("https://github.com/dotcomboom/AutoSite")
    End Sub

    Private Sub WebsiteLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles WebsiteLink.LinkClicked
        Process.Start("https://dotcomboom.somnolescent.net/autosite")
    End Sub

    Private Sub About_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown, LicenseBox.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.NumPad5 Then
            Dim egg = "?"
            While egg.Length < 256
                egg &= "?"
            End While
            Me.Text = egg
            For Each control As Control In Me.Controls
                control.Text = egg
                For Each ctl As Control In control.Controls
                    ctl.Text = egg
                Next
            Next
        End If
    End Sub

    Private Sub Logo_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Logo.DoubleClick
        Main.InspectorBtn.Enabled = True
        Main.ColorScheme.Visible = True
        Sysinfo.Show()
    End Sub

    Private Sub Version_DoubleClick(sender As System.Object, e As MouseEventArgs) Handles Version.MouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Dim oldwtitle As String = Main.wTitle
            Main.wTitle = "AutoSite"
            Dim v = InputBox("Enter a version number to display, or leave blank")
            If v.Length > 0 Then
                Main.wTitle &= " " & v
            End If
            Main.Text = Main.Text.Replace(oldwtitle, Main.wTitle)
        End If
    End Sub
End Class