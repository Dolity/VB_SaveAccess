Imports System.Data.OleDb
Public Class Form1

    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter(cmd)

    Private bitmap As Bitmap


    Private Sub viewer()

        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()

        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jakki\Documents\Database1.accdb")
            conn.Open()

            Using cmd As New OleDbCommand("SELECT * FROM vbsavedata", conn)
                Using da As New OleDbDataAdapter(cmd)
                    Dim dataTable As New DataTable
                    da.Fill(dataTable)
                    DataGridView1.DataSource = dataTable
                End Using
            End Using
        End Using

        DataGridView1.Columns(0).Width = 100
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 80
        DataGridView1.Columns(4).Width = 80
        DataGridView1.Columns(5).Width = 90

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtSearch.Text = "Search"
        txtSearch.ForeColor = Color.Silver

        viewer()

    End Sub

    Private Sub btnSaveData_Click(sender As Object, e As EventArgs) Handles btnSaveData.Click
        Try
            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jakki\Documents\Database1.accdb")
                conn.Open()

                Using cmd As New OleDbCommand("INSERT INTO vbsavedata (StudentID, Firstname, Surname, Address, Postcode, Telephone) VALUES (@StudentID, @Firstname, @Surname, @Address, @Postcode, @Telephone)", conn)
                    cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text)
                    cmd.Parameters.AddWithValue("@Firstname", txtFirstname.Text)
                    cmd.Parameters.AddWithValue("@Surname", txtSurname.Text)
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                    cmd.Parameters.AddWithValue("@Postcode", txtPostCode.Text)
                    cmd.Parameters.AddWithValue("@Telephone", txtTelephone.Text)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    MsgBox(rowsAffected)

                    If rowsAffected > 0 Then
                        MessageBox.Show("Record Saved MS Access", "VB Save Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        viewer()
                    Else
                        MessageBox.Show("Failed to save record", "VB Save Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jakki\Documents\Database1.accdb")
                conn.Open()

                Using cmd As New OleDbCommand("UPDATE vbsavedata SET StudentID = @StudentID, Firstname = @Firstname, Surname = @Surname, Address = @Address, Postcode = @Postcode, Telephone = @Telephone WHERE Firstname = @Firstname", conn)
                    cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text)
                    cmd.Parameters.AddWithValue("@Firstname", txtFirstname.Text)
                    cmd.Parameters.AddWithValue("@Surname", txtSurname.Text)
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                    cmd.Parameters.AddWithValue("@Postcode", txtPostCode.Text)
                    cmd.Parameters.AddWithValue("@Telephone", txtTelephone.Text)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    MsgBox(rowsAffected)

                    If rowsAffected > 0 Then
                        MessageBox.Show("Record Successfully Updated", "VB Save Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        btnSearch_Click(New Object, New EventArgs())
                        viewer()
                    Else
                        MessageBox.Show("Failed to save record", "VB Save Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Try
            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jakki\Documents\Database1.accdb")
                conn.Open()

                Using cmd As New OleDbCommand("DELETE * FROM vbsavedata WHERE StudentID = @StudentID", conn)
                    cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text)
                    cmd.Parameters.AddWithValue("@Firstname", txtFirstname.Text)
                    cmd.Parameters.AddWithValue("@Surname", txtSurname.Text)
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                    cmd.Parameters.AddWithValue("@Postcode", txtPostCode.Text)
                    cmd.Parameters.AddWithValue("@Telephone", txtTelephone.Text)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    MsgBox(rowsAffected)

                    If rowsAffected > 0 Then
                        MessageBox.Show("Record Successfully Deleted", "VB Save Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        btnSearch_Click(New Object, New EventArgs())
                        viewer()
                        txtStudentID.Text = ""
                        txtFirstname.Text = ""
                        txtSurname.Text = ""
                        txtAddress.Text = ""
                        txtPostCode.Text = ""
                        txtTelephone.Text = ""
                        txtSearch.Text = "Search"

                    Else
                        MessageBox.Show("Failed to save record", "VB Save Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtStudentID.Text = ""
        txtFirstname.Text = ""
        txtSurname.Text = ""
        txtAddress.Text = ""
        txtPostCode.Text = ""
        txtTelephone.Text = ""
        txtSearch.Text = "Search"
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim height As Integer = DataGridView1.Height

        Try

            DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height
            bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
            DataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
            PrintPreviewDialog1.ShowDialog()
            DataGridView1.Height = height

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub View_Click(sender As Object, e As EventArgs) Handles View.Click
        viewer()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim checker As Integer

        Try
            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jakki\Documents\Database1.accdb")
                conn.Open()

                Using cmd As New OleDbCommand("SELECT * FROM vbsavedata WHERE StudentID = @StudentID OR Firstname = @Firstname OR Surname = @Surname OR Address = @Address OR Postcode = @Postcode OR Telephone = @Telephone", conn)
                    cmd.Parameters.AddWithValue("@StudentID", txtSearch.Text)
                    cmd.Parameters.AddWithValue("@Firstname", txtSearch.Text)
                    cmd.Parameters.AddWithValue("@Surname", txtSearch.Text)
                    cmd.Parameters.AddWithValue("@Address", txtSearch.Text)
                    cmd.Parameters.AddWithValue("@Postcode", txtSearch.Text)
                    cmd.Parameters.AddWithValue("@Telephone", txtSearch.Text)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    dt = New DataTable()
                    da = New OleDbDataAdapter(cmd)
                    da.Fill(dt)
                    checker = Convert.ToInt32(dt.Rows.Count.ToString)
                    DataGridView1.DataSource = dt

                    MsgBox(rowsAffected)

                    If checker = 0 Then
                        txtSearch.Text = "Search"
                    Else

                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Are you sure to exit", "Access Database", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            txtStudentID.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
            txtFirstname.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            txtSurname.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            txtAddress.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
            txtPostCode.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString
            txtTelephone.Text = DataGridView1.SelectedRows(0).Cells(5).Value.ToString

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Try

            e.Graphics.DrawImage(bitmap, 0, 0)

            Dim recP As RectangleF = e.PageSettings.PrintableArea

            If Me.DataGridView1.Height - recP.Height > 0 Then e.HasMorePages = True




        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtSearch_MouseEnter(sender As Object, e As EventArgs) Handles txtSearch.MouseEnter
        txtSearch.Text = ""
        txtSearch.Focus()
        txtSearch.ForeColor = Color.Black
    End Sub

    Private Sub txtSearch_MouseLeave(sender As Object, e As EventArgs) Handles txtSearch.MouseLeave
        If txtSearch.Text = "" Then
            txtSearch.Text = "Search"
            txtSearch.ForeColor = Color.Silver

        End If
    End Sub
End Class
