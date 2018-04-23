Imports System
Imports System.Windows.Forms

Namespace DateNavigator_HitInfo
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        #Region "#gethitinfo"
        Private Sub dateNavigator1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dateNavigator1.MouseMove
            Dim hitInfo As DevExpress.XtraEditors.Calendar.CalendarHitInfo = dateNavigator1.GetHitInfo(e)
            Dim s1 As String = hitInfo.InfoType.ToString()
            Dim s2 As String = hitInfo.HitDate.ToShortDateString()
            Dim s3 As String = hitInfo.Pt.ToString()

            Me.Text = String.Format("HitInfo for {0} - Date: {1} Point: {2}", s1, s2, s3)
        End Sub
        #End Region ' #gethitinfo
    End Class
End Namespace
