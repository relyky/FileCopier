# FileCopier
檔案複製者：複製目錄檔案，其中可忽略不要的檔案。  
更版：加入同意清單allowList指定copy對象。用於複製“稀少”對象。
## 關鍵技術
### C# async/await
非同步執行。當然仍需符合多執行緒的限制條件。
* 原始碼位置： FileCopier/Form1.cs  
1. async void ProceedCopyDirectoryAsync() --- 非同步函式。把同步函式變成非同步函式。仍需利用MethodInvoker改寫UI顯示的碼，才能符合多執行緒的限制條件，才能非同步執行。  
2. void ProceedCopyDirectory() --- 同步函式
### MethodInvoker
使用MethodInvoker非同步畫面更新
使用MethodInvoker可以不用聲明，將需要異步或同步執行的方法當做參數傳遞給委托實例化的MethodInvoker對象。
* 參考[MethodInvoker Delegate](https://docs.microsoft.com/zh-tw/dotnet/api/system.windows.forms.methodinvoker?view=netframework-4.7.2)
* 原始碼位置： FileCopier/Form1.cs  
1. void RefreshStatusOfUI()  
2. void LogMessage(string format, params object[] args)

<pre>
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
</pre>
