using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;


namespace MyNotepad
{
    /// <summary>
    /// ->创造缓存
    ///   ->解码视频
    ///   ->转换图片
    /// ->播放视频
    /// </summary>
    class MovieControl
    {
        private class MessagePrinter
        {
            private static string CRLF = "\r\n";
            private static string WAITING = "...";
            private static string OK = "√ ";

            private string totalMsg;
            private string activeMsg;

            public void SetCurrentMessage(string msg)
            {
                activeMsg = msg;
            }

            public void FinishCurrentMessage()
            {
                if (activeMsg == null)
                    return;
                if (totalMsg != null)
                    totalMsg += CRLF;
                totalMsg += OK + activeMsg;
                activeMsg = null;
            }

            public string GetMessages()
            {
                return (totalMsg != null ? totalMsg + CRLF : string.Empty) + (activeMsg == null ? "" : activeMsg + WAITING);
            }

            public void Clear()
            {
                totalMsg = null;
                activeMsg = null;
            }

        }

        private static string TempDirectoryPath
        {
            get { return "temp"; }
        }
        private static string TempFileDirectory
        {
            get { return TempDirectoryPath + "/"; }
        }

        public bool IsInit { private set; get; }
        public RichTextBox Editor { get; set; }
        /// <summary>
        /// 越大越流畅，但是内存与外存占用大
        /// </summary>
        public byte FPS { set; get; }
        public uint MaxWidth { set; get; }
        public uint MaxHeight { set; get; }
        public bool IsLoaded { private set; get; }
        public bool IsPlaying { private set; get; }
        /// <summary>
        /// 越大缓存越慢，占用空间越大，但是缓存间隔长
        /// </summary>
        public uint PreBufferSeconds { set; get; }
        /// <summary>
        /// 越大内存越卡，但是越流畅
        /// </summary>
        public uint PreLoadSeconds { set; get; }


        private List<string> formats = new List<string>();
        private MessagePrinter messagePrinter = new MessagePrinter();
        private List<Process> activeProcesses = new List<Process>();
        private List<Thread> activeThreads = new List<Thread>();

        private string path;
        private uint width, height;
        private ulong duration;

        private System.Threading.Timer bufferTimer; //缓存
        private System.Threading.Timer loadTimer; //加载
        private System.Threading.Timer playTimer; //播放
        private bool IsBufferFinish
        {
            get { return bufferSecond >= duration; }
        }
        private uint bufferSecond;//预加载到哪了
        private uint bufferDirNum; //预加载临时文件夹编号
        private ulong currentDir;//现在播放哪一个临时文件夹
        private ulong currentFrame;//现在播放哪一帧

        Queue<string> loadBufferQueue = new Queue<string>();

        public MovieControl()
        {
            TextManager.Instance.AddText(255, '一');
            TextManager.Instance.AddText(250, '亠');
            TextManager.Instance.AddText(215, '二');
            TextManager.Instance.AddText(205, '十');
            TextManager.Instance.AddText(190, '艹');
            TextManager.Instance.AddText(175, '丫');
            TextManager.Instance.AddText(165, '上');
            TextManager.Instance.AddText(155, '工');
            TextManager.Instance.AddText(140, '日');
            TextManager.Instance.AddText(125, '目');
            TextManager.Instance.AddText(110, '口');
            TextManager.Instance.AddText(95, '月');
            TextManager.Instance.AddText(80, '田');
            TextManager.Instance.AddText(65, '朋');
            TextManager.Instance.AddText(50, '雨');
            TextManager.Instance.AddText(40, '晶');
            TextManager.Instance.AddText(30, '鑫');
            TextManager.Instance.AddText(20, '雷');
            TextManager.Instance.AddText(10, '飝');
            TextManager.Instance.AddText(0, '龘');
            //获取支持的格式
            var formatRegex = new Regex(@"^\s*[DE]+\s*(\w+).*$");//捕获视频格式
            StartProcess("-formats", (s, e) =>
            {
                if (string.IsNullOrEmpty(e.Data))
                    return;
                var m = formatRegex.Match(e.Data);
                if (m.Success)
                    formats.Add(m.Groups[1].Value);
            }, (s, e) =>
            {
                IsInit = true;
            });
            bufferTimer = new System.Threading.Timer(BufferVideo, null, Timeout.Infinite, Timeout.Infinite);
            loadTimer = new System.Threading.Timer(LoadBuffer, null, Timeout.Infinite, Timeout.Infinite);
            playTimer = new System.Threading.Timer(PlayPeace, null, Timeout.Infinite, Timeout.Infinite);

        }

