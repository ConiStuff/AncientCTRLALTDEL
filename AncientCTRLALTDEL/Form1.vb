Imports System.Diagnostics

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        RefreshTaskList()
    End Sub

    Private Sub RefreshTaskList()
        ListBox1.Items.Clear()

        Dim explorerTitle As String = ""
        Dim tasks As New List(Of String)

        Dim currentProcessId As Integer = Process.GetCurrentProcess().Id

        For Each p As Process In Process.GetProcesses()
            Try
                If p.MainWindowHandle <> IntPtr.Zero AndAlso Not String.IsNullOrEmpty(p.MainWindowTitle) Then
                    If p.Id = currentProcessId Then Continue For

                    If p.ProcessName.ToLower() = "explorer" Then
                        explorerTitle = p.MainWindowTitle
                    Else
                        tasks.Add(p.MainWindowTitle)
                    End If
                End If
            Catch ex As Exception

            End Try
        Next
        If explorerTitle <> "" Then
            ListBox1.Items.Add(explorerTitle)
        End If

        For Each title As String In tasks
            ListBox1.Items.Add(title)
        Next
    End Sub

    Private Sub leave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leave.Click
        Me.Close()
    End Sub

    Private Sub endtsk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles endtsk.Click
        If ListBox1.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a task to end.")
            Return
        End If

        Dim selectedTitle As String = ListBox1.SelectedItem.ToString()

        For Each p As Process In Process.GetProcesses
            Try
                If p.MainWindowHandle <> IntPtr.Zero AndAlso p.MainWindowTitle = selectedTitle Then
                    p.Kill()

                    RefreshTaskList()
                    Return
                End If
            Catch ex As Exception
                MessageBox.Show("unable to end task.")
            End Try
        Next
        MessageBox.Show("task not found.")

    End Sub

    Private Sub shutdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles shutdown.Click
        Try
            Dim psi As New ProcessStartInfo()
            psi.FileName = "shutdown"
            psi.Arguments = "/s /t 0"
            psi.CreateNoWindow = True
            psi.UseShellExecute = False

            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("An unexpected error is keeping Windows from shutting down.")
        End Try
    End Sub
End Class
