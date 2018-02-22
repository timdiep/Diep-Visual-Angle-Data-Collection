Public Class Instructions
    Private Sub Instructions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Four arrows will appear, one pointing in each direction, corresponding with the four arrow keys.
                        When one of the arrows turns red, press the corresponding arrow key as fast as possible. If the arrow does not immediately change, press it again until it does change. 
                        Your reaction time will be recorded. When you are ready, click on button. The arrows at the bottom of the page will then turn red. 
                        When you push down on the corresponding arrow keys, the arrows will disappear, and
                        the experiment will start when all four arrows are no longer visible."
        rightarrow.Text = CStr(Chr(224))
        downarrow.Text = CStr(Chr(226))
        uparrow.Text = CStr(Chr(225))
        leftarrow.Text = CStr(Chr(223))
        leftarrow.Enabled = False
        rightarrow.Enabled = False
        uparrow.Enabled = False
        downarrow.Enabled = False
        leftarrow.Visible = False
        rightarrow.Visible = False
        uparrow.Visible = False
        downarrow.Visible = False
        participantid = IO.File.ReadAllLines("..\..\timdata.txt").Length + 1
        windowsizecondition = (CInt(Math.Floor(CDbl(participantid) / 6)) Mod 2) + 1
        Label3.Text = "Please sit " & windowsizecondition & " feet away from the screen."
    End Sub

    Private Sub endbutton_Click(sender As Object, e As EventArgs) Handles endbutton.Click
        End
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 127 Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
        Else
            If ((Asc(e.KeyChar)) >= 48) And ((Asc(e.KeyChar)) <= 57) And TextBox1.Text.Length = 2 Then
                TextBox1.Enabled = False
                participantid = CInt(TextBox1.Text)
                leftarrow.Enabled = True
                rightarrow.Enabled = True
                uparrow.Enabled = True
                downarrow.Enabled = True
                leftarrow.Visible = True
                rightarrow.Visible = True
                uparrow.Visible = True
                downarrow.Visible = True

            End If
        End If
    End Sub

    Private Sub Instructions_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Left
                If leftarrow.Enabled Then
                    leftarrow.Enabled = False
                    leftarrow.Visible = False
                    If leftarrow.Enabled = False And rightarrow.Enabled = False And uparrow.Enabled = False And downarrow.Enabled = False Then
                        nextform()
                    End If
                End If
            Case Keys.Up
                If uparrow.Enabled Then
                    uparrow.Enabled = False
                    uparrow.Visible = False
                    If leftarrow.Enabled = False And rightarrow.Enabled = False And uparrow.Enabled = False And downarrow.Enabled = False Then
                        nextform()
                    End If
                End If
            Case Keys.Down
                If downarrow.Enabled Then
                    downarrow.Enabled = False
                    downarrow.Visible = False
                    If leftarrow.Enabled = False And rightarrow.Enabled = False And uparrow.Enabled = False And downarrow.Enabled = False Then
                        nextform()
                    End If
                End If
            Case Keys.Right
                If rightarrow.Enabled Then
                    rightarrow.Enabled = False
                    rightarrow.Visible = False
                    If leftarrow.Enabled = False And rightarrow.Enabled = False And uparrow.Enabled = False And downarrow.Enabled = False Then
                        nextform()
                    End If
                End If
        End Select
    End Sub

    Sub nextform()


        ' If windowsizecondition = 1 Then
        'Form1.Show()
        'Me.Hide()
        'ElseIf windowsizecondition = 2 Then
        'Form2.show()
        'Me.Hide()
        'Else
        'MessageBox.Show("something went wrong... contact Tim")
        'End
        'End If
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        Select Case e.KeyCode
            Case Keys.Left
                MessageBox.Show("left")
            Case Keys.Up
                MessageBox.Show("up")
            Case Keys.Down
                MessageBox.Show("down")
            Case Keys.Right
                MessageBox.Show("right")
        End Select
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Button1.Visible = False
        leftarrow.Enabled = True
        rightarrow.Enabled = True
        uparrow.Enabled = True
        downarrow.Enabled = True
        leftarrow.Visible = True
        rightarrow.Visible = True
        uparrow.Visible = True
        downarrow.Visible = True
    End Sub
End Class