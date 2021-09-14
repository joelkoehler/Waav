


Public Class Form1

	Dim curOct As Integer = 1 '1 is the base level, 0 is below and 2 is above.

	Dim C2 As Integer = CInt(Math.Round(65.41))
	Dim C2s As Integer = CInt(Math.Round(69.3)) 'C#2/Db2
	Dim D2 As Integer = CInt(Math.Round(73.42))
	Dim D2s As Integer = CInt(Math.Round(77.78)) 'D#2/Eb2
	Dim E2 As Integer = CInt(Math.Round(82.41))
	Dim F2 As Integer = CInt(Math.Round(87.31))
	Dim met100On As Boolean = True
	Dim met120On As Boolean = True
	Dim met75On As Boolean = True
	Dim synthOn As Boolean = True
	Dim drumOn As Boolean = True
	Dim steelDrumOn As Boolean = True
	Dim dur As Integer = 200





	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Console.Beep(262, 500)
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Console.Beep(277, 500)
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		Console.Beep(294, 500)
	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		Console.Beep(311, 500)
	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
		Console.Beep(330, 500)
	End Sub

	Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
		Console.Beep(349, 500)
	End Sub

	Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
		Console.Beep(370, 500)
	End Sub

	Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
		Console.Beep(392, 500)
	End Sub

	Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
		Console.Beep(415, 500)
	End Sub

	Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
		Console.Beep(440, 500)
	End Sub

	Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
		Console.Beep(466, 500)
	End Sub

	Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
		Console.Beep(494, 500)
	End Sub

	Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
		PlayLoopingBackgroundSoundFile()

	End Sub
	Sub PlayLoopingBackgroundSoundFile()
		Dim fullpath As String = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\")
		If met100On Then
			My.Computer.Audio.Play(fullpath & "100bpm.wav",
		AudioPlayMode.BackgroundLoop)
			met100On = False
		Else
			StopBackgroundSound()
			met100On = True
		End If

	End Sub
	Sub StopBackgroundSound()
		My.Computer.Audio.Stop()
	End Sub
	Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
		PlayLoopingBackgroundSoundFile2()
	End Sub
	Sub PlayLoopingBackgroundSoundFile2()
		Dim fullpath As String = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\")
		If met75On Then
			My.Computer.Audio.Play(fullpath & "75bpm.wav",
		AudioPlayMode.BackgroundLoop)
			met75On = False
		Else
			StopBackgroundSound2()
			met75On = True
		End If

	End Sub
	Sub StopBackgroundSound2()
		My.Computer.Audio.Stop()
	End Sub
	Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Display.Click

	End Sub


	Private Sub aa(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub





	Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
		If keyData = Keys.Up Then
			If curOct < 2 Then
				curOct += 1
			End If

			Select Case curOct
				Case 0
					Me.Label31.Text = "Low"
				Case 1
					Me.Label31.Text = "Normal"
				Case 2
					Me.Label31.Text = "High"
			End Select

			Return True
		End If
		'detect down arrow key
		If keyData = Keys.Down Then
			If curOct > 0 Then
				curOct -= 1
			End If

			Select Case curOct
				Case 0
					Me.Label31.Text = "Low"
				Case 1
					Me.Label31.Text = "Normal"
				Case 2
					Me.Label31.Text = "High"
			End Select

			Return True
		End If
		Return MyBase.ProcessCmdKey(msg, keyData)
	End Function


	Private Sub Button1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button1.KeyPress

	End Sub

	Private Sub Button2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button2.KeyPress

	End Sub

	Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
		Select Case Asc(e.KeyChar)
			Case 113    'q
				Me.Display.Text = "C"
				Select Case curOct
					Case 0
						Console.Beep(65, (TrackBar1.Value * 100) + dur)
					Case 1
						Console.Beep(262, (TrackBar1.Value * 100) + dur)
					Case 2
						Console.Beep(1047, (TrackBar1.Value * 100) + dur)
				End Select

			Case 50     '2
				Me.Display.Text = "Db"
				Select Case curOct
					Case 0
						Console.Beep(69, (TrackBar1.Value * 100) + dur)
					Case 1
						Console.Beep(277, (TrackBar1.Value * 100) + dur)
					Case 2
						Console.Beep(1109, (TrackBar1.Value * 100) + dur)
				End Select

			Case 119    'w
				Me.Display.Text = "D"
				Select Case curOct
					Case 0
						Console.Beep(73, (TrackBar1.Value * 100) + dur)
					Case 1
						Console.Beep(294, (TrackBar1.Value * 100) + dur)
					Case 2
						Console.Beep(1175, (TrackBar1.Value * 100) + dur)
				End Select

			Case 51     '3
				Me.Display.Text = "Eb"
				Select Case curOct
					Case 0
						Console.Beep(78, (TrackBar1.Value * 100) + dur)
					Case 1
						Console.Beep(311, (TrackBar1.Value * 100) + dur)
					Case 2
						Console.Beep(1245, (TrackBar1.Value * 100) + dur)
				End Select

			Case 101    'e
				Me.Display.Text = "E"
				Select Case curOct
					Case 0
						Console.Beep(82, (TrackBar1.Value * 100) + dur)
					Case 1
						Console.Beep(330, (TrackBar1.Value * 100) + dur)
					Case 2
						Console.Beep(1318, (TrackBar1.Value * 100) + dur)
				End Select

			Case 114    'r
				Me.Display.Text = "F"
				Select Case curOct
					Case 0
						Console.Beep(87, (TrackBar1.Value * 100) + dur)
					Case 1
						Console.Beep(349, (TrackBar1.Value * 100) + dur)
					Case 2
						Console.Beep(1397, (TrackBar1.Value * 100) + dur)
				End Select

			Case 53     '5
				Me.Display.Text = "Gb"
				Select Case curOct
					Case 0
						Console.Beep(93, (TrackBar1.Value * 100) + dur)
					Case 1
						Console.Beep(370, (TrackBar1.Value * 100) + dur)
					Case 2
						Console.Beep(1480, (TrackBar1.Value * 100) + dur)
				End Select

			Case 116    't
				Me.Display.Text = "G"
				Select Case curOct
					Case 0
						Console.Beep(98, (TrackBar1.Value * 100) + dur)
					Case 1
						Console.Beep(392, (TrackBar1.Value * 100) + dur)
					Case 2
						Console.Beep(1568, (TrackBar1.Value * 100) + dur)
				End Select

			Case 54     '6
				Me.Display.Text = "Ab"
				Select Case curOct
					Case 0
						Console.Beep(104, (TrackBar1.Value * 100) + dur)
					Case 1
						Console.Beep(415, (TrackBar1.Value * 100) + dur)
					Case 2
						Console.Beep(1661, (TrackBar1.Value * 100) + dur)
				End Select

			Case 121    'y
				Me.Display.Text = "A"
				Select Case curOct
					Case 0
						Console.Beep(110, (TrackBar1.Value * 100) + dur)
					Case 1
						Console.Beep(440, (TrackBar1.Value * 100) + dur)
					Case 2
						Console.Beep(1760, (TrackBar1.Value * 100) + dur)
				End Select

			Case 55     '7
				Me.Display.Text = "Bb"
				Select Case curOct
					Case 0
						Console.Beep(117, (TrackBar1.Value * 100) + dur)
					Case 1
						Console.Beep(466, (TrackBar1.Value * 100) + dur)
					Case 2
						Console.Beep(1865, (TrackBar1.Value * 100) + dur)
				End Select

			Case 117    'u
				Me.Display.Text = "B"
				Select Case curOct
					Case 0
						Console.Beep(123, (TrackBar1.Value * 100) + dur)
					Case 1
						Console.Beep(494, (TrackBar1.Value * 100) + dur)
					Case 2
						Console.Beep(1976, (TrackBar1.Value * 100) + dur)
				End Select




			Case 118    'v
				Me.Display.Text = "C"
				Select Case curOct
					Case 0
						Console.Beep(131, (TrackBar1.Value * 100) + dur)
					Case 1
						Console.Beep(523, (TrackBar1.Value * 100) + dur)
					Case 2
						Console.Beep(2093, (TrackBar1.Value * 100) + dur)
				End Select

			Case 103    'g
				Me.Display.Text = "Db"
				Select Case curOct
					Case 0
						Console.Beep(139, (TrackBar1.Value * 100) + dur)
					Case 1
						Console.Beep(554, (TrackBar1.Value * 100) + dur)
					Case 2
						Console.Beep(2217, (TrackBar1.Value * 100) + dur)
				End Select

			Case 98     'b
				Me.Display.Text = "D"
				Select Case curOct
					Case 0
						Console.Beep(147, (TrackBar1.Value * 100) + dur)
					Case 1
						Console.Beep(587, (TrackBar1.Value * 100) + dur)
					Case 2
						Console.Beep(2349, (TrackBar1.Value * 100) + dur)
				End Select

			Case 104    'h
				Me.Display.Text = "Eb"
				Select Case curOct
					Case 0
						Console.Beep(156, (TrackBar1.Value * 100) + dur)
					Case 1
						Console.Beep(622, (TrackBar1.Value * 100) + dur)
					Case 2
						Console.Beep(2489, (TrackBar1.Value * 100) + dur)
				End Select

			Case 110    'n
				Me.Display.Text = "E"
				Select Case curOct
					Case 0
						Console.Beep(165, (TrackBar1.Value * 100) + dur)
					Case 1
						Console.Beep(659, (TrackBar1.Value * 100) + dur)
					Case 2
						Console.Beep(2637, (TrackBar1.Value * 100) + dur)
				End Select

			Case 109    'm
				Me.Display.Text = "F"
				Select Case curOct
					Case 0
						Console.Beep(175, (TrackBar1.Value * 100) + dur)
					Case 1
						Console.Beep(698, (TrackBar1.Value * 100) + dur)
					Case 2
						Console.Beep(2794, (TrackBar1.Value * 100) + dur)
				End Select

			Case 107     'k
				Me.Display.Text = "Gb"
				Select Case curOct
					Case 0
						Console.Beep(185, (TrackBar1.Value * 100) + dur)
					Case 1
						Console.Beep(740, (TrackBar1.Value * 100) + dur)
					Case 2
						Console.Beep(2960, (TrackBar1.Value * 100) + dur)
				End Select

			Case 44    ',
				Me.Display.Text = "G"
				Select Case curOct
					Case 0
						Console.Beep(196, (TrackBar1.Value * 100) + dur)
					Case 1
						Console.Beep(784, (TrackBar1.Value * 100) + dur)
					Case 2
						Console.Beep(3136, (TrackBar1.Value * 100) + dur)
				End Select

			Case 108     'l
				Me.Display.Text = "Ab"
				Select Case curOct
					Case 0
						Console.Beep(208, (TrackBar1.Value * 100) + dur)
					Case 1
						Console.Beep(831, (TrackBar1.Value * 100) + dur)
					Case 2
						Console.Beep(3322, (TrackBar1.Value * 100) + dur)
				End Select

			Case 46    '.
				Me.Display.Text = "A"
				Select Case curOct
					Case 0
						Console.Beep(220, (TrackBar1.Value * 100) + dur)
					Case 1
						Console.Beep(880, (TrackBar1.Value * 100) + dur)
					Case 2
						Console.Beep(3520, (TrackBar1.Value * 100) + dur)
				End Select

			Case 59     ';
				Me.Display.Text = "Bb"
				Select Case curOct
					Case 0
						Console.Beep(233, (TrackBar1.Value * 100) + dur)
					Case 1
						Console.Beep(932, (TrackBar1.Value * 100) + dur)
					Case 2
						Console.Beep(3729, (TrackBar1.Value * 100) + dur)
				End Select

			Case 47    '/
				Me.Display.Text = "B"
				Select Case curOct
					Case 0
						Console.Beep(247, (TrackBar1.Value * 100) + dur)
					Case 1
						Console.Beep(988, (TrackBar1.Value * 100) + dur)
					Case 2
						Console.Beep(3951, (TrackBar1.Value * 100) + dur)
				End Select

		End Select
	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
		Me.KeyPreview = True
	End Sub

	Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
		PlayLoopingBackgroundSoundFile1()
	End Sub
	Sub PlayLoopingBackgroundSoundFile1()
		Dim fullpath As String = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\")
		If met120On Then
			My.Computer.Audio.Play(fullpath & "120bpm.wav",
		AudioPlayMode.BackgroundLoop)
			met120On = False
		Else
			StopBackgroundSound1()
			met120On = True
		End If

	End Sub
	Sub StopBackgroundSound1()
		My.Computer.Audio.Stop()
	End Sub

	Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
		PlayLoopingBackgroundSoundFile3()
	End Sub
	Sub PlayLoopingBackgroundSoundFile3()
		Dim fullpath As String = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\")
		If synthOn Then
			My.Computer.Audio.Play(fullpath & "DemoSynth.wav",
		AudioPlayMode.BackgroundLoop)
			synthOn = False
		Else
			StopBackgroundSound3()
			synthOn = True
		End If

	End Sub
	Sub StopBackgroundSound3()
		My.Computer.Audio.Stop()
	End Sub
	Sub PlayLoopingBackgroundSoundFile4()
		Dim fullpath As String = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\")
		If steelDrumOn Then
			My.Computer.Audio.Play(fullpath & "SteelDrum.wav",
		AudioPlayMode.BackgroundLoop)
			steelDrumOn = False
		Else
			StopBackgroundSound4()
			steelDrumOn = True
		End If

	End Sub
	Sub StopBackgroundSound4()
		My.Computer.Audio.Stop()
	End Sub
	Sub PlayLoopingBackgroundSoundFile5()
		Dim fullpath As String = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\")
		If drumOn Then
			My.Computer.Audio.Play(fullpath & "Drum.wav",
		AudioPlayMode.BackgroundLoop)
			drumOn = False
		Else
			StopBackgroundSound5()
			drumOn = True
		End If

	End Sub
	Sub StopBackgroundSound5()
		My.Computer.Audio.Stop()
	End Sub

	Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
		PlayLoopingBackgroundSoundFile4()
	End Sub

	Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
		PlayLoopingBackgroundSoundFile5()
	End Sub

	Private Sub Label31_Click(sender As Object, e As EventArgs) Handles Label31.Click

	End Sub

	Private Sub PictureBox2_Click(sender As Object, e As EventArgs) 

	End Sub
End Class
