Class MainWindow
    Private Sub Enter(sender As Object, e As KeyEventArgs)
        If (e.Key = Key.Return) Then
            MessageBox.Show(alertBox.Text, "Alert!", MessageBoxButton.OKCancel)
            e.Handled = True
        End If



    End Sub
End Class
