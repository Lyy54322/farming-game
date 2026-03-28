using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using 农场.保存存档;

namespace 农场.游戏.首页
{
    public class 启动首页
    {
        public static void 显示001()
        {
            Console.WriteLine(@"
1.市场--------------------------
2.田地--------------------------
3.仓库--------------------------



0.上一页------------------------
"); 
            首页逻辑.处理输入(Console.ReadLine());

        }
}
}
