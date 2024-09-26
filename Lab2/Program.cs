using Lab2;

Game game = new Game("Minecraft");
Subject subject = new Subject("Мобильная разработка");

Student st1 = new Student("Дмитрий", 19, game, subject);
Console.WriteLine(st1.WriteInfo());
//Console.WriteLine(st1._game); //"Student._game" недоступен из-за его уровня защиты
Console.WriteLine(st1.Age);

int number = 0;

st1.GetNumber(number);
Console.WriteLine(number);
st1.RealGetNumber(ref number);
Console.WriteLine(number);
