using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class frmMainStudent : Form
    {
        public frmMainStudent()
        {
            InitializeComponent();
        }

        private void frmMainStudent_Load(object sender, EventArgs e)
        {
            SetupListView();
        }
        private void SetupListView()
        {
            lvwStudents.Columns.Clear();
            lvwStudents.Columns.Add("Student ID", 100);
            lvwStudents.Columns.Add("Full Name", 180);
            lvwStudents.Columns.Add("Course", 120);
            lvwStudents.Columns.Add("Year Level", 90);
            lvwStudents.Columns.Add("GPA", 80);
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmAddStudent frmAdd = new frmAddStudent();
            DialogResult dlgResult = frmAdd.ShowDialog();

            if (dlgResult == DialogResult.OK)
            {
                ListViewItem lviItem = new ListViewItem(frmAdd.StudentID);
                lviItem.SubItems.Add(frmAdd.FullName);
                lviItem.SubItems.Add(frmAdd.Course);
                lviItem.SubItems.Add(frmAdd.YearLevel);
                lviItem.SubItems.Add(frmAdd.GPA.ToString("F2"));

                lvwStudents.Items.Add(lviItem);
                UpdateTotalStudents();
            }
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (lvwStudents.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a student to remove.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dlgConfirm = MessageBox.Show("Remove selected student?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlgConfirm == DialogResult.Yes)
            {
                lvwStudents.Items.Remove(lvwStudents.SelectedItems[0]);
                UpdateTotalStudents();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (lvwStudents.Items.Count == 0)
            {
                MessageBox.Show("No students to clear.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dlgConfirm = MessageBox.Show("Clear all students?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlgConfirm == DialogResult.Yes)
            {
                lvwStudents.Items.Clear();
                UpdateTotalStudents();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateTotalStudents()
        {
            lblTotalStudents.Text = "Total Students: " + lvwStudents.Items.Count.ToString();
        }
    }
}
