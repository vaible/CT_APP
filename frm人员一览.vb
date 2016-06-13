Imports System.IO
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Public Class frm人员查询
#Region "変数定義"

    Private mdt As DataTable
    Private mStrCD As String
    Private mStr名 As String

    Public Property CD() As String
        Get
            Return mStrCD
        End Get
        Set(ByVal value As String)
            mStrCD = value
        End Set
    End Property

    Public Property 名() As String
        Get
            Return mStr名
        End Get
        Set(ByVal value As String)
            mStr名 = value
        End Set
    End Property


#End Region

#Region "常数定義"

    Enum col_Gird

        人员编号 = 0
        人员名 = 1
        人员类别 = 2
        人员类别CD = 3

    End Enum

#End Region

#Region "Form Event"

    Private Sub frm人员查询_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

                    If btnF2查询.Enabled Then
                        btnF2查询.Focus()
                        If btnF2查询.Focused Then
                            Me.btnF2查询_Click(Nothing, Nothing)
                        End If
                    Else
                        Me.Cursor = Cursors.Default
                        Exit Sub
                    End If

                    'F3：
                Case Keys.F3

                    If btnF3选择.Enabled Then
                        btnF3选择.Focus()
                        If btnF3选择.Focused Then
                            Me.btnF3选择_Click(Nothing, Nothing)
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

            If Not Me.Modal Then
                btnF3选择.Visible = False
            End If

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

    Private Sub btnF2查询_Click(sender As Object, e As EventArgs) Handles btnF2查询.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim objM_人员详细T As New M_人员详细T
            Dim objBll As New Bll人员查询

            objM_人员详细T.人员编号 = txt人员编号.Text
            objM_人员详细T.人员名 = txt人员名.Text
            'objM_人员详细T.人员类别 = cbo人员类别.Value
            objM_人员详细T.所属部门 = txt部门编号.Text
            If Not mdt Is Nothing Then
                mdt.Rows.Clear()
            End If

            ''検索データ
            mdt = objBll.GetGridData(objM_人员详细T)

            '結果をGridへセットする
            Utility.SetGridName(mdt, grdlist)

            If mdt.Rows.Count = 0 Then
                CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID16)
                txt人员编号.Focus()
            Else
                grdlist.Focus()
            End If

        Catch ex As Exception
            EXHelper.ProcessEx(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnF3选择_Click(sender As Object, e As EventArgs) Handles btnF3选择.Click
        Try
            If grdlist.ActiveRow Is Nothing Then
                CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                Return
            End If

            mStrCD = grdlist.ActiveRow.Cells(col_Gird.人员编号).Text
            mStr名 = grdlist.ActiveRow.Cells(col_Gird.人员名).Text
            Me.ReturnType = Constant.ENU_SEARCH.SearchMOk
            Me.Close()

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

        'Utility.SetCombo(cbo人员类别, "区分", "名称", "VM人员类别", 1, "", "CAST(区分 AS INT)")

    End Sub

    Public Sub InitForm()

        mdt = New DataTable

        mdt.Columns.Add("人员编号")
        mdt.Columns.Add("人员名")
        mdt.Columns.Add("部门名称")
        mdt.Columns.Add("电话号码")

        Utility.SetGridName(mdt, grdlist)

        '画面控件内容清空
        txt人员名.Text = ""

        txt部门名称.Text = ""

        txt部门编号.Text = ""

        txt人员编号.Text = ""

        'Focus設置
        txt人员编号.Select()

    End Sub

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

#End Region

#Region "Grid Event"
    Private Sub grdList_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grdlist.DoubleClickRow
        Try
            If grdlist.Rows IsNot Nothing AndAlso grdlist.Rows.Count > 0 AndAlso grdlist.ActiveRow IsNot Nothing AndAlso Me.Modal = True Then

                btnF3选择_Click(Nothing, Nothing)

            End If
        Catch ex As Exception
            EXHelper.ProcessEx(ex)
        Finally
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

End Class