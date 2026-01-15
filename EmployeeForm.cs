using DPFP;
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

        protected DPFP.Template Template;

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

        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
                if (Template != null)
                {
                    MessageBox.Show("The fingerprint template is ready for fingerprint verification", "Fingerprint Enrollment");
                }
                else
                {
                    MessageBox.Show("The fingerprint template is not valid, repeat fingerprint scanning", "Fingerprint Enrollment");
                }
            }));
        }

        private void registrationBtn_Click(object sender, EventArgs e)
        {
            //EmployeeRegistrationForm registerForm = new EmployeeRegistrationForm();
            //registerForm.ShowDialog();
            enroll Enfrm = new enroll();
            Enfrm.OnTemplate += this.OnTemplate;
            Enfrm.ShowDialog();
        }
    }
}
