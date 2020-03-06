<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblRegular = New System.Windows.Forms.Label()
        Me.lblDecaf = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.txtDecaf = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtRegular = New System.Windows.Forms.TextBox()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.lstConfirm = New System.Windows.Forms.ListBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblRegular
        '
        Me.lblRegular.AutoSize = True
        Me.lblRegular.ForeColor = System.Drawing.Color.Sienna
        Me.lblRegular.Location = New System.Drawing.Point(23, 57)
        Me.lblRegular.Name = "lblRegular"
        Me.lblRegular.Size = New System.Drawing.Size(44, 13)
        Me.lblRegular.TabIndex = 0
        Me.lblRegular.Text = "Regular"
        '
        'lblDecaf
        '
        Me.lblDecaf.AutoSize = True
        Me.lblDecaf.ForeColor = System.Drawing.Color.Sienna
        Me.lblDecaf.Location = New System.Drawing.Point(26, 91)
        Me.lblDecaf.Name = "lblDecaf"
        Me.lblDecaf.Size = New System.Drawing.Size(36, 13)
        Me.lblDecaf.TabIndex = 1
        Me.lblDecaf.Text = "Decaf"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.ForeColor = System.Drawing.Color.Sienna
        Me.lblTotalPrice.Location = New System.Drawing.Point(23, 161)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalPrice.TabIndex = 2
        Me.lblTotalPrice.Text = "Total Price"
        '
        'txtDecaf
        '
        Me.txtDecaf.Location = New System.Drawing.Point(103, 91)
        Me.txtDecaf.Name = "txtDecaf"
        Me.txtDecaf.Size = New System.Drawing.Size(100, 20)
        Me.txtDecaf.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.ForeColor = System.Drawing.Color.Peru
        Me.btnCalculate.Location = New System.Drawing.Point(114, 117)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtRegular
        '
        Me.txtRegular.Location = New System.Drawing.Point(103, 57)
        Me.txtRegular.Name = "txtRegular"
        Me.txtRegular.Size = New System.Drawing.Size(100, 20)
        Me.txtRegular.TabIndex = 5
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Location = New System.Drawing.Point(103, 161)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalPrice.TabIndex = 6
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.Color.Chocolate
        Me.lblName.Location = New System.Drawing.Point(41, 289)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Name"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.ForeColor = System.Drawing.Color.Chocolate
        Me.lblAddress.Location = New System.Drawing.Point(40, 326)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 8
        Me.lblAddress.Text = "Address"
        '
        'txtCity
        '
        Me.txtCity.AutoSize = True
        Me.txtCity.ForeColor = System.Drawing.Color.Chocolate
        Me.txtCity.Location = New System.Drawing.Point(42, 363)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(24, 13)
        Me.txtCity.TabIndex = 9
        Me.txtCity.Text = "City"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.ForeColor = System.Drawing.Color.Chocolate
        Me.lblState.Location = New System.Drawing.Point(42, 399)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(32, 13)
        Me.lblState.TabIndex = 10
        Me.lblState.Text = "State"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.ForeColor = System.Drawing.Color.Chocolate
        Me.lblZip.Location = New System.Drawing.Point(42, 434)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(50, 13)
        Me.lblZip.TabIndex = 11
        Me.lblZip.Text = "Zip Code"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(114, 289)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 12
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(114, 326)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtAddress.TabIndex = 13
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(114, 363)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 14
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(114, 399)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(100, 20)
        Me.txtState.TabIndex = 15
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(114, 434)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(100, 20)
        Me.txtZip.TabIndex = 16
        '
        'lstConfirm
        '
        Me.lstConfirm.FormattingEnabled = True
        Me.lstConfirm.Location = New System.Drawing.Point(282, 326)
        Me.lstConfirm.Name = "lstConfirm"
        Me.lstConfirm.Size = New System.Drawing.Size(120, 95)
        Me.lstConfirm.TabIndex = 17
        '
        'btnConfirm
        '
        Me.btnConfirm.ForeColor = System.Drawing.Color.Peru
        Me.btnConfirm.Location = New System.Drawing.Point(128, 485)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 18
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(26, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 32)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Celestial Coffee"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 548)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lstConfirm)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.txtRegular)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtDecaf)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.lblDecaf)
        Me.Controls.Add(Me.lblRegular)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRegular As Label
    Friend WithEvents lblDecaf As Label
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents txtDecaf As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtRegular As TextBox
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtCity As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblZip As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents lstConfirm As ListBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents Label1 As Label
End Class
