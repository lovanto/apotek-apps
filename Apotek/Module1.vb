Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Module Module1
    Public Conn As OleDbConnection
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public cmd As OleDbCommand
    Public rd As OleDbDataReader
    Public str As String

    Public cryRpt As New ReportDocument
    Public crtableLogoninfos As New TableLogOnInfos
    Public crtableLogoninfo As New TableLogOnInfo
    Public crConnectionInfo As New ConnectionInfo
    Public CrTables As Tables
    Public CrTable As Table

    Public Sub Module_Konfigurasi_laporan()
        With crConnectionInfo
            .ServerName = (Application.StartupPath.ToString & "\db1.mdb")
            .DatabaseName = (Application.StartupPath.ToString & "\db1.mdb")
            .UserID = ""
            .Password = ""
        End With

        'CrTables = cryRpt.Database.Tables
        'For Each CrTable In CrTables
        'crtableLogoninfo = CrTable.LogOnInfo
        'crtableLogoninfo.ConnectionInfo = crConnectionInfo
        'CrTable.ApplyLogOnInfo(crtableLogoninfo)
        'Next
    End Sub

    Public Sub Koneksi()
        Conn = New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=db1.mdb")
        Conn.Open()
    End Sub
End Module
