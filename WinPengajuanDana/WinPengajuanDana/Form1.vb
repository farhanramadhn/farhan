Imports System.Data.SqlClient
Public Class Form1
    Dim bentuk As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cBidang.Items.Add("ICT")
        cBidang.Items.Add("Akademik")
        cBidang.Items.Add("Keuangan")
        cBidang.Items.Add("Marketing")
        tId.Visible = False
        bUpdate.Visible = False

        show_list_pengajuan()
    End Sub

    Private Sub bSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSimpan.Click
        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim uid As String
        Dim tanggal As String = DateTime.Now.ToString("yyyy-MM-dd")


        Try
            Call OpenKoneksi()
            Dim query_id As String = "SELECT MAX(no)+1 AS MXID FROM Pengajuan"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            uid = dr("MXID")
            dr.Close()

            query = "INSERT INTO Pengajuan (no, nama_pelaksana, bidang, jml, dana, keperluan, tanggal)" & _
                "VALUES (" & uid & ", '" & tNamaPel.Text & "', '" & cBidang.Text & "', " & tJmlPermintaan.Text & ", '" & bentuk & "', '" & tKeperluan.Text & "', '" & tanggal & "')"

            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Close()

            MsgBox("Data Berhasil Disimpan")
            clear_form()


            LVPengajuan.Clear()
            show_list_pengajuan()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub rTunai_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rTunai.CheckedChanged
        bentuk = "Tunai"
    End Sub

    Private Sub rCekBank_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rCekBank.CheckedChanged
        bentuk = "Cek Bank"
    End Sub

    Private Sub rGiro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rGiro.CheckedChanged
        bentuk = "Giro"
    End Sub

    Private Sub show_list_pengajuan()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        LVPengajuan.View = View.Details
        LVPengajuan.Columns.Add("No", 50)
        LVPengajuan.Columns.Add("Nama Pelaksana", 100)
        LVPengajuan.Columns.Add("Bidang", 100)
        LVPengajuan.Columns.Add("Jumlah", 100)
        LVPengajuan.Columns.Add("Bentuk Dana", 100)
        LVPengajuan.Columns.Add("Keperluan", 100)

        Try
            Call OpenKoneksi()
            Dim query_id As String = "SELECT * FROM Pengajuan"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader

            Do While dr.Read
                LVPengajuan.Items.Add(dr("no"))
                LVPengajuan.Items(LVPengajuan.Items.Count - 1).SubItems.Add(dr("nama_pelaksana"))
                LVPengajuan.Items(LVPengajuan.Items.Count - 1).SubItems.Add(dr("bidang"))
                LVPengajuan.Items(LVPengajuan.Items.Count - 1).SubItems.Add(dr("jml"))
                LVPengajuan.Items(LVPengajuan.Items.Count - 1).SubItems.Add(dr("dana"))
                LVPengajuan.Items(LVPengajuan.Items.Count - 1).SubItems.Add(dr("keperluan"))
            Loop
            dr.Close()
            Call CloseKoneksi()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub clear_form()

        tNamaPel.Text = ""
        cBidang.Text = ""
        tJmlPermintaan.Text = ""
        bentuk = ""
        tKeperluan.Text = ""

    End Sub
   
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim Id As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        Try
            Id = LVPengajuan.SelectedItems(0).Text

            Call OpenKoneksi()
            Dim query As String = "DELETE FROM Pengajuan WHERE no = '" + Id + "'"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            Call CloseKoneksi()
            dr.Close()

            LVPengajuan.Clear()
            show_list_pengajuan()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim Id As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        bSimpan.Visible = False
        bUpdate.Visible = True

        Try
            Id = LVPengajuan.SelectedItems(0).Text

            Call OpenKoneksi()
            Dim query As String = "SELECT * FROM Pengajuan WHERE no ='" + Id + "'"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Read()

            tNamaPel.Text = dr("nama_pelaksana")
            cBidang.Text = dr("bidang")
            tJmlPermintaan.Text = dr("jml")
            bentuk = dr("dana")
            tKeperluan.Text = dr("keperluan")
            tId.Text = dr("no")

            Call CloseKoneksi()
            dr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub bUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bUpdate.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        bSimpan.Visible = True
        bUpdate.Visible = False

        Try
            Call OpenKoneksi()
            Dim query As String = "UPDATE Pengajuan SET " & _
                                "nama_pelaksana = '" & tNamaPel.Text & "', " & _
                                "bidang = '" & cBidang.Text & "', " & _
                                "jml = " & tJmlPermintaan.Text & ", " & _
                                "dana = '" & bentuk & "', " & _
                                "keperluan = '" & tKeperluan.Text & "' " & _
                                "WHERE no = " & tId.Text & " "
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Close()
            Call CloseKoneksi()

            MsgBox("Berhasil Di Update")
            clear_form()
            LVPengajuan.Clear()
            show_list_pengajuan()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Class
