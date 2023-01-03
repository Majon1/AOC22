using System;
using System.IO;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        string[] manual = File.ReadAllLines("manual.txt");

        string[] stack1 = new string[] { "D", "T", "R", "B", "J", "L", "W", "G" };
        string[] stack2 = new string[] { "S", "W", "C" };
        string[] stack3 = new string[] { "R", "Z", "T", "M" };
        string[] stack4 = new string[] { "D", "T", "C", "H", "S", "P", "V" };
        string[] stack5 = new string[] { "G", "P", "T", "L", "D", "Z" };
        string[] stack6 = new string[] { "F", "B", "R", "Z", "J", "Q", "C", "D" };
        string[] stack7 = new string[] { "S", "B", "D", "J", "M", "F", "T", "R" };
        string[] stack8 = new string[] { "L", "H", "R", "B", "T", "V", "M" };
        string[] stack9 = new string[] { "Q", "P", "D", "S", "V" };

        Stack<string> stackOne = new Stack<string>(stack1);
        Stack<string> stackTwo = new Stack<string>(stack2);
        Stack<string> stackThree = new Stack<string>(stack3);
        Stack<string> stackFour = new Stack<string>(stack4);
        Stack<string> stackFive = new Stack<string>(stack5);
        Stack<string> stackSix = new Stack<string>(stack6);
        Stack<string> stackSeven = new Stack<string>(stack7);
        Stack<string> stackEight = new Stack<string>(stack8);
        Stack<string> stackNine = new Stack<string>(stack9);

        foreach (string s in manual)
        {
            char c = s[6];

            if (c == ' ')
            {
                int amount = Convert.ToInt32(s[5].ToString());
                int origin = Convert.ToInt32(s[12].ToString());
                int destination = Convert.ToInt32(s[17].ToString());

                {
                    if (origin == 1)
                    {
                        if (destination == 2)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackOne.Count > 0)
                                    stackTwo.Push(stackOne.Pop());
                            }
                        }
                        if (destination == 3)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackOne.Count > 0)
                                    stackThree.Push(stackOne.Pop());
                            }
                        }
                        if (destination == 4)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackOne.Count > 0)
                                    stackFour.Push(stackOne.Pop());
                            }
                        }
                        if (destination == 5)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackOne.Count > 0)
                                    stackFive.Push(stackOne.Pop());
                            }
                        }
                        if (destination == 6)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackOne.Count > 0)
                                    stackSix.Push(stackOne.Pop());
                            }
                        }
                        if (destination == 7)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackOne.Count > 0)
                                    stackSeven.Push(stackOne.Pop());
                            }
                        }
                        if (destination == 8)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackOne.Count > 0)
                                    stackEight.Push(stackOne.Pop());
                            }
                        }
                        if (destination == 9)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackOne.Count > 0)
                                    stackNine.Push(stackOne.Pop());
                            }
                        }
                    }

                    //---------------------------------------------------------

                    if (origin == 2)
                    {
                        if (destination == 1)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackTwo.Count > 0)
                                    stackOne.Push(stackTwo.Pop());
                            }
                        }
                        if (destination == 3)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackTwo.Count > 0)
                                    stackThree.Push(stackTwo.Pop());
                            }
                        }
                        if (destination == 4)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackTwo.Count > 0)
                                    stackFour.Push(stackTwo.Pop());
                            }
                        }
                        if (destination == 5)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackTwo.Count > 0)
                                    stackFive.Push(stackTwo.Pop());
                            }
                        }
                        if (destination == 6)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackTwo.Count > 0)
                                    stackSix.Push(stackTwo.Pop());
                            }
                        }
                        if (destination == 7)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackTwo.Count > 0)
                                    stackSeven.Push(stackTwo.Pop());
                            }
                        }
                        if (destination == 8)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackTwo.Count > 0)
                                    stackEight.Push(stackTwo.Pop());
                            }
                        }
                        if (destination == 9)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackTwo.Count > 0)
                                    stackNine.Push(stackTwo.Pop());
                            }
                        }
                    }
                    //---------------------------------------------------------
                    if (origin == 3)
                    {
                        if (destination == 2)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackThree.Count > 0)
                                    stackTwo.Push(stackThree.Pop());
                            }
                        }
                        if (destination == 1)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackThree.Count > 0)
                                    stackOne.Push(stackThree.Pop());
                            }
                        }
                        if (destination == 4)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackThree.Count > 0)
                                    stackFour.Push(stackThree.Pop());
                            }
                        }
                        if (destination == 5)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackThree.Count > 0)
                                    stackFive.Push(stackThree.Pop());
                            }
                        }
                        if (destination == 6)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackThree.Count > 0)
                                    stackSix.Push(stackThree.Pop());
                            }
                        }
                        if (destination == 7)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackThree.Count > 0)
                                    stackSeven.Push(stackThree.Pop());
                            }
                        }
                        if (destination == 8)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackThree.Count > 0)
                                    stackEight.Push(stackThree.Pop());
                            }
                        }
                        if (destination == 9)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackThree.Count > 0)
                                    stackNine.Push(stackThree.Pop());
                            }
                        }
                    }

                    if (origin == 4)
                    {
                        if (destination == 1)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFour.Count > 0)
                                    stackOne.Push(stackFour.Pop());
                            }
                        }
                        if (destination == 2)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFour.Count > 0)
                                    stackTwo.Push(stackFour.Pop());
                            }
                        }
                        if (destination == 3)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFour.Count > 0)
                                    stackThree.Push(stackFour.Pop());
                            }
                        }
                        if (destination == 5)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFour.Count > 0)
                                    stackFive.Push(stackFour.Pop());
                            }
                        }
                        if (destination == 6)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFour.Count > 0)
                                    stackSix.Push(stackFour.Pop());
                            }
                        }
                        if (destination == 7)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFour.Count > 0)
                                    stackSeven.Push(stackFour.Pop());
                            }
                        }
                        if (destination == 8)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFour.Count > 0)
                                    stackEight.Push(stackFour.Pop());
                            }
                        }
                        if (destination == 9)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFour.Count > 0)
                                    stackNine.Push(stackFour.Pop());
                            }
                        }
                    }
                    if (origin == 5)
                    {
                        if (destination == 1)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFive.Count > 0)
                                    stackOne.Push(stackFive.Pop());
                            }
                        }
                        if (destination == 2)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFive.Count > 0)
                                    stackTwo.Push(stackFive.Pop());
                            }
                        }
                        if (destination == 3)
                        {
                            if (stackFive.Count > 0)
                                for (int i = 0; i < amount; i++)
                                {
                                    if (stackFive.Count > 0)
                                        stackThree.Push(stackFive.Pop());
                                }
                        }
                        if (destination == 4)
                        {
                            if (stackFive.Count > 0)
                                for (int i = 0; i < amount; i++)
                                {
                                    if (stackFive.Count > 0)
                                        stackFour.Push(stackFive.Pop());
                                }
                        }
                        if (destination == 6)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFive.Count > 0)
                                    stackSix.Push(stackFive.Pop());
                            }
                        }
                        if (destination == 7)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFive.Count > 0)
                                    stackSeven.Push(stackFive.Pop());
                            }
                        }
                        if (destination == 8)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFive.Count > 0)
                                    stackEight.Push(stackFive.Pop());
                            }
                        }
                        if (destination == 9)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFive.Count > 0)
                                    stackNine.Push(stackFive.Pop());
                            }
                        }
                    }

                    if (origin == 6)
                    {
                        if (destination == 1)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSix.Count > 0)
                                    stackOne.Push(stackSix.Pop());
                            }
                        }
                        if (destination == 2)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSix.Count > 0)
                                    stackTwo.Push(stackSix.Pop());
                            }
                        }
                        if (destination == 3)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSix.Count > 0)
                                    stackThree.Push(stackSix.Pop());
                            }
                        }
                        if (destination == 4)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSix.Count > 0)
                                    stackFour.Push(stackSix.Pop());
                            }
                        }
                        if (destination == 5)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSix.Count > 0)
                                    stackFive.Push(stackSix.Pop());
                            }
                        }
                        if (destination == 7)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                stackSeven.Push(stackSix.Pop());
                            }
                        }
                        if (destination == 8)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSix.Count > 0)
                                    stackEight.Push(stackSix.Pop());
                            }
                        }
                        if (destination == 9)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSix.Count > 0)
                                    stackNine.Push(stackSix.Pop());
                            }
                        }
                    }
                    if (origin == 7)
                    {
                        if (destination == 1)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSeven.Count > 0)
                                    stackOne.Push(stackSeven.Pop());
                            }
                        }
                        if (destination == 2)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSeven.Count > 0)
                                    stackTwo.Push(stackSeven.Pop());
                            }
                        }
                        if (destination == 3)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSeven.Count > 0)
                                    stackThree.Push(stackSeven.Pop());
                            }
                        }
                        if (destination == 4)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSeven.Count > 0)
                                    stackFour.Push(stackSeven.Pop());
                            }
                        }
                        if (destination == 6)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSeven.Count > 0)
                                    stackSix.Push(stackSeven.Pop());
                            }
                        }
                        if (destination == 5)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSeven.Count > 0)
                                    stackFive.Push(stackSeven.Pop());
                            }
                        }
                        if (destination == 8)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSeven.Count > 0)
                                    stackEight.Push(stackSeven.Pop());
                            }
                        }
                        if (destination == 9)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSeven.Count > 0)
                                    stackNine.Push(stackSeven.Pop());
                            }
                        }
                    }

                    if (origin == 8)
                    {
                        if (destination == 1)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackEight.Count > 0)
                                    stackOne.Push(stackEight.Pop());
                            }
                        }
                        if (destination == 2)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackEight.Count > 0)
                                    stackTwo.Push(stackEight.Pop());
                            }
                        }
                        if (destination == 3)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackEight.Count > 0)
                                    stackThree.Push(stackEight.Pop());
                            }
                        }
                        if (destination == 4)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackEight.Count > 0)
                                    stackFour.Push(stackEight.Pop());
                            }
                        }
                        if (destination == 6)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackEight.Count > 0)
                                    stackSix.Push(stackEight.Pop());
                            }
                        }
                        if (destination == 5)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackEight.Count > 0)
                                    stackFive.Push(stackEight.Pop());
                            }
                        }
                        if (destination == 7)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackEight.Count > 0)
                                    stackSeven.Push(stackEight.Pop());
                            }
                        }
                        if (destination == 9)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackEight.Count > 0)
                                    stackNine.Push(stackEight.Pop());
                            }
                        }
                    }
                    if (origin == 9)
                    {
                        if (destination == 1)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackNine.Count > 0)
                                    stackOne.Push(stackNine.Pop());
                            }
                        }
                        if (destination == 2)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackNine.Count > 0)
                                    stackTwo.Push(stackNine.Pop());
                            }
                        }
                        if (destination == 3)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackNine.Count > 0)
                                    stackThree.Push(stackNine.Pop());
                            }
                        }
                        if (destination == 4)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackNine.Count > 0)
                                    stackFour.Push(stackNine.Pop());
                            }
                        }
                        if (destination == 6)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackNine.Count > 0)
                                    stackSix.Push(stackNine.Pop());
                            }
                        }
                        if (destination == 5)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackNine.Count > 0)
                                    stackFive.Push(stackNine.Pop());
                            }
                        }
                        if (destination == 8)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackNine.Count > 0)
                                    stackEight.Push(stackNine.Pop());
                            }
                        }
                        if (destination == 7)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackNine.Count > 0)
                                    stackSeven.Push(stackNine.Pop());
                            }
                        }
                    }
                }
            }
            else if (c != ' ')
            {
                int amount = Convert.ToInt32(s[5].ToString() + s[6].ToString());
                int origin = Convert.ToInt32(s[13].ToString());
                int destination = Convert.ToInt32(s[18].ToString());
                {
                    if (origin == 1)
                    {
                        if (destination == 2)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackOne.Count > 0)
                                    stackTwo.Push(stackOne.Pop());
                            }
                        }
                        if (destination == 3)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackOne.Count > 0)
                                    stackThree.Push(stackOne.Pop());
                            }
                        }
                        if (destination == 4)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackOne.Count > 0)
                                    stackFour.Push(stackOne.Pop());
                            }
                        }
                        if (destination == 5)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackOne.Count > 0)
                                    stackFive.Push(stackOne.Pop());
                            }
                        }
                        if (destination == 6)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackOne.Count > 0)
                                    stackSix.Push(stackOne.Pop());
                            }
                        }
                        if (destination == 7)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackOne.Count > 0)
                                    stackSeven.Push(stackOne.Pop());
                            }
                        }
                        if (destination == 8)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackOne.Count > 0)
                                    stackEight.Push(stackOne.Pop());
                            }
                        }
                        if (destination == 9)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackOne.Count > 0)
                                    stackNine.Push(stackOne.Pop());
                            }
                        }
                    }

                    //---------------------------------------------------------

                    if (origin == 2)
                    {
                        if (destination == 1)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackTwo.Count > 0)
                                    stackOne.Push(stackTwo.Pop());
                            }
                        }
                        if (destination == 3)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackTwo.Count > 0)
                                    stackThree.Push(stackTwo.Pop());
                            }
                        }
                        if (destination == 4)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackTwo.Count > 0)
                                    stackFour.Push(stackTwo.Pop());
                            }
                        }
                        if (destination == 5)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackTwo.Count > 0)
                                    stackFive.Push(stackTwo.Pop());
                            }
                        }
                        if (destination == 6)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackTwo.Count > 0)
                                    stackSix.Push(stackTwo.Pop());
                            }
                        }
                        if (destination == 7)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackTwo.Count > 0)
                                    stackSeven.Push(stackTwo.Pop());
                            }
                        }
                        if (destination == 8)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackTwo.Count > 0)
                                    stackEight.Push(stackTwo.Pop());
                            }
                        }
                        if (destination == 9)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackTwo.Count > 0)
                                    stackNine.Push(stackTwo.Pop());
                            }
                        }
                    }
                    //---------------------------------------------------------
                    if (origin == 3)
                    {
                        if (destination == 2)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackThree.Count > 0)
                                    stackTwo.Push(stackThree.Pop());
                            }
                        }
                        if (destination == 1)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackThree.Count > 0)
                                    stackOne.Push(stackThree.Pop());
                            }
                        }
                        if (destination == 4)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackThree.Count > 0)
                                    stackFour.Push(stackThree.Pop());
                            }
                        }
                        if (destination == 5)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackThree.Count > 0)
                                    stackFive.Push(stackThree.Pop());
                            }
                        }
                        if (destination == 6)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackThree.Count > 0)
                                    stackSix.Push(stackThree.Pop());
                            }
                        }
                        if (destination == 7)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackThree.Count > 0)
                                    stackSeven.Push(stackThree.Pop());
                            }
                        }
                        if (destination == 8)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackThree.Count > 0)
                                    stackEight.Push(stackThree.Pop());
                            }
                        }
                        if (destination == 9)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackThree.Count > 0)
                                    stackNine.Push(stackThree.Pop());
                            }
                        }
                    }

                    if (origin == 4)
                    {
                        if (destination == 1)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFour.Count > 0)
                                    stackOne.Push(stackFour.Pop());
                            }
                        }
                        if (destination == 2)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFour.Count > 0)
                                    stackTwo.Push(stackFour.Pop());
                            }
                        }
                        if (destination == 3)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFour.Count > 0)
                                    stackThree.Push(stackFour.Pop());
                            }
                        }
                        if (destination == 5)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFour.Count > 0)
                                    stackFive.Push(stackFour.Pop());
                            }
                        }
                        if (destination == 6)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFour.Count > 0)
                                    stackSix.Push(stackFour.Pop());
                            }
                        }
                        if (destination == 7)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFour.Count > 0)
                                    stackSeven.Push(stackFour.Pop());
                            }
                        }
                        if (destination == 8)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFour.Count > 0)
                                    stackEight.Push(stackFour.Pop());
                            }
                        }
                        if (destination == 9)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFour.Count > 0)
                                    stackNine.Push(stackFour.Pop());
                            }
                        }
                    }
                    if (origin == 5)
                    {
                        if (destination == 1)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFive.Count > 0)
                                    stackOne.Push(stackFive.Pop());
                            }
                        }
                        if (destination == 2)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFive.Count > 0)
                                    stackTwo.Push(stackFive.Pop());
                            }
                        }
                        if (destination == 3)
                        {
                            if (stackFive.Count > 0)
                                for (int i = 0; i < amount; i++)
                                {
                                    if (stackFive.Count > 0)
                                        stackThree.Push(stackFive.Pop());
                                }
                        }
                        if (destination == 4)
                        {
                            if (stackFive.Count > 0)
                                for (int i = 0; i < amount; i++)
                                {
                                    if (stackFive.Count > 0)
                                        stackFour.Push(stackFive.Pop());
                                }
                        }
                        if (destination == 6)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFive.Count > 0)
                                    stackSix.Push(stackFive.Pop());
                            }
                        }
                        if (destination == 7)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFive.Count > 0)
                                    stackSeven.Push(stackFive.Pop());
                            }
                        }
                        if (destination == 8)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFive.Count > 0)
                                    stackEight.Push(stackFive.Pop());
                            }
                        }
                        if (destination == 9)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackFive.Count > 0)
                                    stackNine.Push(stackFive.Pop());
                            }
                        }
                    }

                    if (origin == 6)
                    {
                        if (destination == 1)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSix.Count > 0)
                                    stackOne.Push(stackSix.Pop());
                            }
                        }
                        if (destination == 2)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSix.Count > 0)
                                    stackTwo.Push(stackSix.Pop());
                            }
                        }
                        if (destination == 3)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSix.Count > 0)
                                    stackThree.Push(stackSix.Pop());
                            }
                        }
                        if (destination == 4)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSix.Count > 0)
                                    stackFour.Push(stackSix.Pop());
                            }
                        }
                        if (destination == 5)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSix.Count > 0)
                                    stackFive.Push(stackSix.Pop());
                            }
                        }
                        if (destination == 7)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                stackSeven.Push(stackSix.Pop());
                            }
                        }
                        if (destination == 8)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSix.Count > 0)
                                    stackEight.Push(stackSix.Pop());
                            }
                        }
                        if (destination == 9)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSix.Count > 0)
                                    stackNine.Push(stackSix.Pop());
                            }
                        }
                    }
                    if (origin == 7)
                    {
                        if (destination == 1)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSeven.Count > 0)
                                    stackOne.Push(stackSeven.Pop());
                            }
                        }
                        if (destination == 2)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSeven.Count > 0)
                                    stackTwo.Push(stackSeven.Pop());
                            }
                        }
                        if (destination == 3)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSeven.Count > 0)
                                    stackThree.Push(stackSeven.Pop());
                            }
                        }
                        if (destination == 4)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSeven.Count > 0)
                                    stackFour.Push(stackSeven.Pop());
                            }
                        }
                        if (destination == 6)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSeven.Count > 0)
                                    stackSix.Push(stackSeven.Pop());
                            }
                        }
                        if (destination == 5)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSeven.Count > 0)
                                    stackFive.Push(stackSeven.Pop());
                            }
                        }
                        if (destination == 8)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSeven.Count > 0)
                                    stackEight.Push(stackSeven.Pop());
                            }
                        }
                        if (destination == 9)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackSeven.Count > 0)
                                    stackNine.Push(stackSeven.Pop());
                            }
                        }
                    }

                    if (origin == 8)
                    {
                        if (destination == 1)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackEight.Count > 0)
                                    stackOne.Push(stackEight.Pop());
                            }
                        }
                        if (destination == 2)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackEight.Count > 0)
                                    stackTwo.Push(stackEight.Pop());
                            }
                        }
                        if (destination == 3)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackEight.Count > 0)
                                    stackThree.Push(stackEight.Pop());
                            }
                        }
                        if (destination == 4)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackEight.Count > 0)
                                    stackFour.Push(stackEight.Pop());
                            }
                        }
                        if (destination == 6)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackEight.Count > 0)
                                    stackSix.Push(stackEight.Pop());
                            }
                        }
                        if (destination == 5)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackEight.Count > 0)
                                    stackFive.Push(stackEight.Pop());
                            }
                        }
                        if (destination == 7)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackEight.Count > 0)
                                    stackSeven.Push(stackEight.Pop());
                            }
                        }
                        if (destination == 9)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackEight.Count > 0)
                                    stackNine.Push(stackEight.Pop());
                            }
                        }
                    }
                    if (origin == 9)
                    {
                        if (destination == 1)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackNine.Count > 0)
                                    stackOne.Push(stackNine.Pop());
                            }
                        }
                        if (destination == 2)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackNine.Count > 0)
                                    stackTwo.Push(stackNine.Pop());
                            }
                        }
                        if (destination == 3)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackNine.Count > 0)
                                    stackThree.Push(stackNine.Pop());
                            }
                        }
                        if (destination == 4)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackNine.Count > 0)
                                    stackFour.Push(stackNine.Pop());
                            }
                        }
                        if (destination == 6)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackNine.Count > 0)
                                    stackSix.Push(stackNine.Pop());
                            }
                        }
                        if (destination == 5)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackNine.Count > 0)
                                    stackFive.Push(stackNine.Pop());
                            }
                        }
                        if (destination == 8)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackNine.Count > 0)
                                    stackEight.Push(stackNine.Pop());
                            }
                        }
                        if (destination == 7)
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                if (stackNine.Count > 0)
                                    stackSeven.Push(stackNine.Pop());
                            }
                        }
                    }
                }
            }
        }

        if (stackOne.Count > 0)
            Console.Write(stackOne.Peek());
        if (stackTwo.Count > 0)
            Console.Write(stackTwo.Peek());
        if (stackThree.Count > 0)
            Console.Write(stackThree.Peek());
        if (stackFour.Count > 0)
            Console.Write(stackFour.Peek());
        if (stackFive.Count > 0)
            Console.Write(stackFive.Peek());
        if (stackSix.Count > 0)
            Console.Write(stackSix.Peek());
        if (stackSeven.Count > 0)
            Console.Write(stackSeven.Peek());
        if (stackEight.Count > 0)
            Console.Write(stackEight.Peek());
        if (stackNine.Count > 0)
            Console.Write(stackNine.Peek());
    }
}
