Imports System.Data.SqlClient
Imports System.Globalization
Public Class frmLogin
    Dim DAdp As SqlDataAdapter
    Dim table As DataTable
    Dim DSet As DataSet
    Dim com As SqlCommand
    Dim cnn As New PhoneShop
    Dim Eid As Integer
    Dim str As String
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnLogin.Select()
        Me.btnLogin.FlatAppearance.BorderSize = 0
        txtUserName.Text = "User Name"
        txtPassword.Text = "Password"
    End Sub

    Private Sub lblUserName_Enter(sender As Object, e As EventArgs) Handles txtUserName.Enter
        If txtUserName.Text.Trim <> "" Then
            txtUserName.Text = ""
            txtUserName.ForeColor = Color.Black
        End If
    End Sub

    Private Sub lblUserName_Leave(sender As Object, e As EventArgs) Handles txtUserName.Leave
        If txtUserName.Text = "" Then
            txtUserName.Text = "User Name"
            txtUserName.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If txtPassword.Text <> "" Then
            txtPassword.Text = ""
            txtPassword.PasswordChar = "*"
            txtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
            txtPassword.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub chbShow_CheckedChanged(sender As Object, e As EventArgs) Handles chbShow.CheckedChanged
        txtPassword.UseSystemPasswordChar = chbShow.Checked
    End Sub

    Private Sub Login_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        ControlPaint.DrawBorder3D(e.Graphics, New Rectangle(10, 10, 340, 232))
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        cnn.myCon()
        Dim un As String = txtUserName.Text
        Dim pw As String = txtPassword.Text
        DAdp = New SqlDataAdapter()
        DSet = New DataSet()
        com = New SqlCommand("SELECT * FROM getUser1('" +
                                    un + "', '" + pw + "')", cnn.sqlCon)
        DAdp.SelectCommand = com
        DAdp.Fill(DSet)
        If DSet.Tables(0).Rows.Count >= 1 Then
            Dim Row As DataRow = DSet.Tables(0).Rows(0)
            PhoneShop.EID = Row(0).ToString()
            PhoneShop.EName = Row(1).ToString()
            PhoneShop.EPos = Row(4).ToString()
            Dim frm As New frmMainForm
            frm.Show()
        Else

            MessageBox.Show("Your username and password is incorrect...")
        End If
    End Sub
End Class