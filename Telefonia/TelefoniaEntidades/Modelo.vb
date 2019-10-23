Public MustInherit Class Modelo
    Inherits Marca
    Public Sub New(nombreMarca As String, nombreModelo As String)
        MyBase.New(nombreMarca)
        Me.NombreModelo = nombreModelo
    End Sub

    Private _nombreModelo As String
    Public Property NombreModelo As String
        Get
            Return _nombreModelo
        End Get
        Set(value As String)
            If value.Length <= 50 And value.Length > 0 Then
                _nombreModelo = value
            End If
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return MyBase.ToString & " " & NombreModelo
    End Function
End Class
