Imports System.IO
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Public Class frm人员详细

#Region "変数定義"

    Private Enum ENU_详细 As Integer

        階層 = 0
        表示 = 1
        区分 = 2
        区分1 = 3
        区分2 = 4

    End Enum

#End Region

#Region "常数定義"
    Private mds详细 As DataSet
    Private mdt详细Band0 As DataTable
    Private mdt详细Band1 As DataTable
    Private mdt详细Band2 As DataTable
#End Region

#Region "Form Event"

    Private Sub frm人员详细_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Public Sub 人员查询_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            'Comboxリストを設置する
            SetCombox()

            'フォーム初期化
            InitForm()

            Setgrd()

            SetPermission()

        Catch ex As Exception
            EXHelper.ProcessEx(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Public Sub 人员查询_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

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
            Dim objFrm As New frm人员查询
            Dim dtM_部门详细T As New DataTable
            objFrm.ShowDialog()

            If objFrm.ReturnType = Constant.ENU_SEARCH.SearchMOk Then

                '画面模式：修改模式，主键不可编辑
                Z_FormMode = Constant.ENU_FORMMODE.ModeEdit

                txt人员编号.ReadOnly = True

                txt人员编号.Text = objFrm.CD

                Dim dtTemp As DataTable = Utility.GetViewByKey("人员编号", objFrm.CD, "M_人员详细")

                If dtTemp.Rows.Count > 0 Then
                    txt人员名.Text = dtTemp.Rows(0).Item("人员名").ToString
                    txt密码.Text = dtTemp.Rows(0).Item("密码").ToString
                    txt部门编号.Text = dtTemp.Rows(0).Item("所属部门").ToString
                    If Me.txt部门编号.Text.Trim <> String.Empty Then

                        Dim strName As String = ""

                        dtM_部门详细T = Utility.GetViewByWhere(" WHERE 部门编号=" & Utility.ChangeQuotation(txt部门编号.Text.Trim), "M_部门明细")

                        If dtM_部门详细T.Rows.Count <> 0 Then

                            Me.txt部门名称.Text = dtM_部门详细T.Rows(0).Item("部门名称").ToString
                        Else
                            Me.txt部门名称.Text = String.Empty
                        End If
                    Else
                        Me.txt部门名称.Text = String.Empty
                    End If
                    txt工程编号.Text = dtTemp.Rows(0).Item("工程编号").ToString
                    If Me.txt工程编号.Text.Trim <> String.Empty Then

                        Dim strName As String = ""

                        Dim dtM_工程详细T As DataTable = Utility.GetViewByWhere(" WHERE 工程编号=" & Utility.ChangeQuotation(txt工程编号.Text.Trim), "M_工程信息详细")

                        If dtM_工程详细T.Rows.Count <> 0 Then

                            Me.txt工程名称.Text = dtM_工程详细T.Rows(0).Item("工程名").ToString
                        Else
                            Me.txt工程名称.Text = String.Empty
                        End If
                    Else
                        Me.txt工程名称.Text = String.Empty
                    End If
                    cbo在职状态.Value = dtTemp.Rows(0).Item("在职状态").ToString
                    txt电话号码.Text = dtTemp.Rows(0).Item("电话号码").ToString()
                    dtm入职时间.Value = IIf(dtTemp.Rows(0).Item("入职时间").ToString() = "", Nothing, dtTemp.Rows(0).Item("入职时间"))
                    Setgrd()
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
            Setgrd()
        Catch ex As Exception
            EXHelper.ProcessEx(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnF4删除_Click(sender As Object, e As EventArgs) Handles btnF4删除.Click

        Dim objM_人员详细T As M_人员详细T
        Dim objBll As Bll人员详细

        Try

            If Z_FormMode = Constant.ENU_FORMMODE.ModeNew Then
                Return
            End If

            Me.Cursor = Cursors.WaitCursor

            '削除確認メッセージを表示。（MsgID：103）
            If CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
                Exit Sub
            End If

            objM_人员详细T = New M_人员详细T
            objBll = New Bll人员详细

            objM_人员详细T.人员编号 = txt人员编号.Text

            objBll.DoDelete(objM_人员详细T)

            CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID11, "削除")

            InitForm()

            Setgrd()

        Catch ex As Exception
            EXHelper.ProcessEx(ex)
        Finally
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

    Private Sub btnAllSelect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAllSelect.Click

        Dim i As Integer
        Dim j As Integer
        Dim k As Integer

        Try
            Me.Cursor = Cursors.WaitCursor

            For i = 0 To grdList.Rows.Count - 1
                grdList.Rows(i).Cells(ENU_详细.表示).Value = "TRUE"

                For j = 0 To grdList.Rows(i).ChildBands(0).Rows.Count - 1
                    grdList.Rows(i).ChildBands(0).Rows(j).Cells(ENU_详细.表示).Value = "TRUE"

                    For k = 0 To grdList.Rows(i).ChildBands(0).Rows(j).ChildBands(0).Rows.Count - 1
                        grdList.Rows(i).ChildBands(0).Rows(j).ChildBands(0).Rows(k).Cells(ENU_详细.表示).Value = "TRUE"
                    Next
                Next

            Next

            grdList.UpdateData()
        Catch ex As Exception
            '異常処理
            EXHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnAllRelieve_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAllRelieve.Click

        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Try
            Me.Cursor = Cursors.WaitCursor

            For i = 0 To grdList.Rows.Count - 1
                grdList.Rows(i).Cells(ENU_详细.表示).Value = "FALSE"

                For j = 0 To grdList.Rows(i).ChildBands(0).Rows.Count - 1
                    grdList.Rows(i).ChildBands(0).Rows(j).Cells(ENU_详细.表示).Value = "FALSE"

                    For k = 0 To grdList.Rows(i).ChildBands(0).Rows(j).ChildBands(0).Rows.Count - 1
                        grdList.Rows(i).ChildBands(0).Rows(j).ChildBands(0).Rows(k).Cells(ENU_详细.表示).Value = "FALSE"
                    Next
                Next

            Next

            grdList.UpdateData()

        Catch ex As Exception
            '異常処理
            EXHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

#End Region

#Region "Private Event"

    Public Sub SetCombox()

        Utility.SetCombo(cbo在职状态, "区分", "名称", "VM在职状态", 1, "", "CAST(区分 AS INT)")

    End Sub

    Public Sub InitForm()

        '画面控件内容清空
        txt人员编号.Text = ""
        txt人员编号.ReadOnly = False
        txt人员名.Text = ""
        txt密码.Text = ""
        txt部门编号.Text = ""
        txt部门名称.Text = ""
        txt工程编号.Text = ""
        txt工程名称.Text = ""
        cbo在职状态.Value = Nothing
        txt电话号码.Text = ""
        dtm入职时间.Value = Nothing

        '画面模式：新增模式
        Z_FormMode = Constant.ENU_FORMMODE.ModeNew

        'Focus設置
        txt人员编号.Select()

    End Sub

    Private Sub Setgrd()

        Try

            Dim objM_人员详细T As New M_人员详细T
            Dim objBll As New Bll人员详细

            objM_人员详细T.人员编号 = txt人员编号.Text.Trim

            Me.grdList.DataSource = Nothing

            mds详细 = New DataSet

            'mdt详细Band0データを記録テーブル初期化
            Me.mdt详细Band0 = New DataTable
            mdt详细Band0 = objBll.Select详细Band0(objM_人员详细T)

            'mdt详细Band1データを記録テーブル初期化
            Me.mdt详细Band1 = New DataTable
            Me.mdt详细Band1 = New DataTable
            mdt详细Band1 = objBll.Select详细Band1(objM_人员详细T)

            'mdt详细Band2データを記録テーブル初期化
            Me.mdt详细Band2 = New DataTable
            Me.mdt详细Band2 = New DataTable
            mdt详细Band2 = objBll.Select详细Band2(objM_人员详细T)

            ''------------------------------------------

            Dim parentCols() As DataColumn
            Dim childCols() As DataColumn
            Dim drBand(2) As DataRelation

            mds详细 = New DataSet
            'DataSetの親子関係を設定
            mds详细.Relations.Clear()

            '親、子のテーブルを追加
            mdt详细Band0.TableName = "详细Band0"
            mds详细.Tables.Add(mdt详细Band0)

            mdt详细Band1.TableName = "详细Band1"
            mds详细.Tables.Add(mdt详细Band1)

            mdt详细Band2.TableName = "详细Band2"
            mds详细.Tables.Add(mdt详细Band2)

            ReDim parentCols(0)
            ReDim childCols(0)
            parentCols(0) = mds详细.Tables(0).Columns("区分1")
            childCols(0) = mds详细.Tables(1).Columns("区分1")
            drBand(0) = New DataRelation("階層", parentCols, childCols, False)
            mds详细.Relations.Add(drBand(0))

            ReDim parentCols(1)
            ReDim childCols(1)
            parentCols(0) = mds详细.Tables(1).Columns("区分1")
            childCols(0) = mds详细.Tables(2).Columns("区分1")

            parentCols(1) = mds详细.Tables(1).Columns("区分2")
            childCols(1) = mds详细.Tables(2).Columns("区分2")

            drBand(1) = New DataRelation("表示", parentCols, childCols, False)
            mds详细.Relations.Add(drBand(1))

            Me.grdList.DataSource = mds详细
            grdList.Refresh()

        Catch ex As Exception
            '異常処理
            EXHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function CheckInput() As Boolean

        '必填项检查
        '人员编号
        If txt人员编号.Text.Trim = String.Empty Then
            CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "人员编号", "人员编号")
            txt人员编号.Focus()
            Return False
        End If

        '人员名
        If txt人员名.Text.Trim = String.Empty Then
            CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "人员名", "人员名")
            txt人员名.Focus()
            Return False
        End If

        '密码
        If txt密码.Text.Trim = String.Empty Then
            CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "密码", "密码")
            txt密码.Focus()
            Return False
        End If

        '部门
        If txt部门编号.Text.Trim = String.Empty Then
            CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "部门", "部门")
            txt部门编号.Focus()
            Return False
        End If
        '工程
        If txt工程编号.Text.Trim = String.Empty Then
            CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "工程", "工程")
            txt工程编号.Focus()
            Return False
        End If

        '在职状态
        If cbo在职状态.Text.Trim = String.Empty Then
            CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "在职状态", "在职状态")
            cbo在职状态.Focus()
            Return False
        End If

        '电话号码
        If txt电话号码.Text.Trim = String.Empty Then
            CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "电话号码", "电话号码")
            txt电话号码.Focus()
            Return False
        End If

        '入职时间
        If dtm入职时间.Value Is Nothing Then
            CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "入职时间", "入职时间")
            dtm入职时间.Focus()
            Return False
        End If

        '部门
        If txt部门名称.Text.Trim = String.Empty Then
            CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "部门", "部门")
            txt部门编号.Focus()
            Return False
        End If
        '部门
        If txt工程名称.Text.Trim = String.Empty Then
            CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "工程", "工程")
            txt工程名称.Focus()
            Return False
        End If
        Return True

    End Function

    Private Function SaveData() As Boolean

        Dim objM_人员详细T As New M_人员详细T
        Dim objBll As New Bll人员详细
        Dim objM_人员权限T As M_人员权限T
        Dim arr人员权限 As New ArrayList
        objM_人员详细T.人员编号 = txt人员编号.Text
        objM_人员详细T.人员名 = txt人员名.Text
        objM_人员详细T.在职状态 = cbo在职状态.Value
        objM_人员详细T.密码 = txt密码.Text
        objM_人员详细T.所属部门 = txt部门编号.Text
        objM_人员详细T.工程编号 = txt工程编号.Text
        objM_人员详细T.电话号码 = txt电话号码.Text
        objM_人员详细T.入职时间 = dtm入职时间.Value

        For intLoopi = 0 To grdList.Rows.Count - 1

            If grdList.Rows(intLoopi).Cells(ENU_详细.表示).Value.ToString.ToUpper = "TRUE" Then

                objM_人员权限T = New M_人员权限T
                objM_人员权限T.员工编号 = txt人员编号.Text.Trim
                objM_人员权限T.权限区分 = grdList.Rows(intLoopi).Cells(ENU_详细.区分).Value.ToString.Trim

                arr人员权限.Add(objM_人员权限T)

            End If

            For intLoopj = 0 To grdList.Rows(intLoopi).ChildBands(0).Rows.Count - 1

                If grdList.Rows(intLoopi).ChildBands(0).Rows(intLoopj).Cells(ENU_详细.表示).Value.ToString.ToUpper = "TRUE" Then

                    objM_人员权限T = New M_人员权限T
                    objM_人员权限T.员工编号 = txt人员编号.Text.Trim
                    objM_人员权限T.权限区分 = grdList.Rows(intLoopi).ChildBands(0).Rows(intLoopj).Cells(ENU_详细.区分).Value.ToString.Trim

                    arr人员权限.Add(objM_人员权限T)

                End If

                For intLoopk = 0 To grdList.Rows(intLoopi).ChildBands(0).Rows(intLoopj).ChildBands(0).Rows.Count - 1

                    If grdList.Rows(intLoopi).ChildBands(0).Rows(intLoopj).ChildBands(0).Rows(intLoopk).Cells(ENU_详细.表示).Value.ToString.ToUpper = "TRUE" Then

                        objM_人员权限T = New M_人员权限T
                        objM_人员权限T.员工编号 = txt人员编号.Text.Trim
                        objM_人员权限T.权限区分 = grdList.Rows(intLoopi).ChildBands(0).Rows(intLoopj).ChildBands(0).Rows(intLoopk).Cells(ENU_详细.区分).Value.ToString.Trim

                        arr人员权限.Add(objM_人员权限T)

                    End If
                Next intLoopk

            Next intLoopj

        Next intLoopi

        '新增模式：插入数据Insert
        If Z_FormMode = Constant.ENU_FORMMODE.ModeNew Then

            '保存到DB
            If objBll.DoInsert(objM_人员详细T, arr人员权限) = Constant.ENU_RETURNTYPE.KeyRepeat Then

                CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID20)
                txt人员编号.Focus()
                Return False
            End If

            '编辑模式：更新数据Update
        ElseIf Z_FormMode = Constant.ENU_FORMMODE.ModeEdit Then

            objBll.DoUpdate(objM_人员详细T, arr人员权限)

        End If

        Return True

    End Function

    Public Sub SetPermission()

        ''画面モード
        'Select Case Z_FormMode

        '    '新規
        '    Case Constant.ENU_FORMMODE.ModeNew

        '        'F4削除ボタン
        '        btnF4.Enabled = Utility.GetPermission(Constant.cgStrPerm_人员查询_削除, Me.Z_DtPermission)

        '        'F6新規ボタン
        '        btnF6.Enabled = Utility.GetPermission(Constant.cgStrPerm_人员查询_新規, Me.Z_DtPermission)

        '        '更新
        '    Case Constant.ENU_FORMMODE.ModeEdit

        '        'F4削除ボタン
        '        btnF4.Enabled = Utility.GetPermission(Constant.cgStrPerm_人员查询_削除, Me.Z_DtPermission)

        '        'F6新規ボタン
        '        btnF6.Enabled = Utility.GetPermission(Constant.cgStrPerm_人员查询_新規, Me.Z_DtPermission)

        'End Select

    End Sub

    Private Sub SetGridStyle()
        Try

            With grdList.DisplayLayout.Bands(0)

                .Columns(ENU_详细.階層).Width = 103
                .Columns(ENU_详细.階層).CellActivation = Activation.NoEdit
                .Columns(ENU_详细.階層).CellAppearance.BackColor = Color.Silver
                .Columns(ENU_详细.階層).TabStop = False
                .Columns(ENU_详细.表示).Width = 38
                .Columns(ENU_详细.表示).Style = ColumnStyle.CheckBox
                .Columns(ENU_详细.区分).Hidden = True
                .Columns(ENU_详细.区分1).Hidden = True
            End With

            With grdList.DisplayLayout.Bands(1)

                .Columns(ENU_详细.階層).Width = 103
                .Columns(ENU_详细.階層).CellActivation = Activation.NoEdit
                .Columns(ENU_详细.階層).CellAppearance.BackColor = Color.Silver
                .Columns(ENU_详细.階層).TabStop = False
                .Columns(ENU_详细.表示).Width = 38
                .Columns(ENU_详细.表示).Style = ColumnStyle.CheckBox
                .Columns(ENU_详细.区分).Hidden = True
                .Columns(ENU_详细.区分1).Hidden = True
                .Columns(ENU_详细.区分2).Hidden = True

            End With

            With grdList.DisplayLayout.Bands(2)

                .Columns(ENU_详细.階層).Width = 94
                .Columns(ENU_详细.階層).CellActivation = Activation.NoEdit
                .Columns(ENU_详细.階層).CellAppearance.BackColor = Color.Silver
                .Columns(ENU_详细.階層).TabStop = False
                .Columns(ENU_详细.表示).Width = 38
                .Columns(ENU_详细.表示).Style = ColumnStyle.CheckBox
                .Columns(ENU_详细.区分).Hidden = True
                .Columns(ENU_详细.区分1).Hidden = True
                .Columns(ENU_详细.区分2).Hidden = True

            End With

        Catch ex As Exception
            '異常処理
            EXHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Sub SetCellFocus(ByVal intCellRowIndex As Integer, _
                               ByVal intCellColumnIndex As Integer, _
                               Optional ByVal intBandIndex As Integer = 0, _
                               Optional ByVal intChildCellRowIndex As Integer = 0, _
                               Optional ByVal intChildChildCellRowIndex As Integer = 0)
        '全て事件は使用不可をセットする
        grdList.EventManager.AllEventsEnabled = False

        ''進入事件フラグは使用不可をセットする
        'grdList.mblnEnterEventFLG = False

        'グリッドのプッカスをセットする
        grdList.Focus()

        '全て事件は使用可をセットする
        grdList.EventManager.AllEventsEnabled = True

        '有効行を判断する
        If grdList.Rows.Count > 0 Then
            '多層を判断する
            If intBandIndex = 0 Then
                '一層のセルをセットする
                grdList.ActiveCell = grdList.Rows(intCellRowIndex).Cells(intCellColumnIndex)
            ElseIf intBandIndex = 1 Then
                '多層の有効行を判断する
                If grdList.Rows(intCellRowIndex).ChildBands(0).Rows.Count > 0 Then
                    '多層のセルをセットする
                    grdList.ActiveCell = grdList.Rows(intCellRowIndex).ChildBands(0).Rows(intChildCellRowIndex).Cells(intCellColumnIndex)
                Else
                    '多層の新規行をセットする
                    grdList.ActiveCell = grdList.Rows(intCellRowIndex).ChildBands(0).Rows.TemplateAddRow.Cells(intCellColumnIndex)
                End If
            ElseIf intBandIndex = 2 Then
                '多層の有効行を判断する
                If grdList.Rows(intCellRowIndex).ChildBands(0).Rows(intChildCellRowIndex).ChildBands(0).Rows.Count > 0 Then
                    '多層のセルをセットする
                    grdList.ActiveCell = grdList.Rows(intCellRowIndex).ChildBands(0).Rows(intChildCellRowIndex).ChildBands(0). _
                                       Rows(intChildChildCellRowIndex).Cells(intCellColumnIndex)
                Else
                    '多層の新規行をセットする
                    grdList.ActiveCell = grdList.Rows(intCellRowIndex).ChildBands(0).Rows(intChildCellRowIndex).ChildBands(0). _
                                       Rows.TemplateAddRow.Cells(intCellColumnIndex)
                End If
            End If
        Else
            '新規行をセットする
            grdList.ActiveCell = grdList.Rows.TemplateAddRow.Cells(intCellColumnIndex)
        End If

        'プッカスをセットする
        grdList.BeginInvoke(New Windows.Forms.MethodInvoker(AddressOf SetEnterEditMode))

        'grdList.mblnEnterEventFLG = True
    End Sub

    Private Sub SetEnterEditMode()
        grdList.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
    End Sub

