<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.IconButton7 = New FontAwesome.Sharp.IconButton()
        Me.IconButton6 = New FontAwesome.Sharp.IconButton()
        Me.IconButton5 = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.imgLogoDashboard = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.lblFormTittle = New System.Windows.Forms.Label()
        Me.IconHome = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.btnRegistrarSucur = New FontAwesome.Sharp.IconButton()
        Me.btnCargaProduc = New FontAwesome.Sharp.IconButton()
        Me.btnRegistrarClient = New FontAwesome.Sharp.IconButton()
        Me.btnRegistrarEmpl = New FontAwesome.Sharp.IconButton()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLogoDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.AutoScroll = True
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.IconButton7)
        Me.PanelMenu.Controls.Add(Me.IconButton6)
        Me.PanelMenu.Controls.Add(Me.IconButton5)
        Me.PanelMenu.Controls.Add(Me.btnRegistrarSucur)
        Me.PanelMenu.Controls.Add(Me.btnCargaProduc)
        Me.PanelMenu.Controls.Add(Me.btnRegistrarClient)
        Me.PanelMenu.Controls.Add(Me.btnRegistrarEmpl)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 607)
        Me.PanelMenu.TabIndex = 0
        '
        'IconButton7
        '
        Me.IconButton7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.IconButton7.FlatAppearance.BorderSize = 0
        Me.IconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton7.Font = New System.Drawing.Font("Fira Code Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IconButton7.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButton7.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.IconButton7.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButton7.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton7.IconSize = 32
        Me.IconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton7.Location = New System.Drawing.Point(0, 547)
        Me.IconButton7.Name = "IconButton7"
        Me.IconButton7.Padding = New System.Windows.Forms.Padding(10, 0, 20, 15)
        Me.IconButton7.Size = New System.Drawing.Size(220, 60)
        Me.IconButton7.TabIndex = 7
        Me.IconButton7.Text = "Salir"
        Me.IconButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton7.UseVisualStyleBackColor = True
        '
        'IconButton6
        '
        Me.IconButton6.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton6.FlatAppearance.BorderSize = 0
        Me.IconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton6.Font = New System.Drawing.Font("Fira Code Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IconButton6.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButton6.IconChar = FontAwesome.Sharp.IconChar.FilePdf
        Me.IconButton6.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButton6.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton6.IconSize = 40
        Me.IconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton6.Location = New System.Drawing.Point(0, 440)
        Me.IconButton6.Name = "IconButton6"
        Me.IconButton6.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton6.Size = New System.Drawing.Size(220, 60)
        Me.IconButton6.TabIndex = 6
        Me.IconButton6.Text = "Reportes"
        Me.IconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton6.UseVisualStyleBackColor = True
        '
        'IconButton5
        '
        Me.IconButton5.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton5.FlatAppearance.BorderSize = 0
        Me.IconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton5.Font = New System.Drawing.Font("Fira Code Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IconButton5.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButton5.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.IconButton5.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButton5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton5.IconSize = 40
        Me.IconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton5.Location = New System.Drawing.Point(0, 380)
        Me.IconButton5.Name = "IconButton5"
        Me.IconButton5.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton5.Size = New System.Drawing.Size(220, 60)
        Me.IconButton5.TabIndex = 5
        Me.IconButton5.Text = "Tienda"
        Me.IconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton5.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.IconPictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(220, 140)
        Me.PanelLogo.TabIndex = 0
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.IconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.Location = New System.Drawing.Point(74, 43)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox1.TabIndex = 0
        Me.IconPictureBox1.TabStop = False
        '
        'imgLogoDashboard
        '
        Me.imgLogoDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.imgLogoDashboard.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.imgLogoDashboard.IconColor = System.Drawing.Color.White
        Me.imgLogoDashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.imgLogoDashboard.Location = New System.Drawing.Point(936, 0)
        Me.imgLogoDashboard.Name = "imgLogoDashboard"
        Me.imgLogoDashboard.Size = New System.Drawing.Size(32, 32)
        Me.imgLogoDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgLogoDashboard.TabIndex = 0
        Me.imgLogoDashboard.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel1.Controls.Add(Me.IconPictureBox2)
        Me.Panel1.Controls.Add(Me.imgLogoDashboard)
        Me.Panel1.Controls.Add(Me.lblFormTittle)
        Me.Panel1.Controls.Add(Me.IconHome)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(220, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(973, 75)
        Me.Panel1.TabIndex = 1
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Square
        Me.IconPictureBox2.IconColor = System.Drawing.Color.White
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox2.Location = New System.Drawing.Point(898, 0)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IconPictureBox2.TabIndex = 2
        Me.IconPictureBox2.TabStop = False
        '
        'lblFormTittle
        '
        Me.lblFormTittle.AutoSize = True
        Me.lblFormTittle.Font = New System.Drawing.Font("Fira Code Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFormTittle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFormTittle.Location = New System.Drawing.Point(60, 29)
        Me.lblFormTittle.Name = "lblFormTittle"
        Me.lblFormTittle.Size = New System.Drawing.Size(49, 19)
        Me.lblFormTittle.TabIndex = 1
        Me.lblFormTittle.Text = "Home"
        '
        'IconHome
        '
        Me.IconHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IconHome.ForeColor = System.Drawing.Color.MediumPurple
        Me.IconHome.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconHome.IconColor = System.Drawing.Color.MediumPurple
        Me.IconHome.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconHome.IconSize = 36
        Me.IconHome.Location = New System.Drawing.Point(22, 20)
        Me.IconHome.Name = "IconHome"
        Me.IconHome.Size = New System.Drawing.Size(36, 36)
        Me.IconHome.TabIndex = 0
        Me.IconHome.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(220, 75)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(973, 532)
        Me.PanelDesktop.TabIndex = 2
        '
        'btnRegistrarSucur
        '
        Me.btnRegistrarSucur.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrarSucur.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRegistrarSucur.FlatAppearance.BorderSize = 0
        Me.btnRegistrarSucur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarSucur.Font = New System.Drawing.Font("Fira Code Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRegistrarSucur.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnRegistrarSucur.IconChar = FontAwesome.Sharp.IconChar.Store
        Me.btnRegistrarSucur.IconColor = System.Drawing.Color.Gainsboro
        Me.btnRegistrarSucur.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRegistrarSucur.IconSize = 40
        Me.btnRegistrarSucur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrarSucur.Location = New System.Drawing.Point(0, 320)
        Me.btnRegistrarSucur.Name = "btnRegistrarSucur"
        Me.btnRegistrarSucur.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnRegistrarSucur.Size = New System.Drawing.Size(220, 60)
        Me.btnRegistrarSucur.TabIndex = 4
        Me.btnRegistrarSucur.Text = "Sucursales"
        Me.btnRegistrarSucur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrarSucur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRegistrarSucur.UseVisualStyleBackColor = True
        '
        'btnCargaProduc
        '
        Me.btnCargaProduc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCargaProduc.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCargaProduc.FlatAppearance.BorderSize = 0
        Me.btnCargaProduc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargaProduc.Font = New System.Drawing.Font("Fira Code Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCargaProduc.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCargaProduc.IconChar = FontAwesome.Sharp.IconChar.AppleAlt
        Me.btnCargaProduc.IconColor = System.Drawing.Color.Gainsboro
        Me.btnCargaProduc.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCargaProduc.IconSize = 40
        Me.btnCargaProduc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargaProduc.Location = New System.Drawing.Point(0, 260)
        Me.btnCargaProduc.Name = "btnCargaProduc"
        Me.btnCargaProduc.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnCargaProduc.Size = New System.Drawing.Size(220, 60)
        Me.btnCargaProduc.TabIndex = 3
        Me.btnCargaProduc.Text = "Productos"
        Me.btnCargaProduc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargaProduc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCargaProduc.UseVisualStyleBackColor = True
        '
        'btnRegistrarClient
        '
        Me.btnRegistrarClient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrarClient.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRegistrarClient.FlatAppearance.BorderSize = 0
        Me.btnRegistrarClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarClient.Font = New System.Drawing.Font("Fira Code Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRegistrarClient.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnRegistrarClient.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.btnRegistrarClient.IconColor = System.Drawing.Color.Gainsboro
        Me.btnRegistrarClient.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRegistrarClient.IconSize = 40
        Me.btnRegistrarClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrarClient.Location = New System.Drawing.Point(0, 200)
        Me.btnRegistrarClient.Name = "btnRegistrarClient"
        Me.btnRegistrarClient.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnRegistrarClient.Size = New System.Drawing.Size(220, 60)
        Me.btnRegistrarClient.TabIndex = 2
        Me.btnRegistrarClient.Text = "Clientes"
        Me.btnRegistrarClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrarClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRegistrarClient.UseVisualStyleBackColor = True
        '
        'btnRegistrarEmpl
        '
        Me.btnRegistrarEmpl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrarEmpl.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRegistrarEmpl.FlatAppearance.BorderSize = 0
        Me.btnRegistrarEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarEmpl.Font = New System.Drawing.Font("Fira Code Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRegistrarEmpl.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnRegistrarEmpl.IconChar = FontAwesome.Sharp.IconChar.IdCardAlt
        Me.btnRegistrarEmpl.IconColor = System.Drawing.Color.Gainsboro
        Me.btnRegistrarEmpl.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRegistrarEmpl.IconSize = 40
        Me.btnRegistrarEmpl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrarEmpl.Location = New System.Drawing.Point(0, 140)
        Me.btnRegistrarEmpl.Name = "btnRegistrarEmpl"
        Me.btnRegistrarEmpl.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnRegistrarEmpl.Size = New System.Drawing.Size(220, 60)
        Me.btnRegistrarEmpl.TabIndex = 1
        Me.btnRegistrarEmpl.Text = "Empleados"
        Me.btnRegistrarEmpl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrarEmpl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRegistrarEmpl.UseVisualStyleBackColor = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 607)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLogoDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents IconButton7 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents imgLogoDashboard As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblFormTittle As Label
    Friend WithEvents IconHome As FontAwesome.Sharp.IconPictureBox

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnRegistrarSucur As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCargaProduc As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRegistrarClient As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRegistrarEmpl As FontAwesome.Sharp.IconButton
End Class
