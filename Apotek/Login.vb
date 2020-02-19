Imports System.Data.OleDb

Public Class Login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Koneksi()
        cmd = New OleDbCommand("select * from Petugas where NamaPTG='" & TextBox1.Text & "' and PasswordPtg='" & TextBox2.Text & "'", Conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Me.Visible = False
            mastermenu.Show()
            mastermenu.Panel1.Text = rd.GetString(0)
            mastermenu.Panel2.Text = rd.GetString(1)
            mastermenu.Panel3.Text = rd.GetString(3)
            If mastermenu.Panel3.Text <> "ADMINISTRATOR" Then
                MasterMenu.PetugasToolStripMenuItem.Enabled = False
            Else
                MasterMenu.PetugasToolStripMenuItem.Enabled = True
            End If
        Else
            MsgBox("login salah, periksan kembali user name dan password")
            TextBox1.Focus()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then TextBox2.Focus()
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then Button1.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class