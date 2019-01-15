Public Class Cls_DataDownloader
    Dim _fullName As String
    Dim _idNumber As Integer
    Dim _issueDate As String
    Dim _issuer As String
    Dim _gender As String
    Dim _organization As String
    Dim _address As String
    Dim _email As String
    Dim _mobile As String
    Dim _purpose As String
    Dim _status As Integer
    Dim _dateRequest As Date
    Dim _dataset As String

    Public Sub New()

    End Sub

    Public Property fullName() As String
        Get
            Return _fullName
        End Get
        Set(ByVal value As String)
            _fullName = value
        End Set
    End Property

    Public Property idNumber() As Integer
        Get
            Return _idNumber
        End Get
        Set(ByVal value As Integer)
            _idNumber = value
        End Set
    End Property

    Public Property issueDate() As String
        Get
            Return _issueDate
        End Get
        Set(ByVal value As String)
            _issueDate = value
        End Set
    End Property

    Public Property issuer() As String
        Get
            Return _issuer
        End Get
        Set(ByVal value As String)
            _issuer = value
        End Set
    End Property

    Public Property gender() As String
        Get
            Return _gender
        End Get
        Set(ByVal value As String)
            _gender = value
        End Set
    End Property

    Public Property organization() As String
        Get
            Return _organization
        End Get
        Set(ByVal value As String)
            _organization = value
        End Set
    End Property

    Public Property address() As String
        Get
            Return _address
        End Get
        Set(ByVal value As String)
            _address = value
        End Set
    End Property

    Public Property email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Public Property mobile() As String
        Get
            Return _mobile
        End Get
        Set(ByVal value As String)
            _mobile = value
        End Set
    End Property

    Public Property purpose() As String
        Get
            Return _purpose
        End Get
        Set(ByVal value As String)
            _purpose = value
        End Set
    End Property

    Public Property status() As Integer
        Get
            Return _status
        End Get
        Set(ByVal value As Integer)
            _status = value
        End Set
    End Property

    Public Property dateRequest() As Date
        Get
            Return _dateRequest
        End Get
        Set(ByVal value As Date)
            _dateRequest = value
        End Set
    End Property

    Public Property dataset() As String
        Get
            Return _dataset
        End Get
        Set(ByVal value As String)
            _dataset = value
        End Set
    End Property
End Class
