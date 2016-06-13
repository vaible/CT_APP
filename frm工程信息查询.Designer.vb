<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm工程信息查询
    Inherits InheritsSearchForm

    'フォームがコンポーネントの查询をクリーンアップするために dispose をオーバーライドします。

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

    'Windows フォーム デザイナで必要です。

    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。

    'Windows フォーム デザイナを使用して変更できます。  
    'CD エディタを使って変更しないでください。

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("工程编号")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("工程名")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("工程类别")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("工程类别CD")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cbo工程类别 = New UserControl.UCComboEditor(Me.components)
        Me.lbl工程类别 = New UserControl.UCLabel(Me.components)
        Me.txt工程名 = New UserControl.UCText(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.grdList = New UserControl.UCGrid(Me.components)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.cbo工程类别, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt工程名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.TabIndex = 3
        '
        'btnF2查询
        '
        Me.btnF2查询.TabIndex = 1
        '
        'btnF3选择
        '
        Me.btnF3选择.Location = New System.Drawing.Point(175, 12)
        Me.btnF3选择.TabIndex = 2
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 0
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.cbo工程类别)
        Me.UltraGroupBox1.Controls.Add(Me.lbl工程类别)
        Me.UltraGroupBox1.Controls.Add(Me.txt工程名)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel1)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(984, 53)
        Me.UltraGroupBox1.TabIndex = 4
        Me.UltraGroupBox1.Text = "检索条件"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'cbo工程类别
        '
        Appearance16.TextVAlignAsString = "Middle"
        Me.cbo工程类别.Appearance = Appearance16
        Me.cbo工程类别.AutoSize = False
        Me.cbo工程类别.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cbo工程类别.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.cbo工程类别.Location = New System.Drawing.Point(343, 22)
        Me.cbo工程类别.Name = "cbo工程类别"
        Appearance17.ForeColor = System.Drawing.Color.Gray
        Me.cbo工程类别.NullTextAppearance = Appearance17
        Me.cbo工程类别.Size = New System.Drawing.Size(137, 22)
        Me.cbo工程类别.TabIndex = 3
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
        Me.lbl工程类别.Location = New System.Drawing.Point(243, 22)
        Me.lbl工程类别.Name = "lbl工程类别"
        Me.lbl工程类别.Size = New System.Drawing.Size(100, 23)
        Me.lbl工程类别.TabIndex = 2
        Me.lbl工程类别.Text = "工程类别"
        '
        'txt工程名
        '
        Me.txt工程名.AutoSize = False
        Me.txt工程名.Location = New System.Drawing.Point(106, 21)
        Me.txt工程名.MaxLength = 20
        Me.txt工程名.Name = "txt工程名"
        Me.txt工程名.Size = New System.Drawing.Size(137, 23)
        Me.txt工程名.TabIndex = 1
        Me.txt工程名.Z_AddZero = False
        Me.txt工程名.Z_blnChanged = False
        Me.txt工程名.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txt工程名.Z_PKey = False
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
        Me.UcLabel1.Location = New System.Drawing.Point(6, 21)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 0
        Me.UcLabel1.Text = "工程名"
        '
        'grdList
        '
        Appearance1.BackColor = System.Drawing.Color.LightGray
        Appearance1.BorderColor = System.Drawing.Color.Silver
        Appearance1.TextVAlignAsString = "Middle"
        Me.grdList.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.grdList.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grdList.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdList.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.grdList.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdList.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.grdList.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdList.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.grdList.DisplayLayout.MaxColScrollRegions = 1
        Me.grdList.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.Color.White
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.grdList.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(139, Byte), Integer))
        Appearance6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdList.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.grdList.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grdList.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdList.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Copy
        Me.grdList.DisplayLayout.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.grdList.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdList.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.grdList.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grdList.DisplayLayout.Override.CellAppearance = Appearance8
        Me.grdList.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.grdList.DisplayLayout.Override.CellPadding = 0
        Me.grdList.DisplayLayout.Override.DefaultRowHeight = 22
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.grdList.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.grdList.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.grdList.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.grdList.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdList.DisplayLayout.Override.RowAlternateAppearance = Appearance11
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Appearance12.BorderColor = System.Drawing.Color.Silver
        Me.grdList.DisplayLayout.Override.RowAppearance = Appearance12
        Appearance13.TextHAlignAsString = "Center"
        Appearance13.TextVAlignAsString = "Middle"
        Me.grdList.DisplayLayout.Override.RowSelectorAppearance = Appearance13
        Me.grdList.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.grdList.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grdList.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdList.DisplayLayout.Override.RowSelectorStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.grdList.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Me.grdList.DisplayLayout.Override.RowSizingArea = Infragistics.Win.UltraWinGrid.RowSizingArea.RowSelectorsOnly
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(139, Byte), Integer))
        Appearance14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdList.DisplayLayout.Override.SelectedCellAppearance = Appearance14
        Me.grdList.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.grdList.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.grdList.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.grdList.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdList.DisplayLayout.Override.TemplateAddRowAppearance = Appearance15
        Me.grdList.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdList.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdList.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl
        Me.grdList.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.grdList.Location = New System.Drawing.Point(12, 112)
        Me.grdList.Name = "grdList"
        Me.grdList.Size = New System.Drawing.Size(981, 551)
        Me.grdList.TabIndex = 5
        Me.grdList.Text = "UcGrid1"
        '
        'frm工程信息查询
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 691)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.grdList)
        Me.Name = "frm工程信息查询"
        Me.Text = "工程信息查询"
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF2查询, 0)
        Me.Controls.SetChildIndex(Me.btnF3选择, 0)
        Me.Controls.SetChildIndex(Me.grdList, 0)
        Me.Controls.SetChildIndex(Me.UltraGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.cbo工程类别, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt工程名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt工程名 As UserControl.UCText
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents grdList As UserControl.UCGrid
    Friend WithEvents lbl工程类别 As UserControl.UCLabel
    Friend WithEvents cbo工程类别 As UserControl.UCComboEditor
End Class
