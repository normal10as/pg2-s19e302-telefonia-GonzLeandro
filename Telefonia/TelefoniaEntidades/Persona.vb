Public Class Persona

    Public Sub New(apellido As String, nombre As String, documento As Integer)
        Me.Apellido = apellido
        Me.Nombre = nombre
        Me.Documento = documento
    End Sub

    Private _apellido As String
    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            If value.Length <= 30 And value.Length > 0 Then
                _apellido = value
            End If
        End Set
    End Property

    Private _nombre As String
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            If value.Length <= 50 And value.Length > 0 Then
                _nombre = value
            End If
        End Set
    End Property

    Private _documento As UInteger
    Public Property Documento As UInteger
        Get
            Return _documento
        End Get
        Set(ByVal value As UInteger)
            _documento = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Documento & " " & Nombre & " " & Apellido
    End Function

End Class
