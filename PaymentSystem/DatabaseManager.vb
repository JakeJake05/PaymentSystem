Public Class DatabaseManager
    Private ReadOnly data As New Dictionary(Of Integer, Dictionary(Of String, Object))()

    Public Sub New()
        InsertSampleData()
    End Sub

    Public Sub InsertSampleData()
        Dim sampleData As New Dictionary(Of String, Object)()
        sampleData.Add("ID_Number", 202011586)
        sampleData.Add("First_Name", "Mary Joy")
        sampleData.Add("Middle_Name", "Abdurahim")
        sampleData.Add("Last_Name", "Abubacar")
        sampleData.Add("Course", "BS Computer Engineering")
        sampleData.Add("Year", 4)
        sampleData.Add("Balance", 20000.0)
        sampleData.Add("Date_Registered", New DateTime(2024, 4, 22))

        data.Add(202011586, sampleData)
    End Sub

    Public Function GetDataByID(ByVal id As Integer) As Dictionary(Of String, Object)
        If data.ContainsKey(id) Then
            Return data(id)
        Else
            Return Nothing
        End If
    End Function

    Public Function GetAllData() As Dictionary(Of Integer, Dictionary(Of String, Object))
        Return data
    End Function
End Class
