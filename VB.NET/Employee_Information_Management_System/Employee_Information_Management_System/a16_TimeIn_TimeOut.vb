Imports System.Data.SqlClient
Imports System.Data
Public Class a16_TimeIn_TimeOut
    Dim con As New SqlConnection(Form1.conString)
    Sub display()
        txtEmpNo.Focus()
        lblInfo.Text = ""
        Label1.Text = ""
    End Sub
    Private Sub btnTimeInTimeOut_Click(sender As Object, e As EventArgs) Handles btnTimeInTimeOut.Click
        display()

        Try
            If txtEmpNo.Text = String.Empty Then
                lblInfo.Text = "Enter Employee No: "
                lblInfo.ForeColor = Color.Orange
            Else
                Dim cmd As New SqlCommand("Select * from EmpTable where EmpNo = @empNo", con)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@empNo", txtEmpNo.Text())
                Dim da As New SqlDataAdapter(cmd)
                Dim dt1 = New DataTable
                da.SelectCommand = cmd
                da.Fill(dt1)

                If dt1.Rows.Count > 0 Then
                    Dim Nam As String = dt1.Rows(0).Item("EmpName").ToString
                    cmd = New SqlCommand("Select * from AttendanceTable where empNo = @empNo AND attenDate = @attenDate AND outStatus = @outStatus AND inStatus = @inStatus", con)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@empNo", txtEmpNo.Text)
                    cmd.Parameters.AddWithValue("@attenDate", Date.Now.ToString("d"))
                    cmd.Parameters.AddWithValue("@inStatus", "TIME IN")
                    cmd.Parameters.AddWithValue("@outStatus", "TIME OUT")
                    da = New SqlDataAdapter(cmd)
                    Dim dt2 = New DataTable
                    da.SelectCommand = cmd
                    da.Fill(dt2)
                    If txtEmpNo.Text = String.Empty Then
                        lblInfo.Text = "Enter Employee No: "
                        lblInfo.ForeColor = Color.Orange
                    Else
                        cmd = New SqlCommand("Select * from AttendanceTable where empNo = @empNo AND attenDate = @attenDate AND inStatus = @inStatus", con)
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@empNo", txtEmpNo.Text)
                        cmd.Parameters.AddWithValue("@attenDate", Date.Now.ToString("d"))
                        cmd.Parameters.AddWithValue("@inStatus", "TIME IN")
                        da = New SqlDataAdapter(cmd)
                        dt2 = New DataTable
                        da.SelectCommand = cmd
                        da.Fill(dt2)


                        If dt2.Rows.Count > 0 Then
                            Dim dtTime = New TimeSpan()
                            dtTime = Date.Now.TimeOfDay.Subtract(Convert.ToDateTime(dt2.Rows(0).Item("inTime")).TimeOfDay)
                            cmd = New SqlCommand("Update Attendence SET outTime = @outTime, outStatus = @outStatus,TimeDuration = @time Where empNo = @empNo AND attenDate = @attenDate", con)
                            cmd.Parameters.AddWithValue("@empNo", txtEmpNo.Text)
                            cmd.Parameters.AddWithValue("@Time", dtTime.Hours.ToString() + " Hours")
                            cmd.Parameters.AddWithValue("@attenDate", Date.Now.ToString("d"))
                            cmd.Parameters.AddWithValue("@outTime", Date.Now.ToString("t"))
                            cmd.Parameters.AddWithValue("@outStatus", "TIME OUT")
                            con.Open()
                            Dim i = cmd.ExecuteNonQuery
                            con.Close()

                            If i > 0 Then
                                lblInfo.Text = "Time Out Sucess !"
                                Label1.Text = Nam
                                lblInfo.ForeColor = Color.Lime
                                Label1.ForeColor = Color.Blue
                            Else
                                lblInfo.Text = "Time Out Failed !"
                                lblInfo.ForeColor = Color.Red

                            End If
                        Else
                            cmd = New SqlCommand("INSERT INTO AttendanceTable(empNo, attenDate, inTime, inStatus) VALUES(@empNo, @attenDate, @inTime, @inStatus)", con)
                            cmd.Parameters.Clear()
                            cmd.Parameters.AddWithValue("@empNo", txtEmpNo.Text)
                            cmd.Parameters.AddWithValue("@attenDate", Date.Now.ToString("d"))
                            cmd.Parameters.AddWithValue("@inTime", Date.Now.ToString("t"))
                            cmd.Parameters.AddWithValue("@inStatus", "TIME IN")
                            con.Open()
                            Dim i = cmd.ExecuteNonQuery
                            con.Close()
                            If i > 0 Then
                                lblInfo.Text = "Time In Sucess !"
                                Label1.Text = Nam
                                lblInfo.ForeColor = Color.Lime
                                Label1.ForeColor = Color.Blue
                            Else
                                lblInfo.Text = "Time In Failed !"
                                lblInfo.ForeColor = Color.Red
                            End If
                        End If
                    End If
                Else
                    lblInfo.Text = "Employee Not Found !"
                    lblInfo.ForeColor = Color.Red
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub TimeIn_TimeOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display()
        txtEmpNo.Text = ""
    End Sub

End Class