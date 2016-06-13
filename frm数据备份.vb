Public Class frm数据备份

    Private Sub btnF1备份_Click(sender As Object, e As EventArgs) Handles btnF1清空.Click
        Try

            Dim objM_数据备份T As New M_数据备份T
            Dim strFileName As String = Now.ToString("yyMMddhhmmss") + ".bak"
            Dim objBll As New Bll数据备份

            Me.Cursor = Cursors.WaitCursor

            If txt备份路径.Text.Trim = String.Empty Then
                CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "数据备份路径", "数据备份路径")
                txt备份路径.Focus()
                Return
            End If

            If Not System.IO.Directory.Exists(txt备份路径.Text) Then
                CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID90, "数据备份路径", "数据备份路径")
                txt备份路径.Focus()
                Return
            End If

            objM_数据备份T.全名数据备份路径 = txt备份路径.Text + "\" + strFileName
            objM_数据备份T.上次备份日期 = Utility.GetDBTime()
            objM_数据备份T.数据备份路径 = txt备份路径.Text
            If objBll.DoInsert(objM_数据备份T) = Constant.ENU_RETURNTYPE.Succeed Then
                CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID11, "登録")
                Dim strLastDatetime As String = ""
                Dim dtReturn As DataTable = Utility.GetViewByWhere("", "T_数据备份记录", " 上次备份日期")
                If dtReturn.Rows.Count > 0 Then
                    strLastDatetime = dtReturn.Rows(0).Item("上次备份日期").ToString
                End If
                txt上次备份日期.Text = strLastDatetime
                txt备份路径.Text = ""
                txt备份路径.Select()
            End If

        Catch ex As Exception
            'EXHelper.ProcessEx(ex)
            CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID90)
            txt备份路径.Focus()
            Return
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

    Private Sub frm数据备份_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim strLastDatetime As String = ""
            Dim dtReturn As DataTable = Utility.GetViewByWhere("", "T_数据备份记录", " 上次备份日期")
            If dtReturn.Rows.Count > 0 Then
                strLastDatetime = dtReturn.Rows(0).Item("上次备份日期").ToString
            End If
            txt上次备份日期.Text = strLastDatetime
            txt备份路径.Select()
        Catch ex As Exception
            EXHelper.ProcessEx(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub txt备份路径_EditorButtonClick(sender As Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt备份路径.EditorButtonClick
        Try

          Dim ofd As New FolderBrowserDialog
            If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txt备份路径.Text = ofd.SelectedPath
            End If


        Catch ex As Exception
            EXHelper.ProcessEx(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frm数据备份_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode

                'F1：
                Case Keys.F1

                    If btnF1清空.Enabled Then
                        btnF1清空.Focus()
                        If btnF1清空.Focused Then
                            Me.btnF1备份_Click(Nothing, Nothing)
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
End Class