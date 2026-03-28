using System.Diagnostics;
using System.IO;
using System;
using 农场.游戏.启动页;
using 农场.游戏.首页;

namespace 农场.游戏.启动页.启动页
{
    public static class 启动菜单逻辑
    {
        public static void 选择(string a)
        {
            Console.Clear();
            switch (a)
            {
                case "0":
                    {
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("正在退出游戏...");
                        Thread.Sleep(5000);
                        Environment.Exit(0);
                        break;
                    }
                case "1":
                    {
                        Console.WriteLine("对不起，暂时未支持");

                        Console.WriteLine("您可以玩之的存档或退出");
                        Console.WriteLine("上一页1    退出0");
                        string 输入 = Console.ReadLine();
                        if (输入 == "1")
                        {
                            Console.Clear();
                            启动页_.显示();
                        }
                        else if (输入 == "0")
                        {
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine("正在退出游戏...");
                            Thread.Sleep(5000);
                            Environment.Exit(0);
                        }
                        break;
                    }
                case "2":
                    {
                        启动首页.显示001();

                        break;
                    }
                case "4":
                    {
                        Console.Clear();
                        Console.WriteLine(File.ReadAllText("C:\\Users\\admin\\Desktop\\帮助文件.txt"));
                        Console.WriteLine("上一页1    退出0");
                        string 输入 = Console.ReadLine();
                        if (输入 == "1")
                        {
                            Console.Clear();
                            启动页_.显示();
                        }
                        else if (输入 == "0")
                        {
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine("正在退出游戏...");
                            Thread.Sleep(5000);
                            Environment.Exit(0);
                        }
                        break;
                    }
                case "3":
                    {
                        Console.Clear();
                        Console.WriteLine("对不起，暂时与更多");

                        Console.WriteLine("上一页1    退出0");
                        string 输入 = Console.ReadLine();
                        if (输入 == "1")
                        {
                            Console.Clear();
                            启动页_.显示();
                        }
                        else if (输入 == "0")
                        {
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine("正在退出游戏...");
                            Thread.Sleep(5000);
                            Environment.Exit(0);
                        }
                        break;
                    }
            }
        }
    }
}
