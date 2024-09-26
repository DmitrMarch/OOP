using Lab2;

Student st1 = new Student("Дмитрий", 19, new Game("a"), new Subject("a"));
Console.WriteLine(st1.WriteInfo());
st1.BecomeOlder();
Console.WriteLine(st1.WriteInfo());
