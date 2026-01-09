namespace TouchTrackApp
{
    partial class EmployeeRegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeRegistrationForm));
            this.closebtn = new System.Windows.Forms.Button();
            this.fImage = new System.Windows.Forms.PictureBox();
            this.StatusText = new System.Windows.Forms.TextBox();
            this.Prompt = new System.Windows.Forms.TextBox();
            this.startScan = new System.Windows.Forms.Button();
            this.Statuslabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbDayOfWeek = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.timeOut = new System.Windows.Forms.DateTimePicker();
            this.timeIn = new System.Windows.Forms.DateTimePicker();
            this.addSchedBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.schedPreview = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedPreview)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.Transparent;
            this.closebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closebtn.BackgroundImage")));
            this.closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.closebtn.Location = new System.Drawing.Point(600, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(20, 20);
            this.closebtn.TabIndex = 103;
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // fImage
            // 
            this.fImage.BackColor = System.Drawing.Color.Transparent;
            this.fImage.BackgroundImage = global::TouchTrackApp.Properties.Resources.fingerprint;
            this.fImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fImage.Location = new System.Drawing.Point(448, 25);
            this.fImage.Name = "fImage";
            this.fImage.Size = new System.Drawing.Size(150, 194);
            this.fImage.TabIndex = 104;
            this.fImage.TabStop = false;
            // 
            // StatusText
            // 
            this.StatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.StatusText.Location = new System.Drawing.Point(448, 247);
            this.StatusText.Multiline = true;
            this.StatusText.Name = "StatusText";
            this.StatusText.ReadOnly = true;
            this.StatusText.Size = new System.Drawing.Size(150, 190);
            this.StatusText.TabIndex = 106;
            // 
            // Prompt
            // 
            this.Prompt.BackColor = System.Drawing.SystemColors.Control;
            this.Prompt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Prompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Prompt.Location = new System.Drawing.Point(448, 228);
            this.Prompt.Name = "Prompt";
            this.Prompt.ReadOnly = true;
            this.Prompt.Size = new System.Drawing.Size(150, 13);
            this.Prompt.TabIndex = 105;
            // 
            // startScan
            // 
            this.startScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(252)))), ((int)(((byte)(132)))));
            this.startScan.FlatAppearance.BorderSize = 0;
            this.startScan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(169)))), ((int)(((byte)(92)))));
            this.startScan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(169)))), ((int)(((byte)(92)))));
            this.startScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startScan.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.startScan.ForeColor = System.Drawing.Color.White;
            this.startScan.Location = new System.Drawing.Point(448, 445);
            this.startScan.Name = "startScan";
            this.startScan.Size = new System.Drawing.Size(150, 38);
            this.startScan.TabIndex = 107;
            this.startScan.Text = "Start Scan";
            this.startScan.UseVisualStyleBackColor = false;
            // 
            // Statuslabel
            // 
            this.Statuslabel.AutoSize = true;
            this.Statuslabel.Location = new System.Drawing.Point(19, 458);
            this.Statuslabel.Name = "Statuslabel";
            this.Statuslabel.Size = new System.Drawing.Size(56, 13);
            this.Statuslabel.TabIndex = 108;
            this.Statuslabel.Text = "[STATUS]";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtEmployeeID);
            this.panel1.Location = new System.Drawing.Point(31, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 31);
            this.panel1.TabIndex = 109;
            this.panel1.Click += new System.EventHandler(this.focusEmployeeID);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee ID";
            this.label1.Click += new System.EventHandler(this.focusEmployeeID);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.ForeColor = System.Drawing.Color.White;
            this.txtEmployeeID.Location = new System.Drawing.Point(120, 7);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(289, 16);
            this.txtEmployeeID.TabIndex = 2;
            this.txtEmployeeID.TextChanged += new System.EventHandler(this.txtEmployeeID_TextChanged);
            this.txtEmployeeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeID_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtLastName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(31, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 31);
            this.panel2.TabIndex = 110;
            this.panel2.Click += new System.EventHandler(this.focusLastName);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.White;
            this.txtLastName.Location = new System.Drawing.Point(120, 7);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(289, 16);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.focusLastName);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtFirstName);
            this.panel3.Location = new System.Drawing.Point(31, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 31);
            this.panel3.TabIndex = 111;
            this.panel3.Click += new System.EventHandler(this.focusFirstName);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name";
            this.label3.Click += new System.EventHandler(this.focusFirstName);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.White;
            this.txtFirstName.Location = new System.Drawing.Point(120, 7);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(289, 16);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cmbRole);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(31, 177);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 31);
            this.panel4.TabIndex = 112;
            // 
            // cmbRole
            // 
            this.cmbRole.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRole.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.ForeColor = System.Drawing.Color.White;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Dean",
            "Librarian",
            "Professor",
            "Registrar",
            "Utility"});
            this.cmbRole.Location = new System.Drawing.Point(120, 3);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(289, 24);
            this.cmbRole.TabIndex = 4;
            this.cmbRole.TextChanged += new System.EventHandler(this.cmbRole_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(22, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Employee Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 113;
            this.label6.Text = "Schedule";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.cmbDayOfWeek);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(31, 262);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(400, 31);
            this.panel5.TabIndex = 113;
            // 
            // cmbDayOfWeek
            // 
            this.cmbDayOfWeek.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cmbDayOfWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDayOfWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDayOfWeek.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDayOfWeek.ForeColor = System.Drawing.Color.White;
            this.cmbDayOfWeek.FormattingEnabled = true;
            this.cmbDayOfWeek.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cmbDayOfWeek.Location = new System.Drawing.Point(120, 3);
            this.cmbDayOfWeek.Name = "cmbDayOfWeek";
            this.cmbDayOfWeek.Size = new System.Drawing.Size(289, 24);
            this.cmbDayOfWeek.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(10, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Day of Week";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.timeOut);
            this.panel6.Controls.Add(this.timeIn);
            this.panel6.Controls.Add(this.addSchedBtn);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(31, 300);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 31);
            this.panel6.TabIndex = 114;
            // 
            // timeOut
            // 
            this.timeOut.CalendarForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.timeOut.CalendarMonthBackground = System.Drawing.SystemColors.AppWorkspace;
            this.timeOut.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.timeOut.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.timeOut.CalendarTrailingForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.timeOut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeOut.Location = new System.Drawing.Point(255, 4);
            this.timeOut.Name = "timeOut";
            this.timeOut.Size = new System.Drawing.Size(100, 23);
            this.timeOut.TabIndex = 7;
            // 
            // timeIn
            // 
            this.timeIn.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeIn.CalendarForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.timeIn.CalendarMonthBackground = System.Drawing.SystemColors.AppWorkspace;
            this.timeIn.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.timeIn.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.timeIn.CalendarTrailingForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.timeIn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeIn.Location = new System.Drawing.Point(63, 4);
            this.timeIn.Name = "timeIn";
            this.timeIn.Size = new System.Drawing.Size(100, 23);
            this.timeIn.TabIndex = 6;
            // 
            // addSchedBtn
            // 
            this.addSchedBtn.BackColor = System.Drawing.Color.Transparent;
            this.addSchedBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addSchedBtn.BackgroundImage")));
            this.addSchedBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addSchedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSchedBtn.FlatAppearance.BorderSize = 0;
            this.addSchedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSchedBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSchedBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.addSchedBtn.Location = new System.Drawing.Point(367, 3);
            this.addSchedBtn.Name = "addSchedBtn";
            this.addSchedBtn.Size = new System.Drawing.Size(29, 29);
            this.addSchedBtn.TabIndex = 115;
            this.addSchedBtn.UseVisualStyleBackColor = false;
            this.addSchedBtn.Click += new System.EventHandler(this.addSchedBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(185, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Time Out";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(10, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Time In";
            // 
            // schedPreview
            // 
            this.schedPreview.AllowUserToAddRows = false;
            this.schedPreview.AllowUserToResizeColumns = false;
            this.schedPreview.AllowUserToResizeRows = false;
            this.schedPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.schedPreview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.schedPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedPreview.Location = new System.Drawing.Point(16, 113);
            this.schedPreview.MultiSelect = false;
            this.schedPreview.Name = "schedPreview";
            this.schedPreview.ReadOnly = true;
            this.schedPreview.RowHeadersVisible = false;
            this.schedPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.schedPreview.Size = new System.Drawing.Size(400, 89);
            this.schedPreview.TabIndex = 116;
            this.schedPreview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.schedPreview_CellContentClick);
            this.schedPreview.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.schedPreview_RowsAdded);
            this.schedPreview.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.schedPreview_RowsRemoved);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(14, 25);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(428, 194);
            this.panel7.TabIndex = 117;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(-1, -1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(428, 194);
            this.panel8.TabIndex = 118;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.label6);
            this.panel9.Controls.Add(this.schedPreview);
            this.panel9.Location = new System.Drawing.Point(14, 225);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(428, 212);
            this.panel9.TabIndex = 118;
            // 
            // EmployeeRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(620, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Statuslabel);
            this.Controls.Add(this.startScan);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.Prompt);
            this.Controls.Add(this.fImage);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.fImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedPreview)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.PictureBox fImage;
        private System.Windows.Forms.TextBox StatusText;
        private System.Windows.Forms.TextBox Prompt;
        private System.Windows.Forms.Button startScan;
        private System.Windows.Forms.Label Statuslabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cmbDayOfWeek;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker timeOut;
        private System.Windows.Forms.DateTimePicker timeIn;
        private System.Windows.Forms.Button addSchedBtn;
        private System.Windows.Forms.DataGridView schedPreview;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
    }
}