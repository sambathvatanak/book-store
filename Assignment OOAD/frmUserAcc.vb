Imports System.Data.SqlClient
Imports System.Globalization
Public Class frmUserAcc
    Dim DAdp As SqlDataAdapter
    Dim table As DataTable
    Dim DSet As DataSet
    Dim com As SqlCommand
    Dim cnn As New PhoneShop
    Dim Eid As Integer
    Dim str As String
    Dim s_name As String
    Public Sub EnableControl()
        cboEName.Enabled = True
        txtAccName.Enabled = True
        txtAccID.Enabled = True
        txtPwd.Enabled = True
        txtRePwd.Enabled = True
        txtPos.Enabled = True
    End Sub
    Public Sub CloseControl()
        cboEName.Enabled = False
        txtAccName.Enabled = False
        txtAccID.Enabled = False
        txtPwd.Enabled = False
        txtRePwd.Enabled = False
        txtPos.Enabled = False
        btnSave.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
    End Sub
    Public Sub ClearText()
        cboEName.SelectedItem = (-1)
        txtAccName.Text = ""
        txtAccID.Text = ""
        txtPwd.Text = ""
        txtRePwd.Text = ""
        txtPos.Text = ""
    End Sub
    Public Sub FillList()
        Try
            cnn.myCon()
            DAdp = New SqlDataAdapter("SELECT * FROM tbUser", cnn.sqlCon)
            DSet = New DataSet()
            DAdp.Fill(DSet)
            lstUserAcc.DataSource = Nothing
            lstUserAcc.Items.Clear()
            lstUserAcc.DataSource = DSet.Tables(0)
            lstUserAcc.DisplayMember = "UName"
            lstUserAcc.ValueMember = "ID"
            DSet = Nothing
            DAdp.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub frmUserAcc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CloseControl()
        btnDelete.Enabled = False
        FillList()
        Try
            DAdp = New SqlDataAdapter("SELECT * FROM tbStaff", cnn.sqlCon)
            table = New DataTable()
            DAdp.Fill(table)
            cboEName.DataSource = Nothing
            cboEName.Items.Clear()
            cboEName.DataSource = table
            cboEName.DisplayMember = "Name"
            cboEName.ValueMember = "ID"
            table = Nothing
            DAdp.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cboEName.SelectedIndex = (-1)
        txtSearch.Text = ""
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If btnNew.Text = "New" Then
            str = "New"
            EnableControl()
            txtAccID.Enabled = False
            ClearText()
            btnNew.Text = "Cancel"
            btnSave.Enabled = True
            cboEName.Select()
        Else
            Dim btn As MessageBoxButtons = MessageBoxButtons.YesNo

            Dim ans As DialogResult
            ans = MessageBox.Show("តើអ្នកចង់បោះបង់ចោលឬទេ?", "បោះបង់", btn, MessageBoxIcon.Question)
            If ans = DialogResult.Yes Then
                ClearText()
                CloseControl()
                btnSave.Enabled = False
                btnNew.Text = "New"
                btnNew.Enabled = True
                ClearText()
            End If
        End If
    End Sub
    Public Sub SaveData(x As String)
        s_name = cboEName.GetItemText(cboEName.Items(cboEName.SelectedIndex))
        Try
            com = New SqlCommand(x, cnn.sqlCon)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.AddWithValue("@ID", txtAccID.Text)
            com.Parameters.AddWithValue("@SName", s_name)
            com.Parameters.AddWithValue("@UName", txtAccName.Text)
            com.Parameters.AddWithValue("@UPass", txtPwd.Text)
            com.Parameters.AddWithValue("@Upos", txtPos.Text)
            com.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveData("InUser")
        btnNew.Text = "New"
        MessageBox.Show("Your record was saved")
        ClearText()
        frmUserAcc_Load(sender, e)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtRePwd_TextChanged(sender As Object, e As EventArgs) Handles txtRePwd.TextChanged

    End Sub

    Private Sub cboEName_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboEName.SelectionChangeCommitted
        Dim staff As String = cboEName.SelectedValue.ToString()
        'MessageBox.Show(staff)
        Try
            Dim Dreader As SqlDataReader
            com = New SqlCommand("SELECT ID , Position FROM tbStaff WHERE ID LIKE '" + staff + "'", cnn.sqlCon)
            Dreader = com.ExecuteReader
            'com = Nothing
            While Dreader.Read
                txtAccID.Text = Dreader("ID")
                txtPos.Text = Dreader("Position")
            End While
            Dreader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Edit" Then
            EnableControl()
            btnNew.Text = "Cancel"
            btnEdit.Text = "Update"
        Else
            SaveData("UpUser")
            MessageBox.Show("Updated")
            ClearText()
            btnNew.Text = "New"
            btnEdit.Text = "Edit"
            btnEdit.Enabled = False
            btnSave.Enabled = False
            frmUserAcc_Load(sender, e)
        End If
    End Sub

    Private Sub lstUserAcc_Click(sender As Object, e As EventArgs) Handles lstUserAcc.Click
        Dim Did As String
        Dim Dreader As SqlDataReader
        Did = Integer.Parse(lstUserAcc.SelectedValue.ToString())
        Try

            com = New SqlCommand("SELECT * FROM getUser(" + Did + ")", cnn.sqlCon)
            Dreader = com.ExecuteReader
            'com = Nothing
            While Dreader.Read
                txtAccID.Text = Dreader("ID")
                cboEName.DataSource = Nothing
                cboEName.Items.Clear()
                cboEName.Items.Add(Dreader("SName"))
                cboEName.SelectedIndex = 0
                txtAccName.Text = Dreader("UName")
                txtPwd.Text = Dreader("UPass")
                txtRePwd.Text = txtPwd.Text
                txtPos.Text = Dreader("UPos")
                'com.Dispose()
                btnEdit.Enabled = True
                btnDelete.Enabled = True
            End While
            Dreader.Close()
            com.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim btn As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim rs As DialogResult = DialogResult.Yes
        Dim icn As MessageBoxIcon = MessageBoxIcon.Question
        Dim tle As String = "Delete"
        Dim prm As String = "Do you want to delete?"
        rs = MessageBox.Show(prm, tle, btn, icn)
        If rs = DialogResult.Yes Then
            Try
                com = New SqlCommand("DelUser", cnn.sqlCon)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.AddWithValue("@ID", txtAccID.Text)
                com.ExecuteNonQuery()
                ClearText()
                MessageBox.Show("Your record was deleted!!!", "Delete")
            Catch Ex As Exception
                MessageBox.Show(Ex.Message)
            End Try
            frmUserAcc_Load(sender, e)
        End If
    End Sub
End Class