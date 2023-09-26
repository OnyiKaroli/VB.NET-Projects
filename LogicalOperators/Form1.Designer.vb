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
        Me.lblExam = New System.Windows.Forms.Label()
        Me.txtExam = New System.Windows.Forms.TextBox()
        Me.btnGrade = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblExam
        '
        Me.lblExam.AutoSize = True
        Me.lblExam.Location = New System.Drawing.Point(272, 123)
        Me.lblExam.Name = "lblExam"
        Me.lblExam.Size = New System.Drawing.Size(64, 13)
        Me.lblExam.TabIndex = 0
        Me.lblExam.Text = "Exam Score"
        '
        'txtExam
        '
        Me.txtExam.Location = New System.Drawing.Point(423, 123)
        Me.txtExam.MaxLength = 3
        Me.txtExam.Name = "txtExam"
        Me.txtExam.Size = New System.Drawing.Size(100, 20)
        Me.txtExam.TabIndex = 1
        '
        'btnGrade
        '
        Me.btnGrade.Location = New System.Drawing.Point(376, 307)
        Me.btnGrade.Name = "btnGrade"
        Me.btnGrade.Size = New System.Drawing.Size(75, 23)
        Me.btnGrade.TabIndex = 2
        Me.btnGrade.Text = "Grade"
        Me.btnGrade.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnGrade)
        Me.Controls.Add(Me.txtExam)
        Me.Controls.Add(Me.lblExam)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblExam As Label
    Friend WithEvents txtExam As TextBox
    Friend WithEvents btnGrade As Button
End Class
