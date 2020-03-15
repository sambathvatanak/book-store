<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtImID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSubID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboCat = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtPID = New System.Windows.Forms.TextBox()
        Me.txtCatID = New System.Windows.Forms.TextBox()
        Me.txtImQty = New System.Windows.Forms.TextBox()
        Me.txtUPIS = New System.Windows.Forms.TextBox()
        Me.txtUPrice = New System.Windows.Forms.TextBox()
        Me.dtpImportDate = New System.Windows.Forms.DateTimePicker()
        Me.cboEName = New System.Windows.Forms.ComboBox()
        Me.cboSup = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtComName = New System.Windows.Forms.TextBox()
        Me.txtPName = New System.Windows.Forms.TextBox()
        Me.dgvImInfo = New System.Windows.Forms.DataGridView()
        CType(Me.dgvImInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 24)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Import ID"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtImID
        '
        Me.txtImID.Location = New System.Drawing.Point(145, 25)
        Me.txtImID.Multiline = True
        Me.txtImID.Name = "txtImID"
        Me.txtImID.Size = New System.Drawing.Size(141, 25)
        Me.txtImID.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Import Date"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 24)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Employee Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 24)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Employee ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEID
        '
        Me.txtEID.Location = New System.Drawing.Point(145, 118)
        Me.txtEID.Multiline = True
        Me.txtEID.Name = "txtEID"
        Me.txtEID.Size = New System.Drawing.Size(141, 25)
        Me.txtEID.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(325, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 24)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Supplier Name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(325, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 24)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Supplier ID"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSubID
        '
        Me.txtSubID.Location = New System.Drawing.Point(467, 56)
        Me.txtSubID.Multiline = True
        Me.txtSubID.Name = "txtSubID"
        Me.txtSubID.Size = New System.Drawing.Size(144, 25)
        Me.txtSubID.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(322, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 24)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Employee Position"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(467, 118)
        Me.txtPosition.Multiline = True
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(144, 25)
        Me.txtPosition.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(123, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 24)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Product Name"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 24)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Product ID"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboCat
        '
        Me.cboCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCat.FormattingEnabled = True
        Me.cboCat.Location = New System.Drawing.Point(241, 184)
        Me.cboCat.Name = "cboCat"
        Me.cboCat.Size = New System.Drawing.Size(97, 24)
        Me.cboCat.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(254, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 24)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Category"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(364, 157)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 24)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Category ID"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(473, 157)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 24)
        Me.Label12.TabIndex = 35
        Me.Label12.Tag = " "
        Me.Label12.Text = "Import Quantity"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(592, 157)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 24)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Unit Price in Stock"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(739, 157)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 24)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Unit Price"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(658, 24)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(96, 23)
        Me.btnNew.TabIndex = 41
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(658, 59)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 23)
        Me.btnSave.TabIndex = 42
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(658, 91)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 23)
        Me.btnExit.TabIndex = 43
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(456, 420)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 24)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Total Amount"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Location = New System.Drawing.Point(567, 419)
        Me.txtTotalAmount.Multiline = True
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(152, 25)
        Me.txtTotalAmount.TabIndex = 45
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(726, 262)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(95, 23)
        Me.btnRemove.TabIndex = 48
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(726, 224)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(95, 23)
        Me.btnAdd.TabIndex = 47
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtPID
        '
        Me.txtPID.Location = New System.Drawing.Point(15, 183)
        Me.txtPID.Multiline = True
        Me.txtPID.Name = "txtPID"
        Me.txtPID.Size = New System.Drawing.Size(90, 25)
        Me.txtPID.TabIndex = 49
        '
        'txtCatID
        '
        Me.txtCatID.AcceptsReturn = True
        Me.txtCatID.Location = New System.Drawing.Point(356, 183)
        Me.txtCatID.Multiline = True
        Me.txtCatID.Name = "txtCatID"
        Me.txtCatID.Size = New System.Drawing.Size(95, 25)
        Me.txtCatID.TabIndex = 50
        '
        'txtImQty
        '
        Me.txtImQty.Location = New System.Drawing.Point(469, 183)
        Me.txtImQty.Multiline = True
        Me.txtImQty.Name = "txtImQty"
        Me.txtImQty.Size = New System.Drawing.Size(106, 25)
        Me.txtImQty.TabIndex = 51
        '
        'txtUPIS
        '
        Me.txtUPIS.Location = New System.Drawing.Point(594, 183)
        Me.txtUPIS.Multiline = True
        Me.txtUPIS.Name = "txtUPIS"
        Me.txtUPIS.Size = New System.Drawing.Size(115, 25)
        Me.txtUPIS.TabIndex = 52
        '
        'txtUPrice
        '
        Me.txtUPrice.Location = New System.Drawing.Point(731, 183)
        Me.txtUPrice.Multiline = True
        Me.txtUPrice.Name = "txtUPrice"
        Me.txtUPrice.Size = New System.Drawing.Size(90, 25)
        Me.txtUPrice.TabIndex = 53
        '
        'dtpImportDate
        '
        Me.dtpImportDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpImportDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpImportDate.Location = New System.Drawing.Point(144, 57)
        Me.dtpImportDate.Name = "dtpImportDate"
        Me.dtpImportDate.Size = New System.Drawing.Size(142, 22)
        Me.dtpImportDate.TabIndex = 54
        '
        'cboEName
        '
        Me.cboEName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEName.FormattingEnabled = True
        Me.cboEName.Location = New System.Drawing.Point(144, 87)
        Me.cboEName.Name = "cboEName"
        Me.cboEName.Size = New System.Drawing.Size(142, 24)
        Me.cboEName.TabIndex = 55
        '
        'cboSup
        '
        Me.cboSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSup.FormattingEnabled = True
        Me.cboSup.Location = New System.Drawing.Point(467, 26)
        Me.cboSup.Name = "cboSup"
        Me.cboSup.Size = New System.Drawing.Size(142, 24)
        Me.cboSup.TabIndex = 56
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(322, 90)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(129, 24)
        Me.Label16.TabIndex = 58
        Me.Label16.Text = "Company Name"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtComName
        '
        Me.txtComName.Location = New System.Drawing.Point(467, 89)
        Me.txtComName.Multiline = True
        Me.txtComName.Name = "txtComName"
        Me.txtComName.Size = New System.Drawing.Size(144, 25)
        Me.txtComName.TabIndex = 57
        '
        'txtPName
        '
        Me.txtPName.Location = New System.Drawing.Point(126, 183)
        Me.txtPName.Multiline = True
        Me.txtPName.Name = "txtPName"
        Me.txtPName.Size = New System.Drawing.Size(90, 25)
        Me.txtPName.TabIndex = 59
        '
        'dgvImInfo
        '
        Me.dgvImInfo.AllowUserToAddRows = False
        Me.dgvImInfo.AllowUserToDeleteRows = False
        Me.dgvImInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvImInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvImInfo.Location = New System.Drawing.Point(15, 215)
        Me.dgvImInfo.Name = "dgvImInfo"
        Me.dgvImInfo.ReadOnly = True
        Me.dgvImInfo.RowHeadersVisible = False
        Me.dgvImInfo.Size = New System.Drawing.Size(695, 198)
        Me.dgvImInfo.TabIndex = 60
        '
        'frmImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 456)
        Me.Controls.Add(Me.dgvImInfo)
        Me.Controls.Add(Me.txtPName)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtComName)
        Me.Controls.Add(Me.cboSup)
        Me.Controls.Add(Me.cboEName)
        Me.Controls.Add(Me.dtpImportDate)
        Me.Controls.Add(Me.txtUPrice)
        Me.Controls.Add(Me.txtUPIS)
        Me.Controls.Add(Me.txtImQty)
        Me.Controls.Add(Me.txtCatID)
        Me.Controls.Add(Me.txtPID)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboCat)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSubID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtImID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmImport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmImport Information"
        CType(Me.dgvImInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtImID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSubID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboCat As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtPID As System.Windows.Forms.TextBox
    Friend WithEvents txtCatID As System.Windows.Forms.TextBox
    Friend WithEvents txtImQty As System.Windows.Forms.TextBox
    Friend WithEvents txtUPIS As System.Windows.Forms.TextBox
    Friend WithEvents txtUPrice As System.Windows.Forms.TextBox
    Friend WithEvents dtpImportDate As DateTimePicker
    Friend WithEvents cboEName As ComboBox
    Friend WithEvents cboSup As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtComName As TextBox
    Friend WithEvents txtPName As TextBox
    Friend WithEvents dgvImInfo As DataGridView
End Class
