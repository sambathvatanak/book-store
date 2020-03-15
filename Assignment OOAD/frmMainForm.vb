Public Class frmMainForm
    Dim lblPro As New Label
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnProduct.Hide()
        btnImport.Hide()
        btnStock.Hide()
        btnSupplier.Hide()
        btnRptEmp.Hide()
        btnRptImp.Hide()
        btnRptSalehis.Hide()
        lblPro.Hide()
        picbackInven.Hide()
        picbackPro.Hide()
        picbackImp.Hide()
        picbackSup.Hide()
        picbackStock.Hide()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles pnlLogo.Paint

    End Sub

    Private Sub lblLogo_Click(sender As Object, e As EventArgs) Handles lblLogo.Click

    End Sub

    Private Sub pnlSide_Paint(sender As Object, e As PaintEventArgs) Handles pnlSide.Paint

    End Sub

    Private Sub lbl_Emp(sender As Object, e As EventArgs) Handles lblEmp.MouseHover
        lblEmp.BackColor = Color.FromArgb(105, 105, 105)
    End Sub

    Private Sub lblEmp_MouseLeave(sender As Object, e As EventArgs) Handles lblEmp.MouseLeave
        lblEmp.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub lblInventory_MouseHover(sender As Object, e As EventArgs) Handles lblInventory.MouseHover
        lblInventory.BackColor = Color.FromArgb(105, 105, 105)
    End Sub

    Private Sub lblInventory_MouseLeave(sender As Object, e As EventArgs) Handles lblInventory.MouseLeave
        lblInventory.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub lblSale_MouseHover(sender As Object, e As EventArgs) Handles lblSale.MouseHover
        lblSale.BackColor = Color.FromArgb(105, 105, 105)
    End Sub

    Private Sub lblSale_MouseLeave(sender As Object, e As EventArgs) Handles lblSale.MouseLeave
        lblSale.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub lblUser_MouseHover(sender As Object, e As EventArgs) Handles lblUser.MouseHover
        lblUser.BackColor = Color.FromArgb(105, 105, 105)
    End Sub

    Private Sub lblUser_MouseLeave(sender As Object, e As EventArgs) Handles lblUser.MouseLeave
        lblUser.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Close()
    End Sub

    Private Sub lblEmp_Click(sender As Object, e As EventArgs) Handles lblEmp.Click
        pnlSale.Hide()
        pnlInven.Hide()
        pnlStock.Hide()
        pnlUser.Hide()
        pnlReport.Hide()
        pnlImport.Hide()
        pnlProduct.Hide()
        pnlSupplier.Hide()
        pnlDashboard.Hide()
        pnlRptEmp.Hide()
        pnlRptImp.Hide()
        pnlRptSaleHistory.Hide()
        pnlEmp.Size = New Size(830, 465)
        pnlEmp.Location = New System.Drawing.Point(3, 1)
        pnlEmp.Show()
        Dim Emp As New frmEmployee
        Emp.TopLevel = False
        Emp.Parent = pnlEmp
        Emp.Show()
        lblTitle.Text = "Employee"
    End Sub

    Private Sub lblEmp_MouseMove(sender As Object, e As MouseEventArgs) Handles lblEmp.MouseMove
        '  lblEmp.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub lblInventory_Click(sender As Object, e As EventArgs) Handles lblInventory.Click
        frmInventory.Hide()
        pnlSale.Hide()
        pnlEmp.Hide()
        pnlStock.Hide()
        pnlUser.Hide()
        pnlReport.Hide()
        pnlImport.Hide()
        pnlProduct.Hide()
        pnlSupplier.Hide()
        pnlDashboard.Hide()
        pnlRptEmp.Hide()
        pnlRptImp.Hide()
        pnlRptSaleHistory.Hide()
        pnlInven.Size = New Size(830, 465)
        pnlInven.Location = New System.Drawing.Point(3, 1)
        pnlInven.Show()

        picbackInven.Parent = pnlInven
        picbackInven.Size = New Size(75, 31)
        picbackInven.Location = New System.Drawing.Point(0, 0)
        picbackInven.Show()
        btnRptEmp.Hide()
        btnRptImp.Hide()
        btnRptSalehis.Hide()

        btnProduct.Parent = pnlInven
        btnProduct.Size = New Size(239, 125)
        btnProduct.Location = New System.Drawing.Point(160, 68)
        btnProduct.Show()
        btnRptEmp.Hide()
        btnRptImp.Hide()
        btnRptSalehis.Hide()
        lblTitle.Text = "Product"


        'lblPro.Text = "Product"
        'lblPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'lblPro.Parent = pnlInven
        'lblPro.Size = New Size(239, 125)
        'lblPro.Location = New System.Drawing.Point(218, 208)
        'lblPro.Show()

        btnSupplier.Parent = pnlInven
        btnSupplier.Size = New Size(239, 125)
        btnSupplier.Location = New System.Drawing.Point(160, 250)
        btnSupplier.Show()
        lblTitle.Text = "Supplier"

        btnImport.Parent = pnlInven
        btnImport.Size = New Size(239, 125)
        btnImport.Location = New System.Drawing.Point(450, 68)
        btnImport.Show()
        lblTitle.Text = "Import"

        btnStock.Parent = pnlInven
        btnStock.Size = New Size(239, 125)
        btnStock.Location = New System.Drawing.Point(450, 250)
        btnStock.Show()
        lblTitle.Text = "Inventory"

    End Sub

    Private Sub lblSale_Click(sender As Object, e As EventArgs) Handles lblSale.Click
        pnlEmp.Hide()
        pnlStock.Hide()
        pnlUser.Hide()
        pnlReport.Hide()
        pnlImport.Hide()
        pnlProduct.Hide()
        pnlSupplier.Hide()
        pnlDashboard.Hide()
        pnlRptEmp.Hide()
        pnlRptImp.Hide()
        pnlRptSaleHistory.Hide()
        pnlSale.Size = New Size(830, 465)
        pnlSale.Location = New System.Drawing.Point(3, 1)
        pnlSale.Show()
        Dim sale As New frmSale
        sale.TopLevel = False
        sale.Parent = pnlSale
        sale.Show()
        lblTitle.Text = "Sale"
    End Sub

    Private Sub lblStock_Click(sender As Object, e As EventArgs)
        lblTitle.Text = "Stock"
    End Sub

    Private Sub lblUser_Click(sender As Object, e As EventArgs) Handles lblUser.Click
        pnlEmp.Hide()
        pnlStock.Hide()
        pnlReport.Hide()
        pnlImport.Hide()
        pnlProduct.Hide()
        pnlSupplier.Hide()
        pnlDashboard.Hide()
        pnlRptEmp.Hide()
        pnlRptImp.Hide()
        pnlRptSaleHistory.Hide()
        pnlUser.Size = New Size(830, 465)
        pnlUser.Location = New System.Drawing.Point(3, 1)
        pnlUser.Show()
        Dim user As New frmUserAcc
        user.TopLevel = False
        user.Parent = pnlUser
        user.Show()
        lblTitle.Text = "User Account"
    End Sub

    Private Sub lblReport_Click(sender As Object, e As EventArgs) Handles lblReport.Click
        pnlSale.Hide()
        pnlEmp.Hide()
        pnlStock.Hide()
        pnlUser.Hide()
        pnlReport.Hide()
        pnlImport.Hide()
        pnlProduct.Hide()
        pnlSupplier.Hide()
        pnlDashboard.Hide()
        pnlRptEmp.Hide()
        pnlRptImp.Hide()
        pnlRptSaleHistory.Hide()
        pnlReport.Size = New Size(830, 465)
        pnlReport.Location = New System.Drawing.Point(3, 1)
        pnlReport.Show()

        btnRptEmp.Parent = pnlReport
        btnRptEmp.Size = New Size(239, 125)
        btnRptEmp.Location = New System.Drawing.Point(160, 68)
        btnRptEmp.Show()
        lblTitle.Text = "Product"

        btnRptSalehis.Parent = pnlReport
        btnRptSalehis.Size = New Size(239, 125)
        btnRptSalehis.Location = New System.Drawing.Point(160, 250)
        btnRptSalehis.Show()

        btnRptImp.Parent = pnlReport
        btnRptImp.Size = New Size(239, 125)
        btnRptImp.Location = New System.Drawing.Point(450, 68)
        btnRptImp.Show()

    End Sub

    Private Sub lblEmp_Leave(sender As Object, e As EventArgs) Handles lblEmp.Leave
        lblEmp.BackColor = Color.DarkSlateGray
    End Sub




    Private Sub lblDashboard_Click(sender As Object, e As EventArgs) Handles lblDashboard.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        lblTitle.Text = "Employee"
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles ptcHome0.Click

    End Sub

    Private Sub btnProduct_Click(sender As Object, e As EventArgs)


        lblTitle.Text = "Employee"
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles ptcHome0.MouseHover
        ptcHome0.BackColor = Color.FromArgb(105, 105, 105)
    End Sub

    Private Sub pnlHeader_Paint(sender As Object, e As PaintEventArgs) Handles pnlHeader.Paint

    End Sub

    Private Sub pnlProduct_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub pnlImport_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Sale_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Stock_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub pnlDashboard_Paint(sender As Object, e As PaintEventArgs) Handles pnlDashboard.Paint

    End Sub

    Private Sub pnlInven_Paint(sender As Object, e As PaintEventArgs) Handles pnlInven.Paint

    End Sub

    Private Sub pnlProduct_Click(sender As Object, e As EventArgs) Handles pnlProduct.Click
        pnlSale.Hide()
        pnlInven.Hide()
        pnlStock.Hide()
        pnlUser.Hide()
        pnlReport.Hide()
        pnlImport.Hide()
        pnlProduct.Hide()
        pnlSupplier.Hide()
        pnlDashboard.Hide()
        pnlRptEmp.Hide()
        pnlRptImp.Hide()
        pnlRptSaleHistory.Hide()
        frmProduct.Size = New Size(830, 465)
        frmProduct.Location = New System.Drawing.Point(3, 1)
        frmProduct.Show()
    End Sub

    Private Sub pnlMain_Paint_1(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub

    Private Sub pnlSupplier_Paint(sender As Object, e As PaintEventArgs) Handles pnlSupplier.Paint

    End Sub

    Private Sub btnProduct_Click_1(sender As Object, e As EventArgs) Handles btnProduct.Click

        frmInventory.Hide()
        pnlSale.Hide()
        pnlEmp.Hide()
        pnlStock.Hide()
        pnlUser.Hide()
        pnlReport.Hide()
        pnlImport.Hide()
        pnlProduct.Hide()
        pnlSupplier.Hide()
        pnlDashboard.Hide()
        pnlRptEmp.Hide()
        pnlRptImp.Hide()
        pnlRptSaleHistory.Hide()
        pnlInven.Show()
        btnProduct.Hide()
        btnImport.Hide()
        btnSupplier.Hide()
        btnStock.Hide()
        picbackInven.Hide()

        pnlProduct.Parent = pnlInven
        pnlProduct.Size = New Size(830, 465)
        pnlProduct.Location = New System.Drawing.Point(0, 0)
        pnlProduct.Show()

        picbackPro.Parent = pnlProduct
        picbackPro.Size = New Size(60, 25)
        picbackPro.Location = New System.Drawing.Point(0, 0)
        picbackPro.Show()
        btnRptEmp.Hide()
        btnRptImp.Hide()
        btnRptSalehis.Hide()

        Dim pro As New frmProduct
        pro.TopLevel = False
        pro.Parent = pnlProduct
        pro.Show()
        btnRptEmp.Hide()
        btnRptImp.Hide()
        btnRptSalehis.Hide()

        'btnSupplier.Parent = pnlInven
        'btnSupplier.Size = New Size(239, 125)
        'btnSupplier.Location = New System.Drawing.Point(160, 250)
        'btnSupplier.Show()
        'lblTitle.Text = "Supplier"



        'btnImport.Parent = pnlInven
        'btnImport.Size = New Size(239, 125)
        'btnImport.Location = New System.Drawing.Point(450, 68)
        'btnImport.Show()
        'lblTitle.Text = "Import"

        'btnStock.Parent = pnlInven
        'btnStock.Size = New Size(239, 125)
        'btnStock.Location = New System.Drawing.Point(450, 250)
        'btnStock.Show()
        'lblTitle.Text = "Inventory"

        'Dim pro As New frmProduct
        'picbackInven.Hide()
        'pro.TopLevel = False
        'pro.Parent = pnlInven
        'pro.Show()
        'btnProduct.Hide()
        'btnImport.Hide()
        'btnSupplier.Hide()
        'btnStock.Hide()

        'picbackPro.Parent = pnlInven
        'picbackPro.Size = New Size(75, 31)
        'picbackPro.Location = New System.Drawing.Point(2, 4)
        'picbackPro.Show()
        'btnRptImp.Hide()
        'btnRptSalehis.Hide()





    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        picbackImp.Show()
        frmInventory.Hide()
        pnlSale.Hide()
        pnlEmp.Hide()
        pnlStock.Hide()
        pnlUser.Hide()
        pnlReport.Hide()
        pnlProduct.Hide()
        pnlSupplier.Hide()
        pnlDashboard.Hide()
        pnlRptEmp.Hide()
        pnlRptImp.Hide()
        pnlRptSaleHistory.Hide()
        pnlInven.Show()
        btnProduct.Hide()
        btnImport.Hide()
        btnSupplier.Hide()
        btnStock.Hide()
        picbackInven.Hide()

        pnlImport.Parent = pnlInven
        pnlImport.Size = New Size(830, 465)
        pnlImport.Location = New System.Drawing.Point(0, 0)
        pnlImport.Show()

        picbackImp.Parent = pnlImport
        picbackImp.Size = New Size(60, 25)
        picbackImp.Location = New System.Drawing.Point(0, 0)
        picbackImp.Show()
        btnRptEmp.Hide()
        btnRptImp.Hide()
        btnRptSalehis.Hide()

        Dim Imp As New frmImport
        Imp.TopLevel = False
        Imp.Parent = pnlImport
        Imp.Show()
        btnRptEmp.Hide()
        btnRptImp.Hide()
        btnRptSalehis.Hide()

        'Dim Imp As New frmImport
        'Imp.TopLevel = False
        'Imp.Parent = pnlInven
        'Imp.Show()
        'btnProduct.Hide()
        'btnImport.Hide()
        'btnSupplier.Hide()
        'btnStock.Hide()
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        picbackSup.Show()
        frmInventory.Hide()
        pnlSale.Hide()
        pnlEmp.Hide()
        pnlStock.Hide()
        pnlUser.Hide()
        pnlReport.Hide()
        pnlProduct.Hide()
        pnlSupplier.Hide()
        pnlRptEmp.Hide()
        pnlRptImp.Hide()
        pnlRptSaleHistory.Hide()
        pnlInven.Show()
        btnProduct.Hide()
        btnImport.Hide()
        btnSupplier.Hide()
        btnStock.Hide()
        picbackInven.Hide()

        pnlSupplier.Parent = pnlInven
        pnlSupplier.Size = New Size(830, 465)
        pnlSupplier.Location = New System.Drawing.Point(0, 0)
        pnlSupplier.Show()

        picbackSup.Parent = pnlSupplier
        picbackSup.Size = New Size(60, 25)
        picbackSup.Location = New System.Drawing.Point(0, 0)
        picbackSup.Show()
        btnRptEmp.Hide()
        btnRptImp.Hide()
        btnRptSalehis.Hide()

        Dim sup As New frmSupplier
        sup.TopLevel = False
        sup.Parent = pnlSupplier
        sup.Show()
        btnRptEmp.Hide()
        btnRptImp.Hide()
        btnRptSalehis.Hide()

        'Dim Sup As New frmSupplier
        'Sup.TopLevel = False
        'Sup.Parent = pnlInven
        'Sup.Show()
        'btnProduct.Hide()
        'btnImport.Hide()
        'btnSupplier.Hide()
        'btnStock.Hide()
    End Sub

    Private Sub btnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        picbackStock.Show()
        frmInventory.Hide()
        pnlSale.Hide()
        pnlEmp.Hide()
        pnlUser.Hide()
        pnlReport.Hide()
        pnlProduct.Hide()
        pnlSupplier.Hide()
        pnlRptEmp.Hide()
        pnlRptImp.Hide()
        pnlRptSaleHistory.Hide()
        pnlInven.Show()
        btnProduct.Hide()
        btnImport.Hide()
        btnSupplier.Hide()
        btnStock.Hide()
        picbackInven.Hide()

        pnlStock.Parent = pnlInven
        pnlStock.Size = New Size(830, 465)
        pnlStock.Location = New System.Drawing.Point(0, 0)
        pnlStock.Show()

        picbackStock.Parent = pnlStock
        picbackStock.Size = New Size(60, 25)
        picbackStock.Location = New System.Drawing.Point(0, 0)
        picbackStock.Show()
        btnRptEmp.Hide()
        btnRptImp.Hide()
        btnRptSalehis.Hide()

        Dim stock As New frmStock
        stock.TopLevel = False
        stock.Parent = pnlStock
        stock.Show()
        btnRptEmp.Hide()
        btnRptImp.Hide()
        btnRptSalehis.Hide()

        'Dim Stock As New frmStock
        'Stock.TopLevel = False
        'Stock.Parent = pnlInven
        'Stock.Show()
        'btnProduct.Hide()
        'btnImport.Hide()
        'btnSupplier.Hide()
        'btnStock.Hide()
    End Sub

    Private Sub btnRptEmp_Click(sender As Object, e As EventArgs) Handles btnRptEmp.Click
        Dim r As New frmReport
        r.Show()
    End Sub

    Private Sub btnRptImp_Click(sender As Object, e As EventArgs) Handles btnRptImp.Click

    End Sub

    Private Sub picImp2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub picBackPro_Click(sender As Object, e As EventArgs)
        pnlInven.Show()

    End Sub

    Private Sub picbackPro_Click_1(sender As Object, e As EventArgs) Handles picbackPro.Click
        frmInventory.Hide()
        pnlSale.Hide()
        pnlEmp.Hide()
        pnlStock.Hide()
        pnlUser.Hide()
        pnlReport.Hide()
        pnlImport.Hide()
        pnlProduct.Hide()
        pnlSupplier.Hide()
        pnlDashboard.Hide()
        pnlRptEmp.Hide()
        pnlRptImp.Hide()
        pnlRptSaleHistory.Hide()
        pnlInven.Size = New Size(830, 465)
        pnlInven.Location = New System.Drawing.Point(3, 1)
        pnlInven.Show()

        picbackInven.Parent = pnlInven
        picbackInven.Size = New Size(75, 31)
        picbackInven.Location = New System.Drawing.Point(2, 4)
        picbackInven.Show()
        btnRptEmp.Hide()
        btnRptImp.Hide()
        btnRptSalehis.Hide()

        btnProduct.Parent = pnlInven
        btnProduct.Size = New Size(239, 125)
        btnProduct.Location = New System.Drawing.Point(160, 68)
        btnProduct.Show()
        btnRptEmp.Hide()
        btnRptImp.Hide()
        btnRptSalehis.Hide()
        lblTitle.Text = "Product"


        'lblPro.Text = "Product"
        'lblPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'lblPro.Parent = pnlInven
        'lblPro.Size = New Size(239, 125)
        'lblPro.Location = New System.Drawing.Point(218, 208)
        'lblPro.Show()

        btnSupplier.Parent = pnlInven
        btnSupplier.Size = New Size(239, 125)
        btnSupplier.Location = New System.Drawing.Point(160, 250)
        btnSupplier.Show()
        lblTitle.Text = "Supplier"

        btnImport.Parent = pnlInven
        btnImport.Size = New Size(239, 125)
        btnImport.Location = New System.Drawing.Point(450, 68)
        btnImport.Show()
        lblTitle.Text = "Import"

        btnStock.Parent = pnlInven
        btnStock.Size = New Size(239, 125)
        btnStock.Location = New System.Drawing.Point(450, 250)
        btnStock.Show()
        lblTitle.Text = "Inventory"
    End Sub

    Private Sub picbackInven_Click(sender As Object, e As EventArgs) Handles picbackInven.Click

    End Sub

    Private Sub picbackImp_Click(sender As Object, e As EventArgs) Handles picbackImp.Click
        frmInventory.Hide()
        pnlSale.Hide()
        pnlEmp.Hide()
        pnlStock.Hide()
        pnlUser.Hide()
        pnlReport.Hide()
        pnlImport.Hide()
        pnlProduct.Hide()
        pnlSupplier.Hide()
        pnlDashboard.Hide()
        pnlRptEmp.Hide()
        pnlRptImp.Hide()
        pnlRptSaleHistory.Hide()
        pnlInven.Size = New Size(830, 465)
        pnlInven.Location = New System.Drawing.Point(3, 1)
        pnlInven.Show()

        picbackImp.Parent = pnlInven
        picbackImp.Size = New Size(75, 31)
        picbackImp.Location = New System.Drawing.Point(2, 4)
         picbackImp.Show()
        btnRptEmp.Hide()
        btnRptImp.Hide()
        btnRptSalehis.Hide()

        btnProduct.Parent = pnlInven
        btnProduct.Size = New Size(239, 125)
        btnProduct.Location = New System.Drawing.Point(160, 68)
        btnProduct.Show()
        btnRptEmp.Hide()
        btnRptImp.Hide()
        btnRptSalehis.Hide()
        lblTitle.Text = "Product"


        'lblPro.Text = "Product"
        'lblPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'lblPro.Parent = pnlInven
        'lblPro.Size = New Size(239, 125)
        'lblPro.Location = New System.Drawing.Point(218, 208)
        'lblPro.Show()

        btnSupplier.Parent = pnlInven
        btnSupplier.Size = New Size(239, 125)
        btnSupplier.Location = New System.Drawing.Point(160, 250)
        btnSupplier.Show()
        lblTitle.Text = "Supplier"

        btnImport.Parent = pnlInven
        btnImport.Size = New Size(239, 125)
        btnImport.Location = New System.Drawing.Point(450, 68)
        btnImport.Show()
        lblTitle.Text = "Import"

        btnStock.Parent = pnlInven
        btnStock.Size = New Size(239, 125)
        btnStock.Location = New System.Drawing.Point(450, 250)
        btnStock.Show()
        lblTitle.Text = "Inventory"
    End Sub

    Private Sub picbackSup_Click(sender As Object, e As EventArgs) Handles picbackSup.Click
         frmInventory.Hide()
        pnlSale.Hide()
        pnlEmp.Hide()
        pnlStock.Hide()
        pnlUser.Hide()
        pnlReport.Hide()
        pnlImport.Hide()
        pnlProduct.Hide()
        pnlSupplier.Hide()
        pnlDashboard.Hide()
        pnlRptEmp.Hide()
        pnlRptImp.Hide()
        pnlRptSaleHistory.Hide()
        pnlInven.Size = New Size(830, 465)
        pnlInven.Location = New System.Drawing.Point(3, 1)
        pnlInven.Show()

        picbackSup.Parent = pnlInven
        picbackSup.Size = New Size(75, 31)
        picbackSup.Location = New System.Drawing.Point(2, 4)
        picbackSup.Show()
        picbackSup.Hide()
        btnRptImp.Hide()
        btnRptSalehis.Hide()

        btnProduct.Parent = pnlInven
        btnProduct.Size = New Size(239, 125)
        btnProduct.Location = New System.Drawing.Point(160, 68)
        btnProduct.Show()
        btnRptEmp.Hide()
        btnRptImp.Hide()
        btnRptSalehis.Hide()
        lblTitle.Text = "Product"


        'lblPro.Text = "Product"
        'lblPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'lblPro.Parent = pnlInven
        'lblPro.Size = New Size(239, 125)
        'lblPro.Location = New System.Drawing.Point(218, 208)
        'lblPro.Show()

        btnSupplier.Parent = pnlInven
        btnSupplier.Size = New Size(239, 125)
        btnSupplier.Location = New System.Drawing.Point(160, 250)
        btnSupplier.Show()
        lblTitle.Text = "Supplier"

        btnImport.Parent = pnlInven
        btnImport.Size = New Size(239, 125)
        btnImport.Location = New System.Drawing.Point(450, 68)
        btnImport.Show()
        lblTitle.Text = "Import"

        btnStock.Parent = pnlInven
        btnStock.Size = New Size(239, 125)
        btnStock.Location = New System.Drawing.Point(450, 250)
        btnStock.Show()
        lblTitle.Text = "Inventory"

    End Sub
    Private Sub picbackStock_Click(sender As Object, e As EventArgs) Handles picbackStock.Click
        frmInventory.Hide()
        pnlSale.Hide()
        pnlEmp.Hide()
        pnlStock.Hide()
        pnlUser.Hide()
        pnlReport.Hide()
        pnlImport.Hide()
        pnlProduct.Hide()
        pnlSupplier.Hide()
        pnlDashboard.Hide()
        pnlRptEmp.Hide()
        pnlRptImp.Hide()
        pnlRptSaleHistory.Hide()
        pnlInven.Size = New Size(830, 465)
        pnlInven.Location = New System.Drawing.Point(3, 1)
        pnlInven.Show()

        picbackStock.Parent = pnlInven
        picbackStock.Size = New Size(75, 31)
        picbackStock.Location = New System.Drawing.Point(2, 4)
        picbackStock.Show()
        btnRptEmp.Hide()
        btnRptImp.Hide()
        btnRptSalehis.Hide()

        btnProduct.Parent = pnlInven
        btnProduct.Size = New Size(239, 125)
        btnProduct.Location = New System.Drawing.Point(160, 68)
        btnProduct.Show()
        btnRptEmp.Hide()
        btnRptImp.Hide()
        btnRptSalehis.Hide()
        lblTitle.Text = "Product"


        'lblPro.Text = "Product"
        'lblPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'lblPro.Parent = pnlInven
        'lblPro.Size = New Size(239, 125)
        'lblPro.Location = New System.Drawing.Point(218, 208)
        'lblPro.Show()

        btnSupplier.Parent = pnlInven
        btnSupplier.Size = New Size(239, 125)
        btnSupplier.Location = New System.Drawing.Point(160, 250)
        btnSupplier.Show()
        lblTitle.Text = "Supplier"

        btnImport.Parent = pnlInven
        btnImport.Size = New Size(239, 125)
        btnImport.Location = New System.Drawing.Point(450, 68)
        btnImport.Show()
        lblTitle.Text = "Import"

        btnStock.Parent = pnlInven
        btnStock.Size = New Size(239, 125)
        btnStock.Location = New System.Drawing.Point(450, 250)
        btnStock.Show()
        lblTitle.Text = "Inventory"
    End Sub
End Class
