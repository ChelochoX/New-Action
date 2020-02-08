Module PUNTO_DE_MILES
    Public Function Puntos(ByVal strValor As String, Optional ByVal intNumDecimales As Integer = 0) As String

        Dim strAux As String
        Dim strComas As String
        Dim strPuntos As String
        Dim intX As Integer
        Dim bolMenos As Boolean = False

        strComas = ""
        strValor = strValor.Replace(".", "")
        If InStr(strValor, ",") > 0 Then
            strAux = Mid(strValor, 1, InStr(strValor, ",") - 1)
            strComas = Mid(strValor, InStr(strValor, ","))
        Else
            strAux = strValor
        End If

        If Mid(strAux, 1, 1) = "-" Then
            bolMenos = True
            strAux = Mid(strAux, 2)
        End If

        strPuntos = strAux
        strAux = ""
        While strPuntos.Length > 3
            strAux = "." & Mid(strPuntos, strPuntos.Length - 2, 3) & strAux
            strPuntos = Mid(strPuntos, 1, strPuntos.Length - 3)
        End While
        If intNumDecimales <> 0 Then
            If strComas = "" Then strComas = ","
            For intX = Len(strComas) - 1 To intNumDecimales - 1
                strComas = strComas & "0"
            Next

        End If
        strAux = strPuntos & strAux & strComas
        If Mid(strAux, 1, 1) = "." Then strAux = Mid(strAux, 2)
        If bolMenos Then strAux = "-" & strAux

        Return strAux

    End Function
End Module
