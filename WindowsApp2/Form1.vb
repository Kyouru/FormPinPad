Public Class Form1
    Public myPSerial As Object

    Private Sub cmdConectar_Click(sender As Object, e As EventArgs) Handles cmdConectar.Click
        If myPSerial.Connect(txtPuertoCOM.Text, txtVelocidad.Text) Then
            MsgBox("Se conectó al Pinpad.")
            myPSerial.TO_READ = CInt(600)
            myPSerial.TO_TIMEOUT = CInt(6000)
        Else
            If myPSerial.ConnectionTest Then
                MsgBox("Ya esta conectado al PinPad")
            Else
                MsgBox("No hay conexión con el Pinpad.")
            End If
        End If
    End Sub

    Private Sub cmdTest_Click(sender As Object, e As EventArgs) Handles cmdTest.Click
        If myPSerial.ConnectionTest Then
            MsgBox("Hay Conexión")
        Else
            MsgBox("No hay conexión")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set myPSerial = New PSerial
        myPSerial = CreateObject("HComPinpad.Pinpad")
    End Sub

    Private Sub cmdReadCardIni_Click(sender As Object, e As EventArgs) Handles cmdReadCardIni.Click
        If myPSerial.ConnectionTest Then
            If myPSerial.ReadCardIni = 1 Then
                TimerCard.Enabled = True
            End If
        Else
            MsgBox("No hay conexión")
        End If
    End Sub

    Private Sub cmdSetIdlePrompt_Click(sender As Object, e As EventArgs) Handles cmdSetIdlePrompt.Click
        If myPSerial.ConnectionTest Then
            myPSerial.SetIdlePrompt(tbSetIdlePrompt.Text)
        Else
            MsgBox("No hay conexión")
        End If
    End Sub

    Private Sub cmdDisconnect_Click(sender As Object, e As EventArgs) Handles cmdDisconnect.Click

        myPSerial.Disconnect
        MsgBox("Pinpad Desconectado")

    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        myPSerial.Reset
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'myPSerial.Reset
        Try
            myPSerial.Disconnect
        Catch

        End Try
    End Sub

    Private Sub TimerPin_Tick(sender As Object, e As EventArgs) Handles TimerPin.Tick
        Dim iPin As Short
        Dim sPin As String

        sPin = myPSerial.ReadPin(iPin)

        'iPin = 1: Lectura PINBLOCK OK!
        If (sPin <> "") Then
            txtPin.Text = UCase(sPin)
            TimerPin.Enabled = False
            lbPin.Text = "Ok"
        ElseIf iPin = 0 Then 'iPin = 0: Se cancelo ingreso de clave
            TimerPin.Enabled = False
            txtPin.Text = sPin
            lbPin.Text = "Cancelado"

        End If
    End Sub

    Private Sub cmdPedirPin_Click(sender As Object, e As EventArgs) Handles cmdPedirPin.Click
        If myPSerial.ConnectionTest Then
            Dim sNroTarjeta As String

            sNroTarjeta = obtieneNumeroTrajetaDeTrack2()
            If IsNumeric(sNroTarjeta) = False Then
                MsgBox("El número de tarjeta tiene que ser numérico")
                Exit Sub
            End If

            If (sTipoEncriptacion.Text = 2) Then
                If (NroLlave.Text = "0") Or (NroLlave.Text = "1") Or (NroLlave.Text = "2") Then
                    If myPSerial.ReadPinIni_D3D(NroLlave.Text, WK.Text, sNroTarjeta, sTipoEncriptacion.Text) = 1 Then
                        TimerPin.Enabled = True
                    End If
                Else
                    MsgBox("Para DUKPT la Master deber ser 0 o 1 o 2")
                    TimerPin.Enabled = False
                    Exit Sub
                End If
            End If

            If (sTipoEncriptacion.Text = 1) Then
                If (NroLlave.Text = "0") Or (NroLlave.Text = "2") Or (NroLlave.Text = "4") Or (NroLlave.Text = "6") Or (NroLlave.Text = "8") Then
                    If myPSerial.ReadPinIni_D3D(NroLlave.Text, WK.Text, sNroTarjeta, sTipoEncriptacion.Text) = 1 Then
                        TimerPin.Enabled = True
                    End If
                Else
                    MsgBox("Para 3DES la Master deber ser 0 o 2 o 4 o 6 o 8")
                    TimerPin.Enabled = False
                    Exit Sub
                End If
            End If

            If sTipoEncriptacion.Text = 0 Then
                If myPSerial.ReadPinIni_D3D(NroLlave.Text, WK.Text, sNroTarjeta, sTipoEncriptacion.Text) = 1 Then
                    TimerPin.Enabled = True
                End If
            End If

Fin:

        End If
    End Sub
    Private Function obtieneNumeroTrajetaDeTrack2() As String
        Dim sNroTarjeta As String
        Dim desp As Integer
        Dim desp2 As Integer

        desp = 1

        If Len(WK.Text) <> 16 Then
            obtieneNumeroTrajetaDeTrack2 = ""
            MsgBox("La llave de trabajo (WK) debe tener longitud de 16 caracteres")
            GoTo Salir2
        End If

        While desp < Len(txtNroTarjeta.Text)
            If IsNumeric(Mid(txtNroTarjeta.Text, desp, 1)) = True Then
                GoTo Salir
            End If
            desp = desp + 1
        End While


Salir:
        desp2 = desp + 16
        sNroTarjeta = ""
        While desp <= desp2
            If Mid(txtNroTarjeta.Text, desp, 1) = "=" Then
                GoTo Salir2
            End If
            sNroTarjeta = sNroTarjeta & Mid(txtNroTarjeta.Text, desp, 1)
            desp = desp + 1
        End While

Salir2:
        obtieneNumeroTrajetaDeTrack2 = sNroTarjeta

    End Function

    Private Sub TimerCard_Tick(sender As Object, e As EventArgs) Handles TimerCard.Tick
        Dim SCard As String
        SCard = myPSerial.ReadCard
        If (SCard <> "") Then
            txtNroTarjeta.Text = SCard
            TimerCard.Enabled = False
        End If
    End Sub
End Class
