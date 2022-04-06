Public Class Dues
    Dim memSelectAll As String
    Dim memSelectAllDept As String
    Dim memSelectAllDeptNo As String
    Dim memUpdateAll As String
    Dim memUpdateAll2 As String
    Dim memUpdate As String
    Private Sub Dues_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        memSelectAll = "SELECT Member_ID,Surname,Firstname ,Othername,
                  Bill ,Payment,Balance  
                  FROM  Members"
        MembersCommandCreation(memSelectAll)

        memSelectAllDept = "SELECT Member_ID,Surname,Firstname ,Othername,
                  Bill ,Payment,Balance  
                  FROM  Members WHERE Balance < 0"
        MembersCommandCreation(memSelectAllDept)

        memSelectAllDeptNo = "SELECT Member_ID,Surname,Firstname ,Othername,
                  Bill ,Payment,Balance  
                  FROM  Members WHERE Balance >= 0"
        MembersCommandCreation(memSelectAllDeptNo)

        DataGridView2.DataSource = MembersCommandCreation(memSelectAll)
        DataGridView1.DataSource = MembersCommandCreation(memSelectAllDept)
        DataGridView3.DataSource = MembersCommandCreation(memSelectAllDeptNo)
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs)
        If TabControl1.SelectedIndex = 1 Then

        End If
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click

        memSelectAll = "SELECT Member_ID,Surname,Firstname ,Othername,
                  Bill ,Payment,Balance  
                  FROM  Members WHERE Firstname = '" & txtsearchfirst.Text & "' And Member_ID = '" & txtsearchsecond.Text & "'"
        MembersCommandCreation(memSelectAll)
        DataGridView2.DataSource = MembersCommandCreation(memSelectAll)
        Label3.Text = txtsearchsecond.Text
        txtsearchsecond.Clear()
        txtsearchfirst.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl1.SelectedIndex = 0
        memSelectAll = "SELECT Member_ID,Surname,Firstname ,Othername,
                  Bill ,Payment,Balance  
                  FROM  Members"
        MembersCommandCreation(memSelectAll)
        DataGridView2.DataSource = MembersCommandCreation(memSelectAll)

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub DataGridView3_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.RowEnter

    End Sub

    Private Sub txtbillcus_TextChanged(sender As Object, e As EventArgs) Handles txtbill.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Label3.Text = Nothing Then
            MessageBox.Show("Kindly search for a member ")
        Else
            memUpdate = "UPDATE Members SET Bill =  Bill + '" & txtbill.Text & "'
                    WHERE Member_ID = '" & Label3.Text & "'"

            memUpdateAll2 = "UPDATE Members SET Balance =  Payment - Bill
                    WHERE Member_ID = '" & Label3.Text & "'"

            memSelectAllDept = "SELECT Member_ID,Surname,Firstname ,Othername,
                  Bill ,Payment,Balance  
                  FROM  Members WHERE Balance < 0"
            MembersCommandCreation(memSelectAllDept)

            memSelectAllDeptNo = "SELECT Member_ID,Surname,Firstname ,Othername,
                  Bill ,Payment,Balance  
                  FROM  Members WHERE Balance >= 0"
            MembersCommandCreation(memSelectAllDeptNo)

            MembersCommandCreation(memUpdate)
            MembersCommandCreation(memUpdateAll2)
            DataGridView2.DataSource = MembersCommandCreation(memSelectAll)
            txtbill.Clear()
        End If
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Private Sub DataGridView2_RowEnter(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            memUpdateAll = "UPDATE Members SET Bill = Bill + '" & TextBox2.Text & "'
                    "
            memUpdateAll2 = "UPDATE Members SET Balance =  Payment - Bill"

            memSelectAllDept = "SELECT Member_ID,Surname,Firstname ,Othername,
                  Bill ,Payment,Balance  
                  FROM  Members WHERE Balance < 0"
            MembersCommandCreation(memSelectAllDept)

            memSelectAllDeptNo = "SELECT Member_ID,Surname,Firstname ,Othername,
                  Bill ,Payment,Balance  
                  FROM  Members WHERE Balance >= 0"
            MembersCommandCreation(memSelectAllDeptNo)

            MembersCommandCreation(memUpdateAll)
            MembersCommandCreation(memUpdateAll2)
            DataGridView1.DataSource = MembersCommandCreation(memSelectAllDept)
            DataGridView3.DataSource = MembersCommandCreation(memSelectAllDeptNo)
            DataGridView2.DataSource = MembersCommandCreation(memSelectAll)
            MessageBox.Show("All Members have been billed successfully")
            TextBox2.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        If Not e.Cancel AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True

            Me.Hide()
            Dim home = New Home
            home.Show()

        End If
    End Sub

    Private Sub txtpayment_Click(sender As Object, e As EventArgs) Handles txtpayment.Click
        If Label3.Text = Nothing Then
            MessageBox.Show("Kindly search for a member ")
        Else
            memUpdate = "UPDATE Members SET Payment = Payment + '" & txt.Text & "'
                    WHERE Member_ID = '" & Label3.Text & "'"

            memUpdateAll2 = "UPDATE Members SET Balance =  Payment -Bill
                    WHERE Member_ID = '" & Label3.Text & "'"

            memSelectAllDept = "SELECT Member_ID,Surname,Firstname ,Othername,
                  Bill ,Payment,Balance  
                  FROM  Members WHERE Balance < 0"
            MembersCommandCreation(memSelectAllDept)

            memSelectAllDeptNo = "SELECT Member_ID,Surname,Firstname ,Othername,
                  Bill ,Payment,Balance  
                  FROM  Members WHERE Balance >= 0"
            MembersCommandCreation(memSelectAllDeptNo)
            MembersCommandCreation(memUpdate)
            MembersCommandCreation(memUpdateAll2)
            DataGridView1.DataSource = MembersCommandCreation(memSelectAllDept)
            DataGridView3.DataSource = MembersCommandCreation(memSelectAllDeptNo)
            DataGridView2.DataSource = MembersCommandCreation(memSelectAll)

            txt.Clear()
        End If
    End Sub
End Class