        /// <summary>
        /// 执行异步加载，会使用到TextBox作为信息输出
        /// </summary>
        /// <param name="path">视频路径</param>
        /// <returns>是否支持该文件</returns>
        public bool LoadFrom(string path)
        {
            //获取后缀名
            var fd = path.LastIndexOf('.');
            if (fd < 0)
                return false;
            if (!formats.Exists(o => o.Equals(path.Substring(fd + 1))))//查看是否是支持的解码格式
                return false;

            if (IsPlaying)
                Stop();
            else
                Clear();
            this.path = path;
            StartThread(() =>
            {
                //清除数据缓存
                messagePrinter.SetCurrentMessage("正在清除数据缓存");
                Editor.Text = messagePrinter.GetMessages();
                RemoveTempDirectory();
                messagePrinter.FinishCurrentMessage();
                //提取视频大小->解码视频为图片->图片=>字符文件->缓存

                messagePrinter.SetCurrentMessage("正在获取视频信息");
                Editor.Text = messagePrinter.GetMessages();
                StartProcess("-i " + path, //获取视频长宽，时长信息
                (s, e) =>
                {
                    if (e.Data == null)
                        return;
                    var m1 = Regex.Match(e.Data, @"^.*\s+(\d+)x(\d+)[\s,]+.*$");
                    var m2 = Regex.Match(e.Data, @"^.*Duration: (\d\d):(\d\d):(\d\d).\d\d.*$");
                    if (m1.Success)
                    {
                        width = uint.Parse(m1.Groups[1].Value);
                        height = uint.Parse(m1.Groups[2].Value);
                    }
                    else if (m2.Success)
                        duration = uint.Parse(m2.Groups[1].Value) * 60 * 60 + uint.Parse(m2.Groups[2].Value) * 60 + uint.Parse(m2.Groups[3].Value);
                },
                (s, e) =>
                {
                    if (width == 0 || height == 0 || duration == 0)
                    {
                        messagePrinter.SetCurrentMessage("读取视频时出错！");
                        Editor.Text = messagePrinter.GetMessages();
                        Shut();
                        return;
                    }
                    /*缩放视频*/
                    string videoSizeMsg = "视频尺寸为 " + width + "x" + height;
                    if (!(width < MaxWidth && height < MaxHeight))//需要缩放
                    {
                        if ((double)width / MaxWidth > (double)height / MaxHeight) //按照等比缩放
                        {
                            height = height * MaxWidth / width;
                            width = MaxWidth;
                        }
                        else
                        {
                            width = width * MaxHeight / height;
                            height = MaxHeight;
                        }
                        videoSizeMsg += " -> " + width + "x" + height;
                    }
                    messagePrinter.SetCurrentMessage(videoSizeMsg);
                    messagePrinter.FinishCurrentMessage();
                    messagePrinter.SetCurrentMessage("视频时长为：" + duration + " 秒");
                    messagePrinter.FinishCurrentMessage();
                    Editor.Text = messagePrinter.GetMessages();
                });
                messagePrinter.SetCurrentMessage("缓冲视频中");
                Editor.Text = messagePrinter.GetMessages();
                BufferVideo(null);
                messagePrinter.SetCurrentMessage("缓冲视频完成");
                messagePrinter.FinishCurrentMessage();

                messagePrinter.SetCurrentMessage("正在加载缓存");
                Editor.Text = messagePrinter.GetMessages();
                LoadBuffer(null);
                messagePrinter.SetCurrentMessage("加载缓存完成，选择播放即可开始播放视频");
                messagePrinter.FinishCurrentMessage();
                Editor.Text = messagePrinter.GetMessages();
                IsLoaded = true;
            });
            return true;
        }

