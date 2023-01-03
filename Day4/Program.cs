using System;
using System.IO;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        string[] schedule = File.ReadAllLines("schedule.txt");
        //string[] splitted = new string[schedule.Length * 2];
        int amount = 0;
        string[] elf1 = new string[2];
        string[] elf2 = new string[2];

        foreach (string s in schedule)
        {
            string[] splitted = s.Split(",");
            elf1[0] = splitted[0];
            elf2[0] = splitted[1];

            string[] elf1Times = elf1[0].Split("-");

            string[] elf2Times = elf2[0].Split("-");

            //one overlaps whole
            /*if (
                Convert.ToInt32(elf1Times[0]) <= Convert.ToInt32(elf2Times[0])
                && Convert.ToInt32(elf1Times[1]) >= Convert.ToInt32(elf2Times[1])
            )
            {
                amount += 1;
            }
            else if (
                Convert.ToInt32(elf2Times[0]) <= Convert.ToInt32(elf1Times[0])
                && Convert.ToInt32(elf2Times[1]) >= Convert.ToInt32(elf1Times[1])
            )
            {
                amount += 1;
            }*/
            //overlap occurs
            if (
                Convert.ToInt32(elf1Times[0]) <= Convert.ToInt32(elf2Times[0])
                && Convert.ToInt32(elf1Times[1]) >= Convert.ToInt32(elf2Times[1])
            )
            {
                amount += 1;
            }
            else if (
                Convert.ToInt32(elf1Times[0]) <= Convert.ToInt32(elf2Times[0])
                && Convert.ToInt32(elf1Times[1]) >= Convert.ToInt32(elf2Times[0])
            )
            {
                amount += 1;
            }
            else if (
                Convert.ToInt32(elf2Times[0]) <= Convert.ToInt32(elf1Times[0])
                && Convert.ToInt32(elf2Times[1]) >= Convert.ToInt32(elf1Times[0])
            )
            {
                amount += 1;
            }
        }

        Console.WriteLine(amount);
    }
}
