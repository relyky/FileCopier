namespace FileCopier
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtSourceDir = new System.Windows.Forms.TextBox();
            this.txtTargetDir = new System.Windows.Forms.TextBox();
            this.cboIdName = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkCountOnly = new System.Windows.Forms.CheckBox();
            this.chkShowDetail = new System.Windows.Forms.CheckBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.lstIgnoreList = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCopyDirCounter = new System.Windows.Forms.Label();
            this.lblCopyFileCounter = new System.Windows.Forms.Label();
            this.prgCopyDir = new System.Windows.Forms.ProgressBar();
            this.txtDirCounter = new System.Windows.Forms.TextBox();
            this.txtFileCounter = new System.Windows.Forms.TextBox();
            this.lblDirCounter = new System.Windows.Forms.Label();
            this.lblFileCounter = new System.Windows.Forms.Label();
            this.prgCopyFile = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.lstAllowList = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "選取組態";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "說明";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "來源目錄";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "目地目錄";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "忽略清單";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(147, 63);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(594, 27);
            this.txtDescription.TabIndex = 5;
            // 
            // txtSourceDir
            // 
            this.txtSourceDir.Location = new System.Drawing.Point(147, 98);
            this.txtSourceDir.Margin = new System.Windows.Forms.Padding(4);
            this.txtSourceDir.Name = "txtSourceDir";
            this.txtSourceDir.ReadOnly = true;
            this.txtSourceDir.Size = new System.Drawing.Size(594, 27);
            this.txtSourceDir.TabIndex = 6;
            // 
            // txtTargetDir
            // 
            this.txtTargetDir.Location = new System.Drawing.Point(147, 133);
            this.txtTargetDir.Margin = new System.Windows.Forms.Padding(4);
            this.txtTargetDir.Name = "txtTargetDir";
            this.txtTargetDir.ReadOnly = true;
            this.txtTargetDir.Size = new System.Drawing.Size(594, 27);
            this.txtTargetDir.TabIndex = 7;
            // 
            // cboIdName
            // 
            this.cboIdName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdName.FormattingEnabled = true;
            this.cboIdName.Location = new System.Drawing.Point(147, 31);
            this.cboIdName.Margin = new System.Windows.Forms.Padding(4);
            this.cboIdName.Name = "cboIdName";
            this.cboIdName.Size = new System.Drawing.Size(594, 24);
            this.cboIdName.TabIndex = 8;
            this.cboIdName.SelectedIndexChanged += new System.EventHandler(this.cboIdName_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(833, 563);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstAllowList);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.chkCountOnly);
            this.tabPage1.Controls.Add(this.chkShowDetail);
            this.tabPage1.Controls.Add(this.btnRun);
            this.tabPage1.Controls.Add(this.lstIgnoreList);
            this.tabPage1.Controls.Add(this.cboIdName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtTargetDir);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtSourceDir);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtDescription);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(825, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "組態";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkCountOnly
            // 
            this.chkCountOnly.AutoSize = true;
            this.chkCountOnly.Location = new System.Drawing.Point(147, 408);
            this.chkCountOnly.Name = "chkCountOnly";
            this.chkCountOnly.Size = new System.Drawing.Size(107, 20);
            this.chkCountOnly.TabIndex = 15;
            this.chkCountOnly.Text = "只計算數量";
            this.chkCountOnly.UseVisualStyleBackColor = true;
            // 
            // chkShowDetail
            // 
            this.chkShowDetail.AutoSize = true;
            this.chkShowDetail.Location = new System.Drawing.Point(288, 408);
            this.chkShowDetail.Name = "chkShowDetail";
            this.chkShowDetail.Size = new System.Drawing.Size(91, 20);
            this.chkShowDetail.TabIndex = 14;
            this.chkShowDetail.Text = "顯示明細";
            this.chkShowDetail.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(147, 434);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(124, 39);
            this.btnRun.TabIndex = 12;
            this.btnRun.Text = "執行複製";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lstIgnoreList
            // 
            this.lstIgnoreList.FormattingEnabled = true;
            this.lstIgnoreList.ItemHeight = 16;
            this.lstIgnoreList.Location = new System.Drawing.Point(41, 206);
            this.lstIgnoreList.Name = "lstIgnoreList";
            this.lstIgnoreList.Size = new System.Drawing.Size(338, 180);
            this.lstIgnoreList.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtMessage);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(864, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "執行紀錄";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.SystemColors.Info;
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Location = new System.Drawing.Point(3, 118);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(858, 412);
            this.txtMessage.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblCopyDirCounter);
            this.panel1.Controls.Add(this.lblCopyFileCounter);
            this.panel1.Controls.Add(this.prgCopyDir);
            this.panel1.Controls.Add(this.txtDirCounter);
            this.panel1.Controls.Add(this.txtFileCounter);
            this.panel1.Controls.Add(this.lblDirCounter);
            this.panel1.Controls.Add(this.lblFileCounter);
            this.panel1.Controls.Add(this.prgCopyFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 115);
            this.panel1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = " 複製目錄";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = " 複製檔案";
            // 
            // lblCopyDirCounter
            // 
            this.lblCopyDirCounter.AutoSize = true;
            this.lblCopyDirCounter.Location = new System.Drawing.Point(705, 48);
            this.lblCopyDirCounter.Name = "lblCopyDirCounter";
            this.lblCopyDirCounter.Size = new System.Drawing.Size(120, 16);
            this.lblCopyDirCounter.TabIndex = 21;
            this.lblCopyDirCounter.Text = "已複製目錄數量";
            // 
            // lblCopyFileCounter
            // 
            this.lblCopyFileCounter.AutoSize = true;
            this.lblCopyFileCounter.Location = new System.Drawing.Point(705, 19);
            this.lblCopyFileCounter.Name = "lblCopyFileCounter";
            this.lblCopyFileCounter.Size = new System.Drawing.Size(120, 16);
            this.lblCopyFileCounter.TabIndex = 20;
            this.lblCopyFileCounter.Text = "已複製檔案數量";
            // 
            // prgCopyDir
            // 
            this.prgCopyDir.Location = new System.Drawing.Point(105, 41);
            this.prgCopyDir.Name = "prgCopyDir";
            this.prgCopyDir.Size = new System.Drawing.Size(594, 23);
            this.prgCopyDir.TabIndex = 19;
            // 
            // txtDirCounter
            // 
            this.txtDirCounter.Location = new System.Drawing.Point(354, 70);
            this.txtDirCounter.Name = "txtDirCounter";
            this.txtDirCounter.ReadOnly = true;
            this.txtDirCounter.Size = new System.Drawing.Size(155, 27);
            this.txtDirCounter.TabIndex = 18;
            // 
            // txtFileCounter
            // 
            this.txtFileCounter.Location = new System.Drawing.Point(105, 70);
            this.txtFileCounter.Name = "txtFileCounter";
            this.txtFileCounter.ReadOnly = true;
            this.txtFileCounter.Size = new System.Drawing.Size(155, 27);
            this.txtFileCounter.TabIndex = 17;
            // 
            // lblDirCounter
            // 
            this.lblDirCounter.AutoSize = true;
            this.lblDirCounter.Location = new System.Drawing.Point(276, 73);
            this.lblDirCounter.Name = "lblDirCounter";
            this.lblDirCounter.Size = new System.Drawing.Size(72, 16);
            this.lblDirCounter.TabIndex = 16;
            this.lblDirCounter.Text = "目錄數量";
            // 
            // lblFileCounter
            // 
            this.lblFileCounter.AutoSize = true;
            this.lblFileCounter.Location = new System.Drawing.Point(23, 73);
            this.lblFileCounter.Name = "lblFileCounter";
            this.lblFileCounter.Size = new System.Drawing.Size(76, 16);
            this.lblFileCounter.TabIndex = 15;
            this.lblFileCounter.Text = " 檔案數量";
            // 
            // prgCopyFile
            // 
            this.prgCopyFile.Location = new System.Drawing.Point(105, 12);
            this.prgCopyFile.Name = "prgCopyFile";
            this.prgCopyFile.Size = new System.Drawing.Size(594, 23);
            this.prgCopyFile.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 187);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "同意清單";
            // 
            // lstAllowList
            // 
            this.lstAllowList.FormattingEnabled = true;
            this.lstAllowList.ItemHeight = 16;
            this.lstAllowList.Location = new System.Drawing.Point(403, 206);
            this.lstAllowList.Name = "lstAllowList";
            this.lstAllowList.Size = new System.Drawing.Size(338, 180);
            this.lstAllowList.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 563);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "File Copier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtSourceDir;
        private System.Windows.Forms.TextBox txtTargetDir;
        private System.Windows.Forms.ComboBox cboIdName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lstIgnoreList;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar prgCopyFile;
        private System.Windows.Forms.TextBox txtDirCounter;
        private System.Windows.Forms.TextBox txtFileCounter;
        private System.Windows.Forms.Label lblDirCounter;
        private System.Windows.Forms.Label lblFileCounter;
        private System.Windows.Forms.CheckBox chkShowDetail;
        private System.Windows.Forms.CheckBox chkCountOnly;
        private System.Windows.Forms.ProgressBar prgCopyDir;
        private System.Windows.Forms.Label lblCopyDirCounter;
        private System.Windows.Forms.Label lblCopyFileCounter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstAllowList;
        private System.Windows.Forms.Label label8;
    }
}

