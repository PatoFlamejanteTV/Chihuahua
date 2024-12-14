Public Class Form1
    'SFXs / Music by Toby Fox, for the game UNDERTALE
    'OG Dog image can be found on (literally) any Samsung device, creator unknown

    'Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    '    My.Computer.Audio.Play(My.Resources.greaterdog, AudioPlayMode.Background)
    'End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loop when the form loads (program starts)
        My.Computer.Audio.Play(My.Resources.dogsong, AudioPlayMode.BackgroundLoop)
    End Sub
End Class
