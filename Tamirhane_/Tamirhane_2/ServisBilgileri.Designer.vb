<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServisBilgileri
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblPersonelAd = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblSaseNo = New System.Windows.Forms.Label()
        Me.txtYapilanIslem = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnkaydet = New System.Windows.Forms.Button()
        Me.txtSikayet = New System.Windows.Forms.TextBox()
        Me.KM = New System.Windows.Forms.TextBox()
        Me.txtAciklama = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(213, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 25)
        Me.Label6.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(232, 29)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "SERVİS BİLGİLERİ"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.RosyBrown
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblPersonelAd)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.lblSaseNo)
        Me.Panel3.Controls.Add(Me.txtYapilanIslem)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.btnkaydet)
        Me.Panel3.Controls.Add(Me.txtSikayet)
        Me.Panel3.Controls.Add(Me.KM)
        Me.Panel3.Controls.Add(Me.txtAciklama)
        Me.Panel3.Location = New System.Drawing.Point(439, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(602, 698)
        Me.Panel3.TabIndex = 17
        '
        'lblPersonelAd
        '
        Me.lblPersonelAd.AutoSize = True
        Me.lblPersonelAd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblPersonelAd.Location = New System.Drawing.Point(511, 22)
        Me.lblPersonelAd.Name = "lblPersonelAd"
        Me.lblPersonelAd.Size = New System.Drawing.Size(71, 25)
        Me.lblPersonelAd.TabIndex = 46
        Me.lblPersonelAd.Text = "Label9"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.Location = New System.Drawing.Point(386, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 20)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Personel Adı"
        '
        'lblSaseNo
        '
        Me.lblSaseNo.AutoSize = True
        Me.lblSaseNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSaseNo.Location = New System.Drawing.Point(199, 62)
        Me.lblSaseNo.Name = "lblSaseNo"
        Me.lblSaseNo.Size = New System.Drawing.Size(17, 25)
        Me.lblSaseNo.TabIndex = 44
        Me.lblSaseNo.Text = " "
        '
        'txtYapilanIslem
        '
        Me.txtYapilanIslem.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtYapilanIslem.Location = New System.Drawing.Point(187, 253)
        Me.txtYapilanIslem.Multiline = True
        Me.txtYapilanIslem.Name = "txtYapilanIslem"
        Me.txtYapilanIslem.Size = New System.Drawing.Size(295, 69)
        Me.txtYapilanIslem.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 20)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Şase No :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 20)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Yapılan İşlem :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 380)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Açıklama :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "KM :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 20)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Şikayet :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 20)
        Me.Label4.TabIndex = 26
        '
        'btnkaydet
        '
        Me.btnkaydet.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnkaydet.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnkaydet.Image = Global.Tamirhane_2.My.Resources.Resources.Kaydet
        Me.btnkaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnkaydet.Location = New System.Drawing.Point(119, 580)
        Me.btnkaydet.Name = "btnkaydet"
        Me.btnkaydet.Size = New System.Drawing.Size(280, 72)
        Me.btnkaydet.TabIndex = 5
        Me.btnkaydet.Text = "KAYDET"
        Me.btnkaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnkaydet.UseVisualStyleBackColor = False
        '
        'txtSikayet
        '
        Me.txtSikayet.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSikayet.Location = New System.Drawing.Point(187, 106)
        Me.txtSikayet.Multiline = True
        Me.txtSikayet.Name = "txtSikayet"
        Me.txtSikayet.Size = New System.Drawing.Size(250, 82)
        Me.txtSikayet.TabIndex = 1
        '
        'KM
        '
        Me.KM.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.KM.Location = New System.Drawing.Point(187, 213)
        Me.KM.Name = "KM"
        Me.KM.Size = New System.Drawing.Size(127, 34)
        Me.KM.TabIndex = 2
        '
        'txtAciklama
        '
        Me.txtAciklama.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtAciklama.Location = New System.Drawing.Point(187, 378)
        Me.txtAciklama.Multiline = True
        Me.txtAciklama.Name = "txtAciklama"
        Me.txtAciklama.Size = New System.Drawing.Size(295, 70)
        Me.txtAciklama.TabIndex = 4
        '
        'ServisBilgileri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1487, 736)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ServisBilgileri"
        Me.Text = "ServisGiris"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnkaydet As Button
    Friend WithEvents txtSikayet As TextBox
    Friend WithEvents KM As TextBox
    Friend WithEvents txtYapilanIslem As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAciklama As TextBox
    Friend WithEvents lblSaseNo As Label
    Friend WithEvents lblPersonelAd As Label
    Friend WithEvents Label9 As Label
End Class
