<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Perkursor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Perkursor))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TNama = New System.Windows.Forms.TextBox()
        Me.TZat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBentuk = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TSatuan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TJumlah = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TKet = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CmdSimpan = New System.Windows.Forms.Button()
        Me.CmdBaru = New System.Windows.Forms.Button()
        Me.CmdBatal = New System.Windows.Forms.Button()
        Me.CmdTutup = New System.Windows.Forms.Button()
        Me.Jam = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tanggal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CmdHapus = New System.Windows.Forms.Button()
        Me.CmdEdit = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(697, 50)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Data Barang / Obat Prekursor"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Nama Obat"
        '
        'TNama
        '
        Me.TNama.Location = New System.Drawing.Point(76, 64)
        Me.TNama.Name = "TNama"
        Me.TNama.Size = New System.Drawing.Size(147, 20)
        Me.TNama.TabIndex = 38
        '
        'TZat
        '
        Me.TZat.Location = New System.Drawing.Point(76, 90)
        Me.TZat.Name = "TZat"
        Me.TZat.Size = New System.Drawing.Size(120, 20)
        Me.TZat.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Zat Aktif"
        '
        'TBentuk
        '
        Me.TBentuk.Location = New System.Drawing.Point(323, 64)
        Me.TBentuk.Name = "TBentuk"
        Me.TBentuk.Size = New System.Drawing.Size(111, 20)
        Me.TBentuk.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(274, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Bentuk"
        '
        'TSatuan
        '
        Me.TSatuan.Location = New System.Drawing.Point(323, 90)
        Me.TSatuan.Name = "TSatuan"
        Me.TSatuan.Size = New System.Drawing.Size(86, 20)
        Me.TSatuan.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(274, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Satuan"
        '
        'TJumlah
        '
        Me.TJumlah.Location = New System.Drawing.Point(323, 116)
        Me.TJumlah.Name = "TJumlah"
        Me.TJumlah.Size = New System.Drawing.Size(98, 20)
        Me.TJumlah.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(274, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Jumlah"
        '
        'TKet
        '
        Me.TKet.Location = New System.Drawing.Point(514, 156)
        Me.TKet.Multiline = True
        Me.TKet.Name = "TKet"
        Me.TKet.Size = New System.Drawing.Size(166, 72)
        Me.TKet.TabIndex = 48
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(449, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Keterangan"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 152)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(423, 163)
        Me.DataGridView1.TabIndex = 49
        '
        'CmdSimpan
        '
        Me.CmdSimpan.Location = New System.Drawing.Point(448, 250)
        Me.CmdSimpan.Name = "CmdSimpan"
        Me.CmdSimpan.Size = New System.Drawing.Size(75, 23)
        Me.CmdSimpan.TabIndex = 50
        Me.CmdSimpan.Text = "Simpan"
        Me.CmdSimpan.UseVisualStyleBackColor = True
        '
        'CmdBaru
        '
        Me.CmdBaru.Location = New System.Drawing.Point(529, 250)
        Me.CmdBaru.Name = "CmdBaru"
        Me.CmdBaru.Size = New System.Drawing.Size(75, 23)
        Me.CmdBaru.TabIndex = 51
        Me.CmdBaru.Text = "Baru"
        Me.CmdBaru.UseVisualStyleBackColor = True
        '
        'CmdBatal
        '
        Me.CmdBatal.Location = New System.Drawing.Point(610, 250)
        Me.CmdBatal.Name = "CmdBatal"
        Me.CmdBatal.Size = New System.Drawing.Size(75, 23)
        Me.CmdBatal.TabIndex = 52
        Me.CmdBatal.Text = "Batal"
        Me.CmdBatal.UseVisualStyleBackColor = True
        '
        'CmdTutup
        '
        Me.CmdTutup.Location = New System.Drawing.Point(529, 279)
        Me.CmdTutup.Name = "CmdTutup"
        Me.CmdTutup.Size = New System.Drawing.Size(75, 23)
        Me.CmdTutup.TabIndex = 53
        Me.CmdTutup.Text = "Tutup"
        Me.CmdTutup.UseVisualStyleBackColor = True
        '
        'Jam
        '
        Me.Jam.Location = New System.Drawing.Point(552, 64)
        Me.Jam.Name = "Jam"
        Me.Jam.Size = New System.Drawing.Size(111, 20)
        Me.Jam.TabIndex = 55
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(503, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Jam"
        '
        'Tanggal
        '
        Me.Tanggal.Location = New System.Drawing.Point(552, 93)
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.Size = New System.Drawing.Size(111, 20)
        Me.Tanggal.TabIndex = 57
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(503, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Tanggal"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'CmdHapus
        '
        Me.CmdHapus.Location = New System.Drawing.Point(448, 279)
        Me.CmdHapus.Name = "CmdHapus"
        Me.CmdHapus.Size = New System.Drawing.Size(75, 23)
        Me.CmdHapus.TabIndex = 58
        Me.CmdHapus.Text = "Hapus"
        Me.CmdHapus.UseVisualStyleBackColor = True
        '
        'CmdEdit
        '
        Me.CmdEdit.Location = New System.Drawing.Point(610, 279)
        Me.CmdEdit.Name = "CmdEdit"
        Me.CmdEdit.Size = New System.Drawing.Size(75, 23)
        Me.CmdEdit.TabIndex = 59
        Me.CmdEdit.Text = "Edit"
        Me.CmdEdit.UseVisualStyleBackColor = True
        '
        'Perkursor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 329)
        Me.Controls.Add(Me.CmdEdit)
        Me.Controls.Add(Me.CmdHapus)
        Me.Controls.Add(Me.Tanggal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Jam)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CmdTutup)
        Me.Controls.Add(Me.CmdBatal)
        Me.Controls.Add(Me.CmdBaru)
        Me.Controls.Add(Me.CmdSimpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TKet)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TJumlah)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TSatuan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBentuk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TZat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TNama)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Name = "Perkursor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Perkursor"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TNama As System.Windows.Forms.TextBox
    Friend WithEvents TZat As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBentuk As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TSatuan As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TJumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TKet As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CmdSimpan As System.Windows.Forms.Button
    Friend WithEvents CmdBaru As System.Windows.Forms.Button
    Friend WithEvents CmdBatal As System.Windows.Forms.Button
    Friend WithEvents CmdTutup As System.Windows.Forms.Button
    Friend WithEvents Jam As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Tanggal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CmdHapus As System.Windows.Forms.Button
    Friend WithEvents CmdEdit As System.Windows.Forms.Button
End Class
