using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MusicRandomizer
{
    [Serializable]
    class Configuration
    {
        public String currentVersion;

        private static XmlSerializer serializer = new XmlSerializer(typeof(Configuration));
        public static Configuration currentConfig;

        public static void Load()
        {
            if (!File.Exists("Configuration.xml"))
            {
                currentConfig = new Configuration();
                currentConfig.currentVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

                Save();
            }
            else
            {
                using (FileStream stream = File.OpenRead("Configuration.xml"))
                {
                    currentConfig = (Configuration)serializer.Deserialize(stream);
                }
            }
        }

        public static void Save()
        {
            File.Delete("Configuration.xml");
            using (FileStream writer = File.OpenWrite("Configuration.xml"))
            {
                serializer.Serialize(writer, currentConfig);
            }
        }
    }
}
