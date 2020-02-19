<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Retur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Retur))
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TTanggalRetur = New System.Windows.Forms.TextBox()
        Me.TFaktur = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CmdTutup = New System.Windows.Forms.Button()
        Me.TItemretur = New System.Windows.Forms.TextBox()
        Me.TTotalRetur = New System.Windows.Forms.TextBox()
        Me.CmdBatal = New System.Windows.Forms.Button()
        Me.TDibayarRetur = New System.Windows.Forms.TextBox()
        Me.TKembaliRetur = New System.Windows.Forms.TextBox()
        Me.TSubtotal = New System.Windows.Forms.TextBox()
        Me.TJumlah = New System.Windows.Forms.TextBox()
        Me.THarga = New System.Windows.Forms.TextBox()
        Me.TNama = New System.Windows.Forms.TextBox()
        Me.TKode = New System.Windows.Forms.TextBox()
        Me.CmdSimpan = New System.Windows.Forms.Button()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TKasir = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TTanggal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TKembali = New System.Windows.Forms.TextBox()
        Me.TDibayar = New System.Windows.Forms.TextBox()
        Me.TTotal = New System.Windows.Forms.TextBox()
        Me.TItem = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label18
        '
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label18.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Image = CType(resources.GetObject("Label18.Image"), System.Drawing.Image)
        Me.Label18.Location = New System.Drawing.Point(0, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(585, 50)
        Me.Label18.TabIndex = 126
        Me.Label18.Text = "Retur Penjualan"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(380, 59)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 13)
        Me.Label17.TabIndex = 125
        Me.Label17.Text = "Tanggal Retur"
        '
        'TTanggalRetur
        '
        Me.TTanggalRetur.Enabled = False
        Me.TTanggalRetur.Location = New System.Drawing.Point(468, 56)
        Me.TTanggalRetur.Name = "TTanggalRetur"
        Me.TTanggalRetur.Size = New System.Drawing.Size(100, 20)
        Me.TTanggalRetur.TabIndex = 124
        '
        'TFaktur
        '
        Me.TFaktur.Location = New System.Drawing.Point(92, 56)
        Me.TFaktur.Name = "TFaktur"
        Me.TFaktur.Size = New System.Drawing.Size(100, 20)
        Me.TFaktur.TabIndex = 87
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(473, 288)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 123
        Me.Label11.Text = "Sub Total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(418, 287)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 122
        Me.Label10.Text = "Jumlah"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(312, 287)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 121
        Me.Label9.Text = "Harga"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(120, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 120
        Me.Label8.Text = "Nama Barang"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(416, 507)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 118
        Me.Label12.Text = "Kembali"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(416, 481)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 117
        Me.Label13.Text = "Dibayar"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(416, 453)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 116
        Me.Label14.Text = "Total"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(276, 450)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 13)
        Me.Label15.TabIndex = 115
        Me.Label15.Text = "Item"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(17, 287)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 13)
        Me.Label16.TabIndex = 119
        Me.Label16.Text = "Kode Barang"
        '
        'CmdTutup
        '
        Me.CmdTutup.Location = New System.Drawing.Point(182, 448)
        Me.CmdTutup.Name = "CmdTutup"
        Me.CmdTutup.Size = New System.Drawing.Size(75, 23)
        Me.CmdTutup.TabIndex = 114
        Me.CmdTutup.Text = "Tutup"
        Me.CmdTutup.UseVisualStyleBackColor = True
        '
        'TItemretur
        '
        Me.TItemretur.Enabled = False
        Me.TItemretur.Location = New System.Drawing.Point(308, 448)
        Me.TItemretur.Name = "TItemretur"
        Me.TItemretur.Size = New System.Drawing.Size(60, 20)
        Me.TItemretur.TabIndex = 113
        Me.TItemretur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TTotalRetur
        '
        Me.TTotalRetur.Enabled = False
        Me.TTotalRetur.Location = New System.Drawing.Point(468, 448)
        Me.TTotalRetur.Name = "TTotalRetur"
        Me.TTotalRetur.Size = New System.Drawing.Size(100, 20)
        Me.TTotalRetur.TabIndex = 108
        Me.TTotalRetur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CmdBatal
        '
        Me.CmdBatal.Location = New System.Drawing.Point(101, 448)
        Me.CmdBatal.Name = "CmdBatal"
        Me.CmdBatal.Size = New System.Drawing.Size(75, 23)
        Me.CmdBatal.TabIndex = 112
        Me.CmdBatal.Text = "Batal"
        Me.CmdBatal.UseVisualStyleBackColor = True
        '
        'TDibayarRetur
        '
        Me.TDibayarRetur.Enabled = False
        Me.TDibayarRetur.Location = New System.Drawing.Point(468, 480)
        Me.TDibayarRetur.Name = "TDibayarRetur"
        Me.TDibayarRetur.Size = New System.Drawing.Size(100, 20)
        Me.TDibayarRetur.TabIndex = 93
        '
        'TKembaliRetur
        '
        Me.TKembaliRetur.Enabled = False
        Me.TKembaliRetur.Location = New System.Drawing.Point(468, 504)
        Me.TKembaliRetur.Name = "TKembaliRetur"
        Me.TKembaliRetur.Size = New System.Drawing.Size(100, 20)
        Me.TKembaliRetur.TabIndex = 111
        '
        'TSubtotal
        '
        Me.TSubtotal.Location = New System.Drawing.Point(473, 304)
        Me.TSubtotal.Name = "TSubtotal"
        Me.TSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.TSubtotal.TabIndex = 92
        '
        'TJumlah
        '
        Me.TJumlah.Location = New System.Drawing.Point(421, 304)
        Me.TJumlah.Name = "TJumlah"
        Me.TJumlah.Size = New System.Drawing.Size(44, 20)
        Me.TJumlah.TabIndex = 91
        '
        'THarga
        '
        Me.THarga.Location = New System.Drawing.Point(315, 304)
        Me.THarga.Name = "THarga"
        Me.THarga.Size = New System.Drawing.Size(100, 20)
        Me.THarga.TabIndex = 90
        '
        'TNama
        '
        Me.TNama.Location = New System.Drawing.Point(123, 304)
        Me.TNama.Name = "TNama"
        Me.TNama.Size = New System.Drawing.Size(178, 20)
        Me.TNama.TabIndex = 89
        '
        'TKode
        '
        Me.TKode.Location = New System.Drawing.Point(17, 304)
        Me.TKode.Name = "TKode"
        Me.TKode.Size = New System.Drawing.Size(100, 20)
        Me.TKode.TabIndex = 88
        '
        'CmdSimpan
        '
        Me.CmdSimpan.Location = New System.Drawing.Point(20, 448)
        Me.CmdSimpan.Name = "CmdSimpan"
        Me.CmdSimpan.Size = New System.Drawing.Size(75, 23)
        Me.CmdSimpan.TabIndex = 110
        Me.CmdSimpan.Text = "Simpan"
        Me.CmdSimpan.UseVisualStyleBackColor = True
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(20, 332)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(552, 100)
        Me.DGV1.TabIndex = 109
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "Nomor Faktur"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "Kasir"
        '
        'TKasir
        '
        Me.TKasir.Enabled = False
        Me.TKasir.Location = New System.Drawing.Point(73, 227)
        Me.TKasir.Name = "TKasir"
        Me.TKasir.Size = New System.Drawing.Size(100, 20)
        Me.TKasir.TabIndex = 105
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Tanggal"
        '
        'TTanggal
        '
        Me.TTanggal.Enabled = False
        Me.TTanggal.Location = New System.Drawing.Point(73, 203)
        Me.TTanggal.Name = "TTanggal"
        Me.TTanggal.Size = New System.Drawing.Size(100, 20)
        Me.TTanggal.TabIndex = 103
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(417, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "Kembali"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(417, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Dibayar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(417, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Total"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 251)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Item"
        '
        'TKembali
        '
        Me.TKembali.Enabled = False
        Me.TKembali.Location = New System.Drawing.Point(475, 256)
        Me.TKembali.Name = "TKembali"
        Me.TKembali.Size = New System.Drawing.Size(100, 20)
        Me.TKembali.TabIndex = 98
        Me.TKembali.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TDibayar
        '
        Me.TDibayar.Enabled = False
        Me.TDibayar.Location = New System.Drawing.Point(475, 230)
        Me.TDibayar.Name = "TDibayar"
        Me.TDibayar.Size = New System.Drawing.Size(100, 20)
        Me.TDibayar.TabIndex = 95
        Me.TDibayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TTotal
        '
        Me.TTotal.Enabled = False
        Me.TTotal.Location = New System.Drawing.Point(475, 204)
        Me.TTotal.Name = "TTotal"
        Me.TTotal.Size = New System.Drawing.Size(100, 20)
        Me.TTotal.TabIndex = 97
        Me.TTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TItem
        '
        Me.TItem.Enabled = False
        Me.TItem.Location = New System.Drawing.Point(73, 251)
        Me.TItem.Name = "TItem"
        Me.TItem.Size = New System.Drawing.Size(100, 20)
        Me.TItem.TabIndex = 96
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 82)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(560, 111)
        Me.DGV.TabIndex = 94
        '
        'Retur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 535)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TTanggalRetur)
        Me.Controls.Add(Me.TFaktur)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.CmdTutup)
        Me.Controls.Add(Me.TItemretur)
        Me.Controls.Add(Me.TTotalRetur)
        Me.Controls.Add(Me.CmdBatal)
        Me.Controls.Add(Me.TDibayarRetur)
        Me.Controls.Add(Me.TKembaliRetur)
        Me.Controls.Add(Me.TSubtotal)
        Me.Controls.Add(Me.TJumlah)
        Me.Controls.Add(Me.THarga)
        Me.Controls.Add(Me.TNama)
        Me.Controls.Add(Me.TKode)
        Me.Controls.Add(Me.CmdSimpan)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TKasir)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TTanggal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TKembali)
        Me.Controls.Add(Me.TDibayar)
        Me.Controls.Add(Me.TTotal)
        Me.Controls.Add(Me.TItem)
        Me.Controls.Add(Me.DGV)
        Me.Name = "Retur"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retur"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TTanggalRetur As System.Windows.Forms.TextBox
    Friend WithEvents TFaktur As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CmdTutup As System.Windows.Forms.Button
    Friend WithEvents TItemretur As System.Windows.Forms.TextBox
    Friend WithEvents TTotalRetur As System.Windows.Forms.TextBox
    Friend WithEvents CmdBatal As System.Windows.Forms.Button
    Friend WithEvents TDibayarRetur As System.Windows.Forms.TextBox
    Friend WithEvents TKembaliRetur As System.Windows.Forms.TextBox
    Friend WithEvents TSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents TJumlah As System.Windows.Forms.TextBox
    Friend WithEvents THarga As System.Windows.Forms.TextBox
    Friend WithEvents TNama As System.Windows.Forms.TextBox
    Friend WithEvents TKode As System.Windows.Forms.TextBox
    Friend WithEvents CmdSimpan As System.Windows.Forms.Button
    Friend WithEvents DGV1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TKasir As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TTanggal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TKembali As System.Windows.Forms.TextBox
    Friend WithEvents TDibayar As System.Windows.Forms.TextBox
    Friend WithEvents TTotal As System.Windows.Forms.TextBox
    Friend WithEvents TItem As System.Windows.Forms.TextBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
End Class
