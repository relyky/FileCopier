# FileCopier
檔案複製者：複製目錄檔案，其中可忽略不要的檔案。
## 關鍵技術
### C# async/await
非同步執行。當然仍需符合多執行緒的限制條件。
* 原始碼位置： FileCopier/Form1.cs
** protected async void ProceedCopyDirectoryAsync() --- 非同步函式
把同步函式變成非同步函式。仍需利用MethodInvoker改寫UI顯示的碼，才能符合多執行緒的限制條件，才能非同步執行。
** protected void ProceedCopyDirectory() --- 同步函式
### MethodInvoker
使用MethodInvoker非同步畫面更新
使用MethodInvoker可以不用聲明，將需要異步或同步執行的方法當做參數傳遞給委托實例化的MethodInvoker對象。
* 參考[MethodInvoker Delegate](https://docs.microsoft.com/zh-tw/dotnet/api/system.windows.forms.methodinvoker?view=netframework-4.7.2)
* 原始碼位置： FileCopier/Form1.cs
** void RefreshStatusOfUI(), 
** protected void LogMessage(string format, params object[] args)
