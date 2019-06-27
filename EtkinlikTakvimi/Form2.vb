Imports System.Data.OleDb

''' <summary>
''' YENİ KULLANICININ OLUŞTURULDUĞU FORM
''' </summary>

Public Class Form2



    ''işlemlere devam ederken kullanıcıyı kullanıcıyı proje genelinde 
    ''bir değişkende tutabiliriz
    Private theUser As String

    Private Sub newUser(t1 As TextBox, t2 As TextBox, f As Form)
        If t1.Text = "" Or t2.Text = "" Then
            MsgBox("Kutular boş bırakılamaz!")
        Else
            Try
                Dim dir As String = AppDomain.CurrentDomain.BaseDirectory.ToString
                Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & AppDomain.CurrentDomain.BaseDirectory & "\Database1.accdb"
                Dim conn As New OleDbConnection(dbsource)
                Dim insert As String = "Insert into users values('" & t1.Text & "','" & t2.Text & "');"
                Dim cmd As New OleDbCommand(insert, conn)
                conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Kullanıcı kaydı oluşturuldu!")
                Me.Close()
                f.Show()
            Catch ex As Exception
                MsgBox("Hata!")
            End Try
        End If
    End Sub

    Sub newBtn_Click(sender As Object, e As EventArgs) Handles newBtn.Click
        newUser(TextBox1, TextBox2, Form1)
    End Sub

    ''groupbox hizalama
    Private Sub centerGB()
        GroupBox1.Top = (Me.ClientSize.Height / 2) - (GroupBox1.Height / 2)
        GroupBox1.Left = (Me.ClientSize.Width / 2) - (GroupBox1.Width / 2)
    End Sub
    Private Sub Form2_Resize(ByVal sender As Object,
                     ByVal e As System.EventArgs) Handles MyBase.Resize
        centerGB()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        centerGB()
    End Sub

End Class