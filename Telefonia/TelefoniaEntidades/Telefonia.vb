Public Class Telefonia


    'propiedades'
    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    'metodos'
    Public Sub New(Nombre As String)
        'ingrese nombre'
    End Sub

End Class

Public Class Modelo
    'propiedades'
    Private _nombremodelo As String
    Public Property NombreModelo() As String
        Get
            Return _nombremodelo
        End Get
        Set(ByVal value As String)
            _nombremodelo = value
        End Set
    End Property
    'metodos'
    Public Sub New(Nombre As String)
        'ingrese nombre'
    End Sub

End Class
Public Class Equipo

    'propiedades'
    Private _serie As String
    Public Property Serie() As String
        Get
            Return _serie
        End Get
        Set(ByVal value As String)
            _serie = value
        End Set
    End Property

    Private _fechaventa As String
    Public Property FechaVenta() As String
        Get
            Return _fechaventa
        End Get
        Set(ByVal value As String)
            _fechaventa = value
        End Set
    End Property
    'metodos'
    Public Sub New(marca As String, modelo As String, serie As Byte)

    End Sub
    Public Sub Vender(vender As Date)
        'Metodo vender'
    End Sub
End Class

Public Class Linea
    'propiedades'
    Private _codigodearea As String
    Public Property CodigoDeArea() As String
        Get
            Return _codigodearea
        End Get
        Set(ByVal value As String)
            _codigodearea = value
        End Set
    End Property

    Private _numero As String
    Public Property Numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
        End Set
    End Property

    Private _estado As String
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property
    'metodos'
    Public Sub New(CodigoDeArea As Byte, Numero As Byte)

    End Sub
    Public Sub Suspender(suspender As Byte)
        'metodo de suspension'
    End Sub
    Public Sub Reactivar(ReActivar As Byte)
        'metodo de Activacion'
    End Sub

End Class

Public Class Cliente
    'propiedades'
    Private _cuenta As String
    Public Property Cuenta() As String
        Get
            Return _cuenta
        End Get
        Set(ByVal value As String)
            _cuenta = value
        End Set
    End Property
    'metodos'
    Public Sub New()
        'constructor y nada mas'
    End Sub

End Class


Public Class Persona
    'propiedades'
    Private _apellido As String
    Public Property Apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property

    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _documento As String
    Public Property Documento() As String
        Get
            Return _documento
        End Get
        Set(ByVal value As String)
            _documento = value
        End Set
    End Property
    'metodos'
    Public Sub New(apellido As String, nombre As String, documento As Integer)

    End Sub
End Class

Public Class Empresa
    'propiedades'
    Private _razonsocial As String
    Public Property RazonSocial() As String
        Get
            Return _razonsocial
        End Get
        Set(ByVal value As String)
            _razonsocial = value
        End Set
    End Property


    Private _cuit As Integer

    Public Property CUIT() As Integer
        Get
            Return _cuit
        End Get
        Set(ByVal value As Integer)
            _cuit = value
        End Set
    End Property

    'metodos'
    Public Sub New(RazonSocial As String, CUIT As Integer)

    End Sub



End Class