Imports TelefoniaEntidades
Module personaTest
    Public Sub persona()

        Dim persona1 As New Persona("Gonzalez", "Leandro", 41049099)
        persona1.Apellido = "Gonzalez"
        persona1.Nombre = "Leandro"
        persona1.Documento = 41049099

        Console.WriteLine("Apellido: " & persona1.Apellido & " Nombre: " & persona1.Nombre & " Documento: " &
                          persona1.Documento)

        Console.WriteLine(persona1.ToString)

    End Sub
End Module