#End Region

#Region "Control Event"

#Region "工程"

    Private Sub txt工程_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt工程编号.Enter

        Try

            Me.txt工程编号.Tag = Me.txt工程编号.Text.Trim

        Catch ex As Exception
            '異常処理
            EXHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt工程_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt工程编号.Validating

        Dim objReturn As New DataTable
        Try

            If txt工程编号.ReadOnly Then
                Exit Sub
            End If

            If Me.txt工程编号.Tag = Me.txt工程编号.Text.Trim Then
                Exit Sub
            End If

            If Me.txt工程编号.Text.Trim <> String.Empty Then

                objReturn = Utility.GetViewByWhere(" WHERE 工程编号=" & Utility.ChangeQuotation(txt工程编号.Text.Trim), "M_工程信息详细")

                If objReturn.Rows.Count <> 0 Then

                    Me.txt工程名称.Text = objReturn.Rows(0).Item("工程名").ToString
                Else
                    Me.txt工程名称.Text = String.Empty
                End If

                If objReturn.Rows.Count <> 0 Then

                    Me.txt工程名称.Text = objReturn.Rows(0).Item("工程名").ToString
                Else
                    Me.txt工程名称.Text = String.Empty
                End If
            Else
                Me.txt工程编号.Text = String.Empty
                Me.txt工程名称.Text = String.Empty
            End If

        Catch ex As Exception
            '異常処理
            EXHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub txt工程_EditorButtonClick(ByVal sender As Object, ByVal e As UltraWinEditors.EditorButtonEventArgs) Handles txt工程编号.EditorButtonClick

        Dim frmSearch As frm工程信息查询

        Try


            frmSearch = New frm工程信息查询

            '发布人信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_SEARCH.SearchMOk Then

                '根据检索画面数据进行设置                txt工程编号.Text = frmSearch.CD

                Dim dtTemp As DataTable = Utility.GetViewByKey("工程编号", frmSearch.CD, "M_工程信息详细")

                If dtTemp.Rows.Count > 0 Then

                    Me.txt工程编号.Text = dtTemp.Rows(0)("工程编号")          '发布人名
                    Me.txt工程名称.Text = dtTemp.Rows(0)("工程名")     '发布人名
                End If

                If Not frmSearch.ReturnTable Is Nothing Then
                    '检索画面释放
                    frmSearch.ReturnTable.Dispose()
                    frmSearch.ReturnTable = Nothing
                End If

                '检索画面释放
                frmSearch.Dispose()
                frmSearch = Nothing

            End If

            '光标设置
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            '异常处理
            EXHelper.ProcessEx(ex)
        Finally
            '默认光标设置
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "部门"

    Private Sub txt部门_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt部门编号.Enter

        Try

            Me.txt部门编号.Tag = Me.txt部门编号.Text.Trim

        Catch ex As Exception
            '異常処理
            EXHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt部门_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt部门编号.Validating

        Dim objReturn As New DataTable
        Try

            If txt部门编号.ReadOnly Then
                Exit Sub
            End If

            If Me.txt部门编号.Tag = Me.txt部门编号.Text.Trim Then
                Exit Sub
            End If

            If Me.txt部门编号.Text.Trim <> String.Empty Then

                objReturn = Utility.GetViewByWhere(" WHERE 部门编号=" & Utility.ChangeQuotation(txt部门编号.Text.Trim), "M_部门明细")

                If objReturn.Rows.Count <> 0 Then

                    Me.txt部门名称.Text = objReturn.Rows(0).Item("部门名称").ToString
                Else
                    Me.txt部门名称.Text = String.Empty
                End If

                If objReturn.Rows.Count <> 0 Then

                    Me.txt部门名称.Text = objReturn.Rows(0).Item("部门名称").ToString
                Else
                    Me.txt部门名称.Text = String.Empty
                End If
            Else
                Me.txt部门编号.Text = String.Empty
                Me.txt部门名称.Text = String.Empty
            End If

        Catch ex As Exception
            '異常処理
            EXHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub txt部门_EditorButtonClick(ByVal sender As Object, ByVal e As UltraWinEditors.EditorButtonEventArgs) Handles txt部门编号.EditorButtonClick

        Dim frmSearch As frm部门查询

        Try


            frmSearch = New frm部门查询

            '发布人信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_SEARCH.SearchMOk Then

                '根据检索画面数据进行设置                txt部门编号.Text = frmSearch.CD

                Dim dtTemp As DataTable = Utility.GetViewByKey("部门编号", frmSearch.CD, "M_部门明细")

                If dtTemp.Rows.Count > 0 Then

                    Me.txt部门编号.Text = dtTemp.Rows(0)("部门编号")          '发布人名
                    Me.txt部门名称.Text = dtTemp.Rows(0)("部门名称")     '发布人名
                End If

                If Not frmSearch.ReturnTable Is Nothing Then
                    '检索画面释放
                    frmSearch.ReturnTable.Dispose()
                    frmSearch.ReturnTable = Nothing
                End If

                '检索画面释放
                frmSearch.Dispose()
                frmSearch = Nothing

            End If

            '光标设置
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            '异常处理
            EXHelper.ProcessEx(ex)
        Finally
            '默认光标设置
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "密码"
    Private Sub txt密码_Leave(sender As Object, e As EventArgs) Handles txt密码.Leave
        Dim strPassword As String = txt密码.Text
        If txt密码.Text <> String.Empty Then
            If txt密码.Text.Length < 6 Then
                For loopi As Integer = 1 To 6 - txt密码.Text.Length
                    strPassword = "0" & strPassword
                Next
            End If
        End If
        txt密码.Text = strPassword
    End Sub
