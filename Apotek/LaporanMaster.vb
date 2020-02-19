Public Class LaporanMaster

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Laporan.Show()
        cryRpt.Load("barang.rpt")
        Call Module_Konfigurasi_laporan()
        Laporan.CRV.ReportSource = cryRpt
        Laporan.CRV.RefreshReport()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Laporan.Show()
        cryRpt.Load("CrystalReport1.rpt")
        Call Module_Konfigurasi_laporan()
        Laporan.CRV.ReportSource = cryRpt
        Laporan.CRV.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Laporan.Show()
        cryRpt.Load("lap-perkur.rpt")
        Call Module_Konfigurasi_laporan()
        Laporan.CRV.ReportSource = cryRpt
        Laporan.CRV.RefreshReport()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Laporan.Show()
        cryRpt.Load("Lap-SO.rpt")
        Call Module_Konfigurasi_laporan()
        Laporan.CRV.ReportSource = cryRpt
        Laporan.CRV.RefreshReport()
    End Sub
End Class