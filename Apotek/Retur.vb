Imports System.Data.OleDb

Public Class Retur

    Sub TampilData()
        da = New OleDbDataAdapter("select Kode_Barang,Nama_Barang,Harga_Jual,Jumlah,Subtotal from DetailJual where Faktur='" & TFaktur.Text & "' ", Conn)
        ds = New DataSet
        da.Fill(ds, "DetailJual")
        DGV.DataSource = ds.Tables("DetailJual")
        DGV.ReadOnly = True
        cmd = New OleDbCommand("select tanggal,item,total,dibayar,kembali,kodeptg from Penjualan where faktur='" & TFaktur.Text & "'", Conn)
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

    Private Sub TFaktur_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TFaktur.KeyPress
        If e.KeyChar = Chr(13) Then
            If TFaktur.Text = "" Then
                'MsgBox("Faktur masih kosong")

                'TFaktur.Focus()
                DaftarRetur.Show()
            Else
                cmd = New OleDbCommand("select * from Penjualan where faktur='" & TFaktur.Text & "'", Conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    Call TampilData()
                    TKode.Focus()
                Else
                    MsgBox("Nomor faktur tidak valid")
                    TFaktur.Focus()
                End If
            End If
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub Retur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        TTanggalRetur.Text = Today
    End Sub

    'batas ============================================================================
    Sub Kosongkan()
        TKode.Text = ""
        TNama.Text = ""
        THarga.Text = ""
        TJumlah.Text = ""
        TSubtotal.Text = ""
        TKode.Focus()
    End Sub

    Sub Tampilkan()
        da = New OleDbDataAdapter("Select * from temporer", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "temporer")
        DGV.DataSource = (ds.Tables("temporer"))
        DGV.ReadOnly = True
        'Call AturKolom()
    End Sub

    Sub Tampilkanretur()
        da = New OleDbDataAdapter("Select * from temporer", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "temporer")
        DGV1.DataSource = (ds.Tables("temporer"))
        DGV1.ReadOnly = True
        'Call AturKolom()
    End Sub

    Sub AturKolom()
        DGV1.Columns(0).Width = 75
        DGV1.Columns(1).Width = 200
        DGV1.Columns(2).Width = 100
        DGV1.Columns(3).Width = 75
        DGV1.Columns(4).Width = 100
        DGV.Columns(0).Width = 75
        DGV.Columns(1).Width = 200
        DGV.Columns(2).Width = 100
        DGV.Columns(3).Width = 75
        DGV.Columns(4).Width = 100
    End Sub

    Sub HapusGrid()
        da = New OleDbDataAdapter("Delete * from temporer", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "temporer")
        DGV.DataSource = (ds.Tables("temporer"))
    End Sub

    Sub HapusGridRetur()
        da = New OleDbDataAdapter("Delete * from temporer", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "temporer")
        DGV1.DataSource = (ds.Tables("temporer"))
    End Sub

    Sub CariTotal()
        On Error Resume Next
        cmd = New OleDbCommand("select sum(subtotal) as ketemu from temporer", Conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            TTotalRetur.Text = rd.GetValue(0)
        Else
            TTotalRetur.Text = 0
        End If
    End Sub

    Sub Cariitem()
        On Error Resume Next
        cmd = New OleDbCommand("select sum(jumlah) as ketemu from temporer", Conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            TItemretur.Text = rd.GetValue(0)
        Else
            TItemretur.Text = 0
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSimpan.Click
        If TTotalRetur.Text = "" Or TItemretur.Text = "" Then
            MsgBox("Data belum lengkap")
            Exit Sub
        End If


        'simpan ke tabel retur
        Dim simpanretur As String = "Insert into retur(faktur,tanggal,item,total,KodePtg) values " & _
        "('" & TFaktur.Text & "','" & TTanggalRetur.Text & "','" & TItemretur.Text & "','" & TTotalRetur.Text & "','" & MasterMenu.Panel1.Text & "')"
        cmd = New OleDbCommand(simpanretur, Conn)
        cmd.ExecuteNonQuery()

        'update DetailJual
        Dim editDetailJual As String = "update penjualan set total='" & TTotal.Text - TTotalRetur.Text & "', item='" & TItem.Text - TItemretur.Text & "' where faktur='" & TFaktur.Text & "'"
        cmd = New OleDbCommand(editDetailJual, Conn)
        cmd.ExecuteNonQuery()

        'baca tabel DetailJual
        da = New OleDbDataAdapter("select * from temporer", Conn)
        ds = New DataSet
        da.Fill(ds)
        DGV1.DataSource = ds.Tables(0)
        Dim TBL As DataTable = ds.Tables(0)
        For baris As Integer = 0 To TBL.Rows.Count - 1

            'simpan ke tabel detail
            Dim sqlsimpan As String = "Insert into detailretur(faktur,kode_Barang,nama_Barang,harga_Jual,jumlah,subtotal) values " & _
            "('" & TFaktur.Text & "','" & TBL.Rows(baris)(0) & "','" & TBL.Rows(baris)(1) & "','" & TBL.Rows(baris)(2) & "','" & TBL.Rows(baris)(3) & "','" & TBL.Rows(baris)(4) & "')"
            cmd = New OleDbCommand(sqlsimpan, Conn)
            cmd.ExecuteNonQuery()

            'edit detailjual
            cmd = New OleDbCommand("select * from detailjual where faktur='" & TFaktur.Text & "' and kode_barang='" & TBL.Rows(baris)(0) & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Dim editdetail As String = "update detailjual set jumlah='" & rd.Item(4) - TBL.Rows(baris)(3) & "' where faktur='" & TFaktur.Text & "' and kode_barang='" & TBL.Rows(baris)(0) & "'"
                cmd = New OleDbCommand(editdetail, Conn)
                cmd.ExecuteNonQuery()
            End If

            'tambahstok barang
            cmd = New OleDbCommand("select * from barang where kode_barang='" & TBL.Rows(baris)(0) & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Dim tambahstok As String = "update barang set jumlah_barang= '" & rd.GetValue(5) + TBL.Rows(baris)(3) & "' where kode_barang='" & TBL.Rows(baris)(0) & "'"
                cmd = New OleDbCommand(tambahstok, Conn)
                cmd.ExecuteNonQuery()
            End If
        Next baris

        Call HapusGrid()
        Call HapusGridRetur()
        Call Tampilkanretur()
        Call Kosongkan()
        Call HapusMaster()
        Call HapusMasterretur()
        'Faktur.Show()

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TKode.KeyPress
        If e.KeyChar = Chr(13) Then
            If TKode.Text = "" Then
                'DaftarBarang.Show()
                MsgBox("kode barang tiadk terdaftar")
            Else
                cmd = New OleDbCommand("Select * from detailjual where kode_barang='" & TKode.Text & "' and faktur='" & TFaktur.Text & "'", Conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    TNama.Text = rd.GetString(2)
                    THarga.Text = rd.GetValue(3)
                    TJumlah.Text = rd.GetValue(4)
                    TSubtotal.Text = rd.GetValue(5)
                    TSubtotal.Focus()
                Else
                    MsgBox("Kode barang tidak terdaftar di faktur " & TFaktur.Text & "")
                    TKode.Text = ""
                    TKode.Focus()
                End If
            End If
        End If

        If e.KeyChar = Chr(27) Then
            cmd = New OleDbCommand("select * from temporer where kode='" & TKode.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Dim sqlhapus As String = "delete * from temporer where kode='" & TKode.Text & "'"
                cmd = New OleDbCommand(sqlhapus, Conn)
                cmd.ExecuteNonQuery()
                Call Tampilkan()
                Call CariTotal()
                Call Cariitem()
                TKode.Text = ""
            Else
                MsgBox("Kode tidak ada dalam transaksi")
                TKode.Focus()
            End If
        End If

        If e.KeyChar = Chr(9) Then TDibayar.Focus()
    End Sub

    Private Sub TJumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TJumlah.KeyPress
        If e.KeyChar = Chr(13) Then
            cmd = New OleDbCommand("select * from detailjual where kode_barang='" & TKode.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                If TJumlah.Text > rd.GetValue(3) Then
                    MsgBox("" & TNama.Text & " yang dibeli hanya " & rd.GetValue(3) & " buah")
                    TJumlah.Focus()
                    Exit Sub
                Else
                    TSubtotal.Text = THarga.Text * TJumlah.Text
                    Dim sqlsimpan As String = "Insert into temporer (kode,nama,harga,jumlah,subtotal) values " & _
                    "('" & TKode.Text & "','" & TNama.Text & "','" & THarga.Text & "','" & TJumlah.Text & "','" & TSubtotal.Text & "')"
                    cmd = New OleDbCommand(sqlsimpan, Conn)
                    cmd.ExecuteNonQuery()

                    Call Tampilkanretur()
                    Call CariTotal()
                    Call Cariitem()
                    Call Kosongkan()
                End If
            End If
        End If
    End Sub

    Sub HapusMaster()
        TTanggal.Clear()
        TKasir.Clear()
        TItem.Text = ""
        TTotal.Text = ""
        TDibayar.Text = ""
        TKembali.Text = ""
    End Sub

    Sub HapusMasterretur()
        TItemretur.Text = ""
        TTotalRetur.Text = ""
        TDibayarRetur.Text = ""
        TKembaliRetur.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBatal.Click
        'Call HapusGrid()
        Call HapusGridRetur()
        Call HapusMaster()
        Call HapusMasterretur()
        Call Tampilkan()
    End Sub

    Private Sub TDibayar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TDibayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TDibayar.Text) < Val(TTotal.Text) Then
                MsgBox("Pembayaran kurang")
                TKembali.Text = ""
                TDibayar.Focus()
                Exit Sub
            ElseIf Val(TDibayar.Text) = Val(TTotal.Text) Then
                TKembali.Text = 0
                CmdSimpan.Focus()
            Else
                TKembali.Text = Val(TDibayar.Text) - Val(TTotal.Text)
                CmdSimpan.Focus()
            End If
        End If
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdTutup.Click
        Me.Close()
    End Sub



End Class