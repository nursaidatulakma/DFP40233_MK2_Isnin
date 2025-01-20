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
        Label1 = New Label()
        Label2 = New Label()
        txtNama = New TextBox()
        Label3 = New Label()
        txtNoTelefon = New TextBox()
        cmbNegeri = New ComboBox()
        Label4 = New Label()
        rbLelaki = New RadioButton()
        rbPerempuan = New RadioButton()
        GroupBox1 = New GroupBox()
        rbCash = New RadioButton()
        rbCashless = New RadioButton()
        GroupBox2 = New GroupBox()
        chkmilo = New CheckBox()
        chkkopi = New CheckBox()
        chkcoklat = New CheckBox()
        chkstrawberi = New CheckBox()
        chkpisang = New CheckBox()
        GroupBox3 = New GroupBox()
        dtpDate = New DateTimePicker()
        dgvPelanggan = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        btncreate = New Button()
        btnread = New Button()
        btnupdate = New Button()
        btndelete = New Button()
        Label5 = New Label()
        txtAlamat = New TextBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(dgvPelanggan, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(190, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(177, 20)
        Label1.TabIndex = 0
        Label1.Text = "MAKLUMAT PELANGGAN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 1
        Label2.Text = "Nama"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(122, 95)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(317, 27)
        txtNama.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(31, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 20)
        Label3.TabIndex = 3
        Label3.Text = "No. Telefon"
        ' 
        ' txtNoTelefon
        ' 
        txtNoTelefon.Location = New Point(122, 135)
        txtNoTelefon.Name = "txtNoTelefon"
        txtNoTelefon.Size = New Size(217, 27)
        txtNoTelefon.TabIndex = 4
        ' 
        ' cmbNegeri
        ' 
        cmbNegeri.FormattingEnabled = True
        cmbNegeri.Items.AddRange(New Object() {"Perlis", "Kedah", "Pulau Pinang", "Perak", "Selangor", "Melaka ", "Johor", "Terengganu", "Kelantan", "Sabah", "Sarawak", "Negeri Sembilan", "Pahang"})
        cmbNegeri.Location = New Point(537, 98)
        cmbNegeri.Name = "cmbNegeri"
        cmbNegeri.Size = New Size(151, 28)
        cmbNegeri.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(477, 98)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 20)
        Label4.TabIndex = 6
        Label4.Text = "Negeri"
        ' 
        ' rbLelaki
        ' 
        rbLelaki.AutoSize = True
        rbLelaki.Location = New Point(6, 26)
        rbLelaki.Name = "rbLelaki"
        rbLelaki.Size = New Size(68, 24)
        rbLelaki.TabIndex = 7
        rbLelaki.TabStop = True
        rbLelaki.Text = "Lelaki"
        rbLelaki.UseVisualStyleBackColor = True
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(6, 56)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 8
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbPerempuan)
        GroupBox1.Controls.Add(rbLelaki)
        GroupBox1.Location = New Point(419, 207)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(144, 87)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Jantina"
        ' 
        ' rbCash
        ' 
        rbCash.AutoSize = True
        rbCash.Location = New Point(6, 26)
        rbCash.Name = "rbCash"
        rbCash.Size = New Size(61, 24)
        rbCash.TabIndex = 10
        rbCash.TabStop = True
        rbCash.Text = "Cash"
        rbCash.UseVisualStyleBackColor = True
        ' 
        ' rbCashless
        ' 
        rbCashless.AutoSize = True
        rbCashless.Location = New Point(6, 56)
        rbCashless.Name = "rbCashless"
        rbCashless.Size = New Size(85, 24)
        rbCashless.TabIndex = 11
        rbCashless.TabStop = True
        rbCashless.Text = "Cashless"
        rbCashless.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(rbCash)
        GroupBox2.Controls.Add(rbCashless)
        GroupBox2.Location = New Point(615, 207)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(144, 96)
        GroupBox2.TabIndex = 12
        GroupBox2.TabStop = False
        GroupBox2.Text = "Bayaran"
        ' 
        ' chkmilo
        ' 
        chkmilo.AutoSize = True
        chkmilo.Location = New Point(6, 26)
        chkmilo.Name = "chkmilo"
        chkmilo.Size = New Size(61, 24)
        chkmilo.TabIndex = 13
        chkmilo.Text = "milo"
        chkmilo.UseVisualStyleBackColor = True
        ' 
        ' chkkopi
        ' 
        chkkopi.AutoSize = True
        chkkopi.Location = New Point(7, 56)
        chkkopi.Name = "chkkopi"
        chkkopi.Size = New Size(60, 24)
        chkkopi.TabIndex = 14
        chkkopi.Text = "kopi"
        chkkopi.UseVisualStyleBackColor = True
        ' 
        ' chkcoklat
        ' 
        chkcoklat.AutoSize = True
        chkcoklat.Location = New Point(6, 86)
        chkcoklat.Name = "chkcoklat"
        chkcoklat.Size = New Size(71, 24)
        chkcoklat.TabIndex = 15
        chkcoklat.Text = "coklat"
        chkcoklat.UseVisualStyleBackColor = True
        ' 
        ' chkstrawberi
        ' 
        chkstrawberi.AutoSize = True
        chkstrawberi.Location = New Point(91, 26)
        chkstrawberi.Name = "chkstrawberi"
        chkstrawberi.Size = New Size(92, 24)
        chkstrawberi.TabIndex = 16
        chkstrawberi.Text = "strawberi"
        chkstrawberi.UseVisualStyleBackColor = True
        ' 
        ' chkpisang
        ' 
        chkpisang.AutoSize = True
        chkpisang.Location = New Point(91, 56)
        chkpisang.Name = "chkpisang"
        chkpisang.Size = New Size(75, 24)
        chkpisang.TabIndex = 17
        chkpisang.Text = "pisang"
        chkpisang.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(chkmilo)
        GroupBox3.Controls.Add(chkpisang)
        GroupBox3.Controls.Add(chkkopi)
        GroupBox3.Controls.Add(chkstrawberi)
        GroupBox3.Controls.Add(chkcoklat)
        GroupBox3.Location = New Point(31, 266)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(193, 121)
        GroupBox3.TabIndex = 18
        GroupBox3.TabStop = False
        GroupBox3.Text = "Perisa"
        ' 
        ' dtpDate
        ' 
        dtpDate.Location = New Point(477, 144)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(250, 27)
        dtpDate.TabIndex = 19
        ' 
        ' dgvPelanggan
        ' 
        dgvPelanggan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPelanggan.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        dgvPelanggan.Location = New Point(320, 328)
        dgvPelanggan.Name = "dgvPelanggan"
        dgvPelanggan.RowHeadersWidth = 51
        dgvPelanggan.Size = New Size(429, 59)
        dgvPelanggan.TabIndex = 20
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Bil"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Nama"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "No. Telefon"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' btncreate
        ' 
        btncreate.Location = New Point(179, 409)
        btncreate.Name = "btncreate"
        btncreate.Size = New Size(94, 29)
        btncreate.TabIndex = 21
        btncreate.Text = "create"
        btncreate.UseVisualStyleBackColor = True
        ' 
        ' btnread
        ' 
        btnread.Location = New Point(303, 409)
        btnread.Name = "btnread"
        btnread.Size = New Size(94, 29)
        btnread.TabIndex = 22
        btnread.Text = "read"
        btnread.UseVisualStyleBackColor = True
        ' 
        ' btnupdate
        ' 
        btnupdate.Location = New Point(437, 409)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(94, 29)
        btnupdate.TabIndex = 23
        btnupdate.Text = "update"
        btnupdate.UseVisualStyleBackColor = True
        ' 
        ' btndelete
        ' 
        btndelete.Location = New Point(563, 409)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(94, 29)
        btndelete.TabIndex = 24
        btndelete.Text = "delete"
        btndelete.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(37, 172)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 20)
        Label5.TabIndex = 25
        Label5.Text = "Alamat"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(122, 183)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(217, 77)
        txtAlamat.TabIndex = 26
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtAlamat)
        Controls.Add(Label5)
        Controls.Add(btndelete)
        Controls.Add(btnupdate)
        Controls.Add(btnread)
        Controls.Add(btncreate)
        Controls.Add(dgvPelanggan)
        Controls.Add(dtpDate)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label4)
        Controls.Add(cmbNegeri)
        Controls.Add(txtNoTelefon)
        Controls.Add(Label3)
        Controls.Add(txtNama)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(dgvPelanggan, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNoTelefon As TextBox
    Friend WithEvents cmbNegeri As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents rbLelaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbCash As RadioButton
    Friend WithEvents rbCashless As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkmilo As CheckBox
    Friend WithEvents chkkopi As CheckBox
    Friend WithEvents chkcoklat As CheckBox
    Friend WithEvents chkstrawberi As CheckBox
    Friend WithEvents chkpisang As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents dgvPelanggan As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents btncreate As Button
    Friend WithEvents btnread As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAlamat As TextBox

End Class
