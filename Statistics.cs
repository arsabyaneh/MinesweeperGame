using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Minesweeper
{
    public class Statistics
    {
        public long BeginnerTime;
        public long IntermediateTime;
        public long AdvancedTime;

        public DateTime BeginnerDate;
        public DateTime IntermediateDate;
        public DateTime AdvancedDate;

        private Statistics()
        {
            BeginnerTime = long.MaxValue;
            IntermediateTime = long.MaxValue;
            AdvancedTime = long.MaxValue;
        }

        private static Statistics _Current;
        public static  Statistics Current
        {
            get
            {
                if (_Current == null)
                    return LoadFromFile();

                return _Current;
            }
        }

        private static Statistics LoadFromFile()
        {
            string path = Directory.GetCurrentDirectory() + "\\stat.xml";

            if (!File.Exists(path))
            {
                return new Statistics();
            }

            XmlSerializer serializer = new XmlSerializer(typeof(Statistics));
            FileStream stream = new FileStream(path,
                FileMode.Open,
                FileAccess.Read, FileShare.None);

            Statistics statistics = (Statistics)serializer.Deserialize(stream);
            stream.Close();

            return statistics;
        }

        public void Save()
        {
            string path = Directory.GetCurrentDirectory() + "\\stat.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(Statistics));
            FileStream stream = new FileStream(path,
                File.Exists(path) ? FileMode.Truncate : FileMode.CreateNew,
                FileAccess.Write, FileShare.None);

            serializer.Serialize(stream, this);
            stream.Close();
        }
    }
}
