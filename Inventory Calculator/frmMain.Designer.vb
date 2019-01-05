<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFeetInRoll = New System.Windows.Forms.TextBox()
        Me.txtFeetUsed = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalUsedOfRoll = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtShinglesOrBundlesUsed = New System.Windows.Forms.TextBox()
        Me.radBundle = New System.Windows.Forms.RadioButton()
        Me.radShingle = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radSupreme = New System.Windows.Forms.RadioButton()
        Me.radLandmarkPro = New System.Windows.Forms.RadioButton()
        Me.radOakridge = New System.Windows.Forms.RadioButton()
        Me.radLandmark = New System.Windows.Forms.RadioButton()
        Me.radTimberlineHD = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotalUsedOfSquare = New System.Windows.Forms.Label()
        Me.btnRLCalculate = New System.Windows.Forms.Button()
        Me.btnSHClear = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Roll Feet:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Feet Used:"
        '
        'txtFeetInRoll
        '
        Me.txtFeetInRoll.Location = New System.Drawing.Point(158, 58)
        Me.txtFeetInRoll.Name = "txtFeetInRoll"
        Me.txtFeetInRoll.Size = New System.Drawing.Size(89, 29)
        Me.txtFeetInRoll.TabIndex = 2
        '
        'txtFeetUsed
        '
        Me.txtFeetUsed.Location = New System.Drawing.Point(158, 22)
        Me.txtFeetUsed.Name = "txtFeetUsed"
        Me.txtFeetUsed.Size = New System.Drawing.Size(89, 29)
        Me.txtFeetUsed.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Decimal:"
        '
        'lblTotalUsedOfRoll
        '
        Me.lblTotalUsedOfRoll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalUsedOfRoll.Location = New System.Drawing.Point(157, 97)
        Me.lblTotalUsedOfRoll.Name = "lblTotalUsedOfRoll"
        Me.lblTotalUsedOfRoll.Size = New System.Drawing.Size(89, 27)
        Me.lblTotalUsedOfRoll.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(157, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 33)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "&Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(31, 140)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 33)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cl&ear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Quantity Used:"
        '
        'txtShinglesOrBundlesUsed
        '
        Me.txtShinglesOrBundlesUsed.Location = New System.Drawing.Point(171, 36)
        Me.txtShinglesOrBundlesUsed.Name = "txtShinglesOrBundlesUsed"
        Me.txtShinglesOrBundlesUsed.Size = New System.Drawing.Size(75, 29)
        Me.txtShinglesOrBundlesUsed.TabIndex = 9
        '
        'radBundle
        '
        Me.radBundle.AutoSize = True
        Me.radBundle.Location = New System.Drawing.Point(6, 20)
        Me.radBundle.Name = "radBundle"
        Me.radBundle.Size = New System.Drawing.Size(91, 27)
        Me.radBundle.TabIndex = 0
        Me.radBundle.TabStop = True
        Me.radBundle.Text = "Bundles"
        Me.radBundle.UseVisualStyleBackColor = True
        '
        'radShingle
        '
        Me.radShingle.AutoSize = True
        Me.radShingle.Location = New System.Drawing.Point(115, 20)
        Me.radShingle.Name = "radShingle"
        Me.radShingle.Size = New System.Drawing.Size(94, 27)
        Me.radShingle.TabIndex = 1
        Me.radShingle.TabStop = True
        Me.radShingle.Text = "Shingles"
        Me.radShingle.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radShingle)
        Me.GroupBox1.Controls.Add(Me.radBundle)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 47)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose Material Type:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radSupreme)
        Me.GroupBox2.Controls.Add(Me.radLandmarkPro)
        Me.GroupBox2.Controls.Add(Me.radOakridge)
        Me.GroupBox2.Controls.Add(Me.radLandmark)
        Me.GroupBox2.Controls.Add(Me.radTimberlineHD)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(215, 171)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Choose Shingle"
        '
        'radSupreme
        '
        Me.radSupreme.AutoSize = True
        Me.radSupreme.Location = New System.Drawing.Point(6, 132)
        Me.radSupreme.Name = "radSupreme"
        Me.radSupreme.Size = New System.Drawing.Size(128, 27)
        Me.radSupreme.TabIndex = 16
        Me.radSupreme.TabStop = True
        Me.radSupreme.Text = "OC Supreme"
        Me.radSupreme.UseVisualStyleBackColor = True
        '
        'radLandmarkPro
        '
        Me.radLandmarkPro.AutoSize = True
        Me.radLandmarkPro.Location = New System.Drawing.Point(6, 78)
        Me.radLandmarkPro.Name = "radLandmarkPro"
        Me.radLandmarkPro.Size = New System.Drawing.Size(162, 27)
        Me.radLandmarkPro.TabIndex = 15
        Me.radLandmarkPro.TabStop = True
        Me.radLandmarkPro.Text = "CT Landmark Pro"
        Me.radLandmarkPro.UseVisualStyleBackColor = True
        '
        'radOakridge
        '
        Me.radOakridge.AutoSize = True
        Me.radOakridge.Location = New System.Drawing.Point(6, 105)
        Me.radOakridge.Name = "radOakridge"
        Me.radOakridge.Size = New System.Drawing.Size(129, 27)
        Me.radOakridge.TabIndex = 14
        Me.radOakridge.TabStop = True
        Me.radOakridge.Text = "OC Oakridge"
        Me.radOakridge.UseVisualStyleBackColor = True
        '
        'radLandmark
        '
        Me.radLandmark.AutoSize = True
        Me.radLandmark.Location = New System.Drawing.Point(6, 51)
        Me.radLandmark.Name = "radLandmark"
        Me.radLandmark.Size = New System.Drawing.Size(131, 27)
        Me.radLandmark.TabIndex = 13
        Me.radLandmark.TabStop = True
        Me.radLandmark.Text = "CT Landmark"
        Me.radLandmark.UseVisualStyleBackColor = True
        '
        'radTimberlineHD
        '
        Me.radTimberlineHD.AutoSize = True
        Me.radTimberlineHD.Location = New System.Drawing.Point(6, 24)
        Me.radTimberlineHD.Name = "radTimberlineHD"
        Me.radTimberlineHD.Size = New System.Drawing.Size(176, 27)
        Me.radTimberlineHD.TabIndex = 12
        Me.radTimberlineHD.TabStop = True
        Me.radTimberlineHD.Text = "GAF Timberline HD"
        Me.radTimberlineHD.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Decimal:"
        '
        'lblTotalUsedOfSquare
        '
        Me.lblTotalUsedOfSquare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalUsedOfSquare.Location = New System.Drawing.Point(171, 298)
        Me.lblTotalUsedOfSquare.Name = "lblTotalUsedOfSquare"
        Me.lblTotalUsedOfSquare.Size = New System.Drawing.Size(76, 26)
        Me.lblTotalUsedOfSquare.TabIndex = 13
        '
        'btnRLCalculate
        '
        Me.btnRLCalculate.Location = New System.Drawing.Point(134, 338)
        Me.btnRLCalculate.Name = "btnRLCalculate"
        Me.btnRLCalculate.Size = New System.Drawing.Size(112, 33)
        Me.btnRLCalculate.TabIndex = 14
        Me.btnRLCalculate.Text = "Calculate"
        Me.btnRLCalculate.UseVisualStyleBackColor = True
        '
        'btnSHClear
        '
        Me.btnSHClear.Location = New System.Drawing.Point(31, 338)
        Me.btnSHClear.Name = "btnSHClear"
        Me.btnSHClear.Size = New System.Drawing.Size(69, 33)
        Me.btnSHClear.TabIndex = 15
        Me.btnSHClear.Text = "Clear"
        Me.btnSHClear.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtFeetUsed)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtFeetInRoll)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.lblTotalUsedOfRoll)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(281, 192)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Roll Calculator"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtShinglesOrBundlesUsed)
        Me.GroupBox4.Controls.Add(Me.btnRLCalculate)
        Me.GroupBox4.Controls.Add(Me.btnSHClear)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.lblTotalUsedOfSquare)
        Me.GroupBox4.Location = New System.Drawing.Point(4, 210)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(281, 383)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Shingle Calculator"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 587)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Job-Costing Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFeetInRoll As System.Windows.Forms.TextBox
    Friend WithEvents txtFeetUsed As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotalUsedOfRoll As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtShinglesOrBundlesUsed As System.Windows.Forms.TextBox
    Friend WithEvents radBundle As System.Windows.Forms.RadioButton
    Friend WithEvents radShingle As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radTimberlineHD As System.Windows.Forms.RadioButton
    Friend WithEvents radOakridge As System.Windows.Forms.RadioButton
    Friend WithEvents radLandmark As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTotalUsedOfSquare As System.Windows.Forms.Label
    Friend WithEvents btnRLCalculate As System.Windows.Forms.Button
    Friend WithEvents btnSHClear As System.Windows.Forms.Button
    Friend WithEvents radSupreme As System.Windows.Forms.RadioButton
    Friend WithEvents radLandmarkPro As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox

End Class
