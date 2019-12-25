using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyNotepad
{
    public partial class ReplaceForm : Form
    {
        public RichTextBox Editor { get; set; }
        public bool IsMatchCase { set; get; }
        public bool IsCircle { set; get; }

        public ReplaceForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 选中查询到的部分
        /// </summary>
        /// <returns>是否查询到</returns>
        public bool FindDown()
        {
            if (Editor.SelectionLength != 0)
            {
                Editor.SelectionStart += Editor.SelectionLength;
                Editor.SelectionLength = 0;
            }
            if (!(Editor.SelectionStart != Editor.TextLength && Editor.Find(replaceContent.Text, Editor.SelectionStart, Editor.TextLength, (IsMatchCase ? RichTextBoxFinds.MatchCase : 0)) >= 0))
            {
                if (IsCircle && Editor.Find(replaceContent.Text, 0, Editor.SelectionStart, (IsMatchCase ? RichTextBoxFinds.MatchCase : 0)) >= 0)
                    return true;
                return false;
            }
            return true;
        }

        /// <summary>
        /// 查询，有提示
        /// </summary>
        /// <returns>是否查询到</returns>
        public void FindWithTips()
        {
            if (!FindDown())
                MessageBox.Show("找不到\"" + replaceContent.Text + "\"", "记事本", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 将选中内容替换
        /// </summary>
        public void Replace()
        {
            var start = Editor.SelectionStart;
            Editor.Text = Editor.Text.Remove(Editor.SelectionStart, Editor.SelectionLength).Insert(Editor.SelectionStart, replaceToContent.Text);
            Editor.SelectionStart = start + replaceToContent.Text.Length;
        }

        private void ReplaceForm_Load(object sender, EventArgs e)
        {
            IsMatchCase = matchCaseCheckBox.Checked;
            IsCircle = circleCheckBox.Checked;
        }

        private void ReplaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void MatchCaseCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            IsMatchCase = matchCaseCheckBox.Checked;
        }

        private void CircleCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            IsCircle = circleCheckBox.Checked;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            FindWithTips();
        }

        private void ReplaceBtn_Click(object sender, EventArgs e)
        {
            if (Editor.SelectionLength == 0 || !Editor.SelectedText.Equals(replaceContent.Text, IsMatchCase ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase))
            {
                FindWithTips();
                return;
            }
            Replace();
            FindWithTips();
        }

        private void ReplaceAllBtn_Click(object sender, EventArgs e)
        {
            if (IsCircle)
                Editor.Text = Regex.Replace(Editor.Text, replaceContent.Text, replaceToContent.Text, IsMatchCase ? RegexOptions.None : RegexOptions.IgnoreCase);
            else
            {
                var cutBefore = Editor.Text.Substring(0, Editor.SelectionStart);
                var cutAfter = Editor.SelectionStart == Editor.TextLength ? string.Empty : Editor.Text.Substring(Editor.SelectionStart);
                cutAfter = cutAfter == string.Empty ? cutAfter : Regex.Replace(cutAfter, replaceContent.Text, replaceToContent.Text, IsMatchCase ? RegexOptions.None : RegexOptions.IgnoreCase);
                Editor.Text = cutBefore + cutAfter;
            }
            Editor.SelectionStart = Editor.TextLength;
        }
    }

}
