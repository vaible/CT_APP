<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm消息发布
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
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("通知类型")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("发布日期")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("通知内容")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("发布人")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("编号")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtm适用结束日期 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txt通知内容 = New UserControl.UCText(Me.components)
        Me.UcLabel3 = New UserControl.UCLabel(Me.components)
        Me.txt发布人编号 = New UserControl.UCText(Me.components)
        Me.UcLabel4 = New UserControl.UCLabel(Me.components)
        Me.dtm适用开始日期 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UcLabel5 = New UserControl.UCLabel(Me.components)
        Me.txt发布人名称 = New UserControl.UCText(Me.components)
        Me.UcLabel18 = New UserControl.UCLabel(Me.components)
        Me.cbo通知类型 = New UserControl.UCComboEditor(Me.components)
        Me.grdList = New UserControl.UCGrid(Me.components)
        CType(Me.dtm适用结束日期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通知内容, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt发布人编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtm适用开始日期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt发布人名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo通知类型, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.TabIndex = 17
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 13
        '
        'btnF4删除
        '
        Me.btnF4删除.TabIndex = 16
        Me.btnF4删除.Visible = False
        '
        'btnF2编辑
        '
        Me.btnF2编辑.TabIndex = 14
        Me.btnF2编辑.Text = "F2:保存"
        '
        'btnF3保存
        '
        Me.btnF3保存.TabIndex = 15
        Me.btnF3保存.Text = "F3:删除"
        '
        'labModel
        '
        Me.labModel.TabIndex = 12
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(210, 85)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(13, 10)
        Me.UltraLabel2.TabIndex = 4
        Me.UltraLabel2.Text = "~"
        '
        'dtm适用结束日期
        '
        Me.dtm适用结束日期.Location = New System.Drawing.Point(225, 75)
        Me.dtm适用结束日期.MaskInput = "yyyy/mm/dd"
        Me.dtm适用结束日期.Name = "dtm适用结束日期"
        Me.dtm适用结束日期.Size = New System.Drawing.Size(102, 21)
        Me.dtm适用结束日期.TabIndex = 5
        '
        'txt通知内容
        '
        Me.txt通知内容.AutoSize = False
        Me.txt通知内容.Location = New System.Drawing.Point(112, 121)
        Me.txt通知内容.MaxLength = 500
        Me.txt通知内容.Multiline = True
        Me.txt通知内容.Name = "txt通知内容"
        Me.txt通知内容.Scrollbars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txt通知内容.Size = New System.Drawing.Size(884, 46)
        Me.txt通知内容.TabIndex = 10
        Me.txt通知内容.Z_AddZero = False
        Me.txt通知内容.Z_blnChanged = False
        Me.txt通知内容.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txt通知内容.Z_PKey = False
        '
        'UcLabel3
        '
        Appearance2.BackColor = System.Drawing.Color.SkyBlue
        Appearance2.BackColor2 = System.Drawing.Color.White
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance2.BorderColor = System.Drawing.Color.Black
        Appearance2.BorderColor2 = System.Drawing.Color.Black
        Appearance2.TextHAlignAsString = "Left"
        Appearance2.TextVAlignAsString = "Middle"
        Me.UcLabel3.Appearance = Appearance2
        Me.UcLabel3.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel3.Location = New System.Drawing.Point(12, 121)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Size = New System.Drawing.Size(100, 46)
        Me.UcLabel3.TabIndex = 9
        Me.UcLabel3.Text = "通知内容"
        '
        'txt发布人编号
        '
        Me.txt发布人编号.AutoSize = False
        Me.txt发布人编号.ButtonsRight.Add(EditorButton1)
        Me.txt发布人编号.Location = New System.Drawing.Point(112, 98)
        Me.txt发布人编号.MaxLength = 20
        Me.txt发布人编号.Name = "txt发布人编号"
        Me.txt发布人编号.Size = New System.Drawing.Size(94, 23)
        Me.txt发布人编号.TabIndex = 7
        Me.txt发布人编号.Z_AddZero = False
        Me.txt发布人编号.Z_blnChanged = False
        Me.txt发布人编号.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txt发布人编号.Z_PKey = False
        '
        'UcLabel4
        '
        Appearance14.BackColor = System.Drawing.Color.SkyBlue
        Appearance14.BackColor2 = System.Drawing.Color.White
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance14.BorderColor = System.Drawing.Color.Black
        Appearance14.BorderColor2 = System.Drawing.Color.Black
        Appearance14.TextHAlignAsString = "Left"
        Appearance14.TextVAlignAsString = "Middle"
        Me.UcLabel4.Appearance = Appearance14
        Me.UcLabel4.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel4.Location = New System.Drawing.Point(12, 98)
        Me.UcLabel4.Name = "UcLabel4"
        Me.UcLabel4.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel4.TabIndex = 6
        Me.UcLabel4.Text = "*发布人"
        '
        'dtm适用开始日期
        '
        Me.dtm适用开始日期.Location = New System.Drawing.Point(112, 75)
        Me.dtm适用开始日期.MaskInput = "yyyy/mm/dd"
        Me.dtm适用开始日期.Name = "dtm适用开始日期"
        Me.dtm适用开始日期.Size = New System.Drawing.Size(94, 21)
        Me.dtm适用开始日期.TabIndex = 3
        '
        'UcLabel5
        '
        Appearance25.BackColor = System.Drawing.Color.SkyBlue
        Appearance25.BackColor2 = System.Drawing.Color.White
        Appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance25.BorderColor = System.Drawing.Color.Black
        Appearance25.BorderColor2 = System.Drawing.Color.Black
        Appearance25.TextHAlignAsString = "Left"
        Appearance25.TextVAlignAsString = "Middle"
        Me.UcLabel5.Appearance = Appearance25
        Me.UcLabel5.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel5.Location = New System.Drawing.Point(12, 75)
        Me.UcLabel5.Name = "UcLabel5"
        Me.UcLabel5.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel5.TabIndex = 2
        Me.UcLabel5.Text = "适用日期"
        '
        'txt发布人名称
        '
        Appearance19.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txt发布人名称.Appearance = Appearance19
        Me.txt发布人名称.AutoSize = False
        Me.txt发布人名称.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txt发布人名称.Location = New System.Drawing.Point(206, 98)
        Me.txt发布人名称.Name = "txt发布人名称"
        Me.txt发布人名称.ReadOnly = True
        Me.txt发布人名称.Size = New System.Drawing.Size(194, 23)
        Me.txt发布人名称.TabIndex = 8
        Me.txt发布人名称.TabStop = False
        Me.txt发布人名称.Z_AddZero = False
        Me.txt发布人名称.Z_blnChanged = False
        Me.txt发布人名称.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txt发布人名称.Z_PKey = False
        '
        'UcLabel18
        '
        Appearance74.BackColor = System.Drawing.Color.SkyBlue
        Appearance74.BackColor2 = System.Drawing.Color.White
        Appearance74.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance74.BorderColor = System.Drawing.Color.Black
        Appearance74.BorderColor2 = System.Drawing.Color.Black
        Appearance74.TextHAlignAsString = "Left"
        Appearance74.TextVAlignAsString = "Middle"
        Me.UcLabel18.Appearance = Appearance74
        Me.UcLabel18.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel18.Location = New System.Drawing.Point(12, 52)
        Me.UcLabel18.Name = "UcLabel18"
        Me.UcLabel18.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel18.TabIndex = 0
        Me.UcLabel18.Text = "*通知类型"
        '
        'cbo通知类型
        '
        Appearance16.TextVAlignAsString = "Middle"
        Me.cbo通知类型.Appearance = Appearance16
        Me.cbo通知类型.AutoSize = False
        Me.cbo通知类型.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cbo通知类型.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.cbo通知类型.Location = New System.Drawing.Point(112, 52)
        Me.cbo通知类型.Name = "cbo通知类型"
        Appearance17.ForeColor = System.Drawing.Color.Gray
        Me.cbo通知类型.NullTextAppearance = Appearance17
        Me.cbo通知类型.Size = New System.Drawing.Size(94, 22)
        Me.cbo通知类型.TabIndex = 1
        '
        'grdList
        '
        Appearance1.BackColor = System.Drawing.Color.LightGray
        Appearance1.BorderColor = System.Drawing.Color.Silver
        Appearance1.TextVAlignAsString = "Middle"
        Me.grdList.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance3.TextHAlignAsString = "Center"
        Appearance3.TextVAlignAsString = "Middle"
        UltraGridColumn1.Header.Appearance = Appearance3
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.OnCellActivate
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance4.TextHAlignAsString = "Center"
        Appearance4.TextVAlignAsString = "Middle"
        UltraGridColumn2.Header.Appearance = Appearance4
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn2.Width = 103
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance5.TextHAlignAsString = "Center"
        Appearance5.TextVAlignAsString = "Middle"
        UltraGridColumn3.Header.Appearance = Appearance5
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 268
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance6.TextHAlignAsString = "Center"
        Appearance6.TextVAlignAsString = "Middle"
        UltraGridColumn4.Header.Appearance = Appearance6
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance7.TextHAlignAsString = "Center"
        Appearance7.TextVAlignAsString = "Middle"
        UltraGridColumn5.Header.Appearance = Appearance7
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5})
        Me.grdList.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grdList.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdList.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance22.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance22.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance22.BorderColor = System.Drawing.SystemColors.Window
        Me.grdList.DisplayLayout.GroupByBox.Appearance = Appearance22
        Appearance23.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdList.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance23
        Me.grdList.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance24.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance24.BackColor2 = System.Drawing.SystemColors.Control
        Appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance24.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdList.DisplayLayout.GroupByBox.PromptAppearance = Appearance24
        Me.grdList.DisplayLayout.MaxColScrollRegions = 1
        Me.grdList.DisplayLayout.MaxRowScrollRegions = 1
        Appearance26.BackColor = System.Drawing.Color.White
        Appearance26.ForeColor = System.Drawing.Color.Black
        Me.grdList.DisplayLayout.Override.ActiveCellAppearance = Appearance26
        Appearance27.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(139, Byte), Integer))
        Appearance27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdList.DisplayLayout.Override.ActiveRowAppearance = Appearance27
        Me.grdList.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grdList.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdList.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Copy
        Me.grdList.DisplayLayout.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.grdList.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdList.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance28.BackColor = System.Drawing.SystemColors.Window
        Me.grdList.DisplayLayout.Override.CardAreaAppearance = Appearance28
        Appearance29.BorderColor = System.Drawing.Color.Silver
        Appearance29.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grdList.DisplayLayout.Override.CellAppearance = Appearance29
        Me.grdList.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.grdList.DisplayLayout.Override.CellPadding = 0
        Me.grdList.DisplayLayout.Override.DefaultRowHeight = 22
        Appearance30.BackColor = System.Drawing.SystemColors.Control
        Appearance30.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance30.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance30.BorderColor = System.Drawing.SystemColors.Window
        Me.grdList.DisplayLayout.Override.GroupByRowAppearance = Appearance30
        Appearance31.TextHAlignAsString = "Left"
        Me.grdList.DisplayLayout.Override.HeaderAppearance = Appearance31
        Me.grdList.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.grdList.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance32.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdList.DisplayLayout.Override.RowAlternateAppearance = Appearance32
        Appearance33.BackColor = System.Drawing.SystemColors.Window
        Appearance33.BorderColor = System.Drawing.Color.Silver
        Me.grdList.DisplayLayout.Override.RowAppearance = Appearance33
        Appearance34.TextHAlignAsString = "Center"
        Appearance34.TextVAlignAsString = "Middle"
        Me.grdList.DisplayLayout.Override.RowSelectorAppearance = Appearance34
        Me.grdList.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.grdList.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grdList.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdList.DisplayLayout.Override.RowSelectorStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.grdList.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Me.grdList.DisplayLayout.Override.RowSizingArea = Infragistics.Win.UltraWinGrid.RowSizingArea.RowSelectorsOnly
        Appearance35.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(139, Byte), Integer))
        Appearance35.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdList.DisplayLayout.Override.SelectedCellAppearance = Appearance35
        Me.grdList.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.grdList.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.grdList.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.grdList.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance36.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdList.DisplayLayout.Override.TemplateAddRowAppearance = Appearance36
        Me.grdList.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdList.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdList.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl
        Me.grdList.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.grdList.Location = New System.Drawing.Point(12, 173)
        Me.grdList.Name = "grdList"
        Me.grdList.Size = New System.Drawing.Size(981, 533)
        Me.grdList.TabIndex = 18
        Me.grdList.Text = "UcGrid1"
        '
        'frm消息发布
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.grdList)
        Me.Controls.Add(Me.cbo通知类型)
        Me.Controls.Add(Me.txt发布人名称)
        Me.Controls.Add(Me.UcLabel18)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.dtm适用结束日期)
        Me.Controls.Add(Me.txt通知内容)
        Me.Controls.Add(Me.UcLabel3)
        Me.Controls.Add(Me.txt发布人编号)
        Me.Controls.Add(Me.UcLabel4)
        Me.Controls.Add(Me.dtm适用开始日期)
        Me.Controls.Add(Me.UcLabel5)
        Me.Name = "frm消息发布"
        Me.Text = "消息发布"
        Me.Controls.SetChildIndex(Me.UcLabel5, 0)
        Me.Controls.SetChildIndex(Me.dtm适用开始日期, 0)
        Me.Controls.SetChildIndex(Me.UcLabel4, 0)
        Me.Controls.SetChildIndex(Me.txt发布人编号, 0)
        Me.Controls.SetChildIndex(Me.UcLabel3, 0)
        Me.Controls.SetChildIndex(Me.txt通知内容, 0)
        Me.Controls.SetChildIndex(Me.dtm适用结束日期, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel2, 0)
        Me.Controls.SetChildIndex(Me.UcLabel18, 0)
        Me.Controls.SetChildIndex(Me.txt发布人名称, 0)
        Me.Controls.SetChildIndex(Me.labModel, 0)
        Me.Controls.SetChildIndex(Me.btnF3保存, 0)
        Me.Controls.SetChildIndex(Me.btnF2编辑, 0)
        Me.Controls.SetChildIndex(Me.btnF4删除, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.cbo通知类型, 0)
        Me.Controls.SetChildIndex(Me.grdList, 0)
        CType(Me.dtm适用结束日期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通知内容, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt发布人编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtm适用开始日期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt发布人名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo通知类型, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtm适用结束日期 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt通知内容 As UserControl.UCText
    Friend WithEvents UcLabel3 As UserControl.UCLabel
    Friend WithEvents txt发布人编号 As UserControl.UCText
    Friend WithEvents UcLabel4 As UserControl.UCLabel
    Friend WithEvents dtm适用开始日期 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UcLabel5 As UserControl.UCLabel
    Friend WithEvents txt发布人名称 As UserControl.UCText
    Friend WithEvents UcLabel18 As UserControl.UCLabel
    Friend WithEvents cbo通知类型 As UserControl.UCComboEditor
    Friend WithEvents grdList As UserControl.UCGrid
End Class
