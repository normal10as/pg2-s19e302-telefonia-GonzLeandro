Imports TelefoniaEntidades
Module empresaTest
    Public Sub empresa()

        Dim empresa1 As New Empresa("SeniorKioskero", "20123456785")

        Console.WriteLine("Razon social: " & empresa1.RazonSocial)
        Console.WriteLine("Cuit: " & empresa1.Cuit)
        Console.WriteLine(empresa1.ToString)


    End Sub
End Module
