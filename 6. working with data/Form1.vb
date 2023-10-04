Public Class Form1
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		Dim YourMessage As String

		Dim Birthyear As Integer

		Dim AGE As Integer

		YourMessage = "Happy birthday"



		MsgBox(YourMessage)

		AGE = Val(InputBox("enter your age"))
		Birthyear = Val(InputBox("enter the year you were born"))
		MsgBox("you are now " & 2023 - Birthyear & "years old")

	End Sub
End Class
