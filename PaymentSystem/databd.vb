Public Class databd

    Private connectionString As String

    Public Sub New(databasePath As String)
        ' Initialize connection string with database path
        connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Projects\PaymentSystem\PaymentSystem\PaymentSystem\db\systemDB.accdb;"
    End Sub

    Public Function UserExists(id As String) As Boolean
        ' Query to check if the user exists in the database
        Dim query As String = "SELECT COUNT(*) FROM User_Data WHERE ID_NUmber = @ID_Number"

        Using connection As New OleDbConnection(connectionString)

            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@ID_number", id)
                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using

        End Using

    End Function

    Public Function RetrieveUserData(id As String) As UserData
        ' Query to retrieve user data from the database
        Dim query As String = "SELECT * FROM User_Data WHERE ID_number = @ID_number"

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@ID_number", id)
                connection.Open()
                Using reader As OleDbDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Retrieve user data from the database
                        Dim userData As New UserData()
                        userData.ID = reader("ID_number").ToString()
                        userData.Name = reader("First_Name").ToString()
                        ' Add more fields as needed
                        Return userData
                    Else
                        Return Nothing
                    End If
                End Using
            End Using
        End Using
    End Function

End Class

Public Class UserData

    ' Define properties to hold user data
    Public Property ID As String
    Public Property Name As String
    ' Add more properties as needed


End Class
