using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Lab7
{
    public static class XmlIO
    {
        public static List<Student> readXml(string path)
        {
            XmlSerializer xml_serializer = new XmlSerializer(
                typeof(List<Student>));

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Student>? students_list = xml_serializer.Deserialize(fs) 
                    as List<Student>;

                return students_list ?? [];
            }
        }

        public static void writeXml(string path, List<Student> students)
        {
            XmlSerializer xml_serializer = new(typeof(List<Student>));

            using (FileStream fs = new(path, FileMode.OpenOrCreate))
            {
                xml_serializer.Serialize(fs, students);
            }
        }
    }
}
