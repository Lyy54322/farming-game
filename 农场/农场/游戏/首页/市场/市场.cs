using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using 农场.游戏数据;
using 农场.保存存档;

namespace 农场.游戏.首页.市场
{
    public static class 市场
    {
        public static void 显示001()
        {
            Console.WriteLine("=== 农场市场 ===");
            Console.WriteLine("当前火龙果价格：" + 全局数据.火龙果的价格);
            Console.WriteLine("请输入新的火龙果价格：");

            // 安全获取输入
            if (int.TryParse(Console.ReadLine(), out int 新价格))
            {
                // 1. 修改全局数据
                全局数据.火龙果的价格 = 新价格;

                // 2. 调用一次存档（自动把全部数据写入文件）
                读写的中间方法.读写(1);

                Console.WriteLine("✅ 价格修改成功！新价格：" + 全局数据.火龙果的价格);
            }
            else
            {
                Console.WriteLine("❌ 输入的不是有效数字！");
            }
        }
    }
}