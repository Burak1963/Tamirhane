Imports System.Data.SqlClient

Public Class Ayarlar

    Dim baglanti As New SqlConnection($"Data Source={DatabaseHelper.GetServerName};Initial Catalog=istenen;Integrated Security=True")
    Dim textBoxes() As TextBox

    Private Sub Ayarlar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MarkaListele()
        ModelListele()

        ' Formdaki tüm TextBox'ları al ve temizle
        textBoxes = GetAllTextBoxes(Me).ToArray()
        Temizle(textBoxes)
    End Sub

    Private Sub MarkaListele()
        Dim MarkaTablo As New DataTable()
        Dim sql As String = "SELECT * FROM Markalar"
        Dim adtr As New SqlDataAdapter(sql, baglanti)
        adtr.Fill(MarkaTablo)
        dataGridView2.DataSource = MarkaTablo

        cmbMarka.ValueMember = "Marka_ID"
        cmbMarka.DisplayMember = "Marka_Adi"
        cmbMarka.DataSource = MarkaTablo
    End Sub

    Private Sub ModelListele()
        Dim ModelTablo As New DataTable()
        Dim sql As String = "SELECT m.Model_ID, ma.Marka_Adi AS [Marka Adı], m.Model_Adi AS [Model Adı] " &
                            "FROM Modeller m " &
                            "INNER JOIN Markalar ma ON m.Marka_ID = ma.Marka_ID"
        Dim adtr As New SqlDataAdapter(sql, baglanti)
        adtr.Fill(ModelTablo)
        dataGridView1.DataSource = ModelTablo
    End Sub

    Private Sub btnMarkaSil_Click(sender As Object, e As EventArgs) Handles btnMarkaSil.Click
        If dataGridView2.CurrentRow Is Nothing Then
            MessageBox.Show("Silinecek bir marka seçmediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim SilinecekMarka As String = dataGridView2.CurrentRow.Cells("Marka_ID").Value.ToString()

        Dim MarkaSil As String = "DELETE FROM Markalar WHERE Marka_ID=@id"
        Using baglanti As New SqlConnection($"Data Source={DatabaseHelper.GetServerName};Initial Catalog=istenen;Integrated Security=True"),
          Sil As New SqlCommand(MarkaSil, baglanti)
            Sil.Parameters.AddWithValue("@id", SilinecekMarka)

            Try
                baglanti.Open()
                Sil.ExecuteNonQuery()
                MessageBox.Show("Marka Silindi", "Bilgi")
            Catch ex As Exception
                MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        Temizle(textBoxes)
        ModelListele()
        MarkaListele()

    End Sub


    Private Sub btnMarkaKaydet_Click(sender As Object, e As EventArgs) Handles btnMarkaKaydet.Click
        Dim sql As String = "INSERT INTO Markalar (Marka_Adi) VALUES (@ad)"
        Dim cmd As New SqlCommand(sql, baglanti)
        cmd.Parameters.AddWithValue("@ad", txtMarkaAdi.Text)

        baglanti.Open()
        cmd.ExecuteNonQuery()
        baglanti.Close()

        MessageBox.Show("Marka Kaydedildi", "Bilgi")

        MarkaListele()
        Temizle(textBoxes)
    End Sub

    Private Sub btnMarkaGuncelle_Click(sender As Object, e As EventArgs) Handles btnMarkaGuncelle.Click
        ' Eğer güncellenecek marka ID'si boş ise uyarı ver
        If String.IsNullOrWhiteSpace(lblMarkaID.Text) Then
            MessageBox.Show("Güncellenecek bir marka bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim sql As String = "UPDATE Markalar SET Marka_Adi=@ad WHERE Marka_ID=@id"
        Dim cmd As New SqlCommand(sql, baglanti)
        cmd.Parameters.AddWithValue("@id", lblMarkaID.Text)
        cmd.Parameters.AddWithValue("@ad", txtMarkaAdi.Text)

        Try
            baglanti.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected = 0 Then
                MessageBox.Show("Güncellenecek bir marka bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Marka güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Bir hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            baglanti.Close()
        End Try

        MarkaListele()
        ModelListele()

        Temizle(textBoxes)
    End Sub


    ' TextBox'ları temizleme metodu
    Public Sub Temizle(array As TextBox())
        For Each tb As TextBox In array
            tb.Text = String.Empty
        Next
    End Sub

    ' Formdaki tüm TextBox'ları almak için yöntem
    Public Function GetAllTextBoxes(control As Control) As IEnumerable(Of TextBox)
        Dim textboxes As IEnumerable(Of TextBox) = control.Controls.OfType(Of TextBox)()
        For Each childControl As Control In control.Controls
            textboxes = textboxes.Concat(GetAllTextBoxes(childControl)).ToArray()
        Next
        Return textboxes
    End Function



    Private Sub dataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView2.CellDoubleClick
        lblMarkaID.Text = dataGridView2.CurrentRow.Cells("Marka_ID").Value.ToString()
        txtMarkaAdi.Text = dataGridView2.CurrentRow.Cells("Marka_Adi").Value.ToString()
    End Sub


    Private Sub btnModelKaydet_Click(sender As Object, e As EventArgs) Handles btnModelKaydet.Click
        Dim modelKaydetDt As New DataTable()
        Dim modelKaydetDa As New SqlDataAdapter("INSERT INTO Modeller (Marka_ID, Model_Adi) VALUES (@markaid, @modeladi)", baglanti)

        modelKaydetDa.SelectCommand.Parameters.AddWithValue("@markaid", cmbMarka.SelectedValue) ' Markalar tablosundaki Marka_ID
        modelKaydetDa.SelectCommand.Parameters.AddWithValue("@modeladi", txtModelAdi.Text) ' Modeller tablosundaki Model_Adi

        modelKaydetDa.Fill(modelKaydetDt)

        MessageBox.Show("Model Kaydedildi", "Bilgi")

        ModelListele() ' Yeni kayıt sonrası listeyi güncelle

        Temizle(textBoxes) ' Formdaki textBox'ları temizle
    End Sub



    Private Sub dataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellDoubleClick
        lblModelID.Text = dataGridView1.CurrentRow.Cells("Model_ID").Value.ToString()
        txtModelAdi.Text = dataGridView1.CurrentRow.Cells("Model Adı").Value.ToString()
        cmbMarka.Text = dataGridView1.CurrentRow.Cells("Marka Adı").Value.ToString()
    End Sub

    Private Sub btnModelSil_Click(sender As Object, e As EventArgs) Handles btnModelSil.Click
        ' DataGridView'de satır var mı kontrol edelim:
        If dataGridView1.CurrentRow Is Nothing OrElse dataGridView1.CurrentRow.Cells("Model_ID").Value Is Nothing Then
            MessageBox.Show("Silinecek bir model bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim silinecekModel As String = dataGridView1.CurrentRow.Cells("Model_ID").Value.ToString()
        Dim modelSil As String = "DELETE FROM Modeller WHERE Model_ID=@id"

        Using sil As New SqlCommand(modelSil, baglanti)
            sil.Parameters.AddWithValue("@id", silinecekModel)

            Try
                baglanti.Open()
                sil.ExecuteNonQuery()
                MessageBox.Show("Model silindi.", "Bilgi")
            Catch ex As Exception
                MessageBox.Show("Bir hata oluştu: " & ex.Message, "Hata")
            Finally
                baglanti.Close()
            End Try
        End Using

        Temizle(textBoxes)
        ModelListele()
    End Sub


    Private Sub btnModelGuncelle_Click(sender As Object, e As EventArgs) Handles btnModelGuncelle.Click
        Dim modelGuncelle As String = "UPDATE Modeller SET Marka_ID=@markaid, Model_Adi=@modeladi WHERE Model_ID=@id"

        Dim modelID As Integer
        If Not Integer.TryParse(lblModelID.Text, modelID) Then
            MessageBox.Show("Güncellenecek bir model bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim markaID As Integer
        If Not Integer.TryParse(cmbMarka.SelectedValue.ToString(), markaID) Then
            MessageBox.Show("Geçerli bir marka seçimi yapılmadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim guncelle As New SqlCommand(modelGuncelle, baglanti)
        guncelle.Parameters.AddWithValue("@id", modelID)
        guncelle.Parameters.AddWithValue("@markaid", markaID)
        guncelle.Parameters.AddWithValue("@modeladi", txtModelAdi.Text)

        Try
            baglanti.Open()
            Dim rowsAffected As Integer = guncelle.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Kayıt güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Güncellenecek bir model bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Bir hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            baglanti.Close()
        End Try

        ModelListele()
        Temizle(textBoxes)
    End Sub


End Class
