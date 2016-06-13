Imports System.IO
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Public Class frm客户详细

#Region "変数定義"

#End Region

#Region "常数定義"

    Private mStrActGrid As String = "负责"
    Private mDt负责 As DataTable
    Private mDt包装 As DataTable



#End Region

#Region "Form Event"

    Private Sub frm客户详细_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode

                'F1：
                Case Keys.F1

                    If btnF1清空.Enabled Then
                        btnF1清空.Focus()
                        If btnF1清空.Focused Then
                            Me.btnF1清空_Click(Nothing, Nothing)
                        End If
                    Else
                        Me.Cursor = Cursors.Default
                        Exit Sub
                    End If

                    'F2：
                Case Keys.F2

                    If btnF2编辑.Enabled Then
                        btnF2编辑.Focus()
                        If btnF2编辑.Focused Then
                            Me.btnF2编辑_Click(Nothing, Nothing)
                        End If
                    Else
                        Me.Cursor = Cursors.Default
                        Exit Sub
                    End If

                    'F3：
                Case Keys.F3

                    If btnF3保存.Enabled Then
                        btnF3保存.Focus()
                        If btnF3保存.Focused Then
                            Me.btnF3保存_Click(Nothing, Nothing)
                        End If
                    Else
                        Me.Cursor = Cursors.Default
                        Exit Sub
                    End If

                    'F4：
                Case Keys.F4

                    If btnF4删除.Enabled Then
                        btnF4删除.Focus()
                        If btnF4删除.Focused Then
                            Me.btnF4删除_Click(Nothing, Nothing)
                        End If
                    Else
                        Me.Cursor = Cursors.Default
                        Exit Sub
                    End If

                    'F5：
                Case Keys.F5

                    If btnF5行追加.Enabled Then
                        btnF5行追加.Focus()
                        If btnF5行追加.Focused Then
                            Me.btnF5行追加_Click(Nothing, Nothing)
                        End If
                    Else
                        Me.Cursor = Cursors.Default
                        Exit Sub
                    End If
                    'F6：
                Case Keys.F6

                    If btnF6行删除.Enabled Then
                        btnF6行删除.Focus()
                        If btnF6行删除.Focused Then
                            Me.btnF6行删除_Click(Nothing, Nothing)
                        End If
                    Else
                        Me.Cursor = Cursors.Default
                        Exit Sub
                    End If
                    'F12：
                Case Keys.F12

                    If btnF12关闭.Enabled Then
                        btnF12关闭.Focus()
                        If btnF12关闭.Focused Then
                            Me.btnF12关闭_Click(Nothing, Nothing)
                        End If
                    Else
                        Me.Cursor = Cursors.Default
                        Exit Sub
                    End If

                    'その他の場合
                Case Else
                    Me.Cursor = Cursors.Default
                    Exit Sub

            End Select
        Catch ex As Exception
            EXHelper.ProcessEx(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Sub 客户查询_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            'Comboxリストを設置する
            SetCombox()

            'フォーム初期化
            InitForm()

            SetPermission()

        Catch ex As Exception
            EXHelper.ProcessEx(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Public Sub 客户查询_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Try

            '確認メッセージを表示（MsgID：１）はい　：　画面を閉じる,いいえ　：　画面をそのまま
            If CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID1) = Constant.ENU_SHOWMSG.showMsgNo Then
                e.Cancel = True
                Exit Sub
            End If

        Catch ex As Exception
            EXHelper.ProcessEx(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

#End Region

#Region "Button Event"

    Private Sub btnF1清空_Click(sender As Object, e As EventArgs) Handles btnF1清空.Click

        Try
            If CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID6) = Constant.ENU_SHOWMSG.showMsgNo Then
                Return
            End If

            InitForm()

        Catch ex As Exception
            EXHelper.ProcessEx(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnF2编辑_Click(sender As Object, e As EventArgs) Handles btnF2编辑.Click

        Try

            '打开一览画面，返回选择行数据，显示详细数据
            Dim objFrm As New frm客户查询
            Dim objBll客户明细 As New Bll客户详细
            Dim objM_客户详细T As New M_客户详细T
            objFrm.ShowDialog()

            If objFrm.ReturnType = Constant.ENU_SEARCH.SearchMOk Then

                '画面模式：修改模式，主键不可编辑
                Z_FormMode = Constant.ENU_FORMMODE.ModeEdit

                txt客户编号.ReadOnly = True

                txt客户编号.Text = objFrm.CD

                Dim dtTemp As DataTable = Utility.GetViewByKey("客户编号", objFrm.CD, "M_客户详细")

                If dtTemp.Rows.Count > 0 Then
                    txt客户名称.Text = dtTemp.Rows(0).Item("客户名称").ToString
                    txt英文名称.Text = dtTemp.Rows(0).Item("英文名称").ToString
                    cbo客户区分.Value = dtTemp.Rows(0).Item("客户区分").ToString
                    txt邮政编码.Text = dtTemp.Rows(0).Item("邮政编码").ToString
                    txt公司地址.Text = dtTemp.Rows(0).Item("公司地址").ToString
                    txt所在区域.Text = dtTemp.Rows(0).Item("所在区域").ToString
                    txt详细地址.Text = dtTemp.Rows(0).Item("详细地址").ToString
                    txt电话号码.Text = dtTemp.Rows(0).Item("公司电话").ToString
                    txt传真号码.Text = dtTemp.Rows(0).Item("传真").ToString
                    objM_客户详细T.客户编号 = txt客户编号.Text
                    Dim dsReturn As DataSet = objBll客户明细.GetDoubleGridData(objM_客户详细T)

                    mDt负责 = dsReturn.Tables(0)
                    mDt包装 = dsReturn.Tables(1)

                    Utility.SetGridName(mDt负责, grd负责)
                    Utility.SetGridName(mDt包装, grd包装)

                End If

            End If

        Catch ex As Exception
            EXHelper.ProcessEx(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnF3保存_Click(sender As Object, e As EventArgs) Handles btnF3保存.Click

        Try
            Me.Cursor = Cursors.WaitCursor

            '必須入力チェック、正確性チェック
            If Not CheckInput() Then
                Exit Sub
            End If

            Select Case Z_FormMode

                '新規モード
                Case Constant.ENU_FORMMODE.ModeNew
                    If CommonMsg.showMsg(Me.Text.ToString, Constant.ENU_MSGID.MSGID2) = Constant.ENU_SHOWMSG.showMsgNo Then
                        Exit Sub
                    End If

                    '変更モード
                Case Constant.ENU_FORMMODE.ModeEdit
                    If CommonMsg.showMsg(Me.Text.ToString, Constant.ENU_MSGID.MSGID3) = Constant.ENU_SHOWMSG.showMsgNo Then
                        Exit Sub
                    End If

            End Select

            If Not SaveData() Then
                Exit Sub
            End If

            '登録完了のメッセージを表示。(MsgID：11、　\1："登録")
            CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID11, "登録")

            '画面初始化
            InitForm()

        Catch ex As Exception
            EXHelper.ProcessEx(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnF4删除_Click(sender As Object, e As EventArgs) Handles btnF4删除.Click

        Dim objM_客户详细T As M_客户详细T
        Dim objBll As Bll客户详细

        Try

            If Z_FormMode = Constant.ENU_FORMMODE.ModeNew Then
                Return
            End If

            Me.Cursor = Cursors.WaitCursor

            '削除確認メッセージを表示。（MsgID：103）
            If CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
                Exit Sub
            End If

            objM_客户详细T = New M_客户详细T
            objBll = New Bll客户详细

            objM_客户详细T.客户编号 = txt客户编号.Text

            objBll.DoDelete(objM_客户详细T)

            CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID11, "削除")

            InitForm()

        Catch ex As Exception
            EXHelper.ProcessEx(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnF5行追加_Click(sender As Object, e As EventArgs) Handles btnF5行追加.Click
        Dim drDataRow As DataRow = Nothing
        Dim intRow As Integer

        Try

            Select Case mstrActGrid

                Case "负责"
                    drDataRow = mdt负责.NewRow

                    'グリッドの新規行を追加
                    mdt负责.Rows.InsertAt(drDataRow, Me.grd负责.Rows.Count)

                    mdt负责.AcceptChanges()

                    'PFn_SetGridName(mDt, Me.grd负责)

                    Me.grd负责.UpdateData()

                    intRow = Me.grd负责.Rows.Count - 1

                    'Me.grd负责.Rows(intRow).Cells(ENU_GRID入金情報.Hidden_ｽﾃｰﾀｽ).Value = cgStrSTATUS新

                    grd负责.ActiveRow = Me.grd负责.Rows(intRow)
                    grd负责.Rows(intRow).Cells(0).Activate()
                    grd负责.Rows(intRow).Cells(0).Selected = True
                    grd负责.PerformAction(UltraWinGrid.UltraGridAction.EnterEditMode)

                    Me.grd负责.UpdateData()
                    Me.mdt负责.AcceptChanges()

                    Me.grd负责.UpdateData()
                Case "包装"
                    drDataRow = mdt包装.NewRow

                    'グリッドの新規行を追加
                    mdt包装.Rows.InsertAt(drDataRow, Me.grd包装.Rows.Count)

                    mdt包装.AcceptChanges()

                    'PFn_SetGridName(mDt, Me.grd负责)

                    Me.grd包装.UpdateData()

                    intRow = Me.grd包装.Rows.Count - 1

                    'Me.grd负责.Rows(intRow).Cells(ENU_GRID入金情報.Hidden_ｽﾃｰﾀｽ).Value = cgStrSTATUS新

                    grd包装.ActiveRow = Me.grd包装.Rows(intRow)
                    grd包装.Rows(intRow).Cells(0).Activate()
                    grd包装.Rows(intRow).Cells(0).Selected = True
                    grd包装.PerformAction(UltraWinGrid.UltraGridAction.EnterEditMode)

                    Me.grd包装.UpdateData()
                    Me.mdt包装.AcceptChanges()

                    Me.grd包装.UpdateData()
            End Select

        Catch ex As Exception
            '異常処理
            EXHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnF6行删除_Click(sender As Object, e As EventArgs) Handles btnF6行删除.Click
        Dim intRowDelete As Integer
        Dim intRow As Integer

        Try
            Select Case mstrActGrid

                Case "负责"

                    If Me.grd负责.Rows.Count = 0 Then
                        ''明細情報を1件以上入力してください。
                        'CommonMsg.PFn_ShowMsg(Me.Text, ENU_MSGID.MSGID57)
                        Exit Sub
                    End If

                    '砂時計のカーソルが設定
                    Me.Cursor = Cursors.WaitCursor

                    If Me.grd负责.ActiveRow Is Nothing Then
                        'Me.mErrorFocus = False
                        Return
                    End If

                    intRowDelete = Me.grd负责.ActiveRow.Index

                    '削除チェック	
                    '	選択行の削除フラグを反転させ、削除チェックボックスへ反映
                    Me.grd负责.Rows(intRowDelete).Delete(False)


                    Me.grd负责.UpdateData()
                    Me.mdt负责.AcceptChanges()

                    If Me.grd负责.Rows.VisibleRowCount = 0 Or Me.grd负责.Rows.Count = 0 Then
                        '行を追加
                        'FN_AddGridNewRow()
                        Exit Sub
                    Else
                        If Me.grd负责.Rows.VisibleRowCount < intRow Then
                            intRow = 0
                        ElseIf Me.grd负责.Rows.VisibleRowCount = intRow Then
                            intRow = Me.grd负责.Rows.VisibleRowCount - 1
                        End If
                    End If

                    Me.grd负责.Rows.GetRowAtVisibleIndex(intRow).Cells(0).Activated = True
                    Me.grd负责.Rows.GetRowAtVisibleIndex(intRow).Cells(0).Selected = True
                    Me.grd负责.PerformAction(UltraWinGrid.UltraGridAction.EnterEditMode)


                Case "包装"
                    If Me.grd包装.Rows.Count = 0 Then
                        ''明細情報を1件以上入力してください。
                        'CommonMsg.PFn_ShowMsg(Me.Text, ENU_MSGID.MSGID57)
                        Exit Sub
                    End If

                    '砂時計のカーソルが設定
                    Me.Cursor = Cursors.WaitCursor

                    If Me.grd包装.ActiveRow Is Nothing Then
                        'Me.mErrorFocus = False
                        Return
                    End If

                    intRowDelete = Me.grd包装.ActiveRow.Index

                    '削除チェック	
                    '	選択行の削除フラグを反転させ、削除チェックボックスへ反映
                    Me.grd包装.Rows(intRowDelete).Delete(False)


                    Me.grd包装.UpdateData()
                    Me.mdt包装.AcceptChanges()

                    If Me.grd包装.Rows.VisibleRowCount = 0 Or Me.grd包装.Rows.Count = 0 Then
                        '行を追加
                        'FN_AddGridNewRow()
                        Exit Sub
                    Else
                        If Me.grd包装.Rows.VisibleRowCount < intRow Then
                            intRow = 0
                        ElseIf Me.grd包装.Rows.VisibleRowCount = intRow Then
                            intRow = Me.grd包装.Rows.VisibleRowCount - 1
                        End If
                    End If

                    Me.grd包装.Rows.GetRowAtVisibleIndex(intRow).Cells(0).Activated = True
                    Me.grd包装.Rows.GetRowAtVisibleIndex(intRow).Cells(0).Selected = True
                    Me.grd包装.PerformAction(UltraWinGrid.UltraGridAction.EnterEditMode)

            End Select

        Catch ex As Exception
            '異常処理
            EXHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnF12关闭_Click(sender As Object, e As EventArgs) Handles btnF12关闭.Click
        Try

            Me.Close()

        Catch ex As Exception
            EXHelper.ProcessEx(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Private Event"

    Public Sub SetCombox()

        Utility.SetCombo(cbo客户区分, "区分", "名称", "VM客户分类", 1, "", "CAST(区分 AS INT)")

    End Sub

    Public Sub InitForm()

        '画面控件内容清空
        txt客户编号.Text = ""
        txt客户编号.ReadOnly = False

        txt客户名称.Text = ""
        txt英文名称.Text = ""
        cbo客户区分.Value = DBNull.Value
        txt邮政编码.Text = ""
        txt所在区域.Text = ""
        txt公司地址.Text = ""
        txt详细地址.Text = ""
        txt电话号码.Text = ""
        txt传真号码.Text = ""

        '画面模式：新增模式
        Z_FormMode = Constant.ENU_FORMMODE.ModeNew
        'grid 初始化
        InitGrid()
        'Focus設置
        txt客户编号.Select()

    End Sub

    Public Sub InitGrid()

        mDt负责 = New DataTable
        mDt负责.Columns.Add("部门")
        mDt负责.Columns.Add("负责人")
        mDt负责.Columns.Add("电话")
        mDt负责.Columns.Add("传真")
        mDt负责.Columns.Add("邮件")
       
        Utility.SetGridName(mDt负责, grd负责)

        mDt包装 = New DataTable
        mDt包装.Columns.Add("包装编号")
        mDt包装.Columns.Add("零件号")
        mDt包装.Columns.Add("零件名")
        mDt包装.Columns.Add("车型")
        mDt包装.Columns.Add("内包装数量", GetType(Decimal))
        mDt包装.Columns.Add("外包装数量", GetType(Decimal))
        mDt包装.Columns.Add("外包装规格")
        mDt包装.Columns.Add("包装物重量", GetType(Decimal))
        mDt包装.Columns.Add("最大码垛层", GetType(Decimal))

        Utility.SetGridName(mDt包装, grd包装)
        Me.grd负责.DisplayLayout.Override.AllowAddNew = AllowAddNew.No
        Me.grd包装.DisplayLayout.Override.AllowAddNew = AllowAddNew.No

    End Sub

    Public Sub GetDoubleGridData()

        Dim str客户编号 As String = txt客户编号.Text.Trim
        Dim objBll客户 As New Bll客户详细
        Dim dsReturn As New DataSet
        Dim objM_客户详细T As New M_客户详细T
        objM_客户详细T.客户编号 = txt客户编号.Text.Trim

        dsReturn = objBll客户.GetDoubleGridData(objM_客户详细T)

        mDt负责 = dsReturn.Tables(0)
        mDt包装 = dsReturn.Tables(1)

        Utility.SetGridName(mDt负责, grd负责)
        Utility.SetGridName(mDt包装, grd包装)

    End Sub

    Private Function CheckInput() As Boolean

        '必填项检查
        '客户编号
        If txt客户编号.Text.Trim = String.Empty Then
            CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "客户编号", "客户编号")
            txt客户编号.Focus()
            Return False
        End If

        '客户名
        If txt客户名称.Text.Trim = String.Empty Then
            CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "客户名", "客户名")
            txt客户名称.Focus()
            Return False
        End If

        ''客户区分
        'If cbo客户区分.Text.Trim = String.Empty Then
        '    CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "客户区分", "客户区分")
        '    cbo客户区分.Focus()
        '    Return False
        'End If

        If grd负责.Rows.Count > 0 Then
            For loopi As Integer = 0 To grd负责.Rows.Count - 1
                If grd负责.Rows(loopi).Cells(0).Value.ToString = "" Then
                    CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "部门")
                    grd负责.Rows(loopi).Cells(0).Activate()
                    grd负责.PerformAction(UltraWinGrid.UltraGridAction.EnterEditMode)
                    Return False
                End If
            Next
        End If

        If grd包装.Rows.Count > 0 Then
            For loopi As Integer = 0 To grd包装.Rows.Count - 1
                If grd包装.Rows(loopi).Cells(0).Value.ToString = "" Then
                    CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "包装编号")
                    grd包装.Rows(loopi).Cells(0).Activate()
                    grd包装.PerformAction(UltraWinGrid.UltraGridAction.EnterEditMode)
                    Return False
                End If
            Next
        End If

        If grd包装.Rows.Count > 0 Then
            For loopi As Integer = 0 To grd包装.Rows.Count - 1
                If loopi <> grd包装.Rows.Count - 1 Then
                    For loopj As Integer = loopi + 1 To grd包装.Rows.Count - 1
                        If grd包装.Rows(loopi).Cells(0).Value.ToString = grd包装.Rows(loopj).Cells(0).Value.ToString Then
                            CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "包装编号")
                            grd包装.Rows(loopj).Cells(0).Activate()
                            grd包装.PerformAction(UltraWinGrid.UltraGridAction.EnterEditMode)
                            Return False
                        End If
                    Next
                End If
            Next
        End If

        Return True

    End Function

    Private Function SaveData() As Boolean

        Dim objM_客户详细T As New M_客户详细T
        Dim objM_客户联系人T As New M_客户联系人T
        Dim objArrList客户联系人 As New ArrayList
        Dim objM_包装方式T As New M_客户包装方式T
        Dim objArrList客户包装 As New ArrayList
        Dim objBll As New Bll客户详细

        objM_客户详细T.客户编号 = txt客户编号.Text
        objM_客户详细T.客户名称 = txt客户名称.Text
        objM_客户详细T.英文名称 = txt英文名称.Text
        objM_客户详细T.客户区分 = cbo客户区分.Value
        objM_客户详细T.邮政编码 = txt邮政编码.Text
        objM_客户详细T.公司地址 = txt公司地址.Text
        objM_客户详细T.所在区域 = txt所在区域.Text
        objM_客户详细T.详细地址 = txt详细地址.Text
        objM_客户详细T.公司电话 = txt电话号码.Text
        objM_客户详细T.传真 = txt传真号码.Text
        objM_客户详细T.使用状态 = 0

        If grd负责.Rows IsNot Nothing AndAlso grd负责.Rows.Count > 0 Then
            For loopi As Integer = 0 To grd负责.Rows.Count - 1
                objM_客户联系人T = New M_客户联系人T
                objM_客户联系人T.客户编号 = txt客户编号.Text
                objM_客户联系人T.传真 = grd负责.Rows(loopi).Cells("传真").Value.ToString
                objM_客户联系人T.负责人 = grd负责.Rows(loopi).Cells("负责人").Value.ToString
                objM_客户联系人T.负责人电话 = grd负责.Rows(loopi).Cells("电话").Value.ToString
                objM_客户联系人T.负责人所在部门 = grd负责.Rows(loopi).Cells("部门").Value.ToString
                objM_客户联系人T.邮箱地址 = grd负责.Rows(loopi).Cells("邮件").Value.ToString
                objArrList客户联系人.Add(objM_客户联系人T)
            Next
        End If

        If grd包装.Rows IsNot Nothing AndAlso grd包装.Rows.Count > 0 Then
            For loopi As Integer = 0 To grd包装.Rows.Count - 1
                objM_包装方式T = New M_客户包装方式T
                objM_包装方式T.包装编号 = grd包装.Rows(loopi).Cells("包装编号").Value.ToString
                objM_包装方式T.包装物重量 = grd包装.Rows(loopi).Cells("包装物重量").Value.ToString
                objM_包装方式T.车型 = grd包装.Rows(loopi).Cells("车型").Value.ToString
                objM_包装方式T.客户编号 = txt客户编号.Text
                objM_包装方式T.零件号 = grd包装.Rows(loopi).Cells("零件号").Value.ToString
                objM_包装方式T.内包装数量 = grd包装.Rows(loopi).Cells("内包装数量").Value.ToString
                objM_包装方式T.使用状态 = 0
                objM_包装方式T.外包装规格 = grd包装.Rows(loopi).Cells("外包装规格").Value.ToString
                objM_包装方式T.外包装数量 = grd包装.Rows(loopi).Cells("外包装数量").Value.ToString
                objM_包装方式T.最大码垛层数 = grd包装.Rows(loopi).Cells("最大码垛层").Value.ToString
                objArrList客户包装.Add(objM_包装方式T)
            Next
        End If
        objM_客户详细T.集合客户联系人 = objArrList客户联系人
        objM_客户详细T.集合客户包装 = objArrList客户包装
        '新增模式：插入数据Insert
        If Z_FormMode = Constant.ENU_FORMMODE.ModeNew Then

            '保存到DB
            If objBll.DoInsert(objM_客户详细T) = Constant.ENU_RETURNTYPE.KeyRepeat Then

                CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID20)
                txt客户编号.Focus()
                Return False
            End If

            '编辑模式：更新数据Update
        ElseIf Z_FormMode = Constant.ENU_FORMMODE.ModeEdit Then

            objBll.DoUpdate(objM_客户详细T)

        End If

        Return True

    End Function

    Public Sub SetPermission()

        ''画面モード
        'Select Case Z_FormMode

        '    '新規
        '    Case Constant.ENU_FORMMODE.ModeNew

        '        'F4削除ボタン
        '        btnF4.Enabled = Utility.GetPermission(Constant.cgStrPerm_客户查询_削除, Me.Z_DtPermission)

        '        'F6新規ボタン
        '        btnF6.Enabled = Utility.GetPermission(Constant.cgStrPerm_客户查询_新規, Me.Z_DtPermission)

        '        '更新
        '    Case Constant.ENU_FORMMODE.ModeEdit

        '        'F4削除ボタン
        '        btnF4.Enabled = Utility.GetPermission(Constant.cgStrPerm_客户查询_削除, Me.Z_DtPermission)

        '        'F6新規ボタン
        '        btnF6.Enabled = Utility.GetPermission(Constant.cgStrPerm_客户查询_新規, Me.Z_DtPermission)

        'End Select

    End Sub

