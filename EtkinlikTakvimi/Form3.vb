
''' <summary>
''' ETKİNLİKLERİN ARAMA KRİTERLERİNİN SEÇİLDİĞİ FORM
''' </summary>

Public Class Form3

    Dim selectedCity As String
    Dim selectedType As String

    ''combobox varsayılan seçim
    Private Sub setDefault()
        If ComboBox1.Items.Count > 0 Then
            ComboBox1.SelectedIndex = 0    ' The first item has index 0 '
        End If
        If ComboBox2.Items.Count > 0 Then
            ComboBox2.SelectedIndex = 0    ' The first item has index 0 '
        End If
    End Sub

    ''groupbox hizalama
    Private Sub centerGB()
        GroupBox1.Top = (Me.ClientSize.Height / 2) - (GroupBox1.Height / 2)
        GroupBox1.Left = (Me.ClientSize.Width / 2) - (GroupBox1.Width / 2)
    End Sub
    Private Sub Form3_Resize(ByVal sender As Object,
                     ByVal e As System.EventArgs) Handles MyBase.Resize
        centerGB()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        centerGB()
        setDefault()
    End Sub

    Private Sub newBtn_Click(sender As Object, e As EventArgs) Handles newBtn.Click

        If ComboBox1.SelectedIndex = 0 Or ComboBox2.SelectedIndex = 0 Then
            MessageBox.Show("Kutular boş bırakılamaz!")
        Else
            selectedCity = Convert.ToString(ComboBox1.SelectedItem)
            selectedType = Convert.ToString(ComboBox2.SelectedItem)

            Dim biletinialObj As New Biletinial(selectedCity, selectedType)
            If biletinialObj.getEvents.Count > 0 Then
                Dim obj As New Form4
                obj.city = selectedCity
                obj.type = selectedType
                obj.Show()
                Hide()
            End If
        End If

    End Sub

End Class