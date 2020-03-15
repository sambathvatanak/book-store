Imports System.Data.SqlClient
Imports System.Globalization
Public Class frmImport
    Dim DAdp As SqlDataAdapter
    Dim table As DataTable
    Dim DSet As DataSet
    Dim com As SqlCommand
    Dim cnn As New PhoneShop
    Dim Eid As Integer
    Dim str As String
    Dim GTotal As Double
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtImID.TextChanged

    End Sub
    Public Sub CloseControl()
        txtImID.Enabled = False
        dtpImportDate.Enabled = False
        cboEName.Enabled = False
        txtEID.Enabled = False
        cboSup.Enabled = False
        txtSubID.Enabled = False
        txtPosition.Enabled = False
        txtPName.Enabled = False
        txtPID.Enabled = False
        cboCat.Enabled = False
        txtCatID.Enabled = False
        txtImID.Enabled = False
        txtUPIS.Enabled = False
        txtUPrice.Enabled = False
        txtComName.Enabled = False
        txtImQty.Enabled = False
        btnSave.Enabled = False
        btnAdd.Enabled = False
        btnExit.Enabled = False
        btnRemove.Enabled = False
    End Sub
    Public Sub EnableControl()
        txtImID.Enabled = True
        dtpImportDate.Enabled = True
        cboEName.Enabled = True
        txtEID.Enabled = True
        txtImID.Enabled = True
        cboSup.Enabled = True
        txtSubID.Enabled = True
        txtPosition.Enabled = True
        txtPName.Enabled = True
        txtPID.Enabled = True
        cboCat.Enabled = True
        txtCatID.Enabled = True
        txtImID.Enabled = True
        txtUPIS.Enabled = True
        txtUPrice.Enabled = True
        txtComName.Enabled = True
        txtImQty.Enabled = True
        btnSave.Enabled = True
        btnAdd.Enabled = True
        btnExit.Enabled = True
        btnRemove.Enabled = False
    End Sub
    Public Sub ClearMiniControl()
        txtPName.Text = ""
        txtPID.Text = ""
        cboCat.Text = ""
        txtCatID.Text = ""
        txtUPIS.Text = ""
        txtUPrice.Text = ""
        txtImQty.Text = ""
    End Sub

    Public Sub ClearText()
        txtImID.Text = ""
        dtpImportDate.Text = ""
        cboEName.SelectedIndex = -1
        txtEID.Text = ""
        cboSup.SelectedIndex = -1
        txtSubID.Text = ""
        txtPosition.Text = ""
        txtPName.Text = ""
        txtPID.Text = ""
        cboCat.SelectedIndex = -1
        txtCatID.Text = ""
        txtImID.Text = ""
        txtUPIS.Text = ""
        txtUPrice.Text = ""
        txtTotalAmount.Text = ""
        txtComName.Text = ""
        txtImQty.Text = ""
    End Sub
    Public Sub FillStaff()
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
    End Sub
    Public Sub FillSup()
        Try
            DAdp = New SqlDataAdapter("SELECT * FROM tbSupplier", cnn.sqlCon)
            table = New DataTable()
            DAdp.Fill(table)
            cboSup.DataSource = Nothing
            cboSup.Items.Clear()
            cboSup.DataSource = table
            cboSup.DisplayMember = "Name"
            cboSup.ValueMember = "ID"
            table = Nothing
            DAdp.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub FillCat()
        Try
            DAdp = New SqlDataAdapter("SELECT * FROM tbCategory", cnn.sqlCon)
            table = New DataTable()
            DAdp.Fill(table)
            cboCat.DataSource = Nothing
            cboCat.Items.Clear()
            cboCat.DataSource = table
            cboCat.DisplayMember = "Cat"
            cboCat.ValueMember = "ID"
            table = Nothing
            DAdp.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub frmImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn.myCon()
        CloseControl()
        txtTotalAmount.Enabled = False
        dgvImInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvImInfo.AllowUserToResizeRows = False
        dgvImInfo.AllowUserToResizeColumns = False
        dgvImInfo.MultiSelect = False
        dtpImportDate.CustomFormat = " "
        FillStaff()
        FillSup()
        FillCat()
        cboEName.SelectedValue = -1
        cboSup.SelectedValue = -1
        cboCat.SelectedIndex = -1
        dgvImInfo.ColumnCount = 7
        dgvImInfo.Columns(0).Name = "Product ID"
        dgvImInfo.Columns(1).Name = "Product Name"
        dgvImInfo.Columns(2).Name = "Category"
        dgvImInfo.Columns(3).Name = "Category ID"
        dgvImInfo.Columns(4).Name = "Import Quantity"
        dgvImInfo.Columns(5).Name = "UPIS"
        dgvImInfo.Columns(6).Name = "Unit Price"
        ' dgvEmp.Columns(0).Width = 10
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If btnNew.Text = "New" Then
            str = "New"
            EnableControl()
            ClearText()
            btnNew.Text = "Cancel"
            btnSave.Enabled = True
            txtPName.Enabled = False
            txtCatID.Enabled = False
            txtUPIS.Enabled = False
            txtUPrice.Enabled = False
            txtImID.Select()
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
            dgvImInfo.Rows.Clear()
            dtpImportDate.CustomFormat = " "
        End If
    End Sub

    Private Sub dtpImportDate_ValueChanged(sender As Object, e As EventArgs)
        dtpImportDate.CustomFormat = "MM-dd-yyyy"
    End Sub
    Private Sub cboEName_SelectionChangeCommitted_1(sender As Object, e As EventArgs) Handles cboEName.SelectionChangeCommitted
        Dim staff As String = cboEName.SelectedValue.ToString()
        'MessageBox.Show(staff)
        Try
            Dim Dreader As SqlDataReader
            com = New SqlCommand("SELECT ID , Position FROM tbStaff WHERE ID LIKE '" + staff + "'", cnn.sqlCon)
            Dreader = com.ExecuteReader
            com = Nothing
            While Dreader.Read
                txtEID.Text = Dreader("ID")
                txtPosition.Text = Dreader("Position")
            End While
            Dreader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cboSup_SelectionChangeCommitted(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboSup_SelectionChangeCommitted_1(sender As Object, e As EventArgs) Handles cboSup.SelectionChangeCommitted
        Dim sup As String = cboSup.SelectedValue.ToString()
        'MessageBox.Show(staff)
        Try
            Dim Dreader As SqlDataReader
            com = New SqlCommand("SELECT ID , Company FROM tbSupplier WHERE ID LIKE '" + sup + "'", cnn.sqlCon)
            Dreader = com.ExecuteReader
            com = Nothing
            While Dreader.Read
                txtSubID.Text = Dreader("ID")
                txtComName.Text = Dreader("Company")
            End While
            Dreader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dtpImportDate_ValueChanged_1(sender As Object, e As EventArgs) Handles dtpImportDate.ValueChanged
        dtpImportDate.CustomFormat = "MM-dd-yyyy"
    End Sub
    Private Sub cboCat_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboCat.SelectionChangeCommitted
        Dim cat As String = cboCat.SelectedValue.ToString()
        'MessageBox.Show(cat)
        txtCatID.Text = cat
    End Sub

    Private Sub txtPID_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPID.KeyUp
        Dim PID As String = txtPID.Text
        'MessageBox.Show(staff)
        Try
            Dim Dreader As SqlDataReader
            com = New SqlCommand("SELECT Name , UPIS , UnitPrice FROM tbProduct WHERE ID LIKE '" + PID + "'", cnn.sqlCon)
            Dreader = com.ExecuteReader
            com = Nothing
            While Dreader.Read
                txtPName.Text = Dreader("Name")
                txtUPIS.Text = String.Format("{0:C2}", Dreader("UPIS"))
                txtUPrice.Text = String.Format("{0:C2}", Dreader("UnitPrice"))
            End While
            Dreader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim cat As String = cboCat.GetItemText(cboCat.Items(cboCat.SelectedIndex))
        'MessageBox.Show(cat)
        Dim row As String() = New String() {txtPID.Text, txtPName.Text, cat, txtCatID.Text,
                                            txtImQty.Text, txtUPIS.Text, txtUPrice.Text}
        dgvImInfo.Rows.Add(row)
        Dim i As Integer = dgvImInfo.Rows.Count - 1
        Dim mul As Double
        Dim qty As Double = dgvImInfo(4, i).Value
        Dim upis As Double = dgvImInfo(5, i).Value
        mul = qty * upis
        GTotal = GTotal + mul
        txtTotalAmount.Text = String.Format("{0:C2}", GTotal)
        ClearMiniControl()
        txtImID.Enabled = False
        Me.dgvImInfo.ClearSelection()
    End Sub
    Public Sub SaveImport(x As String)
        ' Dim value As String
        'value = Decimal.Parse(txtSalary.Text, NumberStyles.Currency)
        Dim EName As String = cboEName.GetItemText(cboEName.Items(cboEName.SelectedIndex))
        'MessageBox.Show(EName)
        Dim SupName As String = cboSup.GetItemText(cboSup.Items(cboSup.SelectedIndex))
        'MessageBox.Show(SupName)
        Try
            com = New SqlCommand(x, cnn.sqlCon)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.AddWithValue("@ID", txtImID.Text)
            com.Parameters.AddWithValue("@Date", dtpImportDate.Value)
            com.Parameters.AddWithValue("@EID", txtEID.Text)
            com.Parameters.AddWithValue("@EName", EName)
            com.Parameters.AddWithValue("@SID", txtSubID.Text)
            com.Parameters.AddWithValue("@SName", SupName)
            com.Parameters.AddWithValue("@ComName", txtComName.Text)
            com.Parameters.AddWithValue("@EPos", txtPosition.Text)
            com.Parameters.AddWithValue("@Total", txtTotalAmount.Text)
            com.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub SaveImportDetail(x As String)

        Try

            For i As Integer = 0 To dgvImInfo.Rows.Count - 1
                Dim row As Integer = i
                com = New SqlCommand(x, cnn.sqlCon)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.AddWithValue("@IMID", txtImID.Text)
                com.Parameters.AddWithValue("@PID", dgvImInfo(0, i).Value)
                com.Parameters.AddWithValue("@PName", dgvImInfo(1, i).Value)
                com.Parameters.AddWithValue("@CName", dgvImInfo(2, i).Value)
                com.Parameters.AddWithValue("@CID", dgvImInfo(3, i).Value)
                com.Parameters.AddWithValue("@Qty", dgvImInfo(4, i).Value)
                com.Parameters.AddWithValue("@UPIS", dgvImInfo(5, i).Value)
                com.Parameters.AddWithValue("@UnitPrice", dgvImInfo(6, i).Value)
                com.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub UpStock(x As String)
        Try
            For i As Integer = 0 To dgvImInfo.Rows.Count - 1
                Dim row As Integer = i
                Dim PID As String = dgvImInfo(0, i).Value
                Dim Qty As String = dgvImInfo(4, i).Value
                com = New SqlCommand("UPDATE tbStock set Qty=Qty+? WHERE PName LIKE'" + PID + "'", cnn.sqlCon)
                com.CommandType = CommandType.StoredProcedure
                'com.Parameters.AddWithValue("@PName", PName)
                com.Parameters.AddWithValue("@Qty", Qty)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveImport("InImport")
        SaveImportDetail("InImDetail")
        UpStock("UpNewStock")
        MessageBox.Show("Your record was saved")
        dgvImInfo.Rows.Clear()
        ClearText()
        btnExit.Enabled = True
        btnNew.Text = "New"
        frmImport_Load(sender, e)

    End Sub

    Private Sub dgvImInfo_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        '  btnRemove.Enabled = True
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        dgvImInfo.Rows.Remove(dgvImInfo.SelectedRows(0))
        btnRemove.Enabled = False
    End Sub

    Private Sub dgvImInfo_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvImInfo.CellClick
        btnRemove.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

    End Sub
End Class
