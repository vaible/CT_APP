Public Class frm消息发布

#Region "変数定義"
    Private mdt As DataTable
    Private mStrCD As String
#End Region

#Region "常数定義"
    Private mStr编号 As String = ""
#End Region

#Region "Form Event"

    Private Sub frm消息发布_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
                            Me.btnF2保存_Click(Nothing, Nothing)
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
                            Me.btnF3删除_Click(Nothing, Nothing)
                        End If
                    Else
                        Me.Cursor = Cursors.Default
                        Exit Sub
                    End If

                    '    'F4：
                    'Case Keys.F4

                    '    If btnF4删除.Enabled Then
                    '        btnF4删除.Focus()
                    '        If btnF4删除.Focused Then
                    '            Me.btnF4删除_Click(Nothing, Nothing)
                    '        End If
                    '    Else
                    '        Me.Cursor = Cursors.Default
                    '        Exit Sub
                    '    End If

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

    Public Sub 消息发布查询_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

    Public Sub 消息发布查询_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

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

            '画面控件内容清空
            dtm适用开始日期.Value = Nothing
            dtm适用结束日期.Value = Nothing
            cbo通知类型.Value = Nothing
            txt发布人编号.Text = ""
            txt发布人名称.Text = ""
            txt通知内容.Text = ""

            '画面模式：新增模式
            Z_FormMode = Constant.ENU_FORMMODE.ModeNew

            'Focus設置
            cbo通知类型.Select()

        Catch ex As Exception
            EXHelper.ProcessEx(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnF2保存_Click(sender As Object, e As EventArgs) Handles btnF2编辑.Click

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

    Private Sub btnF3删除_Click(sender As Object, e As EventArgs) Handles btnF3保存.Click

        Dim objM_消息发布T As M_消息发布T
        Dim objBll As Bll消息发布

        Try

            Me.Cursor = Cursors.WaitCursor
            If Z_FormMode = Constant.ENU_FORMMODE.ModeNew Then
                Return
            End If
            '削除確認メッセージを表示。（MsgID：103）
            If CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
                Exit Sub
            End If

            objM_消息发布T = New M_消息发布T
            objBll = New Bll消息发布

            objM_消息发布T.编号 = mStr编号

            objBll.DoDelete(objM_消息发布T)

            CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID11, "削除")

            InitForm()

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

#End Region

#Region "Private Event"

    Public Sub SetCombox()

        Utility.SetCombo(cbo通知类型, "区分", "名称", "VM通知类型", 1, "", "CAST(区分 AS INT)")

    End Sub

    Public Sub InitForm()

        Dim objBll消息发布 As New Bll消息发布

        '画面控件内容清空
        dtm适用开始日期.Value = Nothing
        dtm适用结束日期.Value = Nothing
        cbo通知类型.Value = Nothing
        txt发布人编号.Text = ""
        txt发布人名称.Text = ""
        txt通知内容.Text = ""

        '画面模式：新增模式
        Z_FormMode = Constant.ENU_FORMMODE.ModeNew

        'Focus設置
        cbo通知类型.Select()
     
        If Not mdt Is Nothing Then
            mdt.Rows.Clear()
        End If



        ''検索データ
        'mdt = Utility.GetViewByWhere("", "T_消息发布")
        mdt = objBll消息发布.GetGridData()

        '結果をGridへセットする
        Utility.SetGridName(mdt, grdList)


    End Sub

    Private Function CheckInput() As Boolean

        '工程类别
        If cbo通知类型.Text.Trim = String.Empty Then
            CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "工程类别", "工程类别")
            cbo通知类型.Focus()
            Return False
        End If

        '发布人
        If txt发布人编号.Text.Trim = String.Empty Then
            CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "发布人", "发布人")
            txt发布人编号.Focus()
            Return False
        End If

        '发布人名称
        If txt发布人名称.Text.Trim = String.Empty Then
            CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "发布人", "发布人")
            txt发布人编号.Focus()
            Return False
        End If

        '适用日期
        If dtm适用结束日期.Value IsNot Nothing AndAlso dtm适用开始日期.Value IsNot Nothing Then
            If dtm适用开始日期.Value > dtm适用结束日期.Value Then
                CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID15, "适用日期", "适用日期")
                dtm适用开始日期.Focus()
                Return False
            End If
        End If

        Return True

    End Function

    Private Function SaveData() As Boolean

        Dim objM_消息发布T As New M_消息发布T
        Dim objBll As New Bll消息发布
        objM_消息发布T.编号 = mStr编号
        objM_消息发布T.通知类型 = cbo通知类型.Value
        objM_消息发布T.适用开始日期 = dtm适用开始日期.Value
        objM_消息发布T.适用结束日期 = dtm适用结束日期.Value
        objM_消息发布T.发布人 = txt发布人编号.Text
        objM_消息发布T.通知内容 = txt通知内容.Text
        objM_消息发布T.发布日期 = Utility.GetDBTime()
        '新增模式：插入数据Insert
        If Z_FormMode = Constant.ENU_FORMMODE.ModeNew Then

            '保存到DB
            If objBll.DoInsert(objM_消息发布T) = Constant.ENU_RETURNTYPE.KeyRepeat Then

                CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID20)
                cbo通知类型.Focus()
                Return False
            End If

            '编辑模式：更新数据Update
        ElseIf Z_FormMode = Constant.ENU_FORMMODE.ModeEdit Then

            objBll.DoUpdate(objM_消息发布T)

        End If

        Return True

    End Function

    Public Sub SetPermission()

        ''画面モード
        'Select Case Z_FormMode

        '    '新規
        '    Case Constant.ENU_FORMMODE.ModeNew

        '        'F4削除ボタン
        '        btnF4.Enabled = Utility.GetPermission(Constant.cgStrPerm_消息发布查询_削除, Me.Z_DtPermission)

        '        'F6新規ボタン
        '        btnF6.Enabled = Utility.GetPermission(Constant.cgStrPerm_消息发布查询_新規, Me.Z_DtPermission)

        '        '更新
        '    Case Constant.ENU_FORMMODE.ModeEdit

        '        'F4削除ボタン
        '        btnF4.Enabled = Utility.GetPermission(Constant.cgStrPerm_消息发布查询_削除, Me.Z_DtPermission)

        '        'F6新規ボタン
        '        btnF6.Enabled = Utility.GetPermission(Constant.cgStrPerm_消息发布查询_新規, Me.Z_DtPermission)

        'End Select

    End Sub

