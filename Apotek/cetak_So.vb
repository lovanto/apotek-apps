Imports System.Data.OleDb
Public Class cetak_so

    Private Sub cetak_so_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
        ComboBox6.Items.Add("Kcek")
        ComboBox6.Items.Add("Tanggal")
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged
        If ComboBox6.Text = "Kcek" Then
            cmd = New OleDbCommand("select distinct Kcek from StokOfName", Conn)
            rd = cmd.ExecuteReader
            ListBox1.Items.Clear()
            Do While rd.Read
                ListBox1.Items.Add(rd.Item(0))
            Loop
        ElseIf ComboBox6.Text = "Tanggal" Then
            cmd = New OleDbCommand("select distinct Tanggal from StokOfName", Conn)
            rd = cmd.ExecuteReader
            ListBox1.Items.Clear()
            Do While rd.Read
                ListBox1.Items.Add(rd.Item(0))
            Loop
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ComboBox6.Text = "Kcek" Then
            Laporan.Show()
            Laporan.CRV.ReportSource = Nothing
            Laporan.CRV.RefreshReport()
            Laporan.CRV.SelectionFormula = "{StokOfName.Kcek}='" & ListBox1.Text & "'"
            Laporan.CRV.ReportSource = "lap-so.rpt"
        ElseIf ComboBox6.Text = "Tanggal" Then
            Laporan.Show()
            Laporan.CRV.ReportSource = Nothing
            Laporan.CRV.RefreshReport()
            Laporan.CRV.SelectionFormula = "totext({StokOfName.Tanggal})='" & ListBox1.Text & "'"
            Laporan.CRV.ReportSource = "lap-so.rpt"
        End If
    End Sub
End Class