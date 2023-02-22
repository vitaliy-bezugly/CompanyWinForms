namespace Company
{
    partial class CompanyForm
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
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.departmentDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateDepartmentButton = new System.Windows.Forms.Button();
            this.addDepartmentButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.departmentTitleTextBox = new System.Windows.Forms.TextBox();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.updateEmployeeButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ascendingSalaryCheckBox = new System.Windows.Forms.CheckBox();
            this.ascendingFullNameCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fullNameSortButton = new System.Windows.Forms.Button();
            this.salarySortButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveDataButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Location = new System.Drawing.Point(12, 364);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.ReadOnly = true;
            this.employeeDataGridView.RowHeadersWidth = 51;
            this.employeeDataGridView.RowTemplate.Height = 29;
            this.employeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeDataGridView.Size = new System.Drawing.Size(670, 266);
            this.employeeDataGridView.TabIndex = 0;
            // 
            // departmentDataGridView
            // 
            this.departmentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentDataGridView.Location = new System.Drawing.Point(12, 30);
            this.departmentDataGridView.Name = "departmentDataGridView";
            this.departmentDataGridView.ReadOnly = true;
            this.departmentDataGridView.RowHeadersWidth = 51;
            this.departmentDataGridView.RowTemplate.Height = 29;
            this.departmentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.departmentDataGridView.Size = new System.Drawing.Size(670, 308);
            this.departmentDataGridView.TabIndex = 1;
            this.departmentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellContent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Departments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee\'s";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.updateDepartmentButton);
            this.panel1.Controls.Add(this.addDepartmentButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.departmentTitleTextBox);
            this.panel1.Location = new System.Drawing.Point(688, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 251);
            this.panel1.TabIndex = 4;
            // 
            // updateDepartmentButton
            // 
            this.updateDepartmentButton.Location = new System.Drawing.Point(3, 103);
            this.updateDepartmentButton.Name = "updateDepartmentButton";
            this.updateDepartmentButton.Size = new System.Drawing.Size(186, 35);
            this.updateDepartmentButton.TabIndex = 7;
            this.updateDepartmentButton.Text = "Update department";
            this.updateDepartmentButton.UseVisualStyleBackColor = true;
            this.updateDepartmentButton.Click += new System.EventHandler(this.updateDepartmentButton_Click);
            // 
            // addDepartmentButton
            // 
            this.addDepartmentButton.Location = new System.Drawing.Point(3, 62);
            this.addDepartmentButton.Name = "addDepartmentButton";
            this.addDepartmentButton.Size = new System.Drawing.Size(186, 35);
            this.addDepartmentButton.TabIndex = 6;
            this.addDepartmentButton.Text = "Add department";
            this.addDepartmentButton.UseVisualStyleBackColor = true;
            this.addDepartmentButton.Click += new System.EventHandler(this.addDepartmentButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Department\'s title";
            // 
            // departmentTitleTextBox
            // 
            this.departmentTitleTextBox.Location = new System.Drawing.Point(3, 29);
            this.departmentTitleTextBox.Name = "departmentTitleTextBox";
            this.departmentTitleTextBox.Size = new System.Drawing.Size(186, 27);
            this.departmentTitleTextBox.TabIndex = 1;
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(3, 29);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(186, 35);
            this.addEmployeeButton.TabIndex = 8;
            this.addEmployeeButton.Text = "Add employee";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.updateEmployeeButton);
            this.panel3.Controls.Add(this.addEmployeeButton);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(688, 193);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 119);
            this.panel3.TabIndex = 11;
            // 
            // updateEmployeeButton
            // 
            this.updateEmployeeButton.Location = new System.Drawing.Point(3, 70);
            this.updateEmployeeButton.Name = "updateEmployeeButton";
            this.updateEmployeeButton.Size = new System.Drawing.Size(186, 35);
            this.updateEmployeeButton.TabIndex = 11;
            this.updateEmployeeButton.Text = "Update employee";
            this.updateEmployeeButton.UseVisualStyleBackColor = true;
            this.updateEmployeeButton.Click += new System.EventHandler(this.updateEmployeeButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Operations with employee";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.ascendingSalaryCheckBox);
            this.panel4.Controls.Add(this.ascendingFullNameCheckBox);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.fullNameSortButton);
            this.panel4.Controls.Add(this.salarySortButton);
            this.panel4.Location = new System.Drawing.Point(688, 318);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(196, 169);
            this.panel4.TabIndex = 11;
            // 
            // ascendingSalaryCheckBox
            // 
            this.ascendingSalaryCheckBox.AutoSize = true;
            this.ascendingSalaryCheckBox.Checked = true;
            this.ascendingSalaryCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ascendingSalaryCheckBox.Location = new System.Drawing.Point(3, 134);
            this.ascendingSalaryCheckBox.Name = "ascendingSalaryCheckBox";
            this.ascendingSalaryCheckBox.Size = new System.Drawing.Size(100, 24);
            this.ascendingSalaryCheckBox.TabIndex = 12;
            this.ascendingSalaryCheckBox.Text = "Ascending";
            this.ascendingSalaryCheckBox.UseVisualStyleBackColor = true;
            // 
            // ascendingFullNameCheckBox
            // 
            this.ascendingFullNameCheckBox.AutoSize = true;
            this.ascendingFullNameCheckBox.Checked = true;
            this.ascendingFullNameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ascendingFullNameCheckBox.Location = new System.Drawing.Point(3, 66);
            this.ascendingFullNameCheckBox.Name = "ascendingFullNameCheckBox";
            this.ascendingFullNameCheckBox.Size = new System.Drawing.Size(100, 24);
            this.ascendingFullNameCheckBox.TabIndex = 11;
            this.ascendingFullNameCheckBox.Text = "Ascending";
            this.ascendingFullNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sorting operations";
            // 
            // fullNameSortButton
            // 
            this.fullNameSortButton.Location = new System.Drawing.Point(3, 29);
            this.fullNameSortButton.Name = "fullNameSortButton";
            this.fullNameSortButton.Size = new System.Drawing.Size(186, 35);
            this.fullNameSortButton.TabIndex = 8;
            this.fullNameSortButton.Text = "Sort by full name";
            this.fullNameSortButton.UseVisualStyleBackColor = true;
            this.fullNameSortButton.Click += new System.EventHandler(this.fullNameSortButton_Click);
            // 
            // salarySortButton
            // 
            this.salarySortButton.Location = new System.Drawing.Point(3, 93);
            this.salarySortButton.Name = "salarySortButton";
            this.salarySortButton.Size = new System.Drawing.Size(186, 35);
            this.salarySortButton.TabIndex = 9;
            this.salarySortButton.Text = "Sort by salary";
            this.salarySortButton.UseVisualStyleBackColor = true;
            this.salarySortButton.Click += new System.EventHandler(this.salarySortButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loadButton.Location = new System.Drawing.Point(693, 595);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(186, 35);
            this.loadButton.TabIndex = 12;
            this.loadButton.Text = "Load data";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadDataButton_Click);
            // 
            // saveDataButton
            // 
            this.saveDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveDataButton.Location = new System.Drawing.Point(693, 554);
            this.saveDataButton.Name = "saveDataButton";
            this.saveDataButton.Size = new System.Drawing.Size(186, 35);
            this.saveDataButton.TabIndex = 13;
            this.saveDataButton.Text = "Save data";
            this.saveDataButton.UseVisualStyleBackColor = true;
            this.saveDataButton.Click += new System.EventHandler(this.saveDataButton_Click);
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 647);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.saveDataButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departmentDataGridView);
            this.Controls.Add(this.employeeDataGridView);
            this.Name = "CompanyForm";
            this.Text = "Company form";
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView employeeDataGridView;
        private DataGridView departmentDataGridView;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button addDepartmentButton;
        private Label label3;
        private TextBox departmentTitleTextBox;
        private Button updateDepartmentButton;
        private Button addEmployeeButton;
        private Panel panel3;
        private Label label5;
        private Panel panel4;
        private Label label6;
        private Button fullNameSortButton;
        private Button salarySortButton;
        private Button addEmployeeButton2;
        private Button updateEmployeeButton;
        private Button loadButton;
        private CheckBox ascendingSalaryCheckBox;
        private CheckBox ascendingFullNameCheckBox;
        private Button saveDataButton;
    }
}