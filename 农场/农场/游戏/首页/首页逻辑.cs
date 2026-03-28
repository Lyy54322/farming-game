using System;
using System.Collections.Generic;
using System.Text;
using 农场.游戏.首页.市场;

namespace 农场.游戏.首页
{
    public static class 首页逻辑
    {
        public static void 处理输入(string 输入)
        {
            switch (输入)
            {
                case "1":
                    市场.市场.显示001();
                    break;
                case "0":
                    启动首页.显示001();
                    break;
                default:
                    Console.WriteLine("无效输入，请重新输入。");
                    break;
            }
        }
    }
}
