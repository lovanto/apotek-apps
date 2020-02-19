Imports System.Data.OleDb

Public Class DaftarRetur

    Sub Tampilkan()
        cmd = New OleDbCommand("Select * from penjualan", Conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            ListBox1.Items.Add(rd.GetString(0))
        Loop
    End Sub

    Private Sub DaftarRetur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Tampilkan()
        ListBox1.Focus()
    End Sub

    Private Sub ListBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ListBox1.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
        If e.KeyChar = Chr(13) Then
            cmd = New OleDbCommand("select * from penjualan where Faktur='" & ListBox1.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Retur.TFaktur.Text = rd.GetString(0)
                Me.Hide()
                Retur.Show()
            End If
        End If
    End Sub

End Class