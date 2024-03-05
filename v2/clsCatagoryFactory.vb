Namespace IS314_Proj2_Kernja
    Public Class clsCategoryFactory
        Inherits IS314_Assignment1.IS314_Proj2_Kernja.clsObject
        'set a hashtable to hold n number of catagories.
        Private _hash As New Hashtable
        'var to hold what is considered probation
        Private _Probation As Integer
        'var to hold what is considered passing.
        Private _pass As Integer
        'var to hold what audit this is (Audit Type A, B, etc.)
        Private _id As Integer


        'generic getter and setters.
        Public Property ID() As Integer
            Get
                Return _id
            End Get
            Set(ByVal value As Integer)
                _id = value
            End Set
        End Property
        Public Property Probation() As Integer
            Get
                Return _Probation
            End Get
            Set(ByVal value As Integer)
                _Probation = value
            End Set
        End Property
        Public Property Pass() As Integer
            Get
                Return _pass
            End Get
            Set(ByVal value As Integer)
                _pass = value
            End Set
        End Property
        'init the class with default values.
        Private Sub InitClass()
            'this all could have been loaded from an XML file!!!!


            'init hasttable
            _hash = New Hashtable
            'probation is 25
            ' _Probation = 25
            'passing is at least 34
            '_pass = 34

            'create the auditor catagories per the documentation
            'for this, we only choose the default audit of '1'

            'addCategory("Code Logic", 1, 7, 3, 3)
            'addCategory("Code Data Types", 1, 7, 3, 3)
            'addCategory("Overall Code Design", 1, 7, 3, 3)
            'addCategory("Security", 1, 7, 6, 3)
            'addCategory("Documentation", 1, 7, 5, 3)
            'addCategory("Interface Design", 1, 7, 2, 3)
            'addCategory("Program Size", 1, 7, 2, 3)
        End Sub
        Public Sub New()
            'new form?  init the class.
            InitClass()
        End Sub
        Public Sub New(ByVal passLevel As Integer, ByVal probationLevel As Integer)
            'new form, init the class.
            InitClass()
            'set the pass and probation levels to the one shipped through this sub.
            _pass = passLevel
            _Probation = probationLevel
        End Sub
        Public Sub addCategory(ByVal passedName As String)
            'add a new Category with a passed name with default values
            _hash.Add(passedName, New clsCategory(passedName))
        End Sub
        Public Sub addCategory(ByVal passedIndex As Integer, ByVal passedName As String, ByVal passedMin As Integer, ByVal passedMax As Integer, ByVal passedProbation As Integer, ByVal passedValue As Integer)
            'add a new Category with a passed name with specifically set values
            _hash.Add(passedName, New clsCategory(passedIndex, passedName, passedMin, passedMax, passedProbation, passedValue))
        End Sub
        Public Sub setCategory(ByRef passedCategory As clsCategory)
            'and the one good line of code
            'update the Category needed based on the name that was passed in/
            _hash(passedCategory.Name) = passedCategory

            doSpecialFeatures(passedCategory)
        End Sub
        Private Sub doSpecialFeatures(ByRef passedCategory As clsCategory)

            'I stripped out the codw about the Overall Code being less then the other two categories.
            'It should be in here, but with all data coming from server side, I'd rather not
            'deal with that headache.

        End Sub
        Public Function getCatagories() As ArrayList
            'create var for the myreturn variable... anarraylist.
            Dim myReturn As New ArrayList

            'iterate through each item in the hashtable and add to the arraylist.
            For Each value As clsCategory In _hash.Values
                myReturn.Add(value)
            Next

            'and return
            Return myReturn
        End Function

        'return a Category based by name.  should be done by a primary key in case
        'catagories somehow have the same name.
        Public Function getCategory(ByVal passedName As String) As clsCategory
            Return _hash(passedName)
        End Function

        'return the max score for all catagories.
        Public Function getMaxScore() As Integer
            'create my return variable.
            Dim myReturn As Integer = 0
            'create a tempCategory as a place to hold a Category.
            Dim tempCategory As clsCategory
            'create a dictionary entry to get the value from the hash.
            Dim tempItem As DictionaryEntry

            'iterate through the hash
            For Each tempItem In _hash '
                'set the temp Category to an item in the hash.
                tempCategory = tempItem.Value
                'add to the return var the max of the Category minus the min.
                myReturn = (myReturn + tempCategory.Max) - tempCategory.Min
            Next

            Return myReturn
        End Function


        'return the current score for all catagories.
        Public Function getScore() As Integer
            'set my return var.
            Dim myReturn As Integer = 0

            'create vars to iterate through the hash.
            Dim tempCategory As clsCategory
            Dim tempItem As DictionaryEntry

            '
            For Each tempItem In _hash
                'set the temp Category to an item in the hash.
                tempCategory = tempItem.Value
                'add to the return var the current value of the Category minus the min.
                myReturn = myReturn + tempCategory.getScore - tempCategory.Min
            Next

            Return myReturn
        End Function
        Public Function getRating() As clsAuditor.auditRating
            'create a var to hold the return rating.
            Dim myReturn As clsAuditor.auditRating = clsAuditor.auditRating.pass

            'we want to do two things while looping through the hash
            'if one fails, we can fail the whole thing.
            'if not, we still need to add up all values.

            'creat the vars to loop through the hash
            Dim tempCategory As clsCategory
            Dim tempItem As DictionaryEntry
            'create the vars to hold the temp score that we will be adding up while
            'iterating.
            Dim tempScore As Integer = 0

            'iterate
            For Each tempItem In _hash
                'set the tempCategory to the current Category in the hash.
                tempCategory = tempItem.Value
                'compute running score.
                tempScore = tempScore + tempCategory.getScore - tempCategory.Min
                'see if the Category fails.
                If tempCategory.getRating = clsAuditor.auditRating.fail Then
                    'it fails, set overall rating to fail and exit/
                    myReturn = clsAuditor.auditRating.fail
                    Exit For
                End If

            Next

            'if the return is already failing, we do not need to do this.
            If myReturn <> clsAuditor.auditRating.fail Then
                'it didn't fail, we need to figure out its rank based on score.

                'it is on probation since it is >= warning but not quite at passing.
                If tempScore >= Me.Probation And tempScore < Me.Pass Then
                    myReturn = clsAuditor.auditRating.warn
                ElseIf tempScore >= Me.Pass Then
                    'it is passing
                    myReturn = clsAuditor.auditRating.pass
                Else
                    'it failed since it isn't above probation or passing values
                    myReturn = clsAuditor.auditRating.fail
                End If
            End If
            Return myReturn
        End Function

        Public Overrides Function toString() As String
            Return "clsCatagoryFactory"
        End Function
    End Class
End Namespace