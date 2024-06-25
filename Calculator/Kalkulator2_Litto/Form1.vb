Public Class frmkalkulator

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles awowow.Click

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim Angka1, Angka2, Hasil As Double
        Angka1 = Val(txtAngka1.Text)
        Angka2 = Val(txtAngka2.Text)
        Hasil = Angka1 + Angka2
        txtHasil.Text = Hasil
    End Sub

    Private Sub btnKali_Click(sender As Object, e As EventArgs) Handles btnKali.Click
        Dim Angka1, Angka2, Hasil As Double
        Angka1 = Val(txtAngka1.Text)
        Angka2 = Val(txtAngka2.Text)
        Hasil = Angka1 * Angka2
        txtHasil.Text = Hasil
    End Sub

    Private Sub btnKurang_Click(sender As Object, e As EventArgs) Handles btnKurang.Click
        Dim Angka1, Angka2, Hasil As Double
        Angka1 = Val(txtAngka1.Text)
        Angka2 = Val(txtAngka2.Text)
        Hasil = Angka1 - Angka2
        txtHasil.Text = Hasil
    End Sub

    Private Sub btnBagi_Click(sender As Object, e As EventArgs) Handles btnBagi.Click
        Dim Angka1, Angka2, Hasil As Double
        Angka1 = Val(txtAngka1.Text)
        Angka2 = Val(txtAngka2.Text)
        Hasil = Angka1 / Angka2
        txtHasil.Text = Hasil
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtAngka1.Text = ""
        txtAngka2.Text = ""
        txtHasil.Text = ""
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub
End Class
