namespace Lab5
{
    class Program()
    {
        static void Main()
        {
            ITStudent st1 = new("Никита", new Subject("математика"));
            Console.WriteLine(st1.WriteInfo());
        }
    }
}
