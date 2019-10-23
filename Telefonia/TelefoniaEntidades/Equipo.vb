Public MustInherit Class Equipo
    Inherits Modelo
    Public Sub New(nombreMarca As String, nombreModelo As String, serie As String)
        MyBase.New(nombreMarca, nombreModelo)
        Me.SerieEquipo = serie
    End Sub
    Private _serieEquipo As String
    Public Property SerieEquipo As String
        Get
            Return _serieEquipo
        End Get
        Set(value As String)
            If value.Length <= 15 And value.Length > 0 Then
                _serieEquipo = value
            End If
        End Set
    End Property

    Public ReadOnly Property FechaVenta As Date
        Get
            Return Vender()
        End Get
    End Property

    Public Function Vender() As Date
        Return Date.Now
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString & " " & SerieEquipo
    End Function

End Class
