Class MainWindow

    Private r As Integer = 0
    Private g As Integer = 0
    Private b As Integer = 0
    Private a As Integer = 0
    Private BoxColor As Brush = New SolidColorBrush(Color.FromArgb(255, r, g, b))

    Private Sub Slider_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double))
        r = S_Red.Value
        C_Red.Content = r
        RGB_Label.Content = r.ToString() + "," + g.ToString() + "," + b.ToString()
        BoxColor = New SolidColorBrush(Color.FromArgb(a, r, g, b))
        ColorBox.Background = BoxColor
    End Sub

    Private Sub Slider_ValueChanged_1(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double))
        g = S_Green.Value
        C_Green.Content = g
        RGB_Label.Content = r.ToString() + "," + g.ToString() + "," + b.ToString()
        BoxColor = New SolidColorBrush(Color.FromArgb(a, r, g, b))
        ColorBox.Background = BoxColor
    End Sub
    Private Sub Slider_ValueChanged_2(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double))
        b = S_Blue.Value
        C_Blue.Content = b
        RGB_Label.Content = r.ToString() + "," + g.ToString() + "," + b.ToString()
        BoxColor = New SolidColorBrush(Color.FromArgb(a, r, g, b))
        ColorBox.Background = BoxColor
    End Sub
    Private Sub Slider_ValueChanged_3(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double))
        a = S_Alpha.Value
        C_Alpha.Content = a
        RGB_Label.Content = r.ToString() + "," + g.ToString() + "," + b.ToString()
        BoxColor = New SolidColorBrush(Color.FromArgb(a, r, g, b))
        ColorBox.Background = BoxColor
    End Sub
End Class
