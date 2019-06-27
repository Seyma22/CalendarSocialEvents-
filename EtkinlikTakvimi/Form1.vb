Imports System.Data.OleDb

''' <summary>
''' GİRİŞ İŞLEMLERİNİN YAPILDIĞI FORM
''' </summary>

Public Class Form1
    Public Shared theUser As String ''programı kullanan kullanıcı burda tutulacak
    Dim success As Boolean = False

    ''login kontrol sub
    Private Sub login(t1 As TextBox, t2 As TextBox)
        Dim uname As String = ""
        Dim pword As String
        Dim username As String = ""
        Dim pass As String = ""
        If t1.Text = "" Or t2.Text = "" Then
            MsgBox("Kutular boş bırakılamaz!")
        Else
            uname = t1.Text
            pword = t2.Text
            Dim querry As String = "Select password From users where username= '" & uname & "';"
            Dim dir As String = AppDomain.CurrentDomain.BaseDirectory.ToString
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & AppDomain.CurrentDomain.BaseDirectory & "\Database1.accdb"
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()
            Try
                pass = cmd.ExecuteScalar().ToString
            Catch ex As Exception

            End Try
            If (pword = pass) Then
                MsgBox("Giriş Başarılı!")
                theUser = uname
                success = True
            Else
                MsgBox("Giriş Hatalı!")
                t1.Clear()
                t2.Clear()
            End If
        End If
    End Sub

    ''giriş butonu tıklandığında..
    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        login(TextBox1, TextBox2)
        If (success) Then
            Form3.Show()
            Hide()
        End If
    End Sub

    ''yeni kayıt butonu tıklandığında..
    Private Sub newBtn_Click(sender As Object, e As EventArgs) Handles newBtn.Click
        Form2.Show()
        Hide()
    End Sub

    ''groupbox hizalama
    Private Sub centerGB()
        GroupBox1.Top = (Me.ClientSize.Height / 2) - (GroupBox1.Height / 2)
        GroupBox1.Left = (Me.ClientSize.Width / 2) - (GroupBox1.Width / 2)
    End Sub
    Private Sub Form1_Resize(ByVal sender As Object,
                     ByVal e As System.EventArgs) Handles MyBase.Resize
        centerGB()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        centerGB()
    End Sub
End Class
