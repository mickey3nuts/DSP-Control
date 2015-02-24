Public Class DSPControlForm
    'Note 1
    Dim textBoxes() As TextBox

    Private Sub DSPControlForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '' add all textbox names here whose value you want to persist.
        textBoxes = New TextBox() {TextBox1, TextBox2}

        With My.Settings
            If .TextBoxValues Is Nothing Then .TextBoxValues = New System.Collections.Specialized.StringCollection
            For i = 0 To textBoxes.Length - 1
                If .TextBoxValues.Count <= i Then .TextBoxValues.Add("")
                textBoxes(i).Text = .TextBoxValues(i)
            Next
        End With
    End Sub

    Private Sub DSPControlForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        For i = 0 To textBoxes.Length - 1
            My.Settings.TextBoxValues(i) = textBoxes(i).Text
        Next
        My.Settings.Save()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.Activate()
        AboutBox.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles StartServer.Click
        Dim proc As New ProcessStartInfo()
        'Note 2
        'Note 3
        Dim prochide As New ProcessStartInfo()
        prochide.WindowStyle = ProcessWindowStyle.Hidden
        Dim p() As Process
        'Note 4
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MsgBox("You need to declare the DSP path", vbExclamation)
        Else
            'Note 5
            p = Process.GetProcessesByName("DSConnect-server")
            If p.Count > 0 Then
                MsgBox("The server is already running", vbExclamation)
            Else
                If CheckBox1.CheckState = 1 Then
                    proc.WorkingDirectory = TextBox1.Text
                    proc.FileName = "DSConnect-server.exe"
                    Process.Start(proc)
                    proc.FileName = "DSGame-server.exe"
                    Process.Start(proc)
                    proc.FileName = "DSSearch-server.exe"
                    Process.Start(proc)
                Else
                    prochide.WorkingDirectory = TextBox1.Text
                    prochide.FileName = "DSConnect-server.exe"
                    Process.Start(prochide)
                    prochide.FileName = "DSGame-server.exe"
                    Process.Start(prochide)
                    prochide.FileName = "DSSearch-server.exe"
                    Process.Start(prochide)
                End If
            End If
        End If
    End Sub

    Private Sub DSPPath_Click(sender As Object, e As EventArgs) Handles DSPPath.Click
        'Note 6
        Dim folderBrowser As New FolderBrowserDialog
        folderBrowser.SelectedPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments    'Set the default selected folder path

        If (folderBrowser.ShowDialog() = DialogResult.OK) Then
            TextBox1.Text = folderBrowser.SelectedPath
        End If
    End Sub

    Private Sub StopServer_Click(sender As Object, e As EventArgs) Handles StopServer.Click
        'Note 7
        Dim myDSPConnectProcess() As Process = System.Diagnostics.Process.GetProcessesByName("DSConnect-server")
        Dim myDSPGameProcess() As Process = System.Diagnostics.Process.GetProcessesByName("DSGame-server")
        Dim myDSPSearchProcess() As Process = System.Diagnostics.Process.GetProcessesByName("DSSearch-server")
        For Each myKill As Process In myDSPConnectProcess
            myKill.Kill()
        Next
        For Each myKill As Process In myDSPGameProcess
            myKill.Kill()
        Next
        For Each myKill As Process In myDSPSearchProcess
            myKill.Kill()
        Next
    End Sub

    Private Sub RestartServer_Click(sender As Object, e As EventArgs) Handles RestartServer.Click
        'Note 8
        StopServer_Click(sender, e)
        Button1_Click(sender, e)
    End Sub

    Private Sub LaunchAshitaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaunchAshitaToolStripMenuItem.Click
        Dim proc As New ProcessStartInfo()
        Dim p() As Process
        If String.IsNullOrEmpty(TextBox2.Text) Then
            MsgBox("You need to declare Ashita's path", vbExclamation)
        Else
            p = Process.GetProcessesByName("Ashita")
            If p.Count > 0 Then
                MsgBox("Ashita is already running", vbExclamation)
            Else
                proc.WorkingDirectory = TextBox2.Text
                proc.FileName = "Ashita.exe"
                Process.Start(proc)
            End If
        End If
    End Sub

    Private Sub AshitaPath_Click(sender As Object, e As EventArgs) Handles AshitaPath.Click
        Dim folderBrowser As New FolderBrowserDialog
        folderBrowser.SelectedPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments    'Set the default selected folder path

        If (folderBrowser.ShowDialog() = DialogResult.OK) Then
            TextBox2.Text = folderBrowser.SelectedPath
        End If
    End Sub
End Class