#End Region

#End Region

#Region "grid Event"

    Private Sub grdList_CellChange(ByVal sender As Object, ByVal e As CellEventArgs) Handles grdList.CellChange

        'Dim i As Integer
        Dim j As Integer
        Dim k As Integer

        Try

            If grdList.ActiveCell Is Nothing Then
                Exit Sub
            End If


            '砂時計のカーソルが設定
            Me.Cursor = Cursors.WaitCursor


            Select Case grdList.ActiveCell.Column.Index

                Case ENU_详细.表示

                    Select Case grdList.ActiveCell.Band.Index

                        Case 0

                            For j = 0 To grdList.ActiveRow.ChildBands(0).Rows.Count - 1
                                grdList.ActiveRow.ChildBands(0).Rows(j).Cells(ENU_详细.表示).Value = grdList.ActiveCell.Text

                                For k = 0 To grdList.ActiveRow.ChildBands(0).Rows(j).ChildBands(0).Rows.Count - 1
                                    grdList.ActiveRow.ChildBands(0).Rows(j).ChildBands(0).Rows(k).Cells(ENU_详细.表示).Value = grdList.ActiveCell.Text
                                Next
                            Next

                        Case 1

                            For j = 0 To grdList.ActiveRow.ChildBands(0).Rows.Count - 1
                                grdList.ActiveRow.ChildBands(0).Rows(j).Cells(ENU_详细.表示).Value = grdList.ActiveCell.Text
                            Next

                    End Select

            End Select

        Catch ex As Exception
            '異常処理
            EXHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub grdList_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles grdList.Enter
        Try

            If grdList.ActiveCell Is Nothing Then
                grdList.Rows(0).Cells(ENU_详细.表示).Activate()
                SetCellFocus(grdList.ActiveRow.Index, grdList.ActiveCell.Column.Index)
            End If

        Catch ex As Exception
            '異常処理
            EXHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub grdList_InitializeLayout(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grdList.InitializeLayout
        Try

            grdList.DisplayLayout.TabNavigation = TabNavigation.NextControlOnLastCell
            grdList.DisplayLayout.Override.CellClickAction = CellClickAction.EditAndSelectText
            grdList.DisplayLayout.Appearance.BorderColor = Color.Black
            grdList.DisplayLayout.Appearance.BackColor = Color.Transparent
            grdList.DisplayLayout.ViewStyleBand = ViewStyleBand.OutlookGroupBy
            grdList.DisplayLayout.Override.AllowAddNew = AllowAddNew.No
            SetGridStyle()

        Catch ex As Exception
            '異常処理
            EXHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region


End Class