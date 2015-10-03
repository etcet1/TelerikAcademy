namespace InvalidRangeException
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class InvalidRangeExceptionTest
    {
        static void Main()
        {
            ///int test
            try
            {
                int start = 1;
                int end = 100;

                Console.WriteLine("Enter a number between 1 and 100");

                int number = int.Parse(Console.ReadLine());

                if (number < start || number > end)
                {
                    throw new InvalidRangeException<int>(String.Format("Number {3} is out of range[{0} ... {1}]", start, end, number), start, end);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine("{0}\nThe range is: [{1}...{2}]", ex.Message, ex.MinValue, ex.MaxValue);
            }

            ///DateTime test
            try
            {
                DateTime startDate = new DateTime(1980, 1, 1);
                DateTime endDate = new DateTime(2013, 12, 31);

                Console.WriteLine("Enter a date between {0} and {1}", startDate.ToString(), endDate.ToString());

                DateTime date = DateTime.Parse(Console.ReadLine());

                if (date < startDate || date > endDate)
                {
                    throw new InvalidRangeException<DateTime>(String.Format("Number {2} is out of range[{0} ... {1}]", startDate.ToString(), endDate.ToString(), date.ToString()), startDate, endDate);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine("{0}\nThe range is: [{1}...{2}]", ex.ExMessage, ex.MinValue, ex.MaxValue);
            }
        }

    }
}
