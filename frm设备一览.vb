Public Class frm设备查询

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

        设备编号 = 0
        设备名称 = 1
        
    End Enum

#End Region

#Region "Form Event"

    Private Sub frm设备查询_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Public Sub 设备查询_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

            Dim objM_设备详细T As New M_设备详细T
            Dim objBll As New Bll设备查询

            objM_设备详细T.设备编号 = txt设备编号.Text
            objM_设备详细T.设备名称 = txt设备名称.Text

            If Not mdt Is Nothing Then
                mdt.Rows.Clear()
            End If

            ''検索データ
            mdt = objBll.GetGridData(objM_设备详细T)

            '結果をGridへセットする
            Utility.SetGridName(mdt, grdList)

            If mdt.Rows.Count = 0 Then
                CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID16)
                txt设备编号.Focus()
            Else
                grdList.Focus()
            End If

        Catch ex As Exception
            EXHelper.ProcessEx(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnF3选择_Click(sender As Object, e As EventArgs) Handles btnF3选择.Click
        Try
            If grdList.ActiveRow Is Nothing Then
                CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                Return
            End If

            mStrCD = grdList.ActiveRow.Cells(col_Gird.设备编号).Text
            mStr名 = grdList.ActiveRow.Cells(col_Gird.设备名称).Text
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

        'Utility.SetCombo(cbo设备类别, "区分", "名称", "VM设备类别", 1, "", "CAST(区分 AS INT)")

    End Sub

    Public Sub InitForm()

        mdt = New DataTable

        mdt.Columns.Add("设备编号")
        mdt.Columns.Add("设备名称")
        mdt.Columns.Add("设备型号")
        mdt.Columns.Add("上次维护周期")
        mdt.Columns.Add("使用状态")

        Utility.SetGridName(mdt, grdList)

        '画面控件内容清空
        txt设备编号.Text = ""
        txt设备名称.Text = ""

        'Focus設置
        txt设备编号.Select()

    End Sub

    Public Sub SetPermission()

        ''画面モード
        'Select Case Z_FormMode

        '    '新規
        '    Case Constant.ENU_FORMMODE.ModeNew

        '        'F4削除ボタン
        '        btnF4.Enabled = Utility.GetPermission(Constant.cgStrPerm_设备查询_削除, Me.Z_DtPermission)

        '        'F6新規ボタン
        '        btnF6.Enabled = Utility.GetPermission(Constant.cgStrPerm_设备查询_新規, Me.Z_DtPermission)

        '        '更新
        '    Case Constant.ENU_FORMMODE.ModeEdit

        '        'F4削除ボタン
        '        btnF4.Enabled = Utility.GetPermission(Constant.cgStrPerm_设备查询_削除, Me.Z_DtPermission)

        '        'F6新規ボタン
        '        btnF6.Enabled = Utility.GetPermission(Constant.cgStrPerm_设备查询_新規, Me.Z_DtPermission)

        'End Select

    End Sub

#End Region

#Region "Grid Event"
    Private Sub grdList_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grdList.DoubleClickRow
        Try
            If grdList.Rows IsNot Nothing AndAlso grdList.Rows.Count > 0 AndAlso grdList.ActiveRow IsNot Nothing AndAlso Me.Modal = True Then

                btnF3选择_Click(Nothing, Nothing)

            End If
        Catch ex As Exception
            EXHelper.ProcessEx(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region


End Class