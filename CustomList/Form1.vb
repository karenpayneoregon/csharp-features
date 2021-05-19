Imports System.ComponentModel

Public Class Form1

	WithEvents workBindingSource As New BindingSource
	Private workBindingList As New BindingList(Of Work)


	Private Sub PopulateButton_Click(sender As Object, e As EventArgs) Handles PopulateButton.Click

		Dim list As New List(Of Work) From {
			New Work With {.Id = 1, .Description = "First", .UnitCost = 100, .Quantity = 2},
			New Work With {.Id = 2, .Description = "Second", .UnitCost = 10, .Quantity = 1},
			New Work With {.Id = 99, .Description = "Ninety nine", .UnitCost = 200, .Quantity = 1},
			New Work With {.Id = 100, .Description = "One hundred", .UnitCost = 100, .Quantity = 5}
		}

		workBindingList = New BindingList(Of Work)(list)
		workBindingSource.DataSource = workBindingList
		DataGridView1.DataSource = workBindingSource

	End Sub

	Private Sub TotalButton_Click(sender As Object, e As EventArgs) Handles TotalButton.Click
		If workBindingSource.DataSource IsNot Nothing Then
			Dim total = workBindingList.ToList().Total()
			TotalLabel.Text = $"Total: {total}"
		Else
			MessageBox.Show("No work items")
		End If
	End Sub

	Private Sub ChangeButton_Click(sender As Object, e As EventArgs) Handles ChangeButton.Click

		If workBindingSource.DataSource IsNot Nothing Then
			Dim quantity As Integer

			If Integer.TryParse(QuantityTextBox.Text, quantity) Then
				Dim current As Work = workBindingList(workBindingSource.Position)

				current.Quantity = quantity
				workBindingSource.ResetCurrentItem()
			End If

		Else
			MessageBox.Show("No work items")
		End If

	End Sub
End Class