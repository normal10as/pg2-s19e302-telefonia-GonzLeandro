Public Class Empresa

    Public Sub New(razonSocial As String, cuit As String)
        Me.RazonSocial = razonSocial
        Me.Cuit = cuit
    End Sub

    Private _razonsocial As String
    Public Property RazonSocial As String
        Get
            Return _razonsocial
        End Get
        Set(ByVal value As String)
            If value.Length <= 80 And value.Length > 0 Then
                _razonsocial = value
            End If
        End Set
    End Property

    Private _cuit As String
    Public Property Cuit As String
        Get
            Return _cuit
        End Get
        Set(value As String)
            If value.Length <= 13 And value.Length > 0 Then
                _cuit = value
            End If
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return RazonSocial & " " & Cuit
    End Function

End Class
