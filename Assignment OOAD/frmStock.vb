Imports System.Data.SqlClient
Imports System.Globalization
Public Class frmStock
    Dim DAdp As SqlDataAdapter
    Dim table As DataTable
    Dim DSet As DataSet
    Dim com As SqlCommand
    Dim cnn As New PhoneShop
    Dim Eid As Integer
    Dim str As String
    Private Sub frmStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvStockInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStockInfo.ClearSelection()
        dgvStockInfo.AllowUserToResizeRows = False
        dgvStockInfo.AllowUserToResizeColumns = False
        dgvStockInfo.MultiSelect = False
        'dgvProduct.Columns(0).Width = 30
        Try
            cnn.myCon()
            DSet = New DataSet()
            table = New DataTable
            DAdp = New SqlDataAdapter("SELECT * FROM tbStock", cnn.sqlCon)
            DAdp.Fill(DSet)
            dgvStockInfo.DataSource = DSet.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class