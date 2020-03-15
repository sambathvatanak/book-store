Imports System.Data.SqlClient
Public Class PhoneShop

    Public sqlCon As SqlConnection
    Public Shared EID As String
    Public Shared EName As String
    Public Shared EPos As String
    Public Sub myCon()
        Dim conStr As String

        conStr = "Data Source=VATANAKSAMBATH\SQLEXPRESS; Initial Catalog=BookStore; Integrated Security=True"
        Try
            sqlCon = New SqlConnection(conStr)
            sqlCon.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Shared Function EnableControl(frm As Form)
        Dim ct As Control
        For Each ct In frm.Controls
            ct.Enabled = True
        Next
        End
    End Function

    Public Shared Sub CloseControl(frm As Control)
        frm.Enabled = False
    End Sub
    Public Shared Sub CleanControl(frm As Form)
        Dim ctrl As Control
        Dim textbox As TextBox = Nothing
        Dim radio As RadioButton = Nothing
        For Each ctrl In frm.Controls
            If ctrl Is textbox Then
                If ctrl.Tag = "" Then
                    ctrl.Text = ""
                End If
                If ctrl Is radio Then

                End If
            End If
        Next
    End Sub

    Friend Shared Sub EnableControl()
        Throw New NotImplementedException()
    End Sub
End Class
