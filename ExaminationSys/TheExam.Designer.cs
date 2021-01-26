
namespace ExaminationSys
{
    partial class TheExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheExam));
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.ans1 = new System.Windows.Forms.RadioButton();
            this.ans2 = new System.Windows.Forms.RadioButton();
            this.ans3 = new System.Windows.Forms.RadioButton();
            this.ans4 = new System.Windows.Forms.RadioButton();
            this.quest_body = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(43)))), ((int)(((byte)(100)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 421);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(839, 10);
            this.panel5.TabIndex = 25;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(43)))), ((int)(((byte)(100)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 421);
            this.panel3.TabIndex = 26;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(43)))), ((int)(((byte)(100)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 10);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.button13.Location = new System.Drawing.Point(774, 18);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(32, 35);
            this.button13.TabIndex = 27;
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Gabriola", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(43)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(313, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 65);
            this.label2.TabIndex = 45;
            this.label2.Text = "Welcome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submit
            // 
            this.submit.FlatAppearance.BorderSize = 0;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.submit.Location = new System.Drawing.Point(623, 329);
            this.submit.Margin = new System.Windows.Forms.Padding(5);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(183, 84);
            this.submit.TabIndex = 46;
            this.submit.Text = "Submit Answers";
            this.submit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Visible = false;
            this.submit.Click += new System.EventHandler(this.validate_Click);
            // 
            // next
            // 
            this.next.FlatAppearance.BorderSize = 0;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(43)))), ((int)(((byte)(100)))));
            this.next.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.next.Location = new System.Drawing.Point(693, 260);
            this.next.Margin = new System.Windows.Forms.Padding(5);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(72, 59);
            this.next.TabIndex = 54;
            this.next.Text = "Next";
            this.next.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // back
            // 
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(43)))), ((int)(((byte)(100)))));
            this.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back.Location = new System.Drawing.Point(33, 260);
            this.back.Margin = new System.Windows.Forms.Padding(5);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(74, 59);
            this.back.TabIndex = 55;
            this.back.Text = "Back";
            this.back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ans1
            // 
            this.ans1.AutoSize = true;
            this.ans1.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold);
            this.ans1.Location = new System.Drawing.Point(191, 171);
            this.ans1.Name = "ans1";
            this.ans1.Size = new System.Drawing.Size(158, 54);
            this.ans1.TabIndex = 56;
            this.ans1.TabStop = true;
            this.ans1.Text = "radioButton1";
            this.ans1.UseVisualStyleBackColor = true;
            // 
            // ans2
            // 
            this.ans2.AutoSize = true;
            this.ans2.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold);
            this.ans2.Location = new System.Drawing.Point(191, 229);
            this.ans2.Name = "ans2";
            this.ans2.Size = new System.Drawing.Size(161, 54);
            this.ans2.TabIndex = 57;
            this.ans2.TabStop = true;
            this.ans2.Text = "radioButton2";
            this.ans2.UseVisualStyleBackColor = true;
            // 
            // ans3
            // 
            this.ans3.AutoSize = true;
            this.ans3.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold);
            this.ans3.Location = new System.Drawing.Point(191, 287);
            this.ans3.Name = "ans3";
            this.ans3.Size = new System.Drawing.Size(161, 54);
            this.ans3.TabIndex = 58;
            this.ans3.TabStop = true;
            this.ans3.Text = "radioButton3";
            this.ans3.UseVisualStyleBackColor = true;
            // 
            // ans4
            // 
            this.ans4.AutoSize = true;
            this.ans4.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold);
            this.ans4.Location = new System.Drawing.Point(191, 345);
            this.ans4.Name = "ans4";
            this.ans4.Size = new System.Drawing.Size(163, 54);
            this.ans4.TabIndex = 59;
            this.ans4.TabStop = true;
            this.ans4.Text = "radioButton4";
            this.ans4.UseVisualStyleBackColor = true;
            // 
            // quest_body
            // 
            this.quest_body.BackColor = System.Drawing.SystemColors.Control;
            this.quest_body.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold);
            this.quest_body.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(43)))), ((int)(((byte)(100)))));
            this.quest_body.Location = new System.Drawing.Point(76, 72);
            this.quest_body.Multiline = true;
            this.quest_body.Name = "quest_body";
            this.quest_body.ReadOnly = true;
            this.quest_body.Size = new System.Drawing.Size(635, 93);
            this.quest_body.TabIndex = 60;
            // 
            // TheExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 431);
            this.Controls.Add(this.quest_body);
            this.Controls.Add(this.ans4);
            this.Controls.Add(this.ans3);
            this.Controls.Add(this.ans2);
            this.Controls.Add(this.ans1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.next);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TheExam";
            this.Text = "TheExam";
            this.Load += new System.EventHandler(this.TheExam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button13;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submit;
        public System.Windows.Forms.Button next;
        public System.Windows.Forms.Button back;
        public System.Windows.Forms.RadioButton ans1;
        public System.Windows.Forms.RadioButton ans2;
        public System.Windows.Forms.RadioButton ans3;
        public System.Windows.Forms.RadioButton ans4;
        public System.Windows.Forms.TextBox quest_body;
    }
}