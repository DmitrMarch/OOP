﻿namespace Lab4
{
    class Program()
    {
        static void Main()
        {
            ITStudent st1 = new("Никита");
            st1.WriteStudentType();
            st1.WritePersonType();
            Student st2 = (Student)st1;
            st2.WriteStudentType();
            st2.WritePersonType();
        }
    }
}
