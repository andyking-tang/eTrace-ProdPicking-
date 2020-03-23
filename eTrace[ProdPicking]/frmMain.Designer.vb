<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits eTraceUI.eTraceForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim TimerStatus1 As eTraceUI.TimerStatus = New eTraceUI.TimerStatus()
        Me.pnlBody = New eTraceUI.eTracePanel()
        Me.grpOption = New eTraceUI.eTraceGroupBox()
        Me.ETraceTableLayoutPanel1 = New eTraceUI.eTraceTableLayoutPanel()
        Me.btnAdd = New eTraceUI.eTraceButton()
        Me.btnDownload = New eTraceUI.eTraceButton()
        Me.btnSelectTmp = New eTraceUI.eTraceButton()
        Me.btnExcelUpload = New eTraceUI.eTraceButton()
        Me.btnTO = New eTraceUI.eTraceButton()
        Me.ETracePanel1 = New eTraceUI.eTracePanel()
        Me.grpItemdetails = New eTraceUI.eTraceGroupBox()
        Me.dgvItemDetails = New eTraceUI.eTraceDataGridView()
        Me.Material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Revision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Manufacturer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManufacturerPN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PerQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReqQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvlQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PickedQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Shortage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Forming = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpItems = New eTraceUI.eTraceGroupBox()
        Me.dgvItem = New eTraceUI.eTraceDataGridView()
        Me.PONumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelPCBA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssueQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpProcess = New eTraceUI.eTraceGroupBox()
        Me.tblProcess = New eTraceUI.eTraceTableLayoutPanel()
        Me.lblProcess = New eTraceUI.eTraceLabel()
        Me.ddlProcess = New eTraceUI.eTraceComboBox()
        Me.btnCancel = New eTraceUI.eTraceButton()
        Me.grpActions = New eTraceUI.eTraceGroupBox()
        Me.tblActions = New eTraceUI.eTraceTableLayoutPanel()
        Me.btnExcel = New eTraceUI.eTraceButton()
        Me.btnSave = New eTraceUI.eTraceButton()
        Me.lblPDTO = New eTraceUI.eTraceLabel()
        Me.txtPDTO = New eTraceUI.eTraceTextBox()
        Me.btnPost = New eTraceUI.eTraceButton()
        Me.btnCloseTO = New eTraceUI.eTraceButton()
        Me.btnReset = New eTraceUI.eTraceButton()
        Me.btnUnlock = New eTraceUI.eTraceButton()
        Me.grpInput = New eTraceUI.eTraceGroupBox()
        Me.tblInput = New eTraceUI.eTraceTableLayoutPanel()
        Me.lblPO = New eTraceUI.eTraceLabel()
        Me.txtProdOrderNo = New eTraceUI.eTraceTextBox()
        Me.txtIssueQty = New eTraceUI.eTraceTextBox()
        Me.lblIssueQty = New eTraceUI.eTraceLabel()
        Me.lblProdFloor = New eTraceUI.eTraceLabel()
        Me.txtProdFloor = New eTraceUI.eTraceTextBox()
        Me.txtETA = New System.Windows.Forms.DateTimePicker()
        Me.lblETA = New eTraceUI.eTraceLabel()
        Me.txtProdLine = New eTraceUI.eTraceTextBox()
        Me.lblProdLine = New eTraceUI.eTraceLabel()
        Me.ddlSupplyType = New eTraceUI.eTraceComboBox()
        Me.lblSupplyType = New eTraceUI.eTraceLabel()
        Me.ddlReason = New eTraceUI.eTraceComboBox()
        Me.lblReason = New eTraceUI.eTraceLabel()
        Me.ddlStatus = New eTraceUI.eTraceComboBox()
        Me.lblStatus = New eTraceUI.eTraceLabel()
        Me.lblMakeBuy = New eTraceUI.eTraceLabel()
        Me.ddlMakeBuy = New eTraceUI.eTraceComboBox()
        Me.lblSubInv = New eTraceUI.eTraceLabel()
        Me.ddlSubInv = New eTraceUI.eTraceComboBox()
        Me.pnlBody.SuspendLayout()
        Me.grpOption.SuspendLayout()
        Me.ETraceTableLayoutPanel1.SuspendLayout()
        Me.ETracePanel1.SuspendLayout()
        Me.grpItemdetails.SuspendLayout()
        CType(Me.dgvItemDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpItems.SuspendLayout()
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProcess.SuspendLayout()
        Me.tblProcess.SuspendLayout()
        Me.grpActions.SuspendLayout()
        Me.tblActions.SuspendLayout()
        Me.grpInput.SuspendLayout()
        Me.tblInput.SuspendLayout()
        Me.SuspendLayout()
        '
        'MessageBar1
        '
        Me.MessageBar1.Location = New System.Drawing.Point(0, 675)
        Me.MessageBar1.Size = New System.Drawing.Size(1028, 22)
        '
        'pnlBody
        '
        Me.pnlBody.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBody.Controls.Add(Me.grpOption)
        Me.pnlBody.Controls.Add(Me.ETracePanel1)
        Me.pnlBody.Controls.Add(Me.grpItems)
        Me.pnlBody.Controls.Add(Me.grpProcess)
        Me.pnlBody.Controls.Add(Me.grpActions)
        Me.pnlBody.Controls.Add(Me.grpInput)
        Me.pnlBody.Location = New System.Drawing.Point(1, 40)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(1027, 617)
        Me.pnlBody.TabIndex = 3
        '
        'grpOption
        '
        Me.grpOption.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpOption.Controls.Add(Me.ETraceTableLayoutPanel1)
        Me.grpOption.Location = New System.Drawing.Point(5, 151)
        Me.grpOption.Name = "grpOption"
        Me.grpOption.Size = New System.Drawing.Size(1019, 51)
        Me.grpOption.TabIndex = 4
        Me.grpOption.TabStop = False
        Me.grpOption.Tag = "^APP-13@"
        Me.grpOption.Text = "Options"
        '
        'ETraceTableLayoutPanel1
        '
        Me.ETraceTableLayoutPanel1.ColumnCount = 7
        Me.ETraceTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.ETraceTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.ETraceTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.ETraceTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.ETraceTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.ETraceTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.ETraceTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 541.0!))
        Me.ETraceTableLayoutPanel1.Controls.Add(Me.btnAdd, 0, 0)
        Me.ETraceTableLayoutPanel1.Controls.Add(Me.btnDownload, 1, 0)
        Me.ETraceTableLayoutPanel1.Controls.Add(Me.btnSelectTmp, 3, 0)
        Me.ETraceTableLayoutPanel1.Controls.Add(Me.btnExcelUpload, 4, 0)
        Me.ETraceTableLayoutPanel1.Controls.Add(Me.btnTO, 6, 0)
        Me.ETraceTableLayoutPanel1.Location = New System.Drawing.Point(4, 13)
        Me.ETraceTableLayoutPanel1.Name = "ETraceTableLayoutPanel1"
        Me.ETraceTableLayoutPanel1.RowCount = 1
        Me.ETraceTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ETraceTableLayoutPanel1.Size = New System.Drawing.Size(1021, 32)
        Me.ETraceTableLayoutPanel1.TabIndex = 4
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAdd.AutoSize = True
        Me.btnAdd.Location = New System.Drawing.Point(3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(70, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Tag = "^APP-33@"
        Me.btnAdd.Text = "Validate"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDownload
        '
        Me.btnDownload.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnDownload.AutoSize = True
        Me.btnDownload.Location = New System.Drawing.Point(79, 4)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(141, 23)
        Me.btnDownload.TabIndex = 13
        Me.btnDownload.Tag = "^MMC-41@"
        Me.btnDownload.Text = "Download item list from DJ"
        Me.btnDownload.UseVisualStyleBackColor = True
        '
        'btnSelectTmp
        '
        Me.btnSelectTmp.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnSelectTmp.AutoSize = True
        Me.btnSelectTmp.Location = New System.Drawing.Point(226, 4)
        Me.btnSelectTmp.Name = "btnSelectTmp"
        Me.btnSelectTmp.Size = New System.Drawing.Size(105, 23)
        Me.btnSelectTmp.TabIndex = 8
        Me.btnSelectTmp.Tag = "^APP-34@"
        Me.btnSelectTmp.Text = "Select Template"
        Me.btnSelectTmp.UseVisualStyleBackColor = True
        '
        'btnExcelUpload
        '
        Me.btnExcelUpload.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnExcelUpload.AutoSize = True
        Me.btnExcelUpload.Location = New System.Drawing.Point(337, 4)
        Me.btnExcelUpload.Name = "btnExcelUpload"
        Me.btnExcelUpload.Size = New System.Drawing.Size(140, 23)
        Me.btnExcelUpload.TabIndex = 25
        Me.btnExcelUpload.Tag = "^MMC-153@"
        Me.btnExcelUpload.Text = "Upload item list from Excel"
        Me.btnExcelUpload.UseVisualStyleBackColor = True
        '
        'btnTO
        '
        Me.btnTO.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnTO.AutoSize = True
        Me.btnTO.Location = New System.Drawing.Point(483, 4)
        Me.btnTO.Name = "btnTO"
        Me.btnTO.Size = New System.Drawing.Size(100, 23)
        Me.btnTO.TabIndex = 14
        Me.btnTO.Tag = "^MMC-44@"
        Me.btnTO.Text = "Select Pick Order"
        Me.btnTO.UseVisualStyleBackColor = True
        '
        'ETracePanel1
        '
        Me.ETracePanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ETracePanel1.Controls.Add(Me.grpItemdetails)
        Me.ETracePanel1.Location = New System.Drawing.Point(3, 314)
        Me.ETracePanel1.Name = "ETracePanel1"
        Me.ETracePanel1.Size = New System.Drawing.Size(1018, 243)
        Me.ETracePanel1.TabIndex = 5
        '
        'grpItemdetails
        '
        Me.grpItemdetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpItemdetails.Controls.Add(Me.dgvItemDetails)
        Me.grpItemdetails.Location = New System.Drawing.Point(6, 6)
        Me.grpItemdetails.Name = "grpItemdetails"
        Me.grpItemdetails.Size = New System.Drawing.Size(1007, 231)
        Me.grpItemdetails.TabIndex = 2
        Me.grpItemdetails.TabStop = False
        Me.grpItemdetails.Tag = "^APP-35@"
        Me.grpItemdetails.Text = "Item details"
        '
        'dgvItemDetails
        '
        Me.dgvItemDetails.AllowUserToResizeRows = False
        Me.dgvItemDetails.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvItemDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItemDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvItemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvItemDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Material, Me.Revision, Me.Manufacturer, Me.ManufacturerPN, Me.PerQty, Me.ReqQty, Me.AvlQty, Me.PickedQty, Me.OpenQty, Me.Shortage, Me.Status, Me.Forming})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvItemDetails.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvItemDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvItemDetails.Location = New System.Drawing.Point(3, 16)
        Me.dgvItemDetails.Name = "dgvItemDetails"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItemDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvItemDetails.Size = New System.Drawing.Size(1001, 212)
        Me.dgvItemDetails.TabIndex = 0
        '
        'Material
        '
        Me.Material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Material.DataPropertyName = "Material"
        Me.Material.Frozen = True
        Me.Material.HeaderText = "Item"
        Me.Material.Name = "Material"
        Me.Material.ToolTipText = "Material"
        Me.Material.Width = 52
        '
        'Revision
        '
        Me.Revision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Revision.DataPropertyName = "Revision"
        Me.Revision.Frozen = True
        Me.Revision.HeaderText = "Revision"
        Me.Revision.Name = "Revision"
        Me.Revision.ToolTipText = "Revision"
        Me.Revision.Width = 73
        '
        'Manufacturer
        '
        Me.Manufacturer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Manufacturer.DataPropertyName = "Manufacturer"
        Me.Manufacturer.Frozen = True
        Me.Manufacturer.HeaderText = "Manufacturer"
        Me.Manufacturer.Name = "Manufacturer"
        Me.Manufacturer.ToolTipText = "Manufacturer"
        Me.Manufacturer.Width = 95
        '
        'ManufacturerPN
        '
        Me.ManufacturerPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ManufacturerPN.DataPropertyName = "ManufacturerPN"
        Me.ManufacturerPN.Frozen = True
        Me.ManufacturerPN.HeaderText = "ManufacturerPN"
        Me.ManufacturerPN.Name = "ManufacturerPN"
        Me.ManufacturerPN.ToolTipText = "MPN"
        Me.ManufacturerPN.Width = 110
        '
        'PerQty
        '
        Me.PerQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PerQty.DataPropertyName = "PerQty"
        Me.PerQty.Frozen = True
        Me.PerQty.HeaderText = "Qty Per"
        Me.PerQty.Name = "PerQty"
        Me.PerQty.ToolTipText = "PerQty"
        Me.PerQty.Width = 67
        '
        'ReqQty
        '
        Me.ReqQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ReqQty.DataPropertyName = "ReqQty"
        Me.ReqQty.Frozen = True
        Me.ReqQty.HeaderText = "Req Qty"
        Me.ReqQty.Name = "ReqQty"
        Me.ReqQty.ReadOnly = True
        Me.ReqQty.ToolTipText = "ReqQty"
        Me.ReqQty.Width = 71
        '
        'AvlQty
        '
        Me.AvlQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.AvlQty.DataPropertyName = "AvlQty"
        Me.AvlQty.Frozen = True
        Me.AvlQty.HeaderText = "Avl Qty"
        Me.AvlQty.Name = "AvlQty"
        Me.AvlQty.ReadOnly = True
        Me.AvlQty.ToolTipText = "AvlQty"
        Me.AvlQty.Width = 66
        '
        'PickedQty
        '
        Me.PickedQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PickedQty.DataPropertyName = "PickedQty"
        Me.PickedQty.Frozen = True
        Me.PickedQty.HeaderText = "Picked Qty"
        Me.PickedQty.Name = "PickedQty"
        Me.PickedQty.ToolTipText = "PickedQty"
        Me.PickedQty.Width = 84
        '
        'OpenQty
        '
        Me.OpenQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.OpenQty.DataPropertyName = "OpenQty"
        Me.OpenQty.Frozen = True
        Me.OpenQty.HeaderText = "Open Qty"
        Me.OpenQty.Name = "OpenQty"
        Me.OpenQty.ToolTipText = "OpenQty"
        Me.OpenQty.Width = 77
        '
        'Shortage
        '
        Me.Shortage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Shortage.DataPropertyName = "Shortage"
        Me.Shortage.Frozen = True
        Me.Shortage.HeaderText = "Shortage"
        Me.Shortage.Name = "Shortage"
        Me.Shortage.ReadOnly = True
        Me.Shortage.ToolTipText = "Shortage"
        Me.Shortage.Width = 75
        '
        'Status
        '
        Me.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Status.DataPropertyName = "Status"
        Me.Status.Frozen = True
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.ToolTipText = "Status"
        Me.Status.Width = 62
        '
        'Forming
        '
        Me.Forming.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Forming.DataPropertyName = "Forming"
        Me.Forming.Frozen = True
        Me.Forming.HeaderText = "Forming"
        Me.Forming.Name = "Forming"
        Me.Forming.ReadOnly = True
        Me.Forming.ToolTipText = "Forming"
        Me.Forming.Width = 69
        '
        'grpItems
        '
        Me.grpItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpItems.Controls.Add(Me.dgvItem)
        Me.grpItems.Location = New System.Drawing.Point(4, 203)
        Me.grpItems.Name = "grpItems"
        Me.grpItems.Size = New System.Drawing.Size(1019, 104)
        Me.grpItems.TabIndex = 1
        Me.grpItems.TabStop = False
        Me.grpItems.Tag = "^APP-12@"
        Me.grpItems.Text = "Items"
        '
        'dgvItem
        '
        Me.dgvItem.AllowUserToAddRows = False
        Me.dgvItem.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PONumber, Me.ModelPCBA, Me.POQty, Me.IssueQty})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvItem.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvItem.Enabled = False
        Me.dgvItem.Location = New System.Drawing.Point(3, 16)
        Me.dgvItem.Name = "dgvItem"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItem.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvItem.Size = New System.Drawing.Size(1013, 85)
        Me.dgvItem.TabIndex = 0
        Me.dgvItem.TabStop = False
        '
        'PONumber
        '
        Me.PONumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PONumber.DataPropertyName = "DJNo"
        Me.PONumber.HeaderText = "DJ"
        Me.PONumber.Name = "PONumber"
        Me.PONumber.ToolTipText = "PONo"
        Me.PONumber.Width = 45
        '
        'ModelPCBA
        '
        Me.ModelPCBA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ModelPCBA.DataPropertyName = "Product"
        Me.ModelPCBA.HeaderText = "Product"
        Me.ModelPCBA.Name = "ModelPCBA"
        Me.ModelPCBA.ToolTipText = "MatNo"
        Me.ModelPCBA.Width = 69
        '
        'POQty
        '
        Me.POQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.POQty.DataPropertyName = "DJQty"
        Me.POQty.HeaderText = "DJ Qty"
        Me.POQty.Name = "POQty"
        Me.POQty.ToolTipText = "POQty"
        Me.POQty.Width = 64
        '
        'IssueQty
        '
        Me.IssueQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IssueQty.DataPropertyName = "IssueQty"
        Me.IssueQty.HeaderText = "Issue Qty"
        Me.IssueQty.Name = "IssueQty"
        Me.IssueQty.ToolTipText = "IssueQty"
        Me.IssueQty.Width = 76
        '
        'grpProcess
        '
        Me.grpProcess.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpProcess.Controls.Add(Me.tblProcess)
        Me.grpProcess.Location = New System.Drawing.Point(4, 3)
        Me.grpProcess.Name = "grpProcess"
        Me.grpProcess.Size = New System.Drawing.Size(1019, 50)
        Me.grpProcess.TabIndex = 4
        Me.grpProcess.TabStop = False
        Me.grpProcess.Tag = "^TDC-0@"
        Me.grpProcess.Text = "Process"
        '
        'tblProcess
        '
        Me.tblProcess.ColumnCount = 3
        Me.tblProcess.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122.0!))
        Me.tblProcess.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblProcess.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblProcess.Controls.Add(Me.lblProcess, 0, 0)
        Me.tblProcess.Controls.Add(Me.ddlProcess, 1, 0)
        Me.tblProcess.Controls.Add(Me.btnCancel, 2, 0)
        Me.tblProcess.Location = New System.Drawing.Point(3, 12)
        Me.tblProcess.Name = "tblProcess"
        Me.tblProcess.RowCount = 1
        Me.tblProcess.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblProcess.Size = New System.Drawing.Size(949, 35)
        Me.tblProcess.TabIndex = 0
        '
        'lblProcess
        '
        Me.lblProcess.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblProcess.AutoSize = True
        Me.lblProcess.Location = New System.Drawing.Point(3, 11)
        Me.lblProcess.Name = "lblProcess"
        Me.lblProcess.Size = New System.Drawing.Size(59, 13)
        Me.lblProcess.TabIndex = 0
        Me.lblProcess.Tag = "^TDC-0@"
        Me.lblProcess.Text = "Process ID"
        '
        'ddlProcess
        '
        Me.ddlProcess.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ddlProcess.DataType = Nothing
        Me.ddlProcess.ElementTitle = Nothing
        Me.ddlProcess.ErrorColor = System.Drawing.Color.DarkOrange
        Me.ddlProcess.ErrorMessage = Nothing
        Me.ddlProcess.FormattingEnabled = True
        Me.ddlProcess.ItemDataTable = Nothing
        Me.ddlProcess.ItemDesc = Nothing
        Me.ddlProcess.ItemID = Nothing
        Me.ddlProcess.ItemSelect = eTraceUI.eTraceComboBox.ItemSelects.None
        Me.ddlProcess.ItemValue = Nothing
        Me.ddlProcess.LimitToList = True
        Me.ddlProcess.Location = New System.Drawing.Point(125, 7)
        Me.ddlProcess.Name = "ddlProcess"
        Me.ddlProcess.NoOfDecimals = 0
        Me.ddlProcess.ParentControl = Nothing
        Me.ddlProcess.RegEx = Nothing
        Me.ddlProcess.Required = False
        Me.ddlProcess.Size = New System.Drawing.Size(390, 21)
        Me.ddlProcess.StatusControl = Nothing
        Me.ddlProcess.TabIndex = 1
        Me.ddlProcess.TextCase = eTraceUI.eTraceComboBox.TextCases.None
        Me.ddlProcess.ValidationType = Nothing
        Me.ddlProcess.WarnColor = System.Drawing.Color.Wheat
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnCancel.Location = New System.Drawing.Point(521, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(55, 23)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Tag = "^APP-7@"
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'grpActions
        '
        Me.grpActions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpActions.Controls.Add(Me.tblActions)
        Me.grpActions.Location = New System.Drawing.Point(5, 561)
        Me.grpActions.Name = "grpActions"
        Me.grpActions.Size = New System.Drawing.Size(1019, 51)
        Me.grpActions.TabIndex = 3
        Me.grpActions.TabStop = False
        Me.grpActions.Tag = "^APP-13@"
        Me.grpActions.Text = "Actions"
        '
        'tblActions
        '
        Me.tblActions.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tblActions.ColumnCount = 8
        Me.tblActions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblActions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblActions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblActions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblActions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblActions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblActions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblActions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 444.0!))
        Me.tblActions.Controls.Add(Me.btnExcel, 6, 0)
        Me.tblActions.Controls.Add(Me.btnSave, 3, 0)
        Me.tblActions.Controls.Add(Me.lblPDTO, 1, 0)
        Me.tblActions.Controls.Add(Me.txtPDTO, 2, 0)
        Me.tblActions.Controls.Add(Me.btnPost, 0, 0)
        Me.tblActions.Controls.Add(Me.btnCloseTO, 5, 0)
        Me.tblActions.Controls.Add(Me.btnReset, 7, 0)
        Me.tblActions.Controls.Add(Me.btnUnlock, 4, 0)
        Me.tblActions.Location = New System.Drawing.Point(3, 16)
        Me.tblActions.Name = "tblActions"
        Me.tblActions.RowCount = 1
        Me.tblActions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblActions.Size = New System.Drawing.Size(1002, 32)
        Me.tblActions.TabIndex = 0
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnExcel.Location = New System.Drawing.Point(747, 4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(120, 23)
        Me.btnExcel.TabIndex = 1
        Me.btnExcel.Tag = "^MMC-46@"
        Me.btnExcel.Text = "Download to Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnSave.Location = New System.Drawing.Point(309, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(140, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Tag = "^APP-36@"
        Me.btnSave.Text = "Save as Template [F5]"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblPDTO
        '
        Me.lblPDTO.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblPDTO.AutoSize = True
        Me.lblPDTO.Location = New System.Drawing.Point(109, 9)
        Me.lblPDTO.Name = "lblPDTO"
        Me.lblPDTO.Size = New System.Drawing.Size(38, 13)
        Me.lblPDTO.TabIndex = 3
        Me.lblPDTO.Text = "TONO"
        Me.lblPDTO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPDTO.Visible = False
        '
        'txtPDTO
        '
        Me.txtPDTO.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtPDTO.BackColor = System.Drawing.SystemColors.Window
        Me.txtPDTO.DataType = Nothing
        Me.txtPDTO.ElementTitle = Me.lblPDTO
        Me.txtPDTO.ErrorColor = System.Drawing.Color.DarkOrange
        Me.txtPDTO.ErrorMessage = Nothing
        Me.txtPDTO.KeyIn = True
        Me.txtPDTO.Location = New System.Drawing.Point(153, 6)
        Me.txtPDTO.Name = "txtPDTO"
        Me.txtPDTO.NoOfDecimals = 0
        Me.txtPDTO.ParentControl = Nothing
        Me.txtPDTO.RegEx = Nothing
        Me.txtPDTO.Required = False
        Me.txtPDTO.Size = New System.Drawing.Size(150, 20)
        Me.txtPDTO.StatusControl = Nothing
        Me.txtPDTO.TabIndex = 4
        Me.txtPDTO.Tag = "PDTO"
        Me.txtPDTO.TextCase = eTraceUI.eTraceTextBox.TextCases.None
        Me.txtPDTO.ValidationType = Nothing
        Me.txtPDTO.WarnColor = System.Drawing.Color.Wheat
        '
        'btnPost
        '
        Me.btnPost.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnPost.Location = New System.Drawing.Point(3, 4)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(100, 23)
        Me.btnPost.TabIndex = 0
        Me.btnPost.Tag = "^APP-14@"
        Me.btnPost.Text = "Post [F8]"
        Me.btnPost.UseVisualStyleBackColor = True
        '
        'btnCloseTO
        '
        Me.btnCloseTO.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnCloseTO.Location = New System.Drawing.Point(601, 4)
        Me.btnCloseTO.Name = "btnCloseTO"
        Me.btnCloseTO.Size = New System.Drawing.Size(140, 23)
        Me.btnCloseTO.TabIndex = 5
        Me.btnCloseTO.Tag = "^MMC-45@"
        Me.btnCloseTO.Text = "Close Pick Order"
        Me.btnCloseTO.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnReset.Location = New System.Drawing.Point(873, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 23)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Tag = "^APP-15@"
        Me.btnReset.Text = "New [F5]"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnUnlock
        '
        Me.btnUnlock.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnUnlock.Location = New System.Drawing.Point(455, 4)
        Me.btnUnlock.Name = "btnUnlock"
        Me.btnUnlock.Size = New System.Drawing.Size(140, 23)
        Me.btnUnlock.TabIndex = 6
        Me.btnUnlock.Tag = "^MMC-55@"
        Me.btnUnlock.Text = "Unlock Pick Order"
        Me.btnUnlock.UseVisualStyleBackColor = True
        '
        'grpInput
        '
        Me.grpInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInput.Controls.Add(Me.tblInput)
        Me.grpInput.Location = New System.Drawing.Point(4, 57)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(1019, 90)
        Me.grpInput.TabIndex = 0
        Me.grpInput.TabStop = False
        Me.grpInput.Tag = "^APP-27@"
        Me.grpInput.Text = "Input Area"
        '
        'tblInput
        '
        Me.tblInput.ColumnCount = 15
        Me.tblInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tblInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tblInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tblInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tblInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211.0!))
        Me.tblInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblInput.Controls.Add(Me.lblPO, 0, 1)
        Me.tblInput.Controls.Add(Me.txtProdOrderNo, 1, 1)
        Me.tblInput.Controls.Add(Me.txtIssueQty, 4, 1)
        Me.tblInput.Controls.Add(Me.lblProdFloor, 0, 0)
        Me.tblInput.Controls.Add(Me.txtProdFloor, 1, 0)
        Me.tblInput.Controls.Add(Me.lblIssueQty, 3, 1)
        Me.tblInput.Controls.Add(Me.txtETA, 10, 0)
        Me.tblInput.Controls.Add(Me.lblETA, 9, 0)
        Me.tblInput.Controls.Add(Me.txtProdLine, 4, 0)
        Me.tblInput.Controls.Add(Me.lblProdLine, 3, 0)
        Me.tblInput.Controls.Add(Me.ddlSupplyType, 7, 0)
        Me.tblInput.Controls.Add(Me.lblSupplyType, 6, 0)
        Me.tblInput.Controls.Add(Me.ddlReason, 13, 0)
        Me.tblInput.Controls.Add(Me.lblReason, 12, 0)
        Me.tblInput.Controls.Add(Me.ddlStatus, 7, 1)
        Me.tblInput.Controls.Add(Me.lblStatus, 6, 1)
        Me.tblInput.Controls.Add(Me.lblMakeBuy, 9, 1)
        Me.tblInput.Controls.Add(Me.ddlMakeBuy, 10, 1)
        Me.tblInput.Controls.Add(Me.lblSubInv, 12, 1)
        Me.tblInput.Controls.Add(Me.ddlSubInv, 13, 1)
        Me.tblInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblInput.Location = New System.Drawing.Point(3, 16)
        Me.tblInput.Name = "tblInput"
        Me.tblInput.RowCount = 2
        Me.tblInput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblInput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblInput.Size = New System.Drawing.Size(1013, 71)
        Me.tblInput.TabIndex = 0
        '
        'lblPO
        '
        Me.lblPO.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblPO.AutoSize = True
        Me.lblPO.Location = New System.Drawing.Point(3, 46)
        Me.lblPO.Name = "lblPO"
        Me.lblPO.Size = New System.Drawing.Size(66, 13)
        Me.lblPO.TabIndex = 0
        Me.lblPO.Text = "Discrete Job"
        '
        'txtProdOrderNo
        '
        Me.txtProdOrderNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtProdOrderNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtProdOrderNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdOrderNo.DataType = Nothing
        Me.txtProdOrderNo.ElementTitle = Me.lblPO
        Me.txtProdOrderNo.ErrorColor = System.Drawing.Color.DarkOrange
        Me.txtProdOrderNo.ErrorMessage = Nothing
        Me.txtProdOrderNo.KeyIn = True
        Me.txtProdOrderNo.Location = New System.Drawing.Point(75, 43)
        Me.txtProdOrderNo.Name = "txtProdOrderNo"
        Me.txtProdOrderNo.NoOfDecimals = 0
        Me.txtProdOrderNo.ParentControl = Nothing
        Me.txtProdOrderNo.RegEx = Nothing
        Me.txtProdOrderNo.Required = False
        Me.txtProdOrderNo.Size = New System.Drawing.Size(80, 20)
        Me.txtProdOrderNo.StatusControl = Nothing
        Me.txtProdOrderNo.TabIndex = 5
        Me.txtProdOrderNo.Tag = "PONO"
        Me.txtProdOrderNo.TextCase = eTraceUI.eTraceTextBox.TextCases.None
        Me.txtProdOrderNo.ValidationType = Nothing
        Me.txtProdOrderNo.WarnColor = System.Drawing.Color.Wheat
        '
        'txtIssueQty
        '
        Me.txtIssueQty.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtIssueQty.BackColor = System.Drawing.SystemColors.Window
        Me.txtIssueQty.DataType = Nothing
        Me.txtIssueQty.ElementTitle = Me.lblIssueQty
        Me.txtIssueQty.ErrorColor = System.Drawing.Color.DarkOrange
        Me.txtIssueQty.ErrorMessage = Nothing
        Me.txtIssueQty.KeyIn = True
        Me.txtIssueQty.Location = New System.Drawing.Point(241, 43)
        Me.txtIssueQty.Name = "txtIssueQty"
        Me.txtIssueQty.NoOfDecimals = 0
        Me.txtIssueQty.ParentControl = Nothing
        Me.txtIssueQty.RegEx = Nothing
        Me.txtIssueQty.Required = False
        Me.txtIssueQty.Size = New System.Drawing.Size(77, 20)
        Me.txtIssueQty.StatusControl = Nothing
        Me.txtIssueQty.TabIndex = 6
        Me.txtIssueQty.Tag = "IssueQty"
        Me.txtIssueQty.TextCase = eTraceUI.eTraceTextBox.TextCases.None
        Me.txtIssueQty.ValidationType = Nothing
        Me.txtIssueQty.WarnColor = System.Drawing.Color.Wheat
        '
        'lblIssueQty
        '
        Me.lblIssueQty.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblIssueQty.AutoSize = True
        Me.lblIssueQty.Location = New System.Drawing.Point(172, 46)
        Me.lblIssueQty.Name = "lblIssueQty"
        Me.lblIssueQty.Size = New System.Drawing.Size(63, 13)
        Me.lblIssueQty.TabIndex = 2
        Me.lblIssueQty.Text = "Issue Qty    "
        '
        'lblProdFloor
        '
        Me.lblProdFloor.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblProdFloor.AutoSize = True
        Me.lblProdFloor.Location = New System.Drawing.Point(3, 11)
        Me.lblProdFloor.Name = "lblProdFloor"
        Me.lblProdFloor.Size = New System.Drawing.Size(55, 13)
        Me.lblProdFloor.TabIndex = 0
        Me.lblProdFloor.Text = "Prod Floor"
        '
        'txtProdFloor
        '
        Me.txtProdFloor.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtProdFloor.BackColor = System.Drawing.SystemColors.Window
        Me.txtProdFloor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdFloor.DataType = Nothing
        Me.txtProdFloor.ElementTitle = Me.lblProdFloor
        Me.txtProdFloor.ErrorColor = System.Drawing.Color.DarkOrange
        Me.txtProdFloor.ErrorMessage = Nothing
        Me.txtProdFloor.KeyIn = True
        Me.txtProdFloor.Location = New System.Drawing.Point(75, 7)
        Me.txtProdFloor.Name = "txtProdFloor"
        Me.txtProdFloor.NoOfDecimals = 0
        Me.txtProdFloor.ParentControl = Nothing
        Me.txtProdFloor.RegEx = Nothing
        Me.txtProdFloor.Required = False
        Me.txtProdFloor.Size = New System.Drawing.Size(81, 20)
        Me.txtProdFloor.StatusControl = Nothing
        Me.txtProdFloor.TabIndex = 0
        Me.txtProdFloor.Tag = "ProdFloor"
        Me.txtProdFloor.TextCase = eTraceUI.eTraceTextBox.TextCases.UpperCase
        Me.txtProdFloor.ValidationType = Nothing
        Me.txtProdFloor.WarnColor = System.Drawing.Color.Wheat
        '
        'txtETA
        '
        Me.txtETA.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtETA.CustomFormat = "yyyy-MM-dd   HH:mm"
        Me.txtETA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtETA.Location = New System.Drawing.Point(592, 7)
        Me.txtETA.Name = "txtETA"
        Me.txtETA.Size = New System.Drawing.Size(146, 20)
        Me.txtETA.TabIndex = 3
        Me.txtETA.Tag = "ETA"
        '
        'lblETA
        '
        Me.lblETA.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblETA.AutoSize = True
        Me.lblETA.Location = New System.Drawing.Point(529, 11)
        Me.lblETA.Name = "lblETA"
        Me.lblETA.Size = New System.Drawing.Size(28, 13)
        Me.lblETA.TabIndex = 22
        Me.lblETA.Tag = "^MMC-133@"
        Me.lblETA.Text = "ETA"
        '
        'txtProdLine
        '
        Me.txtProdLine.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtProdLine.BackColor = System.Drawing.SystemColors.Window
        Me.txtProdLine.DataType = Nothing
        Me.txtProdLine.ElementTitle = Me.lblProdLine
        Me.txtProdLine.ErrorColor = System.Drawing.Color.DarkOrange
        Me.txtProdLine.ErrorMessage = Nothing
        Me.txtProdLine.KeyIn = True
        Me.txtProdLine.Location = New System.Drawing.Point(241, 7)
        Me.txtProdLine.Name = "txtProdLine"
        Me.txtProdLine.NoOfDecimals = 0
        Me.txtProdLine.ParentControl = Nothing
        Me.txtProdLine.RegEx = Nothing
        Me.txtProdLine.Required = False
        Me.txtProdLine.Size = New System.Drawing.Size(75, 20)
        Me.txtProdLine.StatusControl = Nothing
        Me.txtProdLine.TabIndex = 1
        Me.txtProdLine.Tag = "ProdLine"
        Me.txtProdLine.TextCase = eTraceUI.eTraceTextBox.TextCases.UpperCase
        Me.txtProdLine.ValidationType = Nothing
        Me.txtProdLine.WarnColor = System.Drawing.Color.Wheat
        '
        'lblProdLine
        '
        Me.lblProdLine.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblProdLine.AutoSize = True
        Me.lblProdLine.Location = New System.Drawing.Point(172, 11)
        Me.lblProdLine.Name = "lblProdLine"
        Me.lblProdLine.Size = New System.Drawing.Size(52, 13)
        Me.lblProdLine.TabIndex = 20
        Me.lblProdLine.Text = "Prod Line"
        '
        'ddlSupplyType
        '
        Me.ddlSupplyType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ddlSupplyType.DataType = Nothing
        Me.ddlSupplyType.DisplayMember = "None"
        Me.ddlSupplyType.ElementTitle = Me.lblSupplyType
        Me.ddlSupplyType.ErrorColor = System.Drawing.Color.DarkOrange
        Me.ddlSupplyType.ErrorMessage = Nothing
        Me.ddlSupplyType.FormattingEnabled = True
        Me.ddlSupplyType.ItemDataTable = Nothing
        Me.ddlSupplyType.ItemDesc = Nothing
        Me.ddlSupplyType.ItemID = Nothing
        Me.ddlSupplyType.ItemSelect = eTraceUI.eTraceComboBox.ItemSelects.None
        Me.ddlSupplyType.ItemValue = Nothing
        Me.ddlSupplyType.LimitToList = True
        Me.ddlSupplyType.Location = New System.Drawing.Point(406, 7)
        Me.ddlSupplyType.Name = "ddlSupplyType"
        Me.ddlSupplyType.NoOfDecimals = 0
        Me.ddlSupplyType.ParentControl = Nothing
        Me.ddlSupplyType.RegEx = Nothing
        Me.ddlSupplyType.Required = False
        Me.ddlSupplyType.Size = New System.Drawing.Size(107, 21)
        Me.ddlSupplyType.StatusControl = Nothing
        Me.ddlSupplyType.TabIndex = 2
        Me.ddlSupplyType.Tag = "SupplyType"
        Me.ddlSupplyType.TextCase = eTraceUI.eTraceComboBox.TextCases.None
        Me.ddlSupplyType.ValidationType = Nothing
        Me.ddlSupplyType.WarnColor = System.Drawing.Color.Wheat
        '
        'lblSupplyType
        '
        Me.lblSupplyType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblSupplyType.AutoSize = True
        Me.lblSupplyType.Location = New System.Drawing.Point(334, 11)
        Me.lblSupplyType.Name = "lblSupplyType"
        Me.lblSupplyType.Size = New System.Drawing.Size(66, 13)
        Me.lblSupplyType.TabIndex = 10
        Me.lblSupplyType.Tag = "^MMC-69@"
        Me.lblSupplyType.Text = "Supply Type"
        '
        'ddlReason
        '
        Me.ddlReason.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ddlReason.DataType = Nothing
        Me.ddlReason.DisplayMember = "None"
        Me.ddlReason.DropDownHeight = 200
        Me.ddlReason.DropDownWidth = 350
        Me.ddlReason.ElementTitle = Me.lblReason
        Me.ddlReason.ErrorColor = System.Drawing.Color.DarkOrange
        Me.ddlReason.ErrorMessage = Nothing
        Me.ddlReason.FormattingEnabled = True
        Me.ddlReason.IntegralHeight = False
        Me.ddlReason.ItemDataTable = Nothing
        Me.ddlReason.ItemDesc = Nothing
        Me.ddlReason.ItemID = Nothing
        Me.ddlReason.ItemSelect = eTraceUI.eTraceComboBox.ItemSelects.None
        Me.ddlReason.ItemValue = Nothing
        Me.ddlReason.LimitToList = True
        Me.ddlReason.Location = New System.Drawing.Point(838, 7)
        Me.ddlReason.Name = "ddlReason"
        Me.ddlReason.NoOfDecimals = 0
        Me.ddlReason.ParentControl = Nothing
        Me.ddlReason.RegEx = Nothing
        Me.ddlReason.Required = False
        Me.ddlReason.Size = New System.Drawing.Size(140, 21)
        Me.ddlReason.StatusControl = Nothing
        Me.ddlReason.TabIndex = 4
        Me.ddlReason.Tag = "Reason"
        Me.ddlReason.TextCase = eTraceUI.eTraceComboBox.TextCases.None
        Me.ddlReason.ValidationType = Nothing
        Me.ddlReason.WarnColor = System.Drawing.Color.Wheat
        '
        'lblReason
        '
        Me.lblReason.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblReason.AutoSize = True
        Me.lblReason.Location = New System.Drawing.Point(754, 11)
        Me.lblReason.Name = "lblReason"
        Me.lblReason.Size = New System.Drawing.Size(72, 13)
        Me.lblReason.TabIndex = 19
        Me.lblReason.Text = "Reason Code"
        '
        'ddlStatus
        '
        Me.ddlStatus.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ddlStatus.DataType = Nothing
        Me.ddlStatus.DisplayMember = "None"
        Me.ddlStatus.ElementTitle = Me.lblStatus
        Me.ddlStatus.ErrorColor = System.Drawing.Color.DarkOrange
        Me.ddlStatus.ErrorMessage = Nothing
        Me.ddlStatus.FormattingEnabled = True
        Me.ddlStatus.ItemDataTable = Nothing
        Me.ddlStatus.ItemDesc = Nothing
        Me.ddlStatus.ItemID = Nothing
        Me.ddlStatus.ItemSelect = eTraceUI.eTraceComboBox.ItemSelects.None
        Me.ddlStatus.ItemValue = Nothing
        Me.ddlStatus.LimitToList = True
        Me.ddlStatus.Location = New System.Drawing.Point(406, 42)
        Me.ddlStatus.Name = "ddlStatus"
        Me.ddlStatus.NoOfDecimals = 0
        Me.ddlStatus.ParentControl = Nothing
        Me.ddlStatus.RegEx = Nothing
        Me.ddlStatus.Required = False
        Me.ddlStatus.Size = New System.Drawing.Size(107, 21)
        Me.ddlStatus.StatusControl = Nothing
        Me.ddlStatus.TabIndex = 7
        Me.ddlStatus.Tag = "Status"
        Me.ddlStatus.TextCase = eTraceUI.eTraceComboBox.TextCases.None
        Me.ddlStatus.ValidationType = Nothing
        Me.ddlStatus.WarnColor = System.Drawing.Color.Wheat
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(334, 46)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 24
        Me.lblStatus.Tag = ""
        Me.lblStatus.Text = "Status"
        '
        'lblMakeBuy
        '
        Me.lblMakeBuy.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblMakeBuy.AutoSize = True
        Me.lblMakeBuy.Location = New System.Drawing.Point(529, 46)
        Me.lblMakeBuy.Name = "lblMakeBuy"
        Me.lblMakeBuy.Size = New System.Drawing.Size(57, 13)
        Me.lblMakeBuy.TabIndex = 25
        Me.lblMakeBuy.Tag = ""
        Me.lblMakeBuy.Text = "Make/Buy"
        '
        'ddlMakeBuy
        '
        Me.ddlMakeBuy.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ddlMakeBuy.DataType = Nothing
        Me.ddlMakeBuy.DisplayMember = "None"
        Me.ddlMakeBuy.ElementTitle = Me.lblMakeBuy
        Me.ddlMakeBuy.ErrorColor = System.Drawing.Color.DarkOrange
        Me.ddlMakeBuy.ErrorMessage = Nothing
        Me.ddlMakeBuy.FormattingEnabled = True
        Me.ddlMakeBuy.ItemDataTable = Nothing
        Me.ddlMakeBuy.ItemDesc = Nothing
        Me.ddlMakeBuy.ItemID = Nothing
        Me.ddlMakeBuy.ItemSelect = eTraceUI.eTraceComboBox.ItemSelects.None
        Me.ddlMakeBuy.ItemValue = Nothing
        Me.ddlMakeBuy.LimitToList = True
        Me.ddlMakeBuy.Location = New System.Drawing.Point(592, 42)
        Me.ddlMakeBuy.Name = "ddlMakeBuy"
        Me.ddlMakeBuy.NoOfDecimals = 0
        Me.ddlMakeBuy.ParentControl = Nothing
        Me.ddlMakeBuy.RegEx = Nothing
        Me.ddlMakeBuy.Required = False
        Me.ddlMakeBuy.Size = New System.Drawing.Size(146, 21)
        Me.ddlMakeBuy.StatusControl = Nothing
        Me.ddlMakeBuy.TabIndex = 8
        Me.ddlMakeBuy.Tag = "MakeBuy"
        Me.ddlMakeBuy.TextCase = eTraceUI.eTraceComboBox.TextCases.None
        Me.ddlMakeBuy.ValidationType = Nothing
        Me.ddlMakeBuy.WarnColor = System.Drawing.Color.Wheat
        '
        'lblSubInv
        '
        Me.lblSubInv.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblSubInv.AutoSize = True
        Me.lblSubInv.Location = New System.Drawing.Point(754, 46)
        Me.lblSubInv.Name = "lblSubInv"
        Me.lblSubInv.Size = New System.Drawing.Size(78, 13)
        Me.lblSubInv.TabIndex = 27
        Me.lblSubInv.Text = "Source SubInv"
        '
        'ddlSubInv
        '
        Me.ddlSubInv.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ddlSubInv.DataType = Nothing
        Me.ddlSubInv.DisplayMember = "None"
        Me.ddlSubInv.ElementTitle = Me.lblSubInv
        Me.ddlSubInv.ErrorColor = System.Drawing.Color.DarkOrange
        Me.ddlSubInv.ErrorMessage = Nothing
        Me.ddlSubInv.FormattingEnabled = True
        Me.ddlSubInv.ItemDataTable = Nothing
        Me.ddlSubInv.ItemDesc = Nothing
        Me.ddlSubInv.ItemID = Nothing
        Me.ddlSubInv.ItemSelect = eTraceUI.eTraceComboBox.ItemSelects.None
        Me.ddlSubInv.ItemValue = Nothing
        Me.ddlSubInv.LimitToList = True
        Me.ddlSubInv.Location = New System.Drawing.Point(838, 42)
        Me.ddlSubInv.Name = "ddlSubInv"
        Me.ddlSubInv.NoOfDecimals = 0
        Me.ddlSubInv.ParentControl = Nothing
        Me.ddlSubInv.RegEx = Nothing
        Me.ddlSubInv.Required = False
        Me.ddlSubInv.Size = New System.Drawing.Size(140, 21)
        Me.ddlSubInv.StatusControl = Nothing
        Me.ddlSubInv.TabIndex = 9
        Me.ddlSubInv.Tag = "SubInv"
        Me.ddlSubInv.TextCase = eTraceUI.eTraceComboBox.TextCases.None
        Me.ddlSubInv.ValidationType = Nothing
        Me.ddlSubInv.WarnColor = System.Drawing.Color.Wheat
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1028, 697)
        Me.Controls.Add(Me.pnlBody)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "frmMain"
        TimerStatus1.Frequencies = eTraceUI.Frequencies.Second
        TimerStatus1.Interval = 0
        TimerStatus1.Start = False
        Me.TimerStatus = TimerStatus1
        Me.Controls.SetChildIndex(Me.MessageBar1, 0)
        Me.Controls.SetChildIndex(Me.pnlBody, 0)
        Me.pnlBody.ResumeLayout(False)
        Me.grpOption.ResumeLayout(False)
        Me.ETraceTableLayoutPanel1.ResumeLayout(False)
        Me.ETraceTableLayoutPanel1.PerformLayout()
        Me.ETracePanel1.ResumeLayout(False)
        Me.grpItemdetails.ResumeLayout(False)
        CType(Me.dgvItemDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpItems.ResumeLayout(False)
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProcess.ResumeLayout(False)
        Me.tblProcess.ResumeLayout(False)
        Me.tblProcess.PerformLayout()
        Me.grpActions.ResumeLayout(False)
        Me.tblActions.ResumeLayout(False)
        Me.tblActions.PerformLayout()
        Me.grpInput.ResumeLayout(False)
        Me.tblInput.ResumeLayout(False)
        Me.tblInput.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBody As eTraceUI.eTracePanel
    Friend WithEvents grpOption As eTraceUI.eTraceGroupBox
    Friend WithEvents ETraceTableLayoutPanel1 As eTraceUI.eTraceTableLayoutPanel
    Friend WithEvents btnAdd As eTraceUI.eTraceButton
    Friend WithEvents btnDownload As eTraceUI.eTraceButton
    Friend WithEvents btnSelectTmp As eTraceUI.eTraceButton
    Friend WithEvents btnExcelUpload As eTraceUI.eTraceButton
    Friend WithEvents btnTO As eTraceUI.eTraceButton
    Friend WithEvents ETracePanel1 As eTraceUI.eTracePanel
    Friend WithEvents grpItemdetails As eTraceUI.eTraceGroupBox
    Friend WithEvents dgvItemDetails As eTraceUI.eTraceDataGridView
    Friend WithEvents Material As DataGridViewTextBoxColumn
    Friend WithEvents Revision As DataGridViewTextBoxColumn
    Friend WithEvents Manufacturer As DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerPN As DataGridViewTextBoxColumn
    Friend WithEvents PerQty As DataGridViewTextBoxColumn
    Friend WithEvents ReqQty As DataGridViewTextBoxColumn
    Friend WithEvents AvlQty As DataGridViewTextBoxColumn
    Friend WithEvents PickedQty As DataGridViewTextBoxColumn
    Friend WithEvents OpenQty As DataGridViewTextBoxColumn
    Friend WithEvents Shortage As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Forming As DataGridViewTextBoxColumn
    Friend WithEvents grpItems As eTraceUI.eTraceGroupBox
    Friend WithEvents dgvItem As eTraceUI.eTraceDataGridView
    Friend WithEvents PONumber As DataGridViewTextBoxColumn
    Friend WithEvents ModelPCBA As DataGridViewTextBoxColumn
    Friend WithEvents POQty As DataGridViewTextBoxColumn
    Friend WithEvents IssueQty As DataGridViewTextBoxColumn
    Friend WithEvents grpProcess As eTraceUI.eTraceGroupBox
    Friend WithEvents tblProcess As eTraceUI.eTraceTableLayoutPanel
    Friend WithEvents lblProcess As eTraceUI.eTraceLabel
    Friend WithEvents ddlProcess As eTraceUI.eTraceComboBox
    Friend WithEvents btnCancel As eTraceUI.eTraceButton
    Friend WithEvents grpActions As eTraceUI.eTraceGroupBox
    Friend WithEvents tblActions As eTraceUI.eTraceTableLayoutPanel
    Friend WithEvents btnExcel As eTraceUI.eTraceButton
    Friend WithEvents btnSave As eTraceUI.eTraceButton
    Friend WithEvents lblPDTO As eTraceUI.eTraceLabel
    Friend WithEvents txtPDTO As eTraceUI.eTraceTextBox
    Friend WithEvents btnPost As eTraceUI.eTraceButton
    Friend WithEvents btnCloseTO As eTraceUI.eTraceButton
    Friend WithEvents btnReset As eTraceUI.eTraceButton
    Friend WithEvents btnUnlock As eTraceUI.eTraceButton
    Friend WithEvents grpInput As eTraceUI.eTraceGroupBox
    Friend WithEvents tblInput As eTraceUI.eTraceTableLayoutPanel
    Friend WithEvents lblPO As eTraceUI.eTraceLabel
    Friend WithEvents txtProdOrderNo As eTraceUI.eTraceTextBox
    Friend WithEvents txtIssueQty As eTraceUI.eTraceTextBox
    Friend WithEvents lblIssueQty As eTraceUI.eTraceLabel
    Friend WithEvents lblProdFloor As eTraceUI.eTraceLabel
    Friend WithEvents txtProdFloor As eTraceUI.eTraceTextBox
    Friend WithEvents txtETA As DateTimePicker
    Friend WithEvents lblETA As eTraceUI.eTraceLabel
    Friend WithEvents txtProdLine As eTraceUI.eTraceTextBox
    Friend WithEvents lblProdLine As eTraceUI.eTraceLabel
    Friend WithEvents ddlSupplyType As eTraceUI.eTraceComboBox
    Friend WithEvents lblSupplyType As eTraceUI.eTraceLabel
    Friend WithEvents ddlReason As eTraceUI.eTraceComboBox
    Friend WithEvents lblReason As eTraceUI.eTraceLabel
    Friend WithEvents ddlStatus As eTraceUI.eTraceComboBox
    Friend WithEvents lblStatus As eTraceUI.eTraceLabel
    Friend WithEvents lblMakeBuy As eTraceUI.eTraceLabel
    Friend WithEvents ddlMakeBuy As eTraceUI.eTraceComboBox
    Friend WithEvents lblSubInv As eTraceUI.eTraceLabel
    Friend WithEvents ddlSubInv As eTraceUI.eTraceComboBox
End Class
