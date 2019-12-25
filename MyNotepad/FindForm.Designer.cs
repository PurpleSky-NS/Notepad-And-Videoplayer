namespace MyNotepad
{
    partial class FindForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.findContent = new System.Windows.Forms.TextBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.matchCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.circleCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.downFind = new System.Windows.Forms.RadioButton();
            this.upFind = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "查找内容：";
            // 
            // findContent
            // 
            this.findContent.Font = new System.Drawing.Font("宋体", 10F);
            this.findContent.Location = new System.Drawing.Point(101, 12);
            this.findContent.Name = "findContent";
            this.findContent.Size = new System.Drawing.Size(238, 27);
            this.findContent.TabIndex = 1;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(375, 12);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(114, 36);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.Text = "查找下一个";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(375, 68);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(114, 36);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // matchCaseCheckBox
            // 
            this.matchCaseCheckBox.AutoSize = true;
            this.matchCaseCheckBox.Location = new System.Drawing.Point(12, 105);
            this.matchCaseCheckBox.Name = "matchCaseCheckBox";
            this.matchCaseCheckBox.Size = new System.Drawing.Size(104, 19);
            this.matchCaseCheckBox.TabIndex = 4;
            this.matchCaseCheckBox.Text = "区分大小写";
            this.matchCaseCheckBox.UseVisualStyleBackColor = true;
            this.matchCaseCheckBox.CheckedChanged += new System.EventHandler(this.MatchCaseCheckBox_CheckedChanged);
            // 
            // circleCheckBox
            // 
            this.circleCheckBox.AutoSize = true;
            this.circleCheckBox.Location = new System.Drawing.Point(12, 140);
            this.circleCheckBox.Name = "circleCheckBox";
            this.circleCheckBox.Size = new System.Drawing.Size(59, 19);
            this.circleCheckBox.TabIndex = 5;
            this.circleCheckBox.Text = "循环";
            this.circleCheckBox.UseVisualStyleBackColor = true;
            this.circleCheckBox.CheckedChanged += new System.EventHandler(this.CircleCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.downFind);
            this.groupBox1.Controls.Add(this.upFind);
            this.groupBox1.Location = new System.Drawing.Point(216, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 65);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "方向";
            // 
            // downFind
            // 
            this.downFind.AutoSize = true;
            this.downFind.Checked = true;
            this.downFind.Location = new System.Drawing.Point(89, 24);
            this.downFind.Name = "downFind";
            this.downFind.Size = new System.Drawing.Size(58, 19);
            this.downFind.TabIndex = 1;
            this.downFind.TabStop = true;
            this.downFind.Text = "向下";
            this.downFind.UseVisualStyleBackColor = true;
            this.downFind.CheckedChanged += new System.EventHandler(this.DownFind_CheckedChanged);
            // 
            // upFind
            // 
            this.upFind.AutoSize = true;
            this.upFind.Location = new System.Drawing.Point(7, 25);
            this.upFind.Name = "upFind";
            this.upFind.Size = new System.Drawing.Size(58, 19);
            this.upFind.TabIndex = 0;
            this.upFind.Text = "向上";
            this.upFind.UseVisualStyleBackColor = true;
            this.upFind.CheckedChanged += new System.EventHandler(this.UpFind_CheckedChanged);
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 166);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.circleCheckBox);
            this.Controls.Add(this.matchCaseCheckBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.findContent);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindForm";
            this.ShowIcon = false;
            this.Text = "查找";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindForm_FormClosing);
            this.Load += new System.EventHandler(this.FindForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox findContent;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.CheckBox matchCaseCheckBox;
        private System.Windows.Forms.CheckBox circleCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton downFind;
        private System.Windows.Forms.RadioButton upFind;
    }
}
