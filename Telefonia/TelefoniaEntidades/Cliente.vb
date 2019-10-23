Public Class Cliente

    Public Sub New()

    End Sub

    Private _cuenta As String
    Public Property Cuenta As String
        Get
            Return _cuenta
        End Get
        Set(ByVal value As String)
            _cuenta = value
        End Set
    End Property

End Class
