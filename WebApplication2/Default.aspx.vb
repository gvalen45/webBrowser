Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

	'When button1 is clicked then the user-input in textBox1.Text is sorted using 
	'server reference to sort() method
	Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		'string declared
		Dim var As String
		'server client reference
		Dim sc As ServiceReference1.Service1Client = New ServiceReference1.Service1Client()
		'var is assigned to user-input of TextBox1.Text
		var = TextBox1.Text
		'The user-input is sorted using serverReference method sort()
		'The returned value is outputted to textBox2
		TextBox2.Text = sc.sort(var)
		'close client
		sc.Close()



	End Sub
End Class