<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.srcTx = New System.Windows.Forms.TextBox()
        Me.browseBtn = New System.Windows.Forms.Button()
        Me.createControllerBtn = New System.Windows.Forms.Button()
        Me.ResultRTB = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'srcTx
        '
        Me.srcTx.Enabled = False
        Me.srcTx.Location = New System.Drawing.Point(213, 12)
        Me.srcTx.Name = "srcTx"
        Me.srcTx.Size = New System.Drawing.Size(661, 22)
        Me.srcTx.TabIndex = 1
        '
        'browseBtn
        '
        Me.browseBtn.Location = New System.Drawing.Point(132, 12)
        Me.browseBtn.Name = "browseBtn"
        Me.browseBtn.Size = New System.Drawing.Size(75, 23)
        Me.browseBtn.TabIndex = 2
        Me.browseBtn.Text = "Browse"
        Me.browseBtn.UseVisualStyleBackColor = True
        '
        'createControllerBtn
        '
        Me.createControllerBtn.Location = New System.Drawing.Point(64, 118)
        Me.createControllerBtn.Name = "createControllerBtn"
        Me.createControllerBtn.Size = New System.Drawing.Size(120, 46)
        Me.createControllerBtn.TabIndex = 3
        Me.createControllerBtn.Text = "Create new Controller"
        Me.createControllerBtn.UseVisualStyleBackColor = True
        '
        'ResultRTB
        '
        Me.ResultRTB.Location = New System.Drawing.Point(88, 224)
        Me.ResultRTB.Name = "ResultRTB"
        Me.ResultRTB.Size = New System.Drawing.Size(708, 283)
        Me.ResultRTB.TabIndex = 4
        Me.ResultRTB.Text = ""
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 680)
        Me.Controls.Add(Me.ResultRTB)
        Me.Controls.Add(Me.createControllerBtn)
        Me.Controls.Add(Me.browseBtn)
        Me.Controls.Add(Me.srcTx)
        Me.Name = "Main"
        Me.Text = "Laravel Savior - Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents srcTx As TextBox
    Friend WithEvents browseBtn As Button
    Friend WithEvents createControllerBtn As Button
    Friend WithEvents ResultRTB As RichTextBox
End Class
