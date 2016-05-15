Public Class Juegos
    Dim jugador1 As New Jugador
    Dim jugador2 As New Jugador
    Dim jugador3 As New Jugador
    Dim jugador4 As New Jugador
    Dim jugador5 As New Jugador
    Dim poker1 As New Dados
    Dim poker2 As New Dados
    Dim poker3 As New Dados
    Dim poker4 As New Dados
    Dim poker5 As New Dados
    Dim resultado As String


    Private Sub Juegos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lblfecha.Visible = False
        Timer2.Enabled = True
        Lblfecha.Text = TimeOfDay
        Label1.Visible = False
        DadoTurno.Visible = False
        EmpezarBtn.Visible = False
        GroupBox1.Visible = False
        Jugador1Btn.Visible = False
        Jugador2Btn.Visible = False
        Jugador3Btn.Visible = False
        Jugador4Btn.Visible = False
        Jugador5Btn.Visible = False

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

        If RadioButton2.Checked = True Then

            RadioButton2.Enabled = True

        ElseIf RadioButton3.Checked = True Then

            RadioButton3.Enabled = True

        ElseIf RadioButton4.Checked = True Then

            RadioButton4.Enabled = True

        ElseIf RadioButton5.Checked = True Then

            RadioButton5.Enabled = True

        End If

    End Sub

    Public Function registroJugadores() As String

        Dim registro As String
        registro = InputBox("Ingrese su nombre:", "Nombre del Jugador", "Nombre", 100, 50)
        Return (registro)

    End Function


    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        Label1.Visible = True
        Jugador1Btn.Visible = True
        Jugador2Btn.Visible = True
        Jugador3Btn.Visible = False
        Jugador4Btn.Visible = False
        Jugador5Btn.Visible = False
        RadioButton3.Visible = False
        RadioButton4.Visible = False
        RadioButton5.Visible = False

        If Jugador1Btn.Created And Jugador2Btn.Created Then
            EmpezarBtn.Visible = True

        End If

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

        Label1.Visible = True
        RadioButton2.Visible = False
        RadioButton4.Visible = False
        RadioButton5.Visible = False
        Jugador1Btn.Visible = True
        Jugador2Btn.Visible = True
        Jugador3Btn.Visible = True
        Jugador4Btn.Visible = False
        Jugador5Btn.Visible = False

        If Jugador1Btn.Created And Jugador2Btn.Created Then
            EmpezarBtn.Visible = True

        End If

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged


        Label1.Visible = True
        RadioButton2.Visible = False
        RadioButton3.Visible = False
        RadioButton5.Visible = False
        Jugador1Btn.Visible = True
        Jugador2Btn.Visible = True
        Jugador3Btn.Visible = True
        Jugador4Btn.Visible = True
        Jugador5Btn.Visible = False

        If Jugador1Btn.Created And Jugador2Btn.Created Then
            EmpezarBtn.Visible = True

        End If

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged

        Label1.Visible = True
        RadioButton5.Enabled = True
        RadioButton2.Visible = False
        RadioButton3.Visible = False
        RadioButton4.Visible = False
        Jugador1Btn.Visible = True
        Jugador2Btn.Visible = True
        Jugador3Btn.Visible = True
        Jugador4Btn.Visible = True
        Jugador5Btn.Visible = True

        If Jugador1Btn.Created And Jugador2Btn.Created Then
            EmpezarBtn.Visible = True

        End If

    End Sub

    Private Sub Jugador1Btn_Click(sender As Object, e As EventArgs) Handles Jugador1Btn.Click

        jugador1.setNombre(Me.registroJugadores)

    End Sub



    Private Sub Jugador2Btn_Click(sender As Object, e As EventArgs) Handles Jugador2Btn.Click

        jugador2.getNombre(Me.registroJugadores)

    End Sub

    Private Sub Jugador3Btn_Click(sender As Object, e As EventArgs) Handles Jugador3Btn.Click

        jugador3.getNombre(Me.registroJugadores)

    End Sub

    Private Sub Jugador4Btn_Click(sender As Object, e As EventArgs) Handles Jugador4Btn.Click

        jugador4.getNombre(Me.registroJugadores)

    End Sub

    Private Sub Jugador5Btn_Click(sender As Object, e As EventArgs) Handles Jugador5Btn.Click

        jugador5.getNombre(Me.registroJugadores)

    End Sub

    Public time As Integer = 0

    Private Sub EmpezarBtn_Click(sender As Object, e As EventArgs) Handles EmpezarBtn.Click

        DadoTurno.Visible = True

        MessageBox.Show("El orden de los turnos vendrá determinado por el dado más alto")
        If (Timer1.Enabled Mod 2 = 0) Then

            My.Computer.Audio.Play(My.Resources.The_Sting_Theme__Joplin___The_Entertainer_, AudioPlayMode.Background)

        Else

            My.Computer.Audio.Play(My.Resources.Maple_Leaf_Rag_Played_by_Scott_Joplin, AudioPlayMode.Background)

        End If


    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        Dim opcion As DialogResult

        opcion = MessageBox.Show("Realmente quieres salir del Juego?", "Salir del Juego", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (opcion = DialogResult.Yes) Then
            Me.Close()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick



    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Lblfecha.Text = TimeOfDay

    End Sub

    Private Sub NuevaPartidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaPartidaToolStripMenuItem.Click
        GroupBox1.Visible = True
    End Sub

    Private Sub DadoTurno_Click(sender As Object, e As EventArgs) Handles DadoTurno.Click

    End Sub
End Class
