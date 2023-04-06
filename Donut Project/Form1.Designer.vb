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
        Me.RadNone = New System.Windows.Forms.RadioButton()
        Me.RadCappuccino = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadChocolate = New System.Windows.Forms.RadioButton()
        Me.RadFilled = New System.Windows.Forms.RadioButton()
        Me.RadSugar = New System.Windows.Forms.RadioButton()
        Me.RadGlazed = New System.Windows.Forms.RadioButton()
        Me.GroupDoughnut = New System.Windows.Forms.GroupBox()
        Me.GroupCoffee = New System.Windows.Forms.GroupBox()
        Me.lblsubbox = New System.Windows.Forms.Label()
        Me.Lblsalesbox = New System.Windows.Forms.Label()
        Me.Lbltotalbox = New System.Windows.Forms.Label()
        Me.LblSubtotal = New System.Windows.Forms.Label()
        Me.Lbltotaldue = New System.Windows.Forms.Label()
        Me.LblSalesTax = New System.Windows.Forms.Label()
        Me.Grouptotals = New System.Windows.Forms.GroupBox()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.GroupDoughnut.SuspendLayout()
        Me.GroupCoffee.SuspendLayout()
        Me.Grouptotals.SuspendLayout()
        Me.SuspendLayout()
        '
        'RadNone
        '
        Me.RadNone.AutoSize = True
        Me.RadNone.Location = New System.Drawing.Point(6, 33)
        Me.RadNone.Name = "RadNone"
        Me.RadNone.Size = New System.Drawing.Size(61, 20)
        Me.RadNone.TabIndex = 1
        Me.RadNone.TabStop = True
        Me.RadNone.Text = "None"
        Me.RadNone.UseVisualStyleBackColor = True
        '
        'RadCappuccino
        '
        Me.RadCappuccino.AutoSize = True
        Me.RadCappuccino.Location = New System.Drawing.Point(6, 85)
        Me.RadCappuccino.Name = "RadCappuccino"
        Me.RadCappuccino.Size = New System.Drawing.Size(142, 20)
        Me.RadCappuccino.TabIndex = 2
        Me.RadCappuccino.TabStop = True
        Me.RadCappuccino.Text = "Cappuccino ($2.75)"
        Me.RadCappuccino.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(6, 59)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(118, 20)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Regular ($1.50)"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadChocolate
        '
        Me.RadChocolate.AutoSize = True
        Me.RadChocolate.Location = New System.Drawing.Point(6, 106)
        Me.RadChocolate.Name = "RadChocolate"
        Me.RadChocolate.Size = New System.Drawing.Size(131, 20)
        Me.RadChocolate.TabIndex = 5
        Me.RadChocolate.TabStop = True
        Me.RadChocolate.Text = "Chocolate ($1.25)"
        Me.RadChocolate.UseVisualStyleBackColor = True
        '
        'RadFilled
        '
        Me.RadFilled.AutoSize = True
        Me.RadFilled.Location = New System.Drawing.Point(6, 141)
        Me.RadFilled.Name = "RadFilled"
        Me.RadFilled.Size = New System.Drawing.Size(103, 20)
        Me.RadFilled.TabIndex = 4
        Me.RadFilled.TabStop = True
        Me.RadFilled.Text = "Filled ($1.50)"
        Me.RadFilled.UseVisualStyleBackColor = True
        '
        'RadSugar
        '
        Me.RadSugar.AutoSize = True
        Me.RadSugar.Location = New System.Drawing.Point(6, 70)
        Me.RadSugar.Name = "RadSugar"
        Me.RadSugar.Size = New System.Drawing.Size(106, 20)
        Me.RadSugar.TabIndex = 6
        Me.RadSugar.TabStop = True
        Me.RadSugar.Text = "Sugar ($1.05)"
        Me.RadSugar.UseVisualStyleBackColor = True
        '
        'RadGlazed
        '
        Me.RadGlazed.AutoSize = True
        Me.RadGlazed.Location = New System.Drawing.Point(6, 32)
        Me.RadGlazed.Name = "RadGlazed"
        Me.RadGlazed.Size = New System.Drawing.Size(113, 20)
        Me.RadGlazed.TabIndex = 0
        Me.RadGlazed.TabStop = True
        Me.RadGlazed.Text = "Glazed ($1.05)"
        Me.RadGlazed.UseVisualStyleBackColor = True
        '
        'GroupDoughnut
        '
        Me.GroupDoughnut.Controls.Add(Me.RadGlazed)
        Me.GroupDoughnut.Controls.Add(Me.RadSugar)
        Me.GroupDoughnut.Controls.Add(Me.RadFilled)
        Me.GroupDoughnut.Controls.Add(Me.RadChocolate)
        Me.GroupDoughnut.Location = New System.Drawing.Point(49, 23)
        Me.GroupDoughnut.Name = "GroupDoughnut"
        Me.GroupDoughnut.Size = New System.Drawing.Size(200, 183)
        Me.GroupDoughnut.TabIndex = 7
        Me.GroupDoughnut.TabStop = False
        Me.GroupDoughnut.Text = "Doughnut Choices"
        '
        'GroupCoffee
        '
        Me.GroupCoffee.Controls.Add(Me.RadNone)
        Me.GroupCoffee.Controls.Add(Me.RadCappuccino)
        Me.GroupCoffee.Controls.Add(Me.RadioButton4)
        Me.GroupCoffee.Location = New System.Drawing.Point(55, 226)
        Me.GroupCoffee.Name = "GroupCoffee"
        Me.GroupCoffee.Size = New System.Drawing.Size(200, 130)
        Me.GroupCoffee.TabIndex = 8
        Me.GroupCoffee.TabStop = False
        Me.GroupCoffee.Text = "Coffee choices"
        '
        'lblsubbox
        '
        Me.lblsubbox.BackColor = System.Drawing.Color.LightCoral
        Me.lblsubbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblsubbox.Location = New System.Drawing.Point(136, 24)
        Me.lblsubbox.Name = "lblsubbox"
        Me.lblsubbox.Size = New System.Drawing.Size(84, 28)
        Me.lblsubbox.TabIndex = 9
        '
        'Lblsalesbox
        '
        Me.Lblsalesbox.BackColor = System.Drawing.Color.LightCoral
        Me.Lblsalesbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lblsalesbox.Location = New System.Drawing.Point(136, 75)
        Me.Lblsalesbox.Name = "Lblsalesbox"
        Me.Lblsalesbox.Size = New System.Drawing.Size(84, 29)
        Me.Lblsalesbox.TabIndex = 10
        '
        'Lbltotalbox
        '
        Me.Lbltotalbox.BackColor = System.Drawing.Color.LightCoral
        Me.Lbltotalbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbltotalbox.Location = New System.Drawing.Point(136, 143)
        Me.Lbltotalbox.Name = "Lbltotalbox"
        Me.Lbltotalbox.Size = New System.Drawing.Size(84, 29)
        Me.Lbltotalbox.TabIndex = 11
        '
        'LblSubtotal
        '
        Me.LblSubtotal.AutoSize = True
        Me.LblSubtotal.Location = New System.Drawing.Point(31, 36)
        Me.LblSubtotal.Name = "LblSubtotal"
        Me.LblSubtotal.Size = New System.Drawing.Size(59, 16)
        Me.LblSubtotal.TabIndex = 12
        Me.LblSubtotal.Text = "Subtotal:"
        '
        'Lbltotaldue
        '
        Me.Lbltotaldue.AutoSize = True
        Me.Lbltotaldue.Location = New System.Drawing.Point(31, 144)
        Me.Lbltotaldue.Name = "Lbltotaldue"
        Me.Lbltotaldue.Size = New System.Drawing.Size(69, 16)
        Me.Lbltotaldue.TabIndex = 13
        Me.Lbltotaldue.Text = "Total Due:"
        '
        'LblSalesTax
        '
        Me.LblSalesTax.AutoSize = True
        Me.LblSalesTax.Location = New System.Drawing.Point(31, 88)
        Me.LblSalesTax.Name = "LblSalesTax"
        Me.LblSalesTax.Size = New System.Drawing.Size(71, 16)
        Me.LblSalesTax.TabIndex = 14
        Me.LblSalesTax.Text = "Sales Tax:"
        '
        'Grouptotals
        '
        Me.Grouptotals.Controls.Add(Me.lblsubbox)
        Me.Grouptotals.Controls.Add(Me.LblSalesTax)
        Me.Grouptotals.Controls.Add(Me.Lblsalesbox)
        Me.Grouptotals.Controls.Add(Me.Lbltotaldue)
        Me.Grouptotals.Controls.Add(Me.Lbltotalbox)
        Me.Grouptotals.Controls.Add(Me.LblSubtotal)
        Me.Grouptotals.Location = New System.Drawing.Point(284, 33)
        Me.Grouptotals.Name = "Grouptotals"
        Me.Grouptotals.Size = New System.Drawing.Size(260, 188)
        Me.Grouptotals.TabIndex = 15
        Me.Grouptotals.TabStop = False
        Me.Grouptotals.Text = "GroupBox1"
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(350, 246)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(121, 33)
        Me.BtnCalculate.TabIndex = 16
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(350, 298)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(121, 36)
        Me.BtnExit.TabIndex = 17
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 403)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.Grouptotals)
        Me.Controls.Add(Me.GroupCoffee)
        Me.Controls.Add(Me.GroupDoughnut)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupDoughnut.ResumeLayout(False)
        Me.GroupDoughnut.PerformLayout()
        Me.GroupCoffee.ResumeLayout(False)
        Me.GroupCoffee.PerformLayout()
        Me.Grouptotals.ResumeLayout(False)
        Me.Grouptotals.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadNone As RadioButton
    Friend WithEvents RadCappuccino As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadChocolate As RadioButton
    Friend WithEvents RadFilled As RadioButton
    Friend WithEvents RadSugar As RadioButton
    Friend WithEvents RadGlazed As RadioButton
    Friend WithEvents GroupDoughnut As GroupBox
    Friend WithEvents GroupCoffee As GroupBox
    Friend WithEvents lblsubbox As Label
    Friend WithEvents Lblsalesbox As Label
    Friend WithEvents Lbltotalbox As Label
    Friend WithEvents LblSubtotal As Label
    Friend WithEvents Lbltotaldue As Label
    Friend WithEvents LblSalesTax As Label
    Friend WithEvents Grouptotals As GroupBox
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents BtnExit As Button
End Class
