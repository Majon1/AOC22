using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        String d = File.ReadAllText("string.txt");
        char[] p = d.ToCharArray();

        for (int i = 0; i < p.Length - 3; i++)
        {
            char[] c =
            {
                p[i],
                p[i + 1],
                p[i + 2],
                p[i + 3],
                p[i + 4],
                p[i + 5],
                p[i + 6],
                p[i + 7],
                p[i + 8],
                p[i + 9],
                p[i + 10],
                p[i + 11],
                p[i + 12],
                p[i + 13]
            };
            char[] dis = c.Distinct().ToArray();
            if (dis.Length == c.Length)
            {
                Console.WriteLine("found " + (i + 14));
                break;
            }
        }
    }
}
