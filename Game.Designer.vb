<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game))
        Me.TimerMain = New System.Windows.Forms.Timer(Me.components)
        Me.Missile = New System.Windows.Forms.PictureBox()
        Me.Player = New System.Windows.Forms.PictureBox()
        CType(Me.Missile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerMain
        '
        Me.TimerMain.Enabled = True
        Me.TimerMain.Interval = 1
        '
        'Missile
        '
        Me.Missile.BackColor = System.Drawing.Color.Transparent
        Me.Missile.Image = Global.BattleInSkies.My.Resources.Resources.missile
        Me.Missile.Location = New System.Drawing.Point(248, 311)
        Me.Missile.Name = "Missile"
        Me.Missile.Size = New System.Drawing.Size(32, 30)
        Me.Missile.TabIndex = 1
        Me.Missile.TabStop = False
        '
        'Player
        '
        Me.Player.BackColor = System.Drawing.Color.Transparent
        Me.Player.Image = Global.BattleInSkies.My.Resources.Resources.player
        Me.Player.InitialImage = CType(resources.GetObject("Player.InitialImage"), System.Drawing.Image)
        Me.Player.Location = New System.Drawing.Point(239, 347)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(50, 33)
        Me.Player.TabIndex = 0
        Me.Player.TabStop = False
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImage = Global.BattleInSkies.My.Resources.Resources.skyback
        Me.ClientSize = New System.Drawing.Size(539, 392)
        Me.Controls.Add(Me.Missile)
        Me.Controls.Add(Me.Player)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Game"
        Me.Text = "Battle in the Sky"
        CType(Me.Missile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Player As System.Windows.Forms.PictureBox
    Friend WithEvents TimerMain As System.Windows.Forms.Timer
    Friend WithEvents Missile As System.Windows.Forms.PictureBox

End Class
