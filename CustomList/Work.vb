Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class Work
    Implements INotifyPropertyChanged

    Private _id As Integer
    Private _description As String
    Private _quantity As Integer
    Private _unitCost As Integer

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set
            _id = Value
        End Set
    End Property

    Public Property Description As String
        Get
            Return _description
        End Get
        Set
            _description = Value
        End Set
    End Property

    Public Property Quantity As Integer
        Get
            Return _quantity
        End Get
        Set
            _quantity = Value
        End Set
    End Property

    Public Property UnitCost As Integer
        Get
            Return _unitCost
        End Get
        Set
            _unitCost = Value
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional memberName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(memberName))
    End Sub

    Public Overrides Function ToString() As String
        Return $"Id: {Id} Description: {Description}"
    End Function
End Class