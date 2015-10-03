using System;
using System.Collections.Generic;

//Write a method that checks if the element at given position in 
//given array of integers is bigger than its two neighbors (when such exist).

namespace Methods
{
    class ElementBiggerThanNeighbors
    {
        static int BiggerThanNeighbors(int[] arrayNumbers, int positionNumber)
        {
            //check if element position not in the beginning or at the end of the array
            if (positionNumber>0&&positionNumber<arrayNumbers.GetLength(0)-1)
            {
                if (arrayNumbers[positionNumber]>arrayNumbers[positionNumber-1]&&arrayNumbers[positionNumber]>arrayNumbers[positionNumber+1])
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            //element position at the beginning of the array
            else if(positionNumber==0)
            {
                if (arrayNumbers[positionNumber] > arrayNumbers[positionNumber + 1])
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
            //element position at the end of the array
            else if (positionNumber==arrayNumbers.GetLength(0)-1)
            {
                if (arrayNumbers[positionNumber] > arrayNumbers[positionNumber - 1])
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return -1;
            }
        }
        static bool IsValidnumber(string consoleInput)
        {
            var temp = new int();
            if (int.TryParse(consoleInput, out temp))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Restart(int mode)
        {
            if (mode == 0)
            {
                Console.WriteLine("Invalid input detected!");
                Console.WriteLine("Press any key to restart...");
            }
            else if (mode == 1)
            {
                Console.WriteLine("Press any key to restart...");
            }
            Console.ReadKey();
            Console.Clear();
            Main();
        }
        static void Main()
        {
            int arraySize = new int();
            Console.WriteLine("Please enter the length of the array:");
            string input = Console.ReadLine();
            // check of the input data
            if (IsValidnumber(input))
            {
                arraySize = int.Parse(input);
                int[] arrayNumbers = new int[arraySize];
                Console.WriteLine("Please enter the elements of the array:");
                for (int i = 0; i < arraySize; i++)
                {
                    input = Console.ReadLine();
                    if (IsValidnumber(input))
                    {
                        arrayNumbers[i] = int.Parse(input);
                    }
                    else
                    {
                        Restart(0);
                    }
                }
                Console.WriteLine("Please enter the position of the element in the array:");
                input = Console.ReadLine();
                if (IsValidnumber(input))
                {

                        int numberWanted = int.Parse(input);
                        int result=BiggerThanNeighbors(arrayNumbers, numberWanted);
                        switch (result)
                        {
                            case 0:
                                Console.WriteLine("The number is not bigger than its neighbors.");
                                break;
                            case 1:
                                Console.WriteLine("The number is bigger than its neighbors.");
                                break;
                            case 2:
                                Console.WriteLine("The number is at the beginning of the array and it is bigger than its next neighbor.");
                                break;
                            case 3:
                                Console.WriteLine("The number is at the end of the array and it is bigger than its previous neighbor.");
                                break;
                            default:
                                Restart(0);
                                break;
                        }
                        Restart(1);
                }
                else
                {
                    Restart(0);
                }
            }
            else
            {
                Restart(0);
            }
        }
    }
}
