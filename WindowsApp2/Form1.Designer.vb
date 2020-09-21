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
        Me.components = New System.ComponentModel.Container()
        Me.cmdConectar = New System.Windows.Forms.Button()
        Me.cmdTest = New System.Windows.Forms.Button()
        Me.cmdReadCardIni = New System.Windows.Forms.Button()
        Me.cmdSetIdlePrompt = New System.Windows.Forms.Button()
        Me.cmdDisconnect = New System.Windows.Forms.Button()
        Me.tbReadCardIni = New System.Windows.Forms.TextBox()
        Me.tbSetIdlePrompt = New System.Windows.Forms.TextBox()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmdPedirPin = New System.Windows.Forms.Button()
        Me.txtNroTarjeta = New System.Windows.Forms.TextBox()
        Me.WK = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sTipoEncriptacion = New System.Windows.Forms.ComboBox()
        Me.TimerPin = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPin = New System.Windows.Forms.TextBox()
        Me.NroLlave = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbPin = New System.Windows.Forms.Label()
        Me.TimerCard = New System.Windows.Forms.Timer(Me.components)
        Me.txtPuertoCOM = New System.Windows.Forms.TextBox()
        Me.txtVelocidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdConectar
        '
        Me.cmdConectar.Location = New System.Drawing.Point(274, 22)
        Me.cmdConectar.Name = "cmdConectar"
        Me.cmdConectar.Size = New System.Drawing.Size(166, 49)
        Me.cmdConectar.TabIndex = 0
        Me.cmdConectar.Text = "Conexion"
        Me.cmdConectar.UseVisualStyleBackColor = True
        '
        'cmdTest
        '
        Me.cmdTest.Location = New System.Drawing.Point(446, 22)
        Me.cmdTest.Name = "cmdTest"
        Me.cmdTest.Size = New System.Drawing.Size(166, 49)
        Me.cmdTest.TabIndex = 1
        Me.cmdTest.Text = "Test"
        Me.cmdTest.UseVisualStyleBackColor = True
        '
        'cmdReadCardIni
        '
        Me.cmdReadCardIni.Location = New System.Drawing.Point(362, 109)
        Me.cmdReadCardIni.Name = "cmdReadCardIni"
        Me.cmdReadCardIni.Size = New System.Drawing.Size(166, 49)
        Me.cmdReadCardIni.TabIndex = 2
        Me.cmdReadCardIni.Text = "ReadCardIni"
        Me.cmdReadCardIni.UseVisualStyleBackColor = True
        '
        'cmdSetIdlePrompt
        '
        Me.cmdSetIdlePrompt.Location = New System.Drawing.Point(362, 164)
        Me.cmdSetIdlePrompt.Name = "cmdSetIdlePrompt"
        Me.cmdSetIdlePrompt.Size = New System.Drawing.Size(166, 49)
        Me.cmdSetIdlePrompt.TabIndex = 3
        Me.cmdSetIdlePrompt.Text = "SetIdlePrompt"
        Me.cmdSetIdlePrompt.UseVisualStyleBackColor = True
        '
        'cmdDisconnect
        '
        Me.cmdDisconnect.Location = New System.Drawing.Point(432, 501)
        Me.cmdDisconnect.Name = "cmdDisconnect"
        Me.cmdDisconnect.Size = New System.Drawing.Size(166, 49)
        Me.cmdDisconnect.TabIndex = 4
        Me.cmdDisconnect.Text = "Disconnect"
        Me.cmdDisconnect.UseVisualStyleBackColor = True
        '
        'tbReadCardIni
        '
        Me.tbReadCardIni.Location = New System.Drawing.Point(41, 122)
        Me.tbReadCardIni.Name = "tbReadCardIni"
        Me.tbReadCardIni.Size = New System.Drawing.Size(291, 22)
        Me.tbReadCardIni.TabIndex = 5
        Me.tbReadCardIni.Text = "Midori"
        '
        'tbSetIdlePrompt
        '
        Me.tbSetIdlePrompt.Location = New System.Drawing.Point(41, 177)
        Me.tbSetIdlePrompt.Name = "tbSetIdlePrompt"
        Me.tbSetIdlePrompt.Size = New System.Drawing.Size(291, 22)
        Me.tbSetIdlePrompt.TabIndex = 6
        Me.tbSetIdlePrompt.Text = "Tengo Hambre"
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(260, 501)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(166, 49)
        Me.cmdReset.TabIndex = 7
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'cmdPedirPin
        '
        Me.cmdPedirPin.Location = New System.Drawing.Point(362, 367)
        Me.cmdPedirPin.Name = "cmdPedirPin"
        Me.cmdPedirPin.Size = New System.Drawing.Size(166, 49)
        Me.cmdPedirPin.TabIndex = 8
        Me.cmdPedirPin.Text = "Pedir Pin"
        Me.cmdPedirPin.UseVisualStyleBackColor = True
        '
        'txtNroTarjeta
        '
        Me.txtNroTarjeta.Location = New System.Drawing.Point(80, 355)
        Me.txtNroTarjeta.Name = "txtNroTarjeta"
        Me.txtNroTarjeta.Size = New System.Drawing.Size(252, 22)
        Me.txtNroTarjeta.TabIndex = 9
        '
        'WK
        '
        Me.WK.Location = New System.Drawing.Point(80, 394)
        Me.WK.Name = "WK"
        Me.WK.Size = New System.Drawing.Size(252, 22)
        Me.WK.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 355)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nro T"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 397)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "WK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Tipo Encriptacion"
        '
        'sTipoEncriptacion
        '
        Me.sTipoEncriptacion.FormattingEnabled = True
        Me.sTipoEncriptacion.Items.AddRange(New Object() {"0", "1", "2"})
        Me.sTipoEncriptacion.Location = New System.Drawing.Point(162, 274)
        Me.sTipoEncriptacion.Name = "sTipoEncriptacion"
        Me.sTipoEncriptacion.Size = New System.Drawing.Size(177, 24)
        Me.sTipoEncriptacion.TabIndex = 14
        '
        'TimerPin
        '
        Me.TimerPin.Interval = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 440)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Pin"
        '
        'txtPin
        '
        Me.txtPin.Location = New System.Drawing.Point(80, 437)
        Me.txtPin.Name = "txtPin"
        Me.txtPin.Size = New System.Drawing.Size(252, 22)
        Me.txtPin.TabIndex = 15
        '
        'NroLlave
        '
        Me.NroLlave.FormattingEnabled = True
        Me.NroLlave.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.NroLlave.Location = New System.Drawing.Point(162, 308)
        Me.NroLlave.Name = "NroLlave"
        Me.NroLlave.Size = New System.Drawing.Size(177, 24)
        Me.NroLlave.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Nro Llave"
        '
        'lbPin
        '
        Me.lbPin.AutoSize = True
        Me.lbPin.Location = New System.Drawing.Point(380, 446)
        Me.lbPin.Name = "lbPin"
        Me.lbPin.Size = New System.Drawing.Size(0, 17)
        Me.lbPin.TabIndex = 19
        '
        'TimerCard
        '
        Me.TimerCard.Interval = 10
        '
        'txtPuertoCOM
        '
        Me.txtPuertoCOM.Location = New System.Drawing.Point(119, 22)
        Me.txtPuertoCOM.Name = "txtPuertoCOM"
        Me.txtPuertoCOM.Size = New System.Drawing.Size(116, 22)
        Me.txtPuertoCOM.TabIndex = 20
        Me.txtPuertoCOM.Text = "3"
        '
        'txtVelocidad
        '
        Me.txtVelocidad.Location = New System.Drawing.Point(119, 50)
        Me.txtVelocidad.Name = "txtVelocidad"
        Me.txtVelocidad.Size = New System.Drawing.Size(116, 22)
        Me.txtVelocidad.TabIndex = 21
        Me.txtVelocidad.Text = "19200"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Puerto COM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 17)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Velocidad"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 562)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtVelocidad)
        Me.Controls.Add(Me.txtPuertoCOM)
        Me.Controls.Add(Me.lbPin)
        Me.Controls.Add(Me.NroLlave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPin)
        Me.Controls.Add(Me.sTipoEncriptacion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WK)
        Me.Controls.Add(Me.txtNroTarjeta)
        Me.Controls.Add(Me.cmdPedirPin)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.tbSetIdlePrompt)
        Me.Controls.Add(Me.tbReadCardIni)
        Me.Controls.Add(Me.cmdDisconnect)
        Me.Controls.Add(Me.cmdSetIdlePrompt)
        Me.Controls.Add(Me.cmdReadCardIni)
        Me.Controls.Add(Me.cmdTest)
        Me.Controls.Add(Me.cmdConectar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdConectar As Button
    Friend WithEvents cmdTest As Button
    Friend WithEvents cmdReadCardIni As Button
    Friend WithEvents cmdSetIdlePrompt As Button
    Friend WithEvents cmdDisconnect As Button
    Friend WithEvents tbReadCardIni As TextBox
    Friend WithEvents tbSetIdlePrompt As TextBox
    Friend WithEvents cmdReset As Button
    Friend WithEvents cmdPedirPin As Button
    Friend WithEvents txtNroTarjeta As TextBox
    Friend WithEvents WK As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents sTipoEncriptacion As ComboBox
    Friend WithEvents TimerPin As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPin As TextBox
    Friend WithEvents NroLlave As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbPin As Label
    Friend WithEvents TimerCard As Timer
    Friend WithEvents txtPuertoCOM As TextBox
    Friend WithEvents txtVelocidad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
