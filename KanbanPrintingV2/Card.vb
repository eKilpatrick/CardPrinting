Public Class Card
    Public PN As String = ""
    Public Loc As String = ""
    Public YellowID As String = ""
    Public RedID As String = ""
    Public Desc As String = ""
    Public BinSize As String = ""
    Public ReplStrat As String = ""
    Public Sub New(PN As String, Loc As String, YellowID As String, RedID As String, Desc As String, BinSize As String, ReplStrat As String)
        Me.PN = PN
        Me.Loc = Loc
        Me.YellowID = YellowID
        Me.RedID = RedID
        Me.Desc = Desc
        Me.BinSize = BinSize
        If ReplStrat.Contains("Warehouse") Then
            Me.ReplStrat = "Warehouse"
        Else
            Me.ReplStrat = "Vendor"
        End If

    End Sub
End Class
