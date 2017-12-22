<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_splash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_splash))
        Me.tmr_prgbar = New System.Windows.Forms.Timer(Me.components)
        Me.prgbar_splash = New System.Windows.Forms.ProgressBar()
        Me.lbl_progress = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tmr_prgbar
        '
        Me.tmr_prgbar.Enabled = True
        Me.tmr_prgbar.Interval = 40
        '
        'prgbar_splash
        '
        Me.prgbar_splash.Location = New System.Drawing.Point(12, 286)
        Me.prgbar_splash.Name = "prgbar_splash"
        Me.prgbar_splash.Size = New System.Drawing.Size(555, 17)
        Me.prgbar_splash.TabIndex = 0
        '
        'lbl_progress
        '
        Me.lbl_progress.AutoSize = True
        Me.lbl_progress.BackColor = System.Drawing.Color.Transparent
        Me.lbl_progress.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_progress.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_progress.Location = New System.Drawing.Point(396, 264)
        Me.lbl_progress.Name = "lbl_progress"
        Me.lbl_progress.Size = New System.Drawing.Size(171, 19)
        Me.lbl_progress.TabIndex = 1
        Me.lbl_progress.Text = "Loading . . . 100%"
        '
        'frm_splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(579, 315)
        Me.Controls.Add(Me.lbl_progress)
        Me.Controls.Add(Me.prgbar_splash)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_splash"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmr_prgbar As System.Windows.Forms.Timer
    Friend WithEvents prgbar_splash As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_progress As System.Windows.Forms.Label

End Class
