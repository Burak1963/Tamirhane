Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class GirisPaneli


    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader


    Private Sub btngiris_Click(sender As Object, e As EventArgs) Handles btngiris.Click
        If (txtkullaniciadi.Text = "") Then
            MsgBox("Kullanıcı adı giriniz")
            txtkullaniciadi.Focus()
            Exit Sub
        End If

        If (txtsifre.Text = "") Then
            MsgBox("Sifre giriniz")
            txtsifre.Focus()
            Exit Sub

        End If

        Try
            con = New SqlConnection($"Data Source={DatabaseHelper.GetServerName};Initial Catalog=istenen;Integrated Security=True")
            con.Open()
            cmd = New SqlCommand("Select * from Personeller where Personel_Adi= '" & txtkullaniciadi.Text & "' and Personel_Sifre= '" & txtsifre.Text & "'")
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If (rdr.Read()) Then
                Dim pers_id As String = rdr("Personel_ID").ToString()
                Dim pers_Ad As String = rdr("Personel_Adi").ToString()
                persId = pers_id
                persAd = pers_Ad
                Anasayfa.Show()
                Me.Hide()
            Else
                MsgBox("Geçerli bir kullanıcı adı ve şifre giriniz")
                txtkullaniciadi.Text = ""
                txtsifre.Text = ""
            End If

        Catch ex As Exception

        End Try
    End Sub

    Public Shared persId As String
    Public Shared persAd As String

    Private Sub btncikis_Click(sender As Object, e As EventArgs) Handles btncikis.Click
        Application.Exit()
    End Sub

    Private Sub GirisPaneli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatabaseHelper.SetupDatabase()
        Dim filePath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory)
        filePath &= "\updater.exe"

        Try
            Process.Start(filePath)
        Catch ex As Exception
            MessageBox.Show("Güncelleme kontrol edilirken hata oluştu: " & ex.Message)
        End Try
    End Sub
End Class
