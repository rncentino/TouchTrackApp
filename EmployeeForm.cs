using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouchTrackApp
{
    delegate void Function();

    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to exit?",
            "Confirm Exit",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
    );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void registrationBtn_Click(object sender, EventArgs e)
        {
            EmployeeRegistrationForm registerForm = new EmployeeRegistrationForm();
            registerForm.ShowDialog();
        }
    }
}
