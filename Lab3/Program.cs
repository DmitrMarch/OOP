namespace Lab3
{
    class Program()
    {
        private static Student st1 = new("Дмитрий");

        static void Main()
        {
            Console.WriteLine(st1.WriteInfo());
            Student st2 = new("Никита");
            Console.WriteLine(st2.WriteInfo());
            Student st3 = new("Егор", 20);
            Console.WriteLine(st3.WriteInfo());

            Student.GroupToConsole();
            Student.University.Love();
        }
    }
}
