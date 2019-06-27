Imports System.Net
Imports HtmlAgilityPack

''' <summary>
''' SEÇİLEN ETKİNLİĞİN DETAYLARINI GÖSTEREN FORM
''' </summary>

Public Class Form5
    Public Property url As String
    Public Property f As Form4

    Dim doc As New HtmlDocument

    Public Sub setTitle()
        Try
            Dim title As String = doc.DocumentNode.SelectSingleNode("/html/body/div[1]/div[2]/div[2]/div/div[1]/div[2]/div[1]/div[1]/h1").InnerText
            headerTb.Text = WebUtility.HtmlDecode(title)
        Catch ex As Exception
            MessageBox.Show("Hata oluştu!")
        End Try

    End Sub
    Private Sub setPicture()
        Try
            Dim picUrl As String = doc.DocumentNode.SelectSingleNode("/html/body/div[1]/div[2]/div[2]/div/div[1]/div[1]/div[1]/img").Attributes("src").Value
            PictureBox1.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(picUrl)))
        Catch ex As Exception
            MessageBox.Show("Hata oluştu!")
        End Try
    End Sub
    Public Sub setContent()
        Try
            Dim content As String = doc.DocumentNode.SelectSingleNode("//*[@id='movie-detail']").InnerText
            contentTb.Text = WebUtility.HtmlDecode(content)
        Catch ex As Exception
            MessageBox.Show("Hata oluştu!")
        End Try
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim web As New HtmlWeb
        doc = web.Load(url)
        setPicture()
        setTitle()
        setContent()
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        f.Show()
        Close()
    End Sub
End Class