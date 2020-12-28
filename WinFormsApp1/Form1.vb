Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        'Label3.Text = New DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Name

        Dim last = Application.StartupPath.TrimEnd("\"c)

        Label3.Text = Path.GetFileName(AppDomain.CurrentDomain.BaseDirectory.TrimEnd("\"c))
        'Label3.Text = Path.GetFileName(AppDomain.CurrentDomain.BaseDirectory)
    End Sub
End Class
