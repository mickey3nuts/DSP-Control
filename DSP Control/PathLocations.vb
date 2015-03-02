Public Class PathLocationsListBox

    Private Sub PathLocationsListBox_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Save()
    End Sub

    Private Sub PathLocations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DSPPathTextBox.Text = My.Settings.DSPPath
    End Sub

    Private Sub PathLocations_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub DSPPathButton_Click(sender As Object, e As EventArgs) Handles DSPPathButton.Click
        Dim folderBrowser As New FolderBrowserDialog
        folderBrowser.SelectedPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        If (folderBrowser.ShowDialog() = DialogResult.OK) Then
            DSPPathTextBox.Text = folderBrowser.SelectedPath
        End If
    End Sub

    Private Sub AshitaPathButton_Click(sender As Object, e As EventArgs) Handles AshitaPathButton.Click
        Dim folderBrowser As New FolderBrowserDialog
        folderBrowser.SelectedPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        If (folderBrowser.ShowDialog() = DialogResult.OK) Then
            AshitaPathTextBox.Text = folderBrowser.SelectedPath
        End If
    End Sub

    Private Sub DSPPathTextBox_TextChanged(sender As Object, e As EventArgs) Handles DSPPathTextBox.TextChanged

    End Sub

    Private Sub AshitaPathTextBox_TextChanged(sender As Object, e As EventArgs) Handles AshitaPathTextBox.TextChanged

    End Sub
End Class