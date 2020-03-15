Imports System.Data.SqlClient
Imports System.Globalization
Public Class frmProduct
    Dim DAdp As SqlDataAdapter
    Dim table As DataTable
    Dim DSet As DataSet
    Dim com As SqlCommand
    Dim cnn As New PhoneShop
    Dim Eid As Integer
    Dim str As String

    Public Sub EnableControl()
        txtPID.Enabled = True
        txtPName.Enabled = True
        txtUP.Enabled = True
        txtUPIS.Enabled = True
    End Sub
    Public Sub CloseControl()
        txtPID.Enabled = False
        txtPName.Enabled = False
        txtUP.Enabled = False
        txtUPIS.Enabled = False
    End Sub
    Public Sub ClearText()
        txtPID.Text = ""
        txtPName.Text = ""
        txtUP.Text = ""
        txtUPIS.Text = ""

    End Sub
    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CloseControl()
        btnSave.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False

        dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProduct.ClearSelection()
        dgvProduct.AllowUserToResizeRows = False
        dgvProduct.AllowUserToResizeColumns = False
        dgvProduct.MultiSelect = False
        'dgvProduct.Columns(0).Width = 30
        Try
            cnn.myCon()
            DSet = New DataSet()
            table = New DataTable
            DAdp = New SqlDataAdapter("SELECT * FROM tbProduct", cnn.sqlCon)
            DAdp.Fill(DSet)
            dgvProduct.DataSource = DSet.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If btnNew.Text = "New" Then
            str = "New"
            EnableControl()
            ClearText()
            btnNew.Text = "Cancel"
            btnSave.Enabled = True
            txtPID.Select()
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
        com.Parameters.AddWithValue("@ID", txtPID.Text)
        com.Parameters.AddWithValue("@Name", txtPName.Text)
        com.Parameters.AddWithValue("@UPIS", txtUPIS.Text)
        com.Parameters.AddWithValue("@UnitPrice", txtUP.Text)
        com.ExecuteNonQuery()
    End Sub
    Public Sub SaveStock(x As String)
        Dim qty As Integer = 0
        com = New SqlCommand(x, cnn.sqlCon)
        com.CommandType = CommandType.StoredProcedure
        com.Parameters.AddWithValue("@ID", txtPID.Text)
        com.Parameters.AddWithValue("@PName", txtPName.Text)
        com.Parameters.AddWithValue("@Qty", qty)
        com.Parameters.AddWithValue("@UPIS", txtUPIS.Text)
        com.Parameters.AddWithValue("@UnitPrice", txtUP.Text)
        com.ExecuteNonQuery()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveData("InPro")
        SaveStock("InStock")
        btnNew.Text = "New"
        MessageBox.Show("Your record was saved")
        ClearText()
        frmProduct_Load(sender, e)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Edit" Then
            EnableControl()
            btnNew.Text = "Cancel"
            btnEdit.Text = "Update"
        Else
            SaveData("UpPro")
            SaveStock("UpStock")
            MessageBox.Show("Updated")
            ClearText()
            btnNew.Text = "New"
            btnEdit.Text = ""
            frmProduct_Load(sender, e)
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
                com = New SqlCommand("DelPro", cnn.sqlCon)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.AddWithValue("@ID", Eid)
                com.ExecuteNonQuery()
                ClearText()
                MessageBox.Show("Your record was deleted!!!", "Delete")
            Catch Ex As Exception
                MessageBox.Show(Ex.Message)
            End Try
            frmProduct_Load(sender, e)
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

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
        search("SearchPro")
        dgvProduct.DataSource = table
    End Sub
    Private Sub dgvProduct_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) 
        Dim i As Integer
        If dgvProduct.RowCount > 0 Then
            i = e.RowIndex
            If i < 0 Then
                Return
            End If
            Dim Row As DataGridViewRow = dgvProduct.Rows(i)
            Eid = Integer.Parse(Row.Cells(0).Value.ToString())
            txtPID.Text = Eid
            txtPName.Text = Row.Cells(1).Value.ToString()
            txtUPIS.Text = Row.Cells(2).Value.ToString()
            txtUP.Text = Row.Cells(3).Value.ToString()
            btnEdit.Enabled = True
            btnDelete.Enabled = True
            btnNew.Text = "Cancel"
        End If
    End Sub
End Class