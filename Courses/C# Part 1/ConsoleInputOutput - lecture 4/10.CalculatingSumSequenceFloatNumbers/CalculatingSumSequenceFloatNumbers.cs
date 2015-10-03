using System;

/*
 * Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
 */

class CalculatingSumSequenceFloatNumbers
{
    static void Main()
    {
        //using decimal for calculations in order to be sure that the accuracy is 0.001
        //as even if we use double the actual accuracy is 0.00099999999999989
        decimal summary = 1.0M; //intiial value of the sum
        decimal i = 2.0M; //initial value for the iteration, e.g. 1/2 
        while ( 1/i >= (decimal)0.001M)
        {
            if (i % 2 == 0)
            {
                summary = summary + 1 / i;
            }
            else
            {
                summary = summary - 1 / i;
            }
            i++;
        }
        Console.WriteLine("The sum of the sequence 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...(with accuracy of 0.001) is {0:0.0000000000} \n/truncated to 10 numbers after the floating point for better readability/", summary); 

        // Longer solution
        //decimal summary = 1.0M; //intiial value of the sum
        //decimal i = 2.0M; //initial value for the iteration, e.g. 1/2
        //decimal tmpSummary = 0.0M; //temporary variable which holds the previous result needed to calculate the difference 
        //decimal difference = 1.0M; //set to 1 in order to fulfil the initial condition in the "while" statement
        //while (difference > (decimal) 0.001M)
        //{
        //    tmpSummary = summary;
        //    if (i % 2 == 0)
        //    {
        //        summary = summary + 1 / i;
        //    }
        //    else
        //    {
        //        summary = summary - 1 / i;
        //    }
        //    //calculating the difference in absolute value in order to prevent unexepcted exit due
        //    //to negative value and the conditon (difference > (decimal) 0.001M)
        //    difference = Math.Abs(summary - tmpSummary);
        //    i++;
        //}
        //Console.WriteLine("The sum of the sequence 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...(with accuracy of 0.001) is {0:0.0000000000} \n/truncated to 10 numbers after the floating point for better readability/", summary); 
    }
}
