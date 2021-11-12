<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tools
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grp1 = New System.Windows.Forms.GroupBox()
        Me.lb2 = New System.Windows.Forms.Label()
        Me.lb1 = New System.Windows.Forms.Label()
        Me.btoa = New System.Windows.Forms.Button()
        Me.atob = New System.Windows.Forms.Button()
        Me.A = New System.Windows.Forms.TextBox()
        Me.msg = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grp1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp1
        '
        Me.grp1.Controls.Add(Me.lb2)
        Me.grp1.Controls.Add(Me.lb1)
        Me.grp1.Controls.Add(Me.btoa)
        Me.grp1.Controls.Add(Me.atob)
        Me.grp1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grp1.Location = New System.Drawing.Point(3, 3)
        Me.grp1.Name = "grp1"
        Me.grp1.Size = New System.Drawing.Size(656, 58)
        Me.grp1.TabIndex = 0
        Me.grp1.TabStop = False
        Me.grp1.Text = "Tools"
        '
        'lb2
        '
        Me.lb2.AutoSize = True
        Me.lb2.Location = New System.Drawing.Point(320, 28)
        Me.lb2.Name = "lb2"
        Me.lb2.Size = New System.Drawing.Size(196, 13)
        Me.lb2.TabIndex = 4
        Me.lb2.Text = "Kí tự sang nhị phân. VD :  a -> 0100101" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.lb2.Visible = False
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.Location = New System.Drawing.Point(252, 28)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(333, 13)
        Me.lb1.TabIndex = 3
        Me.lb1.Text = "Nếu chuyển sang kí tự còn mã nhị phân thì cứ tiếp tục nhấn chuyển."
        Me.lb1.Visible = False
        '
        'btoa
        '
        Me.btoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btoa.Location = New System.Drawing.Point(6, 18)
        Me.btoa.Name = "btoa"
        Me.btoa.Size = New System.Drawing.Size(74, 34)
        Me.btoa.TabIndex = 1
        Me.btoa.Text = "Chuyển sang mã nhị phân"
        Me.btoa.UseVisualStyleBackColor = True
        '
        'atob
        '
        Me.atob.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.atob.Location = New System.Drawing.Point(86, 19)
        Me.atob.Name = "atob"
        Me.atob.Size = New System.Drawing.Size(74, 34)
        Me.atob.TabIndex = 0
        Me.atob.Text = "Chuyển sang kí tự"
        Me.atob.UseVisualStyleBackColor = True
        '
        'A
        '
        Me.A.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.A.Location = New System.Drawing.Point(3, 67)
        Me.A.Multiline = True
        Me.A.Name = "A"
        Me.A.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.A.Size = New System.Drawing.Size(656, 331)
        Me.A.TabIndex = 1
        Me.A.Text = "Doraemon!"
        '
        'msg
        '
        Me.msg.AutoSize = True
        Me.msg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.msg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.msg.Location = New System.Drawing.Point(0, 385)
        Me.msg.Name = "msg"
        Me.msg.Size = New System.Drawing.Size(172, 15)
        Me.msg.TabIndex = 5
        Me.msg.Text = "Chỉ hỗ trợ chữ cái La Tinh và Kí tự"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(178, 385)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Thông tin: Tools by Nguyễn Trung Nhẫn - Email: trungnhan21.12@gmail.com"
        '
        'tools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.msg)
        Me.Controls.Add(Me.A)
        Me.Controls.Add(Me.grp1)
        Me.Name = "tools"
        Me.Size = New System.Drawing.Size(662, 401)
        Me.grp1.ResumeLayout(False)
        Me.grp1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grp1 As GroupBox
    Friend WithEvents btoa As Button
    Friend WithEvents atob As Button
    Friend WithEvents A As TextBox
    Friend WithEvents lb1 As Label
    Friend WithEvents lb2 As Label
    Friend WithEvents msg As Label
    Friend WithEvents Label1 As Label
End Class
