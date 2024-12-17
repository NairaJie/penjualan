Public Class Form3
    Sub tampildata()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from customer"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "customer")
        dgvcust.DataSource = ds.Tables("customer")
        kon.Close()
    End Sub

    Private Sub customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampildata()
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvcust.CellContentClick
        Try
            Dim i As Integer
            i = dgvcust.CurrentRow.Index
            With dgvcust.Rows.Item(i)
                Form1.txtidcust.Text = .Cells(0).Value
                Form1.txtnamacust.Text = .Cells(1).Value
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
        mda.Fill(datas, "customer")
        dgvcust.DataSource = datas.Tables("customer")
        kon.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcek.TextChanged
        tampiluser("select * from customer where nama like '%" &
       txtcek.Text & "%' or idcustomer like '%" & txtcek.Text & "%'")
    End Sub
End Class