using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfUserControlApp1
{
    public class SDPrompt
    {
        /// <summary>
        /// 取得使用者控制項中的 SD Prompt 內容
        /// </summary>
        /// <returns>SD Prompt 字串內容</returns>
        public string GetSDPrompt(string prompt)
        {
            // 針對 Prompt 進行處理或修改
            string prompt2 = prompt + " - 已處理";
            return prompt2;
        }
    }
}
