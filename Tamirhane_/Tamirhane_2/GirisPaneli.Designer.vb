<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GirisPaneli
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GirisPaneli))
        Me.txtsifre = New System.Windows.Forms.TextBox()
        Me.txtkullaniciadi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btncikis = New System.Windows.Forms.Button()
        Me.btngiris = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtsifre
        '
        Me.txtsifre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsifre.Location = New System.Drawing.Point(533, 199)
        Me.txtsifre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtsifre.Multiline = True
        Me.txtsifre.Name = "txtsifre"
        Me.txtsifre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtsifre.Size = New System.Drawing.Size(161, 29)
        Me.txtsifre.TabIndex = 2
        '
        'txtkullaniciadi
        '
        Me.txtkullaniciadi.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkullaniciadi.Location = New System.Drawing.Point(533, 140)
        Me.txtkullaniciadi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtkullaniciadi.Multiline = True
        Me.txtkullaniciadi.Name = "txtkullaniciadi"
        Me.txtkullaniciadi.Size = New System.Drawing.Size(161, 29)
        Me.txtkullaniciadi.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Info
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(345, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 29)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Şifre :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Info
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(345, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 29)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Kullanıcı Adı :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(105, 140)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'btncikis
        '
        Me.btncikis.BackColor = System.Drawing.SystemColors.Info
        Me.btncikis.Image = Global.Tamirhane_2.My.Resources.Resources.icons8_close_45
        Me.btncikis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncikis.Location = New System.Drawing.Point(575, 254)
        Me.btncikis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btncikis.Name = "btncikis"
        Me.btncikis.Size = New System.Drawing.Size(121, 47)
        Me.btncikis.TabIndex = 4
        Me.btncikis.Text = " ÇIKIŞ"
        Me.btncikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncikis.UseVisualStyleBackColor = False
        '
        'btngiris
        '
        Me.btngiris.BackColor = System.Drawing.SystemColors.Info
        Me.btngiris.Image = Global.Tamirhane_2.My.Resources.Resources.icons8_login_48
        Me.btngiris.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btngiris.Location = New System.Drawing.Point(349, 254)
        Me.btngiris.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btngiris.Name = "btngiris"
        Me.btngiris.Size = New System.Drawing.Size(199, 47)
        Me.btngiris.TabIndex = 3
        Me.btngiris.Text = "GİRİŞ"
        Me.btngiris.UseVisualStyleBackColor = False
        '
        'GirisPaneli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtsifre)
        Me.Controls.Add(Me.txtkullaniciadi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btncikis)
        Me.Controls.Add(Me.btngiris)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "GirisPaneli"
        Me.Text = "Giriş Paneli"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtsifre As TextBox
    Friend WithEvents txtkullaniciadi As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents Label1 As Label
    Friend WithEvents btngiris As Button
    Friend WithEvents btncikis As Button
End Class
