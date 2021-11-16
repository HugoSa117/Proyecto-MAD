Imports FontAwesome.Sharp

Public Class Dashboard

    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)
    End Sub

    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'boton
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'borde izquierdo
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'Iconoc de Home
            IconHome.IconChar = currentBtn.IconChar
            IconHome.IconColor = customColor
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText

        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        'Abrir solo forms
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'fin
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

        lblFormTittle.Text = currentBtn.Text





    End Sub


    'Eventos (Para clickear los botones del menu izquierdo)

    Private Sub btnRegistrarEmpl_Click(sender As Object, e As EventArgs) Handles btnRegistrarEmpl.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New Form_R_Empleados)
    End Sub

    Private Sub btnRegistrarClient_Click(sender As Object, e As EventArgs) Handles btnRegistrarClient.Click
        ActivateButton(sender, RGBColors.color2)
        OpenChildForm(New Form_R_Clientes)

    End Sub

    Private Sub btnCargaProduc_Click(sender As Object, e As EventArgs) Handles btnCargaProduc.Click
        ActivateButton(sender, RGBColors.color3)
        OpenChildForm(New Form_R_Producto)

    End Sub

    Private Sub btnRegistrarSucur_Click(sender As Object, e As EventArgs) Handles btnRegistrarSucur.Click
        ActivateButton(sender, RGBColors.color4)
        OpenChildForm(New Form_R_Sucursal)

    End Sub

    Private Sub PanelDesktop_Paint(sender As Object, e As PaintEventArgs) Handles PanelDesktop.Paint

    End Sub

    Private Sub PanelLogo_Paint(sender As Object, e As PaintEventArgs) Handles PanelLogo.Paint

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub
End Class