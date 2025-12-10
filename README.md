# WPF 使用者控制項範例 - WpfUserControlApp1

WPF 使用者控制項範例應用程式 - 客戶端教育訓練用

## 專案說明

這是一個為教育訓練設計的 WPF (Windows Presentation Foundation) 示範應用程式，展示如何在 WPF 中建立和使用自訂使用者控制項。

### 主要功能
- **MyUserControl**: 基礎使用者控制項示範
- **MySecUserControl**: 進階使用者控制項，包含文本輸入功能
- **主視窗**: 示範如何整合和使用上述控制項，並與之交互

## 技術堆棧

| 項目 | 版本 |
|------|------|
| .NET Framework | 4.8 |
| C# | 7.3 |
| 框架 | WPF (Windows Presentation Foundation) |
| IDE | Visual Studio 2019 或更新版本 |

## 專案結構

```
WpfUserControlApp1/
├── App.xaml                 # 應用程式配置文件
├── App.xaml.cs             # 應用程式代碼後置
├── MainWindow.xaml         # 主視窗 UI 定義
├── MainWindow.xaml.cs      # 主視窗代碼後置
├── MyUserControl.xaml      # 基礎使用者控制項 UI
├── MyUserControl.xaml.cs   # 基礎使用者控制項代碼後置
├── MySecUserControl.xaml   # 進階使用者控制項 UI
├── MySecUserControl.xaml.cs# 進階使用者控制項代碼後置
└── Properties/
    └── AssemblyInfo.cs     # 組件資訊
```

## 快速開始

### 前置需求

- Windows 10 或更新版本
- Visual Studio 2019 或更新版本 (含 .NET Framework 4.8 SDK)
- .NET Framework 4.8

### 安裝步驟

1. **克隆或下載專案**
   ```bash
   git clone <repository-url>
   cd WpfUserControlApp1
   ```

2. **使用 Visual Studio 開啟專案**
   - 開啟 `WpfUserControlApp1.sln` 檔案

3. **復原 NuGet 套件** (如需要)
   - Visual Studio 會自動復原
   - 或手動執行: `dotnet restore`

4. **編譯專案**
   - 按 `Ctrl + Shift + B` 或選擇 Build > Build Solution

5. **運行應用程式**
   - 按 `F5` 或選擇 Debug > Start Debugging

## 操作執行方式

### 1. 啟動應用程式

運行應用程式後，主視窗會顯示兩個使用者控制項:

```
┌─ WpfUserControlApp1 ───────────────────┐
│                                         │
│  [MyUserControl]                        │
│                                         │
│  [MySecUserControl]                     │
│  ┌─────────────────────────────────┐   │
│  │ 請輸入文本...                   │   │
│  └─────────────────────────────────┘   │
│                                         │
│  ┌─────────────────────────────────┐   │
│  │        獲取提示 (Get Prompt)    │   │
│  └─────────────────────────────────┘   │
│                                         │
└─────────────────────────────────────────┘
```

### 2. 使用 MySecUserControl

- **功能**: 此控制項包含一個文本輸入框，用於輸入提示信息

**步驟:**
1. 在 `MySecUserControl` 的文本框中輸入文本內容
2. 文本框預設提示: "請輸入文本..."

### 3. 點擊「獲取提示」按鈕

- **功能**: 讀取 `MySecUserControl` 中的文本內容並顯示

**步驟:**
1. 在文本框中輸入任意文本 (例如: "這是一個範例提示")
2. 點擊「獲取提示」按鈕
3. 彈出訊息框顯示您輸入的文本內容

**程式流程:**
```
Button_Click() → mySecUserControl.GetSDPrompt → MessageBox.Show()
```

### 4. 示範運行流程

**範例:**

| 步驟 | 操作 | 結果 |
|------|------|------|
| 1 | 在文本框輸入 "Hello WPF" | 文本框顯示 "Hello WPF" |
| 2 | 點擊「獲取提示」按鈕 | 彈出訊息框顯示 "Hello WPF" |
| 3 | 點擊訊息框「確定」按鈕 | 訊息框關閉，返回主視窗 |

