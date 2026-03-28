<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DiskHockey
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        middleBorder = New Button()
        hPlayerBorder = New Button()
        vPlayerBorder1 = New Button()
        vPlayerBorder2 = New Button()
        vCpuBorder2 = New Button()
        vCpuBorder1 = New Button()
        hCpuBorder = New Button()
        hAreaBorder1 = New Button()
        vAreaBorder1 = New Button()
        hAreaBorder2 = New Button()
        vAreaBorder2 = New Button()
        hAreaBorder3 = New Button()
        hAreaBorder4 = New Button()
        vAreaBorder4 = New Button()
        vAreaBorder3 = New Button()
        playerLbl = New Label()
        cpuLbl = New Label()
        playerScoreLbl = New Label()
        cpuScoreLbl = New Label()
        quitBtn = New Button()
        cpuMoveTimer = New Timer(components)
        diskMoveTimer = New Timer(components)
        SuspendLayout()
        ' 
        ' middleBorder
        ' 
        middleBorder.BackColor = Color.Black
        middleBorder.Enabled = False
        middleBorder.FlatAppearance.BorderColor = Color.White
        middleBorder.FlatStyle = FlatStyle.Flat
        middleBorder.Location = New Point(12, 326)
        middleBorder.Name = "middleBorder"
        middleBorder.Size = New Size(619, 5)
        middleBorder.TabIndex = 0
        middleBorder.UseVisualStyleBackColor = False
        ' 
        ' hPlayerBorder
        ' 
        hPlayerBorder.BackColor = Color.Black
        hPlayerBorder.Enabled = False
        hPlayerBorder.FlatAppearance.BorderColor = Color.White
        hPlayerBorder.FlatStyle = FlatStyle.Flat
        hPlayerBorder.Location = New Point(203, 576)
        hPlayerBorder.Name = "hPlayerBorder"
        hPlayerBorder.Size = New Size(238, 10)
        hPlayerBorder.TabIndex = 1
        hPlayerBorder.UseVisualStyleBackColor = False
        ' 
        ' vPlayerBorder1
        ' 
        vPlayerBorder1.BackColor = Color.Black
        vPlayerBorder1.Enabled = False
        vPlayerBorder1.FlatAppearance.BorderColor = Color.White
        vPlayerBorder1.FlatStyle = FlatStyle.Flat
        vPlayerBorder1.Location = New Point(203, 585)
        vPlayerBorder1.Name = "vPlayerBorder1"
        vPlayerBorder1.Size = New Size(10, 60)
        vPlayerBorder1.TabIndex = 2
        vPlayerBorder1.UseVisualStyleBackColor = False
        ' 
        ' vPlayerBorder2
        ' 
        vPlayerBorder2.BackColor = Color.Black
        vPlayerBorder2.Enabled = False
        vPlayerBorder2.FlatAppearance.BorderColor = Color.White
        vPlayerBorder2.FlatStyle = FlatStyle.Flat
        vPlayerBorder2.Location = New Point(431, 585)
        vPlayerBorder2.Name = "vPlayerBorder2"
        vPlayerBorder2.Size = New Size(10, 60)
        vPlayerBorder2.TabIndex = 3
        vPlayerBorder2.UseVisualStyleBackColor = False
        ' 
        ' vCpuBorder2
        ' 
        vCpuBorder2.BackColor = Color.Black
        vCpuBorder2.Enabled = False
        vCpuBorder2.FlatAppearance.BorderColor = Color.White
        vCpuBorder2.FlatStyle = FlatStyle.Flat
        vCpuBorder2.Location = New Point(431, 11)
        vCpuBorder2.Name = "vCpuBorder2"
        vCpuBorder2.Size = New Size(10, 60)
        vCpuBorder2.TabIndex = 6
        vCpuBorder2.UseVisualStyleBackColor = False
        ' 
        ' vCpuBorder1
        ' 
        vCpuBorder1.BackColor = Color.Black
        vCpuBorder1.Enabled = False
        vCpuBorder1.FlatAppearance.BorderColor = Color.White
        vCpuBorder1.FlatStyle = FlatStyle.Flat
        vCpuBorder1.Location = New Point(203, 11)
        vCpuBorder1.Name = "vCpuBorder1"
        vCpuBorder1.Size = New Size(10, 60)
        vCpuBorder1.TabIndex = 5
        vCpuBorder1.UseVisualStyleBackColor = False
        ' 
        ' hCpuBorder
        ' 
        hCpuBorder.BackColor = Color.Black
        hCpuBorder.Enabled = False
        hCpuBorder.FlatAppearance.BorderColor = Color.White
        hCpuBorder.FlatStyle = FlatStyle.Flat
        hCpuBorder.Location = New Point(203, 71)
        hCpuBorder.Name = "hCpuBorder"
        hCpuBorder.Size = New Size(238, 10)
        hCpuBorder.TabIndex = 4
        hCpuBorder.UseVisualStyleBackColor = False
        ' 
        ' hAreaBorder1
        ' 
        hAreaBorder1.BackColor = Color.Yellow
        hAreaBorder1.Enabled = False
        hAreaBorder1.FlatAppearance.BorderColor = Color.White
        hAreaBorder1.FlatStyle = FlatStyle.Flat
        hAreaBorder1.Location = New Point(13, 644)
        hAreaBorder1.Name = "hAreaBorder1"
        hAreaBorder1.Size = New Size(200, 10)
        hAreaBorder1.TabIndex = 7
        hAreaBorder1.UseVisualStyleBackColor = False
        ' 
        ' vAreaBorder1
        ' 
        vAreaBorder1.BackColor = Color.Yellow
        vAreaBorder1.Enabled = False
        vAreaBorder1.FlatAppearance.BorderColor = Color.White
        vAreaBorder1.FlatStyle = FlatStyle.Flat
        vAreaBorder1.Location = New Point(3, 331)
        vAreaBorder1.Name = "vAreaBorder1"
        vAreaBorder1.Size = New Size(10, 313)
        vAreaBorder1.TabIndex = 8
        vAreaBorder1.UseVisualStyleBackColor = False
        ' 
        ' hAreaBorder2
        ' 
        hAreaBorder2.BackColor = Color.Red
        hAreaBorder2.Enabled = False
        hAreaBorder2.FlatAppearance.BorderColor = Color.White
        hAreaBorder2.FlatStyle = FlatStyle.Flat
        hAreaBorder2.Location = New Point(431, 644)
        hAreaBorder2.Name = "hAreaBorder2"
        hAreaBorder2.Size = New Size(200, 10)
        hAreaBorder2.TabIndex = 9
        hAreaBorder2.UseVisualStyleBackColor = False
        ' 
        ' vAreaBorder2
        ' 
        vAreaBorder2.BackColor = Color.Red
        vAreaBorder2.Enabled = False
        vAreaBorder2.FlatAppearance.BorderColor = Color.White
        vAreaBorder2.FlatStyle = FlatStyle.Flat
        vAreaBorder2.Location = New Point(630, 331)
        vAreaBorder2.Name = "vAreaBorder2"
        vAreaBorder2.Size = New Size(10, 313)
        vAreaBorder2.TabIndex = 10
        vAreaBorder2.UseVisualStyleBackColor = False
        ' 
        ' hAreaBorder3
        ' 
        hAreaBorder3.BackColor = Color.LimeGreen
        hAreaBorder3.Enabled = False
        hAreaBorder3.FlatAppearance.BorderColor = Color.White
        hAreaBorder3.FlatStyle = FlatStyle.Flat
        hAreaBorder3.Location = New Point(13, 2)
        hAreaBorder3.Name = "hAreaBorder3"
        hAreaBorder3.Size = New Size(200, 10)
        hAreaBorder3.TabIndex = 11
        hAreaBorder3.UseVisualStyleBackColor = False
        ' 
        ' hAreaBorder4
        ' 
        hAreaBorder4.BackColor = Color.Blue
        hAreaBorder4.Enabled = False
        hAreaBorder4.FlatAppearance.BorderColor = Color.White
        hAreaBorder4.FlatStyle = FlatStyle.Flat
        hAreaBorder4.Location = New Point(431, 2)
        hAreaBorder4.Name = "hAreaBorder4"
        hAreaBorder4.Size = New Size(200, 10)
        hAreaBorder4.TabIndex = 12
        hAreaBorder4.UseVisualStyleBackColor = False
        ' 
        ' vAreaBorder4
        ' 
        vAreaBorder4.BackColor = Color.Blue
        vAreaBorder4.Enabled = False
        vAreaBorder4.FlatAppearance.BorderColor = Color.White
        vAreaBorder4.FlatStyle = FlatStyle.Flat
        vAreaBorder4.Location = New Point(630, 12)
        vAreaBorder4.Name = "vAreaBorder4"
        vAreaBorder4.Size = New Size(10, 313)
        vAreaBorder4.TabIndex = 13
        vAreaBorder4.UseVisualStyleBackColor = False
        ' 
        ' vAreaBorder3
        ' 
        vAreaBorder3.BackColor = Color.LimeGreen
        vAreaBorder3.Enabled = False
        vAreaBorder3.FlatAppearance.BorderColor = Color.White
        vAreaBorder3.FlatStyle = FlatStyle.Flat
        vAreaBorder3.Location = New Point(3, 12)
        vAreaBorder3.Name = "vAreaBorder3"
        vAreaBorder3.Size = New Size(10, 313)
        vAreaBorder3.TabIndex = 14
        vAreaBorder3.UseVisualStyleBackColor = False
        ' 
        ' playerLbl
        ' 
        playerLbl.AutoSize = True
        playerLbl.BackColor = Color.Transparent
        playerLbl.ForeColor = Color.White
        playerLbl.Location = New Point(166, 668)
        playerLbl.Name = "playerLbl"
        playerLbl.Size = New Size(59, 25)
        playerLbl.TabIndex = 15
        playerLbl.Text = "Player"
        ' 
        ' cpuLbl
        ' 
        cpuLbl.AutoSize = True
        cpuLbl.BackColor = Color.Transparent
        cpuLbl.ForeColor = Color.White
        cpuLbl.Location = New Point(420, 668)
        cpuLbl.Name = "cpuLbl"
        cpuLbl.Size = New Size(45, 25)
        cpuLbl.TabIndex = 16
        cpuLbl.Text = "CPU"
        ' 
        ' playerScoreLbl
        ' 
        playerScoreLbl.AutoSize = True
        playerScoreLbl.BackColor = Color.Transparent
        playerScoreLbl.Font = New Font("Agency FB", 28F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        playerScoreLbl.ForeColor = Color.White
        playerScoreLbl.Location = New Point(218, 644)
        playerScoreLbl.Name = "playerScoreLbl"
        playerScoreLbl.Size = New Size(55, 67)
        playerScoreLbl.TabIndex = 17
        playerScoreLbl.Text = "0"
        playerScoreLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cpuScoreLbl
        ' 
        cpuScoreLbl.AutoSize = True
        cpuScoreLbl.BackColor = Color.Transparent
        cpuScoreLbl.Font = New Font("Agency FB", 28F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cpuScoreLbl.ForeColor = Color.White
        cpuScoreLbl.Location = New Point(371, 644)
        cpuScoreLbl.Name = "cpuScoreLbl"
        cpuScoreLbl.Size = New Size(55, 67)
        cpuScoreLbl.TabIndex = 18
        cpuScoreLbl.Text = "0"
        cpuScoreLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' quitBtn
        ' 
        quitBtn.BackColor = Color.Black
        quitBtn.FlatAppearance.BorderColor = Color.White
        quitBtn.FlatStyle = FlatStyle.Flat
        quitBtn.ForeColor = Color.White
        quitBtn.Location = New Point(13, 674)
        quitBtn.Name = "quitBtn"
        quitBtn.Size = New Size(122, 35)
        quitBtn.TabIndex = 19
        quitBtn.Text = "Quit"
        quitBtn.UseVisualStyleBackColor = False
        ' 
        ' cpuMoveTimer
        ' 
        cpuMoveTimer.Enabled = True
        cpuMoveTimer.Interval = 10
        ' 
        ' diskMoveTimer
        ' 
        diskMoveTimer.Enabled = True
        diskMoveTimer.Interval = 10
        ' 
        ' DiskHockey
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(643, 723)
        Controls.Add(quitBtn)
        Controls.Add(cpuScoreLbl)
        Controls.Add(playerScoreLbl)
        Controls.Add(cpuLbl)
        Controls.Add(playerLbl)
        Controls.Add(vAreaBorder3)
        Controls.Add(vAreaBorder4)
        Controls.Add(hAreaBorder4)
        Controls.Add(hAreaBorder3)
        Controls.Add(vAreaBorder2)
        Controls.Add(hAreaBorder2)
        Controls.Add(vAreaBorder1)
        Controls.Add(hAreaBorder1)
        Controls.Add(vCpuBorder2)
        Controls.Add(vCpuBorder1)
        Controls.Add(hCpuBorder)
        Controls.Add(vPlayerBorder2)
        Controls.Add(vPlayerBorder1)
        Controls.Add(hPlayerBorder)
        Controls.Add(middleBorder)
        Name = "DiskHockey"
        Text = "DiskHockey"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents middleBorder As Button
    Friend WithEvents hPlayerBorder As Button
    Friend WithEvents vPlayerBorder1 As Button
    Friend WithEvents vPlayerBorder2 As Button
    Friend WithEvents vCpuBorder2 As Button
    Friend WithEvents vCpuBorder1 As Button
    Friend WithEvents hCpuBorder As Button
    Friend WithEvents hAreaBorder1 As Button
    Friend WithEvents vAreaBorder1 As Button
    Friend WithEvents hAreaBorder2 As Button
    Friend WithEvents vAreaBorder2 As Button
    Friend WithEvents hAreaBorder3 As Button
    Friend WithEvents hAreaBorder4 As Button
    Friend WithEvents vAreaBorder4 As Button
    Friend WithEvents vAreaBorder3 As Button
    Friend WithEvents playerLbl As Label
    Friend WithEvents cpuLbl As Label
    Friend WithEvents playerScoreLbl As Label
    Friend WithEvents cpuScoreLbl As Label
    Friend WithEvents quitBtn As Button
    Friend WithEvents cpuMoveTimer As Timer
    Friend WithEvents diskMoveTimer As Timer

End Class
