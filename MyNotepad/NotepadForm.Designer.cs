namespace MyNotepad
{
    partial class NotepadForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotepadForm));
            this.editorPad = new System.Windows.Forms.RichTextBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找下一个ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找上一个ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.替换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.全选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.时间日期ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自动换行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.状态栏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于记事本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视频ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.开始继续ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTxtDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.positionText = new System.Windows.Forms.ToolStripStatusLabel();
            this.textTypeText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openMovieDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // editorPad
            // 
            this.editorPad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editorPad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorPad.EnableAutoDragDrop = true;
            this.editorPad.Font = new System.Drawing.Font("宋体", 16F);
            this.editorPad.HideSelection = false;
            this.editorPad.Location = new System.Drawing.Point(0, 25);
            this.editorPad.Margin = new System.Windows.Forms.Padding(0);
            this.editorPad.Name = "editorPad";
            this.editorPad.Size = new System.Drawing.Size(504, 309);
            this.editorPad.TabIndex = 0;
            this.editorPad.Text = "";
            this.editorPad.SelectionChanged += new System.EventHandler(this.EditorPad_SelectionChanged);
            this.editorPad.TextChanged += new System.EventHandler(this.EditorPad_TextChanged);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.SystemColors.Window;
            this.mainMenuStrip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.格式ToolStripMenuItem,
            this.查看ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.视频ToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mainMenuStrip.Size = new System.Drawing.Size(504, 25);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.文件ToolStripMenuItem.DoubleClickEnabled = true;
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.新窗口ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.另存为ToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 新窗口ToolStripMenuItem
            // 
            this.新窗口ToolStripMenuItem.Name = "新窗口ToolStripMenuItem";
            this.新窗口ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.新窗口ToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.新窗口ToolStripMenuItem.Text = "新窗口";
            this.新窗口ToolStripMenuItem.Click += new System.EventHandler(this.新窗口ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.另存为ToolStripMenuItem.Text = "另存为";
            this.另存为ToolStripMenuItem.Click += new System.EventHandler(this.另存为ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.撤销ToolStripMenuItem,
            this.toolStripSeparator2,
            this.剪切ToolStripMenuItem,
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.toolStripSeparator3,
            this.查找ToolStripMenuItem,
            this.查找下一个ToolStripMenuItem,
            this.查找上一个ToolStripMenuItem,
            this.替换ToolStripMenuItem,
            this.toolStripSeparator5,
            this.全选ToolStripMenuItem,
            this.时间日期ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.编辑ToolStripMenuItem.Text = "编辑";
            this.编辑ToolStripMenuItem.Click += new System.EventHandler(this.编辑ToolStripMenuItem_Click);
            // 
            // 撤销ToolStripMenuItem
            // 
            this.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem";
            this.撤销ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.撤销ToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.撤销ToolStripMenuItem.Text = "撤销";
            this.撤销ToolStripMenuItem.Click += new System.EventHandler(this.撤销ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(188, 6);
            // 
            // 剪切ToolStripMenuItem
            // 
            this.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            this.剪切ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.剪切ToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.剪切ToolStripMenuItem.Text = "剪切";
            this.剪切ToolStripMenuItem.Click += new System.EventHandler(this.剪切ToolStripMenuItem_Click);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.粘贴ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(188, 6);
            // 
            // 查找ToolStripMenuItem
            // 
            this.查找ToolStripMenuItem.Name = "查找ToolStripMenuItem";
            this.查找ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.查找ToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.查找ToolStripMenuItem.Text = "查找";
            this.查找ToolStripMenuItem.Click += new System.EventHandler(this.查找ToolStripMenuItem_Click);
            // 
            // 查找下一个ToolStripMenuItem
            // 
            this.查找下一个ToolStripMenuItem.Name = "查找下一个ToolStripMenuItem";
            this.查找下一个ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.查找下一个ToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.查找下一个ToolStripMenuItem.Text = "查找下一个";
            this.查找下一个ToolStripMenuItem.Click += new System.EventHandler(this.查找下一个ToolStripMenuItem_Click);
            // 
            // 查找上一个ToolStripMenuItem
            // 
            this.查找上一个ToolStripMenuItem.Name = "查找上一个ToolStripMenuItem";
            this.查找上一个ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.查找上一个ToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.查找上一个ToolStripMenuItem.Text = "查找上一个";
            this.查找上一个ToolStripMenuItem.Click += new System.EventHandler(this.查找上一个ToolStripMenuItem_Click);
            // 
            // 替换ToolStripMenuItem
            // 
            this.替换ToolStripMenuItem.Name = "替换ToolStripMenuItem";
            this.替换ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.替换ToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.替换ToolStripMenuItem.Text = "替换";
            this.替换ToolStripMenuItem.Click += new System.EventHandler(this.替换ToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(188, 6);
            // 
            // 全选ToolStripMenuItem
            // 
            this.全选ToolStripMenuItem.Name = "全选ToolStripMenuItem";
            this.全选ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.全选ToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.全选ToolStripMenuItem.Text = "全选";
            this.全选ToolStripMenuItem.Click += new System.EventHandler(this.全选ToolStripMenuItem_Click);
            // 
            // 时间日期ToolStripMenuItem
            // 
            this.时间日期ToolStripMenuItem.Name = "时间日期ToolStripMenuItem";
            this.时间日期ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.时间日期ToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.时间日期ToolStripMenuItem.Text = "时间/日期";
            this.时间日期ToolStripMenuItem.Click += new System.EventHandler(this.时间日期ToolStripMenuItem_Click);
            // 
            // 格式ToolStripMenuItem
            // 
            this.格式ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.格式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自动换行ToolStripMenuItem,
            this.字体ToolStripMenuItem,
            this.颜色ToolStripMenuItem});
            this.格式ToolStripMenuItem.Name = "格式ToolStripMenuItem";
            this.格式ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.格式ToolStripMenuItem.Text = "格式";
            // 
            // 自动换行ToolStripMenuItem
            // 
            this.自动换行ToolStripMenuItem.Checked = true;
            this.自动换行ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.自动换行ToolStripMenuItem.Name = "自动换行ToolStripMenuItem";
            this.自动换行ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.自动换行ToolStripMenuItem.Text = "自动换行";
            this.自动换行ToolStripMenuItem.Click += new System.EventHandler(this.自动换行ToolStripMenuItem_Click);
            // 
            // 字体ToolStripMenuItem
            // 
            this.字体ToolStripMenuItem.Name = "字体ToolStripMenuItem";
            this.字体ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.字体ToolStripMenuItem.Text = "字体";
            this.字体ToolStripMenuItem.Click += new System.EventHandler(this.字体ToolStripMenuItem_Click);
            // 
            // 颜色ToolStripMenuItem
            // 
            this.颜色ToolStripMenuItem.Name = "颜色ToolStripMenuItem";
            this.颜色ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.颜色ToolStripMenuItem.Text = "颜色";
            this.颜色ToolStripMenuItem.Click += new System.EventHandler(this.颜色ToolStripMenuItem_Click);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.查看ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.状态栏ToolStripMenuItem});
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.查看ToolStripMenuItem.Text = "查看";
            // 
            // 状态栏ToolStripMenuItem
            // 
            this.状态栏ToolStripMenuItem.Checked = true;
            this.状态栏ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.状态栏ToolStripMenuItem.Name = "状态栏ToolStripMenuItem";
            this.状态栏ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.状态栏ToolStripMenuItem.Text = "状态栏";
            this.状态栏ToolStripMenuItem.Click += new System.EventHandler(this.状态栏ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于记事本ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于记事本ToolStripMenuItem
            // 
            this.关于记事本ToolStripMenuItem.Name = "关于记事本ToolStripMenuItem";
            this.关于记事本ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.关于记事本ToolStripMenuItem.Text = "关于记事本";
            this.关于记事本ToolStripMenuItem.Click += new System.EventHandler(this.关于记事本ToolStripMenuItem_Click);
            // 
            // 视频ToolStripMenuItem
            // 
            this.视频ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem1,
            this.开始继续ToolStripMenuItem,
            this.暂停ToolStripMenuItem,
            this.停止ToolStripMenuItem});
            this.视频ToolStripMenuItem.Name = "视频ToolStripMenuItem";
            this.视频ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.视频ToolStripMenuItem.Text = "视频";
            this.视频ToolStripMenuItem.Click += new System.EventHandler(this.视频ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem1
            // 
            this.打开ToolStripMenuItem1.Name = "打开ToolStripMenuItem1";
            this.打开ToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.打开ToolStripMenuItem1.Text = "打开";
            this.打开ToolStripMenuItem1.Click += new System.EventHandler(this.打开ToolStripMenuItem1_Click);
            // 
            // 开始继续ToolStripMenuItem
            // 
            this.开始继续ToolStripMenuItem.Name = "开始继续ToolStripMenuItem";
            this.开始继续ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.开始继续ToolStripMenuItem.Text = "开始/继续";
            this.开始继续ToolStripMenuItem.Click += new System.EventHandler(this.开始继续ToolStripMenuItem_Click);
            // 
            // 暂停ToolStripMenuItem
            // 
            this.暂停ToolStripMenuItem.Name = "暂停ToolStripMenuItem";
            this.暂停ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.暂停ToolStripMenuItem.Text = "暂停";
            this.暂停ToolStripMenuItem.Click += new System.EventHandler(this.暂停ToolStripMenuItem_Click);
            // 
            // 停止ToolStripMenuItem
            // 
            this.停止ToolStripMenuItem.Name = "停止ToolStripMenuItem";
            this.停止ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.停止ToolStripMenuItem.Text = "停止";
            this.停止ToolStripMenuItem.Click += new System.EventHandler(this.停止ToolStripMenuItem_Click);
            // 
            // openTxtDialog
            // 
            this.openTxtDialog.Filter = "文本文件|*.txt|富文本文件|*.rtf";
            this.openTxtDialog.Title = "打开文件";
            // 
            // saveDialog
            // 
            this.saveDialog.FileName = "未命名";
            this.saveDialog.Filter = "文本文件|*.txt|富文本文件|*.rtf";
            this.saveDialog.Title = "保存文件";
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.positionText,
            this.textTypeText,
            this.toolStripStatusLabel2});
            this.statusStrip.Location = new System.Drawing.Point(0, 334);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip.Size = new System.Drawing.Size(504, 24);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "状态栏";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(132, 19);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // positionText
            // 
            this.positionText.AutoSize = false;
            this.positionText.Name = "positionText";
            this.positionText.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.positionText.Size = new System.Drawing.Size(200, 19);
            this.positionText.Text = "第 1 行, 第 1 列";
            // 
            // textTypeText
            // 
            this.textTypeText.AutoSize = false;
            this.textTypeText.Name = "textTypeText";
            this.textTypeText.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.textTypeText.Size = new System.Drawing.Size(150, 19);
            this.textTypeText.Text = "纯文本-Txt(ANSI)";
            this.textTypeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(11, 19);
            this.toolStripStatusLabel2.Text = " ";
            // 
            // openMovieDialog
            // 
            this.openMovieDialog.Filter = "所有文件|*.*";
            // 
            // NotepadForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(504, 358);
            this.Controls.Add(this.editorPad);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NotepadForm";
            this.Text = "记事本";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NotepadForm_FormClosing);
            this.Load += new System.EventHandler(this.NotepadForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openTxtDialog;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 格式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自动换行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 状态栏ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel positionText;
        private System.Windows.Forms.ToolStripStatusLabel textTypeText;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem 撤销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 查找ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查找下一个ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查找上一个ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 替换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 全选ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 时间日期ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于记事本ToolStripMenuItem;
        public System.Windows.Forms.RichTextBox editorPad;
        private System.Windows.Forms.ToolStripMenuItem 视频ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 开始继续ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暂停ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openMovieDialog;
    }
}
