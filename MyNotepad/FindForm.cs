using System.Windows.Forms;

namespace MyNotepad
{
    public partial class FindForm : Form
    {
        public RichTextBox Editor { get; set; }
        public bool IsMatchCase { set; get; }
        public bool IsCircle { set; get; }
        public bool IsDownFind { set; get; }

        public void FindUp()
        {
            if (!(Editor.SelectionStart != 0 && Editor.Find(findContent.Text, 0, Editor.SelectionStart, (IsMatchCase ? RichTextBoxFinds.MatchCase : 0) | RichTextBoxFinds.Reverse) >= 0))
            {
                if (IsCircle && Editor.Find(findContent.Text, Editor.SelectionStart + Editor.SelectionLength, Editor.SelectionLength, (IsMatchCase ? RichTextBoxFinds.MatchCase : 0) | RichTextBoxFinds.Reverse) >= 0)
                    return;
                MessageBox.Show("找不到\"" + findContent.Text + "\"", "记事本", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void FindDown()
        {
            if (Editor.SelectionLength != 0)
            {
                Editor.SelectionStart += Editor.SelectionLength;
                Editor.SelectionLength = 0;
            }
            if (!(Editor.SelectionStart != Editor.TextLength && Editor.Find(findContent.Text, Editor.SelectionStart, Editor.TextLength, (IsMatchCase ? RichTextBoxFinds.MatchCase : 0)) >= 0))
            {
                if (IsCircle && Editor.Find(findContent.Text, 0, Editor.SelectionStart, (IsMatchCase ? RichTextBoxFinds.MatchCase : 0)) >= 0)
                    return;
                MessageBox.Show("找不到\"" + findContent.Text + "\"", "记事本", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public FindForm()
        {
            InitializeComponent();
        }

        private void FindForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void CancelBtn_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void MatchCaseCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            IsMatchCase = matchCaseCheckBox.Checked;
        }

        private void CircleCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            IsCircle = circleCheckBox.Checked;
        }

        private void DownFind_CheckedChanged(object sender, System.EventArgs e)
        {
            IsDownFind = downFind.Checked;
        }

        private void UpFind_CheckedChanged(object sender, System.EventArgs e)
        {
            IsDownFind = !upFind.Checked;
        }

        private void NextBtn_Click(object sender, System.EventArgs e)
        {
            if (IsDownFind)
                FindDown();
            else
                FindUp();
        }

        private void FindForm_Load(object sender, System.EventArgs e)
        {
            IsDownFind = downFind.Checked;
            IsMatchCase = matchCaseCheckBox.Checked;
            IsCircle = circleCheckBox.Checked;
        }
    }
}
