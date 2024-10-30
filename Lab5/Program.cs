namespace Lab5
{
    class Program()
    {
        static void Main()
        {
            ITStudent st1 = new("Никита", 20, new Subject("математика"));
            IPerson pst = st1;
            ISpecialist itst = st1;
            Console.WriteLine(pst.WriteInfo());
            Console.WriteLine(itst.WriteInfo());
        }
    }
}
