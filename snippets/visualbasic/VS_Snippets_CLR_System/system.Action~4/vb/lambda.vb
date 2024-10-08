﻿Option Strict On

' <Snippet4>
Public Module TestLambdaExpression
    Public Sub RunIt()
        Dim ordinals() As String = {"First", "Second", "Third", "Fourth", "Fifth",
                           "Sixth", "Seventh", "Eighth", "Ninth", "Tenth"}
        Dim copiedOrdinals(ordinals.Length - 1) As String
        Dim copyOperation As Action(Of String(), String(), Integer, Integer) =
                           Sub(s1, s2, pos, num) CopyStrings(s1, s2, pos, num)
        copyOperation(ordinals, copiedOrdinals, 3, 5)

        Console.WriteLine()
        For Each ordinal As String In copiedOrdinals
            If String.IsNullOrEmpty(ordinal) Then
                Console.WriteLine("<None>")
            Else
                Console.WriteLine(ordinal)
            End If
        Next
    End Sub

    Private Function CopyStrings(source() As String, target() As String,
                                startPos As Integer, number As Integer) As Integer
        If source.Length <> target.Length Then
            Throw New IndexOutOfRangeException("The source and target arrays must have the same number of elements.")
        End If

        For ctr As Integer = startPos To startPos + number - 1
            target(ctr) = source(ctr)
        Next
        Return number
    End Function
End Module

' The example displays the following output:
'       <None>
'       <None>
'       <None>
'       Fourth
'       Fifth
'       Sixth
'       Seventh
'       Eighth
'       <None>
'       <None>
' </Snippet4>
