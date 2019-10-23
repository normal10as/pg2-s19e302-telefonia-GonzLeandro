Public Class Linea
    Inherits Equipo
    Public Sub New(nombreMarca As String, nombreModelo As String, serie As String, codigoDeArea As UShort, numero As UInteger)
        MyBase.New(nombreMarca, nombreModelo, serie)
        Me.CodigoDeArea = codigoDeArea
        Me.Numero = numero
        _estado = True
    End Sub

    Private _codigoDeArea As UShort
    Public Property CodigoDeArea As UShort
        Get
            Return _codigoDeArea
        End Get
        Set(value As UShort)
            If value <= 9999 And value > 100 Then
                _codigoDeArea = value
            End If
        End Set
    End Property

    Private _numero As UInteger
    Public Property Numero As UInteger
        Get
            Return _numero
        End Get
        Set(value As UInteger)
            If value <= 9999999 And value > 100000 Then
                _numero = value
            End If
        End Set
    End Property

    Private _estado As Boolean
    Public ReadOnly Property Estado As String
        Get
            Return If(_estado, "Activo", "Suspendido")
        End Get
    End Property

    Public Sub Suspender()
        _estado = False
    End Sub
    Public Sub Reactivar()
        _estado = True
    End Sub

    Public Overrides Function ToString() As String
        Dim value As String = CodigoDeArea & " " & Numero
        If Not _estado Then
            value = value & " " & Estado
        End If
        Return MyBase.ToString & " " & value
    End Function

End Class
