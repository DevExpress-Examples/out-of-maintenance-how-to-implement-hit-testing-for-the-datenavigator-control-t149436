Namespace DateNavigator_HitInfo
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.dateNavigator1 = New DevExpress.XtraScheduler.DateNavigator()
            DirectCast(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dateNavigator1
            ' 
            Me.dateNavigator1.DateTime = New Date(2014, 9, 10, 0, 0, 0, 0)
            Me.dateNavigator1.Location = New System.Drawing.Point(12, 12)
            Me.dateNavigator1.Name = "dateNavigator1"
        Me.dateNavigator1.CellPadding = New System.Windows.Forms.Padding(2)
            Me.dateNavigator1.Size = New System.Drawing.Size(388, 334)
            Me.dateNavigator1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(611, 409)
            Me.Controls.Add(Me.dateNavigator1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents dateNavigator1 As DevExpress.XtraScheduler.DateNavigator
    End Class
End Namespace

