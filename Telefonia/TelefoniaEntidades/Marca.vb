Public MustInherit Class Marca
    Public Sub New(nombreMarca As String)
        Me.NombreMarca = nombreMarca
    End Sub
    Private _nombreMarca As String
    Public Property NombreMarca As String
        Get
            Return _nombreMarca
        End Get
        Set(value As String)
            If value.Length <= 30 And value.Length > 0 Then
                _nombreMarca = value
            End If
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return NombreMarca
    End Function

End Class
