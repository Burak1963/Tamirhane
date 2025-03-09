Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class MusteriBilgileri

    Dim baglanti As New SqlConnection($"Data Source={DatabaseHelper.GetServerName};Initial Catalog=istenen;Integrated Security=True")

    Sub Listele()
        Dim dt As New DataTable
        Dim sql As String = "select * from Musteriler"
        Dim adtr As New SqlDataAdapter(sql, baglanti)
        adtr.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub



    Private Sub MusteriBilgileri_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listele()
    End Sub


    Sub Temizle()


        txtAd.Text = String.Empty
        txtSoyad.Text = String.Empty
        txtTelefon.Text = Text = String.Empty
        txtMail.Text = Text = String.Empty
        txtAdres.Text = Text = String.Empty

    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Try

            If baglanti Is Nothing Then
                MessageBox.Show("Veritabanı bağlantısı yapılandırılmadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If


            If String.IsNullOrWhiteSpace(txtTC.Text) Then
                MessageBox.Show("Lütfen TC Kimlik Numarasını girin!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If



            If String.IsNullOrWhiteSpace(txtTelefon.Text) OrElse txtTelefon.Text.Length <> 11 Then
                MessageBox.Show("Telefon numarası tam olarak 11 hane olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If



            Dim kontrolCmd As New SqlCommand("SELECT COUNT(*) FROM Musteriler WHERE TC = @tc", baglanti)
            kontrolCmd.Parameters.AddWithValue("@tc", txtTC.Text)

            If baglanti.State = ConnectionState.Closed Then
                baglanti.Open()
            End If

            Dim kayitVarMi As Integer = Convert.ToInt32(kontrolCmd.ExecuteScalar())
            baglanti.Close()

            ' Eğer kayıt varsa uyarı ver
            If kayitVarMi > 0 Then
                MessageBox.Show("Bu TC Kimlik Numarası ile zaten kayıtlı bir müşteri var!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Müşteri ekleme işlemi
            Dim kaydetCmd As New SqlCommand("INSERT INTO Musteriler (TC, Ad, Soyad, TEL, Mail, Adres, Tarih) 
                                         VALUES (@tc, @ad, @soyad, @tel, @mail, @adres, GETDATE())", baglanti)

            kaydetCmd.Parameters.AddWithValue("@TC", txtTC.Text)
            kaydetCmd.Parameters.AddWithValue("@ad", txtAd.Text)
            kaydetCmd.Parameters.AddWithValue("@soyad", txtSoyad.Text)
            kaydetCmd.Parameters.AddWithValue("@tel", txtTelefon.Text)
            kaydetCmd.Parameters.AddWithValue("@mail", txtMail.Text)
            kaydetCmd.Parameters.AddWithValue("@adres", txtAdres.Text)

            If baglanti.State = ConnectionState.Closed Then
                baglanti.Open()
            End If

            kaydetCmd.ExecuteNonQuery()
            baglanti.Close()

            ' Temizleme ve listeleme
            Temizle()
            Listele()

            MessageBox.Show("Müşteri başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As SqlException When ex.Number = 2627 ' Primary Key hatası
            MessageBox.Show("Bu TC Kimlik Numarası zaten kayıtlı!", "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Her ihtimale karşı bağlantıyı kapat
            If baglanti IsNot Nothing AndAlso baglanti.State = ConnectionState.Open Then
                baglanti.Close()
            End If
        End Try
    End Sub


    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        Try
            ' Bağlantıyı kontrol et
            If baglanti Is Nothing Then
                MessageBox.Show("Veritabanı bağlantısı yapılandırılmadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Güncelleme yapılacak eski TC'yi sakla
            Dim eskiTC As String = txtTCFiltreleme.Text ' Önceki TC buraya kaydedilmiş olmalı!

            ' Yeni TC kimlik numarası boş mu?
            If String.IsNullOrWhiteSpace(txtTC.Text) Then
                MessageBox.Show("Lütfen TC Kimlik Numarasını girin!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Telefon numarası 11 haneli mi kontrol et
            If String.IsNullOrWhiteSpace(txtTelefon.Text) OrElse txtTelefon.Text.Length <> 11 Then
                MessageBox.Show("Telefon numarası tam olarak 11 hane olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Aynı TC numarasına sahip farklı bir kayıt var mı kontrol et
            Dim kontrolCmd As New SqlCommand("SELECT COUNT(*) FROM Musteriler WHERE TC = @tc AND TC <> @eskiTC", baglanti)
            kontrolCmd.Parameters.AddWithValue("@tc", txtTC.Text)
            kontrolCmd.Parameters.AddWithValue("@eskiTC", eskiTC)

            If baglanti.State = ConnectionState.Closed Then
                baglanti.Open()
            End If

            Dim kayitVarMi As Integer = Convert.ToInt32(kontrolCmd.ExecuteScalar())
            baglanti.Close()

            ' Eğer başka bir kayıt varsa, işlemi durdur
            If kayitVarMi > 0 Then
                MessageBox.Show("Bu TC Kimlik Numarası zaten başka bir müşteri için kayıtlı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Güncelleme işlemi
            Dim sql As String = "UPDATE Musteriler 
                             SET TC=@tc, Ad=@ad, Soyad=@soyad, TEL=@tel, Mail=@mail, Adres=@adres, Tarih=@tarih 
                             WHERE TC=@eskiTC"
            Dim Guncelle As New SqlCommand(sql, baglanti)

            Guncelle.Parameters.AddWithValue("@tc", txtTC.Text) ' Yeni TC
            Guncelle.Parameters.AddWithValue("@ad", txtAd.Text)
            Guncelle.Parameters.AddWithValue("@soyad", txtSoyad.Text)
            Guncelle.Parameters.AddWithValue("@tel", txtTelefon.Text)
            Guncelle.Parameters.AddWithValue("@mail", txtMail.Text)
            Guncelle.Parameters.AddWithValue("@adres", txtAdres.Text)
            Guncelle.Parameters.AddWithValue("@tarih", DateTime.Now)
            Guncelle.Parameters.AddWithValue("@eskiTC", eskiTC) ' Güncellenen kaydın eski TC'si

            If baglanti.State = ConnectionState.Closed Then
                baglanti.Open()
            End If

            Dim affectedRows As Integer = Guncelle.ExecuteNonQuery()
            baglanti.Close()

            If affectedRows > 0 Then
                MessageBox.Show("Kayıt Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Listele()
                Temizle()
            Else
                MessageBox.Show("Güncelleme başarısız! Belirtilen TC bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Her durumda bağlantıyı kapat
            If baglanti IsNot Nothing AndAlso baglanti.State = ConnectionState.Open Then
                baglanti.Close()
            End If
        End Try
    End Sub





    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        Dim SilinecekID As String = DataGridView1.CurrentRow.Cells("TC").Value.ToString()

        Dim sql As String = "delete from Musteriler where TC=@TC"
        Dim Komut As New SqlCommand(sql, baglanti)
        Komut.Parameters.AddWithValue("@TC", SilinecekID)

        baglanti.Open()
        Komut.ExecuteNonQuery()
        baglanti.Close()

        MessageBox.Show("Kayit Silindi", "Bilgi")
        Listele()
        Temizle()

    End Sub



    Private Sub txtTCFiltreleme_TextChanged(sender As Object, e As EventArgs) Handles txtTCFiltreleme.TextChanged
        Dim dt As New DataTable
        Dim sql As String = "SELECT * FROM Musteriler WHERE TC LIKE '%' + @TC + '%'"


        Dim adtr As New SqlDataAdapter(sql, baglanti)
        adtr.SelectCommand.Parameters.AddWithValue("@TC", txtTCFiltreleme.Text)

        Try
            baglanti.Open()
            adtr.Fill(dt)
        Catch ex As Exception
            MessageBox.Show("Veritabanına bağlanırken bir hata oluştu: " & ex.Message)
        Finally
            baglanti.Close()
        End Try


        DataGridView1.DataSource = dt
    End Sub
    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        ' Eğer DataGridView'de seçili satır yoksa
        If DataGridView1.CurrentRow Is Nothing Then
            MessageBox.Show("Lütfen bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Satırın tamamı boşsa
        Dim isRowEmpty As Boolean = True
        For Each cell As DataGridViewCell In DataGridView1.CurrentRow.Cells
            If cell.Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(cell.Value.ToString()) Then
                isRowEmpty = False
                Exit For
            End If
        Next

        If isRowEmpty Then
            MessageBox.Show("Seçilen satır boş, lütfen geçerli bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Eğer tüm değerler geçerli ise, textBox'lara değerleri ata
        txtTC.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        txtTCFiltreleme.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        txtAd.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        txtSoyad.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        txtTelefon.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        txtMail.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        txtAdres.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
    End Sub



    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If DataGridView1.CurrentRow IsNot Nothing Then
            Dim saseNo As String = DataGridView1.CurrentRow.Cells("TC").Value.ToString()
            Dim frmAracBilgileri As New AracBilgileri()
            frmAracBilgileri.txtTC.Text = saseNo
            Dim frmAnasayfa As Anasayfa = TryCast(Me.ParentForm, Anasayfa)
            If frmAnasayfa IsNot Nothing Then
                frmAnasayfa.menuDegis(frmAnasayfa.Panel2, frmAracBilgileri)
            Else
                MessageBox.Show("Anasayfa formuna erişilemiyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub txtTC_TextChanged(sender As Object, e As EventArgs) Handles txtTC.TextChanged

        If txtTC.Text.Length > 11 Then
            txtTC.Text = txtTC.Text.Substring(0, 11)
            txtTC.SelectionStart = txtTC.Text.Length
        End If
    End Sub

    Private Sub txtTC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTC.KeyPress

        e.Handled = Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)
    End Sub


    Private Sub txtAd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAd.KeyPress, txtSoyad.KeyPress

        e.Handled = Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub txtTelefon_TextChanged(sender As Object, e As EventArgs) Handles txtTelefon.TextChanged

        If txtTelefon.Text.Length > 11 Then
            txtTelefon.Text = txtTelefon.Text.Substring(0, 11)
            txtTelefon.SelectionStart = txtTelefon.Text.Length
        End If
    End Sub

    Private Sub txtTelefon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefon.KeyPress

        e.Handled = Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)
    End Sub


    Private Sub txtMail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtMail.Validating
        Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        If Not System.Text.RegularExpressions.Regex.IsMatch(txtMail.Text, emailPattern) Then
            MessageBox.Show("Geçerli bir e-posta adresi giriniz.", "Hatalı E-posta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
        End If
    End Sub
    Private Sub txtSoyad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoyad.KeyPress

        e.Handled = Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)
    End Sub


End Class

