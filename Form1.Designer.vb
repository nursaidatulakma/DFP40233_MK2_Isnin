<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblMaklumatPelanggan = New Label()
        lblNama = New Label()
        TxtNama = New TextBox()
        lblNoTelefon = New Label()
        TxtNoTelefon = New TextBox()
        cbxNegeri = New ComboBox()
        lblNegeri = New Label()
        rbtLelaki = New RadioButton()
        rbtPerempuan = New RadioButton()
        gbxJantina = New GroupBox()
        rbtCash = New RadioButton()
        rbtCashless = New RadioButton()
        gbxBayaran = New GroupBox()
        cbxMilo = New CheckBox()
        cbxKopi = New CheckBox()
        cbxCoklat = New CheckBox()
        cbxStrawberi = New CheckBox()
        cbxPisang = New CheckBox()
        gbxPerisa = New GroupBox()
        dtpTarikh = New DateTimePicker()
        dgvMaklumat = New DataGridView()
        clmBil = New DataGridViewTextBoxColumn()
        clmNama = New DataGridViewTextBoxColumn()
        clmNoTelefon = New DataGridViewTextBoxColumn()
        btnCreate = New Button()
        btnRead = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        lblAlamat = New Label()
        TxtAlamat = New TextBox()
        gbxJantina.SuspendLayout()
        gbxBayaran.SuspendLayout()
        gbxPerisa.SuspendLayout()
        CType(dgvMaklumat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblMaklumatPelanggan
        ' 
        lblMaklumatPelanggan.AutoSize = True
        lblMaklumatPelanggan.Location = New Point(190, 39)
        lblMaklumatPelanggan.Name = "lblMaklumatPelanggan"
        lblMaklumatPelanggan.Size = New Size(177, 20)
        lblMaklumatPelanggan.TabIndex = 0
        lblMaklumatPelanggan.Text = "MAKLUMAT PELANGGAN"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(31, 95)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(49, 20)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama"
        ' 
        ' TxtNama
        ' 
        TxtNama.Location = New Point(122, 95)
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(317, 27)
        TxtNama.TabIndex = 2
        ' 
        ' lblNoTelefon
        ' 
        lblNoTelefon.AutoSize = True
        lblNoTelefon.Location = New Point(31, 135)
        lblNoTelefon.Name = "lblNoTelefon"
        lblNoTelefon.Size = New Size(85, 20)
        lblNoTelefon.TabIndex = 3
        lblNoTelefon.Text = "No. Telefon"
        ' 
        ' TxtNoTelefon
        ' 
        TxtNoTelefon.Location = New Point(122, 135)
        TxtNoTelefon.Name = "TxtNoTelefon"
        TxtNoTelefon.Size = New Size(217, 27)
        TxtNoTelefon.TabIndex = 4
        ' 
        ' cbxNegeri
        ' 
        cbxNegeri.FormattingEnabled = True
        cbxNegeri.Items.AddRange(New Object() {"", "Perlis", "Kedah", "Pulau Pinang", "Perak", "Selangor", "Melaka ", "Johor", "Terengganu", "Kelantan", "Sabah", "Sarawak", "Negeri Sembilan", "Pahang"})
        cbxNegeri.Location = New Point(537, 98)
        cbxNegeri.Name = "cbxNegeri"
        cbxNegeri.Size = New Size(151, 28)
        cbxNegeri.TabIndex = 5
        ' 
        ' lblNegeri
        ' 
        lblNegeri.AutoSize = True
        lblNegeri.Location = New Point(477, 98)
        lblNegeri.Name = "lblNegeri"
        lblNegeri.Size = New Size(54, 20)
        lblNegeri.TabIndex = 6
        lblNegeri.Text = "Negeri"
        ' 
        ' rbtLelaki
        ' 
        rbtLelaki.AutoSize = True
        rbtLelaki.Location = New Point(6, 26)
        rbtLelaki.Name = "rbtLelaki"
        rbtLelaki.Size = New Size(68, 24)
        rbtLelaki.TabIndex = 7
        rbtLelaki.TabStop = True
        rbtLelaki.Text = "Lelaki"
        rbtLelaki.UseVisualStyleBackColor = True
        ' 
        ' rbtPerempuan
        ' 
        rbtPerempuan.AutoSize = True
        rbtPerempuan.Location = New Point(6, 56)
        rbtPerempuan.Name = "rbtPerempuan"
        rbtPerempuan.Size = New Size(104, 24)
        rbtPerempuan.TabIndex = 8
        rbtPerempuan.TabStop = True
        rbtPerempuan.Text = "Perempuan"
        rbtPerempuan.UseVisualStyleBackColor = True
        ' 
        ' gbxJantina
        ' 
        gbxJantina.Controls.Add(rbtPerempuan)
        gbxJantina.Controls.Add(rbtLelaki)
        gbxJantina.Location = New Point(419, 183)
        gbxJantina.Name = "gbxJantina"
        gbxJantina.Size = New Size(144, 87)
        gbxJantina.TabIndex = 9
        gbxJantina.TabStop = False
        gbxJantina.Text = "Jantina"
        ' 
        ' rbtCash
        ' 
        rbtCash.AutoSize = True
        rbtCash.Location = New Point(6, 26)
        rbtCash.Name = "rbtCash"
        rbtCash.Size = New Size(61, 24)
        rbtCash.TabIndex = 10
        rbtCash.TabStop = True
        rbtCash.Text = "Cash"
        rbtCash.UseVisualStyleBackColor = True
        ' 
        ' rbtCashless
        ' 
        rbtCashless.AutoSize = True
        rbtCashless.Location = New Point(6, 56)
        rbtCashless.Name = "rbtCashless"
        rbtCashless.Size = New Size(85, 24)
        rbtCashless.TabIndex = 11
        rbtCashless.TabStop = True
        rbtCashless.Text = "Cashless"
        rbtCashless.UseVisualStyleBackColor = True
        ' 
        ' gbxBayaran
        ' 
        gbxBayaran.Controls.Add(rbtCash)
        gbxBayaran.Controls.Add(rbtCashless)
        gbxBayaran.Location = New Point(615, 183)
        gbxBayaran.Name = "gbxBayaran"
        gbxBayaran.Size = New Size(144, 96)
        gbxBayaran.TabIndex = 12
        gbxBayaran.TabStop = False
        gbxBayaran.Text = "Bayaran"
        ' 
        ' cbxMilo
        ' 
        cbxMilo.AutoSize = True
        cbxMilo.Location = New Point(6, 26)
        cbxMilo.Name = "cbxMilo"
        cbxMilo.Size = New Size(61, 24)
        cbxMilo.TabIndex = 13
        cbxMilo.Text = "milo"
        cbxMilo.UseVisualStyleBackColor = True
        ' 
        ' cbxKopi
        ' 
        cbxKopi.AutoSize = True
        cbxKopi.Location = New Point(7, 56)
        cbxKopi.Name = "cbxKopi"
        cbxKopi.Size = New Size(60, 24)
        cbxKopi.TabIndex = 14
        cbxKopi.Text = "kopi"
        cbxKopi.UseVisualStyleBackColor = True
        ' 
        ' cbxCoklat
        ' 
        cbxCoklat.AutoSize = True
        cbxCoklat.Location = New Point(6, 86)
        cbxCoklat.Name = "cbxCoklat"
        cbxCoklat.Size = New Size(71, 24)
        cbxCoklat.TabIndex = 15
        cbxCoklat.Text = "coklat"
        cbxCoklat.UseVisualStyleBackColor = True
        ' 
        ' cbxStrawberi
        ' 
        cbxStrawberi.AutoSize = True
        cbxStrawberi.Location = New Point(91, 26)
        cbxStrawberi.Name = "cbxStrawberi"
        cbxStrawberi.Size = New Size(92, 24)
        cbxStrawberi.TabIndex = 16
        cbxStrawberi.Text = "strawberi"
        cbxStrawberi.UseVisualStyleBackColor = True
        ' 
        ' cbxPisang
        ' 
        cbxPisang.AutoSize = True
        cbxPisang.Location = New Point(91, 56)
        cbxPisang.Name = "cbxPisang"
        cbxPisang.Size = New Size(75, 24)
        cbxPisang.TabIndex = 17
        cbxPisang.Text = "pisang"
        cbxPisang.UseVisualStyleBackColor = True
        ' 
        ' gbxPerisa
        ' 
        gbxPerisa.Controls.Add(cbxMilo)
        gbxPerisa.Controls.Add(cbxPisang)
        gbxPerisa.Controls.Add(cbxKopi)
        gbxPerisa.Controls.Add(cbxStrawberi)
        gbxPerisa.Controls.Add(cbxCoklat)
        gbxPerisa.Location = New Point(31, 266)
        gbxPerisa.Name = "gbxPerisa"
        gbxPerisa.Size = New Size(193, 121)
        gbxPerisa.TabIndex = 18
        gbxPerisa.TabStop = False
        gbxPerisa.Text = "Perisa"
        ' 
        ' dtpTarikh
        ' 
        dtpTarikh.Location = New Point(477, 144)
        dtpTarikh.Name = "dtpTarikh"
        dtpTarikh.Size = New Size(250, 27)
        dtpTarikh.TabIndex = 19
        ' 
        ' dgvMaklumat
        ' 
        dgvMaklumat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMaklumat.Columns.AddRange(New DataGridViewColumn() {clmBil, clmNama, clmNoTelefon})
        dgvMaklumat.Location = New Point(330, 292)
        dgvMaklumat.Name = "dgvMaklumat"
        dgvMaklumat.RowHeadersWidth = 51
        dgvMaklumat.Size = New Size(429, 108)
        dgvMaklumat.TabIndex = 20
        ' 
        ' clmBil
        ' 
        clmBil.HeaderText = "Bil"
        clmBil.MinimumWidth = 6
        clmBil.Name = "clmBil"
        clmBil.Width = 125
        ' 
        ' clmNama
        ' 
        clmNama.HeaderText = "Nama"
        clmNama.MinimumWidth = 6
        clmNama.Name = "clmNama"
        clmNama.Width = 125
        ' 
        ' clmNoTelefon
        ' 
        clmNoTelefon.HeaderText = "No. Telefon"
        clmNoTelefon.MinimumWidth = 6
        clmNoTelefon.Name = "clmNoTelefon"
        clmNoTelefon.Width = 125
        ' 
        ' btnCreate
        ' 
        btnCreate.Location = New Point(179, 409)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(94, 29)
        btnCreate.TabIndex = 21
        btnCreate.Text = "create"
        btnCreate.UseVisualStyleBackColor = True
        ' 
        ' btnRead
        ' 
        btnRead.Location = New Point(303, 409)
        btnRead.Name = "btnRead"
        btnRead.Size = New Size(94, 29)
        btnRead.TabIndex = 22
        btnRead.Text = "read"
        btnRead.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(437, 409)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 23
        btnUpdate.Text = "update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(563, 409)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 24
        btnDelete.Text = "delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(37, 172)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(57, 20)
        lblAlamat.TabIndex = 25
        lblAlamat.Text = "Alamat"
        ' 
        ' TxtAlamat
        ' 
        TxtAlamat.Location = New Point(122, 183)
        TxtAlamat.Multiline = True
        TxtAlamat.Name = "TxtAlamat"
        TxtAlamat.Size = New Size(217, 77)
        TxtAlamat.TabIndex = 26
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TxtAlamat)
        Controls.Add(lblAlamat)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnRead)
        Controls.Add(btnCreate)
        Controls.Add(dgvMaklumat)
        Controls.Add(dtpTarikh)
        Controls.Add(gbxPerisa)
        Controls.Add(gbxBayaran)
        Controls.Add(gbxJantina)
        Controls.Add(lblNegeri)
        Controls.Add(cbxNegeri)
        Controls.Add(TxtNoTelefon)
        Controls.Add(lblNoTelefon)
        Controls.Add(TxtNama)
        Controls.Add(lblNama)
        Controls.Add(lblMaklumatPelanggan)
        Name = "Form1"
        Text = "Form1"
        gbxJantina.ResumeLayout(False)
        gbxJantina.PerformLayout()
        gbxBayaran.ResumeLayout(False)
        gbxBayaran.PerformLayout()
        gbxPerisa.ResumeLayout(False)
        gbxPerisa.PerformLayout()
        CType(dgvMaklumat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblMaklumatPelanggan As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents lblNoTelefon As Label
    Friend WithEvents TxtNoTelefon As TextBox
    Friend WithEvents cbxNegeri As ComboBox
    Friend WithEvents lblNegeri As Label
    Friend WithEvents rbtLelaki As RadioButton
    Friend WithEvents rbtPerempuan As RadioButton
    Friend WithEvents gbxJantina As GroupBox
    Friend WithEvents rbtCash As RadioButton
    Friend WithEvents rbtCashless As RadioButton
    Friend WithEvents gbxBayaran As GroupBox
    Friend WithEvents cbxMilo As CheckBox
    Friend WithEvents cbxKopi As CheckBox
    Friend WithEvents cbxCoklat As CheckBox
    Friend WithEvents cbxStrawberi As CheckBox
    Friend WithEvents cbxPisang As CheckBox
    Friend WithEvents gbxPerisa As GroupBox
    Friend WithEvents dtpTarikh As DateTimePicker
    Friend WithEvents dgvMaklumat As DataGridView
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblAlamat As Label
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents clmBil As DataGridViewTextBoxColumn
    Friend WithEvents clmNama As DataGridViewTextBoxColumn
    Friend WithEvents clmNoTelefon As DataGridViewTextBoxColumn

End Class