#End Region

#Region "Control Event"

#Region "发布人"

    Private Sub txt发布人_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt发布人编号.Enter

        Try

            Me.txt发布人编号.Tag = Me.txt发布人编号.Text.Trim

        Catch ex As Exception
            '異常処理
            EXHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt发布人_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt发布人编号.Validating

        Dim dtM_人员详细T As DataTable

        Try

            If txt发布人编号.ReadOnly Then
                Exit Sub
            End If

            If Me.txt发布人编号.Tag = Me.txt发布人编号.Text.Trim Then
                Exit Sub
            End If

            If Me.txt发布人编号.Text.Trim <> String.Empty Then

                Dim strName As String = ""

                dtM_人员详细T = Utility.GetViewByWhere(" WHERE 人员编号=" & Utility.ChangeQuotation(txt发布人编号.Text.Trim), "M_人员详细")

                If dtM_人员详细T.Rows.Count <> 0 Then

                    Me.txt发布人名称.Text = dtM_人员详细T.Rows(0).Item("人员名").ToString
                Else
                    Me.txt发布人名称.Text = String.Empty
                End If
            Else
                Me.txt发布人名称.Text = String.Empty
            End If

        Catch ex As Exception
            '異常処理
            EXHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub txt发布人_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt发布人编号.EditorButtonClick

        Dim frmSearch As frm人员查询


        Try

            frmSearch = New frm人员查询

            '发布人信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_SEARCH.SearchMOk Then

                '根据检索画面数据进行设置
                txt发布人编号.Text = frmSearch.CD

                Dim dtTemp As DataTable = Utility.GetViewByKey("人员编号", frmSearch.CD, "M_人员详细")

                If dtTemp.Rows.Count > 0 Then

                    Me.txt发布人编号.Text = dtTemp.Rows(0)("人员编号")          '发布人名

                    Me.txt发布人名称.Text = dtTemp.Rows(0)("人员名")     '发布人名

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


    Private Sub grdList_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grdList.DoubleClickRow
        Try
            Dim dtM_人员详细T As New DataTable
            mStr编号 = grdList.ActiveRow.Cells("编号").Value.ToString

            Dim dtRetrun As DataTable = Utility.GetViewByWhere(" WHERE 编号=" & Utility.ChangeQuotation(mStr编号), "T_消息发布")

            If dtRetrun.Rows.Count > 0 Then
                txt发布人编号.Text = dtRetrun.Rows(0).Item("发布人")
                If Me.txt发布人编号.Text.Trim <> String.Empty Then

                    Dim strName As String = ""

                    dtM_人员详细T = Utility.GetViewByWhere(" WHERE 人员编号=" & Utility.ChangeQuotation(txt发布人编号.Text.Trim), "M_人员详细")

                    If dtM_人员详细T.Rows.Count <> 0 Then

                        Me.txt发布人名称.Text = dtM_人员详细T.Rows(0).Item("人员名").ToString
                    Else
                        Me.txt发布人名称.Text = String.Empty
                    End If
                Else
                    Me.txt发布人名称.Text = String.Empty
                End If

                txt通知内容.Text = dtRetrun.Rows(0).Item("通知内容")
                dtm适用结束日期.Value = IIf(dtRetrun.Rows(0).Item("适用结束日期").ToString = "", Nothing, dtRetrun.Rows(0).Item("适用结束日期"))
                dtm适用开始日期.Value = IIf(dtRetrun.Rows(0).Item("适用开始日期").ToString = "", Nothing, dtRetrun.Rows(0).Item("适用开始日期"))
                cbo通知类型.Value = dtRetrun.Rows(0).Item("通知类型")

                Z_FormMode = Constant.ENU_FORMMODE.ModeEdit
            End If

        Catch ex As Exception
            EXHelper.ProcessEx(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

End Class