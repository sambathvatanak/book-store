Imports System.Data.SqlClient
Imports System.Globalization
Public Class frmEmployee
    Dim DAdp As SqlDataAdapter
    Dim table As DataTable
    Dim DSet As DataSet
    Dim com As SqlCommand
    Dim cnn As New PhoneShop
    Dim Eid As Integer
    Dim str As String
    Public Sub CloseControl()
        pnl1.Enabled = False
        pnl2.Enabled = False
    End Sub
    Public Sub EnableControl()
        pnl1.Enabled = True
        pnl2.Enabled = True
    End Sub
    Public Sub ClearText()
        txtName.Text = ""
        txtID.Text = ""
        rdbMale.Checked = False
        rdbFemale.Checked = False
        dtpDOB.CustomFormat = " "
        txtPosition.Text = ""
        txtSalary.Text = ""
        txtAddress.Text = ""
        dtpWorkDate.CustomFormat = " "
        txtPhone.Text = ""
    End Sub

    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CloseControl()
        btnSave.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        dtpWorkDate.CustomFormat = " "
        dtpDOB.CustomFormat = " "

        dgvEmp.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEmp.ClearSelection()
        dgvEmp.AllowUserToResizeRows = False
        dgvEmp.AllowUserToResizeColumns = False
        dgvEmp.MultiSelect = False
        ' dgvEmp.Columns(0).Width = 10
        Try
            cnn.myCon()
            DSet = New DataSet()
            table = New DataTable
            DAdp = New SqlDataAdapter("SELECT * FROM tbStaff", cnn.sqlCon)
            DAdp.Fill(DSet)
            dgvEmp.DataSource = DSet.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub rdbMale_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub rdbFemale_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnNew_Click_1(sender As Object, e As EventArgs) Handles btnNew.Click
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

    Private Sub dtpDOB_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOB.ValueChanged
        dtpDOB.CustomFormat = "MM-dd-yyyy"
    End Sub

    Public Sub SaveData(x As String)
        Dim value As String
        value = Decimal.Parse(txtSalary.Text, NumberStyles.Currency)
        com = New SqlCommand(x, cnn.sqlCon)
        com.CommandType = CommandType.StoredProcedure
        com.Parameters.AddWithValue("@ID", txtID.Text)
        com.Parameters.AddWithValue("@Name", txtName.Text)
        If rdbFemale.Checked = True Then
            com.Parameters.AddWithValue("@Sex", "F")
        Else
            com.Parameters.AddWithValue("@Sex", "M")
            com.Parameters.AddWithValue("@DOB", dtpDOB.Value)
            com.Parameters.AddWithValue("@Pos", txtPosition.Text)
            com.Parameters.AddWithValue("@Add", txtAddress.Text)
            com.Parameters.AddWithValue("@Sal", value)
            com.Parameters.AddWithValue("@WD", dtpWorkDate.Value)
            com.Parameters.AddWithValue("@Phone", txtPhone.Text)
            com.ExecuteNonQuery()
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveData("InStaff")
        MessageBox.Show("saved")
        frmEmployee_Load(sender, e)
    End Sub

    Private Sub dtpWorkDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpWorkDate.ValueChanged
        dtpWorkDate.CustomFormat = "MM-dd-yyyy"
    End Sub

    Private Sub dgvEmp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmp.CellClick
        Dim i As Integer
        If dgvEmp.RowCount > 0 Then
            i = e.RowIndex
            If i < 0 Then
                Return
            End If
            Dim Row As DataGridViewRow = dgvEmp.Rows(i)
                Eid = Integer.Parse(Row.Cells(0).Value.ToString())
                txtID.Text = Eid
                txtName.Text = Row.Cells(1).Value.ToString()
                If Row.Cells(2).Value.ToString() = "F" Then
                    rdbFemale.Checked = True
                Else
                    rdbMale.Checked = True
                    dtpDOB.Text = Convert.ToDateTime(Row.Cells(3).Value).ToString("MM-dd-yyyy")
                    txtPosition.Text = Row.Cells(4).Value.ToString()
                    txtAddress.Text = Row.Cells(5).Value.ToString()
                    'format into currency
                    txtSalary.Text = String.Format("{0:C}", Row.Cells(6).Value)
                    dtpWorkDate.Text = Convert.ToDateTime(Row.Cells(7).Value).ToString("MM-dd-yyyy")
                txtPhone.Text = Row.Cells(8).Value.ToString()
                dtpDOB.CustomFormat = "MM-dd-yyyy"
                    dtpWorkDate.CustomFormat = "MM-dd-yyyy"
                    btnEdit.Enabled = True
                    btnDelete.Enabled = True
                End If
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Edit" Then
            EnableControl()
            btnNew.Text = "Cancel"
            btnEdit.Text = "Update"
        Else
            SaveData("UpStaff")
            MessageBox.Show("Updated")
            ClearText()
            btnNew.Text = "New"
            frmEmployee_Load(sender, e)
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
                com = New SqlCommand("DelStaff", cnn.sqlCon)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.AddWithValue("@ID", Eid)
                com.ExecuteNonQuery()
                ClearText()
                MessageBox.Show("Your record was deleted!!!", "Delete")
            Catch Ex As Exception
                MessageBox.Show(Ex.Message)
            End Try
        End If
        frmEmployee_Load(sender, e)
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
        search("GetByID")
        dgvEmp.DataSource = table
    End Sub
End Class