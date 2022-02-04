<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtBillNo = New System.Windows.Forms.MaskedTextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.lblLastUser = New System.Windows.Forms.Label()
        Me.lblinfo = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblBillNo = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtCalUnit = New System.Windows.Forms.TextBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.day = New System.Windows.Forms.Label()
        Me.txtacknow = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnResetCal = New System.Windows.Forms.Button()
        Me.txtSum = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cmbBill2 = New System.Windows.Forms.ComboBox()
        Me.lblCharge = New System.Windows.Forms.Label()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.lblCalBillNo = New System.Windows.Forms.Label()
        Me.lblCalUnits = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblread = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbBill1 = New System.Windows.Forms.ComboBox()
        Me.cmbMon = New System.Windows.Forms.ComboBox()
        Me.cmbYear1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.gridBill = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gridName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Month = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gridUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gridCharge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblCusHead = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tabControl.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabControl
        '
        Me.tabControl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tabControl.Controls.Add(Me.TabPage2)
        Me.tabControl.Controls.Add(Me.TabPage3)
        Me.tabControl.Controls.Add(Me.TabPage1)
        Me.tabControl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tabControl.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControl.ItemSize = New System.Drawing.Size(115, 30)
        Me.tabControl.Location = New System.Drawing.Point(63, 79)
        Me.tabControl.Multiline = True
        Me.tabControl.Name = "tabControl"
        Me.tabControl.Padding = New System.Drawing.Point(10, 5)
        Me.tabControl.RightToLeftLayout = True
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.ShowToolTips = True
        Me.tabControl.Size = New System.Drawing.Size(600, 450)
        Me.tabControl.TabIndex = 1
        Me.tabControl.Tag = ""
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.btnDelete)
        Me.TabPage2.Controls.Add(Me.txtBillNo)
        Me.TabPage2.Controls.Add(Me.btnUpdate)
        Me.TabPage2.Controls.Add(Me.btnNew)
        Me.TabPage2.Controls.Add(Me.lblLastUser)
        Me.TabPage2.Controls.Add(Me.lblinfo)
        Me.TabPage2.Controls.Add(Me.btnRegister)
        Me.TabPage2.Controls.Add(Me.txtAdd)
        Me.TabPage2.Controls.Add(Me.txtEmail)
        Me.TabPage2.Controls.Add(Me.txtName)
        Me.TabPage2.Controls.Add(Me.lblBillNo)
        Me.TabPage2.Controls.Add(Me.lblEmail)
        Me.TabPage2.Controls.Add(Me.lblAdd)
        Me.TabPage2.Controls.Add(Me.lblName)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(592, 412)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Customer Registration"
        Me.TabPage2.ToolTipText = "Register new customer"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(27, 356)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(163, 35)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "Remove "
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtBillNo
        '
        Me.txtBillNo.BackColor = System.Drawing.Color.White
        Me.txtBillNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBillNo.Location = New System.Drawing.Point(165, 110)
        Me.txtBillNo.Mask = "0000"
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtBillNo.Size = New System.Drawing.Size(380, 22)
        Me.txtBillNo.TabIndex = 17
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(201, 356)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(163, 35)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnNew.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Location = New System.Drawing.Point(381, 356)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(163, 35)
        Me.btnNew.TabIndex = 14
        Me.btnNew.Text = "New customer"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'lblLastUser
        '
        Me.lblLastUser.AutoSize = True
        Me.lblLastUser.BackColor = System.Drawing.Color.Yellow
        Me.lblLastUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblLastUser.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblLastUser.Location = New System.Drawing.Point(166, 86)
        Me.lblLastUser.Name = "lblLastUser"
        Me.lblLastUser.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblLastUser.Size = New System.Drawing.Size(20, 21)
        Me.lblLastUser.TabIndex = 13
        Me.lblLastUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLastUser.Visible = False
        '
        'lblinfo
        '
        Me.lblinfo.AutoSize = True
        Me.lblinfo.BackColor = System.Drawing.Color.White
        Me.lblinfo.ForeColor = System.Drawing.Color.DarkViolet
        Me.lblinfo.Location = New System.Drawing.Point(136, 274)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblinfo.Size = New System.Drawing.Size(20, 21)
        Me.lblinfo.TabIndex = 12
        Me.lblinfo.Visible = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRegister.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(370, 298)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(175, 35)
        Me.btnRegister.TabIndex = 11
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'txtAdd
        '
        Me.txtAdd.BackColor = System.Drawing.Color.White
        Me.txtAdd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAdd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd.Location = New System.Drawing.Point(165, 233)
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(380, 19)
        Me.txtAdd.TabIndex = 10
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(165, 193)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(380, 19)
        Me.txtEmail.TabIndex = 9
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(165, 153)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(380, 19)
        Me.txtName.TabIndex = 8
        '
        'lblBillNo
        '
        Me.lblBillNo.AutoSize = True
        Me.lblBillNo.BackColor = System.Drawing.SystemColors.Control
        Me.lblBillNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillNo.Location = New System.Drawing.Point(23, 112)
        Me.lblBillNo.Name = "lblBillNo"
        Me.lblBillNo.Size = New System.Drawing.Size(108, 24)
        Me.lblBillNo.TabIndex = 6
        Me.lblBillNo.Text = "Bill Number"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.SystemColors.Control
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(23, 192)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(57, 24)
        Me.lblEmail.TabIndex = 5
        Me.lblEmail.Text = "Email"
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.BackColor = System.Drawing.SystemColors.Control
        Me.lblAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdd.Location = New System.Drawing.Point(23, 232)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(80, 24)
        Me.lblAdd.TabIndex = 4
        Me.lblAdd.Text = "Address"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.SystemColors.Control
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(23, 152)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(61, 24)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Location = New System.Drawing.Point(20, 79)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(548, 320)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5, 0, 303, 0)
        Me.Label2.Size = New System.Drawing.Size(517, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Personal Information"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(105, 0, 105, 0)
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(518, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Registration Form"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.txtCalUnit)
        Me.TabPage3.Controls.Add(Me.cmbYear)
        Me.TabPage3.Controls.Add(Me.cmbMonth)
        Me.TabPage3.Controls.Add(Me.lblDate)
        Me.TabPage3.Controls.Add(Me.day)
        Me.TabPage3.Controls.Add(Me.txtacknow)
        Me.TabPage3.Controls.Add(Me.btnNext)
        Me.TabPage3.Controls.Add(Me.btnResetCal)
        Me.TabPage3.Controls.Add(Me.txtSum)
        Me.TabPage3.Controls.Add(Me.btnSave)
        Me.TabPage3.Controls.Add(Me.cmbBill2)
        Me.TabPage3.Controls.Add(Me.lblCharge)
        Me.TabPage3.Controls.Add(Me.btnCal)
        Me.TabPage3.Controls.Add(Me.lblCalBillNo)
        Me.TabPage3.Controls.Add(Me.lblCalUnits)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.PictureBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(592, 412)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Calculate Bill"
        Me.TabPage3.ToolTipText = "Calculate the bill"
        '
        'txtCalUnit
        '
        Me.txtCalUnit.BackColor = System.Drawing.Color.White
        Me.txtCalUnit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCalUnit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCalUnit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalUnit.Location = New System.Drawing.Point(313, 128)
        Me.txtCalUnit.Name = "txtCalUnit"
        Me.txtCalUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCalUnit.Size = New System.Drawing.Size(232, 19)
        Me.txtCalUnit.TabIndex = 34
        Me.txtCalUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbYear
        '
        Me.cmbYear.BackColor = System.Drawing.Color.White
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(450, 38)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(91, 29)
        Me.cmbYear.TabIndex = 33
        '
        'cmbMonth
        '
        Me.cmbMonth.BackColor = System.Drawing.Color.White
        Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbMonth.Location = New System.Drawing.Point(313, 39)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(110, 29)
        Me.cmbMonth.TabIndex = 32
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblDate.Location = New System.Drawing.Point(30, 40)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(115, 24)
        Me.lblDate.TabIndex = 30
        Me.lblDate.Text = "Current Date"
        '
        'day
        '
        Me.day.AutoSize = True
        Me.day.BackColor = System.Drawing.SystemColors.ControlLight
        Me.day.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.day.Location = New System.Drawing.Point(228, 41)
        Me.day.Name = "day"
        Me.day.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.day.Size = New System.Drawing.Size(20, 24)
        Me.day.TabIndex = 28
        '
        'txtacknow
        '
        Me.txtacknow.AutoSize = True
        Me.txtacknow.BackColor = System.Drawing.SystemColors.Window
        Me.txtacknow.ForeColor = System.Drawing.Color.DarkViolet
        Me.txtacknow.Location = New System.Drawing.Point(272, 258)
        Me.txtacknow.Name = "txtacknow"
        Me.txtacknow.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.txtacknow.Size = New System.Drawing.Size(20, 21)
        Me.txtacknow.TabIndex = 27
        Me.txtacknow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.txtacknow.Visible = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnNext.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(313, 366)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(160, 35)
        Me.btnNext.TabIndex = 26
        Me.btnNext.Text = "Next customer"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnResetCal
        '
        Me.btnResetCal.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnResetCal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnResetCal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnResetCal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetCal.ForeColor = System.Drawing.Color.White
        Me.btnResetCal.Location = New System.Drawing.Point(88, 366)
        Me.btnResetCal.Name = "btnResetCal"
        Me.btnResetCal.Size = New System.Drawing.Size(160, 35)
        Me.btnResetCal.TabIndex = 25
        Me.btnResetCal.Text = "Reset"
        Me.btnResetCal.UseVisualStyleBackColor = False
        '
        'txtSum
        '
        Me.txtSum.BackColor = System.Drawing.Color.White
        Me.txtSum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSum.Enabled = False
        Me.txtSum.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSum.Location = New System.Drawing.Point(313, 218)
        Me.txtSum.Name = "txtSum"
        Me.txtSum.ReadOnly = True
        Me.txtSum.Size = New System.Drawing.Size(232, 19)
        Me.txtSum.TabIndex = 24
        Me.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSum.Visible = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(313, 293)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(232, 35)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save Bill"
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'cmbBill2
        '
        Me.cmbBill2.BackColor = System.Drawing.Color.White
        Me.cmbBill2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBill2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbBill2.FormattingEnabled = True
        Me.cmbBill2.Location = New System.Drawing.Point(313, 78)
        Me.cmbBill2.Name = "cmbBill2"
        Me.cmbBill2.Size = New System.Drawing.Size(231, 29)
        Me.cmbBill2.TabIndex = 16
        '
        'lblCharge
        '
        Me.lblCharge.AutoSize = True
        Me.lblCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharge.Location = New System.Drawing.Point(24, 218)
        Me.lblCharge.Name = "lblCharge"
        Me.lblCharge.Size = New System.Drawing.Size(128, 24)
        Me.lblCharge.TabIndex = 13
        Me.lblCharge.Text = "Usage charge"
        '
        'btnCal
        '
        Me.btnCal.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCal.ForeColor = System.Drawing.Color.White
        Me.btnCal.Location = New System.Drawing.Point(313, 168)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(232, 35)
        Me.btnCal.TabIndex = 12
        Me.btnCal.Text = "Calculate Bill"
        Me.btnCal.UseVisualStyleBackColor = False
        '
        'lblCalBillNo
        '
        Me.lblCalBillNo.AutoSize = True
        Me.lblCalBillNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalBillNo.Location = New System.Drawing.Point(24, 78)
        Me.lblCalBillNo.Name = "lblCalBillNo"
        Me.lblCalBillNo.Size = New System.Drawing.Size(161, 24)
        Me.lblCalBillNo.TabIndex = 4
        Me.lblCalBillNo.Text = "Select bill number"
        '
        'lblCalUnits
        '
        Me.lblCalUnits.AutoSize = True
        Me.lblCalUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalUnits.Location = New System.Drawing.Point(24, 128)
        Me.lblCalUnits.Name = "lblCalUnits"
        Me.lblCalUnits.Size = New System.Drawing.Size(146, 24)
        Me.lblCalUnits.TabIndex = 2
        Me.lblCalUnits.Text = "Units consumed"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(180, 0, 180, 0)
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(517, 27)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Bill calculator"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox3.Location = New System.Drawing.Point(28, 37)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(515, 33)
        Me.PictureBox3.TabIndex = 31
        Me.PictureBox3.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.lblread)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.btnView)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.cmbBill1)
        Me.TabPage1.Controls.Add(Me.cmbMon)
        Me.TabPage1.Controls.Add(Me.cmbYear1)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.lblCusHead)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(592, 412)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Customer Details"
        Me.TabPage1.ToolTipText = "View customer details"
        '
        'lblread
        '
        Me.lblread.AutoSize = True
        Me.lblread.BackColor = System.Drawing.Color.White
        Me.lblread.ForeColor = System.Drawing.Color.DarkViolet
        Me.lblread.Location = New System.Drawing.Point(308, 183)
        Me.lblread.Name = "lblread"
        Me.lblread.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblread.Size = New System.Drawing.Size(20, 21)
        Me.lblread.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 25)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Select year"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(310, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 25)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Select month"
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnView.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Location = New System.Drawing.Point(312, 145)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(232, 35)
        Me.btnView.TabIndex = 36
        Me.btnView.Text = "View details"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 25)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Select specific customer"
        '
        'cmbBill1
        '
        Me.cmbBill1.BackColor = System.Drawing.Color.White
        Me.cmbBill1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBill1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbBill1.FormattingEnabled = True
        Me.cmbBill1.Location = New System.Drawing.Point(312, 110)
        Me.cmbBill1.Name = "cmbBill1"
        Me.cmbBill1.Size = New System.Drawing.Size(231, 29)
        Me.cmbBill1.TabIndex = 34
        '
        'cmbMon
        '
        Me.cmbMon.BackColor = System.Drawing.Color.White
        Me.cmbMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMon.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbMon.FormattingEnabled = True
        Me.cmbMon.Items.AddRange(New Object() {"All", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbMon.Location = New System.Drawing.Point(453, 70)
        Me.cmbMon.Name = "cmbMon"
        Me.cmbMon.Size = New System.Drawing.Size(92, 29)
        Me.cmbMon.TabIndex = 23
        '
        'cmbYear1
        '
        Me.cmbYear1.BackColor = System.Drawing.Color.White
        Me.cmbYear1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbYear1.FormattingEnabled = True
        Me.cmbYear1.Location = New System.Drawing.Point(170, 70)
        Me.cmbYear1.MaxDropDownItems = 10
        Me.cmbYear1.Name = "cmbYear1"
        Me.cmbYear1.Size = New System.Drawing.Size(78, 29)
        Me.cmbYear1.TabIndex = 22
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.gridBill, Me.gridName, Me.Month, Me.gridUnit, Me.gridCharge})
        Me.DataGridView1.Location = New System.Drawing.Point(31, 214)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(514, 185)
        Me.DataGridView1.TabIndex = 8
        '
        'gridBill
        '
        Me.gridBill.HeaderText = "Bill number"
        Me.gridBill.Name = "gridBill"
        Me.gridBill.ReadOnly = True
        '
        'gridName
        '
        Me.gridName.HeaderText = "Name"
        Me.gridName.Name = "gridName"
        Me.gridName.ReadOnly = True
        Me.gridName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Month
        '
        Me.Month.HeaderText = "Month"
        Me.Month.Name = "Month"
        Me.Month.ReadOnly = True
        '
        'gridUnit
        '
        Me.gridUnit.HeaderText = "Units"
        Me.gridUnit.Name = "gridUnit"
        Me.gridUnit.ReadOnly = True
        Me.gridUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'gridCharge
        '
        Me.gridCharge.HeaderText = "Total charge"
        Me.gridCharge.Name = "gridCharge"
        Me.gridCharge.ReadOnly = True
        Me.gridCharge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'lblCusHead
        '
        Me.lblCusHead.AutoSize = True
        Me.lblCusHead.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCusHead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCusHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCusHead.Location = New System.Drawing.Point(31, 4)
        Me.lblCusHead.Name = "lblCusHead"
        Me.lblCusHead.Padding = New System.Windows.Forms.Padding(100, 0, 109, 0)
        Me.lblCusHead.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblCusHead.Size = New System.Drawing.Size(514, 27)
        Me.lblCusHead.TabIndex = 2
        Me.lblCusHead.Text = "Customer Utility Information"
        Me.lblCusHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(61, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(405, 33)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = " Regional Water Authorities "
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(34, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(633, 524)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackgroundImage = Global.BillCal_KEG_01.My.Resources.Resources._2
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogout.Location = New System.Drawing.Point(544, 34)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(68, 56)
        Me.btnLogout.TabIndex = 18
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(190, 0, 190, 0)
        Me.Label6.Size = New System.Drawing.Size(514, 25)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Current Date"
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BillCal_KEG_01.My.Resources.Resources._1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(694, 571)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tabControl)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmHome"
        Me.Text = "Regional Water Authorities"
        Me.tabControl.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblBillNo As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblAdd As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents lblCalBillNo As System.Windows.Forms.Label
    Friend WithEvents lblCalUnits As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblCharge As System.Windows.Forms.Label
    Friend WithEvents btnCal As System.Windows.Forms.Button
    Friend WithEvents lblCusHead As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Private WithEvents txtEmail As System.Windows.Forms.TextBox
    Private WithEvents txtName As System.Windows.Forms.TextBox
    Private WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Private WithEvents cmbYear1 As System.Windows.Forms.ComboBox
    Public WithEvents cmbBill2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblinfo As System.Windows.Forms.Label
    Friend WithEvents lblLastUser As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtBillNo As System.Windows.Forms.MaskedTextBox
    Private WithEvents txtSum As System.Windows.Forms.TextBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnResetCal As System.Windows.Forms.Button
    Friend WithEvents txtacknow As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Private WithEvents cmbMon As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Public WithEvents cmbBill1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents day As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents txtCalUnit As System.Windows.Forms.TextBox
    Friend WithEvents lblread As System.Windows.Forms.Label
    Friend WithEvents gridBill As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gridName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Month As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gridUnit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gridCharge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
