<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label = New System.Windows.Forms.Label()
        Me.txtcek = New System.Windows.Forms.TextBox()
        Me.dgvbarang = New System.Windows.Forms.DataGridView()
        CType(Me.dgvbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(31, 32)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(62, 13)
        Me.Label.TabIndex = 0
        Me.Label.Text = "Cari Barang"
        '
        'txtcek
        '
        Me.txtcek.Location = New System.Drawing.Point(34, 58)
        Me.txtcek.Name = "txtcek"
        Me.txtcek.Size = New System.Drawing.Size(709, 20)
        Me.txtcek.TabIndex = 1
        '
        'dgvbarang
        '
        Me.dgvbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbarang.Location = New System.Drawing.Point(34, 100)
        Me.dgvbarang.Name = "dgvbarang"
        Me.dgvbarang.Size = New System.Drawing.Size(709, 217)
        Me.dgvbarang.TabIndex = 2
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvbarang)
        Me.Controls.Add(Me.txtcek)
        Me.Controls.Add(Me.Label)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.dgvbarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label As Label
    Friend WithEvents txtcek As TextBox
    Friend WithEvents dgvbarang As DataGridView
End Class
