Public Class Form1
    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        While True
            For i As Integer = 0 To 9
                Dim x() As Char = Convert.ToString(i, 2).PadLeft(4, "0")

                If (CheckIfTrue(x(0)) Or CheckIfTrue(x(2)) Or CheckIfTrue(x(1)) Or (Not CheckIfTrue(x(3)))) Then
                    Button2.BackColor = Color.Red
                    Button12.BackColor = Color.Red
                Else
                    Button2.BackColor = Color.White
                    Button12.BackColor = Color.White
                End If

                If (CheckIfTrue(x(0)) Or CheckIfTrue(x(2)) Or ((Not (CheckIfTrue(x(1))) Xor (CheckIfTrue(x(3)))))) Then
                    Button3.BackColor = Color.Red
                Else
                    Button3.BackColor = Color.White
                End If

                Button4.BackColor = Color.Red

                If (CheckIfTrue(x(0)) Or (CheckIfTrue(x(1)) And (Not (CheckIfTrue(x(3))))) Or (CheckIfTrue(x(1)) And (Not (CheckIfTrue(x(2))))) Or (Not (CheckIfTrue(x(2))) And (Not (CheckIfTrue(x(3)))))) Then
                    Button7.BackColor = Color.Red
                Else
                    Button7.BackColor = Color.White
                End If

                If (Not CheckIfTrue(x(1)) Or ((Not ((CheckIfTrue(x(2))) Xor (CheckIfTrue(x(3))))))) Then
                    Button9.BackColor = Color.Red
                Else
                    Button9.BackColor = Color.White
                End If

                If (CheckIfTrue(x(0)) Or CheckIfTrue(x(1)) Or CheckIfTrue(x(2))) Then
                    Button13.BackColor = Color.Red
                Else
                    Button13.BackColor = Color.White
                End If

                Button14.BackColor = Color.Red

                If (Not (CheckIfTrue(x(3))) And (Not (CheckIfTrue(x(1))) Or CheckIfTrue(x(2)))) Then
                    Button17.BackColor = Color.Red
                Else
                    Button17.BackColor = Color.White
                End If

                If (Not (CheckIfTrue(x(2))) Or CheckIfTrue(x(3)) Or CheckIfTrue(x(1))) Then
                    Button19.BackColor = Color.Red
                Else
                    Button19.BackColor = Color.White
                End If

                If ((Not (CheckIfTrue(x(1))) And (Not (CheckIfTrue(x(3))))) Or CheckIfTrue(x(0)) Or (Not (CheckIfTrue(x(1))) And (CheckIfTrue(x(2)))) Or (Not (CheckIfTrue(x(3))) And (CheckIfTrue(x(2)))) Or (Not (CheckIfTrue(x(2))) And (CheckIfTrue(x(1))) And (CheckIfTrue(x(3))))) Then
                    Button22.BackColor = Color.Red
                    Button23.BackColor = Color.Red
                Else
                    Button22.BackColor = Color.White
                    Button23.BackColor = Color.White
                End If

                Button24.BackColor = Color.Red

                Await Task.Delay(1000)
            Next
        End While

    End Sub

    Function CheckIfTrue(ByVal y As Char) As Boolean

        If (y = "1") Then
            Return True
        Else
            Return False
        End If

    End Function

End Class
