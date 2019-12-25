using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace MyNotepad
{
    public partial class NotepadForm : Form
    {
        private FileInfo file;
        public FileInfo File
        {
            private set
            {
                file = value;
                Text = FileName + " - 记事本";
            }
            get
            {
                return file;
            }
        }
        public string FileName
        {
            get
            {
                return file == null ? "未命名" : file.Name;
            }
        }
        public string FilePath
        {
            get
            {
                return file == null ? string.Empty : file.FullName;
            }
        }
        public bool IsNewFile
        {
            get
            {
                return file == null;
            }
        }

        private bool isTextTypeRich;
        public bool IsTextTypeRich
        {
            get => isTextTypeRich;
            private set
            {
                isTextTypeRich = value;
                if (value)
                    textTypeText.Text = "带格式文本-Rtf";
                else
                    textTypeText.Text = "纯文本-Txt(ANSI)";
            }
        }


        private bool isTextChanged;
        public bool IsTextChanged
        {
            private set
            {
                if (isTextChanged == value)
                    return;
                isTextChanged = value;
                if (value)
                    Text = "*" + FileName + " - 记事本";
                else
                    Text = FileName + " - 记事本";
            }
            get
            {
                return isTextChanged;
            }
        }
        private bool isLoadNewFile = false;

        private FindForm find;
        private ReplaceForm replace;
        private MovieControl movie;

        public NotepadForm()
        {
            InitializeComponent();
            find = new FindForm();
            replace = new ReplaceForm();
            movie = new MovieControl();
        }

        /// <summary>
        /// 保存至
        /// </summary>
        /// <param name="path">路径</param>
        public void SaveTo(string path)
        {
            if (path.EndsWith("txt"))
                editorPad.SaveFile(path, RichTextBoxStreamType.PlainText);
            else if (path.EndsWith("rtf"))
                editorPad.SaveFile(path, RichTextBoxStreamType.RichText);
            else
                return;
            File = new FileInfo(path);
            saveDialog.FileName = FileName;
            IsTextChanged = false;
        }

        /// <summary>
        /// 获取用户选择的文件存储路径
        /// </summary>
        /// <returns>返回一个路径或者null</returns>
        public string GetSavingFilePath()
        {
            if (IsTextTypeRich) //判断默认存储文件类型
                saveDialog.FilterIndex = 2;
            else
                saveDialog.FilterIndex = 1;
            if (saveDialog.ShowDialog() == DialogResult.OK)
                return saveDialog.FileName;
            return null;
        }

        /// <summary>
        /// 保存到一个新文件中
        /// </summary>
        /// <returns>返回操作是否成功（用户没有取消）</returns>
        public bool SaveToNewFile()
        {
            string path = GetSavingFilePath();
            if (!string.IsNullOrEmpty(path))
            {
                SaveTo(path);
                return true;
            }
            return false;
        }

        /// <summary>
        /// 弹出对话框提示保存为一个新文件
        /// </summary>
        /// <returns>返回操作是否成功（用户没有取消）</returns>
        public bool ConfirmSaveNew()
        {
            var res = MessageBox.Show("你想将更改保存到一个新文件中吗?", "记事本", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch (res)
            {
                case DialogResult.Cancel:
                    return false;
                case DialogResult.Yes:
                    return SaveToNewFile();
                case DialogResult.No:
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 保存当前文件
        /// </summary>
        /// <returns>返回操作是否成功（用户没有取消）</returns>
        public bool Save()
        {
            if (IsNewFile)
                return SaveToNewFile();
            if (FileName.EndsWith("txt") && IsTextTypeRich)
            {
                var res = MessageBox.Show("当前文件是一个纯文本文件，但是你更改了字体样式，如果继续将保存为纯文本文件会导致格式丢失\n是否将之保存为一个带格式的富文本文件?", "记事本", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (res)
                {
                    case DialogResult.Yes:
                        return SaveToNewFile();
                    case DialogResult.Cancel:
                        return false;
                }
            }
            SaveTo(FilePath);
            return true;
        }

        /// <summary>
        /// 确认是否保存至当前文件，如果有富文本改变并且当前文件是个文本文件，会提示保存至富文本文件
        /// </summary>
        /// <returns>返回操作是否成功（用户没有取消）</returns>
        public bool ConfirmSave()
        {
            var res = MessageBox.Show("你想将更改保存到 " + FileName + " 吗?", "记事本", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch (res)
            {
                case DialogResult.Cancel:
                    return false;
                case DialogResult.Yes:
                    return Save();
            }
            return true;
        }

        /// <summary>
        /// 检查用户是否编辑未保存，并提醒
        /// </summary>
        /// <returns>返回操作是否成功（用户没有取消）</returns>
        public bool CheckSaveAndConfirm()
        {
            if (IsTextChanged) //提醒用户保存
            {
                if (IsNewFile)
                    return ConfirmSaveNew();
                else
                    return ConfirmSave();
            }
            return true;
        }

        /// <summary>
        /// 将记事本恢复成新文件
        /// </summary>
        void NewFile()
        {
            editorPad.Text = null;
            editorPad.Font = new System.Drawing.Font("宋体", 16);
            File = null;
            IsTextChanged = false;
            IsTextTypeRich = false;
            if (movie.IsLoaded)
                movie.Stop();
        }

        /// <summary>
        /// 打开一个文件，必须是txt或者rtf的
        /// </summary>
        /// <param name="path">文件路径</param>
        public bool LoadFrom(string path)
        {
            if (path.EndsWith("txt"))
                editorPad.LoadFile(path, RichTextBoxStreamType.PlainText);
            else if (path.EndsWith("rtf"))
                editorPad.LoadFile(path, RichTextBoxStreamType.RichText);
            else
                return false;
            File = new FileInfo(path);
            IsTextChanged = false;
            IsTextTypeRich = path.EndsWith("rtf");
            openTxtDialog.FileName = string.Empty;
            editorPad.Select(editorPad.Text.Length, 0);
            isLoadNewFile = true;
            return true;
        }

        /// <summary>
        /// 用对话框获取打开的文件
        /// </summary>
        /// <returns>返回一个路径或者null</returns>
        public string GetLoadingFilePath()
        {
            if (openTxtDialog.ShowDialog() == DialogResult.OK)
                return openTxtDialog.FileName;
            return null;
        }

        /// <summary>
        /// 用对话框打开一个文件
        /// </summary>
        /// <returns>返回操作是否成功（用户没有取消）</returns>
        public bool OpenFile()
        {
            string path = GetLoadingFilePath();
            if (!string.IsNullOrEmpty(path))
            {
                LoadFrom(path);
                return true;
            }
            return false;
        }

        private void EditorPad_TextChanged(object sender, System.EventArgs e)
        {
            if (isLoadNewFile)
            {
                isLoadNewFile = false;
                return;
            }
            if (editorPad.TextLength == 0 && IsNewFile)
                IsTextChanged = false;
            else
                IsTextChanged = true;
        }

        private void NotepadForm_Load(object sender, System.EventArgs e)
        {
            NewFile();
            CheckForIllegalCrossThreadCalls = false;
            find.Editor = editorPad;
            replace.Editor = editorPad;
            editorPad.SelectionFont = editorPad.Font;
            editorPad.LanguageOption = RichTextBoxLanguageOptions.UIFonts;
            movie.Editor = editorPad;
            movie.FPS = 10;
            movie.MaxWidth = 600; //最大宽度
            movie.MaxHeight = 280;//最大高度
            movie.PreBufferSeconds = 10;//预缓冲秒数
            movie.PreLoadSeconds = 5;//预加载秒数
        }

        private void 新建ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!CheckSaveAndConfirm()) //用户取消操作
                return;
            NewFile();
        }

        private void 新窗口ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var thread = new Thread(() =>
            {
                var window = new NotepadForm();
                window.Show();
                Application.Run(window);
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void 打开ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!CheckSaveAndConfirm()) //用户取消操作
                return;
            OpenFile();
        }

        private void 保存ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Save();
        }

        private void 另存为ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            SaveToNewFile();
        }

        private void 退出ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!CheckSaveAndConfirm()) //用户取消操作
                return;
            Application.Exit();
        }

        private void 自动换行ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            自动换行ToolStripMenuItem.Checked = !自动换行ToolStripMenuItem.Checked;
            editorPad.WordWrap = 自动换行ToolStripMenuItem.Checked;
        }

        private void 字体ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                editorPad.SelectionFont = fontDialog.Font;
                IsTextTypeRich = true;
            }
        }

        private void 颜色ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                editorPad.SelectionColor = colorDialog.Color;
                IsTextTypeRich = true;
            }
        }

        private void EditorPad_SelectionChanged(object sender, System.EventArgs e)
        {
            positionText.Text = string.Format("第 {0} 行, 第 {1} 列", editorPad.GetLineFromCharIndex(editorPad.GetFirstCharIndexOfCurrentLine()) + 1, editorPad.SelectionStart - editorPad.GetFirstCharIndexOfCurrentLine() + 1);
        }

        private void 状态栏ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            状态栏ToolStripMenuItem.Checked = !状态栏ToolStripMenuItem.Checked;
            statusStrip.Visible = 状态栏ToolStripMenuItem.Checked;
        }

        private void 撤销ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            editorPad.Undo();
        }

        private void 剪切ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            editorPad.Cut();
        }

        private void 复制ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            editorPad.Copy();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            editorPad.Paste();
            IsTextTypeRich = true;
        }

        private void 删除ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (editorPad.SelectionLength > 0)
            {
                var start = editorPad.SelectionStart;
                editorPad.Text = editorPad.Text.Remove(editorPad.SelectionStart, editorPad.SelectionLength);
                editorPad.SelectionStart = start;
            }
        }

        private void 编辑ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            撤销ToolStripMenuItem.Enabled = editorPad.CanUndo;
            剪切ToolStripMenuItem.Enabled = editorPad.SelectionLength != 0;
            复制ToolStripMenuItem.Enabled = editorPad.SelectionLength != 0;
            粘贴ToolStripMenuItem.Enabled = Clipboard.ContainsImage() || Clipboard.ContainsText();
            删除ToolStripMenuItem.Enabled = editorPad.SelectionLength != 0;
            查找ToolStripMenuItem.Enabled = editorPad.TextLength != 0;
            查找上一个ToolStripMenuItem.Enabled = editorPad.TextLength != 0;
            查找下一个ToolStripMenuItem.Enabled = editorPad.TextLength != 0;
            替换ToolStripMenuItem.Enabled = editorPad.TextLength != 0;
        }

        private void 全选ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            editorPad.SelectAll();
        }

        private void 时间日期ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            删除ToolStripMenuItem_Click(sender, e);
            var timeStr = DateTime.Now.ToString();
            var afterInsertStart = editorPad.SelectionStart + timeStr.Length;
            editorPad.Text = editorPad.Text.Insert(editorPad.SelectionStart, timeStr);
            editorPad.SelectionStart = afterInsertStart;
        }


        private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            replace.Hide();
            find.Show();
        }

        private void 查找下一个ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            find.FindDown();
        }

        private void 查找上一个ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            find.FindUp();
        }

        private void 替换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            find.Hide();
            replace.Show();
        }

        private void 关于记事本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void NotepadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !CheckSaveAndConfirm();
            if (!e.Cancel && movie.IsLoaded)
                movie.Stop();
        }

        private void 视频ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            开始继续ToolStripMenuItem.Enabled = movie.IsLoaded;
            暂停ToolStripMenuItem.Enabled = movie.IsLoaded;
            停止ToolStripMenuItem.Enabled = movie.IsLoaded;
        }

        private void 打开ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!movie.IsInit)
            {
                MessageBox.Show("视频组件还未初始化完成", "记事本播放器", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (openMovieDialog.ShowDialog() != DialogResult.OK)
                return;
            if (!CheckSaveAndConfirm())
                return;
            NewFile();
            if (!movie.LoadFrom(openMovieDialog.FileName))
            {
                MessageBox.Show("无法识别该文件", "记事本播放器", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void 开始继续ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movie.Play();
        }

        private void 暂停ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movie.Pause();
        }

        private void 停止ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movie.Stop();
        }
    }
}
