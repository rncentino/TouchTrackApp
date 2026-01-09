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
    public partial class EmployeeRegistrationForm : Form
    {
        public EmployeeRegistrationForm()
        {
            InitializeComponent();
            SetupScheduleGrid();

            timeIn.Format = DateTimePickerFormat.Custom;
            timeIn.CustomFormat = "hh:mm tt";
            timeIn.ShowUpDown = true;

            timeOut.Format = DateTimePickerFormat.Custom;
            timeOut.CustomFormat = "hh:mm tt";
            timeOut.ShowUpDown = true;

            startScan.Visible = false;
        }

        private void SetupScheduleGrid()
        {
            schedPreview.Columns.Clear();

            schedPreview.Columns.Add("DayOfWeek", "Day Of Week");
            schedPreview.Columns.Add("TimeIn", "Time In");
            schedPreview.Columns.Add("TimeOut", "Time Out");

            DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn();
            btnRemove.Name = "Action";
            btnRemove.HeaderText = "Action";
            btnRemove.Text = "Remove";
            btnRemove.UseColumnTextForButtonValue = true;

            schedPreview.Columns.Add(btnRemove);
        }


        private void addSchedBtn_Click(object sender, EventArgs e)
        {
            // 1️⃣ Validate day selection
            if (cmbDayOfWeek.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a day.");
                return;
            }

            // 2️⃣ Validate time range
            if (timeOut.Value <= timeIn.Value)
            {
                MessageBox.Show("Time Out must be later than Time In.");
                return;
            }

            // 3️⃣ Check for overlapping schedules (same day)
            foreach (DataGridViewRow row in schedPreview.Rows)
            {
                if (row.IsNewRow)
                    continue;

                string existingDay = Convert.ToString(row.Cells["DayOfWeek"].Value);
                if (existingDay != cmbDayOfWeek.Text)
                    continue;

                TimeSpan existingIn = (TimeSpan)row.Cells["TimeIn"].Tag;
                TimeSpan existingOut = (TimeSpan)row.Cells["TimeOut"].Tag;

                TimeSpan newIn = timeIn.Value.TimeOfDay;
                TimeSpan newOut = timeOut.Value.TimeOfDay;

                if (newIn < existingOut && newOut > existingIn)
                {
                    MessageBox.Show(
                        "Schedule time overlaps with an existing schedule for this day.",
                        "Schedule Conflict",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
            }

            // 4️⃣ ADD ROW TO DATAGRIDVIEW (TEMP STORAGE)
            schedPreview.Rows.Add(
                cmbDayOfWeek.Text,
                timeIn.Value.ToShortTimeString(),
                timeOut.Value.ToShortTimeString()
            );

            // 5️⃣ STORE REAL TIME VALUES IN TAG (IMPORTANT)
            int lastRow = schedPreview.Rows.Count - 1;
            schedPreview.Rows[lastRow].Cells["TimeIn"].Tag = timeIn.Value.TimeOfDay;
            schedPreview.Rows[lastRow].Cells["TimeOut"].Tag = timeOut.Value.TimeOfDay;

            // 6️⃣ OPTIONAL UX CLEANUP
            cmbDayOfWeek.SelectedIndex = -1;
            timeIn.Value = DateTime.Today;
            timeOut.Value = DateTime.Today;
        }

        private void schedPreview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (schedPreview.Columns[e.ColumnIndex].Name == "Action")
            {
                DialogResult result = MessageBox.Show(
                    "Remove this schedule?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    schedPreview.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void validateScan()
        {
            bool isReady =
       !string.IsNullOrWhiteSpace(txtEmployeeID.Text) &&
       !string.IsNullOrWhiteSpace(txtFirstName.Text) &&
       !string.IsNullOrWhiteSpace(txtLastName.Text) &&
       cmbRole.SelectedIndex != -1 &&
       schedPreview.Rows.Count > 0;

            startScan.Visible = isReady;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void focusEmployeeID(object sender, EventArgs e)
        {
            txtEmployeeID.Focus();
        }

        private void focusLastName(object sender, EventArgs e)
        {
            txtLastName.Focus();
        }

        private void focusFirstName(object sender, EventArgs e)
        {
            txtFirstName.Focus();
        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {
            validateScan();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            validateScan();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            validateScan();
        }

        private void cmbRole_TextChanged(object sender, EventArgs e)
        {
            validateScan();
        }

        private void schedPreview_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            validateScan();
        }

        private void schedPreview_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            validateScan();
        }

        private void txtEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // block input
            }
        }
    }
}
