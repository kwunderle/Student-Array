
namespace ArrayOfStudents___Katharine_Wunderle
{
    partial class studentNameArray
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentNameArray));
            this.studentNameTxtBx = new System.Windows.Forms.TextBox();
            this.infoLbl = new System.Windows.Forms.Label();
            this.studentNameLbl = new System.Windows.Forms.Label();
            this.courseGradeLbl = new System.Windows.Forms.Label();
            this.courseGradeTxtBx = new System.Windows.Forms.TextBox();
            this.addStudentToArrayBtn = new System.Windows.Forms.Button();
            this.displayArrayBtn = new System.Windows.Forms.Button();
            this.clrBtn = new System.Windows.Forms.Button();
            this.studentArrayLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentNameTxtBx
            // 
            this.studentNameTxtBx.Location = new System.Drawing.Point(48, 148);
            this.studentNameTxtBx.Name = "studentNameTxtBx";
            this.studentNameTxtBx.Size = new System.Drawing.Size(149, 20);
            this.studentNameTxtBx.TabIndex = 0;
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoLbl.Location = new System.Drawing.Point(12, 12);
            this.infoLbl.Margin = new System.Windows.Forms.Padding(3);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.infoLbl.Size = new System.Drawing.Size(473, 90);
            this.infoLbl.TabIndex = 1;
            this.infoLbl.Text = resources.GetString("infoLbl.Text");
            // 
            // studentNameLbl
            // 
            this.studentNameLbl.AutoSize = true;
            this.studentNameLbl.Location = new System.Drawing.Point(45, 123);
            this.studentNameLbl.Name = "studentNameLbl";
            this.studentNameLbl.Size = new System.Drawing.Size(75, 13);
            this.studentNameLbl.TabIndex = 2;
            this.studentNameLbl.Text = "Student Name";
            // 
            // courseGradeLbl
            // 
            this.courseGradeLbl.AutoSize = true;
            this.courseGradeLbl.Location = new System.Drawing.Point(235, 123);
            this.courseGradeLbl.Name = "courseGradeLbl";
            this.courseGradeLbl.Size = new System.Drawing.Size(210, 13);
            this.courseGradeLbl.TabIndex = 3;
            this.courseGradeLbl.Text = "Course Grade as a Number (e.g. 99 is 99%)";
            // 
            // courseGradeTxtBx
            // 
            this.courseGradeTxtBx.Location = new System.Drawing.Point(238, 148);
            this.courseGradeTxtBx.Name = "courseGradeTxtBx";
            this.courseGradeTxtBx.Size = new System.Drawing.Size(207, 20);
            this.courseGradeTxtBx.TabIndex = 4;
            // 
            // addStudentToArrayBtn
            // 
            this.addStudentToArrayBtn.AutoSize = true;
            this.addStudentToArrayBtn.Location = new System.Drawing.Point(160, 185);
            this.addStudentToArrayBtn.Name = "addStudentToArrayBtn";
            this.addStudentToArrayBtn.Size = new System.Drawing.Size(155, 23);
            this.addStudentToArrayBtn.TabIndex = 5;
            this.addStudentToArrayBtn.Text = "Add Student to Grading Array";
            this.addStudentToArrayBtn.UseVisualStyleBackColor = true;
            this.addStudentToArrayBtn.Click += new System.EventHandler(this.addStudentToArrayBtn_Click);
            // 
            // displayArrayBtn
            // 
            this.displayArrayBtn.AutoSize = true;
            this.displayArrayBtn.Location = new System.Drawing.Point(30, 245);
            this.displayArrayBtn.Name = "displayArrayBtn";
            this.displayArrayBtn.Size = new System.Drawing.Size(435, 23);
            this.displayArrayBtn.TabIndex = 7;
            this.displayArrayBtn.Text = "Display Array - Display Each Student\'s Info from the Stored Array AND Calculate A" +
    "verage";
            this.displayArrayBtn.UseVisualStyleBackColor = true;
            this.displayArrayBtn.Click += new System.EventHandler(this.displayArrayBtn_Click);
            // 
            // clrBtn
            // 
            this.clrBtn.AutoSize = true;
            this.clrBtn.Location = new System.Drawing.Point(68, 403);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(351, 23);
            this.clrBtn.TabIndex = 8;
            this.clrBtn.Text = "Clear Text Box and Clear Array and Reset Student Counter/Array Index";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // studentArrayLbl
            // 
            this.studentArrayLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.studentArrayLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentArrayLbl.Location = new System.Drawing.Point(45, 280);
            this.studentArrayLbl.Name = "studentArrayLbl";
            this.studentArrayLbl.Size = new System.Drawing.Size(400, 107);
            this.studentArrayLbl.TabIndex = 9;
            // 
            // studentNameArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(496, 438);
            this.Controls.Add(this.studentArrayLbl);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.displayArrayBtn);
            this.Controls.Add(this.addStudentToArrayBtn);
            this.Controls.Add(this.courseGradeTxtBx);
            this.Controls.Add(this.courseGradeLbl);
            this.Controls.Add(this.studentNameLbl);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.studentNameTxtBx);
            this.Name = "studentNameArray";
            this.Text = "Student Name Arrays";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentNameTxtBx;
        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.Label studentNameLbl;
        private System.Windows.Forms.Label courseGradeLbl;
        private System.Windows.Forms.TextBox courseGradeTxtBx;
        private System.Windows.Forms.Button addStudentToArrayBtn;
        private System.Windows.Forms.Button displayArrayBtn;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.Label studentArrayLbl;
    }
}

