<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.hati3 = New System.Windows.Forms.PictureBox()
        Me.hati2 = New System.Windows.Forms.PictureBox()
        Me.hati1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hati3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hati2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hati1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(440, 327)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'hati3
        '
        Me.hati3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.hati3.Image = Global.Pakman.My.Resources.Resources.nyawa
        Me.hati3.Location = New System.Drawing.Point(421, 12)
        Me.hati3.Name = "hati3"
        Me.hati3.Size = New System.Drawing.Size(25, 25)
        Me.hati3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hati3.TabIndex = 1
        Me.hati3.TabStop = False
        '
        'hati2
        '
        Me.hati2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.hati2.Image = Global.Pakman.My.Resources.Resources.nyawa
        Me.hati2.Location = New System.Drawing.Point(390, 12)
        Me.hati2.Name = "hati2"
        Me.hati2.Size = New System.Drawing.Size(25, 25)
        Me.hati2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hati2.TabIndex = 2
        Me.hati2.TabStop = False
        '
        'hati1
        '
        Me.hati1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.hati1.Image = Global.Pakman.My.Resources.Resources.nyawa
        Me.hati1.Location = New System.Drawing.Point(359, 12)
        Me.hati1.Name = "hati1"
        Me.hati1.Size = New System.Drawing.Size(25, 25)
        Me.hati1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hati1.TabIndex = 3
        Me.hati1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(582, 464)
        Me.Controls.Add(Me.hati1)
        Me.Controls.Add(Me.hati2)
        Me.Controls.Add(Me.hati3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hati3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hati2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hati1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents hati3 As PictureBox
    Friend WithEvents hati2 As PictureBox
    Friend WithEvents hati1 As PictureBox
End Class
