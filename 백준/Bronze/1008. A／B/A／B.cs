using System;
public class Study
    {
        static void Main()
        {
            int A = 0, B = 0;
            string[] txt = Console.ReadLine().Split();
            A = int.Parse(txt[0]);
            B = int.Parse(txt[1]);
            Console.WriteLine((decimal)A/B);
        }
    }