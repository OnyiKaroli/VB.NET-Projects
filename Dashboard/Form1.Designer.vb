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
        Me.pnlPanelMenu = New System.Windows.Forms.Panel()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.pnlTitleBar = New System.Windows.Forms.Panel()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.pnlDesktop = New System.Windows.Forms.Panel()
        Me.icoCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.btnSettings = New FontAwesome.Sharp.IconButton()
        Me.btnMarketing = New FontAwesome.Sharp.IconButton()
        Me.btnCustomers = New FontAwesome.Sharp.IconButton()
        Me.btnProducts = New FontAwesome.Sharp.IconButton()
        Me.btnOrders = New FontAwesome.Sharp.IconButton()
        Me.btnDashboard = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IconMenuItem1 = New FontAwesome.Sharp.IconMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlPanelMenu.SuspendLayout()
        Me.pnlLogo.SuspendLayout()
        Me.pnlTitleBar.SuspendLayout()
        Me.pnlDesktop.SuspendLayout()
        CType(Me.icoCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlPanelMenu
        '
        Me.pnlPanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnlPanelMenu.Controls.Add(Me.btnSettings)
        Me.pnlPanelMenu.Controls.Add(Me.btnMarketing)
        Me.pnlPanelMenu.Controls.Add(Me.btnCustomers)
        Me.pnlPanelMenu.Controls.Add(Me.btnProducts)
        Me.pnlPanelMenu.Controls.Add(Me.btnOrders)
        Me.pnlPanelMenu.Controls.Add(Me.btnDashboard)
        Me.pnlPanelMenu.Controls.Add(Me.pnlLogo)
        Me.pnlPanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlPanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlPanelMenu.Name = "pnlPanelMenu"
        Me.pnlPanelMenu.Size = New System.Drawing.Size(220, 516)
        Me.pnlPanelMenu.TabIndex = 0
        '
        'pnlLogo
        '
        Me.pnlLogo.Controls.Add(Me.PictureBox1)
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(220, 140)
        Me.pnlLogo.TabIndex = 0
        '
        'pnlTitleBar
        '
        Me.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.pnlTitleBar.Controls.Add(Me.btnMax)
        Me.pnlTitleBar.Controls.Add(Me.btnMin)
        Me.pnlTitleBar.Controls.Add(Me.btnClose)
        Me.pnlTitleBar.Controls.Add(Me.lblHome)
        Me.pnlTitleBar.Controls.Add(Me.icoCurrentForm)
        Me.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitleBar.Location = New System.Drawing.Point(220, 0)
        Me.pnlTitleBar.Name = "pnlTitleBar"
        Me.pnlTitleBar.Size = New System.Drawing.Size(630, 75)
        Me.pnlTitleBar.TabIndex = 1
        '
        'lblHome
        '
        Me.lblHome.AutoSize = True
        Me.lblHome.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblHome.Location = New System.Drawing.Point(50, 29)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(35, 13)
        Me.lblHome.TabIndex = 1
        Me.lblHome.Text = "Home"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnClose.ForeColor = System.Drawing.Color.MediumPurple
        Me.btnClose.Location = New System.Drawing.Point(610, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(20, 20)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnMin
        '
        Me.btnMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnMin.ForeColor = System.Drawing.Color.MediumPurple
        Me.btnMin.Location = New System.Drawing.Point(570, 0)
        Me.btnMin.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(20, 20)
        Me.btnMin.TabIndex = 3
        Me.btnMin.Text = "X"
        Me.btnMin.UseVisualStyleBackColor = False
        '
        'btnMax
        '
        Me.btnMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMax.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnMax.ForeColor = System.Drawing.Color.MediumPurple
        Me.btnMax.Location = New System.Drawing.Point(590, 0)
        Me.btnMax.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(20, 20)
        Me.btnMax.TabIndex = 4
        Me.btnMax.Text = "X"
        Me.btnMax.UseVisualStyleBackColor = False
        '
        'pnlDesktop
        '
        Me.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.pnlDesktop.Controls.Add(Me.DateTimePicker1)
        Me.pnlDesktop.Controls.Add(Me.PictureBox2)
        Me.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDesktop.Location = New System.Drawing.Point(220, 75)
        Me.pnlDesktop.Name = "pnlDesktop"
        Me.pnlDesktop.Size = New System.Drawing.Size(630, 441)
        Me.pnlDesktop.TabIndex = 2
        '
        'icoCurrentForm
        '
        Me.icoCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.icoCurrentForm.ForeColor = System.Drawing.Color.MediumPurple
        Me.icoCurrentForm.IconChar = FontAwesome.Sharp.IconChar.HomeUser
        Me.icoCurrentForm.IconColor = System.Drawing.Color.MediumPurple
        Me.icoCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.icoCurrentForm.Location = New System.Drawing.Point(12, 20)
        Me.icoCurrentForm.Name = "icoCurrentForm"
        Me.icoCurrentForm.Size = New System.Drawing.Size(32, 32)
        Me.icoCurrentForm.TabIndex = 0
        Me.icoCurrentForm.TabStop = False
        '
        'btnSettings
        '
        Me.btnSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Tools
        Me.btnSettings.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnSettings.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSettings.IconSize = 32
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.Location = New System.Drawing.Point(0, 440)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnSettings.Size = New System.Drawing.Size(220, 60)
        Me.btnSettings.TabIndex = 6
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnMarketing
        '
        Me.btnMarketing.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMarketing.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnMarketing.FlatAppearance.BorderSize = 0
        Me.btnMarketing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMarketing.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnMarketing.IconChar = FontAwesome.Sharp.IconChar.MailBulk
        Me.btnMarketing.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnMarketing.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMarketing.IconSize = 32
        Me.btnMarketing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMarketing.Location = New System.Drawing.Point(0, 380)
        Me.btnMarketing.Name = "btnMarketing"
        Me.btnMarketing.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnMarketing.Size = New System.Drawing.Size(220, 60)
        Me.btnMarketing.TabIndex = 5
        Me.btnMarketing.Text = "Marketing"
        Me.btnMarketing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMarketing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMarketing.UseVisualStyleBackColor = True
        '
        'btnCustomers
        '
        Me.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCustomers.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnCustomers.FlatAppearance.BorderSize = 0
        Me.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomers.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCustomers.IconChar = FontAwesome.Sharp.IconChar.User
        Me.btnCustomers.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnCustomers.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCustomers.IconSize = 32
        Me.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.Location = New System.Drawing.Point(0, 320)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnCustomers.Size = New System.Drawing.Size(220, 60)
        Me.btnCustomers.TabIndex = 4
        Me.btnCustomers.Text = "Customers"
        Me.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'btnProducts
        '
        Me.btnProducts.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProducts.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnProducts.FlatAppearance.BorderSize = 0
        Me.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProducts.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnProducts.IconChar = FontAwesome.Sharp.IconChar.Tag
        Me.btnProducts.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnProducts.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnProducts.IconSize = 32
        Me.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducts.Location = New System.Drawing.Point(0, 260)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnProducts.Size = New System.Drawing.Size(220, 60)
        Me.btnProducts.TabIndex = 3
        Me.btnProducts.Text = "Products"
        Me.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'btnOrders
        '
        Me.btnOrders.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOrders.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnOrders.FlatAppearance.BorderSize = 0
        Me.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrders.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnOrders.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.btnOrders.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnOrders.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnOrders.IconSize = 32
        Me.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrders.Location = New System.Drawing.Point(0, 200)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnOrders.Size = New System.Drawing.Size(220, 60)
        Me.btnOrders.TabIndex = 2
        Me.btnOrders.Text = "Orders"
        Me.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOrders.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.LineChart
        Me.btnDashboard.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDashboard.IconSize = 32
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 140)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(220, 60)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Dashboard.My.Resources.Resources.logos
        Me.PictureBox1.Location = New System.Drawing.Point(43, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'IconMenuItem1
        '
        Me.IconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconMenuItem1.IconColor = System.Drawing.Color.Black
        Me.IconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconMenuItem1.Name = "IconMenuItem1"
        Me.IconMenuItem1.Size = New System.Drawing.Size(32, 19)
        Me.IconMenuItem1.Text = "IconMenuItem1"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = Global.Dashboard.My.Resources.Resources.logo_black
        Me.PictureBox2.Location = New System.Drawing.Point(53, 65)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(203, 180)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateTimePicker1.Location = New System.Drawing.Point(262, 65)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(208, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 516)
        Me.Controls.Add(Me.pnlDesktop)
        Me.Controls.Add(Me.pnlTitleBar)
        Me.Controls.Add(Me.pnlPanelMenu)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.pnlPanelMenu.ResumeLayout(False)
        Me.pnlLogo.ResumeLayout(False)
        Me.pnlTitleBar.ResumeLayout(False)
        Me.pnlTitleBar.PerformLayout()
        Me.pnlDesktop.ResumeLayout(False)
        CType(Me.icoCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPanelMenu As Panel
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSettings As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMarketing As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCustomers As FontAwesome.Sharp.IconButton
    Friend WithEvents btnProducts As FontAwesome.Sharp.IconButton
    Friend WithEvents btnOrders As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlTitleBar As Panel
    Friend WithEvents icoCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblHome As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents IconMenuItem1 As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents btnMax As Button
    Friend WithEvents btnMin As Button
    Friend WithEvents pnlDesktop As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Timer1 As Timer
End Class
