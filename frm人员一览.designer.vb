<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm人员查询
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("人员编号")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("人员姓名")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("部门名称")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("电话号码")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraGroupBox1 = New UserControl.UCGroupBox(Me.components)
        Me.txt部门名称 = New UserControl.UCText(Me.components)
        Me.txt部门编号 = New UserControl.UCText(Me.components)
        Me.UcLabel5 = New UserControl.UCLabel(Me.components)
        Me.UcLabel2 = New UserControl.UCLabel(Me.components)
        Me.UcLabel3 = New UserControl.UCLabel(Me.components)
        Me.txt人员名 = New UserControl.UCText(Me.components)
        Me.txt人员编号 = New UserControl.UCText(Me.components)
        Me.grdlist = New UserControl.UCGrid(Me.components)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txt部门名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt部门编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt人员名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt人员编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdlist, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.UltraGroupBox1.Controls.Add(Me.txt部门名称)
        Me.UltraGroupBox1.Controls.Add(Me.txt部门编号)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel5)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel2)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.txt人员名)
        Me.UltraGroupBox1.Controls.Add(Me.txt人员编号)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(984, 77)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.Text = "查询条件"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'txt部门名称
        '
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txt部门名称.Appearance = Appearance1
        Me.txt部门名称.AutoSize = False
        Me.txt部门名称.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txt部门名称.Location = New System.Drawing.Point(544, 19)
        Me.txt部门名称.Name = "txt部门名称"
        Me.txt部门名称.ReadOnly = True
        Me.txt部门名称.Size = New System.Drawing.Size(200, 23)
        Me.txt部门名称.TabIndex = 6
        Me.txt部门名称.TabStop = False
        Me.txt部门名称.Z_AddZero = False
        Me.txt部门名称.Z_blnChanged = False
        Me.txt部门名称.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txt部门名称.Z_PKey = False
        '
        'txt部门编号
        '
        Me.txt部门编号.AutoSize = False
        Me.txt部门编号.ButtonsRight.Add(EditorButton1)
        Me.txt部门编号.Location = New System.Drawing.Point(444, 19)
        Me.txt部门编号.Name = "txt部门编号"
        Me.txt部门编号.Size = New System.Drawing.Size(100, 23)
        Me.txt部门编号.TabIndex = 5
        Me.txt部门编号.Z_AddZero = False
        Me.txt部门编号.Z_blnChanged = False
        Me.txt部门编号.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txt部门编号.Z_PKey = False
        '
        'UcLabel5
        '
        Appearance34.BackColor = System.Drawing.Color.SkyBlue
        Appearance34.BackColor2 = System.Drawing.Color.White
        Appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance34.BorderColor = System.Drawing.Color.Black
        Appearance34.BorderColor2 = System.Drawing.Color.Black
        Appearance34.TextHAlignAsString = "Left"
        Appearance34.TextVAlignAsString = "Middle"
        Me.UcLabel5.Appearance = Appearance34
        Me.UcLabel5.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel5.Location = New System.Drawing.Point(344, 19)
        Me.UcLabel5.Name = "UcLabel5"
        Me.UcLabel5.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel5.TabIndex = 4
        Me.UcLabel5.Text = "部门"
        '
        'UcLabel2
        '
        Appearance35.BackColor = System.Drawing.Color.SkyBlue
        Appearance35.BackColor2 = System.Drawing.Color.White
        Appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance35.BorderColor = System.Drawing.Color.Black
        Appearance35.BorderColor2 = System.Drawing.Color.Black
        Appearance35.TextHAlignAsString = "Left"
        Appearance35.TextVAlignAsString = "Middle"
        Me.UcLabel2.Appearance = Appearance35
        Me.UcLabel2.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel2.Location = New System.Drawing.Point(6, 44)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel2.TabIndex = 2
        Me.UcLabel2.Text = "人员姓名"
        '
        'UcLabel3
        '
        Appearance33.BackColor = System.Drawing.Color.SkyBlue
        Appearance33.BackColor2 = System.Drawing.Color.White
        Appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance33.BorderColor = System.Drawing.Color.Black
        Appearance33.BorderColor2 = System.Drawing.Color.Black
        Appearance33.TextHAlignAsString = "Left"
        Appearance33.TextVAlignAsString = "Middle"
        Me.UcLabel3.Appearance = Appearance33
        Me.UcLabel3.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel3.Location = New System.Drawing.Point(6, 21)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel3.TabIndex = 0
        Me.UcLabel3.Text = "人员编号"
        '
        'txt人员名
        '
        Me.txt人员名.AutoSize = False
        Me.txt人员名.Location = New System.Drawing.Point(106, 44)
        Me.txt人员名.Name = "txt人员名"
        Me.txt人员名.Size = New System.Drawing.Size(134, 23)
        Me.txt人员名.TabIndex = 3
        Me.txt人员名.Z_AddZero = False
        Me.txt人员名.Z_blnChanged = False
        Me.txt人员名.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txt人员名.Z_PKey = False
        '
        'txt人员编号
        '
        Me.txt人员编号.AutoSize = False
        Me.txt人员编号.Location = New System.Drawing.Point(106, 21)
        Me.txt人员编号.Name = "txt人员编号"
        Me.txt人员编号.Size = New System.Drawing.Size(134, 23)
        Me.txt人员编号.TabIndex = 1
        Me.txt人员编号.Z_AddZero = False
        Me.txt人员编号.Z_blnChanged = False
        Me.txt人员编号.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txt人员编号.Z_PKey = False
        '
        'grdlist
        '
        Appearance14.BackColor = System.Drawing.Color.LightGray
        Appearance14.BorderColor = System.Drawing.Color.Silver
        Appearance14.TextVAlignAsString = "Middle"
        Me.grdlist.DisplayLayout.Appearance = Appearance14
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 87
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.grdlist.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grdlist.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdlist.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance16.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance16.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance16.BorderColor = System.Drawing.SystemColors.Window
        Me.grdlist.DisplayLayout.GroupByBox.Appearance = Appearance16
        Appearance17.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdlist.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance17
        Me.grdlist.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance21.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance21.BackColor2 = System.Drawing.SystemColors.Control
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance21.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdlist.DisplayLayout.GroupByBox.PromptAppearance = Appearance21
        Me.grdlist.DisplayLayout.MaxColScrollRegions = 1
        Me.grdlist.DisplayLayout.MaxRowScrollRegions = 1
        Appearance23.BackColor = System.Drawing.Color.White
        Appearance23.ForeColor = System.Drawing.Color.Black
        Me.grdlist.DisplayLayout.Override.ActiveCellAppearance = Appearance23
        Appearance36.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(139, Byte), Integer))
        Appearance36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdlist.DisplayLayout.Override.ActiveRowAppearance = Appearance36
        Me.grdlist.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grdlist.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdlist.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Copy
        Me.grdlist.DisplayLayout.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.grdlist.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdlist.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance37.BackColor = System.Drawing.SystemColors.Window
        Me.grdlist.DisplayLayout.Override.CardAreaAppearance = Appearance37
        Appearance38.BorderColor = System.Drawing.Color.Silver
        Appearance38.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grdlist.DisplayLayout.Override.CellAppearance = Appearance38
        Me.grdlist.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.grdlist.DisplayLayout.Override.CellPadding = 0
        Me.grdlist.DisplayLayout.Override.DefaultRowHeight = 22
        Appearance39.BackColor = System.Drawing.SystemColors.Control
        Appearance39.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance39.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance39.BorderColor = System.Drawing.SystemColors.Window
        Me.grdlist.DisplayLayout.Override.GroupByRowAppearance = Appearance39
        Appearance40.TextHAlignAsString = "Left"
        Me.grdlist.DisplayLayout.Override.HeaderAppearance = Appearance40
        Me.grdlist.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.grdlist.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance41.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdlist.DisplayLayout.Override.RowAlternateAppearance = Appearance41
        Appearance42.BackColor = System.Drawing.SystemColors.Window
        Appearance42.BorderColor = System.Drawing.Color.Silver
        Me.grdlist.DisplayLayout.Override.RowAppearance = Appearance42
        Appearance43.TextHAlignAsString = "Center"
        Appearance43.TextVAlignAsString = "Middle"
        Me.grdlist.DisplayLayout.Override.RowSelectorAppearance = Appearance43
        Me.grdlist.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.grdlist.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grdlist.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdlist.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Me.grdlist.DisplayLayout.Override.RowSizingArea = Infragistics.Win.UltraWinGrid.RowSizingArea.RowSelectorsOnly
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(139, Byte), Integer))
        Appearance2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdlist.DisplayLayout.Override.SelectedCellAppearance = Appearance2
        Me.grdlist.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.grdlist.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.grdlist.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.grdlist.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance44.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdlist.DisplayLayout.Override.TemplateAddRowAppearance = Appearance44
        Me.grdlist.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdlist.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdlist.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl
        Me.grdlist.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.grdlist.Location = New System.Drawing.Point(12, 135)
        Me.grdlist.Name = "grdlist"
        Me.grdlist.Size = New System.Drawing.Size(984, 551)
        Me.grdlist.TabIndex = 1
        Me.grdlist.Text = "UcGrid1"
        '
        'frm人员查询
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.grdlist)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Name = "frm人员查询"
        Me.Text = "人员查询"
        Me.Controls.SetChildIndex(Me.btnF2查询, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF3选择, 0)
        Me.Controls.SetChildIndex(Me.UltraGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.grdlist, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.txt部门名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt部门编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt人员名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt人员编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt人员编号 As UserControl.UCText
    Friend WithEvents grdlist As UserControl.UCGrid
    Friend WithEvents UcLabel3 As UserControl.UCLabel
    Friend WithEvents UcLabel5 As UserControl.UCLabel
    Friend WithEvents UcLabel2 As UserControl.UCLabel
    Friend WithEvents txt人员名 As UserControl.UCText
    Friend WithEvents UltraGroupBox1 As UserControl.UCGroupBox
    Friend WithEvents txt部门名称 As UserControl.UCText
    Friend WithEvents txt部门编号 As UserControl.UCText
End Class
