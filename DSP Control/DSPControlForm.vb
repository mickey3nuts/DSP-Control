Imports System.IO

Public Class DSPControlForm

    Dim AshitaPath As String = "C:\temp\AshitaPath.txt"
    Dim DSPPath As String = "C:\temp\DSPPath.txt"

    Private Sub DSPControlForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not File.Exists(DSPPath) Then
            Dim DSPStream As FileStream
            DSPStream = File.Create(DSPPath)
            DSPStream.Close()
        End If
        If Not File.Exists(AshitaPath) Then
            Dim AshitaStream As FileStream
            AshitaStream = File.Create(AshitaPath)
            AshitaStream.Close()
        End If
    End Sub

    Private Sub DSPControlForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub ViewDirectoryPathToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewDirectoryPathToolStripMenuItem.Click
        'Note 9
        PathLocations.Activate()
        PathLocations.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.Activate()
        AboutBox.Show()
    End Sub

    Private Sub LaunchAshitaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaunchAshitaToolStripMenuItem.Click
        Dim proc As New ProcessStartInfo()
        Dim AshitaRunningVerification() As Process
        If TextBox2.Text = Nothing Then
            Dim AshitaReader As New StreamReader(AshitaPath, False)
            TextBox2.Text = AshitaReader.ReadToEnd
            AshitaReader.Close()
        End If
        If String.IsNullOrEmpty(TextBox2.Text) Then
            MsgBox("You need to declare Ashita's path", vbExclamation)
        Else
            AshitaRunningVerification = Process.GetProcessesByName("Ashita")
            If AshitaRunningVerification.Count > 0 Then
                MsgBox("Ashita is already running", vbExclamation)
            Else
                proc.WorkingDirectory = TextBox2.Text
                proc.FileName = "Ashita.exe"
                Process.Start(proc)
            End If
        End If
    End Sub

    Private Sub StartServer_Click(sender As Object, e As EventArgs) Handles StartServer.Click
        Dim proc As New ProcessStartInfo()
        'Note 2
        'Note 3
        Dim prochide As New ProcessStartInfo()
        prochide.WindowStyle = ProcessWindowStyle.Hidden
        Dim ServerRunningVerification() As Process
        'Note 4
        If TextBox1.Text = Nothing Then
            Dim DSPReader As New StreamReader(DSPPath, False)
            TextBox1.Text = DSPReader.ReadToEnd
            DSPReader.Close()
        End If
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MsgBox("You need to declare the DSP path", vbExclamation)
        Else
            'Note 5
            ServerRunningVerification = Process.GetProcessesByName("DSConnect-server")
            If ServerRunningVerification.Count > 0 Then
                MsgBox("The server is already running", vbExclamation)
            Else
                If ViewServerConsolesToolStripMenuItem.CheckState = 1 Then
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
        StartServer_Click(sender, e)
    End Sub

End Class
