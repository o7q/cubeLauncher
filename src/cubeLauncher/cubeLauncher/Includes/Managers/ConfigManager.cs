using System.IO;
using System.Text;
using static cubeLauncher.Data.Structure.ConfigStructure;

namespace cubeLauncher.Managers
{
    public static class ConfigManager
    {
        public static void WriteConfig(ConfigBase config, string path)
        {
            var sb = new StringBuilder();
            foreach (var field in typeof(ConfigBase).GetFields())
            {
                object value = field.GetValue(config);
                if (value != null)
                    sb.Append(field.Name + "¶" + value.ToString());
                sb.Append("\n");
            }
            sb.Length--;
            File.WriteAllText(path, sb.ToString());
        }

        public static ConfigBase ReadConfig(string path)
        {
            ConfigBase config = new ConfigBase();

            string configFile = File.ReadAllText(path);
            string[] configSetting = configFile.Split('\n');

            for (int i = 0; i < configSetting.Length; i++)
            {
                string[] configSettingPair = configSetting[i].Split('¶');

                switch (configSettingPair[0])
                {
                    case "INSTALL_NAME": config.INSTALL_NAME = configSettingPair[1]; break;
                    case "LAUNCHER_PATH": config.LAUNCHER_PATH = configSettingPair[1]; break;
                }
            }

            return config;
        }
    }
}