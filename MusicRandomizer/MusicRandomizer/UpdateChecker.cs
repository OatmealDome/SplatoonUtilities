using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MusicRandomizer
{
    public class UpdateInfo
    {
        public String latestVersion;
        public String changes;
    }

    class UpdateChecker
    {
        private static XmlSerializer serializer = new XmlSerializer(typeof(UpdateInfo));

        public static UpdateInfo CheckForUpdate()
        {
            string xml;
            using (var client = new WebClient())
            {
                xml = client.DownloadString("https://oatmealdome.github.io/MusicRandomizer/UpdateInfo.xml");
            }

            UpdateInfo updateInfo;
            using (TextReader reader = new StringReader(xml))
            {
                updateInfo = (UpdateInfo) serializer.Deserialize(reader);
            }

            return updateInfo;
        }

        public static void ConvertIfNeeded()
        {
            String version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            if (Configuration.currentConfig.currentVersion.Equals(version))
            {
                // We don't need to convert anything
                return;
            }
        }

    }
}
