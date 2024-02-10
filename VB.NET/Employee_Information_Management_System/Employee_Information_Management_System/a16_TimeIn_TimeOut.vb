Imports System.Data.SqlClient
Imports System.Data
Public Class a16_TimeIn_TimeOut
    Dim con As New SqlConnection(Form1.conString)
    Private Sub btnTimeInTimeOut_Click(sender As Object, e As EventArgs) Handles btnTimeInTimeOut.Click
        Try
            If txtEmpNo.Text = String.Empty Then
                lblInfo.Text = "Enter Employee No: "
                lblInfo.ForeColor = Color.Orange
            Else
                Dim cmd As New SqlCommand("Select * from EmpTable where EmpNo = @empNo", con)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@empNo", txtEmpNo.Text())
                Dim da As New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.SelectCommand = cmd
                da.Fill(dt)

                If dt.Rows.Count > 0 Then
                    cmd = New SqlCommand("Select * from Attendence where EmpNo = @empNo AND attenDate = @attenDate AND outStatus = @outStatus AND inStatus = @inStatus", con)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@empNo", txtEmpNo.Text)
                    cmd.Parameters.AddWithValue("@attenDate", Date.Now.ToString("d"))
                    cmd.Parameters.AddWithValue("@inStatus", "TIME IN")
                    cmd.Parameters.AddWithValue("@outStatus", "TIME OUT")
                    da = New SqlDataAdapter(cmd)
                    dt = New DataTable
                    da.SelectCommand = cmd
                    da.Fill(dt)
                    If txtEmpNo.Text = String.Empty Then
                        lblInfo.Text = "Enter Employee No: "
                        lblInfo.ForeColor = Color.Orange
                    Else
                        cmd = New SqlCommand("Select * from Attendence where EmpNo = @empNo AND attenDate = @attenDate AND inStatus = @inStatus", con)
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@empNo", txtEmpNo.Text)
                        cmd.Parameters.AddWithValue("@attenDate", Date.Now.ToString("d"))
                        cmd.Parameters.AddWithValue("@inStatus", "TIME IN")
                        da = New SqlDataAdapter(cmd)
                        dt = New DataTable
                        da.SelectCommand = cmd
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            cmd = New SqlCommand("Update Attendence SET outTime = @outTime, outStatus = @outStatus Where EmpNo = @empNo AND attenDate = @attenDate", con)
                            cmd.Parameters.AddWithValue("@empNo", txtEmpNo.Text)
                            cmd.Parameters.AddWithValue("@attenDate", Date.Now.ToString("d"))
                            cmd.Parameters.AddWithValue("@outTime", Date.Now.ToString("t"))
                            cmd.Parameters.AddWithValue("@outStatus", "TIME OUT")
                            con.Open()
                            Dim i = cmd.ExecuteNonQuery
                            con.Close()

                            If i > 0 Then
                                lblInfo.Text = "Time Out Sucess !"
                                lblInfo.ForeColor = Color.Lime
                            Else
                                lblInfo.Text = "Time Out Failed !"
                                lblInfo.ForeColor = Color.Red

                            End If
                        Else
                            cmd = New SqlCommand("INSERT INTO Attendence(EmpNo, attenDate, inTime, inStatus) VALUES(@empNo, @attenDate, @inTime, @inStatus)", con)
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
                                lblInfo.ForeColor = Color.Lime
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
        txtEmpNo.Focus()
    End Sub
End Class