Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class fix_so
    Sub Kosongkan()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
    End Sub
    Sub AturLebarKolom()
        DGV.Columns(0).Width = 50
        DGV.Columns(1).Width = 175
        DGV.Columns(2).Width = 75
        DGV.Columns(3).Width = 75
        DGV.Columns(4).Width = 100
    End Sub
    Sub Tampilkan()
        da = New OleDbDataAdapter("Select * from StokOfName", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "StokOfName")
        DGV.DataSource = (ds.Tables("StokOfName"))
        DGV.ReadOnly = True
    End Sub
    Private Sub fix_so_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
        Tampilkan()
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
        TextBox4.ReadOnly = True
        TextBox5.ReadOnly = True
        TextBox6.ReadOnly = True
        TextBox7.ReadOnly = True
        TextBox8.ReadOnly = True
        TextBox9.ReadOnly = True
    End Sub

    Private Sub DGV_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellEndEdit
        If e.ColumnIndex = 6 Then

            cmd = New OleDbCommand("select * from StokOfName where KodeUtama='" & DGV.Rows(e.RowIndex).Cells(0).Value & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                If DGV.Rows(e.RowIndex).Cells(6).Value <> DGV.Rows(e.RowIndex).Cells(7).Value Then
                    DGV.Rows(e.RowIndex).Cells(6).Value = 1
                    'Call TotalItem()
                    'Call TotalHarga()
                Else
                    DGV.Rows(e.RowIndex).Cells(6).Value = 1
                    'Call TotalItem()
                    'Call TotalHarga()
                End If
            End If
            DGV.CurrentCell = DGV.Rows(0).Cells(0)
        End If
    End Sub

    Private Sub btnfix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfix.Click
        cmd = New OleDbCommand("Select * from StokOfName where KodeUtama='" & TextBox1.Text & "'", Conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            Dim sqltambah As String = "Insert into StokOfName(Kode_Barang,Nama_Barang,Dosis,Bentuk,Harga, jumlah_barang,satuan,kategori) values " & _
            "('" & TextBox1.Text & "')"
            cmd = New OleDbCommand(sqltambah, Conn)
            cmd.ExecuteNonQuery()
            Call Kosongkan()
            Call Tampilkan()
        Else
            Dim sqledit As String = "Update StokOfName set " & _
                   "Tanggal='" & TextBox2.Text & "', " & _
                   "KCek='" & TextBox3.Text & "', " & _
                   "KBarang='" & TextBox4.Text & "', " & _
                   "Nama='" & TextBox5.Text & "', " & _
                   "Harga='" & TextBox6.Text & "', " & _
                   "Jumlah_Barang='" & TextBox7.Text & "' " & _
                   "Jumlah_SO='" & TextBox8.Text & "' " & _
                   "Hasil='" & TextBox9.Text & "' " & _
                   "where KodeUtama='" & TextBox1.Text & "'"
            cmd = New OleDbCommand(sqledit, Conn)
            cmd.ExecuteNonQuery()
            Call Kosongkan()
            Call Tampilkan()
        End If
    End Sub

    Private Sub DGV_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.RowHeaderMouseClick
        If Not IsDBNull(DGV.SelectedCells(0).Value) Then

            TextBox1.Text = DGV.SelectedCells(0).Value
            TextBox2.Text = DGV.SelectedCells(1).Value
            TextBox3.Text = DGV.SelectedCells(2).Value
            TextBox4.Text = DGV.SelectedCells(3).Value
            TextBox5.Text = DGV.SelectedCells(4).Value
            TextBox6.Text = DGV.SelectedCells(5).Value
            TextBox7.Text = DGV.SelectedCells(7).Value
            TextBox8.Text = DGV.SelectedCells(7).Value
            TextBox9.Text = DGV.SelectedCells(8).Value
        Else

        End If
    End Sub
End Class