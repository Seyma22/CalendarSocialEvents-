<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.backBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.headerTb = New System.Windows.Forms.TextBox()
        Me.contentTb = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'backBtn
        '
        Me.backBtn.Location = New System.Drawing.Point(12, 12)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(75, 23)
        Me.backBtn.TabIndex = 1
        Me.backBtn.Text = "Geri"
        Me.backBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(297, 508)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'headerTb
        '
        Me.headerTb.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerTb.Location = New System.Drawing.Point(316, 41)
        Me.headerTb.Name = "headerTb"
        Me.headerTb.ReadOnly = True
        Me.headerTb.Size = New System.Drawing.Size(536, 32)
        Me.headerTb.TabIndex = 3
        Me.headerTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'contentTb
        '
        Me.contentTb.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contentTb.Location = New System.Drawing.Point(316, 80)
        Me.contentTb.Multiline = True
        Me.contentTb.Name = "contentTb"
        Me.contentTb.ReadOnly = True
        Me.contentTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.contentTb.Size = New System.Drawing.Size(536, 469)
        Me.contentTb.TabIndex = 4
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 561)
        Me.Controls.Add(Me.contentTb)
        Me.Controls.Add(Me.headerTb)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.backBtn)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents backBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents headerTb As TextBox
    Friend WithEvents contentTb As TextBox
End Class
