public class Student
{
    private string _name;

    public int Age { get; set; }

    public Student (string name) {
        _name = name;
    }

    public Student(string name, int age)
    {
        _name = name;
        Age = age;
    }

    public string WriteInfo()
    {
        return "Студент " + _name + " имеет возраст " + Age.ToString() + " лет";
    }

    public void BecomeOlder()
    {
        Age += 1;
    }


}
