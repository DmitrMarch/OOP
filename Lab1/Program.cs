using Lab1;
using System;

Student st1 = new Student("Дмитрий", 19);
Console.WriteLine(st1.WriteInfo());
st1.BecomeOlder();
Console.WriteLine(st1.WriteInfo());
