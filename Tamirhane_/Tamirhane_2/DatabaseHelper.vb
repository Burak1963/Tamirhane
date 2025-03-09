Imports Microsoft.Win32
Imports System.Data.SqlClient

Public Class DatabaseHelper

    Public Shared Function GetServerName() As String
        Try
            Dim serverName As String = Environment.MachineName
            Dim registryView As RegistryView = If(Environment.Is64BitOperatingSystem, RegistryView.Registry64, RegistryView.Registry32)
            Using hklm As RegistryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView)
                Dim instanceKey As RegistryKey = hklm.OpenSubKey("SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", False)
                If instanceKey IsNot Nothing AndAlso instanceKey.GetValueNames().Length > 0 Then
                    For Each instanceName As String In instanceKey.GetValueNames()
                        If instanceName = "SQLEXPRESS" Then
                            Return $"{serverName}\{instanceName}"
                        End If
                    Next
                End If
            End Using
            Return "Server Bulunamadı."
        Catch ex As Exception
            Return "Server Bulunamadı."
        End Try
    End Function
    Public Shared Sub SetupDatabase()
        Dim serverName As String = GetServerName()

        Dim connectionString As String = $"Server={serverName};Integrated Security=True;"
        Dim databaseName As String = "istenen"


        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim createDatabaseQuery As String = $"IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = '{databaseName}') CREATE DATABASE {databaseName};"
                Using cmd As New SqlCommand(createDatabaseQuery, connection)
                    cmd.ExecuteNonQuery()
                End Using

                connection.ChangeDatabase(databaseName)

                Dim createTablesQuery As String = $"
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Gorevler')
CREATE TABLE Gorevler (
    Gorev_ID int PRIMARY KEY IDENTITY(1,1),
    Gorev_Adi nvarchar(25)
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Personeller')
CREATE TABLE Personeller (
    Personel_ID int PRIMARY KEY IDENTITY(1,1),
    Personel_Adi nvarchar(50),
    Personel_Soyadi nvarchar(50),
    Personel_Gorev_ID int,
    Personel_TC nvarchar(11) UNIQUE,
    Personel_Tel nvarchar(11) UNIQUE,
    Personel_Mail nvarchar(50) UNIQUE,
    Personel_Sifre nvarchar(6),
    FOREIGN KEY (Personel_Gorev_ID) REFERENCES Gorevler(Gorev_ID)
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Markalar')
CREATE TABLE Markalar (
    Marka_ID int PRIMARY KEY IDENTITY(1,1),
    Marka_Adi nvarchar(50)
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Modeller')
CREATE TABLE Modeller (
    Model_ID int PRIMARY KEY IDENTITY(1,1),
    Marka_ID int,
    Model_Adi nvarchar(50),
    FOREIGN KEY (Marka_ID) REFERENCES Markalar(Marka_ID) ON DELETE CASCADE
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Musteriler')
CREATE TABLE Musteriler (
    TC NVARCHAR(11) PRIMARY KEY,
    Ad NVARCHAR(50),
    Soyad NVARCHAR(50),
    TEL NVARCHAR(11) UNIQUE,
    Mail NVARCHAR(50) UNIQUE,
    Adres TEXT,
    Tarih DATETIME DEFAULT GETDATE()
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Arac_Bilgileri')
CREATE TABLE Arac_Bilgileri (
    Sase_NO nvarchar(17) PRIMARY KEY NOT NULL,
    TC NVARCHAR(11),
    Plaka_NO nvarchar(10) UNIQUE,
    Marka_ID int,
    Model_ID int,
    Yil nvarchar(4),
    Motor_NO nvarchar(6) NOT NULL,
    Tarih datetime DEFAULT GETDATE(),
   FOREIGN KEY (Marka_ID) REFERENCES Markalar(Marka_ID) ,
    FOREIGN KEY (Model_ID) REFERENCES Modeller(Model_ID) ,
    FOREIGN KEY (TC) REFERENCES Musteriler(TC) ON UPDATE CASCADE ON DELETE CASCADE
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Servis')
CREATE TABLE Servis (
    Giris_ID int PRIMARY KEY IDENTITY(1,1),
    Personel_ID int,
    Sase_NO nvarchar(17),
    KM nvarchar(7),
    Sikayet text,
    Yapilan_İslem varchar(max),
    Aciklama text,
    Tarih DATE DEFAULT GETDATE(),
    FOREIGN KEY (Personel_ID) REFERENCES Personeller(Personel_ID),
    FOREIGN KEY (Sase_NO) REFERENCES Arac_Bilgileri(Sase_NO) on update cascade ON DELETE CASCADE
);

IF NOT EXISTS (SELECT * FROM Gorevler WHERE Gorev_Adi = 'Usta')
INSERT INTO Gorevler (Gorev_Adi) VALUES ('Usta');

IF NOT EXISTS (SELECT * FROM Gorevler WHERE Gorev_Adi = 'Çırak')
INSERT INTO Gorevler (Gorev_Adi) VALUES ('Çırak');

IF NOT EXISTS (SELECT * FROM Personeller WHERE Personel_TC = '00000000000')
INSERT INTO Personeller (
    Personel_Adi,
    Personel_Soyadi,
    Personel_Gorev_ID,
    Personel_TC,
    Personel_Tel,
    Personel_Mail,
    Personel_Sifre
) 
VALUES (
    'ormetal',
    'Emrah Sezer',
    1,
    '00000000000',
    '00000000000',
    'ormetal@gmail.com',
    '*123'
);
"


                Using cmd As New SqlCommand(createTablesQuery, connection)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Veri tabanı ve/veya tablolar oluşturulurken hata: " & ex.Message)
        End Try
    End Sub


End Class
