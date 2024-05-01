Imports Spire.Xls.Core.Spreadsheet

Public Class Export_to_Excel
    Public Sub New(dgvEmp As DataGridView)
        Try
            Dim xlApp As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer
            xlApp = New Microsoft.Office.Interop.Excel.ApplicationClass
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")
            For i = 0 To dgvEmp.RowCount - 2
                For j = 0 To dgvEmp.ColumnCount - 1
                    For k As Integer = 1 To dgvEmp.Columns.Count
                        xlWorkSheet.Cells(1, k) = dgvEmp.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = dgvEmp(j, i).Value.ToString()
                    Next
                Next
            Next
            'xlWorkSheet.SaveAs("")
            Using sfd As New SaveFileDialog
                If sfd.ShowDialog() = DialogResult.OK Then
                    sfd.Filter = "Excel Files | *.xlsx"
                    sfd.DefaultExt = "xlsx"
                    xlWorkSheet.SaveAs(sfd.FileName)
                End If
            End Using
            xlWorkBook.Close()
            xlApp.Quit()
            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)
            MsgBox("Saved Successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

End Class
