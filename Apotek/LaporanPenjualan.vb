Imports System.Data.OleDb

Public Class LaporanPenjualan

    Dim awal As String
    Dim akhir As String

    Sub TampilTanggal()
        Call Koneksi()
        cmd = New OleDbCommand("select distinct day(tanggal) as hari from penjualan", Conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            ComboBox1.Items.Add(rd.Item(0))
        Loop

        cmd = New OleDbCommand("select distinct month(tanggal) as bulan from penjualan", Conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            ComboBox4.Items.Add(rd.Item(0))
        Loop

        cmd = New OleDbCommand("select distinct year(tanggal) as tahun from penjualan", Conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            ComboBox5.Items.Add(rd.Item(0))
        Loop
        cmd = New OleDbCommand("select distinct year(tanggal) as tahun from penjualan", Conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            ComboBox6.Items.Add(rd.Item(0))
        Loop
    End Sub

    Private Sub LaporanPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call TampilTanggal()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Laporan.Show()
        Laporan.CRV.ReportSource = Nothing
        Laporan.CRV.RefreshReport()
        ' Laporan.CRV.SelectionFormula = "totext({pembelian.Tgl_beli})='" & ComboBox1.Text & "'"
        Laporan.CRV.SelectionFormula = " day({penjualan.Tanggal})=" & Val(ComboBox1.Text)
        Laporan.CRV.ReportSource = "1harian.rpt"

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If ComboBox2.Text = "" Or ComboBox3.Text = "" Then
                MsgBox("Pilih tanggal awal dan tanggal akhir")
                Exit Sub
            Else
                Laporan.Show()
                Laporan.CRV.SelectionFormula = "{Penjualan.Tanggal} in date (" & ComboBox2.Text & ") to date (" & ComboBox3.Text & ")"
                cryRpt.Load("2mingguan.rpt")
                Call Module_Konfigurasi_laporan()
                Laporan.CRV.ReportSource = cryRpt
                Laporan.CRV.RefreshReport()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ComboBox4.Text = "" Or ComboBox5.Text = "" Then
            MsgBox("Pilih dulu bulan dan tahun")
            Exit Sub
        Else
            Laporan.Show()
            Laporan.CRV.SelectionFormula = "Month({Penjualan.Tanggal})=" & Val(ComboBox4.Text) & " and Year({Penjualan.Tanggal})=" & Val(ComboBox5.Text)
            cryRpt.Load("3bulanan.rpt")
            Call Module_Konfigurasi_laporan()
            Laporan.CRV.ReportSource = cryRpt
            Laporan.CRV.RefreshReport()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Laporan.Show()
        Laporan.CRV.ReportSource = Nothing
        Laporan.CRV.RefreshReport()
        Laporan.CRV.SelectionFormula = " Year({penjualan.Tanggal})=" & Val(ComboBox6.Text)
        Laporan.CRV.ReportSource = "4Tahunan.rpt"
    End Sub
End Class