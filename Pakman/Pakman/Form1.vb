Imports System.Drawing
Imports System.Windows.Forms
Public Class Form1
    'map 
    Dim map = {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                {0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0},
                {0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 1, 0, 1, 0},
                {0, 1, 0, 0, 0, 1, 0, 1, 1, 0, 0, 1, 0, 1, 0},
                {0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0},
                {0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0},
                {0, 1, 1, 1, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 0},
                {0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}}
    'kumpulan variabel
    Dim tsz = 40 'tile size (ukuran grid/tilenya)
    Dim pacx = 1 'pakman itu di petak x mana sekarang
    Dim pacy = 1 ' petak y
    Dim enmx = 9 'musuh itu di petak x berapa
    Dim enmy = 7 ' petak y
    Dim enmx2 = 11 'musuh itu di petak x berapa
    Dim enmy2 = 5 ' petak y
    Dim enmx3 = 4 'musuh itu di petak x berapa
    Dim enmy3 = 5 ' petak y
    Dim goalx = 1 'goal (pintu keluar pakman di petak x brp
    Dim goaly = 7 'goal di petak y berapa
    Dim bmp As Bitmap
    Dim oldpacx = 0
    Dim oldpacy = 0
    Dim titikAwal = 1
    'deklarasi sprite citra yang digunakan
    Dim wall As Image = Image.FromFile("D:\aset_game_pakman\bata.png")
    Dim way As Image = Image.FromFile("D:\aset_game_pakman\rumput.png")
    Dim pac As Image = Image.FromFile("D:\aset_game_pakman\pakman.png")
    Dim enm As Image = Image.FromFile("D:\aset_game_pakman\hantu3.png")
    Dim goal As Image = Image.FromFile("D:\aset_game_pakman\omah.jpg")
    Dim isRotateKanan As Boolean = True
    Dim isRotateKiri As Boolean = False
    Dim isRotateAtas As Boolean = False
    Dim isRotateBawah As Boolean = False
    Dim nyawa As Integer = 3
    Private Sub Redraw()
        Dim g As Graphics = Graphics.FromImage(PictureBox1.Image)
        'gambarkan background (jalan dan tembok)
        For y = 0 To 9 '0 to 8 yaitu tinggi map - 1
            For x = 0 To 14 '0 to 10 yaitu lebar map - 1
                If map(y, x) = 0 Then
                    g.DrawImage(wall, x * tsz, y * tsz, tsz, tsz)
                Else
                    g.DrawImage(way, x * tsz, y * tsz, tsz, tsz)
                End If
            Next
        Next
        'gambarkan pacman
        g.DrawImage(pac, pacx * tsz, pacy * tsz, tsz, tsz)
        'gambarkan musuh1
        g.DrawImage(enm, enmx * tsz, enmy * tsz, tsz, tsz)
        'gambarkan musuh2
        g.DrawImage(enm, enmx2 * tsz, enmy2 * tsz, tsz, tsz)
        'gambarkan musuh3
        g.DrawImage(enm, enmx3 * tsz, enmy3 * tsz, tsz, tsz)
        'gambarkan goal
        g.DrawImage(goal, goalx * tsz, goaly * tsz, tsz, tsz)
        PictureBox1.Refresh()
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                If map(pacy - 1, pacx) = 1 Then
                    pacy = pacy - 1
                    If isRotateAtas = False Then
                        If isRotateBawah = True Then
                            pac.RotateFlip(RotateFlipType.Rotate180FlipNone)
                            isRotateAtas = True
                            isRotateBawah = False
                            isRotateKanan = False
                            isRotateKiri = False
                        End If
                        If isRotateKanan = True Then
                            pac.RotateFlip(RotateFlipType.Rotate270FlipNone)
                            isRotateAtas = True
                            isRotateBawah = False
                            isRotateKanan = False
                            isRotateKiri = False
                        End If
                        If isRotateKiri = True Then
                            pac.RotateFlip(RotateFlipType.Rotate90FlipNone)
                            isRotateAtas = True
                            isRotateBawah = False
                            isRotateKanan = False
                            isRotateKiri = False
                        End If
                    End If
                End If
            Case Keys.Down
                If map(pacy + 1, pacx) = 1 Then
                    pacy = pacy + 1
                    If isRotateBawah = False Then
                        If isRotateAtas = True Then
                            pac.RotateFlip(RotateFlipType.Rotate180FlipNone)
                            isRotateAtas = False
                            isRotateBawah = True
                            isRotateKanan = False
                            isRotateKiri = False
                        End If
                        If isRotateKanan = True Then
                            pac.RotateFlip(RotateFlipType.Rotate90FlipNone)
                            isRotateAtas = False
                            isRotateBawah = True
                            isRotateKanan = False
                            isRotateKiri = False
                        End If
                        If isRotateKiri = True Then
                            pac.RotateFlip(RotateFlipType.Rotate270FlipNone)
                            isRotateAtas = False
                            isRotateBawah = True
                            isRotateKanan = False
                            isRotateKiri = False
                        End If
                    End If
                End If
            Case Keys.Right
                If map(pacy, pacx + 1) = 1 Then
                    pacx = pacx + 1
                    If isRotateKanan = False Then
                        If isRotateAtas = True Then
                            pac.RotateFlip(RotateFlipType.Rotate90FlipNone)
                            isRotateAtas = False
                            isRotateBawah = False
                            isRotateKanan = True
                            isRotateKiri = False
                        End If
                        If isRotateBawah = True Then
                            pac.RotateFlip(RotateFlipType.Rotate270FlipNone)
                            isRotateAtas = False
                            isRotateBawah = False
                            isRotateKanan = True
                            isRotateKiri = False
                        End If
                        If isRotateKiri = True Then
                            pac.RotateFlip(RotateFlipType.Rotate180FlipNone)
                            isRotateAtas = False
                            isRotateBawah = False
                            isRotateKanan = True
                            isRotateKiri = False
                        End If
                    End If
                End If
            Case Keys.Left
                If map(pacy, pacx - 1) = 1 Then
                    pacx = pacx - 1
                    If isRotateKiri = False Then
                        If isRotateAtas = True Then
                            pac.RotateFlip(RotateFlipType.Rotate270FlipNone)
                            isRotateAtas = False
                            isRotateBawah = False
                            isRotateKanan = False
                            isRotateKiri = True
                        End If
                        If isRotateBawah = True Then
                            pac.RotateFlip(RotateFlipType.Rotate90FlipNone)
                            isRotateAtas = False
                            isRotateBawah = False
                            isRotateKanan = False
                            isRotateKiri = True
                        End If
                        If isRotateKanan = True Then
                            pac.RotateFlip(RotateFlipType.Rotate180FlipNone)
                            isRotateAtas = False
                            isRotateBawah = False
                            isRotateKanan = False
                            isRotateKiri = True
                        End If
                    End If
                End If
        End Select
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'sesuaikan dulu ukuran picturebox dan form
        PictureBox1.Width = (map.length / (map.GetUpperBound(0) + 1)) * tsz
        PictureBox1.Height = (map.GetUpperBound(0) + 1) * tsz
        Me.Width = PictureBox1.Width + tsz
        Me.Height = PictureBox1.Height + tsz
        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Image = bmp
        Redraw()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'engine untuk musuh
        Dim jarakx, jaraky, jarakx2, jaraky2, jarakx3, jaraky3 As Integer
        Dim arah As Integer 'arah musuh, 0 atas, 1 kanan, 2 bawah, 3 kiri
        'cek jarak pakman dg musuh. kalau lebih jauh di sb x, kejar di x dulu
        'kalau lebih dekat di sb y, kejar ke sb y dulu
        jarakx = Math.Abs(pacx - enmx)
        jaraky = Math.Abs(pacy - enmy)

        jarakx2 = Math.Abs(pacx - enmx2)
        jaraky2 = Math.Abs(pacy - enmy2)

        jarakx3 = Math.Abs(pacx - enmx3)
        jaraky3 = Math.Abs(pacy - enmy3)

        'enemy 1
        If jarakx > jaraky Then 'jika lebih jauh jarak kejar di x
            If (pacx - enmx > 0) Then 'jika pakman di kanan
                arah = 1 'arah kanan
            Else 'jika tidak
                arah = 3 'arah kiri
            End If
        End If
        If jarakx < jaraky Then
            If (pacy - enmy > 0) Then 'jika pakman di bawah
                arah = 2 'arah bawah
            Else 'jika tidak
                arah = 0 'arah atas
            End If
        End If

        'enemy 2
        If jarakx2 > jaraky2 Then 'jika lebih jauh jarak kejar di x
            If (pacx - enmx2 > 0) Then 'jika pakman di kanan
                arah = 1 'arah kanan
            Else 'jika tidak
                arah = 3 'arah kiri
            End If
        End If
        If jarakx2 < jaraky2 Then
            If (pacy - enmy2 > 0) Then 'jika pakman di bawah
                arah = 2 'arah bawah
            Else 'jika tidak
                arah = 0 'arah atas
            End If
        End If

        'enemy 3
        If jarakx3 > jaraky3 Then 'jika lebih jauh jarak kejar di x
            If (pacx - enmx3 > 0) Then 'jika pakman di kanan
                arah = 1 'arah kanan
            Else 'jika tidak
                arah = 3 'arah kiri
            End If
        End If
        If jarakx3 < jaraky3 Then
            If (pacy - enmy3 > 0) Then 'jika pakman di bawah
                arah = 2 'arah bawah
            Else 'jika tidak
                arah = 0 'arah atas
            End If
        End If
        If (oldpacx = pacx) And (oldpacy = pacy) Then 'jika stop
            arah = Math.Floor(Rnd() * 4)
        End If
        Select Case arah
            Case 0
                If map(enmy - 1, enmx) = 1 Then
                    enmy = enmy - 1
                End If

                If map(enmy2 - 1, enmx2) = 1 Then
                    enmy2 = enmy2 - 1
                End If

                If map(enmy3 - 1, enmx3) = 1 Then
                    enmy3 = enmy3 - 1
                End If
            Case 2
                If map(enmy + 1, enmx) = 1 Then
                    enmy = enmy + 1
                End If

                If map(enmy2 + 1, enmx2) = 1 Then
                    enmy2 = enmy2 + 1
                End If

                If map(enmy3 + 1, enmx3) = 1 Then
                    enmy3 = enmy3 + 1
                End If
            Case 1
                If map(enmy, enmx + 1) = 1 Then
                    enmx = enmx + 1
                End If

                If map(enmy2, enmx2 + 1) = 1 Then
                    enmx2 = enmx2 + 1
                End If

                If map(enmy3, enmx3 + 1) = 1 Then
                    enmx3 = enmx3 + 1
                End If
            Case 3
                If map(enmy, enmx - 1) = 1 Then
                    enmx = enmx - 1
                End If

                If map(enmy2, enmx2 - 1) = 1 Then
                    enmx2 = enmx2 - 1
                End If

                If map(enmy3, enmx3 - 1) = 1 Then
                    enmx3 = enmx3 - 1
                End If
        End Select
        oldpacx = pacx
        oldpacy = pacy
        Redraw()

        'cek apakah posisi pakman sama dg musuh
        If (pacx = enmx) And (pacy = enmy) Then
            nyawa = nyawa - 1
            If nyawa = 0 Then
                Timer1.Enabled = False
                hati3.Visible = False
                MsgBox("Pakman Dies!")
            Else
                If nyawa = 2 Then
                    hati1.Visible = False
                    pacx = titikAwal
                    pacy = titikAwal
                    enmx = 9
                    enmy = 7
                    enmx2 = 11
                    enmx3 = 5
                    enmx3 = 4
                    enmy3 = 5
                    Redraw()
                End If
                If nyawa = 1 Then
                    hati2.Visible = False
                    pacx = titikAwal
                    pacy = titikAwal
                    enmx = 9
                    enmy = 7
                    enmx2 = 11
                    enmx3 = 5
                    enmx3 = 4
                    enmy3 = 5
                    Redraw()
                End If
            End If
        ElseIf (pacx = enmx2) And (pacy = enmy2) Then
            nyawa = nyawa - 1
            If nyawa = 0 Then
                Timer1.Enabled = False
                hati3.Visible = False
                MsgBox("Pakman Dies!")
            Else
                If nyawa = 2 Then
                    hati1.Visible = False
                    pacx = titikAwal
                    pacy = titikAwal
                    enmx = 9
                    enmy = 7
                    enmx2 = 11
                    enmx3 = 5
                    enmx3 = 4
                    enmy3 = 5
                    Redraw()
                End If
                If nyawa = 1 Then
                    hati2.Visible = False
                    pacx = titikAwal
                    pacy = titikAwal
                    enmx = 9
                    enmy = 7
                    enmx2 = 11
                    enmx3 = 5
                    enmx3 = 4
                    enmy3 = 5
                    Redraw()
                End If
            End If
        ElseIf (pacx = enmx3) And (pacy = enmy3) Then
            nyawa = nyawa - 1
            If nyawa = 0 Then
                Timer1.Enabled = False
                hati3.Visible = False
                MsgBox("Pakman Dies!")
            Else
                If nyawa = 2 Then
                    hati1.Visible = False
                    pacx = titikAwal
                    pacy = titikAwal
                    enmx = 9
                    enmy = 7
                    enmx2 = 11
                    enmx3 = 5
                    enmx3 = 4
                    enmy3 = 5
                    Redraw()
                End If
                If nyawa = 1 Then
                    hati2.Visible = False
                    pacx = titikAwal
                    pacy = titikAwal
                    enmx = 9
                    enmy = 7
                    enmx2 = 11
                    enmx3 = 5
                    enmx3 = 4
                    enmy3 = 5
                    Redraw()
                End If
            End If
        End If
        'cek apakah posisi pakman sama dg rumah
        If (pacx = goalx) And (pacy = goaly) Then
            Timer1.Enabled = False
            MsgBox("Pakman safe at Home!")
        End If
    End Sub
End Class
