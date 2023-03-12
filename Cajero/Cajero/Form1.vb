Public Class Form1

    Const USUARIO As String = "usuario1"
    Const CONTRASEÑA As String = "contraseña1"

    Dim user As String
    Dim password As String


    Private Sub ButtonRegistrar_Click(sender As Object, e As EventArgs) Handles ButtonRegistrar.Click
        If user = USUARIO Then
            MsgBox("el usuario es correcto")

            If password = CONTRASEÑA Then
                MsgBox("la contraseña es incorrecta")

            ElseIf password <> CONTRASEÑA Then
                MsgBox("ERROR dato mal ingresado")



            End If
            MsgBox("ERROR: Ingreso mal de un dato", MsgBoxStyle.Critical)
        ElseIf user <> USUARIO Then
            MsgBox("ERROR dato mal ingresado")
        End If



        Form2.Show()
        Me.Hide()
    End Sub

End Class
