
namespace ExaminationSys
{
    partial class InstructorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.UserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button13 = new System.Windows.Forms.Button();
            this.departmentLbl = new System.Windows.Forms.Label();
            this.salaryLbl = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.sel_by_dept = new System.Windows.Forms.Button();
            this.sel_all = new System.Windows.Forms.Button();
            this.lblTotalStuds = new System.Windows.Forms.Label();
            this.btnRgstrStud = new System.Windows.Forms.Button();
            this.btnDltStud = new System.Windows.Forms.Button();
            this.btnShowResult = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(43)))), ((int)(((byte)(100)))));
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(43)))), ((int)(((byte)(100)))));
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(43)))), ((int)(((byte)(100)))));
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.panel6.Controls.Add(this.UserName);
            this.panel6.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // UserName
            // 
            resources.ApplyResources(this.UserName, "UserName");
            this.UserName.ForeColor = System.Drawing.Color.White;
            this.UserName.Name = "UserName";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // button13
            // 
            this.button13.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button13.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button13, "button13");
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Name = "button13";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // departmentLbl
            // 
            resources.ApplyResources(this.departmentLbl, "departmentLbl");
            this.departmentLbl.Name = "departmentLbl";
            // 
            // salaryLbl
            // 
            resources.ApplyResources(this.salaryLbl, "salaryLbl");
            this.salaryLbl.Name = "salaryLbl";
            // 
            // department
            // 
            resources.ApplyResources(this.department, "department");
            this.department.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.department.Name = "department";
            // 
            // salary
            // 
            resources.ApplyResources(this.salary, "salary");
            this.salary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.salary.Name = "salary";
            // 
            // dgvData
            // 
            this.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvData, "dgvData");
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            // 
            // sel_by_dept
            // 
            this.sel_by_dept.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.sel_by_dept, "sel_by_dept");
            this.sel_by_dept.Name = "sel_by_dept";
            this.sel_by_dept.UseVisualStyleBackColor = true;
            this.sel_by_dept.Click += new System.EventHandler(this.sel_by_dept_Click);
            // 
            // sel_all
            // 
            this.sel_all.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.sel_all, "sel_all");
            this.sel_all.Name = "sel_all";
            this.sel_all.UseVisualStyleBackColor = true;
            this.sel_all.Click += new System.EventHandler(this.sel_all_Click);
            // 
            // lblTotalStuds
            // 
            resources.ApplyResources(this.lblTotalStuds, "lblTotalStuds");
            this.lblTotalStuds.Name = "lblTotalStuds";
            // 
            // btnRgstrStud
            // 
            resources.ApplyResources(this.btnRgstrStud, "btnRgstrStud");
            this.btnRgstrStud.Name = "btnRgstrStud";
            this.btnRgstrStud.UseVisualStyleBackColor = true;
            this.btnRgstrStud.Click += new System.EventHandler(this.btnRgstrStud_Click);
            // 
            // btnDltStud
            // 
            resources.ApplyResources(this.btnDltStud, "btnDltStud");
            this.btnDltStud.Name = "btnDltStud";
            this.btnDltStud.UseVisualStyleBackColor = true;
            this.btnDltStud.Click += new System.EventHandler(this.btnDltStud_Click);
            // 
            // btnShowResult
            // 
            resources.ApplyResources(this.btnShowResult, "btnShowResult");
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.UseVisualStyleBackColor = true;
            this.btnShowResult.Click += new System.EventHandler(this.btnUpdtStud_Click);
            // 
            // InstructorForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnShowResult);
            this.Controls.Add(this.btnDltStud);
            this.Controls.Add(this.btnRgstrStud);
            this.Controls.Add(this.lblTotalStuds);
            this.Controls.Add(this.sel_all);
            this.Controls.Add(this.sel_by_dept);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.departmentLbl);
            this.Controls.Add(this.salaryLbl);
            this.Controls.Add(this.department);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InstructorForm";
            this.Load += new System.EventHandler(this.InstructorForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InstructorForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InstructorForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.InstructorForm_MouseUp);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label UserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button13;
        public System.Windows.Forms.Label departmentLbl;
        public System.Windows.Forms.Label salaryLbl;
        public System.Windows.Forms.Label department;
        public System.Windows.Forms.Label salary;
        public System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button sel_by_dept;
        private System.Windows.Forms.Button sel_all;
        private System.Windows.Forms.Label lblTotalStuds;
        private System.Windows.Forms.Button btnShowResult;
        private System.Windows.Forms.Button btnDltStud;
        private System.Windows.Forms.Button btnRgstrStud;
    }
}