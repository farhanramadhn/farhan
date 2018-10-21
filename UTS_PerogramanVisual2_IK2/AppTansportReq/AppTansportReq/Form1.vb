Imports System.Data.SqlClient
Public Class Form1
    Dim transportation As String
    Dim cmd_gl As SqlCommand
    Dim dr_gl As SqlDataReader
    Dim query_gl As String
    Dim DateIssue = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss tt")



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cTransportation.Items.Add("Pick Up")
        cTransportation.Items.Add("Box")
        cTransportation.Items.Add("Blind Van")
        cTransportation.Items.Add("Truck")
        cTransportation.Items.Add("BTT")
        cTransportation.Items.Add("Forklift")
        cTransportation.Items.Add("Other")

        tTransportation.Visible = False
        bRequest.Visible = False
        tRequestId.Visible = False

        show_request()
    End Sub

    Private Sub cTransportation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cTransportation.SelectedIndexChanged

        transportation = cTransportation.Text

        If cTransportation.Text = "Other" Then
            tTransportation.Visible = True
        Else
            tTransportation.Visible = False
        End If
    End Sub

    Private Sub bSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSend.Click
        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim RequestId As String

        Try
            Call OpenKoneksi()
            Dim query_id As String = "SELECT MAX(RequestId)+1 AS MXID FROM Request"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            RequestId = dr("MXID")
            dr.Close()

            query = "INSERT INTO Request (RequestId, NameRequestor, RequestorId, Unit, " & _
                "DateIssue, UnitDestination, acRegis, Transportation, Phone, Instruction) " & _
                "VALUES (" & RequestId & ", '" & tNameReq.Text & "', '" & tIdNumber.Text & "', " & _
                " '" & tUnit.Text & "', '" & DateIssue & "', '" & tUnitDesti.Text & "', '" & tACReg.Text & "', " & _
                " '" & transportation & "', '" & tPhone.Text & "', '" & tIntruction.Text & "')"

            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Close()

            clear_from()

            LVreq.Clear()
            show_request()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub clear_from()

        tNameReq.Text = ""
        tIdNumber.Text = ""
        tUnit.Text = ""
        tUnitDesti.Text = ""
        tACReg.Text = ""
        cTransportation.Text = ""
        tTransportation.Text = ""
        tPhone.Text = ""
        tIntruction.Text = ""

        tTransportation.Visible = False
    End Sub

    Private Sub tTransportation_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tTransportation.TextChanged
        transportation = tTransportation.Text
    End Sub

    Private Sub show_request()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        LVreq.View = View.Details
        LVreq.Columns.Add("No", 50)
        LVreq.Columns.Add("Nama", 200)
        LVreq.Columns.Add("Unit From", 100)
        LVreq.Columns.Add("Unit To", 100)
        LVreq.Columns.Add("Request Date", 200)
        LVreq.Columns.Add("Transportation", 150)

        Try
            Call OpenKoneksi()
            Dim query_id As String = "SELECT * FROM Request"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader

            Do While dr.Read
                LVreq.Items.Add(dr("RequestId"))
                LVreq.Items(LVreq.Items.Count - 1).SubItems.Add(dr("NameRequestor"))
                LVreq.Items(LVreq.Items.Count - 1).SubItems.Add(dr("Unit"))
                LVreq.Items(LVreq.Items.Count - 1).SubItems.Add(dr("UnitDestination"))
                LVreq.Items(LVreq.Items.Count - 1).SubItems.Add(dr("DateIssue"))
                LVreq.Items(LVreq.Items.Count - 1).SubItems.Add(dr("Transportation"))

            Loop
            dr.Close()
            Call CloseKoneksi()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim RequestId As String

        Try
            RequestId = LVreq.SelectedItems(0).Text

            Call OpenKoneksi()
            Dim query As String = "DELETE FROM Request WHERE RequestId = '" + RequestId + "'"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            Call CloseKoneksi()
            dr.Close()

            LVreq.Clear()
            show_request()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim RequestId As String
        bSend.Visible = False
        bRequest.Visible = True
        If cTransportation.Text = "Other" Then
            tTransportation.Visible = True
        End If

        Try
            RequestId = LVreq.SelectedItems(0).Text

            Call OpenKoneksi()
            Dim query As String = "SELECT * FROM Request WHERE RequestId = '" + RequestId + "'"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Read()

            tNameReq.Text = dr("NameRequestor")
            tIdNumber.Text = dr("RequestorId")
            tUnit.Text = dr("Unit")
            DTPissue.Value = dr("DateIssue")
            tUnitDesti.Text = dr("UnitDestination")
            tACReg.Text = dr("acRegis")
            transportation = dr("Transportation")
            tPhone.Text = dr("Phone")
            tIntruction.Text = dr("Instruction")
            tRequestId.Text = dr("RequestId")

            Call CloseKoneksi()
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub bRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bRequest.Click
        bRequest.Visible = False
        bSend.Visible = True

        Try
            Call OpenKoneksi()
            query_gl = "UPDATE Request SET " & _
                                "NameRequestor = '" & tNameReq.Text & "', " & _
                                "RequestorId = '" & tIdNumber.Text & "', " & _
                                "Unit = '" & tUnit.Text & "', " & _
                                "DateIssue = '" & DateIssue & "', " & _
                                "UnitDestination = '" & tUnitDesti.Text & "', " & _
                                "acRegis = '" & tACReg.Text & "', " & _
                                "Transportation = '" & transportation & "', " & _
                                "Phone = '" & tPhone.Text & "', " & _
                                "Instruction = '" & tIntruction.Text & "' " & _
                                "WHERE RequestId = " & tRequestId.Text & " "

            cmd_gl = New SqlCommand(query_gl, conn)
            dr_gl = cmd_gl.ExecuteReader
            dr_gl.Close()
            Call CloseKoneksi()
            clear_from()

            LVreq.Clear()
            show_request()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
