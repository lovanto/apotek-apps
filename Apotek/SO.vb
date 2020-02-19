Imports System.Data.OleDb

Public Class SO
    Sub Kosongkan()
        TKCek.Text = ""
        Tanggal.Text = ""
        TJumlah.Text = ""
        TJumlahSO.Text = ""
    End Sub


    Sub Hanyabaca()
        Tanggal.ReadOnly = True
        TJumlah.ReadOnly = True
        TJumlahSO.ReadOnly = True
    End Sub


    Sub Kunci()
        TKCek.Enabled = False
        TJumlahSO.Enabled = False
        Tanggal.Enabled = False
        TJumlah.Enabled = False
        DGV.Enabled = False
    End Sub

    Sub BukaKunci()
        TKCek.Enabled = True
        TJumlahSO.Enabled = True
        Tanggal.Enabled = True
        TJumlah.Enabled = True
        DGV.Enabled = True
    End Sub

    Sub BuatKolomBaru()
        DGV.Columns.Add("KBarang", "Kode Barang")
        DGV.Columns.Add("Nama", "Nama Barang")
        DGV.Columns.Add("Harga", "Harga")
        DGV.Columns.Add("Jumlah", "Jumlah")
        DGV.Columns.Add("JumlahSO", "Stok SO")
        DGV.Columns.Add("Hasil", "Hasil")
        Call AturLebarKolom()
    End Sub

    Sub AturLebarKolom()
        DGV.Columns(0).Width = 100
        DGV.Columns(1).Width = 115
        DGV.Columns(2).Width = 85
        DGV.Columns(3).Width = 55
        DGV.Columns(4).Width = 35
        DGV.Columns(4).Width = 55
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Koneksi()
    End Sub

    Private Sub SO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call BuatKolomBaru()
        Call AturLebarKolom()
        Call Kunci()
    End Sub

    Sub TotalItem()
        Dim HitungItem As Integer = 0
        For I As Integer = 0 To DGV.Rows.Count - 1
            HitungItem = HitungItem + Val(DGV.Rows(I).Cells(3).Value)
            TJumlah.Text = HitungItem
        Next
    End Sub

    Sub TotalHarga()
        Dim HitungHarga As Integer = 0
        For I As Integer = 0 To DGV.Rows.Count - 1
            HitungHarga = HitungHarga + Val(DGV.Rows(I).Cells(4).Value)
            TJumlahSO.Text = HitungHarga
        Next
    End Sub

    Private Sub DGV_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellEndEdit
        If e.ColumnIndex = 0 Then
            cmd = New OleDbCommand("select * from barang where kode_barang='" & DGV.Rows(e.RowIndex).Cells(0).Value & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                DGV.Rows(e.RowIndex).Cells(1).Value = rd.Item(1)
                DGV.Rows(e.RowIndex).Cells(2).Value = rd.Item(2)
                DGV.Rows(e.RowIndex).Cells(3).Value = rd.Item(5)
                DGV.Rows(e.RowIndex).Cells(4).Value = 1
                DGV.Rows(e.RowIndex).Cells(5).Value = DGV.Rows(e.RowIndex).Cells(4).Value - DGV.Rows(e.RowIndex).Cells(3).Value
                Call TotalItem()
                Call TotalHarga()
            Else
                DGV.Rows(e.RowIndex).Cells(5).Value = DGV.Rows(e.RowIndex).Cells(4).Value * DGV.Rows(e.RowIndex).Cells(3).Value
                Call TotalItem()
                Call TotalHarga()
            End If
        End If

        If e.ColumnIndex = 4 Then

            cmd = New OleDbCommand("select * from barang where kode_barang='" & DGV.Rows(e.RowIndex).Cells(0).Value & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                If DGV.Rows(e.RowIndex).Cells(3).Value > rd.Item(4) Then
                    MsgBox("Stok barang hanya ada " & rd.Item(4) & "")
                    DGV.Rows(e.RowIndex).Cells(4).Value = 1
                    DGV.Rows(e.RowIndex).Cells(5).Value = DGV.Rows(e.RowIndex).Cells(4).Value - DGV.Rows(e.RowIndex).Cells(3).Value
                    Call TotalItem()
                    Call TotalHarga()
                Else
                    DGV.Rows(e.RowIndex).Cells(5).Value = DGV.Rows(e.RowIndex).Cells(4).Value - DGV.Rows(e.RowIndex).Cells(3).Value
                    Call TotalItem()
                    Call TotalHarga()
                End If
            End If
            DGV.CurrentCell = DGV.Rows(0).Cells(0)
        End If

    End Sub

    Private Sub CmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmdBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Hanyabaca()
        Call Kosongkan()
        Call BukaKunci()
        Tanggal.Text = Today
    End Sub

    Private Sub CmdBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Kosongkan()
        DGV.Columns.Clear()
        Call BuatKolomBaru()
        DGV.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TKCek.Text = "" Then
            MsgBox("Data belum lengkap, tidak ada transaksi atau pembayaran masih kosong")
            Exit Sub
        End If

        'simpan ke tabel penjualan
        'Dim simpanmaster As String = "Insert into StokOfName(KCek) values " & _
        '"('" & TKCek.Text & "')"
        'cmd = New OleDbCommand(simpanmaster, Conn)
        'cmd.ExecuteNonQuery()
        For baris As Integer = 0 To DGV.Rows.Count - 2
            'simpan ke tabel detail
            Dim sqlsimpan As String = "Insert into StokOfName (KCek,Tanggal,KBarang,Nama,Harga,Jumlah_Barang,Jumlah_SO,Hasil) values " & _
            "('" & TKCek.Text & "','" & Tanggal.Text & "','" & DGV.Rows(baris).Cells(0).Value & "','" & DGV.Rows(baris).Cells(1).Value & "','" & DGV.Rows(baris).Cells(2).Value & "','" & DGV.Rows(baris).Cells(3).Value & "','" & DGV.Rows(baris).Cells(4).Value & "','" & DGV.Rows(baris).Cells(5).Value & "')"
            cmd = New OleDbCommand(sqlsimpan, Conn)
            cmd.ExecuteNonQuery()

            'kurangi stok barang
            'cmd = New OleDbCommand("select * from barang where kode_barang='" & DGV.Rows(baris).Cells(0).Value & "'", Conn)
            'rd = cmd.ExecuteReader
            'rd.Read()
            'If rd.HasRows Then
            'Dim kurangistok As String = "update barang set jumlah_barang= '" & rd.Item(4) - DGV.Rows(baris).Cells(3).Value & "' where kode_barang='" & DGV.Rows(baris).Cells(0).Value & "'"
            'cmd = New OleDbCommand(kurangistok, Conn)
            'cmd.ExecuteNonQuery()
            'End If
        Next baris

        DGV.Columns.Clear()
        Call BuatKolomBaru()
        Call Kosongkan()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call Hanyabaca()
        Call Kosongkan()
        Call BukaKunci()
        Tanggal.Text = Today
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call Kosongkan()
        DGV.Columns.Clear()
        Call BuatKolomBaru()
        DGV.Focus()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TampilSO.ShowDialog()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TampilSO.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Barang1.Show()
    End Sub
End Class