using Newtonsoft.Json;

namespace Lab79
{
    public static class JsonIO
    {
        public static List<Student> readJSONArray(string path)
        {
            string students_json = File.ReadAllText(path);

            List<Student> students_list = JsonConvert.DeserializeObject
                <List<Student>>(students_json)!;

            return students_list;
        }

        public static void writeJSONArray(string path, 
            List<Student> students_list)
        {
            string students_json = JsonConvert.SerializeObject(students_list, 
                Formatting.Indented);

            File.WriteAllText(path, students_json);
        }
    }
}
