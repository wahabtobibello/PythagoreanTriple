Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m As Integer = Convert.ToInt32(mTbx.Text)
        Dim n As Integer = Convert.ToInt32(nTbx.Text)
        If m <= n Then
            MessageBox.Show("M should be greater than N")
        Else
            Dim side1 As Double = Math.Pow(m, 2) - Math.Pow(n, 2)
            Dim side2 As Double = 2 * m * n
            Dim hypo As Double = Math.Pow(m, 2) + Math.Pow(n, 2)
            side1Tbx.Text = side1.ToString()
            side2Tbx.Text = side2.ToString()
            hypoTbx.Text = hypo.ToString()
        End If

    End Sub
End Class
