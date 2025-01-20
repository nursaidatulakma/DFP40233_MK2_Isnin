Public Class Form1
    ' Data structure to hold customer records
    Private CustomerList As New List(Of Customer)

    ' Customer class to hold information
    Private Class Customer
        Public Property Nama As String
        Public Property NoTelefon As String
        Public Property Alamat As String
        Public Property Negeri As String
        Public Property Date As Date
        Public Property Jantina As String
        Public Property Bayaran As String
        Public Property Perisa As String
    End Class

    ' Create button event
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        Dim flavors As String = String.Join(", ", GetSelectedFlavors())

        ' Add a new customer record
        CustomerList.Add(New Customer With {
            .Nama = txtNama.Text,
            .NoTelefon = txtNoTelefon.Text,
            .Alamat = txtAlamat.Text,
            .Negeri = cmbNegeri.Text,
            .Date = dtpDate.Value,
            .Jantina = If(rbMale.Checked, "Male", "Female"),
            .Payment = If(rbCash.Checked, "Cash", "Cashless"),
            .Flavors = flavors
        })

        RefreshGrid()
        ClearInputs()
    End Sub

    ' Read button event
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnread.Click
        RefreshGrid()
    End Sub

    ' Update button event
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If dgvCustomers.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvCustomers.SelectedRows(0).Index
            Dim selectedCustomer = CustomerList(selectedRow)

            ' Update the selected customer record
            selectedCustomer.Name = txtName.Text
            selectedCustomer.Phone = txtPhone.Text
            selectedCustomer.Address = txtAddress.Text
            selectedCustomer.State = cmbState.Text
            selectedCustomer.DateJoined = dtpDate.Value
            selectedCustomer.Gender = If(rbMale.Checked, "Male", "Female")
            selectedCustomer.Payment = If(rbCash.Checked, "Cash", "Cashless")
            selectedCustomer.Flavors = String.Join(", ", GetSelectedFlavors())

            RefreshGrid()
            ClearInputs()
        End If
    End Sub

    ' Delete button event
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If dgvCustomers.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvCustomers.SelectedRows(0).Index
            CustomerList.RemoveAt(selectedRow)
            RefreshGrid()
        End If
    End Sub

    ' Refresh the data grid view with updated customer data
    Private Sub RefreshGrid()
        dgvCustomers.Rows.Clear()
        For Each customer In CustomerList
            dgvCustomers.Rows.Add(dgvCustomers.Rows.Count + 1, customer.Name, customer.Phone)
        Next
    End Sub

    ' Clear input fields
    Private Sub ClearInputs()
        txtName.Clear()
        txtPhone.Clear()
        txtAddress.Clear()
        cmbState.SelectedIndex = -1
        dtpDate.Value = Date.Now
        rbMale.Checked = True
        rbCash.Checked = True
        UncheckFlavors()
    End Sub

    ' Get selected flavors from checkboxes
    Private Function GetSelectedFlavors() As List(Of String)
        Dim flavors As New List(Of String)
        If chkmilo.Checked Then flavors.Add("Milo")
        If chkCoffee.Checked Then flavors.Add("Coffee")
        If chkChocolate.Checked Then flavors.Add("Chocolate")
        If chkStrawberry.Checked Then flavors.Add("Strawberry")
        If chkBanana.Checked Then flavors.Add("Banana")
        Return flavors
    End Function

    ' Uncheck all flavor checkboxes
    Private Sub UncheckFlavors()
        chkmilo.Checked = False
        chkCoffee.Checked = False
        chkChocolate.Checked = False
        chkStrawberry.Checked = False
        chkBanana.Checked = False
    End Sub
End Class

