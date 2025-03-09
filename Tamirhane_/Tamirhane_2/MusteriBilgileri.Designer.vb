<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MusteriBilgileri
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtTCFiltreleme = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtTelefon = New System.Windows.Forms.TextBox()
        Me.txtSoyad = New System.Windows.Forms.TextBox()
        Me.btnSil = New System.Windows.Forms.Button()
        Me.btnGuncelle = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.txtAdres = New System.Windows.Forms.TextBox()
        Me.txtTC = New System.Windows.Forms.TextBox()
        Me.txtAd = New System.Windows.Forms.TextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTCFiltreleme
        '
        Me.txtTCFiltreleme.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTCFiltreleme.Location = New System.Drawing.Point(1095, 37)
        Me.txtTCFiltreleme.Multiline = True
        Me.txtTCFiltreleme.Name = "txtTCFiltreleme"
        Me.txtTCFiltreleme.Size = New System.Drawing.Size(180, 36)
        Me.txtTCFiltreleme.TabIndex = 10
        Me.txtTCFiltreleme.Text = " "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(688, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "TC Numarası Üzerinden Filtreleme :"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.RosyBrown
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtTelefon)
        Me.Panel3.Controls.Add(Me.txtSoyad)
        Me.Panel3.Controls.Add(Me.btnSil)
        Me.Panel3.Controls.Add(Me.btnGuncelle)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.btnKaydet)
        Me.Panel3.Controls.Add(Me.txtAdres)
        Me.Panel3.Controls.Add(Me.txtTC)
        Me.Panel3.Controls.Add(Me.txtAd)
        Me.Panel3.Controls.Add(Me.txtMail)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(27, 17)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(602, 591)
        Me.Panel3.TabIndex = 9
        '
        'txtTelefon
        '
        Me.txtTelefon.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTelefon.Location = New System.Drawing.Point(286, 259)
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(196, 34)
        Me.txtTelefon.TabIndex = 4
        '
        'txtSoyad
        '
        Me.txtSoyad.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSoyad.Location = New System.Drawing.Point(286, 203)
        Me.txtSoyad.Name = "txtSoyad"
        Me.txtSoyad.Size = New System.Drawing.Size(196, 34)
        Me.txtSoyad.TabIndex = 3
        '
        'btnSil
        '
        Me.btnSil.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnSil.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSil.Image = Global.Tamirhane_2.My.Resources.Resources.Sil
        Me.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSil.Location = New System.Drawing.Point(48, 474)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(125, 72)
        Me.btnSil.TabIndex = 9
        Me.btnSil.Text = "SİL"
        Me.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSil.UseVisualStyleBackColor = False
        '
        'btnGuncelle
        '
        Me.btnGuncelle.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnGuncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnGuncelle.Image = Global.Tamirhane_2.My.Resources.Resources.Güncelle
        Me.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuncelle.Location = New System.Drawing.Point(179, 474)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(173, 72)
        Me.btnGuncelle.TabIndex = 8
        Me.btnGuncelle.Text = "GÜNCELLE"
        Me.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuncelle.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(61, 311)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 20)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Mail :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(61, 367)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 20)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Adres :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(59, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Telefon Numarası :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(59, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 20)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "TC Numarası :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Soyad :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Ad :"
        '
        'btnKaydet
        '
        Me.btnKaydet.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnKaydet.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKaydet.Image = Global.Tamirhane_2.My.Resources.Resources.Kaydet
        Me.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKaydet.Location = New System.Drawing.Point(358, 474)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(163, 72)
        Me.btnKaydet.TabIndex = 7
        Me.btnKaydet.Text = "KAYDET"
        Me.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKaydet.UseVisualStyleBackColor = False
        '
        'txtAdres
        '
        Me.txtAdres.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtAdres.Location = New System.Drawing.Point(286, 367)
        Me.txtAdres.Multiline = True
        Me.txtAdres.Name = "txtAdres"
        Me.txtAdres.Size = New System.Drawing.Size(293, 82)
        Me.txtAdres.TabIndex = 6
        '
        'txtTC
        '
        Me.txtTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTC.Location = New System.Drawing.Point(286, 99)
        Me.txtTC.Name = "txtTC"
        Me.txtTC.Size = New System.Drawing.Size(196, 34)
        Me.txtTC.TabIndex = 1
        '
        'txtAd
        '
        Me.txtAd.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtAd.Location = New System.Drawing.Point(286, 149)
        Me.txtAd.Name = "txtAd"
        Me.txtAd.Size = New System.Drawing.Size(196, 34)
        Me.txtAd.TabIndex = 2
        '
        'txtMail
        '
        Me.txtMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtMail.Location = New System.Drawing.Point(286, 311)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(196, 34)
        Me.txtMail.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(255, 29)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "MÜŞTERİ BİLGİLERİ"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(635, 104)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(842, 500)
        Me.DataGridView1.TabIndex = 8
        '
        'MusteriBilgileri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1504, 620)
        Me.Controls.Add(Me.txtTCFiltreleme)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MusteriBilgileri"
        Me.Text = "MusteriBilgileri"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTCFiltreleme As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnSil As Button
    Friend WithEvents btnGuncelle As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnKaydet As Button
    Friend WithEvents txtAdres As TextBox
    Friend WithEvents txtTC As TextBox
    Friend WithEvents txtAd As TextBox
    Friend WithEvents txtMail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtTelefon As TextBox
    Friend WithEvents txtSoyad As TextBox
End Class
