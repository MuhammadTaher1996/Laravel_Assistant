Imports System.Windows.Forms

Public Class Dialog1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles createBtn.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        Dim CMD As New Process

        CMD.StartInfo.UseShellExecute = False
        CMD.StartInfo.RedirectStandardOutput = True
        CMD.StartInfo.CreateNoWindow = False
        CMD.StartInfo.FileName = "cmd.exe"

        If resourseControllerChB.Checked Then

            CMD.StartInfo.Arguments = "/k cd\ & cd " + Main.srcTx.Text + " & php artisan make:controller " + controllerNameTx.Text + " --resource & exit"

        Else
            CMD.StartInfo.Arguments = "/k cd\ & cd " + Main.srcTx.Text + " & php artisan make:controller " + controllerNameTx.Text + " & exit"
        End If

        CMD.Start()
        Main.ResultRTB.Text = CMD.StandardOutput.ReadToEnd
        CMD.Close()

        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
