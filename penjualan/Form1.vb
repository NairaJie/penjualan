Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampildata()
    End Sub

    Sub tampildata()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from transaksi"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "transaksi")
        dgvjual.DataSource = ds.Tables("transaksi")
        kon.Close()
    End Sub

    Private Sub btnbrg_Click(sender As Object, e As EventArgs) Handles btnbrg.Click
        Form2.Show()
    End Sub

    Private Sub btncust_Click(sender As Object, e As EventArgs) Handles btncust.Click
        Form3.Show()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "insert into penjualan values('" & txtjual.Text & "','" & Format(dtpjual.Value, "yyyy-MM-dd") & "','" & txtbarang.Text & "', " &
        " '" & txtidcust.Text & "','" & txtjumlahjual.Text & "', '" & txttotal.Text & "')"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampildata()
    End Sub

    Private Sub dg_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvjual.CellContentClick
        txtjual.Enabled = False
        Try
            Dim i As Integer
            i = dgvjual.CurrentRow.Index
            With dgvjual.Rows.Item(i)
                btnsimpan.Enabled = False
                btnupdate.Enabled = True
                txtjual.Text = .Cells(0).Value
                dtpjual.Text = .Cells(1).Value
                txtbarang.Text = .Cells(2).Value
                txtnamabarang.Text = .Cells(3).Value
                txtidcust.Text = .Cells(5).Value
                txtnamacust.Text = .Cells(6).Value
                txtjumlahjual.Text = .Cells(8).Value
                txttotal.Text = .Cells(9).Value
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "UPDATE penjualan SET tgljual='" &
        Format(dtpjual.Value, "yyyy-MM-dd") & "', idbarang='" & txtbarang.Text & "',idcustomer ='" & txtidcust.Text & "',jumlahjual = '" & txtjumlahjual.Text & "',totalharga  = '" & txttotal.Text & "' WHERE idjual= '" &
        txtjual.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampildata()
        MsgBox("Data Berhasil Disimpan...", MsgBoxStyle.Information, "Konfirmasi")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "delete from penjualan where idjual='" & txtjual.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        MsgBox("Data Terpilih Sudah Terhapus", MsgBoxStyle.Information, "Pesan")
        tampildata()
    End Sub
End Class
