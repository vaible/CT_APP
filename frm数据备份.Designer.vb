<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm数据备份
    Inherits InheritsSearchForm

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraGroupBox1 = New UserControl.UCGroupBox(Me.components)
        Me.txt上次备份日期 = New UserControl.UCText(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.txt备份路径 = New UserControl.UCText(Me.components)
        Me.UcLabel12 = New UserControl.UCLabel(Me.components)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txt上次备份日期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt备份路径, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.Location = New System.Drawing.Point(357, 12)
        Me.btnF12关闭.TabIndex = 4
        Me.btnF12关闭.Text = "F12：关闭"
        '
        'btnF2查询
        '
        Me.btnF2查询.TabIndex = 2
        Me.btnF2查询.Visible = False
        '
        'btnF3选择
        '
        Me.btnF3选择.Location = New System.Drawing.Point(178, 12)
        Me.btnF3选择.TabIndex = 3
        Me.btnF3选择.Text = "F3:备份"
        Me.btnF3选择.Visible = False
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 1
        Me.btnF1清空.Text = "F1:备份"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.txt上次备份日期)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.txt备份路径)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel12)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(429, 136)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.Text = "备份条件"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'txt上次备份日期
        '
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txt上次备份日期.Appearance = Appearance2
        Me.txt上次备份日期.AutoSize = False
        Me.txt上次备份日期.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txt上次备份日期.Location = New System.Drawing.Point(115, 33)
        Me.txt上次备份日期.Name = "txt上次备份日期"
        Me.txt上次备份日期.ReadOnly = True
        Me.txt上次备份日期.Size = New System.Drawing.Size(131, 23)
        Me.txt上次备份日期.TabIndex = 1
        Me.txt上次备份日期.TabStop = False
        Me.txt上次备份日期.Z_AddZero = False
        Me.txt上次备份日期.Z_blnChanged = False
        Me.txt上次备份日期.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txt上次备份日期.Z_PKey = False
        '
        'UcLabel1
        '
        Appearance15.BackColor = System.Drawing.Color.SkyBlue
        Appearance15.BackColor2 = System.Drawing.Color.White
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance15.BorderColor = System.Drawing.Color.Black
        Appearance15.BorderColor2 = System.Drawing.Color.Black
        Appearance15.TextHAlignAsString = "Left"
        Appearance15.TextVAlignAsString = "Middle"
        Me.UcLabel1.Appearance = Appearance15
        Me.UcLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel1.Location = New System.Drawing.Point(15, 33)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 0
        Me.UcLabel1.Text = "上次备份日期"
        '
        'txt备份路径
        '
        Me.txt备份路径.AutoSize = False
        Me.txt备份路径.ButtonsRight.Add(EditorButton1)
        Me.txt备份路径.Location = New System.Drawing.Point(115, 62)
        Me.txt备份路径.MaxLength = 200
        Me.txt备份路径.Name = "txt备份路径"
        Me.txt备份路径.Size = New System.Drawing.Size(289, 23)
        Me.txt备份路径.TabIndex = 3
        Me.txt备份路径.Z_AddZero = False
        Me.txt备份路径.Z_blnChanged = False
        Me.txt备份路径.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txt备份路径.Z_PKey = False
        '
        'UcLabel12
        '
        Appearance1.BackColor = System.Drawing.Color.SkyBlue
        Appearance1.BackColor2 = System.Drawing.Color.White
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance1.BorderColor = System.Drawing.Color.Black
        Appearance1.BorderColor2 = System.Drawing.Color.Black
        Appearance1.TextHAlignAsString = "Left"
        Appearance1.TextVAlignAsString = "Middle"
        Me.UcLabel12.Appearance = Appearance1
        Me.UcLabel12.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel12.Location = New System.Drawing.Point(15, 62)
        Me.UcLabel12.Name = "UcLabel12"
        Me.UcLabel12.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel12.TabIndex = 2
        Me.UcLabel12.Text = "数据备份路径"
        '
        'frm数据备份
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 201)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Name = "frm数据备份"
        Me.Text = "数据备份"
        Me.Controls.SetChildIndex(Me.btnF2查询, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF3选择, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.UltraGroupBox1, 0)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.txt上次备份日期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt备份路径, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraGroupBox1 As UserControl.UCGroupBox
    Friend WithEvents txt备份路径 As UserControl.UCText
    Friend WithEvents UcLabel12 As UserControl.UCLabel
    Friend WithEvents txt上次备份日期 As UserControl.UCText
    Friend WithEvents UcLabel1 As UserControl.UCLabel
End Class
