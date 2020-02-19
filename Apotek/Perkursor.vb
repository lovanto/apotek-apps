Imports System.Data.OleDb

Public Class Perkursor

    Sub Kosongkan()
        TNama.Text = ""
        TZat.Text = ""
        TBentuk.Text = ""
        TSatuan.Text = ""
        TJumlah.Text = ""
        TKet.Text = ""
        TNama.Focus()
    End Sub
    Sub DataBaru()
        TNama.Text = ""
        TZat.Text = ""
        TBentuk.Text = ""
        TSatuan.Text = ""
        TJumlah.Text = ""
        TKet.Text = ""
        TNama.Focus()
    End Sub
    Sub Tampilkan()
        da = New OleDbDataAdapter("Select * from Perkursor order by 1", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Perkursor")
        DataGridView1.DataSource = (ds.Tables("Perkursor"))
        DataGridView1.ReadOnly = True
    End Sub
    Sub BtnBuka()
        CmdSimpan.Enabled = True
        CmdBaru.Enabled = True
        CmdHapus.Enabled = True
        CmdEdit.Enabled = True
        CmdTutup.Enabled = True
        CmdBatal.Enabled = True
    End Sub
    Sub BtnTutup()
        CmdSimpan.Enabled = False
        CmdBaru.Enabled = False
        CmdHapus.Enabled = False
        CmdEdit.Enabled = False
        CmdTutup.Enabled = False
        CmdBatal.Enabled = False
    End Sub
    Sub TxtKunci()
        TNama.Enabled = False
        TZat.Enabled = False
        TBentuk.Enabled = False
        TSatuan.Enabled = False
        TJumlah.Enabled = False
        TKet.Enabled = False
    End Sub
    Sub TxtBuka()
        TNama.Enabled = True
        TZat.Enabled = True
        TBentuk.Enabled = True
        TSatuan.Enabled = True
        TJumlah.Enabled = True
        TKet.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Jam.Text = TimeOfDay
    End Sub

    Private Sub Perkursor_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Tanggal.Text = Today
        Jam.ReadOnly = True
        Tanggal.ReadOnly = True
    End Sub

    Private Sub Perkursor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Tampilkan()
        Call TxtKunci()
        CmdSimpan.Enabled = False
        CmdBatal.Enabled = False
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        If Not IsDBNull(DataGridView1.SelectedCells(0).Value) Then
            TNama.Text = DataGridView1.SelectedCells(0).Value
            TZat.Text = DataGridView1.SelectedCells(1).Value
            TBentuk.Text = DataGridView1.SelectedCells(2).Value
            TSatuan.Text = DataGridView1.SelectedCells(3).Value
            TJumlah.Text = DataGridView1.SelectedCells(4).Value
            TKet.Text = DataGridView1.SelectedCells(5).Value
        Else
            Call Kosongkan()
        End If
    End Sub

    Private Sub CmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSimpan.Click
        If TNama.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            cmd = New OleDbCommand("Select * from Perkursor where nama='" & TNama.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                Dim sqltambah As String = "Insert into Perkursor(nama,kzat,bentuk,satuan,jumlah,ket) values " & _
                "('" & TNama.Text & "','" & TZat.Text & "','" & TBentuk.Text & "','" & TSatuan.Text & "','" & TJumlah.Text & "','" & TKet.Text & "')"
                cmd = New OleDbCommand(sqltambah, Conn)
                cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
                BtnBuka()
                Call TxtKunci()
                CmdSimpan.Enabled = False
                CmdBatal.Enabled = False
            Else
                Dim sqledit As String = "update Perkursor set kzat ='" & TZat.Text & _
                 "', bentuk ='" & TBentuk.Text & _
                 "', satuan ='" & TSatuan.Text & _
                 "', jumlah ='" & TJumlah.Text & _
                 "', ket ='" & TKet.Text & _
                 "' where nama = '" & TNama.Text & "'"
                cmd = New OleDbCommand(sqledit, Conn)
                cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            End If
        End If
    End Sub

    Private Sub CmdBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBaru.Click
        Call TxtBuka()
        Call Kosongkan()
        CmdSimpan.Enabled = True
        CmdBaru.Enabled = False
        CmdBatal.Enabled = True
        CmdEdit.Enabled = False
        CmdTutup.Enabled = False
        CmdHapus.Enabled = False
        TNama.Focus()
    End Sub

    Private Sub CmdBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBatal.Click
        Call Kosongkan()
        Call TxtKunci()
        Call BtnBuka()
        CmdSimpan.Enabled = False
        CmdBatal.Enabled = False
    End Sub

    Private Sub CmdHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdHapus.Click
        If TNama.Text = "" Then
            MsgBox("Tabel belum dipilih..")
        Else
            If MsgBox("Data yakin akan dihapus?", vbYesNo) = vbYes Then
                If Conn.State = ConnectionState.Closed Then Conn.Open()
                str = "delete from Perkursor where nama = '" & TNama.Text & "'"
                cmd = New OleDbCommand(str, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data anda telah dibuang dan di hapus")
                Call Kosongkan()
                Call Tampilkan()
                Conn.Close()
            End If
        End If
    End Sub

    Private Sub CmdTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdTutup.Click
        End
    End Sub

    Private Sub CmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEdit.Click
        If TNama.Text = "" Then
            MsgBox("Data belum dipilih ..")
        Else
            Call TxtBuka()
            Call BtnTutup()
            ' Cmdedit.Enabled = True
            CmdBatal.Enabled = True
            CmdSimpan.Enabled = True
            CmdSimpan.Text = "Perbarui"
            TNama.Enabled = False
            TZat.Focus()
        End If
    End Sub
End Class