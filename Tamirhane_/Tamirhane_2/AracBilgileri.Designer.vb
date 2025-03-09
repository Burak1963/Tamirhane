<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AracBilgileri
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
        Me.components = New System.ComponentModel.Container()
        Me.txtSasefiltreleme = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSase = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTC = New System.Windows.Forms.TextBox()
        Me.btnSil = New System.Windows.Forms.Button()
        Me.btnGuncelle = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.txtSase = New System.Windows.Forms.TextBox()
        Me.txtMotorNo = New System.Windows.Forms.TextBox()
        Me.cmbModel = New System.Windows.Forms.ComboBox()
        Me.ModellerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Arac_servisiDataSet = New Tamirhane_2.arac_servisiDataSet()
        Me.txtPlaka = New System.Windows.Forms.TextBox()
        Me.cmbMarka = New System.Windows.Forms.ComboBox()
        Me.txtModelYili = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.MarkalarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Arac_servisiDataSet1 = New Tamirhane_2.arac_servisiDataSet1()
        Me.ModellerTableAdapter = New Tamirhane_2.arac_servisiDataSetTableAdapters.ModellerTableAdapter()
        Me.MarkalarTableAdapter = New Tamirhane_2.arac_servisiDataSet1TableAdapters.MarkalarTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ModellerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Arac_servisiDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarkalarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Arac_servisiDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSasefiltreleme
        '
        Me.txtSasefiltreleme.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSasefiltreleme.Location = New System.Drawing.Point(1095, 37)
        Me.txtSasefiltreleme.Name = "txtSasefiltreleme"
        Me.txtSasefiltreleme.Size = New System.Drawing.Size(180, 34)
        Me.txtSasefiltreleme.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(677, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Şase Numarası Üzerinden Filtreleme :"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(641, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(842, 500)
        Me.DataGridView1.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RosyBrown
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblSase)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtTC)
        Me.Panel1.Controls.Add(Me.btnSil)
        Me.Panel1.Controls.Add(Me.btnGuncelle)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.btnKaydet)
        Me.Panel1.Controls.Add(Me.txtSase)
        Me.Panel1.Controls.Add(Me.txtMotorNo)
        Me.Panel1.Controls.Add(Me.cmbModel)
        Me.Panel1.Controls.Add(Me.txtPlaka)
        Me.Panel1.Controls.Add(Me.cmbMarka)
        Me.Panel1.Controls.Add(Me.txtModelYili)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Location = New System.Drawing.Point(27, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(602, 591)
        Me.Panel1.TabIndex = 36
        '
        'lblSase
        '
        Me.lblSase.AutoSize = True
        Me.lblSase.Location = New System.Drawing.Point(380, 37)
        Me.lblSase.Name = "lblSase"
        Me.lblSase.Size = New System.Drawing.Size(39, 16)
        Me.lblSase.TabIndex = 35
        Me.lblSase.Text = "Şase"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(63, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 20)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "TC Numarası :"
        '
        'txtTC
        '
        Me.txtTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTC.Location = New System.Drawing.Point(257, 101)
        Me.txtTC.Name = "txtTC"
        Me.txtTC.Size = New System.Drawing.Size(265, 34)
        Me.txtTC.TabIndex = 1
        '
        'btnSil
        '
        Me.btnSil.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnSil.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSil.Image = Global.Tamirhane_2.My.Resources.Resources.Sil
        Me.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSil.Location = New System.Drawing.Point(45, 474)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(125, 72)
        Me.btnSil.TabIndex = 10
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
        Me.btnGuncelle.Location = New System.Drawing.Point(176, 474)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(175, 72)
        Me.btnGuncelle.TabIndex = 9
        Me.btnGuncelle.Text = "GÜNCELLE"
        Me.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuncelle.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.Location = New System.Drawing.Point(58, 326)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 20)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Model Yılı :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.Location = New System.Drawing.Point(57, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 20)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Şase No :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label11.Location = New System.Drawing.Point(59, 270)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 20)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Model :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label12.Location = New System.Drawing.Point(57, 365)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 20)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Motor Kodu :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label13.Location = New System.Drawing.Point(59, 230)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 20)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Marka :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label14.Location = New System.Drawing.Point(58, 190)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 20)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Plaka No :"
        '
        'btnKaydet
        '
        Me.btnKaydet.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnKaydet.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKaydet.Image = Global.Tamirhane_2.My.Resources.Resources.Kaydet
        Me.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKaydet.Location = New System.Drawing.Point(357, 474)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(165, 72)
        Me.btnKaydet.TabIndex = 8
        Me.btnKaydet.Text = "KAYDET"
        Me.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKaydet.UseVisualStyleBackColor = False
        '
        'txtSase
        '
        Me.txtSase.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSase.Location = New System.Drawing.Point(257, 146)
        Me.txtSase.Name = "txtSase"
        Me.txtSase.Size = New System.Drawing.Size(265, 34)
        Me.txtSase.TabIndex = 2
        '
        'txtMotorNo
        '
        Me.txtMotorNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtMotorNo.Location = New System.Drawing.Point(257, 363)
        Me.txtMotorNo.Name = "txtMotorNo"
        Me.txtMotorNo.Size = New System.Drawing.Size(265, 34)
        Me.txtMotorNo.TabIndex = 7
        '
        'cmbModel
        '
        Me.cmbModel.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ModellerBindingSource, "Model_Adi", True))
        Me.cmbModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmbModel.FormattingEnabled = True
        Me.cmbModel.ItemHeight = 29
        Me.cmbModel.Location = New System.Drawing.Point(257, 266)
        Me.cmbModel.Name = "cmbModel"
        Me.cmbModel.Size = New System.Drawing.Size(265, 37)
        Me.cmbModel.TabIndex = 19
        '
        'ModellerBindingSource
        '
        Me.ModellerBindingSource.DataMember = "Modeller"
        Me.ModellerBindingSource.DataSource = Me.Arac_servisiDataSet
        '
        'Arac_servisiDataSet
        '
        Me.Arac_servisiDataSet.DataSetName = "arac_servisiDataSet"
        Me.Arac_servisiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtPlaka
        '
        Me.txtPlaka.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtPlaka.Location = New System.Drawing.Point(257, 188)
        Me.txtPlaka.Name = "txtPlaka"
        Me.txtPlaka.Size = New System.Drawing.Size(265, 34)
        Me.txtPlaka.TabIndex = 3
        '
        'cmbMarka
        '
        Me.cmbMarka.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmbMarka.FormattingEnabled = True
        Me.cmbMarka.ItemHeight = 29
        Me.cmbMarka.Location = New System.Drawing.Point(257, 226)
        Me.cmbMarka.Name = "cmbMarka"
        Me.cmbMarka.Size = New System.Drawing.Size(265, 37)
        Me.cmbMarka.TabIndex = 17
        '
        'txtModelYili
        '
        Me.txtModelYili.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtModelYili.Location = New System.Drawing.Point(257, 322)
        Me.txtModelYili.Name = "txtModelYili"
        Me.txtModelYili.Size = New System.Drawing.Size(265, 34)
        Me.txtModelYili.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label15.Location = New System.Drawing.Point(24, 14)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(208, 29)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "ARAÇ BİLGİLERİ"
        '
        'MarkalarBindingSource
        '
        Me.MarkalarBindingSource.DataMember = "Markalar"
        Me.MarkalarBindingSource.DataSource = Me.Arac_servisiDataSet1
        '
        'Arac_servisiDataSet1
        '
        Me.Arac_servisiDataSet1.DataSetName = "arac_servisiDataSet1"
        Me.Arac_servisiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ModellerTableAdapter
        '
        Me.ModellerTableAdapter.ClearBeforeFill = True
        '
        'MarkalarTableAdapter
        '
        Me.MarkalarTableAdapter.ClearBeforeFill = True
        '
        'AracBilgileri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1504, 620)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtSasefiltreleme)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AracBilgileri"
        Me.Text = "AracBilgileri"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ModellerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Arac_servisiDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarkalarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Arac_servisiDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSasefiltreleme As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSil As Button
    Friend WithEvents btnGuncelle As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnKaydet As Button
    Friend WithEvents txtSase As TextBox
    Friend WithEvents txtMotorNo As TextBox
    Friend WithEvents cmbModel As ComboBox
    Friend WithEvents txtPlaka As TextBox
    Friend WithEvents cmbMarka As ComboBox
    Friend WithEvents txtModelYili As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Arac_servisiDataSet As arac_servisiDataSet
    Friend WithEvents ModellerBindingSource As BindingSource
    Friend WithEvents ModellerTableAdapter As arac_servisiDataSetTableAdapters.ModellerTableAdapter
    Friend WithEvents Arac_servisiDataSet1 As arac_servisiDataSet1
    Friend WithEvents MarkalarBindingSource As BindingSource
    Friend WithEvents MarkalarTableAdapter As arac_servisiDataSet1TableAdapters.MarkalarTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTC As TextBox
    Friend WithEvents lblSase As Label
End Class
