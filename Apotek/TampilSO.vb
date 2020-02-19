Imports System.Data.OleDb

Public Class TampilSO
    Sub Kosongkan()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox1.Focus()
    End Sub
    Sub DataBaru()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox1.Focus()
    End Sub
    Sub Tampilkan()
        da = New OleDbDataAdapter("Select * from StokOfName order by 1", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "StokOfName")
        DGV.DataSource = (ds.Tables("StokOfName"))
        DGV.ReadOnly = True
    End Sub
    Sub BtnBuka()
        cmdhapus.Enabled = True
        cmdtutup.Enabled = True
        cmdbatal.Enabled = True
    End Sub
    Sub BtnTutup()
        cmdhapus.Enabled = False
        cmdtutup.Enabled = False
        cmdbatal.Enabled = False
    End Sub
    Sub TxtKunci()

    End Sub
    Sub TxtBuka()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True
        TextBox8.Enabled = True
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Tampilkan()
        Call TxtKunci()
        cmdbatal.Enabled = False
    End Sub

    Private Sub TampilSO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Tampilkan()
        Call TxtKunci()
        cmdbatal.Enabled = False
    End Sub

    Private Sub DGV_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.RowHeaderMouseClick
        If Not IsDBNull(DGV.SelectedCells(0).Value) Then
            TextBox1.Text = DGV.SelectedCells(0).Value
            TextBox2.Text = DGV.SelectedCells(2).Value
            TextBox3.Text = DGV.SelectedCells(4).Value
            TextBox4.Text = DGV.SelectedCells(3).Value
            TextBox5.Text = DGV.SelectedCells(7).Value
            TextBox6.Text = DGV.SelectedCells(6).Value
            TextBox7.Text = DGV.SelectedCells(8).Value
            TextBox8.Text = DGV.SelectedCells(1).Value
            TextBox9.Text = DGV.SelectedCells(5).Value
        Else
            Call Kosongkan()
        End If
    End Sub

    Private Sub cmdtutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtutup.Click
        Me.Close()
    End Sub

    Private Sub cmdbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbatal.Click
        Call Kosongkan()
        Call TxtKunci()
        Call BtnBuka()
        cmdbatal.Enabled = False
    End Sub

    Private Sub cmdhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdhapus.Click
        If TextBox1.Text = "" Then
            MsgBox("Tabel belum dipilih..")
        Else
            If MsgBox("Data yakin akan dihapus?", vbYesNo) = vbYes Then
                If Conn.State = ConnectionState.Closed Then Conn.Open()
                cmd = New OleDbCommand("Delete * from StokOfName where KCek='" & TextBox2.Text & "'", Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data anda telah dibuang dan di hapus")
                Call Kosongkan()
                Call Tampilkan()
                Conn.Close()
            End If
        End If
    End Sub
End Class