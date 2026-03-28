using System;
using System.Collections.Generic;
using System;
using 农场.游戏数据;
using 农场.保存存档;
using System.Text;

using System;

namespace 农场.保存存档
{
    public class 存档数据
    {
        // ✅ 改成【自动属性】{ get; set; }，System.Text.Json才能正常序列化！
        public string c玩家名 { get; set; }
        public int c金币 { get; set; }
        public int c体力 { get; set; }
        public bool c是否通关 { get; set; }
        public int 火龙果的价格 { get; set; }
        public int 西瓜的价格 { get; set; }
        public int 葡萄的价格 { get; set; }
        public int 草莓的价格 { get; set; }
        public  int 土豆的价格 { get; set; }
        public int 玉米的价格 { get; set; }
        public int 胡萝卜的价格 { get; set; }
        public int 茄子的价格 { get; set; }
        public int 黄瓜的价格 { get; set; }
        public int 南瓜的价格 { get; set; }
        public int 西红柿的价格 { get; set; }
        public int 洋葱的价格 { get; set; }
        public int 大蒜的价格 { get; set; }
        public int 生菜的价格 { get; set; }
        public int 菠菜的价格 { get; set; }
        public int 豆角的价格 { get; set; }
        public int 花菜的价格 { get; set; }
        public int 菜花的价格 { get; set; }


    }
}