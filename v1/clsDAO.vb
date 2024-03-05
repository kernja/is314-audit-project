Namespace IS314_Proj1_Kernja

    Public Class clsDAO
        Inherits clsObject
        Public Function verifyPassword(ByVal passedUsername As String, ByVal passedPassword As String) As Boolean
            Dim myreturn As Boolean = False

            If passedUsername.Equals("foo") And passedPassword.Equals("bar") Then
                myreturn = True
            End If

            Return myreturn
        End Function

        Public Overrides Function toString() As String
            Return "DAO"
        End Function
    End Class
End Namespace
