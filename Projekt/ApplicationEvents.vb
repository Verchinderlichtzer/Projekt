Imports System.Globalization, System.IO, MadMilkman.Ini

Namespace My
    Partial Friend Class MyApplication
        Dim UserCookies As String = Nothing
        Private Sub MyApplication_Startup(sender As Object, e As ApplicationServices.StartupEventArgs) Handles Me.Startup
            If Not Directory.Exists(Path) Then
                Directory.CreateDirectory(Path)
            End If
            If Not File.Exists(Path & "\Projekt.ini") Then
                FileOpen(1, Path & "\Projekt.ini", OpenMode.Output)
                PrintLine(1, "[konfigurasi]")
                PrintLine(1, "username=")
                PrintLine(1, "nama=")
                PrintLine(1, "alamat=")
                PrintLine(1, "telepon=")
                PrintLine(1, "fax=")
                PrintLine(1, "email=")
                PrintLine(1, "website=")
                FileClose(1)
            End If
            If Not File.Exists(Path & "\Projekt.accdb") Then
                Computer.FileSystem.MoveFile(Application.Info.DirectoryPath & "\Projekt.accdb", Path & "\Projekt.accdb")
            End If
            Koneksi()
            Dim us = New CultureInfo("en-US")
            CultureInfo.DefaultThreadCurrentCulture = us
            CultureInfo.DefaultThreadCurrentUICulture = us

            'Dim Ini As New IniFile
            'Ini.Load(Path & "\Projekt.ini")
            'UserCookies = Ini.Sections("konfigurasi").Keys("username").Value
            'QR("SELECT username FROM tbluser WHERE username = '" & UserCookies & "'")
            'If DR.HasRows Then
            '    UserAktif = DR(0)
            '    Application.MainForm = MainF
            '    FormStartup = "MainF"
            'Else
            '    Application.MainForm = Login
            '    FormStartup = "Login"
            'End If
        End Sub
    End Class
End Namespace