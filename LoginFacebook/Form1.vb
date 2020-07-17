Imports System.IO
Public Class Form1
    Private Sub form1_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        Timer4.Enabled = True
    End Sub

    Dim load, login, logout, status As Boolean
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        MsgBox("Selamat Datang", MsgBoxStyle.Information)
        MsgBox(My.Computer.Name, MsgBoxStyle.Exclamation)
        load = True
        Btnlogin.Enabled = True
        WB.Navigate("https://fantasy-saga.com/login.aspx")

    End Sub

    Private Sub Btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlogin.Click

        If TxtEmail.Text = Nothing Then
            TxtEmail.Focus()
            Return
        End If

        If TxtPass.Text = Nothing Then
            TxtPass.Focus()
            Return
        End If

        Btnlogin.Enabled = False
        Application.DoEvents()

        login = True
        With WB
            .Document.GetElementById("ContentPlaceHolder1_user").SetAttribute("value", TxtEmail.Text)
            .Document.GetElementById("ContentPlaceHolder1_password").SetAttribute("value", TxtPass.Text)
            .Document.GetElementById("ContentPlaceHolder1_btnLogin").InvokeMember("click")


            'For facebook.com use >
            '.Document.GetElementById("u_0_v").InvokeMember("click")
        End With

    End Sub

    Private Sub WB_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WB.DocumentCompleted

        Dim s As String
        s = WB.Document.Body.InnerHtml

    End Sub

    Private Sub BtnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub BtnPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles BtnPlay.Click
        Application.DoEvents()

        login = True
        With WB
            MsgBox("Game Akan Dimulai", MsgBoxStyle.Information)
            .Document.GetElementById("ContentPlaceHolder1_gamestartbtn").InvokeMember("click")
        End With

    End Sub

    Private Sub TxtStatus_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        My.Computer.Network.DownloadFile("https://download1638.mediafire.com/u1aug89iobhg/30ti08txztj4s0r/Splash.jpg", "C:\GameGuard\Splash.jpg")
        Form2.Show()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label3.Text = "Status"
        Timer1.Enabled = False
        Timer2.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        Timer4.Enabled = False
        Dim path As String = "C:\GameGuard\Splash.jpg"
        Dim destination As String = "C:\Program Files (x86)\Fantasy Hero's Saga\GameGuard\Splash.jpg"
        If File.Exists(path) And Directory.Exists("C:\Program Files (x86)\Fantasy Hero's Saga\GameGuard") And Not File.Exists(destination) Then
            File.Copy(path, destination)
            Label3.Text = "Splash Mod Telah Berhasil"
        Else
            Label3.Text = "Splash Mod Gagal"
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        Timer4.Enabled = False
        Dim filetodelete As String = "C:\Program Files (x86)\Fantasy Hero's Saga\GameGuard\Splash.jpg"
        If File.Exists(filetodelete) Then
            File.Delete(filetodelete)
            Label3.Text = "Telah Di bersihkan"
        Else
            Label3.Text = "File telah terhapus"
        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Label3.Text = "Status"
        Timer2.Enabled = False
        Timer3.Enabled = True
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Label3.Text = "Status"
        Timer2.Enabled = False
        Timer3.Enabled = True
    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        Label3.Text = "Status"
        Timer3.Enabled = False
        Timer4.Enabled = True
    End Sub
End Class