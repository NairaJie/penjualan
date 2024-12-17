<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.dgvcust = New System.Windows.Forms.DataGridView()
        Me.txtcek = New System.Windows.Forms.TextBox()
        Me.Label = New System.Windows.Forms.Label()
        CType(Me.dgvcust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvcust
        '
        Me.dgvcust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcust.Location = New System.Drawing.Point(28, 101)
        Me.dgvcust.Name = "dgvcust"
        Me.dgvcust.Size = New System.Drawing.Size(709, 217)
        Me.dgvcust.TabIndex = 5
        '
        'txtcek
        '
        Me.txtcek.Location = New System.Drawing.Point(28, 59)
        Me.txtcek.Name = "txtcek"
        Me.txtcek.Size = New System.Drawing.Size(709, 20)
        Me.txtcek.TabIndex = 4
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(25, 33)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(72, 13)
        Me.Label.TabIndex = 3
        Me.Label.Text = "Cari Customer"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvcust)
        Me.Controls.Add(Me.txtcek)
        Me.Controls.Add(Me.Label)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.dgvcust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvcust As DataGridView
    Friend WithEvents txtcek As TextBox
    Friend WithEvents Label As Label
End Class
