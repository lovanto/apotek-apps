Imports System.Data.OleDb

Public Class RincianTransaksi

    Sub TampilFaktur()
        cmd = New OleDbCommand("select * from penjualan", Conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            combobox1.Items.Add(rd.GetString(0))
        Loop
    End Sub

    Sub TampilData()
        da = New OleDbDataAdapter("select nama_barang,Harga_Jual,jumlah,subtotal from detailjual where faktur='" & combobox1.Text & "' ", Conn)
        ds = New DataSet
        da.Fill(ds, "detailjual")
        DGV.DataSource = ds.Tables("detailjual")
        DGV.ReadOnly = True
        cmd = New OleDbCommand("select tanggal,item,total,dibayar,kembali,namaptg from penjualan,petugas where faktur='" & ComboBox1.Text & "'", Conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            TTanggal.Text = rd.GetValue(0)
            TItem.Text = rd.GetValue(1)
            TTotal.Text = rd.GetValue(2)
            TDibayar.Text = rd.GetValue(3)
            TKembali.Text = rd.GetValue(4)
            TKasir.Text = rd.GetValue(5)
        End If

    End Sub

    Private Sub RincianTransaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilFaktur()
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call TampilData()
    End Sub
End Class