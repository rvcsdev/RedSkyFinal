﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RedSkyConfiguration
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnSaveReportConfiguration = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblMonthyNextReport = New System.Windows.Forms.Label()
        Me.lblMonthlyLastReport = New System.Windows.Forms.Label()
        Me.cboMonthlyStatus = New System.Windows.Forms.ComboBox()
        Me.dtMonthly = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblWeeklyDay = New System.Windows.Forms.Label()
        Me.cboWeeklyDay = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblWeeklyGenerationTime = New System.Windows.Forms.Label()
        Me.lblWeeklyNextReport = New System.Windows.Forms.Label()
        Me.lblWeeklyLastReport = New System.Windows.Forms.Label()
        Me.cboWeeklyStatus = New System.Windows.Forms.ComboBox()
        Me.dtWeekly = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDailyTo = New System.Windows.Forms.Label()
        Me.lblDailyFrom = New System.Windows.Forms.Label()
        Me.dtDailyTo = New System.Windows.Forms.DateTimePicker()
        Me.dtDailyFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDailyGenerationTime = New System.Windows.Forms.Label()
        Me.lblDailyNextReport = New System.Windows.Forms.Label()
        Me.lblDailyLastReport = New System.Windows.Forms.Label()
        Me.cboDailyStatus = New System.Windows.Forms.ComboBox()
        Me.dtDaily = New System.Windows.Forms.DateTimePicker()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cboSMTPUseTLSSSL = New System.Windows.Forms.ComboBox()
        Me.lblSMTPId = New System.Windows.Forms.Label()
        Me.btnSaveMailingConfiguration = New System.Windows.Forms.Button()
        Me.lblSMTPPassword = New System.Windows.Forms.Label()
        Me.lblSMTPUsername = New System.Windows.Forms.Label()
        Me.lblSMTPUseTLSSSL = New System.Windows.Forms.Label()
        Me.lblSMTPPortSSL = New System.Windows.Forms.Label()
        Me.lblSMTPServer = New System.Windows.Forms.Label()
        Me.txtSMTPPassword = New System.Windows.Forms.TextBox()
        Me.txtSMTPUsername = New System.Windows.Forms.TextBox()
        Me.txtSMTPPortSSL = New System.Windows.Forms.TextBox()
        Me.txtSMTPServer = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnMailingListCancel = New System.Windows.Forms.Button()
        Me.lblMailingListId = New System.Windows.Forms.Label()
        Me.btnMailingListEdit = New System.Windows.Forms.Button()
        Me.btnMailingListAddNew = New System.Windows.Forms.Button()
        Me.btnMailingListSave = New System.Windows.Forms.Button()
        Me.chkMonthly = New System.Windows.Forms.CheckBox()
        Me.chkWeekly = New System.Windows.Forms.CheckBox()
        Me.chkDaily = New System.Windows.Forms.CheckBox()
        Me.cboMailingListStatus = New System.Windows.Forms.ComboBox()
        Me.txtMailingListEmailAddress = New System.Windows.Forms.TextBox()
        Me.lblMailingListStatus = New System.Windows.Forms.Label()
        Me.lblMailingListEmailAddress = New System.Windows.Forms.Label()
        Me.gvMailingList = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lblOtherConfigurationConfigName = New System.Windows.Forms.Label()
        Me.txtOtherConfigurationConfigValue = New System.Windows.Forms.TextBox()
        Me.btnOtherConfigurationSave = New System.Windows.Forms.Button()
        Me.lblOtherConfigurationConfigId = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.gvMailingList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(624, 470)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnSaveReportConfiguration)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(616, 439)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Report Configuration"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnSaveReportConfiguration
        '
        Me.btnSaveReportConfiguration.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveReportConfiguration.Location = New System.Drawing.Point(489, 389)
        Me.btnSaveReportConfiguration.Name = "btnSaveReportConfiguration"
        Me.btnSaveReportConfiguration.Size = New System.Drawing.Size(117, 39)
        Me.btnSaveReportConfiguration.TabIndex = 3
        Me.btnSaveReportConfiguration.Text = "Save"
        Me.btnSaveReportConfiguration.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.lblMonthyNextReport)
        Me.GroupBox3.Controls.Add(Me.lblMonthlyLastReport)
        Me.GroupBox3.Controls.Add(Me.cboMonthlyStatus)
        Me.GroupBox3.Controls.Add(Me.dtMonthly)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 253)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(610, 125)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Monthly Summary Report"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Status: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date Time of Generation: "
        '
        'lblMonthyNextReport
        '
        Me.lblMonthyNextReport.AutoSize = True
        Me.lblMonthyNextReport.Location = New System.Drawing.Point(395, 80)
        Me.lblMonthyNextReport.Name = "lblMonthyNextReport"
        Me.lblMonthyNextReport.Size = New System.Drawing.Size(48, 18)
        Me.lblMonthyNextReport.TabIndex = 3
        Me.lblMonthyNextReport.Text = "Label6"
        '
        'lblMonthlyLastReport
        '
        Me.lblMonthlyLastReport.AutoSize = True
        Me.lblMonthlyLastReport.Location = New System.Drawing.Point(395, 46)
        Me.lblMonthlyLastReport.Name = "lblMonthlyLastReport"
        Me.lblMonthlyLastReport.Size = New System.Drawing.Size(48, 18)
        Me.lblMonthlyLastReport.TabIndex = 2
        Me.lblMonthlyLastReport.Text = "Label5"
        '
        'cboMonthlyStatus
        '
        Me.cboMonthlyStatus.FormattingEnabled = True
        Me.cboMonthlyStatus.Items.AddRange(New Object() {"ENABLED", "DISABLED"})
        Me.cboMonthlyStatus.Location = New System.Drawing.Point(178, 77)
        Me.cboMonthlyStatus.Name = "cboMonthlyStatus"
        Me.cboMonthlyStatus.Size = New System.Drawing.Size(121, 26)
        Me.cboMonthlyStatus.TabIndex = 1
        '
        'dtMonthly
        '
        Me.dtMonthly.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtMonthly.Location = New System.Drawing.Point(178, 40)
        Me.dtMonthly.Name = "dtMonthly"
        Me.dtMonthly.ShowUpDown = True
        Me.dtMonthly.Size = New System.Drawing.Size(200, 26)
        Me.dtMonthly.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblWeeklyDay)
        Me.GroupBox2.Controls.Add(Me.cboWeeklyDay)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblWeeklyGenerationTime)
        Me.GroupBox2.Controls.Add(Me.lblWeeklyNextReport)
        Me.GroupBox2.Controls.Add(Me.lblWeeklyLastReport)
        Me.GroupBox2.Controls.Add(Me.cboWeeklyStatus)
        Me.GroupBox2.Controls.Add(Me.dtWeekly)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(610, 125)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Weekly Summary Report"
        '
        'lblWeeklyDay
        '
        Me.lblWeeklyDay.AutoSize = True
        Me.lblWeeklyDay.Location = New System.Drawing.Point(14, 39)
        Me.lblWeeklyDay.Name = "lblWeeklyDay"
        Me.lblWeeklyDay.Size = New System.Drawing.Size(126, 18)
        Me.lblWeeklyDay.TabIndex = 7
        Me.lblWeeklyDay.Text = "Day of Generation: "
        '
        'cboWeeklyDay
        '
        Me.cboWeeklyDay.FormattingEnabled = True
        Me.cboWeeklyDay.Items.AddRange(New Object() {"SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY"})
        Me.cboWeeklyDay.Location = New System.Drawing.Point(152, 31)
        Me.cboWeeklyDay.Name = "cboWeeklyDay"
        Me.cboWeeklyDay.Size = New System.Drawing.Size(147, 26)
        Me.cboWeeklyDay.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(341, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Status: "
        '
        'lblWeeklyGenerationTime
        '
        Me.lblWeeklyGenerationTime.AutoSize = True
        Me.lblWeeklyGenerationTime.Location = New System.Drawing.Point(6, 80)
        Me.lblWeeklyGenerationTime.Name = "lblWeeklyGenerationTime"
        Me.lblWeeklyGenerationTime.Size = New System.Drawing.Size(134, 18)
        Me.lblWeeklyGenerationTime.TabIndex = 4
        Me.lblWeeklyGenerationTime.Text = "Time of Generation: "
        '
        'lblWeeklyNextReport
        '
        Me.lblWeeklyNextReport.AutoSize = True
        Me.lblWeeklyNextReport.Location = New System.Drawing.Point(356, 95)
        Me.lblWeeklyNextReport.Name = "lblWeeklyNextReport"
        Me.lblWeeklyNextReport.Size = New System.Drawing.Size(48, 18)
        Me.lblWeeklyNextReport.TabIndex = 3
        Me.lblWeeklyNextReport.Text = "Label4"
        '
        'lblWeeklyLastReport
        '
        Me.lblWeeklyLastReport.AutoSize = True
        Me.lblWeeklyLastReport.Location = New System.Drawing.Point(356, 72)
        Me.lblWeeklyLastReport.Name = "lblWeeklyLastReport"
        Me.lblWeeklyLastReport.Size = New System.Drawing.Size(48, 18)
        Me.lblWeeklyLastReport.TabIndex = 2
        Me.lblWeeklyLastReport.Text = "Label3"
        '
        'cboWeeklyStatus
        '
        Me.cboWeeklyStatus.FormattingEnabled = True
        Me.cboWeeklyStatus.Items.AddRange(New Object() {"ENABLED", "DISABLED"})
        Me.cboWeeklyStatus.Location = New System.Drawing.Point(410, 31)
        Me.cboWeeklyStatus.Name = "cboWeeklyStatus"
        Me.cboWeeklyStatus.Size = New System.Drawing.Size(163, 26)
        Me.cboWeeklyStatus.TabIndex = 1
        '
        'dtWeekly
        '
        Me.dtWeekly.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtWeekly.Location = New System.Drawing.Point(152, 72)
        Me.dtWeekly.Name = "dtWeekly"
        Me.dtWeekly.ShowUpDown = True
        Me.dtWeekly.Size = New System.Drawing.Size(147, 26)
        Me.dtWeekly.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDailyTo)
        Me.GroupBox1.Controls.Add(Me.lblDailyFrom)
        Me.GroupBox1.Controls.Add(Me.dtDailyTo)
        Me.GroupBox1.Controls.Add(Me.dtDailyFrom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblDailyGenerationTime)
        Me.GroupBox1.Controls.Add(Me.lblDailyNextReport)
        Me.GroupBox1.Controls.Add(Me.lblDailyLastReport)
        Me.GroupBox1.Controls.Add(Me.cboDailyStatus)
        Me.GroupBox1.Controls.Add(Me.dtDaily)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(610, 125)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Daily Summary Report"
        '
        'lblDailyTo
        '
        Me.lblDailyTo.AutoSize = True
        Me.lblDailyTo.Location = New System.Drawing.Point(341, 66)
        Me.lblDailyTo.Name = "lblDailyTo"
        Me.lblDailyTo.Size = New System.Drawing.Size(63, 18)
        Me.lblDailyTo.TabIndex = 9
        Me.lblDailyTo.Text = "Daily To: "
        '
        'lblDailyFrom
        '
        Me.lblDailyFrom.AutoSize = True
        Me.lblDailyFrom.Location = New System.Drawing.Point(323, 32)
        Me.lblDailyFrom.Name = "lblDailyFrom"
        Me.lblDailyFrom.Size = New System.Drawing.Size(81, 18)
        Me.lblDailyFrom.TabIndex = 8
        Me.lblDailyFrom.Text = "Daily From: "
        '
        'dtDailyTo
        '
        Me.dtDailyTo.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtDailyTo.Location = New System.Drawing.Point(410, 60)
        Me.dtDailyTo.Name = "dtDailyTo"
        Me.dtDailyTo.ShowUpDown = True
        Me.dtDailyTo.Size = New System.Drawing.Size(163, 26)
        Me.dtDailyTo.TabIndex = 7
        '
        'dtDailyFrom
        '
        Me.dtDailyFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtDailyFrom.Location = New System.Drawing.Point(410, 26)
        Me.dtDailyFrom.Name = "dtDailyFrom"
        Me.dtDailyFrom.ShowUpDown = True
        Me.dtDailyFrom.Size = New System.Drawing.Size(163, 26)
        Me.dtDailyFrom.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Status: "
        '
        'lblDailyGenerationTime
        '
        Me.lblDailyGenerationTime.AutoSize = True
        Me.lblDailyGenerationTime.Location = New System.Drawing.Point(6, 32)
        Me.lblDailyGenerationTime.Name = "lblDailyGenerationTime"
        Me.lblDailyGenerationTime.Size = New System.Drawing.Size(134, 18)
        Me.lblDailyGenerationTime.TabIndex = 4
        Me.lblDailyGenerationTime.Text = "Time of Generation: "
        '
        'lblDailyNextReport
        '
        Me.lblDailyNextReport.AutoSize = True
        Me.lblDailyNextReport.Location = New System.Drawing.Point(356, 99)
        Me.lblDailyNextReport.Name = "lblDailyNextReport"
        Me.lblDailyNextReport.Size = New System.Drawing.Size(48, 18)
        Me.lblDailyNextReport.TabIndex = 3
        Me.lblDailyNextReport.Text = "Label2"
        '
        'lblDailyLastReport
        '
        Me.lblDailyLastReport.AutoSize = True
        Me.lblDailyLastReport.Location = New System.Drawing.Point(87, 99)
        Me.lblDailyLastReport.Name = "lblDailyLastReport"
        Me.lblDailyLastReport.Size = New System.Drawing.Size(48, 18)
        Me.lblDailyLastReport.TabIndex = 2
        Me.lblDailyLastReport.Text = "Label1"
        '
        'cboDailyStatus
        '
        Me.cboDailyStatus.FormattingEnabled = True
        Me.cboDailyStatus.Items.AddRange(New Object() {"ENABLED", "DISABLED"})
        Me.cboDailyStatus.Location = New System.Drawing.Point(152, 60)
        Me.cboDailyStatus.Name = "cboDailyStatus"
        Me.cboDailyStatus.Size = New System.Drawing.Size(147, 26)
        Me.cboDailyStatus.TabIndex = 1
        '
        'dtDaily
        '
        Me.dtDaily.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtDaily.Location = New System.Drawing.Point(152, 26)
        Me.dtDaily.Name = "dtDaily"
        Me.dtDaily.ShowUpDown = True
        Me.dtDaily.Size = New System.Drawing.Size(147, 26)
        Me.dtDaily.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cboSMTPUseTLSSSL)
        Me.TabPage2.Controls.Add(Me.lblSMTPId)
        Me.TabPage2.Controls.Add(Me.btnSaveMailingConfiguration)
        Me.TabPage2.Controls.Add(Me.lblSMTPPassword)
        Me.TabPage2.Controls.Add(Me.lblSMTPUsername)
        Me.TabPage2.Controls.Add(Me.lblSMTPUseTLSSSL)
        Me.TabPage2.Controls.Add(Me.lblSMTPPortSSL)
        Me.TabPage2.Controls.Add(Me.lblSMTPServer)
        Me.TabPage2.Controls.Add(Me.txtSMTPPassword)
        Me.TabPage2.Controls.Add(Me.txtSMTPUsername)
        Me.TabPage2.Controls.Add(Me.txtSMTPPortSSL)
        Me.TabPage2.Controls.Add(Me.txtSMTPServer)
        Me.TabPage2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(616, 439)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mailing Configuration"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cboSMTPUseTLSSSL
        '
        Me.cboSMTPUseTLSSSL.FormattingEnabled = True
        Me.cboSMTPUseTLSSSL.Items.AddRange(New Object() {"TRUE", "FALSE"})
        Me.cboSMTPUseTLSSSL.Location = New System.Drawing.Point(268, 177)
        Me.cboSMTPUseTLSSSL.Name = "cboSMTPUseTLSSSL"
        Me.cboSMTPUseTLSSSL.Size = New System.Drawing.Size(247, 26)
        Me.cboSMTPUseTLSSSL.TabIndex = 14
        '
        'lblSMTPId
        '
        Me.lblSMTPId.AutoSize = True
        Me.lblSMTPId.Location = New System.Drawing.Point(268, 51)
        Me.lblSMTPId.Name = "lblSMTPId"
        Me.lblSMTPId.Size = New System.Drawing.Size(58, 18)
        Me.lblSMTPId.TabIndex = 13
        Me.lblSMTPId.Text = "SMTP ID"
        Me.lblSMTPId.Visible = False
        '
        'btnSaveMailingConfiguration
        '
        Me.btnSaveMailingConfiguration.Location = New System.Drawing.Point(398, 318)
        Me.btnSaveMailingConfiguration.Name = "btnSaveMailingConfiguration"
        Me.btnSaveMailingConfiguration.Size = New System.Drawing.Size(117, 39)
        Me.btnSaveMailingConfiguration.TabIndex = 12
        Me.btnSaveMailingConfiguration.Text = "Save"
        Me.btnSaveMailingConfiguration.UseVisualStyleBackColor = True
        '
        'lblSMTPPassword
        '
        Me.lblSMTPPassword.AutoSize = True
        Me.lblSMTPPassword.Location = New System.Drawing.Point(104, 274)
        Me.lblSMTPPassword.Name = "lblSMTPPassword"
        Me.lblSMTPPassword.Size = New System.Drawing.Size(111, 18)
        Me.lblSMTPPassword.TabIndex = 11
        Me.lblSMTPPassword.Text = "SMTP Password: "
        '
        'lblSMTPUsername
        '
        Me.lblSMTPUsername.AutoSize = True
        Me.lblSMTPUsername.Location = New System.Drawing.Point(100, 227)
        Me.lblSMTPUsername.Name = "lblSMTPUsername"
        Me.lblSMTPUsername.Size = New System.Drawing.Size(115, 18)
        Me.lblSMTPUsername.TabIndex = 10
        Me.lblSMTPUsername.Text = "SMTP Username: "
        '
        'lblSMTPUseTLSSSL
        '
        Me.lblSMTPUseTLSSSL.AutoSize = True
        Me.lblSMTPUseTLSSSL.Location = New System.Drawing.Point(54, 180)
        Me.lblSMTPUseTLSSSL.Name = "lblSMTPUseTLSSSL"
        Me.lblSMTPUseTLSSSL.Size = New System.Drawing.Size(110, 18)
        Me.lblSMTPUseTLSSSL.TabIndex = 9
        Me.lblSMTPUseTLSSSL.Text = "SMTP Enable SSL"
        '
        'lblSMTPPortSSL
        '
        Me.lblSMTPPortSSL.AutoSize = True
        Me.lblSMTPPortSSL.Location = New System.Drawing.Point(104, 133)
        Me.lblSMTPPortSSL.Name = "lblSMTPPortSSL"
        Me.lblSMTPPortSSL.Size = New System.Drawing.Size(111, 18)
        Me.lblSMTPPortSSL.TabIndex = 8
        Me.lblSMTPPortSSL.Text = "SMTP Port (SSL): "
        '
        'lblSMTPServer
        '
        Me.lblSMTPServer.AutoSize = True
        Me.lblSMTPServer.Location = New System.Drawing.Point(123, 87)
        Me.lblSMTPServer.Name = "lblSMTPServer"
        Me.lblSMTPServer.Size = New System.Drawing.Size(92, 18)
        Me.lblSMTPServer.TabIndex = 6
        Me.lblSMTPServer.Text = "SMTP Server: "
        '
        'txtSMTPPassword
        '
        Me.txtSMTPPassword.Location = New System.Drawing.Point(268, 271)
        Me.txtSMTPPassword.Name = "txtSMTPPassword"
        Me.txtSMTPPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSMTPPassword.Size = New System.Drawing.Size(247, 26)
        Me.txtSMTPPassword.TabIndex = 5
        '
        'txtSMTPUsername
        '
        Me.txtSMTPUsername.Location = New System.Drawing.Point(268, 224)
        Me.txtSMTPUsername.Name = "txtSMTPUsername"
        Me.txtSMTPUsername.Size = New System.Drawing.Size(247, 26)
        Me.txtSMTPUsername.TabIndex = 4
        Me.txtSMTPUsername.Text = " "
        '
        'txtSMTPPortSSL
        '
        Me.txtSMTPPortSSL.Location = New System.Drawing.Point(268, 130)
        Me.txtSMTPPortSSL.Name = "txtSMTPPortSSL"
        Me.txtSMTPPortSSL.Size = New System.Drawing.Size(247, 26)
        Me.txtSMTPPortSSL.TabIndex = 2
        '
        'txtSMTPServer
        '
        Me.txtSMTPServer.Location = New System.Drawing.Point(268, 84)
        Me.txtSMTPServer.Name = "txtSMTPServer"
        Me.txtSMTPServer.Size = New System.Drawing.Size(247, 26)
        Me.txtSMTPServer.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnMailingListCancel)
        Me.TabPage3.Controls.Add(Me.lblMailingListId)
        Me.TabPage3.Controls.Add(Me.btnMailingListEdit)
        Me.TabPage3.Controls.Add(Me.btnMailingListAddNew)
        Me.TabPage3.Controls.Add(Me.btnMailingListSave)
        Me.TabPage3.Controls.Add(Me.chkMonthly)
        Me.TabPage3.Controls.Add(Me.chkWeekly)
        Me.TabPage3.Controls.Add(Me.chkDaily)
        Me.TabPage3.Controls.Add(Me.cboMailingListStatus)
        Me.TabPage3.Controls.Add(Me.txtMailingListEmailAddress)
        Me.TabPage3.Controls.Add(Me.lblMailingListStatus)
        Me.TabPage3.Controls.Add(Me.lblMailingListEmailAddress)
        Me.TabPage3.Controls.Add(Me.gvMailingList)
        Me.TabPage3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(616, 439)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Mailing List"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnMailingListCancel
        '
        Me.btnMailingListCancel.Enabled = False
        Me.btnMailingListCancel.Location = New System.Drawing.Point(533, 60)
        Me.btnMailingListCancel.Name = "btnMailingListCancel"
        Me.btnMailingListCancel.Size = New System.Drawing.Size(75, 33)
        Me.btnMailingListCancel.TabIndex = 12
        Me.btnMailingListCancel.Text = "Cancel"
        Me.btnMailingListCancel.UseVisualStyleBackColor = True
        '
        'lblMailingListId
        '
        Me.lblMailingListId.AutoSize = True
        Me.lblMailingListId.Location = New System.Drawing.Point(105, 4)
        Me.lblMailingListId.Name = "lblMailingListId"
        Me.lblMailingListId.Size = New System.Drawing.Size(21, 18)
        Me.lblMailingListId.TabIndex = 11
        Me.lblMailingListId.Text = "ID"
        '
        'btnMailingListEdit
        '
        Me.btnMailingListEdit.Location = New System.Drawing.Point(533, 17)
        Me.btnMailingListEdit.Name = "btnMailingListEdit"
        Me.btnMailingListEdit.Size = New System.Drawing.Size(75, 33)
        Me.btnMailingListEdit.TabIndex = 10
        Me.btnMailingListEdit.Text = "Edit"
        Me.btnMailingListEdit.UseVisualStyleBackColor = True
        '
        'btnMailingListAddNew
        '
        Me.btnMailingListAddNew.Location = New System.Drawing.Point(452, 17)
        Me.btnMailingListAddNew.Name = "btnMailingListAddNew"
        Me.btnMailingListAddNew.Size = New System.Drawing.Size(75, 33)
        Me.btnMailingListAddNew.TabIndex = 9
        Me.btnMailingListAddNew.Text = "Add New"
        Me.btnMailingListAddNew.UseVisualStyleBackColor = True
        '
        'btnMailingListSave
        '
        Me.btnMailingListSave.Enabled = False
        Me.btnMailingListSave.Location = New System.Drawing.Point(452, 60)
        Me.btnMailingListSave.Name = "btnMailingListSave"
        Me.btnMailingListSave.Size = New System.Drawing.Size(75, 33)
        Me.btnMailingListSave.TabIndex = 8
        Me.btnMailingListSave.Text = "Save"
        Me.btnMailingListSave.UseVisualStyleBackColor = True
        '
        'chkMonthly
        '
        Me.chkMonthly.AutoSize = True
        Me.chkMonthly.Enabled = False
        Me.chkMonthly.Location = New System.Drawing.Point(349, 73)
        Me.chkMonthly.Name = "chkMonthly"
        Me.chkMonthly.Size = New System.Drawing.Size(79, 22)
        Me.chkMonthly.TabIndex = 7
        Me.chkMonthly.Text = "Monthly"
        Me.chkMonthly.UseVisualStyleBackColor = True
        '
        'chkWeekly
        '
        Me.chkWeekly.AutoSize = True
        Me.chkWeekly.Enabled = False
        Me.chkWeekly.Location = New System.Drawing.Point(349, 45)
        Me.chkWeekly.Name = "chkWeekly"
        Me.chkWeekly.Size = New System.Drawing.Size(73, 22)
        Me.chkWeekly.TabIndex = 6
        Me.chkWeekly.Text = "Weekly"
        Me.chkWeekly.UseVisualStyleBackColor = True
        '
        'chkDaily
        '
        Me.chkDaily.AutoSize = True
        Me.chkDaily.Enabled = False
        Me.chkDaily.Location = New System.Drawing.Point(349, 17)
        Me.chkDaily.Name = "chkDaily"
        Me.chkDaily.Size = New System.Drawing.Size(58, 22)
        Me.chkDaily.TabIndex = 5
        Me.chkDaily.Text = "Daily"
        Me.chkDaily.UseVisualStyleBackColor = True
        '
        'cboMailingListStatus
        '
        Me.cboMailingListStatus.Enabled = False
        Me.cboMailingListStatus.FormattingEnabled = True
        Me.cboMailingListStatus.Items.AddRange(New Object() {"ACTIVE", "INACTIVE"})
        Me.cboMailingListStatus.Location = New System.Drawing.Point(108, 60)
        Me.cboMailingListStatus.Name = "cboMailingListStatus"
        Me.cboMailingListStatus.Size = New System.Drawing.Size(220, 26)
        Me.cboMailingListStatus.TabIndex = 4
        '
        'txtMailingListEmailAddress
        '
        Me.txtMailingListEmailAddress.Enabled = False
        Me.txtMailingListEmailAddress.Location = New System.Drawing.Point(108, 25)
        Me.txtMailingListEmailAddress.Name = "txtMailingListEmailAddress"
        Me.txtMailingListEmailAddress.Size = New System.Drawing.Size(220, 26)
        Me.txtMailingListEmailAddress.TabIndex = 3
        '
        'lblMailingListStatus
        '
        Me.lblMailingListStatus.AutoSize = True
        Me.lblMailingListStatus.Location = New System.Drawing.Point(49, 63)
        Me.lblMailingListStatus.Name = "lblMailingListStatus"
        Me.lblMailingListStatus.Size = New System.Drawing.Size(53, 18)
        Me.lblMailingListStatus.TabIndex = 2
        Me.lblMailingListStatus.Text = "Status: "
        '
        'lblMailingListEmailAddress
        '
        Me.lblMailingListEmailAddress.AutoSize = True
        Me.lblMailingListEmailAddress.Location = New System.Drawing.Point(8, 28)
        Me.lblMailingListEmailAddress.Name = "lblMailingListEmailAddress"
        Me.lblMailingListEmailAddress.Size = New System.Drawing.Size(102, 18)
        Me.lblMailingListEmailAddress.TabIndex = 1
        Me.lblMailingListEmailAddress.Text = "Email Address: "
        '
        'gvMailingList
        '
        Me.gvMailingList.AllowUserToAddRows = False
        Me.gvMailingList.AllowUserToDeleteRows = False
        Me.gvMailingList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvMailingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvMailingList.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gvMailingList.Location = New System.Drawing.Point(0, 101)
        Me.gvMailingList.Name = "gvMailingList"
        Me.gvMailingList.ReadOnly = True
        Me.gvMailingList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvMailingList.Size = New System.Drawing.Size(616, 338)
        Me.gvMailingList.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.lblOtherConfigurationConfigId)
        Me.TabPage4.Controls.Add(Me.btnOtherConfigurationSave)
        Me.TabPage4.Controls.Add(Me.txtOtherConfigurationConfigValue)
        Me.TabPage4.Controls.Add(Me.lblOtherConfigurationConfigName)
        Me.TabPage4.Location = New System.Drawing.Point(4, 27)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(616, 439)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Other Configuration"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'lblOtherConfigurationConfigName
        '
        Me.lblOtherConfigurationConfigName.AutoSize = True
        Me.lblOtherConfigurationConfigName.Location = New System.Drawing.Point(13, 18)
        Me.lblOtherConfigurationConfigName.Name = "lblOtherConfigurationConfigName"
        Me.lblOtherConfigurationConfigName.Size = New System.Drawing.Size(117, 18)
        Me.lblOtherConfigurationConfigName.TabIndex = 0
        Me.lblOtherConfigurationConfigName.Text = "Reports Location: "
        '
        'txtOtherConfigurationConfigValue
        '
        Me.txtOtherConfigurationConfigValue.Location = New System.Drawing.Point(136, 15)
        Me.txtOtherConfigurationConfigValue.Name = "txtOtherConfigurationConfigValue"
        Me.txtOtherConfigurationConfigValue.Size = New System.Drawing.Size(462, 26)
        Me.txtOtherConfigurationConfigValue.TabIndex = 1
        '
        'btnOtherConfigurationSave
        '
        Me.btnOtherConfigurationSave.Location = New System.Drawing.Point(481, 47)
        Me.btnOtherConfigurationSave.Name = "btnOtherConfigurationSave"
        Me.btnOtherConfigurationSave.Size = New System.Drawing.Size(117, 39)
        Me.btnOtherConfigurationSave.TabIndex = 2
        Me.btnOtherConfigurationSave.Text = "Save"
        Me.btnOtherConfigurationSave.UseVisualStyleBackColor = True
        '
        'lblOtherConfigurationConfigId
        '
        Me.lblOtherConfigurationConfigId.AutoSize = True
        Me.lblOtherConfigurationConfigId.Location = New System.Drawing.Point(16, 72)
        Me.lblOtherConfigurationConfigId.Name = "lblOtherConfigurationConfigId"
        Me.lblOtherConfigurationConfigId.Size = New System.Drawing.Size(48, 18)
        Me.lblOtherConfigurationConfigId.TabIndex = 3
        Me.lblOtherConfigurationConfigId.Text = "Label1"
        Me.lblOtherConfigurationConfigId.Visible = False
        '
        'RedSkyConfiguration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 470)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "RedSkyConfiguration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  RedSky Configuration"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.gvMailingList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnSaveReportConfiguration As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblMonthyNextReport As Label
    Friend WithEvents lblMonthlyLastReport As Label
    Friend WithEvents cboMonthlyStatus As ComboBox
    Friend WithEvents dtMonthly As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblWeeklyGenerationTime As Label
    Friend WithEvents lblWeeklyNextReport As Label
    Friend WithEvents lblWeeklyLastReport As Label
    Friend WithEvents cboWeeklyStatus As ComboBox
    Friend WithEvents dtWeekly As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDailyGenerationTime As Label
    Friend WithEvents lblDailyNextReport As Label
    Friend WithEvents lblDailyLastReport As Label
    Friend WithEvents cboDailyStatus As ComboBox
    Friend WithEvents dtDaily As DateTimePicker
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnSaveMailingConfiguration As Button
    Friend WithEvents lblSMTPPassword As Label
    Friend WithEvents lblSMTPUsername As Label
    Friend WithEvents lblSMTPUseTLSSSL As Label
    Friend WithEvents lblSMTPPortSSL As Label
    Friend WithEvents lblSMTPServer As Label
    Friend WithEvents txtSMTPPassword As TextBox
    Friend WithEvents txtSMTPUsername As TextBox
    Friend WithEvents txtSMTPPortSSL As TextBox
    Friend WithEvents txtSMTPServer As TextBox
    Friend WithEvents gvMailingList As DataGridView
    Friend WithEvents lblSMTPId As Label
    Friend WithEvents cboSMTPUseTLSSSL As ComboBox
    Friend WithEvents btnMailingListEdit As Button
    Friend WithEvents btnMailingListAddNew As Button
    Friend WithEvents btnMailingListSave As Button
    Friend WithEvents chkMonthly As CheckBox
    Friend WithEvents chkWeekly As CheckBox
    Friend WithEvents chkDaily As CheckBox
    Friend WithEvents cboMailingListStatus As ComboBox
    Friend WithEvents txtMailingListEmailAddress As TextBox
    Friend WithEvents lblMailingListStatus As Label
    Friend WithEvents lblMailingListEmailAddress As Label
    Friend WithEvents lblMailingListId As Label
    Friend WithEvents btnMailingListCancel As Button
    Friend WithEvents lblDailyTo As Label
    Friend WithEvents lblDailyFrom As Label
    Friend WithEvents dtDailyTo As DateTimePicker
    Friend WithEvents dtDailyFrom As DateTimePicker
    Friend WithEvents lblWeeklyDay As Label
    Friend WithEvents cboWeeklyDay As ComboBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents btnOtherConfigurationSave As Button
    Friend WithEvents txtOtherConfigurationConfigValue As TextBox
    Friend WithEvents lblOtherConfigurationConfigName As Label
    Friend WithEvents lblOtherConfigurationConfigId As Label
End Class
