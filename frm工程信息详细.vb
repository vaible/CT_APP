Public Class frm工程信息详细

#Region "変数定義"

#End Region

#Region "常数定義"

#End Region

#Region "Form Event"

    Private Sub frm工程信息详细_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Public Sub 工程信息查询_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

    Public Sub 工程信息查询_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

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
            Dim objFrm As New frm工程信息查询

            objFrm.ShowDialog()

            If objFrm.ReturnType = Constant.ENU_SEARCH.SearchMOk Then

                '画面模式：修改模式，主键不可编辑
                Z_FormMode = Constant.ENU_FORMMODE.ModeEdit

                txt工程编号.ReadOnly = True

                txt工程编号.Text = objFrm.CD

                Dim dtTemp As DataTable = Utility.GetViewByKey("工程编号", objFrm.CD, "M_工程信息详细")

                If dtTemp.Rows.Count > 0 Then
                    txt工程名.Text = dtTemp.Rows(0).Item("工程名").ToString
                    cbo工程类别.Value = dtTemp.Rows(0).Item("工程类别").ToString
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

        Dim objM_工程信息详细T As M_工程信息详细T
        Dim objBll As Bll工程信息详细

        Try

            If Z_FormMode = Constant.ENU_FORMMODE.ModeNew Then
                Return
            End If

            Me.Cursor = Cursors.WaitCursor

            '削除確認メッセージを表示。（MsgID：103）
            If CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
                Exit Sub
            End If

            objM_工程信息详细T = New M_工程信息详细T
            objBll = New Bll工程信息详细

            objM_工程信息详细T.工程编号 = txt工程编号.Text

            objBll.DoDelete(objM_工程信息详细T)

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

        Utility.SetCombo(cbo工程类别, "区分", "名称", "VM工程类别", 1, "", "CAST(区分 AS INT)")

    End Sub

    Public Sub InitForm()

        '画面控件内容清空
        txt工程编号.Text = ""
        txt工程编号.ReadOnly = False

        txt工程名.Text = ""
        cbo工程类别.Value = Nothing

        '画面模式：新增模式
        Z_FormMode = Constant.ENU_FORMMODE.ModeNew

        'Focus設置
        txt工程编号.Select()

    End Sub

    Private Function CheckInput() As Boolean

        '必填项检查
        '工程编号
        If txt工程编号.Text.Trim = String.Empty Then
            CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "工程编号", "工程编号")
            txt工程编号.Focus()
            Return False
        End If

        '工程名
        If txt工程名.Text.Trim = String.Empty Then
            CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "工程名", "工程名")
            txt工程名.Focus()
            Return False
        End If

        '工程类别
        If cbo工程类别.Text.Trim = String.Empty Then
            CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "工程类别", "工程类别")
            cbo工程类别.Focus()
            Return False
        End If

        Return True

    End Function

    Private Function SaveData() As Boolean

        Dim objM_工程信息详细T As New M_工程信息详细T
        Dim objBll As New Bll工程信息详细

        objM_工程信息详细T.工程编号 = txt工程编号.Text
        objM_工程信息详细T.工程名 = txt工程名.Text
        objM_工程信息详细T.工程类别 = cbo工程类别.Value
        objM_工程信息详细T.使用状态 = 0

        '新增模式：插入数据Insert
        If Z_FormMode = Constant.ENU_FORMMODE.ModeNew Then

            '保存到DB
            If objBll.DoInsert(objM_工程信息详细T) = Constant.ENU_RETURNTYPE.KeyRepeat Then

                CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID20)
                txt工程编号.Focus()
                Return False
            End If

            '编辑模式：更新数据Update
        ElseIf Z_FormMode = Constant.ENU_FORMMODE.ModeEdit Then

            objBll.DoUpdate(objM_工程信息详细T)

        End If

        Return True

    End Function

    Public Sub SetPermission()

        ''画面モード
        'Select Case Z_FormMode

        '    '新規
        '    Case Constant.ENU_FORMMODE.ModeNew

        '        'F4削除ボタン
        '        btnF4.Enabled = Utility.GetPermission(Constant.cgStrPerm_工程信息查询_削除, Me.Z_DtPermission)

        '        'F6新規ボタン
        '        btnF6.Enabled = Utility.GetPermission(Constant.cgStrPerm_工程信息查询_新規, Me.Z_DtPermission)

        '        '更新
        '    Case Constant.ENU_FORMMODE.ModeEdit

        '        'F4削除ボタン
        '        btnF4.Enabled = Utility.GetPermission(Constant.cgStrPerm_工程信息查询_削除, Me.Z_DtPermission)

        '        'F6新規ボタン
        '        btnF6.Enabled = Utility.GetPermission(Constant.cgStrPerm_工程信息查询_新規, Me.Z_DtPermission)

        'End Select

    End Sub

#End Region

End Class