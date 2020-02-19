Imports System.Data.OleDb

Public Class Barang1
    Sub Kosongkan()
        TKode.Text = ""
        TNama.Text = ""
        TBeli.Text = ""
        TJual.Text = ""
        TJumlah.Text = ""
        THarga.Text = ""
        CmbSatuan.Text = ""
        ComboBox1.Text = ""
        TKode.Focus()
    End Sub

    Sub Kunci()
        TKode.Enabled = False
        TNama.Enabled = False
        TBeli.Enabled = False
        TJual.Enabled = False
        TJumlah.Enabled = False
        THarga.Enabled = False
        CmbSatuan.Enabled = False
        ComboBox1.Enabled = False
        TKode.Focus()
    End Sub

    Sub KunciBuka()
        TKode.Enabled = True
        TNama.Enabled = True
        TBeli.Enabled = True
        TJual.Enabled = True
        TJumlah.Enabled = True
        THarga.Enabled = True
        CmbSatuan.Enabled = True
        ComboBox1.Enabled = True
        TKode.Focus()
    End Sub

    Sub DataBaru()
        TNama.Text = ""
        TBeli.Text = ""
        TJual.Text = ""
        TJumlah.Text = ""
        THarga.Text = ""
        CmbSatuan.Text = ""
        CmbSatuan.Focus()
    End Sub

    Sub Tampilkan()
        da = New OleDbDataAdapter("Select * from barang", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Barang")
        DGV.DataSource = (ds.Tables("Barang"))
        DGV.ReadOnly = True
    End Sub

    Sub TampilSatuan()

        da = New OleDbDataAdapter("Select * from barang order by 1", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "barang")
        DGV.DataSource = (ds.Tables("barang"))
        DGV.ReadOnly = True

        CmbSatuan.Items.Clear()
        cmd = New OleDbCommand("select distinct Satuan from Barang", Conn)
        rd = cmd.ExecuteReader
        While rd.Read
            CmbSatuan.Items.Add(rd.GetString(0))
        End While
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Tampilkan()
        ' Call TampilSatuan()
        Call Kunci()
    End Sub

    Private Sub TKode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TKode.KeyPress
        If e.KeyChar = Chr(13) Then
            cmd = New OleDbCommand("select * from barang where kode_barang='" & TKode.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                TNama.Text = rd.GetString(1)
                TBeli.Text = rd.GetValue(2)
                TJual.Text = rd.GetValue(3)
                TJumlah.Text = rd.GetValue(4)
                CmbSatuan.Text = rd.GetString(5)
                TNama.Focus()
            Else
                Call DataBaru()
                TNama.Focus()
            End If
        End If
    End Sub

    Private Sub CmdHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TKode.Text = "" Then
            MsgBox("Isi kode barang terlebih dahulu")
            TKode.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("Delete * from barang where kode_barang='" & TKode.Text & "'", Conn)
                cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            Else
                Call Kosongkan()
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        da = New OleDbDataAdapter("select * from Barang where Nama_Barang like '%" & TextBox1.Text & "%'", Conn)
        ds = New DataSet
        da.Fill(ds, "ketemu")
        DGV.DataSource = ds.Tables("ketemu")
        DGV.ReadOnly = True
    End Sub

    Private Sub CmdSimpan_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSimpan.Click
        If TKode.Text = "" Or TNama.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            cmd = New OleDbCommand("Select * from barang where kode_barang='" & TKode.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                Dim sqltambah As String = "Insert into barang(Kode_Barang,Nama_Barang,Dosis,Bentuk,Harga, jumlah_barang,satuan,kategori) values " & _
                "('" & TKode.Text & "','" & TNama.Text & "','" & TBeli.Text & "','" & TJumlah.Text & "','" & THarga.Text & "','" & TJual.Text & "','" & CmbSatuan.Text & "','" & ComboBox1.Text & "')"
                cmd = New OleDbCommand(sqltambah, Conn)
                cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            Else
                Dim sqledit As String = "Update Barang set " & _
                "Nama_Barang='" & TNama.Text & "', " & _
                "Dosis='" & TBeli.Text & "', " & _
                "Bentuk='" & TJumlah.Text & "', " & _
                "Harga='" & THarga.Text & "', " & _
                "Jumlah_Barang='" & TJual.Text & "', " & _
                "Satuan='" & CmbSatuan.Text & "' " & _
                "Kategori='" & ComboBox1.Text & "' " & _
                "where Kode_Barang='" & TKode.Text & "'"
                cmd = New OleDbCommand(sqledit, Conn)
                cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            End If
        End If
    End Sub

    Private Sub CmdBatal_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBatal.Click
        Call Kosongkan()
        Call Kunci()
    End Sub

    Private Sub CmdTutup_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdTutup.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBaru.Click
        Call KunciBuka()
        Call Kosongkan()
    End Sub

    Private Sub DGV_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.RowHeaderMouseClick
        If Not IsDBNull(DGV.SelectedCells(0).Value) Then
            TKode.Text = DGV.SelectedCells(0).Value
            TNama.Text = DGV.SelectedCells(1).Value
            TBeli.Text = DGV.SelectedCells(2).Value
            TJual.Text = DGV.SelectedCells(5).Value
            THarga.Text = DGV.SelectedCells(4).Value
            TJumlah.Text = DGV.SelectedCells(3).Value
            CmbSatuan.Text = DGV.SelectedCells(6).Value
            ComboBox1.Text = DGV.SelectedCells(7).Value
        Else
            Call Kosongkan()
        End If
    End Sub

    Private Sub CmdHapus_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdHapus.Click
        If TKode.Text = "" Then
            MsgBox("Tabel belum dipilih..")
        Else
            If MsgBox("Data yakin akan dihapus?", vbYesNo) = vbYes Then
                If Conn.State = ConnectionState.Closed Then Conn.Open()
                str = "delete from Barang where Kode_Barang= '" & TKode.Text & "'"
                cmd = New OleDbCommand(str, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data anda telah dibuang dan di hapus")
                Call Kosongkan()
                Call Tampilkan()
                Conn.Close()
            End If
        End If
    End Sub

    Private Sub CmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEdit.Click
        Call KunciBuka()
        TKode.Enabled = False
        If TKode.Text = "" Then
            MsgBox("Data belum dipilih ..")
        Else
            Call KunciBuka()
            TKode.Enabled = False
            ' Cmdedit.Enabled = True
            CmdBatal.Enabled = True
            CmdSimpan.Enabled = True
            TNama.Focus()
        End If
    End Sub
End Class
