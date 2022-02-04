Imports MySql.Data.MySqlClient
Public Class frmHome
            
    Dim conn As New MySqlConnection
    Dim com As New MySqlCommand
    Dim myreader As MySqlDataReader

    '*****************************************Form load****************************************************
    Private Sub frmHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'connection code
        conn = New MySqlConnection
        conn.ConnectionString = "Server=localhost;userid=root;password=;database=mush"

        'currrent date on calculation page

        For x = 1999 To 2999
            cmbYear.Items.Add(x.ToString)
        Next

        cmbYear.Items.Insert(0, DateTime.Now.Year)
        cmbYear.SelectedIndex = 0

        cmbMonth.Items.Insert(0, DateTime.Now.ToString("MMMM"))
        cmbMonth.SelectedIndex = 0

        day.Text = DateTime.Now.Day & "th of"


        'current year, month on customer page

        cmbYear1.Items.Insert(0, DateTime.Now.Year)
        cmbYear1.SelectedIndex = 0

        cmbMon.Items.Insert(0, DateTime.Now.ToString("MMMM"))
        cmbMon.SelectedIndex = 0

        For x = 1999 To 2999
            cmbYear1.Items.Add(x.ToString)
        Next
        cmbYear1.MaxDropDownItems = 10
    End Sub
    '*******************************************************************************************************

    '*****************************************Tab load****************************************************
    Private Sub tabControl_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabControl.MouseClick
        'clearing all fields 
        txtBillNo.Text = ""
        txtName.Text = ""
        txtAdd.Text = ""
        txtEmail.Text = ""

        lblinfo.Visible = False

        cmbBill2.SelectedIndex = -1
        cmbYear.SelectedIndex = 0
        cmbMonth.SelectedIndex = 0
        txtCalUnit.Text = ""


        txtSum.Visible = False
        btnSave.Visible = False
        txtacknow.Visible = False

        lblread.Visible = False
        'combo box for bill number in calculation page
        Try

            conn.Open()
            cmbBill2.Items.Clear()
            Dim query As String
            query = "SELECT billNo FROM customer"
            com = New MySqlCommand(query, conn)
            myreader = com.ExecuteReader
            While myreader.Read
                Dim sbill = myreader.GetString("billNo")
                cmbBill2.Items.Add(sbill)
            End While

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

        'combo box for bill number in customer details page
        Try

            conn.Open()
            cmbBill1.Items.Clear()
            Dim query As String
            query = "SELECT billNo FROM customer"
            com = New MySqlCommand(query, conn)
            myreader = com.ExecuteReader
            While myreader.Read
                Dim sbill = myreader.GetString("billNo")
                cmbBill1.Items.Add(sbill)
            End While

            cmbBill1.Items.Insert(0, "All")
            cmbBill1.SelectedIndex = 0

            
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

        

    End Sub
    '*******************************************************************************************************


    '***************************************** Registration page****************************************************

    'register button
    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click

        Try
            conn.Open()

            Dim query As String
            query = "INSERT INTO customer VALUES (@bn,@name,@email,@add)"
            com = New MySqlCommand(query, conn)

            com.Parameters.Add("@bn", MySqlDbType.VarChar).Value = txtBillNo.Text
            com.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtName.Text
            com.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtAdd.Text
            com.Parameters.Add("@add", MySqlDbType.VarChar).Value = txtEmail.Text

            If txtBillNo.Text <> "" And txtName.Text <> "" And txtAdd.Text <> "" And txtEmail.Text <> "" Then
                If com.ExecuteNonQuery() = 1 Then
                    lblinfo.Text = "Customer successfully registered"
                End If
            Else
                lblinfo.Text = "Complete all the fields"
            End If

            conn.Close()
        Catch ex As Exception
            lblinfo.Text = ex.Message
        Finally
            lblinfo.Visible = True
            conn.Dispose()
        End Try
    End Sub

    'Reset button
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        txtBillNo.Text = ""
        txtName.Text = ""
        txtAdd.Text = ""
        txtEmail.Text = ""

        lblinfo.Visible = False
    End Sub

    'delete button
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            conn.Open()

            Dim query As String
            query = "DELETE FROM customer WHERE billNo  = '" & txtBillNo.Text & "' "
            com = New MySqlCommand(query, conn)

            If com.ExecuteNonQuery() = 1 Then
                lblinfo.Text = "Customer successfully Removed"
            End If

            conn.Close()
        Catch ex As Exception
            lblinfo.Text = ex.Message
        Finally
            lblinfo.Visible = True
            conn.Dispose()
        End Try
    End Sub

    'update button
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            conn.Open()

            Dim query As String
            query = "UPDATE customer SET email='" & txtEmail.Text & "', address='" & txtAdd.Text & "' WHERE billNo  = '" & txtBillNo.Text & "' "
            com = New MySqlCommand(query, conn)

            If com.ExecuteNonQuery() = 1 Then
                lblinfo.Text = "Customer successfully updated"
            End If

            conn.Close()
        Catch ex As Exception
            lblinfo.Text = ex.Message
        Finally
            lblinfo.Visible = True
            conn.Dispose()
        End Try
    End Sub



    'Show last user added, from label
    Private Sub txtBillNo_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBillNo.MouseHover
        Try

            conn.Open()

            Dim query As String
            Dim id As String
            query = "SELECT MAX(billNo) FROM customer"
            com = New MySqlCommand(query, conn)
            If com.ExecuteScalar().Equals(System.DBNull.Value) Then     'exception handled
                lblLastUser.Text = "No customers,Register for new customer"
                lblLastUser.Visible = True

            Else
                id = com.ExecuteScalar()

                lblLastUser.Text = "Last customer : " & id.ToString()
                lblLastUser.Visible = True

                If id < 10 Then
                    txtBillNo.Text = "000" & id + 1
                ElseIf id < 100 Then
                    txtBillNo.Text = "00" & id + 1
                ElseIf id < 1000 Then
                    txtBillNo.Text = "0" & id + 1
                Else
                    txtBillNo.Text = id + 1
                End If

            End If

           

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    'Remove last user added, from label
    Private Sub txtBillNo_MouseLeave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBillNo.MouseLeave
        lblLastUser.Visible = False
    End Sub

    '*********************************************End of registration page**********************************************************



    '*******************************************Calculation page************************************************************
    'calculate
    Dim sum As Double
    Private Sub btnCal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCal.Click
        Dim calUnit As Integer = 0


        calUnit = Val(txtCalUnit.Text)

        If (calUnit >= 0 And calUnit <= 5) Then
            sum = calUnit * 12

        ElseIf (calUnit <= 10) Then
            sum = 5 * 12 + (calUnit - 5) * 16

        ElseIf (calUnit <= 15) Then
            sum = 5 * 12 + 5 * 16 + (calUnit - 10) * 20

        ElseIf (calUnit <= 20) Then
            sum = 5 * 12 + 5 * 16 + 5 * 20 + (calUnit - 15) * 40

        ElseIf (calUnit <= 25) Then
            sum = 5 * 12 + 5 * 16 + 5 * 20 + 5 * 40 + (calUnit - 20) * 58

        ElseIf (calUnit <= 30) Then
            sum = 5 * 12 + 5 * 16 + 5 * 20 + 5 * 40 + 5 * 58 + (calUnit - 25) * 88

        ElseIf (calUnit <= 40) Then
            sum = 5 * 12 + 5 * 16 + 5 * 20 + 5 * 40 + 5 * 58 + 10 * 88 + (calUnit - 30) * 105

        ElseIf (calUnit <= 50) Then
            sum = 5 * 12 + 5 * 16 + 5 * 20 + 5 * 40 + 5 * 58 + 10 * 88 + 10 * 105 + (calUnit - 40) * 120

        ElseIf (calUnit <= 75) Then
            sum = 5 * 12 + 5 * 16 + 5 * 20 + 5 * 40 + 5 * 58 + 10 * 88 + 10 * 105 + 10 * 120 + (calUnit - 50) * 130
        Else
            sum = 5 * 12 + 5 * 16 + 5 * 20 + 5 * 40 + 5 * 58 + 10 * 88 + 10 * 105 + 10 * 120 + 25 * 130 + (calUnit - 75) * 140
        End If


        txtSum.Text = "LKR  " & sum
        txtSum.Visible = True
        btnSave.Visible = True

    End Sub

    ' Save calculation
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            conn.Open()
            Dim query As String
            query = "INSERT INTO customer_bill VALUES ('" & cmbBill2.Text & "','" & cmbYear.Text & "','" & cmbMonth.Text & "','" & txtCalUnit.Text & "','" & txtSum.Text & "')"
            com = New MySqlCommand(query, conn)

            If cmbBill2.Text <> "" And txtCalUnit.Text <> "" And txtSum.Text <> "" Then

                If com.ExecuteNonQuery() = 1 Then
                    txtacknow.Text = "Bill amount added sucessfully"
                End If

            Else
                txtacknow.Text = "Complete all fields"
            End If

            conn.Close()

        Catch ex As Exception
            txtacknow.Text = ex.Message
        Finally
            txtacknow.Visible = True
            conn.Dispose()
        End Try
    End Sub

    'Reset button
    Private Sub btnResetCal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetCal.Click
        cmbBill2.SelectedIndex = -1
        cmbYear.SelectedIndex = 0
        cmbMonth.SelectedIndex = 0
        txtCalUnit.Text = ""

        btnSave.Visible = False
        txtSum.Visible = False
        txtacknow.Visible = False
    End Sub

    'auto reset if index changed
    Private Sub cmbBill2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBill2.SelectedIndexChanged

        txtSum.Visible = False
        txtacknow.Visible = False
    End Sub

    'Next customer
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        txtCalUnit.Text = ""


        btnSave.Visible = False
        txtSum.Visible = False
        txtacknow.Visible = False
        Dim x As Integer
        Try
            x = cmbBill2.SelectedIndex
            cmbBill2.SelectedIndex = x + 1
        Catch
            txtacknow.Text = "No more users"
            txtacknow.Visible = True
        End Try

    End Sub

    '******************************************calculation page end*********************************************************



    '*******************************************customer_details ***********************************************************
    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click, cmbBill1.SelectedIndexChanged, cmbMon.SelectedIndexChanged, cmbYear1.SelectedIndexChanged
        DataGridView1.Rows.Clear()
        lblread.Visible = False
        conn.Close()
        Try

            conn.Open()
            Dim query As String
            If cmbMon.SelectedItem = "All" And cmbBill1.SelectedItem = "All" Then
                query = "SELECT customer.billNo,name,month,Units_consumed,charge FROM customer_bill INNER JOIN customer ON customer_bill.billNo=customer.billNo WHERE year='" & cmbYear1.Text & "' "

            ElseIf cmbMon.SelectedItem = "All" Then
                query = "SELECT customer.billNo,name,month,Units_consumed,charge FROM customer_bill INNER JOIN customer ON customer_bill.billNo=customer.billNo  WHERE year='" & cmbYear1.Text & "' AND customer.billNo='" & cmbBill1.Text & "'  "
            ElseIf cmbBill1.SelectedItem = "All" Then
                query = "SELECT customer.billNo,name,month,Units_consumed,charge FROM customer_bill INNER JOIN customer ON customer_bill.billNo=customer.billNo  WHERE year='" & cmbYear1.Text & "'  AND month='" & cmbMon.Text & "' "
            Else
                query = "SELECT customer.billNo,name,month,Units_consumed,charge FROM customer_bill INNER JOIN customer ON customer_bill.billNo=customer.billNo WHERE year='" & cmbYear1.Text & "'  AND month='" & cmbMon.Text & "' AND customer.billNo='" & cmbBill1.Text & "' "
            End If

            com = New MySqlCommand(query, conn)

            myreader = com.ExecuteReader

            While myreader.Read
                DataGridView1.Rows.Add(myreader.GetString("billNo"), myreader.GetString("name"), myreader.GetString("month"), myreader.GetString("Units_consumed"), myreader.GetString("charge"))
                If myreader.IsDBNull(0) Then
                    lblread.Text = "No customers"
                    lblread.Visible = True
                End If
            End While
            'sorting
            DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    '**************************************************End of customer detail page*****************************************************

    '******************************************logout btn ***********************************************************
    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        frmLogin.txtUser.Text = ""
        frmLogin.txtPass.Text = ""
        Me.Hide()
        frmLogin.Show()
    End Sub
    '******************************************************************************************************

End Class
