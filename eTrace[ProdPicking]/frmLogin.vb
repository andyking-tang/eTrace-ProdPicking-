Public Class frmLogin
    Private Sub frmLogin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        SetEnv(My.Settings.LoginServer)
        'Dim a As Integer
        'a = InStr(8, My.Settings.eTraceWS, "/", CompareMethod.Text)
        'If a > 0 Then
        '    My.Settings.eTraceWS = Mid(My.Settings.eTraceWS, 1, 7) & My.Settings.LoginServer & Mid(My.Settings.eTraceWS, a)
        'End If
        My.Settings.Save()
    End Sub
    Private Sub LoginCompleted_event() Handles Me.LoginCompleted
        Reset_Properties()

        MainFrm = New frmMain
        'Show application main form
        MainFrm.ShowFrm(Me)
    End Sub

    Public Overrides Sub OnChangeUser()
        'Close all forms before changing user
        Me.ResetAppForLogin(My.Application.OpenForms)
    End Sub

    Private Sub Reset_Properties()

        Try

            ERPLogin.User = ERPLoginData.User
            ERPLogin.PWD = ERPLoginData.PWD
            ERPLogin.UserID = ERPLoginData.UserID
            ERPLogin.OrgCode = ERPLoginData.OrgCode
            ERPLogin.Printer = ERPLoginData.Printer
            ERPLogin.Server = ERPLoginData.Server
            ERPLogin.OrgID = ERPLoginData.OrgID

            ERPLogin.AppID_PO = ERPLoginData.AppID_PO
            ERPLogin.RespID_PO = ERPLoginData.RespID_PO
            ERPLogin.AppID_Inv = ERPLoginData.AppID_Inv
            ERPLogin.RespID_Inv = ERPLoginData.RespID_Inv
            ERPLogin.AppID_WIP = ERPLoginData.AppID_WIP
            ERPLogin.RespID_WIP = ERPLoginData.RespID_WIP

            ERPLogin.UserType = ERPLoginData.UserType
            ERPLogin.UserDept = ERPLoginData.UserDept
            ERPLogin.ResetFlag = ERPLoginData.ResetFlag

            If ERPLogin.ResetFlag = True Then
                If ERPLogin.UserType Is Nothing Then ERPLogin.UserType = ""

                Dim dsMessage As DataSet = New DataSet
                Dim eTraceMessages As DataSet = New DataSet

                dsMessage = eTraceProperties.Copy
                eTraceMessages = eTraceProperties.Copy

                Dim Col1 As New DataColumn()
                Col1.DataType = System.Type.[GetType]("System.String")
                Col1.AllowDBNull = False
                Col1.Caption = "DelFlag"
                Col1.ColumnName = "DelFlag"
                Col1.DefaultValue = "0"
                dsMessage.Tables(1).Columns.Add(Col1)

                Dim i, j As Integer
                Dim DR() As DataRow = Nothing
                Dim DMsg() As DataRow = Nothing
                If ERPLogin.UserType = "" Then
                    DR = eTraceMessages.Tables(1).Select(" ValidationType <> '" & ERPLogin.UserType & "'")
                Else
                    DR = eTraceMessages.Tables(1).Select(" ValidationType = '" & ERPLogin.UserType & "'")
                End If
                If DR.Length > 0 Then
                    For i = 0 To DR.Length - 1
                        Dim FieldName As String = DR(i)("Property").ToString
                        DMsg = dsMessage.Tables(1).Select(" Property = '" & FieldName & "'")
                        If DMsg.Length > 0 Then
                            For j = 0 To DMsg.Length - 1
                                If DMsg(j)("ValidationType").ToString = ERPLogin.UserType Then
                                    If ERPLogin.UserType = "OSP" And DMsg(j)("Property").ToString.ToUpper = "PRODFLOOR" Then
                                        '''''''''''''''Temporary comment the default value setting for ProductionFloor. Will use "UserDept" field to store the default value in future  ----Andyking 20110913
                                        'DMsg(j)("DefaultValue") = ERPLogin.UserDept
                                    End If
                                Else
                                    DMsg(j)("DelFlag") = "1"
                                End If
                                DMsg(j).AcceptChanges()
                            Next
                            'dsMessage.Tables(1).AcceptChanges()
                        End If
                    Next

                    eTraceMessages.Tables(1).Clear()
                    For Each dr1 As DataRow In dsMessage.Tables(1).Rows
                        If dr1("DelFlag") = "0" Then
                            eTraceMessages.Tables(1).ImportRow(dr1)
                        End If
                    Next
                    eTraceMessages.Tables(1).AcceptChanges()
                End If

                Reset_XmlFile(eTraceMessages)

            End If

        Catch ex As Exception
            MsgBox("2" & ex.Message & ex.InnerException.ToString & ex.Source.ToString)
        End Try

    End Sub
End Class
