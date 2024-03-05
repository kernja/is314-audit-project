Namespace IS314_Proj1_Kernja

    Public Class clsCategory
        Inherits clsObject
        'create variables for Category
        'category Name, value (what the audit score is)
        'min and max values for the category, passing values for the category
        'and a comment for string inout.
        Private _name As String
        Private _value As Integer
        Private _min As Integer
        Private _max As Integer
        Private _passing As Integer
        Private _comment As String

        'These are all generic getters/setters.
        Public Property Name() As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                _name = value
            End Set
        End Property
        Public Property Value() As Integer
            Get
                Return _value
            End Get
            Set(ByVal value As Integer)
                _value = sanitizeValue(value)
                If _value > Passing Then
                    Comment = ""
                End If
            End Set
        End Property
        Public Property Passing() As Integer
            Get
                Return _passing
            End Get
            Set(ByVal Passing As Integer)
                _passing = sanitizePassing(Passing)
            End Set
        End Property
        Public Property Min() As Integer
            Get
                Return _min
            End Get
            Set(ByVal Min As Integer)
                _min = Min
            End Set
        End Property
        Public Property Max() As Integer
            Get
                Return _max
            End Get
            Set(ByVal Max As Integer)
                _max = sanitizeMax(Max)
            End Set
        End Property

        Public Function getScore() As Integer
            Return Value
        End Function
        Public Function getRating() As clsAuditor.auditRating
            Dim myReturn As clsAuditor.auditRating

            If Value = Me.Passing Then
                myReturn = clsAuditor.auditRating.warn
            ElseIf Value > Me.Passing Then
                myReturn = clsAuditor.auditRating.pass
            Else
                myReturn = clsAuditor.auditRating.fail
            End If

            Return myReturn
        End Function
        Public Property Comment() As String
            Get
                Return _comment
            End Get
            Set(ByVal value As String)
                _comment = value
            End Set
        End Property

        'sanitize inputs.  this is needed to make sure that max values are below minimum values, etc.
        Private Function sanitizePassing(ByVal passedPass As Integer) As Integer
            If Min >= passedPass Then
                passedPass = Min + 1
            End If

            If Max <= passedPass Then
                passedPass = Max - 1
            End If

            Return passedPass
        End Function
        Private Function sanitizeValue(ByVal passedValue As Integer) As Integer
            If passedValue > Max Then
                passedValue = Max
            End If

            If passedValue < Min Then
                passedValue = Min
            End If

            Return passedValue
        End Function
        Private Function sanitizeMax(ByVal passedMax As Integer) As Integer
            If passedMax <= Min Then
                passedMax = Min + 2
            End If

            Return passedMax
        End Function

        'init the generic values for the class.
        Private Sub InitClass()
            Name = "Generic Category"
            Value = 3
            Min = 1
            Max = 7
        End Sub
        'init the class.
        Public Sub New()
            InitClass()
        End Sub
        'create the class with a passed category name
        Public Sub New(ByVal passedName As String)
            InitClass()
            Name = passedName
        End Sub
        'create the class with the passed category name and values.
        Public Sub New(ByVal passedName As String, ByVal passedMin As Integer, ByVal passedMax As Integer, ByVal passedPassing As Integer, ByVal passedValue As Integer)
            Name = passedName
            Min = passedMin
            Max = passedMax
            Passing = passedPassing
            Value = passedValue
        End Sub

        'woot, to string.
        Public Overrides Function toString() As String
            Return Name
        End Function
    End Class
End Namespace
