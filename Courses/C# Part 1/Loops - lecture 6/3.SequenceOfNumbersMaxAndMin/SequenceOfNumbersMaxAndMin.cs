using System;

/*Write a program that reads from the console a sequence of 
 * N integer numbers and returns the minimal and maximal of them.
 */


namespace SequenceOfNumbersMaxAndMin
{
    class SequenceOfNumbersMaxAndMin
    {
        static void Main()
        {   
            int sequenceLength = 0;
            Console.WriteLine("Please enter the length of your test sequence");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out sequenceLength))
            {
                Console.WriteLine("Please enter valid number");
            }
            else if (sequenceLength<1)
            {
                Console.WriteLine("This could not be used as sequence");
            }
            else if (sequenceLength==1)
            {
                Console.WriteLine("Please enter number 1:");
                int numberSet = int.Parse(Console.ReadLine());
                Console.WriteLine("At sequence with one member the max value and min value are equal to the number, e.g. min value = {0} and max value = {0}.", numberSet);
            }
            else
            {
                // fill-in an array with the desired numbers 
                int[] numberSet = new int[sequenceLength];
                for (int i = 0; i < sequenceLength; i++)
                {
                    Console.WriteLine("Please enter number {0}:",i+1);
                    numberSet[i] = int.Parse(Console.ReadLine());
                }
                
                //setting the value of the first member of the array as initial value for min and max values
                int maxValue = numberSet[0];
                int minValue = numberSet[0];
                for (int i = 0; i < sequenceLength; i++)
                {
                    if (numberSet[i] > maxValue)
                    {
                        maxValue = numberSet[i];
                    }
                    else if (numberSet[i]<minValue)
                    {
                        minValue = numberSet[i];
                    }
                }
                Console.WriteLine("Max value = {0}. Min value = {1}.", maxValue, minValue);
            }
            Console.WriteLine("Press any key to restart");
            Console.ReadKey(true);
            Console.Clear();
            Main();
        }
    }
}
