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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DeumosTheme1 = New Bf3HelpTool.DeumosTheme()
        Me.DeumosButton2 = New Bf3HelpTool.DeumosButton()
        Me.DeumosButton1 = New Bf3HelpTool.DeumosButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Home = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Weapons = New System.Windows.Forms.TabPage()
        Me.DeumosButton3 = New Bf3HelpTool.DeumosButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Vehicles = New System.Windows.Forms.TabPage()
        Me.Maps = New System.Windows.Forms.TabPage()
        Me.Extra = New System.Windows.Forms.TabPage()
        Me.DeumosTheme1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Home.SuspendLayout()
        Me.Weapons.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'DeumosTheme1
        '
        Me.DeumosTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.DeumosTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.DeumosTheme1.Controls.Add(Me.DeumosButton2)
        Me.DeumosTheme1.Controls.Add(Me.DeumosButton1)
        Me.DeumosTheme1.Controls.Add(Me.TabControl1)
        Me.DeumosTheme1.Customization = "Dg4O/zAwMP8EBAT/AAAA//////////8aLS0t/wAAAP////8PZGRk/////yr///8PDg4O/ykpKf8="
        Me.DeumosTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DeumosTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DeumosTheme1.HeaderOffset = 1
        Me.DeumosTheme1.Image = Nothing
        Me.DeumosTheme1.Location = New System.Drawing.Point(0, 0)
        Me.DeumosTheme1.Movable = True
        Me.DeumosTheme1.Name = "DeumosTheme1"
        Me.DeumosTheme1.NoRounding = False
        Me.DeumosTheme1.Sizable = True
        Me.DeumosTheme1.Size = New System.Drawing.Size(963, 577)
        Me.DeumosTheme1.SmartBounds = True
        Me.DeumosTheme1.TabIndex = 0
        Me.DeumosTheme1.Text = "Battlefield 3 - Help Tool"
        Me.DeumosTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.DeumosTheme1.Transparent = False
        '
        'DeumosButton2
        '
        Me.DeumosButton2.BackColor = System.Drawing.Color.Black
        Me.DeumosButton2.Customization = "Dg4O/w4ODv8pKSn/////Bf///x7///8FPj4+/////w8AAAD/EBAQ//////8="
        Me.DeumosButton2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DeumosButton2.Image = Nothing
        Me.DeumosButton2.Location = New System.Drawing.Point(941, 1)
        Me.DeumosButton2.Name = "DeumosButton2"
        Me.DeumosButton2.NoRounding = False
        Me.DeumosButton2.Size = New System.Drawing.Size(21, 23)
        Me.DeumosButton2.TabIndex = 2
        Me.DeumosButton2.Text = "X"
        Me.DeumosButton2.Transparent = False
        '
        'DeumosButton1
        '
        Me.DeumosButton1.BackColor = System.Drawing.Color.Black
        Me.DeumosButton1.Customization = "Dg4O/w4ODv8pKSn/////Bf///x7///8FPj4+/////w8AAAD/EBAQ//////8="
        Me.DeumosButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DeumosButton1.Image = Nothing
        Me.DeumosButton1.Location = New System.Drawing.Point(919, 1)
        Me.DeumosButton1.Name = "DeumosButton1"
        Me.DeumosButton1.NoRounding = False
        Me.DeumosButton1.Size = New System.Drawing.Size(21, 23)
        Me.DeumosButton1.TabIndex = 1
        Me.DeumosButton1.Text = "-"
        Me.DeumosButton1.Transparent = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Home)
        Me.TabControl1.Controls.Add(Me.Weapons)
        Me.TabControl1.Controls.Add(Me.Vehicles)
        Me.TabControl1.Controls.Add(Me.Maps)
        Me.TabControl1.Controls.Add(Me.Extra)
        Me.TabControl1.Location = New System.Drawing.Point(9, 26)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(946, 543)
        Me.TabControl1.TabIndex = 0
        '
        'Home
        '
        Me.Home.BackgroundImage = CType(resources.GetObject("Home.BackgroundImage"), System.Drawing.Image)
        Me.Home.Controls.Add(Me.Label1)
        Me.Home.Controls.Add(Me.WebBrowser1)
        Me.Home.Location = New System.Drawing.Point(4, 22)
        Me.Home.Name = "Home"
        Me.Home.Padding = New System.Windows.Forms.Padding(3)
        Me.Home.Size = New System.Drawing.Size(938, 517)
        Me.Home.TabIndex = 0
        Me.Home.Text = "Home"
        Me.Home.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(375, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(144, 72)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(647, 373)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("http://heroofbf3.tumblr.com/", System.UriKind.Absolute)
        '
        'Weapons
        '
        Me.Weapons.BackgroundImage = Global.Bf3HelpTool.My.Resources.Resources.weapons
        Me.Weapons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Weapons.Controls.Add(Me.DeumosButton3)
        Me.Weapons.Controls.Add(Me.ComboBox1)
        Me.Weapons.Location = New System.Drawing.Point(4, 22)
        Me.Weapons.Name = "Weapons"
        Me.Weapons.Padding = New System.Windows.Forms.Padding(3)
        Me.Weapons.Size = New System.Drawing.Size(938, 517)
        Me.Weapons.TabIndex = 1
        Me.Weapons.Text = "Weapons"
        Me.Weapons.UseVisualStyleBackColor = True
        '
        'DeumosButton3
        '
        Me.DeumosButton3.Customization = "Dg4O/w4ODv8pKSn/////Bf///x7///8FPj4+/////w8AAAD/EBAQ//////8="
        Me.DeumosButton3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DeumosButton3.Image = Nothing
        Me.DeumosButton3.Location = New System.Drawing.Point(433, 446)
        Me.DeumosButton3.Name = "DeumosButton3"
        Me.DeumosButton3.NoRounding = False
        Me.DeumosButton3.Size = New System.Drawing.Size(74, 23)
        Me.DeumosButton3.TabIndex = 1
        Me.DeumosButton3.Text = "Find"
        Me.DeumosButton3.Transparent = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Assault Rifles", "-------------------------------------", "AEK-971", "AK-74M", "AN-94", "F2000", "G3A3", "KH2002", "M16A3", "M16A4", "M416", "-------------------------------------", "BACK TO KARKAND", "FAMAS", "L85A2", "G53", "QBZ-95B", "MG36", "QBB-95", "PP-19", "MK3A1", "L96", "QBU-88", "-------------------------------------", "CLOSE QUARTERS", "AUG A3", "SCAR-L", "G53", "QBZ-95B", "MG36", "QBB-95", "PP-19", "MK3A1", "L96", "QBU-88", "-------------------------------------", "Carbines", "A-91", "AKS-74u", "G36C", "M4A1", "SCAR H", "SG553", "-------------------------------------", "Hand Guns", ".44 Magnum", "93R", "G17C", "G18", "M9", "M1911", "MP412 REX", "MP443", "-------------------------------------", "Light Machine Guns", "M27 IAR", "M240B", "M249", "M60E4", "PKP Pecheneg", "RPK-74M", "Type 88 LMG", "-------------------------------------", "Personal Defense Weapons", "AS VAL", "MP7", "P90", "PDW-R", "PP-2000", "UMP-45", "-------------------------------------", "Rocket Launchers", "", "FIM-92 Stinger", "RPG-7V2", "SA-18 IGLA", "SMAW", "FGM-148 JAVELIN", "-------------------------------------", "Shotguns", "", "870MCS", "DAO-12", "M1014", "SAIGA-12K", "USAS-12", "-------------------------------------", "Sniper / Battle / Marksman Rifles", "", "AS VAL", "M39 EMR", "M40A5", "M82A3", "M98B", "MK11 MOD 0", "SKS", "SVD", "SV98", "-------------------------------------"})
        Me.ComboBox1.Location = New System.Drawing.Point(363, 419)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(212, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Vehicles
        '
        Me.Vehicles.Location = New System.Drawing.Point(4, 22)
        Me.Vehicles.Name = "Vehicles"
        Me.Vehicles.Size = New System.Drawing.Size(938, 517)
        Me.Vehicles.TabIndex = 2
        Me.Vehicles.Text = "Vehicles"
        Me.Vehicles.UseVisualStyleBackColor = True
        '
        'Maps
        '
        Me.Maps.Location = New System.Drawing.Point(4, 22)
        Me.Maps.Name = "Maps"
        Me.Maps.Size = New System.Drawing.Size(938, 517)
        Me.Maps.TabIndex = 3
        Me.Maps.Text = "Maps"
        Me.Maps.UseVisualStyleBackColor = True
        '
        'Extra
        '
        Me.Extra.Location = New System.Drawing.Point(4, 22)
        Me.Extra.Name = "Extra"
        Me.Extra.Size = New System.Drawing.Size(938, 517)
        Me.Extra.TabIndex = 4
        Me.Extra.Text = "Extra"
        Me.Extra.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 577)
        Me.Controls.Add(Me.DeumosTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Opacity = 0.99R
        Me.Text = "Battlefield 3 - Help Tool"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.DeumosTheme1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.Home.ResumeLayout(False)
        Me.Home.PerformLayout()
        Me.Weapons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DeumosTheme1 As Bf3HelpTool.DeumosTheme
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Home As System.Windows.Forms.TabPage
    Friend WithEvents Weapons As System.Windows.Forms.TabPage
    Friend WithEvents Vehicles As System.Windows.Forms.TabPage
    Friend WithEvents Maps As System.Windows.Forms.TabPage
    Friend WithEvents Extra As System.Windows.Forms.TabPage
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents DeumosButton2 As Bf3HelpTool.DeumosButton
    Friend WithEvents DeumosButton1 As Bf3HelpTool.DeumosButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DeumosButton3 As Bf3HelpTool.DeumosButton

End Class
