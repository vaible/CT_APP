<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPDA详细
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
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UcLabel13 = New UserControl.UCLabel(Me.components)
        Me.UcLabel9 = New UserControl.UCLabel(Me.components)
        Me.UcLabel8 = New UserControl.UCLabel(Me.components)
        Me.txtPDA编号 = New UserControl.UCText(Me.components)
        Me.txt备注 = New UserControl.UCText(Me.components)
        Me.txtPDA负责人 = New UserControl.UCText(Me.components)
        Me.UcLabel6 = New UserControl.UCLabel(Me.components)
        Me.txtPDAIP = New UserControl.UCText(Me.components)
        CType(Me.txtPDA编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt备注, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPDA负责人, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPDAIP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.TabIndex = 13
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 9
        '
        'btnF4删除
        '
        Me.btnF4删除.TabIndex = 12
        '
        'btnF2编辑
        '
        Me.btnF2编辑.TabIndex = 10
        '
        'btnF3保存
        '
        Me.btnF3保存.TabIndex = 11
        '
        'labModel
        '
        Me.labModel.TabIndex = 8
        Me.labModel.Text = "新增"
        '
        'UcLabel13
        '
        Appearance28.BackColor = System.Drawing.Color.SkyBlue
        Appearance28.BackColor2 = System.Drawing.Color.White
        Appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance28.BorderColor = System.Drawing.Color.Black
        Appearance28.BorderColor2 = System.Drawing.Color.Black
        Appearance28.TextHAlignAsString = "Left"
        Appearance28.TextVAlignAsString = "Middle"
        Me.UcLabel13.Appearance = Appearance28
        Me.UcLabel13.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel13.Location = New System.Drawing.Point(12, 79)
        Me.UcLabel13.Name = "UcLabel13"
        Me.UcLabel13.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel13.TabIndex = 2
        Me.UcLabel13.Text = "*PDA IP"
        '
        'UcLabel9
        '
        Appearance21.BackColor = System.Drawing.Color.SkyBlue
        Appearance21.BackColor2 = System.Drawing.Color.White
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance21.BorderColor = System.Drawing.Color.Black
        Appearance21.BorderColor2 = System.Drawing.Color.Black
        Appearance21.TextHAlignAsString = "Left"
        Appearance21.TextVAlignAsString = "Middle"
        Me.UcLabel9.Appearance = Appearance21
        Me.UcLabel9.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel9.Location = New System.Drawing.Point(12, 56)
        Me.UcLabel9.Name = "UcLabel9"
        Me.UcLabel9.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel9.TabIndex = 0
        Me.UcLabel9.Text = "*PDA编号"
        '
        'UcLabel8
        '
        Appearance15.BackColor = System.Drawing.Color.SkyBlue
        Appearance15.BackColor2 = System.Drawing.Color.White
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance15.BorderColor = System.Drawing.Color.Black
        Appearance15.BorderColor2 = System.Drawing.Color.Black
        Appearance15.TextHAlignAsString = "Left"
        Appearance15.TextVAlignAsString = "Middle"
        Me.UcLabel8.Appearance = Appearance15
        Me.UcLabel8.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel8.Location = New System.Drawing.Point(12, 125)
        Me.UcLabel8.Name = "UcLabel8"
        Me.UcLabel8.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel8.TabIndex = 6
        Me.UcLabel8.Text = "备注"
        '
        'txtPDA编号
        '
        Me.txtPDA编号.AutoSize = False
        Me.txtPDA编号.Location = New System.Drawing.Point(112, 56)
        Me.txtPDA编号.MaxLength = 20
        Me.txtPDA编号.Name = "txtPDA编号"
        Me.txtPDA编号.Size = New System.Drawing.Size(106, 23)
        Me.txtPDA编号.TabIndex = 1
        Me.txtPDA编号.Z_AddZero = False
        Me.txtPDA编号.Z_blnChanged = False
        Me.txtPDA编号.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txtPDA编号.Z_PKey = False
        '
        'txt备注
        '
        Me.txt备注.AutoSize = False
        Me.txt备注.Location = New System.Drawing.Point(112, 125)
        Me.txt备注.MaxLength = 20
        Me.txt备注.Name = "txt备注"
        Me.txt备注.Size = New System.Drawing.Size(106, 23)
        Me.txt备注.TabIndex = 7
        Me.txt备注.Z_AddZero = False
        Me.txt备注.Z_blnChanged = False
        Me.txt备注.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txt备注.Z_PKey = False
        '
        'txtPDA负责人
        '
        Me.txtPDA负责人.AutoSize = False
        Me.txtPDA负责人.Location = New System.Drawing.Point(112, 102)
        Me.txtPDA负责人.MaxLength = 20
        Me.txtPDA负责人.Name = "txtPDA负责人"
        Me.txtPDA负责人.Size = New System.Drawing.Size(106, 23)
        Me.txtPDA负责人.TabIndex = 5
        Me.txtPDA负责人.Z_AddZero = False
        Me.txtPDA负责人.Z_blnChanged = False
        Me.txtPDA负责人.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txtPDA负责人.Z_PKey = False
        '
        'UcLabel6
        '
        Appearance25.BackColor = System.Drawing.Color.SkyBlue
        Appearance25.BackColor2 = System.Drawing.Color.White
        Appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance25.BorderColor = System.Drawing.Color.Black
        Appearance25.BorderColor2 = System.Drawing.Color.Black
        Appearance25.TextHAlignAsString = "Left"
        Appearance25.TextVAlignAsString = "Middle"
        Me.UcLabel6.Appearance = Appearance25
        Me.UcLabel6.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel6.Location = New System.Drawing.Point(12, 102)
        Me.UcLabel6.Name = "UcLabel6"
        Me.UcLabel6.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel6.TabIndex = 4
        Me.UcLabel6.Text = "*PDA负责人"
        '
        'txtPDAIP
        '
        Me.txtPDAIP.AutoSize = False
        Me.txtPDAIP.Location = New System.Drawing.Point(112, 79)
        Me.txtPDAIP.MaxLength = 20
        Me.txtPDAIP.Name = "txtPDAIP"
        Me.txtPDAIP.Size = New System.Drawing.Size(106, 23)
        Me.txtPDAIP.TabIndex = 3
        Me.txtPDAIP.Z_AddZero = False
        Me.txtPDAIP.Z_blnChanged = False
        Me.txtPDAIP.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txtPDAIP.Z_PKey = False
        '
        'frmPDA详细
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.txtPDAIP)
        Me.Controls.Add(Me.UcLabel13)
        Me.Controls.Add(Me.UcLabel6)
        Me.Controls.Add(Me.UcLabel9)
        Me.Controls.Add(Me.UcLabel8)
        Me.Controls.Add(Me.txtPDA负责人)
        Me.Controls.Add(Me.txtPDA编号)
        Me.Controls.Add(Me.txt备注)
        Me.Name = "frmPDA详细"
        Me.Text = "PDA明细"
        Me.Controls.SetChildIndex(Me.btnF3保存, 0)
        Me.Controls.SetChildIndex(Me.btnF2编辑, 0)
        Me.Controls.SetChildIndex(Me.btnF4删除, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.txt备注, 0)
        Me.Controls.SetChildIndex(Me.txtPDA编号, 0)
        Me.Controls.SetChildIndex(Me.txtPDA负责人, 0)
        Me.Controls.SetChildIndex(Me.UcLabel8, 0)
        Me.Controls.SetChildIndex(Me.UcLabel9, 0)
        Me.Controls.SetChildIndex(Me.UcLabel6, 0)
        Me.Controls.SetChildIndex(Me.UcLabel13, 0)
        Me.Controls.SetChildIndex(Me.labModel, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.txtPDAIP, 0)
        CType(Me.txtPDA编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt备注, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPDA负责人, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPDAIP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt备注 As UserControl.UCText
    Friend WithEvents txtPDA编号 As UserControl.UCText
    Friend WithEvents UcLabel8 As UserControl.UCLabel
    Friend WithEvents UcLabel9 As UserControl.UCLabel
    Friend WithEvents UcLabel13 As UserControl.UCLabel
    Friend WithEvents txtPDA负责人 As UserControl.UCText
    Friend WithEvents UcLabel6 As UserControl.UCLabel
    Friend WithEvents txtPDAIP As UserControl.UCText
End Class
