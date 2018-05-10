Public Class Main
    Private Sub browseBtn_Click(sender As Object, e As EventArgs) Handles browseBtn.Click
        Dim fbd As FolderBrowserDialog
        fbd = New FolderBrowserDialog
        If fbd.ShowDialog = DialogResult.OK Then

            srcTx.Text = fbd.SelectedPath
            Data.src = fbd.SelectedPath

        End If
    End Sub

    Private Sub createControllerBtn_Click(sender As Object, e As EventArgs) Handles createControllerBtn.Click
        Dim d1 As Dialog1
        d1 = New Dialog1
        d1.Show()
    End Sub
End Class