## 核心概念

### 使用者控制項 (UserControl)

使用者控制項是可重用的 UI 元件，可以在其他 WPF 應用程式中使用。

```csharp
// MySecUserControl 示範
public partial class MySecUserControl : UserControl
{
    public MySecUserControl()
    {
        InitializeComponent();
    }

    public string GetSDPrompt
    {
        get { return txtAdditionalInfo.Text; }
    }
}
```

### 屬性 (Property)

`GetSDPrompt` 是一個唯讀屬性，用於取得文本框中的內容:

```csharp
public string GetSDPrompt
{
    get { return txtAdditionalInfo.Text; }
}
```

### 事件處理 (Event Handling)

主視窗的按鈕點擊事件處理:

```csharp
private void Button_Click(object sender, RoutedEventArgs e)
{
    string content = mySecUserControl.GetSDPrompt;
    MessageBox.Show(content, this.Title, MessageBoxButton.OK, 
                    MessageBoxImage.Error);
}
```

## 進階使用

### 修改控制項

1. **編輯 MySecUserControl.xaml**
   - 修改 UI 佈局和控制項屬性

2. **編輯 MySecUserControl.xaml.cs**
   - 新增或修改屬性和方法
   - 例如: 新增驗證邏輯、事件通知等

3. **重編譯和測試**
   - 按 `Ctrl + Shift + B` 編譯
   - 按 `F5` 執行

### 新增自訂方法

在 `MySecUserControl` 中新增自訂方法:

```csharp
public void ClearText()
{
    txtAdditionalInfo.Text = string.Empty;
}

public bool ValidateInput()
{
    return !string.IsNullOrWhiteSpace(txtAdditionalInfo.Text);
}
```

## 常見問題 (FAQ)

### Q: 如何在我的其他 WPF 應用程式中使用這些控制項?

**A:** 
1. 複製 `.xaml` 和 `.xaml.cs` 檔案到您的專案
2. 在 XAML 中引用命名空間
3. 使用控制項:
   ```xml
   <local:MySecUserControl x:Name="mySecUserControl" />
   ```

### Q: 如何修改訊息框的顯示樣式?

**A:** 修改 `MainWindow.xaml.cs` 中的 `Button_Click` 方法:

```csharp
MessageBox.Show(content, "自訂標題", MessageBoxButton.OKCancel, 
                MessageBoxImage.Information);
```

### Q: 如何清除文本框內容?

**A:** 在 `MySecUserControl` 中新增方法:

```csharp
public void Clear()
{
    txtAdditionalInfo.Clear();
}
```

然後在主視窗中呼叫: `mySecUserControl.Clear();`

## 疑難排解

### 應用程式無法啟動

- 確認安裝了 .NET Framework 4.8
- 檢查 Visual Studio 的 Windows Desktop Development 工作負載已安裝
- 嘗試清除 `bin` 和 `obj` 資料夾後重新編譯

### 文本框無法輸入文本

- 確認文本框已獲得焦點 (鼠標點擊文本框)
- 檢查 XAML 中 `IsReadOnly` 屬性是否設為 `False`

### 訊息框未正確顯示

- 確認 `txtAdditionalInfo` 控制項名稱正確
- 檢查是否正確實例化了 `MySecUserControl`

## 參考資源

- [Microsoft WPF 官方文檔](https://docs.microsoft.com/zh-tw/dotnet/desktop/wpf/)
- [WPF 使用者控制項教程](https://docs.microsoft.com/zh-tw/dotnet/desktop/wpf/controls/usercontrol-overview)
- [C# 屬性](https://docs.microsoft.com/zh-tw/dotnet/csharp/programming-guide/classes-and-structs/properties)

## 許可證

此專案為教育訓練用途，版權所有 ? 2025。

## 支援

如有任何問題或建議，請聯繫教育訓練團隊。

---

**最後更新**: 2025 年  
**適用版本**: .NET Framework 4.8, C# 7.3