using System;
using System.Windows.Forms;

namespace DateNavigator_HitInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region #gethitinfo
        private void dateNavigator1_MouseMove(object sender, MouseEventArgs e)
        {
            DevExpress.XtraEditors.Calendar.CalendarHitInfo hitInfo = dateNavigator1.GetHitInfo(e);
            string s1 = hitInfo.HitTest.ToString();
            string s2 = hitInfo.HitDate.ToShortDateString();
            string s3 = hitInfo.HitPoint.ToString();

            this.Text = String.Format("HitInfo for {0} - Date: {1} Point: {2}", s1, s2, s3);
        }
        #endregion #gethitinfo
    }
}
