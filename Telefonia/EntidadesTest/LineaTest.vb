Imports TelefoniaEntidades
Module LineaTest
    Sub linea()
        Dim linea1 As New Linea("Galaxy", "Samsung", "abcd1234", 3764, 991256)
        linea1.NombreModelo = "Galaxy"
        linea1.NombreMarca = "Samsungg"
        linea1.SerieEquipo = "abcd1234"
        linea1.CodigoDeArea = 3764
        linea1.Numero = 991256

        Console.WriteLine(linea1.Estado)
        linea1.Suspender()

        Console.WriteLine(linea1.Estado)
        linea1.Reactivar()

        Console.WriteLine(linea1.Estado)

        Console.WriteLine(linea1.ToString)
        linea1.Suspender()

        Console.WriteLine(linea1.ToString)
    End Sub
End Module
