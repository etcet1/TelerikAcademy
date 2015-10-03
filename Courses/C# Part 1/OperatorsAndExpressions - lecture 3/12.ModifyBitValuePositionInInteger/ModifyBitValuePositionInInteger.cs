using System;

/*We are given integer number n, value v (v=0 or 1) and a position p. 
 *Write a sequence of operators that modifies n to hold the value v 
 *at the position p from the binary representation of n.
 *Example: n = 5 (00000101), p=3, v=1  13 (00001101)
 *n = 5 (00000101), p=2, v=0  1 (00000001)
 */

class ModifyBitValuePositionInInteger
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer:");
        int testInteger = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the desired bit position:");
        int bitPosition = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the desired bit value:");
        int bitValue = int.Parse(Console.ReadLine());
        if (bitValue == 0)
        {
            int mask = ~(1 << bitPosition);
            int result = testInteger & mask;
            Console.WriteLine("Integer = {0} ({1}), bit = {2}, value = {3}\nresult = {4} ({5})", testInteger,  Convert.ToString(testInteger, 2).PadLeft(32, '0'), bitPosition, bitValue, result,  Convert.ToString(result, 2).PadLeft(32, '0') ); 
        }
        else if (bitValue == 1)
        {
            int mask = 1 << bitPosition;       
            int result = testInteger | mask;      
            Console.WriteLine("Integer = {0} ({1}), bit = {2}, value = {3}\nresult = {4} ({5})", testInteger,  Convert.ToString(testInteger, 2).PadLeft(32, '0'), bitPosition, bitValue, result,  Convert.ToString(result, 2).PadLeft(32, '0') ); 
        }
        else if (bitValue > 1 || bitValue < 0)
        {
            Console.WriteLine("The value of bit must be 1 or 0.");
        }else
	    {
            Console.WriteLine("Incorrect input data.");
    	}
    }
}
