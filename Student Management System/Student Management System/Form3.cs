using System;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class frmAddStudent : Form
    {

        // Properties to expose data to MainForm
        public string StudentID { get; private set; }
        public string FullName { get; private set; }
        public string Course { get; private set; }
        public string YearLevel { get; private set; }
        public decimal GPA { get; private set; }

        public frmAddStudent()
        {
            InitializeComponent();
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            // Optionally, initialize controls here (e.g., populate cboYearLevel).
            cboYearLevel.Items.Clear();
            cboYearLevel.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cboYearLevel.SelectedIndex = 0;
            lblError.Text = string.Empty;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            // Validate Student ID
            string strStudentID = txtStudentID.Text.Trim();
            if (string.IsNullOrWhiteSpace(strStudentID))
            {
                lblError.Text = "Student ID is required.";
                txtStudentID.Focus();
                return;
            }

            // Validate Full Name
            string strFullName = txtFullName.Text.Trim();
            if (string.IsNullOrWhiteSpace(strFullName))
            {
                lblError.Text = "Full name is required.";
                txtFullName.Focus();
                return;
            }

            // Validate Course
            string strCourse = txtCourse.Text.Trim();
            if (string.IsNullOrWhiteSpace(strCourse))
            {
                lblError.Text = "Course is required.";
                txtCourse.Focus();
                return;
            }

            string strYearLevel = cboYearLevel.SelectedItem?.ToString() ?? cboYearLevel.Text.Trim();
            if (string.IsNullOrWhiteSpace(strYearLevel))
            {
                lblError.Text = "Year level is required.";
                cboYearLevel.Focus();
                return;
            }

            // Validate GPA
            string strGPA = txtGPA.Text.Trim();
            if (!decimal.TryParse(strGPA, out decimal decGPA))
            {
                lblError.Text = "GPA must be a valid number.";
                txtGPA.Focus();
                return;
            }

            if (decGPA < 0 || decGPA > 4.0m)
            {
                lblError.Text = "GPA must be between 0.00 and 4.00.";
                txtGPA.Focus();
                return;
            }

            // All validations passed
            StudentID = strStudentID;
            FullName = strFullName;
            Course = strCourse;
            YearLevel = strYearLevel;
            GPA = decGPA;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            lblError.Text = "";

            // Validate Student ID
            string strStudentID = txtStudentID.Text.Trim();
            if (string.IsNullOrWhiteSpace(strStudentID))
            {
                lblError.Text = "Student ID is required.";
                txtStudentID.Focus();
                return;
            }

            // Validate Full Name
            string strFullName = txtFullName.Text.Trim();
            if (string.IsNullOrWhiteSpace(strFullName))
            {
                lblError.Text = "Full name is required.";
                txtFullName.Focus();
                return;
            }

            // Validate Course
            string strCourse = txtCourse.Text.Trim();
            if (string.IsNullOrWhiteSpace(strCourse))
            {
                lblError.Text = "Course is required.";
                txtCourse.Focus();
                return;
            }

            string strYearLevel = cboYearLevel.SelectedItem?.ToString() ?? cboYearLevel.Text.Trim();
            if (string.IsNullOrWhiteSpace(strYearLevel))
            {
                lblError.Text = "Year level is required.";
                cboYearLevel.Focus();
                return;
            }

            // Validate GPA
            string strGPA = txtGPA.Text.Trim();
            if (!decimal.TryParse(strGPA, out decimal decGPA))
            {
                lblError.Text = "GPA must be a valid number.";
                txtGPA.Focus();
                return;
            }

            if (decGPA < 0 || decGPA > 4.0m)
            {
                lblError.Text = "GPA must be between 0.00 and 4.00.";
                txtGPA.Focus();
                return;
            }

            // All validations passed
            StudentID = strStudentID;
            FullName = strFullName;
            Course = strCourse;
            YearLevel = strYearLevel;
            GPA = decGPA;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}