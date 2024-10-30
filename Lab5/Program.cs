namespace Lab5
{
    class Program()
    {
        static void Main()
        {
            ITStudent st1 = new("Никита", 20, new Subject("математика"));
            ITStudent st2 = new("Владимир", 22, new Subject("SQL"));
            IPerson pst = st1;
            ISpecialist itst = st1;
            Console.WriteLine(pst.WriteInfo());
            Console.WriteLine(itst.WriteInfo());
            Console.WriteLine(st1.CompareTo(st2));
            Student st_clone = ((Student)st1.Clone());
            st_clone.Age = 100;
            Console.WriteLine(st1.Age);
            Console.WriteLine(st_clone.Age);
        }
    }
}
