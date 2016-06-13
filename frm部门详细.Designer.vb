<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm部门详细
    Inherits InheritsMasterForm

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
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UcLabel9 = New UserControl.UCLabel(Me.components)
        Me.UcLabel8 = New UserControl.UCLabel(Me.components)
        Me.txt部门名称 = New UserControl.UCText(Me.components)
        Me.txt部门编号 = New UserControl.UCText(Me.components)
        CType(Me.txt部门名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt部门编号, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.TabIndex = 9
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 5
        '
        'btnF4删除
        '
        Me.btnF4删除.TabIndex = 8
        '
        'btnF2编辑
        '
        Me.btnF2编辑.TabIndex = 6
        '
        'btnF3保存
        '
        Me.btnF3保存.TabIndex = 7
        '
        'labModel
        '
        Me.labModel.TabIndex = 4
        Me.labModel.Text = "新增"
        '
        'UcLabel9
        '
        Appearance14.BackColor = System.Drawing.Color.SkyBlue
        Appearance14.BackColor2 = System.Drawing.Color.White
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance14.BorderColor = System.Drawing.Color.Black
        Appearance14.BorderColor2 = System.Drawing.Color.Black
        Appearance14.TextHAlignAsString = "Left"
        Appearance14.TextVAlignAsString = "Middle"
        Me.UcLabel9.Appearance = Appearance14
        Me.UcLabel9.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel9.Location = New System.Drawing.Point(12, 79)
        Me.UcLabel9.Name = "UcLabel9"
        Me.UcLabel9.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel9.TabIndex = 2
        Me.UcLabel9.Text = "*部门名称"
        '
        'UcLabel8
        '
        Appearance22.BackColor = System.Drawing.Color.SkyBlue
        Appearance22.BackColor2 = System.Drawing.Color.White
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance22.BorderColor = System.Drawing.Color.Black
        Appearance22.BorderColor2 = System.Drawing.Color.Black
        Appearance22.TextHAlignAsString = "Left"
        Appearance22.TextVAlignAsString = "Middle"
        Me.UcLabel8.Appearance = Appearance22
        Me.UcLabel8.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel8.Location = New System.Drawing.Point(12, 56)
        Me.UcLabel8.Name = "UcLabel8"
        Me.UcLabel8.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel8.TabIndex = 0
        Me.UcLabel8.Text = "*部门编号"
        '
        'txt部门名称
        '
        Me.txt部门名称.AutoSize = False
        Me.txt部门名称.Location = New System.Drawing.Point(112, 79)
        Me.txt部门名称.MaxLength = 20
        Me.txt部门名称.Name = "txt部门名称"
        Me.txt部门名称.Size = New System.Drawing.Size(106, 23)
        Me.txt部门名称.TabIndex = 3
        Me.txt部门名称.Z_AddZero = False
        Me.txt部门名称.Z_blnChanged = False
        Me.txt部门名称.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txt部门名称.Z_PKey = False
        '
        'txt部门编号
        '
        Me.txt部门编号.AutoSize = False
        Me.txt部门编号.Location = New System.Drawing.Point(112, 56)
        Me.txt部门编号.MaxLength = 20
        Me.txt部门编号.Name = "txt部门编号"
        Me.txt部门编号.Size = New System.Drawing.Size(106, 23)
        Me.txt部门编号.TabIndex = 1
        Me.txt部门编号.Z_AddZero = False
        Me.txt部门编号.Z_blnChanged = False
        Me.txt部门编号.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txt部门编号.Z_PKey = False
        '
        'frm部门详细
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.UcLabel9)
        Me.Controls.Add(Me.UcLabel8)
        Me.Controls.Add(Me.txt部门名称)
        Me.Controls.Add(Me.txt部门编号)
        Me.Name = "frm部门详细"
        Me.Text = "部门明细"
        Me.Controls.SetChildIndex(Me.btnF3保存, 0)
        Me.Controls.SetChildIndex(Me.btnF2编辑, 0)
        Me.Controls.SetChildIndex(Me.btnF4删除, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.txt部门编号, 0)
        Me.Controls.SetChildIndex(Me.txt部门名称, 0)
        Me.Controls.SetChildIndex(Me.UcLabel8, 0)
        Me.Controls.SetChildIndex(Me.UcLabel9, 0)
        Me.Controls.SetChildIndex(Me.labModel, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        CType(Me.txt部门名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt部门编号, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt部门编号 As UserControl.UCText
    Friend WithEvents txt部门名称 As UserControl.UCText
    Friend WithEvents UcLabel8 As UserControl.UCLabel
    Friend WithEvents UcLabel9 As UserControl.UCLabel
End Class