        private void BufferVideo(Object o)
        {
            if (bufferSecond >= duration) //播放完成就不需要缓冲了
            {
                bufferTimer.Change(Timeout.Infinite, Timeout.Infinite); //禁用加载
                return;
            }

            lock (bufferTimer)
            {
                var dir = TempFileDirectory + bufferDirNum;
                Directory.CreateDirectory(dir); //创建缓冲目录
                StartProcess(string.Format("-i {0} -ss {1} -t {2} -r {3} -s {4}x{5} {6}/%d.jpg", path, bufferSecond, PreBufferSeconds, FPS, width, height, dir), null, (s, e) =>
                {
                    //开始转码
                    for (int i = 1; ; ++i)
                    {
                        var imgPath = dir + '/' + i + ".jpg";
                        if (!File.Exists(imgPath))
                            break;
                        StartThread((data) =>
                        {
                            try
                            {
                                var path = (string)data;
                                using (Bitmap img = (Bitmap)Image.FromFile(path)) //获取图片
                                {
                                    StringBuilder sb = new StringBuilder(img.Height * (img.Width + 2)); //创建文字缓冲区
                                    for (int y = 0; y < img.Height; ++y)
                                    {
                                        for (int x = 0; x < img.Width; ++x)
                                        {
                                            Color c = img.GetPixel(x, y); //获取像素
                                            byte gray = (byte)((c.R * 30 + c.G * 59 + c.B * 11) / 100); //计算灰度值
                                            sb.Append(TextManager.Instance.GetText(gray)); //获取灰度值对应的文字
                                        }
                                        sb.Append("\r\n");
                                    }
                                    //写入文件 temp/?/x.txt
                                    using (StreamWriter sw = new StreamWriter(new FileStream(path.Replace(".jpg", ".txt"), FileMode.OpenOrCreate, FileAccess.Write), Encoding.Default))
                                        sw.Write(sb.ToString());
                                }
                                File.Delete(path);
                            }
                            catch (Exception) { }
                        }, imgPath);
                    }

                    ++bufferDirNum;
                    bufferSecond += PreBufferSeconds;

                });
            }
        }

        /// <summary>
        /// 播放单张文字
        /// </summary>
        /// <param name="o">没用，占位</param>
        private void PlayPeace(Object o)
        {
            if (!IsPlaying)
                return;
            lock (playTimer)
            {
                if (!IsPlaying)
                    return;
                try
                {
                    if (loadBufferQueue.Count == 0)
                    {
                        if (IsPlayFinish())
                            Stop();
                        else
                            loadTimer.Change(0, PreLoadSeconds);
                        return;
                    }
                    Editor.Text = loadBufferQueue.Dequeue();
                }
                catch (Exception) { }
            }
        }

        /// <summary>
        /// 会加锁以及调用@LoadBufferBase，可能比较费时
        /// </summary>
        /// <returns>返回是否全部播放完成</returns>
        private bool IsPlayFinish()
        {
            lock (loadTimer)
                return !LoadBufferBase() && IsBufferFinish && loadBufferQueue.Count == 0;
        }

        private void LoadBuffer(Object o)
        {
            lock (loadTimer)
            {
                while (loadBufferQueue.Count < FPS * PreLoadSeconds) //加载内容
                    if (!LoadBufferBase()) //已经加载完了
                    {
                        loadTimer.Change(Timeout.Infinite, Timeout.Infinite); //禁用加载
                        break;
                    }
            }
        }

        /// <summary>
        /// 从文件加载缓存
        /// </summary>
        /// <returns>返回是否还可以继续加载</returns>
        private bool LoadBufferBase()
        {
            var file = TempFileDirectory + currentDir + '/' + currentFrame + ".txt";
            //无该文件则表示当前文件夹全波播放完成
            if (File.Exists(file)) //如果可以播放
            {
                try
                {
                    using (var sr = new StreamReader(new FileStream(file, FileMode.Open, FileAccess.Read), Encoding.Default))
                        loadBufferQueue.Enqueue(sr.ReadToEnd()); //全读
                }
                catch (Exception) { }
                ++currentFrame;
                return true;
            }
            //若当前文件夹全部播放完成
            else if (Directory.Exists(TempFileDirectory + (currentDir + 1)))
            {
                //切换到下一个文件夹播放，删除当前文件夹
                StartThread(cur =>
                {
                    try
                    {
                        Directory.Delete(TempFileDirectory + cur, true);
                    }
                    catch (Exception) { }
                }, currentDir); //开个线程删，不然可能会卡
                ++currentDir;
                currentFrame = 1;
                return LoadBufferBase();
            }
            if (!IsBufferFinish)
            {
                bufferTimer.Change(0, PreBufferSeconds * 1000);
                return true;
            }
            return false;
        }

