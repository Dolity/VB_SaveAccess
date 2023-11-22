<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Panel5 = New Panel()
        btnExit = New Button()
        View = New Button()
        btnReset = New Button()
        btnUpdate = New Button()
        btnSearch = New Button()
        btnPrint = New Button()
        btnDelete = New Button()
        btnSaveData = New Button()
        Panel4 = New Panel()
        txtSearch = New TextBox()
        Panel3 = New Panel()
        txtTelephone = New TextBox()
        txtAddress = New TextBox()
        txtFirstname = New TextBox()
        txtPostCode = New TextBox()
        txtSurname = New TextBox()
        txtStudentID = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Panel2 = New Panel()
        Label9 = New Label()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightBlue
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1060, 637)
        Panel1.TabIndex = 0
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.Control
        Panel5.Controls.Add(btnExit)
        Panel5.Controls.Add(View)
        Panel5.Controls.Add(btnReset)
        Panel5.Controls.Add(btnUpdate)
        Panel5.Controls.Add(btnSearch)
        Panel5.Controls.Add(btnPrint)
        Panel5.Controls.Add(btnDelete)
        Panel5.Controls.Add(btnSaveData)
        Panel5.Location = New Point(653, 176)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(394, 447)
        Panel5.TabIndex = 0
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = SystemColors.Control
        btnExit.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnExit.Location = New Point(16, 389)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(363, 49)
        btnExit.TabIndex = 0
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' View
        ' 
        View.BackColor = SystemColors.Control
        View.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        View.Location = New Point(16, 281)
        View.Name = "View"
        View.Size = New Size(363, 49)
        View.TabIndex = 0
        View.Text = "View"
        View.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = SystemColors.Control
        btnReset.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnReset.Location = New Point(16, 173)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(363, 49)
        btnReset.TabIndex = 0
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = SystemColors.Control
        btnUpdate.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnUpdate.Location = New Point(16, 65)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(363, 49)
        btnUpdate.TabIndex = 0
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = SystemColors.Control
        btnSearch.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnSearch.Location = New Point(16, 336)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(363, 49)
        btnSearch.TabIndex = 0
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = SystemColors.Control
        btnPrint.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnPrint.Location = New Point(16, 228)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(363, 49)
        btnPrint.TabIndex = 0
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.Control
        btnDelete.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelete.Location = New Point(16, 120)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(363, 49)
        btnDelete.TabIndex = 0
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnSaveData
        ' 
        btnSaveData.BackColor = SystemColors.Control
        btnSaveData.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnSaveData.Location = New Point(16, 12)
        btnSaveData.Name = "btnSaveData"
        btnSaveData.Size = New Size(363, 49)
        btnSaveData.TabIndex = 0
        btnSaveData.Text = "Save Data"
        btnSaveData.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.Control
        Panel4.Controls.Add(txtSearch)
        Panel4.Location = New Point(653, 92)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(394, 78)
        Panel4.TabIndex = 0
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtSearch.Location = New Point(16, 12)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(363, 54)
        txtSearch.TabIndex = 5
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.Control
        Panel3.Controls.Add(txtTelephone)
        Panel3.Controls.Add(txtAddress)
        Panel3.Controls.Add(txtFirstname)
        Panel3.Controls.Add(txtPostCode)
        Panel3.Controls.Add(txtSurname)
        Panel3.Controls.Add(txtStudentID)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(DataGridView1)
        Panel3.Location = New Point(15, 92)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(632, 531)
        Panel3.TabIndex = 0
        ' 
        ' txtTelephone
        ' 
        txtTelephone.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtTelephone.Location = New Point(190, 243)
        txtTelephone.Name = "txtTelephone"
        txtTelephone.Size = New Size(428, 43)
        txtTelephone.TabIndex = 2
        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtAddress.Location = New Point(190, 149)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(428, 43)
        txtAddress.TabIndex = 2
        ' 
        ' txtFirstname
        ' 
        txtFirstname.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtFirstname.Location = New Point(190, 57)
        txtFirstname.Name = "txtFirstname"
        txtFirstname.Size = New Size(428, 43)
        txtFirstname.TabIndex = 2
        ' 
        ' txtPostCode
        ' 
        txtPostCode.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtPostCode.Location = New Point(190, 196)
        txtPostCode.Name = "txtPostCode"
        txtPostCode.Size = New Size(428, 43)
        txtPostCode.TabIndex = 2
        ' 
        ' txtSurname
        ' 
        txtSurname.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtSurname.Location = New Point(190, 102)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(428, 43)
        txtSurname.TabIndex = 2
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtStudentID.Location = New Point(190, 10)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(428, 43)
        txtStudentID.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(12, 243)
        Label6.Name = "Label6"
        Label6.Size = New Size(139, 37)
        Label6.TabIndex = 1
        Label6.Text = "Telephone"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(12, 196)
        Label5.Name = "Label5"
        Label5.Size = New Size(137, 37)
        Label5.TabIndex = 1
        Label5.Text = "Post Code"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(12, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 37)
        Label4.TabIndex = 1
        Label4.Text = "Address"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(12, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 37)
        Label3.TabIndex = 1
        Label3.Text = "Surname"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(12, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 37)
        Label2.TabIndex = 1
        Label2.Text = "Firstname"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 37)
        Label1.TabIndex = 1
        Label1.Text = "Student ID"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonFace
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 302)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(606, 217)
        DataGridView1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Control
        Panel2.Controls.Add(Label9)
        Panel2.Location = New Point(15, 15)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1032, 71)
        Panel2.TabIndex = 0
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(294, 13)
        Label9.Name = "Label9"
        Label9.Size = New Size(444, 45)
        Label9.TabIndex = 3
        Label9.Text = "Access Database Connection"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1084, 661)
        Controls.Add(Panel1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtPostCode As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents View As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSaveData As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
