Public Class Form1
    Dim input, lewat As Integer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        input = 0
        lewat = 0
    End Sub

    Private Sub Kurang_Click(sender As Object, e As EventArgs) Handles Kurang.Click
        input = Convert.ToInt32(outputText.Text)
        lewat = 2
    End Sub

    Private Sub Tambah_Click(sender As Object, e As EventArgs) Handles Tambah.Click
        input += Convert.ToInt32(outputText.Text)
        lewat = 3
    End Sub

    Private Sub Equals_Click(sender As Object, e As EventArgs) Handles Equals.Click
        If lewat = 2 Then
            input -= Convert.ToInt32(outputText.Text)
        Else
            input = input + outputText.Text
        End If
        outputText.Text = input
        lewat = 1
        input = 0
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        outputText.Clear()
        outputText.Text = 0
        lewat = 0
    End Sub

    Private Sub bt0_Click(sender As Object, e As EventArgs) Handles bt0.Click
        If outputText.Text = 0 Then
            outputText.Text = 0
        Else
            outputText.Text &= 0
        End If
    End Sub

    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click
        If lewat >= 1 Then
            outputText.Text = 0
            If outputText.Text = 0 Then
                outputText.Text = 1
            Else
                outputText.Text &= 1
            End If
        Else
            If outputText.Text = 0 Then
                outputText.Text = 1
            Else
                outputText.Text &= 1
            End If
        End If
    End Sub

    Private Sub bt2_Click(sender As Object, e As EventArgs) Handles bt2.Click
        If lewat >= 1 Then
            outputText.Text = 0
            If outputText.Text = 0 Then
                outputText.Text = 2
            Else
                outputText.Text &= 2
            End If
        Else
            If outputText.Text = 0 Then
                outputText.Text = 2
            Else
                outputText.Text &= 2
            End If
        End If
    End Sub

    Private Sub bt3_Click(sender As Object, e As EventArgs) Handles bt3.Click
        If lewat >= 1 Then
            outputText.Text = 0
            If outputText.Text = 0 Then
                outputText.Text = 3
            Else
                outputText.Text &= 3
            End If
        Else
            If outputText.Text = 0 Then
                outputText.Text = 3
            Else
                outputText.Text &= 3
            End If
        End If
    End Sub

    Private Sub bt4_Click(sender As Object, e As EventArgs) Handles bt4.Click
        If lewat >= 1 Then
            outputText.Text = 0
            If outputText.Text = 0 Then
                outputText.Text = 4
            Else
                outputText.Text &= 4
            End If
        Else
            If outputText.Text = 0 Then
                outputText.Text = 4
            Else
                outputText.Text &= 4
            End If
        End If
    End Sub

    Private Sub bt5_Click(sender As Object, e As EventArgs) Handles bt5.Click
        If lewat >= 1 Then
            outputText.Text = 0
            If outputText.Text = 0 Then
                outputText.Text = 5
            Else
                outputText.Text &= 5
            End If
        Else
            If outputText.Text = 0 Then
                outputText.Text = 5
            Else
                outputText.Text &= 5
            End If
        End If
    End Sub

    Private Sub bt6_Click(sender As Object, e As EventArgs) Handles bt6.Click
        If lewat >= 1 Then
            outputText.Text = 0
            If outputText.Text = 0 Then
                outputText.Text = 6
            Else
                outputText.Text &= 6
            End If
        Else
            If outputText.Text = 0 Then
                outputText.Text = 6
            Else
                outputText.Text &= 6
            End If
        End If
    End Sub

    Private Sub bt7_Click(sender As Object, e As EventArgs) Handles bt7.Click
        If lewat >= 1 Then
            outputText.Text = 0
            If outputText.Text = 0 Then
                outputText.Text = 7
            Else
                outputText.Text &= 7
            End If
        Else
            If outputText.Text = 0 Then
                outputText.Text = 7
            Else
                outputText.Text &= 7
            End If
        End If
    End Sub

    Private Sub bt8_Click(sender As Object, e As EventArgs) Handles bt8.Click
        If lewat >= 1 Then
            outputText.Text = 0
            If outputText.Text = 0 Then
                outputText.Text = 8
            Else
                outputText.Text &= 8
            End If
        Else
            If outputText.Text = 0 Then
                outputText.Text = 8
            Else
                outputText.Text &= 8
            End If
        End If
    End Sub

    Private Sub bt9_Click(sender As Object, e As EventArgs) Handles bt9.Click
        If lewat >= 1 Then
            outputText.Text = 0
            If outputText.Text = 0 Then
                outputText.Text = 9
            Else
                outputText.Text &= 9
            End If
        Else
            If outputText.Text = 0 Then
                outputText.Text = 9
            Else
                outputText.Text &= 9
            End If
        End If
    End Sub
End Class
