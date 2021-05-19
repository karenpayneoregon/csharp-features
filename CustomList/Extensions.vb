Imports System.Runtime.CompilerServices

Public Module Extensions
    <Extension>
    Public Function ToList(Of T)(collection As IEnumerable(Of T)) As List(Of T)
        Return New List(Of T)(collection)
    End Function
    <Extension>
    Public Function Total(sender As List(Of Work)) As Integer
        Return sender.Where(Function(work) work.Id <= 99).Sum(Function(work) work.Quantity * work.UnitCost)
    End Function
End Module