Public Class Form1
    Dim winding As Integer = False
    Dim DONTINTERRUPT As Integer = False
    Dim SafeToClose As Boolean = False
    Shared rand As New Random()

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If SafeToClose = False Then
            e.Cancel = True
            My.Computer.Audio.Play(My.Resources.Pistoph, AudioPlayMode.Background)
            Timer1.Interval = 500
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        winding = True
        Timer1.Enabled = True
        If DONTINTERRUPT = False Then
            Do Until winding = False
                PictureBox1.Image = My.Resources._274
                If DONTINTERRUPT = False Then
                    My.Computer.Audio.Play(My.Resources.windup2, AudioPlayMode.Background)
                End If
                If ProgressBar1.Value < 21 Then
                    ProgressBar1.Value = ProgressBar1.Value + 1
                    If ProgressBar1.Value = 21 Then
                        PictureBox2.Image = My.Resources._546
                    ElseIf ProgressBar1.Value = 20 Then
                        PictureBox2.Image = My.Resources._545
                    ElseIf ProgressBar1.Value = 19 Then
                        PictureBox2.Image = My.Resources._544
                    ElseIf ProgressBar1.Value = 18 Then
                        PictureBox2.Image = My.Resources._543
                    ElseIf ProgressBar1.Value = 17 Then
                        PictureBox2.Image = My.Resources._542
                    ElseIf ProgressBar1.Value = 16 Then
                        PictureBox2.Image = My.Resources._541
                    ElseIf ProgressBar1.Value = 15 Then
                        PictureBox2.Image = My.Resources._540
                    ElseIf ProgressBar1.Value = 14 Then
                        PictureBox2.Image = My.Resources._539
                    ElseIf ProgressBar1.Value = 13 Then
                        PictureBox2.Image = My.Resources._538
                    ElseIf ProgressBar1.Value = 12 Then
                        PictureBox2.Image = My.Resources._537
                    ElseIf ProgressBar1.Value = 11 Then
                        PictureBox2.Image = My.Resources._536
                    ElseIf ProgressBar1.Value = 10 Then
                        PictureBox2.Image = My.Resources._535
                    ElseIf ProgressBar1.Value = 9 Then
                        PictureBox2.Image = My.Resources._534
                    ElseIf ProgressBar1.Value = 8 Then
                        PictureBox2.Image = My.Resources._533
                    ElseIf ProgressBar1.Value = 7 Then
                        PictureBox2.Image = My.Resources._532
                    ElseIf ProgressBar1.Value = 6 Then
                        PictureBox2.Image = My.Resources._531
                    ElseIf ProgressBar1.Value = 5 Then
                        PictureBox2.Image = My.Resources._530
                    ElseIf ProgressBar1.Value = 4 Then
                        PictureBox2.Image = My.Resources._529
                    ElseIf ProgressBar1.Value = 3 Then
                        PictureBox2.Image = My.Resources._528
                    ElseIf ProgressBar1.Value = 2 Then
                        PictureBox2.Image = My.Resources._527
                    ElseIf ProgressBar1.Value = 1 Then
                        PictureBox2.Image = My.Resources._526
                    End If
                End If
                My.Application.DoEvents()
                Threading.Thread.Sleep(250)
            Loop
        End If
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        winding = False
        PictureBox1.Image = My.Resources._252
        My.Computer.Audio.Stop()
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        winding = False
        PictureBox1.Image = My.Resources._252
        My.Computer.Audio.Stop()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value > 1 Then
            ProgressBar1.Value = ProgressBar1.Value - 1
            If ProgressBar1.Value = 21 Then
                PictureBox2.Image = My.Resources._546
            ElseIf ProgressBar1.Value = 20 Then
                PictureBox2.Image = My.Resources._545
            ElseIf ProgressBar1.Value = 19 Then
                PictureBox2.Image = My.Resources._544
            ElseIf ProgressBar1.Value = 18 Then
                PictureBox2.Image = My.Resources._543
            ElseIf ProgressBar1.Value = 17 Then
                PictureBox2.Image = My.Resources._542
            ElseIf ProgressBar1.Value = 16 Then
                PictureBox2.Image = My.Resources._541
            ElseIf ProgressBar1.Value = 15 Then
                PictureBox2.Image = My.Resources._540
            ElseIf ProgressBar1.Value = 14 Then
                PictureBox2.Image = My.Resources._539
            ElseIf ProgressBar1.Value = 13 Then
                PictureBox2.Image = My.Resources._538
            ElseIf ProgressBar1.Value = 12 Then
                PictureBox2.Image = My.Resources._537
            ElseIf ProgressBar1.Value = 11 Then
                PictureBox2.Image = My.Resources._536
            ElseIf ProgressBar1.Value = 10 Then
                PictureBox2.Image = My.Resources._535
            ElseIf ProgressBar1.Value = 9 Then
                PictureBox2.Image = My.Resources._534
            ElseIf ProgressBar1.Value = 8 Then
                PictureBox2.Image = My.Resources._533
            ElseIf ProgressBar1.Value = 7 Then
                PictureBox2.Image = My.Resources._532
            ElseIf ProgressBar1.Value = 6 Then
                PictureBox2.Image = My.Resources._531
            ElseIf ProgressBar1.Value = 5 Then
                PictureBox2.Image = My.Resources._530
            ElseIf ProgressBar1.Value = 4 Then
                PictureBox2.Image = My.Resources._529
            ElseIf ProgressBar1.Value = 3 Then
                PictureBox2.Image = My.Resources._528
            ElseIf ProgressBar1.Value = 2 Then
                PictureBox2.Image = My.Resources._527
            ElseIf ProgressBar1.Value = 1 Then
                PictureBox2.Image = My.Resources._526
            End If
        Else
            Timer1.Enabled = False
            DONTINTERRUPT = True
            My.Computer.Audio.Play(My.Resources.jackinthebox, AudioPlayMode.BackgroundLoop)
            My.Application.DoEvents()
            Dim randomtime As Integer = rand.Next(5000, 60000)
            Threading.Thread.Sleep(randomtime)
            Form2.Show()
        End If
        ' You are motherfucker asshole
        ' '             ,eUDNUUeeU             
        '            +UXb1,      ^1bNe,             
        '         1X+                 ,Ub,         
        '      ,b9,                      +U^       
        '     uN,                          +U,     
        '   +U,                              e4   
        '  1b                           +e1^  +n   
        ' 1b                         ,UX1      16  
        ',b  ,1uu^                 ,Ub  ^1      e7 
        'u1     1^1Nu,            uXHHe  +       4 
        'b     ,1  eHXHU^     +,uXHHDHu  +       e1
        '4     ,1  uHHDHUee^    e^NHHN, ++       +V
        'u      1^ ,NHHN^1       1+   +1,         N
        '+       ,e1  ^u+                         N
        'u                               sU^++    N
        'b                          ,1be  + 1    +4
        'b^                 ,1ss1b+  +s  +beu,   b=
        '1b             e,  1    +   sb1, 1 +s  +w 
        'b1           1+  ^1 sssu1^ +1   4b,  ,U: 
        '  b+          +1+ ++    s   +bee,     9^  
        '   4+         1   ++  ^ee+          ,A|   
        '    eu        1 ,uu,               +g-    
        '      uu                         +g,      
        '        1U^                   ,bA:        
        '          ,uU1             ^bw|           
        '              ,sbUUUUUUNUe^               
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
        If DONTINTERRUPT = False Then
            SafeToClose = True
            Me.Hide()
            My.Computer.Audio.Play(My.Resources._6AM, AudioPlayMode.WaitToComplete)
            Me.Close()
        End If

    End Sub
End Class
