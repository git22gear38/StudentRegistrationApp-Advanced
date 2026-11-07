using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbCourse.Items.Add("Diploma in Information Technology");
            cmbCourse.Items.Add("Certificate in Web Development");
            cmbCourse.Items.Add("Certificate in Computer Applications");

            cmbCourse.SelectedIndex = -1;
            lblResult.Text = "";

            cmbDistrict.Items.Add("Galle");
            cmbDistrict.Items.Add("Colombo");
            cmbDistrict.Items.Add("Gampaha");
            cmbDistrict.Items.Add("Kalutara");
            cmbDistrict.Items.Add("Kandy");
            cmbDistrict.Items.Add("Matale");
            cmbDistrict.Items.Add("Nuwara Eliya");
            cmbDistrict.Items.Add("Matara");
            cmbDistrict.Items.Add("Hambantota");
            cmbDistrict.Items.Add("Jaffna");
            cmbDistrict.Items.Add("Kilinochchi");
            cmbDistrict.Items.Add("Mannar");
            cmbDistrict.Items.Add("Vavuniya");
            cmbDistrict.Items.Add("Mullaitivu");
            cmbDistrict.Items.Add("Batticoloa");
            cmbDistrict.Items.Add("Ampara");
            cmbDistrict.Items.Add("Trincomalee");
            cmbDistrict.Items.Add("Kurunegala");
            cmbDistrict.Items.Add("Puttalam");
            cmbDistrict.Items.Add("Anuradhapura");
            cmbDistrict.Items.Add("Polonnaruwa");
            cmbDistrict.Items.Add("Badulla");
            cmbDistrict.Items.Add("Monaragala");
            cmbDistrict.Items.Add("Ratnapura");
            cmbDistrict.Items.Add("Kegalle");

            cmbDistrict.SelectedIndex = -1;
            lblResult.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check required text fields.
            if (txtStudentId.Text.Trim() == "" ||
                txtFullName.Text.Trim() == "" ||
                txtNIC.Text.Trim() == "" ||
                txtEmail.Text.Trim() == "" ||
                txtPhone.Text.Trim() == "" )
            {
                MessageBox.Show("Please complete all required fields.",
                    "Missing information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Check gender selection
            if (! rdoMale.Checked && !rdoFemale.Checked)
            {
                MessageBox.Show("Please select a gender.");
                return;
            }

            // Check course selection
            if (cmbCourse.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a course.");
                return;
            }

            // Check District selection
            if (cmbDistrict.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a District.");
                return;
            }

            // Check confirmation
            if (!chkConfirm.Checked)
            {
                MessageBox.Show("Plaese confirm the details before registering.");
                return;
            }

            string gender = rdoMale.Checked ? "Male" : "Female";

            string StudentId = txtStudentId.Text.Trim();
            string FullName = txtFullName.Text.Trim();
            string StudentNIC = txtNIC.Text.Trim();
            string DateOfBirth = dtpDateOfBirth.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string course = cmbCourse.Text.Trim();
            string District = cmbDistrict.Text.Trim();
            string address = txtAddress.Text.Trim();

            string result =
                "REGISTRATION SUCCESSFULL" + Environment.NewLine +
                "Student ID: " + StudentId + Environment.NewLine +
                "Name: " + FullName + Environment.NewLine +
                "Student NIC: " + StudentNIC + Environment.NewLine +
                "Date of Birth: " + DateOfBirth + Environment.NewLine +
                "Gender: " + gender + Environment.NewLine +
                "Email: " + email + Environment.NewLine +
                "Phone: " + phone + Environment.NewLine +
                "Course: " + course + Environment.NewLine +
                "District: " + District +Environment.NewLine +
                "Address: " + address;

            lblResult.Text = result;

            MessageBox.Show("Student registration completed successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentId.Clear();
            txtFullName.Clear();
            txtNIC.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();

            dtpDateOfBirth.Value = DateTime.Today;

            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            cmbCourse.SelectedIndex = -1;
            cmbDistrict.SelectedIndex = -1;
            chkConfirm.Checked = false;

            lblResult.Text = "";
            txtStudentId.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Application",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
