using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace TimeTrackerConsoleProto
{
    internal class SaveData
    {
        public static bool SaveInFile()
        {
            string FilePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            if (FilePath != null)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<CTimer>));
                serializer.Serialize(new FileStream(FilePath, FileMode.Create), "TimeList");
                return true;
            }
            return false;
        }
    }
}
