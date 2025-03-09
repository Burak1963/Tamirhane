Imports System.Data.SqlClient

Public Class ServisBilgileri




    Dim baglanti As New SqlConnection($"Data Source={DatabaseHelper.GetServerName};Initial Catalog=istenen;Integrated Security=True")


    Sub Temizle()
            lblSaseNo.Text = String.Empty
            txtSikayet.Text = String.Empty
        KM.Text = String.Empty
        txtYapilanIslem.Text = String.Empty

        txtAciklama.Text = String.Empty


    End Sub





    Private Sub btnkaydet_Click(sender As Object, e As EventArgs) Handles btnkaydet.Click




        Try
            Dim saseNo As String = lblSaseNo.Text


            Dim sql As String = "INSERT INTO Servis (Personel_ID, Sase_NO, KM, Sikayet, Yapilan_İslem,  Aciklama) " &
                            "VALUES (@Personel_ID, @Sase_NO, @KM, @Sikayet, @Yapilan_İslem, @Aciklama)"
            Dim komut As New SqlCommand(sql, baglanti)
            komut.Parameters.AddWithValue("@Personel_ID", GirisPaneli.persId)
            komut.Parameters.AddWithValue("@Sase_NO", saseNo)
            komut.Parameters.AddWithValue("KM", KM.Text)
            komut.Parameters.AddWithValue("@Sikayet", txtSikayet.Text)
            komut.Parameters.AddWithValue("@Yapilan_İslem", txtYapilanIslem.Text)

            komut.Parameters.AddWithValue("@Aciklama", txtAciklama.Text)




            baglanti.Open()
            komut.ExecuteNonQuery()
            baglanti.Close()

            MessageBox.Show("Kayıt başarıyla eklendi.", "Bilgi")

            Temizle()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Dim WithEvents Panel2 As New Panel()

    Private Sub KM_TextChanged(sender As Object, e As EventArgs) Handles KM.TextChanged

        ' Eğer girilen metin 7 karakterden uzunsa, 7 karakterle sınırla
        If KM.Text.Length > 7 Then
            KM.Text = KM.Text.Substring(0, 7)
            KM.SelectionStart = KM.Text.Length ' İmleci sona al
        End If


    End Sub

    Private Sub KM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles KM.KeyPress
        e.Handled = Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)
    End Sub
End Class
