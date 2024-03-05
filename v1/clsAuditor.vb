Namespace IS314_Proj1_Kernja
    Public Class clsAuditor
        Inherits IS314_Assignment1.IS314_Proj1_Kernja.clsObject

        'create an enumeration so that we have values that mean "Pass", "Warn" and "fail"
        Public Enum auditRating
            pass = 0
            warn = 1
            fail = 2
        End Enum
        'private vars that hold the username and password.
        Private _username As String
        Private _password As String
        'vars that hold the Category factory, which holds all catagories of an audit.
        Private _CategoryFactory As clsCategoryFactory
        Public Sub New()
            'set default values.
            Username = "foo"
            Password = "bar"
            Catagories = New clsCategoryFactory()
        End Sub
        'default getter and setters.
        Public Property Username() As String
            Get
                Return _username
            End Get
            Set(ByVal value As String)
                _username = value
            End Set
        End Property
        Public Property Password() As String
            Get
                Return _password
            End Get
            Set(ByVal value As String)
                _password = value
            End Set
        End Property
        Public Property Catagories() As clsCategoryFactory
            Get
                Return _CategoryFactory
            End Get
            Set(ByVal value As clsCategoryFactory)
                _CategoryFactory = value
            End Set
        End Property
        'verify whether or not a password equals what we have in the auditor.

        Public Function verifyPassword() As Boolean
            'default the return var to false.
            Dim myreturn As Boolean = (New clsDAO).verifyPassword(Username, Password)

            Return myreturn
        End Function

        Public Function verifyPassword(ByVal passedUsername As String, ByVal passedPassword As String) As Boolean
            'default the return var to false.

            Password = passedPassword
            Username = passedUsername

            Dim myreturn As Boolean = (New clsDAO).verifyPassword(Username, Password)


            Return myReturn
        End Function

        Public Overrides Function toString() As String
            Return "clsAuditor"
        End Function
    End Class

End Namespace