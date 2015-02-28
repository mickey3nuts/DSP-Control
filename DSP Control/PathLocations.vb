Imports System.IO
Public Class PathLocations
    'Note something reading text file from here https://gist.github.com/ryansmith94/4475463 and here https://www.youtube.com/watch?v=hxLxaHNlHQo
    Dim b As String = "C:\temp\AshitaPath.txt"
    Dim c As String = "C:\temp\DSPPath.txt"

    Private Sub PathLocations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not File.Exists(c) Then
            Dim d As FileStream
            d = File.Create(c)
            d.Close()
        End If
        If Not File.Exists(b) Then
            Dim f As FileStream
            f = File.Create(b)
            f.Close()
        End If
    End Sub

    Private Sub PathLocations_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub DSPPathButton_Click(sender As Object, e As EventArgs) Handles DSPPathButton.Click
        'Note 6
        Dim folderBrowser As New FolderBrowserDialog
        folderBrowser.SelectedPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments    'Set the default selected folder path

        If (folderBrowser.ShowDialog() = DialogResult.OK) Then
            DSPPathTextBox.Text = folderBrowser.SelectedPath
        End If
    End Sub

    Private Sub AshitaPathButton_Click(sender As Object, e As EventArgs) Handles AshitaPathButton.Click
        Dim folderBrowser As New FolderBrowserDialog
        folderBrowser.SelectedPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments    'Set the default selected folder path

        If (folderBrowser.ShowDialog() = DialogResult.OK) Then
            AshitaPathTextBox.Text = folderBrowser.SelectedPath
        End If
    End Sub

    Private Sub readFile() Handles Button1.Click
        Dim DSPReader As New StreamReader(c, False)
        Dim AshitaReader As New StreamReader(b, False)
        DSPPathTextBox.Text = DSPReader.ReadToEnd
        DSPReader.Close()
        AshitaPathTextBox.Text = AshitaReader.ReadToEnd
        AshitaReader.Close()
    End Sub

    Private Sub writeFile() Handles Button2.Click
        Dim DSPWriter As New StreamWriter(c)
        Dim AshitaWriter As New StreamWriter(b)
        DSPWriter.Write(DSPPathTextBox.Text)
        DSPWriter.Close()
        AshitaWriter.Write(AshitaPathTextBox.Text)
        AshitaWriter.Close()
    End Sub
End Class