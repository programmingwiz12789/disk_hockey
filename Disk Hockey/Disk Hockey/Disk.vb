Public Class Disk
    Public x, y, dx, dy, size As Integer
    Public color As Color

    Public Sub New(x As Integer, y As Integer, dx As Integer, dy As Integer, size As Integer, color As Color)
        Me.x = x
        Me.y = y
        Me.dx = dx
        Me.dy = dy
        Me.size = size
        Me.color = color
    End Sub
End Class
