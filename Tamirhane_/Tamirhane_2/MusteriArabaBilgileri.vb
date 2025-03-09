Imports System.Data.SqlClient

Public Class MusteriArabaBilgileri


    Dim baglanti As New SqlConnection($"Data Source={DatabaseHelper.GetServerName};Initial Catalog=istenen;Integrated Security=True")

    Sub Listele()
        Dim dt As New DataTable
        Dim sql As String = "SELECT M.Ad, M.Soyad, M.TC, A.Sase_NO, A.Plaka_NO, M.Mail, M.TEL " &
                        "FROM Arac_Bilgileri AS A " &
                        "INNER JOIN Musteriler AS M ON M.TC = A.TC"

        Try
            baglanti.Open() ' Bağlantıyı aç
            Dim adtr As New SqlDataAdapter(sql, baglanti)
            adtr.Fill(dt)
            DataGridView1.DataSource = dt ' Güncellenmiş verileri DataGridView'e aktar
        Catch ex As Exception
            MessageBox.Show("Veritabanından veri çekerken hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            baglanti.Close() ' Bağlantıyı her durumda kapat
        End Try
    End Sub


    Dim WithEvents Panel2 As New Panel()
    Private Sub MusteriArabaBilgileri_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listele()

        Panel2.Dock = DockStyle.Fill
        Me.Controls.Add(Panel2)
    End Sub






    Private Sub txtSaseFiltreleme_TextChanged(sender As Object, e As EventArgs) Handles txtSaseFiltreleme.TextChanged
        Dim dt As New DataTable
        Dim sql As String = "SELECT * FROM Arac_Bilgileri WHERE Sase_NO LIKE '%" & txtSaseFiltreleme.Text & "%' OR TC LIKE '%" & txtSaseFiltreleme.Text & "%'"
        Dim adtr As New SqlDataAdapter(sql, baglanti)
        adtr.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub


    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        If DataGridView1.CurrentRow IsNot Nothing Then
            ' Sase_NO değerini alın
            Dim saseNo As String = DataGridView1.CurrentRow.Cells("Sase_NO").Value.ToString()

            ' ServisBilgileri formunu oluşturun
            Dim frmServisBilgileri As New ServisBilgileri()
            frmServisBilgileri.lblSaseNo.Text = saseNo

            ' Anasayfa formunu yeniden oluşturun
            Dim frmAnasayfa As Anasayfa = TryCast(Me.ParentForm, Anasayfa)

            If frmAnasayfa IsNot Nothing Then
                frmAnasayfa.menuDegis(frmServisBilgileri)
            Else
                MessageBox.Show("Anasayfa formuna erişilemiyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class