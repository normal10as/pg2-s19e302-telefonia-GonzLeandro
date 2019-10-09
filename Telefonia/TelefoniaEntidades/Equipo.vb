Public Class Equipo

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
            Return vender()
        End Get
    End Property

    Public Function vender() As Date
        Return Date.Now
    End Function

    Public Function toString() As String
        Return SerieEquipo
    End Function

End Class
