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
        Me.btnReportes = New FontAwesome.Sharp.IconButton()
        Me.btnCompras = New FontAwesome.Sharp.IconButton()
        Me.btnRegistrarSucur = New FontAwesome.Sharp.IconButton()
        Me.btnCargaProduc = New FontAwesome.Sharp.IconButton()
        Me.btnRegistrarClient = New FontAwesome.Sharp.IconButton()
        Me.btnRegistrarEmpl = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.IconHome = New FontAwesome.Sharp.IconPictureBox()
        Me.lblFormTittle = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLogo.SuspendLayout()
        CType(Me.IconHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.AutoScroll = True
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnSalir)
        Me.PanelMenu.Controls.Add(Me.btnReportes)
        Me.PanelMenu.Controls.Add(Me.btnCompras)
        Me.PanelMenu.Controls.Add(Me.btnRegistrarSucur)
        Me.PanelMenu.Controls.Add(Me.btnCargaProduc)
        Me.PanelMenu.Controls.Add(Me.btnRegistrarClient)
        Me.PanelMenu.Controls.Add(Me.btnRegistrarEmpl)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 621)
        Me.PanelMenu.TabIndex = 0
        '
        'btnReportes
        '
        Me.btnReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReportes.FlatAppearance.BorderSize = 0
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportes.Font = New System.Drawing.Font("Fira Code Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnReportes.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnReportes.IconChar = FontAwesome.Sharp.IconChar.FilePdf
        Me.btnReportes.IconColor = System.Drawing.Color.Gainsboro
        Me.btnReportes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReportes.IconSize = 32
        Me.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.Location = New System.Drawing.Point(0, 440)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnReportes.Size = New System.Drawing.Size(220, 60)
        Me.btnReportes.TabIndex = 6
        Me.btnReportes.Text = "Reportes"
        Me.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReportes.UseVisualStyleBackColor = True
        '
        'btnCompras
        '
        Me.btnCompras.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCompras.FlatAppearance.BorderSize = 0
        Me.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompras.Font = New System.Drawing.Font("Fira Code Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCompras.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCompras.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.btnCompras.IconColor = System.Drawing.Color.Gainsboro
        Me.btnCompras.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCompras.IconSize = 32
        Me.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompras.Location = New System.Drawing.Point(0, 380)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnCompras.Size = New System.Drawing.Size(220, 60)
        Me.btnCompras.TabIndex = 5
        Me.btnCompras.Text = "Compras"
        Me.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCompras.UseVisualStyleBackColor = True
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
        Me.btnRegistrarSucur.IconSize = 32
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
        Me.btnCargaProduc.IconSize = 32
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
        Me.btnRegistrarClient.IconSize = 32
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
        Me.btnRegistrarEmpl.IconSize = 32
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto_MAD.My.Resources.Resources.d64b8b1f5cd643049149ad4ccd12751e
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(217, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Fira Code Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSalir.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.btnSalir.IconColor = System.Drawing.Color.Gainsboro
        Me.btnSalir.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSalir.IconSize = 32
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(0, 561)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Padding = New System.Windows.Forms.Padding(10, 0, 20, 15)
        Me.btnSalir.Size = New System.Drawing.Size(220, 60)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(220, 140)
        Me.PanelLogo.TabIndex = 0
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(220, 75)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(968, 546)
        Me.PanelDesktop.TabIndex = 2
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
        Me.IconHome.Size = New System.Drawing.Size(32, 32)
        Me.IconHome.TabIndex = 0
        Me.IconHome.TabStop = False
        '
        'lblFormTittle
        '
        Me.lblFormTittle.AutoSize = True
        Me.lblFormTittle.Font = New System.Drawing.Font("Fira Code Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFormTittle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFormTittle.Location = New System.Drawing.Point(57, 28)
        Me.lblFormTittle.Name = "lblFormTittle"
        Me.lblFormTittle.Size = New System.Drawing.Size(69, 19)
        Me.lblFormTittle.TabIndex = 1
        Me.lblFormTittle.Text = "Inicio"
        '
        'IconButton1
        '
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Fira Code SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 24
        Me.IconButton1.Location = New System.Drawing.Point(934, 0)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(34, 31)
        Me.IconButton1.TabIndex = 8
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'IconButton2
        '
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Font = New System.Drawing.Font("Fira Code SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Minus
        Me.IconButton2.IconColor = System.Drawing.Color.White
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 24
        Me.IconButton2.Location = New System.Drawing.Point(861, 0)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(34, 31)
        Me.IconButton2.TabIndex = 9
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'IconButton3
        '
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Font = New System.Drawing.Font("Fira Code SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.Square
        Me.IconButton3.IconColor = System.Drawing.Color.White
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 24
        Me.IconButton3.Location = New System.Drawing.Point(898, 0)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(34, 31)
        Me.IconButton3.TabIndex = 10
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel1.Controls.Add(Me.IconButton3)
        Me.Panel1.Controls.Add(Me.IconButton2)
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.lblFormTittle)
        Me.Panel1.Controls.Add(Me.IconHome)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(220, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(968, 75)
        Me.Panel1.TabIndex = 1
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 621)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.IconHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnReportes As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCompras As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRegistrarSucur As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCargaProduc As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRegistrarClient As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRegistrarEmpl As FontAwesome.Sharp.IconButton

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSalir As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents IconHome As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblFormTittle As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
End Class
