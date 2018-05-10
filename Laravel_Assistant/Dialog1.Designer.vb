<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog1
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.createBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.controllerNameLbl = New System.Windows.Forms.Label()
        Me.controllerNameTx = New System.Windows.Forms.TextBox()
        Me.resourseControllerChB = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.createBtn, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CancelBtn, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(369, 165)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 36)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'createBtn
        '
        Me.createBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.createBtn.Location = New System.Drawing.Point(4, 4)
        Me.createBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.createBtn.Name = "createBtn"
        Me.createBtn.Size = New System.Drawing.Size(89, 28)
        Me.createBtn.TabIndex = 0
        Me.createBtn.Text = "Create"
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.Location = New System.Drawing.Point(101, 4)
        Me.CancelBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(89, 28)
        Me.CancelBtn.TabIndex = 1
        Me.CancelBtn.Text = "Cancel"
        '
        'controllerNameLbl
        '
        Me.controllerNameLbl.AutoSize = True
        Me.controllerNameLbl.Location = New System.Drawing.Point(25, 46)
        Me.controllerNameLbl.Name = "controllerNameLbl"
        Me.controllerNameLbl.Size = New System.Drawing.Size(114, 17)
        Me.controllerNameLbl.TabIndex = 1
        Me.controllerNameLbl.Text = "Controller Name:"
        '
        'controllerNameTx
        '
        Me.controllerNameTx.Location = New System.Drawing.Point(146, 46)
        Me.controllerNameTx.Name = "controllerNameTx"
        Me.controllerNameTx.Size = New System.Drawing.Size(316, 22)
        Me.controllerNameTx.TabIndex = 2
        '
        'resourseControllerChB
        '
        Me.resourseControllerChB.AutoSize = True
        Me.resourseControllerChB.Location = New System.Drawing.Point(146, 87)
        Me.resourseControllerChB.Name = "resourseControllerChB"
        Me.resourseControllerChB.Size = New System.Drawing.Size(156, 21)
        Me.resourseControllerChB.TabIndex = 3
        Me.resourseControllerChB.Text = "Resourse Controller"
        Me.resourseControllerChB.UseVisualStyleBackColor = True
        '
        'Dialog1
        '
        Me.AcceptButton = Me.createBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelBtn
        Me.ClientSize = New System.Drawing.Size(580, 216)
        Me.Controls.Add(Me.resourseControllerChB)
        Me.Controls.Add(Me.controllerNameTx)
        Me.Controls.Add(Me.controllerNameLbl)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create Controller"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents createBtn As System.Windows.Forms.Button
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents controllerNameLbl As Label
    Friend WithEvents controllerNameTx As TextBox
    Friend WithEvents resourseControllerChB As CheckBox
End Class
