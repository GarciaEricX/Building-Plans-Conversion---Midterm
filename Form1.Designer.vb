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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpConversionType = New System.Windows.Forms.GroupBox()
        Me.radInchToMeter = New System.Windows.Forms.RadioButton()
        Me.radMeterToInch = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTItle = New System.Windows.Forms.Label()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblConversion = New System.Windows.Forms.Label()
        Me.grpConversionType.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.YellowGreen
        Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(82, 356)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(173, 49)
        Me.btnConvert.TabIndex = 0
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.YellowGreen
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(314, 356)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(173, 49)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.YellowGreen
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(546, 356)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(173, 49)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'grpConversionType
        '
        Me.grpConversionType.BackColor = System.Drawing.Color.YellowGreen
        Me.grpConversionType.Controls.Add(Me.radMeterToInch)
        Me.grpConversionType.Controls.Add(Me.radInchToMeter)
        Me.grpConversionType.Location = New System.Drawing.Point(367, 147)
        Me.grpConversionType.Name = "grpConversionType"
        Me.grpConversionType.Size = New System.Drawing.Size(200, 99)
        Me.grpConversionType.TabIndex = 3
        Me.grpConversionType.TabStop = False
        Me.grpConversionType.Text = "Convert Measurement"
        '
        'radInchToMeter
        '
        Me.radInchToMeter.AutoSize = True
        Me.radInchToMeter.Checked = True
        Me.radInchToMeter.Location = New System.Drawing.Point(7, 22)
        Me.radInchToMeter.Name = "radInchToMeter"
        Me.radInchToMeter.Size = New System.Drawing.Size(125, 20)
        Me.radInchToMeter.TabIndex = 0
        Me.radInchToMeter.TabStop = True
        Me.radInchToMeter.Text = "Inches to Meters"
        Me.radInchToMeter.UseVisualStyleBackColor = True
        '
        'radMeterToInch
        '
        Me.radMeterToInch.AutoSize = True
        Me.radMeterToInch.Location = New System.Drawing.Point(7, 49)
        Me.radMeterToInch.Name = "radMeterToInch"
        Me.radMeterToInch.Size = New System.Drawing.Size(125, 20)
        Me.radMeterToInch.TabIndex = 1
        Me.radMeterToInch.TabStop = True
        Me.radMeterToInch.Text = "Meters to Inches"
        Me.radMeterToInch.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(272, 222)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'lblTItle
        '
        Me.lblTItle.AutoSize = True
        Me.lblTItle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTItle.Location = New System.Drawing.Point(339, 37)
        Me.lblTItle.Name = "lblTItle"
        Me.lblTItle.Size = New System.Drawing.Size(196, 32)
        Me.lblTItle.TabIndex = 5
        Me.lblTItle.Text = "Converter App"
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInput.Location = New System.Drawing.Point(295, 90)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(333, 25)
        Me.lblInput.TabIndex = 6
        Me.lblInput.Text = "Enter a value and choose conversion"
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.Color.YellowGreen
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(636, 87)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(111, 35)
        Me.txtInput.TabIndex = 7
        '
        'lblConversion
        '
        Me.lblConversion.AutoSize = True
        Me.lblConversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConversion.Location = New System.Drawing.Point(340, 277)
        Me.lblConversion.Name = "lblConversion"
        Me.lblConversion.Size = New System.Drawing.Size(255, 25)
        Me.lblConversion.TabIndex = 8
        Me.lblConversion.Text = "XX meters is XXX inches"
        Me.lblConversion.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblConversion)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.lblTItle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpConversionType)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Name = "Form1"
        Me.Text = "Building Plans Conversion"
        Me.grpConversionType.ResumeLayout(False)
        Me.grpConversionType.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpConversionType As GroupBox
    Friend WithEvents radMeterToInch As RadioButton
    Friend WithEvents radInchToMeter As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTItle As Label
    Friend WithEvents lblInput As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblConversion As Label
End Class
