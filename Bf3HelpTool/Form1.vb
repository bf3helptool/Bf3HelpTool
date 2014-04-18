Public Class Form1
    Dim AppLocation, CurLocation As New Point(0, 0)
    Private Sub DeumosButton2_Click(sender As Object, e As EventArgs) Handles DeumosButton2.Click
        Application.Exit()
    End Sub

    Private Sub DeumosButton1_Click(sender As Object, e As EventArgs) Handles DeumosButton1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub DeumosTheme1_Click(sender As Object, e As EventArgs) Handles DeumosTheme1.Click

    End Sub
    Private Sub Sync()
        AppLocation = Me.Location
        CurLocation = Cursor.Position

    End Sub

    Private Sub DeumosTheme1_MouseDown(sender As Object, e As MouseEventArgs) Handles DeumosTheme1.MouseDown
        Timer1.Enabled = True
        Timer1.Start()
        Sync()
    End Sub

    Private Sub DeumosTheme1_MouseUp(sender As Object, e As MouseEventArgs) Handles DeumosTheme1.MouseUp
        Timer1.Stop()
        Sync()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Location = AppLocation - CurLocation + Cursor.Position
        Sync()
    End Sub

    Private Sub TabControl1_MouseDown(sender As Object, e As MouseEventArgs) Handles TabControl1.MouseDown
        Timer1.Enabled = True
        Timer1.Start()
        Sync()
    End Sub

    Private Sub TabControl1_MouseUp(sender As Object, e As MouseEventArgs) Handles TabControl1.MouseUp
        Timer1.Stop()
        Sync()
    End Sub

    Private Sub Home_MouseDown(sender As Object, e As MouseEventArgs) Handles Home.MouseDown
        Timer1.Enabled = True
        Timer1.Start()
        Sync()
    End Sub

    Private Sub Home_MouseUp(sender As Object, e As MouseEventArgs) Handles Home.MouseUp
        Timer1.Stop()
        Sync()
    End Sub

    Private Sub Maps_MouseDown(sender As Object, e As MouseEventArgs) Handles Maps.MouseDown
        Timer1.Enabled = True
        Timer1.Start()
        Sync()
    End Sub

    Private Sub Maps_MouseUp(sender As Object, e As MouseEventArgs) Handles Maps.MouseUp
        Timer1.Stop()
        Sync()
    End Sub

    Private Sub Vehicles_MouseDown(sender As Object, e As MouseEventArgs) Handles Vehicles.MouseDown
        Timer1.Enabled = True
        Timer1.Start()
        Sync()
    End Sub

    Private Sub Vehicles_MouseUp(sender As Object, e As MouseEventArgs) Handles Vehicles.MouseUp
        Timer1.Stop()
        Sync()
    End Sub

    Private Sub Weapons_MouseDown(sender As Object, e As MouseEventArgs) Handles Weapons.MouseDown
        Timer1.Enabled = True
        Timer1.Start()
        Sync()
    End Sub

    Private Sub Weapons_MouseUp(sender As Object, e As MouseEventArgs) Handles Weapons.MouseUp
        Timer1.Stop()
        Sync()
    End Sub

    Private Sub Extra_MouseDown(sender As Object, e As MouseEventArgs) Handles Extra.MouseDown
        Timer1.Enabled = True
        Timer1.Start()
        Sync()
    End Sub

    Private Sub Extra_MouseUp(sender As Object, e As MouseEventArgs) Handles Extra.MouseUp
        Timer1.Stop()
        Sync()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Battlefield 3 - Help Tool"

    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        Timer1.Enabled = True
        Timer1.Start()
        Sync()
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        Timer1.Stop()
        Sync()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub DeumosButton3_Click(sender As Object, e As EventArgs) Handles DeumosButton3.Click
        If ComboBox1.SelectedItem = "AEK-971" Then
            'Assault Rifles:
            AEK_971.ShowDialog()
        ElseIf ComboBox1.SelectedItem = "AK-74M" Then
            'Open ak74m
        ElseIf ComboBox1.SelectedItem = "AN-94" Then
            'open an94
        ElseIf ComboBox1.SelectedItem = "F2000" Then
            'Open f2000
        ElseIf ComboBox1.SelectedItem = "G3A3" Then
            'Open G3A3
        ElseIf ComboBox1.SelectedItem = "KH2002" Then
            'Open KH2002
        ElseIf ComboBox1.SelectedItem = "M16A3" Then
            'Open M16A3
        ElseIf ComboBox1.SelectedItem = "M16A4" Then
            'Open M16A4
        ElseIf ComboBox1.SelectedItem = "M416" Then
            'Open M416
        ElseIf ComboBox1.SelectedItem = "FAMAS" Then
            'open 
        ElseIf ComboBox1.SelectedItem = "L85A2" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "AUG A3" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "SCAR-L" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "A-91" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "AKS-74u" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "G36C" Then
            'Open
        ElseIf ComboBox1.SelectedItem = "M4A1" Then
            'open 
        ElseIf ComboBox1.SelectedItem = "SCAR H" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "SG553" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "G53" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "QBZ-95B" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "ACW-R" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "MTAR-21" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = ".44 Magnum" Then
            'open 
        ElseIf ComboBox1.SelectedItem = "93R" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "G17C" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "G18" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "M9" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "M1911" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "MP412 REX" Then
            'Open
        ElseIf ComboBox1.SelectedItem = "MP443" Then
            'open 
        ElseIf ComboBox1.SelectedItem = "M27 IAR" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "M240B" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "M249" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "M60E4" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "PKP Pecheneg" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "RPK-74M" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "Type 88 LMG" Then
            'open 
        ElseIf ComboBox1.SelectedItem = "MG36" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "QBB-95" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "L86A2" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "LSAT" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "AS VAL" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "MP7" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "P90" Then
            'open 
        ElseIf ComboBox1.SelectedItem = "PDW-R" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "PP-2000" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "UMP-45" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "PP-19" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "M5K" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "FIM-92 Stinger" Then
            'Open
        ElseIf ComboBox1.SelectedItem = "RPG-7V2" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "SA-18 IGLA" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "SMAW" Then
            'open 
        ElseIf ComboBox1.SelectedItem = "FGM-148 JAVELIN" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "870MCS" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "DAO-12" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "M1014" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "SAIGA-12K" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "USAS-12" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "MK3A1" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "SPAS-12" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "AS VAL" Then
            'open 
        ElseIf ComboBox1.SelectedItem = "M39 EMR" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "M40A5" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "M82A3" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "M98B" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "MK11 MOD 0" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "SKS" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "SVD" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "SV98" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "L96" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "QBU-88" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "JNG-90" Then
            'Open 
        ElseIf ComboBox1.SelectedItem = "M417" Then
            'Open 

        End If
    End Sub
End Class
