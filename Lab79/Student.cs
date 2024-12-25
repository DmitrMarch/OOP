namespace Lab79
{
    public class Student : Person
    {
        // Конструктор для XmlSerializer
        private Student() : base("")
        {
            Fullname = "";
            RecordBook = "";
            Department = "";
            Specification = "";
            Group = "";
            DateOfAdmission = "";
        }

        public Student(string fullname, string recordBook, string department, 
            string specification, string group, string dateOfAdmission)
        : base("")
        {
            Fullname = fullname;
            RecordBook = recordBook;
            Department = department;
            Specification = specification;
            Group = group;
            DateOfAdmission = dateOfAdmission;
        }

        public string RecordBook { get; set; }
        public string Department { get; set; }
        public string Specification { get; set; }
        public string Group { get; set; }
        public string DateOfAdmission { get; set; }

        public static bool containRecBook(string record_book, List<Student> students_list)
        {
            foreach (Student student in students_list)
            {
                if (student.RecordBook.Equals(record_book))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