#End Region

#Region "Grid Event"

    Private Sub grd负责_Enter(sender As Object, e As EventArgs) Handles grd负责.Enter
        mStrActGrid = "负责"
    End Sub

    Private Sub grd包装_Enter(sender As Object, e As EventArgs) Handles grd包装.Enter
        mStrActGrid = "包装"
    End Sub

    Private Sub grd包装_ClickCellButton(sender As Object, e As CellEventArgs) Handles grd包装.ClickCellButton


        Try
            Dim frmSearch As frm完成品信息查询
            Dim dtReturn As New DataTable
            Try

                If grd包装.ActiveCell Is Nothing Then
                    Exit Sub
                End If

                Select Case grd包装.ActiveCell.Column.Key

                    Case "零件号"

                        If Me.grd包装.ActiveRow.Cells("零件号").Activation = Activation.NoEdit Then
                            Exit Sub
                        End If

                        frmSearch = New frm完成品信息查询

                        frmSearch.CD = grd包装.ActiveCell.Text.Trim

                        '零部件の検索画面を開く
                        frmSearch.ShowDialog()

                        If frmSearch.ReturnType = Constant.ENU_SEARCH.SearchMOk Then

                            '画面のデータをセット
                            dtReturn = Utility.GetViewByWhere(" WHERE 零件号=" & Utility.ChangeQuotation(frmSearch.CD), "M_完成品信息详细")

                            If dtReturn.Rows.Count Then
                                '検索画面のデータをセットする
                                Me.grd包装.ActiveRow.Cells("零件号").Value = dtReturn.Rows(0)("零件号")          'CD
                                Me.grd包装.ActiveRow.Cells("零件名").Value = dtReturn.Rows(0)("零件名称")     '名前
                                Me.grd包装.ActiveRow.Cells("车型").Value = dtReturn.Rows(0)("车型")     '名前

                                Me.grd包装.ActiveRow.Cells("零件号").Activated = True
                                grd包装.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)

                            End If

                        End If

                        '検索画面を解放する
                        frmSearch.Dispose()
                        frmSearch = Nothing

                        'カーソルをリリース
                        Me.Cursor = Cursors.Default
                End Select

            Catch ex As Exception
                '異常処理
                EXHelper.ProcessEx(ex)
            Finally
                'デフォルトのカーソル
                Me.Cursor = Cursors.Default
            End Try

        Catch ex As Exception
            '異常処理
            EXHelper.ProcessEx(ex)
        End Try
    End Sub

    Private Sub grd包装_BeforeCellDeactivate(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles grd包装.BeforeCellDeactivate
        Dim dtReturn As New DataTable
        'Dim objBll As New BllM零部件T
        Dim dt As New DataTable

        Try
            If Me.grd包装.Rows.Count = 0 Then
                Exit Sub
            End If

            If Me.grd包装.ActiveRow Is Nothing Then
                Exit Sub
            End If

            If Me.grd包装.ActiveCell Is Nothing Then
                Exit Sub
            End If

            Select Case Me.grd包装.ActiveCell.Column.Key

                Case "零件号"

                    If Me.grd包装.ActiveRow.Cells("零件号").Activation = Activation.NoEdit Then
                        Exit Sub
                    End If

                    If Me.grd包装.ActiveRow.Cells("零件号").Text.Trim = String.Empty Then
                        Me.grd包装.ActiveRow.Cells("零件名").Value = String.Empty
                        Me.grd包装.ActiveRow.Cells("车型").Value = String.Empty
                        Exit Sub
                    End If

                    'objCls.零部件CD = Me.grd包装.ActiveRow.Cells(ENU_GRID.零部件编号).Text.Trim
                    dtReturn = Utility.GetViewByWhere(" WHERE 零件号=" & Utility.ChangeQuotation(grd包装.ActiveRow.Cells("零件号").Text.Trim), "M_完成品信息详细")

                    If dtReturn Is Nothing OrElse dtReturn.Rows.Count = 0 Then
                        'e.Cancel = True
                        Me.grd包装.ActiveRow.Cells("零件号").Value = String.Empty
                        Me.grd包装.ActiveRow.Cells("零件名").Value = String.Empty
                        Me.grd包装.ActiveRow.Cells("车型").Value = String.Empty
                        'grd包装.ActiveRow.Cells("零件号").Activate()
                        'grd包装.PerformAction(UltraWinGrid.UltraGridAction.EnterEditMode)
                        Exit Sub
                    Else
                        Me.grd包装.ActiveRow.Cells("零件名").Value = dtReturn.Rows(0).Item("零件名称").ToString
                        Me.grd包装.ActiveRow.Cells("车型").Value = dtReturn.Rows(0).Item("车型").ToString
                    End If

            End Select

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            '異常処理
            EXHelper.ProcessEx(ex)
        End Try
    End Sub

    Private Sub grd包装_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles grd包装.Validating
        Dim dtReturn As New DataTable
        'Dim objBll As New BllM零部件T
        Dim dt As New DataTable

        Try
            If Me.grd包装.Rows.Count = 0 Then
                Exit Sub
            End If

            If Me.grd包装.ActiveRow Is Nothing Then
                Exit Sub
            End If

            If Me.grd包装.ActiveCell Is Nothing Then
                Exit Sub
            End If

            Select Case Me.grd包装.ActiveCell.Column.Key

                Case "零件号"

                    If Me.grd包装.ActiveRow.Cells("零件号").Activation = Activation.NoEdit Then
                        Exit Sub
                    End If

                    If Me.grd包装.ActiveRow.Cells("零件号").Text.Trim = String.Empty Then
                        Me.grd包装.ActiveRow.Cells("零件名").Value = String.Empty
                        Me.grd包装.ActiveRow.Cells("车型").Value = String.Empty
                        Exit Sub
                    End If

                    'objCls.零部件CD = Me.grd包装.ActiveRow.Cells(ENU_GRID.零部件编号).Text.Trim
                    dtReturn = Utility.GetViewByWhere(" WHERE 零件号=" & Utility.ChangeQuotation(grd包装.ActiveRow.Cells("零件号").Text.Trim), "M_完成品信息详细")

                    If dtReturn Is Nothing OrElse dtReturn.Rows.Count = 0 Then
                        'e.Cancel = True
                        Me.grd包装.ActiveRow.Cells("零件号").Value = String.Empty
                        Me.grd包装.ActiveRow.Cells("零件名").Value = String.Empty
                        Me.grd包装.ActiveRow.Cells("车型").Value = String.Empty
                        'grd包装.ActiveRow.Cells("零件号").Activate()
                        'grd包装.PerformAction(UltraWinGrid.UltraGridAction.EnterEditMode)
                        Exit Sub
                    Else
                        Me.grd包装.ActiveRow.Cells("零件名").Value = dtReturn.Rows(0).Item("零件名称").ToString
                        Me.grd包装.ActiveRow.Cells("车型").Value = dtReturn.Rows(0).Item("车型").ToString
                    End If

            End Select

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            '異常処理
            EXHelper.ProcessEx(ex)
        End Try
    End Sub
#End Region

End Class