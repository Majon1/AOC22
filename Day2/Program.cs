using System;
using System.IO;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        string[] round = File.ReadAllLines("strategy.txt");
        int score = 0;

        string[] opponent = new string[round.Length];
        string[] you = new string[round.Length];
        int j = 0;

        foreach (string rounds in round)
        {
            string[] all = round[].Split(round / 2);
            
            opponent[j] = all[0];
            you[j] = all[1];
            j++;
        }

        for (int i = 0; i < round.Length; i++)
        {
            if (opponent[i] == "A" && you[i] == "X")
            {
                score += 3;
            }
            if (opponent[i] == "A" && you[i] == "Y")
            {
                score += 4;
            }
            if (opponent[i] == "A" && you[i] == "Z")
            {
                score += 8;
            }

            if (opponent[i] == "B" && you[i] == "X")
            {
                score += 1;
            }
            if (opponent[i] == "B" && you[i] == "Y")
            {
                score += 5;
            }
            if (opponent[i] == "B" && you[i] == "Z")
            {
                score += 9;
            }

            if (opponent[i] == "C" && you[i] == "X")
            {
                score += 2;
            }
            if (opponent[i] == "C" && you[i] == "Y")
            {
                score += 6;
            }
            if (opponent[i] == "C" && you[i] == "Z")
            {
                score += 7;
            }

            /*if (you[i] == "X")
            {
                score += 1;
            }

            if (you[i] == "Y")
            {
                score += 2;
            }

            if (you[i] == "Z")
            {
                score += 3;
            }
    
            if (
                opponent[i] == "A" && you[i] == "Y"
                || opponent[i] == "B" && you[i] == "Z"
                || opponent[i] == "C" && you[i] == "X"
            )
            {
                score += 6;
            }
            if (
                opponent[i] == "A" && you[i] == "X"
                || opponent[i] == "B" && you[i] == "Y"
                || opponent[i] == "C" && you[i] == "Z"
            )
            {
                score += 3;
            }*/
        }
        Console.WriteLine("Score: " + score);
    }
}
