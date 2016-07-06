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
    public class Configuration
    {
        public String currentVersion;
        public SplatoonRegion region;
        public String currentPlaylist;

        private static XmlSerializer serializer = new XmlSerializer(typeof(Configuration));
        public static Configuration currentConfig;

        public static void Load()
        {
            if (!File.Exists("Configuration.xml"))
            {
                RegionForm requestForm = new RegionForm();
                requestForm.ShowDialog();

                currentConfig = new Configuration();
                currentConfig.currentVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
                currentConfig.region = requestForm.chosenRegion;
                currentConfig.currentPlaylist = "Default";

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
