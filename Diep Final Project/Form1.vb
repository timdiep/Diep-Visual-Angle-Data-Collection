Option Strict On ' MOVE NEXTARROW FROM END OF EACH KEYDOWN TO JUST IN THE IF STATEMENTS
Option Explicit On
Public Class Form1
    Dim percentage(3) As Integer
    Dim go, norep(19) As Boolean
    Dim tim3 As New Stopwatch
    Dim timwriter As New System.IO.StreamWriter("..\..\timdata.txt", True)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label11.Text = "Participant number % 6 = " + CStr(participantid Mod 6)
        tim3.Start()
        'MessageBox.Show("breakpoint 1")
        Select Case participantid Mod 6
            Case 0 '100% 75% 50%
                percentage = {3, 2, 1}
                counterbalance = 1
            Case 1
                percentage = {1, 3, 2}
                counterbalance = 2
               '50% 100% 75%
            Case 2 '75% 50% 100%
                percentage = {2, 1, 3}
                counterbalance = 3
            Case 3 '75% 100% 50%
                percentage = {2, 3, 1}
                counterbalance = 4
            Case 4 '100% 50% 75%
                percentage = {3, 1, 2}
                counterbalance = 5
            Case 5 '50% 75% 100%
                percentage = {1, 2, 3}
                counterbalance = 6
        End Select
        nextCondition()
        nextArrow()
    End Sub

    Sub nextArrow()
        Dim count As Integer
        Dim narrow As Integer = rand.Next(0, 20)
        If Array.IndexOf(norep, False) = -1 Then
            nextCondition()
        ElseIf norep(narrow) Then
            Do While norep(narrow)
                narrow = rand.Next(0, 20)
                count += 1
                If count > 75 Then Debug.WriteLine(Array.IndexOf(norep, False))
            Loop
        End If
        Debug.WriteLine(CStr(narrow))
        norep(narrow) = True
        Select Case narrow Mod 4
            Case 0
                uparrow.ForeColor = Color.Red
            Case 1
                rightarrow.ForeColor = Color.Red
            Case 2
                downarrow.ForeColor = Color.Red
            Case 3
                leftarrow.ForeColor = Color.Red
        End Select
    End Sub

    Sub nextCondition()
        'End
        Dim i As Integer

        If percentage(0) > 0 Then
            arrowSize(percentage(0))
            percentage(0) = -1 * percentage(0)
            For i = 0 To 19
                norep(i) = False
            Next
            'nextArrow()
        ElseIf percentage(1) > 0 Then
            arrowSize(percentage(1))
            If percentage(0) = -1 Then
                score50 = tim3.ElapsedMilliseconds
            ElseIf percentage(0) = -2 Then
                score75 = tim3.ElapsedMilliseconds
            ElseIf percentage(0) = -3 Then
                score100 = tim3.ElapsedMilliseconds
            Else
                MessageBox.Show("It's broken...")
            End If
            percentage(1) = -1 * percentage(1)
            For i = 0 To 19
                norep(i) = False
            Next
            'nextArrow()
        ElseIf percentage(2) > 0 Then
            arrowSize(percentage(2))
            If percentage(1) = -1 Then
                score50 = tim3.ElapsedMilliseconds - (score100 + score50 + score75)
            ElseIf percentage(1) = -2 Then
                score75 = tim3.ElapsedMilliseconds - (score100 + score50 + score75)
            ElseIf percentage(1) = -3 Then
                score100 = tim3.ElapsedMilliseconds - (score100 + score50 + score75)
            Else
                MessageBox.Show("It's broken...")
            End If
            percentage(2) = -1 * percentage(2)
            For i = 0 To 19
                norep(i) = False
            Next
            'nextArrow()
        Else

            If percentage(2) = -1 Then
                score50 = tim3.ElapsedMilliseconds - (score100 + score50 + score75)
            ElseIf percentage(2) = -2 Then
                score75 = tim3.ElapsedMilliseconds - (score100 + score50 + score75)
            ElseIf percentage(2) = -3 Then
                score100 = tim3.ElapsedMilliseconds - (score100 + score50 + score75)
            Else
                MessageBox.Show("It's broken...")
            End If
            'writing data from here
            timwriter.WriteLine(participantid & ";" & windowsizecondition & ";" & counterbalance & ";" & score50 & ";" & score75 & ";" & score100)
            timwriter.Close()
            Thankyouscreen.Show()
            Me.Hide()
            'to here
        End If
    End Sub

    Sub arrowSize(ByVal cond As Integer)
        Select Case cond 'set arrow positions before task
            Case 3
                uparrow.Location = New Point(791, -47)
                downarrow.Location = New Point(792, 802)
                leftarrow.Location = New Point(-73, 398)
                rightarrow.Location = New Point(1616, 398)
            Case 2
                uparrow.Location = New Point(791, 89)
                downarrow.Location = New Point(792, 706)
                leftarrow.Location = New Point(167, 398)
                rightarrow.Location = New Point(1392, 398)
            Case 1
                uparrow.Location = New Point(791, 224)
                downarrow.Location = New Point(792, 571)
                leftarrow.Location = New Point(407, 398)
                rightarrow.Location = New Point(1151, 398)
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                If uparrow.ForeColor = Color.Red Then
                    uparrow.ForeColor = Color.Black
                    nextArrow()
                End If
            Case Keys.Down
                If downarrow.ForeColor = Color.Red Then
                    downarrow.ForeColor = Color.Black
                    nextArrow()
                End If
            Case Keys.Left
                If leftarrow.ForeColor = Color.Red Then
                    leftarrow.ForeColor = Color.Black
                    nextArrow()
                End If
            Case Keys.Right
                If rightarrow.ForeColor = Color.Red Then
                    rightarrow.ForeColor = Color.Black
                    nextArrow()
                End If
        End Select
    End Sub

End Class
