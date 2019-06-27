<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.detailBtn = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'backBtn
        '
        Me.backBtn.Location = New System.Drawing.Point(12, 9)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(75, 23)
        Me.backBtn.TabIndex = 1
        Me.backBtn.Text = "Geri"
        Me.backBtn.UseVisualStyleBackColor = True
        '
        'detailBtn
        '
        Me.detailBtn.Location = New System.Drawing.Point(758, 237)
        Me.detailBtn.Name = "detailBtn"
        Me.detailBtn.Size = New System.Drawing.Size(85, 68)
        Me.detailBtn.TabIndex = 2
        Me.detailBtn.Text = "Etkinliği Görüntüle"
        Me.detailBtn.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 19
        Me.ListBox1.Location = New System.Drawing.Point(12, 38)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(724, 517)
        Me.ListBox1.TabIndex = 3
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 561)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.detailBtn)
        Me.Controls.Add(Me.backBtn)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents backBtn As Button
    Friend WithEvents detailBtn As Button
    Friend WithEvents ListBox1 As ListBox
End Class
