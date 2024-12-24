using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public static class JsonIO
    {
        public static List<Student> readJSONArray(String path)
        {
            string students_json = File.ReadAllText(path);

            List<Student> Students = JsonConvert.DeserializeObject
                <List<Student>>(students_json)!;

            return Students;
        }

        public static void writeJSONArray(String path, List<Student> students)
        {
            string students_json = JsonConvert.SerializeObject(students, 
                Formatting.Indented);

            File.WriteAllText(path, students_json);
        }
    }
}
