Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class Penjualan1

    Sub BersihkanText()
        Total.Text = ""
        Dibayar.Text = ""
        Kembali.Text = ""
        Item.Text = ""
    End Sub

    Sub BuatKolomBaru()
        DGV.Columns.Add("Kode", "Kode")
        DGV.Columns.Add("Nama", "Nama Barang")
        DGV.Columns.Add("Harga", "Harga")
        DGV.Columns.Add("Jumlah", "Jumlah")
        DGV.Columns.Add("Total", "SubTotal")
        Call AturLebarKolom()
    End Sub

    Sub AturLebarKolom()
        DGV.Columns(0).Width = 50
        DGV.Columns(1).Width = 175
        DGV.Columns(2).Width = 75
        DGV.Columns(3).Width = 75
        DGV.Columns(4).Width = 100
    End Sub

    Sub FakturOtomatis()
        cmd = New OleDbCommand("Select * from penjualan where faktur in (select max(faktur) from penjualan) order by faktur desc", Conn)
        Dim urutan As String
        Dim hitung As Long
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urutan = Format(Now, "yyMMdd") + "0001"
        Else
            If Microsoft.VisualBasic.Left(rd.GetString(0), 6) <> Format(Now, "yyMMdd") Then
                urutan = Format(Now, "yyMMdd") + "0001"
            Else
                hitung = rd.GetString(0) + 1
                urutan = Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("0000" & hitung, 4)
            End If
        End If
        Faktur.Text = urutan
    End Sub

    Private Sub Penjualan1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call FakturOtomatis()
        Tanggal.Text = Today
    End Sub

    Private Sub Penjualan1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call BuatKolomBaru()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Jam.Text = TimeOfDay

    End Sub

    Private Sub BTNBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBatal.Click
        Call BersihkanText()
        DGV.Columns.Clear()
        Call BuatKolomBaru()
        DGV.Focus()
    End Sub

    Sub kena(ByVal myGrid As DataGrid)
        ' Set the current cell to cell 1, row 1.
        myGrid.CurrentCell = New DataGridCell(1, 1)
    End Sub


    Private Sub DGV_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellEndEdit
        If e.ColumnIndex = 0 Then
            cmd = New OleDbCommand("select * from barang where kode_barang='" & DGV.Rows(e.RowIndex).Cells(0).Value & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                DGV.Rows(e.RowIndex).Cells(1).Value = rd.Item(1)
                DGV.Rows(e.RowIndex).Cells(2).Value = rd.Item(4)
                DGV.Rows(e.RowIndex).Cells(3).Value = 1
                DGV.Rows(e.RowIndex).Cells(4).Value = DGV.Rows(e.RowIndex).Cells(2).Value * DGV.Rows(e.RowIndex).Cells(3).Value
                Call TotalItem()
                Call TotalHarga()
                'DGV.CurrentCell = DGV(3, 0)
                'DGV.Rows(e.RowIndex).Cells(3).Value = Keys.Up
            Else
                MsgBox("Kode barang tidak terdaftar")
            End If
        End If

        If e.ColumnIndex = 3 Then

            cmd = New OleDbCommand("select * from barang where kode_barang='" & DGV.Rows(e.RowIndex).Cells(0).Value & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                If DGV.Rows(e.RowIndex).Cells(3).Value > rd.Item(5) Then
                    MsgBox("Stok barang hanya ada " & rd.Item(5) & "")
                    DGV.Rows(e.RowIndex).Cells(3).Value = 1
                    DGV.Rows(e.RowIndex).Cells(4).Value = DGV.Rows(e.RowIndex).Cells(2).Value * DGV.Rows(e.RowIndex).Cells(3).Value
                    Call TotalItem()
                    Call TotalHarga()
                Else
                    DGV.Rows(e.RowIndex).Cells(4).Value = DGV.Rows(e.RowIndex).Cells(2).Value * DGV.Rows(e.RowIndex).Cells(3).Value
                    Call TotalItem()
                    Call TotalHarga()
                End If
            End If
            DGV.CurrentCell = DGV.Rows(0).Cells(0)
        End If

    End Sub

    Sub TotalItem()
        Dim HitungItem As Integer = 0
        For I As Integer = 0 To DGV.Rows.Count - 1
            HitungItem = HitungItem + Val(DGV.Rows(I).Cells(3).Value)
            Item.Text = HitungItem
        Next
    End Sub

    Sub TotalHarga()
        Dim HitungHarga As Integer = 0
        For I As Integer = 0 To DGV.Rows.Count - 1
            HitungHarga = HitungHarga + Val(DGV.Rows(I).Cells(4).Value)
            Total.Text = HitungHarga
        Next
    End Sub

    Private Sub BTNTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNTutup.Click
        Me.Close()
    End Sub

    Sub HapusBaris()
        On Error Resume Next
        'DGV.Rows.RemoveAt(DGV.CurrentCell.RowIndex)
        Dim baris As Integer = DGV.CurrentCell.RowIndex
        DGV.Rows(baris).Cells(0).Value = ""
        Chr(30)
    End Sub

    Private Sub DGV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGV.KeyDown
        If e.KeyCode = Keys.Up Then
            DGV.CurrentCell = DGV.Rows(0).Cells(3)
        End If
    End Sub


    Private Sub DGV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DGV.KeyPress
        On Error Resume Next
        If e.KeyChar = Chr(27) Then
            DGV.Rows.RemoveAt(DGV.CurrentCell.RowIndex)
            Call TotalItem()
            Call TotalHarga()
            Dibayar.Clear()
            Kembali.Text = ""
        End If


    End Sub

    Private Sub Dibayar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Dibayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(Dibayar.Text) < Val(Total.Text) Then
                MsgBox("Pembayaran kurang")
                Kembali.Text = ""
                Dibayar.Focus()
                Exit Sub
            ElseIf Val(Dibayar.Text) = Val(Total.Text) Then
                Kembali.Text = 0
                BTNSimpan.Focus()
            Else
                Kembali.Text = Val(Dibayar.Text) - Val(Total.Text)
                BTNSimpan.Focus()
            End If
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True

    End Sub

    Private Sub BTNSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSimpan.Click
        If Total.Text = "" Or Dibayar.Text = "" Or Kembali.Text = "" Or Item.Text = "" Then
            MsgBox("Data belum lengkap, tidak ada transaksi atau pembayaran masih kosong")
            Exit Sub
        End If

        'simpan ke tabel penjualan
        Dim simpanmaster As String = "Insert into penjualan(faktur,tanggal,item,total,dibayar,kembali,KodePtg) values " & _
        "('" & Faktur.Text & "','" & Tanggal.Text & "','" & Item.Text & "','" & Total.Text & "','" & Dibayar.Text & "','" & Kembali.Text & "','" & MasterMenu.Panel1.Text & "')"
        cmd = New OleDbCommand(simpanmaster, Conn)
        cmd.ExecuteNonQuery()

        For baris As Integer = 0 To DGV.Rows.Count - 2
            'simpan ke tabel detail
            Dim sqlsimpan As String = "Insert into detailjual (faktur,kode_Barang,nama_Barang,harga_Jual,jumlah,subtotal) values " & _
            "('" & Faktur.Text & "','" & DGV.Rows(baris).Cells(0).Value & "','" & DGV.Rows(baris).Cells(1).Value & "','" & DGV.Rows(baris).Cells(2).Value & "','" & DGV.Rows(baris).Cells(3).Value & "','" & DGV.Rows(baris).Cells(4).Value & "')"
            cmd = New OleDbCommand(sqlsimpan, Conn)
            cmd.ExecuteNonQuery()

            'kurangi stok barang
            cmd = New OleDbCommand("select * from barang where kode_barang='" & DGV.Rows(baris).Cells(0).Value & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Dim kurangistok As String = "update barang set jumlah_barang= '" & rd.Item(5) - DGV.Rows(baris).Cells(3).Value & "' where kode_barang='" & DGV.Rows(baris).Cells(0).Value & "'"
                cmd = New OleDbCommand(kurangistok, Conn)
                cmd.ExecuteNonQuery()
            End If
        Next baris

        DGV.Columns.Clear()
        Call BuatKolomBaru()
        Call FakturOtomatis()
        Call BersihkanText()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Barang1.ShowDialog()
    End Sub

    Private Sub Tanggal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tanggal.Click

    End Sub

    Private Sub Jam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Jam.Click

    End Sub
End Class