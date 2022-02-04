Imports MySql.Data.MySqlClient
Public Class frmLogin
    Dim conn As New MySqlConnection
    Dim com As New MySqlCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        conn = New MySqlConnection
        conn.ConnectionString = "Server=localhost;userid=root;password=;database=mush"
        Dim myreader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "select * FROM admin WHERE Username='" & txtUser.Text & "'  AND  password='" & txtPass.Text & "' "
            com = New MySqlCommand(query, conn)
            myreader = com.ExecuteReader

            If myreader.Read Then
                frmHome.Show()
                Me.Hide()
                frmHome.txtBillNo.Text = ""
            Else
                lblerror.Text = "Invalid credintials"
                lblerror.Visible = True
                Me.Show()
                txtUser.Clear()
                txtPass.Clear()

            End If


            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    'validate username
    Private Sub txtUser_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUser.Validating
        If String.IsNullOrEmpty(txtUser.Text) Then
            ErrorProvider1.SetError(txtUser, "Name is required")
        Else
            ErrorProvider1.SetError(txtUser, String.Empty)
        End If
    End Sub
    'validate password
    Private Sub txtPass_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPass.Validating
        If String.IsNullOrEmpty(txtPass.Text) Then
            ErrorProvider2.SetError(txtPass, "Password is required")
        Else
            ErrorProvider2.SetError(txtPass, String.Empty)
        End If
    End Sub

    'Show password
    Private Sub cbShow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbShow.CheckedChanged
        If cbShow.Checked = True Then
            txtPass.UseSystemPasswordChar() = False
            cbShow.Text = "Hide  "
        Else
            txtPass.UseSystemPasswordChar() = True
            cbShow.Text = "Show"
        End If



    End Sub

    'forget password
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("Please contact your databse administrator" & vbNewLine & "Only specified admins have permission")
    End Sub
    
End Class
