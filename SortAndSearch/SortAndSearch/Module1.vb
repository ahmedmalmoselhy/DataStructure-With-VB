﻿Module Module1

    Sub Main()

    End Sub
    Class CArray
        Private arr() As Integer
        Private numElements As Integer

        Public Sub New(ByVal number As Integer)
            ReDim arr(number)
            numElements = 0
        End Sub

        Public Sub insert(ByVal item As Integer)
            ' Increasing the size of the array
            If numElements > arr.GetUpperBound(0) Then
                ReDim Preserve arr(numElements * 1.25)
            End If
            arr(numElements) = item
            numElements += 1
        End Sub

        Public Sub showArray()
            Dim index As Integer
            For index = 0 To numElements - 1
                Console.Write(arr(index) & " ")
            Next
            Console.WriteLine()
        End Sub
    End Class
End Module
