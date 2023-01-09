namespace ExamWeek6
{
    partial class Form1
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
            this.TxtEmpNo = new System.Windows.Forms.TextBox();
            this.TxtEmpName = new System.Windows.Forms.TextBox();
            this.TxtSalary = new System.Windows.Forms.TextBox();
            this.LblEmpNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAddNew = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdConsultant = new System.Windows.Forms.RadioButton();
            this.RdPayRoll = new System.Windows.Forms.RadioButton();
            this.LblMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtEmpNo
            // 
            this.TxtEmpNo.Location = new System.Drawing.Point(246, 83);
            this.TxtEmpNo.Name = "TxtEmpNo";
            this.TxtEmpNo.Size = new System.Drawing.Size(218, 26);
            this.TxtEmpNo.TabIndex = 1;
            // 
            // TxtEmpName
            // 
            this.TxtEmpName.Location = new System.Drawing.Point(246, 137);
            this.TxtEmpName.Name = "TxtEmpName";
            this.TxtEmpName.Size = new System.Drawing.Size(218, 26);
            this.TxtEmpName.TabIndex = 2;
            // 
            // TxtSalary
            // 
            this.TxtSalary.Location = new System.Drawing.Point(246, 199);
            this.TxtSalary.Name = "TxtSalary";
            this.TxtSalary.Size = new System.Drawing.Size(218, 26);
            this.TxtSalary.TabIndex = 3;
            // 
            // LblEmpNo
            // 
            this.LblEmpNo.AutoSize = true;
            this.LblEmpNo.Location = new System.Drawing.Point(107, 89);
            this.LblEmpNo.Name = "LblEmpNo";
            this.LblEmpNo.Size = new System.Drawing.Size(103, 20);
            this.LblEmpNo.TabIndex = 1;
            this.LblEmpNo.Text = "Employee No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Salary";
            // 
            // BtnAddNew
            // 
            this.BtnAddNew.Location = new System.Drawing.Point(236, 272);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.Size = new System.Drawing.Size(118, 38);
            this.BtnAddNew.TabIndex = 2;
            this.BtnAddNew.Text = "Add New";
            this.BtnAddNew.UseVisualStyleBackColor = true;
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(370, 272);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(94, 38);
            this.BtnReset.TabIndex = 2;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdConsultant);
            this.groupBox1.Controls.Add(this.RdPayRoll);
            this.groupBox1.Location = new System.Drawing.Point(524, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 142);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Type";
            // 
            // RdConsultant
            // 
            this.RdConsultant.AutoSize = true;
            this.RdConsultant.Location = new System.Drawing.Point(31, 86);
            this.RdConsultant.Name = "RdConsultant";
            this.RdConsultant.Size = new System.Drawing.Size(111, 24);
            this.RdConsultant.TabIndex = 0;
            this.RdConsultant.TabStop = true;
            this.RdConsultant.Text = "Consultant";
            this.RdConsultant.UseVisualStyleBackColor = true;
            this.RdConsultant.CheckedChanged += new System.EventHandler(this.RdConsultant_CheckedChanged);
            // 
            // RdPayRoll
            // 
            this.RdPayRoll.AutoSize = true;
            this.RdPayRoll.ForeColor = System.Drawing.Color.Black;
            this.RdPayRoll.Location = new System.Drawing.Point(31, 38);
            this.RdPayRoll.Name = "RdPayRoll";
            this.RdPayRoll.Size = new System.Drawing.Size(87, 24);
            this.RdPayRoll.TabIndex = 0;
            this.RdPayRoll.TabStop = true;
            this.RdPayRoll.Text = "PayRoll";
            this.RdPayRoll.UseVisualStyleBackColor = true;
            this.RdPayRoll.CheckedChanged += new System.EventHandler(this.RdPayRoll_CheckedChanged);
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Location = new System.Drawing.Point(158, 363);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(0, 20);
            this.LblMessage.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblMessage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnAddNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblEmpNo);
            this.Controls.Add(this.TxtSalary);
            this.Controls.Add(this.TxtEmpName);
            this.Controls.Add(this.TxtEmpNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEmpNo;
        private System.Windows.Forms.TextBox TxtEmpName;
        private System.Windows.Forms.TextBox TxtSalary;
        private System.Windows.Forms.Label LblEmpNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAddNew;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdConsultant;
        private System.Windows.Forms.RadioButton RdPayRoll;
        private System.Windows.Forms.Label LblMessage;
    }
}

