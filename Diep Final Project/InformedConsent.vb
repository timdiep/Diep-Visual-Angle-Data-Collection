Public Class InformedConsent
    Private Sub InformedConsent_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label1.Text = "You are being asked to participate in an experiment exploring the effect of window visual angle on task performance. This experiment is being conducted by a student from a Computer Applications course (Psychology 418/518/ Fall 2015), under the supervision of Dr. Thomas Strybel from the Psychology Department at California State University Long Beach as part of the class requirements.  The principal researcher is Timothy Diep. The purpose of the study is to examine whether stimulus field of vision percentage will affect task performance when controlling for window visual angle, regardless of objective window size. If you volunteer to participate in this study, you will be asked to perform a reaction time task using the arrow keys on your computer's keyboard.  The risks of possible fatigue, eye strain, or headaches are not greater than those ordinarily encountered in daily life (e.g., reading materials, listening to music, or playing a game on a computer). Any information that is obtained in connection with this study and that can be identified with you will remain confidential and will be disclosed only with your permission or as required by law. 

You may withdraw from this experiment at any time without consequences. You may also refuse to answer any questions you do not want to answer and still remain in the study.  

If you have any questions, comments or concerns, you may contact Dr. Strybel at 562-985-5035, thomas.strybel@csulb.edu.

By clicking on the Accept Button below, you certify that you are at least 18 years of age, understand the procedures and conditions of your participation described above, and agree to participate in this study."
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub DeclineButton_Click(sender As Object, e As EventArgs) Handles DeclineButton.Click
        End
    End Sub

    Private Sub AcceptButton_Click(sender As Object, e As EventArgs) Handles AcceptButton.Click
        Instructions.Show()
        Me.Hide()
    End Sub
End Class