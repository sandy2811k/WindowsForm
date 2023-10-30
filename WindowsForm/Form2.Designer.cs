namespace WindowsForm
{
    partial class Form2
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
            this.lbl_Employee_id = new System.Windows.Forms.Label();
            this.lbl_Employee_name = new System.Windows.Forms.Label();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.lbl_BasicSalary = new System.Windows.Forms.Label();
            this.lbl_HRA = new System.Windows.Forms.Label();
            this.lbl_PF = new System.Windows.Forms.Label();
            this.lbl_DA = new System.Windows.Forms.Label();
            this.lbl_TA = new System.Windows.Forms.Label();
            this.lbl_GrossSalary = new System.Windows.Forms.Label();
            this.txt_Employeeid = new System.Windows.Forms.TextBox();
            this.txt_EmployeeName = new System.Windows.Forms.TextBox();
            this.txt_HRA = new System.Windows.Forms.TextBox();
            this.txt_BasicSalary = new System.Windows.Forms.TextBox();
            this.txt_TA = new System.Windows.Forms.TextBox();
            this.txt_DA = new System.Windows.Forms.TextBox();
            this.txt_PF = new System.Windows.Forms.TextBox();
            this.txt_GrossSalary = new System.Windows.Forms.TextBox();
            this.txt_comboBox_Department = new System.Windows.Forms.ComboBox();
            this.butn_Calculate = new System.Windows.Forms.Button();
            this.butn_Display = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Employee_id
            // 
            this.lbl_Employee_id.AutoSize = true;
            this.lbl_Employee_id.Location = new System.Drawing.Point(81, 41);
            this.lbl_Employee_id.Name = "lbl_Employee_id";
            this.lbl_Employee_id.Size = new System.Drawing.Size(64, 13);
            this.lbl_Employee_id.TabIndex = 0;
            this.lbl_Employee_id.Text = "Employee id";
            // 
            // lbl_Employee_name
            // 
            this.lbl_Employee_name.AutoSize = true;
            this.lbl_Employee_name.Location = new System.Drawing.Point(81, 91);
            this.lbl_Employee_name.Name = "lbl_Employee_name";
            this.lbl_Employee_name.Size = new System.Drawing.Size(84, 13);
            this.lbl_Employee_name.TabIndex = 1;
            this.lbl_Employee_name.Text = "Employee Name";
            // 
            // lbl_Department
            // 
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.Location = new System.Drawing.Point(81, 147);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(62, 13);
            this.lbl_Department.TabIndex = 2;
            this.lbl_Department.Text = "Department";
            // 
            // lbl_BasicSalary
            // 
            this.lbl_BasicSalary.AutoSize = true;
            this.lbl_BasicSalary.Location = new System.Drawing.Point(81, 193);
            this.lbl_BasicSalary.Name = "lbl_BasicSalary";
            this.lbl_BasicSalary.Size = new System.Drawing.Size(65, 13);
            this.lbl_BasicSalary.TabIndex = 3;
            this.lbl_BasicSalary.Text = "Basic Salary";
            // 
            // lbl_HRA
            // 
            this.lbl_HRA.AutoSize = true;
            this.lbl_HRA.Location = new System.Drawing.Point(81, 242);
            this.lbl_HRA.Name = "lbl_HRA";
            this.lbl_HRA.Size = new System.Drawing.Size(30, 13);
            this.lbl_HRA.TabIndex = 4;
            this.lbl_HRA.Text = "HRA";
            // 
            // lbl_PF
            // 
            this.lbl_PF.AutoSize = true;
            this.lbl_PF.Location = new System.Drawing.Point(82, 363);
            this.lbl_PF.Name = "lbl_PF";
            this.lbl_PF.Size = new System.Drawing.Size(20, 13);
            this.lbl_PF.TabIndex = 5;
            this.lbl_PF.Text = "PF";
            // 
            // lbl_DA
            // 
            this.lbl_DA.AutoSize = true;
            this.lbl_DA.Location = new System.Drawing.Point(82, 321);
            this.lbl_DA.Name = "lbl_DA";
            this.lbl_DA.Size = new System.Drawing.Size(22, 13);
            this.lbl_DA.TabIndex = 6;
            this.lbl_DA.Text = "DA";
            // 
            // lbl_TA
            // 
            this.lbl_TA.AutoSize = true;
            this.lbl_TA.Location = new System.Drawing.Point(82, 282);
            this.lbl_TA.Name = "lbl_TA";
            this.lbl_TA.Size = new System.Drawing.Size(21, 13);
            this.lbl_TA.TabIndex = 7;
            this.lbl_TA.Text = "TA";
            // 
            // lbl_GrossSalary
            // 
            this.lbl_GrossSalary.AutoSize = true;
            this.lbl_GrossSalary.Location = new System.Drawing.Point(82, 400);
            this.lbl_GrossSalary.Name = "lbl_GrossSalary";
            this.lbl_GrossSalary.Size = new System.Drawing.Size(66, 13);
            this.lbl_GrossSalary.TabIndex = 8;
            this.lbl_GrossSalary.Text = "Gross Salary";
            // 
            // txt_Employeeid
            // 
            this.txt_Employeeid.Location = new System.Drawing.Point(211, 34);
            this.txt_Employeeid.Name = "txt_Employeeid";
            this.txt_Employeeid.Size = new System.Drawing.Size(206, 20);
            this.txt_Employeeid.TabIndex = 9;
            // 
            // txt_EmployeeName
            // 
            this.txt_EmployeeName.Location = new System.Drawing.Point(211, 84);
            this.txt_EmployeeName.Name = "txt_EmployeeName";
            this.txt_EmployeeName.Size = new System.Drawing.Size(206, 20);
            this.txt_EmployeeName.TabIndex = 10;
            // 
            // txt_HRA
            // 
            this.txt_HRA.Location = new System.Drawing.Point(211, 235);
            this.txt_HRA.Name = "txt_HRA";
            this.txt_HRA.ReadOnly = true;
            this.txt_HRA.Size = new System.Drawing.Size(206, 20);
            this.txt_HRA.TabIndex = 11;
            this.txt_HRA.TextChanged += new System.EventHandler(this.txt_HRA_TextChanged);
            // 
            // txt_BasicSalary
            // 
            this.txt_BasicSalary.Location = new System.Drawing.Point(211, 186);
            this.txt_BasicSalary.Name = "txt_BasicSalary";
            this.txt_BasicSalary.Size = new System.Drawing.Size(206, 20);
            this.txt_BasicSalary.TabIndex = 12;
            // 
            // txt_TA
            // 
            this.txt_TA.Location = new System.Drawing.Point(211, 279);
            this.txt_TA.Name = "txt_TA";
            this.txt_TA.ReadOnly = true;
            this.txt_TA.Size = new System.Drawing.Size(206, 20);
            this.txt_TA.TabIndex = 13;
            this.txt_TA.TextChanged += new System.EventHandler(this.txt_TA_TextChanged);
            // 
            // txt_DA
            // 
            this.txt_DA.Location = new System.Drawing.Point(211, 314);
            this.txt_DA.Name = "txt_DA";
            this.txt_DA.ReadOnly = true;
            this.txt_DA.Size = new System.Drawing.Size(206, 20);
            this.txt_DA.TabIndex = 14;
            this.txt_DA.TextChanged += new System.EventHandler(this.txt_DA_TextChanged);
            // 
            // txt_PF
            // 
            this.txt_PF.Location = new System.Drawing.Point(211, 356);
            this.txt_PF.Name = "txt_PF";
            this.txt_PF.ReadOnly = true;
            this.txt_PF.Size = new System.Drawing.Size(206, 20);
            this.txt_PF.TabIndex = 15;
            this.txt_PF.TextChanged += new System.EventHandler(this.txt_PF_TextChanged);
            // 
            // txt_GrossSalary
            // 
            this.txt_GrossSalary.Location = new System.Drawing.Point(211, 393);
            this.txt_GrossSalary.Name = "txt_GrossSalary";
            this.txt_GrossSalary.ReadOnly = true;
            this.txt_GrossSalary.Size = new System.Drawing.Size(206, 20);
            this.txt_GrossSalary.TabIndex = 16;
            this.txt_GrossSalary.TextChanged += new System.EventHandler(this.txt_GrossSalary_TextChanged);
            // 
            // txt_comboBox_Department
            // 
            this.txt_comboBox_Department.FormattingEnabled = true;
            this.txt_comboBox_Department.Location = new System.Drawing.Point(211, 139);
            this.txt_comboBox_Department.Name = "txt_comboBox_Department";
            this.txt_comboBox_Department.Size = new System.Drawing.Size(206, 21);
            this.txt_comboBox_Department.TabIndex = 17;
            this.txt_comboBox_Department.SelectedIndexChanged += new System.EventHandler(this.comboBox_Department_SelectedIndexChanged);
            // 
            // butn_Calculate
            // 
            this.butn_Calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.butn_Calculate.Location = new System.Drawing.Point(444, 347);
            this.butn_Calculate.Name = "butn_Calculate";
            this.butn_Calculate.Size = new System.Drawing.Size(132, 28);
            this.butn_Calculate.TabIndex = 18;
            this.butn_Calculate.Text = "Calculate";
            this.butn_Calculate.UseVisualStyleBackColor = false;
            this.butn_Calculate.Click += new System.EventHandler(this.butn_Calculate_Click);
            // 
            // butn_Display
            // 
            this.butn_Display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.butn_Display.Location = new System.Drawing.Point(606, 347);
            this.butn_Display.Name = "butn_Display";
            this.butn_Display.Size = new System.Drawing.Size(132, 28);
            this.butn_Display.TabIndex = 19;
            this.butn_Display.Text = "Display";
            this.butn_Display.UseVisualStyleBackColor = false;
            this.butn_Display.Click += new System.EventHandler(this.butn_Display_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.Location = new System.Drawing.Point(463, 149);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(50, 15);
            this.lblmsg.TabIndex = 21;
            this.lblmsg.Text = "lblmsg";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.butn_Display);
            this.Controls.Add(this.butn_Calculate);
            this.Controls.Add(this.txt_comboBox_Department);
            this.Controls.Add(this.txt_GrossSalary);
            this.Controls.Add(this.txt_PF);
            this.Controls.Add(this.txt_DA);
            this.Controls.Add(this.txt_TA);
            this.Controls.Add(this.txt_BasicSalary);
            this.Controls.Add(this.txt_HRA);
            this.Controls.Add(this.txt_EmployeeName);
            this.Controls.Add(this.txt_Employeeid);
            this.Controls.Add(this.lbl_GrossSalary);
            this.Controls.Add(this.lbl_TA);
            this.Controls.Add(this.lbl_DA);
            this.Controls.Add(this.lbl_PF);
            this.Controls.Add(this.lbl_HRA);
            this.Controls.Add(this.lbl_BasicSalary);
            this.Controls.Add(this.lbl_Department);
            this.Controls.Add(this.lbl_Employee_name);
            this.Controls.Add(this.lbl_Employee_id);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Employee_id;
        private System.Windows.Forms.Label lbl_Employee_name;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.Label lbl_BasicSalary;
        private System.Windows.Forms.Label lbl_HRA;
        private System.Windows.Forms.Label lbl_PF;
        private System.Windows.Forms.Label lbl_DA;
        private System.Windows.Forms.Label lbl_TA;
        private System.Windows.Forms.Label lbl_GrossSalary;
        private System.Windows.Forms.TextBox txt_Employeeid;
        private System.Windows.Forms.TextBox txt_EmployeeName;
        private System.Windows.Forms.TextBox txt_HRA;
        private System.Windows.Forms.TextBox txt_BasicSalary;
        private System.Windows.Forms.TextBox txt_TA;
        private System.Windows.Forms.TextBox txt_DA;
        private System.Windows.Forms.TextBox txt_PF;
        private System.Windows.Forms.TextBox txt_GrossSalary;
        private System.Windows.Forms.ComboBox txt_comboBox_Department;
        private System.Windows.Forms.Button butn_Calculate;
        private System.Windows.Forms.Button butn_Display;
        private System.Windows.Forms.Label lblmsg;
    }
}