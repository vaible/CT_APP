<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm设备详细
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
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UcLabel13 = New UserControl.UCLabel(Me.components)
        Me.UcLabel9 = New UserControl.UCLabel(Me.components)
        Me.txt维护周期 = New UserControl.UCText(Me.components)
        Me.txt设备编号 = New UserControl.UCText(Me.components)
        Me.UcLabel5 = New UserControl.UCLabel(Me.components)
        Me.UcLabel7 = New UserControl.UCLabel(Me.components)
        Me.UcLabel10 = New UserControl.UCLabel(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.UcLabel17 = New UserControl.UCLabel(Me.components)
        Me.txt设备名称 = New UserControl.UCText(Me.components)
        Me.txt设备型号 = New UserControl.UCText(Me.components)
        Me.txt维护厂商 = New UserControl.UCText(Me.components)
        Me.UcLabel2 = New UserControl.UCLabel(Me.components)
        Me.txt维护负责人 = New UserControl.UCText(Me.components)
        Me.UcLabel3 = New UserControl.UCLabel(Me.components)
        Me.txt负责人电话 = New UserControl.UCText(Me.components)
        Me.UcLabel4 = New UserControl.UCLabel(Me.components)
        Me.cbo使用状态 = New UserControl.UCComboEditor(Me.components)
        Me.dtm上次维护日期 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.num设备产量 = New UserControl.UCNumericEditor(Me.components)
        CType(Me.txt维护周期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt设备编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt设备名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt设备型号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt维护厂商, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt维护负责人, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt负责人电话, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo使用状态, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtm上次维护日期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num设备产量, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.TabIndex = 25
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 21
        '
        'btnF4删除
        '
        Me.btnF4删除.TabIndex = 24
        '
        'btnF2编辑
        '
        Me.btnF2编辑.TabIndex = 22
        '
        'btnF3保存
        '
        Me.btnF3保存.TabIndex = 23
        '
        'labModel
        '
        Me.labModel.TabIndex = 20
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
        Me.UcLabel13.Location = New System.Drawing.Point(12, 100)
        Me.UcLabel13.Name = "UcLabel13"
        Me.UcLabel13.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel13.TabIndex = 4
        Me.UcLabel13.Text = "*设备型号"
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
        Me.UcLabel9.Location = New System.Drawing.Point(12, 54)
        Me.UcLabel9.Name = "UcLabel9"
        Me.UcLabel9.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel9.TabIndex = 0
        Me.UcLabel9.Text = "*设备编号"
        '
        'txt维护周期
        '
        Me.txt维护周期.AutoSize = False
        Me.txt维护周期.Location = New System.Drawing.Point(112, 123)
        Me.txt维护周期.MaxLength = 20
        Me.txt维护周期.Name = "txt维护周期"
        Me.txt维护周期.Size = New System.Drawing.Size(130, 23)
        Me.txt维护周期.TabIndex = 7
        Me.txt维护周期.Z_AddZero = False
        Me.txt维护周期.Z_blnChanged = False
        Me.txt维护周期.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txt维护周期.Z_PKey = False
        '
        'txt设备编号
        '
        Me.txt设备编号.AutoSize = False
        Me.txt设备编号.Location = New System.Drawing.Point(112, 54)
        Me.txt设备编号.MaxLength = 20
        Me.txt设备编号.Name = "txt设备编号"
        Me.txt设备编号.Size = New System.Drawing.Size(130, 23)
        Me.txt设备编号.TabIndex = 1
        Me.txt设备编号.Z_AddZero = False
        Me.txt设备编号.Z_blnChanged = False
        Me.txt设备编号.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txt设备编号.Z_PKey = False
        '
        'UcLabel5
        '
        Appearance17.BackColor = System.Drawing.Color.SkyBlue
        Appearance17.BackColor2 = System.Drawing.Color.White
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance17.BorderColor = System.Drawing.Color.Black
        Appearance17.BorderColor2 = System.Drawing.Color.Black
        Appearance17.TextHAlignAsString = "Left"
        Appearance17.TextVAlignAsString = "Middle"
        Me.UcLabel5.Appearance = Appearance17
        Me.UcLabel5.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel5.Location = New System.Drawing.Point(12, 169)
        Me.UcLabel5.Name = "UcLabel5"
        Me.UcLabel5.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel5.TabIndex = 10
        Me.UcLabel5.Text = "使用状态"
        '
        'UcLabel7
        '
        Appearance13.BackColor = System.Drawing.Color.SkyBlue
        Appearance13.BackColor2 = System.Drawing.Color.White
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance13.BorderColor = System.Drawing.Color.Black
        Appearance13.BorderColor2 = System.Drawing.Color.Black
        Appearance13.TextHAlignAsString = "Left"
        Appearance13.TextVAlignAsString = "Middle"
        Me.UcLabel7.Appearance = Appearance13
        Me.UcLabel7.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel7.Location = New System.Drawing.Point(12, 146)
        Me.UcLabel7.Name = "UcLabel7"
        Me.UcLabel7.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel7.TabIndex = 8
        Me.UcLabel7.Text = "上次维护日期"
        '
        'UcLabel10
        '
        Appearance19.BackColor = System.Drawing.Color.SkyBlue
        Appearance19.BackColor2 = System.Drawing.Color.White
        Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance19.BorderColor = System.Drawing.Color.Black
        Appearance19.BorderColor2 = System.Drawing.Color.Black
        Appearance19.TextHAlignAsString = "Left"
        Appearance19.TextVAlignAsString = "Middle"
        Me.UcLabel10.Appearance = Appearance19
        Me.UcLabel10.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel10.Location = New System.Drawing.Point(12, 123)
        Me.UcLabel10.Name = "UcLabel10"
        Me.UcLabel10.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel10.TabIndex = 6
        Me.UcLabel10.Text = "维护周期"
        '
        'UcLabel1
        '
        Appearance16.BackColor = System.Drawing.Color.SkyBlue
        Appearance16.BackColor2 = System.Drawing.Color.White
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance16.BorderColor = System.Drawing.Color.Black
        Appearance16.BorderColor2 = System.Drawing.Color.Black
        Appearance16.TextHAlignAsString = "Left"
        Appearance16.TextVAlignAsString = "Middle"
        Me.UcLabel1.Appearance = Appearance16
        Me.UcLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel1.Location = New System.Drawing.Point(12, 192)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 12
        Me.UcLabel1.Text = "设备产量"
        '
        'UcLabel17
        '
        Appearance14.BackColor = System.Drawing.Color.SkyBlue
        Appearance14.BackColor2 = System.Drawing.Color.White
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance14.BorderColor = System.Drawing.Color.Black
        Appearance14.BorderColor2 = System.Drawing.Color.Black
        Appearance14.TextHAlignAsString = "Left"
        Appearance14.TextVAlignAsString = "Middle"
        Me.UcLabel17.Appearance = Appearance14
        Me.UcLabel17.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel17.Location = New System.Drawing.Point(12, 77)
        Me.UcLabel17.Name = "UcLabel17"
        Me.UcLabel17.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel17.TabIndex = 2
        Me.UcLabel17.Text = "*设备名称"
        '
        'txt设备名称
        '
        Me.txt设备名称.AutoSize = False
        Me.txt设备名称.Location = New System.Drawing.Point(112, 77)
        Me.txt设备名称.MaxLength = 20
        Me.txt设备名称.Name = "txt设备名称"
        Me.txt设备名称.Size = New System.Drawing.Size(130, 23)
        Me.txt设备名称.TabIndex = 3
        Me.txt设备名称.Z_AddZero = False
        Me.txt设备名称.Z_blnChanged = False
        Me.txt设备名称.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txt设备名称.Z_PKey = False
        '
        'txt设备型号
        '
        Me.txt设备型号.AutoSize = False
        Me.txt设备型号.Location = New System.Drawing.Point(112, 100)
        Me.txt设备型号.MaxLength = 50
        Me.txt设备型号.Name = "txt设备型号"
        Me.txt设备型号.Size = New System.Drawing.Size(130, 23)
        Me.txt设备型号.TabIndex = 5
        Me.txt设备型号.Z_AddZero = False
        Me.txt设备型号.Z_blnChanged = False
        Me.txt设备型号.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txt设备型号.Z_PKey = False
        '
        'txt维护厂商
        '
        Me.txt维护厂商.AutoSize = False
        Me.txt维护厂商.Location = New System.Drawing.Point(112, 214)
        Me.txt维护厂商.MaxLength = 20
        Me.txt维护厂商.Name = "txt维护厂商"
        Me.txt维护厂商.Size = New System.Drawing.Size(130, 23)
        Me.txt维护厂商.TabIndex = 15
        Me.txt维护厂商.Z_AddZero = False
        Me.txt维护厂商.Z_blnChanged = False
        Me.txt维护厂商.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txt维护厂商.Z_PKey = False
        '
        'UcLabel2
        '
        Appearance22.BackColor = System.Drawing.Color.SkyBlue
        Appearance22.BackColor2 = System.Drawing.Color.White
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance22.BorderColor = System.Drawing.Color.Black
        Appearance22.BorderColor2 = System.Drawing.Color.Black
        Appearance22.TextHAlignAsString = "Left"
        Appearance22.TextVAlignAsString = "Middle"
        Me.UcLabel2.Appearance = Appearance22
        Me.UcLabel2.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel2.Location = New System.Drawing.Point(12, 215)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel2.TabIndex = 14
        Me.UcLabel2.Text = "维护厂商"
        '
        'txt维护负责人
        '
        Me.txt维护负责人.AutoSize = False
        Me.txt维护负责人.Location = New System.Drawing.Point(112, 237)
        Me.txt维护负责人.MaxLength = 20
        Me.txt维护负责人.Name = "txt维护负责人"
        Me.txt维护负责人.Size = New System.Drawing.Size(130, 23)
        Me.txt维护负责人.TabIndex = 17
        Me.txt维护负责人.Z_AddZero = False
        Me.txt维护负责人.Z_blnChanged = False
        Me.txt维护负责人.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txt维护负责人.Z_PKey = False
        '
        'UcLabel3
        '
        Appearance15.BackColor = System.Drawing.Color.SkyBlue
        Appearance15.BackColor2 = System.Drawing.Color.White
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance15.BorderColor = System.Drawing.Color.Black
        Appearance15.BorderColor2 = System.Drawing.Color.Black
        Appearance15.TextHAlignAsString = "Left"
        Appearance15.TextVAlignAsString = "Middle"
        Me.UcLabel3.Appearance = Appearance15
        Me.UcLabel3.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel3.Location = New System.Drawing.Point(12, 238)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel3.TabIndex = 16
        Me.UcLabel3.Text = "维护负责人"
        '
        'txt负责人电话
        '
        Me.txt负责人电话.AutoSize = False
        Me.txt负责人电话.Location = New System.Drawing.Point(112, 260)
        Me.txt负责人电话.MaxLength = 20
        Me.txt负责人电话.Name = "txt负责人电话"
        Me.txt负责人电话.Size = New System.Drawing.Size(130, 23)
        Me.txt负责人电话.TabIndex = 19
        Me.txt负责人电话.Z_AddZero = False
        Me.txt负责人电话.Z_blnChanged = False
        Me.txt负责人电话.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txt负责人电话.Z_PKey = False
        '
        'UcLabel4
        '
        Appearance18.BackColor = System.Drawing.Color.SkyBlue
        Appearance18.BackColor2 = System.Drawing.Color.White
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance18.BorderColor = System.Drawing.Color.Black
        Appearance18.BorderColor2 = System.Drawing.Color.Black
        Appearance18.TextHAlignAsString = "Left"
        Appearance18.TextVAlignAsString = "Middle"
        Me.UcLabel4.Appearance = Appearance18
        Me.UcLabel4.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel4.Location = New System.Drawing.Point(12, 261)
        Me.UcLabel4.Name = "UcLabel4"
        Me.UcLabel4.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel4.TabIndex = 18
        Me.UcLabel4.Text = "负责人电话"
        '
        'cbo使用状态
        '
        Appearance4.TextVAlignAsString = "Middle"
        Me.cbo使用状态.Appearance = Appearance4
        Me.cbo使用状态.AutoSize = False
        Me.cbo使用状态.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cbo使用状态.Font = New System.Drawing.Font("MS Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbo使用状态.Location = New System.Drawing.Point(112, 169)
        Me.cbo使用状态.Name = "cbo使用状态"
        Appearance5.ForeColor = System.Drawing.Color.Gray
        Me.cbo使用状态.NullTextAppearance = Appearance5
        Me.cbo使用状态.Size = New System.Drawing.Size(130, 22)
        Me.cbo使用状态.TabIndex = 11
        '
        'dtm上次维护日期
        '
        Me.dtm上次维护日期.AutoSize = False
        Me.dtm上次维护日期.Location = New System.Drawing.Point(112, 146)
        Me.dtm上次维护日期.MaskInput = "yyyy/mm/dd"
        Me.dtm上次维护日期.Name = "dtm上次维护日期"
        Me.dtm上次维护日期.Size = New System.Drawing.Size(130, 23)
        Me.dtm上次维护日期.TabIndex = 9
        '
        'num设备产量
        '
        Appearance1.ImageVAlign = Infragistics.Win.VAlign.Middle
        Appearance1.TextHAlignAsString = "Right"
        Me.num设备产量.Appearance = Appearance1
        Me.num设备产量.AutoSize = False
        Me.num设备产量.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.num设备产量.FormatString = "#,##0"
        Me.num设备产量.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.num设备产量.Location = New System.Drawing.Point(112, 191)
        Me.num设备产量.MaskInput = "nnn,nnn,nnn"
        Me.num设备产量.MaxValue = 99999999
        Me.num设备产量.MinValue = 0
        Me.num设备产量.Name = "num设备产量"
        Me.num设备产量.Nullable = True
        Me.num设备产量.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.num设备产量.Size = New System.Drawing.Size(130, 23)
        Me.num设备产量.TabIndex = 13
        Me.num设备产量.Z_blnChanged = False
        '
        'frm设备详细
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.num设备产量)
        Me.Controls.Add(Me.dtm上次维护日期)
        Me.Controls.Add(Me.cbo使用状态)
        Me.Controls.Add(Me.txt设备型号)
        Me.Controls.Add(Me.txt设备名称)
        Me.Controls.Add(Me.UcLabel17)
        Me.Controls.Add(Me.UcLabel4)
        Me.Controls.Add(Me.txt负责人电话)
        Me.Controls.Add(Me.UcLabel3)
        Me.Controls.Add(Me.txt维护负责人)
        Me.Controls.Add(Me.UcLabel2)
        Me.Controls.Add(Me.txt维护厂商)
        Me.Controls.Add(Me.UcLabel1)
        Me.Controls.Add(Me.UcLabel13)
        Me.Controls.Add(Me.UcLabel10)
        Me.Controls.Add(Me.UcLabel7)
        Me.Controls.Add(Me.UcLabel5)
        Me.Controls.Add(Me.UcLabel9)
        Me.Controls.Add(Me.txt维护周期)
        Me.Controls.Add(Me.txt设备编号)
        Me.Name = "frm设备详细"
        Me.Text = "设备明细"
        Me.Controls.SetChildIndex(Me.btnF3保存, 0)
        Me.Controls.SetChildIndex(Me.btnF2编辑, 0)
        Me.Controls.SetChildIndex(Me.btnF4删除, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.txt设备编号, 0)
        Me.Controls.SetChildIndex(Me.txt维护周期, 0)
        Me.Controls.SetChildIndex(Me.UcLabel9, 0)
        Me.Controls.SetChildIndex(Me.UcLabel5, 0)
        Me.Controls.SetChildIndex(Me.UcLabel7, 0)
        Me.Controls.SetChildIndex(Me.UcLabel10, 0)
        Me.Controls.SetChildIndex(Me.UcLabel13, 0)
        Me.Controls.SetChildIndex(Me.labModel, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.UcLabel1, 0)
        Me.Controls.SetChildIndex(Me.txt维护厂商, 0)
        Me.Controls.SetChildIndex(Me.UcLabel2, 0)
        Me.Controls.SetChildIndex(Me.txt维护负责人, 0)
        Me.Controls.SetChildIndex(Me.UcLabel3, 0)
        Me.Controls.SetChildIndex(Me.txt负责人电话, 0)
        Me.Controls.SetChildIndex(Me.UcLabel4, 0)
        Me.Controls.SetChildIndex(Me.UcLabel17, 0)
        Me.Controls.SetChildIndex(Me.txt设备名称, 0)
        Me.Controls.SetChildIndex(Me.txt设备型号, 0)
        Me.Controls.SetChildIndex(Me.cbo使用状态, 0)
        Me.Controls.SetChildIndex(Me.dtm上次维护日期, 0)
        Me.Controls.SetChildIndex(Me.num设备产量, 0)
        CType(Me.txt维护周期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt设备编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt设备名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt设备型号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt维护厂商, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt维护负责人, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt负责人电话, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo使用状态, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtm上次维护日期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num设备产量, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt设备编号 As UserControl.UCText
    Friend WithEvents txt维护周期 As UserControl.UCText
    Friend WithEvents UcLabel9 As UserControl.UCLabel
    Friend WithEvents UcLabel13 As UserControl.UCLabel
    Friend WithEvents UcLabel5 As UserControl.UCLabel
    Friend WithEvents UcLabel7 As UserControl.UCLabel
    Friend WithEvents UcLabel10 As UserControl.UCLabel
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents UcLabel17 As UserControl.UCLabel
    Friend WithEvents txt设备名称 As UserControl.UCText
    Friend WithEvents txt设备型号 As UserControl.UCText
    Friend WithEvents txt维护厂商 As UserControl.UCText
    Friend WithEvents UcLabel2 As UserControl.UCLabel
    Friend WithEvents txt维护负责人 As UserControl.UCText
    Friend WithEvents UcLabel3 As UserControl.UCLabel
    Friend WithEvents txt负责人电话 As UserControl.UCText
    Friend WithEvents UcLabel4 As UserControl.UCLabel
    Friend WithEvents cbo使用状态 As UserControl.UCComboEditor
    Friend WithEvents dtm上次维护日期 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents num设备产量 As UserControl.UCNumericEditor
End Class
