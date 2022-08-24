<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_NAME = New System.Windows.Forms.TextBox()
        Me.TXT_NIT = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RBTN_ELECTRICAS = New System.Windows.Forms.RadioButton()
        Me.RBTN_MANUALES = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CB_BARRENOP = New System.Windows.Forms.CheckBox()
        Me.CB_PULIDORA = New System.Windows.Forms.CheckBox()
        Me.CB_LLAVES = New System.Windows.Forms.CheckBox()
        Me.CB_CANGREJO = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RBTN_EFECTIVO = New System.Windows.Forms.RadioButton()
        Me.RBTN_TARJETA = New System.Windows.Forms.RadioButton()
        Me.RBTN_TRANSFERENCIA = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_PARCIAL = New System.Windows.Forms.TextBox()
        Me.TXT_TOTAL = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUBMENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MENU1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MENU2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MENU3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox1.Controls.Add(Me.TXT_NIT)
        Me.GroupBox1.Controls.Add(Me.TXT_NAME)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(910, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS CLIENTE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(50, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE CLIENTE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(50, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIT CLIENTE:"
        '
        'TXT_NAME
        '
        Me.TXT_NAME.Location = New System.Drawing.Point(206, 21)
        Me.TXT_NAME.Multiline = True
        Me.TXT_NAME.Name = "TXT_NAME"
        Me.TXT_NAME.Size = New System.Drawing.Size(223, 56)
        Me.TXT_NAME.TabIndex = 2
        '
        'TXT_NIT
        '
        Me.TXT_NIT.Location = New System.Drawing.Point(206, 83)
        Me.TXT_NIT.Name = "TXT_NIT"
        Me.TXT_NIT.Size = New System.Drawing.Size(223, 22)
        Me.TXT_NIT.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RBTN_MANUALES)
        Me.GroupBox2.Controls.Add(Me.RBTN_ELECTRICAS)
        Me.GroupBox2.Location = New System.Drawing.Point(49, 229)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(308, 160)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TIPO DE HERRAMIENTAS"
        '
        'RBTN_ELECTRICAS
        '
        Me.RBTN_ELECTRICAS.AutoSize = True
        Me.RBTN_ELECTRICAS.Location = New System.Drawing.Point(34, 46)
        Me.RBTN_ELECTRICAS.Name = "RBTN_ELECTRICAS"
        Me.RBTN_ELECTRICAS.Size = New System.Drawing.Size(113, 21)
        Me.RBTN_ELECTRICAS.TabIndex = 0
        Me.RBTN_ELECTRICAS.TabStop = True
        Me.RBTN_ELECTRICAS.Text = "ELECTRICAS"
        Me.RBTN_ELECTRICAS.UseVisualStyleBackColor = True
        '
        'RBTN_MANUALES
        '
        Me.RBTN_MANUALES.AutoSize = True
        Me.RBTN_MANUALES.Location = New System.Drawing.Point(34, 105)
        Me.RBTN_MANUALES.Name = "RBTN_MANUALES"
        Me.RBTN_MANUALES.Size = New System.Drawing.Size(104, 21)
        Me.RBTN_MANUALES.TabIndex = 1
        Me.RBTN_MANUALES.TabStop = True
        Me.RBTN_MANUALES.Text = "MANUALES"
        Me.RBTN_MANUALES.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CB_CANGREJO)
        Me.GroupBox3.Controls.Add(Me.CB_LLAVES)
        Me.GroupBox3.Controls.Add(Me.CB_PULIDORA)
        Me.GroupBox3.Controls.Add(Me.CB_BARRENOP)
        Me.GroupBox3.Location = New System.Drawing.Point(578, 229)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(381, 251)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "HERRAMIENTAS DISPONIBLES"
        '
        'CB_BARRENOP
        '
        Me.CB_BARRENOP.AutoSize = True
        Me.CB_BARRENOP.Location = New System.Drawing.Point(129, 36)
        Me.CB_BARRENOP.Name = "CB_BARRENOP"
        Me.CB_BARRENOP.Size = New System.Drawing.Size(98, 21)
        Me.CB_BARRENOP.TabIndex = 0
        Me.CB_BARRENOP.Text = "BARRENO"
        Me.CB_BARRENOP.UseVisualStyleBackColor = True
        '
        'CB_PULIDORA
        '
        Me.CB_PULIDORA.AutoSize = True
        Me.CB_PULIDORA.Location = New System.Drawing.Point(129, 86)
        Me.CB_PULIDORA.Name = "CB_PULIDORA"
        Me.CB_PULIDORA.Size = New System.Drawing.Size(100, 21)
        Me.CB_PULIDORA.TabIndex = 1
        Me.CB_PULIDORA.Text = "PULIDORA"
        Me.CB_PULIDORA.UseVisualStyleBackColor = True
        '
        'CB_LLAVES
        '
        Me.CB_LLAVES.AutoSize = True
        Me.CB_LLAVES.Location = New System.Drawing.Point(129, 139)
        Me.CB_LLAVES.Name = "CB_LLAVES"
        Me.CB_LLAVES.Size = New System.Drawing.Size(82, 21)
        Me.CB_LLAVES.TabIndex = 2
        Me.CB_LLAVES.Text = "LLAVES"
        Me.CB_LLAVES.UseVisualStyleBackColor = True
        '
        'CB_CANGREJO
        '
        Me.CB_CANGREJO.AutoSize = True
        Me.CB_CANGREJO.Location = New System.Drawing.Point(129, 189)
        Me.CB_CANGREJO.Name = "CB_CANGREJO"
        Me.CB_CANGREJO.Size = New System.Drawing.Size(115, 21)
        Me.CB_CANGREJO.TabIndex = 3
        Me.CB_CANGREJO.Text = "CANGREJOS"
        Me.CB_CANGREJO.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RBTN_TRANSFERENCIA)
        Me.GroupBox4.Controls.Add(Me.RBTN_TARJETA)
        Me.GroupBox4.Controls.Add(Me.RBTN_EFECTIVO)
        Me.GroupBox4.Location = New System.Drawing.Point(49, 468)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(308, 194)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "FORMA DE PAGO"
        '
        'RBTN_EFECTIVO
        '
        Me.RBTN_EFECTIVO.AutoSize = True
        Me.RBTN_EFECTIVO.Location = New System.Drawing.Point(60, 38)
        Me.RBTN_EFECTIVO.Name = "RBTN_EFECTIVO"
        Me.RBTN_EFECTIVO.Size = New System.Drawing.Size(96, 21)
        Me.RBTN_EFECTIVO.TabIndex = 0
        Me.RBTN_EFECTIVO.TabStop = True
        Me.RBTN_EFECTIVO.Text = "EFECTIVO"
        Me.RBTN_EFECTIVO.UseVisualStyleBackColor = True
        '
        'RBTN_TARJETA
        '
        Me.RBTN_TARJETA.AutoSize = True
        Me.RBTN_TARJETA.Location = New System.Drawing.Point(60, 86)
        Me.RBTN_TARJETA.Name = "RBTN_TARJETA"
        Me.RBTN_TARJETA.Size = New System.Drawing.Size(95, 21)
        Me.RBTN_TARJETA.TabIndex = 1
        Me.RBTN_TARJETA.TabStop = True
        Me.RBTN_TARJETA.Text = "TARGETA"
        Me.RBTN_TARJETA.UseVisualStyleBackColor = True
        '
        'RBTN_TRANSFERENCIA
        '
        Me.RBTN_TRANSFERENCIA.AutoSize = True
        Me.RBTN_TRANSFERENCIA.Location = New System.Drawing.Point(60, 142)
        Me.RBTN_TRANSFERENCIA.Name = "RBTN_TRANSFERENCIA"
        Me.RBTN_TRANSFERENCIA.Size = New System.Drawing.Size(175, 21)
        Me.RBTN_TRANSFERENCIA.TabIndex = 2
        Me.RBTN_TRANSFERENCIA.TabStop = True
        Me.RBTN_TRANSFERENCIA.Text = "TRANSFERENCIA ACH"
        Me.RBTN_TRANSFERENCIA.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TXT_TOTAL)
        Me.GroupBox5.Controls.Add(Me.TXT_PARCIAL)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Location = New System.Drawing.Point(578, 506)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(381, 156)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "RESULTADOS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "PARCIAL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 21)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "TOTAL"
        '
        'TXT_PARCIAL
        '
        Me.TXT_PARCIAL.Location = New System.Drawing.Point(142, 46)
        Me.TXT_PARCIAL.Name = "TXT_PARCIAL"
        Me.TXT_PARCIAL.Size = New System.Drawing.Size(186, 22)
        Me.TXT_PARCIAL.TabIndex = 2
        '
        'TXT_TOTAL
        '
        Me.TXT_TOTAL.Location = New System.Drawing.Point(142, 104)
        Me.TXT_TOTAL.Name = "TXT_TOTAL"
        Me.TXT_TOTAL.Size = New System.Drawing.Size(186, 22)
        Me.TXT_TOTAL.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULARToolStripMenuItem, Me.LIMPIARToolStripMenuItem, Me.SALIRToolStripMenuItem, Me.SUBMENUToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1445, 28)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CALCULARToolStripMenuItem
        '
        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
        Me.CALCULARToolStripMenuItem.Text = "CALCULAR"
        '
        'LIMPIARToolStripMenuItem
        '
        Me.LIMPIARToolStripMenuItem.Name = "LIMPIARToolStripMenuItem"
        Me.LIMPIARToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.LIMPIARToolStripMenuItem.Text = "LIMPIAR"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(61, 24)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'SUBMENUToolStripMenuItem
        '
        Me.SUBMENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENU1ToolStripMenuItem, Me.MENU2ToolStripMenuItem, Me.MENU3ToolStripMenuItem})
        Me.SUBMENUToolStripMenuItem.Name = "SUBMENUToolStripMenuItem"
        Me.SUBMENUToolStripMenuItem.Size = New System.Drawing.Size(96, 24)
        Me.SUBMENUToolStripMenuItem.Text = "SUB MENU"
        '
        'MENU1ToolStripMenuItem
        '
        Me.MENU1ToolStripMenuItem.Name = "MENU1ToolStripMenuItem"
        Me.MENU1ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.MENU1ToolStripMenuItem.Text = "MENU 1"
        '
        'MENU2ToolStripMenuItem
        '
        Me.MENU2ToolStripMenuItem.Name = "MENU2ToolStripMenuItem"
        Me.MENU2ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.MENU2ToolStripMenuItem.Text = "MENU 2"
        '
        'MENU3ToolStripMenuItem
        '
        Me.MENU3ToolStripMenuItem.Name = "MENU3ToolStripMenuItem"
        Me.MENU3ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.MENU3ToolStripMenuItem.Text = "MENU 3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(1445, 741)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TXT_NIT As TextBox
    Friend WithEvents TXT_NAME As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RBTN_MANUALES As RadioButton
    Friend WithEvents RBTN_ELECTRICAS As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CB_CANGREJO As CheckBox
    Friend WithEvents CB_LLAVES As CheckBox
    Friend WithEvents CB_PULIDORA As CheckBox
    Friend WithEvents CB_BARRENOP As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RBTN_TRANSFERENCIA As RadioButton
    Friend WithEvents RBTN_TARJETA As RadioButton
    Friend WithEvents RBTN_EFECTIVO As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TXT_TOTAL As TextBox
    Friend WithEvents TXT_PARCIAL As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SUBMENUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MENU1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MENU2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MENU3ToolStripMenuItem As ToolStripMenuItem
End Class
