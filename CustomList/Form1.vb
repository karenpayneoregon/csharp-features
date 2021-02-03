Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class Form1

	WithEvents mBindingSource As New BindingSource
	Private mBindingList As New BindingList(Of Work)


	Private Sub PopulateButton_Click(sender As Object, e As EventArgs) Handles PopulateButton.Click

		Dim list As New List(Of Work) From {
			New Work With {.Id = 1, .Description = "First", .UnitCost = 100, .Quantity = 2},
			New Work With {.Id = 2, .Description = "Second", .UnitCost = 10, .Quantity = 1},
			New Work With {.Id = 99, .Description = "Ninety nine", .UnitCost = 200, .Quantity = 1},
			New Work With {.Id = 100, .Description = "One hundred", .UnitCost = 100, .Quantity = 5}
		}

		mBindingList = New BindingList(Of Work)(list)
		mBindingSource.DataSource = mBindingList
		DataGridView1.DataSource = mBindingSource

	End Sub

	Private Sub TotalButton_Click(sender As Object, e As EventArgs) Handles TotalButton.Click
		If mBindingSource.DataSource IsNot Nothing Then
			Dim total = mBindingList.ToList().Total()
			TotalLabel.Text = $"Total: {total}"
		Else
			MessageBox.Show("No work items")
		End If
	End Sub

	Private Sub ChangeButton_Click(sender As Object, e As EventArgs) Handles ChangeButton.Click

		If mBindingSource.DataSource IsNot Nothing Then

		    Dim quantity As Integer

			If Integer.TryParse(QuantityTextBox.Text, quantity) Then
				mBindingList(mBindingSource.Position).Quantity = quantity
				mBindingSource.ResetCurrentItem()
			End If

		Else
			MessageBox.Show("No work items")
		End If

	End Sub
End Class
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

