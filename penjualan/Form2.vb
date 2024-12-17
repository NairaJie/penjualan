Public Class Form2
    Sub tampildata()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from barang"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "barang")
        dgvbarang.DataSource = ds.Tables("barang")
        kon.Close()
    End Sub

    Private Sub barang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampildata()
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvbarang.CellContentClick
        Try
            Dim i As Integer
            i = dgvbarang.CurrentRow.Index
            With dgvbarang.Rows.Item(i)
                Form1.txtbarang.Text = .Cells(0).Value
                Form1.txtnamabarang.Text = .Cells(1).Value
                Me.Close()
            End With
        Catch ex As Exception
        End Try
    End Sub

    Sub tampiluser(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        Dim datas As New DataSet
        mda.Fill(datas, "barang")
        dgvbarang.DataSource = datas.Tables("barang")
        kon.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcek.TextChanged
        tampiluser("select * from barang where namabarang like '%" &
       txtcek.Text & "%' or idbarang like '%" & txtcek.Text & "%'")
    End Sub
End Class