<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformedConsent
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DeclineButton = New System.Windows.Forms.Button()
        Me.AcceptButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1900, 800)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 1045)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "End"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DeclineButton
        '
        Me.DeclineButton.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeclineButton.Location = New System.Drawing.Point(650, 861)
        Me.DeclineButton.Name = "DeclineButton"
        Me.DeclineButton.Size = New System.Drawing.Size(300, 100)
        Me.DeclineButton.TabIndex = 2
        Me.DeclineButton.Text = "Decline"
        Me.DeclineButton.UseVisualStyleBackColor = True
        '
        'AcceptButton
        '
        Me.AcceptButton.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcceptButton.Location = New System.Drawing.Point(970, 861)
        Me.AcceptButton.Name = "AcceptButton"
        Me.AcceptButton.Size = New System.Drawing.Size(300, 100)
        Me.AcceptButton.TabIndex = 3
        Me.AcceptButton.Text = "Accept"
        Me.AcceptButton.UseVisualStyleBackColor = True
        '
        'InformedConsent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1920, 1084)
        Me.Controls.Add(Me.AcceptButton)
        Me.Controls.Add(Me.DeclineButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InformedConsent"
        Me.Text = "InformedConsent"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DeclineButton As Button
    Friend WithEvents AcceptButton As Button
End Class
