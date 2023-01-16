namespace SecondCode
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
            this.CbSort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGetData = new System.Windows.Forms.Button();
            this.DataGv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGv)).BeginInit();
            this.SuspendLayout();
            // 
            // CbSort
            // 
            this.CbSort.DisplayMember = "--select--";
            this.CbSort.FormattingEnabled = true;
            this.CbSort.Items.AddRange(new object[] {
            "Credit Limit : Low to High",
            "Credit Limit : High to Low",
            "Customer Name : A-Z",
            "Customer Name : Z-A"});
            this.CbSort.Location = new System.Drawing.Point(262, 121);
            this.CbSort.Name = "CbSort";
            this.CbSort.Size = new System.Drawing.Size(171, 28);
            this.CbSort.TabIndex = 0;
            this.CbSort.Text = "--Select--";
            this.CbSort.SelectedIndexChanged += new System.EventHandler(this.CbSort_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sort By";
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(262, 62);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(121, 26);
            this.TxtCity.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer City";
            // 
            // BtnGetData
            // 
            this.BtnGetData.Location = new System.Drawing.Point(451, 57);
            this.BtnGetData.Name = "BtnGetData";
            this.BtnGetData.Size = new System.Drawing.Size(117, 37);
            this.BtnGetData.TabIndex = 3;
            this.BtnGetData.Text = "Get Data";
            this.BtnGetData.UseVisualStyleBackColor = true;
            this.BtnGetData.Click += new System.EventHandler(this.BtnGetData_Click);
            // 
            // DataGv
            // 
            this.DataGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGv.Location = new System.Drawing.Point(105, 203);
            this.DataGv.Name = "DataGv";
            this.DataGv.RowHeadersWidth = 62;
            this.DataGv.RowTemplate.Height = 28;
            this.DataGv.Size = new System.Drawing.Size(616, 225);
            this.DataGv.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGv);
            this.Controls.Add(this.BtnGetData);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbSort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGetData;
        private System.Windows.Forms.DataGridView DataGv;
    }
}

