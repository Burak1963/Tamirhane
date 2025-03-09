<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ayarlar
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
        Me.label7 = New System.Windows.Forms.Label()
        Me.txtUrunAra = New System.Windows.Forms.TextBox()
        Me.dataGridView2 = New System.Windows.Forms.DataGridView()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblMarkaID = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.btnMarkaGuncelle = New System.Windows.Forms.Button()
        Me.btnMarkaSil = New System.Windows.Forms.Button()
        Me.txtMarkaAdi = New System.Windows.Forms.TextBox()
        Me.btnMarkaKaydet = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblModelID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbMarka = New System.Windows.Forms.ComboBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtModelAdi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnModelGuncelle = New System.Windows.Forms.Button()
        Me.btnModelSil = New System.Windows.Forms.Button()
        Me.btnModelKaydet = New System.Windows.Forms.Button()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.dataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label7.Location = New System.Drawing.Point(708, 279)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(84, 20)
        Me.label7.TabIndex = 57
        Me.label7.Text = "Ürün Ara"
        '
        'txtUrunAra
        '
        Me.txtUrunAra.Location = New System.Drawing.Point(824, 279)
        Me.txtUrunAra.Name = "txtUrunAra"
        Me.txtUrunAra.Size = New System.Drawing.Size(191, 22)
        Me.txtUrunAra.TabIndex = 10
        '
        'dataGridView2
        '
        Me.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView2.Location = New System.Drawing.Point(712, 36)
        Me.dataGridView2.Name = "dataGridView2"
        Me.dataGridView2.RowHeadersWidth = 51
        Me.dataGridView2.RowTemplate.Height = 24
        Me.dataGridView2.Size = New System.Drawing.Size(328, 188)
        Me.dataGridView2.TabIndex = 55
        '
        'groupBox2
        '
        Me.groupBox2.BackColor = System.Drawing.Color.CadetBlue
        Me.groupBox2.Controls.Add(Me.lblMarkaID)
        Me.groupBox2.Controls.Add(Me.label11)
        Me.groupBox2.Controls.Add(Me.btnMarkaGuncelle)
        Me.groupBox2.Controls.Add(Me.btnMarkaSil)
        Me.groupBox2.Controls.Add(Me.txtMarkaAdi)
        Me.groupBox2.Controls.Add(Me.btnMarkaKaydet)
        Me.groupBox2.Controls.Add(Me.label4)
        Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox2.Location = New System.Drawing.Point(114, 23)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(387, 201)
        Me.groupBox2.TabIndex = 54
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Marka Düzenle"
        '
        'lblMarkaID
        '
        Me.lblMarkaID.AutoSize = True
        Me.lblMarkaID.Location = New System.Drawing.Point(259, 35)
        Me.lblMarkaID.Name = "lblMarkaID"
        Me.lblMarkaID.Size = New System.Drawing.Size(85, 20)
        Me.lblMarkaID.TabIndex = 24
        Me.lblMarkaID.Text = "Marka ID"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(7, 35)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(146, 20)
        Me.label11.TabIndex = 23
        Me.label11.Text = "Marka Numarası"
        '
        'btnMarkaGuncelle
        '
        Me.btnMarkaGuncelle.Location = New System.Drawing.Point(229, 126)
        Me.btnMarkaGuncelle.Name = "btnMarkaGuncelle"
        Me.btnMarkaGuncelle.Size = New System.Drawing.Size(138, 56)
        Me.btnMarkaGuncelle.TabIndex = 4
        Me.btnMarkaGuncelle.Text = "GÜNCELLE"
        Me.btnMarkaGuncelle.UseVisualStyleBackColor = True
        '
        'btnMarkaSil
        '
        Me.btnMarkaSil.Location = New System.Drawing.Point(128, 126)
        Me.btnMarkaSil.Name = "btnMarkaSil"
        Me.btnMarkaSil.Size = New System.Drawing.Size(95, 56)
        Me.btnMarkaSil.TabIndex = 3
        Me.btnMarkaSil.Text = "SİL"
        Me.btnMarkaSil.UseVisualStyleBackColor = True
        '
        'txtMarkaAdi
        '
        Me.txtMarkaAdi.Location = New System.Drawing.Point(180, 79)
        Me.txtMarkaAdi.Name = "txtMarkaAdi"
        Me.txtMarkaAdi.Size = New System.Drawing.Size(159, 27)
        Me.txtMarkaAdi.TabIndex = 1
        Me.txtMarkaAdi.Text = " "
        '
        'btnMarkaKaydet
        '
        Me.btnMarkaKaydet.Location = New System.Drawing.Point(13, 126)
        Me.btnMarkaKaydet.Name = "btnMarkaKaydet"
        Me.btnMarkaKaydet.Size = New System.Drawing.Size(109, 56)
        Me.btnMarkaKaydet.TabIndex = 2
        Me.btnMarkaKaydet.Text = "KAYDET"
        Me.btnMarkaKaydet.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(47, 86)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(93, 20)
        Me.label4.TabIndex = 2
        Me.label4.Text = "Marka Adı"
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.MediumPurple
        Me.groupBox1.Controls.Add(Me.lblModelID)
        Me.groupBox1.Controls.Add(Me.Label1)
        Me.groupBox1.Controls.Add(Me.cmbMarka)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.txtModelAdi)
        Me.groupBox1.Controls.Add(Me.Label2)
        Me.groupBox1.Controls.Add(Me.btnModelGuncelle)
        Me.groupBox1.Controls.Add(Me.btnModelSil)
        Me.groupBox1.Controls.Add(Me.btnModelKaydet)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(114, 280)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(387, 262)
        Me.groupBox1.TabIndex = 53
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Model Düzenle"
        '
        'lblModelID
        '
        Me.lblModelID.AutoSize = True
        Me.lblModelID.Location = New System.Drawing.Point(270, 36)
        Me.lblModelID.Name = "lblModelID"
        Me.lblModelID.Size = New System.Drawing.Size(84, 20)
        Me.lblModelID.TabIndex = 26
        Me.lblModelID.Text = "Model ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Model Numarası"
        '
        'cmbMarka
        '
        Me.cmbMarka.FormattingEnabled = True
        Me.cmbMarka.ItemHeight = 20
        Me.cmbMarka.Location = New System.Drawing.Point(180, 114)
        Me.cmbMarka.Name = "cmbMarka"
        Me.cmbMarka.Size = New System.Drawing.Size(159, 28)
        Me.cmbMarka.TabIndex = 20
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(47, 122)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(93, 20)
        Me.label5.TabIndex = 19
        Me.label5.Text = "Marka Adı"
        '
        'txtModelAdi
        '
        Me.txtModelAdi.Location = New System.Drawing.Point(180, 62)
        Me.txtModelAdi.Name = "txtModelAdi"
        Me.txtModelAdi.Size = New System.Drawing.Size(159, 27)
        Me.txtModelAdi.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Model Adı"
        '
        'btnModelGuncelle
        '
        Me.btnModelGuncelle.Location = New System.Drawing.Point(229, 171)
        Me.btnModelGuncelle.Name = "btnModelGuncelle"
        Me.btnModelGuncelle.Size = New System.Drawing.Size(138, 56)
        Me.btnModelGuncelle.TabIndex = 9
        Me.btnModelGuncelle.Text = "GÜNCELLE"
        Me.btnModelGuncelle.UseVisualStyleBackColor = True
        '
        'btnModelSil
        '
        Me.btnModelSil.Location = New System.Drawing.Point(128, 171)
        Me.btnModelSil.Name = "btnModelSil"
        Me.btnModelSil.Size = New System.Drawing.Size(95, 56)
        Me.btnModelSil.TabIndex = 8
        Me.btnModelSil.Text = "SİL"
        Me.btnModelSil.UseVisualStyleBackColor = True
        '
        'btnModelKaydet
        '
        Me.btnModelKaydet.Location = New System.Drawing.Point(13, 171)
        Me.btnModelKaydet.Name = "btnModelKaydet"
        Me.btnModelKaydet.Size = New System.Drawing.Size(109, 56)
        Me.btnModelKaydet.TabIndex = 7
        Me.btnModelKaydet.Text = "KAYDET"
        Me.btnModelKaydet.UseVisualStyleBackColor = True
        '
        'dataGridView1
        '
        Me.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(709, 307)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.RowHeadersWidth = 51
        Me.dataGridView1.RowTemplate.Height = 24
        Me.dataGridView1.Size = New System.Drawing.Size(627, 235)
        Me.dataGridView1.TabIndex = 52
        '
        'Ayarlar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1486, 573)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.txtUrunAra)
        Me.Controls.Add(Me.dataGridView2)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.dataGridView1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ayarlar"
        Me.Text = "Ayarlar"
        CType(Me.dataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label7 As Label
    Private WithEvents txtUrunAra As TextBox
    Private WithEvents dataGridView2 As DataGridView
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents lblMarkaID As Label
    Private WithEvents label11 As Label
    Private WithEvents btnMarkaGuncelle As Button
    Private WithEvents btnMarkaSil As Button
    Private WithEvents txtMarkaAdi As TextBox
    Private WithEvents btnMarkaKaydet As Button
    Private WithEvents label4 As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents lblModelID As Label
    Private WithEvents Label1 As Label
    Private WithEvents cmbMarka As ComboBox
    Private WithEvents label5 As Label
    Private WithEvents txtModelAdi As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents btnModelGuncelle As Button
    Private WithEvents btnModelSil As Button
    Private WithEvents btnModelKaydet As Button
    Private WithEvents dataGridView1 As DataGridView
End Class
