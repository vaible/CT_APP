<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm生产线一览
    Inherits InheritsSearchForm

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("生产线编号")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("生产线名称")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.grdList = New UserControl.UCGrid(Me.components)
        Me.UcGroupBox1 = New UserControl.UCGroupBox(Me.components)
        Me.txt生产线名称 = New UserControl.UCText(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.UcLabel4 = New UserControl.UCLabel(Me.components)
        Me.txt生产线编号 = New UserControl.UCText(Me.components)
        CType(Me.grdList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UcGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UcGroupBox1.SuspendLayout()
        CType(Me.txt生产线名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt生产线编号, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'grdList
        '
        Appearance15.BackColor = System.Drawing.Color.LightGray
        Appearance15.BorderColor = System.Drawing.Color.Silver
        Appearance15.TextVAlignAsString = "Middle"
        Me.grdList.DisplayLayout.Appearance = Appearance15
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        Me.grdList.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grdList.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdList.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance16.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance16.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance16.BorderColor = System.Drawing.SystemColors.Window
        Me.grdList.DisplayLayout.GroupByBox.Appearance = Appearance16
        Appearance17.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdList.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance17
        Me.grdList.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance18.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance18.BackColor2 = System.Drawing.SystemColors.Control
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance18.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdList.DisplayLayout.GroupByBox.PromptAppearance = Appearance18
        Me.grdList.DisplayLayout.MaxColScrollRegions = 1
        Me.grdList.DisplayLayout.MaxRowScrollRegions = 1
        Appearance19.BackColor = System.Drawing.Color.White
        Appearance19.ForeColor = System.Drawing.Color.Black
        Me.grdList.DisplayLayout.Override.ActiveCellAppearance = Appearance19
        Appearance20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(139, Byte), Integer))
        Appearance20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdList.DisplayLayout.Override.ActiveRowAppearance = Appearance20
        Me.grdList.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grdList.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdList.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Copy
        Me.grdList.DisplayLayout.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.grdList.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdList.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance21.BackColor = System.Drawing.SystemColors.Window
        Me.grdList.DisplayLayout.Override.CardAreaAppearance = Appearance21
        Appearance22.BorderColor = System.Drawing.Color.Silver
        Appearance22.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grdList.DisplayLayout.Override.CellAppearance = Appearance22
        Me.grdList.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.grdList.DisplayLayout.Override.CellPadding = 0
        Me.grdList.DisplayLayout.Override.DefaultRowHeight = 22
        Appearance23.BackColor = System.Drawing.SystemColors.Control
        Appearance23.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance23.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance23.BorderColor = System.Drawing.SystemColors.Window
        Me.grdList.DisplayLayout.Override.GroupByRowAppearance = Appearance23
        Appearance24.TextHAlignAsString = "Left"
        Me.grdList.DisplayLayout.Override.HeaderAppearance = Appearance24
        Me.grdList.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.grdList.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance25.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdList.DisplayLayout.Override.RowAlternateAppearance = Appearance25
        Appearance26.BackColor = System.Drawing.SystemColors.Window
        Appearance26.BorderColor = System.Drawing.Color.Silver
        Me.grdList.DisplayLayout.Override.RowAppearance = Appearance26
        Appearance27.TextHAlignAsString = "Center"
        Appearance27.TextVAlignAsString = "Middle"
        Me.grdList.DisplayLayout.Override.RowSelectorAppearance = Appearance27
        Me.grdList.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.grdList.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grdList.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdList.DisplayLayout.Override.RowSelectorStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.grdList.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Me.grdList.DisplayLayout.Override.RowSizingArea = Infragistics.Win.UltraWinGrid.RowSizingArea.RowSelectorsOnly
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(139, Byte), Integer))
        Appearance2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdList.DisplayLayout.Override.SelectedCellAppearance = Appearance2
        Me.grdList.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.grdList.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.grdList.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.grdList.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance28.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdList.DisplayLayout.Override.TemplateAddRowAppearance = Appearance28
        Me.grdList.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdList.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdList.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl
        Me.grdList.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.grdList.Location = New System.Drawing.Point(12, 135)
        Me.grdList.Name = "grdList"
        Me.grdList.Size = New System.Drawing.Size(981, 551)
        Me.grdList.TabIndex = 1
        Me.grdList.Text = "UcGrid1"
        '
        'UcGroupBox1
        '
        Me.UcGroupBox1.Controls.Add(Me.txt生产线名称)
        Me.UcGroupBox1.Controls.Add(Me.UcLabel1)
        Me.UcGroupBox1.Controls.Add(Me.UcLabel4)
        Me.UcGroupBox1.Controls.Add(Me.txt生产线编号)
        Me.UcGroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.UcGroupBox1.Name = "UcGroupBox1"
        Me.UcGroupBox1.Size = New System.Drawing.Size(984, 77)
        Me.UcGroupBox1.TabIndex = 0
        Me.UcGroupBox1.Text = "查询条件"
        Me.UcGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'txt生产线名称
        '
        Me.txt生产线名称.AutoSize = False
        Me.txt生产线名称.Location = New System.Drawing.Point(106, 44)
        Me.txt生产线名称.MaxLength = 200
        Me.txt生产线名称.Name = "txt生产线名称"
        Me.txt生产线名称.Size = New System.Drawing.Size(134, 23)
        Me.txt生产线名称.TabIndex = 3
        Me.txt生产线名称.Z_AddZero = False
        Me.txt生产线名称.Z_blnChanged = False
        Me.txt生产线名称.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txt生产线名称.Z_PKey = False
        '
        'UcLabel1
        '
        Appearance35.BackColor = System.Drawing.Color.SkyBlue
        Appearance35.BackColor2 = System.Drawing.Color.White
        Appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance35.BorderColor = System.Drawing.Color.Black
        Appearance35.BorderColor2 = System.Drawing.Color.Black
        Appearance35.TextHAlignAsString = "Left"
        Appearance35.TextVAlignAsString = "Middle"
        Me.UcLabel1.Appearance = Appearance35
        Me.UcLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcLabel1.Location = New System.Drawing.Point(6, 44)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 2
        Me.UcLabel1.Text = "生产线名称"
        '
        'UcLabel4
        '
        Appearance3.BackColor = System.Drawing.Color.SkyBlue
        Appearance3.BackColor2 = System.Drawing.Color.White
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance3.BorderColor = System.Drawing.Color.Black
        Appearance3.BorderColor2 = System.Drawing.Color.Black
        Appearance3.TextHAlignAsString = "Left"
        Appearance3.TextVAlignAsString = "Middle"
        Me.UcLabel4.Appearance = Appearance3
        Me.UcLabel4.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel4.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcLabel4.Location = New System.Drawing.Point(6, 21)
        Me.UcLabel4.Name = "UcLabel4"
        Me.UcLabel4.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel4.TabIndex = 0
        Me.UcLabel4.Text = "生产线编号"
        '
        'txt生产线编号
        '
        Me.txt生产线编号.AutoSize = False
        Me.txt生产线编号.Location = New System.Drawing.Point(106, 21)
        Me.txt生产线编号.MaxLength = 20
        Me.txt生产线编号.Name = "txt生产线编号"
        Me.txt生产线编号.Size = New System.Drawing.Size(134, 23)
        Me.txt生产线编号.TabIndex = 1
        Me.txt生产线编号.Z_AddZero = False
        Me.txt生产线编号.Z_blnChanged = False
        Me.txt生产线编号.Z_InputMask = UserControl.UCText.InputMask.Defalut
        Me.txt生产线编号.Z_PKey = False
        '
        'frm生产线一览
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.UcGroupBox1)
        Me.Controls.Add(Me.grdList)
        Me.Name = "frm生产线一览"
        Me.Text = "生产线一览"
        Me.Controls.SetChildIndex(Me.grdList, 0)
        Me.Controls.SetChildIndex(Me.UcGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.btnF2查询, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF3选择, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        CType(Me.grdList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UcGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UcGroupBox1.ResumeLayout(False)
        CType(Me.txt生产线名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt生产线编号, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdList As UserControl.UCGrid
    Friend WithEvents UcGroupBox1 As UserControl.UCGroupBox
    Friend WithEvents UcLabel4 As UserControl.UCLabel
    Friend WithEvents txt生产线编号 As UserControl.UCText
    Friend WithEvents txt生产线名称 As UserControl.UCText
    Friend WithEvents UcLabel1 As UserControl.UCLabel
End Class
