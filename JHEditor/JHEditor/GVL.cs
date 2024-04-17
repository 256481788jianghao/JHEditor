using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHEditor
{
    public class GVL
    {
        public static JHDirectoryMgr directoryMgr = new JHDirectoryMgr();
        public static FilesMgr filesMgr = new FilesMgr();
        public static ConfigParam ConfigParam = new ConfigParam();


        public static void InitConfigParam()
        {
            if (File.Exists("./configparam.json"))
            {
                string json_str = File.ReadAllText("./configparam.json");
                ConfigParam = JsonConvert.DeserializeObject<ConfigParam>(json_str);
            }
        }

        public static void SaveConfigParam()
        {
            string json_str = JsonConvert.SerializeObject(ConfigParam);
            File.WriteAllText("./configparam.json", json_str);
        }
    }
}
