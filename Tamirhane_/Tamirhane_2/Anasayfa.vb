Imports System.Data.SqlClient

Public Class Anasayfa


    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader



    Sub menuDegis(acilanform As Form)
        Panel2.Controls.Clear()
        acilanform.TopLevel = False
        Panel2.Controls.Add(acilanform)
        acilanform.Show()
    End Sub

    Public Sub menuDegis(acilanpanel As Panel, acilanform As Form)
        ' Panel2'nin içeriğini temizleyin
        acilanpanel.Controls.Clear()

        ' Formu panelin içine yerleştirin
        acilanform.TopLevel = False
        acilanform.FormBorderStyle = FormBorderStyle.None
        acilanform.Dock = DockStyle.Fill
        acilanpanel.Controls.Add(acilanform)

        ' Formu gösterin
        acilanform.Show()
    End Sub








    Private Sub btnaracbilgileri_Click(sender As Object, e As EventArgs) Handles btnaracbilgileri.Click
        menuDegis(AracBilgileri)
        AracBilgileri.Listele()
        AracBilgileri.MarkaListele()


    End Sub

    Private Sub btnmusteribilgileri_Click(sender As Object, e As EventArgs) Handles btnmusteribilgileri.Click
        menuDegis(MusteriBilgileri)
        MusteriBilgileri.Listele()
    End Sub

    Private Sub btnMusteriAracBilgileri_Click(sender As Object, e As EventArgs) Handles btnMusteriAracBilgileri.Click
        menuDegis(MusteriArabaBilgileri)
        MusteriArabaBilgileri.Listele()
    End Sub

    Private Sub btnservisbilgileri_Click(sender As Object, e As EventArgs) Handles btnservisbilgileri.Click
        menuDegis(ServisBilgileri)
    End Sub

    Private Sub btncikis_Click(sender As Object, e As EventArgs) Handles btncikis.Click
        Application.Exit()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        menuDegis(Anasayfa_Buton)
    End Sub

    Private Sub btnGecmmisServisBilgileri_Click(sender As Object, e As EventArgs) Handles btnGecmmisServisBilgileri.Click
        menuDegis(GecmisServis)
        GecmisServis.Listele()
        GecmisServis.Temizle()

    End Sub

    Private Sub btnAyarlar_Click(sender As Object, e As EventArgs) Handles btnAyarlar.Click
        menuDegis(Ayarlar)

    End Sub

    Private Sub Anasayfa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class