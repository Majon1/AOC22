using System;
using System.IO;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        string[] backpack = File.ReadAllLines("backpack.txt");

        string[] comp1 = new string[backpack.Length];
        string[] comp2 = new string[backpack.Length];
        List<string> sharing = new List<string>();
        string[] scoring =
        {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "i",
            "j",
            "k",
            "l",
            "m",
            "n",
            "o",
            "p",
            "q",
            "r",
            "s",
            "t",
            "u",
            "v",
            "w",
            "x",
            "y",
            "z",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"
        };

        int priority = 0;
        int j = 0;

        foreach (string things in backpack)
        {
            comp1[j] = things.Substring(0, things.Length / 2);
            //Console.WriteLine(comp1[j]);
            comp2[j] = things.Remove(0, things.Length / 2);
            //Console.WriteLine(comp2[j]);
            //Console.WriteLine();
            j++;
        }

        //compare
        int ind = 0;
        foreach (string thing in comp1)
        {
            foreach (char d in thing)
            {
                if (comp2[ind].Contains(d))
                {
                    sharing.Add(Char.ToString(d));
                }
            }
            ind++;
        }

        foreach (string s in sharing)
        {
            Console.WriteLine("sharing " + s);
        }

        /*string[] newA = sharing.Distinct().ToArray();

        for (int i = 0; i < newA.Length; i++)
        {
            Console.WriteLine("newA " + newA[i]);
        }*/

        foreach (string c in sharing)
        {
            priority += Array.IndexOf(scoring, c) + 1;
        }

        Console.WriteLine(priority);
    }
}
