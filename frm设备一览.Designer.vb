<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm设备查询
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
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("设备编号")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("设备名称")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("设备型号")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("上次维护日期")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("使用状态")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraGroupBox1 = New UserControl.UCGroupBox(Me.components)
        Me.txt设备名称 = New UserControl.UCText(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.UcLabel3 = New UserControl.UCLabel(Me.components)
        Me.txt设备编号 = New UserControl.UCText(Me.components)
        Me.grdList = New UserControl.UCGrid(Me.components)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txt设备名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt设备编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.TabIndex = 5
        Me.btnF12关闭.Text = "F12：关闭"
        '
        'btnF2查询
        '
        Me.btnF2查询.TabIndex = 3
        '
        'btnF3选择
        '
        Me.btnF3选择.TabIndex = 4
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 2
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.txt设备名称)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.txt设备编号)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(984, 77)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.Text = "查询条件"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'txt设备名称
        '
        Me.txt设备名称.AutoSize = False
        Me.txt设备名称.Location = New System.Drawing.Point(106, 44)
        Me.txt设备名称.MaxLength = 20
        Me.txt设备名称.Name = "txt设备名称"
        Me.txt设备名称.Size = New System.Drawing.Size(134, 23)
        Me.txt设备名称.TabIndex = 3
        Me.txt设备名称.Z_AddZero = False
        Me.txt设备名称.Z_blnChanged = False
        Me.txt设备名称.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txt设备名称.Z_PKey = False
        '
        'UcLabel1
        '
        Appearance62.BackColor = System.Drawing.Color.SkyBlue
        Appearance62.BackColor2 = System.Drawing.Color.White
        Appearance62.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance62.BorderColor = System.Drawing.Color.Black
        Appearance62.BorderColor2 = System.Drawing.Color.Black
        Appearance62.TextHAlignAsString = "Left"
        Appearance62.TextVAlignAsString = "Middle"
        Me.UcLabel1.Appearance = Appearance62
        Me.UcLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel1.Location = New System.Drawing.Point(6, 44)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 2
        Me.UcLabel1.Text = "设备名称"
        '
        'UcLabel3
        '
        Appearance35.BackColor = System.Drawing.Color.SkyBlue
        Appearance35.BackColor2 = System.Drawing.Color.White
        Appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance35.BorderColor = System.Drawing.Color.Black
        Appearance35.BorderColor2 = System.Drawing.Color.Black
        Appearance35.TextHAlignAsString = "Left"
        Appearance35.TextVAlignAsString = "Middle"
        Me.UcLabel3.Appearance = Appearance35
        Me.UcLabel3.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel3.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcLabel3.Location = New System.Drawing.Point(6, 21)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel3.TabIndex = 0
        Me.UcLabel3.Text = "设备编号"
        '
        'txt设备编号
        '
        Me.txt设备编号.AutoSize = False
        Me.txt设备编号.Location = New System.Drawing.Point(106, 21)
        Me.txt设备编号.MaxLength = 20
        Me.txt设备编号.Name = "txt设备编号"
        Me.txt设备编号.Size = New System.Drawing.Size(134, 23)
        Me.txt设备编号.TabIndex = 1
        Me.txt设备编号.Z_AddZero = False
        Me.txt设备编号.Z_blnChanged = False
        Me.txt设备编号.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txt设备编号.Z_PKey = False
        '
        'grdList
        '
        Appearance2.BackColor = System.Drawing.Color.LightGray
        Appearance2.BorderColor = System.Drawing.Color.Silver
        Appearance2.TextVAlignAsString = "Middle"
        Me.grdList.DisplayLayout.Appearance = Appearance2
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.OnCellActivate
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.OnCellActivate
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.OnCellActivate
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.OnCellActivate
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 108
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.OnCellActivate
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5})
        Me.grdList.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grdList.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdList.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance17.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance17.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance17.BorderColor = System.Drawing.SystemColors.Window
        Me.grdList.DisplayLayout.GroupByBox.Appearance = Appearance17
        Appearance18.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdList.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance18
        Me.grdList.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance19.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance19.BackColor2 = System.Drawing.SystemColors.Control
        Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance19.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdList.DisplayLayout.GroupByBox.PromptAppearance = Appearance19
        Me.grdList.DisplayLayout.MaxColScrollRegions = 1
        Me.grdList.DisplayLayout.MaxRowScrollRegions = 1
        Appearance20.BackColor = System.Drawing.Color.White
        Appearance20.ForeColor = System.Drawing.Color.Black
        Me.grdList.DisplayLayout.Override.ActiveCellAppearance = Appearance20
        Appearance21.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(139, Byte), Integer))
        Appearance21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdList.DisplayLayout.Override.ActiveRowAppearance = Appearance21
        Me.grdList.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grdList.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdList.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Copy
        Me.grdList.DisplayLayout.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.grdList.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdList.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance22.BackColor = System.Drawing.SystemColors.Window
        Me.grdList.DisplayLayout.Override.CardAreaAppearance = Appearance22
        Appearance23.BorderColor = System.Drawing.Color.Silver
        Appearance23.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grdList.DisplayLayout.Override.CellAppearance = Appearance23
        Me.grdList.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.grdList.DisplayLayout.Override.CellPadding = 0
        Me.grdList.DisplayLayout.Override.DefaultRowHeight = 22
        Appearance24.BackColor = System.Drawing.SystemColors.Control
        Appearance24.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance24.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance24.BorderColor = System.Drawing.SystemColors.Window
        Me.grdList.DisplayLayout.Override.GroupByRowAppearance = Appearance24
        Appearance25.TextHAlignAsString = "Left"
        Me.grdList.DisplayLayout.Override.HeaderAppearance = Appearance25
        Me.grdList.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.grdList.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance26.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdList.DisplayLayout.Override.RowAlternateAppearance = Appearance26
        Appearance27.BackColor = System.Drawing.SystemColors.Window
        Appearance27.BorderColor = System.Drawing.Color.Silver
        Me.grdList.DisplayLayout.Override.RowAppearance = Appearance27
        Appearance28.TextHAlignAsString = "Center"
        Appearance28.TextVAlignAsString = "Middle"
        Me.grdList.DisplayLayout.Override.RowSelectorAppearance = Appearance28
        Me.grdList.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.grdList.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grdList.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdList.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Me.grdList.DisplayLayout.Override.RowSizingArea = Infragistics.Win.UltraWinGrid.RowSizingArea.RowSelectorsOnly
        Appearance29.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(139, Byte), Integer))
        Appearance29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdList.DisplayLayout.Override.SelectedCellAppearance = Appearance29
        Me.grdList.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.grdList.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.grdList.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.grdList.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance30.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdList.DisplayLayout.Override.TemplateAddRowAppearance = Appearance30
        Me.grdList.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdList.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdList.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl
        Me.grdList.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.grdList.Location = New System.Drawing.Point(12, 135)
        Me.grdList.Name = "grdList"
        Me.grdList.Size = New System.Drawing.Size(983, 551)
        Me.grdList.TabIndex = 1
        Me.grdList.Text = "UcGrid1"
        '
        'frm设备查询
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.grdList)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Name = "frm设备查询"
        Me.Text = "设备查询"
        Me.Controls.SetChildIndex(Me.btnF2查询, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF3选择, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.UltraGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.grdList, 0)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.txt设备名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt设备编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraGroupBox1 As UserControl.UCGroupBox
    Friend WithEvents grdList As UserControl.UCGrid
    Friend WithEvents txt设备名称 As UserControl.UCText
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents UcLabel3 As UserControl.UCLabel
    Friend WithEvents txt设备编号 As UserControl.UCText
End Class

