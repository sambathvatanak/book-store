Imports System.Data.SqlClient
Imports System.Globalization
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmSale
    Dim DAdp As SqlDataAdapter
    Dim table As DataTable
    Dim DSet As DataSet
    Dim com As SqlCommand
    Dim cnn As New PhoneShop
    Dim Eid As Integer
    Dim str As String
    Dim UP As String
    Dim add As Double = 0
    Dim add_KH As Double = 0
    Dim Qty As String
    Dim Dis As Double
    Public Sub CloseControl()
        txtInvNo.Enabled = False
        txtEPos.Enabled = False
        cboEmp.Enabled = False
        txtSaleID.Enabled = False
        txtProID.Enabled = False
        txtProName.Enabled = False
        txtQty.Enabled = False
        txtDisp.Enabled = False
        txtTUS.Enabled = False
        txtTKH.Enabled = False
        txtChUS.Enabled = False
        txtChKH.Enabled = False
        txtCKH.Enabled = False
        txtCUS.Enabled = False
        txtDis.Enabled = False
        btnPrint.Enabled = False
    End Sub
    Public Sub EnableControl()
        txtInvNo.Enabled = True
        txtEPos.Enabled = True
        cboEmp.Enabled = True
        txtSaleID.Enabled = True
        txtProID.Enabled = True
        txtProName.Enabled = True
        txtQty.Enabled = True
        txtDisp.Enabled = True
        txtTUS.Enabled = True
        txtTKH.Enabled = True
        txtChUS.Enabled = True
        txtChKH.Enabled = True
        txtCKH.Enabled = True
        txtCUS.Enabled = True
        txtDis.Enabled = True
        btnPrint.Enabled = True
    End Sub
    Public Sub ClearText()
        txtInvNo.Text = ""
        txtEPos.Text = ""
        cboEmp.SelectedIndex = -1
        txtSaleID.Text = ""
        txtProID.Text = ""
        txtProName.Text = ""
        txtQty.Text = ""
        txtDisp.Text = ""
        txtTUS.Text = ""
        txtTKH.Text = ""
        txtChUS.Text = ""
        txtChKH.Text = ""
        txtCKH.Text = ""
        txtCUS.Text = ""
        txtDis.Text = ""
    End Sub
    Public Sub ClearMiniText()
        txtProID.Text = ""
        txtProName.Text = ""
        txtQty.Text = ""
        txtDisp.Text = ""
    End Sub

    Public Sub FillStaff()
        Try
            DAdp = New SqlDataAdapter("SELECT * FROM tbStaff", cnn.sqlCon)
            table = New DataTable()
            DAdp.Fill(table)
            cboEmp.DataSource = Nothing
            cboEmp.Items.Clear()
            cboEmp.DataSource = table
            cboEmp.DisplayMember = "Name"
            cboEmp.ValueMember = "ID"
            table = Nothing
            DAdp.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub frmSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn.myCon()
        CloseControl()
        dgvSale.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSale.AllowUserToResizeRows = False
        dgvSale.AllowUserToResizeColumns = False
        dgvSale.MultiSelect = False
        FillStaff()
        cboEmp.SelectedIndex = -1
        dgvSale.ColumnCount = 4
        dgvSale.Columns(0).Name = "Description"
        dgvSale.Columns(1).Name = "Quantity"
        dgvSale.Columns(2).Name = "Unit Price"
        dgvSale.Columns(3).Name = "Sub Total"
        Timer1.Enabled = True
    End Sub

    Private Sub cboEmp_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboEmp.SelectionChangeCommitted
        Dim staff As String = cboEmp.SelectedValue.ToString()
        'MessageBox.Show(staff)
        Try
            Dim Dreader As SqlDataReader
            com = New SqlCommand("SELECT Position FROM tbStaff WHERE ID LIKE '" + staff + "'", cnn.sqlCon)
            Dreader = com.ExecuteReader
            com = Nothing
            While Dreader.Read
                txtEPos.Text = Dreader("Position")
            End While
            Dreader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If btnExit.Text = "Exit" Then

        Else
            Dim btn As MessageBoxButtons = MessageBoxButtons.YesNo

            Dim ans As DialogResult
            ans = MessageBox.Show("តើអ្នកចង់បោះបង់ចោលឬទេ?", "បោះបង់", btn, MessageBoxIcon.Question)
            If ans = DialogResult.Yes Then
                ClearText()
                CloseControl()
                btnPrint.Enabled = False
                btnNew.Text = "New"
                btnNew.Enabled = True
                btnExit.Text = "Exit"
                ClearText()
            End If
            dgvSale.Rows.Clear()
        End If
    End Sub
    Public Sub UnitPrice()
        Dim PName As String = txtProName.Text
        Try
            Dim Dreader As SqlDataReader
            com = New SqlCommand("SELECT UnitPrice FROM tbProduct WHERE Name LIKE '" + PName + "'", cnn.sqlCon)
            Dreader = com.ExecuteReader
            com = Nothing
            While Dreader.Read
                UP = Dreader("UnitPrice")
            End While
            Dreader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub Pos()
        Dim staff As String = PhoneShop.EID
        'MessageBox.Show(staff)
        Try
            Dim Dreader As SqlDataReader
            com = New SqlCommand("SELECT Position FROM tbStaff WHERE ID LIKE '" + staff + "'", cnn.sqlCon)
            Dreader = com.ExecuteReader
            com = Nothing
            While Dreader.Read
                txtEPos.Text = Dreader("Position")
            End While
            Dreader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnNew_Click_1(sender As Object, e As EventArgs) Handles btnNew.Click
        If btnNew.Text = "New" Then
            str = "New"
            EnableControl()
            ClearText()
            'MessageBox.Show(PhoneShop.EName)
            cboEmp.SelectedValue = PhoneShop.EID
            Pos()
            btnPrint.Enabled = True
            txtInvNo.Select()
            btnNew.Text = "Add"
            btnExit.Text = "Cancel"
        Else
            UnitPrice()
            Dim SubTotal As Double
            Dim a As Double = UP
            'Dim b As Double = Qty
            Dim UTotal As Double
            Dim KTotal As Double
            'Dim Dis As Double
            If txtDisp.Text = "" Then
                SubTotal = txtQty.Text * a
                ' SubTotal = String.Format("{0:C2}", SubTotal)
                Dim row As String() = New String() {txtProName.Text, txtQty.Text, a, SubTotal}
                dgvSale.Rows.Add(row)
                Dim i As Integer = dgvSale.Rows.Count - 1
                Dim mul As Integer = 0
                Dim qty As Double = dgvSale(1, i).Value
                Dim UP As Double = dgvSale(2, i).Value
                mul = qty * UP
                add = add + mul
                UTotal = add
                KTotal = UTotal * 4000
                Dim kh As Double = mul * 4000
                add_KH = add_KH + kh
                txtTUS.Text = UTotal
                txtTKH.Text = KTotal
            Else
                Dim i As Integer = dgvSale.Rows.Count - 1
                Dim mul As Double = 0
                Dim qty As Double = txtQty.Text
                'Dim UP As Double = dgvSale(2, i).Value
                mul = a * qty
                Dis = txtDisp.Text
                Dim Discount As Double = Dis * mul / 100
                SubTotal = Discount
                ' SubTotal = String.Format("{0:C2}", SubTotal)
                Dim row As String() = New String() {txtProName.Text, txtQty.Text, a, SubTotal}
                dgvSale.Rows.Add(row)
                txtDis.Text=dis
                add = add + Discount
                UTotal = add
                KTotal = UTotal * 4000
                Dim kh As Double = mul * 4000
                add_KH = add_KH + KTotal
                txtTUS.Text = UTotal
                txtTKH.Text = KTotal
            End If
            'MessageBox.Show(add_KH)
            ClearMiniText()
            txtInvNo.Enabled = False
            Me.dgvSale.ClearSelection()
        End If
    End Sub

    Private Sub txtProID_KeyUp(sender As Object, e As KeyEventArgs) Handles txtProID.KeyUp
        Dim PID As String = txtProID.Text
        'MessageBox.Show(staff)
        Try
            Dim Dreader As SqlDataReader
            com = New SqlCommand("SELECT Name FROM tbProduct WHERE ID LIKE '" + PID + "'", cnn.sqlCon)
            Dreader = com.ExecuteReader
            com = Nothing
            While Dreader.Read
                txtProName.Text = Dreader("Name")
            End While
            Dreader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtCUS_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCUS.KeyUp
        If txtCUS.Text = "" Then
            txtChUS.Text = 0
        Else
            Dim CDollar As Double
            Double.TryParse(txtCUS.Text, CDollar)
            Dim total As Double = CDollar - add
            'MessageBox.Show(total)
            txtChKH.Text = 0
            txtCKH.Text = 0
            txtChUS.Text = total
        End If
    End Sub

    Private Sub txtCKH_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCKH.KeyUp
        If txtCKH.Text = "" Then
            txtChKH.Text = 0
        Else
            Dim CKH As Double
            Double.TryParse(txtCKH.Text, CKH)
            Dim total As Double = CKH - add_KH
            txtCUS.Text = 0
            txtChUS.Text = 0
            txtChKH.Text = total
        End If
    End Sub

    Private Sub txtCUS_Enter(sender As Object, e As EventArgs) Handles txtCUS.Enter
        txtCUS.Text = ""
    End Sub

    Private Sub txtCKH_Enter(sender As Object, e As EventArgs) Handles txtCKH.Enter
        txtCKH.Text = ""
    End Sub
    Public Sub SaveSale(x As String)
        ' Dim value As String
        'value = Decimal.Parse(txtSalary.Text, NumberStyles.Currency)
        Dim EName As String = cboEmp.GetItemText(cboEmp.Items(cboEmp.SelectedIndex))
        Try
            com = New SqlCommand(x, cnn.sqlCon)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.AddWithValue("@SID", txtInvNo.Text)
            com.Parameters.AddWithValue("@SDate", lblDate.Text)
            com.Parameters.AddWithValue("@EName", EName)
            com.Parameters.AddWithValue("@EPos", txtEPos.Text)
            com.Parameters.AddWithValue("@Total", txtTUS.Text)
            com.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub SaveSaleDetail(x As String)
        ' Dim value As String
        'value = Decimal.Parse(txtSalary.Text, NumberStyles.Currency)

        Dim EName As String = cboEmp.GetItemText(cboEmp.Items(cboEmp.SelectedIndex))
        Try
            For i As Integer = 0 To dgvSale.Rows.Count - 1
                Dim row As Integer = i
                com = New SqlCommand(x, cnn.sqlCon)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.AddWithValue("@InID", txtInvNo.Text)
                com.Parameters.AddWithValue("@Pname", dgvSale(0, i).Value)
                com.Parameters.AddWithValue("@PQTY", dgvSale(1, i).Value)
                com.Parameters.AddWithValue("@UnitPrice", dgvSale(2, i).Value)
                com.Parameters.AddWithValue("@SubTotal", dgvSale(0, i).Value)
                com.Parameters.AddWithValue("@TDollar", txtTUS.Text)
                com.Parameters.AddWithValue("@TRiel", txtTKH.Text)
                com.Parameters.AddWithValue("@CDollar", txtCUS.Text)
                com.Parameters.AddWithValue("@CRiel", txtCKH.Text)
                com.Parameters.AddWithValue("@CHDollar", txtChUS.Text)
                com.Parameters.AddWithValue("@CHRiel", txtChKH.Text)
                com.Parameters.AddWithValue("@DisPer", Dis.ToString)
                com.Parameters.AddWithValue("@Dis", txtDis.Text)
                com.Parameters.AddWithValue("@EName", EName)
                com.Parameters.AddWithValue("@SDate", lblDate.Text)
                com.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub SaveTempo(x As String)
        ' Dim value As String
        'value = Decimal.Parse(txtSalary.Text, NumberStyles.Currency)

        Dim EName As String = cboEmp.GetItemText(cboEmp.Items(cboEmp.SelectedIndex))
        Try
            For i As Integer = 0 To dgvSale.Rows.Count - 1
                Dim row As Integer = i
                com = New SqlCommand(x, cnn.sqlCon)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.AddWithValue("@InID", txtInvNo.Text)
                com.Parameters.AddWithValue("@Pname", dgvSale(0, i).Value)
                com.Parameters.AddWithValue("@PQTY", dgvSale(1, i).Value)
                com.Parameters.AddWithValue("@UnitPrice", dgvSale(2, i).Value)
                com.Parameters.AddWithValue("@SubTotal", dgvSale(3, i).Value)
                com.Parameters.AddWithValue("@TDollar", txtTUS.Text)
                com.Parameters.AddWithValue("@TRiel", txtTKH.Text)
                com.Parameters.AddWithValue("@CDollar", txtCUS.Text)
                com.Parameters.AddWithValue("@CRiel", txtCKH.Text)
                com.Parameters.AddWithValue("@CHDollar", txtChUS.Text)
                com.Parameters.AddWithValue("@CHRiel", txtChKH.Text)
                com.Parameters.AddWithValue("@DisPer", Dis.ToString)
                com.Parameters.AddWithValue("@Dis", txtDis.Text)
                com.Parameters.AddWithValue("@EName", EName)
                com.Parameters.AddWithValue("@SDate", lblDate.Text)
                com.Parameters.AddWithValue("@GTotal", txtTUS.Text)
                com.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub DelTempo()
        Try
            com = New SqlCommand("DelTempo", cnn.sqlCon)
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.AddWithValue("@InID", Eid)
            com.ExecuteNonQuery()
            ClearText()
            'MessageBox.Show("Your record was deleted!!!", "Delete")
        Catch Ex As Exception
            MessageBox.Show(Ex.Message)
        End Try
    End Sub
    'Public Sub Report()
    '    Dim sale As New rptSale
    '    Dim RV As New frmReport
    '    Dim dt As New DataTable

    '    Dim PH, add, TS As TextObject

    '    If sale.ReportDefinition.ReportObjects("InID") = Nothing Then
    '        PH = (TextObject)RE.ReportDefinition.ReportObjects("txtPhone")
    '            PH.Text = txtInvNo.Text.ToString().PadLeft(15, "0")
    '    End If


    '    If (RE.ReportDefinition.ReportObjects["txtAdd"] != null)
    '        {
    '            add = (TextObject)RE.ReportDefinition.ReportObjects["txtAdd"];
    '            add.Text = txtAddress.Text;
    '        }

    '        If (RE.ReportDefinition.ReportObjects["txtTS"] != null)
    '        {
    '            TS = (TextObject)RE.ReportDefinition.ReportObjects["txtTS"];
    '            TS.Text = String.Format("{0:C}", t);
    '        }

    '        //if (cr.ReportDefinition.ReportObjects["txtTotal"] != null)
    '        //{
    '        //    Total = (TextObject)cr.ReportDefinition.ReportObjects["txtTotal"];
    '        //    Total.Text = string.Format("{0:C}", t);
    '        //}
    '        RE.SetDataSource(dt);
    '        RV.CRViewer.ReportSource = RE;
    '        RV.CRViewer.Refresh();
    '        RV.Show();
    'End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        SaveSale("InSale")
        SaveSaleDetail("InSaledetail")
        SaveTempo("InTempo")
        'UpStock("UpNewStock")
        add = 0
        add_KH = 0
        Dim frm As New frmReport
        frm.Show()
        'DelTempo()
        'MessageBox.Show("Your record was saved")
        dgvSale.Rows.Clear()
        ClearText()
        btnExit.Enabled = True
        btnNew.Text = "New"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("dd-MM-yyyy")
        lblTime.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub cboEmp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmp.SelectedIndexChanged

    End Sub

    Private Sub cboEmp_Enter(sender As Object, e As EventArgs) Handles cboEmp.Enter

    End Sub
End Class