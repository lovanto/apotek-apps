Public Class MasterMenu

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        GB2.Visible = True
        GB2.Dock = DockStyle.Bottom
        GB3.Visible = False
        GB4.Visible = False
        GB5.Visible = False

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GB2.Visible = False
        GB3.Visible = True
        GB3.Dock = DockStyle.Bottom
        GB4.Visible = False
        GB5.Visible = False

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GB2.Visible = False
        GB3.Visible = False
        GB4.Visible = True
        GB4.Dock = DockStyle.Bottom
        GB5.Visible = False

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        GB2.Visible = False
        GB3.Visible = False
        GB4.Visible = False
        GB5.Visible = True

        GB5.Dock = DockStyle.Bottom


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If MessageBox.Show("Tutup Aplikasi...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            End
        End If

    End Sub

    Private Sub MasterMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GB1.Dock = DockStyle.Top
        GB2.Visible = True
        GB3.Visible = False
        GB4.Visible = False
        GB5.Visible = False
        GB2.Dock = DockStyle.Bottom
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Petugas.ShowDialog()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Barang1.ShowDialog()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Penjualan1.ShowDialog()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Retur.ShowDialog()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        LaporanMaster.Show()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Laporan.Show()
        cryRpt.Load("Penjualan.rpt")
        Call Module_Konfigurasi_laporan()
        Laporan.CRV.ReportSource = cryRpt
        Laporan.CRV.RefreshReport()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        RincianTransaksi.Show()
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        GantiPassword.ShowDialog()
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        System.Windows.Forms.Help.ShowHelp(Me, "manualbook penjualan.chm")
    End Sub

    Private Sub PetugasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PetugasToolStripMenuItem.Click
        Petugas.ShowDialog()
    End Sub

    Private Sub BarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangToolStripMenuItem.Click
        Barang1.ShowDialog()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjualanToolStripMenuItem.Click
        Penjualan1.ShowDialog()
    End Sub

    Private Sub ReturPenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturPenjualanToolStripMenuItem.Click
        Retur.ShowDialog()
    End Sub

    Private Sub DataMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataMasterToolStripMenuItem.Click
        LaporanMaster.Show()
    End Sub

    Private Sub DataTransaksiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataTransaksiToolStripMenuItem.Click
        Laporan.Show()
        cryRpt.Load("Penjualan.rpt")
        Call Module_Konfigurasi_laporan()
        Laporan.CRV.ReportSource = cryRpt
        Laporan.CRV.RefreshReport()
    End Sub

    Private Sub RincianPenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RincianPenjualanToolStripMenuItem.Click
        RincianTransaksi.Show()
    End Sub

    Private Sub GantiPassswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GantiPassswordToolStripMenuItem.Click
        GantiPassword.ShowDialog()
    End Sub

    Private Sub ManualBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        System.Windows.Forms.Help.ShowHelp(Me, "manualbook penjualan.chm")
    End Sub

    Private Sub TutupAplikasiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TutupAplikasiToolStripMenuItem.Click
        If MessageBox.Show("Tutup Aplikasi...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            End
        End If
    End Sub

    Private Sub GB3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GB3.Enter

    End Sub

    Private Sub GB1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GB1.Enter

    End Sub

    Private Sub GB2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GB2.Enter

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Perkursor.ShowDialog()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        SO.Show()
    End Sub

    Private Sub BarangPerkursorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangPerkursorToolStripMenuItem.Click
        Perkursor.Show()
    End Sub

    Private Sub StokOpnameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StokOpnameToolStripMenuItem.Click
        SO.Show()
    End Sub
End Class