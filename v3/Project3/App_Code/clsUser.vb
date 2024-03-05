'Namespace IS314_Proj2_Kernja
Public Class clsUser
    Inherits clsObject
    'holds information about the current person being logged in
    Private uUsername As String

    Private uNameFirst As String
    Private uNameMiddle As String
    Private uNameLast As String

    Private uID As Integer
    Public Sub New(ByVal passedUsername As String)
        Username = passedUsername
        'get all of the info about the person (full name) from the DB
        Dim myDAO As New clsDAO
        myDAO.getUserInformation(Username, ID, FirstName, LastName, MiddleName)
    End Sub
    Public Property ID() As Integer
        Get
            Return uID
        End Get
        Set(ByVal value As Integer)
            uID = value
        End Set
    End Property
    Public Property MiddleName() As String
        Get
            Return uNameMiddle
        End Get
        Set(ByVal value As String)
            uNameMiddle = value
        End Set
    End Property
    Public Property LastName() As String
        Get
            Return uNameLast
        End Get
        Set(ByVal value As String)
            uNameLast = value
        End Set
    End Property
    Public Property FirstName() As String
        Get
            Return uNameFirst
        End Get
        Set(ByVal value As String)
            uNameFirst = value
        End Set
    End Property
    Public Property Username() As String
        Get
            Return uUsername
        End Get
        Set(ByVal value As String)
            uUsername = value
        End Set
    End Property

End Class
'End Namespace
