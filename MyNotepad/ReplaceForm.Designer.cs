namespace MyNotepad
{
    partial class ReplaceForm
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
            this.circleCheckBox = new System.Windows.Forms.CheckBox();
            this.matchCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.replaceContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.replaceBtn = new System.Windows.Forms.Button();
            this.replaceAllBtn = new System.Windows.Forms.Button();
            this.replaceToContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // circleCheckBox
            // 
            this.circleCheckBox.AutoSize = true;
            this.circleCheckBox.Location = new System.Drawing.Point(9, 158);
            this.circleCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.circleCheckBox.Name = "circleCheckBox";
            this.circleCheckBox.Size = new System.Drawing.Size(48, 16);
            this.circleCheckBox.TabIndex = 11;
            this.circleCheckBox.Text = "循环";
            this.circleCheckBox.UseVisualStyleBackColor = true;
            this.circleCheckBox.CheckedChanged += new System.EventHandler(this.CircleCheckBox_CheckedChanged);
            // 
            // matchCaseCheckBox
            // 
            this.matchCaseCheckBox.AutoSize = true;
            this.matchCaseCheckBox.Location = new System.Drawing.Point(9, 130);
            this.matchCaseCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.matchCaseCheckBox.Name = "matchCaseCheckBox";
            this.matchCaseCheckBox.Size = new System.Drawing.Size(84, 16);
            this.matchCaseCheckBox.TabIndex = 10;
            this.matchCaseCheckBox.Text = "区分大小写";
            this.matchCaseCheckBox.UseVisualStyleBackColor = true;
            this.matchCaseCheckBox.CheckedChanged += new System.EventHandler(this.MatchCaseCheckBox_CheckedChanged);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(281, 109);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(86, 29);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(281, 8);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(2);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(86, 29);
            this.nextBtn.TabIndex = 8;
            this.nextBtn.Text = "查找下一个";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // replaceContent
            // 
            this.replaceContent.Font = new System.Drawing.Font("宋体", 10F);
            this.replaceContent.Location = new System.Drawing.Point(76, 13);
            this.replaceContent.Margin = new System.Windows.Forms.Padding(2);
            this.replaceContent.Name = "replaceContent";
            this.replaceContent.Size = new System.Drawing.Size(193, 23);
            this.replaceContent.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "替换内容：";
            // 
            // replaceBtn
            // 
            this.replaceBtn.Location = new System.Drawing.Point(281, 42);
            this.replaceBtn.Margin = new System.Windows.Forms.Padding(2);
            this.replaceBtn.Name = "replaceBtn";
            this.replaceBtn.Size = new System.Drawing.Size(86, 29);
            this.replaceBtn.TabIndex = 12;
            this.replaceBtn.Text = "替换";
            this.replaceBtn.UseVisualStyleBackColor = true;
            this.replaceBtn.Click += new System.EventHandler(this.ReplaceBtn_Click);
            // 
            // replaceAllBtn
            // 
            this.replaceAllBtn.Location = new System.Drawing.Point(281, 75);
            this.replaceAllBtn.Margin = new System.Windows.Forms.Padding(2);
            this.replaceAllBtn.Name = "replaceAllBtn";
            this.replaceAllBtn.Size = new System.Drawing.Size(86, 29);
            this.replaceAllBtn.TabIndex = 13;
            this.replaceAllBtn.Text = "全部替换";
            this.replaceAllBtn.UseVisualStyleBackColor = true;
            this.replaceAllBtn.Click += new System.EventHandler(this.ReplaceAllBtn_Click);
            // 
            // replaceToContent
            // 
            this.replaceToContent.Font = new System.Drawing.Font("宋体", 10F);
            this.replaceToContent.Location = new System.Drawing.Point(76, 46);
            this.replaceToContent.Margin = new System.Windows.Forms.Padding(2);
            this.replaceToContent.Name = "replaceToContent";
            this.replaceToContent.Size = new System.Drawing.Size(193, 23);
            this.replaceToContent.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F);
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "替换为：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "友情提示：替换会导致RTF富文本样式丢失";
            // 
            // ReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 180);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.replaceToContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.replaceAllBtn);
            this.Controls.Add(this.replaceBtn);
            this.Controls.Add(this.circleCheckBox);
            this.Controls.Add(this.matchCaseCheckBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.replaceContent);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReplaceForm";
            this.Text = "ReplaceForm";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReplaceForm_FormClosing);
            this.Load += new System.EventHandler(this.ReplaceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox circleCheckBox;
        private System.Windows.Forms.CheckBox matchCaseCheckBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.TextBox replaceContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button replaceBtn;
        private System.Windows.Forms.Button replaceAllBtn;
        private System.Windows.Forms.TextBox replaceToContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
