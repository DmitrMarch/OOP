namespace Lab6
{
    class Program()
    {
        static void Main()
        {
            try
            {
                Console.Write("Имя: ");
                string name = new(Console.ReadLine());
                Console.Write("Возраст: ");
                int age = int.Parse(Console.ReadLine()!);
                Student st1 = new(name, age);
                Console.WriteLine(st1.WriteInfo());
            }
            catch (Exception ex) when (ex.Message == "Name must contain at least 1 character") 
            {
                Console.WriteLine("Имя должно содеражать хотя бы 1 символ");
            }
            catch (Exception ex) when (ex.Message == "Age must be a non-negative number")
            {
                Console.WriteLine("Возраст должен быть неотрицательным числом");
            }
            catch (FormatException)
            {
                Console.WriteLine("Возраст указан в неправильном формате");
            }
        }
    }
}
