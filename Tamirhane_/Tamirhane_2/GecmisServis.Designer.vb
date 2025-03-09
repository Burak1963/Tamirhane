<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GecmisServis
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtSasefiltreleme = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtYapilanIslem = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSikayet = New System.Windows.Forms.TextBox()
        Me.txtKM = New System.Windows.Forms.TextBox()
        Me.txtAciklama = New System.Windows.Forms.TextBox()
        Me.btnguncelle = New System.Windows.Forms.Button()
        Me.lblSaseNo = New System.Windows.Forms.Label()
        Me.aa = New System.Windows.Forms.Label()
        Me.lblTarih = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(30, 114)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(697, 437)
        Me.DataGridView1.TabIndex = 0
        '
        'txtSasefiltreleme
        '
        Me.txtSasefiltreleme.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSasefiltreleme.Location = New System.Drawing.Point(460, 72)
        Me.txtSasefiltreleme.Multiline = True
        Me.txtSasefiltreleme.Name = "txtSasefiltreleme"
        Me.txtSasefiltreleme.Size = New System.Drawing.Size(180, 36)
        Me.txtSasefiltreleme.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 25)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Şase Numarası Üzerinden Filtreleme :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(279, 29)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Geçmiş Servis Bilgileri"
        '
        'txtYapilanIslem
        '
        Me.txtYapilanIslem.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtYapilanIslem.Location = New System.Drawing.Point(1045, 284)
        Me.txtYapilanIslem.Multiline = True
        Me.txtYapilanIslem.Name = "txtYapilanIslem"
        Me.txtYapilanIslem.Size = New System.Drawing.Size(295, 69)
        Me.txtYapilanIslem.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(872, 286)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 20)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Yapılan İşlem :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(872, 375)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Açıklama :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(872, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "KM :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(872, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 20)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Şikayet :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(917, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 20)
        Me.Label4.TabIndex = 58
        '
        'txtSikayet
        '
        Me.txtSikayet.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSikayet.Location = New System.Drawing.Point(1045, 137)
        Me.txtSikayet.Multiline = True
        Me.txtSikayet.Name = "txtSikayet"
        Me.txtSikayet.Size = New System.Drawing.Size(250, 82)
        Me.txtSikayet.TabIndex = 1
        '
        'txtKM
        '
        Me.txtKM.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtKM.Location = New System.Drawing.Point(1045, 244)
        Me.txtKM.Name = "txtKM"
        Me.txtKM.Size = New System.Drawing.Size(127, 34)
        Me.txtKM.TabIndex = 2
        '
        'txtAciklama
        '
        Me.txtAciklama.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtAciklama.Location = New System.Drawing.Point(1045, 373)
        Me.txtAciklama.Multiline = True
        Me.txtAciklama.Name = "txtAciklama"
        Me.txtAciklama.Size = New System.Drawing.Size(295, 70)
        Me.txtAciklama.TabIndex = 4
        '
        'btnguncelle
        '
        Me.btnguncelle.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnguncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnguncelle.Image = Global.Tamirhane_2.My.Resources.Resources.Kaydet
        Me.btnguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnguncelle.Location = New System.Drawing.Point(1045, 468)
        Me.btnguncelle.Name = "btnguncelle"
        Me.btnguncelle.Size = New System.Drawing.Size(197, 72)
        Me.btnguncelle.TabIndex = 5
        Me.btnguncelle.Text = "GÜNCELLE"
        Me.btnguncelle.UseVisualStyleBackColor = False
        '
        'lblSaseNo
        '
        Me.lblSaseNo.AutoSize = True
        Me.lblSaseNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSaseNo.Location = New System.Drawing.Point(1040, 49)
        Me.lblSaseNo.Name = "lblSaseNo"
        Me.lblSaseNo.Size = New System.Drawing.Size(106, 29)
        Me.lblSaseNo.TabIndex = 65
        Me.lblSaseNo.Text = "Şase No"
        '
        'aa
        '
        Me.aa.AutoSize = True
        Me.aa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.aa.Location = New System.Drawing.Point(872, 56)
        Me.aa.Name = "aa"
        Me.aa.Size = New System.Drawing.Size(92, 20)
        Me.aa.TabIndex = 66
        Me.aa.Text = "Şase No :"
        '
        'lblTarih
        '
        Me.lblTarih.AutoSize = True
        Me.lblTarih.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTarih.Location = New System.Drawing.Point(1040, 92)
        Me.lblTarih.Name = "lblTarih"
        Me.lblTarih.Size = New System.Drawing.Size(69, 29)
        Me.lblTarih.TabIndex = 67
        Me.lblTarih.Text = "Tarih"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(872, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 20)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Tarih :"
        '
        'GecmisServis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1486, 573)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblTarih)
        Me.Controls.Add(Me.aa)
        Me.Controls.Add(Me.lblSaseNo)
        Me.Controls.Add(Me.btnguncelle)
        Me.Controls.Add(Me.txtYapilanIslem)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSikayet)
        Me.Controls.Add(Me.txtKM)
        Me.Controls.Add(Me.txtAciklama)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSasefiltreleme)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GecmisServis"
        Me.Text = "GecmisServis"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtSasefiltreleme As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtYapilanIslem As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSikayet As TextBox
    Friend WithEvents txtKM As TextBox
    Friend WithEvents txtAciklama As TextBox
    Friend WithEvents btnguncelle As Button
    Friend WithEvents lblSaseNo As Label
    Friend WithEvents aa As Label
    Friend WithEvents lblTarih As Label
    Friend WithEvents Label6 As Label
End Class
