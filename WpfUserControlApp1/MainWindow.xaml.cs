using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfUserControlApp1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// 初始化 MainWindow 的新執行個體
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 按鈕點擊事件處理常式
        /// 取得 SD Prompt 內容並顯示在訊息方塊中
        /// </summary>
        /// <param name="sender">事件來源物件</param>
        /// <param name="e">路由事件引數</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 取得 SD Prompt 內容
            string content = GetSDPrompt();

            // 顯示訊息方塊
            MessageBox.Show(content, this.Title, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        #region Application-Specific Methods
        /// <summary>
        /// 取得使用者控制項中的 SD Prompt 內容
        /// </summary>
        /// <returns>SD Prompt 字串內容</returns>
        private string GetSDPrompt()
        {
            SDPrompt sd = new SDPrompt();

            return sd.GetSDPrompt(mySecUserControl.GetSDPrompt);
        }
        #endregion
    }
}