        public void Play()
        {
            if (!IsLoaded)
                return;
            if (!IsPlaying)
            {
                IsPlaying = true;
                Editor.SelectionFont = Editor.Font = new Font("宋体", 1f, GraphicsUnit.Point);
                bufferTimer.Change(0, PreBufferSeconds * 1000); //立即缓冲一次，设置固定时间缓冲
                loadTimer.Change(0, PreLoadSeconds * 1000);
                playTimer.Change(0, 1000 / FPS); //设置定时器开始播放
            }
        }

        public void Pause()
        {
            if (!IsLoaded)
                return;
            if (IsPlaying)
            {
                IsPlaying = false;
                bufferTimer.Change(Timeout.Infinite, Timeout.Infinite); //禁用缓冲
                loadTimer.Change(Timeout.Infinite, Timeout.Infinite); //关闭加载
                playTimer.Change(Timeout.Infinite, Timeout.Infinite); //取消播放
            }
        }

        public void Stop()
        {
            Shut();
        }
        private void Clear()
        {
            IsLoaded = false;
            messagePrinter.Clear();
            bufferSecond = 0;
            bufferDirNum = 0;
            currentDir = 0;
            currentFrame = 1;
            IsPlaying = false;
            path = null;
            width = height = 0;
            duration = 0;
            loadBufferQueue.Clear();
        }

        private void Shut() //Shut关的更彻底
        {
            bufferTimer.Change(Timeout.Infinite, Timeout.Infinite); //关闭缓冲
            loadTimer.Change(Timeout.Infinite, Timeout.Infinite); //关闭加载
            playTimer.Change(Timeout.Infinite, Timeout.Infinite); //关闭播放
            while (activeThreads.Count != 0)
            {
                lock (activeThreads)
                {
                    try
                    {
                        activeThreads.ForEach(i =>
                        {
                            try
                            {
                                if (i.IsAlive)
                                    i.Abort();
                            }
                            catch (Exception) { }
                        });
                        activeThreads.Clear();
                    }
                    catch (Exception) { }
                }
            }
            while (activeProcesses.Count != 0)
            {
                lock (activeProcesses)
                {
                    try
                    {
                        activeProcesses.ForEach(i =>
                        {
                            try
                            {
                                if (!i.HasExited)
                                    i.Kill();
                            }
                            catch (Exception) { }
                        });
                        activeProcesses.Clear();
                    }
                    catch (Exception) { }
                }
            }
            Clear();
            StartThread(RemoveTempDirectory);
        }

        private void CreateTempDirectory()
        {
            if (!Directory.Exists(TempDirectoryPath))
                Directory.CreateDirectory(TempDirectoryPath);//创建临时目录
        }

        private void RemoveTempDirectory()
        {
            try
            {
                Directory.Delete(TempDirectoryPath, true);
            }
            catch (Exception) { }
        }

        private void StartProcess(string arg, DataReceivedEventHandler OnOutput, EventHandler OnExited)
        {
            using (Process ffmpeg = new Process())
            {
                lock (activeProcesses)
                    activeProcesses.Add(ffmpeg);
                ffmpeg.StartInfo.FileName = "ffmpeg.exe";
                ffmpeg.StartInfo.CreateNoWindow = true;
                ffmpeg.StartInfo.UseShellExecute = false;
                ffmpeg.StartInfo.RedirectStandardError = true;
                ffmpeg.StartInfo.RedirectStandardOutput = true;
                ffmpeg.StartInfo.RedirectStandardInput = true;
                ffmpeg.EnableRaisingEvents = true;
                ffmpeg.StartInfo.Arguments = arg;
                ffmpeg.OutputDataReceived += OnOutput;
                ffmpeg.ErrorDataReceived += OnOutput;
                ffmpeg.Exited += OnExited;
                ffmpeg.Start();
                ffmpeg.StandardInput.Close();
                ffmpeg.BeginOutputReadLine();
                ffmpeg.BeginErrorReadLine();
                ffmpeg.WaitForExit();
                activeProcesses.Remove(ffmpeg);
            }
        }

        private void StartThread(ParameterizedThreadStart threadStart, object data)
        {
            var thread = new Thread((o) =>
            {
                threadStart(o);
                activeThreads.Remove(Thread.CurrentThread);
            });
            lock (activeThreads)
                activeThreads.Add(thread);
            thread.Start(data);
        }

        private void StartThread(ThreadStart threadStart)
        {
            var thread = new Thread(() =>
            {
                threadStart();
                activeThreads.Remove(Thread.CurrentThread);
            });
            lock (activeThreads)
                activeThreads.Add(thread);
            thread.Start();
        }
    }
}
