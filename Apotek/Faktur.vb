Public Class Faktur

    Private Sub CRV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CRV.RefreshReport()
        CRV.ReportSource = "faktur.rpt"
        CRV.RefreshReport()
    End Sub

    Private Sub Faktur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class