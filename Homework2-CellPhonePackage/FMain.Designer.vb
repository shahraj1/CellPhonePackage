<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMain
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpSelectaPlan = New System.Windows.Forms.GroupBox()
        Me.btnFamily = New System.Windows.Forms.Button()
        Me.btnIndividual = New System.Windows.Forms.Button()
        Me.lblFamily = New System.Windows.Forms.Label()
        Me.lblInvidiual = New System.Windows.Forms.Label()
        Me.grpSelectaPlan.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(288, 218)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(90, 43)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'grpSelectaPlan
        '
        Me.grpSelectaPlan.Controls.Add(Me.btnFamily)
        Me.grpSelectaPlan.Controls.Add(Me.btnIndividual)
        Me.grpSelectaPlan.Controls.Add(Me.lblFamily)
        Me.grpSelectaPlan.Controls.Add(Me.lblInvidiual)
        Me.grpSelectaPlan.Location = New System.Drawing.Point(23, 12)
        Me.grpSelectaPlan.Name = "grpSelectaPlan"
        Me.grpSelectaPlan.Size = New System.Drawing.Size(377, 190)
        Me.grpSelectaPlan.TabIndex = 0
        Me.grpSelectaPlan.TabStop = False
        Me.grpSelectaPlan.Text = "Select a Plan"
        '
        'btnFamily
        '
        Me.btnFamily.BackColor = System.Drawing.SystemColors.Control
        Me.btnFamily.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFamily.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFamily.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFamily.Location = New System.Drawing.Point(268, 98)
        Me.btnFamily.Name = "btnFamily"
        Me.btnFamily.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnFamily.Size = New System.Drawing.Size(90, 43)
        Me.btnFamily.TabIndex = 3
        Me.btnFamily.Text = "Family"
        Me.btnFamily.UseVisualStyleBackColor = False
        '
        'btnIndividual
        '
        Me.btnIndividual.BackColor = System.Drawing.SystemColors.Control
        Me.btnIndividual.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnIndividual.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIndividual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnIndividual.Location = New System.Drawing.Point(268, 34)
        Me.btnIndividual.Name = "btnIndividual"
        Me.btnIndividual.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnIndividual.Size = New System.Drawing.Size(90, 43)
        Me.btnIndividual.TabIndex = 1
        Me.btnIndividual.Text = "Individual"
        Me.btnIndividual.UseVisualStyleBackColor = False
        '
        'lblFamily
        '
        Me.lblFamily.BackColor = System.Drawing.SystemColors.Control
        Me.lblFamily.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFamily.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFamily.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFamily.Location = New System.Drawing.Point(18, 98)
        Me.lblFamily.Name = "lblFamily"
        Me.lblFamily.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFamily.Size = New System.Drawing.Size(203, 66)
        Me.lblFamily.TabIndex = 2
        Me.lblFamily.Text = "The Family plan allows you to purchase multiple cell phones of the same model, wi" & _
    "th each phone sharing one monthly package."
        '
        'lblInvidiual
        '
        Me.lblInvidiual.BackColor = System.Drawing.SystemColors.Control
        Me.lblInvidiual.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblInvidiual.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvidiual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblInvidiual.Location = New System.Drawing.Point(18, 34)
        Me.lblInvidiual.Name = "lblInvidiual"
        Me.lblInvidiual.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInvidiual.Size = New System.Drawing.Size(203, 64)
        Me.lblInvidiual.TabIndex = 0
        Me.lblInvidiual.Text = "The Individual plan provides one cell phone and a variety of monthly packages."
        '
        'FMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 284)
        Me.Controls.Add(Me.grpSelectaPlan)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cell Phone Packages"
        Me.grpSelectaPlan.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents grpSelectaPlan As System.Windows.Forms.GroupBox
    Public WithEvents btnFamily As System.Windows.Forms.Button
    Public WithEvents btnIndividual As System.Windows.Forms.Button
    Public WithEvents lblFamily As System.Windows.Forms.Label
    Public WithEvents lblInvidiual As System.Windows.Forms.Label

End Class
