namespace AVEVA_code_test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.CreateFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.CreateLastNameTextBox = new System.Windows.Forms.TextBox();
            this.CreateEmailTextBox = new System.Windows.Forms.TextBox();
            this.CreateDateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.CreateEmployeePanel = new System.Windows.Forms.Panel();
            this.CreateCurrentlyEmployedCheckBox = new System.Windows.Forms.CheckBox();
            this.MessageCreateEmployee = new System.Windows.Forms.Label();
            this.EmployeeUpdatePanel = new System.Windows.Forms.Panel();
            this.UpdateEmployeeMessage = new System.Windows.Forms.Label();
            this.UpdateCurrentlyEmployed = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.UpdateID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.UpdateDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.UpdateEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.UpdateLastName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.UpdateFirstName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ListEmployeesPanel = new System.Windows.Forms.Panel();
            this.ListSearchCheckBox = new System.Windows.Forms.CheckBox();
            this.ListSearchDate = new System.Windows.Forms.DateTimePicker();
            this.EmployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentlyEmployedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.employeeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.SearchDropDown = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CreateEmployeePanel.SuspendLayout();
            this.EmployeeUpdatePanel.SuspendLayout();
            this.ListEmployeesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(245, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "First name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Currently employed";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(309, 437);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(94, 29);
            this.CreateButton.TabIndex = 6;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // CreateFirstNameTextBox
            // 
            this.CreateFirstNameTextBox.Location = new System.Drawing.Point(317, 98);
            this.CreateFirstNameTextBox.MaxLength = 30;
            this.CreateFirstNameTextBox.Name = "CreateFirstNameTextBox";
            this.CreateFirstNameTextBox.Size = new System.Drawing.Size(250, 27);
            this.CreateFirstNameTextBox.TabIndex = 7;
            // 
            // CreateLastNameTextBox
            // 
            this.CreateLastNameTextBox.Location = new System.Drawing.Point(317, 140);
            this.CreateLastNameTextBox.MaxLength = 30;
            this.CreateLastNameTextBox.Name = "CreateLastNameTextBox";
            this.CreateLastNameTextBox.Size = new System.Drawing.Size(250, 27);
            this.CreateLastNameTextBox.TabIndex = 8;
            // 
            // CreateEmailTextBox
            // 
            this.CreateEmailTextBox.Location = new System.Drawing.Point(317, 182);
            this.CreateEmailTextBox.MaxLength = 60;
            this.CreateEmailTextBox.Name = "CreateEmailTextBox";
            this.CreateEmailTextBox.Size = new System.Drawing.Size(250, 27);
            this.CreateEmailTextBox.TabIndex = 9;
            // 
            // CreateDateOfBirthPicker
            // 
            this.CreateDateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CreateDateOfBirthPicker.Location = new System.Drawing.Point(317, 221);
            this.CreateDateOfBirthPicker.Name = "CreateDateOfBirthPicker";
            this.CreateDateOfBirthPicker.Size = new System.Drawing.Size(250, 27);
            this.CreateDateOfBirthPicker.TabIndex = 12;
            // 
            // CreateEmployeePanel
            // 
            this.CreateEmployeePanel.Controls.Add(this.CreateCurrentlyEmployedCheckBox);
            this.CreateEmployeePanel.Controls.Add(this.MessageCreateEmployee);
            this.CreateEmployeePanel.Controls.Add(this.label1);
            this.CreateEmployeePanel.Controls.Add(this.CreateDateOfBirthPicker);
            this.CreateEmployeePanel.Controls.Add(this.label2);
            this.CreateEmployeePanel.Controls.Add(this.label3);
            this.CreateEmployeePanel.Controls.Add(this.CreateEmailTextBox);
            this.CreateEmployeePanel.Controls.Add(this.label4);
            this.CreateEmployeePanel.Controls.Add(this.CreateLastNameTextBox);
            this.CreateEmployeePanel.Controls.Add(this.label5);
            this.CreateEmployeePanel.Controls.Add(this.CreateFirstNameTextBox);
            this.CreateEmployeePanel.Controls.Add(this.label6);
            this.CreateEmployeePanel.Controls.Add(this.CreateButton);
            this.CreateEmployeePanel.Location = new System.Drawing.Point(11, 43);
            this.CreateEmployeePanel.Name = "CreateEmployeePanel";
            this.CreateEmployeePanel.Size = new System.Drawing.Size(733, 520);
            this.CreateEmployeePanel.TabIndex = 13;
            // 
            // CreateCurrentlyEmployedCheckBox
            // 
            this.CreateCurrentlyEmployedCheckBox.AutoSize = true;
            this.CreateCurrentlyEmployedCheckBox.Location = new System.Drawing.Point(317, 265);
            this.CreateCurrentlyEmployedCheckBox.Name = "CreateCurrentlyEmployedCheckBox";
            this.CreateCurrentlyEmployedCheckBox.Size = new System.Drawing.Size(105, 24);
            this.CreateCurrentlyEmployedCheckBox.TabIndex = 14;
            this.CreateCurrentlyEmployedCheckBox.Text = "Employed?";
            this.CreateCurrentlyEmployedCheckBox.UseVisualStyleBackColor = true;
            // 
            // MessageCreateEmployee
            // 
            this.MessageCreateEmployee.AutoEllipsis = true;
            this.MessageCreateEmployee.Location = new System.Drawing.Point(161, 337);
            this.MessageCreateEmployee.Name = "MessageCreateEmployee";
            this.MessageCreateEmployee.Size = new System.Drawing.Size(420, 60);
            this.MessageCreateEmployee.TabIndex = 13;
            // 
            // EmployeeUpdatePanel
            // 
            this.EmployeeUpdatePanel.Controls.Add(this.UpdateEmployeeMessage);
            this.EmployeeUpdatePanel.Controls.Add(this.UpdateCurrentlyEmployed);
            this.EmployeeUpdatePanel.Controls.Add(this.label15);
            this.EmployeeUpdatePanel.Controls.Add(this.UpdateID);
            this.EmployeeUpdatePanel.Controls.Add(this.label9);
            this.EmployeeUpdatePanel.Controls.Add(this.UpdateDateOfBirth);
            this.EmployeeUpdatePanel.Controls.Add(this.label10);
            this.EmployeeUpdatePanel.Controls.Add(this.label11);
            this.EmployeeUpdatePanel.Controls.Add(this.UpdateEmail);
            this.EmployeeUpdatePanel.Controls.Add(this.label12);
            this.EmployeeUpdatePanel.Controls.Add(this.UpdateLastName);
            this.EmployeeUpdatePanel.Controls.Add(this.label13);
            this.EmployeeUpdatePanel.Controls.Add(this.UpdateFirstName);
            this.EmployeeUpdatePanel.Controls.Add(this.label14);
            this.EmployeeUpdatePanel.Controls.Add(this.UpdateButton);
            this.EmployeeUpdatePanel.Location = new System.Drawing.Point(14, 43);
            this.EmployeeUpdatePanel.Name = "EmployeeUpdatePanel";
            this.EmployeeUpdatePanel.Size = new System.Drawing.Size(733, 520);
            this.EmployeeUpdatePanel.TabIndex = 14;
            // 
            // UpdateEmployeeMessage
            // 
            this.UpdateEmployeeMessage.AutoEllipsis = true;
            this.UpdateEmployeeMessage.Location = new System.Drawing.Point(152, 373);
            this.UpdateEmployeeMessage.Name = "UpdateEmployeeMessage";
            this.UpdateEmployeeMessage.Size = new System.Drawing.Size(420, 60);
            this.UpdateEmployeeMessage.TabIndex = 15;
            // 
            // UpdateCurrentlyEmployed
            // 
            this.UpdateCurrentlyEmployed.AutoSize = true;
            this.UpdateCurrentlyEmployed.Location = new System.Drawing.Point(318, 324);
            this.UpdateCurrentlyEmployed.Name = "UpdateCurrentlyEmployed";
            this.UpdateCurrentlyEmployed.Size = new System.Drawing.Size(105, 24);
            this.UpdateCurrentlyEmployed.TabIndex = 15;
            this.UpdateCurrentlyEmployed.Text = "Employed?";
            this.UpdateCurrentlyEmployed.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(149, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 20);
            this.label15.TabIndex = 14;
            this.label15.Text = "ID of employee";
            // 
            // UpdateID
            // 
            this.UpdateID.Location = new System.Drawing.Point(318, 96);
            this.UpdateID.Name = "UpdateID";
            this.UpdateID.Size = new System.Drawing.Size(250, 27);
            this.UpdateID.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(246, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "Update Employee";
            // 
            // UpdateDateOfBirth
            // 
            this.UpdateDateOfBirth.Location = new System.Drawing.Point(318, 283);
            this.UpdateDateOfBirth.Name = "UpdateDateOfBirth";
            this.UpdateDateOfBirth.Size = new System.Drawing.Size(250, 27);
            this.UpdateDateOfBirth.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(145, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "First name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(145, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Last name";
            // 
            // UpdateEmail
            // 
            this.UpdateEmail.Location = new System.Drawing.Point(318, 244);
            this.UpdateEmail.MaxLength = 60;
            this.UpdateEmail.Name = "UpdateEmail";
            this.UpdateEmail.Size = new System.Drawing.Size(250, 27);
            this.UpdateEmail.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(145, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Email";
            // 
            // UpdateLastName
            // 
            this.UpdateLastName.Location = new System.Drawing.Point(318, 202);
            this.UpdateLastName.MaxLength = 30;
            this.UpdateLastName.Name = "UpdateLastName";
            this.UpdateLastName.Size = new System.Drawing.Size(250, 27);
            this.UpdateLastName.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(145, 288);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "Date of birth";
            // 
            // UpdateFirstName
            // 
            this.UpdateFirstName.Location = new System.Drawing.Point(318, 160);
            this.UpdateFirstName.MaxLength = 30;
            this.UpdateFirstName.Name = "UpdateFirstName";
            this.UpdateFirstName.Size = new System.Drawing.Size(250, 27);
            this.UpdateFirstName.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(145, 328);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "Currently employed";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(310, 449);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(94, 29);
            this.UpdateButton.TabIndex = 6;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ListEmployeesPanel
            // 
            this.ListEmployeesPanel.Controls.Add(this.ListSearchCheckBox);
            this.ListEmployeesPanel.Controls.Add(this.ListSearchDate);
            this.ListEmployeesPanel.Controls.Add(this.EmployeeDataGridView);
            this.ListEmployeesPanel.Controls.Add(this.SearchDropDown);
            this.ListEmployeesPanel.Controls.Add(this.label7);
            this.ListEmployeesPanel.Controls.Add(this.SearchTextBox);
            this.ListEmployeesPanel.Controls.Add(this.SearchButton);
            this.ListEmployeesPanel.Location = new System.Drawing.Point(16, 43);
            this.ListEmployeesPanel.Name = "ListEmployeesPanel";
            this.ListEmployeesPanel.Size = new System.Drawing.Size(733, 520);
            this.ListEmployeesPanel.TabIndex = 14;
            // 
            // ListSearchCheckBox
            // 
            this.ListSearchCheckBox.AutoSize = true;
            this.ListSearchCheckBox.Location = new System.Drawing.Point(314, 85);
            this.ListSearchCheckBox.Name = "ListSearchCheckBox";
            this.ListSearchCheckBox.Size = new System.Drawing.Size(105, 24);
            this.ListSearchCheckBox.TabIndex = 15;
            this.ListSearchCheckBox.Text = "Employed?";
            this.ListSearchCheckBox.UseVisualStyleBackColor = true;
            this.ListSearchCheckBox.Visible = false;
            // 
            // ListSearchDate
            // 
            this.ListSearchDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ListSearchDate.Location = new System.Drawing.Point(311, 82);
            this.ListSearchDate.Name = "ListSearchDate";
            this.ListSearchDate.Size = new System.Drawing.Size(173, 27);
            this.ListSearchDate.TabIndex = 15;
            this.ListSearchDate.Visible = false;
            // 
            // EmployeeDataGridView
            // 
            this.EmployeeDataGridView.AllowUserToAddRows = false;
            this.EmployeeDataGridView.AllowUserToDeleteRows = false;
            this.EmployeeDataGridView.AllowUserToOrderColumns = true;
            this.EmployeeDataGridView.AutoGenerateColumns = false;
            this.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.currentlyEmployedDataGridViewCheckBoxColumn});
            this.EmployeeDataGridView.DataSource = this.employeeBindingSource2;
            this.EmployeeDataGridView.Location = new System.Drawing.Point(18, 160);
            this.EmployeeDataGridView.MultiSelect = false;
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.ReadOnly = true;
            this.EmployeeDataGridView.RowHeadersWidth = 51;
            this.EmployeeDataGridView.RowTemplate.Height = 29;
            this.EmployeeDataGridView.Size = new System.Drawing.Size(694, 339);
            this.EmployeeDataGridView.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 125;
            // 
            // currentlyEmployedDataGridViewCheckBoxColumn
            // 
            this.currentlyEmployedDataGridViewCheckBoxColumn.DataPropertyName = "CurrentlyEmployed";
            this.currentlyEmployedDataGridViewCheckBoxColumn.HeaderText = "CurrentlyEmployed";
            this.currentlyEmployedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.currentlyEmployedDataGridViewCheckBoxColumn.Name = "currentlyEmployedDataGridViewCheckBoxColumn";
            this.currentlyEmployedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.currentlyEmployedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // employeeBindingSource2
            // 
            this.employeeBindingSource2.DataSource = typeof(AVEVA_code_test.Models.Employee);
            // 
            // SearchDropDown
            // 
            this.SearchDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchDropDown.FormattingEnabled = true;
            this.SearchDropDown.Items.AddRange(new object[] {
            "id",
            "first name",
            "last name",
            "email",
            "date of birth",
            "currently employed"});
            this.SearchDropDown.Location = new System.Drawing.Point(154, 82);
            this.SearchDropDown.Name = "SearchDropDown";
            this.SearchDropDown.Size = new System.Drawing.Size(151, 28);
            this.SearchDropDown.TabIndex = 9;
            this.SearchDropDown.SelectedIndexChanged += new System.EventHandler(this.SearchDropDown_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(306, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "List Employees";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(311, 83);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(173, 27);
            this.SearchTextBox.TabIndex = 7;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(490, 81);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(94, 29);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataSource = typeof(AVEVA_code_test.Models.Employee);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.createToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(769, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(AVEVA_code_test.Models.Employee);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 580);
            this.Controls.Add(this.CreateEmployeePanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.EmployeeUpdatePanel);
            this.Controls.Add(this.ListEmployeesPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Employee management";
            this.CreateEmployeePanel.ResumeLayout(false);
            this.CreateEmployeePanel.PerformLayout();
            this.EmployeeUpdatePanel.ResumeLayout(false);
            this.EmployeeUpdatePanel.PerformLayout();
            this.ListEmployeesPanel.ResumeLayout(false);
            this.ListEmployeesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button CreateButton;
        private TextBox CreateFirstNameTextBox;
        private TextBox CreateLastNameTextBox;
        private TextBox CreateEmailTextBox;
        private DateTimePicker CreateDateOfBirthPicker;
        private Panel CreateEmployeePanel;
        private Label MessageCreateEmployee;
        private Panel ListEmployeesPanel;
        private ComboBox SearchDropDown;
        private Label label7;
        private TextBox SearchTextBox;
        private Button SearchButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem listToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem;
        private Panel EmployeeUpdatePanel;
        private Label label15;
        private TextBox UpdateID;
        private Label label9;
        private DateTimePicker UpdateDateOfBirth;
        private Label label10;
        private Label label11;
        private TextBox UpdateEmail;
        private Label label12;
        private TextBox UpdateLastName;
        private Label label13;
        private TextBox UpdateFirstName;
        private Label label14;
        private Button UpdateButton;
        private DataGridView EmployeeDataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn firstname;
        private DataGridViewTextBoxColumn lastname;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn dateofbirth;
        private DataGridViewTextBoxColumn currentlyemployed;
        private CheckBox CreateCurrentlyEmployedCheckBox;
        private CheckBox UpdateCurrentlyEmployed;
        private Label UpdateEmployeeMessage;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn currentlyEmployedDataGridViewCheckBoxColumn;
        private BindingSource employeeBindingSource1;
        private BindingSource employeeBindingSource;
        private BindingSource employeeBindingSource2;
        private CheckBox ListSearchCheckBox;
        private DateTimePicker ListSearchDate;
    }
}