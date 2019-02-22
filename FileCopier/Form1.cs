using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCopier
{
    public partial class Form1 : Form
    {
        protected FCConfigPackage configPkg;

        #region state
        // 執行狀態
        private int _fileCounter = 0;
        private int _dirCounter = 0;
        private int _copyFileCounter = 0;
        private int _copyDirCounter = 0;
        // 設定
        private FCConfig _config = null;
        private bool _countOnly = false;
        private bool _showDetail = true;
        #endregion

        #region Logic Biz
        
        protected void LoadConfigPackage(out FCConfigPackage configPkg)
        {
            string json = File.ReadAllText(@"FileCopyConfig.json", Encoding.UTF8);
            configPkg = JsonConvert.DeserializeObject<FCConfigPackage>(json);
        }

        protected void SaveConfigPackage(FCConfigPackage configPkg)
        {
            string json = JsonConvert.SerializeObject(configPkg, Formatting.Indented);
            File.WriteAllText(@"FileCopyConfig.json", json , Encoding.UTF8);
        }

        /// <summary>
        /// 複製檔案並計算數量
        /// </summary>
        protected void ProceedCopyDirectory()
        {
            DateTime beginTime = DateTime.Now;
            LogMessage("## 開始複製目錄…");
            LogMessage("選取組態：{0}", _config.idName);
            LogMessage("來源目錄：{0}", _config.sourceDir);
            LogMessage("目的目錄：{0}", _config.targetDir);

            // 重設執行狀態
            _fileCounter = 0;
            _dirCounter = 0;
            _copyFileCounter = 0;
            _copyDirCounter = 0;

            try
            {
                DirectoryInfo sourceDir = new DirectoryInfo(_config.sourceDir);
                DirectoryInfo targetDir = new DirectoryInfo(_config.targetDir);
                if (!sourceDir.Exists)
                {
                    LogMessage("來源目錄不存在！");
                    return;
                }

                if (!targetDir.Exists)
                {
                    LogMessage("目的目錄不存在！");
                    return;
                }

                if (_config.ignoreList == null)
                {
                    LogMessage("無忽略清單不予執行。");
                    return;
                }
                    
                // GO

                // prefix 先計算數量
                SetupUIMode_Count();

                // 先計算數量
                SubCountSourceDirInfo(sourceDir);
                RefreshStatusOfUI();

                // 只計算數量
                if (_countOnly) return;

                // prefix 再複製檔案
                SetupUIMode_Copy();

                // 再複製檔案
                SubCopyDirectory(sourceDir, targetDir);
                RefreshStatusOfUI();
            }
            catch (Exception ex)
            {
                LogMessage("--------------------------------------------");
                LogMessage("## 出現錯誤！");
                LogMessage(ex.Message);
                LogMessage(ex.StackTrace);
            }
            finally
            {
                LogMessage("## 複製目錄完成。");
                LogMessage("檔案數量：{0}", _fileCounter);
                LogMessage("目錄數量：{0}", _dirCounter);
                LogMessage("複製檔案：{0}", _copyFileCounter);
                LogMessage("複製目錄：{0}", _copyDirCounter);
                LogMessage("執行時間：{0:hh\\:mm\\:ss}", DateTime.Now.Subtract(beginTime));
                LogMessage("============================================");
            }
        }

        protected async void ProceedCopyDirectoryAsync()
        {
            await Task.Run(() => {
                ProceedCopyDirectory();
                ProceedCopyAllowList();
            });
        }

        protected void ProceedCopyAllowList()
        {
            DateTime beginTime = DateTime.Now;
            LogMessage("## 開始複製同意清單…");
            LogMessage("選取組態：{0}", _config.idName);
            LogMessage("來源目錄：{0}", _config.sourceDir);
            LogMessage("目的目錄：{0}", _config.targetDir);

            // 重設執行狀態
            _fileCounter = 0;
            _dirCounter = 0;
            _copyFileCounter = 0;
            _copyDirCounter = 0;

            try
            {
                DirectoryInfo sourceDir = new DirectoryInfo(_config.sourceDir);
                DirectoryInfo targetDir = new DirectoryInfo(_config.targetDir);
                if (!sourceDir.Exists)
                {
                    LogMessage("來源目錄不存在！");
                    return;
                }

                if (!targetDir.Exists)
                {
                    LogMessage("目的目錄不存在！");
                    return;
                }

                if (_config.allowList == null)
                {
                    LogMessage("無同意清單不予執行。");
                    return;
                }

                // GO

                // prefix 先計算數量
                SetupUIMode_Count();

                // 先計算數量
                _fileCounter = _config.allowList.Count;

                RefreshStatusOfUI();

                // 只計算數量
                if (_countOnly) return;

                // prefix 再複製檔案
                SetupUIMode_Copy();

                // 再複製檔案
                DoCopyAllowList(sourceDir, targetDir);

                RefreshStatusOfUI();
            }
            catch (Exception ex)
            {
                LogMessage("--------------------------------------------");
                LogMessage("## 出現錯誤！");
                LogMessage(ex.Message);
                LogMessage(ex.StackTrace);
            }
            finally
            {
                LogMessage("## 複製同意清單完成。");
                LogMessage("檔案數量：{0}", _fileCounter);
                LogMessage("目錄數量：{0}", _dirCounter);
                LogMessage("複製檔案：{0}", _copyFileCounter);
                LogMessage("複製目錄：{0}", _copyDirCounter);
                LogMessage("執行時間：{0:hh\\:mm\\:ss}", DateTime.Now.Subtract(beginTime));
                LogMessage("============================================");
            }
        }

        //protected async void ProceedCopyAllowListAsync()
        //{
        //    await Task.Run(() => ProceedCopyAllowList());
        //}

        /// <summary>
        /// 計算檔案與目錄數量
        /// </summary>
        protected void SubCountSourceDirInfo(DirectoryInfo sourceDir)
        {
            foreach (FileInfo fi in sourceDir.GetFiles())
            {
                // 若在忽略清單，則跳過。
                if (_config.ignoreList.Contains(fi.Name)) continue;

                _fileCounter++;
                if (_showDetail) LogMessage("file {0}", fi.FullName); // trace
                RefreshStatusOfUI();
            }

            foreach (DirectoryInfo di in sourceDir.GetDirectories())
            {
                // 若在忽略清單，則跳過。
                if (_config.ignoreList.Contains(di.Name)) continue;

                _dirCounter++;
                if(_showDetail) LogMessage("dir {0}", di.FullName); // trace
                RefreshStatusOfUI();

                // 遞迴
                SubCountSourceDirInfo(di);
            }
        }

        /// <summary>
        /// 複製檔案與目錄
        /// </summary>
        protected void SubCopyDirectory(DirectoryInfo sourceDir, DirectoryInfo targetDir)
        {
            try
            {
                // 先複製檔案
                foreach (FileInfo fi in sourceDir.GetFiles())
                {
                    // 若在忽略清單，則跳過。
                    if (_config.ignoreList.Contains(fi.Name)) continue;

                    _copyFileCounter++;
                    string targetFilepath = Path.Combine(targetDir.FullName, fi.Name);
                    if (_showDetail) LogMessage("copy {0}\r\n  to {1}", fi.FullName,targetFilepath); // trace
                    File.Copy(fi.FullName, targetFilepath, true);
                    RefreshStatusOfUI();
                }

                // 再處理目錄
                foreach (DirectoryInfo di in sourceDir.GetDirectories())
                {
                    // 若在忽略清單，則跳過。
                    if (_config.ignoreList.Contains(di.Name)) continue;

                    _copyDirCounter++;
                    DirectoryInfo nextTargetDir = new DirectoryInfo(Path.Combine(targetDir.FullName, di.Name));
                    if (_showDetail) LogMessage("dir {0}", nextTargetDir.FullName); // trace
                    if (!nextTargetDir.Exists) nextTargetDir.Create();
                    RefreshStatusOfUI();

                    // 遞迴
                    SubCopyDirectory(di, nextTargetDir);
                }
            }
            finally
            {
                if (_showDetail) this.LogMessage("已複製目錄 [{0}]", sourceDir.FullName);
            }
        }

        /// <summary>
        /// 複製同意清單檔案
        /// </summary>
        protected void DoCopyAllowList(DirectoryInfo sourceDir, DirectoryInfo targetDir)
        {
            try
            {
                foreach (string filename in _config.allowList)
                {
                    // 若以“\”結尾則視為目錄
                    if (filename.EndsWith("\\"))
                    {
                        //## copy direcotry
                        DirectoryInfo dirSource = new DirectoryInfo(sourceDir.FullName + filename);
                        DirectoryInfo dirTarget = new DirectoryInfo(targetDir.FullName + filename);

                        //if (_showDetail)
                        LogMessage("copy directory {0}\r\n  to {1}", dirSource.FullName, dirTarget.FullName); // trace

                        FileCopierBiz.DirectoryCopy(dirSource.FullName, dirTarget.FullName, true);
                        _copyFileCounter++;

                        RefreshStatusOfUI();
                    }
                    else
                    {
                        //## copy file
                        FileInfo sourceFile = new FileInfo(sourceDir.FullName + filename);
                        FileInfo targetFile = new FileInfo(targetDir.FullName + filename);

                        // 若檔案不存在，則跳過。
                        if (!sourceFile.Exists)
                        {
                            LogMessage("NOT EXISTS {0}", sourceFile.FullName); // trace
                            continue;
                        }

                        if (_showDetail) LogMessage("copy {0}\r\n  to {1}", sourceFile.FullName, targetFile.FullName); // trace

                        if (!targetFile.Directory.Exists)
                            targetFile.Directory.Create();

                        File.Copy(sourceFile.FullName, targetFile.FullName, true);
                        _copyFileCounter++;

                        RefreshStatusOfUI();
                    }
                }
            }
            finally
            {
                if (_showDetail) this.LogMessage("已複製同意清單");
            }
        }

        #endregion

        #region UI Refresh Method

        protected void LogMessage(string msg)
        {
            // Don't do anything if the form's handle hasn't been created 
            // or the form has been disposed.
            if (!this.IsHandleCreated || this.IsDisposed) return;

            // Invoke an anonymous method on the thread of the form.
            this.Invoke((MethodInvoker)delegate
            {
                this.txtMessage.AppendText(msg + Environment.NewLine);
            });
        }

        protected void LogMessage(string format, params object[] args)
        {
            // Don't do anything if the form's handle hasn't been created 
            // or the form has been disposed.
            if (!this.IsHandleCreated || this.IsDisposed) return;

            // Invoke an anonymous method on the thread of the form.
            this.Invoke((MethodInvoker)delegate
            {
                string msg = String.Format(format, args);
                this.txtMessage.AppendText(msg + Environment.NewLine);
            });
        }

        protected void RefreshStatusOfUI()
        {
            // Don't do anything if the form's handle hasn't been created 
            // or the form has been disposed.
            if (!this.IsHandleCreated || this.IsDisposed) return;

            // Invoke an anonymous method on the thread of the form.
            this.Invoke((MethodInvoker)delegate
            {
                // 更新結果
                this.txtFileCounter.Text = string.Format("{0:N0}", _fileCounter);
                this.txtDirCounter.Text = string.Format("{0:N0}", _dirCounter);
                this.lblCopyFileCounter.Text = string.Format("{0:N0}", _copyFileCounter);
                this.lblCopyDirCounter.Text = string.Format("{0:N0}", _copyDirCounter);
                this.prgCopyFile.Value = Math.Min(prgCopyFile.Maximum, _copyFileCounter);
                this.prgCopyDir.Value = Math.Min(prgCopyDir.Maximum, _copyDirCounter);
            });
        }

        protected void SetupUIMode_Count()
        {
            // Don't do anything if the form's handle hasn't been created 
            // or the form has been disposed.
            if (!this.IsHandleCreated || this.IsDisposed) return;

            // Invoke an anonymous method on the thread of the form.
            this.Invoke((MethodInvoker)delegate
            {
                prgCopyFile.SuspendLayout();
                prgCopyFile.Style = ProgressBarStyle.Blocks;
                prgCopyFile.Minimum = 0;
                prgCopyFile.Value = 0;
                prgCopyFile.Maximum = int.MaxValue;
                prgCopyFile.ResumeLayout();

                prgCopyDir.SuspendLayout();
                prgCopyDir.Style = ProgressBarStyle.Blocks;
                prgCopyDir.Minimum = 0;
                prgCopyDir.Value = 0;
                prgCopyDir.Maximum = int.MaxValue;
                prgCopyFile.ResumeLayout();
            });
        }

        protected void SetupUIMode_Copy()
        {
            // Don't do anything if the form's handle hasn't been created 
            // or the form has been disposed.
            if (!this.IsHandleCreated || this.IsDisposed) return;

            // Invoke an anonymous method on the thread of the form.
            this.Invoke((MethodInvoker)delegate
            {
                prgCopyFile.SuspendLayout();
                prgCopyFile.Style = ProgressBarStyle.Blocks;
                prgCopyFile.Minimum = 0;
                prgCopyFile.Value = 0;
                prgCopyFile.Maximum = _fileCounter;
                prgCopyFile.ResumeLayout();

                prgCopyDir.SuspendLayout();
                prgCopyDir.Style = ProgressBarStyle.Blocks;
                prgCopyDir.Minimum = 0;
                prgCopyDir.Value = 0;
                prgCopyDir.Maximum = _dirCounter;
                prgCopyFile.ResumeLayout();
            });
        }

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadConfigPackage(out this.configPkg);

            //# 將組態設定填入元件
            this.cboIdName.DataSource = this.configPkg.configList;
            this.cboIdName.DisplayMember = "idName";
            this.cboIdName.ValueMember = "idName";
            this.cboIdName.SelectedIndex = 0; // 將觸發 cboIdName_SelectedIndexChanged

            this.chkCountOnly.Checked = this.configPkg.countOnly;
            this.chkShowDetail.Checked = this.configPkg.showDetail;
        }

        private void cboIdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FCConfig cfg = (FCConfig)this.cboIdName.SelectedItem;

            //# 填入元件
            this.txtDescription.Text = cfg.description;
            this.txtSourceDir.Text = cfg.sourceDir;
            this.txtTargetDir.Text = cfg.targetDir;
            this.lstIgnoreList.DataSource = cfg.ignoreList;
            this.lstAllowList.DataSource = cfg.allowList;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //# 取設定
            FCConfig cfg = (FCConfig)this.cboIdName.SelectedItem;

            //# 切換畫面
            this.tabControl1.SelectedTab = this.tabPage2;

            //# prefix 開始
            // 把設定值送進去
            _config = cfg;
            _countOnly = chkCountOnly.Checked;
            _showDetail = chkShowDetail.Checked;

            //# 開始
            this.ProceedCopyDirectoryAsync();
            //this.ProceedCopyDirectory();

            //this.ProceedCopyAllowListAsync();
        }

    }

}
