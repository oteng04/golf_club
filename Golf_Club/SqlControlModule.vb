Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Module SqlControlModule
    Public adminSqlDataReader As SqlDataReader
    Public authenSqlDataReader As SqlDataReader
    Public memSqlDataReader As SqlDataReader

    Public Function AdminCommandCreation(SqlCommand As String) As DataTable
        Dim adminDataTable As New DataTable
        Try
            Using connection As New SqlConnection(My.Settings.Admin_login)
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If
                Using command As New SqlCommand(SqlCommand, connection)
                    adminSqlDataReader = command.ExecuteReader
                    adminDataTable.Load(adminSqlDataReader)
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return adminDataTable
    End Function
    Public Function AuthentificationCommandCreation(SqlCommand As String) As DataTable
        Dim authenDataTable As New DataTable
        Try
            Using connection As New SqlConnection(My.Settings.Authen)
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If
                Using command As New SqlCommand(SqlCommand, connection)
                    authenSqlDataReader = command.ExecuteReader
                    authenDataTable.Load(authenSqlDataReader)
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return authenDataTable
    End Function

    Public Function MembersCommandCreation(SqlCommand As String) As DataTable
        Dim memDataTable As New DataTable
        Try
            Using connection As New SqlConnection(My.Settings.Members)
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If
                Using command As New SqlCommand(SqlCommand, connection)
                    memSqlDataReader = command.ExecuteReader
                    memDataTable.Load(memSqlDataReader)
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return memDataTable
    End Function

End Module