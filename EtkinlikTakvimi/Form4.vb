
''' <summary>
''' ARAMA SONRASINDA BULUNAN ETKİNLİKLERİN SIRALANACAĞI FORM
''' </summary>

Public Class Form4

    Public Property city As String
    Public Property type As String
    Dim list As List(Of Etkinlik)
    Dim dom = AppDomain.CurrentDomain.BaseDirectory

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim biletinialObj As New Biletinial(city, type)
        list = biletinialObj.getEvents

        For Each l In list
            ListBox1.Items.Add(l.eventDateProperty & "  |||||  " & l.titleProperty)
        Next
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Form3.Show()
        Hide()
    End Sub

    Private Sub detailBtn_Click(sender As Object, e As EventArgs) Handles detailBtn.Click
        Dim selectedItemIndex As Integer
        selectedItemIndex = ListBox1.SelectedIndex

        Dim obj As New Form5
        obj.url = list(selectedItemIndex).eventUrlProperty
        obj.f = Me
        obj.Show()
        Hide()
    End Sub


End Class