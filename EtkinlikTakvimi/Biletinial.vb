Imports System.Net
Imports System.Text.RegularExpressions
Imports HtmlAgilityPack

''' <summary>
''' biletinial.com üzerindeki işlemleri tutan sınıf
''' </summary>

Public Class Biletinial
    Private city, type As String
    Dim i As Integer = 0
    Dim j As Integer = 0
    Dim k As Integer = 0

    Dim eventList As List(Of Etkinlik) = New List(Of Etkinlik)
    ''yapıcı fonksiyon => nesne oluşturulurken string şehir ve string etkinlik türü parametrelerini alır
    Public Sub New(c As String, t As String)
        city = c
        type = t
    End Sub

    Private Function getCityId(cityName As String) As String
        Dim ht As Hashtable = New Hashtable()
        ht.Add("İstanbul Avrupa", 5)
        ht.Add("İstanbul Anadolu", 77)
        ht.Add("Ankara", 3)
        ht.Add("Eskişehir", 19)
        ht.Add("İzmir", 24)
        ht.Add("Amasya", 75)
        ht.Add("Antalya", 23)
        ht.Add("Artvin", 80)
        ht.Add("Aydın", 29)
        ht.Add("Balıkesir", 25)
        ht.Add("Bartın", 35)
        ht.Add("Bolu", 36)
        ht.Add("Burdur", 81)
        ht.Add("Bursa", 11)
        ht.Add("Çorum", 74)
        ht.Add("Denizli", 14)
        ht.Add("Gaziantep", 9)
        ht.Add("Giresun", 88)
        ht.Add("Isparta", 28)
        ht.Add("Kastamonu", 41)
        ht.Add("Kayseri", 83)
        ht.Add("Kocaeli", 20)
        ht.Add("Kütahya", 38)
        ht.Add("Manisa", 69)
        ht.Add("Muğla", 4)
        ht.Add("Nevşehir", 18)
        ht.Add("Niğde", 82)
        ht.Add("Ordu", 48)
        ht.Add("Rize", 32)
        ht.Add("Sakarya", 39)
        ht.Add("Samsun", 43)
        ht.Add("Sivas", 73)
        ht.Add("Tabzon", 16)
        ht.Add("Zonguldak", 6)
        ht.Add("Karaman", 45)
        ht.Add("Düzce", 31)
        ht.Add("Kıbrıs", 55)
        Return ht(cityName)
    End Function

    Private Function createUrl()
        Dim url As String
        url = "https://biletinial.com/" & type & "?cityId=" & getCityId(city) & "&date="
        Return url
    End Function

    Public Function getEvents() As List(Of Etkinlik)
        Dim web As New HtmlWeb
        Dim doc As New HtmlDocument
        doc = web.Load(createUrl())
        Try
            ''bulunan her bir etkinliğin ismi alınıyor
            For Each l As HtmlNode In doc.DocumentNode.SelectNodes("//div[@class='event-title']")
                Dim obj As New Etkinlik()
                obj.titleProperty = WebUtility.HtmlDecode(l.InnerText)
                eventList.Add(obj)
            Next
            ''bulunan her bir etkinliğin tarihi alınıyor
            For Each l As HtmlNode In doc.DocumentNode.SelectNodes("//div[@class='col-md-6 col-sm-8 col-xs-12']//div[@class='date']")
                eventList(i).eventDateProperty = WebUtility.HtmlDecode(l.InnerText).Replace(" ", "")
                i += 1
            Next
            ''bulunan her bir etkinliğin url i alınıyor
            For Each l As HtmlNode In doc.DocumentNode.SelectNodes("//div[@class='col-md-6 col-sm-8 col-xs-12']")
                For Each slide In l.SelectNodes(".//div[@class='event-card']")
                    eventList(j).eventUrlProperty = "https://biletinial.com" & WebUtility.HtmlDecode(slide.SelectSingleNode(".//a").Attributes("href").Value)
                    j += 1
                Next
            Next
        Catch ex As Exception
            MessageBox.Show("Etkinlik Bulunamadı!")
        End Try
        Return eventList
    End Function


End Class
