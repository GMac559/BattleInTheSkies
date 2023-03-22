Public Class Game
    Dim PlayerRight As Boolean
    Dim PlayerLeft As Boolean
    Dim PlayerSpeed As Integer
    Dim MissileSpeed As Integer
    Dim EnemySpeed As Integer
    Dim EnemyApproach As Integer
    Const NumberEnemies As Integer = 25
    Dim EnemyRight(NumberEnemies) As Boolean
    Dim Enemies(NumberEnemies) As PictureBox
    Dim x As Integer
    Dim Killed As Integer
    Private Sub TimerMain_Tick(sender As Object, e As EventArgs) Handles TimerMain.Tick
        MovePlayer()
        ShootMissile()
        MoveEnemy()
        CheckIfHit()
        CheckIfGameEnd()
    End Sub
    Private Sub Start_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Right Then
            PlayerRight = True
            PlayerLeft = False
        End If
        If e.KeyValue = Keys.Left Then
            PlayerLeft = True
            PlayerRight = False
        End If
        If e.KeyValue = Keys.Space And Missile.Visible = False Then
            Missile.Top = Player.Top
            Missile.Left = Player.Left + (Player.Width / 2) - (Missile.Width / 2)
            Missile.Visible = True
        End If
    End Sub
    Private Sub MovePlayer()
        If PlayerRight = True And Player.Left + Player.Width < Me.ClientRectangle.Width Then
            Player.Left += PlayerSpeed
        End If
        If PlayerLeft = True And Player.Left > Me.ClientRectangle.Left Then
            Player.Left -= PlayerSpeed
        End If
    End Sub
    Private Sub Start_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = Keys.Right Then
            PlayerRight = False
        End If
        If e.KeyValue = Keys.Left Then
            PlayerLeft = False
        End If
    End Sub
    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Missile.SizeMode = PictureBoxSizeMode.Zoom
        Player.SizeMode = PictureBoxSizeMode.Zoom
        Settings()
        EnemiesLoad()
    End Sub
    Private Sub Settings()
        MissileSpeed = 15
        PlayerSpeed = 7
        Missile.Visible = False
        For Me.x = 1 To NumberEnemies
            EnemyRight(x) = True
        Next
        EnemySpeed = 8
        EnemyApproach = 55
    End Sub
    Private Sub ShootMissile()
        If Missile.Visible = True Then
            Missile.Top -= MissileSpeed
        End If

        If Missile.Top + Missile.Height < Me.ClientRectangle.Top Then
            Missile.Visible = False
        End If
    End Sub
    Private Sub MoveEnemy()
        For Me.x = 1 To NumberEnemies
            If EnemyRight(x) = True Then
                Enemies(x).Left += EnemySpeed
            Else
                Enemies(x).Left -= EnemySpeed
            End If

            If Enemies(x).Left + Enemies(x).Width > Me.ClientRectangle.Width And EnemyRight(x) = True Then
                EnemyRight(x) = False
                Enemies(x).Top += EnemyApproach
            End If

            If Enemies(x).Left < Me.ClientRectangle.Left And EnemyRight(x) = False Then
                EnemyRight(x) = True
                Enemies(x).Top += EnemyApproach
            End If
        Next
    End Sub
    Private Sub CheckIfGameEnd()
        For Me.x = 1 To NumberEnemies
            If Enemies(x).Top + Enemies(x).Height >= Player.Top And Enemies(x).Visible = True Then
                TimerMain.Enabled = False
                Me.x = NumberEnemies
                Me.Close()
                LoseScreen.Show()
            End If
        Next
        If Killed = NumberEnemies Then
            TimerMain.Enabled = False
            Me.Close()
            WinScreen.Show()
        End If
    End Sub
    Private Sub CheckIfHit()
        For Me.x = 1 To NumberEnemies
            If (Missile.Top + Missile.Height >= Enemies(x).Top) And (Missile.Top <= Enemies(x).Top + Enemies(x).Height) And (Missile.Left + Missile.Width >= Enemies(x).Left) And (Missile.Left <= Enemies(x).Left + Enemies(x).Width) And Missile.Visible = True And Enemies(x).Visible = True Then
                Enemies(x).Visible = False
                Missile.Visible = False
                Killed += 1
            End If
        Next
    End Sub
    Private Sub EnemiesLoad()
        For Me.x = 1 To NumberEnemies
            Enemies(x) = New PictureBox
            Enemies(x).Image = My.Resources.badguy
            Enemies(x).SizeMode = PictureBoxSizeMode.Zoom
            Enemies(x).Width = 45
            Enemies(x).Height = 45
            Enemies(x).BackColor = Color.Transparent
            Enemies(x).Left = (-50 * x) - (x * 5)
            Controls.Add(Enemies(x))
        Next
    End Sub
End Class

