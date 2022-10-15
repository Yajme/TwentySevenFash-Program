Imports System.Data.SqlClient
Imports FontAwesome.Sharp

Public Class Admin
    Public Shared adminmain
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel

    Dim con As New SqlConnection("Data Source=<Source>;Initial Catalog=<DatabaseName>;Integrated Security=True")
    Dim cmd As New SqlCommand("select * from users where username= @username and password= @password", con)


    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        changeMenu("Home")
    End Sub



    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim confirmation As String = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo, "Confirmation Dialog Box")
        If confirmation = vbYes Then
            End 'ends program
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim confirmation As String = MsgBox("Do you really want to Logout?", MsgBoxStyle.YesNo, "Confirmation Dialog Box")
        If confirmation = vbYes Then
            Me.Close() 'Current Form Closed
            Login.Show() 'Form Name.show()
        End If
    End Sub

    Private Sub ActiveButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(44, 62, 80)
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
        End If
    End Sub

    Private Sub disabledButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(231, 76, 60, 1.0)
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White

        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblTime.Text = TimeString
        lblDate.Text = DateString


    End Sub
    Private Sub addForm(frm As Form)
        PanelContainer.Controls.Clear()
        frm.TopMost = True
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        PanelContainer.Controls.Add(frm)
        frm.Show()

    End Sub
    Private Sub changeMenu(menu As String)
        Select Case menu
            Case "Home"
                addForm(frmHome)
            Case "Student"
                addForm(frmStu)
            Case "Teacher"
                addForm(frmTeacher)
            Case "Facilities"
                addForm(frmFaci)
            Case "CourseandSubject"
                addForm(frmCS)
            Case "Department"
                addForm(frmDept)
        End Select
    End Sub

    Private Sub btnStu_Click(sender As Object, e As EventArgs)
        ActiveButton(sender, RGBColors.color1)
        changeMenu("Student")
    End Sub

    Private Sub btnCS_Click(sender As Object, e As EventArgs)
        changeMenu("CourseandSubject")
    End Sub

    Private Sub btnTchr_Click(sender As Object, e As EventArgs)
        changeMenu("Teacher")
    End Sub

    Private Sub btnFaci_Click(sender As Object, e As EventArgs)
        changeMenu("Facilities")
    End Sub

    Private Sub btnDept_Click(sender As Object, e As EventArgs)
        changeMenu("Department")
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        changeMenu("Home")
    End Sub


End Class