﻿Public Class frmRegistry
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub

    Private Sub frmRegistry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("powershell", "-File C:\YourFileLocation")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox",
"UserCreatedTestKey", "Yes")

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\PC Toolbox\Debugging",
"RegistryTestKey", "This is a test key.")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class