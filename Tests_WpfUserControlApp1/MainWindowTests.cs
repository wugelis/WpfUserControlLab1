using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfUserControlApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WpfUserControlApp1.Tests
{
    [TestClass()]
    public class MainWindowTests
    {
        [TestMethod()]
        public void Test_GetSDPrompt()
        {
            // Arrange - 準備測試資料和物件
            var sdPrompt = new SDPrompt();
            string inputPrompt = "test prompt";
            string expectedOutput = "test prompt - 已處理";

            // Act - 執行要測試的方法
            string actualOutput = sdPrompt.GetSDPrompt(inputPrompt);

            // Assert - 驗證結果
            Assert.AreEqual(expectedOutput, actualOutput);
        }

    }
}