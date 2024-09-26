using Lab2;

Game game = new Game("");
Subject subject = new Subject("");

Student st1 = new Student("Дмитрий", 19, game, subject);
Console.WriteLine(st1.WriteInfo());
st1.BecomeOlder();
Console.WriteLine(st1.WriteInfo());
