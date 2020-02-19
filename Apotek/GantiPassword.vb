Imports System.Data.OleDb

Public Class GantiPassword

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Koneksi()

        If e.KeyChar = Chr(13) Then
            cmd = New OleDbCommand("select * from petugas where namaptg='" & TextBox1.Text & "' and kodeptg='" & MasterMenu.Panel1.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                TextBox2.Enabled = True
                TextBox2.Focus()
            Else
                MsgBox("Anda tidak berhak mengganti password disini")
                TextBox1.Focus()
            End If
        End If
    End Sub


    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Koneksi()

        If e.KeyChar = Chr(13) Then
            cmd = New OleDbCommand("select * from petugas where namaptg='" & MasterMenu.Panel2.Text & "' and passwordptg='" & TextBox2.Text & "' ", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                TextBox3.Enabled = True
                TextBox3.Focus()
            Else
                MsgBox("Password lama salah")
                TextBox2.Focus()
            End If
        End If

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        Koneksi()

        If e.KeyChar = Chr(13) Then
            If TextBox3.Text = "" Then
                MsgBox("Passwrod baru wajib diisi")
                TextBox3.Focus()
            Else
                TextBox4.Enabled = True
                TextBox4.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        Koneksi()

        If e.KeyChar = Chr(13) Then
            If TextBox4.Text <> TextBox3.Text Then
                MsgBox("Password konfirmasi salah")
                TextBox4.Focus()
            Else
                If MessageBox.Show("Yakin akan ganti password..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim ganti As String = "Update petugas set passwordptg='" & TextBox3.Text & "' where namaptg='" & TextBox1.Text & "' and kodeptg='" & MasterMenu.Panel1.Text & "'"
                    cmd = New OleDbCommand(ganti, Conn)
                    cmd.ExecuteNonQuery()
                    TextBox1.Clear()
                    TextBox2.Clear()
                    TextBox3.Clear()
                    TextBox4.Clear()
                    Me.Close()
                Else
                    TextBox1.Clear()
                    TextBox2.Clear()
                    TextBox3.Clear()
                    TextBox4.Clear()
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub GantiPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
    End Sub

End Class