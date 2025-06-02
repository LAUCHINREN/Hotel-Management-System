using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security;

namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    public partial class CleaningStatusForm : Form
    {
        private string roomID;
        private string statusReport;
        private bool isCleaned;
        private bool isDirty;
        private string reportIssues;
        public CleaningStatusForm(string roomID, string roomType, string date, string time, string venue, string existingStatusReport, bool existingIsCleaned, bool existingIsDirty, string existingReportIssues)
        {
            InitializeComponent();
            lblRoomID.Text = roomID;
            lblRoomType.Text = roomType;
            lblScheduleDate.Text = date;
            lblScheduleTime.Text = time;
            lblVenue.Text = venue;
            this.roomID = roomID;
            this.statusReport = existingStatusReport;
            this.isCleaned = existingIsCleaned;
            this.isDirty = existingIsDirty;
            this.reportIssues = existingReportIssues;

            // Display existing status report if any
            labelShowStatus.Text = existingStatusReport;
            checkBoxCleaned.Checked = existingIsCleaned;
            checkBoxDirty.Checked = existingIsDirty;
            txtReportIssues.Text = existingReportIssues;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            
        }
        private void checkBoxCleaned_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCleaned.Checked)
            {
                checkBoxDirty.Checked = false;
            }
        }

        private void checkBoxDirty_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDirty.Checked)
            {
                checkBoxCleaned.Checked = false;
            }
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            string status = checkBoxCleaned.Checked ? "Cleaned" : "Dirty";
            string issues = txtReportIssues.Text;

            statusReport = $"The status of {roomID} is {status}. Issues: {issues}";
            isCleaned = checkBoxCleaned.Checked;
            isDirty = checkBoxDirty.Checked;
            reportIssues = txtReportIssues.Text;

            // Display the status report
            labelShowStatus.Text = statusReport;

            // Notify StatusReport to update
            MessageBox.Show($"Reported successfully!");
            
        }
        public string GetStatusReport()
        {
            return statusReport;
        }
        public (string StatusReport, bool IsCleaned, bool IsDirty, string ReportIssues) GetStatusDetails()
        {
            return (statusReport, isCleaned, isDirty, reportIssues);
        }
        private void labelShowStatus_Click(object sender, EventArgs e)
        {
           
        }
    }
}
