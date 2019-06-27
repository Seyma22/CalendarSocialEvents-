''' <summary>
''' Etkinliğin niteliklerini belirleyen sınıf
''' </summary>

Public Class Etkinlik
    Private title As String
    Private eventDate As String
    Private eventUrl As String

    '' get ve set için property ler
    Public Property titleProperty() As String
        Get
            Return title
        End Get
        Set(value As String)
            title = value
        End Set
    End Property
    Public Property eventDateProperty() As String
        Get
            Return eventDate
        End Get
        Set(value As String)
            eventDate = value
        End Set
    End Property
    Public Property eventUrlProperty() As String
        Get
            Return eventUrl
        End Get
        Set(value As String)
            eventUrl = value
        End Set
    End Property

End Class
