Public Class DiskHockey
    Dim leftLimit, rightLimit, playerTopLimit, playerBottomLimit, cpuTopLimit, cpuBottomLimit As Integer
    Dim pieceSize, diskSize, playerInitX, playerInitY, cpuInitX, cpuInitY, diskInitX, diskInitY As Integer
    Dim player, CPU As Piece
    Dim disk As Disk
    Dim start As Boolean
    Dim playerScore, cpuScore, offset, mouseX, mouseY As Integer

    Private Sub LoadInit()
        leftLimit = vAreaBorder1.Right
        rightLimit = vAreaBorder2.Left
        playerTopLimit = middleBorder.Bottom
        playerBottomLimit = hAreaBorder1.Top
        cpuTopLimit = hAreaBorder3.Bottom
        cpuBottomLimit = middleBorder.Top
        pieceSize = 80
        diskSize = 60
        playerInitX = (leftLimit + rightLimit) \ 2 - pieceSize \ 2
        playerInitY = hPlayerBorder.Top - pieceSize - 10
        cpuInitX = (leftLimit + rightLimit) \ 2 - pieceSize \ 2
        cpuInitY = hCpuBorder.Bottom + 10
        diskInitX = (leftLimit + rightLimit) \ 2 - diskSize \ 2
        diskInitY = middleBorder.Top + middleBorder.Height \ 2 - diskSize \ 2
        offset = 1
        playerScore = 0
        cpuScore = 0
        DoubleBuffered = True
    End Sub

    Private Sub LoadGame()
        player = New Piece(playerInitX, playerInitY, 0, 0, pieceSize, Color.Red)
        CPU = New Piece(cpuInitX, cpuInitY, 0, 0, pieceSize, Color.Blue)
        disk = New Disk(diskInitX, diskInitY, 0, 0, diskSize, Color.White)
        mouseX = -1
        mouseY = -1
        start = False
        Invalidate()
    End Sub

    Private Sub DiskHockey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInit()
        LoadGame()
        CenterToScreen()
    End Sub

    Private Sub DiskHockey_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim g As Graphics = e.Graphics
        g.FillEllipse(New SolidBrush(CPU.color), CPU.x, CPU.y, CPU.size, CPU.size)
        g.FillEllipse(New SolidBrush(player.color), player.x, player.y, player.size, player.size)
        g.FillEllipse(New SolidBrush(disk.color), disk.x, disk.y, disk.size, disk.size)
    End Sub

    Private Sub DiskHockey_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Dim mouseRect As Rectangle = New Rectangle(e.X, e.Y, offset, offset)
        Dim playerRect As Rectangle = New Rectangle(player.x, player.y, player.size, player.size)
        If mouseRect.IntersectsWith(playerRect) Then
            mouseX = e.X
            mouseY = e.Y
        End If
    End Sub

    Private Function Transformize(value As Integer)
        If value = 0 Then
            Return 0
        End If
        Return 10 * value \ Math.Abs(value)
    End Function

    Private Sub DiskHockey_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If mouseX <> -1 And mouseY <> -1 Then
            Dim playerRect As Rectangle = New Rectangle(player.x, player.y, player.size, player.size)
            Dim diskRect As Rectangle = New Rectangle(disk.x, disk.y, disk.size, disk.size)
            player.x = Math.Max(leftLimit, Math.Min(e.X - player.size / 2, rightLimit - player.size))
            player.y = Math.Max(playerTopLimit, Math.Min(e.Y - player.size / 2, playerBottomLimit - player.size))
            Invalidate()
            player.dx = Transformize(player.x - mouseX)
            player.dy = Transformize(player.y - mouseY)
            playerRect.Inflate(offset, offset)
            diskRect.Inflate(offset, offset)
            If playerRect.IntersectsWith(diskRect) Then
                start = True
            End If
        End If
    End Sub

    Private Sub DiskHockey_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If mouseX <> -1 And mouseY <> -1 Then
            mouseX = -1
            mouseY = -1
        End If
    End Sub

    Private Sub cpuAiMove()
        CPU.dx = Transformize(disk.x - CPU.x)
        CPU.dy = Transformize(disk.y - CPU.y)
        CPU.x = Math.Max(leftLimit, Math.Min(CPU.x + CPU.dx, rightLimit - CPU.size))
        CPU.y = Math.Max(cpuTopLimit, Math.Min(CPU.y + CPU.dy, cpuBottomLimit - CPU.size))
    End Sub

    Private Sub cpuMoveTimer_tick(sender As Object, e As EventArgs) Handles cpuMoveTimer.Tick
        If start Then
            Dim cpuRect = New Rectangle(CPU.x, CPU.y, CPU.size, CPU.size)
            Dim diskRect = New Rectangle(disk.x, disk.y, disk.size, disk.size)
            cpuAiMove()
            Invalidate()
            If GameOverStatus(disk) = 1 Then
                start = False
                Dim result As DialogResult = MessageBox.Show("CPU wins!" & ControlChars.NewLine & "Play again?", "Game Over", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    LoadGame()
                ElseIf result = DialogResult.No Then
                    Close()
                End If
            ElseIf GameOverStatus(disk) = -1 Then
                start = False
                Dim result As DialogResult = MessageBox.Show("You win!" & ControlChars.NewLine & "Play again?", "Game Over", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    LoadGame()
                ElseIf result = DialogResult.No Then
                    Close()
                End If
            End If
        End If
    End Sub

    Private Function GameOverStatus(disk As Disk)
        If start Then
            Dim upperHalfDiskRect As Rectangle = New Rectangle(disk.x, disk.y, disk.size, disk.size \ 2)
            Dim bottomHalfDiskRect As Rectangle = New Rectangle(disk.x, disk.y + disk.size \ 2, disk.size, disk.size \ 2)
            Dim cpuGoal As Rectangle = New Rectangle(vCpuBorder1.Right, vCpuBorder1.Top, vCpuBorder2.Left - vCpuBorder1.Right + 1, vCpuBorder2.Bottom - vCpuBorder1.Top + 1)
            Dim playerGoal As Rectangle = New Rectangle(vPlayerBorder1.Right, vPlayerBorder1.Top, vPlayerBorder2.Left - vPlayerBorder1.Right + 1, vPlayerBorder2.Bottom - vPlayerBorder1.Top + 1)
            If playerGoal.Contains(bottomHalfDiskRect) Then
                Return 1
            ElseIf cpuGoal.Contains(upperHalfDiskRect) Then
                Return -1
            End If
        End If
        Return 0
    End Function

    Private Sub diskMoveTimer_tick(sender As Object, e As EventArgs) Handles diskMoveTimer.Tick
        If start Then
            Dim diskRect = New Rectangle(disk.x, disk.y, disk.size, disk.size)
            Dim cpuRect = New Rectangle(CPU.x, CPU.y, CPU.size, CPU.size)
            Dim playerRect As Rectangle = New Rectangle(player.x, player.y, player.size, player.size)
            diskRect.Inflate(offset, offset)
            cpuRect.Inflate(offset, offset)
            playerRect.Inflate(offset, offset)
            If diskRect.IntersectsWith(cpuRect) Then
                disk.dx = Transformize(CPU.dx)
                disk.dy = Transformize(CPU.dy)
            ElseIf diskRect.IntersectsWith(playerRect) Then
                disk.dx = Transformize(player.dx)
                disk.dy = Transformize(player.dy)
            End If
            If disk.x < leftLimit Then
                disk.dx = Transformize(Math.Abs(disk.dx))
            End If
            If disk.x + disk.size > rightLimit Then
                disk.dx = Transformize(-Math.Abs(disk.dx))
            End If
            If disk.y < cpuTopLimit Then
                disk.dy = Transformize(Math.Abs(disk.dy))
            End If
            If disk.y + disk.size > playerBottomLimit Then
                disk.dy = Transformize(-Math.Abs(disk.dy))
            End If
            disk.x += disk.dx
            disk.y += disk.dy
            Invalidate()
            If GameOverStatus(disk) = -1 Then
                playerScore += 1
                playerScoreLbl.Text = playerScore
                start = False
                Dim result As DialogResult = MessageBox.Show("You win!" & ControlChars.NewLine & "Play again?", "Game Over", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    LoadGame()
                ElseIf result = DialogResult.No Then
                    Close()
                End If
            ElseIf GameOverStatus(disk) = 1 Then
                cpuScore += 1
                cpuScoreLbl.Text = cpuScore
                start = False
                Dim result As DialogResult = MessageBox.Show("CPU wins!" & ControlChars.NewLine & "Play again?", "Game Over", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    LoadGame()
                ElseIf result = DialogResult.No Then
                    Close()
                End If
            End If
        End If
    End Sub

    Private Sub quitBtn_Click(sender As Object, e As EventArgs) Handles quitBtn.Click
        Close()
    End Sub
End Class