using System.IO;
using System.Xml.Serialization;

namespace Corsework.Data.DataBase
{
    static class Serializer
    {
        public static void Deserialize<T>(string path, ref T list)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            var s = new XmlSerializer(typeof(T));
            list = (T)s.Deserialize(fs);
            fs.Dispose();
        }
        public static T Deserialize<T>(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            var s = new XmlSerializer(typeof(T));
            T tmp = (T)s.Deserialize(fs);
            fs.Dispose();
            return tmp;
        }

        /* можно использовать контрукцию using{} по завершении которой fs.dispose() вызывается автоматически 
         * или вызывать вручную или использовать блоки try / finally */
        public static void Serialize<T>(string path, T list)
        {
            var s = new XmlSerializer(typeof(T));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                s.Serialize(fs, list);
            }
        }
    }
}
