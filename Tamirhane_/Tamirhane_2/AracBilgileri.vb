Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices

Public Class AracBilgileri

    ' Veritabanı bağlantı dizesi
    Dim baglanti As New SqlConnection($"Data Source={DatabaseHelper.GetServerName};Initial Catalog=istenen;Integrated Security=True")

    Sub Listele()
        Dim dt As New DataTable
        Dim sql As String = "SELECT ab.TC,ab.Sase_NO, ab.Plaka_NO, m.Marka_Adi AS Marka, mdl.Model_Adi AS Model, ab.Yil, ab.Tarih, ab.Motor_NO FROM Arac_Bilgileri AS ab INNER JOIN Markalar AS m ON ab.Marka_ID = m.Marka_ID INNER JOIN Modeller AS mdl ON ab.Model_ID = mdl.Model_ID"
        Dim adtr As New SqlDataAdapter(sql, baglanti)
        adtr.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Sub Temizle()
        txtTC.Text = String.Empty
        txtSase.Text = String.Empty
        txtPlaka.Text = String.Empty
        txtModelYili.Text = String.Empty
        txtMotorNo.Text = Text = String.Empty

    End Sub


    Dim WithEvents Panel2 As New Panel()



    Sub MarkaListele()
        cmbMarka.DataSource = Nothing
        cmbMarka.Items.Clear()

        Dim markatablo As New DataTable()
        Dim komut As New SqlCommand("SELECT * FROM Markalar", baglanti)

        baglanti.Open()
        Dim okuyucu As SqlDataReader = komut.ExecuteReader()
        markatablo.Load(okuyucu)
        baglanti.Close()

        cmbMarka.ValueMember = "Marka_ID"
        cmbMarka.DisplayMember = "Marka_Adi"
        cmbMarka.DataSource = markatablo
    End Sub



    Sub ModelListele(markaID As Integer)
        Dim modeldt As New DataTable()
        Dim modelda As New SqlDataAdapter("SELECT * FROM Modeller WHERE Marka_ID = @markaID", baglanti)
        modelda.SelectCommand.Parameters.AddWithValue("@markaID", markaID)
        modelda.Fill(modeldt)

        cmbModel.ValueMember = "Model_ID"
        cmbModel.DisplayMember = "Model_Adi"
        cmbModel.DataSource = modeldt
    End Sub


    Private Sub AracBilgileri_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listele()
        MarkaListele() ' Markaları listele
    End Sub

    Private Sub cmbMarka_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMarka.SelectedIndexChanged
        If cmbMarka.SelectedIndex <> -1 Then
            ModelListele(CInt(cmbMarka.SelectedValue)) ' Seçilen markaya göre modelleri listele
        End If
    End Sub





    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Try
            Dim sql As String = "INSERT INTO Arac_Bilgileri (TC, Sase_NO, Plaka_NO, Marka_ID, Model_ID, Yil, Tarih, Motor_NO) 
                             VALUES (@TC, @sase, @plaka, @marka, @model, @yil, GETDATE(), @motor)"


            If String.IsNullOrWhiteSpace(txtSase.Text) OrElse txtSase.Text.Length <> 17 Then
                MessageBox.Show("Şase numarası tam olarak 17 hane olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim komut As New SqlCommand(sql, baglanti)
            komut.Parameters.AddWithValue("@TC", txtTC.Text)
            komut.Parameters.AddWithValue("@sase", txtSase.Text)
            komut.Parameters.AddWithValue("@plaka", txtPlaka.Text)
            komut.Parameters.AddWithValue("@marka", cmbMarka.SelectedValue)
            komut.Parameters.AddWithValue("@model", cmbModel.SelectedValue)
            komut.Parameters.AddWithValue("@yil", txtModelYili.Text)
            komut.Parameters.AddWithValue("@motor", txtMotorNo.Text)

            baglanti.Open()
            Dim rowsAffected As Integer = komut.ExecuteNonQuery()
            baglanti.Close()

            If rowsAffected > 0 Then
                MessageBox.Show("Kayıt başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Listele() ' DataGridView'i güncelle
                Temizle() ' TextBoxları temizle
            Else
                MessageBox.Show("Kayıt eklenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If baglanti.State = ConnectionState.Open Then
                baglanti.Close()
            End If
        End Try
    End Sub


    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        Dim eskiSase As String = lblSase.Text ' Güncellemeden önceki değer burada olmalı!
        Dim yeniSase As String = txtSase.Text ' Yeni şase numarasını al (txtSase.Text)

        ' Şase numarasını da güncellenmiş sorgu
        Dim sql As String = "UPDATE Arac_Bilgileri 
                         SET Sase_NO=@yeniSase, Plaka_NO=@plaka, Marka_ID=@marka, 
                             Model_ID=@model, Yil=@yil, Tarih=@tarih, Motor_NO=@motor 
                         WHERE Sase_NO=@eskiSase"

        Dim komut As New SqlCommand(sql, baglanti)
        komut.Parameters.AddWithValue("@yeniSase", yeniSase)
        komut.Parameters.AddWithValue("@plaka", txtPlaka.Text)
        komut.Parameters.AddWithValue("@marka", cmbMarka.SelectedValue)
        komut.Parameters.AddWithValue("@model", cmbModel.SelectedValue)
        komut.Parameters.AddWithValue("@yil", txtModelYili.Text)
        komut.Parameters.AddWithValue("@tarih", DateTime.Now)
        komut.Parameters.AddWithValue("@motor", txtMotorNo.Text)
        komut.Parameters.AddWithValue("@eskiSase", eskiSase)

        Try
            baglanti.Open()
            Dim affectedRows As Integer = komut.ExecuteNonQuery()
            baglanti.Close()

            If affectedRows > 0 Then
                MessageBox.Show("Kayıt Güncellendi", "Bilgi")
                Listele()
                Temizle()
            Else
                MessageBox.Show("Güncelleme başarısız! Belirtilen şase numarası bulunamadı.", "Hata")
            End If
        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message, "Hata")
            baglanti.Close()
        End Try
    End Sub




    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        txtTC.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString() ' Sase_NO sütunu (0. indeks)
        lblSase.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString() ' Sase_NO sütunu (0. indeks)
        txtSase.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString() ' Sase_NO sütunu (0. indeks)
        txtPlaka.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString() ' Plaka_NO sütunu (1. indeks)
        cmbMarka.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString() ' Marka sütunu (2. indeks)
        cmbModel.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString() ' Model sütunu (3. indeks)
        txtModelYili.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString() ' Yil sütunu (4. indeks)
        txtMotorNo.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString() ' Motor_NO sütunu (6. indeks)

    End Sub



    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If DataGridView1.CurrentRow IsNot Nothing Then
            Dim saseNo As String = DataGridView1.CurrentRow.Cells("Sase_NO").Value.ToString()
            Dim frmServisBilgileri As New ServisBilgileri()
            frmServisBilgileri.lblSaseNo.Text = saseNo
            Dim frmAnasayfa As Anasayfa = TryCast(Me.ParentForm, Anasayfa)
            If frmAnasayfa IsNot Nothing Then
                frmAnasayfa.menuDegis(frmAnasayfa.Panel2, frmServisBilgileri)
            Else
                MessageBox.Show("Anasayfa formuna erişilemiyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click

        If DataGridView1.CurrentRow Is Nothing Then
            MessageBox.Show("Silinecek veri yok.", "Bilgi")
            Return
        End If

        Dim SilinecekSase As String = DataGridView1.CurrentRow.Cells("Sase_NO").Value.ToString()

        Dim sql As String = "delete from Arac_Bilgileri where Sase_NO=@Sase"
        Dim komut As New SqlCommand(sql, baglanti)
        komut.Parameters.AddWithValue("@Sase", SilinecekSase)

        baglanti.Open()
        komut.ExecuteNonQuery()
        baglanti.Close()

        MessageBox.Show("Kayit Silindi", "Bilgi")
        Listele()
        Temizle()

    End Sub




    Private Sub txtSasefiltreleme_TextChanged(sender As Object, e As EventArgs) Handles txtSasefiltreleme.TextChanged
        Dim dt As New DataTable
        Dim sql As String = "SELECT * FROM Arac_Bilgileri WHERE Sase_NO LIKE '%' + @sase + '%' OR TC LIKE '%' + @TC + '%'"

        Using baglanti As New SqlConnection("Data Source=Burak;Initial Catalog=tamirhane;Integrated Security=True")
            Dim adtr As New SqlDataAdapter(sql, baglanti)
            adtr.SelectCommand.Parameters.AddWithValue("@sase", txtSasefiltreleme.Text)
            adtr.SelectCommand.Parameters.AddWithValue("@TC", txtSasefiltreleme.Text)
            Try
                baglanti.Open()
                adtr.Fill(dt)
            Catch ex As Exception
                MessageBox.Show("Veritabanına bağlanırken bir hata oluştu: " & ex.Message)
            Finally
                baglanti.Close()
            End Try
        End Using

        DataGridView1.DataSource = dt
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

    Private Sub txtSase_TextChanged(sender As Object, e As EventArgs) Handles txtSase.TextChanged

        If txtSase.Text.Length > 17 Then
            txtSase.Text = txtSase.Text.Substring(0, 17)
            txtSase.SelectionStart = txtSase.Text.Length
        End If
    End Sub

    Private Sub txtPlaka_TextChanged(sender As Object, e As EventArgs) Handles txtPlaka.TextChanged

        If txtPlaka.Text.Length > 10 Then
            txtPlaka.Text = txtPlaka.Text.Substring(0, 10)
            txtPlaka.SelectionStart = txtPlaka.Text.Length
        End If
    End Sub


    Private Sub txtModelYili_TextChanged(sender As Object, e As EventArgs) Handles txtModelYili.TextChanged

        If txtModelYili.Text.Length > 4 Then
            txtModelYili.Text = txtModelYili.Text.Substring(0, 4)
            txtModelYili.SelectionStart = txtModelYili.Text.Length
        End If
    End Sub

    Private Sub txtModelYili_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtModelYili.KeyPress

        e.Handled = Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)
    End Sub


    Private Sub txtMotorNo_TextChanged(sender As Object, e As EventArgs) Handles txtMotorNo.TextChanged

        If txtMotorNo.Text.Length > 6 Then
            txtMotorNo.Text = txtMotorNo.Text.Substring(0, 6)
            txtMotorNo.SelectionStart = txtMotorNo.Text.Length
        End If
    End Sub

End Class
