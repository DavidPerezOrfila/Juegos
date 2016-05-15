<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Juegos
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PokerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaPartidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CartasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdivinaLaParejaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Jugador1Btn = New System.Windows.Forms.Button()
        Me.Jugador2Btn = New System.Windows.Forms.Button()
        Me.Jugador3Btn = New System.Windows.Forms.Button()
        Me.Jugador4Btn = New System.Windows.Forms.Button()
        Me.Jugador5Btn = New System.Windows.Forms.Button()
        Me.EmpezarBtn = New System.Windows.Forms.Button()
        Me.DadoTurno = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lblfecha = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DadosToolStripMenuItem, Me.CartasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(524, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DadosToolStripMenuItem
        '
        Me.DadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PokerToolStripMenuItem})
        Me.DadosToolStripMenuItem.Name = "DadosToolStripMenuItem"
        Me.DadosToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.DadosToolStripMenuItem.Text = "Dados"
        '
        'PokerToolStripMenuItem
        '
        Me.PokerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaPartidaToolStripMenuItem})
        Me.PokerToolStripMenuItem.Name = "PokerToolStripMenuItem"
        Me.PokerToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.PokerToolStripMenuItem.Text = "Poker"
        '
        'NuevaPartidaToolStripMenuItem
        '
        Me.NuevaPartidaToolStripMenuItem.Name = "NuevaPartidaToolStripMenuItem"
        Me.NuevaPartidaToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.NuevaPartidaToolStripMenuItem.Text = "Nuevo Juego"
        '
        'CartasToolStripMenuItem
        '
        Me.CartasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdivinaLaParejaToolStripMenuItem})
        Me.CartasToolStripMenuItem.Name = "CartasToolStripMenuItem"
        Me.CartasToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.CartasToolStripMenuItem.Text = "Cartas"
        '
        'AdivinaLaParejaToolStripMenuItem
        '
        Me.AdivinaLaParejaToolStripMenuItem.Name = "AdivinaLaParejaToolStripMenuItem"
        Me.AdivinaLaParejaToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.AdivinaLaParejaToolStripMenuItem.Text = "Adivina la pareja"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(50, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 211)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elije el número de Jugadores"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(76, 141)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(37, 21)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "5"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(76, 113)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(37, 21)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(76, 85)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(37, 21)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(76, 57)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(37, 21)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Jugador1Btn
        '
        Me.Jugador1Btn.Location = New System.Drawing.Point(299, 86)
        Me.Jugador1Btn.Name = "Jugador1Btn"
        Me.Jugador1Btn.Size = New System.Drawing.Size(85, 29)
        Me.Jugador1Btn.TabIndex = 2
        Me.Jugador1Btn.Text = "Jugador 1"
        Me.Jugador1Btn.UseVisualStyleBackColor = True
        '
        'Jugador2Btn
        '
        Me.Jugador2Btn.Location = New System.Drawing.Point(403, 86)
        Me.Jugador2Btn.Name = "Jugador2Btn"
        Me.Jugador2Btn.Size = New System.Drawing.Size(85, 29)
        Me.Jugador2Btn.TabIndex = 3
        Me.Jugador2Btn.Text = "Jugador 2"
        Me.Jugador2Btn.UseVisualStyleBackColor = True
        '
        'Jugador3Btn
        '
        Me.Jugador3Btn.Location = New System.Drawing.Point(299, 146)
        Me.Jugador3Btn.Name = "Jugador3Btn"
        Me.Jugador3Btn.Size = New System.Drawing.Size(85, 29)
        Me.Jugador3Btn.TabIndex = 4
        Me.Jugador3Btn.Text = "Jugador 3"
        Me.Jugador3Btn.UseVisualStyleBackColor = True
        '
        'Jugador4Btn
        '
        Me.Jugador4Btn.Location = New System.Drawing.Point(403, 146)
        Me.Jugador4Btn.Name = "Jugador4Btn"
        Me.Jugador4Btn.Size = New System.Drawing.Size(85, 29)
        Me.Jugador4Btn.TabIndex = 5
        Me.Jugador4Btn.Text = "Jugador 4"
        Me.Jugador4Btn.UseVisualStyleBackColor = True
        '
        'Jugador5Btn
        '
        Me.Jugador5Btn.Location = New System.Drawing.Point(299, 211)
        Me.Jugador5Btn.Name = "Jugador5Btn"
        Me.Jugador5Btn.Size = New System.Drawing.Size(85, 26)
        Me.Jugador5Btn.TabIndex = 6
        Me.Jugador5Btn.Text = "Jugador 5"
        Me.Jugador5Btn.UseVisualStyleBackColor = True
        '
        'EmpezarBtn
        '
        Me.EmpezarBtn.Location = New System.Drawing.Point(12, 361)
        Me.EmpezarBtn.Name = "EmpezarBtn"
        Me.EmpezarBtn.Size = New System.Drawing.Size(163, 31)
        Me.EmpezarBtn.TabIndex = 7
        Me.EmpezarBtn.Text = "Empezar Partida"
        Me.EmpezarBtn.UseVisualStyleBackColor = True
        '
        'DadoTurno
        '
        Me.DadoTurno.Location = New System.Drawing.Point(227, 361)
        Me.DadoTurno.Name = "DadoTurno"
        Me.DadoTurno.Size = New System.Drawing.Size(112, 31)
        Me.DadoTurno.TabIndex = 8
        Me.DadoTurno.Text = "Lanzar"
        Me.DadoTurno.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(299, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Label1"
        '
        'Lblfecha
        '
        Me.Lblfecha.AutoSize = True
        Me.Lblfecha.Location = New System.Drawing.Point(403, 46)
        Me.Lblfecha.Name = "Lblfecha"
        Me.Lblfecha.Size = New System.Drawing.Size(51, 17)
        Me.Lblfecha.TabIndex = 10
        Me.Lblfecha.Text = "Label2"
        '
        'Juegos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 445)
        Me.Controls.Add(Me.Lblfecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DadoTurno)
        Me.Controls.Add(Me.EmpezarBtn)
        Me.Controls.Add(Me.Jugador5Btn)
        Me.Controls.Add(Me.Jugador4Btn)
        Me.Controls.Add(Me.Jugador3Btn)
        Me.Controls.Add(Me.Jugador2Btn)
        Me.Controls.Add(Me.Jugador1Btn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Juegos"
        Me.ShowIcon = False
        Me.Text = "Juegos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PokerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaPartidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CartasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdivinaLaParejaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Jugador1Btn As Button
    Friend WithEvents Jugador2Btn As Button
    Friend WithEvents Jugador3Btn As Button
    Friend WithEvents Jugador4Btn As Button
    Friend WithEvents Jugador5Btn As Button
    Friend WithEvents EmpezarBtn As Button
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents DadoTurno As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Lblfecha As Label
End Class
