Imports System.Data.SqlClient
Imports System.Globalization
Public Class frmSupplier
    Dim DAdp As SqlDataAdapter
    Dim table As DataTable
    Dim DSet As DataSet
    Dim com As SqlCommand
    Dim cnn As New PhoneShop
    Dim Eid As Integer
    Dim str As String
    Public Sub EnableControl()
        txtID.Enabled = True
        txtName.Enabled = True
        txtComName.Enabled = True
        txtAdd.Enabled = True
        txtPNumber.Enabled = True
        txtEmail.Enabled = True
    End Sub
    Public Sub CloseControl()
        txtID.Enabled = False
        txtName.Enabled = False
        txtComName.Enabled = False
        txtAdd.Enabled = False
        txtPNumber.Enabled = False
        txtEmail.Enabled = False
    End Sub
    Public Sub ClearText()
        txtID.Text = ""
        txtName.Text = ""
        txtComName.Text = ""
        txtAdd.Text = ""
        txtPNumber.Text = ""
        txtEmail.Text = ""

    End Sub
    Private Sub frmSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CloseControl()
        btnSave.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False

        dgvSupplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSupplier.ClearSelection()
        dgvSupplier.AllowUserToResizeRows = False
        dgvSupplier.AllowUserToResizeColumns = False
        dgvSupplier.MultiSelect = False
        'dgvProduct.Columns(0).Width = 30
        Try
            cnn.myCon()
            DSet = New DataSet()
            table = New DataTable
            DAdp = New SqlDataAdapter("SELECT * FROM tbSupplier", cnn.sqlCon)
            DAdp.Fill(DSet)
            dgvSupplier.DataSource = DSet.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If btnNew.Text = "New" Then
            str = "New"
            EnableControl()
            ClearText()
            btnNew.Text = "Cancel"
            btnSave.Enabled = True
            txtID.Select()
        Else
            Dim btn As MessageBoxButtons = MessageBoxButtons.YesNo

            Dim ans As DialogResult
            ans = MessageBox.Show("តើអ្នកចង់បោះបង់ចោលឬទេ?", "បោះបង់", btn, MessageBoxIcon.Question)
            If ans = DialogResult.Yes Then
                ClearText()
                CloseControl()
                btnEdit.Enabled = False
                btnSave.Enabled = False
                btnNew.Text = "New"
                btnEdit.Text = "Edit"
                btnNew.Enabled = True
                ClearText()
            End If
        End If
    End Sub
    Public Sub SaveData(x As String)
        com = New SqlCommand(x, cnn.sqlCon)
        com.CommandType = CommandType.StoredProcedure
        com.Parameters.AddWithValue("@ID", txtID.Text)
        com.Parameters.AddWithValue("@Name", txtName.Text)
        com.Parameters.AddWithValue("@Company", txtComName.Text)
        com.Parameters.AddWithValue("@Address", txtAdd.Text)
        com.Parameters.AddWithValue("@Phone", txtPNumber.Text)
        com.Parameters.AddWithValue("@Email", txtEmail.Text)

        com.ExecuteNonQuery()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveData("InSupplier")
        btnNew.Text = "New"
        MessageBox.Show("Your record was saved")
        ClearText()
        frmSupplier_Load(sender, e)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Edit" Then
            EnableControl()
            btnNew.Text = "Cancel"
            btnEdit.Text = "Update"
        Else
            SaveData("UpSupplier")
            MessageBox.Show("Updated")
            ClearText()
            btnNew.Text = "New"
            frmSupplier_Load(sender, e)
        End If
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
                com = New SqlCommand("DelSupplier", cnn.sqlCon)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.AddWithValue("@ID", Eid)
                com.ExecuteNonQuery()
                ClearText()
                MessageBox.Show("Your record was deleted!!!", "Delete")
            Catch Ex As Exception
                MessageBox.Show(Ex.Message)
            End Try
            frmSupplier_Load(sender, e)
        End If
    End Sub
    Public Sub search(Z As String)
        table = New DataTable()
        com = New SqlCommand(Z, cnn.sqlCon)
        com.CommandType = CommandType.StoredProcedure
        DAdp = New SqlDataAdapter()
        com.Parameters.AddWithValue("@x", txtSearch.Text)
        DAdp.SelectCommand = com
        DAdp.Fill(table)
        com.Dispose()
        DAdp.Dispose()
    End Sub
    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp
        search("SearchSup")
        dgvSupplier.DataSource = table
    End Sub

    Private Sub dgvSupplier_CellClick(sender As Object, e As DataGridViewCellEventArgs) 
        Dim i As Integer
        If dgvSupplier.RowCount > 0 Then
            i = e.RowIndex
            If i < 0 Then
                Return
            End If
            Dim Row As DataGridViewRow = dgvSupplier.Rows(i)
            Eid = Integer.Parse(Row.Cells(0).Value.ToString())
            txtID.Text = Eid
            txtName.Text = Row.Cells(1).Value.ToString()
            txtComName.Text = Row.Cells(2).Value.ToString()
            txtAdd.Text = Row.Cells(3).Value.ToString()
            txtPNumber.Text = Row.Cells(4).Value.ToString()
            txtEmail.Text = Row.Cells(5).Value.ToString()
            btnEdit.Enabled = True
            btnDelete.Enabled = True
            btnNew.Text = "Cancel"
        End If
    End Sub
End Class