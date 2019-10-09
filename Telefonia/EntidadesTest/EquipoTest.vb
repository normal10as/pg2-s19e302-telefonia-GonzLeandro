Imports TelefoniaEntidades
Module EquipoTest
    Public Sub Equipo()

        Dim telefono1 As New Equipo()
        telefono1.SerieEquipo("12345")

        Console.WriteLine("Fecha de venta: " & telefono1.FechaVenta)

        Console.WriteLine(telefono1.toString)

    End Sub
End Module
