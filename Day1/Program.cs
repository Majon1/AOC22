using System;
using System.IO;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        string[] calories = File.ReadAllLines("calories.txt");
        List<int> elfs = new List<int>();
        List<int> cal = new List<int>();

        for (int i = 0; i < calories.Length; i++)
        {
            if (calories[i] == "")
            {
                calories[i] = "0";
            }
            int f = Convert.ToInt32(calories[i]);
            cal.Add(f);
        }

        int sum = 0;
        for (int i = 0; i < cal.Count; i++)
        {
            if (cal[i] != 0)
            {
                sum = sum + cal[i];
            }
            else if (cal[i] == 0)
            {
                elfs.Add(sum);
                sum = 0;
            }
            if (i == cal.Count - 1)
            {
                sum = sum + cal[i];
                elfs.Add(sum);
            }
        }

        int max = 0;
        foreach (int calory in elfs)
        {
            if (calory > max)
            {
                max = calory;
            }
        }
        Console.WriteLine("most calories: " + max);

        elfs.Sort();
        elfs.Reverse();

        Console.WriteLine(
            "The three elfs carrying most carries "
                + (elfs[0] + elfs[1] + elfs[2])
                + " calories combined."
        );
    }
}
