
namespace ExaminationSys
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.email = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.UserName = new System.Windows.Forms.Label();
            this.doneMail = new System.Windows.Forms.Button();
            this.chngPass = new System.Windows.Forms.Button();
            this.phone = new System.Windows.Forms.Label();
            this.upd_email = new System.Windows.Forms.Button();
            this.upd_phone = new System.Windows.Forms.Button();
            this.donePhone = new System.Windows.Forms.Button();
            this.mailnew = new System.Windows.Forms.TextBox();
            this.phonenew = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.donePass = new System.Windows.Forms.Button();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.oldPasslabel = new System.Windows.Forms.Label();
            this.oldPass = new System.Windows.Forms.TextBox();
            this.newLabel = new System.Windows.Forms.Label();
            this.courses = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(309, 380);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(512, 66);
            this.dgvData.TabIndex = 4;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(43)))), ((int)(((byte)(100)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 10);
            this.panel2.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(43)))), ((int)(((byte)(100)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 10);
            this.panel1.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(43)))), ((int)(((byte)(100)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 465);
            this.panel3.TabIndex = 22;
            // 
            // button13
            // 
            this.button13.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(820, 15);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(32, 35);
            this.button13.TabIndex = 23;
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(43)))), ((int)(((byte)(100)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 465);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(860, 10);
            this.panel4.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(43)))), ((int)(((byte)(100)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(860, 10);
            this.panel5.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 137);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.email.Location = new System.Drawing.Point(210, 123);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(72, 25);
            this.email.TabIndex = 29;
            this.email.Text = "Email";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.panel6.Controls.Add(this.UserName);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Location = new System.Drawing.Point(33, 18);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(167, 187);
            this.panel6.TabIndex = 30;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.White;
            this.UserName.Location = new System.Drawing.Point(43, 153);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(86, 24);
            this.UserName.TabIndex = 45;
            this.UserName.Text = "Name : ";
            // 
            // doneMail
            // 
            this.doneMail.FlatAppearance.BorderSize = 0;
            this.doneMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneMail.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneMail.Image = ((System.Drawing.Image)(resources.GetObject("doneMail.Image")));
            this.doneMail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.doneMail.Location = new System.Drawing.Point(546, 72);
            this.doneMail.Margin = new System.Windows.Forms.Padding(5);
            this.doneMail.Name = "doneMail";
            this.doneMail.Size = new System.Drawing.Size(95, 38);
            this.doneMail.TabIndex = 32;
            this.doneMail.Text = "Done";
            this.doneMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doneMail.UseVisualStyleBackColor = true;
            this.doneMail.Visible = false;
            this.doneMail.Click += new System.EventHandler(this.doneMail_Click);
            // 
            // chngPass
            // 
            this.chngPass.FlatAppearance.BorderSize = 0;
            this.chngPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chngPass.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chngPass.Image = ((System.Drawing.Image)(resources.GetObject("chngPass.Image")));
            this.chngPass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chngPass.Location = new System.Drawing.Point(210, 240);
            this.chngPass.Margin = new System.Windows.Forms.Padding(5);
            this.chngPass.Name = "chngPass";
            this.chngPass.Size = new System.Drawing.Size(232, 47);
            this.chngPass.TabIndex = 35;
            this.chngPass.Text = "Change Password";
            this.chngPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chngPass.UseVisualStyleBackColor = true;
            this.chngPass.Click += new System.EventHandler(this.button1_Click);
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.phone.Location = new System.Drawing.Point(210, 203);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(61, 25);
            this.phone.TabIndex = 37;
            this.phone.Text = "phne";
            this.phone.Click += new System.EventHandler(this.phone_Click);
            // 
            // upd_email
            // 
            this.upd_email.FlatAppearance.BorderSize = 0;
            this.upd_email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upd_email.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upd_email.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.upd_email.Location = new System.Drawing.Point(559, 76);
            this.upd_email.Margin = new System.Windows.Forms.Padding(5);
            this.upd_email.Name = "upd_email";
            this.upd_email.Size = new System.Drawing.Size(78, 35);
            this.upd_email.TabIndex = 38;
            this.upd_email.Text = "Change ";
            this.upd_email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.upd_email.UseVisualStyleBackColor = true;
            this.upd_email.Click += new System.EventHandler(this.upd_email_Click);
            // 
            // upd_phone
            // 
            this.upd_phone.FlatAppearance.BorderSize = 0;
            this.upd_phone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upd_phone.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upd_phone.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.upd_phone.Location = new System.Drawing.Point(559, 153);
            this.upd_phone.Margin = new System.Windows.Forms.Padding(5);
            this.upd_phone.Name = "upd_phone";
            this.upd_phone.Size = new System.Drawing.Size(78, 38);
            this.upd_phone.TabIndex = 41;
            this.upd_phone.Text = "Change ";
            this.upd_phone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.upd_phone.UseVisualStyleBackColor = true;
            this.upd_phone.Click += new System.EventHandler(this.button4_Click);
            // 
            // donePhone
            // 
            this.donePhone.FlatAppearance.BorderSize = 0;
            this.donePhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donePhone.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donePhone.Image = ((System.Drawing.Image)(resources.GetObject("donePhone.Image")));
            this.donePhone.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.donePhone.Location = new System.Drawing.Point(546, 149);
            this.donePhone.Margin = new System.Windows.Forms.Padding(5);
            this.donePhone.Name = "donePhone";
            this.donePhone.Size = new System.Drawing.Size(95, 42);
            this.donePhone.TabIndex = 39;
            this.donePhone.Text = "Done";
            this.donePhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.donePhone.UseVisualStyleBackColor = true;
            this.donePhone.Visible = false;
            this.donePhone.Click += new System.EventHandler(this.donePhone_Click);
            // 
            // mailnew
            // 
            this.mailnew.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailnew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.mailnew.Location = new System.Drawing.Point(645, 83);
            this.mailnew.Multiline = true;
            this.mailnew.Name = "mailnew";
            this.mailnew.Size = new System.Drawing.Size(189, 28);
            this.mailnew.TabIndex = 42;
            this.mailnew.UseWaitCursor = true;
            this.mailnew.Visible = false;
            // 
            // phonenew
            // 
            this.phonenew.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.phonenew.Location = new System.Drawing.Point(645, 163);
            this.phonenew.Multiline = true;
            this.phonenew.Name = "phonenew";
            this.phonenew.Size = new System.Drawing.Size(189, 28);
            this.phonenew.TabIndex = 43;
            this.phonenew.UseWaitCursor = true;
            this.phonenew.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Gabriola", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(51, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 65);
            this.label2.TabIndex = 44;
            this.label2.Text = "Welcome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 45;
            this.label3.Text = "Email : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 46;
            this.label4.Text = "Phone : ";
            // 
            // donePass
            // 
            this.donePass.FlatAppearance.BorderSize = 0;
            this.donePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donePass.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donePass.Image = ((System.Drawing.Image)(resources.GetObject("donePass.Image")));
            this.donePass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.donePass.Location = new System.Drawing.Point(502, 303);
            this.donePass.Margin = new System.Windows.Forms.Padding(5);
            this.donePass.Name = "donePass";
            this.donePass.Size = new System.Drawing.Size(95, 42);
            this.donePass.TabIndex = 47;
            this.donePass.Text = "Done";
            this.donePass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.donePass.UseVisualStyleBackColor = true;
            this.donePass.Visible = false;
            this.donePass.Click += new System.EventHandler(this.donePass_Click);
            // 
            // passwordtext
            // 
            this.passwordtext.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.passwordtext.Location = new System.Drawing.Point(645, 272);
            this.passwordtext.Multiline = true;
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(189, 28);
            this.passwordtext.TabIndex = 48;
            this.passwordtext.UseWaitCursor = true;
            this.passwordtext.Visible = false;
            // 
            // oldPasslabel
            // 
            this.oldPasslabel.AutoSize = true;
            this.oldPasslabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPasslabel.Location = new System.Drawing.Point(498, 244);
            this.oldPasslabel.Name = "oldPasslabel";
            this.oldPasslabel.Size = new System.Drawing.Size(122, 22);
            this.oldPasslabel.TabIndex = 49;
            this.oldPasslabel.Text = "Old Password";
            this.oldPasslabel.Visible = false;
            // 
            // oldPass
            // 
            this.oldPass.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.oldPass.Location = new System.Drawing.Point(645, 240);
            this.oldPass.Multiline = true;
            this.oldPass.Name = "oldPass";
            this.oldPass.Size = new System.Drawing.Size(189, 28);
            this.oldPass.TabIndex = 50;
            this.oldPass.UseWaitCursor = true;
            this.oldPass.Visible = false;
            // 
            // newLabel
            // 
            this.newLabel.AutoSize = true;
            this.newLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLabel.Location = new System.Drawing.Point(498, 276);
            this.newLabel.Name = "newLabel";
            this.newLabel.Size = new System.Drawing.Size(131, 22);
            this.newLabel.TabIndex = 51;
            this.newLabel.Text = "New Password";
            this.newLabel.Visible = false;
            // 
            // courses
            // 
            this.courses.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.courses.FormattingEnabled = true;
            this.courses.Location = new System.Drawing.Point(33, 404);
            this.courses.Name = "courses";
            this.courses.Size = new System.Drawing.Size(121, 36);
            this.courses.TabIndex = 52;
            this.courses.Visible = false;
            this.courses.SelectedIndexChanged += new System.EventHandler(this.courses_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(33, 290);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 106);
            this.button1.TabIndex = 53;
            this.button1.Text = "Display Courses";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(162, 401);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 45);
            this.button2.TabIndex = 54;
            this.button2.Text = "Take Exam";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StudentForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 475);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.courses);
            this.Controls.Add(this.newLabel);
            this.Controls.Add(this.oldPass);
            this.Controls.Add(this.oldPasslabel);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.donePass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phonenew);
            this.Controls.Add(this.mailnew);
            this.Controls.Add(this.upd_phone);
            this.Controls.Add(this.donePhone);
            this.Controls.Add(this.upd_email);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.chngPass);
            this.Controls.Add(this.doneMail);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.email);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgvData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StudentForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StudentForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StudentForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label email;
        private System.Windows.Forms.Button doneMail;
        private System.Windows.Forms.Button chngPass;
        public System.Windows.Forms.Label phone;
        private System.Windows.Forms.Button upd_email;
        private System.Windows.Forms.Button upd_phone;
        private System.Windows.Forms.Button donePhone;
        private System.Windows.Forms.TextBox mailnew;
        private System.Windows.Forms.TextBox phonenew;
        public System.Windows.Forms.Label UserName;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button donePass;
        private System.Windows.Forms.TextBox passwordtext;
        public System.Windows.Forms.Label oldPasslabel;
        private System.Windows.Forms.TextBox oldPass;
        public System.Windows.Forms.Label newLabel;
        private System.Windows.Forms.ComboBox courses;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}