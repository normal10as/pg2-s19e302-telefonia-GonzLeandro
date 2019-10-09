Imports TelefoniaEntidades
Module ModeloTest

    Public Sub modelo()
        Dim galaxy As New Modelo("Galaxy S4")

        Console.WriteLine("Modelo: " & galaxy.NombreModelo)

        Console.WriteLine(galaxy.toString())

    End Sub

End Module
