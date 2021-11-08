Public Class Form1

    Dim download As New Net.WebClient

    Private Sub DownloadProgresso(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs)
        pgProgresso.Value = e.ProgressPercentage
        lblProgresso.Text = "Progresso: " & e.ProgressPercentage.ToString & "%"
        lblqtdBaixado.Text = "Baixados: " & FormatNumber(e.BytesReceived / 1024, 2).ToString & "KB"
        lblTam.Text = "Tamanho: " & FormatNumber(e.TotalBytesToReceive / 1024, 2).ToString & "KB"
    End Sub

    Private Sub DownloadConcluido(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        MsgBox("Download Concluido!!", MsgBoxStyle.OkOnly, "Aviso")

    End Sub

    Private Sub AtivaEventos()
        AddHandler download.DownloadProgressChanged, AddressOf DownloadProgresso
        AddHandler download.DownloadFileCompleted, AddressOf DownloadConcluido
    End Sub

    Private Sub IniciaDownload(ByVal Arquivo As String, ByVal Destino As String)
        Try
            Dim uriOrigem As New Uri(Arquivo)
            download.DownloadFileAsync(uriOrigem, Destino)

        Catch ex As Exception
            MsgBox("ERRO", MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        AtivaEventos()

    End Sub

    Private Sub Btn_baixar_Click(sender As Object, e As EventArgs) Handles Btn_baixar.Click
        Dim nomeArq = txt_nome.Text
        Dim localArq

        If FDB.ShowDialog() = DialogResult.OK Then
            txt_valor.Text = FDB.SelectedPath
        End If
        localArq = txt_valor.Text

        'IniciaDownload(txt_URL.Text, "C:\Users\Victor\Downloads\" & nomeArq & ".exe")
        IniciaDownload(txt_URL.Text, localArq & "\" & nomeArq & ".exe")

    End Sub
End Class
