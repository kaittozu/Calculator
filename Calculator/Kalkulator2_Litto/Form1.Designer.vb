<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmkalkulator
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
        Me.angka1 = New System.Windows.Forms.Label()
        Me.Angka2 = New System.Windows.Forms.Label()
        Me.awowow = New System.Windows.Forms.Label()
        Me.txtAngka1 = New System.Windows.Forms.TextBox()
        Me.txtAngka2 = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnKurang = New System.Windows.Forms.Button()
        Me.btnBagi = New System.Windows.Forms.Button()
        Me.btnKali = New System.Windows.Forms.Button()
        Me.txtHasil = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'angka1
        '
        Me.angka1.AutoSize = True
        Me.angka1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.angka1.Location = New System.Drawing.Point(12, 50)
        Me.angka1.Name = "angka1"
        Me.angka1.Size = New System.Drawing.Size(97, 13)
        Me.angka1.TabIndex = 0
        Me.angka1.Text = "Angka Pertama "
        '
        'Angka2
        '
        Me.Angka2.AutoSize = True
        Me.Angka2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Angka2.Location = New System.Drawing.Point(12, 81)
        Me.Angka2.Name = "Angka2"
        Me.Angka2.Size = New System.Drawing.Size(87, 13)
        Me.Angka2.TabIndex = 1
        Me.Angka2.Text = "Angka Kedua "
        '
        'awowow
        '
        Me.awowow.AutoSize = True
        Me.awowow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.awowow.Location = New System.Drawing.Point(12, 163)
        Me.awowow.Name = "awowow"
        Me.awowow.Size = New System.Drawing.Size(90, 13)
        Me.awowow.TabIndex = 2
        Me.awowow.Text = "Jumlah Hasil : "
        '
        'txtAngka1
        '
        Me.txtAngka1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtAngka1.ForeColor = System.Drawing.SystemColors.Info
        Me.txtAngka1.Location = New System.Drawing.Point(117, 47)
        Me.txtAngka1.Name = "txtAngka1"
        Me.txtAngka1.Size = New System.Drawing.Size(155, 20)
        Me.txtAngka1.TabIndex = 3
        '
        'txtAngka2
        '
        Me.txtAngka2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtAngka2.ForeColor = System.Drawing.SystemColors.Info
        Me.txtAngka2.Location = New System.Drawing.Point(117, 81)
        Me.txtAngka2.Name = "txtAngka2"
        Me.txtAngka2.Size = New System.Drawing.Size(155, 20)
        Me.txtAngka2.TabIndex = 4
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnTambah.Location = New System.Drawing.Point(15, 116)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(44, 23)
        Me.btnTambah.TabIndex = 5
        Me.btnTambah.Text = "+"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'btnKurang
        '
        Me.btnKurang.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnKurang.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnKurang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKurang.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnKurang.Location = New System.Drawing.Point(86, 116)
        Me.btnKurang.Name = "btnKurang"
        Me.btnKurang.Size = New System.Drawing.Size(44, 23)
        Me.btnKurang.TabIndex = 6
        Me.btnKurang.Text = "-"
        Me.btnKurang.UseVisualStyleBackColor = False
        '
        'btnBagi
        '
        Me.btnBagi.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnBagi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBagi.Location = New System.Drawing.Point(157, 116)
        Me.btnBagi.Name = "btnBagi"
        Me.btnBagi.Size = New System.Drawing.Size(44, 23)
        Me.btnBagi.TabIndex = 7
        Me.btnBagi.Text = "/"
        Me.btnBagi.UseVisualStyleBackColor = True
        '
        'btnKali
        '
        Me.btnKali.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnKali.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKali.Location = New System.Drawing.Point(228, 116)
        Me.btnKali.Name = "btnKali"
        Me.btnKali.Size = New System.Drawing.Size(44, 23)
        Me.btnKali.TabIndex = 8
        Me.btnKali.Text = "X"
        Me.btnKali.UseVisualStyleBackColor = True
        '
        'txtHasil
        '
        Me.txtHasil.BackColor = System.Drawing.SystemColors.HotTrack
        Me.txtHasil.ForeColor = System.Drawing.SystemColors.Info
        Me.txtHasil.Location = New System.Drawing.Point(117, 160)
        Me.txtHasil.Name = "txtHasil"
        Me.txtHasil.Size = New System.Drawing.Size(155, 20)
        Me.txtHasil.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Kalkulator"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(15, 199)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(115, 23)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(157, 199)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(115, 23)
        Me.btnKeluar.TabIndex = 12
        Me.btnKeluar.Text = "Quit"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'frmkalkulator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(284, 242)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHasil)
        Me.Controls.Add(Me.btnKali)
        Me.Controls.Add(Me.btnBagi)
        Me.Controls.Add(Me.btnKurang)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.txtAngka2)
        Me.Controls.Add(Me.txtAngka1)
        Me.Controls.Add(Me.awowow)
        Me.Controls.Add(Me.Angka2)
        Me.Controls.Add(Me.angka1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmkalkulator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kalkulator Sederhana"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents angka1 As System.Windows.Forms.Label
    Friend WithEvents Angka2 As System.Windows.Forms.Label
    Friend WithEvents awowow As System.Windows.Forms.Label
    Friend WithEvents txtAngka1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAngka2 As System.Windows.Forms.TextBox
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnKurang As System.Windows.Forms.Button
    Friend WithEvents btnBagi As System.Windows.Forms.Button
    Friend WithEvents btnKali As System.Windows.Forms.Button
    Friend WithEvents txtHasil As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button

End Class
