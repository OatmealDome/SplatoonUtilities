using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace MusicRandomizer
{
    [Serializable]
    public class MusicFile
    {
        public String path
        {
            get;
            set;
        }

        [XmlIgnore]
        public String fileName
        {
            get
            {
                String name = Path.GetFileName(path);
                return name.Substring(0, name.Length - 6);
            }
            private set
            {
                // do nothing
            }
        }

        public List<TrackType> types
        {
            get;
            set;
        }
    }
}

