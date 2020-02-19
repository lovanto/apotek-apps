<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penjualan1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Penjualan1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Dibayar = New System.Windows.Forms.TextBox()
        Me.BTNTutup = New System.Windows.Forms.Button()
        Me.BTNBatal = New System.Windows.Forms.Button()
        Me.BTNSimpan = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Item = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Kembali = New System.Windows.Forms.Label()
        Me.Jam = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Tanggal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Faktur = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 380)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 28)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "Kode Barang"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(547, 50)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Transaksi Penjualan"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(15, 98)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(519, 227)
        Me.DGV.TabIndex = 37
        '
        'Dibayar
        '
        Me.Dibayar.Location = New System.Drawing.Point(434, 366)
        Me.Dibayar.Name = "Dibayar"
        Me.Dibayar.Size = New System.Drawing.Size(100, 20)
        Me.Dibayar.TabIndex = 54
        Me.Dibayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BTNTutup
        '
        Me.BTNTutup.Location = New System.Drawing.Point(177, 343)
        Me.BTNTutup.Name = "BTNTutup"
        Me.BTNTutup.Size = New System.Drawing.Size(75, 25)
        Me.BTNTutup.TabIndex = 53
        Me.BTNTutup.Text = "Tutup"
        Me.BTNTutup.UseVisualStyleBackColor = True
        '
        'BTNBatal
        '
        Me.BTNBatal.Location = New System.Drawing.Point(96, 343)
        Me.BTNBatal.Name = "BTNBatal"
        Me.BTNBatal.Size = New System.Drawing.Size(75, 25)
        Me.BTNBatal.TabIndex = 52
        Me.BTNBatal.Text = "Batal"
        Me.BTNBatal.UseVisualStyleBackColor = True
        '
        'BTNSimpan
        '
        Me.BTNSimpan.Location = New System.Drawing.Point(15, 343)
        Me.BTNSimpan.Name = "BTNSimpan"
        Me.BTNSimpan.Size = New System.Drawing.Size(75, 25)
        Me.BTNSimpan.TabIndex = 51
        Me.BTNSimpan.Text = "Simpan"
        Me.BTNSimpan.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Location = New System.Drawing.Point(258, 343)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 20)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Item"
        '
        'Item
        '
        Me.Item.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Item.Location = New System.Drawing.Point(306, 343)
        Me.Item.Name = "Item"
        Me.Item.Size = New System.Drawing.Size(48, 20)
        Me.Item.TabIndex = 49
        Me.Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(372, 343)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 20)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Total"
        '
        'Total
        '
        Me.Total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Total.Location = New System.Drawing.Point(434, 343)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(100, 20)
        Me.Total.TabIndex = 47
        Me.Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(372, 368)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 20)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Dibayar"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(372, 389)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 20)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Kembali"
        '
        'Kembali
        '
        Me.Kembali.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Kembali.Location = New System.Drawing.Point(434, 389)
        Me.Kembali.Name = "Kembali"
        Me.Kembali.Size = New System.Drawing.Size(100, 20)
        Me.Kembali.TabIndex = 44
        Me.Kembali.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Jam
        '
        Me.Jam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Jam.Location = New System.Drawing.Point(431, 66)
        Me.Jam.Name = "Jam"
        Me.Jam.Size = New System.Drawing.Size(100, 20)
        Me.Jam.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(383, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 20)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Jam"
        '
        'Tanggal
        '
        Me.Tanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Tanggal.Location = New System.Drawing.Point(254, 66)
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.Size = New System.Drawing.Size(100, 20)
        Me.Tanggal.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(191, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Tanggal"
        '
        'Faktur
        '
        Me.Faktur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Faktur.Location = New System.Drawing.Point(63, 66)
        Me.Faktur.Name = "Faktur"
        Me.Faktur.Size = New System.Drawing.Size(100, 20)
        Me.Faktur.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(12, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Faktur"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 420)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Dibayar)
        Me.Controls.Add(Me.BTNTutup)
        Me.Controls.Add(Me.BTNBatal)
        Me.Controls.Add(Me.BTNSimpan)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Item)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Kembali)
        Me.Controls.Add(Me.Jam)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Tanggal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Faktur)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Penjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penjualan"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Dibayar As System.Windows.Forms.TextBox
    Friend WithEvents BTNTutup As System.Windows.Forms.Button
    Friend WithEvents BTNBatal As System.Windows.Forms.Button
    Friend WithEvents BTNSimpan As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Item As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Total As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Kembali As System.Windows.Forms.Label
    Friend WithEvents Jam As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Tanggal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Faktur As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
