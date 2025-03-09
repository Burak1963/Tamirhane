Imports System.Data.SqlClient

Public Class GecmisServis

    Dim baglanti As New SqlConnection($"Data Source={DatabaseHelper.GetServerName};Initial Catalog=istenen;Integrated Security=True")

    Sub Listele()
        Dim dt As New DataTable
        Dim sql As String = "select Sase_No,  Tarih from Servis"
        Dim adtr As New SqlDataAdapter(sql, baglanti)
        adtr.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub



    Private Sub txtSasefiltreleme_TextChanged(sender As Object, e As EventArgs) Handles txtSasefiltreleme.TextChanged
        Dim dt As New DataTable
        Dim sql As String = "SELECT Sase_No,Tarih FROM Servis  WHERE Sase_NO LIKE '%' + @sase + '%' or Tarih LIKE '%' + @tarih + '%'"

        Using baglanti As New SqlConnection($"Data Source={DatabaseHelper.GetServerName};Initial Catalog=istenen;Integrated Security=True")
            Dim adtr As New SqlDataAdapter(sql, baglanti)
            adtr.SelectCommand.Parameters.AddWithValue("@sase", txtSasefiltreleme.Text)
            adtr.SelectCommand.Parameters.AddWithValue("@tarih", txtSasefiltreleme.Text)
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



    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            If Not row.IsNewRow AndAlso Not IsDBNull(row.Cells("Sase_NO").Value) Then
                ' Sase_NO değerini labela atama
                lblSaseNo.Text = row.Cells("Sase_NO").Value.ToString()
            End If

            If Not row.IsNewRow AndAlso Not IsDBNull(row.Cells("Tarih").Value) Then
                ' Sase_NO değerini labela atama
                lblTarih.Text = row.Cells("Tarih").Value.ToString()
            End If


            If Not row.IsNewRow AndAlso Not IsDBNull(row.Cells("Sase_NO").Value) Then
                Dim saseNo As String = row.Cells("Sase_NO").Value.ToString()
                Dim tarih As DateTime = Convert.ToDateTime(row.Cells("Tarih").Value)



                Dim query As String = "SELECT Sikayet, KM, Yapilan_İslem, Aciklama FROM Servis WHERE Sase_NO = @SaseNo AND Tarih = @Tarih"
                Using conn As New SqlConnection($"Data Source={DatabaseHelper.GetServerName};Initial Catalog=istenen;Integrated Security=True")
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@SaseNo", saseNo)
                        cmd.Parameters.AddWithValue("@Tarih", tarih)

                        conn.Open()
                        Using reader As SqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                txtSikayet.Text = reader("Sikayet").ToString()
                                txtKM.Text = reader("KM").ToString()
                                txtYapilanIslem.Text = reader("Yapilan_İslem").ToString()
                                txtAciklama.Text = reader("Aciklama").ToString()
                            End If
                        End Using
                    End Using
                End Using
            End If
        End If
    End Sub


    Private Sub GecmisServis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listele()
    End Sub

    Private Sub btnguncelle_Click(sender As Object, e As EventArgs) Handles btnguncelle.Click



        Dim sql As String = "UPDATE Servis SET Sikayet =@sikayet, KM=@km, Yapilan_İslem=@yapilanislem, Aciklama=@aciklama  WHERE Sase_NO=@eskiSase and Tarih=@tarih"

        Dim komut As New SqlCommand(sql, baglanti)
        komut.Parameters.AddWithValue("@eskisase", lblSaseNo.Text)



        Dim tarih As DateTime
        If DateTime.TryParse(lblTarih.Text, tarih) Then
            komut.Parameters.AddWithValue("@tarih", tarih.ToString("yyyy-MM-dd"))
        Else
            MessageBox.Show("Geçerli bir tarih giriniz.")
            Return ' Geçerli bir tarih değilse işlemi sonlandır
        End If


        komut.Parameters.AddWithValue("@sikayet", txtSikayet.Text)
        komut.Parameters.AddWithValue("@km", txtKM.Text)
        komut.Parameters.AddWithValue("@yapilanislem", txtYapilanIslem.Text)
        komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text)
        ' Güncellenecek kaydı belirtmek için

        baglanti.Open()
        komut.ExecuteNonQuery()
        baglanti.Close()

        MessageBox.Show("Kayıt Güncellendi", "Bilgi")
        Listele()
        Temizle()
    End Sub

    Sub Temizle()
        lblSaseNo.Text = String.Empty
        lblTarih.Text = String.Empty
        txtSikayet.Text = String.Empty
        txtKM.Text = String.Empty
        txtYapilanIslem.Text = String.Empty
        txtAciklama.Text = String.Empty


    End Sub

    Private Sub txtKM_TextChanged(sender As Object, e As EventArgs) Handles txtKM.TextChanged

        If txtKM.Text.Length > 7 Then
            txtKM.Text = txtKM.Text.Substring(0, 7)
            txtKM.SelectionStart = txtKM.Text.Length
        End If
    End Sub

    Private Sub txtKM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKM.KeyPress
        e.Handled = Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)
    End Sub
End Class