<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FFamily
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
        Me.txtNumPhones = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grpTotals = New System.Windows.Forms.GroupBox()
        Me.txtTotalMonthlyCharge = New System.Windows.Forms.TextBox()
        Me.txtPackageCharge = New System.Windows.Forms.TextBox()
        Me.txtOptions = New System.Windows.Forms.TextBox()
        Me.txtPhoneSubTotal = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblPackageCharge = New System.Windows.Forms.Label()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.lblTotalMontlyCharge = New System.Windows.Forms.Label()
        Me.lblPhoneSubTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.grpSelectaPackage = New System.Windows.Forms.GroupBox()
        Me.radPlanUnlimited = New System.Windows.Forms.RadioButton()
        Me.radPlan1500 = New System.Windows.Forms.RadioButton()
        Me.radPlan800 = New System.Windows.Forms.RadioButton()
        Me.grpSelectaPhone = New System.Windows.Forms.GroupBox()
        Me.radModel200 = New System.Windows.Forms.RadioButton()
        Me.radModel110 = New System.Windows.Forms.RadioButton()
        Me.radModel100 = New System.Windows.Forms.RadioButton()
        Me.grpSelectaOption = New System.Windows.Forms.GroupBox()
        Me.chkTextMessaging = New System.Windows.Forms.CheckBox()
        Me.chkVoiceMail = New System.Windows.Forms.CheckBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpTotals.SuspendLayout()
        Me.grpSelectaPackage.SuspendLayout()
        Me.grpSelectaPhone.SuspendLayout()
        Me.grpSelectaOption.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNumPhones
        '
        Me.txtNumPhones.AcceptsReturn = True
        Me.txtNumPhones.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumPhones.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumPhones.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumPhones.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNumPhones.Location = New System.Drawing.Point(178, 24)
        Me.txtNumPhones.MaxLength = 0
        Me.txtNumPhones.Name = "txtNumPhones"
        Me.txtNumPhones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNumPhones.Size = New System.Drawing.Size(40, 23)
        Me.txtNumPhones.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(27, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(136, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Number of Phones"
        '
        'grpTotals
        '
        Me.grpTotals.Controls.Add(Me.txtTotalMonthlyCharge)
        Me.grpTotals.Controls.Add(Me.txtPackageCharge)
        Me.grpTotals.Controls.Add(Me.txtOptions)
        Me.grpTotals.Controls.Add(Me.txtPhoneSubTotal)
        Me.grpTotals.Controls.Add(Me.txtTax)
        Me.grpTotals.Controls.Add(Me.txtPhone)
        Me.grpTotals.Controls.Add(Me.lblPackageCharge)
        Me.grpTotals.Controls.Add(Me.lblOptions)
        Me.grpTotals.Controls.Add(Me.lblTotalMontlyCharge)
        Me.grpTotals.Controls.Add(Me.lblPhoneSubTotal)
        Me.grpTotals.Controls.Add(Me.lblTax)
        Me.grpTotals.Controls.Add(Me.lblPhone)
        Me.grpTotals.Location = New System.Drawing.Point(195, 195)
        Me.grpTotals.Name = "grpTotals"
        Me.grpTotals.Size = New System.Drawing.Size(256, 225)
        Me.grpTotals.TabIndex = 7
        Me.grpTotals.TabStop = False
        Me.grpTotals.Text = "Totals"
        '
        'txtTotalMonthlyCharge
        '
        Me.txtTotalMonthlyCharge.Enabled = False
        Me.txtTotalMonthlyCharge.Location = New System.Drawing.Point(152, 165)
        Me.txtTotalMonthlyCharge.Name = "txtTotalMonthlyCharge"
        Me.txtTotalMonthlyCharge.Size = New System.Drawing.Size(77, 22)
        Me.txtTotalMonthlyCharge.TabIndex = 11
        '
        'txtPackageCharge
        '
        Me.txtPackageCharge.Enabled = False
        Me.txtPackageCharge.Location = New System.Drawing.Point(152, 138)
        Me.txtPackageCharge.Name = "txtPackageCharge"
        Me.txtPackageCharge.Size = New System.Drawing.Size(77, 22)
        Me.txtPackageCharge.TabIndex = 10
        '
        'txtOptions
        '
        Me.txtOptions.Enabled = False
        Me.txtOptions.Location = New System.Drawing.Point(152, 110)
        Me.txtOptions.Name = "txtOptions"
        Me.txtOptions.Size = New System.Drawing.Size(77, 22)
        Me.txtOptions.TabIndex = 9
        '
        'txtPhoneSubTotal
        '
        Me.txtPhoneSubTotal.Enabled = False
        Me.txtPhoneSubTotal.Location = New System.Drawing.Point(152, 82)
        Me.txtPhoneSubTotal.Name = "txtPhoneSubTotal"
        Me.txtPhoneSubTotal.Size = New System.Drawing.Size(77, 22)
        Me.txtPhoneSubTotal.TabIndex = 8
        '
        'txtTax
        '
        Me.txtTax.Enabled = False
        Me.txtTax.Location = New System.Drawing.Point(152, 54)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(77, 22)
        Me.txtTax.TabIndex = 7
        '
        'txtPhone
        '
        Me.txtPhone.Enabled = False
        Me.txtPhone.Location = New System.Drawing.Point(152, 27)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(77, 22)
        Me.txtPhone.TabIndex = 6
        '
        'lblPackageCharge
        '
        Me.lblPackageCharge.BackColor = System.Drawing.SystemColors.Control
        Me.lblPackageCharge.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPackageCharge.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPackageCharge.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPackageCharge.Location = New System.Drawing.Point(6, 140)
        Me.lblPackageCharge.Name = "lblPackageCharge"
        Me.lblPackageCharge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPackageCharge.Size = New System.Drawing.Size(117, 20)
        Me.lblPackageCharge.TabIndex = 4
        Me.lblPackageCharge.Text = "Package Charge"
        Me.lblPackageCharge.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblOptions
        '
        Me.lblOptions.BackColor = System.Drawing.SystemColors.Control
        Me.lblOptions.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOptions.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptions.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOptions.Location = New System.Drawing.Point(27, 113)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOptions.Size = New System.Drawing.Size(97, 19)
        Me.lblOptions.TabIndex = 3
        Me.lblOptions.Text = "Options"
        Me.lblOptions.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalMontlyCharge
        '
        Me.lblTotalMontlyCharge.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotalMontlyCharge.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotalMontlyCharge.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalMontlyCharge.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotalMontlyCharge.Location = New System.Drawing.Point(27, 168)
        Me.lblTotalMontlyCharge.Name = "lblTotalMontlyCharge"
        Me.lblTotalMontlyCharge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotalMontlyCharge.Size = New System.Drawing.Size(97, 38)
        Me.lblTotalMontlyCharge.TabIndex = 5
        Me.lblTotalMontlyCharge.Text = "Total Monthly Charge"
        Me.lblTotalMontlyCharge.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPhoneSubTotal
        '
        Me.lblPhoneSubTotal.BackColor = System.Drawing.SystemColors.Control
        Me.lblPhoneSubTotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPhoneSubTotal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneSubTotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPhoneSubTotal.Location = New System.Drawing.Point(27, 85)
        Me.lblPhoneSubTotal.Name = "lblPhoneSubTotal"
        Me.lblPhoneSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPhoneSubTotal.Size = New System.Drawing.Size(97, 19)
        Me.lblPhoneSubTotal.TabIndex = 2
        Me.lblPhoneSubTotal.Text = "Phone Total"
        Me.lblPhoneSubTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.SystemColors.Control
        Me.lblTax.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTax.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTax.Location = New System.Drawing.Point(27, 57)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTax.Size = New System.Drawing.Size(97, 20)
        Me.lblTax.TabIndex = 1
        Me.lblTax.Text = "Tax"
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPhone
        '
        Me.lblPhone.BackColor = System.Drawing.SystemColors.Control
        Me.lblPhone.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPhone.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPhone.Location = New System.Drawing.Point(27, 29)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPhone.Size = New System.Drawing.Size(97, 20)
        Me.lblPhone.TabIndex = 0
        Me.lblPhone.Text = "Phone Subtotal"
        Me.lblPhone.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'grpSelectaPackage
        '
        Me.grpSelectaPackage.Controls.Add(Me.radPlanUnlimited)
        Me.grpSelectaPackage.Controls.Add(Me.radPlan1500)
        Me.grpSelectaPackage.Controls.Add(Me.radPlan800)
        Me.grpSelectaPackage.Location = New System.Drawing.Point(195, 60)
        Me.grpSelectaPackage.Name = "grpSelectaPackage"
        Me.grpSelectaPackage.Size = New System.Drawing.Size(256, 108)
        Me.grpSelectaPackage.TabIndex = 4
        Me.grpSelectaPackage.TabStop = False
        Me.grpSelectaPackage.Text = "Select a Package"
        '
        'radPlanUnlimited
        '
        Me.radPlanUnlimited.BackColor = System.Drawing.SystemColors.Control
        Me.radPlanUnlimited.Cursor = System.Windows.Forms.Cursors.Default
        Me.radPlanUnlimited.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPlanUnlimited.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radPlanUnlimited.Location = New System.Drawing.Point(14, 78)
        Me.radPlanUnlimited.Name = "radPlanUnlimited"
        Me.radPlanUnlimited.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radPlanUnlimited.Size = New System.Drawing.Size(215, 20)
        Me.radPlanUnlimited.TabIndex = 2
        Me.radPlanUnlimited.TabStop = True
        Me.radPlanUnlimited.Text = "Unlimited minutes per month"
        Me.radPlanUnlimited.UseVisualStyleBackColor = False
        '
        'radPlan1500
        '
        Me.radPlan1500.BackColor = System.Drawing.SystemColors.Control
        Me.radPlan1500.Cursor = System.Windows.Forms.Cursors.Default
        Me.radPlan1500.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPlan1500.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radPlan1500.Location = New System.Drawing.Point(14, 50)
        Me.radPlan1500.Name = "radPlan1500"
        Me.radPlan1500.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radPlan1500.Size = New System.Drawing.Size(202, 20)
        Me.radPlan1500.TabIndex = 1
        Me.radPlan1500.TabStop = True
        Me.radPlan1500.Text = "1500 Minutes per month"
        Me.radPlan1500.UseVisualStyleBackColor = False
        '
        'radPlan800
        '
        Me.radPlan800.BackColor = System.Drawing.SystemColors.Control
        Me.radPlan800.Cursor = System.Windows.Forms.Cursors.Default
        Me.radPlan800.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPlan800.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radPlan800.Location = New System.Drawing.Point(14, 23)
        Me.radPlan800.Name = "radPlan800"
        Me.radPlan800.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radPlan800.Size = New System.Drawing.Size(202, 19)
        Me.radPlan800.TabIndex = 0
        Me.radPlan800.TabStop = True
        Me.radPlan800.Text = "800 Minutes per month"
        Me.radPlan800.UseVisualStyleBackColor = False
        '
        'grpSelectaPhone
        '
        Me.grpSelectaPhone.Controls.Add(Me.radModel200)
        Me.grpSelectaPhone.Controls.Add(Me.radModel110)
        Me.grpSelectaPhone.Controls.Add(Me.radModel100)
        Me.grpSelectaPhone.Location = New System.Drawing.Point(30, 57)
        Me.grpSelectaPhone.Name = "grpSelectaPhone"
        Me.grpSelectaPhone.Size = New System.Drawing.Size(141, 112)
        Me.grpSelectaPhone.TabIndex = 2
        Me.grpSelectaPhone.TabStop = False
        Me.grpSelectaPhone.Text = "Select a Phone"
        '
        'radModel200
        '
        Me.radModel200.BackColor = System.Drawing.SystemColors.Control
        Me.radModel200.Cursor = System.Windows.Forms.Cursors.Default
        Me.radModel200.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radModel200.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radModel200.Location = New System.Drawing.Point(17, 77)
        Me.radModel200.Name = "radModel200"
        Me.radModel200.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radModel200.Size = New System.Drawing.Size(106, 20)
        Me.radModel200.TabIndex = 2
        Me.radModel200.TabStop = True
        Me.radModel200.Text = "Model 200"
        Me.radModel200.UseVisualStyleBackColor = False
        '
        'radModel110
        '
        Me.radModel110.BackColor = System.Drawing.SystemColors.Control
        Me.radModel110.Cursor = System.Windows.Forms.Cursors.Default
        Me.radModel110.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radModel110.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radModel110.Location = New System.Drawing.Point(17, 49)
        Me.radModel110.Name = "radModel110"
        Me.radModel110.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radModel110.Size = New System.Drawing.Size(106, 20)
        Me.radModel110.TabIndex = 1
        Me.radModel110.TabStop = True
        Me.radModel110.Text = "Model 110"
        Me.radModel110.UseVisualStyleBackColor = False
        '
        'radModel100
        '
        Me.radModel100.BackColor = System.Drawing.SystemColors.Control
        Me.radModel100.Cursor = System.Windows.Forms.Cursors.Default
        Me.radModel100.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radModel100.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radModel100.Location = New System.Drawing.Point(17, 22)
        Me.radModel100.Name = "radModel100"
        Me.radModel100.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radModel100.Size = New System.Drawing.Size(106, 19)
        Me.radModel100.TabIndex = 0
        Me.radModel100.TabStop = True
        Me.radModel100.Text = "Model 100"
        Me.radModel100.UseVisualStyleBackColor = False
        '
        'grpSelectaOption
        '
        Me.grpSelectaOption.Controls.Add(Me.chkTextMessaging)
        Me.grpSelectaOption.Controls.Add(Me.chkVoiceMail)
        Me.grpSelectaOption.Location = New System.Drawing.Point(30, 195)
        Me.grpSelectaOption.Name = "grpSelectaOption"
        Me.grpSelectaOption.Size = New System.Drawing.Size(141, 113)
        Me.grpSelectaOption.TabIndex = 3
        Me.grpSelectaOption.TabStop = False
        Me.grpSelectaOption.Text = "Select Option"
        '
        'chkTextMessaging
        '
        Me.chkTextMessaging.BackColor = System.Drawing.SystemColors.Control
        Me.chkTextMessaging.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkTextMessaging.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTextMessaging.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkTextMessaging.Location = New System.Drawing.Point(11, 74)
        Me.chkTextMessaging.Name = "chkTextMessaging"
        Me.chkTextMessaging.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkTextMessaging.Size = New System.Drawing.Size(105, 20)
        Me.chkTextMessaging.TabIndex = 1
        Me.chkTextMessaging.Text = "Text Messaging"
        Me.chkTextMessaging.UseVisualStyleBackColor = False
        '
        'chkVoiceMail
        '
        Me.chkVoiceMail.BackColor = System.Drawing.SystemColors.Control
        Me.chkVoiceMail.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkVoiceMail.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVoiceMail.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkVoiceMail.Location = New System.Drawing.Point(11, 40)
        Me.chkVoiceMail.Name = "chkVoiceMail"
        Me.chkVoiceMail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkVoiceMail.Size = New System.Drawing.Size(106, 20)
        Me.chkVoiceMail.TabIndex = 0
        Me.chkVoiceMail.Text = "Voice Mail"
        Me.chkVoiceMail.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClose.Location = New System.Drawing.Point(37, 377)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClose.Size = New System.Drawing.Size(99, 32)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.Control
        Me.btnCalculate.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCalculate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCalculate.Location = New System.Drawing.Point(37, 328)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCalculate.Size = New System.Drawing.Size(99, 35)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'FFamily
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(479, 444)
        Me.Controls.Add(Me.grpTotals)
        Me.Controls.Add(Me.grpSelectaPackage)
        Me.Controls.Add(Me.grpSelectaPhone)
        Me.Controls.Add(Me.grpSelectaOption)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtNumPhones)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FFamily"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Family Plan"
        Me.grpTotals.ResumeLayout(False)
        Me.grpTotals.PerformLayout()
        Me.grpSelectaPackage.ResumeLayout(False)
        Me.grpSelectaPhone.ResumeLayout(False)
        Me.grpSelectaOption.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents txtNumPhones As System.Windows.Forms.TextBox
    Public WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents grpTotals As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalMonthlyCharge As System.Windows.Forms.TextBox
    Friend WithEvents txtPackageCharge As System.Windows.Forms.TextBox
    Friend WithEvents txtOptions As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtTax As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Public WithEvents lblPackageCharge As System.Windows.Forms.Label
    Public WithEvents lblOptions As System.Windows.Forms.Label
    Public WithEvents lblTotalMontlyCharge As System.Windows.Forms.Label
    Public WithEvents lblPhoneSubTotal As System.Windows.Forms.Label
    Public WithEvents lblTax As System.Windows.Forms.Label
    Public WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents grpSelectaPackage As System.Windows.Forms.GroupBox
    Public WithEvents radPlanUnlimited As System.Windows.Forms.RadioButton
    Public WithEvents radPlan1500 As System.Windows.Forms.RadioButton
    Public WithEvents radPlan800 As System.Windows.Forms.RadioButton
    Friend WithEvents grpSelectaPhone As System.Windows.Forms.GroupBox
    Public WithEvents radModel200 As System.Windows.Forms.RadioButton
    Public WithEvents radModel110 As System.Windows.Forms.RadioButton
    Public WithEvents radModel100 As System.Windows.Forms.RadioButton
    Friend WithEvents grpSelectaOption As System.Windows.Forms.GroupBox
    Public WithEvents chkTextMessaging As System.Windows.Forms.CheckBox
    Public WithEvents chkVoiceMail As System.Windows.Forms.CheckBox
    Public WithEvents btnClose As System.Windows.Forms.Button
    Public WithEvents btnCalculate As System.Windows.Forms.Button
End Class
