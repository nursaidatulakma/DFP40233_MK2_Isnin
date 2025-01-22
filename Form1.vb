Public Class Form1
    ' Declare a DataTable to hold the customer data
    Dim customerTable As New DataTable()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the DataGridView columns
        customerTable.Columns.Add("Bil", GetType(Integer))
        customerTable.Columns.Add("Nama", GetType(String))
        customerTable.Columns.Add("No. Telefon", GetType(String))
        dgvMaklumat.DataSource = customerTable

        ' Populate the Negeri dropdown
        cbxNegeri.Items.AddRange(New String() {"Johor", "Kedah", "Kelantan", "Melaka", "Negeri Sembilan", "Pahang", "Penang", "Perak", "Perlis", "Sabah", "Sarawak", "Selangor", "Terengganu"})
        cbxNegeri.SelectedIndex = 0
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ' Validate that the required fields are not empty
        If String.IsNullOrWhiteSpace(TxtNama.Text) OrElse String.IsNullOrWhiteSpace(TxtNoTelefon.Text) Then
            MessageBox.Show("Please fill in both the Name and Phone Number fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Create a new row in the DataTable
        Dim newRow As DataRow = customerTable.NewRow()

        ' Populate the row with data from input fields
        newRow("Bil") = customerTable.Rows.Count + 1 ' Auto-increment for the "Bil" column
        newRow("Nama") = TxtNama.Text
        newRow("No. Telefon") = TxtNoTelefon.Text

        ' Add the new row to the DataTable
        customerTable.Rows.Add(newRow)

        ' Clear input fields after adding
        ClearFields()

        ' Provide feedback to the user
        MessageBox.Show("Customer record created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub BtnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        ' Display the selected row details in the input fields
        If dgvMaklumat.CurrentRow IsNot Nothing Then
            Dim rowIndex As Integer = dgvMaklumat.CurrentRow.Index
            TxtNama.Text = customerTable.Rows(rowIndex)("Nama").ToString()
            TxtNoTelefon.Text = customerTable.Rows(rowIndex)("No. Telefon").ToString()
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Check if a row is selected in the DataGridView
        If dgvMaklumat.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a row to update.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validate that the required fields are not empty
        If String.IsNullOrWhiteSpace(TxtNama.Text) OrElse String.IsNullOrWhiteSpace(TxtNoTelefon.Text) Then
            MessageBox.Show("Please fill in both the Name and Phone Number fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Get the index of the selected row
        Dim rowIndex As Integer = dgvMaklumat.CurrentRow.Index

        ' Update the selected row with data from input fields
        customerTable.Rows(rowIndex)("Nama") = TxtNama.Text
        customerTable.Rows(rowIndex)("No. Telefon") = TxtNoTelefon.Text

        ' Refresh the DataGridView (if necessary)
        dgvMaklumat.Refresh()

        ' Clear input fields after updating
        ClearFields()

        ' Provide feedback to the user
        MessageBox.Show("Customer record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Check if a row is selected in the DataGridView
        If dgvMaklumat.CurrentRow IsNot Nothing Then
            ' Get the index of the selected row
            Dim rowIndex As Integer = dgvMaklumat.CurrentRow.Index

            ' Confirm deletion
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                ' Delete the row from the DataTable
                customerTable.Rows(rowIndex).Delete()

                ' Refresh DataGridView after deletion (if necessary)
                dgvMaklumat.DataSource = Nothing
                dgvMaklumat.DataSource = customerTable

                ' Clear input fields
                ClearFields()
            End If
        Else
            ' Display a message if no row is selected
            MessageBox.Show("Please select a row to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub ClearFields()
        ' Clear input fields
        TxtNama.Clear()
        TxtNoTelefon.Clear()
        TxtAlamat.Clear()
        cbxNegeri.SelectedIndex = 0
        rbtLelaki.Checked = False
        rbtPerempuan.Checked = False
        cbxMilo.Checked = False
        cbxKopi.Checked = False
        cbxCoklat.Checked = False
        cbxStrawberi.Checked = False
        cbxPisang.Checked = False
        rbtCash.Checked = False
        rbtCashless.Checked = False
    End Sub


End Class



