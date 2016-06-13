<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm工程信息详细
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
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UcLabel9 = New UserControl.UCLabel(Me.components)
        Me.txt工程名 = New UserControl.UCText(Me.components)
        Me.lbl工程类别 = New UserControl.UCLabel(Me.components)
        Me.txt工程编号 = New UserControl.UCText(Me.components)
        Me.lbl工程编号 = New UserControl.UCLabel(Me.components)
        Me.cbo工程类别 = New UserControl.UCComboEditor(Me.components)
        CType(Me.txt工程名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt工程编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo工程类别, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.TabIndex = 5
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 1
        '
        'btnF4删除
        '
        Me.btnF4删除.TabIndex = 4
        '
        'btnF2编辑
        '
        Me.btnF2编辑.TabIndex = 2
        '
        'btnF3保存
        '
        Me.btnF3保存.TabIndex = 3
        '
        'labModel
        '
        Me.labModel.TabIndex = 0
        '
        'UcLabel9
        '
        Appearance2.BackColor = System.Drawing.Color.SkyBlue
        Appearance2.BackColor2 = System.Drawing.Color.White
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance2.BorderColor = System.Drawing.Color.Black
        Appearance2.BorderColor2 = System.Drawing.Color.Black
        Appearance2.TextHAlignAsString = "Left"
        Appearance2.TextVAlignAsString = "Middle"
        Me.UcLabel9.Appearance = Appearance2
        Me.UcLabel9.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel9.Location = New System.Drawing.Point(12, 74)
        Me.UcLabel9.Name = "UcLabel9"
        Me.UcLabel9.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel9.TabIndex = 8
        Me.UcLabel9.Text = "*工程名"
        '
        'txt工程名
        '
        Me.txt工程名.AutoSize = False
        Me.txt工程名.Location = New System.Drawing.Point(112, 74)
        Me.txt工程名.MaxLength = 20
        Me.txt工程名.Name = "txt工程名"
        Me.txt工程名.Size = New System.Drawing.Size(137, 23)
        Me.txt工程名.TabIndex = 9
        Me.txt工程名.Z_AddZero = False
        Me.txt工程名.Z_blnChanged = False
        Me.txt工程名.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txt工程名.Z_PKey = False
        '
        'lbl工程类别
        '
        Appearance96.BackColor = System.Drawing.Color.SkyBlue
        Appearance96.BackColor2 = System.Drawing.Color.White
        Appearance96.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance96.BorderColor = System.Drawing.Color.Black
        Appearance96.BorderColor2 = System.Drawing.Color.Black
        Appearance96.TextHAlignAsString = "Left"
        Appearance96.TextVAlignAsString = "Middle"
        Me.lbl工程类别.Appearance = Appearance96
        Me.lbl工程类别.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.lbl工程类别.Location = New System.Drawing.Point(12, 97)
        Me.lbl工程类别.Name = "lbl工程类别"
        Me.lbl工程类别.Size = New System.Drawing.Size(100, 23)
        Me.lbl工程类别.TabIndex = 10
        Me.lbl工程类别.Text = "工程类别"
        '
        'txt工程编号
        '
        Me.txt工程编号.AutoSize = False
        Me.txt工程编号.Location = New System.Drawing.Point(112, 51)
        Me.txt工程编号.MaxLength = 20
        Me.txt工程编号.Name = "txt工程编号"
        Me.txt工程编号.Size = New System.Drawing.Size(137, 23)
        Me.txt工程编号.TabIndex = 7
        Me.txt工程编号.Z_AddZero = False
        Me.txt工程编号.Z_blnChanged = False
        Me.txt工程编号.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txt工程编号.Z_PKey = False
        '
        'lbl工程编号
        '
        Appearance1.BackColor = System.Drawing.Color.SkyBlue
        Appearance1.BackColor2 = System.Drawing.Color.White
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance1.BorderColor = System.Drawing.Color.Black
        Appearance1.BorderColor2 = System.Drawing.Color.Black
        Appearance1.TextHAlignAsString = "Left"
        Appearance1.TextVAlignAsString = "Middle"
        Me.lbl工程编号.Appearance = Appearance1
        Me.lbl工程编号.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.lbl工程编号.Location = New System.Drawing.Point(12, 51)
        Me.lbl工程编号.Name = "lbl工程编号"
        Me.lbl工程编号.Size = New System.Drawing.Size(100, 23)
        Me.lbl工程编号.TabIndex = 6
        Me.lbl工程编号.Text = "*工程编号"
        '
        'cbo工程类别
        '
        Appearance4.TextVAlignAsString = "Middle"
        Me.cbo工程类别.Appearance = Appearance4
        Me.cbo工程类别.AutoSize = False
        Me.cbo工程类别.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cbo工程类别.Font = New System.Drawing.Font("MS Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo工程类别.Location = New System.Drawing.Point(112, 97)
        Me.cbo工程类别.Name = "cbo工程类别"
        Appearance5.ForeColor = System.Drawing.Color.Gray
        Me.cbo工程类别.NullTextAppearance = Appearance5
        Me.cbo工程类别.Size = New System.Drawing.Size(137, 22)
        Me.cbo工程类别.TabIndex = 11
        '
        'frm工程信息详细
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 691)
        Me.Controls.Add(Me.cbo工程类别)
        Me.Controls.Add(Me.lbl工程类别)
        Me.Controls.Add(Me.lbl工程编号)
        Me.Controls.Add(Me.txt工程编号)
        Me.Controls.Add(Me.UcLabel9)
        Me.Controls.Add(Me.txt工程名)
        Me.Name = "frm工程信息详细"
        Me.Text = "工程详细"
        Me.Controls.SetChildIndex(Me.txt工程名, 0)
        Me.Controls.SetChildIndex(Me.UcLabel9, 0)
        Me.Controls.SetChildIndex(Me.txt工程编号, 0)
        Me.Controls.SetChildIndex(Me.lbl工程编号, 0)
        Me.Controls.SetChildIndex(Me.lbl工程类别, 0)
        Me.Controls.SetChildIndex(Me.labModel, 0)
        Me.Controls.SetChildIndex(Me.btnF3保存, 0)
        Me.Controls.SetChildIndex(Me.btnF2编辑, 0)
        Me.Controls.SetChildIndex(Me.btnF4删除, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.cbo工程类别, 0)
        CType(Me.txt工程名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt工程编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo工程类别, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt工程名 As UserControl.UCText
    Friend WithEvents UcLabel9 As UserControl.UCLabel
    Friend WithEvents lbl工程类别 As UserControl.UCLabel
    Friend WithEvents txt工程编号 As UserControl.UCText
    Friend WithEvents lbl工程编号 As UserControl.UCLabel
    Friend WithEvents cbo工程类别 As UserControl.UCComboEditor
End Class
