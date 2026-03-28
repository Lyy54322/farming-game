using System.Text.Json;

namespace 农场.保存存档
{
    public class 读写存档
    {
        static public void 保存(存档数据 数据)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(数据);
            File.WriteAllText("存档文件.json", json);
        }
        static public 存档数据 读档()
        {
            if (!File.Exists("存档文件.json"))
            {
                return new 存档数据();
            }

            string json = File.ReadAllText("存档文件.json");
            return JsonSerializer.Deserialize<存档数据>(json)!;
        }
    }
}
