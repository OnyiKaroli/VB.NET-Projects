<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblKS = New System.Windows.Forms.Label()
        Me.lblPOS = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.chkShow = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblLogin)
        Me.Panel1.Controls.Add(Me.lblPOS)
        Me.Panel1.Controls.Add(Me.lblKS)
        Me.Panel1.Location = New System.Drawing.Point(93, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(327, 425)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel2.Controls.Add(Me.chkShow)
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Controls.Add(Me.btnSignIn)
        Me.Panel2.Controls.Add(Me.lblPassword)
        Me.Panel2.Controls.Add(Me.txtPassword)
        Me.Panel2.Controls.Add(Me.lblUsername)
        Me.Panel2.Controls.Add(Me.txtUsername)
        Me.Panel2.Location = New System.Drawing.Point(420, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(327, 425)
        Me.Panel2.TabIndex = 1
        '
        'lblKS
        '
        Me.lblKS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblKS.AutoSize = True
        Me.lblKS.Font = New System.Drawing.Font("Segoe UI", 40.0!, System.Drawing.FontStyle.Bold)
        Me.lblKS.ForeColor = System.Drawing.Color.Silver
        Me.lblKS.Location = New System.Drawing.Point(49, 155)
        Me.lblKS.Name = "lblKS"
        Me.lblKS.Size = New System.Drawing.Size(95, 72)
        Me.lblKS.TabIndex = 0
        Me.lblKS.Text = "KS"
        '
        'lblPOS
        '
        Me.lblPOS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPOS.AutoSize = True
        Me.lblPOS.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.lblPOS.ForeColor = System.Drawing.Color.Silver
        Me.lblPOS.Location = New System.Drawing.Point(125, 165)
        Me.lblPOS.Name = "lblPOS"
        Me.lblPOS.Size = New System.Drawing.Size(152, 32)
        Me.lblPOS.TabIndex = 1
        Me.lblPOS.Text = "Point Of Sale"
        '
        'lblLogin
        '
        Me.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblLogin.ForeColor = System.Drawing.Color.Silver
        Me.lblLogin.Location = New System.Drawing.Point(125, 197)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(46, 20)
        Me.lblLogin.TabIndex = 2
        Me.lblLogin.Text = "Login"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(99, 101)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(196, 25)
        Me.txtUsername.TabIndex = 0
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Silver
        Me.lblUsername.Location = New System.Drawing.Point(17, 103)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(80, 20)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Silver
        Me.lblPassword.Location = New System.Drawing.Point(21, 157)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(76, 20)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(99, 155)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(196, 25)
        Me.txtPassword.TabIndex = 2
        '
        'btnSignIn
        '
        Me.btnSignIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignIn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignIn.ForeColor = System.Drawing.Color.Silver
        Me.btnSignIn.Location = New System.Drawing.Point(34, 229)
        Me.btnSignIn.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(252, 40)
        Me.btnSignIn.TabIndex = 4
        Me.btnSignIn.Text = "Sign In"
        Me.btnSignIn.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Silver
        Me.LinkLabel1.Location = New System.Drawing.Point(115, 364)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(81, 13)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Create Account"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        '
        'chkShow
        '
        Me.chkShow.AutoSize = True
        Me.chkShow.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShow.ForeColor = System.Drawing.Color.Silver
        Me.chkShow.Location = New System.Drawing.Point(99, 197)
        Me.chkShow.Name = "chkShow"
        Me.chkShow.Size = New System.Drawing.Size(107, 17)
        Me.chkShow.TabIndex = 6
        Me.chkShow.Text = "Show Password"
        Me.chkShow.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(843, 519)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblPOS As Label
    Friend WithEvents lblKS As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnSignIn As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents chkShow As CheckBox
End Class
